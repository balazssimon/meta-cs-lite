// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Diagnostics;
using MetaDslx.CodeAnalysis.Symbols;
using Roslyn.Utilities;

namespace MetaDslx.CodeAnalysis
{
    /// <summary>
    /// A program location in metadata.
    /// </summary>
    internal sealed class MetadataLocation : Location, IEquatable<MetadataLocation?>
    {
        private readonly ModuleSymbol _module;

        internal MetadataLocation(ModuleSymbol module)
        {
            Debug.Assert(module != null);
            _module = module;
        }

        public override LocationKind Kind
        {
            get { return LocationKind.MetadataFile; }
        }

        public ModuleSymbol MetadataModule
        {
            get { return _module; }
        }

        public override int GetHashCode()
        {
            return _module.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as MetadataLocation);
        }

        public bool Equals(MetadataLocation? other)
        {
            return other is object && other._module == _module;
        }
    }
}
