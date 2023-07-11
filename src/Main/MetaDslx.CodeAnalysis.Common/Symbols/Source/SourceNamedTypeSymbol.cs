using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
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

        public Symbol ContainingSymbol => _containingSymbol;

        public MergedDeclaration Declaration => _declaration;
    }
}
