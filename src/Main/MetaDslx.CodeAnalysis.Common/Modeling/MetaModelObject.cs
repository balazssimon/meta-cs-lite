using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Linq;

namespace MetaDslx.Modeling
{
    public abstract class MetaModelObject : ModelObject
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Dictionary<ModelProperty, ISlot>? _properties;

        public MetaModelObject(string? id)
            : base(id)
        {
        }

        protected override IEnumerable<ModelProperty> StoredPropertiesCore => (IEnumerable<ModelProperty>?)_properties?.Keys ?? ImmutableArray<ModelProperty>.Empty;

        protected override ISlot? MAttachSlot(ModelPropertySlot propertySlot)
        {
            if (_properties is not null && _properties.TryGetValue(propertySlot.SlotProperty, out var slot)) return slot;
            slot = MCreateSlot(propertySlot);
            if (slot is not null)
            {
                if (_properties is null) _properties = new Dictionary<ModelProperty, ISlot>();
                _properties.Add(propertySlot.SlotProperty, slot);
            }
            return slot;
        }

        protected override ISlot? MGetSlot(ModelPropertySlot propertySlot)
        {
            if (MInfo.AllDeclaredProperties.Contains(propertySlot.SlotProperty)) return MAttachSlot(propertySlot);
            else return null;
        }
    }
}
