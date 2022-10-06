using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Reflection;
using System.Text;
using System.Xml.Linq;

namespace MetaDslx.Modeling
{
    public abstract class ModelObject : IModelObject
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string _id;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private IModel? _model;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private IModelObject? _parent;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<IModelObject> _children;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Dictionary<ModelProperty, object?> _properties;

        public ModelObject(string? id = null)
        {
            _id = id ?? Guid.NewGuid().ToString();
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

        string IModelObject.Id
        {
            get => _id;
            set => _id = value;
        }
        
        IModel? IModelObject.Model
        {
            get => _model;
            set
            {
                if (_model != null && value != null) throw new ArgumentException(nameof(value), $"Model object '{this}' is already contained by the model '{_model}. To change the model of an object, remove the object from the old model first.'");
                if (!object.ReferenceEquals(_model, value))
                {
                    var originalModel = _model;
                    try
                    {
                        if (originalModel != null)
                        {
                            _model = null;
                            originalModel.RemoveObject(this);
                        }
                        _model = value;
                        if (_model != null)
                        {
                            _model.AddObject(this);
                        }
                    }
                    catch
                    {
                        _model = originalModel;
                        throw;
                    }
                }
            }
        }

        IModelObject? IModelObject.Parent => _parent;

        IList<IModelObject> IModelObject.Children => _children;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ImmutableArray<ModelProperty> IModelObject.DeclaredProperties => this.MDeclaredProperties;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ImmutableArray<ModelProperty> IModelObject.AllDeclaredProperties => this.MAllDeclaredProperties;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ImmutableArray<ModelProperty> IModelObject.PublicProperties => this.MPublicProperties;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        IEnumerable<ModelProperty> IModelObject.Properties
        {
            get
            {
                foreach (var prop in MPublicProperties)
                {
                    yield return prop;
                }
                foreach (var prop in ((IModelObject)this).AttachedProperties)
                {
                    yield return prop;
                }
            }
        }
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        IEnumerable<ModelProperty> IModelObject.AttachedProperties
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
        ModelProperty? IModelObject.NameProperty => MNameProperty;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ModelProperty? IModelObject.TypeProperty => MTypeProperty;

        void IModelObject.Init(ModelProperty property, object? value)
        {
            //if (value != null && !property.Type.IsAssignableFrom(value.GetType())) throw new ArgumentException($"The type '{value.GetType()}' of '{value}' is not assignable to the type '{property.Type}' of '{property}'.");
            var slot = GetSlot(property);
            _properties[slot.SlotProperty] = value;
        }

        public T MGet<T>(ModelProperty property)
        {
            var value = ((IModelObject)this).Get(property);
            if (value == null) return default(T);
            else return (T)value;
        }

        object? IModelObject.Get(ModelProperty property)
        {
            var slot = GetSlot(property);
            if (_properties.TryGetValue(slot.SlotProperty, out var value))
            {
                if (slot.Flags.HasFlag(ModelPropertyFlags.Collection) && property.Flags.HasFlag(ModelPropertyFlags.SingleItem))
                {
                    var collection = value as IModelCollection;
                    if (collection != null)
                    {
                        return collection.SingleItem;
                    }
                    else
                    {
                        throw new InvalidOperationException($"Collection property '{property.Name}' must be initialized in the constructor with an IModelCollection implementation using MInit().");
                    }
                }
                return value;
            }
            else
            {
                if (slot.Flags.HasFlag(ModelPropertyFlags.Collection))
                {
                    throw new InvalidOperationException($"Collection property '{property.Name}' must be initialized in the constructor with an IModelCollection implementation using MInit().");
                }
                else
                {
                    return null;
                }
            }
        }

        public void MAdd<T>(ModelProperty property, T value)
        {
            ((IModelObject)this).Add(property, value);
        }

        public void MRemove<T>(ModelProperty property, T value)
        {
            ((IModelObject)this).Remove(property, value);
        }

        void IModelObject.Add(ModelProperty property, object? item)
        {
            var slot = GetSlot(property);
            foreach (var slotProperty in slot.SlotProperties)
            {
                if (slotProperty.Flags.HasFlag(ModelPropertyFlags.Readonly)) throw new ArgumentException($"The property '{slotProperty.Name}' is read only.");
                if (slotProperty.Flags.HasFlag(ModelPropertyFlags.NullableType) && item == null) throw new ArgumentException($"Null value cannot be assigned to the property '{slotProperty.Name}'.");
                if (item != null && !slotProperty.Type.IsAssignableFrom(item.GetType())) throw new ArgumentException($"'{item}' of type '{item.GetType()}' is not assignable to the property '{slotProperty.Name}' of type '{slotProperty.Type}'.");
            }
            if (_properties.TryGetValue(slot.SlotProperty, out var oldValue))
            {
                if (slot.Flags.HasFlag(ModelPropertyFlags.Collection))
                {
                    if (oldValue is IModelCollection collection)
                    {
                        if (property.Flags.HasFlag(ModelPropertyFlags.Collection))
                        {
                            collection.Add(item);
                        }
                        else
                        {
                            collection.SingleItem = item;
                        }
                    }
                    else
                    {
                        throw new InvalidOperationException($"Collection property '{property.Name}' must be initialized in the constructor with an IModelCollection implementation using MInit().");
                    }
                }
                else
                {
                    if (oldValue == null && item == null) return;
                    if ((oldValue != null && !oldValue.Equals(item)) || (oldValue == null && item != null))
                    {
                        try
                        {
                            _properties[slot.SlotProperty] = null;
                            if (oldValue != null) ValueRemoved(slot, oldValue);
                            _properties[slot.SlotProperty] = item;
                            if (item != null) ValueAdded(slot, item);
                        }
                        catch
                        {
                            _properties[slot.SlotProperty] = oldValue;
                            throw;
                        }
                    }
                }
            }
            else if (!slot.Flags.HasFlag(ModelPropertyFlags.Collection))
            {
                try
                {
                    _properties[slot.SlotProperty] = item;
                    if (item != null) ValueAdded(slot, item);
                }
                catch
                {
                    _properties.Remove(slot.SlotProperty);
                    throw;
                }
            }
        }

        void IModelObject.Remove(ModelProperty property, object? item)
        {
            if (item == null) throw new ArgumentNullException(nameof(item));
            var slot = GetSlot(property);
            foreach (var slotProperty in slot.SlotProperties)
            {
                if (slotProperty.Flags.HasFlag(ModelPropertyFlags.Readonly)) throw new ArgumentException($"The property '{slotProperty.Name}' is read only.");
                if (slotProperty.Flags.HasFlag(ModelPropertyFlags.NullableType) && item == null) throw new ArgumentException($"Null value cannot be assigned to the property '{slotProperty.Name}'.");
                if (item != null && !slotProperty.Type.IsAssignableFrom(item.GetType())) throw new ArgumentException($"'{item}' of type '{item.GetType()}' is not assignable to the property '{slotProperty.Name}' of type '{slotProperty.Type}'.");
            }
            if (_properties.TryGetValue(slot.SlotProperty, out var oldValue))
            {
                if (slot.Flags.HasFlag(ModelPropertyFlags.Collection))
                {
                    if (oldValue is IModelCollection collection)
                    {
                        collection.Remove(item);
                    }
                    else
                    {
                        throw new InvalidOperationException($"Collection property '{property.Name}' must be initialized in the constructor with an IModelCollection implementation using MInit().");
                    }
                }
                else
                {
                    if (oldValue != null && oldValue.Equals(item))
                    {
                        try
                        {
                            _properties[slot.SlotProperty] = null;
                            if (oldValue != null) ValueRemoved(slot, oldValue);
                        }
                        catch
                        {
                            _properties[slot.SlotProperty] = oldValue;
                            throw;
                        }
                    }
                }
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
                    var mobjParent = mobj.Parent;
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
                        mobj.Add(oppositeProperty, this);
                    }
                    foreach (var subsettedProperty in GetSubsettedProperties(slotProperty))
                    {
                        mthis.Add(subsettedProperty, mobj);
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
                                var collection = mthis.Get(slotProperty) as IModelCollection;
                                if (collection != null)
                                {
                                    stillContained |= collection.Contains(mobj);
                                }
                            }
                            else
                            {
                                stillContained |= object.ReferenceEquals(mthis.Get(slotProperty), mobj);
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
                        mobj.Remove(oppositeProperty, this);
                    }
                    foreach (var subsettingProperty in GetSubsettingProperties(slotProperty))
                    {
                        mthis.Remove(subsettingProperty, mobj);
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
            if (nameProp != null) name = ((IModelObject)this).Get(nameProp)?.ToString();
            var typeProp = MTypeProperty;
            string? type = null;
            if (typeProp != null) type = ((IModelObject)this).Get(typeProp)?.ToString();
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
