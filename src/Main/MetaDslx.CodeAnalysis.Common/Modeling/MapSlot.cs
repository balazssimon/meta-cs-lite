using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Text;

namespace MetaDslx.Modeling
{
    /*internal class MapSlot : Slot, IMapSlot
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Dictionary<Box, Box> _items;

        public MapSlot(IModelObject owner, ModelPropertySlot property)
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
    }*/
}
