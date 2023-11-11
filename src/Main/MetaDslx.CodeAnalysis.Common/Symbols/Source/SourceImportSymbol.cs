using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.CodeAnalysis.Symbols.CSharp;
using MetaDslx.CodeAnalysis.Symbols.Meta;
using MetaDslx.Modeling;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Xml.Linq;

namespace MetaDslx.CodeAnalysis.Symbols.Source
{
    public sealed class SourceImportSymbol : ImportSymbol, ISourceSymbol
    {
        private readonly MergedDeclaration _declaration;
        private ImmutableArray<SourceLocation> _locations;

        internal SourceImportSymbol(Symbol container, MergedDeclaration declaration)
            : base(container)
        {
            _declaration = declaration;
        }

        public new SourceModuleSymbol ContainingModule => (SourceModuleSymbol)base.ContainingModule;
        protected SourceSymbolFactory SymbolFactory => ContainingModule.SymbolFactory;
        public MergedDeclaration Declaration => _declaration;
        public ImmutableArray<SyntaxNodeOrToken> DeclaringSyntaxReferences => _declaration.SyntaxReferences;
        public override ImmutableArray<Location> Locations => ((ISourceSymbol)this).Locations.Cast<SourceLocation, Location>();
        ImmutableArray<SourceLocation> ISourceSymbol.Locations
        {
            get
            {
                if (_locations.IsDefault)
                {
                    var locations = _declaration.SyntaxReferences.Select(sr => sr.GetLocation() as SourceLocation).Where(l => l is not null).ToImmutableArray();
                    ImmutableInterlocked.InterlockedInitialize(ref _locations, locations);
                }
                return _locations;
            }
        }
        protected override string? CompleteProperty_Name(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return _declaration.Name;
        }

        protected override string? CompleteProperty_MetadataName(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return _declaration.MetadataName;
        }

        protected override ImmutableArray<Symbol> CompletePart_CreateContainedSymbols(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return SymbolFactory.CreateContainedSymbols(this, diagnostics);
        }
        
        protected override (ImmutableArray<AliasSymbol> aliases, ImmutableArray<NamespaceSymbol> namespaces, ImmutableArray<DeclaredSymbol> symbols, ImmutableArray<DeclaredSymbol> metaModelSymbols, ImmutableArray<MetaModel> metaModels) ComputeImports(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            var files = SymbolFactory.GetSymbolPropertyValues<string>(this, nameof(Files), diagnostics, cancellationToken);
            var aliases = SymbolFactory.GetSymbolPropertyValues<AliasSymbol>(this, nameof(Aliases), diagnostics, cancellationToken);
            var namespaces = SymbolFactory.GetSymbolPropertyValues<NamespaceSymbol>(this, nameof(Namespaces), diagnostics, cancellationToken);
            var symbols = SymbolFactory.GetSymbolPropertyValues<DeclaredSymbol>(this, nameof(Symbols), diagnostics, cancellationToken);
            var metaModelSymbols = SymbolFactory.GetSymbolPropertyValues<DeclaredSymbol>(this, nameof(MetaModelSymbols), diagnostics, cancellationToken);
            var metaModelsBuilder = ArrayBuilder<MetaModel>.GetInstance();
            foreach (var metaModelSymbol in metaModelSymbols)
            {
                var fullName = SymbolDisplayFormat.QualifiedNameOnlyFormat.ToString(metaModelSymbol);
                MetaModel? metaModel = null;
                foreach (var mmRef in DeclaringCompilation.ExternalReferences.OfType<MetaModelReference>())
                {
                    if (mmRef.MetaModel.MFullName == fullName)
                    {
                        metaModel = mmRef.MetaModel;
                        break;
                    }
                }
                if (metaModel is null && metaModelSymbol is CSharpTypeSymbol csharpTypeSymbol)
                {
                    metaModel = new SymbolMetaModel(csharpTypeSymbol);
                }
                if (metaModel is not null)
                {
                    metaModelsBuilder.Add(metaModel);
                }
                else
                {
                    diagnostics.Add(Diagnostic.Create(CommonErrorCode.ERR_DeclarationError, this.Locations.FirstOrDefault(), $"The imported type '{fullName}' is not a metamodel."));
                }
            }
            var metaModels = metaModelsBuilder.ToImmutableAndFree();
            if (files.Length > 0)
            {
                var compilation = this.DeclaringCompilation;
                if (compilation is not null)
                {
                    if (compilation.Options.MergeGlobalNamespace)
                    {
                        diagnostics.Add(Diagnostic.Create(CommonErrorCode.ERR_FileImportsDisabled, this.Locations.FirstOrDefault()));
                    }
                    else
                    {
                        var symbolsBuilder = ArrayBuilder<DeclaredSymbol>.GetInstance();
                        var currentFilePaths = PooledHashSet<string>.GetInstance();
                        foreach (var syntaxReference in this.DeclaringSyntaxReferences)
                        {
                            currentFilePaths.Add(syntaxReference.SyntaxTree.FilePath);
                        }
                        foreach (var currentFilePath in currentFilePaths)
                        {
                            var currentDirectory = Path.GetDirectoryName(currentFilePath) ?? string.Empty;
                            foreach (var fileName in files)
                            {
                                var importedFilePath = fileName;
                                var found = false;
                                if (!string.IsNullOrWhiteSpace(fileName))
                                {
                                    importedFilePath = Path.GetFullPath(Path.IsPathRooted(fileName) ? fileName : Path.Combine(currentDirectory, fileName));
                                    foreach (var syntaxTree in compilation.SyntaxTrees)
                                    {
                                        if (!string.IsNullOrWhiteSpace(syntaxTree.FilePath))
                                        {
                                            var treeFilePath = Path.GetFullPath(syntaxTree.FilePath);
                                            if (importedFilePath == treeFilePath)
                                            {
                                                found = true;
                                                var fileNamespace = compilation.GetRootNamespace(syntaxTree);
                                                symbolsBuilder.AddRange(fileNamespace.Members);
                                            }
                                        }
                                    }
                                }
                                if (!found)
                                {
                                    diagnostics.Add(Diagnostic.Create(CommonErrorCode.ERR_ImportedFileNotFound, this.Locations.FirstOrDefault(), fileName, importedFilePath));
                                }
                            }
                        }
                        currentFilePaths.Free();
                        symbolsBuilder.AddRange(symbols);
                        symbols = symbolsBuilder.ToImmutableAndFree();
                    }
                }
            }
            return (aliases, namespaces, symbols, metaModelSymbols, metaModels);
        }
    }
}
