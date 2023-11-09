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
		void VisitName(NameSyntax node);
		void VisitQualifier(QualifierSyntax node);
		void VisitQualifierList(QualifierListSyntax node);
		void VisitIdentifier(IdentifierSyntax node);
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
		TResult VisitName(NameSyntax node);
		TResult VisitQualifier(QualifierSyntax node);
		TResult VisitQualifierList(QualifierListSyntax node);
		TResult VisitIdentifier(IdentifierSyntax node);
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
		TResult VisitName(NameSyntax node, TArg argument);
		TResult VisitQualifier(QualifierSyntax node, TArg argument);
		TResult VisitQualifierList(QualifierListSyntax node, TArg argument);
		TResult VisitIdentifier(IdentifierSyntax node, TArg argument);
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
            var name = (QualifierSyntax)this.Visit(node.Name);
            var tSemicolon = this.VisitToken(node.TSemicolon);
            var @using = this.VisitList(node.Using);
            var eof = this.VisitToken(node.EndOfFileToken);
        	    
        	return node.Update(kNamespace, name, tSemicolon, @using, eof);
        }

        public virtual SyntaxNode VisitUsing(UsingSyntax node)
        {
            var kUsing = this.VisitToken(node.KUsing);
            var namespaces = (QualifierSyntax)this.Visit(node.Namespaces);
            var tSemicolon = this.VisitToken(node.TSemicolon);
        	    
        	return node.Update(kUsing, namespaces, tSemicolon);
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
