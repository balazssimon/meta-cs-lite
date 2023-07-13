// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections.Immutable;
using Roslyn.Utilities;

namespace MetaDslx.CodeAnalysis
{
    /// <summary>
    /// Information about a metadata reference.
    /// </summary>
    public struct MetadataReferenceProperties : IEquatable<MetadataReferenceProperties>
    {
        private readonly ImmutableArray<string> _aliases;

        /// <summary>
        /// Default properties for a reference.
        /// </summary>
        public static MetadataReferenceProperties Default => new MetadataReferenceProperties();

        /// <summary>
        /// Initializes reference properties.
        /// </summary>
        /// <param name="aliases">Assembly aliases. Can't be set for a module.</param>
        public MetadataReferenceProperties(ImmutableArray<string> aliases = default)
        {
            if (!aliases.IsDefaultOrEmpty)
            {
                foreach (var alias in aliases)
                {
                    if (!StringUtilities.IsIdentifier(alias))
                    {
                        throw new ArgumentException("Invalid alias", nameof(aliases));
                    }
                }
            }

            _aliases = aliases;
            HasRecursiveAliases = false;
        }

        internal MetadataReferenceProperties(ImmutableArray<string> aliases, bool hasRecursiveAliases)
            : this(aliases)
        {
            HasRecursiveAliases = hasRecursiveAliases;
        }

        /// <summary>
        /// Returns <see cref="MetadataReferenceProperties"/> with specified aliases.
        /// </summary>
        public MetadataReferenceProperties WithAliases(IEnumerable<string> aliases)
        {
            return WithAliases(aliases.AsImmutableOrEmpty());
        }

        /// <summary>
        /// Returns <see cref="MetadataReferenceProperties"/> with specified aliases.
        /// </summary>
        public MetadataReferenceProperties WithAliases(ImmutableArray<string> aliases)
        {
            return new MetadataReferenceProperties(aliases, HasRecursiveAliases);
        }

        /// <summary>
        /// Returns <see cref="MetadataReferenceProperties"/> with <see cref="HasRecursiveAliases"/> set to specified value.
        /// </summary>
        internal MetadataReferenceProperties WithRecursiveAliases(bool value)
        {
            return new MetadataReferenceProperties(_aliases, value);
        }

        /// <summary>
        /// Alias that represents a global declaration space.
        /// </summary>
        /// <remarks>
        /// Namespaces in references whose <see cref="Aliases"/> contain <see cref="GlobalAlias"/> are available in global declaration space.
        /// </remarks>
        public static string GlobalAlias => "global";

        /// <summary>
        /// Aliases for the metadata reference. Empty if the reference has no aliases.
        /// </summary>
        /// <remarks>
        /// In C# these aliases can be used in "extern alias" syntax to disambiguate type names. 
        /// </remarks>
        public ImmutableArray<string> Aliases
        {
            get
            {
                // Simplify usage - we can't avoid the _aliases field being null but we can always return empty array here:
                return _aliases.NullToEmpty();
            }
        }

        /// <summary>
        /// True to apply <see cref="Aliases"/> recursively on the target assembly and on all its transitive dependencies.
        /// False to apply <see cref="Aliases"/> only on the target assembly.
        /// </summary>
        internal bool HasRecursiveAliases { get; private set; }

        public override bool Equals(object? obj)
        {
            return obj is MetadataReferenceProperties && Equals((MetadataReferenceProperties)obj);
        }

        public bool Equals(MetadataReferenceProperties other)
        {
            return Aliases.SequenceEqual(other.Aliases)
                && HasRecursiveAliases == other.HasRecursiveAliases;
        }

        public override int GetHashCode()
        {
            return Hash.Combine(Hash.CombineValues(Aliases), HasRecursiveAliases.GetHashCode());
        }

        public static bool operator ==(MetadataReferenceProperties left, MetadataReferenceProperties right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(MetadataReferenceProperties left, MetadataReferenceProperties right)
        {
            return !left.Equals(right);
        }
    }

    internal static class MetadataReferencePropertiesExtensions
    {
        public static MetadataReferenceProperties ToMetaDslx(this Microsoft.CodeAnalysis.MetadataReferenceProperties properties)
        {
            return new MetadataReferenceProperties(properties.Aliases);
        }
    }
}
