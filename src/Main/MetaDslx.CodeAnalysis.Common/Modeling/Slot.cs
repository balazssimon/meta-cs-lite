using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace MetaDslx.Modeling
{
    public abstract class Slot : ISlot
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly ModelObject _owner;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly ModelPropertySlot _property;

        public Slot(ModelObject owner, ModelPropertySlot property)
        {
            _owner = owner;
            _property = property;
        }

        public ModelObject Owner => _owner;
        public ModelPropertySlot Property => _property;

    }
}
