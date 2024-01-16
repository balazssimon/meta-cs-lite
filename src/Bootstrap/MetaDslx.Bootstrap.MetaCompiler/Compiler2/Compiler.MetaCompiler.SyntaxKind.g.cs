
#nullable enable

namespace MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax
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
		__LastRule = SimpleQualifierSimpleIdentifierBlock,
		

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
		
		KSymbols,
		
		KLanguage,
		
		TColon,
		
		KBlock,
		
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
		
		TPrimitiveType,
		
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
            
		
            
		UsingAlt1,
            
		UsingMetaModel,
            
		UsingSymbols,
            
		
            
		Declarations,
            
		
            
		LanguageDeclaration,
            
		
            
		Grammar,
            
		
            
		GrammarRuleAlt1,
            
		Block,
            
		Token,
            
		Fragment,
            
		
            
		Rule,
            
		
            
		Alternative,
            
		
            
		Element,
            
		
            
		ElementValueTokens,
            
		BlockInline,
            
		RuleRefAlt1,
            
		RuleRefAlt2,
            
		RuleRefAlt3,
            
		
            
		LAlternative,
            
		
            
		LElement,
            
		
            
		LElementValueTokens,
            
		LBlock,
            
		LRange,
            
		LReference,
            
		
            
		ExpressionAlt1,
            
		ArrayExpression,
            
		
            
		SingleExpression,
            
		
            
		ParserAnnotation,
            
		
            
		LexerAnnotation,
            
		
            
		AnnotationArguments,
            
		
            
		AnnotationArgument,
            
		
            
		ReturnTypeIdentifierAlt1,
            
		ReturnTypeIdentifierAlt2,
            
		
            
		ReturnTypeQualifierAlt1,
            
		ReturnTypeQualifierAlt2,
            
		
            
		Name,
            
		
            
		Qualifier,
            
		
            
		IdentifierTokens,
            
		
            
		SimpleIdentifier,
            
		
            
		RuleBlock1Alt1,
            
		RuleBlock1Alt2,
            
		
            
		RuleAlternativesBlock,
            
		
            
		BlockBlock1,
            
		
            
		BlockAlternativesBlock,
            
		
            
		BlockInlineAlternativesBlock,
            
		
            
		AlternativeBlock1,
            
		
            
		AlternativeBlock1Block1,
            
		
            
		AlternativeBlock2,
            
		
            
		ElementBlock1,
            
		
            
		RuleRefAlt3ReferencedTypesBlock,
            
		
            
		TokenBlock1Alt1,
            
		TokenBlock1Alt2,
            
		
            
		TokenBlock1Alt1Block1,
            
		
            
		TokenAlternativesBlock,
            
		
            
		FragmentAlternativesBlock,
            
		
            
		LBlockAlternativesBlock,
            
		
            
		Tokens,
            
		SimpleQualifier,
            
		
            
		ArrayExpressionItemsBlock,
            
		
            
		AnnotationArgumentsArgumentsBlock,
            
		
            
		AnnotationArgumentBlock1,
            
		
            
		QualifierIdentifierBlock,
            
		
            
		SimpleQualifierSimpleIdentifierBlock,
            
		
	}

    public static class CompilerSyntaxKindExtensions
    {
        public static CompilerSyntaxKind GetCompilerKind(this __SyntaxToken token)
        {
            return (CompilerSyntaxKind)token.RawKind;
        }
    }
}