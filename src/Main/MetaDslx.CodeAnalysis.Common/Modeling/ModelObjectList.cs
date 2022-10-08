using MetaDslx.CodeAnalysis.PooledObjects;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
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
                CheckReadonly();
                SafeReplace(index, value);
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
                    throw new InvalidOperationException($"This collection is not a single item collection.");
                }
            }
        }
        

        public void Add(T item)
        {
            CheckReadonly();
            SafeInsert(_items.Count, item);
        }

        public void Clear()
        {
            CheckReadonly();
            while (_items.Count > 0) SafeRemoveAt(_items.Count - 1);
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
            CheckReadonly();
            SafeInsert(index, item);
        }

        public bool Remove(T item)
        {
            var index = _items.IndexOf(item);
            if (index >= 0) RemoveAt(index);
            return index >= 0;
        }

        public void RemoveAt(int index)
        {
            CheckReadonly();
            SafeRemoveAt(index);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        void IModelCollection.Add(object? item)
        {
            foreach (var slotProperty in _slot.SlotProperties)
            {
                if (!slotProperty.Type.IsAssignableFrom(item.GetType())) throw new ArgumentException($"The type '{item.GetType()}' of '{item}' is not assignable to the type '{slotProperty.Type}' of '{slotProperty}'.");
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

        private void SafeReplace(int index, T item)
        {
            if (!NullableType && item == null) throw new ArgumentNullException(nameof(item));
            var valueReplaced = false;
            var oldValue = _items[index];
            try
            {
                if (!item.Equals(oldValue))
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
                        throw new InvalidOperationException($"Value '{item}' will not be unique.");
                    }
                }
            }
            catch
            {
                if (valueReplaced) _items[index] = oldValue;
                throw;
            }
        }

        private void SafeInsert(int index, T item)
        {
            if (!NullableType && item == null) throw new ArgumentNullException(nameof(item));
            var valueAdded = false;
            try
            {
                if (NonUnique || !_items.Contains(item))
                {
                    if (SingleItem && _items.Count >= 1)
                    {
                        throw new InvalidOperationException($"Only one item is allowed in this collection.");
                    }
                    _items.Insert(index, item);
                    valueAdded = true;
                    _owner.ValueAdded(_slot, item);
                }
            }
            catch
            {
                if (valueAdded) _items.RemoveAt(_items.Count - 1);
                throw;
            }
        }

        private void SafeRemoveAt(int index)
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
            catch
            {
                if (valueRemoved) _items.Insert(index, oldItem);
                throw;
            }
        }

        private void CheckReadonly()
        {
            foreach (var slotProperty in _slot.SlotProperties)
            {
                if (slotProperty.IsReadOnly) throw new InvalidOperationException($"Collection property '{slotProperty.Name}' is read only.");
            }
        }

        void IModelCollectionCore.AddCore(object? item)
        {
            SafeInsert(_items.Count, (T)item);
        }

        void IModelCollectionCore.RemoveCore(object? item)
        {
            var index = _items.IndexOf((T)item);
            if (index >= 0) SafeRemoveAt(index);
        }
    }
}
