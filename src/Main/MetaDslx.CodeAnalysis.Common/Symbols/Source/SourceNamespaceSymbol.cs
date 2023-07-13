using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.CodeAnalysis.Symbols.Source
{
    public class SourceNamespaceSymbol : NamespaceSymbol
    {
        private readonly SourceModuleSymbol _module;
        private readonly Symbol _containingSymbol;
        private readonly MergedDeclaration _declaration;

        public SourceNamespaceSymbol(SourceModuleSymbol module, Symbol containingSymbol, MergedDeclaration declaration, IModelObject? modelObject)
        {
            _module = module;
            _declaration = declaration;
            _containingSymbol = containingSymbol;
        }

        public SourceModuleSymbol ModuleSymbol => _module;
        public override Symbol? ContainingSymbol => _containingSymbol;
        public MergedDeclaration Declaration => _declaration;
        public override ImmutableArray<Location> Locations => _declaration.NameLocations;
        public override ImmutableArray<SyntaxNodeOrToken> DeclaringSyntax => _declaration.SyntaxReferences;
    }
}
