using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.CodeAnalysis.Symbols.Source;
using MetaDslx.Modeling;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Symbols.Model
{
    public class ModelSymbolFactory
    {
        private readonly Dictionary<Type, Func<Symbol, IModelObject, Symbol>> _constructors = new();
        private readonly ConcurrentDictionary<object, Symbol> _symbols = new();
        private readonly Compilation _compilation;

        public ModelSymbolFactory(Compilation compilation)
        {
            Register<AttributeSymbol>((s, mo) => new ModelAttributeSymbol(s, mo));
            Register<NamespaceSymbol>((s, mo) => new ModelNamespaceSymbol(s, mo));
            Register<TypeSymbol>((s, mo) => new ModelTypeSymbol(s, mo));
            Register<DeclaredSymbol>((s, mo) => new ModelDeclaredSymbol(s, mo));
        }

        protected void Register<TSymbol>(Func<Symbol, IModelObject, TSymbol> constructor)
            where TSymbol : Symbol
        {
            _constructors.Add(typeof(TSymbol), constructor);
        }

        internal void AddSymbol(MetaDslx.Modeling.Model model, Symbol symbol)
        {
            _symbols.TryAdd(model, symbol);
        }

        internal void AddSymbol(IModelObject model, Symbol symbol)
        {
            _symbols.TryAdd(model, symbol);
        }

        public Symbol? GetSymbol(IModelObject? modelObject)
        {
            if (modelObject is null) return null;
            if (_symbols.TryGetValue(modelObject, out var oldSymbol))
            {
                return oldSymbol;
            }
            else
            {
                var symbolType = modelObject.SymbolType;
                if (symbolType is null) return null;
                Symbol? container = null;
                if (modelObject.Parent is not null)
                {
                    container = GetSymbol(modelObject.Parent);
                }
                else
                {
                    if (_symbols.TryGetValue(modelObject.Model, out var moduleSymbol)) container = moduleSymbol;
                }
                if (container is null) return null;
                return CreateSymbol(symbolType, container, modelObject);
            }
        }

        public TSymbol? GetSymbol<TSymbol>(IModelObject? modelObject)
            where TSymbol : Symbol
        {
            return GetSymbol(modelObject) as TSymbol;
        }

        public ImmutableArray<TSymbol> GetSymbols<TSymbol>(IEnumerable<IModelObject?> modelObjects)
            where TSymbol : Symbol
        {
            var builder = ArrayBuilder<TSymbol>.GetInstance();
            foreach (var modelObject in modelObjects)
            {
                var symbol = GetSymbol(modelObject);
                if (symbol is TSymbol typedSymbol) builder.Add(typedSymbol);
            }
            return builder.ToImmutableAndFree();
        }

        public ImmutableArray<Symbol> CreateChildSymbols(IModelObject? modelObject)
        {
            return GetSymbols<Symbol>(modelObject.Children);
        }

        public ImmutableArray<DeclaredSymbol> GetMemberSymbols(IModelObject? modelObject)
        {
            if (modelObject is null) return ImmutableArray<DeclaredSymbol>.Empty;
            return GetSymbols<DeclaredSymbol>(modelObject.Children);
        }

        public ImmutableArray<TValue> GetSymbolPropertyValues<TValue>(IModelObject? modelObject, string symbolProperty, DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            if (modelObject is null) return ImmutableArray<TValue>.Empty;
            var builder = ArrayBuilder<TValue>.GetInstance();
            foreach (var prop in modelObject.PublicProperties.Where(prop => prop.SymbolProperty == symbolProperty))
            {
                if (typeof(Symbol).IsAssignableFrom(typeof(TValue)))
                {
                    foreach (var item in modelObject.GetValues(prop))
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        if (item is null) continue;
                        Symbol? symbolItem = null;
                        if (item is IModelObject mobj) symbolItem = GetSymbol(mobj);
                        else if (item is MetaType mtype) symbolItem = mtype.AsTypeSymbol(_compilation);
                        else if (item is Type type) symbolItem = symbolItem = _compilation.ResolveType(type.FullName);
                        if (symbolItem is TValue typedSymbol)
                        {
                            builder.Add(typedSymbol);
                        }
                        else
                        {
                            diagnostics.Add(Diagnostic.Create(CommonErrorCode.ERR_InvalidSymbolPropertyValue, null, symbolItem, symbolItem?.GetType(), symbolProperty, typeof(TValue)));
                        }
                    }
                }
                else
                {
                    foreach (var item in modelObject.GetValues(prop))
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        var value = item;
                        if (item is MetaType mtype)
                        {
                            if (typeof(TValue) == typeof(Type)) value = mtype.AsType();
                            if (typeof(TValue) == typeof(string)) value = mtype.FullName;
                            if (typeof(IModelObject).IsAssignableFrom(typeof(TValue))) value = mtype.OriginalModelObject;
                        }
                        if (value is TValue typedValue)
                        {
                            builder.Add(typedValue);
                        }
                        else
                        {
                            diagnostics.Add(Diagnostic.Create(CommonErrorCode.ERR_InvalidSymbolPropertyValue, null, item, item?.GetType(), symbolProperty, typeof(TValue)));
                        }
                    }
                }
            }
            return builder.ToImmutableAndFree();
        }

        public TValue GetSymbolPropertyValue<TValue>(IModelObject? modelObject, string symbolProperty, DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            var values = GetSymbolPropertyValues<TValue>(modelObject, symbolProperty, diagnostics, cancellationToken);
            if (values.Length == 1) return values[0];
            else if (values.Length == 0) return default;
            else
            {
                var first = values[0];
                for (int i = 1; i < values.Length; i++)
                {
                    var next = values[i];
                    if (first is null)
                    {
                        if (next is not null)
                        {
                            first = next;
                        }
                    }
                    else
                    {
                        if (!first.Equals(next))
                        {
                            diagnostics.Add(Diagnostic.Create(CommonErrorCode.ERR_AmbigValue, null, symbolProperty, first, next));
                        }
                    }
                }
                return first;
            }
        }

        protected Symbol? CreateSymbol(Type symbolType, Symbol container, IModelObject modelObject)
        {
            if (_symbols.TryGetValue(modelObject, out var oldSymbol))
            {
                return oldSymbol;
            }
            else if (_constructors.TryGetValue(symbolType, out var constructor))
            {
                var newSymbol = constructor(container, modelObject);
                return _symbols.GetOrAdd(modelObject, newSymbol);
            }
            else
            {
                return null;
            }
        }
    }
}
