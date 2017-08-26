﻿using Generator.Metadata;
using System.IO;
using System.Linq;

namespace Generator
{
    internal partial class Codegenretor
    {
        private class CS
        {
            public static void GenarateDomain(Domain domain, string OutputDir)
            {
                var Classes = domain.Classes.Where(DefaultClassFilter);

                Directory.GetFiles(OutputDir, "*.cs").ToList().ForEach(File.Delete);

                foreach (var cl in Classes)
                {
                    GenerateClass(cl, Path.Combine(OutputDir, cl.Name));
                }
            }

            private static void GenerateClass(Class Class, string OutputPath)
            {
                var cw = new CoreWriter();
                cw.WriteLine("using System;");
                cw.WriteLine("using System.Runtime.InteropServices;");
                cw.WriteLine();
                cw.WriteLine("namespace UnrealEngine");
                cw.OpenBlock();

                GenerateSummaty(cw, Class.Description);

                cw.Write(Class.IsStructure
                    ? $"public partial struct {Class.Name}"
                    : $"public partial class {Class.Name}");

                if (Class.BaseClass != null)
                    cw.Write($" : {Class.BaseClass.Name}");

                cw.WriteLine();
                cw.OpenBlock();

                GenerateClassUtilitesTop(cw, Class);

                var methods = Class.Methods.Where(DefaultMethodFilter);
                methods = methods.Where(m => m.Operator == null);

                var cw_DllImport = new CoreWriter(cw);
                var cw_ExternMethods = new CoreWriter(cw);

                foreach (var method in methods)
                {
                    GenerateMethodDLLImport(cw_DllImport, Class, method);
                    GenerateMethodBody(cw_ExternMethods, Class, method);
                }

                if (Class.IsStructure)
                {
                    foreach (var prop in Class.Property.Where(DefaultPropertyFilter))
                    {
                        GenerateSummaty(cw, prop.Description);
                        cw.WriteLine($"public {ExportVariable(prop)} {{ get; set; }}");
                    }
                    cw.WriteLine();
                }

                cw.WriteLine("#region DLLInmport");
                cw.Write(cw_DllImport);
                cw.WriteLine("#endregion");
                cw.WriteLine();

                cw.WriteLine("#region ExternMethods");
                cw.Write(cw_ExternMethods);
                cw.WriteLine("#endregion");
                cw.WriteLine();

                GenerateClassUtilitesButtom(cw, Class);

                cw.CloseBlock();
                cw.CloseBlock();

                cw.SaveToFile(OutputPath + ".cs");
            }

            private static void GenerateClassUtilitesTop(CoreWriter cw, Class Class)
            {
                if (Class.IsStructure)
                {
                }
                else
                {
                    if (Class.BaseClass == null)
                    {
                        cw.WriteLine("protected readonly IntPtr NativePointer;");
                        cw.WriteLine();
                        cw.WriteLine($"public {Class.Name}(IntPtr Adress)");
                        cw.OpenBlock();
                        cw.WriteLine("NativePointer = Adress;");
                        cw.CloseBlock();
                    }
                    else
                    {
                        cw.WriteLine($"public {Class.Name}(IntPtr Adress)");
                        cw.WriteLine("\t: base(Adress)");
                        cw.OpenBlock();
                        cw.CloseBlock();
                    }
                }
                cw.WriteLine();
            }

            private static void GenerateClassUtilitesButtom(CoreWriter cw, Class Class)
            {
                if (Class.IsStructure)
                {
                }
                else
                {
                    cw.WriteLine($"public static explicit operator IntPtr({Class.Name} Self)");
                    cw.OpenBlock();
                    cw.WriteLine("return Self.NativePointer;");
                    cw.CloseBlock();
                    cw.WriteLine();

                    cw.WriteLine($"public static implicit operator {Class.Name}(IntPtr Adress)");
                    cw.OpenBlock();
                    cw.WriteLine($"return Adress == IntPtr.Zero ? null : new {Class.Name}(Adress);");
                    cw.CloseBlock();
                }
            }

            private static void GenerateMethodDLLImport(CoreWriter cw, Class Class, Method method)
            {
                var inputs = method.InputTypes.Select(ExportVariable).ToList();
                inputs.Insert(0, (Class.IsStructure ? Class.Name : "IntPtr") + " Self");

                var param = string.Join(", ", inputs);

                cw.WriteLine("#if PACING");
                cw.WriteLine($"[DllImport(\"{DllPaksImportName}\")]");
                cw.WriteLine("#else");
                cw.WriteLine($"[DllImport(\"{DllEditorImportName}\")]");
                cw.WriteLine("#endif");
                cw.WriteLine(
                    $"private static extern {ExportVariable(method.ReturnType)} {GetCPPMethodName(method)}({param});");
                cw.WriteLine();
            }

            private static void GenerateMethodBody(CoreWriter cw, Class Class, Method method)
            {
                var inputs = method.InputTypes.Select(t => t.Name).ToList();
                inputs.Insert(0, Class.IsStructure ? "this" : "NativePointer");

                var param = string.Join(", ", method.InputTypes.Select(ExportVariable));
                var call = string.Join(", ", inputs);

                var name = method.UMeta.ContainsKey("DisplayName") ? method.UMeta["DisplayName"] : method.Name;

                GenerateSummaty(cw, method.Description);

                cw.WriteLine(
                    $"public {ExportVariable(method.ReturnType)} {name}({param})");

                cw.OpenBlock();

                cw.Write(!method.ReturnType.IsVoid, "return ");
                cw.WriteLine($"{GetCPPMethodName(method)}({call});");

                cw.CloseBlock();
                cw.WriteLine();
            }

            private static void GenerateSummaty(CoreWriter cw, string Description)
            {
                if (string.IsNullOrEmpty(Description))
                    return;

                var rows = Description.Split('\n');

                cw.WriteLine();
                cw.WriteLine("/// <summary>");

                foreach (var row in rows)
                {
                    cw.WriteLine("/// " + row.Trim(' ', '\t', '*', '/', '\\'));
                }

                cw.WriteLine("/// </summary>");
            }

            private static string ExportVariable(Variable variable)
            {
                var result = variable.GetTypeCS();

                if (!string.IsNullOrEmpty(variable.Name))
                {
                    var name = variable.UMeta.ContainsKey("DisplayName") ? variable.UMeta["DisplayName"] : variable.Name;
                    result += " " + variable.Name;

                    if (ValidateDefaultValue(variable.Default))
                        result += " = " + variable.Default;
                }

                return result;
            }

            private static bool ValidateDefaultValue(string value)
            {
                if (bool.TryParse(value, out var _r1))
                    return true;

                if (int.TryParse(value, out var _r3))
                    return true;

                if (float.TryParse(value, out var _r2))
                    return true;

                return false;
            }
        }
    }
}