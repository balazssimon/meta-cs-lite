using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.Modeling
{
    public interface ISingleSlot : ISlot
    {
        Box Box { get; }
        object? Value { get; set; }
        Box? Init(object? value);
    }

    public interface ISingleSlot<T> : ISlot<T>
    {
        Box Box { get; }
        T Value { get; set; }
        Box? Init(T value);
    }
}
