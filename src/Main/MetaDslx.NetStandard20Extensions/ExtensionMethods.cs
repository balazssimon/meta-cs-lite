using System;
using System.Collections.Generic;
using System.Text;

namespace System.Text
{
    internal static class SystemTextExtensionMethods
    {
#if NETSTANDARD2_0
        public static void Append(this StringBuilder builder, ReadOnlySpan<char> value)
        {
            builder.Append(value.ToArray());
        }
#endif

    }
}
