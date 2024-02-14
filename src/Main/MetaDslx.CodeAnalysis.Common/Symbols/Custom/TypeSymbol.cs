using System.Threading;
using System.Collections.Immutable;
using MetaDslx.Modeling;
using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.Symbols;

namespace MetaDslx.CodeAnalysis.Symbols.__Impl
{
    public class TypeSymbolImpl : TypeSymbolBase
    {
        public override (ImmutableArray<TypeSymbol> BaseTypes, ImmutableArray<TypeSymbol> AllBaseTypes) Complete_BaseTypes(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public override ImmutableArray<DeclarationSymbol> Complete_Members(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
