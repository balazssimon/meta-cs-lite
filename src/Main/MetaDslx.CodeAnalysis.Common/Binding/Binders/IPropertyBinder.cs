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
        Type? GetValueType(CancellationToken cancellationToken = default);
        ImmutableArray<IValueBinder> GetValueBinders(IPropertyBinder propertyBinder, CancellationToken cancellationToken = default);
    }
}
