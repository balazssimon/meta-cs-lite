using System;
using System.Collections;
using System.Text;

namespace MetaDslx.Modeling
{
    public interface IModelCollection : IEnumerable
    {
        void Add(object? item);
        void Remove(object? item);
        bool Contains(object? item);
        int Count { get; }
        object? SingleItem { get; set; }
    }
}
