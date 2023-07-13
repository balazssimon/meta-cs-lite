// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using Roslyn.Utilities;

namespace MetaDslx.CodeAnalysis
{
    /// <summary>
    /// Reference to another C# or VB compilation.
    /// </summary>
    internal sealed class CompilationReference : MetadataReference, IEquatable<CompilationReference>
    {
        private Compilation _compilation;

        internal CompilationReference(Compilation compilation, MetadataReferenceProperties properties)
            : base(properties)
        {
            _compilation = compilation;
        }

        protected override MetadataReference WithPropertiesCore(MetadataReferenceProperties properties)
        {
            return new CompilationReference(_compilation, properties);
        }

        public bool Equals(CompilationReference? other)
        {
            if (other == null)
            {
                return false;
            }

            if (object.ReferenceEquals(this, other))
            {
                return true;
            }

            // MetadataProperty implements value equality
            return object.Equals(this._compilation, other._compilation) && object.Equals(this.Properties, other.Properties);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as CompilationReference);
        }

        public override int GetHashCode()
        {
            return Hash.Combine(this._compilation.GetHashCode(), this.Properties.GetHashCode());
        }
    }
}
