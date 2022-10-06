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
        private readonly ModelPropertyFlags _flags;

        public ModelPropertySlot(ModelProperty slotProperty, ImmutableArray<ModelProperty> slotProperties, ModelPropertyFlags flags)
        {
            _slotProperty = slotProperty;
            _slotProperties = slotProperties;
            _flags = flags;
        }

        public ModelProperty SlotProperty => _slotProperty;
        public ImmutableArray<ModelProperty> SlotProperties => _slotProperties;
        public ModelPropertyFlags Flags => _flags;

    }
}
