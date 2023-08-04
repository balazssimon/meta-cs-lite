using MetaDslx.CodeAnalysis.Symbols;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Binding
{
    public interface IQualifierBinder
    {
        ImmutableArray<IIdentifierBinder> GetIdentifierBinders(CancellationToken cancellationToken = default);
        Symbol? GetIdentifierSymbol(BindingContext context, IIdentifierBinder identifier);
    }
}
