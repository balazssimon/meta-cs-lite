﻿using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.CodeAnalysis.Symbols;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Binding
{
    public class IdentifierBinder : QualifierBinder, IIdentifierBinder
    {
        private string? _name;
        private string? _metadataName;
        private ImmutableArray<object?> _symbols;

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

        protected sealed override ImmutableArray<object?> ComputeValues(MetaType expectedType, DiagnosticBag diagnostics, CancellationToken cancellationToken = default)
        {
            CacheNameAndMetadataName(cancellationToken);
            if (_symbols.IsDefault)
            {
                var qualifier = GetEnclosingQualifierBinder();
                ImmutableInterlocked.InterlockedInitialize(ref _symbols, ComputeValues(expectedType, qualifier, diagnostics, cancellationToken));
            }
            return _symbols;
        }

        protected virtual ImmutableArray<object?> ComputeValues(MetaType expectedType, IQualifierBinder? enclosingQualifier, DiagnosticBag diagnostics, CancellationToken cancellationToken = default)
        {
            if (enclosingQualifier is not null && enclosingQualifier != this)
            {
                var multiLookup = this.GetEnclosingMultiLookupBinder();
                var keys = multiLookup?.GetMultiLookupKeys(cancellationToken) ?? ImmutableArray<object>.Empty;
                if (!keys.IsDefaultOrEmpty)
                {
                    var symbols = ArrayBuilder<object?>.GetInstance();
                    foreach (var key in keys)
                    {
                        var symbol = enclosingQualifier.GetIdentifierSymbol(this, key, cancellationToken);
                        symbols.Add(symbol);
                        if (symbol is not null && symbol is DeclarationSymbol declaredSymbol && !declaredSymbol.IsErrorSymbol) MarkSymbolAsUsed(declaredSymbol);
                    }
                    return symbols.ToImmutableAndFree();
                }
                else
                {
                    var symbol = enclosingQualifier.GetIdentifierSymbol(this, null, cancellationToken);
                    return ImmutableArray.Create<object?>(symbol);
                }
            }
            else
            {
                return base.ComputeValues(expectedType, diagnostics, cancellationToken);
            }
        }

        public override string ToString()
        {
            var builder = PooledStringBuilder.GetInstance();
            var sb = builder.Builder;
            sb.Append(this.GetType().Name);
            if (!_symbols.IsDefaultOrEmpty)
            {
                var delim = ": ";
                foreach (var symbol in _symbols)
                {
                    sb.Append(delim);
                    sb.Append(symbol);
                    delim = ", ";
                }
            }
            return builder.ToStringAndFree();
        }
    }
}
