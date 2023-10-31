using Antlr4.Runtime;
using MetaDslx.CodeAnalysis.Syntax.InternalSyntax;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.Languages.MetaCompiler.Antlr
{
    public static class AntlrSyntaxKind
    {
        public static int ToAntlr(int rawKind)
        {
            if (rawKind == (int)InternalSyntaxKind.Eof) return TokenConstants.EOF;
            else if (rawKind == (int)InternalSyntaxKind.BadToken) return TokenConstants.InvalidType;
            else if (rawKind > (int)InternalSyntaxKind.LastWellKnownSyntaxKind) return rawKind - (int)InternalSyntaxKind.LastWellKnownSyntaxKind;
            else throw new ArgumentOutOfRangeException(nameof(rawKind));
        }

        public static int FromAntlr(int antlrTokenKind)
        {
            if (antlrTokenKind == TokenConstants.EOF) return (int)InternalSyntaxKind.Eof;
            else if (antlrTokenKind == TokenConstants.InvalidType) return (int)InternalSyntaxKind.BadToken;
            else if (antlrTokenKind >= 1) return antlrTokenKind + (int)InternalSyntaxKind.LastWellKnownSyntaxKind;
            else throw new ArgumentOutOfRangeException(nameof(antlrTokenKind));
        }
    }
}
