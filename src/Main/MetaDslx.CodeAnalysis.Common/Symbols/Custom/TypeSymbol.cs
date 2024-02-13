using System.Threading;
using System.Collections.Immutable;
using MetaDslx.Modeling;
using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.Symbols;

namespace MetaDslx.CodeAnalysis.Symbols.__Impl
{
    public partial class TypeSymbolImpl
    {
        public override ImmutableArray<TypeSymbol> Complete_AllBaseTypes(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public override (ImmutableArray<TypeSymbol>, ImmutableArray<TypeSymbol>) Complete_BaseTypes(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
