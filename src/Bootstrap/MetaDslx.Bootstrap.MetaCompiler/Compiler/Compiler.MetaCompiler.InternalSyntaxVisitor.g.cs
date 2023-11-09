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
		public virtual void VisitParserRuleGreen(ParserRuleGreen node) => this.DefaultVisit(node);
		public virtual void VisitBlockRuleGreen(BlockRuleGreen node) => this.DefaultVisit(node);
		public virtual void VisitParserRuleAlternativeGreen(ParserRuleAlternativeGreen node) => this.DefaultVisit(node);
		public virtual void VisitParserRuleElementGreen(ParserRuleElementGreen node) => this.DefaultVisit(node);
		public virtual void VisitIntExpressionGreen(IntExpressionGreen node) => this.DefaultVisit(node);
		public virtual void VisitStringExpressionGreen(StringExpressionGreen node) => this.DefaultVisit(node);
		public virtual void VisitReferenceExpressionGreen(ReferenceExpressionGreen node) => this.DefaultVisit(node);
		public virtual void VisitExpressionTokensGreen(ExpressionTokensGreen node) => this.DefaultVisit(node);
		public virtual void VisitNameGreen(NameGreen node) => this.DefaultVisit(node);
		public virtual void VisitQualifierGreen(QualifierGreen node) => this.DefaultVisit(node);
		public virtual void VisitQualifierListGreen(QualifierListGreen node) => this.DefaultVisit(node);
		public virtual void VisitIdentifierGreen(IdentifierGreen node) => this.DefaultVisit(node);
		public virtual void VisitParserRuleBlock1Green(ParserRuleBlock1Green node) => this.DefaultVisit(node);
		public virtual void VisitParserRuleBlock2Green(ParserRuleBlock2Green node) => this.DefaultVisit(node);
		public virtual void VisitBlockRuleBlock1Green(BlockRuleBlock1Green node) => this.DefaultVisit(node);
		public virtual void VisitParserRuleAlternativeBlock1Green(ParserRuleAlternativeBlock1Green node) => this.DefaultVisit(node);
		public virtual void VisitParserRuleAlternativeBlock2Green(ParserRuleAlternativeBlock2Green node) => this.DefaultVisit(node);
		public virtual void VisitQualifierBlock1Green(QualifierBlock1Green node) => this.DefaultVisit(node);
		public virtual void VisitQualifierListBlock1Green(QualifierListBlock1Green node) => this.DefaultVisit(node);
	}

	internal class CompilerInternalSyntaxVisitor<TResult> : InternalSyntaxVisitor<TResult>
	{
		public virtual TResult VisitSkippedTokensTrivia(GreenSkippedTokensTriviaSyntax node) => this.DefaultVisit(node);
		public virtual TResult VisitMainGreen(MainGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitUsingGreen(UsingGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitDeclarationsGreen(DeclarationsGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitLanguageDeclarationGreen(LanguageDeclarationGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitParserRuleGreen(ParserRuleGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitBlockRuleGreen(BlockRuleGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitParserRuleAlternativeGreen(ParserRuleAlternativeGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitParserRuleElementGreen(ParserRuleElementGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitIntExpressionGreen(IntExpressionGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitStringExpressionGreen(StringExpressionGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitReferenceExpressionGreen(ReferenceExpressionGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitExpressionTokensGreen(ExpressionTokensGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitNameGreen(NameGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitQualifierGreen(QualifierGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitQualifierListGreen(QualifierListGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitIdentifierGreen(IdentifierGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitParserRuleBlock1Green(ParserRuleBlock1Green node) => this.DefaultVisit(node);
		public virtual TResult VisitParserRuleBlock2Green(ParserRuleBlock2Green node) => this.DefaultVisit(node);
		public virtual TResult VisitBlockRuleBlock1Green(BlockRuleBlock1Green node) => this.DefaultVisit(node);
		public virtual TResult VisitParserRuleAlternativeBlock1Green(ParserRuleAlternativeBlock1Green node) => this.DefaultVisit(node);
		public virtual TResult VisitParserRuleAlternativeBlock2Green(ParserRuleAlternativeBlock2Green node) => this.DefaultVisit(node);
		public virtual TResult VisitQualifierBlock1Green(QualifierBlock1Green node) => this.DefaultVisit(node);
		public virtual TResult VisitQualifierListBlock1Green(QualifierListBlock1Green node) => this.DefaultVisit(node);
	}
}
