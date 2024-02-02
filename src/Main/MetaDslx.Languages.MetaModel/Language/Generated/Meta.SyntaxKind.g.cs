
#nullable enable

namespace MetaDslx.Languages.MetaModel.Compiler.Syntax
{
    using __SyntaxToken = global::MetaDslx.CodeAnalysis.SyntaxToken;
    using __InternalSyntaxKind = global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.InternalSyntaxKind;

    public enum MetaSyntaxKind
    {
        __FirstToken = TComma,
        __LastToken = TInvalidToken,
        __FirstFixedToken = TComma,
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
        TComma,
        TUtf8Bom,
        KNamespace,
        TSemicolon,
        KUsing,
        KMetamodel,
        KConst,
        KEnum,
        TLBrace,
        TRBrace,
        KAbstract,
        KClass,
        TLParen,
        TRParen,
        TLBracket,
        TRBracket,
        TQuestion,
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
        TDollar,
        TColon,
        KContains,
        KDerived,
        KOpposite,
        KSubsets,
        KRedefines,
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
        MetaModel,
        MetaDeclarationAlt1,
        MetaDeclarationAlt2,
        MetaDeclarationAlt3,
        MetaConstant,
        MetaEnum,
        MetaEnumLiteral,
        MetaClass,
        MetaProperty,
        MetaOperation,
        MetaParameter,
        SimpleTypeReference,
        MetaArrayType,
        MetaNullableType,
        TypeReferenceAlt1,
        TypeReferenceAlt2,
        PrimitiveType,
        Name,
        Qualifier,
        Identifier,
        MetaEnumliteralsBlock,
        MetaClassBlock1Alt1,
        MetaClassBlock1Alt2,
        MetaClassBlock2,
        MetaClassBlock2baseTypesBlock,
        MetaClassBlock3,
        MetaClassBlock3Block1Alt1,
        MetaClassBlock3Block1Alt2,
        MetaPropertyBlock1Alt1,
        MetaPropertyBlock1Alt2,
        MetaPropertyBlock2Alt1,
        MetaPropertyBlock2Alt2,
        MetaPropertyBlock3Alt1,
        MetaPropertyBlock3Alt2,
        MetaPropertyBlock3Alt3,
        MetaPropertyBlock3Alt1oppositePropertiesBlock,
        MetaPropertyBlock3Alt2subsettedPropertiesBlock,
        MetaPropertyBlock3Alt3redefinedPropertiesBlock,
        MetaOperationBlock1,
        MetaOperationBlock1parametersBlock,
        QualifierIdentifierBlock,
    }

    public static class MetaSyntaxKindExtensions
    {
        public static MetaSyntaxKind GetMetaKind(this __SyntaxToken token)
        {
            return (MetaSyntaxKind)token.RawKind;
        }
    }
}
