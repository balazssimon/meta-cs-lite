using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis.Symbols.CSharp
{
    internal class CSharpNamedTypeSymbol : NamedTypeSymbol
    {
        private INamedTypeSymbol _csharpSymbol;

        public CSharpNamedTypeSymbol(INamedTypeSymbol csharpSymbol)
        {
            _csharpSymbol = csharpSymbol;
        }

        public INamedTypeSymbol CSharpSymbol => _csharpSymbol;
    }
}
