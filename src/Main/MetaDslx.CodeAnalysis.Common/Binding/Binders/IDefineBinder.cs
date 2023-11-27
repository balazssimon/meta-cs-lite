using MetaDslx.CodeAnalysis.Symbols;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.CodeAnalysis.Binding
{
    public interface IDefineBinder
    {
        ImmutableArray<Symbol> NestingSymbols { get; }
        ImmutableArray<Symbol> DefinedSymbols { get; }
    }
}
