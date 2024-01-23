using MetaDslx.CodeAnalysis.Binding;
using MetaDslx.CodeAnalysis.Symbols;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Roslyn.Utilities;
using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.PooledObjects;

namespace MetaDslx.Languages.MetaCompiler.Symbols
{
    internal class SymbolPropertyBinder : UseBinder, IMultiLookupBinder
    {
        private ImmutableArray<MetaType> _expectedTypes;
        private ImmutableArray<object?> _expectedTypeObjects;
        private PElementSymbol? _containingElement;

        public SymbolPropertyBinder()
            : base(ImmutableArray.Create(typeof(DeclarationSymbol)))
        {
        }

        public PElementSymbol? ContainingElement
        {
            get
            {
                if (_containingElement is null)
                {
                    PElementSymbol? containingElement = null;
                    Binder? currentBinder = this;
                    while (currentBinder != null)
                    {
                        if (currentBinder is IDefineBinder defineBinder)
                        {
                            foreach (var symbol in defineBinder.DefinedSymbols)
                            {
                                containingElement = symbol.GetInnermostContainingSymbol<PElementSymbol>(includeSelf: true);
                                break;
                            }
                            break;
                        }
                        currentBinder = currentBinder.ParentBinder;
                    }
                    Interlocked.CompareExchange(ref _containingElement, containingElement, null);
                }
                return _containingElement;
            }
        }

        public ImmutableArray<MetaType> ExpectedTypes
        {
            get
            {
                if (_expectedTypes.IsDefault)
                {
                    ImmutableInterlocked.InterlockedInitialize(ref _expectedTypes, GetExpectedTypes());
                }
                return _expectedTypes;
            }
        }

        private ImmutableArray<MetaType> GetExpectedTypes()
        {
            var alt = ContainingElement?.ContainingPAlternativeSymbol;
            if (alt is null || alt.IsResolvingExpectedTypes) return ImmutableArray<MetaType>.Empty;
            else return alt.ExpectedTypes;
        }

        public ImmutableArray<object> GetMultiLookupKeys(CancellationToken cancellationToken = default)
        {
            if (_expectedTypeObjects.IsDefault)
            {
                ImmutableInterlocked.InterlockedInitialize(ref _expectedTypeObjects, ExpectedTypes.Where(et => et.IsTypeSymbol).Select(et => (object)et).ToImmutableArray());
            }
            return _expectedTypeObjects;
        }

        protected override bool IsViable(LookupContext context, DeclarationSymbol symbol)
        {
            if (context.MultiLookupKey is null) return false;
            var alt = (MetaType)context.MultiLookupKey;
            if (alt.IsNull || !alt.IsTypeSymbol) return false;
            return base.IsViable(context, symbol);
        }

        protected override void AdjustFinalLookupContext(LookupContext context)
        {
            base.AdjustFinalLookupContext(context);
            context.IgnoreDiagnostics = true;
            if (context.MultiLookupKey is null) return;
            context.IsCaseSensitive = false;
            var alt = (MetaType)context.MultiLookupKey;
            if (alt.IsNull || !alt.IsTypeSymbol) return;
            context.Qualifier = alt.OriginalTypeSymbol;
            context.IgnoreDiagnostics = context.Qualifier?.IsError ?? true;
        }

        protected override Diagnostic UpdateDiagnostic(LookupContext context, Diagnostic diagnostic)
        {
            var trace = string.Join(", ", ResolveTrace());
            return Diagnostic.Create(CommonErrorCode.ERR_BindingError, this.Location, $"{diagnostic} [{trace}]" );
        }

        private ImmutableArray<string> ResolveTrace()
        {
            var elem = ContainingElement;
            var alt = elem?.ContainingPAlternativeSymbol;
            var grammar = alt?.GetOutermostContainingSymbol<GrammarSymbol>();
            if (grammar is null) return ImmutableArray<string>.Empty;
            return grammar.ResolveTrace(elem, et => true);
        }

    }
}
