using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml.Linq;

namespace MetaDslx.CodeAnalysis.Symbols.Source
{
    public class SourceSymbolFactory
    {
        private static readonly ConditionalWeakTable<Type, IModelObjectInfo> s_infosByType = new();
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
            if (declaration.ModelObjectType is null) return null;
            var module = container is ModuleSymbol moduleSymbol ? moduleSymbol : ((Symbol)container).ContainingModule;
            var sourceModule = module as SourceModuleSymbol;
            var modelFactory = sourceModule?.ModelFactory;
            if (modelFactory is null) return null;
            if (!s_infosByType.TryGetValue(declaration.ModelObjectType, out var info))
            {
                foreach (var metaModel in modelFactory.MetaModels)
                {
                    if (metaModel.Info.TryGetInfo(declaration.ModelObjectType, out info))
                    {
                        s_infosByType.Add(declaration.ModelObjectType, info);
                        break;
                    }
                }
            }
            if (info is null || info.SymbolType is null || !symbolType.IsAssignableFrom(info.SymbolType)) return null;
            if (_constructors.TryGetValue(info.SymbolType, out var constructor)) 
            {
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
