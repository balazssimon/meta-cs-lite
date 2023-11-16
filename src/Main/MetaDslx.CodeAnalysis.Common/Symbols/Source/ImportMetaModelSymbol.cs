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
    public class ImportMetaModelSymbol : SourceImportSymbol
    {
        private ImmutableArray<MetaModel> _metaModels;

        public ImportMetaModelSymbol(Symbol container, MergedDeclaration declaration)
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
            var metaModelSymbols = SymbolFactory.GetSymbolPropertyValues<DeclaredSymbol>(this, nameof(Symbols), diagnostics, cancellationToken);
            var compilation = DeclaringCompilation;
            var symbolsBuilder = ArrayBuilder<DeclaredSymbol>.GetInstance();
            var metaModelsBuilder = ArrayBuilder<MetaModel>.GetInstance();
            foreach (var metaModelSymbol in metaModelSymbols)
            {
                var fullName = SymbolDisplayFormat.QualifiedNameOnlyFormat.ToString(metaModelSymbol);
                MetaModel? metaModel = null;
                if (compilation is not null)
                {
                    foreach (var mmRef in compilation.ExternalReferences.OfType<MetaModelReference>())
                    {
                        if (mmRef.MetaModel.MFullName == fullName)
                        {
                            metaModel = mmRef.MetaModel;
                            break;
                        }
                    }
                }
                if (metaModel is null && !metaModelSymbol.IsError && metaModelSymbol is CSharpTypeSymbol csharpTypeSymbol)
                {
                    var csharpNamespaceSymbol = csharpTypeSymbol.ContainingNamespace as CSharpNamespaceSymbol;
                    if (csharpNamespaceSymbol is not null)
                    {
                        metaModel = new SymbolMetaModel(csharpNamespaceSymbol, metaModelSymbol.Name, false);
                    }
                }
                if (metaModel is not null)
                {
                    metaModelsBuilder.Add(metaModel);
                    foreach (var type in metaModel.MEnumTypes)
                    {
                        symbolsBuilder.Add(new MetaEnumSymbol(metaModelSymbol, metaModel, type));
                    }
                    foreach (var type in metaModel.MClassTypes)
                    {
                        symbolsBuilder.Add(new MetaClassSymbol(metaModelSymbol, metaModel, type));
                    }
                }
                else
                {
                    diagnostics.Add(Diagnostic.Create(CommonErrorCode.ERR_DeclarationError, this.Locations.FirstOrDefault(), $"The imported type '{fullName}' is not a metamodel."));
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
