﻿using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.Symbols.Model;
using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Symbols.Source
{
    internal class SourceRootNamespaceSymbol : NamespaceSymbol, ISourceSymbol, IModelSymbol
    {
        private readonly MergedDeclaration _declaration;
        private readonly MetaDslx.Modeling.Model _model;
        private readonly ModuleSymbol _module;

        public SourceRootNamespaceSymbol(SourceModuleSymbol container, MergedDeclaration declaration, MetaDslx.Modeling.Model model)
            : base(container)
        {
            _declaration = declaration;
            _model = model;
            _module = container is ModuleSymbol moduleSymbol ? moduleSymbol : container.ContainingModule;
        }

        public override NamespaceExtent Extent => new NamespaceExtent(_module);
        public override ModuleSymbol ContainingModule => _module;

        public MetaDslx.Modeling.Model Model => _model;
        public IModelObject ModelObject => null;

        public MergedDeclaration Declaration => _declaration;
        protected SourceSymbolFactory SymbolFactory => ((SourceModuleSymbol)ContainingModule).SymbolFactory;
        public ImmutableArray<SyntaxNodeOrToken> DeclaringSyntaxReferences => _declaration.SyntaxReferences;
        public SyntaxNodeOrToken DeclaringSyntaxReference => DeclaringSyntaxReferences.FirstOrDefault();
        public override ImmutableArray<Location> Locations => ((ISourceSymbol)this).Locations.Cast<SourceLocation, Location>();
        ImmutableArray<SourceLocation> ISourceSymbol.Locations => _declaration.NameLocations.Length > 0 ? _declaration.NameLocations : DeclaringSyntaxReferences.Select(sr => sr.GetLocation() as SourceLocation).ToImmutableArray();
        SourceLocation ISourceSymbol.Location => ((ISourceSymbol)this).Locations.FirstOrDefault();
        public Type ModelObjectType => _declaration.ModelObjectType;

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
            if (this is IErrorSymbol) return ImmutableArray<Symbol>.Empty;
            return SymbolFactory.CreateContainedSymbols(this, diagnostics);
        }

        protected override ImmutableArray<DeclarationSymbol> CompleteProperty_Members(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return SymbolFactory.GetMemberSymbols(this, diagnostics);
        }

        protected override ImmutableArray<ImportSymbol> CompleteProperty_Imports(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return SymbolFactory.GetImportSymbols(this);
        }

    }
}