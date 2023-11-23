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
        private ImmutableArray<MetaType> _expectedTypes;
        private ImmutableArray<object?> _expectedTypeObjects;

        public SymbolPropertyBinder()
            : base(ImmutableArray.Create(typeof(DeclaredSymbol)))
        {
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
            Binder? currentBinder = this;
            while (currentBinder != null)
            {
                if (currentBinder is IDefineBinder defineBinder)
                {
                    foreach (var symbol in defineBinder.DefinedSymbols)
                    {
                        if (symbol is PAlternativeSymbol altSymbol)
                        {
                            var block = altSymbol.ContainingPBlockSymbol;
                            if (block is not null)
                            {
                                return block.ExpectedTypes;
                            }
                            else if (altSymbol.ContainingParserRuleSymbol is not null && !altSymbol.ReturnType.IsNull)
                            {
                                return ImmutableArray.Create(altSymbol.ReturnType);
                            }
                            return ImmutableArray<MetaType>.Empty;
                        }
                    }
                }
                currentBinder = currentBinder.ParentBinder;
            }
            return ImmutableArray<MetaType>.Empty;
        }

        public ImmutableArray<object> GetMultiLookupKeys(CancellationToken cancellationToken = default)
        {
            if (_expectedTypeObjects.IsDefault)
            {
                ImmutableInterlocked.InterlockedInitialize(ref _expectedTypeObjects, ExpectedTypes.Where(et => et.IsTypeSymbol).Select(et => (object)et).ToImmutableArray());
            }
            return _expectedTypeObjects;
        }

        protected override bool IsViable(LookupContext context, DeclaredSymbol symbol)
        {
            if (context.MultiLookupKey is null) return false;
            var alt = (MetaType)context.MultiLookupKey;
            if (alt.IsNull || !alt.IsTypeSymbol) return false;
            return base.IsViable(context, symbol);
        }

        protected override void AdjustFinalLookupContext(LookupContext context)
        {
            base.AdjustFinalLookupContext(context);
            if (context.MultiLookupKey is null) return;
            context.IsCaseSensitive = false;
            var alt = (MetaType)context.MultiLookupKey;
            if (alt.IsNull || !alt.IsTypeSymbol) return;
            context.Qualifier = alt.OriginalTypeSymbol;
        }
    }
}
