using MetaDslx.CodeAnalysis.Symbols.Errors;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.CodeAnalysis.Symbols
{
    public interface IErrorSymbol
    {
        ErrorSymbolInfo ErrorInfo { get; }
        ImmutableArray<Symbol> CandidateSymbols { get; }
    }
}
