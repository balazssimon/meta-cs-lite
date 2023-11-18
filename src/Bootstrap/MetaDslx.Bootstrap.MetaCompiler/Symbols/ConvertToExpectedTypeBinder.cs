using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Binding;
using MetaDslx.CodeAnalysis.Symbols;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Bootstrap.MetaCompiler.Symbols
{
    internal class ConvertToExpectedTypeBinder : UseBinder
    {
        private MetaType _expectedType;

        public ConvertToExpectedTypeBinder()
            : base(ImmutableArray.Create(typeof(MetaSymbol)))
        {
        }

        public MetaType ExpectedType
        {
            get
            {
                if (_expectedType.IsNull)
                {
                    var expectedType = this.ContainingDefinedSymbols.OfType<ExpressionSymbol>().FirstOrDefault()?.ExpectedType ?? default;
                    _expectedType.InterlockedInitialize(expectedType);
                }
                return _expectedType;
            }
        }

        protected override void AdjustFinalLookupContext(LookupContext context)
        {
            base.AdjustFinalLookupContext(context);
            if (context.Qualifier is null)
            {
                context.Qualifier = ExpectedType.OriginalTypeSymbol;
            }
        }

        /*
        protected override bool ComputeValue(MetaType expectedType, out object? value, CancellationToken cancellationToken)
        {
            var exprExpectedType = this.ContainingDefinedSymbols.OfType<ExpressionSymbol>().FirstOrDefault()?.ExpectedType ?? default;
            if (exprExpectedType.IsEnum)
            {
                var symbol = exprExpectedType.GetEnumValue(RawValue);
                value = symbol.OriginalValue;
                return !symbol.IsNull;
            }
            return base.ComputeValue(expectedType, out value, cancellationToken);
        }*/
    }
}
