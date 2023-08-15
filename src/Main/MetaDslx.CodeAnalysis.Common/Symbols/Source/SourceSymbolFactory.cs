﻿using MetaDslx.CodeAnalysis.Binding;
using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.PooledObjects;
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
        private static readonly ConditionalWeakTable<Type, IModelObjectInfo> s_infosByType = new();
        private readonly Dictionary<Type, Func<Symbol, MergedDeclaration, IModelObject, Symbol>> _constructors = new();
        private readonly SourceModuleSymbol _module;

        public SourceSymbolFactory(SourceModuleSymbol module)
        {
            _module = module;
            Register<NamespaceSymbol>((s, d, mo) => new SourceNamespaceSymbol(s, d, mo));
            Register<NamedTypeSymbol>((s, d, mo) => new SourceNamedTypeSymbol(s, d, mo));
            Register<DeclaredSymbol>((s, d, mo) => new SourceDeclaredSymbol(s, d, mo));
        }

        protected Compilation Compilation => _module.DeclaringCompilation;

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
            var info = GetModelObjectInfo(declaration.ModelObjectType);
            if (info is null || info.SymbolType is null || !symbolType.IsAssignableFrom(info.SymbolType)) return null;
            var modelFactory = _module.ModelFactory;
            if (modelFactory is null) return null;
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

        public IModelObjectInfo? GetModelObjectInfo(Type modelObjectType)
        {
            if (modelObjectType is null) return null;
            var modelFactory = _module.ModelFactory;
            if (modelFactory is null) return null;
            if (!s_infosByType.TryGetValue(modelObjectType, out var info))
            {
                foreach (var metaModel in modelFactory.MetaModels)
                {
                    if (metaModel.Info.TryGetInfo(modelObjectType, out info))
                    {
                        s_infosByType.Add(modelObjectType, info);
                        break;
                    }
                }
            }
            return info;
        }

        public ImmutableArray<TValue> GetSymbolPropertyValues<TValue>(ISourceSymbol? symbol, string symbolProperty, DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            if (symbol is null) return ImmutableArray<TValue>.Empty;
            var modelObject = symbol.ModelObject;
            if (modelObject is null) return ImmutableArray<TValue>.Empty;
            var builder = ArrayBuilder<TValue>.GetInstance();
            foreach (var prop in modelObject.PublicProperties.Where(prop => prop.SymbolProperty == symbolProperty))
            {
                foreach (var decl in symbol.DeclaringSyntaxReferences)
                {
                    cancellationToken.ThrowIfCancellationRequested();
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
                    if (declBinder is null)
                    {
                        if (symbolProperty == nameof(DeclaredSymbol.Members))
                        {
                            foreach (var location in symbol.Locations)
                            {
                                if (decl.SyntaxTree == location.SourceTree && decl.Span.Contains(location.SourceSpan))
                                {
                                    binder = Compilation.GetEnclosingBinder(location.SourceTree, location.SourceSpan);
                                    NestingBinder? nestingBinder = null;
                                    while (binder is not null)
                                    {
                                        if (binder is NestingBinder nestBinder)
                                        {
                                            nestingBinder = nestBinder;
                                            break;
                                        }
                                        binder = binder.ParentBinder;
                                    }
                                    if (nestingBinder is not null && prop.Name == nestingBinder.Property)
                                    {
                                        foreach (var childSymbol in ((Symbol)symbol).ContainedSymbols)
                                        {
                                            foreach (var childLocation in childSymbol.Locations)
                                            {
                                                if (decl.SyntaxTree == (childLocation as SourceLocation)?.SourceTree && decl.Span.Contains(childLocation.SourceSpan))
                                                {
                                                    var value = childSymbol;
                                                    if (value is TValue tvalue)
                                                    {
                                                        builder.Add(tvalue);
                                                        try
                                                        {
                                                            if (value is Symbol symbolValue)
                                                            {
                                                                var modelObjectValue = (symbolValue as IModelSymbol)?.ModelObject;
                                                                if (modelObjectValue is not null)
                                                                {
                                                                    modelObject.Add(prop, modelObjectValue);
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
                                                    else
                                                    {
                                                        diagnostics.Add(Diagnostic.Create(CommonErrorCode.ERR_InvalidSymbolPropertyValue, decl.GetLocation(), value, value.GetType(), symbolProperty, typeof(TValue)));
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            Debug.Assert(false);
                        }
                    }
                    else
                    {
                        var propBinders = declBinder.GetPropertyBinders(prop.Name, cancellationToken);
                        foreach (var propBinder in propBinders)
                        {
                            var valueBinders = propBinder.GetValueBinders(propBinder, cancellationToken);
                            foreach (var ivalueBinder in valueBinders)
                            {
                                var valueBinder = (Binder)ivalueBinder;
                                var bindingContext = new BindingContext(diagnostics, cancellationToken);
                                var values = valueBinder.Bind(bindingContext);
                                foreach (var value in values)
                                {
                                    if (value is TValue tvalue)
                                    {
                                        builder.Add(tvalue);
                                        try
                                        {
                                            if (value is Symbol symbolValue)
                                            {
                                                var modelObjectValue = (symbolValue as IModelSymbol)?.ModelObject;
                                                if (modelObjectValue is not null)
                                                {
                                                    modelObject.Add(prop, modelObjectValue);
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
                                    else
                                    {
                                        diagnostics.Add(Diagnostic.Create(CommonErrorCode.ERR_InvalidSymbolPropertyValue, decl.GetLocation(), value, value.GetType(), symbolProperty, typeof(TValue)));
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return builder.ToImmutableAndFree();
        }
    }
}
