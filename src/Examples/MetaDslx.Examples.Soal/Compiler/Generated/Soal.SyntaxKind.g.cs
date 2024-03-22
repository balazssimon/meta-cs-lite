
namespace MetaDslx.Examples.Soal.Compiler.Syntax
{
    using __SyntaxToken = global::MetaDslx.CodeAnalysis.SyntaxToken;
    using __InternalSyntaxKind = global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.InternalSyntaxKind;

    public enum SoalSyntaxKind
    {
        __FirstToken = KNull,
        __LastToken = TInvalidToken,
        __FirstFixedToken = KNull,
        __LastFixedToken = TDot,
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
        KNull,
        KTrue,
        KFalse,
        TComma,
        TUtf8Bom,
        KNamespace,
        TSemicolon,
        KUsing,
        KEnum,
        TLBrace,
        TRBrace,
        KStruct,
        KInterface,
        KReadonly,
        KResource,
        KAsync,
        TLParen,
        TRParen,
        KVoid,
        KService,
        TColon,
        KBinding,
        KREST,
        KSOAP,
        TQuestion,
        KObject,
        KBinary,
        KBool,
        KString,
        KInt,
        KLong,
        KFloat,
        KDouble,
        KDate,
        KTime,
        KDatetime,
        KDuration,
        KThrows,
        TLBracket,
        TRBracket,
        TDot,
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
        Using,
        DeclarationAlt1,
        DeclarationAlt2,
        DeclarationAlt3,
        DeclarationAlt4,
        EnumType,
        EnumLiteral,
        StructType,
        Property,
        Interface,
        Resource,
        Operation,
        InputParameterList,
        OutputParameterListAlt1,
        OutputParameterListAlt2,
        OutputParameterListAlt3,
        Parameter,
        SingleReturnParameter,
        Service,
        BindingKind,
        TypeReference,
        SimpleTypeAlt1,
        SimpleTypeAlt2,
        SimpleTypeAlt3,
        SimpleTypeAlt4,
        SimpleTypeAlt5,
        SimpleTypeAlt6,
        SimpleTypeAlt7,
        SimpleTypeAlt8,
        SimpleTypeAlt9,
        SimpleTypeAlt10,
        SimpleTypeAlt11,
        SimpleTypeAlt12,
        SimpleTypeAlt13,
        Name,
        Qualifier,
        Identifier,
        MainBlock1,
        EnumTypeBlock1,
        EnumTypeBlock1literalsBlock,
        StructTypeBlock1,
        ResourceBlock1,
        ResourceBlock1exceptionsBlock,
        OperationBlock1,
        OperationBlock1exceptionsBlock,
        InputParameterListBlock1,
        InputParameterListBlock1parametersBlock,
        OutputParameterListAlt3parametersBlock,
        TypeReferenceBlock1,
        QualifierIdentifierBlock,
    }

    public static class SoalSyntaxKindExtensions
    {
        public static SoalSyntaxKind GetSoalKind(this __SyntaxToken token)
        {
            return (SoalSyntaxKind)token.RawKind;
        }
    }
}
