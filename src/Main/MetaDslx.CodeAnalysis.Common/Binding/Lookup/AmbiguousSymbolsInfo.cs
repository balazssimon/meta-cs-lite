using MetaDslx.CodeAnalysis.Symbols;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis.Binding
{
    public struct AmbiguousSymbolsInfo
    {
        private readonly DeclaredSymbol _best;
        private readonly AmbiguousSymbolLocation _bestLocation;
        private readonly DeclaredSymbol _second;
        private readonly AmbiguousSymbolLocation _secondLocation;

        public AmbiguousSymbolsInfo(DeclaredSymbol best, AmbiguousSymbolLocation bestLocation, DeclaredSymbol second, AmbiguousSymbolLocation secondLocation)
        {
            _best = best;
            _bestLocation = bestLocation;
            _second = second;
            _secondLocation = secondLocation;
        }

        public DeclaredSymbol Best => _best;
        public AmbiguousSymbolLocation BestLocation => _bestLocation;
        public DeclaredSymbol Second => _second;
        public AmbiguousSymbolLocation SecondLocation => _secondLocation;
    }
}
