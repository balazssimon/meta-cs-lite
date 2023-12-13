using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.Modeling
{
    public interface IMultiMapSlot : ISlot
    {
        bool IsUnordered { get; }
        bool IsNonUnique { get; }

        int Count { get; }

        bool ContainsKey(object? key);
        IEnumerable Keys { get; }
        ICollectionSlot this[object? key] { get; }
        Box Add(object? key, object? value);
        Box Remove(object? key);
        Box Remove(object? key, object? value);
        bool TryGetValues(object? key, out ICollectionSlot? values);
        bool TryGetKeyBox(object? key, out Box? keyBox);
    }

    public interface IMultiMapSlot<TKey, TValue> : IMapSlot
    {
        bool ContainsKey(TKey key);
        new IEnumerable<TKey> Keys { get; }
        TValue this[TKey key] { get; }
        Box Add(TKey key, TValue value);
        Box Remove(TKey key);
        Box Remove(TKey key, TValue value);
        bool TryGetValues(TKey key, out ICollectionSlot<TValue>? value);
        bool TryGetKeyBox(TKey key, out Box? keyBox);
    }
}
