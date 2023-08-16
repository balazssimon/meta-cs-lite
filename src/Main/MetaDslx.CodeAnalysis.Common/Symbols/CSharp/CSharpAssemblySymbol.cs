using Microsoft.CodeAnalysis;
using Roslyn.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Globalization;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Symbols.CSharp
{
    internal class CSharpAssemblySymbol : AssemblySymbol
    {
        private readonly CSharpSymbolFactory _symbolFactory;
        private readonly IAssemblySymbol _csharpSymbol;
        private ImmutableArray<CSharpModuleSymbol> _modules;

        public CSharpAssemblySymbol(CSharpSymbolFactory symbolFactory, IAssemblySymbol csharpSymbol)
        {
            _symbolFactory = symbolFactory;
            _csharpSymbol = csharpSymbol;
        }

        public IAssemblySymbol CSharpSymbol => _csharpSymbol;
        public CSharpSymbolFactory SymbolFactory => _symbolFactory;
        public override ImmutableArray<Location> Locations => _csharpSymbol.Locations.SelectAsArray(l => l.ToMetaDslx());

        public override ImmutableArray<ModuleSymbol> Modules => _modules.Cast<CSharpModuleSymbol, ModuleSymbol>();

        public override bool IsCorLibrary
        {
            get
            {
                var systemObject = _csharpSymbol.GetTypeByMetadataName("System.Object");
                if (systemObject is null) return false;
                return systemObject.DeclaredAccessibility == Microsoft.CodeAnalysis.Accessibility.Public && 
                    systemObject.TypeKind == TypeKind.Class;
            }
        }

        internal void DangerousSetModules(ImmutableArray<CSharpModuleSymbol> modules)
        {
            _modules = modules;
        }

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
            return _modules.Cast<CSharpModuleSymbol, Symbol>();
        }

        protected override ImmutableArray<AttributeSymbol> CompleteProperty_Attributes(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return SymbolFactory.CreateAttributes(_csharpSymbol, diagnostics, cancellationToken);
        }
    }
}
