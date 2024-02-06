using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.Languages.Uml.Model
{
    internal class UniqueList<T> : IList<T>
    {
        private readonly List<T> _list;

        public UniqueList()
        {
            _list = new List<T>();
        }

        public UniqueList(IEnumerable<T> items)
            : this()
        {
            AddRange(items);
        }

        public T this[int index] 
        {
            get
            {
                return _list[index];
            }
            set
            {
                if (_list[index] is null)
                {
                    if (_list.Contains(value)) _list.RemoveAt(index);
                    else _list[index] = value;
                }
                else if (!_list[index].Equals(value))
                {
                    if (_list.Contains(value)) _list.RemoveAt(index);
                    else _list[index] = value;
                }
            }
        }

        public int Count => _list.Count;

        public bool IsReadOnly => false;

        public void Add(T item)
        {
            if (!_list.Contains(item))
            {
                _list.Add(item);
            }
        }

        public void AddRange(IEnumerable<T> items)
        {
            foreach (var item in items)
            {
                if (!_list.Contains(item))
                {
                    _list.Add(item);
                }
            }
        }

        public void Clear()
        {
            _list.Clear();
        }

        public bool Contains(T item)
        {
            return _list.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            _list.CopyTo(array, arrayIndex);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _list.GetEnumerator();
        }

        public int IndexOf(T item)
        {
            return _list.IndexOf(item);
        }

        public void Insert(int index, T item)
        {
            if (_list.Contains(item))
            {
                _list.Insert(index, item);
            }
        }

        public bool Remove(T item)
        {
            return _list.Remove(item);
        }

        public void RemoveAt(int index)
        {
            _list.RemoveAt(index);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)_list).GetEnumerator();
        }
    }
}
