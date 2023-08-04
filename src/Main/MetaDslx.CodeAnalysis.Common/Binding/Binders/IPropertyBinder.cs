﻿using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Binding
{
    public interface IPropertyBinder
    {
        string Name { get; }
        Type? GetValueType(BindingContext context);
        ImmutableArray<IValueBinder> GetValueBinders(ImmutableArray<IPropertyBinder> propertyBinders, CancellationToken cancellationToken = default);
    }
}
