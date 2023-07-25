using MetaDslx.CodeAnalysis.PooledObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis.Symbols
{
    public class SymbolDisplayFormat
    {
        public static readonly SymbolDisplayFormat Default = new SymbolDisplayFormat(includeSymbolKind: true);
        public static readonly SymbolDisplayFormat QualifiedNameOnlyFormat = new SymbolDisplayFormat(includeQualifier: true);
        public static readonly SymbolDisplayFormat FullyQualifiedFormat = new SymbolDisplayFormat(includeQualifier: true, includeGlobalScope: true);

        private readonly bool _includeSymbolKind;
        private readonly bool _includeQualifier;
        private readonly bool _includeGlobalScope;

        protected SymbolDisplayFormat(bool includeSymbolKind = false, bool includeQualifier = false, bool includeGlobalScope = false)
        {
            _includeSymbolKind = includeSymbolKind;
            _includeQualifier = includeQualifier;
            _includeGlobalScope = includeGlobalScope;
        }

        public bool IncludeSymbolKind => _includeSymbolKind;
        public bool IncludeQualifier => _includeQualifier;
        public bool IncludeGlobalScope => _includeGlobalScope;

        public string ToString(Symbol? symbol)
        {
            if (symbol is null) return string.Empty;
            var builder = PooledStringBuilder.GetInstance();
            var sb = builder.Builder;
            if (symbol is DeclaredSymbol declaredSymbol)
            {
                if (IncludeQualifier)
                {
                    var container = declaredSymbol;
                    while (container is not null)
                    {
                        if (sb.Length > 0) sb.Insert(0, ".");
                        sb.Insert(0, container.MetadataName);
                        container = container.ContainingSymbol as DeclaredSymbol;
                    }
                    if (IncludeGlobalScope)
                    {
                        sb.Insert(0, "global::");
                    }
                }
                else
                {
                    sb.Append(declaredSymbol.MetadataName);
                }
            }
            else if (symbol is NamedSymbol namedSymbol)
            {
                sb.Append(namedSymbol.MetadataName);
            }
            if (IncludeSymbolKind)
            {
                if (sb.Length > 0) sb.Append(" ");
                sb.Append("[");
                sb.Append(symbol.GetType().Name);
                sb.Append("]");
            }
            return builder.ToStringAndFree();
        }
    }
}
