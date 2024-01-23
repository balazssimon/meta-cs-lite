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
		void VisitMetaEnum(MetaEnumSyntax node);
		void VisitMetaClass(MetaClassSyntax node);
		void VisitEnumBody(EnumBodySyntax node);
		void VisitMetaEnumLiteral(MetaEnumLiteralSyntax node);
		void VisitClassNameAlt1(ClassNameAlt1Syntax node);
		void VisitClassNameAlt2(ClassNameAlt2Syntax node);
		void VisitBaseClasses(BaseClassesSyntax node);
		void VisitClassBody(ClassBodySyntax node);
		void VisitClassMemberAlt1(ClassMemberAlt1Syntax node);
		void VisitClassMemberAlt2(ClassMemberAlt2Syntax node);
		void VisitMetaProperty(MetaPropertySyntax node);
		void VisitPropertyNameAlt1(PropertyNameAlt1Syntax node);
		void VisitPropertyNameAlt2(PropertyNameAlt2Syntax node);
		void VisitMetaOperation(MetaOperationSyntax node);
		void VisitMetaParameter(MetaParameterSyntax node);
		void VisitTypeReferenceTokens(TypeReferenceTokensSyntax node);
		void VisitSimpleTypeReferenceAlt2(SimpleTypeReferenceAlt2Syntax node);
		void VisitMetaArrayType(MetaArrayTypeSyntax node);
		void VisitMetaNullableType(MetaNullableTypeSyntax node);
		void VisitName(NameSyntax node);
		void VisitQualifier(QualifierSyntax node);
		void VisitIdentifier(IdentifierSyntax node);
		void VisitEnumBodyEnumLiteralsBlock(EnumBodyEnumLiteralsBlockSyntax node);
		void VisitBaseClassesBaseTypesBlock(BaseClassesBaseTypesBlockSyntax node);
		void VisitPropertyOpposite(PropertyOppositeSyntax node);
		void VisitPropertySubsets(PropertySubsetsSyntax node);
		void VisitPropertyRedefines(PropertyRedefinesSyntax node);
		void VisitPropertyOppositeOppositePropertiesBlock(PropertyOppositeOppositePropertiesBlockSyntax node);
		void VisitPropertySubsetsSubsettedPropertiesBlock(PropertySubsetsSubsettedPropertiesBlockSyntax node);
		void VisitPropertyRedefinesRedefinedPropertiesBlock(PropertyRedefinesRedefinedPropertiesBlockSyntax node);
		void VisitMetaOperationParameterListBlock(MetaOperationParameterListBlockSyntax node);
		void VisitQualifierQualifierBlock(QualifierQualifierBlockSyntax node);
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

public virtual void VisitMetaEnum(MetaEnumSyntax node)
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

public virtual void VisitClassMemberAlt1(ClassMemberAlt1Syntax node)
{
    this.DefaultVisit(node);
}

public virtual void VisitClassMemberAlt2(ClassMemberAlt2Syntax node)
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

public virtual void VisitMetaOperation(MetaOperationSyntax node)
{
    this.DefaultVisit(node);
}

public virtual void VisitMetaParameter(MetaParameterSyntax node)
{
    this.DefaultVisit(node);
}

public virtual void VisitTypeReferenceTokens(TypeReferenceTokensSyntax node)
{
    this.DefaultVisit(node);
}

public virtual void VisitSimpleTypeReferenceAlt2(SimpleTypeReferenceAlt2Syntax node)
{
    this.DefaultVisit(node);
}

public virtual void VisitMetaArrayType(MetaArrayTypeSyntax node)
{
    this.DefaultVisit(node);
}

public virtual void VisitMetaNullableType(MetaNullableTypeSyntax node)
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

public virtual void VisitIdentifier(IdentifierSyntax node)
{
    this.DefaultVisit(node);
}

public virtual void VisitEnumBodyEnumLiteralsBlock(EnumBodyEnumLiteralsBlockSyntax node)
{
    this.DefaultVisit(node);
}

public virtual void VisitBaseClassesBaseTypesBlock(BaseClassesBaseTypesBlockSyntax node)
{
    this.DefaultVisit(node);
}

public virtual void VisitPropertyOpposite(PropertyOppositeSyntax node)
{
    this.DefaultVisit(node);
}

public virtual void VisitPropertySubsets(PropertySubsetsSyntax node)
{
    this.DefaultVisit(node);
}

public virtual void VisitPropertyRedefines(PropertyRedefinesSyntax node)
{
    this.DefaultVisit(node);
}

public virtual void VisitPropertyOppositeOppositePropertiesBlock(PropertyOppositeOppositePropertiesBlockSyntax node)
{
    this.DefaultVisit(node);
}

public virtual void VisitPropertySubsetsSubsettedPropertiesBlock(PropertySubsetsSubsettedPropertiesBlockSyntax node)
{
    this.DefaultVisit(node);
}

public virtual void VisitPropertyRedefinesRedefinedPropertiesBlock(PropertyRedefinesRedefinedPropertiesBlockSyntax node)
{
    this.DefaultVisit(node);
}

public virtual void VisitMetaOperationParameterListBlock(MetaOperationParameterListBlockSyntax node)
{
    this.DefaultVisit(node);
}

public virtual void VisitQualifierQualifierBlock(QualifierQualifierBlockSyntax node)
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
	TResult VisitMetaEnum(MetaEnumSyntax node);
	TResult VisitMetaClass(MetaClassSyntax node);
	TResult VisitEnumBody(EnumBodySyntax node);
	TResult VisitMetaEnumLiteral(MetaEnumLiteralSyntax node);
	TResult VisitClassNameAlt1(ClassNameAlt1Syntax node);
	TResult VisitClassNameAlt2(ClassNameAlt2Syntax node);
	TResult VisitBaseClasses(BaseClassesSyntax node);
	TResult VisitClassBody(ClassBodySyntax node);
	TResult VisitClassMemberAlt1(ClassMemberAlt1Syntax node);
	TResult VisitClassMemberAlt2(ClassMemberAlt2Syntax node);
	TResult VisitMetaProperty(MetaPropertySyntax node);
	TResult VisitPropertyNameAlt1(PropertyNameAlt1Syntax node);
	TResult VisitPropertyNameAlt2(PropertyNameAlt2Syntax node);
	TResult VisitMetaOperation(MetaOperationSyntax node);
	TResult VisitMetaParameter(MetaParameterSyntax node);
	TResult VisitTypeReferenceTokens(TypeReferenceTokensSyntax node);
	TResult VisitSimpleTypeReferenceAlt2(SimpleTypeReferenceAlt2Syntax node);
	TResult VisitMetaArrayType(MetaArrayTypeSyntax node);
	TResult VisitMetaNullableType(MetaNullableTypeSyntax node);
	TResult VisitName(NameSyntax node);
	TResult VisitQualifier(QualifierSyntax node);
	TResult VisitIdentifier(IdentifierSyntax node);
	TResult VisitEnumBodyEnumLiteralsBlock(EnumBodyEnumLiteralsBlockSyntax node);
	TResult VisitBaseClassesBaseTypesBlock(BaseClassesBaseTypesBlockSyntax node);
	TResult VisitPropertyOpposite(PropertyOppositeSyntax node);
	TResult VisitPropertySubsets(PropertySubsetsSyntax node);
	TResult VisitPropertyRedefines(PropertyRedefinesSyntax node);
	TResult VisitPropertyOppositeOppositePropertiesBlock(PropertyOppositeOppositePropertiesBlockSyntax node);
	TResult VisitPropertySubsetsSubsettedPropertiesBlock(PropertySubsetsSubsettedPropertiesBlockSyntax node);
	TResult VisitPropertyRedefinesRedefinedPropertiesBlock(PropertyRedefinesRedefinedPropertiesBlockSyntax node);
	TResult VisitMetaOperationParameterListBlock(MetaOperationParameterListBlockSyntax node);
	TResult VisitQualifierQualifierBlock(QualifierQualifierBlockSyntax node);
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

public virtual TResult VisitMetaEnum(MetaEnumSyntax node)
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

public virtual TResult VisitClassMemberAlt1(ClassMemberAlt1Syntax node)
{
    return this.DefaultVisit(node);
}

public virtual TResult VisitClassMemberAlt2(ClassMemberAlt2Syntax node)
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

public virtual TResult VisitMetaOperation(MetaOperationSyntax node)
{
    return this.DefaultVisit(node);
}

public virtual TResult VisitMetaParameter(MetaParameterSyntax node)
{
    return this.DefaultVisit(node);
}

public virtual TResult VisitTypeReferenceTokens(TypeReferenceTokensSyntax node)
{
    return this.DefaultVisit(node);
}

public virtual TResult VisitSimpleTypeReferenceAlt2(SimpleTypeReferenceAlt2Syntax node)
{
    return this.DefaultVisit(node);
}

public virtual TResult VisitMetaArrayType(MetaArrayTypeSyntax node)
{
    return this.DefaultVisit(node);
}

public virtual TResult VisitMetaNullableType(MetaNullableTypeSyntax node)
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

public virtual TResult VisitIdentifier(IdentifierSyntax node)
{
    return this.DefaultVisit(node);
}

public virtual TResult VisitEnumBodyEnumLiteralsBlock(EnumBodyEnumLiteralsBlockSyntax node)
{
    return this.DefaultVisit(node);
}

public virtual TResult VisitBaseClassesBaseTypesBlock(BaseClassesBaseTypesBlockSyntax node)
{
    return this.DefaultVisit(node);
}

public virtual TResult VisitPropertyOpposite(PropertyOppositeSyntax node)
{
    return this.DefaultVisit(node);
}

public virtual TResult VisitPropertySubsets(PropertySubsetsSyntax node)
{
    return this.DefaultVisit(node);
}

public virtual TResult VisitPropertyRedefines(PropertyRedefinesSyntax node)
{
    return this.DefaultVisit(node);
}

public virtual TResult VisitPropertyOppositeOppositePropertiesBlock(PropertyOppositeOppositePropertiesBlockSyntax node)
{
    return this.DefaultVisit(node);
}

public virtual TResult VisitPropertySubsetsSubsettedPropertiesBlock(PropertySubsetsSubsettedPropertiesBlockSyntax node)
{
    return this.DefaultVisit(node);
}

public virtual TResult VisitPropertyRedefinesRedefinedPropertiesBlock(PropertyRedefinesRedefinedPropertiesBlockSyntax node)
{
    return this.DefaultVisit(node);
}

public virtual TResult VisitMetaOperationParameterListBlock(MetaOperationParameterListBlockSyntax node)
{
    return this.DefaultVisit(node);
}

public virtual TResult VisitQualifierQualifierBlock(QualifierQualifierBlockSyntax node)
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
	TResult VisitMetaEnum(MetaEnumSyntax node, TArg argument);
	TResult VisitMetaClass(MetaClassSyntax node, TArg argument);
	TResult VisitEnumBody(EnumBodySyntax node, TArg argument);
	TResult VisitMetaEnumLiteral(MetaEnumLiteralSyntax node, TArg argument);
	TResult VisitClassNameAlt1(ClassNameAlt1Syntax node, TArg argument);
	TResult VisitClassNameAlt2(ClassNameAlt2Syntax node, TArg argument);
	TResult VisitBaseClasses(BaseClassesSyntax node, TArg argument);
	TResult VisitClassBody(ClassBodySyntax node, TArg argument);
	TResult VisitClassMemberAlt1(ClassMemberAlt1Syntax node, TArg argument);
	TResult VisitClassMemberAlt2(ClassMemberAlt2Syntax node, TArg argument);
	TResult VisitMetaProperty(MetaPropertySyntax node, TArg argument);
	TResult VisitPropertyNameAlt1(PropertyNameAlt1Syntax node, TArg argument);
	TResult VisitPropertyNameAlt2(PropertyNameAlt2Syntax node, TArg argument);
	TResult VisitMetaOperation(MetaOperationSyntax node, TArg argument);
	TResult VisitMetaParameter(MetaParameterSyntax node, TArg argument);
	TResult VisitTypeReferenceTokens(TypeReferenceTokensSyntax node, TArg argument);
	TResult VisitSimpleTypeReferenceAlt2(SimpleTypeReferenceAlt2Syntax node, TArg argument);
	TResult VisitMetaArrayType(MetaArrayTypeSyntax node, TArg argument);
	TResult VisitMetaNullableType(MetaNullableTypeSyntax node, TArg argument);
	TResult VisitName(NameSyntax node, TArg argument);
	TResult VisitQualifier(QualifierSyntax node, TArg argument);
	TResult VisitIdentifier(IdentifierSyntax node, TArg argument);
	TResult VisitEnumBodyEnumLiteralsBlock(EnumBodyEnumLiteralsBlockSyntax node, TArg argument);
	TResult VisitBaseClassesBaseTypesBlock(BaseClassesBaseTypesBlockSyntax node, TArg argument);
	TResult VisitPropertyOpposite(PropertyOppositeSyntax node, TArg argument);
	TResult VisitPropertySubsets(PropertySubsetsSyntax node, TArg argument);
	TResult VisitPropertyRedefines(PropertyRedefinesSyntax node, TArg argument);
	TResult VisitPropertyOppositeOppositePropertiesBlock(PropertyOppositeOppositePropertiesBlockSyntax node, TArg argument);
	TResult VisitPropertySubsetsSubsettedPropertiesBlock(PropertySubsetsSubsettedPropertiesBlockSyntax node, TArg argument);
	TResult VisitPropertyRedefinesRedefinedPropertiesBlock(PropertyRedefinesRedefinedPropertiesBlockSyntax node, TArg argument);
	TResult VisitMetaOperationParameterListBlock(MetaOperationParameterListBlockSyntax node, TArg argument);
	TResult VisitQualifierQualifierBlock(QualifierQualifierBlockSyntax node, TArg argument);
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

public virtual TResult VisitMetaEnum(MetaEnumSyntax node, TArg argument)
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

public virtual TResult VisitClassMemberAlt1(ClassMemberAlt1Syntax node, TArg argument)
{
    return this.DefaultVisit(node, argument);
}

public virtual TResult VisitClassMemberAlt2(ClassMemberAlt2Syntax node, TArg argument)
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

public virtual TResult VisitMetaOperation(MetaOperationSyntax node, TArg argument)
{
    return this.DefaultVisit(node, argument);
}

public virtual TResult VisitMetaParameter(MetaParameterSyntax node, TArg argument)
{
    return this.DefaultVisit(node, argument);
}

public virtual TResult VisitTypeReferenceTokens(TypeReferenceTokensSyntax node, TArg argument)
{
    return this.DefaultVisit(node, argument);
}

public virtual TResult VisitSimpleTypeReferenceAlt2(SimpleTypeReferenceAlt2Syntax node, TArg argument)
{
    return this.DefaultVisit(node, argument);
}

public virtual TResult VisitMetaArrayType(MetaArrayTypeSyntax node, TArg argument)
{
    return this.DefaultVisit(node, argument);
}

public virtual TResult VisitMetaNullableType(MetaNullableTypeSyntax node, TArg argument)
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

public virtual TResult VisitIdentifier(IdentifierSyntax node, TArg argument)
{
    return this.DefaultVisit(node, argument);
}

public virtual TResult VisitEnumBodyEnumLiteralsBlock(EnumBodyEnumLiteralsBlockSyntax node, TArg argument)
{
    return this.DefaultVisit(node, argument);
}

public virtual TResult VisitBaseClassesBaseTypesBlock(BaseClassesBaseTypesBlockSyntax node, TArg argument)
{
    return this.DefaultVisit(node, argument);
}

public virtual TResult VisitPropertyOpposite(PropertyOppositeSyntax node, TArg argument)
{
    return this.DefaultVisit(node, argument);
}

public virtual TResult VisitPropertySubsets(PropertySubsetsSyntax node, TArg argument)
{
    return this.DefaultVisit(node, argument);
}

public virtual TResult VisitPropertyRedefines(PropertyRedefinesSyntax node, TArg argument)
{
    return this.DefaultVisit(node, argument);
}

public virtual TResult VisitPropertyOppositeOppositePropertiesBlock(PropertyOppositeOppositePropertiesBlockSyntax node, TArg argument)
{
    return this.DefaultVisit(node, argument);
}

public virtual TResult VisitPropertySubsetsSubsettedPropertiesBlock(PropertySubsetsSubsettedPropertiesBlockSyntax node, TArg argument)
{
    return this.DefaultVisit(node, argument);
}

public virtual TResult VisitPropertyRedefinesRedefinedPropertiesBlock(PropertyRedefinesRedefinedPropertiesBlockSyntax node, TArg argument)
{
    return this.DefaultVisit(node, argument);
}

public virtual TResult VisitMetaOperationParameterListBlock(MetaOperationParameterListBlockSyntax node, TArg argument)
{
    return this.DefaultVisit(node, argument);
}

public virtual TResult VisitQualifierQualifierBlock(QualifierQualifierBlockSyntax node, TArg argument)
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
    var usingList = this.VisitList(node.UsingList);
    var declarations = (DeclarationsSyntax)this.Visit(node.Declarations);
    var endOfFileToken = this.VisitToken(node.EndOfFileToken);
	return node.Update(kNamespace, name, tSemicolon, usingList, declarations, endOfFileToken);
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

public virtual SyntaxNode VisitMetaEnum(MetaEnumSyntax node)
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
    var className = (ClassNameSyntax)this.Visit(node.ClassName);
    var baseClasses = (BaseClassesSyntax)this.Visit(node.BaseClasses);
    var classBody = (ClassBodySyntax)this.Visit(node.ClassBody);
	return node.Update(isAbstract, kClass, className, baseClasses, classBody);
}

public virtual SyntaxNode VisitEnumBody(EnumBodySyntax node)
{
    var tLBrace = this.VisitToken(node.TLBrace);
    var enumLiterals = this.VisitList(node.EnumLiterals);
    var tRBrace = this.VisitToken(node.TRBrace);
	return node.Update(tLBrace, enumLiterals, tRBrace);
}

public virtual SyntaxNode VisitMetaEnumLiteral(MetaEnumLiteralSyntax node)
{
    var name = (NameSyntax)this.Visit(node.Name);
	return node.Update(name);
}

public virtual SyntaxNode VisitClassNameAlt1(ClassNameAlt1Syntax node)
{
    var identifier = (IdentifierSyntax)this.Visit(node.Identifier);
    var tDollar = this.VisitToken(node.TDollar);
    var symbolType = (IdentifierSyntax)this.Visit(node.SymbolType);
	return node.Update(identifier, tDollar, symbolType);
}

public virtual SyntaxNode VisitClassNameAlt2(ClassNameAlt2Syntax node)
{
    var identifier = (IdentifierSyntax)this.Visit(node.Identifier);
	return node.Update(identifier);
}

public virtual SyntaxNode VisitBaseClasses(BaseClassesSyntax node)
{
    var tColon = this.VisitToken(node.TColon);
    var baseTypes = this.VisitList(node.BaseTypes);
	return node.Update(tColon, baseTypes);
}

public virtual SyntaxNode VisitClassBody(ClassBodySyntax node)
{
    var tLBrace = this.VisitToken(node.TLBrace);
    var classMemberList = this.VisitList(node.ClassMemberList);
    var tRBrace = this.VisitToken(node.TRBrace);
	return node.Update(tLBrace, classMemberList, tRBrace);
}

public virtual SyntaxNode VisitClassMemberAlt1(ClassMemberAlt1Syntax node)
{
    var properties = (MetaPropertySyntax)this.Visit(node.Properties);
	return node.Update(properties);
}

public virtual SyntaxNode VisitClassMemberAlt2(ClassMemberAlt2Syntax node)
{
    var operations = (MetaOperationSyntax)this.Visit(node.Operations);
	return node.Update(operations);
}

public virtual SyntaxNode VisitMetaProperty(MetaPropertySyntax node)
{
    var tokens = this.VisitToken(node.Tokens);
    var type = (TypeReferenceSyntax)this.Visit(node.Type);
    var propertyName = (PropertyNameSyntax)this.Visit(node.PropertyName);
    var block = this.VisitList(node.Block);
    var tSemicolon = this.VisitToken(node.TSemicolon);
	return node.Update(tokens, type, propertyName, block, tSemicolon);
}

public virtual SyntaxNode VisitPropertyNameAlt1(PropertyNameAlt1Syntax node)
{
    var identifier = (IdentifierSyntax)this.Visit(node.Identifier);
    var tDollar = this.VisitToken(node.TDollar);
    var symbolProperty = (IdentifierSyntax)this.Visit(node.SymbolProperty);
	return node.Update(identifier, tDollar, symbolProperty);
}

public virtual SyntaxNode VisitPropertyNameAlt2(PropertyNameAlt2Syntax node)
{
    var identifier = (IdentifierSyntax)this.Visit(node.Identifier);
	return node.Update(identifier);
}

public virtual SyntaxNode VisitMetaOperation(MetaOperationSyntax node)
{
    var returnType = (TypeReferenceSyntax)this.Visit(node.ReturnType);
    var name = (NameSyntax)this.Visit(node.Name);
    var tLParen = this.VisitToken(node.TLParen);
    var parameterList = this.VisitList(node.ParameterList);
    var tRParen = this.VisitToken(node.TRParen);
    var tSemicolon = this.VisitToken(node.TSemicolon);
	return node.Update(returnType, name, tLParen, parameterList, tRParen, tSemicolon);
}

public virtual SyntaxNode VisitMetaParameter(MetaParameterSyntax node)
{
    var type = (TypeReferenceSyntax)this.Visit(node.Type);
    var name = (NameSyntax)this.Visit(node.Name);
	return node.Update(type, name);
}

public virtual SyntaxNode VisitTypeReferenceTokens(TypeReferenceTokensSyntax node)
{
    var token = this.VisitToken(node.Token);
	return node.Update(token);
}

public virtual SyntaxNode VisitSimpleTypeReferenceAlt2(SimpleTypeReferenceAlt2Syntax node)
{
    var qualifier = (QualifierSyntax)this.Visit(node.Qualifier);
	return node.Update(qualifier);
}

public virtual SyntaxNode VisitMetaArrayType(MetaArrayTypeSyntax node)
{
    var itemType = (TypeReferenceSyntax)this.Visit(node.ItemType);
    var tLBracket = this.VisitToken(node.TLBracket);
    var tRBracket = this.VisitToken(node.TRBracket);
	return node.Update(itemType, tLBracket, tRBracket);
}

public virtual SyntaxNode VisitMetaNullableType(MetaNullableTypeSyntax node)
{
    var innerType = (TypeReferenceSyntax)this.Visit(node.InnerType);
    var tQuestion = this.VisitToken(node.TQuestion);
	return node.Update(innerType, tQuestion);
}

public virtual SyntaxNode VisitName(NameSyntax node)
{
    var identifier = (IdentifierSyntax)this.Visit(node.Identifier);
	return node.Update(identifier);
}

public virtual SyntaxNode VisitQualifier(QualifierSyntax node)
{
    var qualifier = this.VisitList(node.Qualifier);
	return node.Update(qualifier);
}

public virtual SyntaxNode VisitIdentifier(IdentifierSyntax node)
{
    var token = this.VisitToken(node.Token);
	return node.Update(token);
}

public virtual SyntaxNode VisitEnumBodyEnumLiteralsBlock(EnumBodyEnumLiteralsBlockSyntax node)
{
    var tComma = this.VisitToken(node.TComma);
    var literals = (MetaEnumLiteralSyntax)this.Visit(node.Literals);
	return node.Update(tComma, literals);
}

public virtual SyntaxNode VisitBaseClassesBaseTypesBlock(BaseClassesBaseTypesBlockSyntax node)
{
    var tComma = this.VisitToken(node.TComma);
    var baseTypes = (QualifierSyntax)this.Visit(node.BaseTypes);
	return node.Update(tComma, baseTypes);
}

public virtual SyntaxNode VisitPropertyOpposite(PropertyOppositeSyntax node)
{
    var kOpposite = this.VisitToken(node.KOpposite);
    var oppositeProperties = this.VisitList(node.OppositeProperties);
	return node.Update(kOpposite, oppositeProperties);
}

public virtual SyntaxNode VisitPropertySubsets(PropertySubsetsSyntax node)
{
    var kSubsets = this.VisitToken(node.KSubsets);
    var subsettedProperties = this.VisitList(node.SubsettedProperties);
	return node.Update(kSubsets, subsettedProperties);
}

public virtual SyntaxNode VisitPropertyRedefines(PropertyRedefinesSyntax node)
{
    var kRedefines = this.VisitToken(node.KRedefines);
    var redefinedProperties = this.VisitList(node.RedefinedProperties);
	return node.Update(kRedefines, redefinedProperties);
}

public virtual SyntaxNode VisitPropertyOppositeOppositePropertiesBlock(PropertyOppositeOppositePropertiesBlockSyntax node)
{
    var tComma = this.VisitToken(node.TComma);
    var oppositeProperties = (QualifierSyntax)this.Visit(node.OppositeProperties);
	return node.Update(tComma, oppositeProperties);
}

public virtual SyntaxNode VisitPropertySubsetsSubsettedPropertiesBlock(PropertySubsetsSubsettedPropertiesBlockSyntax node)
{
    var tComma = this.VisitToken(node.TComma);
    var subsettedProperties = (QualifierSyntax)this.Visit(node.SubsettedProperties);
	return node.Update(tComma, subsettedProperties);
}

public virtual SyntaxNode VisitPropertyRedefinesRedefinedPropertiesBlock(PropertyRedefinesRedefinedPropertiesBlockSyntax node)
{
    var tComma = this.VisitToken(node.TComma);
    var redefinedProperties = (QualifierSyntax)this.Visit(node.RedefinedProperties);
	return node.Update(tComma, redefinedProperties);
}

public virtual SyntaxNode VisitMetaOperationParameterListBlock(MetaOperationParameterListBlockSyntax node)
{
    var tComma = this.VisitToken(node.TComma);
    var parameters = (MetaParameterSyntax)this.Visit(node.Parameters);
	return node.Update(tComma, parameters);
}

public virtual SyntaxNode VisitQualifierQualifierBlock(QualifierQualifierBlockSyntax node)
{
    var tDot = this.VisitToken(node.TDot);
    var identifier = (IdentifierSyntax)this.Visit(node.Identifier);
	return node.Update(tDot, identifier);
}
		}
}
