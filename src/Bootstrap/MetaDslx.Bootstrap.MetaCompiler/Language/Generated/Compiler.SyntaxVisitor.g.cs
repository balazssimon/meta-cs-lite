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
		void VisitLanguageDeclaration(LanguageDeclarationSyntax node);
		void VisitGrammar(GrammarSyntax node);
		void VisitRule(RuleSyntax node);
		void VisitToken(TokenSyntax node);
		void VisitFragment(FragmentSyntax node);
		void VisitAlternative(AlternativeSyntax node);
		void VisitElement(ElementSyntax node);
		void VisitBlock(BlockSyntax node);
		void VisitEof1(Eof1Syntax node);
		void VisitFixed(FixedSyntax node);
		void VisitRuleRefAlt1(RuleRefAlt1Syntax node);
		void VisitRuleRefAlt2(RuleRefAlt2Syntax node);
		void VisitRuleRefAlt3(RuleRefAlt3Syntax node);
		void VisitBlockAlternative(BlockAlternativeSyntax node);
		void VisitLAlternative(LAlternativeSyntax node);
		void VisitLElement(LElementSyntax node);
		void VisitLElementValueTokens(LElementValueTokensSyntax node);
		void VisitLBlock(LBlockSyntax node);
		void VisitLRange(LRangeSyntax node);
		void VisitLReference(LReferenceSyntax node);
		void VisitExpressionAlt1(ExpressionAlt1Syntax node);
		void VisitArrayExpression(ArrayExpressionSyntax node);
		void VisitSingleExpression(SingleExpressionSyntax node);
		void VisitParserAnnotation(ParserAnnotationSyntax node);
		void VisitLexerAnnotation(LexerAnnotationSyntax node);
		void VisitAnnotationArgument(AnnotationArgumentSyntax node);
		void VisitTypeReferenceIdentifierAlt1(TypeReferenceIdentifierAlt1Syntax node);
		void VisitTypeReferenceIdentifierAlt2(TypeReferenceIdentifierAlt2Syntax node);
		void VisitTypeReferenceAlt1(TypeReferenceAlt1Syntax node);
		void VisitTypeReferenceAlt2(TypeReferenceAlt2Syntax node);
		void VisitName(NameSyntax node);
		void VisitIdentifier(IdentifierSyntax node);
		void VisitMainBlock1(MainBlock1Syntax node);
		void VisitRuleBlock1Alt1(RuleBlock1Alt1Syntax node);
		void VisitRuleBlock1Alt2(RuleBlock1Alt2Syntax node);
		void VisitRuleAlternativesBlock(RuleAlternativesBlockSyntax node);
		void VisitAlternativeBlock1(AlternativeBlock1Syntax node);
		void VisitAlternativeBlock2(AlternativeBlock2Syntax node);
		void VisitElementBlock1(ElementBlock1Syntax node);
		void VisitBlockAlternativesBlock(BlockAlternativesBlockSyntax node);
		void VisitBlockAlternativeBlock1(BlockAlternativeBlock1Syntax node);
		void VisitRuleRefAlt3ReferencedTypesBlock(RuleRefAlt3ReferencedTypesBlockSyntax node);
		void VisitRuleRefAlt3Block1(RuleRefAlt3Block1Syntax node);
		void VisitTokenBlock1Alt1(TokenBlock1Alt1Syntax node);
		void VisitTokenBlock1Alt2(TokenBlock1Alt2Syntax node);
		void VisitTokenAlternativesBlock(TokenAlternativesBlockSyntax node);
		void VisitFragmentAlternativesBlock(FragmentAlternativesBlockSyntax node);
		void VisitLBlockAlternativesBlock(LBlockAlternativesBlockSyntax node);
		void VisitTokens(TokensSyntax node);
		void VisitSingleExpressionBlock1Alt2(SingleExpressionBlock1Alt2Syntax node);
		void VisitSingleExpressionBlock1Alt3(SingleExpressionBlock1Alt3Syntax node);
		void VisitParserAnnotationArgumentsBlock(ParserAnnotationArgumentsBlockSyntax node);
		void VisitLexerAnnotationArgumentsBlock(LexerAnnotationArgumentsBlockSyntax node);
		void VisitAnnotationArgumentBlock1(AnnotationArgumentBlock1Syntax node);
		void VisitMainQualifierBlock(MainQualifierBlockSyntax node);
		void VisitAlternativeBlock1Block1(AlternativeBlock1Block1Syntax node);
		void VisitTokenBlock1Alt1Block1(TokenBlock1Alt1Block1Syntax node);
		void VisitArrayExpressionItemsBlock(ArrayExpressionItemsBlockSyntax node);
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

public virtual void VisitLanguageDeclaration(LanguageDeclarationSyntax node)
{
    this.DefaultVisit(node);
}

public virtual void VisitGrammar(GrammarSyntax node)
{
    this.DefaultVisit(node);
}

public virtual void VisitRule(RuleSyntax node)
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

public virtual void VisitAlternative(AlternativeSyntax node)
{
    this.DefaultVisit(node);
}

public virtual void VisitElement(ElementSyntax node)
{
    this.DefaultVisit(node);
}

public virtual void VisitBlock(BlockSyntax node)
{
    this.DefaultVisit(node);
}

public virtual void VisitEof1(Eof1Syntax node)
{
    this.DefaultVisit(node);
}

public virtual void VisitFixed(FixedSyntax node)
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

public virtual void VisitBlockAlternative(BlockAlternativeSyntax node)
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

public virtual void VisitLElementValueTokens(LElementValueTokensSyntax node)
{
    this.DefaultVisit(node);
}

public virtual void VisitLBlock(LBlockSyntax node)
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

public virtual void VisitAnnotationArgument(AnnotationArgumentSyntax node)
{
    this.DefaultVisit(node);
}

public virtual void VisitTypeReferenceIdentifierAlt1(TypeReferenceIdentifierAlt1Syntax node)
{
    this.DefaultVisit(node);
}

public virtual void VisitTypeReferenceIdentifierAlt2(TypeReferenceIdentifierAlt2Syntax node)
{
    this.DefaultVisit(node);
}

public virtual void VisitTypeReferenceAlt1(TypeReferenceAlt1Syntax node)
{
    this.DefaultVisit(node);
}

public virtual void VisitTypeReferenceAlt2(TypeReferenceAlt2Syntax node)
{
    this.DefaultVisit(node);
}

public virtual void VisitName(NameSyntax node)
{
    this.DefaultVisit(node);
}

public virtual void VisitIdentifier(IdentifierSyntax node)
{
    this.DefaultVisit(node);
}

public virtual void VisitMainBlock1(MainBlock1Syntax node)
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

public virtual void VisitRuleAlternativesBlock(RuleAlternativesBlockSyntax node)
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

public virtual void VisitBlockAlternativesBlock(BlockAlternativesBlockSyntax node)
{
    this.DefaultVisit(node);
}

public virtual void VisitBlockAlternativeBlock1(BlockAlternativeBlock1Syntax node)
{
    this.DefaultVisit(node);
}

public virtual void VisitRuleRefAlt3ReferencedTypesBlock(RuleRefAlt3ReferencedTypesBlockSyntax node)
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

public virtual void VisitTokenAlternativesBlock(TokenAlternativesBlockSyntax node)
{
    this.DefaultVisit(node);
}

public virtual void VisitFragmentAlternativesBlock(FragmentAlternativesBlockSyntax node)
{
    this.DefaultVisit(node);
}

public virtual void VisitLBlockAlternativesBlock(LBlockAlternativesBlockSyntax node)
{
    this.DefaultVisit(node);
}

public virtual void VisitTokens(TokensSyntax node)
{
    this.DefaultVisit(node);
}

public virtual void VisitSingleExpressionBlock1Alt2(SingleExpressionBlock1Alt2Syntax node)
{
    this.DefaultVisit(node);
}

public virtual void VisitSingleExpressionBlock1Alt3(SingleExpressionBlock1Alt3Syntax node)
{
    this.DefaultVisit(node);
}

public virtual void VisitParserAnnotationArgumentsBlock(ParserAnnotationArgumentsBlockSyntax node)
{
    this.DefaultVisit(node);
}

public virtual void VisitLexerAnnotationArgumentsBlock(LexerAnnotationArgumentsBlockSyntax node)
{
    this.DefaultVisit(node);
}

public virtual void VisitAnnotationArgumentBlock1(AnnotationArgumentBlock1Syntax node)
{
    this.DefaultVisit(node);
}

public virtual void VisitMainQualifierBlock(MainQualifierBlockSyntax node)
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

public virtual void VisitArrayExpressionItemsBlock(ArrayExpressionItemsBlockSyntax node)
{
    this.DefaultVisit(node);
}
    }

public interface ICompilerSyntaxVisitor<TResult> 
{
    TResult VisitSkippedTokensTrivia(CompilerSkippedTokensTriviaSyntax node);
	TResult VisitMain(MainSyntax node);
	TResult VisitUsing(UsingSyntax node);
	TResult VisitLanguageDeclaration(LanguageDeclarationSyntax node);
	TResult VisitGrammar(GrammarSyntax node);
	TResult VisitRule(RuleSyntax node);
	TResult VisitToken(TokenSyntax node);
	TResult VisitFragment(FragmentSyntax node);
	TResult VisitAlternative(AlternativeSyntax node);
	TResult VisitElement(ElementSyntax node);
	TResult VisitBlock(BlockSyntax node);
	TResult VisitEof1(Eof1Syntax node);
	TResult VisitFixed(FixedSyntax node);
	TResult VisitRuleRefAlt1(RuleRefAlt1Syntax node);
	TResult VisitRuleRefAlt2(RuleRefAlt2Syntax node);
	TResult VisitRuleRefAlt3(RuleRefAlt3Syntax node);
	TResult VisitBlockAlternative(BlockAlternativeSyntax node);
	TResult VisitLAlternative(LAlternativeSyntax node);
	TResult VisitLElement(LElementSyntax node);
	TResult VisitLElementValueTokens(LElementValueTokensSyntax node);
	TResult VisitLBlock(LBlockSyntax node);
	TResult VisitLRange(LRangeSyntax node);
	TResult VisitLReference(LReferenceSyntax node);
	TResult VisitExpressionAlt1(ExpressionAlt1Syntax node);
	TResult VisitArrayExpression(ArrayExpressionSyntax node);
	TResult VisitSingleExpression(SingleExpressionSyntax node);
	TResult VisitParserAnnotation(ParserAnnotationSyntax node);
	TResult VisitLexerAnnotation(LexerAnnotationSyntax node);
	TResult VisitAnnotationArgument(AnnotationArgumentSyntax node);
	TResult VisitTypeReferenceIdentifierAlt1(TypeReferenceIdentifierAlt1Syntax node);
	TResult VisitTypeReferenceIdentifierAlt2(TypeReferenceIdentifierAlt2Syntax node);
	TResult VisitTypeReferenceAlt1(TypeReferenceAlt1Syntax node);
	TResult VisitTypeReferenceAlt2(TypeReferenceAlt2Syntax node);
	TResult VisitName(NameSyntax node);
	TResult VisitIdentifier(IdentifierSyntax node);
	TResult VisitMainBlock1(MainBlock1Syntax node);
	TResult VisitRuleBlock1Alt1(RuleBlock1Alt1Syntax node);
	TResult VisitRuleBlock1Alt2(RuleBlock1Alt2Syntax node);
	TResult VisitRuleAlternativesBlock(RuleAlternativesBlockSyntax node);
	TResult VisitAlternativeBlock1(AlternativeBlock1Syntax node);
	TResult VisitAlternativeBlock2(AlternativeBlock2Syntax node);
	TResult VisitElementBlock1(ElementBlock1Syntax node);
	TResult VisitBlockAlternativesBlock(BlockAlternativesBlockSyntax node);
	TResult VisitBlockAlternativeBlock1(BlockAlternativeBlock1Syntax node);
	TResult VisitRuleRefAlt3ReferencedTypesBlock(RuleRefAlt3ReferencedTypesBlockSyntax node);
	TResult VisitRuleRefAlt3Block1(RuleRefAlt3Block1Syntax node);
	TResult VisitTokenBlock1Alt1(TokenBlock1Alt1Syntax node);
	TResult VisitTokenBlock1Alt2(TokenBlock1Alt2Syntax node);
	TResult VisitTokenAlternativesBlock(TokenAlternativesBlockSyntax node);
	TResult VisitFragmentAlternativesBlock(FragmentAlternativesBlockSyntax node);
	TResult VisitLBlockAlternativesBlock(LBlockAlternativesBlockSyntax node);
	TResult VisitTokens(TokensSyntax node);
	TResult VisitSingleExpressionBlock1Alt2(SingleExpressionBlock1Alt2Syntax node);
	TResult VisitSingleExpressionBlock1Alt3(SingleExpressionBlock1Alt3Syntax node);
	TResult VisitParserAnnotationArgumentsBlock(ParserAnnotationArgumentsBlockSyntax node);
	TResult VisitLexerAnnotationArgumentsBlock(LexerAnnotationArgumentsBlockSyntax node);
	TResult VisitAnnotationArgumentBlock1(AnnotationArgumentBlock1Syntax node);
	TResult VisitMainQualifierBlock(MainQualifierBlockSyntax node);
	TResult VisitAlternativeBlock1Block1(AlternativeBlock1Block1Syntax node);
	TResult VisitTokenBlock1Alt1Block1(TokenBlock1Alt1Block1Syntax node);
	TResult VisitArrayExpressionItemsBlock(ArrayExpressionItemsBlockSyntax node);
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

public virtual TResult VisitLanguageDeclaration(LanguageDeclarationSyntax node)
{
    return this.DefaultVisit(node);
}

public virtual TResult VisitGrammar(GrammarSyntax node)
{
    return this.DefaultVisit(node);
}

public virtual TResult VisitRule(RuleSyntax node)
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

public virtual TResult VisitAlternative(AlternativeSyntax node)
{
    return this.DefaultVisit(node);
}

public virtual TResult VisitElement(ElementSyntax node)
{
    return this.DefaultVisit(node);
}

public virtual TResult VisitBlock(BlockSyntax node)
{
    return this.DefaultVisit(node);
}

public virtual TResult VisitEof1(Eof1Syntax node)
{
    return this.DefaultVisit(node);
}

public virtual TResult VisitFixed(FixedSyntax node)
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

public virtual TResult VisitBlockAlternative(BlockAlternativeSyntax node)
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

public virtual TResult VisitLElementValueTokens(LElementValueTokensSyntax node)
{
    return this.DefaultVisit(node);
}

public virtual TResult VisitLBlock(LBlockSyntax node)
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

public virtual TResult VisitAnnotationArgument(AnnotationArgumentSyntax node)
{
    return this.DefaultVisit(node);
}

public virtual TResult VisitTypeReferenceIdentifierAlt1(TypeReferenceIdentifierAlt1Syntax node)
{
    return this.DefaultVisit(node);
}

public virtual TResult VisitTypeReferenceIdentifierAlt2(TypeReferenceIdentifierAlt2Syntax node)
{
    return this.DefaultVisit(node);
}

public virtual TResult VisitTypeReferenceAlt1(TypeReferenceAlt1Syntax node)
{
    return this.DefaultVisit(node);
}

public virtual TResult VisitTypeReferenceAlt2(TypeReferenceAlt2Syntax node)
{
    return this.DefaultVisit(node);
}

public virtual TResult VisitName(NameSyntax node)
{
    return this.DefaultVisit(node);
}

public virtual TResult VisitIdentifier(IdentifierSyntax node)
{
    return this.DefaultVisit(node);
}

public virtual TResult VisitMainBlock1(MainBlock1Syntax node)
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

public virtual TResult VisitRuleAlternativesBlock(RuleAlternativesBlockSyntax node)
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

public virtual TResult VisitBlockAlternativesBlock(BlockAlternativesBlockSyntax node)
{
    return this.DefaultVisit(node);
}

public virtual TResult VisitBlockAlternativeBlock1(BlockAlternativeBlock1Syntax node)
{
    return this.DefaultVisit(node);
}

public virtual TResult VisitRuleRefAlt3ReferencedTypesBlock(RuleRefAlt3ReferencedTypesBlockSyntax node)
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

public virtual TResult VisitTokenAlternativesBlock(TokenAlternativesBlockSyntax node)
{
    return this.DefaultVisit(node);
}

public virtual TResult VisitFragmentAlternativesBlock(FragmentAlternativesBlockSyntax node)
{
    return this.DefaultVisit(node);
}

public virtual TResult VisitLBlockAlternativesBlock(LBlockAlternativesBlockSyntax node)
{
    return this.DefaultVisit(node);
}

public virtual TResult VisitTokens(TokensSyntax node)
{
    return this.DefaultVisit(node);
}

public virtual TResult VisitSingleExpressionBlock1Alt2(SingleExpressionBlock1Alt2Syntax node)
{
    return this.DefaultVisit(node);
}

public virtual TResult VisitSingleExpressionBlock1Alt3(SingleExpressionBlock1Alt3Syntax node)
{
    return this.DefaultVisit(node);
}

public virtual TResult VisitParserAnnotationArgumentsBlock(ParserAnnotationArgumentsBlockSyntax node)
{
    return this.DefaultVisit(node);
}

public virtual TResult VisitLexerAnnotationArgumentsBlock(LexerAnnotationArgumentsBlockSyntax node)
{
    return this.DefaultVisit(node);
}

public virtual TResult VisitAnnotationArgumentBlock1(AnnotationArgumentBlock1Syntax node)
{
    return this.DefaultVisit(node);
}

public virtual TResult VisitMainQualifierBlock(MainQualifierBlockSyntax node)
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

public virtual TResult VisitArrayExpressionItemsBlock(ArrayExpressionItemsBlockSyntax node)
{
    return this.DefaultVisit(node);
}
    }

public interface ICompilerSyntaxVisitor<TArg, TResult> 
{
    TResult VisitSkippedTokensTrivia(CompilerSkippedTokensTriviaSyntax node, TArg argument);
	TResult VisitMain(MainSyntax node, TArg argument);
	TResult VisitUsing(UsingSyntax node, TArg argument);
	TResult VisitLanguageDeclaration(LanguageDeclarationSyntax node, TArg argument);
	TResult VisitGrammar(GrammarSyntax node, TArg argument);
	TResult VisitRule(RuleSyntax node, TArg argument);
	TResult VisitToken(TokenSyntax node, TArg argument);
	TResult VisitFragment(FragmentSyntax node, TArg argument);
	TResult VisitAlternative(AlternativeSyntax node, TArg argument);
	TResult VisitElement(ElementSyntax node, TArg argument);
	TResult VisitBlock(BlockSyntax node, TArg argument);
	TResult VisitEof1(Eof1Syntax node, TArg argument);
	TResult VisitFixed(FixedSyntax node, TArg argument);
	TResult VisitRuleRefAlt1(RuleRefAlt1Syntax node, TArg argument);
	TResult VisitRuleRefAlt2(RuleRefAlt2Syntax node, TArg argument);
	TResult VisitRuleRefAlt3(RuleRefAlt3Syntax node, TArg argument);
	TResult VisitBlockAlternative(BlockAlternativeSyntax node, TArg argument);
	TResult VisitLAlternative(LAlternativeSyntax node, TArg argument);
	TResult VisitLElement(LElementSyntax node, TArg argument);
	TResult VisitLElementValueTokens(LElementValueTokensSyntax node, TArg argument);
	TResult VisitLBlock(LBlockSyntax node, TArg argument);
	TResult VisitLRange(LRangeSyntax node, TArg argument);
	TResult VisitLReference(LReferenceSyntax node, TArg argument);
	TResult VisitExpressionAlt1(ExpressionAlt1Syntax node, TArg argument);
	TResult VisitArrayExpression(ArrayExpressionSyntax node, TArg argument);
	TResult VisitSingleExpression(SingleExpressionSyntax node, TArg argument);
	TResult VisitParserAnnotation(ParserAnnotationSyntax node, TArg argument);
	TResult VisitLexerAnnotation(LexerAnnotationSyntax node, TArg argument);
	TResult VisitAnnotationArgument(AnnotationArgumentSyntax node, TArg argument);
	TResult VisitTypeReferenceIdentifierAlt1(TypeReferenceIdentifierAlt1Syntax node, TArg argument);
	TResult VisitTypeReferenceIdentifierAlt2(TypeReferenceIdentifierAlt2Syntax node, TArg argument);
	TResult VisitTypeReferenceAlt1(TypeReferenceAlt1Syntax node, TArg argument);
	TResult VisitTypeReferenceAlt2(TypeReferenceAlt2Syntax node, TArg argument);
	TResult VisitName(NameSyntax node, TArg argument);
	TResult VisitIdentifier(IdentifierSyntax node, TArg argument);
	TResult VisitMainBlock1(MainBlock1Syntax node, TArg argument);
	TResult VisitRuleBlock1Alt1(RuleBlock1Alt1Syntax node, TArg argument);
	TResult VisitRuleBlock1Alt2(RuleBlock1Alt2Syntax node, TArg argument);
	TResult VisitRuleAlternativesBlock(RuleAlternativesBlockSyntax node, TArg argument);
	TResult VisitAlternativeBlock1(AlternativeBlock1Syntax node, TArg argument);
	TResult VisitAlternativeBlock2(AlternativeBlock2Syntax node, TArg argument);
	TResult VisitElementBlock1(ElementBlock1Syntax node, TArg argument);
	TResult VisitBlockAlternativesBlock(BlockAlternativesBlockSyntax node, TArg argument);
	TResult VisitBlockAlternativeBlock1(BlockAlternativeBlock1Syntax node, TArg argument);
	TResult VisitRuleRefAlt3ReferencedTypesBlock(RuleRefAlt3ReferencedTypesBlockSyntax node, TArg argument);
	TResult VisitRuleRefAlt3Block1(RuleRefAlt3Block1Syntax node, TArg argument);
	TResult VisitTokenBlock1Alt1(TokenBlock1Alt1Syntax node, TArg argument);
	TResult VisitTokenBlock1Alt2(TokenBlock1Alt2Syntax node, TArg argument);
	TResult VisitTokenAlternativesBlock(TokenAlternativesBlockSyntax node, TArg argument);
	TResult VisitFragmentAlternativesBlock(FragmentAlternativesBlockSyntax node, TArg argument);
	TResult VisitLBlockAlternativesBlock(LBlockAlternativesBlockSyntax node, TArg argument);
	TResult VisitTokens(TokensSyntax node, TArg argument);
	TResult VisitSingleExpressionBlock1Alt2(SingleExpressionBlock1Alt2Syntax node, TArg argument);
	TResult VisitSingleExpressionBlock1Alt3(SingleExpressionBlock1Alt3Syntax node, TArg argument);
	TResult VisitParserAnnotationArgumentsBlock(ParserAnnotationArgumentsBlockSyntax node, TArg argument);
	TResult VisitLexerAnnotationArgumentsBlock(LexerAnnotationArgumentsBlockSyntax node, TArg argument);
	TResult VisitAnnotationArgumentBlock1(AnnotationArgumentBlock1Syntax node, TArg argument);
	TResult VisitMainQualifierBlock(MainQualifierBlockSyntax node, TArg argument);
	TResult VisitAlternativeBlock1Block1(AlternativeBlock1Block1Syntax node, TArg argument);
	TResult VisitTokenBlock1Alt1Block1(TokenBlock1Alt1Block1Syntax node, TArg argument);
	TResult VisitArrayExpressionItemsBlock(ArrayExpressionItemsBlockSyntax node, TArg argument);
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

public virtual TResult VisitLanguageDeclaration(LanguageDeclarationSyntax node, TArg argument)
{
    return this.DefaultVisit(node, argument);
}

public virtual TResult VisitGrammar(GrammarSyntax node, TArg argument)
{
    return this.DefaultVisit(node, argument);
}

public virtual TResult VisitRule(RuleSyntax node, TArg argument)
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

public virtual TResult VisitAlternative(AlternativeSyntax node, TArg argument)
{
    return this.DefaultVisit(node, argument);
}

public virtual TResult VisitElement(ElementSyntax node, TArg argument)
{
    return this.DefaultVisit(node, argument);
}

public virtual TResult VisitBlock(BlockSyntax node, TArg argument)
{
    return this.DefaultVisit(node, argument);
}

public virtual TResult VisitEof1(Eof1Syntax node, TArg argument)
{
    return this.DefaultVisit(node, argument);
}

public virtual TResult VisitFixed(FixedSyntax node, TArg argument)
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

public virtual TResult VisitBlockAlternative(BlockAlternativeSyntax node, TArg argument)
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

public virtual TResult VisitLElementValueTokens(LElementValueTokensSyntax node, TArg argument)
{
    return this.DefaultVisit(node, argument);
}

public virtual TResult VisitLBlock(LBlockSyntax node, TArg argument)
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

public virtual TResult VisitAnnotationArgument(AnnotationArgumentSyntax node, TArg argument)
{
    return this.DefaultVisit(node, argument);
}

public virtual TResult VisitTypeReferenceIdentifierAlt1(TypeReferenceIdentifierAlt1Syntax node, TArg argument)
{
    return this.DefaultVisit(node, argument);
}

public virtual TResult VisitTypeReferenceIdentifierAlt2(TypeReferenceIdentifierAlt2Syntax node, TArg argument)
{
    return this.DefaultVisit(node, argument);
}

public virtual TResult VisitTypeReferenceAlt1(TypeReferenceAlt1Syntax node, TArg argument)
{
    return this.DefaultVisit(node, argument);
}

public virtual TResult VisitTypeReferenceAlt2(TypeReferenceAlt2Syntax node, TArg argument)
{
    return this.DefaultVisit(node, argument);
}

public virtual TResult VisitName(NameSyntax node, TArg argument)
{
    return this.DefaultVisit(node, argument);
}

public virtual TResult VisitIdentifier(IdentifierSyntax node, TArg argument)
{
    return this.DefaultVisit(node, argument);
}

public virtual TResult VisitMainBlock1(MainBlock1Syntax node, TArg argument)
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

public virtual TResult VisitRuleAlternativesBlock(RuleAlternativesBlockSyntax node, TArg argument)
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

public virtual TResult VisitBlockAlternativesBlock(BlockAlternativesBlockSyntax node, TArg argument)
{
    return this.DefaultVisit(node, argument);
}

public virtual TResult VisitBlockAlternativeBlock1(BlockAlternativeBlock1Syntax node, TArg argument)
{
    return this.DefaultVisit(node, argument);
}

public virtual TResult VisitRuleRefAlt3ReferencedTypesBlock(RuleRefAlt3ReferencedTypesBlockSyntax node, TArg argument)
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

public virtual TResult VisitTokenAlternativesBlock(TokenAlternativesBlockSyntax node, TArg argument)
{
    return this.DefaultVisit(node, argument);
}

public virtual TResult VisitFragmentAlternativesBlock(FragmentAlternativesBlockSyntax node, TArg argument)
{
    return this.DefaultVisit(node, argument);
}

public virtual TResult VisitLBlockAlternativesBlock(LBlockAlternativesBlockSyntax node, TArg argument)
{
    return this.DefaultVisit(node, argument);
}

public virtual TResult VisitTokens(TokensSyntax node, TArg argument)
{
    return this.DefaultVisit(node, argument);
}

public virtual TResult VisitSingleExpressionBlock1Alt2(SingleExpressionBlock1Alt2Syntax node, TArg argument)
{
    return this.DefaultVisit(node, argument);
}

public virtual TResult VisitSingleExpressionBlock1Alt3(SingleExpressionBlock1Alt3Syntax node, TArg argument)
{
    return this.DefaultVisit(node, argument);
}

public virtual TResult VisitParserAnnotationArgumentsBlock(ParserAnnotationArgumentsBlockSyntax node, TArg argument)
{
    return this.DefaultVisit(node, argument);
}

public virtual TResult VisitLexerAnnotationArgumentsBlock(LexerAnnotationArgumentsBlockSyntax node, TArg argument)
{
    return this.DefaultVisit(node, argument);
}

public virtual TResult VisitAnnotationArgumentBlock1(AnnotationArgumentBlock1Syntax node, TArg argument)
{
    return this.DefaultVisit(node, argument);
}

public virtual TResult VisitMainQualifierBlock(MainQualifierBlockSyntax node, TArg argument)
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

public virtual TResult VisitArrayExpressionItemsBlock(ArrayExpressionItemsBlockSyntax node, TArg argument)
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
    var qualifier = this.VisitList(node.Qualifier);
    var tSemicolon = this.VisitToken(node.TSemicolon);
    var usingList = this.VisitList(node.UsingList);
    var block = (MainBlock1Syntax)this.Visit(node.Block);
    var endOfFileToken = this.VisitToken(node.EndOfFileToken);
	return node.Update(kNamespace, qualifier, tSemicolon, usingList, block, endOfFileToken);
}

public virtual SyntaxNode VisitUsing(UsingSyntax node)
{
    var kUsing = this.VisitToken(node.KUsing);
    var qualifier = this.VisitList(node.Qualifier);
    var tSemicolon = this.VisitToken(node.TSemicolon);
	return node.Update(kUsing, qualifier, tSemicolon);
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
    var grammarRules = this.VisitList(node.GrammarRules);
	return node.Update(grammarRules);
}

public virtual SyntaxNode VisitRule(RuleSyntax node)
{
    var annotations1 = this.VisitList(node.Annotations1);
    var block = (RuleBlock1Syntax)this.Visit(node.Block);
    var tColon = this.VisitToken(node.TColon);
    var alternatives = this.VisitList(node.Alternatives);
    var tSemicolon = this.VisitToken(node.TSemicolon);
	return node.Update(annotations1, block, tColon, alternatives, tSemicolon);
}

public virtual SyntaxNode VisitToken(TokenSyntax node)
{
    var annotations1 = this.VisitList(node.Annotations1);
    var block = (TokenBlock1Syntax)this.Visit(node.Block);
    var tColon = this.VisitToken(node.TColon);
    var alternatives = this.VisitList(node.Alternatives);
    var tSemicolon = this.VisitToken(node.TSemicolon);
	return node.Update(annotations1, block, tColon, alternatives, tSemicolon);
}

public virtual SyntaxNode VisitFragment(FragmentSyntax node)
{
    var kFragment = this.VisitToken(node.KFragment);
    var name = (NameSyntax)this.Visit(node.Name);
    var tColon = this.VisitToken(node.TColon);
    var alternatives = this.VisitList(node.Alternatives);
    var tSemicolon = this.VisitToken(node.TSemicolon);
	return node.Update(kFragment, name, tColon, alternatives, tSemicolon);
}

public virtual SyntaxNode VisitAlternative(AlternativeSyntax node)
{
    var block1 = (AlternativeBlock1Syntax)this.Visit(node.Block1);
    var elements = this.VisitList(node.Elements);
    var block2 = (AlternativeBlock2Syntax)this.Visit(node.Block2);
	return node.Update(block1, elements, block2);
}

public virtual SyntaxNode VisitElement(ElementSyntax node)
{
    var block = (ElementBlock1Syntax)this.Visit(node.Block);
    var value = (ElementValueSyntax)this.Visit(node.Value);
    var multiplicity = this.VisitToken(node.Multiplicity);
	return node.Update(block, value, multiplicity);
}

public virtual SyntaxNode VisitBlock(BlockSyntax node)
{
    var annotations1 = this.VisitList(node.Annotations1);
    var tLParen = this.VisitToken(node.TLParen);
    var alternatives = this.VisitList(node.Alternatives);
    var tRParen = this.VisitToken(node.TRParen);
	return node.Update(annotations1, tLParen, alternatives, tRParen);
}

public virtual SyntaxNode VisitEof1(Eof1Syntax node)
{
    var kEof = this.VisitToken(node.KEof);
	return node.Update(kEof);
}

public virtual SyntaxNode VisitFixed(FixedSyntax node)
{
    var annotations1 = this.VisitList(node.Annotations1);
    var text = this.VisitToken(node.Text);
	return node.Update(annotations1, text);
}

public virtual SyntaxNode VisitRuleRefAlt1(RuleRefAlt1Syntax node)
{
    var annotations1 = this.VisitList(node.Annotations1);
    var grammarRule = (IdentifierSyntax)this.Visit(node.GrammarRule);
	return node.Update(annotations1, grammarRule);
}

public virtual SyntaxNode VisitRuleRefAlt2(RuleRefAlt2Syntax node)
{
    var annotations1 = this.VisitList(node.Annotations1);
    var tHash = this.VisitToken(node.THash);
    var referencedTypes = (TypeReferenceSyntax)this.Visit(node.ReferencedTypes);
	return node.Update(annotations1, tHash, referencedTypes);
}

public virtual SyntaxNode VisitRuleRefAlt3(RuleRefAlt3Syntax node)
{
    var annotations1 = this.VisitList(node.Annotations1);
    var tHashLBrace = this.VisitToken(node.THashLBrace);
    var referencedTypes = this.VisitList(node.ReferencedTypes);
    var block = (RuleRefAlt3Block1Syntax)this.Visit(node.Block);
    var tRBrace = this.VisitToken(node.TRBrace);
	return node.Update(annotations1, tHashLBrace, referencedTypes, block, tRBrace);
}

public virtual SyntaxNode VisitBlockAlternative(BlockAlternativeSyntax node)
{
    var elements = this.VisitList(node.Elements);
    var block = (BlockAlternativeBlock1Syntax)this.Visit(node.Block);
	return node.Update(elements, block);
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

public virtual SyntaxNode VisitLElementValueTokens(LElementValueTokensSyntax node)
{
    var token = this.VisitToken(node.Token);
	return node.Update(token);
}

public virtual SyntaxNode VisitLBlock(LBlockSyntax node)
{
    var tLParen = this.VisitToken(node.TLParen);
    var alternatives = this.VisitList(node.Alternatives);
    var tRParen = this.VisitToken(node.TRParen);
	return node.Update(tLParen, alternatives, tRParen);
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
    var items = this.VisitList(node.Items);
    var tRBrace = this.VisitToken(node.TRBrace);
	return node.Update(tLBrace, items, tRBrace);
}

public virtual SyntaxNode VisitSingleExpression(SingleExpressionSyntax node)
{
    var value = (SingleExpressionBlock1Syntax)this.Visit(node.Value);
	return node.Update(value);
}

public virtual SyntaxNode VisitParserAnnotation(ParserAnnotationSyntax node)
{
    var tLBracket = this.VisitToken(node.TLBracket);
    var qualifier = this.VisitList(node.Qualifier);
    var tLParen = this.VisitToken(node.TLParen);
    var arguments = this.VisitList(node.Arguments);
    var tRParen = this.VisitToken(node.TRParen);
    var tRBracket = this.VisitToken(node.TRBracket);
	return node.Update(tLBracket, qualifier, tLParen, arguments, tRParen, tRBracket);
}

public virtual SyntaxNode VisitLexerAnnotation(LexerAnnotationSyntax node)
{
    var tLBracket = this.VisitToken(node.TLBracket);
    var qualifier = this.VisitList(node.Qualifier);
    var tLParen = this.VisitToken(node.TLParen);
    var arguments = this.VisitList(node.Arguments);
    var tRParen = this.VisitToken(node.TRParen);
    var tRBracket = this.VisitToken(node.TRBracket);
	return node.Update(tLBracket, qualifier, tLParen, arguments, tRParen, tRBracket);
}

public virtual SyntaxNode VisitAnnotationArgument(AnnotationArgumentSyntax node)
{
    var block = (AnnotationArgumentBlock1Syntax)this.Visit(node.Block);
    var value = (ExpressionSyntax)this.Visit(node.Value);
	return node.Update(block, value);
}

public virtual SyntaxNode VisitTypeReferenceIdentifierAlt1(TypeReferenceIdentifierAlt1Syntax node)
{
    var tokens = this.VisitToken(node.Tokens);
	return node.Update(tokens);
}

public virtual SyntaxNode VisitTypeReferenceIdentifierAlt2(TypeReferenceIdentifierAlt2Syntax node)
{
    var identifier = (IdentifierSyntax)this.Visit(node.Identifier);
	return node.Update(identifier);
}

public virtual SyntaxNode VisitTypeReferenceAlt1(TypeReferenceAlt1Syntax node)
{
    var tokens = this.VisitToken(node.Tokens);
	return node.Update(tokens);
}

public virtual SyntaxNode VisitTypeReferenceAlt2(TypeReferenceAlt2Syntax node)
{
    var qualifier = this.VisitList(node.Qualifier);
	return node.Update(qualifier);
}

public virtual SyntaxNode VisitName(NameSyntax node)
{
    var identifier = (IdentifierSyntax)this.Visit(node.Identifier);
	return node.Update(identifier);
}

public virtual SyntaxNode VisitIdentifier(IdentifierSyntax node)
{
    var token = this.VisitToken(node.Token);
	return node.Update(token);
}

public virtual SyntaxNode VisitMainBlock1(MainBlock1Syntax node)
{
    var declarations = (LanguageDeclarationSyntax)this.Visit(node.Declarations);
	return node.Update(declarations);
}

public virtual SyntaxNode VisitRuleBlock1Alt1(RuleBlock1Alt1Syntax node)
{
    var returnType = (TypeReferenceIdentifierSyntax)this.Visit(node.ReturnType);
	return node.Update(returnType);
}

public virtual SyntaxNode VisitRuleBlock1Alt2(RuleBlock1Alt2Syntax node)
{
    var identifier = (IdentifierSyntax)this.Visit(node.Identifier);
    var kReturns = this.VisitToken(node.KReturns);
    var returnType = (TypeReferenceSyntax)this.Visit(node.ReturnType);
	return node.Update(identifier, kReturns, returnType);
}

public virtual SyntaxNode VisitRuleAlternativesBlock(RuleAlternativesBlockSyntax node)
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
    var block = (AlternativeBlock1Block1Syntax)this.Visit(node.Block);
    var tColon = this.VisitToken(node.TColon);
	return node.Update(annotations1, kAlt, name, block, tColon);
}

public virtual SyntaxNode VisitAlternativeBlock2(AlternativeBlock2Syntax node)
{
    var tEqGt = this.VisitToken(node.TEqGt);
    var returnValue = (ExpressionSyntax)this.Visit(node.ReturnValue);
	return node.Update(tEqGt, returnValue);
}

public virtual SyntaxNode VisitElementBlock1(ElementBlock1Syntax node)
{
    var annotations1 = this.VisitList(node.Annotations1);
    var name = (NameSyntax)this.Visit(node.Name);
    var assignment = this.VisitToken(node.Assignment);
	return node.Update(annotations1, name, assignment);
}

public virtual SyntaxNode VisitBlockAlternativesBlock(BlockAlternativesBlockSyntax node)
{
    var tBar = this.VisitToken(node.TBar);
    var alternatives = (BlockAlternativeSyntax)this.Visit(node.Alternatives);
	return node.Update(tBar, alternatives);
}

public virtual SyntaxNode VisitBlockAlternativeBlock1(BlockAlternativeBlock1Syntax node)
{
    var tEqGt = this.VisitToken(node.TEqGt);
    var returnValue = (ExpressionSyntax)this.Visit(node.ReturnValue);
	return node.Update(tEqGt, returnValue);
}

public virtual SyntaxNode VisitRuleRefAlt3ReferencedTypesBlock(RuleRefAlt3ReferencedTypesBlockSyntax node)
{
    var tComma = this.VisitToken(node.TComma);
    var referencedTypes = (TypeReferenceSyntax)this.Visit(node.ReferencedTypes);
	return node.Update(tComma, referencedTypes);
}

public virtual SyntaxNode VisitRuleRefAlt3Block1(RuleRefAlt3Block1Syntax node)
{
    var tBar = this.VisitToken(node.TBar);
    var grammarRule = (IdentifierSyntax)this.Visit(node.GrammarRule);
	return node.Update(tBar, grammarRule);
}

public virtual SyntaxNode VisitTokenBlock1Alt1(TokenBlock1Alt1Syntax node)
{
    var kToken = this.VisitToken(node.KToken);
    var name = (NameSyntax)this.Visit(node.Name);
    var block = (TokenBlock1Alt1Block1Syntax)this.Visit(node.Block);
	return node.Update(kToken, name, block);
}

public virtual SyntaxNode VisitTokenBlock1Alt2(TokenBlock1Alt2Syntax node)
{
    var isTrivia = this.VisitToken(node.IsTrivia);
    var name = (NameSyntax)this.Visit(node.Name);
	return node.Update(isTrivia, name);
}

public virtual SyntaxNode VisitTokenAlternativesBlock(TokenAlternativesBlockSyntax node)
{
    var tBar = this.VisitToken(node.TBar);
    var alternatives = (LAlternativeSyntax)this.Visit(node.Alternatives);
	return node.Update(tBar, alternatives);
}

public virtual SyntaxNode VisitFragmentAlternativesBlock(FragmentAlternativesBlockSyntax node)
{
    var tBar = this.VisitToken(node.TBar);
    var alternatives = (LAlternativeSyntax)this.Visit(node.Alternatives);
	return node.Update(tBar, alternatives);
}

public virtual SyntaxNode VisitLBlockAlternativesBlock(LBlockAlternativesBlockSyntax node)
{
    var tBar = this.VisitToken(node.TBar);
    var alternatives = (LAlternativeSyntax)this.Visit(node.Alternatives);
	return node.Update(tBar, alternatives);
}

public virtual SyntaxNode VisitTokens(TokensSyntax node)
{
    var token = this.VisitToken(node.Token);
	return node.Update(token);
}

public virtual SyntaxNode VisitSingleExpressionBlock1Alt2(SingleExpressionBlock1Alt2Syntax node)
{
    var tokens = this.VisitToken(node.Tokens);
	return node.Update(tokens);
}

public virtual SyntaxNode VisitSingleExpressionBlock1Alt3(SingleExpressionBlock1Alt3Syntax node)
{
    var qualifier = this.VisitList(node.Qualifier);
	return node.Update(qualifier);
}

public virtual SyntaxNode VisitParserAnnotationArgumentsBlock(ParserAnnotationArgumentsBlockSyntax node)
{
    var tComma = this.VisitToken(node.TComma);
    var arguments = (AnnotationArgumentSyntax)this.Visit(node.Arguments);
	return node.Update(tComma, arguments);
}

public virtual SyntaxNode VisitLexerAnnotationArgumentsBlock(LexerAnnotationArgumentsBlockSyntax node)
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

public virtual SyntaxNode VisitMainQualifierBlock(MainQualifierBlockSyntax node)
{
    var tDot = this.VisitToken(node.TDot);
    var identifier = (IdentifierSyntax)this.Visit(node.Identifier);
	return node.Update(tDot, identifier);
}

public virtual SyntaxNode VisitAlternativeBlock1Block1(AlternativeBlock1Block1Syntax node)
{
    var kReturns = this.VisitToken(node.KReturns);
    var returnType = (TypeReferenceSyntax)this.Visit(node.ReturnType);
	return node.Update(kReturns, returnType);
}

public virtual SyntaxNode VisitTokenBlock1Alt1Block1(TokenBlock1Alt1Block1Syntax node)
{
    var kReturns = this.VisitToken(node.KReturns);
    var returnType = (TypeReferenceSyntax)this.Visit(node.ReturnType);
	return node.Update(kReturns, returnType);
}

public virtual SyntaxNode VisitArrayExpressionItemsBlock(ArrayExpressionItemsBlockSyntax node)
{
    var tComma = this.VisitToken(node.TComma);
    var items = (SingleExpressionSyntax)this.Visit(node.Items);
	return node.Update(tComma, items);
}
		}
}
