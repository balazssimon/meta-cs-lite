using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.CodeAnalysis.Symbols;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Binding
{
    public class IdentifierBinder : Binder, IQualifierBinder, IIdentifierBinder, IValueBinder
    {
        private string? _name;
        private string? _metadataName;
        private ImmutableArray<Diagnostic> _nameDiagnostics;

        protected override ImmutableArray<SingleDeclaration> BuildDeclarationTree(SingleDeclarationBuilder builder)
        {
            builder.AddIdentifier(this.Name, this.MetadataName, this.Location);
            return ImmutableArray<SingleDeclaration>.Empty;
        }

        public string Name
        {
            get
            {
                CacheNameAndMetadataName(default);
                return _name;
            }
        }

        public string MetadataName
        {
            get
            {
                CacheNameAndMetadataName(default);
                return _metadataName;
            }
        }

        public string GetName(BindingContext context)
        {
            CacheNameAndMetadataName(context);
            return this.Name;
        }

        public string GetMetadataName(BindingContext context)
        {
            CacheNameAndMetadataName(context);
            return this.MetadataName;
        }

        private void CacheNameAndMetadataName(BindingContext context)
        {
            if (_nameDiagnostics.IsDefault)
            {
                var computeContext = BindingContext.GetInstance(context.CancellationToken);
                var name = ComputeName(context) ?? string.Empty;
                var metadataName = ComputeMetadataName(context) ?? string.Empty;
                Interlocked.CompareExchange(ref _name, name, null);
                Interlocked.CompareExchange(ref _metadataName, metadataName, null);
                ImmutableInterlocked.InterlockedInitialize(ref _nameDiagnostics, computeContext.ToDiagnosticsAndFree());
            }
            context.AddDiagnostics(_nameDiagnostics);
        }

        protected virtual string? ComputeName(BindingContext context)
        {
            return this.Syntax.ToString();
        }

        protected virtual string? ComputeMetadataName(BindingContext context)
        {
            return ComputeName(context);
        }

        protected override void CollectNameBinders(ArrayBuilder<INameBinder> nameBinders, CancellationToken cancellationToken)
        {
        }

        protected override void CollectQualifierBinders(ArrayBuilder<IQualifierBinder> qualifierBinders, CancellationToken cancellationToken)
        {
            qualifierBinders.Add(this);
        }

        protected override void CollectIdentifierBinders(ArrayBuilder<IIdentifierBinder> identifierBinders, CancellationToken cancellationToken)
        {
            identifierBinders.Add(this);
        }

        protected override void CollectValueBinders(ImmutableArray<IPropertyBinder> propertyBinders, ArrayBuilder<IValueBinder> valueBinders, CancellationToken cancellationToken)
        {
            valueBinders.Add(this);
        }

        protected override ImmutableArray<object?> BindValues(BindingContext context)
        {
            CacheNameAndMetadataName(context);
            context.Diagnostics.AddRange(_nameDiagnostics);
            // TODO:MetaDslx
            return base.BindValues(context);
        }

        public Symbol? GetIdentifierSymbol(BindingContext context, IIdentifierBinder identifier)
        {
            // TODO:MetaDslx
            throw new NotImplementedException();
        }
    }
}
