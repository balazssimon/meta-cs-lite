using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.CodeAnalysis.Declarations
{
    public abstract class Declaration
    {
        public abstract string? Name { get; }
        public abstract string? MetadataName { get; }
        public abstract Type ModelObjectType { get; }
    }
}
