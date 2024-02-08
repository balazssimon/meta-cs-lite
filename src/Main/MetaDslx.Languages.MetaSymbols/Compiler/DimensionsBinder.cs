using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Binding;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;
using System.Threading;

namespace MetaDslx.Languages.MetaSymbols.Compiler
{
    internal class DimensionsBinder : ValueBinder
    {
        protected override ImmutableArray<object?> ComputeValues(MetaType expectedType, DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return base.ComputeValues(expectedType, diagnostics, cancellationToken);
        }
    }
}
