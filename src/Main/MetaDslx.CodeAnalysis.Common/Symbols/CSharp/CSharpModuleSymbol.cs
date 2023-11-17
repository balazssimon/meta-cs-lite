using MetaDslx.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis;
using Roslyn.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Symbols.CSharp
{
    internal class CSharpModuleSymbol : ModuleSymbol, ICSharpSymbol
    {
        private readonly CSharpAssemblySymbol _containingAssembly;
        private readonly IModuleSymbol _csharpSymbol;
        private NamespaceSymbol _globalNamespace;

        public CSharpModuleSymbol(CSharpAssemblySymbol containingAssembly, IModuleSymbol csharpSymbol)
            : base(containingAssembly)
        {
            _containingAssembly = containingAssembly;
            _csharpSymbol = csharpSymbol;
        }

        public override AssemblySymbol? ContainingAssembly => _containingAssembly;
        public CSharpSymbolFactory SymbolFactory => _containingAssembly.SymbolFactory;
        public IModuleSymbol CSharpSymbol => _csharpSymbol;
        public override ImmutableArray<Location> Locations => _csharpSymbol.Locations.SelectAsArray(l => l.ToMetaDslx());

        ISymbol ICSharpSymbol.CSharpSymbol => this.CSharpSymbol;

        protected override string? CompleteProperty_Name(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return _csharpSymbol.Name;
        }

        protected override string? CompleteProperty_MetadataName(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return _csharpSymbol.MetadataName;
        }

        protected override NamespaceSymbol CompleteProperty_GlobalNamespace(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return SymbolFactory.GetSymbol<NamespaceSymbol>(_csharpSymbol.GlobalNamespace, diagnostics, cancellationToken);
        }

        protected override ImmutableArray<AttributeSymbol> CompleteProperty_Attributes(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return SymbolFactory.CreateAttributes(_csharpSymbol, diagnostics, cancellationToken);
        }
    }
}
