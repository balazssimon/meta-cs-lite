using Microsoft.CodeAnalysis;
using Roslyn.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Symbols.CSharp
{
    internal class CSharpNamedTypeSymbol : NamedTypeSymbol
    {
        private readonly INamedTypeSymbol _csharpSymbol;

        public CSharpNamedTypeSymbol(Symbol container, INamedTypeSymbol csharpSymbol)
            : base(container)
        {
            _csharpSymbol = csharpSymbol;
        }

        public CSharpSymbolFactory SymbolFactory => ((CSharpModuleSymbol)ContainingModule).SymbolFactory;
        public INamedTypeSymbol CSharpSymbol => _csharpSymbol;
        public override ImmutableArray<Location> Locations => _csharpSymbol.Locations.SelectAsArray(l => l.ToMetaDslx());

        public override bool IsImplicitlyDeclared => _csharpSymbol.IsImplicitlyDeclared;
        public override bool IsStatic => _csharpSymbol.IsStatic;
        public override bool IsExtern => _csharpSymbol.IsExtern;
        public override bool IsError => _csharpSymbol.TypeKind == TypeKind.Error;
        public override bool IsReferenceType => _csharpSymbol.IsReferenceType;
        public override bool IsValueType => _csharpSymbol.IsValueType;

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
            return SymbolFactory.GetSymbols<Symbol>(_csharpSymbol.GetMembers());
        }

        protected override ImmutableArray<DeclaredSymbol> CompleteProperty_Members(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return SymbolFactory.GetSymbols<DeclaredSymbol>(_csharpSymbol.GetMembers());
        }
    }
}
