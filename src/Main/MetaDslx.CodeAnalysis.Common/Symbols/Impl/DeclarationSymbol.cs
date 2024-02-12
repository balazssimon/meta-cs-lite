using System.Threading;
using System.Collections.Immutable;
using MetaDslx.Modeling;
using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.Symbols;

namespace MetaDslx.CodeAnalysis.Symbols
{
    internal partial class DeclarationSymbolImpl : DeclarationSymbolBase
    {
        protected override ImmutableArray<DeclarationSymbol> Complete_Members(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
