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
        private ImmutableArray<CSharpModuleSymbol> _modules;

        public CSharpAssemblySymbol(IAssemblySymbol csharpSymbol)
        {
            _csharpSymbol = csharpSymbol;
        }

        public IAssemblySymbol CSharpSymbol => _csharpSymbol;
        public override ImmutableArray<Symbol> ContainedSymbols => _modules.Cast<CSharpModuleSymbol, Symbol>();

        internal void DangerousSetModules(ImmutableArray<CSharpModuleSymbol> modules)
        {
            _modules = modules;
        }
    }
}
