using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Symbols
{
    public abstract partial class ModuleSymbol : Symbol
    {
        private NamespaceSymbol _globalNamespace;

        protected ModuleSymbol(Symbol container) 
            : base(container)
        {
        }

        public NamespaceSymbol GlobalNamespace
        {
            get
            {
                ForceComplete(CompletionGraph.FinishCreatingContainedSymbols, null, default);
                return _globalNamespace;
            }
        }

        protected sealed override ImmutableArray<Symbol> CompletePart_CreateContainedSymbols(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            var globalNamespace = CompleteProperty_GlobalNamespace(diagnostics, cancellationToken);
            Interlocked.CompareExchange(ref _globalNamespace, globalNamespace, null);
            return _globalNamespace is null ? ImmutableArray<Symbol>.Empty : ImmutableArray.Create<Symbol>(_globalNamespace);
        }

        protected abstract NamespaceSymbol CompleteProperty_GlobalNamespace(DiagnosticBag diagnostics, CancellationToken cancellationToken);
    }
}
