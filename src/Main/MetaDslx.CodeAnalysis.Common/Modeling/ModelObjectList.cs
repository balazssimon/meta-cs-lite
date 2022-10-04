using MetaDslx.CodeAnalysis.PooledObjects;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace MetaDslx.Modeling
{
    public class ModelObjectList<T> : IList<T>, IModelCollection
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ModelObject _owner;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ModelProperty _property;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<T> _items;

        public ModelObjectList(ModelObject owner, ModelProperty property)
        {
            _owner = owner;
            _property = property;
            _items = new List<T>();
        }

        public IModelObject Owner => _owner;
        public ModelProperty Property => _property;

        public T this[int index] 
        {
            get => _items[index]; 
            set
            {
                if (value == null) throw new ArgumentNullException(nameof(value));
                var oldValue = _items[index];
                if (!value.Equals(oldValue))
                {
                    _items[index] = default(T);
                    _owner.ValueRemoved(_property, oldValue);
                    _items[index] = value;
                    _owner.ValueAdded(_property, value);
                }
            }
        }

        public int Count => _items.Count;

        public bool IsReadOnly => _property.IsReadonly;

        int IModelCollection.MCount => Count;

        public void Add(T item)
        {
            if (_property.IsNonUnique || !_items.Contains(item))
            {
                _items.Add(item);
                _owner.ValueAdded(_property, item);
            }
        }

        public void Clear()
        {
            while (_items.Count > 0) RemoveAt(_items.Count - 1);
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
            if (!_property.IsNonUnique || !_items.Contains(item))
            {
                _items.Insert(index, item);
                _owner.ValueAdded(_property, item);
            }
        }

        public bool Remove(T item)
        {
            if (_items.Remove(item))
            {
                if (_property.IsNonUnique || !_items.Contains(item))
                {
                    _owner.ValueRemoved(_property, item);
                }
                return true;
            }
            return false;
        }

        public void RemoveAt(int index)
        {
            var oldItem = _items[index];
            _items.RemoveAt(index);
            if (_property.IsNonUnique || !_items.Contains(oldItem))
            {
                _owner.ValueRemoved(_property, oldItem);
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        void IModelCollection.MAdd(object? item)
        {
            this.Add((T)item);
        }

        void IModelCollection.MRemove(object? item)
        {
            this.Remove((T)item);
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

        bool IModelCollection.MContains(object? item)
        {
            if (item is T titem) return Contains(titem);
            else return false;
        }
    }
}
