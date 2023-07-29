using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.CodeAnalysis.Symbols;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.CodeAnalysis.Binding
{
    public class ScopeBinder : Binder, IScopeBinder
    {
        private readonly bool _local;
        private ImmutableArray<Symbol> _containingSymbols;

        public ScopeBinder(bool local = false)
        {
            _local = local;
        }

        public bool IsLocal => _local;

        public override ImmutableArray<Symbol> GetContainingSymbols()
        {
            if (!_containingSymbols.IsDefault) return _containingSymbols;
            var parent = ParentBinder;
            var parentSymbols = parent?.GetDefinedSymbols() ?? ImmutableArray<Symbol>.Empty;
            while (parent is not null && parentSymbols.IsDefaultOrEmpty)
            {
                parent = parent.ParentBinder;
                parentSymbols = parent?.GetDefinedSymbols() ?? ImmutableArray<Symbol>.Empty;
            }
            if (parentSymbols.IsDefaultOrEmpty) return ImmutableArray<Symbol>.Empty;
            ImmutableInterlocked.InterlockedInitialize(ref _containingSymbols, parentSymbols);
            return _containingSymbols;
        }

        public override string ToString()
        {
            var builder = PooledStringBuilder.GetInstance();
            var sb = builder.Builder;
            sb.Append(this.GetType().Name);
            sb.Append(": [");
            var delim = string.Empty;
            foreach (var symbol in GetContainingSymbols())
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
