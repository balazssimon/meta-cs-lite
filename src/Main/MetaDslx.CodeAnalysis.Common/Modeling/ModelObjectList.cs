﻿using MetaDslx.CodeAnalysis.PooledObjects;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Text;

namespace MetaDslx.Modeling
{
    public class ModelObjectList<T> : IList<T>, IModelCollection, IModelCollectionCore
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ModelObject _owner;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ModelPropertySlot _slot;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<T> _items;

        public ModelObjectList(ModelObject owner, ModelPropertySlot slot)
        {
            _owner = owner;
            _slot = slot;
            _items = new List<T>();
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public IModelObject Owner => _owner;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public ModelPropertySlot Slot => _slot;

        public T this[int index] 
        {
            get => _items[index]; 
            set
            {
                if (Owner.Model.IsReadOnly) throw new ModelException($"Error assigning '{value}' to '{_slot.SlotProperty.QualifiedName}[{index}]' in '{Owner}': the model '{Owner.Model}' is read only.");
                if (Owner.Model.ValidationOptions.ValidateReadOnly && _slot.Flags.HasFlag(ModelPropertyFlags.ReadOnly))
                {
                    _slot.ThrowModelException(mp => mp.IsReadOnly, mp => $"Error assigning '{value}' to '{mp.QualifiedName}[{index}]' in '{Owner}': the property is read only.");
                }
                ReplaceCore(index, value);
            }
        }

        public int Count => _items.Count;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool IsReadOnly => _slot.Flags.HasFlag(ModelPropertyFlags.ReadOnly);
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool NonUnique => _slot.Flags.HasFlag(ModelPropertyFlags.NonUnique);
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool NullableType => _slot.Flags.HasFlag(ModelPropertyFlags.NullableType);
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool SingleItem => _slot.Flags.HasFlag(ModelPropertyFlags.SingleItem);
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        int IModelCollection.Count => Count;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        object? IModelCollection.SingleItem
        {
            get
            {
                return _slot.Flags.HasFlag(ModelPropertyFlags.SingleItem) && _items.Count == 1 ? _items[0] : null;
            }
            set
            {
                if (_slot.Flags.HasFlag(ModelPropertyFlags.SingleItem))
                {
                    if (_items.Count == 0) Add((T)value);
                    else this[0] = (T)value;
                }
                else
                {
                    _slot.ThrowModelException(mp => mp.IsSingleItem, mp => $"Error assigning '{value}' to '{mp.QualifiedName}' in '{Owner}': this collection is not a single item collection.");
                }
            }
        }
        

        public void Add(T item)
        {
            if (Owner.Model.IsReadOnly) throw new ModelException($"Error adding '{item}' to '{_slot.SlotProperty.QualifiedName}' in '{Owner}': the model '{Owner.Model}' is read only.");
            if (Owner.Model.ValidationOptions.ValidateReadOnly && _slot.Flags.HasFlag(ModelPropertyFlags.ReadOnly))
            {
                _slot.ThrowModelException(mp => mp.IsReadOnly, mp => $"Error adding '{item}' to '{mp.QualifiedName}' in '{Owner}': the property is read only.");
            }
            InsertCore(_items.Count, item);
        }

        public void Clear()
        {
            if (Owner.Model.IsReadOnly) throw new ModelException($"Error clearing '{_slot.SlotProperty.QualifiedName}' in '{Owner}': the model '{Owner.Model}' is read only.");
            if (Owner.Model.ValidationOptions.ValidateReadOnly && _slot.Flags.HasFlag(ModelPropertyFlags.ReadOnly))
            {
                _slot.ThrowModelException(mp => mp.IsReadOnly, mp => $"Error clearing '{mp.QualifiedName}' in '{Owner}': the property is read only.");
            }
            while (_items.Count > 0) RemoveAtCore(_items.Count - 1);
        }

        public bool Contains(T item)
        {
            return _items.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            _items.CopyTo(array, arrayIndex);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _items.GetEnumerator();
        }

        public int IndexOf(T item)
        {
            return _items.IndexOf(item);
        }

        public void Insert(int index, T item)
        {
            if (Owner.Model.IsReadOnly) throw new ModelException($"Error inserting '{item}' at '{_slot.SlotProperty.QualifiedName}[{index}]' in '{Owner}': the model '{Owner.Model}' is read only.");
            if (Owner.Model.ValidationOptions.ValidateReadOnly && _slot.Flags.HasFlag(ModelPropertyFlags.ReadOnly))
            {
                _slot.ThrowModelException(mp => mp.IsReadOnly, mp => $"Error inserting '{item}' at '{mp.QualifiedName}[{index}]' in '{Owner}': the property is read only.");
            }
            InsertCore(index, item);
        }

        public bool Remove(T item)
        {
            var index = _items.IndexOf(item);
            if (index >= 0) RemoveAt(index);
            return index >= 0;
        }

        public void RemoveAt(int index)
        {
            if (Owner.Model.IsReadOnly) throw new ModelException($"Error removing item at '{_slot.SlotProperty.QualifiedName}[{index}]' in '{Owner}': the model '{Owner.Model}' is read only.");
            if (Owner.Model.ValidationOptions.ValidateReadOnly && _slot.Flags.HasFlag(ModelPropertyFlags.ReadOnly))
            {
                _slot.ThrowModelException(mp => mp.IsReadOnly, mp => $"Error removing item at '{mp.QualifiedName}[{index}]' in '{Owner}': the property is read only.");
            }
            RemoveAtCore(index);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        void IModelCollection.Add(object? item)
        {
            if (item != null)
            {
                _slot.ThrowModelException(mp => !mp.Type.IsAssignableFrom(item.GetType()), mp => $"Error adding '{item}' to '{mp.QualifiedName}' in '{Owner}': the item type '{item.GetType()}' is not assignable to the property type '{mp.Type}'.");
            }
            if (item is T typedItem)
            {
                this.Add(typedItem);
            }
        }

        void IModelCollection.Remove(object? item)
        {
            if (item is T typedItem)
            {
                this.Remove(typedItem);
            }
        }

        public override string ToString()
        {
            var psb = PooledStringBuilder.GetInstance();
            var sb = psb.Builder;
            var first = true;
            sb.Append('[');
            foreach (var item in _items)
            {
                if (first) first = false;
                else sb.Append(", ");
                sb.Append(item.ToString());
            }
            sb.Append(']');
            return psb.ToStringAndFree();
        }

        bool IModelCollection.Contains(object? item)
        {
            if (item is T titem) return Contains(titem);
            else return false;
        }

        private void ReplaceCore(int index, T item)
        {
            if (Owner.Model.ValidationOptions.ValidateNullable && !NullableType && item == null)
            {
                _slot.ThrowModelException(mp => mp.IsNullable, mp => $"Error assigning '{item}' to '{mp.QualifiedName}[{index}]' in '{Owner}': the item cannot be null.");
            }
            var valueReplaced = false;
            var oldValue = _items[index];
            try
            {
                if ((item is null && oldValue is not null) || (item is not null && !item.Equals(oldValue)))
                {
                    _items[index] = default(T);
                    _owner.ValueRemoved(_slot, oldValue);
                    if (NonUnique || !_items.Contains(item))
                    {
                        _items[index] = item;
                        _owner.ValueAdded(_slot, item);
                    }
                    else
                    {
                        _slot.ThrowModelException(mp => !mp.Type.IsAssignableFrom(item.GetType()), mp => $"Error assigning '{item}' to '{mp.QualifiedName}[{index}]' in '{Owner}': the item will not be unique in the collection.");
                    }
                }
            }
            catch (Exception ex)
            {
                if (valueReplaced) _items[index] = oldValue;
                if (Owner.Model.ValidationOptions.FullPropertyModificationStackInExceptions) throw new ModelException($"Error assigning '{item}' to '{_slot.SlotProperty.QualifiedName}[{index}]' in '{Owner}'", ex);
                else throw;
            }
        }

        private void InsertCore(int index, T item)
        {
            if (Owner.Model.ValidationOptions.ValidateNullable && !NullableType && item == null)
            {
                _slot.ThrowModelException(mp => mp.IsNullable, mp => $"Error inserting '{item}' at '{mp.QualifiedName}[{index}]' in '{Owner}': the item cannot be null.");
            }
            var valueAdded = false;
            try
            {
                if (NonUnique || !_items.Contains(item))
                {
                    if (SingleItem && _items.Count >= 1)
                    {
                        _slot.ThrowModelException(mp => mp.IsSingleItem, mp => $"Error inserting '{item}' at '{mp.QualifiedName}[{index}]' in '{Owner}': this collection can only contain a single item.");
                    }
                    _items.Insert(index, item);
                    valueAdded = true;
                    _owner.ValueAdded(_slot, item);
                }
            }
            catch (Exception ex)
            {
                if (valueAdded) _items.RemoveAt(_items.Count - 1);
                if (Owner.Model.ValidationOptions.FullPropertyModificationStackInExceptions) throw new ModelException($"Error inserting '{item}' at '{_slot.SlotProperty.QualifiedName}[{index}]' in '{Owner}'", ex);
                else throw;
            }
        }

        private void RemoveAtCore(int index)
        {
            var valueRemoved = false;
            var oldItem = _items[index];
            try
            {
                _items.RemoveAt(index);
                valueRemoved = true;
                if (NonUnique || !_items.Contains(oldItem))
                {
                    _owner.ValueRemoved(_slot, oldItem);
                }
            }
            catch (Exception ex)
            {
                if (valueRemoved) _items.Insert(index, oldItem);
                if (Owner.Model.ValidationOptions.FullPropertyModificationStackInExceptions) throw new ModelException($"Error removing '{oldItem}' at '{_slot.SlotProperty.QualifiedName}[{index}]' in '{Owner}'", ex);
                else throw;
            }
        }

        void IModelCollectionCore.AddCore(object? item)
        {
            if (item is not null)
            {
                _slot.ThrowModelException(mp => !mp.Type.IsAssignableFrom(item.GetType()), mp => $"Error adding '{item}' to '{mp.QualifiedName}' in '{Owner}': the item type '{item.GetType()}' is not assignable to the property type '{mp.Type}'.");
            }
            InsertCore(_items.Count, (T)item);
        }

        void IModelCollectionCore.RemoveCore(object? item)
        {
            if (item is not null)
            {
                _slot.ThrowModelException(mp => !mp.Type.IsAssignableFrom(item.GetType()), mp => $"Error removing '{item}' from '{mp.QualifiedName}' in '{Owner}': the item type '{item.GetType()}' is not assignable to the property type '{mp.Type}'.");
            }
            var index = _items.IndexOf((T)item);
            if (index >= 0) RemoveAtCore(index);
        }

    }
}
