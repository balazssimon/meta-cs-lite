using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Syntax.InternalSyntax;

#nullable enable

namespace MetaDslx.Bootstrap.MetaModel.Compiler.Syntax
{
	public enum MetaCoreSyntaxKind
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
		KEnum,
		TLBrace,
		TRBrace,
		KAbstract,
		KClass,
		THash,
		TColon,
		KContains,
		KDerived,
		KOpposite,
		KBool,
		KInt,
		KString,
		KType,
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
		MetaArrayType,
		TypeReferenceAlt3,
		TypeReferenceTokens,
		Name,
		Qualifier,
		QualifierList,
		Identifier,
		EnumLiteralsBlock1,
		BaseClassesBlock1,
		QualifierBlock1,
		QualifierListBlock1,
	}

    public static class MetaCoreSyntaxKindExtensions
    {
        public static MetaCoreSyntaxKind GetMetaCoreKind(this SyntaxToken token)
        {
            return (MetaCoreSyntaxKind)token.RawKind;
        }
    }
}
