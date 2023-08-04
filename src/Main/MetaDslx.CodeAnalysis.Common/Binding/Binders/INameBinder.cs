using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Binding
{
    public interface INameBinder
    {
        ImmutableArray<IQualifierBinder> GetQualifierBinders(CancellationToken cancellationToken = default);
    }
}
