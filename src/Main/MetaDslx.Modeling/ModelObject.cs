﻿using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
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

        protected abstract IModelObjectInfo MInfo { get; }
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        string IModelObject.Id
        {
            get => _id;
            set => _id = value;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        IMetaModel IModelObject.MetaModel => MInfo.MetaModel;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        IModelObject? IModelObject.MetaClass => MInfo.MetaClass;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        Type IModelObject.MetaType => MInfo.MetaType;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        IModelObjectInfo IModelObject.Info => MInfo;

        IModel? IModelObject.Model
        {
            get => _model;
            set
            {
                if (_model != null && value != null) throw new ModelException($"Error changing the model '{_model}' of '{this}' to {value}: to change the model of an object, remove the object from the old model first.'");
                if (_model != null && _model.IsReadOnly) throw new ModelException($"Error changing the model '{_model}' of '{this}' to {value}: the model containing the object is read only.");
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
                    catch (Exception ex)
                    {
                        _model = originalModel;
                        throw new ModelException($"Error setting the model of '{this}' to {value}", ex);
                    }
                }
            }
        }

        IModelObject? IModelObject.Parent => _parent;

        IList<IModelObject> IModelObject.Children => _children;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ImmutableArray<ModelProperty> IModelObject.DeclaredProperties => MInfo.DeclaredProperties;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ImmutableArray<ModelProperty> IModelObject.AllDeclaredProperties => MInfo.AllDeclaredProperties;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ImmutableArray<ModelProperty> IModelObject.PublicProperties => MInfo.PublicProperties;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        IEnumerable<ModelProperty> IModelObject.Properties
        {
            get
            {
                foreach (var prop in MInfo.PublicProperties)
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
                    if (!MInfo.AllDeclaredProperties.Contains(prop))
                    {
                        yield return prop;
                    }
                }
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        string? IModelObject.Name
        {
            get
            {
                var nameProp = MInfo.NameProperty;
                string? name = null;
                if (nameProp != null) name = ((IModelObject)this).Get(nameProp)?.ToString();
                return name;
            }
            set
            {
                var nameProp = MInfo.NameProperty;
                if (nameProp != null) ((IModelObject)this).Add(nameProp, value);
            }
        }
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ModelProperty? IModelObject.NameProperty => MInfo.NameProperty;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ModelProperty? IModelObject.TypeProperty => MInfo.TypeProperty;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        Type? IModelObject.SymbolType => MInfo.SymbolType;

        void IModelObject.Init(ModelProperty property, object? value)
        {
            if (_model != null && _model.IsReadOnly) throw new ModelException($"Error initializing '{property.QualifiedName}' in '{this}' with '{value}': the model '{_model}' is read only.");
            var slot = GetSlot(property);
            _properties[slot.SlotProperty] = value;
        }

        bool IModelObject.IsDefault(ModelProperty property)
        {
            var value = ((IModelObject)this).Get(property);
            if (value is null) return property.DefaultValue is null;
            else return value.Equals(property.DefaultValue);
        }

        public T MGet<T>(ModelProperty property)
        {
            var value = ((IModelObject)this).Get(property);
            if (value is null) return default(T);
            else return (T)value;
            //Convert.ChangeType(value, typeof(T), CultureInfo.InvariantCulture);
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
                        throw new ModelException($"Error getting value of '{property.QualifiedName}' in '{this}': the property must be initialized in the constructor with an IModelCollection implementation using Init().");
                    }
                }
                return value;
            }
            else
            {
                if (slot.Flags.HasFlag(ModelPropertyFlags.Collection))
                {
                    throw new ModelException($"Error getting value of '{property.QualifiedName}' in '{this}': the property must be initialized in the constructor with an IModelCollection implementation using Init().");
                }
                else
                {
                    return null;
                }
            }
        }

        IEnumerable<object> IModelObject.GetValues(ModelProperty property)
        {
            var slot = GetSlot(property);
            if (_properties.TryGetValue(slot.SlotProperty, out var value))
            {
                if (slot.Flags.HasFlag(ModelPropertyFlags.Collection))
                {
                    var collection = value as IModelCollection;
                    if (collection != null)
                    {
                        foreach (var item in collection)
                        {
                            yield return item;
                        }
                    }
                    else
                    {
                        throw new ModelException($"Error getting value of '{property.QualifiedName}' in '{this}': the property must be initialized in the constructor with an IModelCollection implementation using Init().");
                    }
                }
                else
                {
                    yield return value;
                }
            }
            else
            {
                if (slot.Flags.HasFlag(ModelPropertyFlags.Collection))
                {
                    throw new ModelException($"Error getting value of '{property.QualifiedName}' in '{this}': the property must be initialized in the constructor with an IModelCollection implementation using Init().");
                }
                else
                {
                    yield break;
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
            if (_model != null && _model.IsReadOnly) throw new ModelException($"{GetAddMessage(property, item)}: the model '{_model}' is read only.");
            var slot = GetSlot(property);
            if (_model.ValidationOptions.ValidateReadOnly && slot.Flags.HasFlag(ModelPropertyFlags.ReadOnly))
            {
                slot.ThrowModelException(mp => mp.IsReadOnly, mp => $"{GetAddMessage(property, item)}: the property is read only.");
            }
            AddCore(property, item, false);
        }

        internal void AddCore(ModelProperty property, object? item, bool fromOpposite)
        {
            var slot = GetSlot(property);
            if (item is not null)
            {
                slot.ThrowModelException(mp => !mp.Type.IsAssignableFrom(item.GetType()), mp => $"{GetAddMessage(mp, item)}: the item type '{item.GetType()}' is not assignable to the property type '{mp.Type}'.");
            }
            else if (_model.ValidationOptions.ValidateNullable)
            {
                slot.ThrowModelException(mp => mp.IsNullable, mp => $"{GetAddMessage(mp, item)}: value cannot be null.");
            }
            if (_properties.TryGetValue(slot.SlotProperty, out var oldValue))
            {
                if (slot.Flags.HasFlag(ModelPropertyFlags.Collection))
                {
                    if (oldValue is IModelCollection collection)
                    {
                        if (property.Flags.HasFlag(ModelPropertyFlags.Collection))
                        {
                            if (collection is IModelCollectionCore collectionCore)
                            {
                                collectionCore.AddCore(item, fromOpposite);
                            }
                        }
                        else
                        {
                            collection.SingleItem = item;
                        }
                    }
                    else
                    {
                        slot.ThrowModelException(mp => mp.IsCollection, mp => $"{GetAddMessage(mp, item)}: the property must be initialized in the constructor with an IModelCollection implementation using Init().");
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
                            if (oldValue != null) ValueRemoved(slot, oldValue, fromOpposite);
                            _properties[slot.SlotProperty] = item;
                            if (item != null) ValueAdded(slot, item, fromOpposite);
                        }
                        catch (Exception ex)
                        {
                            _properties[slot.SlotProperty] = oldValue;
                            if (_model.ValidationOptions.FullPropertyModificationStackInExceptions) throw new ModelException($"{GetAddMessage(slot.SlotProperty, item)}", ex);
                            else throw;
                        }
                    }
                }
            }
            else if (!slot.Flags.HasFlag(ModelPropertyFlags.Collection))
            {
                try
                {
                    _properties[slot.SlotProperty] = item;
                    if (item != null) ValueAdded(slot, item, fromOpposite);
                }
                catch (Exception ex)
                {
                    _properties.Remove(slot.SlotProperty);
                    if (_model.ValidationOptions.FullPropertyModificationStackInExceptions) throw new ModelException($"{GetAddMessage(slot.SlotProperty, item)}", ex);
                    else throw;
                }
            }
        }

        void IModelObject.Remove(ModelProperty property, object? item)
        {
            if (_model != null && _model.IsReadOnly) throw new ModelException($"{GetRemoveMessage(property, item)}: the model '{_model}' is read only.");
            var slot = GetSlot(property);
            if (_model.ValidationOptions.ValidateReadOnly && slot.Flags.HasFlag(ModelPropertyFlags.ReadOnly))
            {
                slot.ThrowModelException(mp => mp.IsReadOnly, mp => $"{GetRemoveMessage(property, item)}: the property is read only.");
            }
            RemoveCore(property, item, false);
        }

        internal void RemoveCore(ModelProperty property, object? item, bool fromOpposite)
        {
            var slot = GetSlot(property);
            if (_properties.TryGetValue(slot.SlotProperty, out var oldValue))
            {
                if (slot.Flags.HasFlag(ModelPropertyFlags.Collection))
                {
                    if (oldValue is IModelCollectionCore collection)
                    {
                        collection.RemoveCore(item, fromOpposite);
                    }
                    else
                    {
                        slot.ThrowModelException(mp => mp.IsCollection, mp => $"{GetAddMessage(mp, item)}: the property must be initialized in the constructor with an IModelCollection implementation using Init().");
                    }
                }
                else
                {
                    if (oldValue != null && oldValue.Equals(item))
                    {
                        try
                        {
                            _properties[slot.SlotProperty] = null;
                            if (oldValue != null) ValueRemoved(slot, oldValue, fromOpposite);
                        }
                        catch (Exception ex)
                        {
                            _properties[slot.SlotProperty] = oldValue;
                            if (_model.ValidationOptions.FullPropertyModificationStackInExceptions) throw new ModelException($"{GetRemoveMessage(slot.SlotProperty, item)}", ex);
                            else throw;
                        }
                    }
                }
            }
        }

        internal void ValueAdded(ModelPropertySlot slot, object value, bool fromOpposite)
        {
            if (slot.Flags.HasFlag(ModelPropertyFlags.Untracked)) return;
            if (slot.Flags.HasFlag(ModelPropertyFlags.ModelObjectType) && value is IModelObject mobj)
            {
                var mthis = (IModelObject)this;
                if (slot.Flags.HasFlag(ModelPropertyFlags.Containment))
                {
                    var mobjParent = mobj.Parent;
                    if (mobjParent == null) ((ModelObject)mobj)._parent = mthis;
                    else if (!object.ReferenceEquals(mobjParent, this))
                    {
                        throw new ModelException($"Cannot set the container of object '{mobj}' to '{this}': the object is already contained by the parent '{mobjParent}'. Remove the object from the parent first.");
                    }
                    if (!_children.Contains(mobj))
                    {
                        _children.Add(mobj);
                    }
                }
                foreach (var slotProperty in slot.SlotProperties)
                {
                    if (!fromOpposite)
                    {
                        foreach (var oppositeProperty in ((IModelObject)this).GetOppositeProperties(slotProperty))
                        {
                            ((ModelObject)mobj).AddCore(oppositeProperty, this, true);
                        }
                    }
                    foreach (var subsettedProperty in ((IModelObject)this).GetSubsettedProperties(slotProperty))
                    {
                        this.AddCore(subsettedProperty, mobj, fromOpposite);
                    }
                }
            }
        }

        internal void ValueRemoved(ModelPropertySlot slot, object? value, bool fromOpposite)
        {
            if (slot.Flags.HasFlag(ModelPropertyFlags.Untracked)) return;
            if (slot.Flags.HasFlag(ModelPropertyFlags.ModelObjectType) && value is IModelObject mobj)
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
                    if (!fromOpposite)
                    {
                        foreach (var oppositeProperty in ((IModelObject)this).GetOppositeProperties(slotProperty))
                        {
                            ((ModelObject)mobj).RemoveCore(oppositeProperty, this, true);
                        }
                    }
                    foreach (var subsettingProperty in ((IModelObject)this).GetSubsettingProperties(slotProperty))
                    {
                        this.RemoveCore(subsettingProperty, mobj, fromOpposite);
                    }
                }
            }
        }

        public override string ToString()
        {
            var metaTypeName = this.GetType().Name;
            if (metaTypeName.EndsWith("Impl")) metaTypeName = metaTypeName.Substring(0, metaTypeName.Length - 4);
            var nameProp = MInfo.NameProperty;
            string? name = null;
            if (nameProp != null) name = ((IModelObject)this).Get(nameProp)?.ToString();
            var typeProp = MInfo.TypeProperty;
            string? type = null;
            if (typeProp != null) type = ((IModelObject)this).Get(typeProp)?.ToString();
            if (!string.IsNullOrWhiteSpace(name) && !string.IsNullOrWhiteSpace(type)) return $"{name}: {type}";
            else if (!string.IsNullOrWhiteSpace(name)) return $"{name}";
            else if (!string.IsNullOrWhiteSpace(type)) return $":{type}";
            else return $"({metaTypeName})";
        }

        private ModelPropertySlot? GetSlot(ModelProperty property)
        {
            return ((ModelObjectInfo)MInfo).GetSlot(property);
        }

        ModelProperty? IModelObject.GetProperty(string name)
        {
            return MInfo.PublicProperties.FirstOrDefault(p => p.Name == name);
        }

        ImmutableArray<ModelProperty> IModelObject.GetOppositeProperties(ModelProperty property)
        {
            return ((ModelObjectInfo)MInfo).GetOppositeProperties(property);
        }

        ImmutableArray<ModelProperty> IModelObject.GetSubsettedProperties(ModelProperty property)
        {
            return ((ModelObjectInfo)MInfo).GetSubsettedProperties(property);
        }

        ImmutableArray<ModelProperty> IModelObject.GetSubsettingProperties(ModelProperty property)
        {
            return ((ModelObjectInfo)MInfo).GetSubsettingProperties(property);
        }

        ImmutableArray<ModelProperty> IModelObject.GetRedefinedProperties(ModelProperty property)
        {
            return ((ModelObjectInfo)MInfo).GetRedefinedProperties(property);
        }

        ImmutableArray<ModelProperty> IModelObject.GetRedefiningProperties(ModelProperty property)
        {
            return ((ModelObjectInfo)MInfo).GetRedefiningProperties(property);
        }

        private string GetAddMessage(ModelProperty property, object? item)
        {
            if (property.IsSingleItem) return $"Error assigning '{item}' to {property.QualifiedName} in {this}";
            else return $"Error adding '{item}' to {property.QualifiedName} in {this}";
        }

        private string GetRemoveMessage(ModelProperty property, object? item)
        {
            if (property.IsSingleItem) return $"Error assigning '{item}' to {property.QualifiedName} in {this}";
            else return $"Error removing '{item}' from {property.QualifiedName} in {this}";
        }
    }
}