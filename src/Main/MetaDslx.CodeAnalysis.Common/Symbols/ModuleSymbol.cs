using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.CodeAnalysis.Symbols
{
    public abstract class ModuleSymbol : Symbol
    {
        public override ImmutableArray<Location> Locations => ImmutableArray<Location>.Empty;
        public override ImmutableArray<SyntaxNodeOrToken> DeclaringSyntax => ImmutableArray<SyntaxNodeOrToken>.Empty;
    }
}
