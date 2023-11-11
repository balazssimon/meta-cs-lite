using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.Modeling
{
    public interface IModelCollection : IEnumerable
    {
        void Add(object? item);
        void Remove(object? item);
        bool Contains(object? item);
        void Clear();
        int Count { get; }
        bool IsReadOnly { get; }
        bool IsNonUnique { get; }
        bool IsNullable { get; }
        bool IsSingleItem { get; }
        object? SingleItem { get; set; }
        IList<TTo> CastTo<TTo>();
    }
}
