using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Binding
{
    public interface IPropertyBinder
    {
        string Name { get; }
        ImmutableArray<object?> ValuesOpt { get; }
        MetaType OwnerType { get; }
        MetaType Type { get; }
        ImmutableArray<IValueBinder> GetValueBinders(CancellationToken cancellationToken = default);
    }
}
