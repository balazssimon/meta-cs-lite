using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

namespace MetaDslx.Modeling.Reflection
{
    public sealed class ReflectionModelObject : ModelObject
    {
        private static readonly ConditionalWeakTable<ReflectionModelObject, Dictionary<ModelProperty, object?>> _attachedProperties = new ConditionalWeakTable<ReflectionModelObject, Dictionary<ModelProperty, object?>>();
        private readonly object _underlyingObject;
        private readonly ReflectionModelClassInfo _info;
        private Dictionary<ModelPropertySlot, ReflectionModelObjectList>? _collections;

        internal ReflectionModelObject(object underlyingObject, ReflectionModelClassInfo info, string? id = null)
            : base(id)
        {
            if (underlyingObject is null) throw new ArgumentNullException(nameof(underlyingObject));
            if (info is null) throw new ArgumentNullException(nameof(info));
            _underlyingObject = underlyingObject;
            _info = info;
        }

        public object UnderlyingObject => _underlyingObject;
        protected override object MUnderlyingObject => UnderlyingObject;

        public override ModelClassInfo MInfo => _info;

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
            var rawValue = ToValue(value);
            if (slot.Flags.HasFlag(ModelPropertyFlags.Collection))
            {
                //value = GetCollection(slot);
            }
            else
            {
                foreach (var prop in slot.SlotProperties)
                {
                    var propInfo = _underlyingObject.GetType().GetProperty(prop.Name, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
                    if (propInfo is not null)
                    {
                        found = true;
                        propInfo.SetValue(_underlyingObject, rawValue);
                    }
                }
            }
            if (!found)
            {
                var attachedProperties = _attachedProperties.GetValue(this, mobj => new Dictionary<ModelProperty, object?>());
                attachedProperties[slot.SlotProperty] = rawValue;
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
                    value = ToModelObject(propInfo.GetValue(_underlyingObject));
                }
                return true;
            }
            else if (_attachedProperties.TryGetValue(this, out var attachedProperties))
            {
                if (attachedProperties.TryGetValue(slot.SlotProperty, out value))
                {
                    value = ToModelObject(value);
                    return true;
                }
            }
            value = null;
            return false;
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

        internal object? ToValue(object? modelObject)
        {
            if (modelObject is IModelObject mobj) return mobj.UnderlyingObject;
            else return modelObject;
        }

        internal object? ToModelObject(object? value)
        {
            return value;
        }
    }
}
