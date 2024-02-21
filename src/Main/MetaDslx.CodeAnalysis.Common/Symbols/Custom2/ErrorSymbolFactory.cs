using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Symbols.Errors
{
    public class ErrorSymbolFactory : SymbolFactory<ErrorSymbolInfo>
    {
        public ErrorSymbolFactory() 
        {
        }

        public override string? GetName(ErrorSymbolInfo underlyingObject, DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return underlyingObject.Name;
        }

        public override string? GetMetadataName(ErrorSymbolInfo underlyingObject, DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return underlyingObject.MetadataName;
        }

        public override ImmutableArray<Symbol> CreateContainedSymbols(Symbol container, DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return ImmutableArray<Symbol>.Empty;
        }

        public override ImmutableArray<TValue> GetSymbolPropertyValues<TValue>(Symbol symbol, string symbolProperty, DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return ImmutableArray<TValue>.Empty;
        }

        public override void ComputeNonSymbolProperties(Symbol symbol, DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            // nop
        }

        protected override ErrorSymbolInfo? GetParentCore(ErrorSymbolInfo underlyingObject, DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return null;
        }

        protected override Symbol? CreateSymbolCore(Symbol container, ErrorSymbolInfo underlyingObject, DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
