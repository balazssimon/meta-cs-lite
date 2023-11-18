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
        private readonly Type? _type;
        private string? _rawValue;
        private ImmutableArray<Diagnostic> _rawValueDiagnostics;

        public ValueBinder(Type? type = null)
        {
            _type = type;
        }

        public Type? Type => _type;

        public string RawValue
        {
            get
            {
                CacheRawValue(default);
                return _rawValue;
            }
        }

        private void CacheRawValue(CancellationToken cancellationToken = default)
        {
            var rawValue = ComputeRawValue(cancellationToken) ?? string.Empty;
            Interlocked.CompareExchange(ref _rawValue, rawValue, null);
        }

        protected virtual string? ComputeRawValue(CancellationToken cancellationToken = default)
        {
            return this.Syntax.ToString();
        }

        protected override ImmutableArray<SingleDeclaration> BuildDeclarationTree(SingleDeclarationBuilder builder)
        {
            return ImmutableArray<SingleDeclaration>.Empty;
        }

        protected override void CollectNameBinders(ArrayBuilder<INameBinder> nameBinders, CancellationToken cancellationToken)
        {
        }

        protected override void CollectQualifierBinders(ArrayBuilder<IQualifierBinder> qualifierBinders, CancellationToken cancellationToken)
        {
        }

        protected override void CollectIdentifierBinders(ArrayBuilder<IIdentifierBinder> identifierBinders, CancellationToken cancellationToken)
        {
        }

        protected override void CollectValueBinders(IPropertyBinder propertyBinder, ArrayBuilder<IValueBinder> valueBinders, CancellationToken cancellationToken)
        {
            valueBinders.Add(this);
        }

        protected override ImmutableArray<object?> BindValues(CancellationToken cancellationToken = default)
        {
            return ImmutableArray.Create(ComputeValue(cancellationToken));
        }

        private object? ComputeValue(CancellationToken cancellationToken)
        {
            CacheRawValue(cancellationToken);
            var propertyBinder = GetEnclosingPropertyBinder();
            if (propertyBinder is null)
            {
                AddDiagnostic(Diagnostic.Create(CommonErrorCode.ERR_BindingError, Location, $"Value '{RawValue}' is not enclosed in an IPropertyBinder."));
            }
            else
            {
                var expectedType = propertyBinder.GetValueType(cancellationToken);
                if (ComputeValue(expectedType, out var value, cancellationToken))
                {
                    return value;
                }
                else
                {
                    AddDiagnostic(Diagnostic.Create(CommonErrorCode.ERR_BindingError, Location, $"Value '{RawValue}' cannot be converted to type '{expectedType.FullName}'. Are you missing a TypeConverter?"));
                }
            }
            return null;
        }

        protected virtual bool ComputeValue(MetaType expectedType, out object? value, CancellationToken cancellationToken)
        {
            if (expectedType == typeof(MetaType))
            {
                value = MetaType.FromName(RawValue);
                return true;
            }
            else
            {
                return Language.SyntaxFacts.TryExtractValue(expectedType, RawValue, out value);
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
