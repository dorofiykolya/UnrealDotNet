﻿using System.Collections.Generic;
using System.Linq;

namespace CodeGenerator.Metadata
{
    public abstract class Type : Primitive
    {
        protected Type()
        {
            TemplateTypes = new List<Variable>();
        }

        public bool IsImplemented { get; set; }
        public bool IsManualImplemented { get; set; }
        public override bool IsTemplate => base.IsTemplate || TemplateTypes.Any();
        public string TemplateBaseName { get; set; }

        public Type NamespaceBaseType { get; set; }
        public Domain Domain { get; set; }

        public List<Variable> TemplateTypes { get; set; }

        public bool IsVoid => Name == "void";

        public string FullName => NamespaceBaseType != null ? NamespaceBaseType.FullName + "." + Name : Name;
    }
}