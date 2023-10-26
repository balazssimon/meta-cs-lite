﻿using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.CodeAnalysis.Symbols;
using MetaDslx.CodeAnalysis.Symbols.Errors;
using Microsoft.CodeAnalysis;
using Roslyn.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Diagnostics;
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
            IsLookup = 0x04
        }

        private readonly ObjectPool<LookupContext> _pool;
        private readonly Compilation _compilation;
        private readonly Language _language;
        private readonly DefaultLookupValidator _defaultLookupValidator;
        private readonly ErrorSymbolFactory _errorSymbolFactory;
        private Binder _originalBinder;
        private SourceLocation _location;
        private HashSet<ILookupValidator> _validators;
        private HashSet<string> _viableNames;
        private HashSet<string> _viableMetadataNames;
        private SyntaxNodeOrToken _alias;
        private DeclaredSymbol? _qualifier;
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
        public SyntaxNodeOrToken Alias
        {
            get => _alias;
            set => _alias = value;
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
            _originalBinder = null;
            _location = null;
            _validators.Clear();
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
            context.OriginalBinder = _originalBinder;
            context.Location = _location;
            context.Validators.UnionWith(_validators);
            context.ViableNames.UnionWith(_viableNames);
            context.ViableMetadataNames.UnionWith(_viableMetadataNames);
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

        public void AddValidator(ILookupValidator validator)
        {
            _validators.Add(validator);
        }

        public bool IsViable(DeclaredSymbol symbol)
        {
            if (symbol is null) return false;
            if (_viableNames.Count > 0 && !_viableNames.Contains(symbol.Name)) return false;
            if (_viableMetadataNames.Count > 0 && !_viableMetadataNames.Contains(symbol.MetadataName)) return false;
            var unwrapped = AliasSymbol.UnwrapAlias(this, symbol) as DeclaredSymbol;
            if (unwrapped is null) return false;
            if (!DefaultLookupValidator.IsViable(this, unwrapped)) return false;
            foreach (var validator in this.Validators)
            {
                if (!validator.IsViable(this, unwrapped)) return false;
            }
            return true;
        }

        public SingleLookupResult Validate(DeclaredSymbol symbol)
        {
            var unwrappedSymbol = AliasSymbol.UnwrapAlias(this, symbol) as DeclaredSymbol;
            var result = LookupResult.Good(symbol);
            var defaultResult = DefaultLookupValidator.ValidateResult(this, symbol, unwrappedSymbol);
            if (defaultResult.Kind > LookupResultKind.Empty && defaultResult.Kind < result.Kind)
            {
                result = defaultResult;
            }
            foreach (var validator in this.Validators)
            {
                var tempResult = validator.ValidateResult(this, symbol, unwrappedSymbol);
                if (tempResult.Kind > LookupResultKind.Empty && tempResult.Kind < result.Kind)
                {
                    result = tempResult;
                }
            }
            return result;
        }

        public bool AddResult(DeclaredSymbol symbol)
        {
            var viable = IsViable(symbol);
            if (viable) _result.MergeEqual(Validate(symbol));
            return viable;
        }

        public void AddResult(SingleLookupResult result)
        {
            _result.MergeEqual(result);
        }

        public void AddResults(IEnumerable<DeclaredSymbol> symbols)
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
        public DeclaredSymbol GetResultSymbol()
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