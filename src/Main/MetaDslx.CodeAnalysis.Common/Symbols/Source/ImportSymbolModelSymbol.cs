using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.CodeAnalysis.Symbols.CSharp;
using MetaDslx.CodeAnalysis.Symbols.Meta;
using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Symbols.Source
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
            foreach (var symbolNamespace in namespaces.Where(ns => !ns.IsError))
            {
                var metaModel = new SymbolMetaModel(symbolNamespace, symbolNamespace.Name, true);
                metaModelsBuilder.Add(metaModel);
                foreach (var type in metaModel.MEnumTypes)
                {
                    symbolsBuilder.Add(new MetaEnumSymbol(symbolNamespace, metaModel, type));
                }
                foreach (var type in metaModel.MClassTypes)
                {
                    symbolsBuilder.Add(new MetaClassSymbol(symbolNamespace, metaModel, type));
                }
            }
            _metaModels = metaModelsBuilder.ToImmutableAndFree();
            return (ImmutableArray<string>.Empty, ImmutableArray<AliasSymbol>.Empty, ImmutableArray<NamespaceSymbol>.Empty, symbolsBuilder.ToImmutableAndFree());
        }

        protected override void CompletePart_Validate(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            var unusedSymbols = UnusedSymbols;
            if (!unusedSymbols.IsEmpty)
            {
                var builder = PooledStringBuilder.GetInstance();
                var sb = builder.Builder;
                foreach (var metaModel in _metaModels)
                {
                    sb.Clear();
                    foreach (var symbol in unusedSymbols.OfType<MetaTypeSymbol>().Where(us => us.MetaModel == metaModel).OrderBy(us => us.Name))
                    {
                        if (sb.Length > 0) sb.Append(", ");
                        sb.Append(symbol.Name);
                    }
                    if (sb.Length > 0) diagnostics.Add(Diagnostic.Create(CommonErrorCode.WRN_UnusedMetaTypes, this.Locations.FirstOrDefault(), metaModel.MName, builder.ToString()));
                }
                builder.Free();
            }
        }

    }
}
