using MetaDslx.CodeAnalysis.Binding;
using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.CodeAnalysis.Symbols.Errors;
using MetaDslx.CodeAnalysis.Symbols.Model;
using MetaDslx.Modeling;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Xml.Linq;

namespace MetaDslx.CodeAnalysis.Symbols.Source
{
    public class SourceSymbolFactory
    {
        private static readonly ConditionalWeakTable<Type, ModelClassInfo> s_infosByType = new();
        private readonly Dictionary<Type, Func<Symbol, MergedDeclaration, IModelObject, Symbol>> _constructors = new();
        private readonly Dictionary<Type, Func<Symbol, MergedDeclaration, Symbol>> _non_mo_constructors = new();
        private readonly SourceModuleSymbol _module;

        public SourceSymbolFactory(SourceModuleSymbol module)
        {
            _module = module;
            Register<AliasSymbol>((s, d) => new SourceAliasSymbol(s, d));
            Register<ImportSymbol>((s, d) => new SourceImportSymbol(s, d));
            Register<Symbol>((s, d, mo) => new SourceSymbol(s, d, mo));
            Register<AttributeSymbol>((s, d, mo) => new SourceAttributeSymbol(s, d, mo));
            Register<NamespaceSymbol>((s, d, mo) => new SourceNamespaceSymbol(s, d, mo));
            Register<TypeSymbol>((s, d, mo) => new SourceTypeSymbol(s, d, mo));
            Register<DeclaredSymbol>((s, d, mo) => new SourceDeclaredSymbol(s, d, mo));
        }

        protected Compilation Compilation => _module.DeclaringCompilation;

        protected void Register<TSymbol>(Func<Symbol, MergedDeclaration, IModelObject, TSymbol> constructor)
            where TSymbol : Symbol
        {
            _constructors.Add(typeof(TSymbol), constructor);
        }

        protected void Register<TSymbol>(Func<Symbol, MergedDeclaration, TSymbol> constructor)
            where TSymbol : Symbol
        {
            _non_mo_constructors.Add(typeof(TSymbol), constructor);
        }

        public TSymbol? CreateSymbol<TSymbol>(ISourceSymbol container, MergedDeclaration declaration, DiagnosticBag diagnostics)
            where TSymbol : Symbol
        {
            return CreateSymbol(typeof(TSymbol), container, declaration, diagnostics) as TSymbol;
        }

        public ImmutableArray<Symbol> CreateContainedSymbols(ISourceSymbol container, DiagnosticBag diagnostics)
        {
            var declaration = container.Declaration;
            var symbols = ArrayBuilder<Symbol>.GetInstance();
            foreach (var child in declaration.Children)
            {
                var symbol = CreateSymbol<Symbol>(container, child, diagnostics);
                if (symbol is not null) symbols.Add(symbol);
            }
            return symbols.ToImmutableAndFree();
        }

        public ImmutableArray<DeclaredSymbol> GetMemberSymbols(ISourceSymbol container, DiagnosticBag diagnostics)
        {
            var symbol = (Symbol)container;
            if (symbol.ContainedSymbols.Length == 0) return ImmutableArray<DeclaredSymbol>.Empty;
            else return symbol.ContainedSymbols.OfType<DeclaredSymbol>().ToImmutableArray();
        }

        public ImmutableArray<ImportSymbol> GetImportSymbols(ISourceSymbol container)
        {
            var symbol = (Symbol)container;
            if (symbol.ContainedSymbols.Length == 0) return ImmutableArray<ImportSymbol>.Empty;
            else return symbol.ContainedSymbols.OfType<ImportSymbol>().ToImmutableArray();
        }

        protected Symbol? CreateSymbol(Type symbolType, ISourceSymbol container, MergedDeclaration declaration, DiagnosticBag diagnostics)
        {
            var location = declaration.NameLocations.FirstOrDefault() ?? declaration.SyntaxReferences.FirstOrDefault().GetLocation();
            if (declaration?.ModelObjectType is null) return null;
            if (_non_mo_constructors.TryGetValue(declaration.ModelObjectType, out var non_mo_constructor))
            {
                return non_mo_constructor((Symbol)container, declaration);
            }
            else if (container is IModelSymbol containerModelSymbol)
            {
                if (declaration.ModelObjectType is null) return null;
                var info = GetModelObjectInfo(declaration.ModelObjectType);
                if (info is null)
                {
                    var objectName = container is null || container is ModuleSymbol ? "the root namespace" : $"the declaration '{declaration.Name}'";
                    var diagnostic = Diagnostic.Create(CommonErrorCode.ERR_DeclarationError, location, $"Could not determine the model object information for {objectName} of type '{declaration.ModelObjectType.FullName}'. Are you missing a meta model reference?");
                    diagnostics.Add(diagnostic);
                    return Compilation[declaration.Language].ErrorSymbolFactory.CreateSymbol(symbolType, (Symbol)container, new ErrorSymbolInfo(declaration.Name, declaration.MetadataName, ImmutableArray<Symbol>.Empty, diagnostic));
                }
                var infoSymbolType = info.SymbolType.AsType();
                if (infoSymbolType is null)
                {
                    var objectName = container is null || container is ModuleSymbol ? "the root namespace" : $"the declaration '{declaration.Name}'";
                    var diagnostic = Diagnostic.Create(CommonErrorCode.ERR_DeclarationError, location, $"There is no symbol type defined for for {objectName} of type '{declaration.ModelObjectType.FullName}'. Are you missing a meta model reference?'");
                    diagnostics.Add(diagnostic);
                    return Compilation[declaration.Language].ErrorSymbolFactory.CreateSymbol(symbolType, (Symbol)container, new ErrorSymbolInfo(declaration.Name, declaration.MetadataName, ImmutableArray<Symbol>.Empty, diagnostic));
                }
                if (!symbolType.IsAssignableFrom(infoSymbolType)) return null;
                var modelFactory = _module.ModelFactory;
                if (modelFactory is null) return null;
                if (_constructors.TryGetValue(infoSymbolType, out var constructor))
                {
                    var modelObject = modelFactory.Create(containerModelSymbol.Model, declaration.ModelObjectType);
                    if (modelObject is not null)
                    {
                        modelObject.Name = declaration.Name;
                        if (containerModelSymbol.ModelObject is not null)
                        {
                            containerModelSymbol.ModelObject.Children.Add(modelObject);
                            if (declaration.QualifierProperty is not null)
                            {
                                var qprop = containerModelSymbol.ModelObject.GetProperty(declaration.QualifierProperty);
                                if (qprop is not null)
                                {
                                    containerModelSymbol.ModelObject.Add(qprop, modelObject);
                                }
                            }
                        }
                    }
                    return constructor((Symbol)container, declaration, modelObject);
                }
                else
                {
                    var objectName = container is null || container is ModuleSymbol ? "the root namespace" : $"the declaration '{declaration.Name}'";
                    var diagnostic = Diagnostic.Create(CommonErrorCode.ERR_DeclarationError, location, $"Could not create symbol for {objectName}. There is no source symbol type registered for '{infoSymbolType.FullName}' in the SourceSymbolFactory.");
                    diagnostics.Add(diagnostic);
                }
            }
            return null;
        }

        public ModelClassInfo? GetModelObjectInfo(Type modelObjectType)
        {
            if (modelObjectType is null) return null;
            var modelFactory = _module.ModelFactory;
            if (modelFactory is null) return null;
            if (!s_infosByType.TryGetValue(modelObjectType, out var info))
            {
                foreach (var metaModel in modelFactory.MetaModels)
                {
                    if (metaModel.MClassInfosByType.TryGetValue(modelObjectType, out info))
                    {
                        s_infosByType.Add(modelObjectType, info);
                        break;
                    }
                }
            }
            return info;
        }

        public TValue GetSymbolPropertyValue<TValue>(ISourceSymbol? symbol, string symbolProperty, DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            var values = GetSymbolPropertyValues<TValue>(symbol, symbolProperty, diagnostics, cancellationToken);
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

        public ImmutableArray<TValue> GetSymbolPropertyValues<TValue>(ISourceSymbol? symbol, string symbolProperty, DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            if (symbol is null) return ImmutableArray<TValue>.Empty;
            if (symbol is IModelSymbol modelSymbol) return GetModelSymbolPropertyValues<TValue>(symbol, modelSymbol, symbolProperty, diagnostics, cancellationToken);
            else return GetNonModelSymbolPropertyValues<TValue>(symbol, symbolProperty, diagnostics, cancellationToken);
        }

        private ImmutableArray<TValue> GetNonModelSymbolPropertyValues<TValue>(ISourceSymbol symbol, string symbolProperty, DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            var builder = ArrayBuilder<TValue>.GetInstance();
            foreach (var decl in symbol.DeclaringSyntaxReferences)
            {
                cancellationToken.ThrowIfCancellationRequested();
                if (decl.IsNull) continue;
                Binder? declBinder = null;
                var binder = Compilation.GetBinder(decl);
                while (binder is not null)
                {
                    if (binder is IDefineBinder defineBinder && defineBinder.DefinedSymbols.Contains((Symbol)symbol))
                    {
                        declBinder = binder;
                        break;
                    }
                    binder = binder.ParentBinder;
                }
                Debug.Assert(declBinder is not null);
                if (declBinder is not null)
                {
                    var propBinders = declBinder.GetPropertyBinders(symbolProperty, cancellationToken);
                    foreach (var propBinder in propBinders)
                    {
                        var values = ((Binder)propBinder).Bind(cancellationToken);
                        foreach (var value in values)
                        {
                            if (value is TValue tvalue)
                            {
                                builder.Add(tvalue);
                            }
                            else
                            {
                                diagnostics.Add(Diagnostic.Create(CommonErrorCode.ERR_InvalidSymbolPropertyValue, decl.GetLocation(), value, value.GetType(), symbolProperty, typeof(TValue)));
                            }
                        }
                    }
                }
            }
            return builder.ToImmutableAndFree();
        }

        private ImmutableArray<TValue> GetModelSymbolPropertyValues<TValue>(ISourceSymbol symbol, IModelSymbol modelSymbol, string symbolProperty, DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            if (symbol is null) return ImmutableArray<TValue>.Empty;
            var modelObject = modelSymbol.ModelObject;
            if (modelObject is null) return ImmutableArray<TValue>.Empty;
            var builder = ArrayBuilder<TValue>.GetInstance();
            foreach (var prop in modelObject.PublicProperties.Where(prop => prop.SymbolProperty == symbolProperty))
            {
                foreach (var decl in symbol.DeclaringSyntaxReferences)
                {
                    cancellationToken.ThrowIfCancellationRequested();
                    if (decl.IsNull) continue;
                    Binder? declBinder = null;
                    var binder = Compilation.GetBinder(decl);
                    var isNesting = false;
                    while (binder is not null)
                    {
                        if (binder is IDefineBinder defineBinder)
                        {
                            if (defineBinder.DefinedSymbols.Contains((Symbol)symbol))
                            {
                                declBinder = binder;
                            }
                            else if (defineBinder.NestingSymbols.Contains((Symbol)symbol))
                            {
                                declBinder = null;
                                isNesting = true;
                            }
                            break;
                        }
                        binder = binder.ParentBinder;
                    }
                    if (declBinder is not null)
                    {
                        var propBinders = declBinder.GetPropertyBinders(prop.Name, cancellationToken);
                        foreach (var propBinder in propBinders)
                        {
                            var values = ((Binder)propBinder).Bind(cancellationToken);
                            foreach (var value in values)
                            {
                                if (value is null) continue;
                                var error = false;
                                if (typeof(TValue) == typeof(MetaType) && value is TypeSymbol typeSymbol)
                                {
                                    builder.Add((TValue)(object)MetaType.FromTypeSymbol(typeSymbol));
                                }
                                else if (typeof(TValue) == typeof(MetaSymbol) && value is Symbol valueSymbol)
                                {
                                    builder.Add((TValue)(object)MetaSymbol.FromSymbol(valueSymbol));
                                }
                                else if (value is TValue tvalue)
                                {
                                    builder.Add(tvalue);
                                }
                                else
                                {
                                    error = true;
                                    diagnostics.Add(Diagnostic.Create(CommonErrorCode.ERR_InvalidSymbolPropertyValue, decl.GetLocation(), value, value.GetType(), symbolProperty, typeof(TValue)));
                                }
                                if (!error)
                                {
                                    try
                                    {
                                        if (prop.Type.IsAssignableTo(typeof(Symbol)) && prop.Type.IsAssignableFrom(value.GetType()))
                                        {
                                            modelObject.Add(prop, value);
                                        }
                                        else if (value is Symbol symbolValue)
                                        {
                                            var modelObjectValue = (symbolValue as IModelSymbol)?.ModelObject;
                                            if (modelObjectValue is not null && prop.Type.IsAssignableFrom(modelObjectValue.Info.MetaType))
                                            {
                                                modelObject.Add(prop, modelObjectValue);
                                            }
                                            else
                                            {
                                                modelObject.Add(prop, value);
                                            }
                                        }
                                        else
                                        {
                                            modelObject.Add(prop, value);
                                        }
                                    }
                                    catch (ModelException ex)
                                    {
                                        diagnostics.Add(Diagnostic.Create(CommonErrorCode.ERR_InvalidModelObjectPropertyValue, decl.GetLocation(), value, value.GetType(), prop.Name, prop.Type));
                                    }
                                }
                            }
                        }
                    }
                    else if (!isNesting)
                    {
                        diagnostics.Add(Diagnostic.Create(ErrorCode.ERR_InternalError, decl.GetLocation(), $"Could not resolve declaration of '{symbol.Declaration.Name}' in SourceSymbolFactory."));
                    }
                }
            }
            return builder.ToImmutableAndFree();
        }

        public void ComputeNonSymbolProperties(ISourceSymbol? symbol, DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            if (symbol is null) return;
            var modelSymbol = symbol as IModelSymbol;
            if (modelSymbol is null) return;
            var modelObject = modelSymbol.ModelObject;
            if (modelObject is null) return;
            foreach (var decl in symbol.DeclaringSyntaxReferences)
            {
                cancellationToken.ThrowIfCancellationRequested();
                if (decl.IsNull) continue;
                Binder? declBinder = null;
                var binder = Compilation.GetBinder(decl);
                while (binder is not null)
                {
                    if (binder is IDefineBinder defineBinder && defineBinder.DefinedSymbols.Contains((Symbol)symbol))
                    {
                        declBinder = binder;
                        break;
                    }
                    binder = binder.ParentBinder;
                }
                //Debug.Assert(declBinder is not null || (symbol is NamespaceSymbol ns && ns.IsGlobalNamespace));
                if (declBinder is not null)
                {
                    var propBinders = declBinder.GetPropertyBinders(propertyName: null, cancellationToken);
                    foreach (var propBinder in propBinders)
                    {
                        var prop = modelObject.GetProperty(propBinder.Name);
                        if (prop is not null && prop.SymbolProperty is null)
                        {
                            var values = ((Binder)propBinder).Bind(cancellationToken);
                            foreach (var value in values)
                            {
                                try
                                {
                                    if (prop.Type.IsAssignableTo(typeof(Symbol)) && prop.Type.IsAssignableFrom(value.GetType()))
                                    {
                                        modelObject.Add(prop, value);
                                    }
                                    else if (value is Symbol symbolValue)
                                    {
                                        var modelObjectValue = (symbolValue as IModelSymbol)?.ModelObject;
                                        if (modelObjectValue is not null && prop.Type.IsAssignableFrom(modelObjectValue.Info.MetaType))
                                        {
                                            modelObject.Add(prop, modelObjectValue);
                                        }
                                        else
                                        {
                                            modelObject.Add(prop, value);
                                        }
                                    }
                                    else
                                    {
                                        modelObject.Add(prop, value);
                                    }
                                }
                                catch (ModelException ex)
                                {
                                    diagnostics.Add(Diagnostic.Create(CommonErrorCode.ERR_InvalidModelObjectPropertyValue, decl.GetLocation(), value, value.GetType(), prop.Name, prop.Type));
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
