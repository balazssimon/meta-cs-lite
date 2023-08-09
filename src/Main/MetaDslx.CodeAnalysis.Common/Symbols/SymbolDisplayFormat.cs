using MetaDslx.CodeAnalysis.PooledObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis.Symbols
{
    public class SymbolDisplayFormat
    {
        public static readonly SymbolDisplayFormat Default = new SymbolDisplayFormat(includeSymbolDisplayKind: true);
        public static readonly SymbolDisplayFormat QualifiedNameOnlyFormat = new SymbolDisplayFormat(includeQualifier: true);
        public static readonly SymbolDisplayFormat QualifiedNameArityFormat = new SymbolDisplayFormat(includeQualifier: true, includeArity: true);
        public static readonly SymbolDisplayFormat FullyQualifiedFormat = new SymbolDisplayFormat(includeQualifier: true, includeGlobalScope: true);

        private readonly bool _includeSymbolKind;
        private readonly bool _includeSymbolDisplayKind;
        private readonly bool _includeQualifier;
        private readonly bool _includeArity;
        private readonly bool _includeGlobalScope;

        protected SymbolDisplayFormat(bool includeSymbolKind = false, bool includeSymbolDisplayKind = false, bool includeQualifier = false, bool includeArity = false, bool includeGlobalScope = false)
        {
            _includeSymbolKind = includeSymbolKind;
            _includeSymbolDisplayKind = includeSymbolDisplayKind;
            _includeQualifier = includeQualifier;
            _includeGlobalScope = includeGlobalScope;
            _includeArity = includeArity;
        }

        public bool IncludeSymbolKind => _includeSymbolKind;
        public bool IncludeSymbolDisplayKind => _includeSymbolDisplayKind;
        public bool IncludeQualifier => _includeQualifier;
        public bool IncludeArity => _includeArity;
        public bool IncludeGlobalScope => _includeGlobalScope;

        public string ToString(Symbol? symbol)
        {
            if (symbol is null) return string.Empty;
            var builder = PooledStringBuilder.GetInstance();
            var sb = builder.Builder;
            if (IncludeSymbolDisplayKind)
            {
                sb.Append(symbol.DisplayKind);
                sb.Append(" '");
            }
            if (symbol is DeclaredSymbol declaredSymbol)
            {
                if (IncludeQualifier)
                {
                    var container = declaredSymbol;
                    while (container is not null)
                    {
                        if (sb.Length > 0) sb.Insert(0, ".");
                        sb.Insert(0, IncludeArity ? container.MetadataName : container.Name);
                        container = container.ContainingSymbol as DeclaredSymbol;
                    }
                    if (IncludeGlobalScope)
                    {
                        sb.Insert(0, "global::");
                    }
                }
                else
                {
                    sb.Append(IncludeArity ? declaredSymbol.MetadataName : declaredSymbol.Name);
                }
            }
            else 
            {
                sb.Append(IncludeArity ? symbol.MetadataName : symbol.Name);
            }
            if (IncludeSymbolDisplayKind)
            {
                sb.Append("'");
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
