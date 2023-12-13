using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Text;

namespace MetaDslx.Modeling
{
    internal class CollectionSlot : Slot, ICollectionSlot
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<Box> _items;

        public CollectionSlot(IModelObject owner, ModelPropertySlot property)
            : base(owner, property)
        {
            _items = new List<Box>();
        }

        public List<Box> Items => _items;

        public override bool IsDefault => _items.Count == 0;

        public bool IsUnordered => Property.IsUnordered;

        public bool IsNonUnique => Property.IsNonUnique;

        public int Count => _items.Count;

    }
}
