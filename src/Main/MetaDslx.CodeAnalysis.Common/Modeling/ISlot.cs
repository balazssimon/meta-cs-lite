using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.Modeling
{
    public interface ISlot
    {
        IModelObject Owner { get; }
        ModelPropertySlot Property { get; }
        bool IsSingle { get; }
        bool IsCollection { get; }
        bool IsMap { get; }
        bool IsReadOnly { get; }
        bool IsNullable { get; }

        bool IsDefault { get; }
        bool Contains(object? item);
        Box Add(object? item, Box? oppositeBox = null);
        Box Remove(object? item, Box? oppositeBox = null);

        ISingleSlot? AsSingle();
        ISingleSlot<T>? AsSingle<T>();
        ICollectionSlot? AsCollection();
        ICollectionSlot<T>? AsCollection<T>();
        IMapSlot? AsMap();
        IMapSlot<TKey, TValue>? AsMap<TKey, TValue>();
    }

}
