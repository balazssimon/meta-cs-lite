using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Text;

namespace MetaDslx.Modeling
{
    public class MapSlot : Slot
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Dictionary<Box, Box> _items;

        public MapSlot(ModelObject owner, ModelPropertySlot property)
            : base(owner, property)
        {
            _items = new Dictionary<Box, Box>();
        }

        public Dictionary<Box, Box> Items => _items;
        public Func<IModelObject, object>? KeySelector => Property.MapKeySelector;

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
