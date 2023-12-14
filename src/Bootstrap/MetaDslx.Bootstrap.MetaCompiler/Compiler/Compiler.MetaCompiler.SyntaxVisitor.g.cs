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
		void VisitGrammarRuleAlt1(GrammarRuleAlt1Syntax node);
		void VisitBlock(BlockSyntax node);
		void VisitToken(TokenSyntax node);
		void VisitFragment(FragmentSyntax node);
		void VisitRule(RuleSyntax node);
		void VisitAlternative(AlternativeSyntax node);
		void VisitElement(ElementSyntax node);
		void VisitBlockInline(BlockInlineSyntax node);
		void VisitEof(EofSyntax node);
		void VisitKeyword(KeywordSyntax node);
		void VisitRuleRefAlt1(RuleRefAlt1Syntax node);
		void VisitRuleRefAlt2(RuleRefAlt2Syntax node);
		void VisitRuleRefAlt3(RuleRefAlt3Syntax node);
		void VisitLAlternative(LAlternativeSyntax node);
		void VisitLElement(LElementSyntax node);
		void VisitLBlock(LBlockSyntax node);
		void VisitLFixed(LFixedSyntax node);
		void VisitLWildCard(LWildCardSyntax node);
		void VisitLRange(LRangeSyntax node);
		void VisitLReference(LReferenceSyntax node);
		void VisitExpressionAlt1(ExpressionAlt1Syntax node);
		void VisitArrayExpression(ArrayExpressionSyntax node);
		void VisitSingleExpression(SingleExpressionSyntax node);
		void VisitParserAnnotation(ParserAnnotationSyntax node);
		void VisitLexerAnnotation(LexerAnnotationSyntax node);
		void VisitAnnotationArguments(AnnotationArgumentsSyntax node);
		void VisitAnnotationArgument(AnnotationArgumentSyntax node);
		void VisitReturnTypeIdentifierAlt1(ReturnTypeIdentifierAlt1Syntax node);
		void VisitReturnTypeIdentifierAlt2(ReturnTypeIdentifierAlt2Syntax node);
		void VisitReturnTypeQualifierAlt1(ReturnTypeQualifierAlt1Syntax node);
		void VisitReturnTypeQualifierAlt2(ReturnTypeQualifierAlt2Syntax node);
		void VisitName(NameSyntax node);
		void VisitQualifier(QualifierSyntax node);
		void VisitQualifierList(QualifierListSyntax node);
		void VisitIdentifierAlt1(IdentifierAlt1Syntax node);
		void VisitIdentifierAlt2(IdentifierAlt2Syntax node);
		void VisitSimpleQualifier(SimpleQualifierSyntax node);
		void VisitSimpleIdentifier(SimpleIdentifierSyntax node);
		void VisitGrammarBlock1(GrammarBlock1Syntax node);
		void VisitRuleBlock1Alt1(RuleBlock1Alt1Syntax node);
		void VisitRuleBlock1Alt2(RuleBlock1Alt2Syntax node);
		void VisitRuleBlock2(RuleBlock2Syntax node);
		void VisitBlockBlock1(BlockBlock1Syntax node);
		void VisitBlockBlock2(BlockBlock2Syntax node);
		void VisitBlockInlineBlock1(BlockInlineBlock1Syntax node);
		void VisitAlternativeBlock1(AlternativeBlock1Syntax node);
		void VisitAlternativeBlock2(AlternativeBlock2Syntax node);
		void VisitElementBlock1(ElementBlock1Syntax node);
		void VisitRuleRefAlt3Block1(RuleRefAlt3Block1Syntax node);
		void VisitTokenBlock1Alt1(TokenBlock1Alt1Syntax node);
		void VisitTokenBlock1Alt2(TokenBlock1Alt2Syntax node);
		void VisitTokenBlock2(TokenBlock2Syntax node);
		void VisitFragmentBlock1(FragmentBlock1Syntax node);
		void VisitLBlockBlock1(LBlockBlock1Syntax node);
		void VisitSingleExpressionBlock1Alt4(SingleExpressionBlock1Alt4Syntax node);
		void VisitSingleExpressionBlock1Alt5(SingleExpressionBlock1Alt5Syntax node);
		void VisitSingleExpressionBlock1Alt6(SingleExpressionBlock1Alt6Syntax node);
		void VisitSingleExpressionBlock1Tokens(SingleExpressionBlock1TokensSyntax node);
		void VisitArrayExpressionBlock1(ArrayExpressionBlock1Syntax node);
		void VisitAnnotationArgumentsBlock1(AnnotationArgumentsBlock1Syntax node);
		void VisitAnnotationArgumentBlock1(AnnotationArgumentBlock1Syntax node);
		void VisitQualifierBlock1(QualifierBlock1Syntax node);
		void VisitQualifierListBlock1(QualifierListBlock1Syntax node);
		void VisitSimpleQualifierBlock1(SimpleQualifierBlock1Syntax node);
		void VisitAlternativeBlock1Block1(AlternativeBlock1Block1Syntax node);
		void VisitTokenBlock1Alt1Block1(TokenBlock1Alt1Block1Syntax node);
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

		public virtual void VisitGrammarRuleAlt1(GrammarRuleAlt1Syntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitBlock(BlockSyntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitToken(TokenSyntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitFragment(FragmentSyntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitRule(RuleSyntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitAlternative(AlternativeSyntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitElement(ElementSyntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitBlockInline(BlockInlineSyntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitEof(EofSyntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitKeyword(KeywordSyntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitRuleRefAlt1(RuleRefAlt1Syntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitRuleRefAlt2(RuleRefAlt2Syntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitRuleRefAlt3(RuleRefAlt3Syntax node)
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

		public virtual void VisitExpressionAlt1(ExpressionAlt1Syntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitArrayExpression(ArrayExpressionSyntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitSingleExpression(SingleExpressionSyntax node)
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

		public virtual void VisitReturnTypeIdentifierAlt1(ReturnTypeIdentifierAlt1Syntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitReturnTypeIdentifierAlt2(ReturnTypeIdentifierAlt2Syntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitReturnTypeQualifierAlt1(ReturnTypeQualifierAlt1Syntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitReturnTypeQualifierAlt2(ReturnTypeQualifierAlt2Syntax node)
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

		public virtual void VisitSimpleQualifier(SimpleQualifierSyntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitSimpleIdentifier(SimpleIdentifierSyntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitGrammarBlock1(GrammarBlock1Syntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitRuleBlock1Alt1(RuleBlock1Alt1Syntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitRuleBlock1Alt2(RuleBlock1Alt2Syntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitRuleBlock2(RuleBlock2Syntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitBlockBlock1(BlockBlock1Syntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitBlockBlock2(BlockBlock2Syntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitBlockInlineBlock1(BlockInlineBlock1Syntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitAlternativeBlock1(AlternativeBlock1Syntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitAlternativeBlock2(AlternativeBlock2Syntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitElementBlock1(ElementBlock1Syntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitRuleRefAlt3Block1(RuleRefAlt3Block1Syntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitTokenBlock1Alt1(TokenBlock1Alt1Syntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitTokenBlock1Alt2(TokenBlock1Alt2Syntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitTokenBlock2(TokenBlock2Syntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitFragmentBlock1(FragmentBlock1Syntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitLBlockBlock1(LBlockBlock1Syntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitSingleExpressionBlock1Alt4(SingleExpressionBlock1Alt4Syntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitSingleExpressionBlock1Alt5(SingleExpressionBlock1Alt5Syntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitSingleExpressionBlock1Alt6(SingleExpressionBlock1Alt6Syntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitSingleExpressionBlock1Tokens(SingleExpressionBlock1TokensSyntax node)
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

		public virtual void VisitSimpleQualifierBlock1(SimpleQualifierBlock1Syntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitAlternativeBlock1Block1(AlternativeBlock1Block1Syntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitTokenBlock1Alt1Block1(TokenBlock1Alt1Block1Syntax node)
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
		TResult VisitGrammarRuleAlt1(GrammarRuleAlt1Syntax node);
		TResult VisitBlock(BlockSyntax node);
		TResult VisitToken(TokenSyntax node);
		TResult VisitFragment(FragmentSyntax node);
		TResult VisitRule(RuleSyntax node);
		TResult VisitAlternative(AlternativeSyntax node);
		TResult VisitElement(ElementSyntax node);
		TResult VisitBlockInline(BlockInlineSyntax node);
		TResult VisitEof(EofSyntax node);
		TResult VisitKeyword(KeywordSyntax node);
		TResult VisitRuleRefAlt1(RuleRefAlt1Syntax node);
		TResult VisitRuleRefAlt2(RuleRefAlt2Syntax node);
		TResult VisitRuleRefAlt3(RuleRefAlt3Syntax node);
		TResult VisitLAlternative(LAlternativeSyntax node);
		TResult VisitLElement(LElementSyntax node);
		TResult VisitLBlock(LBlockSyntax node);
		TResult VisitLFixed(LFixedSyntax node);
		TResult VisitLWildCard(LWildCardSyntax node);
		TResult VisitLRange(LRangeSyntax node);
		TResult VisitLReference(LReferenceSyntax node);
		TResult VisitExpressionAlt1(ExpressionAlt1Syntax node);
		TResult VisitArrayExpression(ArrayExpressionSyntax node);
		TResult VisitSingleExpression(SingleExpressionSyntax node);
		TResult VisitParserAnnotation(ParserAnnotationSyntax node);
		TResult VisitLexerAnnotation(LexerAnnotationSyntax node);
		TResult VisitAnnotationArguments(AnnotationArgumentsSyntax node);
		TResult VisitAnnotationArgument(AnnotationArgumentSyntax node);
		TResult VisitReturnTypeIdentifierAlt1(ReturnTypeIdentifierAlt1Syntax node);
		TResult VisitReturnTypeIdentifierAlt2(ReturnTypeIdentifierAlt2Syntax node);
		TResult VisitReturnTypeQualifierAlt1(ReturnTypeQualifierAlt1Syntax node);
		TResult VisitReturnTypeQualifierAlt2(ReturnTypeQualifierAlt2Syntax node);
		TResult VisitName(NameSyntax node);
		TResult VisitQualifier(QualifierSyntax node);
		TResult VisitQualifierList(QualifierListSyntax node);
		TResult VisitIdentifierAlt1(IdentifierAlt1Syntax node);
		TResult VisitIdentifierAlt2(IdentifierAlt2Syntax node);
		TResult VisitSimpleQualifier(SimpleQualifierSyntax node);
		TResult VisitSimpleIdentifier(SimpleIdentifierSyntax node);
		TResult VisitGrammarBlock1(GrammarBlock1Syntax node);
		TResult VisitRuleBlock1Alt1(RuleBlock1Alt1Syntax node);
		TResult VisitRuleBlock1Alt2(RuleBlock1Alt2Syntax node);
		TResult VisitRuleBlock2(RuleBlock2Syntax node);
		TResult VisitBlockBlock1(BlockBlock1Syntax node);
		TResult VisitBlockBlock2(BlockBlock2Syntax node);
		TResult VisitBlockInlineBlock1(BlockInlineBlock1Syntax node);
		TResult VisitAlternativeBlock1(AlternativeBlock1Syntax node);
		TResult VisitAlternativeBlock2(AlternativeBlock2Syntax node);
		TResult VisitElementBlock1(ElementBlock1Syntax node);
		TResult VisitRuleRefAlt3Block1(RuleRefAlt3Block1Syntax node);
		TResult VisitTokenBlock1Alt1(TokenBlock1Alt1Syntax node);
		TResult VisitTokenBlock1Alt2(TokenBlock1Alt2Syntax node);
		TResult VisitTokenBlock2(TokenBlock2Syntax node);
		TResult VisitFragmentBlock1(FragmentBlock1Syntax node);
		TResult VisitLBlockBlock1(LBlockBlock1Syntax node);
		TResult VisitSingleExpressionBlock1Alt4(SingleExpressionBlock1Alt4Syntax node);
		TResult VisitSingleExpressionBlock1Alt5(SingleExpressionBlock1Alt5Syntax node);
		TResult VisitSingleExpressionBlock1Alt6(SingleExpressionBlock1Alt6Syntax node);
		TResult VisitSingleExpressionBlock1Tokens(SingleExpressionBlock1TokensSyntax node);
		TResult VisitArrayExpressionBlock1(ArrayExpressionBlock1Syntax node);
		TResult VisitAnnotationArgumentsBlock1(AnnotationArgumentsBlock1Syntax node);
		TResult VisitAnnotationArgumentBlock1(AnnotationArgumentBlock1Syntax node);
		TResult VisitQualifierBlock1(QualifierBlock1Syntax node);
		TResult VisitQualifierListBlock1(QualifierListBlock1Syntax node);
		TResult VisitSimpleQualifierBlock1(SimpleQualifierBlock1Syntax node);
		TResult VisitAlternativeBlock1Block1(AlternativeBlock1Block1Syntax node);
		TResult VisitTokenBlock1Alt1Block1(TokenBlock1Alt1Block1Syntax node);
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

		public virtual TResult VisitGrammarRuleAlt1(GrammarRuleAlt1Syntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitBlock(BlockSyntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitToken(TokenSyntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitFragment(FragmentSyntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitRule(RuleSyntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitAlternative(AlternativeSyntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitElement(ElementSyntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitBlockInline(BlockInlineSyntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitEof(EofSyntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitKeyword(KeywordSyntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitRuleRefAlt1(RuleRefAlt1Syntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitRuleRefAlt2(RuleRefAlt2Syntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitRuleRefAlt3(RuleRefAlt3Syntax node)
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

		public virtual TResult VisitExpressionAlt1(ExpressionAlt1Syntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitArrayExpression(ArrayExpressionSyntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitSingleExpression(SingleExpressionSyntax node)
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

		public virtual TResult VisitReturnTypeIdentifierAlt1(ReturnTypeIdentifierAlt1Syntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitReturnTypeIdentifierAlt2(ReturnTypeIdentifierAlt2Syntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitReturnTypeQualifierAlt1(ReturnTypeQualifierAlt1Syntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitReturnTypeQualifierAlt2(ReturnTypeQualifierAlt2Syntax node)
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

		public virtual TResult VisitSimpleQualifier(SimpleQualifierSyntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitSimpleIdentifier(SimpleIdentifierSyntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitGrammarBlock1(GrammarBlock1Syntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitRuleBlock1Alt1(RuleBlock1Alt1Syntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitRuleBlock1Alt2(RuleBlock1Alt2Syntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitRuleBlock2(RuleBlock2Syntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitBlockBlock1(BlockBlock1Syntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitBlockBlock2(BlockBlock2Syntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitBlockInlineBlock1(BlockInlineBlock1Syntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitAlternativeBlock1(AlternativeBlock1Syntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitAlternativeBlock2(AlternativeBlock2Syntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitElementBlock1(ElementBlock1Syntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitRuleRefAlt3Block1(RuleRefAlt3Block1Syntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitTokenBlock1Alt1(TokenBlock1Alt1Syntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitTokenBlock1Alt2(TokenBlock1Alt2Syntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitTokenBlock2(TokenBlock2Syntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitFragmentBlock1(FragmentBlock1Syntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitLBlockBlock1(LBlockBlock1Syntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitSingleExpressionBlock1Alt4(SingleExpressionBlock1Alt4Syntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitSingleExpressionBlock1Alt5(SingleExpressionBlock1Alt5Syntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitSingleExpressionBlock1Alt6(SingleExpressionBlock1Alt6Syntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitSingleExpressionBlock1Tokens(SingleExpressionBlock1TokensSyntax node)
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

		public virtual TResult VisitSimpleQualifierBlock1(SimpleQualifierBlock1Syntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitAlternativeBlock1Block1(AlternativeBlock1Block1Syntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitTokenBlock1Alt1Block1(TokenBlock1Alt1Block1Syntax node)
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
		TResult VisitGrammarRuleAlt1(GrammarRuleAlt1Syntax node, TArg argument);
		TResult VisitBlock(BlockSyntax node, TArg argument);
		TResult VisitToken(TokenSyntax node, TArg argument);
		TResult VisitFragment(FragmentSyntax node, TArg argument);
		TResult VisitRule(RuleSyntax node, TArg argument);
		TResult VisitAlternative(AlternativeSyntax node, TArg argument);
		TResult VisitElement(ElementSyntax node, TArg argument);
		TResult VisitBlockInline(BlockInlineSyntax node, TArg argument);
		TResult VisitEof(EofSyntax node, TArg argument);
		TResult VisitKeyword(KeywordSyntax node, TArg argument);
		TResult VisitRuleRefAlt1(RuleRefAlt1Syntax node, TArg argument);
		TResult VisitRuleRefAlt2(RuleRefAlt2Syntax node, TArg argument);
		TResult VisitRuleRefAlt3(RuleRefAlt3Syntax node, TArg argument);
		TResult VisitLAlternative(LAlternativeSyntax node, TArg argument);
		TResult VisitLElement(LElementSyntax node, TArg argument);
		TResult VisitLBlock(LBlockSyntax node, TArg argument);
		TResult VisitLFixed(LFixedSyntax node, TArg argument);
		TResult VisitLWildCard(LWildCardSyntax node, TArg argument);
		TResult VisitLRange(LRangeSyntax node, TArg argument);
		TResult VisitLReference(LReferenceSyntax node, TArg argument);
		TResult VisitExpressionAlt1(ExpressionAlt1Syntax node, TArg argument);
		TResult VisitArrayExpression(ArrayExpressionSyntax node, TArg argument);
		TResult VisitSingleExpression(SingleExpressionSyntax node, TArg argument);
		TResult VisitParserAnnotation(ParserAnnotationSyntax node, TArg argument);
		TResult VisitLexerAnnotation(LexerAnnotationSyntax node, TArg argument);
		TResult VisitAnnotationArguments(AnnotationArgumentsSyntax node, TArg argument);
		TResult VisitAnnotationArgument(AnnotationArgumentSyntax node, TArg argument);
		TResult VisitReturnTypeIdentifierAlt1(ReturnTypeIdentifierAlt1Syntax node, TArg argument);
		TResult VisitReturnTypeIdentifierAlt2(ReturnTypeIdentifierAlt2Syntax node, TArg argument);
		TResult VisitReturnTypeQualifierAlt1(ReturnTypeQualifierAlt1Syntax node, TArg argument);
		TResult VisitReturnTypeQualifierAlt2(ReturnTypeQualifierAlt2Syntax node, TArg argument);
		TResult VisitName(NameSyntax node, TArg argument);
		TResult VisitQualifier(QualifierSyntax node, TArg argument);
		TResult VisitQualifierList(QualifierListSyntax node, TArg argument);
		TResult VisitIdentifierAlt1(IdentifierAlt1Syntax node, TArg argument);
		TResult VisitIdentifierAlt2(IdentifierAlt2Syntax node, TArg argument);
		TResult VisitSimpleQualifier(SimpleQualifierSyntax node, TArg argument);
		TResult VisitSimpleIdentifier(SimpleIdentifierSyntax node, TArg argument);
		TResult VisitGrammarBlock1(GrammarBlock1Syntax node, TArg argument);
		TResult VisitRuleBlock1Alt1(RuleBlock1Alt1Syntax node, TArg argument);
		TResult VisitRuleBlock1Alt2(RuleBlock1Alt2Syntax node, TArg argument);
		TResult VisitRuleBlock2(RuleBlock2Syntax node, TArg argument);
		TResult VisitBlockBlock1(BlockBlock1Syntax node, TArg argument);
		TResult VisitBlockBlock2(BlockBlock2Syntax node, TArg argument);
		TResult VisitBlockInlineBlock1(BlockInlineBlock1Syntax node, TArg argument);
		TResult VisitAlternativeBlock1(AlternativeBlock1Syntax node, TArg argument);
		TResult VisitAlternativeBlock2(AlternativeBlock2Syntax node, TArg argument);
		TResult VisitElementBlock1(ElementBlock1Syntax node, TArg argument);
		TResult VisitRuleRefAlt3Block1(RuleRefAlt3Block1Syntax node, TArg argument);
		TResult VisitTokenBlock1Alt1(TokenBlock1Alt1Syntax node, TArg argument);
		TResult VisitTokenBlock1Alt2(TokenBlock1Alt2Syntax node, TArg argument);
		TResult VisitTokenBlock2(TokenBlock2Syntax node, TArg argument);
		TResult VisitFragmentBlock1(FragmentBlock1Syntax node, TArg argument);
		TResult VisitLBlockBlock1(LBlockBlock1Syntax node, TArg argument);
		TResult VisitSingleExpressionBlock1Alt4(SingleExpressionBlock1Alt4Syntax node, TArg argument);
		TResult VisitSingleExpressionBlock1Alt5(SingleExpressionBlock1Alt5Syntax node, TArg argument);
		TResult VisitSingleExpressionBlock1Alt6(SingleExpressionBlock1Alt6Syntax node, TArg argument);
		TResult VisitSingleExpressionBlock1Tokens(SingleExpressionBlock1TokensSyntax node, TArg argument);
		TResult VisitArrayExpressionBlock1(ArrayExpressionBlock1Syntax node, TArg argument);
		TResult VisitAnnotationArgumentsBlock1(AnnotationArgumentsBlock1Syntax node, TArg argument);
		TResult VisitAnnotationArgumentBlock1(AnnotationArgumentBlock1Syntax node, TArg argument);
		TResult VisitQualifierBlock1(QualifierBlock1Syntax node, TArg argument);
		TResult VisitQualifierListBlock1(QualifierListBlock1Syntax node, TArg argument);
		TResult VisitSimpleQualifierBlock1(SimpleQualifierBlock1Syntax node, TArg argument);
		TResult VisitAlternativeBlock1Block1(AlternativeBlock1Block1Syntax node, TArg argument);
		TResult VisitTokenBlock1Alt1Block1(TokenBlock1Alt1Block1Syntax node, TArg argument);
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

		public virtual TResult VisitGrammarRuleAlt1(GrammarRuleAlt1Syntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitBlock(BlockSyntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitToken(TokenSyntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitFragment(FragmentSyntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitRule(RuleSyntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitAlternative(AlternativeSyntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitElement(ElementSyntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitBlockInline(BlockInlineSyntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitEof(EofSyntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitKeyword(KeywordSyntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitRuleRefAlt1(RuleRefAlt1Syntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitRuleRefAlt2(RuleRefAlt2Syntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitRuleRefAlt3(RuleRefAlt3Syntax node, TArg argument)
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

		public virtual TResult VisitExpressionAlt1(ExpressionAlt1Syntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitArrayExpression(ArrayExpressionSyntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitSingleExpression(SingleExpressionSyntax node, TArg argument)
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

		public virtual TResult VisitReturnTypeIdentifierAlt1(ReturnTypeIdentifierAlt1Syntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitReturnTypeIdentifierAlt2(ReturnTypeIdentifierAlt2Syntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitReturnTypeQualifierAlt1(ReturnTypeQualifierAlt1Syntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitReturnTypeQualifierAlt2(ReturnTypeQualifierAlt2Syntax node, TArg argument)
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

		public virtual TResult VisitSimpleQualifier(SimpleQualifierSyntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitSimpleIdentifier(SimpleIdentifierSyntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitGrammarBlock1(GrammarBlock1Syntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitRuleBlock1Alt1(RuleBlock1Alt1Syntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitRuleBlock1Alt2(RuleBlock1Alt2Syntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitRuleBlock2(RuleBlock2Syntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitBlockBlock1(BlockBlock1Syntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitBlockBlock2(BlockBlock2Syntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitBlockInlineBlock1(BlockInlineBlock1Syntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitAlternativeBlock1(AlternativeBlock1Syntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitAlternativeBlock2(AlternativeBlock2Syntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitElementBlock1(ElementBlock1Syntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitRuleRefAlt3Block1(RuleRefAlt3Block1Syntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitTokenBlock1Alt1(TokenBlock1Alt1Syntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitTokenBlock1Alt2(TokenBlock1Alt2Syntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitTokenBlock2(TokenBlock2Syntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitFragmentBlock1(FragmentBlock1Syntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitLBlockBlock1(LBlockBlock1Syntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitSingleExpressionBlock1Alt4(SingleExpressionBlock1Alt4Syntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitSingleExpressionBlock1Alt5(SingleExpressionBlock1Alt5Syntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitSingleExpressionBlock1Alt6(SingleExpressionBlock1Alt6Syntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitSingleExpressionBlock1Tokens(SingleExpressionBlock1TokensSyntax node, TArg argument)
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

		public virtual TResult VisitSimpleQualifierBlock1(SimpleQualifierBlock1Syntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitAlternativeBlock1Block1(AlternativeBlock1Block1Syntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitTokenBlock1Alt1Block1(TokenBlock1Alt1Block1Syntax node, TArg argument)
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

        public virtual SyntaxNode VisitGrammarRuleAlt1(GrammarRuleAlt1Syntax node)
        {
            var rule = (RuleSyntax)this.Visit(node.Rule);
        	    
        	return node.Update(rule);
        }

        public virtual SyntaxNode VisitBlock(BlockSyntax node)
        {
            var annotations1 = this.VisitList(node.Annotations1);
            var kBlock = this.VisitToken(node.KBlock);
            var name = (NameSyntax)this.Visit(node.Name);
            var blockBlock1 = (BlockBlock1Syntax)this.Visit(node.BlockBlock1);
            var tColon = this.VisitToken(node.TColon);
            var alternativeList = this.VisitList(node.AlternativeList);
            var tSemicolon = this.VisitToken(node.TSemicolon);
        	    
        	return node.Update(annotations1, kBlock, name, blockBlock1, tColon, alternativeList, tSemicolon);
        }

        public virtual SyntaxNode VisitToken(TokenSyntax node)
        {
            var annotations1 = this.VisitList(node.Annotations1);
            var tokenBlock1 = (TokenBlock1Syntax)this.Visit(node.TokenBlock1);
            var tColon = this.VisitToken(node.TColon);
            var lAlternativeList = this.VisitList(node.LAlternativeList);
            var tSemicolon = this.VisitToken(node.TSemicolon);
        	    
        	return node.Update(annotations1, tokenBlock1, tColon, lAlternativeList, tSemicolon);
        }

        public virtual SyntaxNode VisitFragment(FragmentSyntax node)
        {
            var name = (NameSyntax)this.Visit(node.Name);
            var tColon = this.VisitToken(node.TColon);
            var lAlternativeList = this.VisitList(node.LAlternativeList);
            var tSemicolon = this.VisitToken(node.TSemicolon);
        	    
        	return node.Update(name, tColon, lAlternativeList, tSemicolon);
        }

        public virtual SyntaxNode VisitRule(RuleSyntax node)
        {
            var annotations1 = this.VisitList(node.Annotations1);
            var ruleBlock1 = (RuleBlock1Syntax)this.Visit(node.RuleBlock1);
            var tColon = this.VisitToken(node.TColon);
            var alternativeList = this.VisitList(node.AlternativeList);
            var tSemicolon = this.VisitToken(node.TSemicolon);
        	    
        	return node.Update(annotations1, ruleBlock1, tColon, alternativeList, tSemicolon);
        }

        public virtual SyntaxNode VisitAlternative(AlternativeSyntax node)
        {
            var alternativeBlock1 = (AlternativeBlock1Syntax)this.Visit(node.AlternativeBlock1);
            var elements = this.VisitList(node.Elements);
            var alternativeBlock2 = (AlternativeBlock2Syntax)this.Visit(node.AlternativeBlock2);
        	    
        	return node.Update(alternativeBlock1, elements, alternativeBlock2);
        }

        public virtual SyntaxNode VisitElement(ElementSyntax node)
        {
            var elementBlock1 = (ElementBlock1Syntax)this.Visit(node.ElementBlock1);
            var valueAnnotations = this.VisitList(node.ValueAnnotations);
            var value = (ElementValueSyntax)this.Visit(node.Value);
            var multiplicity = this.VisitToken(node.Multiplicity);
        	    
        	return node.Update(elementBlock1, valueAnnotations, value, multiplicity);
        }

        public virtual SyntaxNode VisitBlockInline(BlockInlineSyntax node)
        {
            var tLParen = this.VisitToken(node.TLParen);
            var alternativeList = this.VisitList(node.AlternativeList);
            var tRParen = this.VisitToken(node.TRParen);
        	    
        	return node.Update(tLParen, alternativeList, tRParen);
        }

        public virtual SyntaxNode VisitEof(EofSyntax node)
        {
            var kEof = this.VisitToken(node.KEof);
        	    
        	return node.Update(kEof);
        }

        public virtual SyntaxNode VisitKeyword(KeywordSyntax node)
        {
            var text = this.VisitToken(node.Text);
        	    
        	return node.Update(text);
        }

        public virtual SyntaxNode VisitRuleRefAlt1(RuleRefAlt1Syntax node)
        {
            var grammarRule = (IdentifierSyntax)this.Visit(node.GrammarRule);
        	    
        	return node.Update(grammarRule);
        }

        public virtual SyntaxNode VisitRuleRefAlt2(RuleRefAlt2Syntax node)
        {
            var tHash = this.VisitToken(node.THash);
            var referencedTypes = (ReturnTypeQualifierSyntax)this.Visit(node.ReferencedTypes);
        	    
        	return node.Update(tHash, referencedTypes);
        }

        public virtual SyntaxNode VisitRuleRefAlt3(RuleRefAlt3Syntax node)
        {
            var tHashLBrace = this.VisitToken(node.THashLBrace);
            var returnTypeQualifierList = this.VisitList(node.ReturnTypeQualifierList);
            var tRBrace = this.VisitToken(node.TRBrace);
        	    
        	return node.Update(tHashLBrace, returnTypeQualifierList, tRBrace);
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

        public virtual SyntaxNode VisitExpressionAlt1(ExpressionAlt1Syntax node)
        {
            var singleExpression = (SingleExpressionSyntax)this.Visit(node.SingleExpression);
        	    
        	return node.Update(singleExpression);
        }

        public virtual SyntaxNode VisitArrayExpression(ArrayExpressionSyntax node)
        {
            var tLBrace = this.VisitToken(node.TLBrace);
            var arrayExpressionBlock1 = (ArrayExpressionBlock1Syntax)this.Visit(node.ArrayExpressionBlock1);
            var tRBrace = this.VisitToken(node.TRBrace);
        	    
        	return node.Update(tLBrace, arrayExpressionBlock1, tRBrace);
        }

        public virtual SyntaxNode VisitSingleExpression(SingleExpressionSyntax node)
        {
            var value = (SingleExpressionBlock1Syntax)this.Visit(node.Value);
        	    
        	return node.Update(value);
        }

        public virtual SyntaxNode VisitParserAnnotation(ParserAnnotationSyntax node)
        {
            var tLBracket = this.VisitToken(node.TLBracket);
            var attributeClass = (QualifierSyntax)this.Visit(node.AttributeClass);
            var annotationArguments = (AnnotationArgumentsSyntax)this.Visit(node.AnnotationArguments);
            var tRBracket = this.VisitToken(node.TRBracket);
        	    
        	return node.Update(tLBracket, attributeClass, annotationArguments, tRBracket);
        }

        public virtual SyntaxNode VisitLexerAnnotation(LexerAnnotationSyntax node)
        {
            var tLBracket = this.VisitToken(node.TLBracket);
            var attributeClass = (QualifierSyntax)this.Visit(node.AttributeClass);
            var annotationArguments = (AnnotationArgumentsSyntax)this.Visit(node.AnnotationArguments);
            var tRBracket = this.VisitToken(node.TRBracket);
        	    
        	return node.Update(tLBracket, attributeClass, annotationArguments, tRBracket);
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

        public virtual SyntaxNode VisitReturnTypeIdentifierAlt1(ReturnTypeIdentifierAlt1Syntax node)
        {
            var tPrimitiveType = this.VisitToken(node.TPrimitiveType);
        	    
        	return node.Update(tPrimitiveType);
        }

        public virtual SyntaxNode VisitReturnTypeIdentifierAlt2(ReturnTypeIdentifierAlt2Syntax node)
        {
            var identifier = (IdentifierSyntax)this.Visit(node.Identifier);
        	    
        	return node.Update(identifier);
        }

        public virtual SyntaxNode VisitReturnTypeQualifierAlt1(ReturnTypeQualifierAlt1Syntax node)
        {
            var tPrimitiveType = this.VisitToken(node.TPrimitiveType);
        	    
        	return node.Update(tPrimitiveType);
        }

        public virtual SyntaxNode VisitReturnTypeQualifierAlt2(ReturnTypeQualifierAlt2Syntax node)
        {
            var qualifier = (QualifierSyntax)this.Visit(node.Qualifier);
        	    
        	return node.Update(qualifier);
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
            var tIdentifier = this.VisitToken(node.TIdentifier);
        	    
        	return node.Update(tIdentifier);
        }

        public virtual SyntaxNode VisitIdentifierAlt2(IdentifierAlt2Syntax node)
        {
            var tVerbatimIdentifier = this.VisitToken(node.TVerbatimIdentifier);
        	    
        	return node.Update(tVerbatimIdentifier);
        }

        public virtual SyntaxNode VisitSimpleQualifier(SimpleQualifierSyntax node)
        {
            var simpleIdentifierList = this.VisitList(node.SimpleIdentifierList);
        	    
        	return node.Update(simpleIdentifierList);
        }

        public virtual SyntaxNode VisitSimpleIdentifier(SimpleIdentifierSyntax node)
        {
            var tIdentifier = this.VisitToken(node.TIdentifier);
        	    
        	return node.Update(tIdentifier);
        }

        public virtual SyntaxNode VisitGrammarBlock1(GrammarBlock1Syntax node)
        {
            var grammarRules = this.VisitList(node.GrammarRules);
        	    
        	return node.Update(grammarRules);
        }

        public virtual SyntaxNode VisitRuleBlock1Alt1(RuleBlock1Alt1Syntax node)
        {
            var returnType = (ReturnTypeIdentifierSyntax)this.Visit(node.ReturnType);
        	    
        	return node.Update(returnType);
        }

        public virtual SyntaxNode VisitRuleBlock1Alt2(RuleBlock1Alt2Syntax node)
        {
            var identifier = (IdentifierSyntax)this.Visit(node.Identifier);
            var kReturns = this.VisitToken(node.KReturns);
            var returnType = (ReturnTypeQualifierSyntax)this.Visit(node.ReturnType);
        	    
        	return node.Update(identifier, kReturns, returnType);
        }

        public virtual SyntaxNode VisitRuleBlock2(RuleBlock2Syntax node)
        {
            var tBar = this.VisitToken(node.TBar);
            var alternatives = (AlternativeSyntax)this.Visit(node.Alternatives);
        	    
        	return node.Update(tBar, alternatives);
        }

        public virtual SyntaxNode VisitBlockBlock1(BlockBlock1Syntax node)
        {
            var kReturns = this.VisitToken(node.KReturns);
            var returnType = (ReturnTypeQualifierSyntax)this.Visit(node.ReturnType);
        	    
        	return node.Update(kReturns, returnType);
        }

        public virtual SyntaxNode VisitBlockBlock2(BlockBlock2Syntax node)
        {
            var tBar = this.VisitToken(node.TBar);
            var alternatives = (AlternativeSyntax)this.Visit(node.Alternatives);
        	    
        	return node.Update(tBar, alternatives);
        }

        public virtual SyntaxNode VisitBlockInlineBlock1(BlockInlineBlock1Syntax node)
        {
            var tBar = this.VisitToken(node.TBar);
            var alternatives = (AlternativeSyntax)this.Visit(node.Alternatives);
        	    
        	return node.Update(tBar, alternatives);
        }

        public virtual SyntaxNode VisitAlternativeBlock1(AlternativeBlock1Syntax node)
        {
            var annotations1 = this.VisitList(node.Annotations1);
            var kAlt = this.VisitToken(node.KAlt);
            var name = (NameSyntax)this.Visit(node.Name);
            var alternativeBlock1Block1 = (AlternativeBlock1Block1Syntax)this.Visit(node.AlternativeBlock1Block1);
            var tColon = this.VisitToken(node.TColon);
        	    
        	return node.Update(annotations1, kAlt, name, alternativeBlock1Block1, tColon);
        }

        public virtual SyntaxNode VisitAlternativeBlock2(AlternativeBlock2Syntax node)
        {
            var tEqGt = this.VisitToken(node.TEqGt);
            var returnValue = (ExpressionSyntax)this.Visit(node.ReturnValue);
        	    
        	return node.Update(tEqGt, returnValue);
        }

        public virtual SyntaxNode VisitElementBlock1(ElementBlock1Syntax node)
        {
            var nameAnnotations = this.VisitList(node.NameAnnotations);
            var symbolProperty = (IdentifierSyntax)this.Visit(node.SymbolProperty);
            var assignment = this.VisitToken(node.Assignment);
        	    
        	return node.Update(nameAnnotations, symbolProperty, assignment);
        }

        public virtual SyntaxNode VisitRuleRefAlt3Block1(RuleRefAlt3Block1Syntax node)
        {
            var tComma = this.VisitToken(node.TComma);
            var referencedTypes = (ReturnTypeQualifierSyntax)this.Visit(node.ReferencedTypes);
        	    
        	return node.Update(tComma, referencedTypes);
        }

        public virtual SyntaxNode VisitTokenBlock1Alt1(TokenBlock1Alt1Syntax node)
        {
            var kToken = this.VisitToken(node.KToken);
            var name = (NameSyntax)this.Visit(node.Name);
            var tokenBlock1Alt1Block1 = (TokenBlock1Alt1Block1Syntax)this.Visit(node.TokenBlock1Alt1Block1);
        	    
        	return node.Update(kToken, name, tokenBlock1Alt1Block1);
        }

        public virtual SyntaxNode VisitTokenBlock1Alt2(TokenBlock1Alt2Syntax node)
        {
            var isTrivia1 = this.VisitToken(node.IsTrivia1);
            var name = (NameSyntax)this.Visit(node.Name);
        	    
        	return node.Update(isTrivia1, name);
        }

        public virtual SyntaxNode VisitTokenBlock2(TokenBlock2Syntax node)
        {
            var tBar = this.VisitToken(node.TBar);
            var alternatives = (LAlternativeSyntax)this.Visit(node.Alternatives);
        	    
        	return node.Update(tBar, alternatives);
        }

        public virtual SyntaxNode VisitFragmentBlock1(FragmentBlock1Syntax node)
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

        public virtual SyntaxNode VisitSingleExpressionBlock1Alt4(SingleExpressionBlock1Alt4Syntax node)
        {
            var tInteger = this.VisitToken(node.TInteger);
        	    
        	return node.Update(tInteger);
        }

        public virtual SyntaxNode VisitSingleExpressionBlock1Alt5(SingleExpressionBlock1Alt5Syntax node)
        {
            var tString = this.VisitToken(node.TString);
        	    
        	return node.Update(tString);
        }

        public virtual SyntaxNode VisitSingleExpressionBlock1Alt6(SingleExpressionBlock1Alt6Syntax node)
        {
            var simpleQualifier = (SimpleQualifierSyntax)this.Visit(node.SimpleQualifier);
        	    
        	return node.Update(simpleQualifier);
        }

        public virtual SyntaxNode VisitSingleExpressionBlock1Tokens(SingleExpressionBlock1TokensSyntax node)
        {
            var tokens = this.VisitToken(node.Tokens);
        	    
        	return node.Update(tokens);
        }

        public virtual SyntaxNode VisitArrayExpressionBlock1(ArrayExpressionBlock1Syntax node)
        {
            var singleExpressionList = this.VisitList(node.SingleExpressionList);
        	    
        	return node.Update(singleExpressionList);
        }

        public virtual SyntaxNode VisitAnnotationArgumentsBlock1(AnnotationArgumentsBlock1Syntax node)
        {
            var tComma = this.VisitToken(node.TComma);
            var arguments = (AnnotationArgumentSyntax)this.Visit(node.Arguments);
        	    
        	return node.Update(tComma, arguments);
        }

        public virtual SyntaxNode VisitAnnotationArgumentBlock1(AnnotationArgumentBlock1Syntax node)
        {
            var namedParameter = (IdentifierSyntax)this.Visit(node.NamedParameter);
            var tColon = this.VisitToken(node.TColon);
        	    
        	return node.Update(namedParameter, tColon);
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

        public virtual SyntaxNode VisitSimpleQualifierBlock1(SimpleQualifierBlock1Syntax node)
        {
            var tDot = this.VisitToken(node.TDot);
            var simpleIdentifier = (SimpleIdentifierSyntax)this.Visit(node.SimpleIdentifier);
        	    
        	return node.Update(tDot, simpleIdentifier);
        }

        public virtual SyntaxNode VisitAlternativeBlock1Block1(AlternativeBlock1Block1Syntax node)
        {
            var kReturns = this.VisitToken(node.KReturns);
            var returnType = (ReturnTypeQualifierSyntax)this.Visit(node.ReturnType);
        	    
        	return node.Update(kReturns, returnType);
        }

        public virtual SyntaxNode VisitTokenBlock1Alt1Block1(TokenBlock1Alt1Block1Syntax node)
        {
            var kReturns = this.VisitToken(node.KReturns);
            var returnType = (ReturnTypeQualifierSyntax)this.Visit(node.ReturnType);
        	    
        	return node.Update(kReturns, returnType);
        }

        public virtual SyntaxNode VisitArrayExpressionBlock1Block1(ArrayExpressionBlock1Block1Syntax node)
        {
            var tComma = this.VisitToken(node.TComma);
            var items = (SingleExpressionSyntax)this.Visit(node.Items);
        	    
        	return node.Update(tComma, items);
        }
				
    }
}
