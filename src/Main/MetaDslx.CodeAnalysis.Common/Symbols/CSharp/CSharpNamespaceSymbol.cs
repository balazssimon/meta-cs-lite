using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis.Symbols.CSharp
{
    internal class CSharpNamespaceSymbol : NamespaceSymbol
    {
        private INamespaceSymbol _csharpSymbol;

        public CSharpNamespaceSymbol(INamespaceSymbol csharpSymbol)
        {
            _csharpSymbol = csharpSymbol;
        }

        public INamespaceSymbol CSharpSymbol => _csharpSymbol;
    }
}
