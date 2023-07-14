using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.CodeAnalysis.Symbols.CSharp
{
    internal class CSharpMemberSymbol : MemberSymbol
    {
        private Symbol _containingSymbol;
        private ISymbol _csharpSymbol;

        public CSharpMemberSymbol(Symbol containingSymbol, ISymbol csharpSymbol)
        {
            _containingSymbol = containingSymbol;
            _csharpSymbol = csharpSymbol;
        }

        public ISymbol CSharpSymbol => _csharpSymbol;
        public override Symbol? ContainingSymbol => _containingSymbol;
        public override ImmutableArray<Location> Locations => ImmutableArray<Location>.Empty;
        public override ImmutableArray<SyntaxNodeOrToken> DeclaringSyntaxReferences => ImmutableArray<SyntaxNodeOrToken>.Empty;

    }
}
