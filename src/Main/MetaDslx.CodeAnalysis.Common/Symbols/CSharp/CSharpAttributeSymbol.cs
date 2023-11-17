using Microsoft.CodeAnalysis;
using Roslyn.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Symbols.CSharp
{
    internal class CSharpAttributeSymbol : AttributeSymbol, ICSharpSymbol
    {
        private readonly Microsoft.CodeAnalysis.AttributeData _csharpSymbol;

        public CSharpAttributeSymbol(Symbol container, Microsoft.CodeAnalysis.AttributeData csharpSymbol)
            : base(container)
        {
            _csharpSymbol = csharpSymbol;
        }

        public CSharpSymbolFactory SymbolFactory => ((CSharpModuleSymbol)ContainingModule).SymbolFactory;
        public ISymbol CSharpSymbol => _csharpSymbol.AttributeClass;
        public override ImmutableArray<Location> Locations => _csharpSymbol.AttributeClass.Locations.SelectAsArray(l => l.ToMetaDslx());

        protected override string? CompleteProperty_Name(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return _csharpSymbol.AttributeClass.Name;
        }

        protected override string? CompleteProperty_MetadataName(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return _csharpSymbol.AttributeClass.MetadataName;
        }

        protected override ImmutableArray<Symbol> CompletePart_CreateContainedSymbols(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return ImmutableArray<Symbol>.Empty;
        }

        protected override TypeSymbol CompleteProperty_AttributeClass(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return SymbolFactory.GetSymbol<TypeSymbol>(_csharpSymbol.AttributeClass, diagnostics, cancellationToken);
        }

    }
}
