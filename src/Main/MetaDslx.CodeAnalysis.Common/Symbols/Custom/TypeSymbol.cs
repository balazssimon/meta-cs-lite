using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Threading;
using MetaDslx.Modeling;
using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.Symbols;

namespace MetaDslx.CodeAnalysis.Symbols.__Impl
{
    public class TypeSymbolImpl : TypeSymbolBase
    {
        public override (ImmutableArray<TypeSymbol> BaseTypes, ImmutableArray<TypeSymbol> AllBaseTypes) Complete_BaseTypes(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            SymbolFactory.GetSymbolPropertyValues<TypeSymbol>(this, nameof(BaseTypes), diagnostics, cancellationToken);
            throw new NotImplementedException();
        }
    }
}
