using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.Modeling
{
    public interface ISlot
    {
        IModelObject Owner { get; }
        ModelPropertySlot ModelProperty { get; }
        bool IsSingle { get; }
        bool IsCollection { get; }
        bool IsMap { get; }

        bool IsDefault { get; }
        Box? Add(object? item);
        Box? Remove(object? item);

        ISingleSlot? AsSingle();
        ISingleSlot<T>? AsSingle<T>();
        ICollectionSlot? AsCollection();
        ICollectionSlot<T>? AsCollection<T>();
        IMapSlot? AsMap();
        IMapSlot<TKey, TValue>? AsMap<TKey, TValue>();
    }

}
