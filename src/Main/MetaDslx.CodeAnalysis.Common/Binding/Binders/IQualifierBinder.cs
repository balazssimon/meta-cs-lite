﻿using MetaDslx.CodeAnalysis.Symbols;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Binding
{
    public interface IQualifierBinder
    {
        bool IsName { get; }
        bool IsTopMostQualifier { get; }
        ImmutableArray<IIdentifierBinder> GetIdentifierBinders(CancellationToken cancellationToken = default);
        Symbol? GetIdentifierSymbol(IIdentifierBinder identifier, object? multiLookupKey, CancellationToken cancellationToken = default);
    }
}
