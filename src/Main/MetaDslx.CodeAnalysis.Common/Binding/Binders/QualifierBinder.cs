using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.CodeAnalysis.Symbols;
using MetaDslx.CodeAnalysis.Symbols.Errors;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
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

        protected override ImmutableArray<object?> BindValues(CancellationToken cancellationToken = default)
        {
            CacheIdentifiers(cancellationToken);
            if (_symbols.Length > 0) return ImmutableArray.Create<object?>(_symbols[_symbols.Length - 1]);
            else return ImmutableArray<object?>.Empty;
        }

        public bool IsTopMostQualifier => GetEnclosingQualifierBinder() == this;

        public bool IsName => GetEnclosingNameBinder() is not null;

        private void CacheIdentifiers(CancellationToken cancellationToken = default)
        {
            if (_identifiers.IsDefault)
            {
                var identifiers = IsTopMostQualifier ? (this is IdentifierBinder identifier ? ImmutableArray.Create<IIdentifierBinder>(identifier) : GetIdentifierBinders(cancellationToken)) : ImmutableArray<IIdentifierBinder>.Empty;
                ImmutableInterlocked.InterlockedInitialize(ref _identifiers, identifiers);
            }
            if (_symbols.IsDefault)
            {
                var symbols = _identifiers.Length > 0 ? (IsName ? ResolveDefinition(cancellationToken) : ResolveUse(cancellationToken)) : ImmutableArray<Symbol?>.Empty;
                ImmutableInterlocked.InterlockedInitialize(ref _symbols, symbols);
            }
        }

        private ImmutableArray<Symbol?> ResolveDefinition(CancellationToken cancellationToken = default)
        {
            var result = new Symbol?[_identifiers.Length];
            var lastIdentifier = (Binder)_identifiers[_identifiers.Length - 1];
            foreach (var symbol in ContainingDefinedSymbols)
            {
                foreach (var decl in symbol.GetSingleDeclarations(cancellationToken))
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
            }
            if (result.Length > 0 && result[0] is null)
            {
                var container = this.ContainingDefinedSymbols.FirstOrDefault();
                i = 0;
                while (i < result.Length && result[i] is null)
                {
                    var name = _identifiers[i].GetName(cancellationToken);
                    var metadataName = _identifiers[i].GetMetadataName(cancellationToken);
                    var location = ((Binder)_identifiers[i]).Location;
                    result[i] = Compilation[Language].ErrorSymbolFactory.CreateSymbol<DeclaredSymbol>(container, new ErrorSymbolInfo(name, metadataName, ImmutableArray<Symbol>.Empty, Diagnostic.Create(CommonErrorCode.ERR_DeclarationError, location, $"Could not create declaration '{name}.'")));
                }
            }
            return result.ToImmutableArray();
        }

        private ImmutableArray<Symbol?> ResolveUse(CancellationToken cancellationToken = default)
        {
            var lookupContext = this.AllocateLookupContext(diagnose: true);
            var identifiers = _identifiers.SelectAsArray(b => ((Binder)b).Syntax);
            var symbols = this.BindQualifiedName(lookupContext, identifiers);
            AddDiagnostics(lookupContext.Diagnostics);
            return symbols.Cast<DeclaredSymbol,Symbol>();
        }

        public Symbol? GetIdentifierSymbol(IIdentifierBinder identifier, CancellationToken cancellationToken = default)
        {
            CacheIdentifiers(cancellationToken);
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
