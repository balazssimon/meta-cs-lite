using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.Symbols.Model;
using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Symbols
{
    internal sealed class RootNamespaceSymbol : __Impl.NamespaceSymbolInst
    {
        private readonly MetaDslx.Modeling.Model _model;

        public RootNamespaceSymbol(ModuleSymbol container, MergedDeclaration declaration, MetaDslx.Modeling.Model model)
            : base(container, container.DeclaringCompilation, declaration: declaration, extent: new NamespaceExtent(container is ModuleSymbol moduleSymbol ? moduleSymbol : container.ContainingModule))
        {
            _model = model;
        }

        protected override ImmutableArray<Symbol> CompletePart_CreateContainedSymbols(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            if (MergedDeclaration is null)
            {
                return ContainingModule.SymbolFactory.GetSymbols<Symbol>(this, _model.RootObjects, diagnostics, cancellationToken);
            }
            else
            {
                return base.CompletePart_CreateContainedSymbols(diagnostics, cancellationToken);
            }
        }
    }
}
