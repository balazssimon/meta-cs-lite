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

    public interface ISingleSlot<T> : ISingleSlot
    {
        new T Value { get; set; }
    }
}
