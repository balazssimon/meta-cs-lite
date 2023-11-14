using System;

#nullable enable

namespace MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax
{
    using MetaDslx.CodeAnalysis.Syntax.InternalSyntax;

	internal class CompilerInternalSyntaxVisitor : InternalSyntaxVisitor
	{
		public virtual void VisitSkippedTokensTrivia(GreenSkippedTokensTriviaSyntax node) => this.DefaultVisit(node);
		public virtual void VisitMainGreen(MainGreen node) => this.DefaultVisit(node);
		public virtual void VisitUsingGreen(UsingGreen node) => this.DefaultVisit(node);
		public virtual void VisitDeclarationsGreen(DeclarationsGreen node) => this.DefaultVisit(node);
		public virtual void VisitLanguageDeclarationGreen(LanguageDeclarationGreen node) => this.DefaultVisit(node);
		public virtual void VisitGrammarGreen(GrammarGreen node) => this.DefaultVisit(node);
		public virtual void VisitParserRuleGreen(ParserRuleGreen node) => this.DefaultVisit(node);
		public virtual void VisitLexerRuleGreen(LexerRuleGreen node) => this.DefaultVisit(node);
		public virtual void VisitPAlternativeGreen(PAlternativeGreen node) => this.DefaultVisit(node);
		public virtual void VisitPElementGreen(PElementGreen node) => this.DefaultVisit(node);
		public virtual void VisitPReferenceAlt1Green(PReferenceAlt1Green node) => this.DefaultVisit(node);
		public virtual void VisitPReferenceAlt2Green(PReferenceAlt2Green node) => this.DefaultVisit(node);
		public virtual void VisitPReferenceAlt3Green(PReferenceAlt3Green node) => this.DefaultVisit(node);
		public virtual void VisitPEofGreen(PEofGreen node) => this.DefaultVisit(node);
		public virtual void VisitPKeywordGreen(PKeywordGreen node) => this.DefaultVisit(node);
		public virtual void VisitPBlockGreen(PBlockGreen node) => this.DefaultVisit(node);
		public virtual void VisitLAlternativeGreen(LAlternativeGreen node) => this.DefaultVisit(node);
		public virtual void VisitLElementGreen(LElementGreen node) => this.DefaultVisit(node);
		public virtual void VisitLReferenceGreen(LReferenceGreen node) => this.DefaultVisit(node);
		public virtual void VisitLFixedGreen(LFixedGreen node) => this.DefaultVisit(node);
		public virtual void VisitLWildCardGreen(LWildCardGreen node) => this.DefaultVisit(node);
		public virtual void VisitLRangeGreen(LRangeGreen node) => this.DefaultVisit(node);
		public virtual void VisitLBlockGreen(LBlockGreen node) => this.DefaultVisit(node);
		public virtual void VisitIntExpressionGreen(IntExpressionGreen node) => this.DefaultVisit(node);
		public virtual void VisitStringExpressionGreen(StringExpressionGreen node) => this.DefaultVisit(node);
		public virtual void VisitReferenceExpressionGreen(ReferenceExpressionGreen node) => this.DefaultVisit(node);
		public virtual void VisitExpressionTokensGreen(ExpressionTokensGreen node) => this.DefaultVisit(node);
		public virtual void VisitAnnotationGreen(AnnotationGreen node) => this.DefaultVisit(node);
		public virtual void VisitAnnotationArgumentsGreen(AnnotationArgumentsGreen node) => this.DefaultVisit(node);
		public virtual void VisitAnnotationArgumentGreen(AnnotationArgumentGreen node) => this.DefaultVisit(node);
		public virtual void VisitNameGreen(NameGreen node) => this.DefaultVisit(node);
		public virtual void VisitQualifierGreen(QualifierGreen node) => this.DefaultVisit(node);
		public virtual void VisitQualifierListGreen(QualifierListGreen node) => this.DefaultVisit(node);
		public virtual void VisitIdentifierGreen(IdentifierGreen node) => this.DefaultVisit(node);
		public virtual void VisitUsingBlock1Alt1Green(UsingBlock1Alt1Green node) => this.DefaultVisit(node);
		public virtual void VisitUsingBlock1Alt2Green(UsingBlock1Alt2Green node) => this.DefaultVisit(node);
		public virtual void VisitGrammarBlock1Green(GrammarBlock1Green node) => this.DefaultVisit(node);
		public virtual void VisitParserRuleBlock1Alt1Green(ParserRuleBlock1Alt1Green node) => this.DefaultVisit(node);
		public virtual void VisitParserRuleBlock1Alt2Green(ParserRuleBlock1Alt2Green node) => this.DefaultVisit(node);
		public virtual void VisitParserRuleBlock1Alt3Green(ParserRuleBlock1Alt3Green node) => this.DefaultVisit(node);
		public virtual void VisitParserRuleBlock2Green(ParserRuleBlock2Green node) => this.DefaultVisit(node);
		public virtual void VisitPAlternativeBlock1Green(PAlternativeBlock1Green node) => this.DefaultVisit(node);
		public virtual void VisitPAlternativeBlock2Green(PAlternativeBlock2Green node) => this.DefaultVisit(node);
		public virtual void VisitPElementBlock1Green(PElementBlock1Green node) => this.DefaultVisit(node);
		public virtual void VisitPReferenceAlt3Block1Green(PReferenceAlt3Block1Green node) => this.DefaultVisit(node);
		public virtual void VisitPBlockBlock1Green(PBlockBlock1Green node) => this.DefaultVisit(node);
		public virtual void VisitLexerRuleBlock1Alt1Green(LexerRuleBlock1Alt1Green node) => this.DefaultVisit(node);
		public virtual void VisitLexerRuleBlock1Alt2Green(LexerRuleBlock1Alt2Green node) => this.DefaultVisit(node);
		public virtual void VisitLexerRuleBlock1Alt3Green(LexerRuleBlock1Alt3Green node) => this.DefaultVisit(node);
		public virtual void VisitLexerRuleBlock2Green(LexerRuleBlock2Green node) => this.DefaultVisit(node);
		public virtual void VisitLBlockBlock1Green(LBlockBlock1Green node) => this.DefaultVisit(node);
		public virtual void VisitAnnotationArgumentsBlock1Green(AnnotationArgumentsBlock1Green node) => this.DefaultVisit(node);
		public virtual void VisitAnnotationArgumentBlock1Green(AnnotationArgumentBlock1Green node) => this.DefaultVisit(node);
		public virtual void VisitQualifierBlock1Green(QualifierBlock1Green node) => this.DefaultVisit(node);
		public virtual void VisitQualifierListBlock1Green(QualifierListBlock1Green node) => this.DefaultVisit(node);
		public virtual void VisitLexerRuleBlock1Alt1Block1Green(LexerRuleBlock1Alt1Block1Green node) => this.DefaultVisit(node);
	}

	internal class CompilerInternalSyntaxVisitor<TResult> : InternalSyntaxVisitor<TResult>
	{
		public virtual TResult VisitSkippedTokensTrivia(GreenSkippedTokensTriviaSyntax node) => this.DefaultVisit(node);
		public virtual TResult VisitMainGreen(MainGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitUsingGreen(UsingGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitDeclarationsGreen(DeclarationsGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitLanguageDeclarationGreen(LanguageDeclarationGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitGrammarGreen(GrammarGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitParserRuleGreen(ParserRuleGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitLexerRuleGreen(LexerRuleGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitPAlternativeGreen(PAlternativeGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitPElementGreen(PElementGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitPReferenceAlt1Green(PReferenceAlt1Green node) => this.DefaultVisit(node);
		public virtual TResult VisitPReferenceAlt2Green(PReferenceAlt2Green node) => this.DefaultVisit(node);
		public virtual TResult VisitPReferenceAlt3Green(PReferenceAlt3Green node) => this.DefaultVisit(node);
		public virtual TResult VisitPEofGreen(PEofGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitPKeywordGreen(PKeywordGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitPBlockGreen(PBlockGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitLAlternativeGreen(LAlternativeGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitLElementGreen(LElementGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitLReferenceGreen(LReferenceGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitLFixedGreen(LFixedGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitLWildCardGreen(LWildCardGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitLRangeGreen(LRangeGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitLBlockGreen(LBlockGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitIntExpressionGreen(IntExpressionGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitStringExpressionGreen(StringExpressionGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitReferenceExpressionGreen(ReferenceExpressionGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitExpressionTokensGreen(ExpressionTokensGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitAnnotationGreen(AnnotationGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitAnnotationArgumentsGreen(AnnotationArgumentsGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitAnnotationArgumentGreen(AnnotationArgumentGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitNameGreen(NameGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitQualifierGreen(QualifierGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitQualifierListGreen(QualifierListGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitIdentifierGreen(IdentifierGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitUsingBlock1Alt1Green(UsingBlock1Alt1Green node) => this.DefaultVisit(node);
		public virtual TResult VisitUsingBlock1Alt2Green(UsingBlock1Alt2Green node) => this.DefaultVisit(node);
		public virtual TResult VisitGrammarBlock1Green(GrammarBlock1Green node) => this.DefaultVisit(node);
		public virtual TResult VisitParserRuleBlock1Alt1Green(ParserRuleBlock1Alt1Green node) => this.DefaultVisit(node);
		public virtual TResult VisitParserRuleBlock1Alt2Green(ParserRuleBlock1Alt2Green node) => this.DefaultVisit(node);
		public virtual TResult VisitParserRuleBlock1Alt3Green(ParserRuleBlock1Alt3Green node) => this.DefaultVisit(node);
		public virtual TResult VisitParserRuleBlock2Green(ParserRuleBlock2Green node) => this.DefaultVisit(node);
		public virtual TResult VisitPAlternativeBlock1Green(PAlternativeBlock1Green node) => this.DefaultVisit(node);
		public virtual TResult VisitPAlternativeBlock2Green(PAlternativeBlock2Green node) => this.DefaultVisit(node);
		public virtual TResult VisitPElementBlock1Green(PElementBlock1Green node) => this.DefaultVisit(node);
		public virtual TResult VisitPReferenceAlt3Block1Green(PReferenceAlt3Block1Green node) => this.DefaultVisit(node);
		public virtual TResult VisitPBlockBlock1Green(PBlockBlock1Green node) => this.DefaultVisit(node);
		public virtual TResult VisitLexerRuleBlock1Alt1Green(LexerRuleBlock1Alt1Green node) => this.DefaultVisit(node);
		public virtual TResult VisitLexerRuleBlock1Alt2Green(LexerRuleBlock1Alt2Green node) => this.DefaultVisit(node);
		public virtual TResult VisitLexerRuleBlock1Alt3Green(LexerRuleBlock1Alt3Green node) => this.DefaultVisit(node);
		public virtual TResult VisitLexerRuleBlock2Green(LexerRuleBlock2Green node) => this.DefaultVisit(node);
		public virtual TResult VisitLBlockBlock1Green(LBlockBlock1Green node) => this.DefaultVisit(node);
		public virtual TResult VisitAnnotationArgumentsBlock1Green(AnnotationArgumentsBlock1Green node) => this.DefaultVisit(node);
		public virtual TResult VisitAnnotationArgumentBlock1Green(AnnotationArgumentBlock1Green node) => this.DefaultVisit(node);
		public virtual TResult VisitQualifierBlock1Green(QualifierBlock1Green node) => this.DefaultVisit(node);
		public virtual TResult VisitQualifierListBlock1Green(QualifierListBlock1Green node) => this.DefaultVisit(node);
		public virtual TResult VisitLexerRuleBlock1Alt1Block1Green(LexerRuleBlock1Alt1Block1Green node) => this.DefaultVisit(node);
	}
}
