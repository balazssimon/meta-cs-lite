using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Threading;
using MetaDslx.Modeling;
using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.Symbols;
using System.Diagnostics;

namespace MetaDslx.CodeAnalysis.Symbols.__Impl
{
    public class TypeSymbolImpl : TypeSymbolBase
    {
        public override ImmutableArray<TypeSymbol> Complete_AllBaseTypes(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return BaseTypes; // TODO
        }

        public override bool IsDerivedFrom(TypeSymbol type, TypeEqualityComparer comparison)
        {
            Debug.Assert(type is not null);
            if (object.ReferenceEquals(this.AsInstance<TypeSymbol>(), type)) return false;
            return AllBaseTypes.Any(t => comparison.Equals(t, type));
        }

        public override bool IsEqualToOrDerivedFrom(TypeSymbol type, TypeEqualityComparer comparison)
        {
            return comparison.Equals(this.AsInstance<TypeSymbol>(), type) || this.IsDerivedFrom(type, comparison);
        }
    }
}
