using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis;
using Roslyn.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Text;
using System.Threading;
using System.Xml.Linq;

namespace MetaDslx.CodeAnalysis.Binding
{
    public class ValueBinder : Binder, IValueBinder
    {
        private MetaType _type;
        private string? _rawValue;

        public ValueBinder(MetaType type = default)
        {
            _type = type;
        }

        public MetaType Type
        {
            get
            {
                CacheRawValue();
                return _type;
            }
        }

        public string RawValue
        {
            get
            {
                CacheRawValue();
                return _rawValue;
            }
        }

        private void CacheRawValue(CancellationToken cancellationToken = default)
        {
            if (_rawValue is not null) return;
            var type = ComputeType(this.Diagnostics, cancellationToken);
            _type.InterlockedInitialize(type);
            var rawValue = ComputeRawValue(this.Diagnostics, cancellationToken) ?? string.Empty;
            Interlocked.CompareExchange(ref _rawValue, rawValue, null);
        }

        protected virtual string? ComputeRawValue(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return this.Syntax.ToString();
        }

        protected virtual MetaType ComputeType(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return _type;
        }

        protected override ImmutableArray<SingleDeclaration> BuildDeclarationTree(SingleDeclarationBuilder builder)
        {
            return ImmutableArray<SingleDeclaration>.Empty;
        }

        protected sealed override ImmutableArray<object?> BindValues(CancellationToken cancellationToken = default)
        {
            var propertyBinder = GetEnclosingPropertyBinder();
            var expectedType = propertyBinder?.Type ?? Type;
            return ComputeValues(expectedType, cancellationToken);
        }

        private ImmutableArray<object?> ComputeValues(MetaType expectedType, CancellationToken cancellationToken)
        {
            var diagnostics = DiagnosticBag.GetInstance();
            var values = ComputeValues(expectedType, diagnostics, cancellationToken);
            AddDiagnostics(diagnostics);
            diagnostics.Free();
            return values;
        }

        protected virtual ImmutableArray<object?> ComputeValues(MetaType expectedType, DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            if (Compilation.SymbolValueConverter.TryConvertTo(RawValue, expectedType, out var convertedValue, this, diagnostics, cancellationToken))
            {
                return ImmutableArray.Create(convertedValue);
            }
            else
            {
                diagnostics.Add(Diagnostic.Create(CommonErrorCode.ERR_BindingError, this.Location, $"Could not convert value '{RawValue}' to type '{expectedType}'."));
                return ImmutableArray<object?>.Empty;
            }
        }

        public override string ToString()
        {
            var builder = PooledStringBuilder.GetInstance();
            var sb = builder.Builder;
            sb.Append(this.GetType().Name);
            sb.Append(": [");
            sb.Append(_rawValue);
            sb.Append(": ");
            sb.Append(_type);
            sb.Append("]");
            return builder.ToStringAndFree();
        }
    }
}
