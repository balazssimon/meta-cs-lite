using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Globalization;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Symbols.CSharp
{
    internal class CSharpAssemblySymbol : AssemblySymbol
    {
        private IAssemblySymbol _csharpSymbol;

        public CSharpAssemblySymbol(IAssemblySymbol csharpSymbol)
        {
            _csharpSymbol = csharpSymbol;
        }

        public IAssemblySymbol CSharpSymbol => _csharpSymbol;

    }
}
