using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.CodeAnalysis.Symbols;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Binding
{
    public class ScopeBinder : Binder, IScopeBinder
    {
        private readonly bool _local;
        private ImmutableArray<DeclarationSymbol> _containingScopeSymbols;

        public ScopeBinder(bool local = false)
        {
            _local = local;
        }

        public bool IsLocal => _local;

        public override ImmutableArray<DeclarationSymbol> ContainingScopeSymbols
        {
            get
            {
                if (!_containingScopeSymbols.IsDefault) return _containingScopeSymbols;
                var parent = ParentBinder;
                var parentSymbols = parent?.DefinedSymbols ?? ImmutableArray<Symbol>.Empty;
                while (parent is not null && parentSymbols.IsDefaultOrEmpty)
                {
                    parent = parent.ParentBinder;
                    parentSymbols = parent?.DefinedSymbols ?? ImmutableArray<Symbol>.Empty;
                }
                if (parentSymbols.IsDefaultOrEmpty) return ImmutableArray<DeclarationSymbol>.Empty;
                ImmutableInterlocked.InterlockedInitialize(ref _containingScopeSymbols, parentSymbols.OfType<DeclarationSymbol>().ToImmutableArray());
                return _containingScopeSymbols;
            }
        }

        protected override void CollectNameBinders(ArrayBuilder<INameBinder> nameBinders, CancellationToken cancellationToken)
        {
        }

        protected override void CollectQualifierBinders(ArrayBuilder<IQualifierBinder> qualifierBinders, CancellationToken cancellationToken)
        {
        }

        protected override void CollectIdentifierBinders(ArrayBuilder<IIdentifierBinder> identifierBinders, CancellationToken cancellationToken)
        {
        }

        protected override void CollectValueBinders(IPropertyBinder propertyBinder, ArrayBuilder<IValueBinder> valueBinders, CancellationToken cancellationToken)
        {
        }

        public override string ToString()
        {
            var builder = PooledStringBuilder.GetInstance();
            var sb = builder.Builder;
            sb.Append(this.GetType().Name);
            sb.Append(": [");
            var delim = string.Empty;
            foreach (var symbol in ContainingScopeSymbols)
            {
                sb.Append(delim);
                sb.Append(symbol);
                delim = ", ";
            }
            sb.Append("]");
            return builder.ToStringAndFree();
        }
    }
}
