using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis.Symbols
{
    /// <summary>
    /// Allows for the comparison of two <see cref="Symbol"/> instances
    /// </summary>
    public class TypeEqualityComparer : IEqualityComparer<TypeSymbol?>
    {
        /// <summary>
        /// Compares two <see cref="TypeSymbol"/> instances based on the default comparison rules, equivalent to calling <see cref="IEquatable{TypeSymbol}.Equals(TypeSymbol)"/>
        /// </summary>
        public static readonly TypeEqualityComparer Default = new TypeEqualityComparer();
        public static readonly TypeEqualityComparer ConsiderEverything = new TypeEqualityComparer();
        public static readonly TypeEqualityComparer CLRSignature = new TypeEqualityComparer(ignoreDynamic: true, ignoreNullability: true, ignoreCustomModifiers: false);

        private bool _ignoreDynamic;
        private bool _ignoreNullability;
        private bool _ignoreCustomModifiers;

        protected TypeEqualityComparer(bool ignoreDynamic = false, bool ignoreNullability = false, bool ignoreCustomModifiers = false)
        {
            _ignoreDynamic = ignoreDynamic;
            _ignoreNullability = ignoreNullability;
            _ignoreCustomModifiers = ignoreCustomModifiers;
        }

        public bool IgnoreDynamic => _ignoreDynamic;
        public bool IgnoreNullability => _ignoreNullability;
        public bool IgnoreCustomModifiers => _ignoreCustomModifiers;

        /// <summary>
        /// Determines if two <see cref="Symbol" /> instances are equal according to the rules of this comparer
        /// </summary>
        /// <param name="x">The first symbol to compare</param>
        /// <param name="y">The second symbol to compare</param>
        /// <returns>True if the symbols are equivalent</returns>
        public virtual bool Equals(TypeSymbol? x, TypeSymbol? y)
        {
            return object.ReferenceEquals(x, y);
        }

        public virtual int GetHashCode(TypeSymbol? obj)
        {
            return obj?.GetHashCode() ?? 0;
        }
    }
}
