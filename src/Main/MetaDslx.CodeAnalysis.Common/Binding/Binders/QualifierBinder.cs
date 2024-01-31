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
    public class QualifierBinder : ValueBinder, IQualifierBinder
    {
        private ImmutableArray<IIdentifierBinder> _identifiers;
        private object? _symbols;

        protected override ImmutableArray<SingleDeclaration> BuildDeclarationTree(SingleDeclarationBuilder builder)
        {
            builder.BeginQualifier();
            try
            {
                return BuildChildDeclarationTree(builder);
            }
            finally
            {
                builder.EndQualifier();
            }
        }

        public ImmutableArray<IIdentifierBinder> GetIdentifierBinders(CancellationToken cancellationToken = default)
        {
            if (!IsTopMostQualifier) return ImmutableArray<IIdentifierBinder>.Empty;
            var identifierBinders = ArrayBuilder<IIdentifierBinder>.GetInstance();
            var queue = ArrayBuilder<Binder>.GetInstance();
            queue.Add(this);
            int i = 0;
            while (i < queue.Count)
            {
                var binder = queue[i];
                var addChildren = true;
                if (binder is IIdentifierBinder identifierBinder)
                {
                    identifierBinders.Add(identifierBinder);
                    addChildren = false;
                }
                else if (binder is IQualifierBinder)
                {
                    addChildren = true;
                }
                else if (binder is IValueBinder || binder is IScopeBinder)
                {
                    addChildren = false;
                }
                if (addChildren)
                {
                    foreach (var child in binder.GetChildBinders(false, cancellationToken))
                    {
                        queue.Add(child);
                    }
                }
                ++i;
            }
            queue.Free();
            return identifierBinders.ToImmutableAndFree();
        }

        protected override ImmutableArray<object?> ComputeValues(MetaType expectedType, DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            CacheIdentifiers(cancellationToken);
            if (_symbols is ImmutableArray<Symbol> symbolArray)
            {
                if (symbolArray.Length > 0) return ImmutableArray.Create<object?>(symbolArray[symbolArray.Length - 1]);
                else return ImmutableArray<object?>.Empty;
            }
            else if (_symbols is ImmutableDictionary<object, ImmutableArray<Symbol?>> symbolDictionary)
            {
                var result = ArrayBuilder<object?>.GetInstance();
                var multiLookup = this.GetEnclosingMultiLookupBinder();
                var keys = multiLookup?.GetMultiLookupKeys(cancellationToken) ?? ImmutableArray<object>.Empty;
                if (!keys.IsDefaultOrEmpty)
                {
                    foreach (var key in keys)
                    {
                        var symbolDictionaryArray = symbolDictionary[key];
                        if (symbolDictionaryArray.Length > 0) result.Add(symbolDictionaryArray[symbolDictionaryArray.Length - 1]);
                        else result.Add(null);
                    }
                }
                return result.ToImmutableAndFree();
            }
            return ImmutableArray<object?>.Empty;
        }

        public bool IsTopMostQualifier => GetEnclosingQualifierBinder() == this;

        public bool IsName => GetEnclosingNameBinder() is not null;

        private void CacheIdentifiers(CancellationToken cancellationToken)
        {
            if (_identifiers.IsDefault)
            {
                var identifiers = IsTopMostQualifier ? (this is IdentifierBinder identifier ? ImmutableArray.Create<IIdentifierBinder>(identifier) : GetIdentifierBinders(cancellationToken)) : ImmutableArray<IIdentifierBinder>.Empty;
                ImmutableInterlocked.InterlockedInitialize(ref _identifiers, identifiers);
            }
            if (_symbols is null)
            {
                var symbols = _identifiers.Length > 0 ? (IsName ? ResolveDefinition(cancellationToken) : ResolveUse(cancellationToken)) : ImmutableArray<Symbol?>.Empty;
                Interlocked.CompareExchange(ref _symbols, symbols, null);
            }
        }

        private ImmutableArray<Symbol?> ResolveDefinition(CancellationToken cancellationToken)
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
                    result[i] = Compilation[Language].ErrorSymbolFactory.CreateSymbol<DeclarationSymbol>(container, new ErrorSymbolInfo(name, metadataName, ImmutableArray<Symbol>.Empty, Diagnostic.Create(CommonErrorCode.ERR_DeclarationError, location, $"Could not create declaration '{name}.'")));
                }
            }
            return result.ToImmutableArray();
        }

        private object ResolveUse(CancellationToken cancellationToken)
        {
            var identifiers = _identifiers.SelectAsArray(b => ((Binder)b).Syntax);
            var multiLookup = this.GetEnclosingMultiLookupBinder();
            var keys = multiLookup?.GetMultiLookupKeys(cancellationToken) ?? ImmutableArray<object>.Empty;
            if (!keys.IsDefaultOrEmpty)
            {
                var result = ImmutableDictionary.CreateBuilder<object, ImmutableArray<Symbol?>>();
                var lookupContext = this.AllocateLookupContext();
                foreach (var key in keys)
                {
                    lookupContext.Clear();
                    lookupContext.Diagnose = true;
                    lookupContext.MultiLookupKey = key;
                    var symbols = this.BindQualifiedName(lookupContext, identifiers);
                    AddDiagnostics(lookupContext.Diagnostics);
                    result.Add(key, symbols.Cast<DeclarationSymbol, Symbol>());
                }
                lookupContext.Free();
                return result.ToImmutable();
            }
            else
            {
                var lookupContext = this.AllocateLookupContext(diagnose: true);
                var symbols = this.BindQualifiedName(lookupContext, identifiers);
                AddDiagnostics(lookupContext.Diagnostics);
                lookupContext.Free();
                return symbols.Cast<DeclarationSymbol, Symbol>();
            }
        }

        public Symbol? GetIdentifierSymbol(IIdentifierBinder identifier, object? multiLookupKey, CancellationToken cancellationToken = default)
        {
            CacheIdentifiers(cancellationToken);
            var index = _identifiers.IndexOf(identifier);
            if (_symbols is ImmutableArray<Symbol> symbolArray)
            {
                if (multiLookupKey is not null) return null;
                if (index >= 0 && symbolArray.Length > index) return symbolArray[index];
            }
            else if (_symbols is ImmutableDictionary<object, ImmutableArray<Symbol?>> symbolDictionary)
            {
                if (symbolDictionary.TryGetValue(multiLookupKey, out var symbolDictionaryArray))
                {
                    if (index >= 0 && symbolDictionaryArray.Length > index) return symbolDictionaryArray[index];
                }
            }
            return null;
        }

        public override string ToString()
        {
            var builder = PooledStringBuilder.GetInstance();
            var sb = builder.Builder;
            sb.Append(this.GetType().Name);
            if (_symbols is ImmutableArray<Symbol> symbolArray)
            {
                sb.Append(": [");
                var delim = string.Empty;
                foreach (var symbol in symbolArray)
                {
                    sb.Append(delim);
                    sb.Append(symbol);
                    delim = ".";
                }
                sb.Append("]");
            }
            else if (_symbols is ImmutableDictionary<object, ImmutableArray<Symbol?>> symbolDictionary)
            {
                sb.Append(": ");
                foreach (var key in symbolDictionary.Keys)
                {
                    sb.Append("{");
                    sb.Append(key);
                    sb.Append(":");
                    var symbolDictionaryArray = symbolDictionary[key];
                    sb.Append("[");
                    var delim = string.Empty;
                    foreach (var symbol in symbolDictionaryArray)
                    {
                        sb.Append(delim);
                        sb.Append(symbol);
                        delim = ".";
                    }
                    sb.Append("]");
                    sb.Append("}");
                }
            }
            return builder.ToStringAndFree();
        }
    }
}
