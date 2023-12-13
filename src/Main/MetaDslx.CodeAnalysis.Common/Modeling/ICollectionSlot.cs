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

        void Clear();
        int Count { get; }
        int IndexOf(object? item);
        int LastIndexOf(object? item);

        object? this[int index] { get; set; }

        Box BoxAt(int index);
        Box BoxOf(object? item);
        ImmutableArray<Box> AllBoxesOf(object? item);

        Box Add(object? item);
        ImmutableArray<Box> AddRange(IEnumerable item);
        Box Insert(int index, object? item);
        ImmutableArray<Box> InsertRange(int index, IEnumerable item);
        Box Remove(object? item);
        Box RemoveAt(int index);
        ImmutableArray<Box> RemoveRange(int index, int count);
        ImmutableArray<Box> RemoveRange(IEnumerable item);
        ImmutableArray<Box> RetainRange(IEnumerable item);
        void Reverse();
    }

    public interface ICollectionSlot<T> : ICollectionSlot, IEnumerable<T>
    {
        new T this[int index] { get; set; }
        bool Contains(T item);
        int IndexOf(T item);
        int LastIndexOf(T item);
        Box BoxOf(T item);
        ImmutableArray<Box> AllBoxesOf(T item);
        Box Add(T item);
        ImmutableArray<Box> AddRange(IEnumerable<T> item);
        Box Insert(int index, T item);
        ImmutableArray<Box> InsertRange(int index, IEnumerable<T> item);
        Box Remove(T item);
        ImmutableArray<Box> RemoveRange(IEnumerable<T> item);
        ImmutableArray<Box> RetainRange(IEnumerable<T> item);
    }
}
