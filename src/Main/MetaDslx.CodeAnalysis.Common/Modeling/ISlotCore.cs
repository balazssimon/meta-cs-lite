using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.Modeling
{
    public interface ISlotCore
    {
        void AddCore(object? item, Box? oppositeBox);
        void RemoveCore(object? item, Box? oppositeBox);
        //ImmutableArray<Box> AddRange(IEnumerable<object?> items, ImmutableArray<Box> oppositeBoxes);
        //ImmutableArray<Box> RemoveRange(IEnumerable<object?> items, ImmutableArray<Box> oppositeBoxes);
    }
}
