﻿using MetaDslx.CodeAnalysis.Symbols;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis.Binding.Lookup
{
    public class LookupTypeOnlyValidator : ILookupValidator
    {
        public bool IsViable(LookupContext context, DeclaredSymbol symbol)
        {
            return symbol is TypeSymbol;
        }

        public Diagnostic UpdateDiagnostic(LookupContext context, Diagnostic diagnostic)
        {
            return diagnostic;
        }

        public SingleLookupResult ValidateResult(LookupContext context, DeclaredSymbol resultSymbol, DeclaredSymbol unwrappedSymbol)
        {
            return LookupResult.Good(resultSymbol);
        }
    }
}
