// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;

namespace MetaDslx.CodeAnalysis.Symbols
{
    /// <summary>
    /// Allows for the comparison of two <see cref="Symbol"/> instances
    /// </summary>
    public class SymbolEqualityComparer : IEqualityComparer<Symbol?>
    {
        /// <summary>
        /// Compares two <see cref="Symbol"/> instances based on the default comparison rules, equivalent to calling <see cref="IEquatable{Symbol}.Equals(Symbol)"/>
        /// </summary>
        public static readonly SymbolEqualityComparer Default = new SymbolEqualityComparer();

        protected SymbolEqualityComparer()
        {
        }

        /// <summary>
        /// Determines if two <see cref="Symbol" /> instances are equal according to the rules of this comparer
        /// </summary>
        /// <param name="x">The first symbol to compare</param>
        /// <param name="y">The second symbol to compare</param>
        /// <returns>True if the symbols are equivalent</returns>
        public virtual bool Equals(Symbol? x, Symbol? y)
        {
            return object.ReferenceEquals(x, y);
        }

        public virtual int GetHashCode(Symbol? obj)
        {
            return obj?.GetHashCode() ?? 0;
        }
    }
}
