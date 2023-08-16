using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.CodeAnalysis.Symbols.Errors
{
    public class ErrorSymbolInfo
    {
        private readonly string _name;
        private readonly string _metadataName;
        private readonly ImmutableArray<Symbol> _symbols;
        private readonly Diagnostic _diagnostic;

        public ErrorSymbolInfo(string name, string metadataName, ImmutableArray<Symbol> symbols, Diagnostic diagnostic)
        {
            _name = name;
            _metadataName = metadataName;
            _symbols = symbols;
            _diagnostic = diagnostic;
        }

        public string Name => _name;
        public string MetadataName => _metadataName;
        public ImmutableArray<Symbol> Symbols => _symbols;
        public Diagnostic Diagnostic => _diagnostic;
    }
}
