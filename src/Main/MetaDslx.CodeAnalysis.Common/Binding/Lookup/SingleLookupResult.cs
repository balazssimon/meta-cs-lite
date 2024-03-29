﻿using MetaDslx.CodeAnalysis.Symbols;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis.Binding
{
    /// <summary>
    /// Represents a result of lookup operation over a 0 or 1 symbol (as opposed to a scope). The
    /// typical use is to represent that a particular symbol is good/bad/unavailable.
    /// 
    /// For more explanation of Kind, Symbol, Error - see LookupResult.
    /// </summary>
    public struct SingleLookupResult
    {
        // the kind of result.
        public readonly LookupResultKind Kind;

        // the symbol or null.
        public readonly DeclarationSymbol Symbol;

        // the error of the result, if it is NonViable or Inaccessible
        public readonly DiagnosticInfo Error;

        public SingleLookupResult(LookupResultKind kind, DeclarationSymbol symbol, DiagnosticInfo error)
        {
            this.Kind = kind;
            this.Symbol = symbol;
            this.Error = error;
        }
    }
}
