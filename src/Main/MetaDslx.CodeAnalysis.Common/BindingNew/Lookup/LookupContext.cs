using Autofac;
using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.CodeAnalysis.Symbols;
using MetaDslx.CodeAnalysis.Symbols.Errors;
using Microsoft.CodeAnalysis;
using Roslyn.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
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
            IsLookup = 0x04,
            IsCaseSensitive = 0x10,
            IgnoreDiagnostics = 0x20,
        }

        private static ObjectPool<LookupContext> s_lookupContextPool;

        private readonly ObjectPool<LookupContext> _pool;
        private Compilation _compilation;
        private Language _language;
        private DefaultLookupValidator _defaultLookupValidator;
        private ErrorSymbolFactory _errorSymbolFactory;
        private object? _multiLookupKey;
        private Binder _originalBinder;
        private Binder _currentBinder;
        private SourceLocation _location;
        private HashSet<ILookupValidator> _validators;
        private string? _name;
        private string? _metadataName;
        private HashSet<string> _namePrefixes;
        private HashSet<string> _nameSuffixes;
        private HashSet<string> _viableNames;
        private HashSet<string> _viableMetadataNames;
        private SyntaxNodeOrToken _alias;
        private DeclarationSymbol? _qualifier;
        private LookupContext? _qualifierContext;
        private HashSet<TypeSymbol> _baseTypesBeingResolved;
        private TypeSymbol? _accessThroughType;
        private LookupFlags _flags;
        private LookupResult _result;
        private DiagnosticBag _diagnostics;
        private HashSet<DiagnosticInfo> _useSiteDiagnostics;
        private CancellationToken _cancellationToken;

        internal LookupContext(ObjectPool<LookupContext> pool)
        {
            _pool = pool;
            _validators = new HashSet<ILookupValidator>();
            _namePrefixes = new HashSet<string>();
            _nameSuffixes = new HashSet<string>();
            _viableNames = new HashSet<string>();
            _viableMetadataNames = new HashSet<string>();
            _baseTypesBeingResolved = new HashSet<TypeSymbol>();
            _result = new LookupResult();
            _diagnostics = new DiagnosticBag();
            _useSiteDiagnostics = new HashSet<DiagnosticInfo>();
            _cancellationToken = default;
        }

        public Compilation Compilation => _compilation;
        public Language Language => _language;
        public DefaultLookupValidator DefaultLookupValidator => _defaultLookupValidator;
        public ErrorSymbolFactory ErrorSymbolFactory => _errorSymbolFactory;

        public object? MultiLookupKey
        {
            get => _multiLookupKey;
            set => _multiLookupKey = value;
        }
        public Binder OriginalBinder
        {
            get => _originalBinder;
            set => _originalBinder = value;
        }
        public Binder CurrentBinder
        {
            get => _currentBinder;
            set => _currentBinder = value;
        }
        public SourceLocation? Location
        {
            get => _location;
            set => _location = value;
        }
        public SyntaxNodeOrToken Alias
        {
            get => _alias;
            set => _alias = value;
        }
        public DeclarationSymbol? Qualifier
        {
            get => _qualifier;
            set => _qualifier = value;
        }
        public LookupContext? QualifierContext
        {
            get => _qualifierContext;
            set => _qualifierContext = value;
        }
        public HashSet<string> NamePrefixes => _namePrefixes;
        public HashSet<string> NameSuffixes => _nameSuffixes;
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
            get => _flags.HasFlag(LookupFlags.Diagnose) && !_flags.HasFlag(LookupFlags.IgnoreDiagnostics);
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
        public bool IsCaseSensitive
        {
            get => _flags.HasFlag(LookupFlags.IsCaseSensitive);
            set
            {
                if (value) _flags |= LookupFlags.IsCaseSensitive;
                else _flags &= ~LookupFlags.IsCaseSensitive;
            }
        }
        public bool IgnoreDiagnostics
        {
            get => _flags.HasFlag(LookupFlags.IgnoreDiagnostics);
            set
            {
                if (value) _flags |= LookupFlags.IgnoreDiagnostics;
                else _flags &= ~LookupFlags.IgnoreDiagnostics;
            }
        }
        public LookupResult Result => _result;
        public DiagnosticBag Diagnostics => _diagnostics;
        public HashSet<DiagnosticInfo> UseSiteDiagnostics => _useSiteDiagnostics;
        public CancellationToken CancellationToken
        {
            get => _cancellationToken;
            set => _cancellationToken = value;
        }

        public void Free()
        {
            this.Clear();
            _compilation = null;
            _language = null;
            _defaultLookupValidator = null;
            _errorSymbolFactory = null;
            if (_pool != null)
            {
                _pool.Free(this);
            }
        }

        public virtual void Clear()
        {
            _multiLookupKey = null;
            _originalBinder = null;
            _currentBinder = null;
            _location = null;
            _validators.Clear();
            _name = null;
            _metadataName = null;
            _namePrefixes.Clear();
            _nameSuffixes.Clear();
            _viableNames.Clear();
            _viableMetadataNames.Clear();
            _alias = null;
            _qualifier = null;
            _qualifierContext = null;
            _baseTypesBeingResolved.Clear();
            _accessThroughType = null;
            _flags = LookupFlags.None;
            _result.Clear();
            _diagnostics.Clear();
            _useSiteDiagnostics.Clear();
        }

        public virtual void ClearResult()
        {
            _result.Clear();
            _diagnostics.Clear();
            _useSiteDiagnostics.Clear();
        }

        public static LookupContext GetInstance(Compilation compilation, Language language)
        {
            if (compilation is null) throw new ArgumentNullException(nameof(compilation));
            if (language is null) throw new ArgumentNullException(nameof(language));
            if (s_lookupContextPool is null)
            {
                Interlocked.CompareExchange(ref s_lookupContextPool, new ObjectPool<LookupContext>(() => new LookupContext(s_lookupContextPool), 128), null);
            }
            var result = s_lookupContextPool.Allocate();
            result._compilation = compilation;
            result._language = language;
            result._defaultLookupValidator = compilation.DefaultLookupValidator;
            result._errorSymbolFactory = compilation.ServiceProvider.Resolve<ErrorSymbolFactory>();
            return result;
        }

        public virtual LookupContext AllocateCopy()
        {
            var context = GetInstance(_compilation, _language);
            context.MultiLookupKey = _multiLookupKey;
            context.OriginalBinder = _originalBinder;
            context.CurrentBinder = _currentBinder;
            context.Location = _location;
            context.Validators.UnionWith(_validators);
            context.SetName(_name, _metadataName);
            context.SetNamePrefixes(_namePrefixes);
            context.SetNameSuffixes(_nameSuffixes);
            context.Alias = _alias;
            context.Qualifier = _qualifier;
            context.QualifierContext = _qualifierContext;
            context.BaseTypesBeingResolved.UnionWith(_baseTypesBeingResolved);
            context.AccessThroughType = _accessThroughType;
            context._flags = _flags;
            return context;
        }

        public void SetName(string name, string? metadataName = null)
        {
            _name = name;
            _metadataName = metadataName;
            ComputeViableNames();
        }

        public void SetNamePrefixes(IEnumerable<string> prefixes)
        {
            if (_namePrefixes.Count == 0 && !prefixes.Any()) return;
            _namePrefixes.Clear();
            _namePrefixes.UnionWith(prefixes);
            ComputeViableNames();
        }

        public void SetNameSuffixes(IEnumerable<string> suffixes)
        {
            if (_nameSuffixes.Count == 0 && !suffixes.Any()) return;
            _nameSuffixes.Clear();
            _nameSuffixes.UnionWith(suffixes);
            ComputeViableNames();
        }

        private void ComputeViableNames()
        {
            _viableNames.Clear();
            if (!string.IsNullOrEmpty(_name))
            {
                _viableNames.Add(_name);
                if (_namePrefixes.Count > 0 && _nameSuffixes.Count > 0)
                {
                    foreach (var prefix in _namePrefixes)
                    {
                        foreach (var suffix in _nameSuffixes)
                        {
                            _viableNames.Add($"{prefix}{_name}{suffix}");
                        }
                    }
                }
                else if (_namePrefixes.Count > 0 || _nameSuffixes.Count > 0)
                {
                    foreach (var prefix in _namePrefixes)
                    {
                        _viableNames.Add($"{prefix}{_name}");
                    }
                    foreach (var suffix in _nameSuffixes)
                    {
                        _viableNames.Add($"{_name}{suffix}");
                    }
                }
            }
            _viableMetadataNames.Clear();
            if (!string.IsNullOrEmpty(_metadataName))
            {
                _viableMetadataNames.Add(_metadataName);
                if (_namePrefixes.Count > 0 && _nameSuffixes.Count > 0)
                {
                    foreach (var prefix in _namePrefixes)
                    {
                        foreach (var suffix in _nameSuffixes)
                        {
                            _viableMetadataNames.Add($"{prefix}{_metadataName}{suffix}");
                        }
                    }
                }
                else
                {
                    foreach (var prefix in _namePrefixes)
                    {
                        _viableMetadataNames.Add($"{prefix}{_metadataName}");
                    }
                    foreach (var suffix in _nameSuffixes)
                    {
                        _viableMetadataNames.Add($"{_metadataName}{suffix}");
                    }
                }
            }
        }

        public void SetQualifier(DeclarationSymbol? qualifier, LookupContext? qualifierContext = null)
        {
            _qualifier = qualifier;
            _qualifierContext = qualifierContext;
        }

        public void AddValidator(ILookupValidator validator)
        {
            _validators.Add(validator);
        }

        public bool IsViable(DeclarationSymbol symbol)
        {
            if (_originalBinder is not null) return ((ILookupValidator)_originalBinder).IsViable(this, symbol);
            else return DefaultLookupValidator.IsViable(this, symbol);
        }

        public SingleLookupResult Validate(DeclarationSymbol symbol)
        {
            var unwrappedSymbol = Binder.UnwrapAlias(symbol) as DeclarationSymbol;
            if (_originalBinder is not null) return ((ILookupValidator)_originalBinder).ValidateResult(this, symbol, unwrappedSymbol);
            else return DefaultLookupValidator.ValidateResult(this, symbol, unwrappedSymbol);
        }

        public bool AddResult(DeclarationSymbol symbol)
        {
            var viable = IsViable(symbol);
            if (viable) _result.MergeEqual(Validate(symbol));
            return viable;
        }

        public void AddResult(SingleLookupResult result)
        {
            _result.MergeEqual(result);
        }

        public void AddResults(IEnumerable<DeclarationSymbol> symbols)
        {
            foreach (var symbol in symbols)
            {
                AddResult(symbol);
            }
        }

        public void AddResults(LookupCandidates candidates)
        {
            foreach (var symbol in candidates.Symbols)
            {
                AddResult(symbol);
            }
            if (this.Diagnose) this.UseSiteDiagnostics.UnionWith(candidates.UseSiteDiagnostics);
        }

        public void AddDiagnostic(Diagnostic diagnostic)
        {
            if (this.Diagnose) this.Diagnostics.Add(diagnostic);
        }

        /// <summary>
        /// Retrieves the single best result of the lookup. Never gives a null result:
        /// if the symbol could not be resolved, an error symbol will be returned.
        /// </summary>
        public DeclarationSymbol GetResultSymbol()
        {
            DefaultLookupValidator.TryGetResultSymbol(this, out var resultSymbol);
            return resultSymbol;
        }

        public void MergeHidingLookupCandidates(LookupCandidates resultHiding, LookupCandidates resultHidden)
        {
            // TODO:MetaDslx
            resultHiding.Merge(resultHidden);
        }
    }
}
