using Antlr4.Runtime;
using MetaDslx.CodeAnalysis.Syntax.InternalSyntax;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis.Antlr4
{
    internal static class Antlr4SyntaxKind
    {
        public static int ToAntlr4(int rawKind)
        {
            if (rawKind == (int)InternalSyntaxKind.Eof) return TokenConstants.EOF;
            else if (rawKind == (int)InternalSyntaxKind.BadToken) return TokenConstants.InvalidType;
            else if (rawKind > (int)InternalSyntaxKind.LastWellKnownSyntaxKind) return rawKind - (int)InternalSyntaxKind.LastWellKnownSyntaxKind;
            else throw new ArgumentOutOfRangeException(nameof(rawKind));
        }

        public static int FromAntlr4(int antlr4TokenKind)
        {
            if (antlr4TokenKind == TokenConstants.EOF) return (int)InternalSyntaxKind.Eof;
            else if (antlr4TokenKind == TokenConstants.InvalidType) return (int)InternalSyntaxKind.BadToken;
            else if (antlr4TokenKind >= 1) return antlr4TokenKind + (int)InternalSyntaxKind.LastWellKnownSyntaxKind;
            else throw new ArgumentOutOfRangeException(nameof(antlr4TokenKind));
        }
    }
}
