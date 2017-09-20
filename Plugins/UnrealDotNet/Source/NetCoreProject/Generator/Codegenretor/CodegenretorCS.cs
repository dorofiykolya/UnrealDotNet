﻿using System;
using System.Collections.Generic;
using Generator.Metadata;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using Enum = Generator.Metadata.Enum;

namespace Generator
{
    internal partial class Codegenretor
    {
        private class CS
        {
            public static void GenarateDomain(Domain domain, string OutputDir)
            {
                Directory.GetFiles(OutputDir, "*.cs", SearchOption.AllDirectories).ToList().ForEach(File.Delete);

                foreach (var cl in domain.Classes)
                {
                    var subdir = cl.IsStructure ? "Struct" : "Class";
                    GenerateClass(cl, Path.Combine(OutputDir, subdir, cl.Name));

                    var methods = Filter.GetVirtualMethods(cl);
                    if (methods.Any())
                        GenerateManageClass(cl, Path.Combine(OutputDir, "Manage"));
                }

                GenerateEnums(domain.Enums, Path.Combine(OutputDir, "Enums"));
            }

            private static void GenerateClass(Class Class, string OutputPath)
            {
                var cw = new CoreWriter();
                cw.WriteLine("using System;");
                cw.WriteLine("using System.Runtime.InteropServices;");
                cw.WriteLine();
                cw.WriteLine("namespace UnrealEngine");
                cw.OpenBlock();

                GenerateSummaty(cw, Class, "Класс не может быть наследован в Вашем коде, используйте Manage" + Class.Name.Substring(1));

                var baseClass = Class.BaseClass != null ? Class.BaseClass.Name : (Class.IsStructure ? "NativeStructWrapper" : "NativeWrapper");

                cw.WriteLine($"public {(Class.IsFinal ? "sealed" : "")} partial class {Class.Name} : {baseClass}");
                cw.OpenBlock();

                GenerateClassUtilitesTop(cw, Class, false);

                var cw_DllImport = new CoreWriter(cw);
                var cw_ExternMethods = new CoreWriter(cw);
                var cw_Property = new CoreWriter(cw);

                GenerateClassDLLImport(cw_DllImport, Class);
                Class.Property.ForEach(p => GenerateProperty(cw_Property, Class, p));

                foreach (var method in Class.Methods)
                {
                    GenerateMethodDLLImport(cw_DllImport, Class, method);
                    GenerateMethodBody(cw_ExternMethods, Class, method);
                }
                
                if (!cw_DllImport.IsEmpty())
                {
                    cw.WriteLine("#region DLLInmport");
                    cw.Write(cw_DllImport);
                    cw.WriteLine("#endregion");
                    cw.WriteLine();
                }

                if (!cw_Property.IsEmpty())
                {
                    cw.WriteLine("#region Property");
                    cw.Write(cw_Property);
                    cw.WriteLine("#endregion");
                    cw.WriteLine();
                }

                if (!cw_ExternMethods.IsEmpty())
                {
                    cw.WriteLine("#region ExternMethods");
                    cw.Write(cw_ExternMethods);
                    cw.WriteLine("#endregion");
                    cw.WriteLine();
                }

                GenerateClassUtilitesButtom(cw, Class);

                cw.CloseBlock();
                cw.CloseBlock();

                cw.SaveToFile(OutputPath + ".cs");
            }

            private static void GenerateManageClass(Class Class, string OutputPath)
            {
                var cw = new CoreWriter();
                cw.WriteLine("using System;");
                cw.WriteLine("using System.Runtime.InteropServices;");
                cw.WriteLine();
                cw.WriteLine("namespace UnrealEngine");
                cw.OpenBlock();

                var manageClass = new Class("Manage" + Class.Name.Substring(1));

                GenerateSummaty(cw, Class, "Этот класс может быть наследованн");

                cw.WriteLine($"public partial class {manageClass.Name} : {Class.Name}");
                cw.OpenBlock();

                GenerateClassUtilitesTop(cw, manageClass, true);

                foreach (var method in Filter.GetVirtualMethods(Class))
                {
                    GenerateManageMethod(cw, method);
                }

                GenerateClassUtilitesButtom(cw, manageClass);

                cw.CloseBlock();
                cw.CloseBlock();

                cw.SaveToFile(Path.Combine(OutputPath, manageClass.Name + ".cs"));
            }

            private static void GenerateManageMethod(CoreWriter cw, Method method)
            {
                var param = string.Join(", ", method.InputTypes.Select(m => ExportVariable(m, false)));

                GenerateSummaty(cw, method);

                cw.Write(method.AccessModifier.ToString().ToLower() + " ");
                cw.WriteLine($"override {ExportVariable(method.ReturnType)} {method.GetDisplayName()}({param}) {{ }}");
                // cw.WriteLine($"\t=> base.{name}({string.Join(", ", inputs)});");

                cw.WriteLine();
            }

            private static void GenerateProperty(CoreWriter cw, Class Class, Variable prop)
            {
                if (Class.IsStructure && prop.AccessModifier != AccessModifier.Public)
                    return;

                GenerateSummaty(cw, prop);
                cw.WriteLine($"{prop.AccessModifier.ToString().ToLower()} {ExportVariable(prop, false)}");
                cw.OpenBlock();

                var convGet = prop is EnumVariable ? $"({prop.Type})" : "";
                var convSet = prop is EnumVariable ? $"(byte)" : "";

                cw.WriteLine($"get => {convGet}{ExportPropertyPrefix}{Class.Name}_{prop.Name}_GET(NativePointer);");

                if (!prop.IsReadOnly())
                    cw.WriteLine($"set => {ExportPropertyPrefix}{Class.Name}_{prop.Name}_SET(NativePointer, {convSet}value);");

                cw.CloseBlock();
                cw.WriteLine();
            }

            private static void GenerateClassUtilitesTop(CoreWriter cw, Class Class, bool ForManage)
            {
                if (Class.IsStructure)
                {
                    GenerateStructConstructors(cw, Class);
                }
                else
                {
                    cw.WriteLine($"public {Class.Name}(IntPtr Adress)");
                    cw.WriteLine("\t: base(Adress)");
                    cw.OpenBlock();
                    cw.CloseBlock();
                    cw.WriteLine();

                    if (!ForManage && !Filter.NewObjectBlackList.Contains(Class.Name))
                    {
                        cw.WriteLine($"public {Class.Name}(UObject Parent = null, string Name = \"{Class.Name.Substring(1)}\")");
                        cw.WriteLine("\t: base(IntPtr.Zero)");
                        cw.OpenBlock();
                        cw.WriteLine($"NativePointer = {ExportPrefix}NewObject_{Class.Name}(Parent, Name);");
                        cw.CloseBlock();
                        cw.WriteLine();
                    }
                }
            }

            private static void GenerateClassDLLImport(CoreWriter cw, Class Class)
            {
                if (Class.IsStructure)
                {
                    GenerateStructConstructorsDLLImport(cw, Class);
                }
                else
                {
                    if (!Filter.NewObjectBlackList.Contains(Class.Name))
                    {
                        WriteDLLImport(cw);
                        cw.WriteLine($"private static extern IntPtr {ExportPrefix}NewObject_{Class.Name}(IntPtr Parent, string Name);");
                        cw.WriteLine();
                    }
                }

                GenerateClassPropertyDLLImport(cw, Class);
            }

            private static void GenerateClassPropertyDLLImport(CoreWriter cw, Class Class)
            {
                foreach (var prop in Class.Property.Where(p => !p.IsConst))
                {
                    var baseName = $"{ExportPropertyPrefix}{Class.Name}_{prop.Name}";

                    WriteDLLImport(cw);
                    cw.WriteLine($"private static extern {prop.GetTypeCSForExtend(true)} {baseName}_GET(IntPtr Ptr);");

                    if (!prop.IsReadOnly())
                    {
                        WriteDLLImport(cw);
                        cw.WriteLine(
                            $"private static extern void {baseName}_SET(IntPtr Ptr, {prop.GetTypeCSForExtend()} Value);");
                    }

                    cw.WriteLine();
                }
            }

            private static void GenerateStructConstructors(CoreWriter cw, Class Class)
            {
                cw.WriteLine(
                    $"internal {Class.Name}(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)");
                cw.OpenBlock();
                cw.CloseBlock();
                cw.WriteLine();

                foreach (var ctr in Class.Constructors)
                {
                    var ctrFullName = GetExportConstructorFullName(ctr);
                    var call = string.Join(", ", ctr.InputTypes.Select(VarNameForCall).ToList());
                    var param = string.Join(", ", ctr.InputTypes.Select(m => ExportVariable(m, false)));

                    GenerateSummaty(cw, ctr);

                    cw.WriteLine($"public {Class.Name}({param}) :");
                    cw.WriteLine($"\tbase({ctrFullName}({call}), false)");

                    cw.OpenBlock();
                    cw.CloseBlock();
                    cw.WriteLine();
                }
            }

            private static void GenerateStructConstructorsDLLImport(CoreWriter cw, Class Class)
            {
                foreach (var ctr in Class.Constructors)
                {
                    var param = string.Join(", ", ctr.InputTypes.Select(m => ExportVariable(m, false, true)));

                    var ctrFullName = GetExportConstructorFullName(ctr);

                    WriteDLLImport(cw);
                    cw.WriteLine($"private static extern IntPtr {ctrFullName}({param});");
                    cw.WriteLine();
                }
            }

            private static void GenerateMethodDLLImport(CoreWriter cw, Class Class, Method method)
            {
                var genStringWrap = method.ReturnType.Type == "FText" || method.ReturnType.Type == "FName" ||
                                    method.ReturnType.Type == "FString";

                var inputs = method.InputTypes.Select(m => ExportVariable(m, false, true)).ToList();
                inputs.Insert(0, "IntPtr Self");

                if (genStringWrap)
                    inputs.Add("out int ResultStringLen");

                var param = string.Join(", ", inputs);
                var ret = genStringWrap ? "IntPtr" : ExportVariable(method.ReturnType, false, true, true);

                WriteDLLImport(cw);
                cw.WriteLine(
                    $"private static extern {ret} {GetCPPMethodName(method)}({param});");
                cw.WriteLine();
            }

            private static void GenerateMethodBody(CoreWriter cw, Class Class, Method method)
            {
                var genStringWrap = method.ReturnType.Type == "FText" || method.ReturnType.Type == "FName" ||
                                    method.ReturnType.Type == "FString";

                var inputs = method.InputTypes.Select(VarNameForCall).ToList();

                var genDefault = !method.IsVirtual &&
                                 ValidateDefaultValue(method.InputTypes.LastOrDefault()?.Default) != null;

                var param = string.Join(", ", method.InputTypes.Select(m => ExportVariable(m, genDefault)));

                GenerateSummaty(cw, method);
                cw.Write(method.AccessModifier.ToString().ToLower() + " ");
                cw.Write(method.IsVirtual, "virtual ");

                if (method.Name == "ToString" && !method.InputTypes.Any())
                    cw.Write("override ");

                inputs.Insert(0, "this");
                cw.WriteLine($"{ExportVariable(method.ReturnType)} {method.GetDisplayName()}({param})");

                if (genStringWrap)
                {
                    inputs.Add("out int ResultStringLen");
                    cw.WriteLine(
                        $"\t=> Marshal.PtrToStringUTF8({GetCPPMethodName(method)}({string.Join(", ", inputs)}), ResultStringLen);");
                }
                else
                {
                    cw.Write("\t=> ");

                    if (method.ReturnType is EnumVariable)
                    {
                        cw.Write($"({method.ReturnType.Type})");
                    }

                    cw.WriteLine($"{GetCPPMethodName(method)}({string.Join(", ", inputs)});");
                }

                cw.WriteLine();
            }

            private static void GenerateEnums(IEnumerable<Enum> Enums, string OutputPath)
            {
                var cw = new CoreWriter();
                cw.WriteLine("namespace UnrealEngine");
                cw.OpenBlock();

                Enums.ForEach(en => GenerateEnum(cw, en));

                cw.CloseBlock();

                cw.SaveToFile(OutputPath + ".cs");
            }

            private static void GenerateEnum(CoreWriter cw, Enum Enum)
            {
                GenerateSummaty(cw, Enum);

                cw.WriteLine($"public enum {Enum.Name} : byte");
                cw.OpenBlock();

                foreach (var field in Enum.Fields)
                {
                    GenerateSummaty(cw, field);

                    cw.Write(field.Name);

                    if (!string.IsNullOrEmpty(field.Value))
                    {
                        cw.Write($" = {field.Value}");
                    }

                    cw.WriteLine(",");
                }

                cw.CloseBlock();
                cw.WriteLine();
            }

            private static void GenerateSummaty(CoreWriter cw, Primitive primitive, string Insert = "")
            {
                if (string.IsNullOrEmpty(primitive.Description))
                    return;

                var rows = primitive.Description.Split('\n');

                cw.WriteLine();
                cw.WriteLine("/// <summary>");

                cw.WriteLine(!string.IsNullOrEmpty(Insert), "/// " + Insert);

                foreach (var row in rows)
                {
                    var format = row.Trim(' ', '\t', '*', '/', '\\', '\n', '\r');

                    if (format == "")
                        continue;

                    var match = SummaryParamRegex.Match(format);
                    if (match.Success)
                    {
                        cw.WriteLine($"/// <param name=\"{match.Groups[1]}\">{match.Groups[2]} </param>");
                    }
                    else
                    {
                        match = SummaryReturnRegex.Match(format);
                        if (match.Success)
                        {
                            cw.WriteLine($"/// <return>{match.Groups[1]} </return>");
                        }
                        else
                            cw.WriteLine($"/// <para>{format} </para>");
                    }
                }

                cw.WriteLine("/// </summary>");
            }

            private static void GenerateClassUtilitesButtom(CoreWriter cw, Class Class)
            {
                cw.WriteLine($"public static implicit operator IntPtr({Class.Name} Self)");
                cw.OpenBlock();
                cw.WriteLine("return Self.NativePointer;");
                cw.CloseBlock();
                cw.WriteLine();

                if (Class.IsStructure)
                {
                    cw.WriteLine($"public static implicit operator {Class.Name}(IntPtr Adress)");
                    cw.OpenBlock();
                    cw.WriteLine($"return Adress == IntPtr.Zero ? null : new {Class.Name}(Adress, false);");
                    cw.CloseBlock();
                }
                else
                {
                    cw.WriteLine($"public static implicit operator {Class.Name}(ObjectPointerDescription PtrDesc)");
                    cw.OpenBlock();
                    cw.WriteLine($"return NativeManager.GetWrapper<{Class.Name}>(PtrDesc);");
                    cw.CloseBlock();
                }
            }

            private static void WriteDLLImport(CoreWriter cw)
            {
                cw.WriteLine(
                    "[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]");
            }

            private static string ExportVariable(Variable variable, bool IncludeDefault = true, bool ForExtern = false, bool ForReturn = false)
            {
                var result = ForExtern ? variable.GetTypeCSForExtend(ForReturn) : variable.GetTypeCS();

                if (!string.IsNullOrEmpty(variable.Name))
                {
                    result += " " + variable.GetDisplayName();

                    if (IncludeDefault)
                    {
                        var val = ValidateDefaultValue(variable.Default);
                        if (val != null)
                            result += " = " + val;
                    }
                }

                return result;
            }

            private static string VarNameForCall(Variable variable)
            {
                if (variable is EnumVariable)
                    return $"(byte){variable.Name}";

                return variable.Name;
            }

            private static string ValidateDefaultValue(string value)
            {
                if (bool.TryParse(value, out var _))
                    return value;

                if (int.TryParse(value, out var _))
                    return value;

                if (float.TryParse(value, out var _))
                    return value;

                if (value == "nullptr" || value == "NULL")
                    return "null";

                return null;
            }
        }
    }
}