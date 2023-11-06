using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.Modeling.Meta
{
    public abstract class MetaPropertySlot<TType, TProperty>
    {
        public MetaPropertySlot(MetaProperty<TType, TProperty> slotProperty, ImmutableArray<MetaProperty<TType, TProperty>> slotProperties, object? defaultValue, ModelPropertyFlags flags)
        {
            SlotProperty = slotProperty;
            SlotProperties = slotProperties;
            DefaultValue = defaultValue;
            Flags = flags;
        }

        public MetaProperty<TType, TProperty> SlotProperty { get; }
        public ImmutableArray<MetaProperty<TType, TProperty>> SlotProperties { get; }
        public object? DefaultValue { get; }
        public ModelPropertyFlags Flags { get; }
    }
}
