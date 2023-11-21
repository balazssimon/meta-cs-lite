using MetaDslx.CodeAnalysis.Binding;
using MetaDslx.CodeAnalysis.Symbols;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Roslyn.Utilities;
using MetaDslx.CodeAnalysis;

namespace MetaDslx.Bootstrap.MetaCompiler.Symbols
{
    internal class SymbolPropertyBinder : UseBinder, IMultiLookupBinder
    {
        private ImmutableArray<PAlternativeSymbol> _alternatives;

        public SymbolPropertyBinder()
            : base(ImmutableArray.Create(typeof(DeclaredSymbol)))
        {
        }

        public ImmutableArray<PAlternativeSymbol> Alternatives
        {
            get
            {
                if (_alternatives.IsDefault)
                {
                    ImmutableInterlocked.InterlockedInitialize(ref _alternatives, GetAlternatives());
                }
                return _alternatives;
            }
        }

        private ImmutableArray<PAlternativeSymbol> GetAlternatives()
        {
            Binder? currentBinder = this;
            while (currentBinder != null)
            {
                if (currentBinder is IDefineBinder defineBinder)
                {
                    foreach (var symbol in defineBinder.DefinedSymbols)
                    {
                        if (symbol is PAlternativeSymbol altSymbol && altSymbol.ContainingSymbol is ParserRuleSymbol ruleSymbol)
                        {
                            if (ruleSymbol.IsBlock)
                            {
                                var grammar = ruleSymbol.ContainingGrammarSymbol;
                                if (grammar is not null && grammar.BlockFromAlterativeReferences.TryGetValue(ruleSymbol, out var blockRefs))
                                {
                                    return blockRefs;
                                }
                            }
                            else
                            {
                                return ImmutableArray.Create(altSymbol);
                            }
                            return ImmutableArray<PAlternativeSymbol>.Empty;
                        }
                    }
                }
                currentBinder = currentBinder.ParentBinder;
            }
            return ImmutableArray<PAlternativeSymbol>.Empty;
        }

        public ImmutableArray<object> GetMultiLookupKeys(CancellationToken cancellationToken = default)
        {
            return Alternatives.CastArray<object>();
        }

        protected override bool IsViable(LookupContext context, DeclaredSymbol symbol)
        {
            var alt = context.MultiLookupKey as PAlternativeSymbol;
            if (alt is null) return false;
            var returnType = alt.ReturnType;
            if (returnType.IsNull || !returnType.IsTypeSymbol) return false;
            return base.IsViable(context, symbol);
        }

        protected override void AdjustFinalLookupContext(LookupContext context)
        {
            base.AdjustFinalLookupContext(context);
            context.IsCaseSensitive = false;
            var alt = context.MultiLookupKey as PAlternativeSymbol;
            context.Qualifier = alt?.ReturnType.OriginalTypeSymbol;
        }
    }
}
