using MetaDslx.CodeAnalysis.Symbols;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.CodeAnalysis
{
    public class SymbolDiagnosticInfo : DiagnosticInfo
    {
        private readonly ImmutableArray<Symbol> _symbols;
        private readonly ImmutableArray<Location> _additionalLocations;

        public SymbolDiagnosticInfo(string name, string metadataName, DiagnosticDescriptor descriptor, params object[] arguments)
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

        public SymbolDiagnosticInfo(ImmutableArray<Symbol> symbols, DiagnosticDescriptor descriptor, Location? additionalLocation, params object[] arguments)
            : base(descriptor, arguments)
        {
            _symbols = symbols;
            _additionalLocations = additionalLocation is not null ? ImmutableArray.Create(additionalLocation) : ImmutableArray<Location>.Empty;
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
