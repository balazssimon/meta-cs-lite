using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.CodeAnalysis.Symbols;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Binding
{
    public class QualifierBinder : Binder, IQualifierBinder, IValueBinder
    {
        private ImmutableArray<IIdentifierBinder> _identifiers;
        private ImmutableArray<Symbol?> _symbols;

        protected override ImmutableArray<SingleDeclaration> BuildDeclarationTree(SingleDeclarationBuilder builder)
        {
            builder.BeginQualifier();
            try
            {
                return base.BuildDeclarationTree(builder);
            }
            finally
            {
                builder.EndQualifier();
            }
        }

        protected override void CollectNameBinders(ArrayBuilder<INameBinder> nameBinders, CancellationToken cancellationToken)
        {
        }

        protected override void CollectQualifierBinders(ArrayBuilder<IQualifierBinder> qualifierBinders, CancellationToken cancellationToken)
        {
            qualifierBinders.Add(this);
        }

        protected override void CollectValueBinders(IPropertyBinder propertyBinder, ArrayBuilder<IValueBinder> valueBinders, CancellationToken cancellationToken)
        {
            if (IsTopMostQualifier) valueBinders.Add(this);
        }

        protected override ImmutableArray<object?> BindValues(BindingContext context)
        {
            CacheIdentifiers(context);
            if (_identifiers.Length > 0) return ImmutableArray.Create<object?>(_identifiers[_identifiers.Length - 1]);
            else return ImmutableArray<object?>.Empty;
        }

        public bool IsTopMostQualifier => GetEnclosingQualifierBinder() == this;

        public bool IsName => GetEnclosingNameBinder() is not null;

        private void CacheIdentifiers(BindingContext context)
        {
            if (_identifiers.IsDefault)
            {
                var identifiers = IsTopMostQualifier ? GetIdentifierBinders(context.CancellationToken) : ImmutableArray<IIdentifierBinder>.Empty;
                ImmutableInterlocked.InterlockedInitialize(ref _identifiers, identifiers);
            }
            if (_symbols.IsDefault)
            {
                var symbols = _identifiers.Length > 0 ? (IsName ? ResolveDefinition(context) : ResolveUse(context)) : ImmutableArray<Symbol?>.Empty;
                ImmutableInterlocked.InterlockedInitialize(ref _symbols, symbols);
            }
        }

        private ImmutableArray<Symbol?> ResolveDefinition(BindingContext context)
        {
            var result = new Symbol?[_identifiers.Length];
            var lastIdentifier = (Binder)_identifiers[_identifiers.Length - 1];
            foreach (var symbol in ContainingDefinedSymbols)
            {
                foreach (var decl in symbol.GetSingleDeclarations(context.CancellationToken))
                {
                    if (decl.NameLocation == lastIdentifier.Location)
                    {
                        result[_identifiers.Length - 1] = symbol;
                        break;
                    }
                }
                if (result[_identifiers.Length - 1] is not null) break;
            }
            int i = _identifiers.Length - 1;
            while (i > 0)
            {
                var parent = result[i]?.ContainingSymbol;
                result[--i] = parent;
                //Debug.Assert(parent is null || parent.Locations.Contains(((Binder)_identifiers[i]).Location));
                Debug.Assert(parent is not null && parent.Locations.Contains(((Binder)_identifiers[i]).Location));
            }
            return result.ToImmutableArray();
        }

        private ImmutableArray<Symbol?> ResolveUse(BindingContext context)
        {
            return ImmutableArray<Symbol?>.Empty;
        }

        public Symbol? GetIdentifierSymbol(BindingContext context, IIdentifierBinder identifier)
        {
            CacheIdentifiers(context);
            var index = _identifiers.IndexOf(identifier);
            if (index >= 0 && _symbols.Length > index) return _symbols[index];
            else return null;
        }

        public override string ToString()
        {
            var builder = PooledStringBuilder.GetInstance();
            var sb = builder.Builder;
            sb.Append(this.GetType().Name);
            if (!_symbols.IsDefault)
            {
                sb.Append(": [");
                var delim = string.Empty;
                foreach (var symbol in _symbols)
                {
                    sb.Append(delim);
                    sb.Append(symbol);
                    delim = ".";
                }
                sb.Append("]");
            }
            return builder.ToStringAndFree();
        }
    }
}
