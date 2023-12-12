using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace MetaDslx.Modeling
{
    public class Box
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly ISlot _slot;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private object? _value;

        public Box(ISlot slot, object? value)
        {
            _slot = slot;
            _value = value;
        }

        public ISlot Slot => _slot;
        public object? Value
        {
            get => _value;
            set => _value = value;
        }
    }
}
