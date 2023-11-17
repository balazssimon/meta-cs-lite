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

        public string GetName(CancellationToken cancellationToken = default)
        {
            CacheNameAndMetadataName(cancellationToken);
            return this.Name;
        }

        public string GetMetadataName(CancellationToken cancellationToken = default)
        {
            CacheNameAndMetadataName(cancellationToken);
            return this.MetadataName;
        }

        private void CacheNameAndMetadataName(CancellationToken cancellationToken = default)
        {
            var name = ComputeName(cancellationToken) ?? string.Empty;
            var metadataName = ComputeMetadataName(cancellationToken) ?? string.Empty;
            Interlocked.CompareExchange(ref _name, name, null);
            Interlocked.CompareExchange(ref _metadataName, metadataName, null);
        }

        protected virtual string? ComputeName(CancellationToken cancellationToken = default)
        {
            return this.Language.SyntaxFacts.ExtractName(this.Syntax);
        }

        protected virtual string? ComputeMetadataName(CancellationToken cancellationToken = default)
        {
            return this.Language.SyntaxFacts.ExtractMetadataName(this.Syntax);
        }

        protected override void CollectIdentifierBinders(ArrayBuilder<IIdentifierBinder> identifierBinders, CancellationToken cancellationToken)
        {
            identifierBinders.Add(this);
        }

        protected override ImmutableArray<object?> BindValues(CancellationToken cancellationToken = default)
        {
            CacheNameAndMetadataName(cancellationToken);
            CacheSymbol(cancellationToken);
            if (_symbol is not null) return ImmutableArray.Create<object?>(_symbol);
            else return ImmutableArray<object?>.Empty;
        }

        private void CacheSymbol(CancellationToken cancellationToken = default)
        {
            if (_symbol is null)
            {
                var qualifier = GetEnclosingQualifierBinder();
                if (qualifier is not null)
                {
                    var symbol = qualifier.GetIdentifierSymbol(this, cancellationToken);
                    Interlocked.CompareExchange(ref _symbol, symbol, null);
                    if (symbol is not null && !symbol.IsError && symbol is DeclaredSymbol declaredSymbol) MarkSymbolAsUsed(declaredSymbol);
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
