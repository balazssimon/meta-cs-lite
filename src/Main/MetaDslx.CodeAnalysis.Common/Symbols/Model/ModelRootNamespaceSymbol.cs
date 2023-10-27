﻿using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Symbols.Model
{
    public class ModelRootNamespaceSymbol : NamespaceSymbol
    {
        private readonly MetaDslx.Modeling.Model _model;
        private readonly ModuleSymbol _module;

        public ModelRootNamespaceSymbol(Symbol container, MetaDslx.Modeling.Model model)
            : base(container)
        {
            _model = model;
            _module = container is ModuleSymbol moduleSymbol ? moduleSymbol : container.ContainingModule;
        }

        public override NamespaceExtent Extent => new NamespaceExtent(_module);
        public override ImmutableArray<Location> Locations => ImmutableArray<Location>.Empty;

        protected override string? CompleteProperty_Name(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return string.Empty;
        }

        protected override ImmutableArray<Symbol> CompletePart_CreateContainedSymbols(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return ((ModelModuleSymbol)ContainingModule).SymbolFactory.GetSymbols<Symbol>(_model.ModelObjects.Where(mo => mo.Parent is null));
        }

        protected override ImmutableArray<DeclaredSymbol> CompleteProperty_Members(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return ((ModelModuleSymbol)ContainingModule).SymbolFactory.GetSymbols<DeclaredSymbol>(_model.ModelObjects.Where(mo => mo.Parent is null));
        }
    }
}
