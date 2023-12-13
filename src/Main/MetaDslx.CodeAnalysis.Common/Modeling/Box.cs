using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace MetaDslx.Modeling
{
    public class Box
    {
        private static readonly object DefaultValue = new object();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly ISlot _slot;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private object? _value;

        public Box(ISlot slot)
        {
            _slot = slot;
            _value = DefaultValue;
        }

        public ISlot Slot => _slot;
        public IModelObject Owner => _slot.Owner;
        public ModelPropertySlot Property => _slot.Property;

        public bool IsDefault => _value == DefaultValue;

        public object? Value
        {
            get => IsDefault ? _slot.Property.DefaultValue : _value;
            internal set => _value = value;
        }

        internal void Clear()
        {
            _value = DefaultValue;
        }
    }
}
