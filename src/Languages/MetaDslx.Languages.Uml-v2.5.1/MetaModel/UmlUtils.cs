using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;

namespace MetaDslx.Languages.Uml.MetaModel
{
    internal static class UmlUtils
    {
        public static List<T> UnionWith<T>(this List<T> list, IEnumerable<T?> items)
        {
            foreach (var item in items)
            {
                if (item is not null && !list.Contains(item)) list.Add(item);
            }
            return list;
        }

        public static List<T> Include<T>(this List<T> list, T? item)
        {
            if (item is not null && !list.Contains(item)) list.Add(item);
            return list;
        }

        public static List<T> AsListSet<T>(this IEnumerable<T?> items)
        {
            var result = new List<T>();
            result.UnionWith(items);
            return result;
        }

        public static List<T> SingleItemList<T>(T? item)
        {
            var result = new List<T>();
            if (item is not null) result.Add(item);
            return result;
        }

        public static List<T> EmptyList<T>()
        {
            var result = new List<T>();
            return result;
        }

        public static IEnumerable<T> AllInstances<T>(this object mobj)
        {
            var model = ((IModelObject)mobj).Model;
            return model?.Objects.OfType<T>() ?? ImmutableArray<T>.Empty;
        }

        /*public static IList<TOutput> CollectItemsOfType<TObject, TInput, TOutput>(this TObject obj, IList<TInput> items)
        {
            var result = new List<TOutput>();
            foreach (var item in items)
            {
                if (!result.Contains(item)) result.Add(item);
            }
            return result;
        }*/
    }
}
