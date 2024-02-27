using MetaDslx.CodeAnalysis.Symbols;
using MetaDslx.CodeAnalysis.Symbols.Errors;
using MetaDslx.CodeAnalysis.Symbols.Model;
using Roslyn.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace MetaDslx.CodeAnalysis.Binding
{
    public class DefaultLookupValidator : ILookupValidator
    {
        private readonly Compilation _compilation;

        public DefaultLookupValidator(Compilation compilation)
        {
            _compilation = compilation;
        }

        public Compilation Compilation => _compilation;

        public virtual bool IsViable(LookupContext context, DeclarationSymbol? symbol)
        {
            if (string.IsNullOrEmpty(symbol?.Name)) return false;
            if (context.IsCaseSensitive)
            {
                if (context.ViableNames.Count > 0 && !context.ViableNames.Contains(symbol.Name)) return false;
                if (context.ViableMetadataNames.Count > 0 && !context.ViableMetadataNames.Contains(symbol.MetadataName)) return false;
                if (context.NamePrefixes.Count > 0 && !context.NamePrefixes.Any(p => symbol.Name.StartsWith(p))) return false;
                if (context.NameSuffixes.Count > 0 && !context.NameSuffixes.Any(s => symbol.Name.EndsWith(s))) return false;
            }
            else
            {
                if (context.ViableNames.Count > 0 && !context.ViableNames.Contains(symbol.Name, StringComparer.OrdinalIgnoreCase)) return false;
                if (context.ViableMetadataNames.Count > 0 && !context.ViableMetadataNames.Contains(symbol.MetadataName, StringComparer.OrdinalIgnoreCase)) return false;
                if (context.NamePrefixes.Count > 0 && !context.NamePrefixes.Any(p => symbol.Name.StartsWith(p, StringComparison.OrdinalIgnoreCase))) return false;
                if (context.NameSuffixes.Count > 0 && !context.NameSuffixes.Any(s => symbol.Name.EndsWith(s, StringComparison.OrdinalIgnoreCase))) return false;
            }
            var unwrapped = Binder.UnwrapAlias(symbol) as DeclarationSymbol;
            if (unwrapped is null) return false;
            foreach (var validator in context.Validators)
            {
                if (validator != context.OriginalBinder && !validator.IsViable(context, unwrapped)) return false;
            }
            return true;
        }

        public virtual SingleLookupResult ValidateResult(LookupContext context, DeclarationSymbol resultSymbol, DeclarationSymbol unwrappedSymbol)
        {
            var result = LookupResult.Good(resultSymbol);
            foreach (var validator in context.Validators)
            {
                if (validator != context.OriginalBinder)
                {
                    var tempResult = validator.ValidateResult(context, resultSymbol, unwrappedSymbol);
                    if (tempResult.Kind > LookupResultKind.Empty && tempResult.Kind < result.Kind)
                    {
                        result = tempResult;
                    }
                }
            }
            return result;
        }

        public virtual bool TryGetResultSymbol(LookupContext context, out DeclarationSymbol resultSymbol)
        {
            var result = context.Result;
            var symbols = result.Symbols;
            symbols.Sort(ConsistentSymbolOrder.Instance);

            if (result.IsEmpty)
            {
                var errorInfo = NotFound(context);
                resultSymbol = context.ErrorSymbolFactory.CreateSymbol<DeclarationSymbol>(context.Qualifier ?? _compilation.GlobalNamespace, errorInfo, null, default);
                return false;
            }
            if (result.IsMultiViable && symbols.Count > 1)
            {
                Ambiguous(context, out resultSymbol);
                return false;
            }
            // result.Error might be null if we have already generated parser errors
            if (result.Error != null)
            {
                // Suppress cascading
                if (context.Qualifier is null || !context.Qualifier.IsErrorSymbol) 
                {
                    context.AddDiagnostic(Diagnostic.Create(result.Error, context.Location));
                }
            }
            resultSymbol = symbols[0];
            // TODO:MetaDslx: ReportUseSiteDiagnostics???
            return result.IsSingleViable;
        }


        /// <remarks>
        /// This is only intended to be called when the name is ambiguous
        /// </remarks>
        protected virtual ErrorSymbolInfo Ambiguous(LookupContext context, out DeclarationSymbol resultSymbol)
        {
            var location = context.Location;
            var info = GetBestAmbiguousSymbols(context.Result);
            var symbols = context.Result.Symbols;
            var best = info.Best;
            var second = info.Second;
            var originalSymbols = symbols.ToImmutable();
            var errorSymbols = originalSymbols.CastArray<Symbol>();
            object bestLocation = info.BestLocation == AmbiguousSymbolLocation.FromSourceModule
                ? best.Locations.OfType<SourceLocation>().FirstOrDefault()?.SourceTree?.FilePath
                : best.ContainingModule;
            var format = SymbolDisplayFormat.QualifiedNameArityFormat;
            var sameSymbols = format.ToString(best) == format.ToString(second);
            //if names match, arities match, and containing symbols match (recursively), ...
            if (sameSymbols && IsFromCompilation(info.BestLocation) && !IsFromCompilation(info.SecondLocation))
            {
                // The {1} in '{0}' conflicts with the imported {3} in '{2}'. Using the symbol defined in '{0}'.
                var errorInfo = new ErrorSymbolInfo(best.SymbolType, best.Name, best.MetadataName, errorSymbols, Diagnostic.Create(CommonErrorCode.WRN_SameFullNameThisAggAgg, location, bestLocation, SymbolDisplayFormat.FullyQualifiedFormat.ToString(best), GetContainingAssembly(second), SymbolDisplayFormat.FullyQualifiedFormat.ToString(second)));
                context.AddDiagnostic(errorInfo.Diagnostic);
                resultSymbol = best;
                return errorInfo;
            }
            else
            {
                // suppress reporting the error if we found multiple symbols from source module
                // since an error has already been reported from the declaration
                var reportError = !(info.BestLocation == AmbiguousSymbolLocation.FromSourceModule && info.SecondLocation == AmbiguousSymbolLocation.FromSourceModule);
                // '{0}' is an ambiguous reference between '{1}' and '{2}'
                var errorInfo = new ErrorSymbolInfo(best.SymbolType, best.Name, best.MetadataName, errorSymbols, Diagnostic.Create(CommonErrorCode.ERR_AmbigContext, location, best.Name, SymbolDisplayFormat.FullyQualifiedFormat.ToString(best), SymbolDisplayFormat.FullyQualifiedFormat.ToString(second)));
                if (reportError)
                {
                    context.AddDiagnostic(errorInfo.Diagnostic);
                }
                resultSymbol = context.ErrorSymbolFactory.CreateSymbol<DeclarationSymbol>(best.ContainingDeclaration ?? _compilation.GlobalNamespace, errorInfo, null, default);
                return errorInfo;
            }
        }

        /// <summary>
        /// Prefer symbols from source module, then from added modules, then from referenced assemblies.
        /// </summary>
        protected AmbiguousSymbolsInfo GetBestAmbiguousSymbols(LookupResult result)
        {
            var symbols = result.Symbols;

            DeclarationSymbol firstSymbol = null;
            var firstLocation = AmbiguousSymbolLocation.None;
            DeclarationSymbol secondSymbol = null;
            var secondLocation = AmbiguousSymbolLocation.None;

            for (int i = 0; i < symbols.Count; i++)
            {
                var symbol = symbols[i];
                AmbiguousSymbolLocation location;

                if (symbol is NamespaceSymbol namespaceSymbol)
                {
                    location = AmbiguousSymbolLocation.None;
                    foreach (var ns in namespaceSymbol.ConstituentNamespaces)
                    {
                        var current = GetLocation(Compilation, ns);
                        if (IsSecondLocationBetter(location, current))
                        {
                            location = current;
                            if (location == AmbiguousSymbolLocation.FromSourceModule)
                            {
                                break;
                            }
                        }
                    }
                }
                else
                {
                    location = GetLocation(Compilation, symbol);
                }

                if (IsSecondLocationBetter(secondLocation, location))
                {
                    secondLocation = location;
                    secondSymbol = symbol;
                    if (IsSecondLocationBetter(firstLocation, secondLocation))
                    {
                        var tempSymbol = firstSymbol;
                        var tempLocation = firstLocation;
                        firstSymbol = secondSymbol;
                        firstLocation = secondLocation;
                        secondSymbol = tempSymbol;
                        secondLocation = tempLocation;
                    }
                }
            }

            Debug.Assert(firstLocation != AmbiguousSymbolLocation.None);
            Debug.Assert(secondLocation != AmbiguousSymbolLocation.None);

            return new AmbiguousSymbolsInfo(firstSymbol, firstLocation, secondSymbol, secondLocation);
        }

        private static AmbiguousSymbolLocation GetLocation(Compilation compilation, Symbol symbol)
        {
            var containingAssembly = symbol.ContainingAssembly;
            if (containingAssembly == compilation.SourceAssembly)
            {
                return (symbol.ContainingModule == compilation.SourceModule) ?
                    AmbiguousSymbolLocation.FromSourceModule :
                    AmbiguousSymbolLocation.FromAddedModule;
            }
            else if (containingAssembly is not null)
            {
                return containingAssembly.IsCorLibrary ?
                    AmbiguousSymbolLocation.FromCorLibrary :
                    AmbiguousSymbolLocation.FromReferencedAssembly;
            }
            else
            {
                return AmbiguousSymbolLocation.FromAddedModule;
            }
        }

        /// <summary>
        /// Returns true if the second is a better location than the first.
        /// </summary>
        private static bool IsSecondLocationBetter(AmbiguousSymbolLocation firstLocation, AmbiguousSymbolLocation secondLocation)
        {
            Debug.Assert(secondLocation != 0);
            return (firstLocation == AmbiguousSymbolLocation.None) || (firstLocation > secondLocation);
        }

        /// <summary>
        /// Returns true if the second is a better location than the first.
        /// </summary>
        private static bool IsFromCompilation(AmbiguousSymbolLocation location)
        {
            return location == AmbiguousSymbolLocation.FromSourceModule || location == AmbiguousSymbolLocation.FromAddedModule;
        }

        private static AssemblySymbol GetContainingAssembly(Symbol symbol)
        {
            // Merged namespaces that span multiple assemblies don't have a containing assembly,
            // so just use the containing assembly of the first constituent.
            return symbol.ContainingAssembly ?? (symbol as NamespaceSymbol)?.ConstituentNamespaces.FirstOrDefault()?.ContainingAssembly;
        }

        /// <remarks>
        /// This is only intended to be called when the name isn't found (i.e. not when it is found but is inaccessible, has the wrong arity, etc).
        /// </remarks>
        protected virtual ErrorSymbolInfo NotFound(LookupContext context)
        {
            var syntaxFacts = context.Language.SyntaxFacts;
            var name = context.ViableNames.FirstOrDefault() ?? string.Empty;
            var metadataName = context.ViableMetadataNames.FirstOrDefault() ?? name;
            var location = context.Location;
            var qualifierOpt = context.Qualifier;
            var aliasOpt = context.Alias;

            if (qualifierOpt is not null)
            {
                if (qualifierOpt is NamespaceSymbol)
                {
                    if (ReferenceEquals(qualifierOpt, Compilation.GlobalNamespace))
                    {
                        Debug.Assert(aliasOpt == null || syntaxFacts.IsGlobalAlias(aliasOpt));
                        var errorInfo = new ErrorSymbolInfo(qualifierOpt.SymbolType, name, metadataName, ImmutableArray<Symbol>.Empty, Diagnostic.Create(CommonErrorCode.ERR_GlobalSingleNameNotFound, context.Location, name, qualifierOpt));
                        context.AddDiagnostic(errorInfo.Diagnostic);
                        return errorInfo;
                    }
                    else
                    {
                        object container = qualifierOpt;

                        // If there was an alias (e.g. A::C) and the given qualifier is the global namespace of the alias,
                        // then use the alias name in the error message, since it's more helpful than "<global namespace>".
                        if (aliasOpt != null && qualifierOpt is NamespaceSymbol qualifierNs && qualifierNs.IsGlobalNamespace)
                        {
                            container = aliasOpt;
                        }

                        var errorInfo = new ErrorSymbolInfo(qualifierOpt.SymbolType, name, metadataName, ImmutableArray<Symbol>.Empty, Diagnostic.Create(CommonErrorCode.ERR_DottedNameNotFoundInNS, context.Location, name, container));
                        context.AddDiagnostic(errorInfo.Diagnostic);
                        return errorInfo;
                    }
                }
                else
                {
                    if (qualifierOpt.IsErrorSymbol)
                    {
                        return qualifierOpt.ErrorInfo;
                    }
                    var errorInfo = new ErrorSymbolInfo(typeof(DeclarationSymbol), name, metadataName, ImmutableArray<Symbol>.Empty, Diagnostic.Create(CommonErrorCode.ERR_DottedNameNotFoundInAgg, context.Location, name, qualifierOpt));
                    context.AddDiagnostic(errorInfo.Diagnostic);
                    return errorInfo;
                }
            }

            var singleErrorInfo = new ErrorSymbolInfo(typeof(DeclarationSymbol), name, metadataName, ImmutableArray<Symbol>.Empty, Diagnostic.Create(CommonErrorCode.ERR_SingleNameNotFound, context.Location, name));
            context.AddDiagnostic(singleErrorInfo.Diagnostic);
            return singleErrorInfo;
        }
    }
}
