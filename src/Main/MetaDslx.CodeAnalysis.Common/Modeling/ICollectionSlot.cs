using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.Modeling
{
    public interface ICollectionSlot : IEnumerable
    {
        bool IsReadOnly { get; }
        bool IsUnordered { get; }
        bool IsNonUnique { get; }
        bool IsNullable { get; }

        void Clear();
        int Count { get; }
        bool Contains(object? item);
        int IndexOf(object? item);

        object? this[int index] { get; set; }

        ImmutableArray<Box> BoxOf(object? item);
        Box BoxAt(int index);

        Box? Add(object? item);
        ImmutableArray<Box?> AddRange(IEnumerable item);
        Box? Remove(object? item);
        ImmutableArray<Box?> RemoveRange(IEnumerable item);
        Box? Insert(int index, object? item);
        ImmutableArray<Box?> InsertRange(int index, IEnumerable item);
        Box? RemoveAt(int index);
        ImmutableArray<Box?> RemoveRange(int index, int count);

        ICollectionSlot<TTo> CastTo<TTo>();
    }

    public interface ICollectionSlot<T> : ICollectionSlot, IEnumerable<T>
    {
        new T this[int index] { get; set; }
        bool Contains(T item);
        int IndexOf(T item);
        Box? Add(T item);
        ImmutableArray<Box?> AddRange(IEnumerable<T> item);
        Box? Remove(T item);
        ImmutableArray<Box?> RemoveRange(IEnumerable<T> item);
        Box? Insert(int index, T item);
        ImmutableArray<Box?> InsertRange(int index, IEnumerable<T> item);
    }
}
