using Microsoft.CodeAnalysis;
using Roslyn.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Symbols.CSharp
{
    internal class CSharpNamespaceSymbol : NamespaceSymbol, ICSharpSymbol
    {
        private readonly INamespaceSymbol _csharpSymbol;
        private readonly ModuleSymbol _module;

        public CSharpNamespaceSymbol(Symbol container, INamespaceSymbol csharpSymbol)
            : base(container)
        {
            _csharpSymbol = csharpSymbol;
            _module = container is ModuleSymbol moduleSymbol ? moduleSymbol : container.ContainingModule;
        }

        public CSharpSymbolFactory SymbolFactory => ((CSharpModuleSymbol)ContainingModule).SymbolFactory;
        public INamespaceSymbol CSharpSymbol => _csharpSymbol;
        public override ImmutableArray<Location> Locations => _csharpSymbol.Locations.SelectAsArray(l => l.ToMetaDslx());

        public override NamespaceExtent Extent => new NamespaceExtent(_module);
        public override ModuleSymbol ContainingModule => _module;

        ISymbol ICSharpSymbol.CSharpSymbol => this.CSharpSymbol;

        protected override string? CompleteProperty_Name(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return _csharpSymbol.Name;
        }

        protected override string? CompleteProperty_MetadataName(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return _csharpSymbol.MetadataName;
        }

        protected override ImmutableArray<Symbol> CompletePart_CreateContainedSymbols(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return SymbolFactory.GetSymbols<Symbol>(_csharpSymbol.GetMembers(), diagnostics, cancellationToken);
        }

        protected override ImmutableArray<DeclaredSymbol> CompleteProperty_Members(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return SymbolFactory.GetSymbols<DeclaredSymbol>(_csharpSymbol.GetMembers(), diagnostics, cancellationToken);
        }

        protected override ImmutableArray<AttributeSymbol> CompleteProperty_Attributes(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return SymbolFactory.CreateAttributes(_csharpSymbol, diagnostics, cancellationToken);
        }
    }
}
