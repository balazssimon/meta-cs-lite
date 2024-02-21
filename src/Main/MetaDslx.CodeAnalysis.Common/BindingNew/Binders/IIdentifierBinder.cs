using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Binding
{
    public interface IIdentifierBinder
    {
        string GetName(CancellationToken cancellationToken = default);
        string GetMetadataName(CancellationToken cancellationToken = default);
    }
}
