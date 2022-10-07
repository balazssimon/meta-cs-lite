using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.Modeling
{
    public class ModelPropertySlot
    {
        private readonly ModelProperty _slotProperty;
        private readonly ImmutableArray<ModelProperty> _slotProperties;
        private readonly object? _defaultValue;
        private readonly ModelPropertyFlags _flags;

        public ModelPropertySlot(ModelProperty slotProperty, ImmutableArray<ModelProperty> slotProperties, object? defaultValue, ModelPropertyFlags flags)
        {
            _slotProperty = slotProperty;
            _slotProperties = slotProperties;
            _defaultValue = defaultValue;
            _flags = flags;
        }

        public ModelProperty SlotProperty => _slotProperty;
        public ImmutableArray<ModelProperty> SlotProperties => _slotProperties;
        public object? DefaultValue => _defaultValue;
        public ModelPropertyFlags Flags => _flags;

    }
}
