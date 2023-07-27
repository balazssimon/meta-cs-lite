using MetaDslx.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis;
using Roslyn.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Symbols.CSharp
{
    internal class CSharpModuleSymbol : ModuleSymbol
    {
        private readonly IModuleSymbol _csharpSymbol;
        private readonly CSharpSymbolFactory _symbolFactory;
        private NamespaceSymbol _globalNamespace;

        public CSharpModuleSymbol(CSharpAssemblySymbol containingAssembly, CSharpSymbolFactory symbolFactory, IModuleSymbol csharpSymbol)
            : base(containingAssembly)
        {
            _symbolFactory = symbolFactory;
            _csharpSymbol = csharpSymbol;
        }

        public CSharpSymbolFactory SymbolFactory => _symbolFactory;
        public IModuleSymbol CSharpSymbol => _csharpSymbol;
        public override ImmutableArray<Location> Locations => _csharpSymbol.Locations.SelectAsArray(l => l.ToMetaDslx());

        protected override string? CompleteProperty_Name(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return _csharpSymbol.Name;
        }

        protected override NamespaceSymbol CompleteProperty_GlobalNamespace(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return _symbolFactory.GetSymbol<NamespaceSymbol>(_csharpSymbol.GlobalNamespace);
        }
    }
}
