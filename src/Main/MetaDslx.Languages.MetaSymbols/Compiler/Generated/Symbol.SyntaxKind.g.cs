
#nullable enable

namespace MetaDslx.Languages.MetaSymbols.Compiler.Syntax
{
    using __SyntaxToken = global::MetaDslx.CodeAnalysis.SyntaxToken;
    using __InternalSyntaxKind = global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.InternalSyntaxKind;

    public enum SymbolSyntaxKind
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
        KUsing,
        KAbstract,
        KSymbol,
        TLParen,
        TRParen,
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
        KVoid,
        TColon,
        TLBrace,
        TRBrace,
        KWeak,
        KDerived,
        TEq,
        KPhase,
        TQuestion,
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
        Symbol,
        Property,
        Operation,
        Parameter,
        TypeReference,
        ArrayDimensions,
        SimpleTypeReferenceAlt1,
        SimpleTypeReferenceAlt2,
        PrimitiveType,
        ValueAlt1,
        ValueAlt2,
        ValueAlt3,
        ValueAlt4,
        ValueAlt5,
        ValueAlt6,
        Name,
        Qualifier,
        Identifier,
        TBoolean,
        MainBlock1,
        SymbolBlock1,
        SymbolBlock1baseTypesBlock,
        SymbolBlock2,
        SymbolBlock2Block1Alt1,
        SymbolBlock2Block1Alt2,
        PropertyBlock1Alt1,
        PropertyBlock1Alt2,
        PropertyBlock2,
        PropertyBlock3,
        OperationBlock1,
        OperationBlock1parametersBlock,
        TypeReferenceBlock1,
        ArrayDimensionsBlock1,
        QualifierIdentifierBlock,
    }

    public static class SymbolSyntaxKindExtensions
    {
        public static SymbolSyntaxKind GetSymbolKind(this __SyntaxToken token)
        {
            return (SymbolSyntaxKind)token.RawKind;
        }
    }
}
