using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.Modeling.Meta
{
    public abstract class MetaPropertyInfo<TType, TProperty, TSymbol>
    {
        public MetaPropertyInfo(MetaPropertySlot<TType, TProperty, TSymbol> slot,
            ImmutableArray<MetaProperty<TType, TProperty, TSymbol>> oppositeProperties = default,
            ImmutableArray<MetaProperty<TType, TProperty, TSymbol>> subsettedProperties = default,
            ImmutableArray<MetaProperty<TType, TProperty, TSymbol>> subsettingProperties = default,
            ImmutableArray<MetaProperty<TType, TProperty, TSymbol>> redefinedProperties = default,
            ImmutableArray<MetaProperty<TType, TProperty, TSymbol>> redefiningProperties = default,
            ImmutableArray<MetaProperty<TType, TProperty, TSymbol>> hiddenProperties = default,
            ImmutableArray<MetaProperty<TType, TProperty, TSymbol>> hidingProperties = default)
        {
            Slot = slot;
            OppositeProperties = oppositeProperties;
            SubsettedProperties = subsettedProperties;
            SubsettingProperties = subsettingProperties;
            RedefinedProperties = redefinedProperties;
            RedefiningProperties = redefiningProperties;
            HiddenProperties = hiddenProperties;
            HidingProperties = hidingProperties;
        }

        public MetaPropertySlot<TType, TProperty, TSymbol> Slot { get; }
        public ImmutableArray<MetaProperty<TType, TProperty, TSymbol>> OppositeProperties { get; }
        public ImmutableArray<MetaProperty<TType, TProperty, TSymbol>> SubsettedProperties { get; }
        public ImmutableArray<MetaProperty<TType, TProperty, TSymbol>> SubsettingProperties { get; }
        public ImmutableArray<MetaProperty<TType, TProperty, TSymbol>> RedefinedProperties { get; }
        public ImmutableArray<MetaProperty<TType, TProperty, TSymbol>> RedefiningProperties { get; }
        public ImmutableArray<MetaProperty<TType, TProperty, TSymbol>> HiddenProperties { get; }
        public ImmutableArray<MetaProperty<TType, TProperty, TSymbol>> HidingProperties { get; }
    }
}
