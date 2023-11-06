using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Syntax.InternalSyntax;

#nullable enable

namespace MetaDslx.Languages.MetaModel.Compiler.Syntax
{
	public enum MetaSyntaxKind
	{
		__FirstToken = TComma,
		__LastToken = TMultiLineComment,
		__FirstFixedToken = TComma,
		__LastFixedToken = TDot,
		__FirstRule = Main,
		__LastRule = QualifierListBlock1,

		// Built-in:
		None = InternalSyntaxKind.None,
		List = InternalSyntaxKind.List,
		BadToken = InternalSyntaxKind.BadToken,
		MissingToken = InternalSyntaxKind.MissingToken,
		SkippedTokensTrivia = InternalSyntaxKind.SkippedTokensTrivia,
		DisabledTextTrivia = InternalSyntaxKind.DisabledTextTrivia,
		ConflictMarkerTrivia = InternalSyntaxKind.ConflictMarkerTrivia,
		Eof = InternalSyntaxKind.Eof,

		// Tokens:
		TComma,
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
		KContains,
		KDerived,
		KOpposite,
		TLParen,
		TRParen,
		KBool,
		KInt,
		KString,
		KType,
		KVoid,
		TLBracket,
		TRBracket,
		TDot,
		TInteger,
		TDecimal,
		TIdentifier,
		TString,
		TWhitespace,
		TLineEnd,
		TSingleLineComment,
		TMultiLineComment,

		// Rules:
		Main,
		Using,
		Declarations,
		MetaModel,
		MetaConstant,
		MetaEnumType,
		MetaClass,
		EnumBody,
		EnumLiterals,
		MetaEnumLiteral,
		ClassNameAlt1,
		ClassNameAlt2,
		BaseClasses,
		ClassBody,
		MetaProperty,
		PropertyNameAlt1,
		PropertyNameAlt2,
		PropertyOpposite,
		MetaOperation,
		ParameterList,
		MetaParameter,
		MetaArrayType,
		TypeReferenceAlt3,
		TypeReferenceTokens,
		Name,
		Qualifier,
		QualifierList,
		Identifier,
		EnumLiteralsBlock1,
		BaseClassesBlock1,
		ParameterListBlock1,
		QualifierBlock1,
		QualifierListBlock1,
	}

    public static class MetaSyntaxKindExtensions
    {
        public static MetaSyntaxKind GetMetaKind(this SyntaxToken token)
        {
            return (MetaSyntaxKind)token.RawKind;
        }
    }
}
