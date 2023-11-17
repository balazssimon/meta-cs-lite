using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis.Symbols.CSharp
{
    public interface ICSharpSymbol
    {
        ISymbol CSharpSymbol { get; }
        CSharpSymbolFactory SymbolFactory { get; }
    }
}
