using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Binding;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Roslyn.Utilities;

namespace MetaDslx.Bootstrap.MetaCompiler2.Symbols
{
    public class DecodeStringBinder : ValueBinder
    {
        protected override ImmutableArray<object?> ComputeValues(MetaType expectedType, DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            if (RawValue.StartsWith('\'') && RawValue.EndsWith('\'') ||
                RawValue.StartsWith('"') && RawValue.EndsWith('"'))
            {
                return ImmutableArray.Create<object?>(RawValue.DecodeString());
            }
            else
            {
                return ImmutableArray<object?>.Empty;
            }
        }
    }
}
