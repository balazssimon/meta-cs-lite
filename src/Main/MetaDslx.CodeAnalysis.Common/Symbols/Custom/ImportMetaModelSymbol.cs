using System.Threading;
using System.Collections.Immutable;
using MetaDslx.Modeling;
using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.Symbols;
using System;

namespace MetaDslx.CodeAnalysis.Symbols.__Impl
{
    public partial class ImportMetaModelSymbolImpl
    {
        public override ImmutableArray<Modeling.MetaModel> Complete_MetaModels(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
