using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.Modeling.Meta
{
    public abstract class MetaClass<TType, TProperty>
    {
        public MetaClass(TType? underlyingType)
        {
            UnderlyingType = underlyingType;
        }

        internal protected TType? UnderlyingType { get; }

        public abstract string Name { get; }
        public abstract TType? SymbolType { get; }
        internal protected abstract ImmutableArray<TType> OriginalBaseTypes { get; }
        internal protected abstract ImmutableArray<TProperty> OriginalDeclaredProperties { get; }

        public ImmutableArray<MetaClass<TType, TProperty>> AllBaseTypes { get; internal set; }
        public MetaProperty<TType, TProperty>? NameProperty { get; internal set; }
        public MetaProperty<TType, TProperty>? TypeProperty { get; internal set; }
        public ImmutableArray<MetaProperty<TType, TProperty>> DeclaredProperties { get; internal set; }
        public ImmutableArray<MetaProperty<TType, TProperty>> AllDeclaredProperties { get; internal set; }
        public ImmutableArray<MetaProperty<TType, TProperty>> PublicProperties { get; internal set; }
        public ImmutableDictionary<string, MetaProperty<TType, TProperty>> PublicPropertiesByName { get; internal set; }
        public ImmutableDictionary<MetaProperty<TType, TProperty>, MetaPropertyInfo<TType, TProperty>> ModelPropertyInfos { get; internal set; }
    }
}
