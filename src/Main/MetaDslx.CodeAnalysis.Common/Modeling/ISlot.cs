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
        IEnumerable<Box> Boxes { get; }
    }

    public static class SlotExtensions
    {
        public static ISingleSlot? AsSingle(this ISlot slot)
        {
            return slot as ISingleSlot;
        }

        public static ISingleSlot<T>? AsSingle<T>(this ISlot slot)
        {
            if (slot is ISingleSlot<T> typedSlot) return typedSlot;
            var untypedSlot = slot.AsSingle();
            return untypedSlot is not null ? new SingleSlot<T>(untypedSlot) : null;
        }

        public static ICollectionSlot? AsCollection(this ISlot slot)
        {
            return slot as ICollectionSlot;
        }

        public static ICollectionSlot<T>? AsCollection<T>(this ISlot slot)
        {
            if (slot is ICollectionSlot<T> typedSlot) return typedSlot;
            var untypedSlot = slot.AsCollection();
            return untypedSlot is not null ? new CollectionSlot<T>(untypedSlot) : null;
        }

        public static IMapSlot? AsMap(this ISlot slot)
        {
            return slot as IMapSlot;
        }
        /*
        public static IMapSlot<TKey, TValue>? AsMap<TKey, TValue>(this ISlot slot)
        {
            if (slot is IMapSlot<TKey, TValue> typedSlot) return typedSlot;
            var untypedSlot = slot.AsMap();
            return untypedSlot is not null ? new MapSlot<TKey, TValue>(untypedSlot) : null;
        }

        public static IMultiMapSlot? AsMultiMap(this ISlot slot)
        {
            return slot as IMultiMapSlot;
        }

        public static IMultiMapSlot<TKey, TValue>? AsMultiMap<TKey, TValue>(this ISlot slot)
        {
            if (slot is IMultiMapSlot<TKey, TValue> typedSlot) return typedSlot;
            var untypedSlot = slot.AsMultiMap();
            return untypedSlot is not null ? new MultiMapSlot<TKey, TValue>(untypedSlot) : null;
        }*/

    }
}
