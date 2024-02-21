using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.CodeAnalysis.Symbols
{
    public class ErrorSymbolInfo
    {
        private readonly string _name;
        private readonly string _metadataName;
        private readonly ImmutableArray<Symbol> _candidateSymbols;
        private readonly Diagnostic _diagnostic;

        public ErrorSymbolInfo(string name, string metadataName, ImmutableArray<Symbol> candidateSymbols, Diagnostic diagnostic)
        {
            _name = name;
            _metadataName = metadataName;
            _candidateSymbols = candidateSymbols;
            _diagnostic = diagnostic;
        }

        public string Name => _name;
        public string MetadataName => _metadataName;
        public ImmutableArray<Symbol> CandidateSymbols => _candidateSymbols;
        public Diagnostic Diagnostic => _diagnostic;
    }
}
