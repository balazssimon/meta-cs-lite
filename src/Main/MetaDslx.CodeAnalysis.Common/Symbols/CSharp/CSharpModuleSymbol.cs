using Microsoft.CodeAnalysis;
using Roslyn.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.CodeAnalysis.Symbols.CSharp
{
    internal class CSharpModuleSymbol : ModuleSymbol
    {
        private IModuleSymbol _csharpSymbol;

        public CSharpModuleSymbol(CSharpAssemblySymbol containingAssembly, IModuleSymbol csharpSymbol)
            : base(containingAssembly)
        {
            _csharpSymbol = csharpSymbol;
        }

        public IModuleSymbol CSharpSymbol => _csharpSymbol;

        public override ImmutableArray<Location> Locations => _csharpSymbol.Locations.SelectAsArray(l => l.ToMetaDslx());

        public override ImmutableArray<SyntaxNodeOrToken> DeclaringSyntaxReferences => ImmutableArray<SyntaxNodeOrToken>.Empty;
    }
}
