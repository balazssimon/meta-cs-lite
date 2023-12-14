using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.Modeling
{
    public interface ICollectionSlot : ISlot, IEnumerable
    {
        bool IsUnordered { get; }
        bool IsNonUnique { get; }

        int Count { get; }
        int IndexOf(object? item);
        int LastIndexOf(object? item);

        object? this[int index] { get; set; }

        Box BoxAt(int index);
        Box? BoxOf(object? item);
        ImmutableArray<Box> AllBoxesOf(object? item);

        ImmutableArray<Box> AddRange(IEnumerable items);
        Box? Insert(int index, object? item);
        ImmutableArray<Box> InsertRange(int index, IEnumerable items);
        ImmutableArray<Box> RemoveAll(object? item);
        Box? RemoveAt(int index);
        ImmutableArray<Box> RemoveRange(int index, int count);
        ImmutableArray<Box> RemoveRange(IEnumerable items);
        ImmutableArray<Box> RetainRange(IEnumerable items);
        void Reverse();
    }

    public interface ICollectionSlot<T> : ICollectionSlot, IList<T>
    {
        new T this[int index] { get; set; }
        new int Count { get; }
        new bool Contains(T item);
        new int IndexOf(T item);
        int LastIndexOf(T item);
        Box? BoxOf(T item);
        ImmutableArray<Box> AllBoxesOf(T item);
        new Box? Add(T item);
        ImmutableArray<Box> AddRange(IEnumerable<T> items);
        new Box? Insert(int index, T item);
        ImmutableArray<Box> InsertRange(int index, IEnumerable<T> items);
        new Box? Remove(T item);
        ImmutableArray<Box> RemoveAll(T item);
        ImmutableArray<Box> RemoveRange(IEnumerable<T> items);
        ImmutableArray<Box> RetainRange(IEnumerable<T> items);
    }
}
