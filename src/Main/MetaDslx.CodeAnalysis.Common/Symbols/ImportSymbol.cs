using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
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
                    CompletionGraph.ContainedSymbolsCompleted,
                    CompletionGraph.StartValidatingSymbol, CompletionGraph.FinishValidatingSymbol);
        }

        private ImmutableArray<AliasSymbol> _aliases;
        private ImmutableArray<NamespaceSymbol> _namespaces;
        private ImmutableArray<DeclaredSymbol> _symbols;
        private ImmutableArray<DeclaredSymbol> _metaModelSymbols;
        private ImmutableArray<MetaModel> _metaModels;

        protected ImportSymbol(Symbol container) 
            : base(container)
        {
        }

        protected override CompletionGraph CompletionGraph => CompletionParts.CompletionGraph;

        [ModelProperty]
        public ImmutableArray<string> Files => ImmutableArray<string>.Empty;

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

        [ModelProperty]
        public ImmutableArray<DeclaredSymbol> MetaModelSymbols
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

        protected override bool ForceCompletePart(ref CompletionPart incompletePart, SourceLocation? locationOpt, CancellationToken cancellationToken)
        {
            if (incompletePart == CompletionParts.StartComputingImports || incompletePart == CompletionParts.FinishComputingImports)
            {
                if (NotePartComplete(CompletionParts.StartComputingImports))
                {
                    var diagnostics = DiagnosticBag.GetInstance();
                    var value = ComputeImports(diagnostics, cancellationToken);
                    _aliases = value.aliases;
                    _namespaces = value.namespaces;
                    _symbols = value.symbols;
                    _metaModelSymbols = value.metaModelSymbols;
                    _metaModels = value.metaModels;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.FinishComputingImports);
                }
                return true;
            }
            else if (base.ForceCompletePart(ref incompletePart, locationOpt, cancellationToken))
            {
                return true;
            }
            return false;
        }

        protected virtual (ImmutableArray<AliasSymbol> aliases, ImmutableArray<NamespaceSymbol> namespaces, ImmutableArray<DeclaredSymbol> symbols, ImmutableArray<DeclaredSymbol> metaModelSymbols, ImmutableArray<MetaModel> metaModels) ComputeImports(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
