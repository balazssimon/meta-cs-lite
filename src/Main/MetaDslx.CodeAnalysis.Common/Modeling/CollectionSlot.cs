﻿using MetaDslx.CodeAnalysis.PooledObjects;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;

namespace MetaDslx.Modeling
{
    internal class CollectionSlot : Slot, ICollectionSlot, ISlotCore, IEnumerable
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<Box> _boxes;

        public CollectionSlot(IModelObject owner, ModelPropertySlot property)
            : base(owner, property)
        {
            _boxes = new List<Box>();
        }

        public override IEnumerable<Box> Boxes => _boxes;

        public override SlotKind Kind => SlotKind.Collection;

        public override bool IsDefault => _boxes.Count == 0;

        public bool IsUnordered => Property.IsUnordered;

        public bool IsNonUnique => Property.IsNonUnique;

        public int Count => _boxes.Count;

        public object? this[int index] 
        {
            get => _boxes[index].Value;
            set => ReplaceAtCore(index, value, null);
        }

        public override void Clear()
        {
            while (_boxes.Count > 0)
            {
                RemoveAtCore(_boxes.Count - 1, null);
            }
        }

        public override bool Contains(object? item)
        {
            return _boxes.Any(b => b.HasValue(item));
        }

        void ISlotCore.AddCore(object? item, Box? oppositeBox)
        {
            AddCore(item, oppositeBox);
        }

        void ISlotCore.RemoveCore(object? item, Box? oppositeBox)
        {
            RemoveCore(item, oppositeBox);
        }

        private void AddCore(object? item, Box? oppositeBox)
        {
            InsertAtCore(_boxes.Count, item, oppositeBox);
        }

        private Box? InsertAtCore(int index, object? item, Box? oppositeBox)
        {
            if (oppositeBox is null) CheckReadOnly(GetInsertMessage(Property.SlotProperty, item));
            CheckValueType(item, mp => GetInsertMessage(mp, item));
            var valueAdded = false;
            try
            {
                if (IsNonUnique || !_boxes.Any(b => b.HasValue(item)))
                {
                    if (Property.IsSingle && _boxes.Count >= 1)
                    {
                        Property.ThrowModelException(mp => mp.IsSingle, mp => $"{GetInsertMessage(mp, item)}: this collection can only contain a single item.");
                    }
                    var box = new Box(this);
                    box.Value = item;
                    _boxes.Insert(index, box);
                    valueAdded = true;
                    ValueAdded(box, oppositeBox);
                    return box;
                }
                return null;
            }
            catch (Exception ex)
            {
                if (valueAdded) _boxes.RemoveAt(index);
                if (Owner.Model.ValidationOptions.FullPropertyModificationStackInExceptions) throw new ModelException(GetInsertMessage(Property.SlotProperty, item), ex);
                else throw;
            }
        }

        private void RemoveCore(object? item, Box? oppositeBox)
        {
            var index = IndexOf(item);
            while (index >= 0)
            {
                RemoveAtCore(index, oppositeBox);
                index = IndexOf(item);
            }
        }

        private Box? RemoveAtCore(int index, Box? oppositeBox)
        {
            var valueRemoved = false;
            var box = _boxes[index];
            var oldValue = box.Value;
            try
            {
                _boxes.RemoveAt(index);
                valueRemoved = true;
                if (IsNonUnique || !_boxes.Any(b => b.HasValue(oldValue)))
                {
                    ValueRemoved(box, oldValue, oppositeBox);
                    return box;
                }
                return null;
            }
            catch (Exception ex)
            {
                if (valueRemoved)
                {
                    box.Value = oldValue;
                    _boxes.Insert(index, box);
                }
                if (Owner.Model.ValidationOptions.FullPropertyModificationStackInExceptions) throw new ModelException(GetRemoveMessage(Property.SlotProperty, box.Value), ex);
                else throw;
            }
        }

        private Box? ReplaceAtCore(int index, object? item, Box? oppositeBox)
        {
            if (oppositeBox is null) CheckReadOnly(GetInsertMessage(Property.SlotProperty, item));
            CheckValueType(item, mp => GetInsertMessage(mp, item));
            var valueReplaced = false;
            var box = _boxes[index];
            var oldValue = box.Value;
            try
            {
                if (!box.HasValue(item))
                {
                    box.Clear();
                    ValueRemoved(box, oldValue, oppositeBox);
                    if (IsNonUnique || !_boxes.Any(b => b.HasValue(item)))
                    {
                        box.Value = item;
                        ValueAdded(box, oppositeBox);
                        return box;
                    }
                    else
                    {
                        throw new ModelException($"Error assigning '{item}' to '{Property.QualifiedName}[{index}]' in '{Owner}': the item will not be unique in the collection.");
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                if (valueReplaced) box.Value = oldValue;
                if (Owner.Model.ValidationOptions.FullPropertyModificationStackInExceptions) throw new ModelException(GetAssignMessage(Property.SlotProperty, item), ex);
                else throw;
            }
        }

        protected string GetAssignMessage(ModelProperty property, object? value)
        {
            return $"Error assigning '{value}' to '{property.QualifiedName}' in '{Owner}'";
        }

        protected string GetInsertMessage(ModelProperty property, object? value)
        {
            return $"Error inserting '{value}' to '{property.QualifiedName}' in '{Owner}'";
        }

        protected string GetRemoveMessage(ModelProperty property, object? value)
        {
            return $"Error removing '{value}' from '{property.QualifiedName}' in '{Owner}'";
        }

        public int IndexOf(object? item)
        {
            for (int i = 0; i < _boxes.Count; ++i)
            {
                if (_boxes[i].HasValue(item)) return i;
            }
            return -1;
        }

        public int LastIndexOf(object? item)
        {
            for (int i = _boxes.Count - 1; i >= 0; --i)
            {
                if (_boxes[i].HasValue(item)) return i;
            }
            return -1;
        }

        public Box BoxAt(int index)
        {
            return _boxes[index];
        }

        public Box? BoxOf(object? item)
        {
            var index = IndexOf(item);
            if (index >= 0) return _boxes[index];
            else return null;
        }

        public ImmutableArray<Box> AllBoxesOf(object? item)
        {
            var result = ArrayBuilder<Box>.GetInstance();
            for (int i = 0; i < _boxes.Count; ++i)
            {
                var box = _boxes[i];
                if (box.HasValue(item)) result.Add(box);
            }
            return result.ToImmutableAndFree();
        }

        public Box? Add(object? item)
        {
            return InsertAtCore(_boxes.Count, item, null);
        }

        public ImmutableArray<Box> AddRange(IEnumerable items)
        {
            var result = ArrayBuilder<Box>.GetInstance();
            foreach (var item in items)
            {
                var box = Add(item);
                if (box is not null) result.Add(box);
            }
            return result.ToImmutableAndFree();
        }

        public Box Insert(int index, object? item)
        {
            return InsertAtCore(index, item, null);
        }

        public ImmutableArray<Box> InsertRange(int index, IEnumerable items)
        {
            var result = ArrayBuilder<Box>.GetInstance();
            foreach (var item in items)
            {
                var box = InsertAtCore(index, item, null);
                if (box is not null) result.Add(box);
                ++index;
            }
            return result.ToImmutableAndFree();
        }

        public Box? Remove(object? item)
        {
            var index = IndexOf(item);
            if (index >= 0) return RemoveAtCore(index, null);
            else return null;
        }

        public ImmutableArray<Box> RemoveAll(object? item)
        {
            var result = ArrayBuilder<Box>.GetInstance();
            var index = IndexOf(item);
            while (index >= 0)
            {
                var box = RemoveAtCore(index, null);
                if (box is not null) result.Add(box);
                index = IndexOf(item);
            }
            return result.ToImmutableAndFree();
        }

        public Box? RemoveAt(int index)
        {
            return RemoveAtCore(index, null);
        }

        public ImmutableArray<Box> RemoveRange(int index, int count)
        {
            var result = ArrayBuilder<Box>.GetInstance();
            for (int i = 0; i < count; ++i)
            {
                var box = RemoveAtCore(index, null);
                if (box is not null) result.Add(box);
            }
            return result.ToImmutableAndFree();
        }

        public ImmutableArray<Box> RemoveRange(IEnumerable items)
        {
            var result = ArrayBuilder<Box>.GetInstance();
            var itemSet = PooledHashSet<object>.GetInstance();
            foreach (var item in items)
            {
                itemSet.Add(item);
            }
            for (int i = _boxes.Count - 1; i >= 0; --i)
            {
                var box = _boxes[i];
                if (itemSet.Contains(box.Value))
                {
                    _boxes.RemoveAt(i);
                    result.Add(box);
                }
            }
            itemSet.Free();
            return result.ToImmutableAndFree();
        }

        public ImmutableArray<Box> RetainRange(IEnumerable items)
        {
            var result = ArrayBuilder<Box>.GetInstance();
            var itemSet = PooledHashSet<object>.GetInstance();
            foreach (var item in items)
            {
                itemSet.Add(item);
            }
            for (int i = _boxes.Count - 1; i >= 0; --i)
            {
                var box = _boxes[i];
                if (!itemSet.Contains(box.Value))
                {
                    _boxes.RemoveAt(i);
                    result.Add(box);
                }
            }
            itemSet.Free();
            return result.ToImmutableAndFree();
        }

        public void Reverse()
        {
            _boxes.Reverse();
        }

        public IEnumerator GetEnumerator()
        {
            foreach (var box in _boxes)
            {
                yield return box.Value;
            }
        }
    }

    internal class CollectionSlot<T> : IList<T>, ICollectionSlot<T>, ISlotCore
    {
        private readonly ICollectionSlot _wrappedSlot;

        public CollectionSlot(ICollectionSlot wrappedSlot)
        {
            _wrappedSlot = wrappedSlot;
        }

        public IModelObject Owner => _wrappedSlot.Owner;

        public ModelPropertySlot Property => _wrappedSlot.Property;

        public bool IsReadOnly => _wrappedSlot.IsReadOnly;

        public bool IsNullable => _wrappedSlot.IsNullable;

        public SlotKind Kind => SlotKind.Single;

        public bool IsDefault => _wrappedSlot.IsDefault;

        void ISlotCore.AddCore(object? item, Box? oppositeBox)
        {
            (_wrappedSlot as ISlotCore)?.AddCore(item, oppositeBox);
        }

        void ISlotCore.RemoveCore(object? item, Box? oppositeBox)
        {
            (_wrappedSlot as ISlotCore)?.RemoveCore(item, oppositeBox);
        }

        bool ICollectionSlot.IsUnordered => _wrappedSlot.IsUnordered;

        bool ICollectionSlot.IsNonUnique => _wrappedSlot.IsNonUnique;

        IEnumerable<Box> ISlot.Boxes => _wrappedSlot.Boxes;

        int ICollectionSlot.Count => _wrappedSlot.Count;

        IModelObject ISlot.Owner => _wrappedSlot.Owner;

        ModelPropertySlot ISlot.Property => _wrappedSlot.Property;

        SlotKind ISlot.Kind => SlotKind.Collection;

        bool ISlot.IsReadOnly => _wrappedSlot.IsReadOnly;

        bool ISlot.IsNullable => _wrappedSlot.IsNullable;

        bool ISlot.IsDefault => _wrappedSlot.IsDefault;

        int ICollection<T>.Count => _wrappedSlot.Count;

        bool ICollection<T>.IsReadOnly => _wrappedSlot.IsReadOnly;

        T IList<T>.this[int index]
        {
            get => (T)_wrappedSlot[index];
            set => _wrappedSlot[index] = value;
        }

        T ICollectionSlot<T>.this[int index]
        {
            get => (T)_wrappedSlot[index];
            set => _wrappedSlot[index] = value;
        }

        object? ICollectionSlot.this[int index]
        {
            get => _wrappedSlot[index];
            set => _wrappedSlot[index] = value;
        }

        Box? ICollectionSlot<T>.Add(T item)
        {
            return _wrappedSlot.Add(item);
        }

        Box? ICollectionSlot.Add(object? item)
        {
            return _wrappedSlot.Add(item);
        }

        ImmutableArray<Box> ICollectionSlot<T>.AddRange(IEnumerable<T> items)
        {
            return _wrappedSlot.AddRange(items);
        }

        ImmutableArray<Box> ICollectionSlot.AddRange(IEnumerable items)
        {
            return _wrappedSlot.AddRange(items);
        }

        ImmutableArray<Box> ICollectionSlot<T>.AllBoxesOf(T item)
        {
            return _wrappedSlot.AllBoxesOf(item);
        }

        ImmutableArray<Box> ICollectionSlot.AllBoxesOf(object? item)
        {
            return _wrappedSlot.AllBoxesOf(item);
        }

        Box ICollectionSlot.BoxAt(int index)
        {
            return _wrappedSlot.BoxAt(index);
        }

        Box? ICollectionSlot<T>.BoxOf(T item)
        {
            return _wrappedSlot.BoxOf(item);
        }

        Box? ICollectionSlot.BoxOf(object? item)
        {
            return _wrappedSlot.BoxOf(item);
        }

        void ISlot.Clear()
        {
            _wrappedSlot.Clear();
        }

        bool ICollectionSlot<T>.Contains(T item)
        {
            return _wrappedSlot.Contains(item);
        }

        bool ISlot.Contains(object? item)
        {
            return _wrappedSlot.Contains(item);
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var box in _wrappedSlot.Boxes)
            {
                yield return (T)box.Value;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _wrappedSlot.GetEnumerator();
        }

        int ICollectionSlot<T>.IndexOf(T item)
        {
            return _wrappedSlot.IndexOf(item);
        }

        int ICollectionSlot.IndexOf(object? item)
        {
            return _wrappedSlot.IndexOf(item);
        }

        Box? ICollectionSlot<T>.Insert(int index, T item)
        {
            return _wrappedSlot.Insert(index, item);
        }

        Box? ICollectionSlot.Insert(int index, object? item)
        {
            return _wrappedSlot.Insert(index, item);
        }

        ImmutableArray<Box> ICollectionSlot<T>.InsertRange(int index, IEnumerable<T> items)
        {
            return _wrappedSlot.InsertRange(index, items);
        }

        ImmutableArray<Box> ICollectionSlot.InsertRange(int index, IEnumerable items)
        {
            return _wrappedSlot.InsertRange(index, items);
        }

        int ICollectionSlot<T>.LastIndexOf(T item)
        {
            return _wrappedSlot.LastIndexOf(item);
        }

        int ICollectionSlot.LastIndexOf(object? item)
        {
            return _wrappedSlot.LastIndexOf(item);
        }

        Box? ICollectionSlot<T>.Remove(T item)
        {
            return _wrappedSlot.Remove(item);
        }

        Box? ICollectionSlot.Remove(object? item)
        {
            return _wrappedSlot.Remove(item);
        }

        ImmutableArray<Box> ICollectionSlot.RemoveAll(object? item)
        {
            return _wrappedSlot.RemoveAll(item);
        }

        ImmutableArray<Box> ICollectionSlot<T>.RemoveAll(T item)
        {
            return _wrappedSlot.RemoveAll(item);
        }

        Box? ICollectionSlot.RemoveAt(int index)
        {
            return _wrappedSlot.RemoveAt(index);
        }

        ImmutableArray<Box> ICollectionSlot<T>.RemoveRange(IEnumerable<T> items)
        {
            return _wrappedSlot.RemoveRange(items);
        }

        ImmutableArray<Box> ICollectionSlot.RemoveRange(int index, int count)
        {
            return _wrappedSlot.RemoveRange(index, count);
        }

        ImmutableArray<Box> ICollectionSlot.RemoveRange(IEnumerable items)
        {
            return _wrappedSlot.RemoveRange(items);
        }

        ImmutableArray<Box> ICollectionSlot<T>.RetainRange(IEnumerable<T> items)
        {
            return _wrappedSlot.RetainRange(items);
        }

        ImmutableArray<Box> ICollectionSlot.RetainRange(IEnumerable items)
        {
            return _wrappedSlot.RetainRange(items);
        }

        void ICollectionSlot.Reverse()
        {
            _wrappedSlot.Reverse();
        }

        int IList<T>.IndexOf(T item)
        {
            return _wrappedSlot.IndexOf(item);
        }

        void IList<T>.Insert(int index, T item)
        {
            _wrappedSlot.Insert(index, item);
        }

        void IList<T>.RemoveAt(int index)
        {
            _wrappedSlot.RemoveAt(index);
        }

        void ICollection<T>.Add(T item)
        {
            _wrappedSlot.Add(item);
        }

        void ICollection<T>.Clear()
        {
            _wrappedSlot.Clear();
        }

        bool ICollection<T>.Contains(T item)
        {
            return _wrappedSlot.Contains(item);
        }

        void ICollection<T>.CopyTo(T[] array, int arrayIndex)
        {
            if (array == null) throw new ArgumentNullException(nameof(array));
            if (arrayIndex < 0) throw new ArgumentOutOfRangeException(nameof(arrayIndex));
            if (arrayIndex + _wrappedSlot.Count > array.Length) throw new ArgumentException("The number of elements in the collection is greater than the available space from arrayIndex to the end of the destination array.");
            for (int i = 0; i < _wrappedSlot.Count; ++i)
            {
                array[arrayIndex + i] = (T)_wrappedSlot[i];
            }
        }

        bool ICollection<T>.Remove(T item)
        {
            return _wrappedSlot.Remove(item) is not null;
        }
    }
}
