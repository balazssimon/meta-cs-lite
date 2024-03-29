﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.Modeling
{
    public interface IMapSlot : ISlot
    {
        bool IsUnordered { get; }
        bool IsNonUnique { get; }

        int Count { get; }
        void Clear();

        bool ContainsKey(object? key);
        IEnumerable Keys { get; }
        object? this[object? key] { get; }
        void Add(object? key, object? value);
        void Remove(object? key);
        bool TryGetValue(object? key, out object? value);
        bool TryGetKeyBox(object? key, out Box? keyBox);
        bool TryGetValueBox(object? key, out Box? valueBox);
    }

    public interface IMapSlot<TKey,TValue> : IMapSlot
    {
        bool ContainsKey(TKey key);
        new IEnumerable<TKey> Keys { get; }
        TValue this[TKey key] { get; }
        void Add(TKey key, TValue value);
        void Remove(TKey key);
        bool TryGetValue(TKey key, out TValue? value);
        bool TryGetKeyBox(TKey key, out Box? keyBox);
        bool TryGetValueBox(TKey key, out Box? valueBox);
    }
}
