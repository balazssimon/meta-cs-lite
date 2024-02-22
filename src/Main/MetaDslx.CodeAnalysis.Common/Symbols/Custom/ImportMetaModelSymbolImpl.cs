using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Threading;
using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.Symbols;

namespace MetaDslx.CodeAnalysis.Symbols.Impl
{
    using __Model = MetaDslx.Modeling.Model;
    using __IModelObject = MetaDslx.Modeling.IModelObject;
    using __ISymbol = Microsoft.CodeAnalysis.ISymbol;

    public class ImportMetaModelSymbolImpl : ImportMetaModelSymbol
    {
        public ImportMetaModelSymbolImpl(Symbol? container, Compilation? compilation = null, MergedDeclaration? declaration = null, __Model? model = null, __IModelObject? modelObject = null, __ISymbol csharpSymbol = null, ErrorSymbolInfo? errorInfo = null, bool fixedSymbol = false, string? name = default, string? metadataName = default, global::System.Collections.Immutable.ImmutableArray<AttributeSymbol> attributes = default, global::MetaDslx.CodeAnalysis.MetaSymbol metaModelSymbols = default, global::System.Collections.Immutable.ImmutableArray<string> files = default, global::System.Collections.Immutable.ImmutableArray<AliasSymbol> aliases = default, global::System.Collections.Immutable.ImmutableArray<NamespaceSymbol> namespaces = default, global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> symbols = default) 
            : base(container, compilation, declaration, model, modelObject, csharpSymbol, errorInfo, fixedSymbol, name, metadataName, attributes, files: files, aliases: aliases, namespaces: namespaces, symbols: symbols)
        {
        }

        protected override ImmutableArray<Modeling.MetaModel> Compute_MetaModels(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
