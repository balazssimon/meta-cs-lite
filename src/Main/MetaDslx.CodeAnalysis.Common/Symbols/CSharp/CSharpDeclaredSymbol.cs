﻿using Microsoft.CodeAnalysis;
using Roslyn.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Symbols.CSharp
{
    public class CSharpDeclaredSymbol : DeclaredSymbol
    {
        private readonly ISymbol _csharpSymbol;

        public CSharpDeclaredSymbol(Symbol container, ISymbol csharpSymbol) 
            : base(container)
        {
            _csharpSymbol = csharpSymbol;
        }

        public CSharpSymbolFactory SymbolFactory => ((CSharpModuleSymbol)ContainingModule).SymbolFactory;
        public ISymbol CSharpSymbol => _csharpSymbol;
        public override ImmutableArray<Location> Locations => _csharpSymbol.Locations.SelectAsArray(l => l.ToMetaDslx());

        public override bool IsImplicitlyDeclared => _csharpSymbol.IsImplicitlyDeclared;
        public override bool IsStatic => _csharpSymbol.IsStatic;
        public override bool IsExtern => _csharpSymbol.IsExtern;

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
            if (_csharpSymbol is INamespaceOrTypeSymbol nsot) return SymbolFactory.GetSymbols<Symbol>(nsot.GetMembers());
            else return ImmutableArray<Symbol>.Empty;
        }

        protected override ImmutableArray<DeclaredSymbol> CompleteProperty_Members(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            if (_csharpSymbol is INamespaceOrTypeSymbol nsot) return SymbolFactory.GetSymbols<DeclaredSymbol>(nsot.GetMembers());
            else return ImmutableArray<DeclaredSymbol>.Empty;
        }
    }
}
