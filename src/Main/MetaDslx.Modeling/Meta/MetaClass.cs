using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.Modeling.Meta
{
    public abstract class MetaClass<TType, TProperty, TSymbol>
    {
        public MetaClass(TType underlyingType)
        {
            UnderlyingType = underlyingType;
        }

        public TType UnderlyingType { get; }

        public abstract string Name { get; }
        public abstract TSymbol? SymbolType { get; set; }
        public abstract ImmutableArray<TType> OriginalBaseTypes { get; }
        public abstract ImmutableArray<TProperty> OriginalDeclaredProperties { get; }

        public ImmutableArray<MetaClass<TType, TProperty, TSymbol>> AllBaseTypes { get; internal set; }
        public MetaProperty<TType, TProperty, TSymbol>? NameProperty { get; internal set; }
        public MetaProperty<TType, TProperty, TSymbol>? TypeProperty { get; internal set; }
        public ImmutableArray<MetaProperty<TType, TProperty, TSymbol>> DeclaredProperties { get; internal set; }
        public ImmutableArray<MetaProperty<TType, TProperty, TSymbol>> AllDeclaredProperties { get; internal set; }
        public ImmutableArray<MetaProperty<TType, TProperty, TSymbol>> PublicProperties { get; internal set; }
        public ImmutableArray<MetaPropertySlot<TType, TProperty, TSymbol>> Slots { get; internal set; }
        public ImmutableDictionary<string, MetaProperty<TType, TProperty, TSymbol>> PublicPropertiesByName { get; internal set; }
        public ImmutableDictionary<MetaProperty<TType, TProperty, TSymbol>, MetaPropertyInfo<TType, TProperty, TSymbol>> ModelPropertyInfos { get; internal set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
