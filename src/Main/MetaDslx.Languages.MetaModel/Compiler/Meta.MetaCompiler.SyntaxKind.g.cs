
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
		__LastRule = QualifierQualifierBlock,

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
		TDollar,
		TColon,
		KOpposite,
		KSubsets,
		KRedefines,
		TLParen,
		TRParen,
		TLBracket,
		TRBracket,
		TQuestion,
		KBool,
		KInt,
		KString,
		KType,
		KSymbol,
		KObject,
		KVoid,
		KContains,
		KDerived,
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
		Declarations,
		MetaModel,
		MetaConstant,
		MetaEnum,
		MetaClass,
		EnumBody,
		MetaEnumLiteral,
		ClassNameAlt1,
		ClassNameAlt2,
		BaseClasses,
		ClassBody,
		ClassMemberAlt1,
		ClassMemberAlt2,
		MetaProperty,
		PropertyNameAlt1,
		PropertyNameAlt2,
		MetaOperation,
		MetaParameter,
		TypeReferenceTokens,
		SimpleTypeReferenceAlt2,
		MetaArrayType,
		MetaNullableType,
		Name,
		Qualifier,
		Identifier,
		EnumBodyEnumLiteralsBlock,
		BaseClassesBaseTypesBlock,
		PropertyOpposite,
		PropertySubsets,
		PropertyRedefines,
		PropertyOppositeOppositePropertiesBlock,
		PropertySubsetsSubsettedPropertiesBlock,
		PropertyRedefinesRedefinedPropertiesBlock,
		MetaOperationParameterListBlock,
		QualifierQualifierBlock,
}

    public static class MetaSyntaxKindExtensions
    {
        public static MetaSyntaxKind GetMetaKind(this __SyntaxToken token)
        {
            return (MetaSyntaxKind)token.RawKind;
        }
    }
}
