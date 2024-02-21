using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Binding
{
    public abstract class MultiLookupBinder : Binder, IMultiLookupBinder
    {
        public abstract ImmutableArray<object> GetMultiLookupKeys(CancellationToken cancellationToken = default);
    }
}
