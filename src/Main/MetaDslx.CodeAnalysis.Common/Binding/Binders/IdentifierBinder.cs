using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.CodeAnalysis.Symbols;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Binding
{
    public class IdentifierBinder : QualifierBinder, IIdentifierBinder
    {
        private string? _name;
        private string? _metadataName;
        private ImmutableArray<Diagnostic> _nameDiagnostics;
        private Symbol? _symbol;

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

        protected override void CollectIdentifierBinders(ArrayBuilder<IIdentifierBinder> identifierBinders, CancellationToken cancellationToken)
        {
            identifierBinders.Add(this);
        }

        protected override ImmutableArray<object?> BindValues(BindingContext context)
        {
            CacheNameAndMetadataName(context);
            context.AddDiagnostics(_nameDiagnostics);
            CacheSymbol(context);
            if (_symbol is not null) return ImmutableArray.Create<object?>(_symbol);
            else return ImmutableArray<object?>.Empty;
        }

        private void CacheSymbol(BindingContext context)
        {
            if (_symbol is null)
            {
                var qualifier = GetEnclosingQualifierBinder();
                if (qualifier is not null)
                {
                    var symbol = qualifier.GetIdentifierSymbol(context, this);
                    Interlocked.CompareExchange(ref _symbol, symbol, null);
                }
            }
        }

        public override string ToString()
        {
            var builder = PooledStringBuilder.GetInstance();
            var sb = builder.Builder;
            sb.Append(this.GetType().Name);
            if (_symbol is not null)
            {
                sb.Append(": ");
                sb.Append(_symbol);
            }
            return builder.ToStringAndFree();
        }
    }
}
