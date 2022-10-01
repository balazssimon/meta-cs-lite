using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis.Modeling
{
    [AttributeUsage(AttributeTargets.Interface, AllowMultiple = false, Inherited = true)]
    public class MetaModelAttribute : Attribute
    {
        public bool AutoLookupNamespace { get; set; } = true;
    }

    [AttributeUsage(AttributeTargets.Interface, AllowMultiple = false, Inherited = false)]
    public class MetaClassAttribute : Attribute
    {
        public bool IsAbstract { get; set; }
    }

    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
    public class OppositeAttribute : Attribute
    {
        public OppositeAttribute(Type type, string property)
        {
            Type = type;
            Property = property;
        }

        public Type Type { get; set; }
        public string Property { get; set; }
    }
}
