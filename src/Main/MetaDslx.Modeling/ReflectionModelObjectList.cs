using Autofac.Features.Indexed;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Reflection;
using System.Text;

namespace MetaDslx.Modeling
{
    internal class ReflectionModelObjectList : IModelCollection, IModelCollectionCore
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ReflectionModelObject _owner;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ModelPropertySlot _slot;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private PropertyInfo _property;

        public ReflectionModelObjectList(ReflectionModelObject owner, ModelPropertySlot slot)
        {
            _owner = owner;
            _slot = slot;
            var type = _owner.UnderlyingObject.GetType();
            var slotInfo = type.GetProperty(slot.SlotProperty.Name, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            if (slotInfo is not null && typeof(ICollection).IsAssignableFrom(slotInfo.PropertyType))
            {
                _property = slotInfo;
            }
            else
            {
                foreach (var prop in slot.SlotProperties)
                {
                    var propInfo = type.GetProperty(prop.Name, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
                    if (propInfo is not null && typeof(ICollection).IsAssignableFrom(slotInfo.PropertyType))
                    {
                        _property = propInfo;
                        break;
                    }
                }
            }
            if (_property is null) throw new ArgumentException(nameof(slot), "Slot must be a collection.");
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public IModelObject Owner => _owner;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public ModelPropertySlot Slot => _slot;

        public dynamic Items => _property?.GetValue(_owner.UnderlyingObject);

        public bool IsReadOnly => _slot.Flags.HasFlag(ModelPropertyFlags.ReadOnly);
        public bool IsNonUnique => _slot.Flags.HasFlag(ModelPropertyFlags.NonUnique);
        public bool IsNullable => _slot.Flags.HasFlag(ModelPropertyFlags.NullableType);
        public bool IsSingleItem => _slot.Flags.HasFlag(ModelPropertyFlags.SingleItem);

        public object? SingleItem
        {
            get
            {
                var items = Items;
                if (items is null) return null;
                return _slot.Flags.HasFlag(ModelPropertyFlags.SingleItem) && items.Count == 1 ? FirstOf(items) : null;
            }
            set
            {
                if (_slot.Flags.HasFlag(ModelPropertyFlags.SingleItem))
                {
                    var items = Items;
                    if (items is null) return;
                    if (items.Count != 1 || value != FirstOf(items))
                    {
                        Clear();
                        Add(value);
                    }
                }
                else
                {
                    _slot.ThrowModelException(mp => mp.IsSingleItem, mp => $"Error assigning '{value}' to '{mp.QualifiedName}' in '{Owner}': this collection is not a single item collection.");
                }
            }
        }

        public int Count => Items?.Count ?? 0;

        public void Add(object? item)
        {
            if (Owner.Model.IsReadOnly) throw new ModelException($"Error adding '{item}' to '{_slot.SlotProperty.QualifiedName}' in '{Owner}': the model '{Owner.Model}' is read only.");
            if (Owner.Model.ValidationOptions.ValidateReadOnly && _slot.Flags.HasFlag(ModelPropertyFlags.ReadOnly))
            {
                _slot.ThrowModelException(mp => mp.IsReadOnly, mp => $"Error adding '{item}' to '{mp.QualifiedName}' in '{Owner}': the property is read only.");
            }
            AddCore(item, false);
        }

        public void Remove(object? item)
        {
            if (Owner.Model.IsReadOnly) throw new ModelException($"Error removing '{item}' from '{_slot.SlotProperty.QualifiedName}' in '{Owner}': the model '{Owner.Model}' is read only.");
            if (Owner.Model.ValidationOptions.ValidateReadOnly && _slot.Flags.HasFlag(ModelPropertyFlags.ReadOnly))
            {
                _slot.ThrowModelException(mp => mp.IsReadOnly, mp => $"Error removing '{item}' from '{mp.QualifiedName}' in '{Owner}': the property is read only.");
            }
            RemoveCore(item, false);
        }

        public bool Contains(object? item)
        {
            var value = GetValue(item);
            return Items.Contains(value);
        }

        public IEnumerator GetEnumerator()
        {
            foreach (var value in Items)
            {
                yield return GetItem(value);
            }
        }

        public void Clear()
        {
            if (Owner.Model.IsReadOnly) throw new ModelException($"Error clearing '{_slot.SlotProperty.QualifiedName}' in '{Owner}': the model '{Owner.Model}' is read only.");
            if (Owner.Model.ValidationOptions.ValidateReadOnly && _slot.Flags.HasFlag(ModelPropertyFlags.ReadOnly))
            {
                _slot.ThrowModelException(mp => mp.IsReadOnly, mp => $"Error clearing '{mp.QualifiedName}' in '{Owner}': the property is read only.");
            }
            while (Items.Count > 0) RemoveCore(FirstOf(Items), false);
        }

        public void AddCore(object? item, bool fromOpposite)
        {
            if (Owner.Model.ValidationOptions.ValidateNullable && !IsNullable && item == null)
            {
                _slot.ThrowModelException(mp => mp.IsNullable, mp => $"Error adding '{item}' to '{mp.QualifiedName}' in '{Owner}': the item cannot be null.");
            }
            var valueAdded = false;
            var items = Items;
            var value = GetValue(item);
            try
            {
                if (IsNonUnique || !items.Contains(value))
                {
                    if (IsSingleItem && items.Count >= 1)
                    {
                        _slot.ThrowModelException(mp => mp.IsSingleItem, mp => $"Error adding '{value}' to '{mp.QualifiedName}' in '{Owner}': this collection can only contain a single item.");
                    }
                    items.Add(value);
                    valueAdded = true;
                    _owner.ValueAdded(_slot, item, fromOpposite);
                }
            }
            catch (Exception ex)
            {
                if (valueAdded) items.Remove(value);
                if (Owner.Model.ValidationOptions.FullPropertyModificationStackInExceptions) throw new ModelException($"Error adding '{value}' to '{_slot.SlotProperty.QualifiedName}' in '{Owner}'", ex);
                else throw;
            }
        }

        public void RemoveCore(object? item, bool fromOpposite)
        {
            var valueRemoved = false;
            var items = Items;
            var value = GetValue(item);
            try
            {
                items.Remove(value);
                valueRemoved = true;
                if (IsNonUnique || !items.Contains(value))
                {
                    _owner.ValueRemoved(_slot, item, fromOpposite);
                }
            }
            catch (Exception ex)
            {
                if (valueRemoved) items.Add(value);
                if (Owner.Model.ValidationOptions.FullPropertyModificationStackInExceptions) throw new ModelException($"Error removing '{value}' from '{_slot.SlotProperty.QualifiedName}' in '{Owner}'", ex);
                else throw;
            }
        }

        private object? FirstOf(ICollection collection)
        {
            var enumerator = collection.GetEnumerator();
            if (enumerator.MoveNext()) return enumerator.Current;
            else return null;
        }

        private Type GetType(object item)
        {
            return item is IModelObject mobj ? mobj.MetaType : item.GetType();
        }

        private object? GetValue(object? item)
        {
            if (item is IModelObject mobj) return mobj.UnderlyingObject;
            else return item;
        }

        private object? GetItem(object? value)
        {
            return value;
        }
    }
}
