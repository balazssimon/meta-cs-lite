using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace MetaDslx.Modeling
{
    public class CollectionSlot : Slot
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<Box> _items;

        public CollectionSlot(ModelObject owner, ModelPropertySlot property)
            : base(owner, property)
        {
            _items = new List<Box>();
        }

        public List<Box> Items => _items;

        public void Add(Box? box)
        {
            throw new NotImplementedException();
        }

        public void Remove(Box? box)
        {
            throw new NotImplementedException();
        }
    }
}
