using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.Modeling
{
    internal class ModelObjectListRedefinition<T, TRedefined> : IList<T>
    {
        private ModelObjectList<TRedefined> _items;

        public ModelObjectListRedefinition(ModelObjectList<TRedefined> items)
        {
            _items = items;
        }

        public T this[int index] 
        {
            get => (T)(object)_items[index];
            set => _items[index] = (TRedefined)(object)value;
        }

        public int Count => _items.Count;

        public bool IsReadOnly => _items.IsReadOnly;

        public void Add(T item)
        {
            _items.Add((TRedefined)(object)item);
        }

        public void Clear()
        {
            _items.Clear();
        }

        public bool Contains(T item)
        {
            return _items.Contains((TRedefined)(object)item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            var redefArray = new TRedefined[array.Length];
            _items.CopyTo(redefArray, arrayIndex);
            for (int i = arrayIndex; i < redefArray.Length; i++)
            {
                array[i] = (T)(object)redefArray[i];
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return (IEnumerator<T>)_items.GetEnumerator();
        }

        public int IndexOf(T item)
        {
            return _items.IndexOf((TRedefined)(object)item);
        }

        public void Insert(int index, T item)
        {
            _items.Insert(index, (TRedefined)(object)item);
        }

        public bool Remove(T item)
        {
            return _items.Remove((TRedefined)(object)item);
        }

        public void RemoveAt(int index)
        {
            _items.RemoveAt(index);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
