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
    using INamespaceSymbol = Microsoft.CodeAnalysis.INamespaceSymbol;

    internal sealed class RootNamespaceSymbol : Impl.NamespaceSymbolImpl
    {
        private readonly MetaDslx.Modeling.Model _model;

        public RootNamespaceSymbol(ModuleSymbol container, MergedDeclaration declaration, MetaDslx.Modeling.Model model)
            : base(extent: new NamespaceExtent(container is ModuleSymbol moduleSymbol ? moduleSymbol : container.ContainingModule), container: container, compilation: container.DeclaringCompilation, declaration: declaration, modelObject: null, csharpSymbol: null, errorInfo: null)
        {
            _model = model;
        }

        public RootNamespaceSymbol(ModuleSymbol container, INamespaceSymbol csharpSymbol, MetaDslx.Modeling.Model model)
            : base(extent: new NamespaceExtent(container is ModuleSymbol moduleSymbol ? moduleSymbol : container.ContainingModule), container: container, compilation: container.DeclaringCompilation, declaration: null, modelObject: null, csharpSymbol: csharpSymbol, errorInfo: null)
        {
            _model = model;
        }

        public override Modeling.Model Model => _model;

        protected override string? Compute_Name(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return string.Empty;
        }

        protected override string? Compute_MetadataName(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return string.Empty;
        }

        protected override ImmutableArray<Symbol> CompletePart_CreateContainedSymbols(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            if (IsModelSymbol && !IsSourceSymbol && !IsCSharpSymbol)
            {
                return ContainingModule!.SymbolFactory.CreateSymbols<Symbol>(this, _model.RootObjects, diagnostics, cancellationToken);
            }
            else
            {
                return base.CompletePart_CreateContainedSymbols(diagnostics, cancellationToken);
            }
        }
    }
}
