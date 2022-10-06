using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.Modeling
{
    public interface IModelCollection
    {
        void Add(object? item);
        void Remove(object? item);
        bool Contains(object? item);
        int Count { get; }
        object? SingleItem { get; set; }
    }
}
