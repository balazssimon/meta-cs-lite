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
    internal class SymbolPropertyBinder : UseBinder
    {
        private PAlternativeSymbol? _alternativeSymbol;

        public SymbolPropertyBinder()
            : base(ImmutableArray.Create(typeof(DeclaredSymbol)))
        {
        }

        public PAlternativeSymbol? PAlternativeSymbol
        {
            get
            {
                if (_alternativeSymbol is null)
                {
                    Interlocked.CompareExchange(ref _alternativeSymbol, GetEnclosingAlternative(), null);
                }
                return _alternativeSymbol;
            }
        }

        protected PAlternativeSymbol? GetEnclosingAlternative()
        {
            Binder? currentBinder = this;
            while (currentBinder != null)
            {
                if (currentBinder is IDefineBinder defineBinder)
                {
                    foreach (var symbol in defineBinder.DefinedSymbols)
                    {
                        if (symbol is PAlternativeSymbol altSymbol && altSymbol.ContainingSymbol is ParserRuleSymbol)
                        {
                            return altSymbol;
                        }
                    }
                }
                currentBinder = currentBinder.ParentBinder;
            }
            return null;
        }

        protected override bool IsViable(LookupContext context, DeclaredSymbol symbol)
        {
            var returnType = PAlternativeSymbol?.ReturnType ?? default;
            if (returnType.IsNull || !returnType.IsTypeSymbol) return false;
            return base.IsViable(context, symbol);
        }

        protected override void AdjustFinalLookupContext(LookupContext context)
        {
            base.AdjustFinalLookupContext(context);
            context.IsCaseSensitive = false;
            context.Qualifier = PAlternativeSymbol?.ReturnType.OriginalTypeSymbol;
        }
    }
}
