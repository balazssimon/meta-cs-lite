using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.Modeling.Meta
{
    public abstract class MetaPropertyInfo<TType, TProperty, TOperation>
    {
        public MetaPropertyInfo(MetaPropertySlot<TType, TProperty, TOperation> slot,
            ImmutableArray<MetaProperty<TType, TProperty, TOperation>> oppositeProperties = default,
            ImmutableArray<MetaProperty<TType, TProperty, TOperation>> subsettedProperties = default,
            ImmutableArray<MetaProperty<TType, TProperty, TOperation>> subsettingProperties = default,
            ImmutableArray<MetaProperty<TType, TProperty, TOperation>> redefinedProperties = default,
            ImmutableArray<MetaProperty<TType, TProperty, TOperation>> redefiningProperties = default,
            ImmutableArray<MetaProperty<TType, TProperty, TOperation>> hiddenProperties = default,
            ImmutableArray<MetaProperty<TType, TProperty, TOperation>> hidingProperties = default)
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

        public MetaPropertySlot<TType, TProperty, TOperation> Slot { get; }
        public ImmutableArray<MetaProperty<TType, TProperty, TOperation>> OppositeProperties { get; }
        public ImmutableArray<MetaProperty<TType, TProperty, TOperation>> SubsettedProperties { get; }
        public ImmutableArray<MetaProperty<TType, TProperty, TOperation>> SubsettingProperties { get; }
        public ImmutableArray<MetaProperty<TType, TProperty, TOperation>> RedefinedProperties { get; }
        public ImmutableArray<MetaProperty<TType, TProperty, TOperation>> RedefiningProperties { get; }
        public ImmutableArray<MetaProperty<TType, TProperty, TOperation>> HiddenProperties { get; }
        public ImmutableArray<MetaProperty<TType, TProperty, TOperation>> HidingProperties { get; }
    }
}
