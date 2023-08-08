using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.CodeAnalysis.Symbols;
using Microsoft.CodeAnalysis;
using Roslyn.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Xml.Linq;

namespace MetaDslx.CodeAnalysis.Binding
{
    public class LookupContext
    {
        [Flags]
        private enum LookupFlags
        {
            None = 0,
            Diagnose = 0x01,
            InImport = 0x02,
            IsLookup = 0x04
        }

        private readonly ObjectPool<LookupContext> _pool;
        private Binder _originalBinder;
        private SourceLocation _location;
        private HashSet<ILookupValidator> _validators;
        private HashSet<string> _viableNames;
        private HashSet<string> _viableMetadataNames;
        private DeclaredSymbol? _qualifier;
        private LookupContext? _qualifierContext;
        private HashSet<TypeSymbol> _baseTypesBeingResolved;
        private TypeSymbol? _accessThroughType;
        private LookupFlags _flags;
        private HashSet<DiagnosticInfo> _useSiteDiagnostics;

        internal protected LookupContext(ObjectPool<LookupContext> pool)
        {
            _pool = pool;
            _validators = new HashSet<ILookupValidator>();
            _viableNames = new HashSet<string>();
            _viableMetadataNames = new HashSet<string>();
            _baseTypesBeingResolved = new HashSet<TypeSymbol>();
            _useSiteDiagnostics = new HashSet<DiagnosticInfo>();
        }

        public Compilation? Compilation => _originalBinder?.Compilation;
        public SyntaxNodeOrToken Syntax => _originalBinder?.Syntax ?? default;
        protected ILookupValidator? DefaultLookupValidator => _originalBinder?.Compilation?.DefaultLookupValidator;
        
        public Binder OriginalBinder
        {
            get => _originalBinder;
            set => _originalBinder = value;
        }
        public SourceLocation? Location
        {
            get => _location;
            set => _location = value;
        }
        public DeclaredSymbol? Qualifier
        {
            get => _qualifier;
            set => _qualifier = value;
        }
        public LookupContext? QualifierContext
        {
            get => _qualifierContext;
            set => _qualifierContext = value;
        }
        public HashSet<string> ViableNames => _viableNames;
        public HashSet<string> ViableMetadataNames => _viableMetadataNames;
        public HashSet<ILookupValidator> Validators => _validators;
        public HashSet<TypeSymbol> BaseTypesBeingResolved => _baseTypesBeingResolved;
        public TypeSymbol? AccessThroughType
        {
            get => _accessThroughType;
            set => _accessThroughType = value;
        }
        public bool Diagnose
        {
            get => _flags.HasFlag(LookupFlags.Diagnose);
            set
            {
                if (value) _flags |= LookupFlags.Diagnose;
                else _flags &= ~LookupFlags.Diagnose;
            }
        }
        public bool InImport
        {
            get => _flags.HasFlag(LookupFlags.InImport);
            set
            {
                if (value) _flags |= LookupFlags.InImport;
                else _flags &= ~LookupFlags.InImport;
            }
        }
        public bool IsLookup
        {
            get => _flags.HasFlag(LookupFlags.IsLookup);
            set
            {
                if (value) _flags |= LookupFlags.IsLookup;
                else _flags &= ~LookupFlags.IsLookup;
            }
        }
        public HashSet<DiagnosticInfo> UseSiteDiagnostics => _useSiteDiagnostics;

        public void Free()
        {
            this.Clear();
            if (_pool != null)
            {
                _pool.Free(this);
            }
        }

        public virtual void Clear()
        {
            _originalBinder = null;
            _location = null;
            _validators.Clear();
            _viableNames.Clear();
            _viableMetadataNames.Clear();
            _qualifier = null;
            _qualifierContext = null;
            _baseTypesBeingResolved.Clear();
            _accessThroughType = null;
            _flags = LookupFlags.None;
            _useSiteDiagnostics.Clear();
        }

        public void SetName(string name, string? metadataName = null)
        {
            _viableNames.Clear();
            if (!string.IsNullOrEmpty(name)) _viableNames.Add(name);
            _viableMetadataNames.Clear();
            if (!string.IsNullOrEmpty(metadataName)) _viableMetadataNames.Add(metadataName);
        }

        public void SetQualifier(DeclaredSymbol? qualifier, LookupContext? qualifierContext = null)
        {
            _qualifier = qualifier;
            _qualifierContext = qualifierContext;
        }

        public bool IsViable(DeclaredSymbol symbol)
        {
            var defaultValidator = DefaultLookupValidator;
            if (defaultValidator is not null)
            {
                if (!defaultValidator.IsViable(this, symbol)) return false;
            }
            foreach (var validator in this.Validators)
            {
                if (!validator.IsViable(this, symbol)) return false;
            }
            return true;
        }

        public SingleLookupResult CheckSingleResultViability(DeclaredSymbol symbol)
        {
            var unwrappedSymbol = UnwrapAlias(this, symbol);
            var aliasSymbol = symbol as AliasSymbol;
            var result = LookupResult.Good(unwrappedSymbol);
            var defaultValidator = DefaultLookupValidator;
            if (defaultValidator is not null)
            {
                defaultValidator.CheckSingleResultViability(this, ref result, aliasSymbol);
            }
            foreach (var validator in this.Validators)
            {
                validator.CheckSingleResultViability(this, ref result, aliasSymbol);
            }
            return result;
        }

        public void CheckFinalResultViability(LookupResult result)
        {
            var defaultValidator = DefaultLookupValidator;
            if (defaultValidator is not null)
            {
                defaultValidator.CheckFinalResultViability(this, result);
                if (!result.IsMultiViable) return;
            }
            foreach (var validator in this.Validators)
            {
                validator.CheckFinalResultViability(this, result);
                if (!result.IsMultiViable) return;
            }
        }

        public static DeclaredSymbol UnwrapAlias(LookupContext context, DeclaredSymbol symbol)
        {
            if (symbol is AliasSymbol aliasSymbol) return aliasSymbol.GetAliasTarget(context);
            else return symbol;
        }

        // return the type or namespace symbol in a lookup result, or report an error.
        public virtual DeclaredSymbol ResultSymbol(
            LookupResult result,
            DiagnosticBag diagnostics,
            bool suppressUseSiteDiagnostics,
            out bool wasError)
        {
            // TODO
            throw new NotImplementedException();
        }

        /// <remarks>
        /// This is only intended to be called when the name isn't found (i.e. not when it is found but is inaccessible, has the wrong arity, etc).
        /// </remarks>
        protected DiagnosticInfo NotFound(SyntaxNodeOrToken aliasOpt, string whereText, DiagnosticBag diagnostics)
        {
            var where = this.Syntax;
            var syntaxFacts = Compilation.MainLanguage.SyntaxFacts;
            var location = where.GetLocation();
            var qualifierOpt = this.Qualifier;

            if (qualifierOpt is not null)
            {
                if (qualifierOpt is TypeSymbol)
                {
                    if (qualifierOpt is IErrorSymbol errorQualifier && errorQualifier.ErrorInfo != null)
                    {
                        return errorQualifier.ErrorInfo;
                    }
                    var diagnosticInfo = new DiagnosticInfo(CommonErrorCode.ERR_DottedNameNotFoundInAgg, whereText, qualifierOpt);
                    diagnostics.Add(Diagnostic.Create(diagnosticInfo, location));
                    return diagnosticInfo;
                }
                else
                {
                    Debug.Assert(qualifierOpt is NamespaceSymbol);

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
            }

            var singleDiagnosticInfo = new DiagnosticInfo(CommonErrorCode.ERR_SingleNameNotFound, whereText);
            diagnostics.Add(Diagnostic.Create(singleDiagnosticInfo, location));
            return singleDiagnosticInfo;
        }


        [Flags]
        private enum BestSymbolLocation
        {
            None,
            FromSourceModule,
            FromAddedModule,
            FromReferencedAssembly,
            FromCorLibrary,
            FromMetaLibrary
        }

        [DebuggerDisplay("Location = {_location}, Index = {_index}")]
        private struct BestSymbolInfo
        {
            private readonly BestSymbolLocation _location;
            private readonly int _index;

            /// <summary>
            /// Returns -1 if None.
            /// </summary>
            public int Index
            {
                get
                {
                    return IsNone ? -1 : _index;
                }
            }

            public bool IsFromSourceModule
            {
                get
                {
                    return _location == BestSymbolLocation.FromSourceModule;
                }
            }

            public bool IsFromAddedModule
            {
                get
                {
                    return _location == BestSymbolLocation.FromAddedModule;
                }
            }

            public bool IsFromMetaLibrary
            {
                get
                {
                    return _location == BestSymbolLocation.FromMetaLibrary;
                }
            }

            public bool IsFromCompilation
            {
                get
                {
                    return (_location == BestSymbolLocation.FromSourceModule) || (_location == BestSymbolLocation.FromAddedModule) || (_location == BestSymbolLocation.FromMetaLibrary);
                }
            }

            public bool IsNone
            {
                get
                {
                    return _location == BestSymbolLocation.None;
                }
            }

            public bool IsFromCorLibrary
            {
                get
                {
                    return _location == BestSymbolLocation.FromCorLibrary;
                }
            }

            public BestSymbolInfo(BestSymbolLocation location, int index)
            {
                Debug.Assert(location != BestSymbolLocation.None);
                _location = location;
                _index = index;
            }

            /// <summary>
            /// Prefers symbols from source module, then from added modules, then from referenced assemblies.
            /// Returns true if values were swapped.
            /// </summary>
            public static bool Sort(ref BestSymbolInfo first, ref BestSymbolInfo second)
            {
                if (IsSecondLocationBetter(first._location, second._location))
                {
                    BestSymbolInfo temp = first;
                    first = second;
                    second = temp;
                    return true;
                }

                return false;
            }

            /// <summary>
            /// Returns true if the second is a better location than the first.
            /// </summary>
            public static bool IsSecondLocationBetter(BestSymbolLocation firstLocation, BestSymbolLocation secondLocation)
            {
                Debug.Assert(secondLocation != 0);
                return (firstLocation == BestSymbolLocation.None) || (firstLocation > secondLocation);
            }
        }

        /// <summary>
        /// Prefer symbols from source module, then from added modules, then from referenced assemblies.
        /// </summary>
        private BestSymbolInfo GetBestSymbolInfo(ArrayBuilder<DeclaredSymbol> symbols, out BestSymbolInfo secondBest)
        {
            BestSymbolInfo first = default(BestSymbolInfo);
            BestSymbolInfo second = default(BestSymbolInfo);

            for (int i = 0; i < symbols.Count; i++)
            {
                var symbol = symbols[i];
                BestSymbolLocation location;

                if (symbol is NamespaceSymbol namespaceSymbol)
                {
                    location = BestSymbolLocation.None;
                    foreach (var ns in namespaceSymbol.ConstituentNamespaces)
                    {
                        var current = GetLocation(Compilation, ns);
                        if (BestSymbolInfo.IsSecondLocationBetter(location, current))
                        {
                            location = current;
                            if (location == BestSymbolLocation.FromSourceModule)
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

                var third = new BestSymbolInfo(location, i);
                if (BestSymbolInfo.Sort(ref second, ref third))
                {
                    BestSymbolInfo.Sort(ref first, ref second);
                }
            }

            Debug.Assert(!first.IsNone);
            Debug.Assert(!second.IsNone);

            secondBest = second;
            return first;
        }

        private static BestSymbolLocation GetLocation(Compilation? compilation, Symbol symbol)
        {
            if (compilation is null) return BestSymbolLocation.None;
            var containingAssembly = symbol.ContainingAssembly;
            if (containingAssembly == compilation.SourceAssembly)
            {
                return (symbol.ContainingModule == compilation.SourceModule) ?
                    BestSymbolLocation.FromSourceModule :
                    BestSymbolLocation.FromAddedModule;
            }
            else
            {
                return BestSymbolLocation.FromReferencedAssembly;
                // TODO:MetaDslx
                /*return (containingAssembly == containingAssembly.CorLibrary) ?
                    BestSymbolLocation.FromCorLibrary :
                    BestSymbolLocation.FromReferencedAssembly;*/
            }
        }

        /// <summary>
        /// Reports use-site diagnostics for the specified symbol.
        /// </summary>
        /// <returns>
        /// True if there was an error among the reported diagnostics
        /// </returns>
        internal static bool ReportUseSiteDiagnostics(Symbol symbol, DiagnosticBag diagnostics, SyntaxNode node)
        {
            DiagnosticInfo info = symbol.GetUseSiteDiagnostic();
            return info != null && Symbol.ReportUseSiteDiagnostic(info, diagnostics, node.Location);
        }

        internal static bool ReportUseSiteDiagnostics(Symbol symbol, DiagnosticBag diagnostics, SyntaxToken token)
        {
            DiagnosticInfo info = symbol.GetUseSiteDiagnostic();
            return info != null && Symbol.ReportUseSiteDiagnostic(info, diagnostics, token.GetLocation());
        }

        internal static bool ReportUseSiteDiagnostics(Symbol symbol, DiagnosticBag diagnostics, SyntaxNodeOrToken nodeOrToken)
        {
            DiagnosticInfo info = symbol.GetUseSiteDiagnostic();
            return info != null && Symbol.ReportUseSiteDiagnostic(info, diagnostics, nodeOrToken.GetLocation());
        }

        /// <summary>
        /// Reports use-site diagnostics for the specified symbol.
        /// </summary>
        /// <returns>
        /// True if there was an error among the reported diagnostics
        /// </returns>
        internal static bool ReportUseSiteDiagnostics(Symbol symbol, DiagnosticBag diagnostics, Location location)
        {
            DiagnosticInfo info = symbol.GetUseSiteDiagnostic();
            return info != null && Symbol.ReportUseSiteDiagnostic(info, diagnostics, location);
        }

        private class ConsistentSymbolOrder : IComparer<Symbol>
        {
            public static readonly ConsistentSymbolOrder Instance = new ConsistentSymbolOrder();
            public int Compare(Symbol fst, Symbol snd)
            {
                if (snd == fst) return 0;
                if ((object)fst == null) return -1;
                if ((object)snd == null) return 1;
                if (snd.Name != fst.Name) return string.CompareOrdinal(fst.Name, snd.Name);
                if (snd.MetadataName != fst.MetadataName) return string.CompareOrdinal(fst.MetadataName, snd.MetadataName);
                if (snd.Kind != fst.Kind) return string.CompareOrdinal(fst.Kind, snd.Kind);
                int aLocationsCount = !snd.Locations.IsDefault ? snd.Locations.Length : 0;
                int bLocationsCount = fst.Locations.Length;
                if (aLocationsCount != bLocationsCount) return aLocationsCount - bLocationsCount;
                if (aLocationsCount == 0 && bLocationsCount == 0) return Compare(fst.ContainingSymbol, snd.ContainingSymbol);
                Location la = snd.Locations[0];
                Location lb = fst.Locations[0];
                var laIsInSource = la is SourceLocation;
                var lbIsInSource = lb is SourceLocation;
                if (laIsInSource != lbIsInSource) return laIsInSource ? 1 : -1;
                int containerResult = Compare(fst.ContainingSymbol, snd.ContainingSymbol);
                if (!laIsInSource) return containerResult;
                if (containerResult == 0 && ((SourceLocation)la).SourceTree == ((SourceLocation)lb).SourceTree) return lb.SourceSpan.Start - la.SourceSpan.Start;
                return containerResult;
            }
        }
    }
}
