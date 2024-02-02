using MetaDslx.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.Modeling.Meta
{
    public abstract class MetaPropertySlot<TType, TProperty, TOperation>
    {
        public MetaPropertySlot(MetaProperty<TType, TProperty, TOperation> slotProperty, ImmutableArray<MetaProperty<TType, TProperty, TOperation>> slotProperties, object? defaultValue, ModelPropertyFlags flags, ModelPropertyFlags keyFlags)
        {
            SlotProperty = slotProperty;
            SlotProperties = slotProperties;
            DefaultValue = defaultValue;
            Flags = flags;
            KeyFlags = keyFlags;
        }

        public MetaProperty<TType, TProperty, TOperation> SlotProperty { get; }
        public ImmutableArray<MetaProperty<TType, TProperty, TOperation>> SlotProperties { get; }
        public object? DefaultValue { get; }
        public ModelPropertyFlags Flags { get; }
        public ModelPropertyFlags KeyFlags { get; }
    }
}
