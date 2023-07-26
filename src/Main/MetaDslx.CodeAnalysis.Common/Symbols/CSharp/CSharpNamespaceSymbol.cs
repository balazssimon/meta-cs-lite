using Microsoft.CodeAnalysis;
using Roslyn.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Symbols.CSharp
{
    internal class CSharpNamespaceSymbol : NamespaceSymbol
    {
        private readonly INamespaceSymbol _csharpSymbol;

        public CSharpNamespaceSymbol(Symbol container, INamespaceSymbol csharpSymbol)
            : base(container)
        {
            _csharpSymbol = csharpSymbol;
        }

        public INamespaceSymbol CSharpSymbol => _csharpSymbol;
        public override ImmutableArray<Location> Locations => _csharpSymbol.Locations.SelectAsArray(l => l.ToMetaDslx());

        public override NamespaceExtent Extent => new NamespaceExtent(ContainingModule);

        protected override string? CompleteProperty_Name(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return _csharpSymbol.Name;
        }

        protected override string? CompleteProperty_MetadataName(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return _csharpSymbol.MetadataName;
        }
    }
}
