
#nullable enable

namespace MetaDslx.Bootstrap.MetaCompiler3.Compiler.Syntax
{
    using __SyntaxToken = global::MetaDslx.CodeAnalysis.SyntaxToken;
    using __InternalSyntaxKind = global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.InternalSyntaxKind;

    public enum CompilerSyntaxKind
    {
        __FirstToken = TComma,
        __LastToken = TInvalidToken,
        __FirstFixedToken = TComma,
        __LastFixedToken = KFalse,
        __FirstRule = Main,
        __LastRule = QualifierIdentifierBlock,

        // Built-in:
        None = __InternalSyntaxKind.None,
        List = __InternalSyntaxKind.List,
        BadToken = __InternalSyntaxKind.BadToken,
        MissingToken = __InternalSyntaxKind.MissingToken,
        SkippedTokensTrivia = __InternalSyntaxKind.SkippedTokensTrivia,
        DisabledTextTrivia = __InternalSyntaxKind.DisabledTextTrivia,
        ConflictMarkerTrivia = __InternalSyntaxKind.ConflictMarkerTrivia,
        Eof = __InternalSyntaxKind.Eof,

        // Tokens:
        TComma,
        TUtf8Bom,
        KNamespace,
        TSemicolon,
        KMetamodel,
        KLanguage,
        TColon,
        TLParen,
        TRParen,
        THash,
        THashLBrace,
        TRBrace,
        KEof,
        KFragment,
        TTilde,
        TDot,
        TDotDot,
        TLBrace,
        TLBracket,
        TRBracket,
        TEq,
        TQuestionEq,
        TExclEq,
        TPlusEq,
        TQuestion,
        TAsterisk,
        TPlus,
        TQuestionQuestion,
        TAsteriskQuestion,
        TPlusQuestion,
        KObject,
        KBool,
        KChar,
        KString,
        KByte,
        KSbyte,
        KShort,
        KUshort,
        KInt,
        KUint,
        KLong,
        KUlong,
        KFloat,
        KDouble,
        KDecimal,
        KType,
        KSymbol,
        KVoid,
        KUsing,
        KReturns,
        TBar,
        KAlt,
        TEqGt,
        KToken,
        KHidden,
        KNull,
        KTrue,
        KFalse,
        TInteger,
        TDecimal,
        TIdentifier,
        TVerbatimIdentifier,
        TString,
        TWhitespace,
        TLineEnd,
        TSingleLineComment,
        TMultiLineComment,
        TInvalidToken,

        // Rules:
        Main,
        UsingMetaModel,
        UsingAlt2,
        LanguageDeclaration,
        Grammar,
        GrammarRuleAlt1,
        GrammarRuleAlt2,
        Rule,
        Alternative,
        Element,
        ElementValueAlt1,
        ElementValueAlt2,
        ElementValueAlt3,
        ElementValueAlt4,
        Block,
        BlockAlternative,
        RuleRefAlt1,
        RuleRefAlt2,
        RuleRefAlt3,
        Eof1,
        Fixed,
        LexerRuleAlt1,
        LexerRuleAlt2,
        Token,
        Fragment,
        LAlternative,
        LElement,
        LElementValueAlt1,
        LElementValueAlt2,
        LElementValueAlt3,
        LElementValueAlt4,
        LElementValueAlt5,
        LReference,
        LFixed,
        LWildCard,
        LRange,
        LBlock,
        ExpressionAlt1,
        ExpressionAlt2,
        SingleExpressionAlt1,
        SingleExpressionAlt2,
        ArrayExpression,
        ParserAnnotation,
        LexerAnnotation,
        AnnotationArgument,
        Assignment,
        Multiplicity,
        TypeReferenceIdentifierAlt1,
        TypeReferenceIdentifierAlt2,
        TypeReferenceAlt1,
        TypeReferenceAlt2,
        PrimitiveType,
        Name,
        Qualifier,
        Identifier,
        MainBlock1,
        MainBlock2,
        LanguageDeclarationBlock1,
        LanguageDeclarationBlock1baseLanguagesBlock,
        GrammarBlock1,
        RuleBlock1Alt1,
        RuleBlock1Alt2,
        RulealternativesBlock,
        AlternativeBlock1,
        AlternativeBlock1Block1Alt1,
        AlternativeBlock1Block1Alt2,
        AlternativeBlock2,
        ElementBlock1,
        BlockalternativesBlock,
        BlockAlternativeBlock1,
        RuleRefAlt3referencedTypesBlock,
        RuleRefAlt3Block1,
        TokenBlock1Alt1,
        TokenBlock1Alt2,
        TokenBlock1Alt1Block1,
        TokenalternativesBlock,
        FragmentalternativesBlock,
        LBlockalternativesBlock,
        SingleExpressionAlt1Block1Alt1,
        SingleExpressionAlt1Block1Alt2,
        SingleExpressionAlt1Block1Alt3,
        SingleExpressionAlt1Block1Alt4,
        SingleExpressionAlt1Block1Alt5,
        SingleExpressionAlt1Block1Alt6,
        SingleExpressionAlt1Block1Alt7,
        ArrayExpressionBlock1,
        ArrayExpressionBlock1itemsBlock,
        ParserAnnotationBlock1,
        ParserAnnotationBlock1argumentsBlock,
        LexerAnnotationBlock1,
        LexerAnnotationBlock1argumentsBlock,
        AnnotationArgumentBlock1,
        QualifierIdentifierBlock,
    }

    public static class CompilerSyntaxKindExtensions
    {
        public static CompilerSyntaxKind GetCompilerKind(this __SyntaxToken token)
        {
            return (CompilerSyntaxKind)token.RawKind;
        }
    }
}
