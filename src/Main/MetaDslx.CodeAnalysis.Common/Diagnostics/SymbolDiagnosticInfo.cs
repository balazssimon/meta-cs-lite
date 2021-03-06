using MetaDslx.CodeAnalysis.Symbols;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.CodeAnalysis
{
    public class SymbolDiagnosticInfo : DiagnosticInfo
    {
        // not serialized:
        private readonly ImmutableArray<Symbol> _symbols;
        // not serialized:
        private readonly ImmutableArray<Location> _additionalLocations;

        public SymbolDiagnosticInfo(DiagnosticDescriptor descriptor, params object[] arguments)
            : base(descriptor, arguments)
        {
            _symbols = ImmutableArray<Symbol>.Empty;
            _additionalLocations = ImmutableArray<Location>.Empty;
        }

        public SymbolDiagnosticInfo(ImmutableArray<Symbol> symbols, DiagnosticDescriptor descriptor, params object[] arguments)
            : base(descriptor, arguments)
        {
            _symbols = symbols;
            _additionalLocations = ImmutableArray<Location>.Empty;
        }

        public SymbolDiagnosticInfo(ImmutableArray<Symbol> symbols, DiagnosticDescriptor descriptor, ImmutableArray<Location> additionalLocations, params object[] arguments)
            : base(descriptor, arguments)
        {
            _symbols = symbols;
            _additionalLocations = additionalLocations;
        }

        public virtual ImmutableArray<Symbol> Symbols => _symbols;

        public override IReadOnlyList<Location> AdditionalLocations => _additionalLocations;
    }
}
