using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.Modeling;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.CodeAnalysis.Symbols.Implementation
{
    public class SymbolImpl : Symbol
    {
        public SymbolImpl(Symbol? container, Compilation? compilation = null, MergedDeclaration? declaration = null, IModelObject? modelObject = null, ISymbol csharpSymbol = null, ErrorSymbolInfo? errorInfo = null) 
            : base(container, compilation, declaration, modelObject, csharpSymbol, errorInfo)
        {
        }
    }
}
