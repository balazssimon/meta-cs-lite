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
        private Dictionary<ModelProperty, object?> _properties;

        public MetaModelObject(string? id = null)
            : base(id)
        {
            _properties = new Dictionary<ModelProperty, object?>();
        }

        protected override object? MUnderlyingObject => this;
        protected override IEnumerable<ModelProperty> StoredPropertiesCore => _properties.Keys;
        
        protected override void SetSlotValueCore(ModelPropertySlot slot, object? value)
        {
            if (value is null && !MInfo.AllDeclaredProperties.Contains(slot.SlotProperty))
            {
                _properties.Remove(slot.SlotProperty);
            }
            else
            {
                _properties[slot.SlotProperty] = value;
            }
        }
        
        protected override bool TryGetSlotValueCore(ModelPropertySlot slot, out object? value)
        {
            return _properties.TryGetValue(slot.SlotProperty, out value);
        }
    }
}
