using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.Modeling
{
    public sealed class ModelProperty
    {
        private Type _declaringType;
        private string _name;
        private Type _type;
        private object? _defaultValue;
        private ModelPropertyFlags _flags;
        private string? _symbolProperty;

        public ModelProperty(Type declaringType, string name, Type type, object? defaultValue, ModelPropertyFlags flags, string? symbolProperty = null)
        {
            _declaringType = declaringType;
            _name = name;
            _type = type;
            _defaultValue = defaultValue;
            _flags = flags;
            _symbolProperty = symbolProperty;
        }

        public Type DeclaringType => _declaringType;
        public string Name => _name;
        public string QualifiedName => $"{_declaringType.Name}.{_name}";
        public ModelPropertyFlags Flags => _flags;
        public Type Type => _type;
        public object? DefaultValue => _defaultValue;
        public string? SymbolProperty => _symbolProperty;
        public bool IsDerived => _flags.HasFlag(ModelPropertyFlags.Derived);
        public bool IsDerivedUnion => _flags.HasFlag(ModelPropertyFlags.DerivedUnion);
        public bool IsContainment => _flags.HasFlag(ModelPropertyFlags.Containment);
        public bool IsNonUnique => _flags.HasFlag(ModelPropertyFlags.NonUnique);
        public bool IsCollection => _flags.HasFlag(ModelPropertyFlags.Collection);
        public bool IsSingleItem => _flags.HasFlag(ModelPropertyFlags.SingleItem);
        public bool IsReadOnly => _flags.HasFlag(ModelPropertyFlags.ReadOnly);
        public bool IsModelObject => _flags.HasFlag(ModelPropertyFlags.ModelObjectType);
        public bool IsNullable => _flags.HasFlag(ModelPropertyFlags.NullableType);
        public bool IsName => _flags.HasFlag(ModelPropertyFlags.Name);

        public override string ToString()
        {
            return $"{DeclaringType.Name}.{Name}";
        }
    }
}
