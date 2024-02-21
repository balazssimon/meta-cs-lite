using MetaDslx.CodeAnalysis.Symbols;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis.Binding
{
    public struct AmbiguousSymbolsInfo
    {
        private readonly DeclarationSymbol _best;
        private readonly AmbiguousSymbolLocation _bestLocation;
        private readonly DeclarationSymbol _second;
        private readonly AmbiguousSymbolLocation _secondLocation;

        public AmbiguousSymbolsInfo(DeclarationSymbol best, AmbiguousSymbolLocation bestLocation, DeclarationSymbol second, AmbiguousSymbolLocation secondLocation)
        {
            _best = best;
            _bestLocation = bestLocation;
            _second = second;
            _secondLocation = secondLocation;
        }

        public DeclarationSymbol Best => _best;
        public AmbiguousSymbolLocation BestLocation => _bestLocation;
        public DeclarationSymbol Second => _second;
        public AmbiguousSymbolLocation SecondLocation => _secondLocation;
    }
}
