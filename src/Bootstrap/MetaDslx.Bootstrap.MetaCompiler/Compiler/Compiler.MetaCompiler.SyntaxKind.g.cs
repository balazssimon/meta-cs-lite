using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Syntax.InternalSyntax;

#nullable enable

namespace MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax
{
	public enum CompilerSyntaxKind
	{
		__FirstToken = TComma,
		__LastToken = TInvalidToken,
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
		KLanguage,
		KReturns,
		TColon,
		TBar,
		KBlock,
		TLBrace,
		TRBrace,
		TEqGt,
		KNull,
		KTrue,
		KFalse,
		TDot,
		TInteger,
		TDecimal,
		TIdentifier,
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
		LanguageDeclaration,
		ParserRule,
		BlockRule,
		ParserRuleAlternative,
		ParserRuleElement,
		IntExpression,
		StringExpression,
		ReferenceExpression,
		ExpressionTokens,
		Name,
		Qualifier,
		QualifierList,
		Identifier,
		UsingBlock1Alt1,
		UsingBlock1Alt2,
		ParserRuleBlock1,
		ParserRuleBlock2,
		BlockRuleBlock1,
		ParserRuleAlternativeBlock1,
		ParserRuleAlternativeBlock2,
		QualifierBlock1,
		QualifierListBlock1,
	}

    public static class CompilerSyntaxKindExtensions
    {
        public static CompilerSyntaxKind GetCompilerKind(this SyntaxToken token)
        {
            return (CompilerSyntaxKind)token.RawKind;
        }
    }
}
