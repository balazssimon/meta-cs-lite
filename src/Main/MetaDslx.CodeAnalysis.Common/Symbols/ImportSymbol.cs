using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.CodeAnalysis.Symbols.CSharp;
using MetaDslx.CodeAnalysis.Symbols.Meta;
using MetaDslx.CodeAnalysis.Symbols.Model;
using MetaDslx.CodeAnalysis.Symbols.Source;
using MetaDslx.Modeling;
using Microsoft.CodeAnalysis;
using Roslyn.Utilities;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Symbols
{
    public abstract partial class ImportSymbol : Symbol
    {
        public new static class CompletionParts
        {
            public static readonly CompletionPart StartComputingImports = new CompletionPart(nameof(StartComputingImports));
            public static readonly CompletionPart FinishComputingImports = new CompletionPart(nameof(FinishComputingImports));
            public static readonly CompletionPart StartComputingProperty_Attributes = Symbol.CompletionParts.StartComputingProperty_Attributes;
            public static readonly CompletionPart FinishComputingProperty_Attributes = Symbol.CompletionParts.FinishComputingProperty_Attributes;
            public static readonly CompletionGraph CompletionGraph =
                CompletionGraph.CreateFromParts(
                    CompletionGraph.StartInitializing, CompletionGraph.FinishInitializing,
                    CompletionGraph.StartCreatingContainedSymbols, CompletionGraph.FinishCreatingContainedSymbols,
                    StartComputingImports, FinishComputingImports,
                    StartComputingProperty_Attributes, FinishComputingProperty_Attributes,
                    CompletionGraph.StartComputingNonSymbolProperties, CompletionGraph.FinishComputingNonSymbolProperties,
                    CompletionGraph.ContainedSymbolsFinalized,
                    CompletionGraph.StartFinalizing, CompletionGraph.FinishFinalizing,
                    CompletionGraph.ContainedSymbolsCompleted,
                    CompletionGraph.StartValidating, CompletionGraph.FinishValidating);
        }

        private bool _isComputingImports;
        private ImmutableArray<string> _files;
        private ImmutableArray<AliasSymbol> _aliases;
        private ImmutableArray<NamespaceSymbol> _namespaces;
        private ImmutableArray<DeclaredSymbol> _symbols;
        private ImmutableHashSet<DeclaredSymbol> _allSymbols;
        private object? _unusedSymbols;
        private object? _unusedNamespaces;

        protected ImportSymbol(Symbol container) 
            : base(container)
        {
        }

        protected override CompletionGraph CompletionGraph => CompletionParts.CompletionGraph;

        public bool IsComputingImports => _isComputingImports;

        [ModelProperty]
        public ImmutableArray<string> Files
        {
            get
            {
                ForceComplete(CompletionParts.FinishComputingImports, null, default);
                return _files;
            }
        }

        [ModelProperty]
        public ImmutableArray<AliasSymbol> Aliases
        {
            get
            {
                ForceComplete(CompletionParts.FinishComputingImports, null, default);
                return _aliases;
            }
        }

        [ModelProperty]
        public ImmutableArray<NamespaceSymbol> Namespaces
        {
            get
            {
                ForceComplete(CompletionParts.FinishComputingImports, null, default);
                return _namespaces;
            }
        }

        [ModelProperty]
        public ImmutableArray<DeclaredSymbol> Symbols
        {
            get
            {
                ForceComplete(CompletionParts.FinishComputingImports, null, default);
                return _symbols;
            }
        }

        public ImmutableArray<NamespaceSymbol> UnusedNamespaces
        {
            get
            {
                ForceComplete(CompletionGraph.FinishFinalizing, null, default);
                if (_unusedNamespaces is ConcurrentDictionary<NamespaceSymbol, byte> uncd)
                {
                    Interlocked.Exchange(ref _unusedNamespaces, uncd.Keys.ToImmutableArray());
                }
                return (ImmutableArray<NamespaceSymbol>)_unusedNamespaces;
            }
        }

        public ImmutableArray<DeclaredSymbol> UnusedSymbols
        {
            get
            {
                ForceComplete(CompletionGraph.FinishFinalizing, null, default);
                if (_unusedSymbols is ConcurrentDictionary<NamespaceSymbol, byte> uscd)
                {
                    Interlocked.Exchange(ref _unusedSymbols, uscd.Keys.ToImmutableArray());
                }
                return (ImmutableArray<DeclaredSymbol>)_unusedSymbols;
            }
        }

        protected override bool ForceCompletePart(ref CompletionPart incompletePart, SourceLocation? locationOpt, CancellationToken cancellationToken)
        {
            if (incompletePart == CompletionParts.StartComputingImports || incompletePart == CompletionParts.FinishComputingImports)
            {
                if (NotePartComplete(CompletionParts.StartComputingImports))
                {
                    _isComputingImports = true;
                    var diagnostics = DiagnosticBag.GetInstance();
                    var value = ComputeImports(diagnostics, cancellationToken);
                    _files = value.files;
                    _aliases = value.aliases;
                    _namespaces = value.namespaces;
                    _symbols = value.symbols;
                    ComputeSymbols(diagnostics);
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.FinishComputingImports);
                    _isComputingImports = false;
                }
                return true;
            }
            else if (base.ForceCompletePart(ref incompletePart, locationOpt, cancellationToken))
            {
                return true;
            }
            return false;
        }

        protected virtual ImmutableArray<NamespaceSymbol> ComputeNamespaces(DiagnosticBag diagnostics)
        {
            return ImmutableArray<NamespaceSymbol>.Empty;
        }

        private void ComputeSymbols(DiagnosticBag diagnostics)
        {
            var symbolsBuilder = ArrayBuilder<DeclaredSymbol>.GetInstance();
            symbolsBuilder.AddRange(_aliases);
            var compilation = DeclaringCompilation;
            if (_files.Length > 0 && this is ISourceSymbol sourceSymbol && compilation is not null)
            {
                if (compilation.Options.MergeGlobalNamespace)
                {
                    diagnostics.Add(Diagnostic.Create(CommonErrorCode.ERR_FileImportsDisabled, this.Locations.FirstOrDefault()));
                }
                else
                {
                    var currentFilePaths = PooledHashSet<string>.GetInstance();
                    foreach (var syntaxReference in sourceSymbol.DeclaringSyntaxReferences)
                    {
                        currentFilePaths.Add(syntaxReference.SyntaxTree.FilePath);
                    }
                    foreach (var currentFilePath in currentFilePaths)
                    {
                        var currentDirectory = Path.GetDirectoryName(currentFilePath) ?? string.Empty;
                        foreach (var fileName in _files)
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
                }
            }
            if (symbolsBuilder.Count > 0)
            {
                symbolsBuilder.AddRange(_symbols);
                _symbols = symbolsBuilder.ToImmutableAndFree();
            }
            else
            {
                symbolsBuilder.Free();
            }
            var unusedSymbols = new ConcurrentDictionary<DeclaredSymbol, byte>();
            foreach (var symbol in _symbols)
            {
                unusedSymbols.TryAdd(symbol, 0);
            }
            _unusedSymbols = unusedSymbols;
            var unusedNamespaces = new ConcurrentDictionary<NamespaceSymbol, byte>();
            foreach (var ns in _namespaces)
            {
                unusedNamespaces.TryAdd(ns, 0);
            }
            _unusedNamespaces = unusedNamespaces;
            var allSymbols = ImmutableHashSet.CreateBuilder<DeclaredSymbol>();
            allSymbols.AddAll(_symbols);
            allSymbols.AddAll(_namespaces);
            _allSymbols = allSymbols.ToImmutable();
        }

        public virtual bool MarkImportedSymbolAsUsed(DeclaredSymbol symbol)
        {
            if (_allSymbols is null) return false;
            if (!_allSymbols.Contains(symbol)) return false;
            if (_unusedSymbols is ConcurrentDictionary<DeclaredSymbol, byte> uscd &&
                (_symbols.Contains(symbol) || symbol is AliasSymbol aliasSymbol && _aliases.Contains(aliasSymbol)))
            {
                uscd.TryRemove(symbol, out var _);
            }
            var importedNamespace = _namespaces.FirstOrDefault(ns => ns.Members.Contains(symbol));
            if (_unusedNamespaces is ConcurrentDictionary<NamespaceSymbol, byte> uncd &&
                importedNamespace is not null)
            {
                uncd.TryRemove(importedNamespace, out var _);
            }
            return true;
        }

        protected virtual (ImmutableArray<string> files, ImmutableArray<AliasSymbol> aliases, ImmutableArray<NamespaceSymbol> namespaces, ImmutableArray<DeclaredSymbol> symbols) ComputeImports(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        protected override void CompletePart_Validate(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            var unusedNamespaces = UnusedNamespaces;
            if (!unusedNamespaces.IsEmpty)
            {
                var builder = PooledStringBuilder.GetInstance();
                var sb = builder.Builder;
                foreach (var ns in unusedNamespaces)
                {
                    if (sb.Length > 0) sb.Append(", ");
                    sb.Append(SymbolDisplayFormat.QualifiedNameOnlyFormat.ToString(ns));
                }
                diagnostics.Add(Diagnostic.Create(CommonErrorCode.HDN_UnusedNamespaces, this.Locations.FirstOrDefault(), builder.ToStringAndFree()));
            }
            var unusedSymbols = UnusedSymbols;
            if (!unusedSymbols.IsEmpty)
            {
                var builder = PooledStringBuilder.GetInstance();
                var sb = builder.Builder;
                foreach (var symbol in unusedSymbols.Where(us => !(us is MetaTypeSymbol)))
                {
                    if (sb.Length > 0) sb.Append(", ");
                    sb.Append(SymbolDisplayFormat.QualifiedNameOnlyFormat.ToString(symbol));
                }
                if (sb.Length > 0) diagnostics.Add(Diagnostic.Create(CommonErrorCode.HDN_UnusedSymbols, this.Locations.FirstOrDefault(), builder.ToString()));
                builder.Free();
            }
        }
    }
}
