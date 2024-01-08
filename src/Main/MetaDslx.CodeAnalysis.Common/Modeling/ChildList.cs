using MetaDslx.CodeAnalysis.PooledObjects;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.Modeling
{
    internal class ChildList : IList<IModelObject>
    {
        private readonly IModelObject _parent;
        private readonly List<IModelObject> _children;

        public ChildList(IModelObject parent)
        {
            _parent = parent;
            _children = new List<IModelObject>();
        }

        public IModelObject this[int index] 
        {
            get => _children[index]; 
            set
            {
                if (value is null) throw new ModelException($"Cannot add 'null' as a child to an object.");
                if (_children[index] == value) return;
                if (_children.Contains(value)) return;
                if (value.MParent != _parent) throw new ModelException($"Error changing the parent '{value.MParent}' of '{value}' to {_parent}: to change the parent of an object, remove the object from the old parent first.'");
                var oldChild = _children[index];
                _children[index] = value;
                oldChild.MParent = null;
                value.MParent = _parent;
            }
        }

        public int Count => _children.Count;

        public bool IsReadOnly => _parent.MModel.IsReadOnly;

        public void Add(IModelObject item)
        {
            if (item is null) throw new ModelException($"Cannot add 'null' as a child to an object.");
            if (_children.Contains(item)) return;
            _children.Add(item);
            item.MParent = _parent;
        }

        public void Clear()
        {
            var items = _children.ToArray();
            _children.Clear();
            foreach (var item in items)
            {
                item.MParent = null;
            }
        }

        public bool Contains(IModelObject item)
        {
            return _children.Contains(item);
        }

        public void CopyTo(IModelObject[] array, int arrayIndex)
        {
            _children.CopyTo(array, arrayIndex);
        }

        public IEnumerator<IModelObject> GetEnumerator()
        {
            return _children.GetEnumerator();
        }

        public int IndexOf(IModelObject item)
        {
            return _children.IndexOf(item);
        }

        public void Insert(int index, IModelObject item)
        {
            if (item is null) throw new ModelException($"Cannot add 'null' as a child to an object.");
            if (_children.Contains(item)) return;
            _children.Insert(index, item);
            item.MParent = _parent;
        }

        public bool Remove(IModelObject item)
        {
            if (_children.Remove(item))
            {
                item.MParent = null;
                return true;
            }
            return false;
        }

        public void RemoveAt(int index)
        {
            var item = _children[index];
            _children.RemoveAt(index);
            item.MParent = null;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public override string ToString()
        {
            return $"Count = {Count}";
        }
    }
}
