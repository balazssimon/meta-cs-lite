using MetaDslx.CodeAnalysis.Symbols;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis.Binding
{
    public interface ILookupValidator
    {
        bool IsViable(LookupContext context, DeclaredSymbol symbol);
        /// <summary>
        /// General pattern: checks and diagnostics refer to unwrapped symbol,
        /// but lookup results refer to wrapped (alias) symbol.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="result"></param>
        /// <param name="aliasSymbol"></param>
        void CheckSingleResultViability(LookupContext context, ref SingleLookupResult result, AliasSymbol? aliasSymbol);
        void CheckFinalResultViability(LookupContext context, LookupResult result);
    }
}
