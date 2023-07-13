using MetaDslx.CodeAnalysis.PooledObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis.Symbols
{
    public class SymbolDisplayFormat
    {
        public readonly SymbolDisplayFormat Default = new SymbolDisplayFormat();
        public readonly SymbolDisplayFormat QualifiedNameOnlyFormat = new QualifiedNameOnlySymbolFormat();
        public readonly SymbolDisplayFormat FullyQualifiedFormat = new FullyQualifiedFormatSymbolFormat();

        protected SymbolDisplayFormat() 
        { 
        }

        public virtual string Format(Symbol? symbol)
        {
            if (symbol is null) return string.Empty;
            return symbol.MetadataName + " (" + symbol.GetKindText() + ")";
        }
    }

    internal class QualifiedNameOnlySymbolFormat : SymbolDisplayFormat
    {
        public override string Format(Symbol? symbol)
        {
            if (symbol is null) return string.Empty;
            var builder = PooledStringBuilder.GetInstance();
            var sb = builder.Builder;
            var container = symbol;
            while (container is not null) 
            {
                if (sb.Length > 0) sb.Append(".");
                sb.Append(container.MetadataName);
                container = container.ContainingSymbol as DeclaredSymbol;
            }
            return builder.ToStringAndFree();
        }
    }

    internal class FullyQualifiedFormatSymbolFormat : SymbolDisplayFormat
    {
        public override string Format(Symbol? symbol)
        {
            if (symbol is null) return string.Empty;
            var builder = PooledStringBuilder.GetInstance();
            var sb = builder.Builder;
            var container = symbol;
            while (container is not null)
            {
                if (sb.Length > 0) sb.Append(".");
                else sb.Append("global::");
                sb.Append(container.MetadataName);
                container = container.ContainingSymbol as DeclaredSymbol;
            }
            return builder.ToStringAndFree();
        }
    }
}
