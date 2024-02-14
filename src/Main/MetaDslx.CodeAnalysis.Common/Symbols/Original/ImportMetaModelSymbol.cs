using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.CodeAnalysis.Symbols.CSharp;
using MetaDslx.CodeAnalysis.Symbols.Model;

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
    public class ImportMetaModelSymbol : SourceImportSymbol
    {
        private ImmutableArray<MetaSymbol> _metaModelSymbols;
        private ImmutableArray<MetaModel> _metaModels;

        public ImportMetaModelSymbol(Symbol container, MergedDeclaration declaration)
            : base(container, declaration)
        {
        }

        public ImmutableArray<MetaSymbol> MetaModelSymbols
        {
            get
            {
                ForceComplete(CompletionParts.FinishComputingImports, null, default);
                return _metaModelSymbols;
            }
        }

        public ImmutableArray<MetaModel> MetaModels
        {
            get
            {
                ForceComplete(CompletionParts.FinishComputingImports, null, default);
                return _metaModels;
            }
        }

        protected override (ImmutableArray<string> files, ImmutableArray<AliasSymbol> aliases, ImmutableArray<NamespaceSymbol> namespaces, ImmutableArray<DeclarationSymbol> symbols) ComputeImports(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            var metaModelSymbols = SymbolFactory.GetSymbolPropertyValues<DeclarationSymbol>(this, nameof(MetaModelSymbols), diagnostics, cancellationToken);
            var compilation = DeclaringCompilation;
            var symbolsBuilder = ArrayBuilder<DeclarationSymbol>.GetInstance();
            var metaModelsBuilder = ArrayBuilder<MetaModel>.GetInstance();
            foreach (var metaModelSymbol in metaModelSymbols)
            {
                var fullName = SymbolDisplayFormat.QualifiedNameOnlyFormat.ToString(metaModelSymbol);
                MetaModel? referencedMetaModel = null;
                ModelModuleSymbol? modelModuleSymbol = null;
                if (compilation is not null)
                {
                    foreach (var mmRef in compilation.ExternalReferences.OfType<MetaModelReference>())
                    {
                        if (mmRef.MetaModel.MFullName == fullName)
                        {
                            referencedMetaModel = mmRef.MetaModel;
                            modelModuleSymbol = compilation.SourceAssembly.Modules.OfType<ModelModuleSymbol>().Where(m => m.Model == referencedMetaModel.MModel).FirstOrDefault();
                            break;
                        }
                    }
                }
                if (modelModuleSymbol is not null)
                {
                    var modelSymbolFactory = modelModuleSymbol.SymbolFactory;
                    metaModelsBuilder.Add(referencedMetaModel);
                    foreach (var type in referencedMetaModel.MModel.Objects.Where(mobj => mobj.MInfo.MetaType.FullName == "MetaDslx.Languages.MetaModel.Model.MetaEnum"))
                    {
                        var typeSymbol = modelSymbolFactory.GetSymbol(type) as TypeSymbol;
                        if (typeSymbol is not null)
                        {
                            symbolsBuilder.Add(typeSymbol);
                        }
                        else
                        {
                            diagnostics.Add(Diagnostic.Create(CommonErrorCode.ERR_DeclarationError, Locations.FirstOrDefault(), $"The type '{type}' imported from the metamodel '{referencedMetaModel.MName}' could not be resolve. Are you missing an assembly reference?"));
                        }
                    }
                    foreach (var type in referencedMetaModel.MModel.Objects.Where(mobj => mobj.MInfo.MetaType.FullName == "MetaDslx.Languages.MetaModel.Model.MetaClass"))
                    {
                        var typeSymbol = modelSymbolFactory.GetSymbol(type) as TypeSymbol;
                        if (typeSymbol is not null)
                        {
                            symbolsBuilder.Add(typeSymbol);
                        }
                        else
                        {
                            diagnostics.Add(Diagnostic.Create(CommonErrorCode.ERR_DeclarationError, Locations.FirstOrDefault(), $"The type '{type}' imported from the metamodel '{referencedMetaModel.MName}' could not be resolve. Are you missing an assembly reference?"));
                        }
                    }
                }
                else if (referencedMetaModel is not null)
                {
                    metaModelsBuilder.Add(referencedMetaModel);
                    foreach (var type in referencedMetaModel.MEnumTypes)
                    {
                        var typeSymbol = type.AsTypeSymbol(compilation);
                        if (typeSymbol is not null)
                        {
                            symbolsBuilder.Add(typeSymbol);
                        }
                        else
                        {
                            diagnostics.Add(Diagnostic.Create(CommonErrorCode.ERR_DeclarationError, Locations.FirstOrDefault(), $"The type '{type}' imported from the metamodel '{referencedMetaModel.MName}' could not be resolve. Are you missing an assembly reference?"));
                        }
                    }
                    foreach (var type in referencedMetaModel.MClassTypes)
                    {
                        var typeSymbol = type.AsTypeSymbol(compilation);
                        if (typeSymbol is not null)
                        {
                            symbolsBuilder.Add(typeSymbol);
                        }
                        else
                        {
                            diagnostics.Add(Diagnostic.Create(CommonErrorCode.ERR_DeclarationError, Locations.FirstOrDefault(), $"The type '{type}' imported from the metamodel '{referencedMetaModel.MName}' could not be resolve. Are you missing an assembly reference?"));
                        }
                    }
                }
                else
                {
                    var metaModelNamespace = metaModelSymbol.ContainingNamespace;
                    var name = metaModelSymbol.Name;
                    var ignoredTypes = PooledHashSet<string>.GetInstance();
                    ignoredTypes.Add(name);
                    ignoredTypes.Add($"I{name}");
                    ignoredTypes.Add($"{name}ModelFactory");
                    ignoredTypes.Add($"{name}ModelMultiFactory");
                    ignoredTypes.Add($"ICustom{name}Implementation");
                    ignoredTypes.Add($"Custom{name}Implementation");
                    ignoredTypes.Add($"Custom{name}ImplementationBase");
                    foreach (var typeSymbol in metaModelNamespace.ContainedSymbols.OfType<TypeSymbol>())
                    {
                        if (ignoredTypes.Contains(typeSymbol.Name)) continue;
                        symbolsBuilder.Add(typeSymbol);
                    }
                }
                /*else if (metaModel is null && !metaModelSymbol.IsError && metaModelSymbol is CSharpTypeSymbol csharpTypeSymbol)
                {
                    var csharpNamespaceSymbol = csharpTypeSymbol.ContainingNamespace as CSharpNamespaceSymbol;
                    if (csharpNamespaceSymbol is not null)
                    {
                        metaModel = new ImportedMetaModel(csharpNamespaceSymbol, metaModelSymbol.Name, false);
                        symbolsBuilder.AddRange(ImportedMetaUtils.CollectTypes(csharpNamespaceSymbol, collectSymbols: false));
                    }
                }*/
                /*if (metaModel is null)
                {
                    diagnostics.Add(Diagnostic.Create(CommonErrorCode.ERR_DeclarationError, Locations.FirstOrDefault(), $"The imported type '{fullName}' is not a metamodel."));
                }*/
            }
            _metaModels = metaModelsBuilder.ToImmutableAndFree();
            _metaModelSymbols = metaModelSymbols.Select(s => MetaSymbol.FromSymbol(s)).ToImmutableArray();
            return (ImmutableArray<string>.Empty, ImmutableArray<AliasSymbol>.Empty, ImmutableArray<NamespaceSymbol>.Empty, symbolsBuilder.ToImmutableAndFree());
        }

        protected override void CompletePart_Validate(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            var unusedSymbols = UnusedSymbols;
            if (!unusedSymbols.IsEmpty)
            {
                var builder = PooledStringBuilder.GetInstance();
                var sb = builder.Builder;
                if (_metaModels.Length == 1)
                {
                    var metaModel = _metaModels[0];
                    foreach (var symbol in unusedSymbols.OrderBy(us => us.Name))
                    {
                        if (sb.Length > 0) sb.Append(", ");
                        sb.Append(symbol.Name);
                    }
                    if (sb.Length > 0) diagnostics.Add(Diagnostic.Create(CommonErrorCode.WRN_UnusedMetaTypes, Locations.FirstOrDefault(), metaModel.MName, builder.ToString()));
                }
                else
                {
                    foreach (var metaModel in _metaModels)
                    {
                        sb.Clear();
                        foreach (var symbol in unusedSymbols.OfType<TypeSymbol>().Where(ts => metaModel.MContains(MetaType.FromTypeSymbol(ts))).OrderBy(us => us.Name))
                        {
                            if (sb.Length > 0) sb.Append(", ");
                            sb.Append(symbol.Name);
                        }
                        if (sb.Length > 0) diagnostics.Add(Diagnostic.Create(CommonErrorCode.WRN_UnusedMetaTypes, Locations.FirstOrDefault(), metaModel.MName, builder.ToString()));
                    }
                }
                builder.Free();
            }
        }
    }
}
