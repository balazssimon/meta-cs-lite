using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.PooledObjects;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Binding
{
    public class ConstantBinder : ValueBinder
    {
        private readonly object? _value;

        public ConstantBinder(object? value)
            : base(value?.GetType() ?? typeof(object))
        {
            _value = value;
        }

        public object? Value => _value;

        protected override ImmutableArray<SingleDeclaration> BuildDeclarationTree(SingleDeclarationBuilder builder)
        {
            return ImmutableArray<SingleDeclaration>.Empty;
        }

        protected override ImmutableArray<object?> ComputeValues(MetaType expectedType, DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return ImmutableArray.Create(Value);
        }

        public override string ToString()
        {
            var builder = PooledStringBuilder.GetInstance();
            var sb = builder.Builder;
            sb.Append(this.GetType().Name);
            sb.Append(": [");
            sb.Append(Value);
            sb.Append("]");
            return builder.ToStringAndFree();
        }
    }
}
