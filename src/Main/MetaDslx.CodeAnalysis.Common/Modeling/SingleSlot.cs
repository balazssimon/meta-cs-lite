using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace MetaDslx.Modeling
{
    internal class SingleSlot : Slot
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Box? _box;

        public SingleSlot(ModelObject owner, ModelPropertySlot property)
            : base(owner, property)
        {
        }

        public Box? Box => _box;

        public override object? Get()
        {
            return _box;
        }

        public override void Add(Box? box)
        {
            _box = box;
        }

        public override void Remove(Box? box)
        {
            if (_box == box) _box = null;
        }
    }
}
