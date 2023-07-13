using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.CodeAnalysis.Symbols.CSharp
{
    internal class CSharpNamespaceSymbol : NamespaceSymbol
    {
        private Symbol _containingSymbol;
        private INamespaceSymbol _csharpSymbol;

        public CSharpNamespaceSymbol(Symbol containingSymbol, INamespaceSymbol csharpSymbol)
        {
            _containingSymbol = containingSymbol;
            _csharpSymbol = csharpSymbol;
        }

        public INamespaceSymbol CSharpSymbol => _csharpSymbol;
        public override Symbol? ContainingSymbol => _containingSymbol;
        public override ImmutableArray<Location> Locations => ImmutableArray<Location>.Empty;
        public override ImmutableArray<SyntaxNodeOrToken> DeclaringSyntax => ImmutableArray<SyntaxNodeOrToken>.Empty;

    }
}
