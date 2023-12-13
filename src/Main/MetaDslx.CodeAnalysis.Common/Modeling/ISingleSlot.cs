using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.Modeling
{
    public interface ISingleSlot : ISlot
    {
        void Clear();
        object? Get();
        Box GetBox();
        Box Init(object? value);
        Box Set(object? value);
    }

    public interface ISingleSlot<T> : ISingleSlot
    {
        new T Get();
        Box Set(T value);
    }
}
