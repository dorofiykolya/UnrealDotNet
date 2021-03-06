﻿using System.Collections.Generic;
using System.IO;
using System.Linq;
using CodeGenerator.Metadata;

namespace CodeGenerator.CodeGen.Modules
{
    internal class ManageClassGenretorModule : CodeGenretorModule<Class>
    {
        private List<Method> _virtualMethods;

        public ManageClassGenretorModule(Config config) : base(config)
        {
        }

        protected override IEnumerable<Class> GetPrimitives(Domain domain)
        {
            return domain.Classes;
        }

        protected override void SetOutputPath(string outputCppDir, string outputCsDir)
        {
            base.SetOutputPath(outputCppDir, outputCsDir);

            PathOutputCpp = Path.Combine(PathOutputCpp, "Manage");
            PathOutputH = Path.Combine(PathOutputH, "Manage");
            PathOutputCs = Path.Combine(PathOutputCs, "Manage");

            CreateDirectoryIfNotExist(PathOutputCpp);
            CreateDirectoryIfNotExist(PathOutputH);
            CreateDirectoryIfNotExist(PathOutputCs);
        }

        protected override bool CanGenerate(Class Class)
        {
            if (Cfg.Filter.ManageClassBlackList.Contains(Class.Name))
                return false;

            if (Class.IsFinal || Class.IsStructure)
                return false;

            while (Class != null)
            {
                if (Class.Methods.Any(m => m.IsVirtual))
                    return true;

                Class = Class.BaseClass;
            }

            return false;
        }

        protected override void PreGenerate(Class Class)
        {
            _virtualMethods = Class.Methods
                .Where(m => m.IsVirtual &&
                            !m.IsOverride &&
                            !m.IsConst &&
                            m.ReturnType.Type.IsVoid &&
                            m.InputTypes.All(t => !t.IsReadOnly()))
                .ToList();
        }

        #region H

        protected override void GenerateH(Class Class)
        {
            var cw = new CodeWriter();

            cw.WriteLine("#pragma once");
            cw.WriteLine();
            GenerateFileHeader(cw);
            cw.WriteLine("PRAGMA_DISABLE_DEPRECATION_WARNINGS");
            cw.WriteLine();
            cw.WriteLine("#include \"CoreShell.h\"");
            cw.WriteLine("#include \"IManageObject.h\"");
            cw.WriteLine($"#include \"{GetSourceFileName(Class)}\"");
            cw.WriteLine($"#include \"Manage{Class.BaseName}.generated.h\"");
            cw.WriteLine();

            GenerateSourceInfo(cw, Class);

            cw.WriteLine("UCLASS()");
            cw.WriteLine(
                $"class {Cfg.CppApiUe} {Class.Litera}Manage{Class.BaseName} : public {Class.Name}, public IManageObject");
            cw.OpenBlock();

            cw.WriteLine("GENERATED_BODY()");
            cw.WriteLine();
            cw.WriteLine("bool bIsManageAttach = false;");
            cw.WriteLine();
            cw.WriteLine("bool AddWrapperIfNotAttach();");
            cw.WriteLine();

            cw.WriteLineNoTab("public:");
            cw.WriteLine();
            cw.WriteLine("UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = \"C#\")");
            cw.WriteLine("FDotnetTypeName ManageClassName;");
            cw.WriteLine();

            foreach (var method in _virtualMethods.Where(m => m.AccessModifier == AccessModifier.Public))
                GenerateManageMethodHead(cw, method);

            cw.WriteLine();
            cw.WriteLineNoTab("protected:");

            foreach (var method in _virtualMethods.Where(m => m.AccessModifier == AccessModifier.Protected))
                GenerateManageMethodHead(cw, method);

            cw.CloseBlock(";");
            cw.WriteLine();

            cw.WriteLine("PRAGMA_ENABLE_DEPRECATION_WARNINGS");

            cw.SaveToFile(Path.Combine(PathOutputH, "Manage" + Class.BaseName + ".h"));
        }

        #endregion

        #region CS

        protected override void GenerateCs(Class Class)
        {
            var cw = new CodeWriter();

            GenerateFileHeader(cw);
            cw.WriteLine("using System;");
            cw.WriteLine("using System.Runtime.InteropServices;");
            cw.WriteLine();

            GenerateSourceInfo(cw, Class);

            cw.WriteLine("namespace UnrealEngine");
            cw.OpenBlock();

            var manageClassName = "Manage" + Class.BaseName;

            cw.WriteLine($"[ManageType(\"{manageClassName}\")]");
            cw.WriteLine($"public partial class {manageClassName} : {Class.Name}");
            cw.OpenBlock();

            cw.WriteLine($"public {manageClassName}(IntPtr Adress)");
            cw.WriteLine("\t: base(Adress)");
            cw.OpenBlock();
            cw.CloseBlock();
            cw.WriteLine();

            foreach (var method in _virtualMethods)
            {
                GenerateManageMethodCs(cw, method);
            }

            cw.WriteLine($"public static implicit operator IntPtr({manageClassName} self)");
            cw.OpenBlock();
            cw.WriteLine("return self.NativePointer;");
            cw.CloseBlock();
            cw.WriteLine();
            cw.WriteLine($"public static implicit operator {manageClassName}(ObjectPointerDescription PtrDesc)");
            cw.OpenBlock();
            cw.WriteLine($"return NativeManager.GetWrapper<{manageClassName}>(PtrDesc);");
            cw.CloseBlock();

            cw.CloseBlock();
            cw.CloseBlock();

            cw.SaveToFile(Path.Combine(PathOutputCs, manageClassName + ".cs"));
        }

        private void GenerateManageMethodCs(CodeWriter cw, Method method)
        {
            var param = string.Join(", ", method.InputTypes.Select(m => ExportVariable(m, false)));

            GenerateSummaty(cw, method);

            cw.Write(method.AccessModifier.ToString().ToLower() + " ");
            cw.WriteLine($"override {ExportVariable(method.ReturnType)} {method.GetDisplayName()}({param}) {{ }}");
            // cw.WriteLine($"\t=> base.{name}({string.Join(", ", inputs)});"); // todo: доделать виртуальные методы

            cw.WriteLine();
        }

        private string ExportVariable(Variable variable, bool includeDefault = true, bool forExtern = false,
            bool forReturn = false)
        {
            var result = forExtern ? variable.GetTypeCsForExtend(forReturn) : variable.GetTypeCs();

            if (!string.IsNullOrEmpty(variable.Name))
            {
                result += " " + ToLowerCamelCase(variable.GetDisplayName());

                if (includeDefault)
                {
                    var val = ValidateDefaultValue(variable.Default);
                    if (val != null)
                        result += " = " + val;
                }
            }

            return result;
        }

        private string VarNameForCall(Variable variable)
        {
            var name = ToLowerCamelCase(variable.Name);

            if (variable is EnumVariable)
                return $"(byte){name}";

            return name;
        }

        private string ValidateDefaultValue(string value)
        {
            if (bool.TryParse(value, out _))
                return value;

            if (int.TryParse(value, out _))
                return value;

            if (float.TryParse(value, out _))
                return value;

            if (value == "nullptr" || value == "NULL")
                return "null";

            return null;
        }

        #endregion

        #region CPP

        protected override void GenerateCpp(Class Class)
        {
            var cw = new CodeWriter();

            GenerateFileHeader(cw);
            cw.WriteLine($"#include \"{Cfg.CppPch}.h\"");
            cw.WriteLine($"#include \"DotnetTypeName.h\"");
            cw.WriteLine($"#include \"Generate/Manage/Manage{Class.BaseName}.h\"");
            cw.WriteLine();
            cw.WriteLine("PRAGMA_DISABLE_DEPRECATION_WARNINGS");
            cw.WriteLine();

            GenerateSourceInfo(cw, Class);

            cw.WriteLine($"bool {Class.Litera}Manage{Class.BaseName}::AddWrapperIfNotAttach()");
            cw.OpenBlock();
            cw.WriteLine("if (!bIsManageAttach && !ManageClassName.FullName.IsEmpty())");
            cw.OpenBlock();
            cw.WriteLine("auto dotnetTypeName = ManageClassName.PackJSON();");
            cw.WriteLine("auto core = UCoreShell::GetInstance();");
            cw.WriteLine();
            cw.WriteLine(
                "bIsManageAttach = core->InvokeInWrapper<bool, 0>(\"UnrealEngine.NativeManager\", \"AddWrapper\", this, TCHAR_TO_UTF8(*dotnetTypeName));");
            cw.CloseBlock();
            cw.WriteLine();
            cw.WriteLine("return bIsManageAttach;");
            cw.CloseBlock();
            cw.WriteLine();

            _virtualMethods.ForEach(m => GenerateManageMethod(cw, m));

            cw.WriteLine("PRAGMA_ENABLE_DEPRECATION_WARNINGS");

            cw.SaveToFile(Path.Combine(PathOutputCpp, "Manage" + Class.BaseName + ".cpp"));
        }

        private void GenerateManageMethodHead(CodeWriter cw, Method method)
        {
            var param = string.Join(", ", method.InputTypes.Select(v => v.GetTypeCppOgiginal()));

            cw.WriteLine($"virtual {method.ReturnType.GetTypeCppOgiginal()} {method.Name}({param}) override;");
        }

        private void GenerateManageMethod(CodeWriter cw, Method method)
        {
            var param = string.Join(", ", method.InputTypes.Select(v => v.GetTypeCppOgiginal()));
            var call = string.Join(", ", method.InputTypes.Select(v => v.Name));
            var callInObject = string.IsNullOrEmpty(call) ? call : ", " + call;
            var Class = method.OwnerClass;

            cw.WriteLine(
                $"{method.ReturnType.GetTypeCppOgiginal()} {Class.Litera}Manage{Class.BaseName}::{method.Name}({param})");
            cw.OpenBlock();

            if (method.Name == "OnConstruction")
            {
                cw.WriteLine(
                    "auto rootComponent = NewObject<USceneComponent>(this, USceneComponent::GetDefaultSceneRootVariableName(), RF_Transactional);");
                cw.WriteLine("rootComponent->Mobility = EComponentMobility::Movable;");
                cw.WriteLine("rootComponent->bVisualizeComponent = true;");
                cw.WriteLine("rootComponent->SetWorldTransform(Transform);");
                cw.WriteLine("");
                cw.WriteLine("SetRootComponent(rootComponent);");
                cw.WriteLine("AddInstanceComponent(rootComponent);");
                cw.WriteLine("");
                cw.WriteLine("rootComponent->RegisterComponent();");
                cw.WriteLine("");
            }

            cw.WriteLine($"Super::{method.Name}({call});"); // todo: убрать это отсюда и вызывать из управляемого кода

            if (method.ReturnType.Type.Name != "void")
                cw.Write("return ");

            cw.WriteLine("");
            cw.WriteLine("if(AddWrapperIfNotAttach())");
            cw.WriteLine($"\tUCoreShell::GetInstance()->InvokeInObject(this, \"{method.Name}\"{callInObject});");

            cw.CloseBlock();
            cw.WriteLine();
        }

        #endregion
    }
}