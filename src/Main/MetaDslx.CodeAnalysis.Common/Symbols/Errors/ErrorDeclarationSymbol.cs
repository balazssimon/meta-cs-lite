using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Symbols.Errors
{
    public class ErrorDeclarationSymbol : DeclarationSymbol, IErrorSymbol
    {
        private readonly ErrorSymbolInfo _errorInfo;
        private readonly ImmutableArray<Location> _locations;

        public ErrorDeclarationSymbol(Symbol container, ErrorSymbolInfo errorInfo) 
            : base(container)
        {
            _errorInfo = errorInfo;
            _locations = ImmutableArray.Create(_errorInfo.Diagnostic.Location).AddRange(_errorInfo.Diagnostic.AdditionalLocations);
        }

        public ErrorSymbolInfo ErrorInfo => _errorInfo;
        public ImmutableArray<Symbol> CandidateSymbols => _errorInfo.Symbols;
        public override ImmutableArray<Location> Locations => _locations;

        protected override string? CompleteProperty_Name(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return _errorInfo.Name;
        }

        protected override string? CompleteProperty_MetadataName(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return _errorInfo.MetadataName;
        }

    }
}
