using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.CodeAnalysis.Symbols.CSharp
{
    internal class CSharpNamedTypeSymbol : NamedTypeSymbol
    {
        private Symbol _containingSymbol;
        private INamedTypeSymbol _csharpSymbol;

        public CSharpNamedTypeSymbol(Symbol containingSymbol, INamedTypeSymbol csharpSymbol)
        {
            _containingSymbol = containingSymbol;
            _csharpSymbol = csharpSymbol;
        }

        public INamedTypeSymbol CSharpSymbol => _csharpSymbol;
        public override Symbol? ContainingSymbol => _containingSymbol;
        public override ImmutableArray<Location> Locations => ImmutableArray<Location>.Empty;
        public override ImmutableArray<SyntaxNodeOrToken> DeclaringSyntax => ImmutableArray<SyntaxNodeOrToken>.Empty;
    }
}
