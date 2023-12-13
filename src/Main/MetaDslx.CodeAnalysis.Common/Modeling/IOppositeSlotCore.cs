using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.Modeling
{
    public interface IOppositeSlotCore
    {
        Box? AddCore(object? item, Box? oppositeBox);
        Box? RemoveCore(object? item, Box? oppositeBox);
        //ImmutableArray<Box> AddRange(IEnumerable<object?> items, ImmutableArray<Box> oppositeBoxes);
        //ImmutableArray<Box> RemoveRange(IEnumerable<object?> items, ImmutableArray<Box> oppositeBoxes);
    }
}
