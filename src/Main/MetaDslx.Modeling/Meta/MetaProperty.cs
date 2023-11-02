using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.Modeling.Meta
{
    public abstract class MetaProperty<TType, TProperty>
    {
        public MetaProperty(MetaClass<TType, TProperty> declaringType, TProperty underlyingProperty)
        {
            DeclaringType = declaringType;
            UnderlyingProperty = underlyingProperty;
        }

        public MetaClass<TType, TProperty> DeclaringType { get; }
        internal protected TProperty UnderlyingProperty { get; }

        public abstract string Name { get; }
        internal protected abstract TType OriginalType { get; }
        internal protected abstract ModelPropertyFlags OriginalFlags { get; }
        public abstract bool HasSetter { get; }
        public abstract object? DefaultValue { get; }
        public abstract string? SymbolProperty { get; }
        internal protected abstract IEnumerable<(TType DeclaringType, string PropertyName)> GetRedefinedProperties();
        internal protected abstract IEnumerable<(TType DeclaringType, string PropertyName)> GetSubsettedProperties();
        internal protected abstract IEnumerable<(TType DeclaringType, string PropertyName)> GetOppositeProperties();

        public ModelPropertyFlags Flags { get; internal set; }
        public TType Type { get; internal set; }
    }
}
