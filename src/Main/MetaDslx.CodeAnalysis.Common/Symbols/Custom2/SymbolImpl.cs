using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.Modeling;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.CodeAnalysis.Symbols.Impl
{
    public class SymbolImpl : Symbol
    {
        public SymbolImpl(Symbol? container, Compilation? compilation = null, MergedDeclaration? declaration = null, Modeling.Model? model = null, IModelObject? modelObject = null, ISymbol csharpSymbol = null, ErrorSymbolInfo? errorInfo = null, bool fixedSymbol = false, string? name = null, string? metadataName = null, ImmutableArray<AttributeSymbol> attributes = default) 
            : base(container, compilation, declaration, model, modelObject, csharpSymbol, errorInfo, fixedSymbol, name, metadataName, attributes)
        {
        }
    }
}
