using MetaDslx.Modeling;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.Modeling
{
    public interface ISlot 
    {
        IModelObject Owner { get; }
        ModelPropertySlot Property { get; }
        SlotKind Kind { get; }
        bool IsReadOnly { get; }
        bool IsNullable { get; }

        bool IsDefault { get; }
        void Clear();
        bool Contains(object? item);
        Box? Add(object? item);
        Box? Remove(object? item);
        Box? Replace(object? oldItem, object? newItem);
        IEnumerable<object?> Values { get; }
        IEnumerable<Box> Boxes { get; }

        ISingleSlot? AsSingle();
        ISingleSlot<T>? AsSingle<T>();
        ICollectionSlot? AsCollection();
        ICollectionSlot<T>? AsCollection<T>();
    }

    public interface ISlot<T>
    {
        IModelObject Owner { get; }
        ModelPropertySlot Property { get; }
        SlotKind Kind { get; }
        bool IsReadOnly { get; }
        bool IsNullable { get; }

        bool IsDefault { get; }
        void Clear();
        bool Contains(T item);
        Box? Add(T item);
        Box? Remove(T item);
        Box? Replace(T oldItem, T newItem);
        IEnumerable<T> Values { get; }
        IEnumerable<Box> Boxes { get; }

        ISingleSlot? AsSingle();
        ISingleSlot<TAs>? AsSingle<TAs>();
        ICollectionSlot? AsCollection();
        ICollectionSlot<TAs>? AsCollection<TAs>();
    }
}
