using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;
using System.Xml.Linq;

namespace MetaDslx.CodeAnalysis.Symbols.Source
{
    public class SourceSymbolFactory
    {
        private readonly Dictionary<Type, Func<Symbol, MergedDeclaration, IModelObject, Symbol>> _constructors = new();

        public SourceSymbolFactory()
        {
            Register<NamespaceSymbol>((s, d, mo) => new SourceNamespaceSymbol(s, d, mo));
            Register<NamedTypeSymbol>((s, d, mo) => new SourceNamedTypeSymbol(s, d, mo));
            Register<DeclaredSymbol>((s, d, mo) => new SourceDeclaredSymbol(s, d, mo));
        }

        protected void Register<TSymbol>(Func<Symbol, MergedDeclaration, IModelObject, TSymbol> constructor)
            where TSymbol : Symbol
        {
            _constructors.Add(typeof(TSymbol), constructor);
        }
        
        public TSymbol? CreateSymbol<TSymbol>(ISourceSymbol container, MergedDeclaration declaration)
            where TSymbol : Symbol
        {
            return CreateSymbol(typeof(TSymbol), container, declaration) as TSymbol;
        }

        public ImmutableArray<Symbol> CreateContainedSymbols(ISourceSymbol container)
        {
            var declaration = container.Declaration;
            var symbols = ArrayBuilder<Symbol>.GetInstance();
            foreach (var child in declaration.Children)
            {
                var symbol = CreateSymbol<Symbol>(container, child);
                if (symbol is not null) symbols.Add(symbol);
            }
            return symbols.ToImmutableAndFree();
        }

        protected Symbol? CreateSymbol(Type symbolType, ISourceSymbol container, MergedDeclaration declaration)
        {
            if (_constructors.TryGetValue(symbolType, out var constructor)) 
            {
                var modelFactory = container is SourceModuleSymbol moduleSymbol ? moduleSymbol.ModelFactory : container.ContainingModule.ModelFactory;
                var modelObject = modelFactory.Create(container.Model, declaration.ModelObjectType);
                if (modelObject is not null)
                {
                    modelObject.Name = declaration.Name;
                    if (container.ModelObject is not null) container.ModelObject.Children.Add(modelObject);
                }
                return constructor((Symbol)container, declaration, modelObject);
            }
            else
            {
                return null;
            }
        }
    }
}
