﻿using MetaDslx.CodeAnalysis.Binding;
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
            Register<ImportMetaModelSymbol>((s, d) => new ImportMetaModelSymbol(s, d));
            Register<Symbol>((s, d, mo) => new SourceSymbol(s, d, mo));
            Register<AttributeSymbol>((s, d, mo) => new SourceAttributeSymbol(s, d, mo));
            Register<NamespaceSymbol>((s, d, mo) => new SourceNamespaceSymbol(s, d, mo));
            Register<TypeSymbol>((s, d, mo) => new SourceTypeSymbol(s, d, mo));
            Register<DeclarationSymbol>((s, d, mo) => new SourceDeclarationSymbol(s, d, mo));
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

        public ImmutableArray<DeclarationSymbol> GetMemberSymbols(ISourceSymbol container, DiagnosticBag diagnostics)
        {
            var symbol = (Symbol)container;
            if (symbol.ContainedSymbols.Length == 0) return ImmutableArray<DeclarationSymbol>.Empty;
            else return symbol.ContainedSymbols.OfType<DeclarationSymbol>().ToImmutableArray();
        }

        public ImmutableArray<ImportSymbol> GetImportSymbols(ISourceSymbol container)
        {
            var symbol = (Symbol)container;
            if (symbol.ContainedSymbols.Length == 0) return ImmutableArray<ImportSymbol>.Empty;
            else return symbol.ContainedSymbols.OfType<ImportSymbol>().ToImmutableArray();
        }

        protected Symbol? CreateSymbol(Type symbolType, ISourceSymbol container, MergedDeclaration declaration, DiagnosticBag diagnostics)
        {
            if (container is null) throw new ArgumentNullException(nameof(container));
            if (container is ModuleSymbol) throw new ArgumentException("ModuleSymbol is unexpected here.", nameof(container));
            if (container is AssemblySymbol) throw new ArgumentException("AssemblySymbol is unexpected here.", nameof(container));
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
                    var objectName = container is SourceRootNamespaceSymbol ? "the root namespace" : $"the declaration '{declaration.Name}'";
                    var diagnostic = Diagnostic.Create(CommonErrorCode.ERR_DeclarationError, location, $"Could not determine the model object information for {objectName} of type '{declaration.ModelObjectType.FullName}'. Are you missing a meta model reference? Are you missing an entry in the SourceSymbolFactory?");
                    diagnostics.Add(diagnostic);
                    return Compilation[declaration.Language].ErrorSymbolFactory.CreateSymbol(symbolType, (Symbol)container, new ErrorSymbolInfo(declaration.Name, declaration.MetadataName, ImmutableArray<Symbol>.Empty, diagnostic));
                }
                var infoSymbolType = info.SymbolType.AsType();
                if (infoSymbolType is null)
                {
                    var objectName = container is SourceRootNamespaceSymbol ? "the root namespace" : $"the declaration '{declaration.Name}'";
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
                        modelObject.MName = declaration.Name;
                        if (containerModelSymbol.ModelObject is not null)
                        {
                            containerModelSymbol.ModelObject.MChildren.Add(modelObject);
                            if (declaration.QualifierProperty is not null)
                            {
                                var qslot = containerModelSymbol.ModelObject.MGetSlot(declaration.QualifierProperty);
                                var box = qslot?.Add(modelObject);
                                box.Syntax = declaration.SyntaxReferences.FirstOrDefault();
                            }
                        }
                        else if (container is SourceRootNamespaceSymbol rootNs)
                        {
                            rootNs.Model.AttachObject(modelObject);
                        }
                    }
                    var symbol = constructor((Symbol)container, declaration, modelObject);
                    if (modelObject is not null)
                    {
                        modelObject.MSymbol = symbol;
                    }
                    return symbol;
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
            var converter = Compilation.SymbolValueConverter;
            if (converter is null) return ImmutableArray<TValue>.Empty;
            var builder = ArrayBuilder<TValue>.GetInstance();
            foreach (var decl in symbol.DeclaringSyntaxReferences)
            {
                cancellationToken.ThrowIfCancellationRequested();
                if (decl.IsNull) continue;
                if (TryGetDeclarationBinder(symbol, decl, out var declBinder, out var isNesting))
                {
                    var propBinders = declBinder.GetPropertyBinders(symbolProperty, cancellationToken);
                    foreach (var propBinder in propBinders)
                    {
                        var valueBinders = propBinder.GetValueBinders(cancellationToken);
                        foreach (var valueBinder in valueBinders)
                        {
                            var values = ((Binder)valueBinder).Bind(cancellationToken);
                            foreach (var value in values)
                            {
                                var symbolValueSuccess = converter.TryConvertTo(value, typeof(TValue), out var symbolValue, (Binder)valueBinder, diagnostics, cancellationToken);
                                if (symbolValueSuccess)
                                {
                                    builder.Add((TValue)symbolValue);
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
            return builder.ToImmutableAndFree();
        }

        private ImmutableArray<TValue> GetModelSymbolPropertyValues<TValue>(ISourceSymbol symbol, IModelSymbol modelSymbol, string symbolProperty, DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            if (symbol is null) return ImmutableArray<TValue>.Empty;
            var modelObject = modelSymbol.ModelObject;
            if (modelObject is null) return ImmutableArray<TValue>.Empty;
            var converter = Compilation.SymbolValueConverter;
            if (converter is null) return ImmutableArray<TValue>.Empty;
            var builder = ArrayBuilder<TValue>.GetInstance();
            foreach (var prop in modelObject.MInfo.PublicProperties.Where(prop => prop.SymbolProperty == symbolProperty))
            {
                var slot = modelObject.MGetSlot(prop);
                if (slot is null) continue;
                foreach (var decl in symbol.DeclaringSyntaxReferences)
                {
                    cancellationToken.ThrowIfCancellationRequested();
                    if (decl.IsNull) continue;
                    if (TryGetDeclarationBinder(symbol, decl, out var declBinder, out var isNesting))
                    {
                        var propBinders = declBinder.GetPropertyBinders(prop.Name, cancellationToken);
                        foreach (var propBinder in propBinders)
                        {
                            var valueBinders = propBinder.GetValueBinders(cancellationToken);
                            foreach (var valueBinder in valueBinders)
                            {
                                var values = ((Binder)valueBinder).Bind(cancellationToken);
                                foreach (var value in values)
                                {
                                    var symbolValueSuccess = converter.TryConvertTo(value, typeof(TValue), out var symbolValue, (Binder)valueBinder, diagnostics, cancellationToken);
                                    var mobjValueSuccess = converter.TryConvertTo(value, slot.Property.SlotProperty.Type, out var mobjValue, (Binder)valueBinder, diagnostics, cancellationToken);
                                    if (symbolValueSuccess && mobjValueSuccess)
                                    {
                                        builder.Add((TValue)symbolValue);
                                        try
                                        {
                                            var box = slot.Add(mobjValue);
                                            if (box is not null) box.Syntax = ((Binder)valueBinder).Syntax;
                                        }
                                        catch (Exception ex)
                                        {
                                            diagnostics.Add(Diagnostic.Create(ErrorCode.ERR_InternalError, decl.GetLocation(), $"Could not assign value {mobjValue} to {slot} in SourceSymbolFactory: {ex.ToString()}"));
                                        }
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
            var converter = Compilation.SymbolValueConverter;
            if (converter is null) return;
            foreach (var decl in symbol.DeclaringSyntaxReferences)
            {
                cancellationToken.ThrowIfCancellationRequested();
                if (decl.IsNull) continue;
                if (TryGetDeclarationBinder(symbol, decl, out var declBinder, out var isNesting))
                {
                    var propBinders = declBinder.GetPropertyBinders(propertyName: null, cancellationToken);
                    foreach (var propBinder in propBinders)
                    {
                        var prop = modelObject.MInfo.GetProperty(propBinder.Name);
                        if (prop is not null && prop.SymbolProperty is null)
                        {
                            var slot = modelObject.MGetSlot(prop);
                            if (slot is null) continue;
                            var valueBinders = propBinder.GetValueBinders(cancellationToken);
                            foreach (var valueBinder in valueBinders)
                            {
                                var values = ((Binder)valueBinder).Bind(cancellationToken);
                                foreach (var value in values)
                                {
                                    var mobjValueSuccess = converter.TryConvertTo(value, slot.Property.SlotProperty.Type, out var mobjValue, (Binder)valueBinder, diagnostics, cancellationToken);
                                    if (mobjValueSuccess)
                                    {
                                        try
                                        {
                                            var box = slot.Add(mobjValue);
                                            if (box is not null) box.Syntax = ((Binder)valueBinder).Syntax;
                                        }
                                        catch (Exception ex)
                                        {
                                            diagnostics.Add(Diagnostic.Create(ErrorCode.ERR_InternalError, decl.GetLocation(), $"Could not assign value {mobjValue} to {slot} in SourceSymbolFactory: {ex.ToString()}"));
                                        }
                                    }
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

        protected bool TryGetDeclarationBinder(ISourceSymbol? symbol, SyntaxNodeOrToken declaration, out IDefineBinder? binder, out bool isNesting)
        {
            binder = null;
            var declBinder = Compilation.GetBinder(declaration);
            isNesting = false;
            while (declBinder is not null)
            {
                if (declBinder is IDefineBinder defineBinder)
                {
                    if (defineBinder.DefinedSymbols.Contains((Symbol)symbol))
                    {
                        binder = defineBinder;
                        return true;
                    }
                    else if (defineBinder.NestingSymbols.Contains((Symbol)symbol))
                    {
                        isNesting = true;
                    }
                    return false;
                }
                declBinder = declBinder.ParentBinder;
            }
            return false;
        }
    }
}
