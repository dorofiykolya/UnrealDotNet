﻿using Generator.Metadata;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using static UHeaderParser;
using Delegate = Generator.Metadata.Delegate;
using Enum = Generator.Metadata.Enum;
using Type = Generator.Metadata.Type;

namespace Generator
{
    public class MetadataVisitor : UHeaderBaseVisitor<object>
    {
        private readonly ConcurrentDictionary<string, Type> _types;
        private Dictionary<string, string> _currentUMeta;
        private AccessModifier _accessModifier;
        private Variable _currentDelegateVariable;
        private Delegate _currentDelegate;
        private Class _currentClass;
        private Enum _currentEnum;
        private string _currentFile;
        private string _currentComment;
        private bool _ignoreOfPragma;
        private bool _ignoreOfAccessModifier;
        private int _preprocessorIfCount;

        private bool Ignore => _ignoreOfPragma || _ignoreOfAccessModifier;

        public MetadataVisitor(ConcurrentDictionary<string, Type> types)
        {
            _types = types;
        }

        public void Append(TranslationUnitContext translationunit, string file)
        {
            _preprocessorIfCount = 0;
            _ignoreOfAccessModifier = false;
            _ignoreOfPragma = false;
            _currentComment = "";
            _currentFile = file;

            _currentDelegateVariable = null;
            _currentDelegate = null;
            _currentClass = null;
            _currentEnum = null;

            Visit(translationunit);
        }

        private Type GetType(TypeContext context)
        {
            var name = context.typeName().GetText();

            if (_types.TryGetValue(name, out var val))
                return val;

            if (name.StartsWith("E"))
            {
                return Get<Enum>(context);
            }
            if (name.EndsWith("Signature"))
            {
                return Get<Delegate>(context);
            }

            return Get<Class>(context);
        }
        
        private T Get<T>(TypeContext context) where T : Type
        {
            var name = context.typeName().GetText();

            if (name.Contains("<"))
            {
                name = context.typeName().Identifier().First().GetText();
                var templateTypes = context.typeName().type();

                name += "__";
                name += string.Join(", ", templateTypes.Select(x => x.typeName().Identifier().First().GetText()));
            }

            if (_types.TryGetValue(name, out var val))
            {
                if (val is T)
                    return (T)val;

                throw new InvalidOperationException($"Элемент уже использован как {val.GetType()}");
            }

            var def = (Type)Activator.CreateInstance(typeof(T), name);
            _types.TryAdd(name, def);

            foreach (var nameContext in context.typeName().type())
            {
                def.TemplateTypes.Add(ParceType(nameContext)); 
            }

            return (T)def;
        }

        public override object VisitClassDeclaration(ClassDeclarationContext context)
        {
            if (_ignoreOfPragma)
                return null;

            var namespaceBaseClass = _currentClass;

            _currentClass = Get<Class>(context.type());

            var isStructReal = context.classOrStruct().GetText() == "struct";

            _currentClass.SourceFile = _currentFile;
            _currentClass.SourceLine = context.Start.Line;
            _currentClass.IsImplemented = true;
            _currentClass.IsTemplate = context.FoundChild<TemplateDefineContext>();
            _currentClass.IsFinal = context.FoundChild<IsFinalContext>();
            _currentClass.UMeta = _currentUMeta ?? _currentClass.UMeta;
            _currentClass.Description = _currentComment;

            switch (_currentClass.Name.First())
            {
                case 'U':
                    _currentClass.IsStructure = false;
                    break;

                case 'F':
                    _currentClass.IsStructure = true;
                    break;

                default:
                    _currentClass.IsStructure = isStructReal;
                    break;
            }

            _accessModifier = isStructReal
                ? AccessModifier.Public
                : AccessModifier.Private;

            _ignoreOfAccessModifier = _accessModifier == AccessModifier.Private;

            var parentClassName = context.Child<ClassParentListContext>()?.type();
            if (parentClassName != null)
            {
                _currentClass.BaseClass = Get<Class>(parentClassName);
            }

            _currentUMeta = null;
            _currentComment = "";

            VisitClassBody(context.Child<ClassBodyContext>());

            _currentClass.NamespaceBaseType = namespaceBaseClass;
            _currentClass = namespaceBaseClass;

            return null;
        }

        public override object VisitEnumDeclaration(EnumDeclarationContext context)
        {
            if (_ignoreOfPragma)
                return null;

            var name = context.type()?.GetText();

            if (string.IsNullOrEmpty(name))
                return null;

            _currentEnum = Get<Enum>(context.type());
            _currentEnum.SourceFile = _currentFile;
            _currentEnum.SourceLine = context.Start.Line;
            _currentEnum.UMeta = _currentUMeta ?? new Dictionary<string, string>();
            _currentEnum.Description = _currentComment;
            _currentEnum.IsImplemented = true;

            _currentUMeta = null;
            _currentComment = "";

            var body = context.enumElementList();

            if (body != null)
                VisitEnumElementList(body);

            _currentEnum = null;
            return null;
        }

        public override object VisitEnumElement(EnumElementContext context)
        {
            _currentEnum?.Fields.Add(new Enum.Field
            {
                Name = context.enumElementName().GetText(),
                Value = context.propertyDefaultValue()?.GetText(),
                UMeta = _currentUMeta ?? new Dictionary<string, string>(),
                Description = _currentComment,
            });

            _currentUMeta = null;
            _currentComment = "";

            return null;
        }

        public override object VisitProperty(PropertyContext context)
        {
            if (Ignore || _currentClass == null)
                return null;

            var variable = ParceType(context.type());
            variable.AccessModifier = _accessModifier;
            variable.Default = context.propertyDefaultValue()?.GetText();
            variable.Description = _currentComment;
            variable.IsStatic = context.FoundChild<IsStaticContext>();
            variable.Name = context.propertyName().GetText();
            variable.UMeta = _currentUMeta ?? variable.UMeta;
            variable.OwnerClass = _currentClass;

            _currentClass.Property.Add(variable);
            _currentUMeta = null;
            _currentComment = "";

            return null;
        }

        public override object VisitMethod(MethodContext context)
        {
            if (Ignore || _currentClass == null)
                return null;

            var method = new Method(context.methodName().GetText())
            {
                IsConst = context.FoundChild<IsConstContext>(),
                IsFinal = context.FoundChild<IsFinalContext>(),
                IsStatic = context.FoundChild<IsStaticContext>(),
                IsFriend = context.FoundChild<IsFriendContext>(),
                IsVirtual = context.FoundChild<IsVirtualContext>(),
                IsOverride = context.FoundChild<IsOverrideContext>(),
                IsTemplate = context.FoundChild<TemplateDefineContext>(),
                UMeta = _currentUMeta ?? new Dictionary<string, string>(),
                AccessModifier = _accessModifier,
                Description = _currentComment,
                OwnerClass = _currentClass,
                Operator = context.methodName().methodOperator()?.GetText(),

                ReturnType = ParceType(context.type()),
                InputTypes = context.FindAll<MethodParametrContext>().Reverse()
                    .Select(ParceParam).ToList()
            };

            if (!_currentClass.Methods.Any(m => m.Equals(method)))
                _currentClass.Methods.Add(method);

            _currentUMeta = null;
            _currentComment = "";
            return null;
        }

        public override object VisitConstructor(ConstructorContext context)
        {
            if (Ignore || _currentClass == null)
                return null;

            if (context.isDestructor() != null)
                return null;

            var name = context.methodName().GetText();

            if (name == _currentClass.Name)
            {
                var method = new Method(context.methodName().GetText())
                {
                    IsConst = context.FoundChild<IsConstContext>(),
                    UMeta = _currentUMeta ?? new Dictionary<string, string>(),
                    Description = _currentComment,
                    OwnerClass = _currentClass,
                    Operator = context.methodName().methodOperator()?.GetText(),
                    AccessModifier = _accessModifier,
                    ReturnType = new ClassVariable(_currentClass),

                    InputTypes = context.FindAll<MethodParametrContext>().Reverse()
                        .Select(ParceParam).ToList()
                };

                if (!_currentClass.Constructors.Any(m => m.Equals(method)))
                    _currentClass.Constructors.Add(method);
            }

            _currentUMeta = null;
            _currentComment = "";
            return null;
        }

        public override object VisitUDefine(UDefineContext context)
        {
            if (_ignoreOfPragma)
                return null;

            var name = context.uDefineName().GetText();

            if (name.StartsWith("DECLARE_DYNAMIC_MULTICAST_DELEGATE"))
            {
                var ls = context.uMeta().uMetaParametrList();

                _currentDelegate = Get<Delegate>(ls.uMetaParametr().uMetaParamKey().type());
                _currentDelegate.SourceFile = _currentFile;
                _currentDelegate.SourceLine = context.Start.Line;
                _currentDelegate.IsImplemented = true;
                _currentDelegate.IsTemplate = context.FoundChild<TemplateDefineContext>();
                _currentDelegate.Description = _currentComment;

                _currentDelegateVariable = null;
                _currentUMeta = new Dictionary<string, string>();

                if (ls.uMetaParametrList() != null)
                    VisitChildren(ls.uMetaParametrList());

                _currentDelegate = null;
                _currentUMeta = null;
                _currentComment = "";
            }

            return base.VisitUDefine(context);
        }

        public override object VisitUMeta(UMetaContext context)
        {
            var ls = context.uMetaParametrList();

            if (ls != null)
            {
                _currentUMeta = new Dictionary<string, string>();
                VisitUMetaParametrList(ls);
            }

            return null;
        }

        public override object VisitUMetaParametr(UMetaParametrContext context)
        {
            var key = context.uMetaParamKey().GetText();
            var value = context.uMetaParamValue()?.GetText();
            var paramList = context.uMetaParametrList();

            if (!_currentUMeta.ContainsKey(key))
            {
                if (_currentDelegate != null)
                {
                    ParceDelegateKey(context);
                }
                else
                    _currentUMeta.Add(key, value != null ? value.Trim('"') : "");
            }
            if (paramList != null)
            {
                VisitUMetaParametrList(paramList);
            }

            return null;
        }

        private void ParceDelegateKey(UMetaParametrContext context)
        {
            if (_currentDelegate == null)
                return;

            if (_currentDelegateVariable == null)
            {
                _currentDelegateVariable = ParceType(context.FindFirst<TypeContext>());
            }
            else
            {
                var key = context.uMetaParamKey().GetText();
                _currentDelegateVariable.Name = key;

                _currentDelegate.Parametrs.Add(_currentDelegateVariable);
                _currentDelegateVariable = null;
            }
        }

        private Variable ParceParam(MethodParametrContext context)
        {
            var variable = ParceType(context.type());
            variable.Name = context.methodParametrName()?.GetText();
            variable.Default = context.methodParametrDefaultValue()?.GetText();

            return variable;
        }

        private Variable ParceType(TypeContext context)
        {
            var typeName = context.typeName().GetText();
            Variable variable;

            if (PrimitiveVariable.PrimitiveTypes.Contains(typeName))
            {
                variable = new PrimitiveVariable(typeName);
            }
            else
            {
                var type = GetType(context);
                if (type is Class)
                {
                    variable = new ClassVariable((Class)type);
                }
                else if (type is Delegate)
                {
                    variable = new DelegateVariable((Delegate)type);
                }
                else if(type is Enum)
                {
                    variable = new EnumVariable((Enum)type);
                }
                else
                {
                    throw new InvalidOperationException();
                }
            }

            variable.IsConst = context.FoundChild<IsConstContext>();
            variable.IsPointer = context.FoundChild<IsPtrQuantContext>();
            variable.IsReference = context.FoundChild<IsRefQuantContext>();

            return variable;
        }

        public override object VisitPreprocessDerective(PreprocessDerectiveContext context)
        {
            var text = context.GetText();
            if (text.StartsWith("#if "))
            {
                if (text.StartsWith("#if WITH_EDITOR"))
                {
                    _ignoreOfPragma = true;
                }

                if (_ignoreOfPragma)
                    _preprocessorIfCount++;
            }
            else if (text.StartsWith("#endif") && _ignoreOfPragma)
            {
                _preprocessorIfCount--;
                if (_preprocessorIfCount == 0)
                {
                    _ignoreOfPragma = false;
                }
            }

            return base.VisitPreprocessDerective(context);
        }

        public override object VisitAccessSpecifier(AccessSpecifierContext context)
        {
            System.Enum.TryParse(typeof(AccessModifier), context.GetText(), true, out var result);
            _accessModifier = (AccessModifier)result;

            _ignoreOfAccessModifier = _accessModifier == AccessModifier.Private;

            return null;
        }

        public override object VisitComment(CommentContext context)
        {
            if (_currentClass != null || _currentEnum != null)
                _currentComment = context.GetText();

            return null;
        }
    }
}