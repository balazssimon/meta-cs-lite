using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis.Annotations
{
    public enum TokenKind
    {
        None,
        Whitespace,
        EndOfLine,
        Comment,
        Keyword,
        Identifier,
        String,
        Number,
        Separator,
        Other
    }
}
