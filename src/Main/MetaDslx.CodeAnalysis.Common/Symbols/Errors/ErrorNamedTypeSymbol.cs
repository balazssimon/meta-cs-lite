using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.CodeAnalysis.Symbols.Errors
{
    public class ErrorNamedTypeSymbol : NamedTypeSymbol, IErrorSymbol
    {
        private DiagnosticInfo _errorInfo;

        public ErrorNamedTypeSymbol(Symbol container, DiagnosticInfo errorInfo)
            : base(container)
        {
            _errorInfo = errorInfo;
        }

        public override ImmutableArray<Location> Locations => ImmutableArray<Location>.Empty;

        public DiagnosticInfo ErrorInfo => _errorInfo;
    }
}
