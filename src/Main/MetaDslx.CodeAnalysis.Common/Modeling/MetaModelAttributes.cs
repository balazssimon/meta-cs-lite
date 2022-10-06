using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.Modeling
{
    [AttributeUsage(AttributeTargets.Interface, AllowMultiple = false, Inherited = false)]
    public class MetaModelAttribute : Attribute
    {
        public string Uri { get; set; }
        public string Prefix { get; set; }
        public ushort MajorVersion { get; set; }
        public ushort MinorVersion { get; set; }
    }

    [AttributeUsage(AttributeTargets.Interface, AllowMultiple = false, Inherited = false)]
    public class MetaClassAttribute : Attribute
    {
        private readonly Type? _type;

        public MetaClassAttribute(Type? type = null)
        {
            _type = type;
        }

        public Type? Type => _type;
        public bool IsAbstract { get; set; }
    }

    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public class NameAttribute : Attribute
    {
    }

    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public class TypeAttribute : Attribute
    {
    }

    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public class UntrackedAttribute : Attribute
    {
    }

    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public class NonUniqueAttribute : Attribute
    {
    }

    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public class UnorderedAttribute : Attribute
    {
    }

    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public class ContainmentAttribute : Attribute
    {
    }

    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public class ReadonlyAttribute : Attribute
    {
    }

    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public class DerivedAttribute : Attribute
    {
    }

    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public class DerivedUnionAttribute : Attribute
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

    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
    public class RedefinesAttribute : Attribute
    {
        public RedefinesAttribute(Type type, string property)
        {
            Type = type;
            Property = property;
        }

        public Type Type { get; }
        public string Property { get; }
    }

    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
    public class SubsetsAttribute : Attribute
    {
        public SubsetsAttribute(Type type, string property)
        {
            Type = type;
            Property = property;
        }

        public Type Type { get; }
        public string Property { get; }
    }
}
