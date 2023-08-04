using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis;
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

        private void CacheRawValue(BindingContext context)
        {
            if (_rawValueDiagnostics.IsDefault)
            {
                var computeContext = BindingContext.GetInstance(context.CancellationToken);
                var rawValue = ComputeRawValue(context) ?? string.Empty;
                Interlocked.CompareExchange(ref _rawValue, rawValue, null);
                ImmutableInterlocked.InterlockedInitialize(ref _rawValueDiagnostics, computeContext.ToDiagnosticsAndFree());
            }
            context.AddDiagnostics(_rawValueDiagnostics);
        }

        protected virtual string? ComputeRawValue(BindingContext context)
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

        protected override void CollectValueBinders(ImmutableArray<IPropertyBinder> propertyBinders, ArrayBuilder<IValueBinder> valueBinders, CancellationToken cancellationToken)
        {
            valueBinders.Add(this);
        }

        protected override ImmutableArray<object?> BindValues(BindingContext context)
        {
            return ImmutableArray.Create(ComputeValue(context));
        }

        protected virtual object? ComputeValue(BindingContext context)
        {
            CacheRawValue(context);
            var propertyBinder = GetEnclosingPropertyBinder();
            if (propertyBinder is null)
            {
                context.AddDiagnostic(Diagnostic.Create(ErrorCode.ERR_BindingError, Location, $"Value '{RawValue}' is not enclosed in an IPropertyBinder."));
            }
            var expectedType = propertyBinder?.GetValueType(context);
            if (expectedType is not null)
            {
                try
                {
                    var value = TypeDescriptor.GetConverter(expectedType).ConvertFromInvariantString(RawValue);
                    return value;
                }
                catch (NotSupportedException)
                {
                    context.AddDiagnostic(Diagnostic.Create(ErrorCode.ERR_BindingError, Location, $"Value '{RawValue}' cannot be converted to type '{expectedType.FullName}'. Are you missing a TypeConverter?"));
                }
                return null;
            }
            return null;
        }
    }
}
