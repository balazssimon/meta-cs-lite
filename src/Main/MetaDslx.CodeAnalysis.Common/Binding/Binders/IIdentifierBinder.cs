using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Binding
{
    public interface IIdentifierBinder
    {
        string GetName(BindingContext context);
        string GetMetadataName(BindingContext context);
    }
}
