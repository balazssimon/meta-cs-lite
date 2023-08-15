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

        public ModelSymbolFactory()
        {
            Register<NamespaceSymbol>((s, mo) => new ModelNamespaceSymbol(s, mo));
            Register<NamedTypeSymbol>((s, mo) => new ModelNamedTypeSymbol(s, mo));
            Register<DeclaredSymbol>((s, mo) => new ModelDeclaredSymbol(s, mo));
        }

        protected void Register<TSymbol>(Func<Symbol, IModelObject, TSymbol> constructor)
            where TSymbol : Symbol
        {
            _constructors.Add(typeof(TSymbol), constructor);
        }

        internal void AddSymbol(IModel model, Symbol symbol)
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

        public ImmutableArray<TSymbol> GetSymbolPropertyValues<TSymbol>(IModelObject? modelObject, string symbolProperty, DiagnosticBag diagnostics, CancellationToken cancellationToken)
            where TSymbol : Symbol
        {
            if (modelObject is null) return ImmutableArray<TSymbol>.Empty;
            var builder = ArrayBuilder<TSymbol>.GetInstance();
            var values = PooledHashSet<IModelObject>.GetInstance();
            foreach (var prop in modelObject.PublicProperties.Where(prop => prop.SymbolProperty == symbolProperty))
            {
                foreach (var item in modelObject.GetValues(prop).OfType<IModelObject>())
                {
                    cancellationToken.ThrowIfCancellationRequested();
                    if (values.Add(item))
                    {
                        var symbol = GetSymbol(modelObject);
                        if (symbol is TSymbol typedSymbol)
                        {
                            builder.Add(typedSymbol);
                        }
                        else
                        {
                            diagnostics.Add(Diagnostic.Create(CommonErrorCode.ERR_InvalidSymbolPropertyValue, null, symbol, symbol.GetType(), symbolProperty, typeof(TSymbol)));
                        }
                    }
                }
            }
            values.Free();
            return builder.ToImmutableAndFree();
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
