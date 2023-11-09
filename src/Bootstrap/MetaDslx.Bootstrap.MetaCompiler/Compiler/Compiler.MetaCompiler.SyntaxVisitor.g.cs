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
		void VisitParserRule(ParserRuleSyntax node);
		void VisitBlockRule(BlockRuleSyntax node);
		void VisitParserRuleAlternative(ParserRuleAlternativeSyntax node);
		void VisitParserRuleElement(ParserRuleElementSyntax node);
		void VisitIntExpression(IntExpressionSyntax node);
		void VisitStringExpression(StringExpressionSyntax node);
		void VisitReferenceExpression(ReferenceExpressionSyntax node);
		void VisitExpressionTokens(ExpressionTokensSyntax node);
		void VisitName(NameSyntax node);
		void VisitQualifier(QualifierSyntax node);
		void VisitQualifierList(QualifierListSyntax node);
		void VisitIdentifier(IdentifierSyntax node);
		void VisitUsingBlock1Alt1(UsingBlock1Alt1Syntax node);
		void VisitUsingBlock1Alt2(UsingBlock1Alt2Syntax node);
		void VisitParserRuleBlock1(ParserRuleBlock1Syntax node);
		void VisitParserRuleBlock2(ParserRuleBlock2Syntax node);
		void VisitBlockRuleBlock1(BlockRuleBlock1Syntax node);
		void VisitParserRuleAlternativeBlock1(ParserRuleAlternativeBlock1Syntax node);
		void VisitParserRuleAlternativeBlock2(ParserRuleAlternativeBlock2Syntax node);
		void VisitQualifierBlock1(QualifierBlock1Syntax node);
		void VisitQualifierListBlock1(QualifierListBlock1Syntax node);
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

		public virtual void VisitParserRule(ParserRuleSyntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitBlockRule(BlockRuleSyntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitParserRuleAlternative(ParserRuleAlternativeSyntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitParserRuleElement(ParserRuleElementSyntax node)
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

		public virtual void VisitExpressionTokens(ExpressionTokensSyntax node)
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

		public virtual void VisitIdentifier(IdentifierSyntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitUsingBlock1Alt1(UsingBlock1Alt1Syntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitUsingBlock1Alt2(UsingBlock1Alt2Syntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitParserRuleBlock1(ParserRuleBlock1Syntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitParserRuleBlock2(ParserRuleBlock2Syntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitBlockRuleBlock1(BlockRuleBlock1Syntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitParserRuleAlternativeBlock1(ParserRuleAlternativeBlock1Syntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitParserRuleAlternativeBlock2(ParserRuleAlternativeBlock2Syntax node)
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
    }

	public interface ICompilerSyntaxVisitor<TResult> 
	{
	    TResult VisitSkippedTokensTrivia(CompilerSkippedTokensTriviaSyntax node);
		TResult VisitMain(MainSyntax node);
		TResult VisitUsing(UsingSyntax node);
		TResult VisitDeclarations(DeclarationsSyntax node);
		TResult VisitLanguageDeclaration(LanguageDeclarationSyntax node);
		TResult VisitParserRule(ParserRuleSyntax node);
		TResult VisitBlockRule(BlockRuleSyntax node);
		TResult VisitParserRuleAlternative(ParserRuleAlternativeSyntax node);
		TResult VisitParserRuleElement(ParserRuleElementSyntax node);
		TResult VisitIntExpression(IntExpressionSyntax node);
		TResult VisitStringExpression(StringExpressionSyntax node);
		TResult VisitReferenceExpression(ReferenceExpressionSyntax node);
		TResult VisitExpressionTokens(ExpressionTokensSyntax node);
		TResult VisitName(NameSyntax node);
		TResult VisitQualifier(QualifierSyntax node);
		TResult VisitQualifierList(QualifierListSyntax node);
		TResult VisitIdentifier(IdentifierSyntax node);
		TResult VisitUsingBlock1Alt1(UsingBlock1Alt1Syntax node);
		TResult VisitUsingBlock1Alt2(UsingBlock1Alt2Syntax node);
		TResult VisitParserRuleBlock1(ParserRuleBlock1Syntax node);
		TResult VisitParserRuleBlock2(ParserRuleBlock2Syntax node);
		TResult VisitBlockRuleBlock1(BlockRuleBlock1Syntax node);
		TResult VisitParserRuleAlternativeBlock1(ParserRuleAlternativeBlock1Syntax node);
		TResult VisitParserRuleAlternativeBlock2(ParserRuleAlternativeBlock2Syntax node);
		TResult VisitQualifierBlock1(QualifierBlock1Syntax node);
		TResult VisitQualifierListBlock1(QualifierListBlock1Syntax node);
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

		public virtual TResult VisitParserRule(ParserRuleSyntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitBlockRule(BlockRuleSyntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitParserRuleAlternative(ParserRuleAlternativeSyntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitParserRuleElement(ParserRuleElementSyntax node)
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

		public virtual TResult VisitExpressionTokens(ExpressionTokensSyntax node)
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

		public virtual TResult VisitIdentifier(IdentifierSyntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitUsingBlock1Alt1(UsingBlock1Alt1Syntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitUsingBlock1Alt2(UsingBlock1Alt2Syntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitParserRuleBlock1(ParserRuleBlock1Syntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitParserRuleBlock2(ParserRuleBlock2Syntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitBlockRuleBlock1(BlockRuleBlock1Syntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitParserRuleAlternativeBlock1(ParserRuleAlternativeBlock1Syntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitParserRuleAlternativeBlock2(ParserRuleAlternativeBlock2Syntax node)
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
    }

	public interface ICompilerSyntaxVisitor<TArg, TResult> 
	{
	    TResult VisitSkippedTokensTrivia(CompilerSkippedTokensTriviaSyntax node, TArg argument);
		TResult VisitMain(MainSyntax node, TArg argument);
		TResult VisitUsing(UsingSyntax node, TArg argument);
		TResult VisitDeclarations(DeclarationsSyntax node, TArg argument);
		TResult VisitLanguageDeclaration(LanguageDeclarationSyntax node, TArg argument);
		TResult VisitParserRule(ParserRuleSyntax node, TArg argument);
		TResult VisitBlockRule(BlockRuleSyntax node, TArg argument);
		TResult VisitParserRuleAlternative(ParserRuleAlternativeSyntax node, TArg argument);
		TResult VisitParserRuleElement(ParserRuleElementSyntax node, TArg argument);
		TResult VisitIntExpression(IntExpressionSyntax node, TArg argument);
		TResult VisitStringExpression(StringExpressionSyntax node, TArg argument);
		TResult VisitReferenceExpression(ReferenceExpressionSyntax node, TArg argument);
		TResult VisitExpressionTokens(ExpressionTokensSyntax node, TArg argument);
		TResult VisitName(NameSyntax node, TArg argument);
		TResult VisitQualifier(QualifierSyntax node, TArg argument);
		TResult VisitQualifierList(QualifierListSyntax node, TArg argument);
		TResult VisitIdentifier(IdentifierSyntax node, TArg argument);
		TResult VisitUsingBlock1Alt1(UsingBlock1Alt1Syntax node, TArg argument);
		TResult VisitUsingBlock1Alt2(UsingBlock1Alt2Syntax node, TArg argument);
		TResult VisitParserRuleBlock1(ParserRuleBlock1Syntax node, TArg argument);
		TResult VisitParserRuleBlock2(ParserRuleBlock2Syntax node, TArg argument);
		TResult VisitBlockRuleBlock1(BlockRuleBlock1Syntax node, TArg argument);
		TResult VisitParserRuleAlternativeBlock1(ParserRuleAlternativeBlock1Syntax node, TArg argument);
		TResult VisitParserRuleAlternativeBlock2(ParserRuleAlternativeBlock2Syntax node, TArg argument);
		TResult VisitQualifierBlock1(QualifierBlock1Syntax node, TArg argument);
		TResult VisitQualifierListBlock1(QualifierListBlock1Syntax node, TArg argument);
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

		public virtual TResult VisitParserRule(ParserRuleSyntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitBlockRule(BlockRuleSyntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitParserRuleAlternative(ParserRuleAlternativeSyntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitParserRuleElement(ParserRuleElementSyntax node, TArg argument)
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

		public virtual TResult VisitExpressionTokens(ExpressionTokensSyntax node, TArg argument)
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

		public virtual TResult VisitIdentifier(IdentifierSyntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitUsingBlock1Alt1(UsingBlock1Alt1Syntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitUsingBlock1Alt2(UsingBlock1Alt2Syntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitParserRuleBlock1(ParserRuleBlock1Syntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitParserRuleBlock2(ParserRuleBlock2Syntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitBlockRuleBlock1(BlockRuleBlock1Syntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitParserRuleAlternativeBlock1(ParserRuleAlternativeBlock1Syntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitParserRuleAlternativeBlock2(ParserRuleAlternativeBlock2Syntax node, TArg argument)
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
            var qualifier = (QualifierSyntax)this.Visit(node.Qualifier);
            var tSemicolon = this.VisitToken(node.TSemicolon);
            var @using = this.VisitList(node.Using);
            var declarations = (DeclarationsSyntax)this.Visit(node.Declarations);
            var eof = this.VisitToken(node.EndOfFileToken);
        	    
        	return node.Update(kNamespace, qualifier, tSemicolon, @using, declarations, eof);
        }

        public virtual SyntaxNode VisitUsing(UsingSyntax node)
        {
            var kUsing = this.VisitToken(node.KUsing);
            var usingBlock1 = (UsingBlock1Syntax)this.Visit(node.UsingBlock1);
            var tSemicolon = this.VisitToken(node.TSemicolon);
        	    
        	return node.Update(kUsing, usingBlock1, tSemicolon);
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
        	    
        	return node.Update(kLanguage, name, tSemicolon);
        }

        public virtual SyntaxNode VisitParserRule(ParserRuleSyntax node)
        {
            var name = (NameSyntax)this.Visit(node.Name);
            var parserRuleBlock1 = (ParserRuleBlock1Syntax)this.Visit(node.ParserRuleBlock1);
            var tColon = this.VisitToken(node.TColon);
            var parserRuleAlternativeList = this.VisitList(node.ParserRuleAlternativeList);
            var tSemicolon = this.VisitToken(node.TSemicolon);
        	    
        	return node.Update(name, parserRuleBlock1, tColon, parserRuleAlternativeList, tSemicolon);
        }

        public virtual SyntaxNode VisitBlockRule(BlockRuleSyntax node)
        {
            var isBlock = this.VisitToken(node.IsBlock);
            var name = (NameSyntax)this.Visit(node.Name);
            var tColon = this.VisitToken(node.TColon);
            var parserRuleAlternativeList = this.VisitList(node.ParserRuleAlternativeList);
            var tSemicolon = this.VisitToken(node.TSemicolon);
        	    
        	return node.Update(isBlock, name, tColon, parserRuleAlternativeList, tSemicolon);
        }

        public virtual SyntaxNode VisitParserRuleAlternative(ParserRuleAlternativeSyntax node)
        {
            var parserRuleAlternativeBlock1 = (ParserRuleAlternativeBlock1Syntax)this.Visit(node.ParserRuleAlternativeBlock1);
            var elements = this.VisitList(node.Elements);
            var parserRuleAlternativeBlock2 = (ParserRuleAlternativeBlock2Syntax)this.Visit(node.ParserRuleAlternativeBlock2);
        	    
        	return node.Update(parserRuleAlternativeBlock1, elements, parserRuleAlternativeBlock2);
        }

        public virtual SyntaxNode VisitParserRuleElement(ParserRuleElementSyntax node)
        {
            var name = (NameSyntax)this.Visit(node.Name);
        	    
        	return node.Update(name);
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
            var qualifier = (QualifierSyntax)this.Visit(node.Qualifier);
        	    
        	return node.Update(qualifier);
        }

        public virtual SyntaxNode VisitExpressionTokens(ExpressionTokensSyntax node)
        {
            var tokens = this.VisitToken(node.Tokens);
        	    
        	return node.Update(tokens);
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

        public virtual SyntaxNode VisitIdentifier(IdentifierSyntax node)
        {
            var tIdentifier = this.VisitToken(node.TIdentifier);
        	    
        	return node.Update(tIdentifier);
        }

        public virtual SyntaxNode VisitUsingBlock1Alt1(UsingBlock1Alt1Syntax node)
        {
            var namespaces = (QualifierSyntax)this.Visit(node.Namespaces);
        	    
        	return node.Update(namespaces);
        }

        public virtual SyntaxNode VisitUsingBlock1Alt2(UsingBlock1Alt2Syntax node)
        {
            var kMetamodel = this.VisitToken(node.KMetamodel);
            var metaModels = (QualifierSyntax)this.Visit(node.MetaModels);
        	    
        	return node.Update(kMetamodel, metaModels);
        }

        public virtual SyntaxNode VisitParserRuleBlock1(ParserRuleBlock1Syntax node)
        {
            var kReturns = this.VisitToken(node.KReturns);
            var returnType = (QualifierSyntax)this.Visit(node.ReturnType);
        	    
        	return node.Update(kReturns, returnType);
        }

        public virtual SyntaxNode VisitParserRuleBlock2(ParserRuleBlock2Syntax node)
        {
            var tBar = this.VisitToken(node.TBar);
            var alternatives = (ParserRuleAlternativeSyntax)this.Visit(node.Alternatives);
        	    
        	return node.Update(tBar, alternatives);
        }

        public virtual SyntaxNode VisitBlockRuleBlock1(BlockRuleBlock1Syntax node)
        {
            var tBar = this.VisitToken(node.TBar);
            var alternatives = (ParserRuleAlternativeSyntax)this.Visit(node.Alternatives);
        	    
        	return node.Update(tBar, alternatives);
        }

        public virtual SyntaxNode VisitParserRuleAlternativeBlock1(ParserRuleAlternativeBlock1Syntax node)
        {
            var tLBrace = this.VisitToken(node.TLBrace);
            var returnType = (QualifierSyntax)this.Visit(node.ReturnType);
            var tRBrace = this.VisitToken(node.TRBrace);
        	    
        	return node.Update(tLBrace, returnType, tRBrace);
        }

        public virtual SyntaxNode VisitParserRuleAlternativeBlock2(ParserRuleAlternativeBlock2Syntax node)
        {
            var tEqGt = this.VisitToken(node.TEqGt);
            var returnValue = (ExpressionSyntax)this.Visit(node.ReturnValue);
        	    
        	return node.Update(tEqGt, returnValue);
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
				
    }
}
