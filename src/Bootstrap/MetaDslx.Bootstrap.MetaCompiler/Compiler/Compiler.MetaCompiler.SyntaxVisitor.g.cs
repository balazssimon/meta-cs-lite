using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Syntax;
using MetaDslx.CodeAnalysis.Syntax.InternalSyntax;

#nullable enable

namespace MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax
{

	public interface ICompilerSyntaxVisitor
	{
	    void VisitSkippedTokensTrivia(CompilerSkippedTokensTriviaSyntax node);
		void VisitMain(MainSyntax node);
		void VisitUsing(UsingSyntax node);
		void VisitDeclarations(DeclarationsSyntax node);
		void VisitLanguageDeclaration(LanguageDeclarationSyntax node);
		void VisitGrammar(GrammarSyntax node);
		void VisitParserRule(ParserRuleSyntax node);
		void VisitLexerRule(LexerRuleSyntax node);
		void VisitPAlternative(PAlternativeSyntax node);
		void VisitPElement(PElementSyntax node);
		void VisitPBlock(PBlockSyntax node);
		void VisitPEof(PEofSyntax node);
		void VisitPKeyword(PKeywordSyntax node);
		void VisitPReferenceAlt1(PReferenceAlt1Syntax node);
		void VisitPReferenceAlt2(PReferenceAlt2Syntax node);
		void VisitPReferenceAlt3(PReferenceAlt3Syntax node);
		void VisitLAlternative(LAlternativeSyntax node);
		void VisitLElement(LElementSyntax node);
		void VisitLBlock(LBlockSyntax node);
		void VisitLFixed(LFixedSyntax node);
		void VisitLWildCard(LWildCardSyntax node);
		void VisitLRange(LRangeSyntax node);
		void VisitLReference(LReferenceSyntax node);
		void VisitIntExpression(IntExpressionSyntax node);
		void VisitStringExpression(StringExpressionSyntax node);
		void VisitReferenceExpression(ReferenceExpressionSyntax node);
		void VisitArrayExpression(ArrayExpressionSyntax node);
		void VisitExpressionTokens(ExpressionTokensSyntax node);
		void VisitParserAnnotation(ParserAnnotationSyntax node);
		void VisitLexerAnnotation(LexerAnnotationSyntax node);
		void VisitAnnotationArguments(AnnotationArgumentsSyntax node);
		void VisitAnnotationArgument(AnnotationArgumentSyntax node);
		void VisitName(NameSyntax node);
		void VisitQualifier(QualifierSyntax node);
		void VisitQualifierList(QualifierListSyntax node);
		void VisitIdentifierAlt1(IdentifierAlt1Syntax node);
		void VisitIdentifierAlt2(IdentifierAlt2Syntax node);
		void VisitIdentifierAlt3(IdentifierAlt3Syntax node);
		void VisitGrammarBlock1(GrammarBlock1Syntax node);
		void VisitParserRuleBlock1Alt1(ParserRuleBlock1Alt1Syntax node);
		void VisitParserRuleBlock1Alt2(ParserRuleBlock1Alt2Syntax node);
		void VisitParserRuleBlock1Alt3(ParserRuleBlock1Alt3Syntax node);
		void VisitParserRuleBlock2(ParserRuleBlock2Syntax node);
		void VisitPAlternativeBlock1(PAlternativeBlock1Syntax node);
		void VisitPAlternativeBlock2(PAlternativeBlock2Syntax node);
		void VisitPElementBlock1(PElementBlock1Syntax node);
		void VisitPReferenceAlt3Block1(PReferenceAlt3Block1Syntax node);
		void VisitPBlockBlock1(PBlockBlock1Syntax node);
		void VisitLexerRuleBlock1Alt1(LexerRuleBlock1Alt1Syntax node);
		void VisitLexerRuleBlock1Alt2(LexerRuleBlock1Alt2Syntax node);
		void VisitLexerRuleBlock1Alt3(LexerRuleBlock1Alt3Syntax node);
		void VisitLexerRuleBlock2(LexerRuleBlock2Syntax node);
		void VisitLBlockBlock1(LBlockBlock1Syntax node);
		void VisitArrayExpressionBlock1(ArrayExpressionBlock1Syntax node);
		void VisitAnnotationArgumentsBlock1(AnnotationArgumentsBlock1Syntax node);
		void VisitAnnotationArgumentBlock1(AnnotationArgumentBlock1Syntax node);
		void VisitQualifierBlock1(QualifierBlock1Syntax node);
		void VisitQualifierListBlock1(QualifierListBlock1Syntax node);
		void VisitLexerRuleBlock1Alt1Block1(LexerRuleBlock1Alt1Block1Syntax node);
		void VisitArrayExpressionBlock1Block1(ArrayExpressionBlock1Block1Syntax node);
    }

	public class CompilerSyntaxVisitor : SyntaxVisitor, ICompilerSyntaxVisitor
	{
	    public virtual void VisitSkippedTokensTrivia(CompilerSkippedTokensTriviaSyntax node)
	    {
	        this.DefaultVisit(node);
	    }

		public virtual void VisitMain(MainSyntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitUsing(UsingSyntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitDeclarations(DeclarationsSyntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitLanguageDeclaration(LanguageDeclarationSyntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitGrammar(GrammarSyntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitParserRule(ParserRuleSyntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitLexerRule(LexerRuleSyntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitPAlternative(PAlternativeSyntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitPElement(PElementSyntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitPBlock(PBlockSyntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitPEof(PEofSyntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitPKeyword(PKeywordSyntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitPReferenceAlt1(PReferenceAlt1Syntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitPReferenceAlt2(PReferenceAlt2Syntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitPReferenceAlt3(PReferenceAlt3Syntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitLAlternative(LAlternativeSyntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitLElement(LElementSyntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitLBlock(LBlockSyntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitLFixed(LFixedSyntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitLWildCard(LWildCardSyntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitLRange(LRangeSyntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitLReference(LReferenceSyntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitIntExpression(IntExpressionSyntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitStringExpression(StringExpressionSyntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitReferenceExpression(ReferenceExpressionSyntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitArrayExpression(ArrayExpressionSyntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitExpressionTokens(ExpressionTokensSyntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitParserAnnotation(ParserAnnotationSyntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitLexerAnnotation(LexerAnnotationSyntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitAnnotationArguments(AnnotationArgumentsSyntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitAnnotationArgument(AnnotationArgumentSyntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitName(NameSyntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitQualifier(QualifierSyntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitQualifierList(QualifierListSyntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitIdentifierAlt1(IdentifierAlt1Syntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitIdentifierAlt2(IdentifierAlt2Syntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitIdentifierAlt3(IdentifierAlt3Syntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitGrammarBlock1(GrammarBlock1Syntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitParserRuleBlock1Alt1(ParserRuleBlock1Alt1Syntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitParserRuleBlock1Alt2(ParserRuleBlock1Alt2Syntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitParserRuleBlock1Alt3(ParserRuleBlock1Alt3Syntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitParserRuleBlock2(ParserRuleBlock2Syntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitPAlternativeBlock1(PAlternativeBlock1Syntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitPAlternativeBlock2(PAlternativeBlock2Syntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitPElementBlock1(PElementBlock1Syntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitPReferenceAlt3Block1(PReferenceAlt3Block1Syntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitPBlockBlock1(PBlockBlock1Syntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitLexerRuleBlock1Alt1(LexerRuleBlock1Alt1Syntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitLexerRuleBlock1Alt2(LexerRuleBlock1Alt2Syntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitLexerRuleBlock1Alt3(LexerRuleBlock1Alt3Syntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitLexerRuleBlock2(LexerRuleBlock2Syntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitLBlockBlock1(LBlockBlock1Syntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitArrayExpressionBlock1(ArrayExpressionBlock1Syntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitAnnotationArgumentsBlock1(AnnotationArgumentsBlock1Syntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitAnnotationArgumentBlock1(AnnotationArgumentBlock1Syntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitQualifierBlock1(QualifierBlock1Syntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitQualifierListBlock1(QualifierListBlock1Syntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitLexerRuleBlock1Alt1Block1(LexerRuleBlock1Alt1Block1Syntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitArrayExpressionBlock1Block1(ArrayExpressionBlock1Block1Syntax node)
		{
		    this.DefaultVisit(node);
		}
    }

	public interface ICompilerSyntaxVisitor<TResult> 
	{
	    TResult VisitSkippedTokensTrivia(CompilerSkippedTokensTriviaSyntax node);
		TResult VisitMain(MainSyntax node);
		TResult VisitUsing(UsingSyntax node);
		TResult VisitDeclarations(DeclarationsSyntax node);
		TResult VisitLanguageDeclaration(LanguageDeclarationSyntax node);
		TResult VisitGrammar(GrammarSyntax node);
		TResult VisitParserRule(ParserRuleSyntax node);
		TResult VisitLexerRule(LexerRuleSyntax node);
		TResult VisitPAlternative(PAlternativeSyntax node);
		TResult VisitPElement(PElementSyntax node);
		TResult VisitPBlock(PBlockSyntax node);
		TResult VisitPEof(PEofSyntax node);
		TResult VisitPKeyword(PKeywordSyntax node);
		TResult VisitPReferenceAlt1(PReferenceAlt1Syntax node);
		TResult VisitPReferenceAlt2(PReferenceAlt2Syntax node);
		TResult VisitPReferenceAlt3(PReferenceAlt3Syntax node);
		TResult VisitLAlternative(LAlternativeSyntax node);
		TResult VisitLElement(LElementSyntax node);
		TResult VisitLBlock(LBlockSyntax node);
		TResult VisitLFixed(LFixedSyntax node);
		TResult VisitLWildCard(LWildCardSyntax node);
		TResult VisitLRange(LRangeSyntax node);
		TResult VisitLReference(LReferenceSyntax node);
		TResult VisitIntExpression(IntExpressionSyntax node);
		TResult VisitStringExpression(StringExpressionSyntax node);
		TResult VisitReferenceExpression(ReferenceExpressionSyntax node);
		TResult VisitArrayExpression(ArrayExpressionSyntax node);
		TResult VisitExpressionTokens(ExpressionTokensSyntax node);
		TResult VisitParserAnnotation(ParserAnnotationSyntax node);
		TResult VisitLexerAnnotation(LexerAnnotationSyntax node);
		TResult VisitAnnotationArguments(AnnotationArgumentsSyntax node);
		TResult VisitAnnotationArgument(AnnotationArgumentSyntax node);
		TResult VisitName(NameSyntax node);
		TResult VisitQualifier(QualifierSyntax node);
		TResult VisitQualifierList(QualifierListSyntax node);
		TResult VisitIdentifierAlt1(IdentifierAlt1Syntax node);
		TResult VisitIdentifierAlt2(IdentifierAlt2Syntax node);
		TResult VisitIdentifierAlt3(IdentifierAlt3Syntax node);
		TResult VisitGrammarBlock1(GrammarBlock1Syntax node);
		TResult VisitParserRuleBlock1Alt1(ParserRuleBlock1Alt1Syntax node);
		TResult VisitParserRuleBlock1Alt2(ParserRuleBlock1Alt2Syntax node);
		TResult VisitParserRuleBlock1Alt3(ParserRuleBlock1Alt3Syntax node);
		TResult VisitParserRuleBlock2(ParserRuleBlock2Syntax node);
		TResult VisitPAlternativeBlock1(PAlternativeBlock1Syntax node);
		TResult VisitPAlternativeBlock2(PAlternativeBlock2Syntax node);
		TResult VisitPElementBlock1(PElementBlock1Syntax node);
		TResult VisitPReferenceAlt3Block1(PReferenceAlt3Block1Syntax node);
		TResult VisitPBlockBlock1(PBlockBlock1Syntax node);
		TResult VisitLexerRuleBlock1Alt1(LexerRuleBlock1Alt1Syntax node);
		TResult VisitLexerRuleBlock1Alt2(LexerRuleBlock1Alt2Syntax node);
		TResult VisitLexerRuleBlock1Alt3(LexerRuleBlock1Alt3Syntax node);
		TResult VisitLexerRuleBlock2(LexerRuleBlock2Syntax node);
		TResult VisitLBlockBlock1(LBlockBlock1Syntax node);
		TResult VisitArrayExpressionBlock1(ArrayExpressionBlock1Syntax node);
		TResult VisitAnnotationArgumentsBlock1(AnnotationArgumentsBlock1Syntax node);
		TResult VisitAnnotationArgumentBlock1(AnnotationArgumentBlock1Syntax node);
		TResult VisitQualifierBlock1(QualifierBlock1Syntax node);
		TResult VisitQualifierListBlock1(QualifierListBlock1Syntax node);
		TResult VisitLexerRuleBlock1Alt1Block1(LexerRuleBlock1Alt1Block1Syntax node);
		TResult VisitArrayExpressionBlock1Block1(ArrayExpressionBlock1Block1Syntax node);
    }

	public class CompilerSyntaxVisitor<TResult> : SyntaxVisitor<TResult>, ICompilerSyntaxVisitor<TResult>
	{
	    public virtual TResult VisitSkippedTokensTrivia(CompilerSkippedTokensTriviaSyntax node)
	    {
	        return this.DefaultVisit(node);
	    }

		public virtual TResult VisitMain(MainSyntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitUsing(UsingSyntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitDeclarations(DeclarationsSyntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitLanguageDeclaration(LanguageDeclarationSyntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitGrammar(GrammarSyntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitParserRule(ParserRuleSyntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitLexerRule(LexerRuleSyntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitPAlternative(PAlternativeSyntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitPElement(PElementSyntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitPBlock(PBlockSyntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitPEof(PEofSyntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitPKeyword(PKeywordSyntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitPReferenceAlt1(PReferenceAlt1Syntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitPReferenceAlt2(PReferenceAlt2Syntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitPReferenceAlt3(PReferenceAlt3Syntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitLAlternative(LAlternativeSyntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitLElement(LElementSyntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitLBlock(LBlockSyntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitLFixed(LFixedSyntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitLWildCard(LWildCardSyntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitLRange(LRangeSyntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitLReference(LReferenceSyntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitIntExpression(IntExpressionSyntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitStringExpression(StringExpressionSyntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitReferenceExpression(ReferenceExpressionSyntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitArrayExpression(ArrayExpressionSyntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitExpressionTokens(ExpressionTokensSyntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitParserAnnotation(ParserAnnotationSyntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitLexerAnnotation(LexerAnnotationSyntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitAnnotationArguments(AnnotationArgumentsSyntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitAnnotationArgument(AnnotationArgumentSyntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitName(NameSyntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitQualifier(QualifierSyntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitQualifierList(QualifierListSyntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitIdentifierAlt1(IdentifierAlt1Syntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitIdentifierAlt2(IdentifierAlt2Syntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitIdentifierAlt3(IdentifierAlt3Syntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitGrammarBlock1(GrammarBlock1Syntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitParserRuleBlock1Alt1(ParserRuleBlock1Alt1Syntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitParserRuleBlock1Alt2(ParserRuleBlock1Alt2Syntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitParserRuleBlock1Alt3(ParserRuleBlock1Alt3Syntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitParserRuleBlock2(ParserRuleBlock2Syntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitPAlternativeBlock1(PAlternativeBlock1Syntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitPAlternativeBlock2(PAlternativeBlock2Syntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitPElementBlock1(PElementBlock1Syntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitPReferenceAlt3Block1(PReferenceAlt3Block1Syntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitPBlockBlock1(PBlockBlock1Syntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitLexerRuleBlock1Alt1(LexerRuleBlock1Alt1Syntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitLexerRuleBlock1Alt2(LexerRuleBlock1Alt2Syntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitLexerRuleBlock1Alt3(LexerRuleBlock1Alt3Syntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitLexerRuleBlock2(LexerRuleBlock2Syntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitLBlockBlock1(LBlockBlock1Syntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitArrayExpressionBlock1(ArrayExpressionBlock1Syntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitAnnotationArgumentsBlock1(AnnotationArgumentsBlock1Syntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitAnnotationArgumentBlock1(AnnotationArgumentBlock1Syntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitQualifierBlock1(QualifierBlock1Syntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitQualifierListBlock1(QualifierListBlock1Syntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitLexerRuleBlock1Alt1Block1(LexerRuleBlock1Alt1Block1Syntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitArrayExpressionBlock1Block1(ArrayExpressionBlock1Block1Syntax node)
		{
		    return this.DefaultVisit(node);
		}
    }

	public interface ICompilerSyntaxVisitor<TArg, TResult> 
	{
	    TResult VisitSkippedTokensTrivia(CompilerSkippedTokensTriviaSyntax node, TArg argument);
		TResult VisitMain(MainSyntax node, TArg argument);
		TResult VisitUsing(UsingSyntax node, TArg argument);
		TResult VisitDeclarations(DeclarationsSyntax node, TArg argument);
		TResult VisitLanguageDeclaration(LanguageDeclarationSyntax node, TArg argument);
		TResult VisitGrammar(GrammarSyntax node, TArg argument);
		TResult VisitParserRule(ParserRuleSyntax node, TArg argument);
		TResult VisitLexerRule(LexerRuleSyntax node, TArg argument);
		TResult VisitPAlternative(PAlternativeSyntax node, TArg argument);
		TResult VisitPElement(PElementSyntax node, TArg argument);
		TResult VisitPBlock(PBlockSyntax node, TArg argument);
		TResult VisitPEof(PEofSyntax node, TArg argument);
		TResult VisitPKeyword(PKeywordSyntax node, TArg argument);
		TResult VisitPReferenceAlt1(PReferenceAlt1Syntax node, TArg argument);
		TResult VisitPReferenceAlt2(PReferenceAlt2Syntax node, TArg argument);
		TResult VisitPReferenceAlt3(PReferenceAlt3Syntax node, TArg argument);
		TResult VisitLAlternative(LAlternativeSyntax node, TArg argument);
		TResult VisitLElement(LElementSyntax node, TArg argument);
		TResult VisitLBlock(LBlockSyntax node, TArg argument);
		TResult VisitLFixed(LFixedSyntax node, TArg argument);
		TResult VisitLWildCard(LWildCardSyntax node, TArg argument);
		TResult VisitLRange(LRangeSyntax node, TArg argument);
		TResult VisitLReference(LReferenceSyntax node, TArg argument);
		TResult VisitIntExpression(IntExpressionSyntax node, TArg argument);
		TResult VisitStringExpression(StringExpressionSyntax node, TArg argument);
		TResult VisitReferenceExpression(ReferenceExpressionSyntax node, TArg argument);
		TResult VisitArrayExpression(ArrayExpressionSyntax node, TArg argument);
		TResult VisitExpressionTokens(ExpressionTokensSyntax node, TArg argument);
		TResult VisitParserAnnotation(ParserAnnotationSyntax node, TArg argument);
		TResult VisitLexerAnnotation(LexerAnnotationSyntax node, TArg argument);
		TResult VisitAnnotationArguments(AnnotationArgumentsSyntax node, TArg argument);
		TResult VisitAnnotationArgument(AnnotationArgumentSyntax node, TArg argument);
		TResult VisitName(NameSyntax node, TArg argument);
		TResult VisitQualifier(QualifierSyntax node, TArg argument);
		TResult VisitQualifierList(QualifierListSyntax node, TArg argument);
		TResult VisitIdentifierAlt1(IdentifierAlt1Syntax node, TArg argument);
		TResult VisitIdentifierAlt2(IdentifierAlt2Syntax node, TArg argument);
		TResult VisitIdentifierAlt3(IdentifierAlt3Syntax node, TArg argument);
		TResult VisitGrammarBlock1(GrammarBlock1Syntax node, TArg argument);
		TResult VisitParserRuleBlock1Alt1(ParserRuleBlock1Alt1Syntax node, TArg argument);
		TResult VisitParserRuleBlock1Alt2(ParserRuleBlock1Alt2Syntax node, TArg argument);
		TResult VisitParserRuleBlock1Alt3(ParserRuleBlock1Alt3Syntax node, TArg argument);
		TResult VisitParserRuleBlock2(ParserRuleBlock2Syntax node, TArg argument);
		TResult VisitPAlternativeBlock1(PAlternativeBlock1Syntax node, TArg argument);
		TResult VisitPAlternativeBlock2(PAlternativeBlock2Syntax node, TArg argument);
		TResult VisitPElementBlock1(PElementBlock1Syntax node, TArg argument);
		TResult VisitPReferenceAlt3Block1(PReferenceAlt3Block1Syntax node, TArg argument);
		TResult VisitPBlockBlock1(PBlockBlock1Syntax node, TArg argument);
		TResult VisitLexerRuleBlock1Alt1(LexerRuleBlock1Alt1Syntax node, TArg argument);
		TResult VisitLexerRuleBlock1Alt2(LexerRuleBlock1Alt2Syntax node, TArg argument);
		TResult VisitLexerRuleBlock1Alt3(LexerRuleBlock1Alt3Syntax node, TArg argument);
		TResult VisitLexerRuleBlock2(LexerRuleBlock2Syntax node, TArg argument);
		TResult VisitLBlockBlock1(LBlockBlock1Syntax node, TArg argument);
		TResult VisitArrayExpressionBlock1(ArrayExpressionBlock1Syntax node, TArg argument);
		TResult VisitAnnotationArgumentsBlock1(AnnotationArgumentsBlock1Syntax node, TArg argument);
		TResult VisitAnnotationArgumentBlock1(AnnotationArgumentBlock1Syntax node, TArg argument);
		TResult VisitQualifierBlock1(QualifierBlock1Syntax node, TArg argument);
		TResult VisitQualifierListBlock1(QualifierListBlock1Syntax node, TArg argument);
		TResult VisitLexerRuleBlock1Alt1Block1(LexerRuleBlock1Alt1Block1Syntax node, TArg argument);
		TResult VisitArrayExpressionBlock1Block1(ArrayExpressionBlock1Block1Syntax node, TArg argument);
    }

	public class CompilerSyntaxVisitor<TArg, TResult> : SyntaxVisitor<TArg, TResult>, ICompilerSyntaxVisitor<TArg, TResult>
	{
	    public virtual TResult VisitSkippedTokensTrivia(CompilerSkippedTokensTriviaSyntax node, TArg argument)
	    {
	        return this.DefaultVisit(node, argument);
	    }

		public virtual TResult VisitMain(MainSyntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitUsing(UsingSyntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitDeclarations(DeclarationsSyntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitLanguageDeclaration(LanguageDeclarationSyntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitGrammar(GrammarSyntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitParserRule(ParserRuleSyntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitLexerRule(LexerRuleSyntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitPAlternative(PAlternativeSyntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitPElement(PElementSyntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitPBlock(PBlockSyntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitPEof(PEofSyntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitPKeyword(PKeywordSyntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitPReferenceAlt1(PReferenceAlt1Syntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitPReferenceAlt2(PReferenceAlt2Syntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitPReferenceAlt3(PReferenceAlt3Syntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitLAlternative(LAlternativeSyntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitLElement(LElementSyntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitLBlock(LBlockSyntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitLFixed(LFixedSyntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitLWildCard(LWildCardSyntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitLRange(LRangeSyntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitLReference(LReferenceSyntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitIntExpression(IntExpressionSyntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitStringExpression(StringExpressionSyntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitReferenceExpression(ReferenceExpressionSyntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitArrayExpression(ArrayExpressionSyntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitExpressionTokens(ExpressionTokensSyntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitParserAnnotation(ParserAnnotationSyntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitLexerAnnotation(LexerAnnotationSyntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitAnnotationArguments(AnnotationArgumentsSyntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitAnnotationArgument(AnnotationArgumentSyntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitName(NameSyntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitQualifier(QualifierSyntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitQualifierList(QualifierListSyntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitIdentifierAlt1(IdentifierAlt1Syntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitIdentifierAlt2(IdentifierAlt2Syntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitIdentifierAlt3(IdentifierAlt3Syntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitGrammarBlock1(GrammarBlock1Syntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitParserRuleBlock1Alt1(ParserRuleBlock1Alt1Syntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitParserRuleBlock1Alt2(ParserRuleBlock1Alt2Syntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitParserRuleBlock1Alt3(ParserRuleBlock1Alt3Syntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitParserRuleBlock2(ParserRuleBlock2Syntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitPAlternativeBlock1(PAlternativeBlock1Syntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitPAlternativeBlock2(PAlternativeBlock2Syntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitPElementBlock1(PElementBlock1Syntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitPReferenceAlt3Block1(PReferenceAlt3Block1Syntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitPBlockBlock1(PBlockBlock1Syntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitLexerRuleBlock1Alt1(LexerRuleBlock1Alt1Syntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitLexerRuleBlock1Alt2(LexerRuleBlock1Alt2Syntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitLexerRuleBlock1Alt3(LexerRuleBlock1Alt3Syntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitLexerRuleBlock2(LexerRuleBlock2Syntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitLBlockBlock1(LBlockBlock1Syntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitArrayExpressionBlock1(ArrayExpressionBlock1Syntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitAnnotationArgumentsBlock1(AnnotationArgumentsBlock1Syntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitAnnotationArgumentBlock1(AnnotationArgumentBlock1Syntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitQualifierBlock1(QualifierBlock1Syntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitQualifierListBlock1(QualifierListBlock1Syntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitLexerRuleBlock1Alt1Block1(LexerRuleBlock1Alt1Block1Syntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitArrayExpressionBlock1Block1(ArrayExpressionBlock1Block1Syntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}
    }

	public class CompilerSyntaxRewriter : SyntaxRewriter, ICompilerSyntaxVisitor<SyntaxNode?>
	{
	    public CompilerSyntaxRewriter(bool visitIntoStructuredTrivia = false)
			: base(CompilerLanguage.Instance, visitIntoStructuredTrivia)
	    {
	    }
	
	    public virtual SyntaxNode VisitSkippedTokensTrivia(CompilerSkippedTokensTriviaSyntax node)
	    {
	      var tokens = this.VisitList(node.Tokens);
	      return node.Update(tokens);
	    }

        public virtual SyntaxNode VisitMain(MainSyntax node)
        {
            var kNamespace = this.VisitToken(node.KNamespace);
            var name = (QualifierSyntax)this.Visit(node.Name);
            var tSemicolon = this.VisitToken(node.TSemicolon);
            var @using = this.VisitList(node.Using);
            var declarations = (DeclarationsSyntax)this.Visit(node.Declarations);
            var eof = this.VisitToken(node.EndOfFileToken);
        	    
        	return node.Update(kNamespace, name, tSemicolon, @using, declarations, eof);
        }

        public virtual SyntaxNode VisitUsing(UsingSyntax node)
        {
            var kUsing = this.VisitToken(node.KUsing);
            var namespaces = (QualifierSyntax)this.Visit(node.Namespaces);
            var tSemicolon = this.VisitToken(node.TSemicolon);
        	    
        	return node.Update(kUsing, namespaces, tSemicolon);
        }

        public virtual SyntaxNode VisitDeclarations(DeclarationsSyntax node)
        {
            var declarations = (LanguageDeclarationSyntax)this.Visit(node.Declarations);
            var declarations1 = this.VisitList(node.Declarations1);
        	    
        	return node.Update(declarations, declarations1);
        }

        public virtual SyntaxNode VisitLanguageDeclaration(LanguageDeclarationSyntax node)
        {
            var kLanguage = this.VisitToken(node.KLanguage);
            var name = (NameSyntax)this.Visit(node.Name);
            var tSemicolon = this.VisitToken(node.TSemicolon);
            var grammar = (GrammarSyntax)this.Visit(node.Grammar);
        	    
        	return node.Update(kLanguage, name, tSemicolon, grammar);
        }

        public virtual SyntaxNode VisitGrammar(GrammarSyntax node)
        {
            var grammarBlock1 = (GrammarBlock1Syntax)this.Visit(node.GrammarBlock1);
        	    
        	return node.Update(grammarBlock1);
        }

        public virtual SyntaxNode VisitParserRule(ParserRuleSyntax node)
        {
            var annotations1 = this.VisitList(node.Annotations1);
            var parserRuleBlock1 = (ParserRuleBlock1Syntax)this.Visit(node.ParserRuleBlock1);
            var tColon = this.VisitToken(node.TColon);
            var pAlternativeList = this.VisitList(node.PAlternativeList);
            var tSemicolon = this.VisitToken(node.TSemicolon);
        	    
        	return node.Update(annotations1, parserRuleBlock1, tColon, pAlternativeList, tSemicolon);
        }

        public virtual SyntaxNode VisitLexerRule(LexerRuleSyntax node)
        {
            var annotations1 = this.VisitList(node.Annotations1);
            var lexerRuleBlock1 = (LexerRuleBlock1Syntax)this.Visit(node.LexerRuleBlock1);
            var tColon = this.VisitToken(node.TColon);
            var lAlternativeList = this.VisitList(node.LAlternativeList);
            var tSemicolon = this.VisitToken(node.TSemicolon);
        	    
        	return node.Update(annotations1, lexerRuleBlock1, tColon, lAlternativeList, tSemicolon);
        }

        public virtual SyntaxNode VisitPAlternative(PAlternativeSyntax node)
        {
            var pAlternativeBlock1 = (PAlternativeBlock1Syntax)this.Visit(node.PAlternativeBlock1);
            var elements = this.VisitList(node.Elements);
            var pAlternativeBlock2 = (PAlternativeBlock2Syntax)this.Visit(node.PAlternativeBlock2);
        	    
        	return node.Update(pAlternativeBlock1, elements, pAlternativeBlock2);
        }

        public virtual SyntaxNode VisitPElement(PElementSyntax node)
        {
            var pElementBlock1 = (PElementBlock1Syntax)this.Visit(node.PElementBlock1);
            var valueAnnotations = this.VisitList(node.ValueAnnotations);
            var value = (PElementValueSyntax)this.Visit(node.Value);
            var multiplicity = this.VisitToken(node.Multiplicity);
        	    
        	return node.Update(pElementBlock1, valueAnnotations, value, multiplicity);
        }

        public virtual SyntaxNode VisitPBlock(PBlockSyntax node)
        {
            var tLParen = this.VisitToken(node.TLParen);
            var pAlternativeList = this.VisitList(node.PAlternativeList);
            var tRParen = this.VisitToken(node.TRParen);
        	    
        	return node.Update(tLParen, pAlternativeList, tRParen);
        }

        public virtual SyntaxNode VisitPEof(PEofSyntax node)
        {
            var kEof = this.VisitToken(node.KEof);
        	    
        	return node.Update(kEof);
        }

        public virtual SyntaxNode VisitPKeyword(PKeywordSyntax node)
        {
            var text = this.VisitToken(node.Text);
        	    
        	return node.Update(text);
        }

        public virtual SyntaxNode VisitPReferenceAlt1(PReferenceAlt1Syntax node)
        {
            var rule = (IdentifierSyntax)this.Visit(node.Rule);
        	    
        	return node.Update(rule);
        }

        public virtual SyntaxNode VisitPReferenceAlt2(PReferenceAlt2Syntax node)
        {
            var tHash = this.VisitToken(node.THash);
            var referencedTypes = (QualifierSyntax)this.Visit(node.ReferencedTypes);
        	    
        	return node.Update(tHash, referencedTypes);
        }

        public virtual SyntaxNode VisitPReferenceAlt3(PReferenceAlt3Syntax node)
        {
            var tHashLBrace = this.VisitToken(node.THashLBrace);
            var qualifierList = this.VisitList(node.QualifierList);
            var tRBrace = this.VisitToken(node.TRBrace);
        	    
        	return node.Update(tHashLBrace, qualifierList, tRBrace);
        }

        public virtual SyntaxNode VisitLAlternative(LAlternativeSyntax node)
        {
            var elements = this.VisitList(node.Elements);
        	    
        	return node.Update(elements);
        }

        public virtual SyntaxNode VisitLElement(LElementSyntax node)
        {
            var isNegated = this.VisitToken(node.IsNegated);
            var value = (LElementValueSyntax)this.Visit(node.Value);
            var multiplicity = this.VisitToken(node.Multiplicity);
        	    
        	return node.Update(isNegated, value, multiplicity);
        }

        public virtual SyntaxNode VisitLBlock(LBlockSyntax node)
        {
            var tLParen = this.VisitToken(node.TLParen);
            var lAlternativeList = this.VisitList(node.LAlternativeList);
            var tRParen = this.VisitToken(node.TRParen);
        	    
        	return node.Update(tLParen, lAlternativeList, tRParen);
        }

        public virtual SyntaxNode VisitLFixed(LFixedSyntax node)
        {
            var text = this.VisitToken(node.Text);
        	    
        	return node.Update(text);
        }

        public virtual SyntaxNode VisitLWildCard(LWildCardSyntax node)
        {
            var tDot = this.VisitToken(node.TDot);
        	    
        	return node.Update(tDot);
        }

        public virtual SyntaxNode VisitLRange(LRangeSyntax node)
        {
            var startChar = this.VisitToken(node.StartChar);
            var tDotDot = this.VisitToken(node.TDotDot);
            var endChar = this.VisitToken(node.EndChar);
        	    
        	return node.Update(startChar, tDotDot, endChar);
        }

        public virtual SyntaxNode VisitLReference(LReferenceSyntax node)
        {
            var rule = (IdentifierSyntax)this.Visit(node.Rule);
        	    
        	return node.Update(rule);
        }

        public virtual SyntaxNode VisitIntExpression(IntExpressionSyntax node)
        {
            var intValue = this.VisitToken(node.IntValue);
        	    
        	return node.Update(intValue);
        }

        public virtual SyntaxNode VisitStringExpression(StringExpressionSyntax node)
        {
            var stringValue = this.VisitToken(node.StringValue);
        	    
        	return node.Update(stringValue);
        }

        public virtual SyntaxNode VisitReferenceExpression(ReferenceExpressionSyntax node)
        {
            var symbolValue = (QualifierSyntax)this.Visit(node.SymbolValue);
        	    
        	return node.Update(symbolValue);
        }

        public virtual SyntaxNode VisitArrayExpression(ArrayExpressionSyntax node)
        {
            var tLBrace = this.VisitToken(node.TLBrace);
            var arrayExpressionBlock1 = (ArrayExpressionBlock1Syntax)this.Visit(node.ArrayExpressionBlock1);
            var tRBrace = this.VisitToken(node.TRBrace);
        	    
        	return node.Update(tLBrace, arrayExpressionBlock1, tRBrace);
        }

        public virtual SyntaxNode VisitExpressionTokens(ExpressionTokensSyntax node)
        {
            var tokens = this.VisitToken(node.Tokens);
        	    
        	return node.Update(tokens);
        }

        public virtual SyntaxNode VisitParserAnnotation(ParserAnnotationSyntax node)
        {
            var tLBracket = this.VisitToken(node.TLBracket);
            var type = (QualifierSyntax)this.Visit(node.Type);
            var annotationArguments = (AnnotationArgumentsSyntax)this.Visit(node.AnnotationArguments);
            var tRBracket = this.VisitToken(node.TRBracket);
        	    
        	return node.Update(tLBracket, type, annotationArguments, tRBracket);
        }

        public virtual SyntaxNode VisitLexerAnnotation(LexerAnnotationSyntax node)
        {
            var tLBracket = this.VisitToken(node.TLBracket);
            var type = (QualifierSyntax)this.Visit(node.Type);
            var annotationArguments = (AnnotationArgumentsSyntax)this.Visit(node.AnnotationArguments);
            var tRBracket = this.VisitToken(node.TRBracket);
        	    
        	return node.Update(tLBracket, type, annotationArguments, tRBracket);
        }

        public virtual SyntaxNode VisitAnnotationArguments(AnnotationArgumentsSyntax node)
        {
            var tLParen = this.VisitToken(node.TLParen);
            var annotationArgumentList = this.VisitList(node.AnnotationArgumentList);
            var tRParen = this.VisitToken(node.TRParen);
        	    
        	return node.Update(tLParen, annotationArgumentList, tRParen);
        }

        public virtual SyntaxNode VisitAnnotationArgument(AnnotationArgumentSyntax node)
        {
            var annotationArgumentBlock1 = (AnnotationArgumentBlock1Syntax)this.Visit(node.AnnotationArgumentBlock1);
            var value = (ExpressionSyntax)this.Visit(node.Value);
        	    
        	return node.Update(annotationArgumentBlock1, value);
        }

        public virtual SyntaxNode VisitName(NameSyntax node)
        {
            var identifier = (IdentifierSyntax)this.Visit(node.Identifier);
        	    
        	return node.Update(identifier);
        }

        public virtual SyntaxNode VisitQualifier(QualifierSyntax node)
        {
            var identifierList = this.VisitList(node.IdentifierList);
        	    
        	return node.Update(identifierList);
        }

        public virtual SyntaxNode VisitQualifierList(QualifierListSyntax node)
        {
            var qualifierList = this.VisitList(node.QualifierList);
        	    
        	return node.Update(qualifierList);
        }

        public virtual SyntaxNode VisitIdentifierAlt1(IdentifierAlt1Syntax node)
        {
            var tPrimitiveType = this.VisitToken(node.TPrimitiveType);
        	    
        	return node.Update(tPrimitiveType);
        }

        public virtual SyntaxNode VisitIdentifierAlt2(IdentifierAlt2Syntax node)
        {
            var tIdentifier = this.VisitToken(node.TIdentifier);
        	    
        	return node.Update(tIdentifier);
        }

        public virtual SyntaxNode VisitIdentifierAlt3(IdentifierAlt3Syntax node)
        {
            var tVerbatimIdentifier = this.VisitToken(node.TVerbatimIdentifier);
        	    
        	return node.Update(tVerbatimIdentifier);
        }

        public virtual SyntaxNode VisitGrammarBlock1(GrammarBlock1Syntax node)
        {
            var rules = this.VisitList(node.Rules);
        	    
        	return node.Update(rules);
        }

        public virtual SyntaxNode VisitParserRuleBlock1Alt1(ParserRuleBlock1Alt1Syntax node)
        {
            var isBlock = this.VisitToken(node.IsBlock);
            var name = (NameSyntax)this.Visit(node.Name);
        	    
        	return node.Update(isBlock, name);
        }

        public virtual SyntaxNode VisitParserRuleBlock1Alt2(ParserRuleBlock1Alt2Syntax node)
        {
            var returnType = (IdentifierSyntax)this.Visit(node.ReturnType);
        	    
        	return node.Update(returnType);
        }

        public virtual SyntaxNode VisitParserRuleBlock1Alt3(ParserRuleBlock1Alt3Syntax node)
        {
            var name = (NameSyntax)this.Visit(node.Name);
            var kReturns = this.VisitToken(node.KReturns);
            var returnType = (QualifierSyntax)this.Visit(node.ReturnType);
        	    
        	return node.Update(name, kReturns, returnType);
        }

        public virtual SyntaxNode VisitParserRuleBlock2(ParserRuleBlock2Syntax node)
        {
            var tBar = this.VisitToken(node.TBar);
            var alternatives = (PAlternativeSyntax)this.Visit(node.Alternatives);
        	    
        	return node.Update(tBar, alternatives);
        }

        public virtual SyntaxNode VisitPAlternativeBlock1(PAlternativeBlock1Syntax node)
        {
            var tExclLBrace = this.VisitToken(node.TExclLBrace);
            var returnType = (QualifierSyntax)this.Visit(node.ReturnType);
            var tRBrace = this.VisitToken(node.TRBrace);
        	    
        	return node.Update(tExclLBrace, returnType, tRBrace);
        }

        public virtual SyntaxNode VisitPAlternativeBlock2(PAlternativeBlock2Syntax node)
        {
            var tEqGt = this.VisitToken(node.TEqGt);
            var returnValue = (ExpressionSyntax)this.Visit(node.ReturnValue);
        	    
        	return node.Update(tEqGt, returnValue);
        }

        public virtual SyntaxNode VisitPElementBlock1(PElementBlock1Syntax node)
        {
            var nameAnnotations = this.VisitList(node.NameAnnotations);
            var symbolProperty = (IdentifierSyntax)this.Visit(node.SymbolProperty);
            var assignment = this.VisitToken(node.Assignment);
        	    
        	return node.Update(nameAnnotations, symbolProperty, assignment);
        }

        public virtual SyntaxNode VisitPReferenceAlt3Block1(PReferenceAlt3Block1Syntax node)
        {
            var tComma = this.VisitToken(node.TComma);
            var referencedTypes = (QualifierSyntax)this.Visit(node.ReferencedTypes);
        	    
        	return node.Update(tComma, referencedTypes);
        }

        public virtual SyntaxNode VisitPBlockBlock1(PBlockBlock1Syntax node)
        {
            var tBar = this.VisitToken(node.TBar);
            var alternatives = (PAlternativeSyntax)this.Visit(node.Alternatives);
        	    
        	return node.Update(tBar, alternatives);
        }

        public virtual SyntaxNode VisitLexerRuleBlock1Alt1(LexerRuleBlock1Alt1Syntax node)
        {
            var kToken = this.VisitToken(node.KToken);
            var name = (NameSyntax)this.Visit(node.Name);
            var lexerRuleBlock1Alt1Block1 = (LexerRuleBlock1Alt1Block1Syntax)this.Visit(node.LexerRuleBlock1Alt1Block1);
        	    
        	return node.Update(kToken, name, lexerRuleBlock1Alt1Block1);
        }

        public virtual SyntaxNode VisitLexerRuleBlock1Alt2(LexerRuleBlock1Alt2Syntax node)
        {
            var isHidden = this.VisitToken(node.IsHidden);
            var name = (NameSyntax)this.Visit(node.Name);
        	    
        	return node.Update(isHidden, name);
        }

        public virtual SyntaxNode VisitLexerRuleBlock1Alt3(LexerRuleBlock1Alt3Syntax node)
        {
            var isFragment = this.VisitToken(node.IsFragment);
            var name = (NameSyntax)this.Visit(node.Name);
        	    
        	return node.Update(isFragment, name);
        }

        public virtual SyntaxNode VisitLexerRuleBlock2(LexerRuleBlock2Syntax node)
        {
            var tBar = this.VisitToken(node.TBar);
            var alternatives = (LAlternativeSyntax)this.Visit(node.Alternatives);
        	    
        	return node.Update(tBar, alternatives);
        }

        public virtual SyntaxNode VisitLBlockBlock1(LBlockBlock1Syntax node)
        {
            var tBar = this.VisitToken(node.TBar);
            var alternatives = (LAlternativeSyntax)this.Visit(node.Alternatives);
        	    
        	return node.Update(tBar, alternatives);
        }

        public virtual SyntaxNode VisitArrayExpressionBlock1(ArrayExpressionBlock1Syntax node)
        {
            var expressionList = this.VisitList(node.ExpressionList);
        	    
        	return node.Update(expressionList);
        }

        public virtual SyntaxNode VisitAnnotationArgumentsBlock1(AnnotationArgumentsBlock1Syntax node)
        {
            var tComma = this.VisitToken(node.TComma);
            var arguments = (AnnotationArgumentSyntax)this.Visit(node.Arguments);
        	    
        	return node.Update(tComma, arguments);
        }

        public virtual SyntaxNode VisitAnnotationArgumentBlock1(AnnotationArgumentBlock1Syntax node)
        {
            var name = (IdentifierSyntax)this.Visit(node.Name);
            var tColon = this.VisitToken(node.TColon);
        	    
        	return node.Update(name, tColon);
        }

        public virtual SyntaxNode VisitQualifierBlock1(QualifierBlock1Syntax node)
        {
            var tDot = this.VisitToken(node.TDot);
            var identifier = (IdentifierSyntax)this.Visit(node.Identifier);
        	    
        	return node.Update(tDot, identifier);
        }

        public virtual SyntaxNode VisitQualifierListBlock1(QualifierListBlock1Syntax node)
        {
            var tComma = this.VisitToken(node.TComma);
            var qualifier = (QualifierSyntax)this.Visit(node.Qualifier);
        	    
        	return node.Update(tComma, qualifier);
        }

        public virtual SyntaxNode VisitLexerRuleBlock1Alt1Block1(LexerRuleBlock1Alt1Block1Syntax node)
        {
            var kReturns = this.VisitToken(node.KReturns);
            var returnType = (QualifierSyntax)this.Visit(node.ReturnType);
        	    
        	return node.Update(kReturns, returnType);
        }

        public virtual SyntaxNode VisitArrayExpressionBlock1Block1(ArrayExpressionBlock1Block1Syntax node)
        {
            var tComma = this.VisitToken(node.TComma);
            var items = (ExpressionSyntax)this.Visit(node.Items);
        	    
        	return node.Update(tComma, items);
        }
				
    }
}
