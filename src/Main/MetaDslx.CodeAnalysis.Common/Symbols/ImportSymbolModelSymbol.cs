using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.CodeAnalysis.Symbols.CSharp;
//using MetaDslx.CodeAnalysis.Symbols.MetaModelImport;
using MetaDslx.CodeAnalysis.Symbols.Source;
using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Symbols
{
    public class ImportSymbolModelSymbol : SourceImportSymbol
    {
        private ImmutableArray<MetaModel> _metaModels;

        public ImportSymbolModelSymbol(Symbol container, MergedDeclaration declaration)
            : base(container, declaration)
        {
        }

        public ImmutableArray<MetaModel> MetaModels
        {
            get
            {
                ForceComplete(CompletionParts.FinishComputingImports, null, default);
                return _metaModels;
            }
        }

        protected override (ImmutableArray<string> files, ImmutableArray<AliasSymbol> aliases, ImmutableArray<NamespaceSymbol> namespaces, ImmutableArray<DeclaredSymbol> symbols) ComputeImports(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            var namespaces = SymbolFactory.GetSymbolPropertyValues<NamespaceSymbol>(this, nameof(Namespaces), diagnostics, cancellationToken);
            var compilation = DeclaringCompilation;
            var symbolsBuilder = ArrayBuilder<DeclaredSymbol>.GetInstance();
            var metaModelsBuilder = ArrayBuilder<MetaModel>.GetInstance();
            /*foreach (var symbolNamespace in namespaces.Where(ns => !ns.IsError))
            {
                var metaModel = new ImportedMetaModel(symbolNamespace, symbolNamespace.Name, true);
                metaModelsBuilder.Add(metaModel);
                symbolsBuilder.AddRange(ImportedMetaUtils.CollectTypes(symbolNamespace, collectSymbols: true));
            }*/
            _metaModels = metaModelsBuilder.ToImmutableAndFree();
            return (ImmutableArray<string>.Empty, ImmutableArray<AliasSymbol>.Empty, ImmutableArray<NamespaceSymbol>.Empty, symbolsBuilder.ToImmutableAndFree());
        }

    }
}
