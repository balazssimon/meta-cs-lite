using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.Modeling.Meta
{
    public abstract class MetaPropertySlot<TType, TProperty, TSymbol>
    {
        public MetaPropertySlot(MetaProperty<TType, TProperty, TSymbol> slotProperty, ImmutableArray<MetaProperty<TType, TProperty, TSymbol>> slotProperties, object? defaultValue, ModelPropertyFlags flags)
        {
            SlotProperty = slotProperty;
            SlotProperties = slotProperties;
            DefaultValue = defaultValue;
            Flags = flags;
        }

        public MetaProperty<TType, TProperty, TSymbol> SlotProperty { get; }
        public ImmutableArray<MetaProperty<TType, TProperty, TSymbol>> SlotProperties { get; }
        public object? DefaultValue { get; }
        public ModelPropertyFlags Flags { get; }
    }
}
