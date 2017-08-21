﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Transactions;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using Generator.Metadata;
using static CPP14Parser;

namespace Generator
{
    public class MetadataVisitor : CPP14BaseVisitor<object>
    {
        private readonly Dictionary<string, Class> Classes = new Dictionary<string, Class>();
        private Class CurrentClass;
        private string CurrentFile;
        private bool Ignore;

        public Domain GetDomain() => new Domain { Classes = Classes.Values.ToList() };

        public void Append(TranslationunitContext Translationunit, string file)
        {
            CurrentFile = file;
            Visit(Translationunit);
        }

        private Class GetClass(string name)
        {
            Classes.TryGetValue(name, out Class Class);

            if (Class != null)
                return Class;

            Class = new Class(name);
            Classes.Add(name, Class);

            return Class;
        }

        public override object VisitClassspecifier(ClassspecifierContext context)
        {
            var head = context.GetChild<ClassheadContext>(0);
            var name = head.FindFirst<ClassheadnameContext>().GetText();

            CurrentClass = GetClass(name);

            if (CurrentClass.IsImplemented)
                return null;

            CurrentClass.IsImplemented = true;
            CurrentClass.SourceFile = CurrentFile;

            var baseDec = head.FindFirst<BaseclauseContext>();
            if (baseDec != null)
            {
                var baseName = baseDec.FindFirst<BasetypespecifierContext>().GetText();
                CurrentClass.BaseClass = GetClass(baseName);
            }

            Ignore = true;
            var m = context.FindFirst<MemberspecificationContext>(false);
            if (m != null)
                VisitMemberspecification(m);

            CurrentClass = null;
            return null;
        }

        public override object VisitMemberdeclaration(MemberdeclarationContext context)
        {
            if (Ignore || CurrentClass == null)
                return null;

            var meta = context.FindFirst<UmetaContext>();
            var Parameters = context.FindFirst<ParameterdeclarationclauseContext>();

            if (meta != null)
            {
                VisitMetadata(meta);
            }
            else if (Parameters != null)
            {
                VisitFunction(context);
            }

            return null;
        }

        private void VisitMetadata(UmetaContext context)
        {
            var metadata = context.FindAll<UmetaParametrContext>();
        }

        private void VisitFunction(ParserRuleContext context)
        {
            var name = context.FindFirst<NoptrdeclaratorContext>().FindFirst<TerminalNodeImpl>().GetText();
            var Parameters = context.FindFirst<ParameterdeclarationclauseContext>();
            var metadata = context.FindFirst<UmetaContext>()?.FindAll<UmetaParametrContext>();

            var method = new Method(name)
            {
                ReturnType = ParceVariableForReturn(context),
                InputTypes = Parameters.FindAll<ParameterdeclarationContext>().Reverse()
                    .Select(ParceVariable).ToList()
            };

            CurrentClass.Methods.Add(method);
        }

        private Variable ParceVariable(ParserRuleContext context)
        {
            var declarator = context.FindFirst<DeclaratorContext>();
            var Ptrdeclarator = declarator.FindFirst<PtroperatorContext>();

            var variable = ParceVariableMain(context, Ptrdeclarator);
            variable.Name = declarator.FindFirst<NoptrdeclaratorContext>().FindFirst<TerminalNodeImpl>().GetText();

            return variable;
        }

        private Variable ParceVariableForReturn(ParserRuleContext context)
        {
            var Ptrdeclarator = context.FindFirst<PtrdeclaratorContext>().FindFirst<PtroperatorContext>(false);
            return ParceVariableMain(context, Ptrdeclarator);
        }

        private Variable ParceVariableMain(ParserRuleContext context, ParserRuleContext Ptrdeclarator)
        {
            var declspecRoot = context.FindFirst<DeclspecifierseqContext>();
            var declspec = declspecRoot.FindFirst<DeclspecifierseqContext>() ?? declspecRoot;

            var types = declspec.FindAll<TerminalNodeImpl>().Select(n => n.GetText());
            types = types.Where(s => s != "struct" && s != "class");
            var type = string.Join(' ', types);

            Variable variable;

            if (PrimitiveVariable.PrimitiveTypes.Contains(type))
                variable = new PrimitiveVariable(type);
            else
                variable = new ClassVariable(GetClass(type));

            variable.IsConst = declspecRoot.FindFirst<CvqualifierContext>() != null;

            if (Ptrdeclarator != null)
            {
                variable.IsReference = Ptrdeclarator.GetText() == "&";
                variable.IsPointer = Ptrdeclarator.GetText() == "*";
            }

            return variable;
        }

        public override object VisitAccessspecifier(AccessspecifierContext context)
        {
            Ignore = context.GetText() != "public";
            return null;
        }
    }
}