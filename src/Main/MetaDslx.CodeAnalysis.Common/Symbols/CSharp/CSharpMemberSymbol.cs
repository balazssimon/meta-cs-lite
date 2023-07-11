using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis.Symbols.CSharp
{
    internal class CSharpMemberSymbol : MemberSymbol
    {
        private ISymbol _csharpSymbol;

        public CSharpMemberSymbol(ISymbol csharpSymbol)
        {
            _csharpSymbol = csharpSymbol;
        }

        public ISymbol CSharpSymbol => _csharpSymbol;
    }
}
