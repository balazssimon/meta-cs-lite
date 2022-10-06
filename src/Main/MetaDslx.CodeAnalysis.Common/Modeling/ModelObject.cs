using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Text;
using System.Xml.Linq;

namespace MetaDslx.Modeling
{
    public abstract class ModelObject : IModelObject
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private IModel? _model;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private IModelObject? _parent;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<IModelObject> _children;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Dictionary<ModelProperty, object?> _properties;

        public ModelObject()
        {
            _properties = new Dictionary<ModelProperty, object?>();
            _children = new List<IModelObject>();
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected abstract ImmutableArray<ModelProperty> MDeclaredProperties { get; }
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected abstract ImmutableArray<ModelProperty> MAllDeclaredProperties { get; }
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected abstract ImmutableArray<ModelProperty> MPublicProperties { get; }
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected abstract ModelProperty? MNameProperty { get; }
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected abstract ModelProperty? MTypeProperty { get; }
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected abstract Dictionary<ModelProperty, ModelPropertyInfo> MModelPropertyInfos { get; }

        public IModelObject? MParent => _parent;
        public IList<IModelObject> MChildren => _children;
        public IModel? MModel => _model;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ImmutableArray<ModelProperty> IModelObject.MDeclaredProperties => this.MDeclaredProperties;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ImmutableArray<ModelProperty> IModelObject.MAllDeclaredProperties => this.MAllDeclaredProperties;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ImmutableArray<ModelProperty> IModelObject.MPublicProperties => this.MPublicProperties;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        IEnumerable<ModelProperty> IModelObject.MProperties
        {
            get
            {
                foreach (var prop in MPublicProperties)
                {
                    yield return prop;
                }
                foreach (var prop in ((IModelObject)this).MAttachedProperties)
                {
                    yield return prop;
                }
            }
        }
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        IEnumerable<ModelProperty> IModelObject.MAttachedProperties
        {
            get
            {
                foreach (var prop in _properties.Keys)
                {
                    if (!MAllDeclaredProperties.Contains(prop))
                    {
                        yield return prop;
                    }
                }
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ModelProperty? IModelObject.MNameProperty => MNameProperty;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ModelProperty? IModelObject.MTypeProperty => MTypeProperty;

        void IModelObject.MSetModel(IModel? model)
        {
            if (_model != null && model != null) throw new ArgumentException(nameof(model), $"Model object '{this}' is already contained by the model '{_model}.'");
            _model = model;
        }

        void IModelObject.MInit(ModelProperty property, object? value)
        {
            //if (value != null && !property.Type.IsAssignableFrom(value.GetType())) throw new ArgumentException($"The type '{value.GetType()}' of '{value}' is not assignable to the type '{property.Type}' of '{property}'.");
            var slot = GetSlot(property);
            _properties[slot.SlotProperty] = value;
        }

        public T MGet<T>(ModelProperty property)
        {
            var value = ((IModelObject)this).MGet(property);
            if (value == null) return default(T);
            else return (T)value;
        }

        object? IModelObject.MGet(ModelProperty property)
        {
            var slot = GetSlot(property);
            if (_properties.TryGetValue(slot.SlotProperty, out var value)) return value;
            else return null;
        }

        public void MSet<T>(ModelProperty property, T value)
        {
            ((IModelObject)this).MSet(property, value);
        }

        void IModelObject.MSet(ModelProperty property, object? value)
        {
            if (property.IsReadonly) throw new ArgumentException($"Property '{property.Name}' is readonly, its value cannot be set.", nameof(property));
            if (property.IsCollection) throw new ArgumentException($"Property '{property.Name}' is a collection, its value cannot be set.", nameof(property));
            var slot = GetSlot(property);
            if (value != null)
            {
                foreach (var slotProperty in slot.SlotProperties)
                {
                    if (!slotProperty.Type.IsAssignableFrom(value.GetType())) throw new ArgumentException($"The type '{value.GetType()}' of '{value}' is not assignable to the type '{slotProperty.Type}' of '{slotProperty}'.");
                }
            }
            if (_properties.TryGetValue(slot.SlotProperty, out var oldValue))
            {
                if (oldValue == null && value == null) return;
                if (oldValue != null && oldValue.Equals(value)) return;
                try
                {
                    _properties[slot.SlotProperty] = null;
                    if (oldValue != null) ValueRemoved(slot, oldValue);
                    _properties[slot.SlotProperty] = value;
                    if (value != null) ValueAdded(slot, value);
                }
                catch
                {
                    _properties[slot.SlotProperty] = oldValue;
                    throw;
                }
            }
            else
            {
                try
                {
                    _properties[slot.SlotProperty] = value;
                    if (value != null) ValueAdded(slot, value);
                }
                catch
                {
                    _properties[slot.SlotProperty] = null;
                    throw;
                }
            }
        }

        void IModelObject.MAdd(ModelProperty property, object? item)
        {
            if (!property.IsCollection) throw new ArgumentException($"Property '{property.Name}' must be a collection.", nameof(property));
            if (item == null) throw new ArgumentNullException(nameof(item));
            var slot = GetSlot(property);
            foreach (var slotProperty in slot.SlotProperties)
            {
                if (!slotProperty.Type.IsAssignableFrom(item.GetType())) throw new ArgumentException($"The type '{item.GetType()}' of '{item}' is not assignable to the type '{slotProperty.Type}' of '{slotProperty}'.");
            }
            if (!_properties.TryGetValue(slot.SlotProperty, out var collection))
            {
                throw new InvalidOperationException($"Collection property '{property.Name}' must be initialized in the constructor.");
            }
            if (collection is IModelCollection modelCollection)
            {
                modelCollection.MAdd(item);
            }
            else
            {
                throw new InvalidOperationException($"The value of the collection property '{property.Name}' must be initialized with an IModelCollection implementation.");
            }
        }

        void IModelObject.MRemove(ModelProperty property, object? item)
        {
            if (!property.IsCollection) throw new ArgumentException($"Property '{property.Name}' must be a collection.", nameof(property));
            if (item == null) throw new ArgumentNullException(nameof(item));
            var slot = GetSlot(property);
            foreach (var slotProperty in slot.SlotProperties)
            {
                if (!slotProperty.Type.IsAssignableFrom(item.GetType())) throw new ArgumentException($"The type '{item.GetType()}' of '{item}' is not assignable to the type '{slotProperty.Type}' of '{slotProperty}'.");
            }
            if (!_properties.TryGetValue(slot.SlotProperty, out var collection))
            {
                throw new InvalidOperationException($"Collection property '{property.Name}' must be initialized in the constructor.");
            }
            if (collection is IModelCollection modelCollection)
            {
                modelCollection.MRemove(item);
            }
            else
            {
                throw new InvalidOperationException($"The value of the collection property '{property.Name}' must be initialized with an IModelCollection implementation.");
            }
        }

        internal void ValueAdded(ModelPropertySlot slot, object value)
        {
            if (slot.Flags.HasFlag(ModelPropertyFlags.Untracked)) return;
            if (slot.Flags.HasFlag(ModelPropertyFlags.MetaClassType) && value is IModelObject mobj)
            {
                var mthis = (IModelObject)this;
                if (slot.Flags.HasFlag(ModelPropertyFlags.Containment))
                {
                    var mobjParent = mobj.MParent;
                    if (mobjParent == null) ((ModelObject)mobj)._parent = mthis;
                    else if (!object.ReferenceEquals(mobjParent, this))
                    {
                        throw new InvalidOperationException($"The object '{mobj}' is already contained by '{mobjParent}', cannot set its container to '{this}'. Set the parent to 'null' first.");
                    }
                    if (!_children.Contains(mobj))
                    {
                        _children.Add(mobj);
                    }
                }
                foreach (var slotProperty in slot.SlotProperties)
                {
                    foreach (var oppositeProperty in GetOppositeProperties(slotProperty))
                    {
                        if (oppositeProperty.Flags.HasFlag(ModelPropertyFlags.Collection)) mobj.MAdd(oppositeProperty, this);
                        else mobj.MSet(oppositeProperty, this);
                    }
                    foreach (var subsettedProperty in GetSubsettedProperties(slotProperty))
                    {
                        if (subsettedProperty.Flags.HasFlag(ModelPropertyFlags.Collection)) mthis.MAdd(subsettedProperty, mobj);
                        else mthis.MSet(subsettedProperty, mobj);
                    }
                }
            }
        }

        internal void ValueRemoved(ModelPropertySlot slot, object? value)
        {
            if (slot.Flags.HasFlag(ModelPropertyFlags.Untracked)) return;
            if (slot.Flags.HasFlag(ModelPropertyFlags.MetaClassType) && value is IModelObject mobj)
            {
                var mthis = (IModelObject)this;
                if (slot.Flags.HasFlag(ModelPropertyFlags.Containment))
                {
                    var stillContained = false;
                    foreach (var slotProperty in slot.SlotProperties)
                    {
                        if (slotProperty.Flags.HasFlag(ModelPropertyFlags.Containment))
                        {
                            if (slotProperty.Flags.HasFlag(ModelPropertyFlags.Collection))
                            {
                                var collection = mthis.MGet(slotProperty) as IModelCollection;
                                if (collection != null)
                                {
                                    stillContained |= collection.MContains(mobj);
                                }
                            }
                            else
                            {
                                stillContained |= object.ReferenceEquals(mthis.MGet(slotProperty), mobj);
                            }
                        }
                        if (stillContained) break;
                    }
                    if (!stillContained)
                    {
                        _children.Remove(mobj);
                        ((ModelObject)mobj)._parent = null;
                    }
                }
                foreach (var slotProperty in slot.SlotProperties)
                {
                    foreach (var oppositeProperty in GetOppositeProperties(slotProperty))
                    {
                        if (oppositeProperty.Flags.HasFlag(ModelPropertyFlags.Collection)) mobj.MRemove(oppositeProperty, this);
                        else mobj.MSet(oppositeProperty, null);
                    }
                    foreach (var subsettingProperty in GetSubsettingProperties(slotProperty))
                    {
                        if (subsettingProperty.Flags.HasFlag(ModelPropertyFlags.Collection)) mthis.MRemove(subsettingProperty, mobj);
                        else mthis.MSet(subsettingProperty, null);
                    }
                }
            }
        }

        public override string ToString()
        {
            var metaTypeName = this.GetType().Name;
            if (metaTypeName.EndsWith("Impl")) metaTypeName = metaTypeName.Substring(0, metaTypeName.Length - 4);
            var nameProp = MNameProperty;
            string? name = null;
            if (nameProp != null) name = ((IModelObject)this).MGet(nameProp)?.ToString();
            var typeProp = MTypeProperty;
            string? type = null;
            if (typeProp != null) type = ((IModelObject)this).MGet(typeProp)?.ToString();
            if (!string.IsNullOrWhiteSpace(name) && !string.IsNullOrWhiteSpace(type)) return $"{name}: {type}";
            else if (!string.IsNullOrWhiteSpace(name)) return $"{name}";
            else if (!string.IsNullOrWhiteSpace(type)) return $":{type}";
            else return $"({metaTypeName})";
        }

        private ModelPropertySlot? GetSlot(ModelProperty property)
        {
            if (MModelPropertyInfos.TryGetValue(property, out var info)) return info.Slot;
            else return null;
        }

        private ImmutableArray<ModelProperty> GetOppositeProperties(ModelProperty property)
        {
            if (MModelPropertyInfos.TryGetValue(property, out var info)) return info.OppositeProperties;
            else return ImmutableArray<ModelProperty>.Empty;
        }

        private ImmutableArray<ModelProperty> GetSubsettedProperties(ModelProperty property)
        {
            if (MModelPropertyInfos.TryGetValue(property, out var info)) return info.SubsettedProperties;
            else return ImmutableArray<ModelProperty>.Empty;
        }

        private ImmutableArray<ModelProperty> GetSubsettingProperties(ModelProperty property)
        {
            if (MModelPropertyInfos.TryGetValue(property, out var info)) return info.SubsettingProperties;
            else return ImmutableArray<ModelProperty>.Empty;
        }

        private ImmutableArray<ModelProperty> GetRedefinedProperties(ModelProperty property)
        {
            if (MModelPropertyInfos.TryGetValue(property, out var info)) return info.RedefinedProperties;
            else return ImmutableArray<ModelProperty>.Empty;
        }

        private ImmutableArray<ModelProperty> GetRedefiningProperties(ModelProperty property)
        {
            if (MModelPropertyInfos.TryGetValue(property, out var info)) return info.RedefiningProperties;
            else return ImmutableArray<ModelProperty>.Empty;
        }
    }
}
