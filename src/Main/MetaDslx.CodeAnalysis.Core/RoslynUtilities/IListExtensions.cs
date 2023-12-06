using System;
using System.Collections.Generic;
using System.Text;

namespace Roslyn.Utilities
{
    public static class IListExtensions
    {
        public static void AddRange<T>(this IList<T> list, IEnumerable<T> items)
        {
            foreach (var item in items)
            {
                list.Add(item);
            }
        }

        public static void InsertRangeAt<T>(this IList<T> list, int index, IEnumerable<T> items)
        {
            var i = index;
            foreach (var item in items)
            {
                list.Insert(i, item);
                ++i;
            }
        }
    }
}
