using MetaDslx.CodeAnalysis.Symbols;
using MetaDslx.CodeAnalysis.Symbols.Errors;
using MetaDslx.CodeAnalysis.Symbols.Model;
using Roslyn.Utilities;
using System;
using System.Collections.Generic;
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

        public virtual bool IsViable(LookupContext context, DeclaredSymbol? symbol)
        {
            return true;
        }

        public virtual SingleLookupResult ValidateResult(LookupContext context, DeclaredSymbol resultSymbol, DeclaredSymbol unwrappedSymbol)
        {
            return LookupResult.Good(resultSymbol);
        }

        public virtual bool TryGetResultSymbol(LookupContext context, DiagnosticBag diagnostics, out DeclaredSymbol resultSymbol)
        {
            var where = context.Syntax;
            var result = context.Result;
            var symbols = result.Symbols;
            symbols.Sort(ConsistentSymbolOrder.Instance);

            if (result.IsEmpty)
            {
                DiagnosticInfo errorInfo = NotFound(context, diagnostics);
                resultSymbol = _compilation.ErrorSymbolFactory.CreateSymbol<DeclaredSymbol>(context.Qualifier ?? _compilation.GlobalNamespace, errorInfo);
                return false;
            }
            if (result.IsMultiViable && symbols.Count > 1)
            {
                Ambiguous(context, diagnostics, out resultSymbol);
                return false;
            }
            // result.Error might be null if we have already generated parser errors
            if (result.Error != null)
            {
                // Suppress cascading
                if (context.Qualifier is null || !context.Qualifier.IsError) 
                {
                    diagnostics.Add(Diagnostic.Create(result.Error, where.GetLocation()));
                }
            }
            resultSymbol = symbols[0];
            // TODO:MetaDslx: ReportUseSiteDiagnostics???
            return result.IsSingleViable;
        }


        /// <remarks>
        /// This is only intended to be called when the name is ambiguous
        /// </remarks>
        protected virtual DiagnosticInfo Ambiguous(LookupContext context, DiagnosticBag diagnostics, out DeclaredSymbol resultSymbol)
        {
            var where = context.Syntax;
            var syntaxFacts = where.Language.SyntaxFacts;
            var whereText = syntaxFacts.ExtractName(where);
            var location = where.GetLocation();
            var qualifierOpt = context.Qualifier;
            var aliasOpt = context.Alias;
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
                var errorInfo = new SymbolDiagnosticInfo(errorSymbols, CommonErrorCode.WRN_SameFullNameThisAggAgg, bestLocation, best, GetContainingAssembly(second), second);
                diagnostics.Add(Diagnostic.Create(errorInfo, location));
                resultSymbol = best;
                return errorInfo;
            }
            else
            {
                // suppress reporting the error if we found multiple symbols from source module
                // since an error has already been reported from the declaration
                var reportError = !(info.BestLocation == AmbiguousSymbolLocation.FromSourceModule && info.SecondLocation == AmbiguousSymbolLocation.FromSourceModule);
                // '{0}' is an ambiguous reference between '{1}' and '{2}'
                var errorInfo = new SymbolDiagnosticInfo(errorSymbols, CommonErrorCode.ERR_AmbigContext, best.Name, best, second);
                if (reportError)
                {
                    diagnostics.Add(Diagnostic.Create(errorInfo, location));
                }
                resultSymbol = _compilation.ErrorSymbolFactory.CreateSymbol<DeclaredSymbol>(best.ContainingDeclaration ?? _compilation.GlobalNamespace, errorInfo);
                return errorInfo;
            }
        }

        /// <summary>
        /// Prefer symbols from source module, then from added modules, then from referenced assemblies.
        /// </summary>
        protected AmbiguousSymbolsInfo GetBestAmbiguousSymbols(LookupResult result)
        {
            var symbols = result.Symbols;

            DeclaredSymbol firstSymbol = null;
            var firstLocation = AmbiguousSymbolLocation.None;
            DeclaredSymbol secondSymbol = null;
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
            else
            {
                return containingAssembly.IsCorLibrary ?
                    AmbiguousSymbolLocation.FromCorLibrary :
                    AmbiguousSymbolLocation.FromReferencedAssembly;
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
        protected virtual DiagnosticInfo NotFound(LookupContext context, DiagnosticBag diagnostics)
        {
            var where = context.Syntax;
            var syntaxFacts = where.Language.SyntaxFacts;
            var whereText = syntaxFacts.ExtractName(where);
            var location = where.GetLocation();
            var qualifierOpt = context.Qualifier;
            var aliasOpt = context.Alias;

            if (qualifierOpt is not null)
            {
                if (qualifierOpt is NamespaceSymbol)
                {
                    if (ReferenceEquals(qualifierOpt, Compilation.GlobalNamespace))
                    {
                        Debug.Assert(aliasOpt == null || syntaxFacts.IsGlobalAlias(aliasOpt));
                        var diagnosticInfo = new DiagnosticInfo(CommonErrorCode.ERR_GlobalSingleNameNotFound, whereText, qualifierOpt);
                        diagnostics.Add(Diagnostic.Create(diagnosticInfo, location));
                        return diagnosticInfo;
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

                        var diagnosticInfo = new DiagnosticInfo(CommonErrorCode.ERR_DottedNameNotFoundInNS, whereText, container);
                        diagnostics.Add(Diagnostic.Create(diagnosticInfo, location));
                        return diagnosticInfo;
                    }
                }
                else
                {
                    if (qualifierOpt is IErrorSymbol errorQualifier && errorQualifier.ErrorInfo != null)
                    {
                        return errorQualifier.ErrorInfo;
                    }
                    var diagnosticInfo = new DiagnosticInfo(CommonErrorCode.ERR_DottedNameNotFoundInAgg, whereText, qualifierOpt);
                    diagnostics.Add(Diagnostic.Create(diagnosticInfo, location));
                    return diagnosticInfo;
                }
            }

            var singleDiagnosticInfo = new DiagnosticInfo(CommonErrorCode.ERR_SingleNameNotFound, whereText);
            diagnostics.Add(Diagnostic.Create(singleDiagnosticInfo, location));
            return singleDiagnosticInfo;
        }
    }
}
