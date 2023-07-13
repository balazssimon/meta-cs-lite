using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis.Symbols.CSharp
{
    internal class CSharpModuleSymbol : ModuleSymbol
    {
        private IModuleSymbol _csharpSymbol;

        public CSharpModuleSymbol(IModuleSymbol csharpSymbol)
        {
            _csharpSymbol = csharpSymbol;
        }

        public IModuleSymbol CSharpSymbol => _csharpSymbol;
        public override Symbol? ContainingSymbol => null;
    }
}
