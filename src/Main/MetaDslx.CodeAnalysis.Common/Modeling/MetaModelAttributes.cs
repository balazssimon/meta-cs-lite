using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.Modeling
{
    [AttributeUsage(AttributeTargets.Interface, AllowMultiple = false, Inherited = false)]
    public class MetaModelAttribute : Attribute
    {
    }

    [AttributeUsage(AttributeTargets.Interface, AllowMultiple = false, Inherited = false)]
    public class MetaClassAttribute : Attribute
    {
        public bool IsAbstract { get; set; }
    }

    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public class ContainsAttribute : Attribute
    {
    }

    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
    public class OppositeAttribute : Attribute
    {
        public OppositeAttribute(Type type, string property)
        {
            Type = type;
            Property = property;
        }

        public Type Type { get; }
        public string Property { get; }
    }
}
