using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.CodeAnalysis.Analyzers.Modeling
{
    internal struct MetaSlot
    {
        private readonly MetaProperty _slotProperty;
        private readonly ImmutableArray<MetaProperty> _slotProperties;
        private readonly ModelPropertyFlags _flags;

        public MetaSlot(MetaProperty slotProperty, ImmutableArray<MetaProperty> slotProperties, ModelPropertyFlags flags)
        {
            _slotProperty = slotProperty;
            _slotProperties = slotProperties;
            _flags = flags;
        }

        public MetaProperty SlotProperty => _slotProperty;
        public ImmutableArray<MetaProperty> SlotProperties => _slotProperties;
        public ModelPropertyFlags Flags => _flags;
    }
}
