using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Binding
{
    public interface IMultiLookupBinder
    {
        ImmutableArray<object> GetMultiLookupKeys(CancellationToken cancellationToken = default);
    }
}
