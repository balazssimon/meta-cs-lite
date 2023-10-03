using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis.Syntax
{
    public class TokenKind
    {
    }

    public class EndOfFileTokenKind : TokenKind
    {
    }

    public class HiddenTokenKind : TokenKind
    {
    }

    public class WhitespaceTokenKind : HiddenTokenKind
    {
    }

    public class EndOfLineTokenKind : HiddenTokenKind
    {
    }

    public class CommentTokenKind : HiddenTokenKind
    {
    }

    public class SingleLineCommentTokenKind : CommentTokenKind
    {
    }

    public class MultiLineCommentTokenKind : CommentTokenKind
    {
    }

    public class IdentifierTokenKind : TokenKind
    {
    }

    public class KeywordTokenKind : TokenKind
    {
    }

    public class NumberTokenKind : TokenKind
    {
    }

    public class StringTokenKind : TokenKind
    {
    }

    public class CharacterTokenKind : TokenKind
    {
    }

    public class SeparatorTokenKind : TokenKind
    {
    }

    public class OtherTokenKind : TokenKind
    {
    }

}
