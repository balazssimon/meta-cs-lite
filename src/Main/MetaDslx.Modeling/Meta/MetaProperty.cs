using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.Modeling.Meta
{
    public abstract class MetaProperty<TType, TProperty, TOperation>
    {
        public MetaProperty(MetaClass<TType, TProperty, TOperation> declaringType, TProperty underlyingProperty)
        {
            DeclaringType = declaringType;
            UnderlyingProperty = underlyingProperty;
        }

        public MetaClass<TType, TProperty, TOperation> DeclaringType { get; }
        public TProperty UnderlyingProperty { get; }

        public abstract string Name { get; }
        public abstract TType OriginalType { get; }
        public abstract ModelPropertyFlags OriginalFlags { get; }
        public abstract bool HasSetter { get; }
        public abstract object? DefaultValue { get; }
        public abstract string? SymbolProperty { get; }
        internal protected abstract IEnumerable<(TType DeclaringType, string PropertyName)> GetRedefinedProperties();
        internal protected abstract IEnumerable<(TType DeclaringType, string PropertyName)> GetSubsettedProperties();
        internal protected abstract IEnumerable<(TType DeclaringType, string PropertyName)> GetOppositeProperties();

        public ModelPropertyFlags Flags { get; internal set; }
        public TType Type { get; internal set; }

        public override string ToString()
        {
            return $"{Name}.{UnderlyingProperty}";
        }
    }
}
