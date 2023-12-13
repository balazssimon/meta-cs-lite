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

        protected override void SetSlotValueCore(ModelPropertySlot propertySlot, ISlot? slot)
        {
            if (slot is null && !MInfo.AllDeclaredProperties.Contains(propertySlot.SlotProperty))
            {
                _properties?.Remove(propertySlot.SlotProperty);
            }
            else if (slot is not null || _properties is not null && _properties.ContainsKey(propertySlot.SlotProperty))
            {
                if (_properties is null) _properties = new Dictionary<ModelProperty, ISlot>();
                _properties[propertySlot.SlotProperty] = slot;
            }
        }

        protected override bool TryGetSlotValueCore(ModelPropertySlot propertySlot, out ISlot? slot)
        {
            return _properties.TryGetValue(propertySlot.SlotProperty, out slot);
        }
    }
}
