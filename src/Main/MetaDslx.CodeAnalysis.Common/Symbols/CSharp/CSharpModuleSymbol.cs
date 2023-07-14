using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis.Symbols.CSharp
{
    internal class CSharpModuleSymbol : ModuleSymbol
    {
        private CSharpAssemblySymbol _containingAssembly;
        private IModuleSymbol _csharpSymbol;

        public CSharpModuleSymbol(CSharpAssemblySymbol containingAssembly, IModuleSymbol csharpSymbol)
        {
            _containingAssembly = containingAssembly;
            _csharpSymbol = csharpSymbol;
        }

        public IModuleSymbol CSharpSymbol => _csharpSymbol;
        public override Symbol? ContainingSymbol => _containingAssembly;
    }
}
