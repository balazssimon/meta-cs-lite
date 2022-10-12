using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.Languages.Uml.MetaModel
{
    internal static class UmlUtils
    {
        public static IList<T> DistinctList<T>(this IEnumerable<T> items)
        {
            var result = new List<T>();
            foreach (var item in items)
            {
                if (!result.Contains(item)) result.Add(item);
            }
            return result;
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
