using MetaDslx.CodeAnalysis;
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
        public abstract Location? Location { get; }

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
        public ModelPropertyFlags KeyFlags { get; internal set; }
        public TType KeyType { get; internal set; }

        public bool IsSingle => Flags.HasFlag(ModelPropertyFlags.Single);
        public bool IsCollection => Flags.HasFlag(ModelPropertyFlags.Collection);
        public bool IsMap => Flags.HasFlag(ModelPropertyFlags.Map);
        public bool IsMultiMap => Flags.HasFlag(ModelPropertyFlags.MultiMap);

        public override string ToString()
        {
            return $"{DeclaringType.Name}.{UnderlyingProperty}";
        }
    }
}
