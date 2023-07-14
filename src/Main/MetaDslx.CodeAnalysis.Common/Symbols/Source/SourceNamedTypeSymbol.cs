using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.CodeAnalysis.Symbols.Source
{
    public class SourceNamedTypeSymbol : NamedTypeSymbol
    {
        private readonly Symbol _containingSymbol;
        private readonly MergedDeclaration _declaration;

        public SourceNamedTypeSymbol(Symbol containingSymbol, MergedDeclaration declaration, IModelObject? modelObject)
        {
            _containingSymbol = containingSymbol;
            _declaration = declaration;
        }

        public override Symbol ContainingSymbol => _containingSymbol;
        public MergedDeclaration Declaration => _declaration;
        public override ImmutableArray<Location> Locations => _declaration.NameLocations;
        public override ImmutableArray<SyntaxNodeOrToken> DeclaringSyntaxReferences => _declaration.SyntaxReferences;
    }
}
