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
        }

        private readonly ObjectPool<LookupContext> _pool;
        private readonly Compilation _compilation;
        private readonly Language _language;
        private readonly DefaultLookupValidator _defaultLookupValidator;
        private readonly ErrorSymbolFactory _errorSymbolFactory;
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

        internal protected LookupContext(ObjectPool<LookupContext> pool, Compilation compilation, Language language)
        {
            _pool = pool;
            _compilation = compilation;
            _language = language;
            _defaultLookupValidator = _compilation[_language].DefaultLookupValidator;
            _errorSymbolFactory = _compilation[_language].ErrorSymbolFactory;
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
        public bool IsCaseSensitive
        {
            get => _flags.HasFlag(LookupFlags.IsCaseSensitive);
            set
            {
                if (value) _flags |= LookupFlags.IsCaseSensitive;
                else _flags &= ~LookupFlags.IsCaseSensitive;
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

        public virtual LookupContext AllocateCopy()
        {
            var context = Compilation[Language].SemanticsFactory.LookupContextPool.Allocate();
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
            _namePrefixes.UnionWith(prefixes.Where(p => !string.IsNullOrWhiteSpace(p)));
            ComputeViableNames();
        }

        public void SetNameSuffixes(IEnumerable<string> suffixes)
        {
            if (_nameSuffixes.Count == 0 && !suffixes.Any()) return;
            _nameSuffixes.Clear();
            _nameSuffixes.UnionWith(suffixes.Where(s => !string.IsNullOrWhiteSpace(s)));
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
            var unwrappedSymbol = AliasSymbol.UnwrapAlias(this, symbol) as DeclarationSymbol;
            if (_originalBinder is not null) return ((ILookupValidator)_originalBinder).ValidateResult(this, symbol, unwrappedSymbol);
            else return DefaultLookupValidator.ValidateResult(this, symbol, unwrappedSymbol);
        }

        public Diagnostic UpdateDiagnostic(Diagnostic diagnostic)
        {
            if (_originalBinder is not null) return ((ILookupValidator)_originalBinder).UpdateDiagnostic(this, diagnostic);
            else return DefaultLookupValidator.UpdateDiagnostic(this, diagnostic);
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
