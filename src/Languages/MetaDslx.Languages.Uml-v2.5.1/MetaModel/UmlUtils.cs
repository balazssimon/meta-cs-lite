using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.Languages.Uml.MetaModel
{
    internal static class UmlUtils
    {
        public static List<T> UnionWith<T>(this List<T> list, IEnumerable<T> items)
        {
            foreach (var item in items)
            {
                if (!list.Contains(item)) list.Add(item);
            }
            return list;
        }

        public static List<T> Include<T>(this List<T> list, T item)
        {
            if (!list.Contains(item)) list.Add(item);
            return list;
        }

        public static List<T> AsListSet<T>(this IEnumerable<T> items)
        {
            var result = new List<T>();
            result.UnionWith(items);
            return result;
        }

        public static IEnumerable<T> AllInstances<T>(this object mobj)
        {
            var model = (IModelObject)mobj;
            return model.Objects.OfType<T>();
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
