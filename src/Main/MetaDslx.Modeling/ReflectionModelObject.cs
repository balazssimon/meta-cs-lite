using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

namespace MetaDslx.Modeling
{
    public class ReflectionModelObject : ModelObjectBase
    {
        private static readonly ConditionalWeakTable<ReflectionModelObject, Dictionary<ModelProperty, object?>> _attachedProperties = new ConditionalWeakTable<ReflectionModelObject, Dictionary<ModelProperty, object?>>();
        private readonly object _underlyingObject;
        private Dictionary<ModelPropertySlot, ReflectionModelObjectList>? _collections;

        public ReflectionModelObject(object underlyingObject, string? id = null)
            : base(id)
        {
            if (underlyingObject == null) throw new ArgumentNullException(nameof(underlyingObject));
            _underlyingObject = underlyingObject;
        }


        public object UnderlyingObject => _underlyingObject;
        protected override object MUnderlyingObject => UnderlyingObject;

        protected override ModelObjectInfo MInfo => ReflectionMetaModel.GetModelObjectInfo(_underlyingObject.GetType());

        protected override IEnumerable<ModelProperty> StoredPropertiesCore
        {
            get
            {
                foreach (var prop in MInfo.PublicProperties)
                {
                    yield return prop;
                }
                if (_attachedProperties.TryGetValue(this, out var attachedProperties))
                {
                    foreach (var prop in attachedProperties.Keys)
                    {
                        yield return prop;
                    }
                }
            }
        }

        protected override void SetSlotValueCore(ModelPropertySlot slot, object? value)
        {
            var found = false;
            if (slot.Flags.HasFlag(ModelPropertyFlags.Collection))
            {
                value = GetCollection(slot);
            }
            else
            {
                foreach (var prop in slot.SlotProperties)
                {
                    var propInfo = _underlyingObject.GetType().GetProperty(prop.Name, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
                    if (propInfo is not null)
                    {
                        found = true;
                        propInfo.SetValue(_underlyingObject, value);
                    }
                }
            }
            if (!found)
            {
                var attachedProperties = _attachedProperties.GetValue(this, mobj => new Dictionary<ModelProperty, object?>());
                attachedProperties[slot.SlotProperty] = value;
            }
        }

        protected override bool TryGetSlotValueCore(ModelPropertySlot slot, out object? value)
        {
            var propInfo = _underlyingObject.GetType().GetProperty(slot.SlotProperty.Name, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            if (propInfo is not null)
            {
                if (slot.Flags.HasFlag(ModelPropertyFlags.Collection))
                {
                    value = GetCollection(slot);
                }
                else
                {
                    value = propInfo.GetValue(_underlyingObject);
                }
                return true;
            }
            else if (_attachedProperties.TryGetValue(this, out var attachedProperties))
            {
                return attachedProperties.TryGetValue(slot.SlotProperty, out value);
            }
            else
            {
                value = null;
                return false;
            }
        }

        private ReflectionModelObjectList GetCollection(ModelPropertySlot slot)
        {
            if (_collections is null) _collections = new Dictionary<ModelPropertySlot, ReflectionModelObjectList>();
            if (!_collections.TryGetValue(slot, out var collection))
            {
                collection = new ReflectionModelObjectList(this, slot);
                _collections.Add(slot, collection);
            }
            return collection;
        }
    }
}
