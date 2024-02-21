using MetaDslx.CodeAnalysis.Symbols;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace MetaDslx.CodeAnalysis.Binding
{
    public partial class Binder : ILookupValidator
    {
        public DefaultLookupValidator DefaultLookupValidator => Compilation[Language].DefaultLookupValidator;

        public LookupContext AllocateLookupContext(
            string? name = null,
            string? metadataName = null,
            SyntaxNodeOrToken alias = default,
            DeclarationSymbol? qualifier = null,
            LookupContext? qualifierContext = null,
            TypeSymbol? accessThroughType = null,
            IEnumerable<TypeSymbol>? baseTypesBeingResolved = null,
            bool diagnose = false,
            bool isCaseSensitive = true,
            bool inImport = false,
            bool isLookup = false,
            object? multiLookupKey = null,
            IEnumerable<ILookupValidator>? validators = null)
        {
            var context = Compilation[Language].SemanticsFactory.LookupContextPool.Allocate();
            context.MultiLookupKey = multiLookupKey;
            context.OriginalBinder = this;
            context.Location = this.Location;
            if (validators is not null) context.Validators.UnionWith(validators);
            context.SetName(name, metadataName);
            context.Alias = alias;
            context.SetQualifier(qualifier, qualifierContext);
            if (baseTypesBeingResolved is not null) context.BaseTypesBeingResolved.UnionWith(baseTypesBeingResolved);
            context.AccessThroughType = accessThroughType;
            context.Diagnose = diagnose;
            context.IsCaseSensitive = isCaseSensitive;
            context.InImport = inImport;
            context.IsLookup = isLookup;
            return context;
        }

        protected virtual void AdjustInitialLookupContext(LookupContext context)
        {
            if (_parentBinder is not null) _parentBinder.AdjustInitialLookupContext(context);
        }

        protected virtual void AdjustFinalLookupContext(LookupContext context)
        {
            if (_parentBinder is not null) _parentBinder.AdjustFinalLookupContext(context);
        }

        protected virtual bool IsViable(LookupContext context, DeclarationSymbol symbol)
        {
            return DefaultLookupValidator.IsViable(context, symbol);
        }

        protected virtual SingleLookupResult ValidateResult(LookupContext context, DeclarationSymbol resultSymbol, DeclarationSymbol unwrappedSymbol)
        {
            return DefaultLookupValidator.ValidateResult(context, resultSymbol, unwrappedSymbol);
        }

        bool ILookupValidator.IsViable(LookupContext context, DeclarationSymbol symbol)
        {
            return this.IsViable(context, symbol);
        }

        SingleLookupResult ILookupValidator.ValidateResult(LookupContext context, DeclarationSymbol resultSymbol, DeclarationSymbol unwrappedSymbol)
        {
            return this.ValidateResult(context, resultSymbol, unwrappedSymbol);
        }

        public Binder LookupSymbols(LookupContext context)
        {
            var originalDiagnose = context.Diagnose;
            try
            {
                // don't create diagnosis instances unless lookup fails
                context.Diagnose = false;
                var binder = this.LookupSymbolsInternal(context);
                var result = context.Result;
                Debug.Assert((binder != null) || result.IsClear);
                
                if (result.Kind != LookupResultKind.Viable && result.Kind != LookupResultKind.Empty)
                {
                    result.Clear();
                    // retry to get diagnosis
                    context.Diagnose = true; 
                    var otherBinder = this.LookupSymbolsInternal(context);
                    Debug.Assert(binder == otherBinder);
                }

                Debug.Assert(result.IsMultiViable || result.IsClear || result.Error != null);
                return binder;
            }
            finally
            {
                context.Diagnose = originalDiagnose;
            }
        }

        private Binder LookupSymbolsInternal(LookupContext context)
        {
            var result = context.Result;
            Debug.Assert(result.IsClear);

            LookupContext? contextCopy = null;
            Binder binder = null;
            for (var scope = this; scope != null && !result.IsMultiViable; scope = scope.ParentBinder)
            {
                if (binder != null)
                {
                    if (contextCopy is null) contextCopy = context.AllocateCopy();
                    contextCopy.ClearResult();
                    scope.LookupSymbolsInSingleBinder(contextCopy);
                    result.MergeEqual(contextCopy.Result);
                    if (context.Diagnose) context.UseSiteDiagnostics.UnionWith(contextCopy.UseSiteDiagnostics);
                }
                else
                {
                    scope.LookupSymbolsInSingleBinder(context);
                    if (!result.IsClear) binder = scope;
                }
            }
            if (contextCopy is not null) contextCopy.Free();
            return binder;
        }

        private void LookupSymbolsInSingleBinder(LookupContext context)
        {
            var candidates = LookupCandidates.GetInstance();
            AddLookupCandidateSymbolsInSingleBinder(context, candidates);
            context.AddResults(candidates);
            candidates.Free();
        }

        public void AddCompletionSymbols(LookupContext context, LookupCandidates result)
        {
            this.AddLookupCandidateSymbols(context, result);
        }

        private void AddLookupCandidateSymbols(LookupContext context, LookupCandidates result)
        {
            var adjustedContext = context.AllocateCopy();
            this.AdjustInitialLookupContext(adjustedContext);
            this.AdjustFinalLookupContext(adjustedContext);
            try
            {
                for (var scope = this; scope != null; scope = scope.ParentBinder)
                {
                    scope.AddLookupCandidateSymbolsInSingleBinder(context, result);
                }
            }
            finally
            {
                adjustedContext.Free();
            }
        }

        protected virtual void AddLookupCandidateSymbolsInSingleBinder(LookupContext context, LookupCandidates result)
        {
            var originalQualifier = context.Qualifier;
            try
            {
                if (originalQualifier is null)
                {
                    foreach (var scope in this.ContainingScopeSymbols)
                    {
                        context.Qualifier = scope;
                        this.AddCandidateSymbolsInternal(context, result);
                    }
                }
                else
                {
                    context.Qualifier = UnwrapAlias(context.Qualifier) as DeclarationSymbol;
                    this.AddCandidateSymbolsInternal(context, result);
                }
            }
            finally
            {
                context.Qualifier = originalQualifier;
            }
        }

        private void AddCandidateSymbolsInternal(LookupContext context, LookupCandidates result)
        {
            var originalAccessThroughType = context.AccessThroughType;
            try
            {
                var qualifierIsError = context.Qualifier.IsErrorSymbol;
                if (qualifierIsError)
                {
                    AddLookupCandidateSymbolsInErrorSymbol(context, result);
                    return;
                }
                var qualifierIsType = context.Qualifier is TypeSymbol;
                if (!qualifierIsType) context.AccessThroughType = null;
                AddLookupCandidateSymbolsInScope(context, result);
                if (result.IsClear) AddLookupCandidateSymbolsFromImports(context, result);
                // TODO:MetaDslx: Submissions
                if (qualifierIsType && result.IsClear) AddLookupCandidateSymbolsInBaseTypes(context, result);
            }
            finally
            {
                context.AccessThroughType = originalAccessThroughType;
            }
        }

        private void AddLookupCandidateSymbolsInErrorSymbol(LookupContext context, LookupCandidates result)
        {
            var qualifier = context.Qualifier;
            var candidateSymbols = qualifier.ErrorInfo.CandidateSymbols;
            if (!candidateSymbols.IsDefault && candidateSymbols.Length == 1 && candidateSymbols[0] is DeclarationSymbol declaredSymbol && !declaredSymbol.IsErrorSymbol)
            {
                try
                {
                    context.Qualifier = declaredSymbol;
                    AddLookupCandidateSymbolsInScope(context, result);
                }
                finally
                {
                    context.Qualifier = qualifier;
                }
            }
        }

        private void AddLookupCandidateSymbolsFromImports(LookupContext context, LookupCandidates result)
        {
            if (context.InImport) return;
            var qualifier = context.Qualifier;
            if (qualifier is not null)
            {
                context.InImport = true;
                try
                {
                    foreach (var import in qualifier.Imports)
                    {
                        result.AddRange(import.Aliases.Where(a => context.IsViable(a)));
                        foreach (var ns in import.Namespaces)
                        {
                            result.AddRange(ns.Members.Where(m => context.IsViable(m)));
                        }
                        result.AddRange(import.Symbols.Where(m => context.IsViable(m)));
                    }
                }
                finally
                {
                    context.InImport = false;
                }
            }
        }

        private void AddLookupCandidateSymbolsInScope(LookupContext context, LookupCandidates result)
        {
            var qualifier = context.Qualifier;
            if (qualifier is not null)
            {
                result.AddRange(qualifier.Members.Where(m => context.IsViable(m)));
            }
        }

        private void AddLookupCandidateSymbolsInBaseTypes(LookupContext context, LookupCandidates result)
        {
            var type = context.Qualifier as TypeSymbol;
            Debug.Assert(type is not null);
            try
            {
                var tmp = LookupCandidates.GetInstance();
                foreach (var currentType in type.AllBaseTypes)
                {
                    tmp.Clear();
                    context.Qualifier = currentType;
                    AddLookupCandidateSymbolsInScope(context, tmp);
                    context.MergeHidingLookupCandidates(result, tmp);
                }
                tmp.Free();
            }
            finally
            {
                context.Qualifier = type;
            }
        }

        public static Symbol UnwrapAlias(Symbol symbol)
        {
            if (symbol is AliasSymbol aliasSymbol) return aliasSymbol.Target;
            else return symbol;
        }
    }
}
