using System.Threading;
using System.Collections.Immutable;
using MetaDslx.Modeling;
using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.Symbols;

namespace MetaDslx.CodeAnalysis.Symbols.__Impl
{
    public class ImportMetaModelSymbolImpl : ImportMetaModelSymbolBase
    {
        public override ImmutableArray<MetaModel> Complete_MetaModels(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
