using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis.Syntax.InternalSyntax
{
    public enum InternalSyntaxKind
    {
        None,
        List,
        BadToken,
        MissingToken,
        SkippedTokensTrivia,
        DisabledTextTrivia,
        ConflictMarkerTrivia,
        Eof
    }
}
