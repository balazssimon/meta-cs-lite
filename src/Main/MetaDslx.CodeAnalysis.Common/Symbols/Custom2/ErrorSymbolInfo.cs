using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.CodeAnalysis.Symbols
{
    public class ErrorSymbolInfo
    {
        private readonly Type _symbolType;
        private readonly string _name;
        private readonly string _metadataName;
        private readonly ImmutableArray<Symbol> _candidateSymbols;
        private readonly Diagnostic _diagnostic;

        public ErrorSymbolInfo(Type symbolType, string name, string metadataName, ImmutableArray<Symbol> candidateSymbols, Diagnostic diagnostic)
        {
            _symbolType = symbolType;
            _name = name;
            _metadataName = metadataName;
            _candidateSymbols = candidateSymbols;
            _diagnostic = diagnostic;
        }

        public Type SymbolType => _symbolType;
        public string Name => _name;
        public string MetadataName => _metadataName;
        public ImmutableArray<Symbol> CandidateSymbols => _candidateSymbols;
        public Diagnostic Diagnostic => _diagnostic;
        public Location Location => _diagnostic.Location;
    }
}
