using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis.Symbols.Source
{
    public class SourceNamespaceSymbol : NamespaceSymbol
    {
        private readonly SourceModuleSymbol _module;
        private readonly MergedDeclaration _declaration;

        public SourceNamespaceSymbol(SourceModuleSymbol module, Symbol containingSymbol, MergedDeclaration declaration, IModelObject? modelObject)
        {
            _module = module;
            _declaration = declaration;
        }

        public SourceModuleSymbol ModuleSymbol => _module;

        public MergedDeclaration Declaration => _declaration;
    }
}
