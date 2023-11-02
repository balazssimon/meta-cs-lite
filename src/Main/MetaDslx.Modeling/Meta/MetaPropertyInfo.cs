using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.Modeling.Meta
{
    public abstract class MetaPropertyInfo<TType, TProperty>
    {
        public MetaPropertyInfo(MetaPropertySlot<TType, TProperty> slot,
            ImmutableArray<MetaProperty<TType, TProperty>> oppositeProperties = default,
            ImmutableArray<MetaProperty<TType, TProperty>> subsettedProperties = default,
            ImmutableArray<MetaProperty<TType, TProperty>> subsettingProperties = default,
            ImmutableArray<MetaProperty<TType, TProperty>> redefinedProperties = default,
            ImmutableArray<MetaProperty<TType, TProperty>> redefiningProperties = default)
        {
            Slot = slot;
            OppositeProperties = oppositeProperties;
            SubsettedProperties = subsettedProperties;
            SubsettingProperties = subsettingProperties;
            RedefinedProperties = redefinedProperties;
            RedefiningProperties = redefiningProperties;
        }

        public MetaPropertySlot<TType, TProperty> Slot { get; }
        public ImmutableArray<MetaProperty<TType, TProperty>> OppositeProperties { get; }
        public ImmutableArray<MetaProperty<TType, TProperty>> SubsettedProperties { get; }
        public ImmutableArray<MetaProperty<TType, TProperty>> SubsettingProperties { get; }
        public ImmutableArray<MetaProperty<TType, TProperty>> RedefinedProperties { get; }
        public ImmutableArray<MetaProperty<TType, TProperty>> RedefiningProperties { get; }
    }
}
