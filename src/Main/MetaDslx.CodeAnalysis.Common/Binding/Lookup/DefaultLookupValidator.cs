using MetaDslx.CodeAnalysis.Symbols;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis.Binding
{
    public class DefaultLookupValidator : ILookupValidator
    {
        public bool IsViable(LookupContext context, DeclaredSymbol? symbol)
        {
            if (symbol is null) return false;
            if (context.ViableNames.Count > 0 && !context.ViableNames.Contains(symbol.Name)) return false;
            if (context.ViableMetadataNames.Count > 0 && !context.ViableMetadataNames.Contains(symbol.MetadataName)) return false;
            return true;
        }

        public void CheckSingleResultViability(LookupContext context, ref SingleLookupResult result, AliasSymbol? aliasSymbol)
        {
        }

        public void CheckFinalResultViability(LookupContext context, LookupResult result)
        {
        }

    }
}
