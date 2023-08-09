using MetaDslx.CodeAnalysis.Symbols;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis.Binding
{
    public interface ILookupValidator
    {
        /// <summary>
        /// Provides a quick feedback about a symbol whether it should be considered
        /// at all for the given lookup context. 
        /// If <see cref="IsViable(LookupContext, DeclaredSymbol)"/> returns false,
        /// the candidate symbol will not be added to the lookup results.
        /// If the symbol is wrong, but a diagnostic may explain the problem, 
        /// <see cref="IsViable(LookupContext, DeclaredSymbol)"/> should return true 
        /// and <see cref="ValidateResult(LookupContext, DeclaredSymbol, DeclaredSymbol)"/>
        /// should provide the appropriate diagnostic for the symbol.
        /// </summary>
        /// <param name="context">The constraints of the current lookup.</param>
        /// <param name="symbol">A symbol that is considered to be added to the lookup results.</param>
        /// <returns></returns>
        bool IsViable(LookupContext context, DeclaredSymbol symbol);

        /// <summary>
        /// Checks the result symbol and provides diagnostic in case the symbol is wrong.
        /// General pattern: checks and diagnostics refer to the unwrapped symbol,
        /// but lookup results refer to the result symbol.
        /// </summary>
        /// <param name="context">The constraints of the current lookup</param>
        /// <param name="resultSymbol">The result symbol to be validated.</param>
        /// <param name="unwrappedSymbol">If the result symbol is an alias, the unwrapped symbol is its target. Otherwise, the result symbol and the unwrapped symbol are the same.</param>
        SingleLookupResult ValidateResult(LookupContext context, DeclaredSymbol resultSymbol, DeclaredSymbol unwrappedSymbol);
    }
}
