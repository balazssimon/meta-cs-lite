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

namespace MetaDslx.Languages.MetaModel.Compiler.Syntax
{

	public interface IMetaSyntaxVisitor
	{
	    void VisitSkippedTokensTrivia(MetaSkippedTokensTriviaSyntax node);
		void VisitMain(MainSyntax node);
		void VisitUsing(UsingSyntax node);
		void VisitDeclarations(DeclarationsSyntax node);
		void VisitMetaModel(MetaModelSyntax node);
		void VisitMetaConstant(MetaConstantSyntax node);
		void VisitMetaEnumType(MetaEnumTypeSyntax node);
		void VisitMetaClass(MetaClassSyntax node);
		void VisitEnumBody(EnumBodySyntax node);
		void VisitEnumLiterals(EnumLiteralsSyntax node);
		void VisitMetaEnumLiteral(MetaEnumLiteralSyntax node);
		void VisitClassNameAlt1(ClassNameAlt1Syntax node);
		void VisitClassNameAlt2(ClassNameAlt2Syntax node);
		void VisitBaseClasses(BaseClassesSyntax node);
		void VisitClassBody(ClassBodySyntax node);
		void VisitMetaProperty(MetaPropertySyntax node);
		void VisitPropertyNameAlt1(PropertyNameAlt1Syntax node);
		void VisitPropertyNameAlt2(PropertyNameAlt2Syntax node);
		void VisitPropertyOpposite(PropertyOppositeSyntax node);
		void VisitMetaOperation(MetaOperationSyntax node);
		void VisitParameterList(ParameterListSyntax node);
		void VisitMetaParameter(MetaParameterSyntax node);
		void VisitMetaArrayType(MetaArrayTypeSyntax node);
		void VisitTypeReferenceAlt3(TypeReferenceAlt3Syntax node);
		void VisitTypeReferenceTokens(TypeReferenceTokensSyntax node);
		void VisitName(NameSyntax node);
		void VisitQualifier(QualifierSyntax node);
		void VisitQualifierList(QualifierListSyntax node);
		void VisitIdentifier(IdentifierSyntax node);
		void VisitEnumLiteralsBlock1(EnumLiteralsBlock1Syntax node);
		void VisitBaseClassesBlock1(BaseClassesBlock1Syntax node);
		void VisitParameterListBlock1(ParameterListBlock1Syntax node);
		void VisitQualifierBlock1(QualifierBlock1Syntax node);
		void VisitQualifierListBlock1(QualifierListBlock1Syntax node);
    }

	public class MetaSyntaxVisitor : SyntaxVisitor, IMetaSyntaxVisitor
	{
	    public virtual void VisitSkippedTokensTrivia(MetaSkippedTokensTriviaSyntax node)
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

		public virtual void VisitMetaModel(MetaModelSyntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitMetaConstant(MetaConstantSyntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitMetaEnumType(MetaEnumTypeSyntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitMetaClass(MetaClassSyntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitEnumBody(EnumBodySyntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitEnumLiterals(EnumLiteralsSyntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitMetaEnumLiteral(MetaEnumLiteralSyntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitClassNameAlt1(ClassNameAlt1Syntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitClassNameAlt2(ClassNameAlt2Syntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitBaseClasses(BaseClassesSyntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitClassBody(ClassBodySyntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitMetaProperty(MetaPropertySyntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitPropertyNameAlt1(PropertyNameAlt1Syntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitPropertyNameAlt2(PropertyNameAlt2Syntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitPropertyOpposite(PropertyOppositeSyntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitMetaOperation(MetaOperationSyntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitParameterList(ParameterListSyntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitMetaParameter(MetaParameterSyntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitMetaArrayType(MetaArrayTypeSyntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitTypeReferenceAlt3(TypeReferenceAlt3Syntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitTypeReferenceTokens(TypeReferenceTokensSyntax node)
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

		public virtual void VisitEnumLiteralsBlock1(EnumLiteralsBlock1Syntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitBaseClassesBlock1(BaseClassesBlock1Syntax node)
		{
		    this.DefaultVisit(node);
		}

		public virtual void VisitParameterListBlock1(ParameterListBlock1Syntax node)
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

	public interface IMetaSyntaxVisitor<TResult> 
	{
	    TResult VisitSkippedTokensTrivia(MetaSkippedTokensTriviaSyntax node);
		TResult VisitMain(MainSyntax node);
		TResult VisitUsing(UsingSyntax node);
		TResult VisitDeclarations(DeclarationsSyntax node);
		TResult VisitMetaModel(MetaModelSyntax node);
		TResult VisitMetaConstant(MetaConstantSyntax node);
		TResult VisitMetaEnumType(MetaEnumTypeSyntax node);
		TResult VisitMetaClass(MetaClassSyntax node);
		TResult VisitEnumBody(EnumBodySyntax node);
		TResult VisitEnumLiterals(EnumLiteralsSyntax node);
		TResult VisitMetaEnumLiteral(MetaEnumLiteralSyntax node);
		TResult VisitClassNameAlt1(ClassNameAlt1Syntax node);
		TResult VisitClassNameAlt2(ClassNameAlt2Syntax node);
		TResult VisitBaseClasses(BaseClassesSyntax node);
		TResult VisitClassBody(ClassBodySyntax node);
		TResult VisitMetaProperty(MetaPropertySyntax node);
		TResult VisitPropertyNameAlt1(PropertyNameAlt1Syntax node);
		TResult VisitPropertyNameAlt2(PropertyNameAlt2Syntax node);
		TResult VisitPropertyOpposite(PropertyOppositeSyntax node);
		TResult VisitMetaOperation(MetaOperationSyntax node);
		TResult VisitParameterList(ParameterListSyntax node);
		TResult VisitMetaParameter(MetaParameterSyntax node);
		TResult VisitMetaArrayType(MetaArrayTypeSyntax node);
		TResult VisitTypeReferenceAlt3(TypeReferenceAlt3Syntax node);
		TResult VisitTypeReferenceTokens(TypeReferenceTokensSyntax node);
		TResult VisitName(NameSyntax node);
		TResult VisitQualifier(QualifierSyntax node);
		TResult VisitQualifierList(QualifierListSyntax node);
		TResult VisitIdentifier(IdentifierSyntax node);
		TResult VisitEnumLiteralsBlock1(EnumLiteralsBlock1Syntax node);
		TResult VisitBaseClassesBlock1(BaseClassesBlock1Syntax node);
		TResult VisitParameterListBlock1(ParameterListBlock1Syntax node);
		TResult VisitQualifierBlock1(QualifierBlock1Syntax node);
		TResult VisitQualifierListBlock1(QualifierListBlock1Syntax node);
    }

	public class MetaSyntaxVisitor<TResult> : SyntaxVisitor<TResult>, IMetaSyntaxVisitor<TResult>
	{
	    public virtual TResult VisitSkippedTokensTrivia(MetaSkippedTokensTriviaSyntax node)
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

		public virtual TResult VisitMetaModel(MetaModelSyntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitMetaConstant(MetaConstantSyntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitMetaEnumType(MetaEnumTypeSyntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitMetaClass(MetaClassSyntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitEnumBody(EnumBodySyntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitEnumLiterals(EnumLiteralsSyntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitMetaEnumLiteral(MetaEnumLiteralSyntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitClassNameAlt1(ClassNameAlt1Syntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitClassNameAlt2(ClassNameAlt2Syntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitBaseClasses(BaseClassesSyntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitClassBody(ClassBodySyntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitMetaProperty(MetaPropertySyntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitPropertyNameAlt1(PropertyNameAlt1Syntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitPropertyNameAlt2(PropertyNameAlt2Syntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitPropertyOpposite(PropertyOppositeSyntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitMetaOperation(MetaOperationSyntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitParameterList(ParameterListSyntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitMetaParameter(MetaParameterSyntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitMetaArrayType(MetaArrayTypeSyntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitTypeReferenceAlt3(TypeReferenceAlt3Syntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitTypeReferenceTokens(TypeReferenceTokensSyntax node)
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

		public virtual TResult VisitEnumLiteralsBlock1(EnumLiteralsBlock1Syntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitBaseClassesBlock1(BaseClassesBlock1Syntax node)
		{
		    return this.DefaultVisit(node);
		}

		public virtual TResult VisitParameterListBlock1(ParameterListBlock1Syntax node)
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

	public interface IMetaSyntaxVisitor<TArg, TResult> 
	{
	    TResult VisitSkippedTokensTrivia(MetaSkippedTokensTriviaSyntax node, TArg argument);
		TResult VisitMain(MainSyntax node, TArg argument);
		TResult VisitUsing(UsingSyntax node, TArg argument);
		TResult VisitDeclarations(DeclarationsSyntax node, TArg argument);
		TResult VisitMetaModel(MetaModelSyntax node, TArg argument);
		TResult VisitMetaConstant(MetaConstantSyntax node, TArg argument);
		TResult VisitMetaEnumType(MetaEnumTypeSyntax node, TArg argument);
		TResult VisitMetaClass(MetaClassSyntax node, TArg argument);
		TResult VisitEnumBody(EnumBodySyntax node, TArg argument);
		TResult VisitEnumLiterals(EnumLiteralsSyntax node, TArg argument);
		TResult VisitMetaEnumLiteral(MetaEnumLiteralSyntax node, TArg argument);
		TResult VisitClassNameAlt1(ClassNameAlt1Syntax node, TArg argument);
		TResult VisitClassNameAlt2(ClassNameAlt2Syntax node, TArg argument);
		TResult VisitBaseClasses(BaseClassesSyntax node, TArg argument);
		TResult VisitClassBody(ClassBodySyntax node, TArg argument);
		TResult VisitMetaProperty(MetaPropertySyntax node, TArg argument);
		TResult VisitPropertyNameAlt1(PropertyNameAlt1Syntax node, TArg argument);
		TResult VisitPropertyNameAlt2(PropertyNameAlt2Syntax node, TArg argument);
		TResult VisitPropertyOpposite(PropertyOppositeSyntax node, TArg argument);
		TResult VisitMetaOperation(MetaOperationSyntax node, TArg argument);
		TResult VisitParameterList(ParameterListSyntax node, TArg argument);
		TResult VisitMetaParameter(MetaParameterSyntax node, TArg argument);
		TResult VisitMetaArrayType(MetaArrayTypeSyntax node, TArg argument);
		TResult VisitTypeReferenceAlt3(TypeReferenceAlt3Syntax node, TArg argument);
		TResult VisitTypeReferenceTokens(TypeReferenceTokensSyntax node, TArg argument);
		TResult VisitName(NameSyntax node, TArg argument);
		TResult VisitQualifier(QualifierSyntax node, TArg argument);
		TResult VisitQualifierList(QualifierListSyntax node, TArg argument);
		TResult VisitIdentifier(IdentifierSyntax node, TArg argument);
		TResult VisitEnumLiteralsBlock1(EnumLiteralsBlock1Syntax node, TArg argument);
		TResult VisitBaseClassesBlock1(BaseClassesBlock1Syntax node, TArg argument);
		TResult VisitParameterListBlock1(ParameterListBlock1Syntax node, TArg argument);
		TResult VisitQualifierBlock1(QualifierBlock1Syntax node, TArg argument);
		TResult VisitQualifierListBlock1(QualifierListBlock1Syntax node, TArg argument);
    }

	public class MetaSyntaxVisitor<TArg, TResult> : SyntaxVisitor<TArg, TResult>, IMetaSyntaxVisitor<TArg, TResult>
	{
	    public virtual TResult VisitSkippedTokensTrivia(MetaSkippedTokensTriviaSyntax node, TArg argument)
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

		public virtual TResult VisitMetaModel(MetaModelSyntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitMetaConstant(MetaConstantSyntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitMetaEnumType(MetaEnumTypeSyntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitMetaClass(MetaClassSyntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitEnumBody(EnumBodySyntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitEnumLiterals(EnumLiteralsSyntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitMetaEnumLiteral(MetaEnumLiteralSyntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitClassNameAlt1(ClassNameAlt1Syntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitClassNameAlt2(ClassNameAlt2Syntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitBaseClasses(BaseClassesSyntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitClassBody(ClassBodySyntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitMetaProperty(MetaPropertySyntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitPropertyNameAlt1(PropertyNameAlt1Syntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitPropertyNameAlt2(PropertyNameAlt2Syntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitPropertyOpposite(PropertyOppositeSyntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitMetaOperation(MetaOperationSyntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitParameterList(ParameterListSyntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitMetaParameter(MetaParameterSyntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitMetaArrayType(MetaArrayTypeSyntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitTypeReferenceAlt3(TypeReferenceAlt3Syntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitTypeReferenceTokens(TypeReferenceTokensSyntax node, TArg argument)
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

		public virtual TResult VisitEnumLiteralsBlock1(EnumLiteralsBlock1Syntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitBaseClassesBlock1(BaseClassesBlock1Syntax node, TArg argument)
		{
		    return this.DefaultVisit(node, argument);
		}

		public virtual TResult VisitParameterListBlock1(ParameterListBlock1Syntax node, TArg argument)
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

	public class MetaSyntaxRewriter : SyntaxRewriter, IMetaSyntaxVisitor<SyntaxNode?>
	{
	    public MetaSyntaxRewriter(bool visitIntoStructuredTrivia = false)
			: base(MetaLanguage.Instance, visitIntoStructuredTrivia)
	    {
	    }
	
	    public virtual SyntaxNode VisitSkippedTokensTrivia(MetaSkippedTokensTriviaSyntax node)
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
            var declarations = this.VisitList(node.Declarations);
        	    
        	return node.Update(declarations);
        }

        public virtual SyntaxNode VisitMetaModel(MetaModelSyntax node)
        {
            var kMetamodel = this.VisitToken(node.KMetamodel);
            var name = (NameSyntax)this.Visit(node.Name);
            var tSemicolon = this.VisitToken(node.TSemicolon);
        	    
        	return node.Update(kMetamodel, name, tSemicolon);
        }

        public virtual SyntaxNode VisitMetaConstant(MetaConstantSyntax node)
        {
            var kConst = this.VisitToken(node.KConst);
            var type = (TypeReferenceSyntax)this.Visit(node.Type);
            var name = (NameSyntax)this.Visit(node.Name);
            var tSemicolon = this.VisitToken(node.TSemicolon);
        	    
        	return node.Update(kConst, type, name, tSemicolon);
        }

        public virtual SyntaxNode VisitMetaEnumType(MetaEnumTypeSyntax node)
        {
            var kEnum = this.VisitToken(node.KEnum);
            var name = (NameSyntax)this.Visit(node.Name);
            var enumBody = (EnumBodySyntax)this.Visit(node.EnumBody);
        	    
        	return node.Update(kEnum, name, enumBody);
        }

        public virtual SyntaxNode VisitMetaClass(MetaClassSyntax node)
        {
            var isAbstract = this.VisitToken(node.IsAbstract);
            var kClass = this.VisitToken(node.KClass);
            var name = (ClassNameSyntax)this.Visit(node.Name);
            var baseClasses = (BaseClassesSyntax)this.Visit(node.BaseClasses);
            var classBody = (ClassBodySyntax)this.Visit(node.ClassBody);
        	    
        	return node.Update(isAbstract, kClass, name, baseClasses, classBody);
        }

        public virtual SyntaxNode VisitEnumBody(EnumBodySyntax node)
        {
            var tLBrace = this.VisitToken(node.TLBrace);
            var enumLiterals = (EnumLiteralsSyntax)this.Visit(node.EnumLiterals);
            var tRBrace = this.VisitToken(node.TRBrace);
        	    
        	return node.Update(tLBrace, enumLiterals, tRBrace);
        }

        public virtual SyntaxNode VisitEnumLiterals(EnumLiteralsSyntax node)
        {
            var metaEnumLiteralList = this.VisitList(node.MetaEnumLiteralList);
        	    
        	return node.Update(metaEnumLiteralList);
        }

        public virtual SyntaxNode VisitMetaEnumLiteral(MetaEnumLiteralSyntax node)
        {
            var name = (NameSyntax)this.Visit(node.Name);
        	    
        	return node.Update(name);
        }

        public virtual SyntaxNode VisitClassNameAlt1(ClassNameAlt1Syntax node)
        {
            var tIdentifier = this.VisitToken(node.TIdentifier);
            var tDollar = this.VisitToken(node.TDollar);
            var symbolType = (IdentifierSyntax)this.Visit(node.SymbolType);
        	    
        	return node.Update(tIdentifier, tDollar, symbolType);
        }

        public virtual SyntaxNode VisitClassNameAlt2(ClassNameAlt2Syntax node)
        {
            var tIdentifier = this.VisitToken(node.TIdentifier);
        	    
        	return node.Update(tIdentifier);
        }

        public virtual SyntaxNode VisitBaseClasses(BaseClassesSyntax node)
        {
            var baseClassesBlock1 = (BaseClassesBlock1Syntax)this.Visit(node.BaseClassesBlock1);
        	    
        	return node.Update(baseClassesBlock1);
        }

        public virtual SyntaxNode VisitClassBody(ClassBodySyntax node)
        {
            var tLBrace = this.VisitToken(node.TLBrace);
            var properties = this.VisitList(node.Properties);
            var tRBrace = this.VisitToken(node.TRBrace);
        	    
        	return node.Update(tLBrace, properties, tRBrace);
        }

        public virtual SyntaxNode VisitMetaProperty(MetaPropertySyntax node)
        {
            var element = this.VisitToken(node.Element);
            var type = (TypeReferenceSyntax)this.Visit(node.Type);
            var name = (PropertyNameSyntax)this.Visit(node.Name);
            var propertyOpposite = (PropertyOppositeSyntax)this.Visit(node.PropertyOpposite);
            var tSemicolon = this.VisitToken(node.TSemicolon);
        	    
        	return node.Update(element, type, name, propertyOpposite, tSemicolon);
        }

        public virtual SyntaxNode VisitPropertyNameAlt1(PropertyNameAlt1Syntax node)
        {
            var tIdentifier = this.VisitToken(node.TIdentifier);
            var tDollar = this.VisitToken(node.TDollar);
            var symbolProperty = this.VisitToken(node.SymbolProperty);
        	    
        	return node.Update(tIdentifier, tDollar, symbolProperty);
        }

        public virtual SyntaxNode VisitPropertyNameAlt2(PropertyNameAlt2Syntax node)
        {
            var tIdentifier = this.VisitToken(node.TIdentifier);
        	    
        	return node.Update(tIdentifier);
        }

        public virtual SyntaxNode VisitPropertyOpposite(PropertyOppositeSyntax node)
        {
            var kOpposite = this.VisitToken(node.KOpposite);
            var opposite = (QualifierSyntax)this.Visit(node.Opposite);
        	    
        	return node.Update(kOpposite, opposite);
        }

        public virtual SyntaxNode VisitMetaOperation(MetaOperationSyntax node)
        {
            var returnType = (TypeReferenceSyntax)this.Visit(node.ReturnType);
            var name = (NameSyntax)this.Visit(node.Name);
            var tLParen = this.VisitToken(node.TLParen);
            var parameterList = (ParameterListSyntax)this.Visit(node.ParameterList);
            var tRParen = this.VisitToken(node.TRParen);
        	    
        	return node.Update(returnType, name, tLParen, parameterList, tRParen);
        }

        public virtual SyntaxNode VisitParameterList(ParameterListSyntax node)
        {
            var metaParameterList = this.VisitList(node.MetaParameterList);
        	    
        	return node.Update(metaParameterList);
        }

        public virtual SyntaxNode VisitMetaParameter(MetaParameterSyntax node)
        {
            var type = (TypeReferenceSyntax)this.Visit(node.Type);
            var name = (NameSyntax)this.Visit(node.Name);
        	    
        	return node.Update(type, name);
        }

        public virtual SyntaxNode VisitMetaArrayType(MetaArrayTypeSyntax node)
        {
            var itemType = (TypeReferenceSyntax)this.Visit(node.ItemType);
            var tLBracket = this.VisitToken(node.TLBracket);
            var tRBracket = this.VisitToken(node.TRBracket);
        	    
        	return node.Update(itemType, tLBracket, tRBracket);
        }

        public virtual SyntaxNode VisitTypeReferenceAlt3(TypeReferenceAlt3Syntax node)
        {
            var qualifier = (QualifierSyntax)this.Visit(node.Qualifier);
        	    
        	return node.Update(qualifier);
        }

        public virtual SyntaxNode VisitTypeReferenceTokens(TypeReferenceTokensSyntax node)
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

        public virtual SyntaxNode VisitEnumLiteralsBlock1(EnumLiteralsBlock1Syntax node)
        {
            var tComma = this.VisitToken(node.TComma);
            var literals = (MetaEnumLiteralSyntax)this.Visit(node.Literals);
        	    
        	return node.Update(tComma, literals);
        }

        public virtual SyntaxNode VisitBaseClassesBlock1(BaseClassesBlock1Syntax node)
        {
            var tColon = this.VisitToken(node.TColon);
            var baseTypes = (QualifierListSyntax)this.Visit(node.BaseTypes);
        	    
        	return node.Update(tColon, baseTypes);
        }

        public virtual SyntaxNode VisitParameterListBlock1(ParameterListBlock1Syntax node)
        {
            var tComma = this.VisitToken(node.TComma);
            var parameters = (MetaParameterSyntax)this.Visit(node.Parameters);
        	    
        	return node.Update(tComma, parameters);
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
