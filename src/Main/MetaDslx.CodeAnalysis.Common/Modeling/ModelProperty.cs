using MetaDslx.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.Modeling
{
    public sealed class ModelProperty
    {
        private MetaType _declaringType;
        private string _name;
        private MetaType _type;
        private MetaSymbol? _defaultValue;
        private ModelPropertyFlags _flags;
        private string? _symbolProperty;

        public ModelProperty(MetaType declaringType, string name, MetaType type, MetaSymbol? defaultValue, ModelPropertyFlags flags, string? symbolProperty = null)
        {
            _declaringType = declaringType;
            _name = name;
            _type = type;
            _defaultValue = defaultValue;
            _flags = flags;
            _symbolProperty = symbolProperty;
            if (symbolProperty == "Name") _flags |= ModelPropertyFlags.Name;
            if (symbolProperty == "Type") _flags |= ModelPropertyFlags.Type;
        }

        public MetaType DeclaringType => _declaringType;
        public string Name => _name;
        public string QualifiedName => $"{_declaringType.Name}.{_name}";
        public ModelPropertyFlags Flags => _flags;
        public MetaType Type => _type;
        public MetaSymbol? DefaultValue => _defaultValue;
        public string? SymbolProperty => _symbolProperty;
        public bool IsDerived => _flags.HasFlag(ModelPropertyFlags.Derived);
        public bool IsDerivedUnion => _flags.HasFlag(ModelPropertyFlags.DerivedUnion);
        public bool IsContainment => _flags.HasFlag(ModelPropertyFlags.Containment);
        public bool IsNonUnique => _flags.HasFlag(ModelPropertyFlags.NonUnique);
        public bool IsCollection => _flags.HasFlag(ModelPropertyFlags.Collection);
        public bool IsMap => _flags.HasFlag(ModelPropertyFlags.Map);
        public bool IsSingleItem => _flags.HasFlag(ModelPropertyFlags.SingleItem);
        public bool IsReadOnly => _flags.HasFlag(ModelPropertyFlags.ReadOnly);
        public bool IsModelObject => _flags.HasFlag(ModelPropertyFlags.ModelObjectType);
        public bool IsNullable => _flags.HasFlag(ModelPropertyFlags.NullableType);
        public bool IsName => _flags.HasFlag(ModelPropertyFlags.Name);
        public bool IsType => _flags.HasFlag(ModelPropertyFlags.Type);

        public override string ToString()
        {
            return $"{DeclaringType.Name}.{Name}";
        }
    }
}
