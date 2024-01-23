#nullable enable

namespace MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax
{
	internal class MetaInternalSyntaxVisitor : global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.InternalSyntaxVisitor
	{
		public virtual void VisitSkippedTokensTrivia(GreenSkippedTokensTriviaSyntax node) => this.DefaultVisit(node);
		public virtual void VisitMainGreen(MainGreen node) => this.DefaultVisit(node);
		public virtual void VisitUsingGreen(UsingGreen node) => this.DefaultVisit(node);
		public virtual void VisitDeclarationsGreen(DeclarationsGreen node) => this.DefaultVisit(node);
		public virtual void VisitMetaModelGreen(MetaModelGreen node) => this.DefaultVisit(node);
		public virtual void VisitMetaConstantGreen(MetaConstantGreen node) => this.DefaultVisit(node);
		public virtual void VisitMetaEnumGreen(MetaEnumGreen node) => this.DefaultVisit(node);
		public virtual void VisitMetaClassGreen(MetaClassGreen node) => this.DefaultVisit(node);
		public virtual void VisitEnumBodyGreen(EnumBodyGreen node) => this.DefaultVisit(node);
		public virtual void VisitMetaEnumLiteralGreen(MetaEnumLiteralGreen node) => this.DefaultVisit(node);
		public virtual void VisitClassNameAlt1Green(ClassNameAlt1Green node) => this.DefaultVisit(node);
		public virtual void VisitClassNameAlt2Green(ClassNameAlt2Green node) => this.DefaultVisit(node);
		public virtual void VisitBaseClassesGreen(BaseClassesGreen node) => this.DefaultVisit(node);
		public virtual void VisitClassBodyGreen(ClassBodyGreen node) => this.DefaultVisit(node);
		public virtual void VisitClassMemberAlt1Green(ClassMemberAlt1Green node) => this.DefaultVisit(node);
		public virtual void VisitClassMemberAlt2Green(ClassMemberAlt2Green node) => this.DefaultVisit(node);
		public virtual void VisitMetaPropertyGreen(MetaPropertyGreen node) => this.DefaultVisit(node);
		public virtual void VisitPropertyNameAlt1Green(PropertyNameAlt1Green node) => this.DefaultVisit(node);
		public virtual void VisitPropertyNameAlt2Green(PropertyNameAlt2Green node) => this.DefaultVisit(node);
		public virtual void VisitMetaOperationGreen(MetaOperationGreen node) => this.DefaultVisit(node);
		public virtual void VisitMetaParameterGreen(MetaParameterGreen node) => this.DefaultVisit(node);
		public virtual void VisitTypeReferenceTokensGreen(TypeReferenceTokensGreen node) => this.DefaultVisit(node);
		public virtual void VisitSimpleTypeReferenceAlt2Green(SimpleTypeReferenceAlt2Green node) => this.DefaultVisit(node);
		public virtual void VisitMetaArrayTypeGreen(MetaArrayTypeGreen node) => this.DefaultVisit(node);
		public virtual void VisitMetaNullableTypeGreen(MetaNullableTypeGreen node) => this.DefaultVisit(node);
		public virtual void VisitNameGreen(NameGreen node) => this.DefaultVisit(node);
		public virtual void VisitQualifierGreen(QualifierGreen node) => this.DefaultVisit(node);
		public virtual void VisitIdentifierGreen(IdentifierGreen node) => this.DefaultVisit(node);
		public virtual void VisitEnumBodyEnumLiteralsBlockGreen(EnumBodyEnumLiteralsBlockGreen node) => this.DefaultVisit(node);
		public virtual void VisitBaseClassesBaseTypesBlockGreen(BaseClassesBaseTypesBlockGreen node) => this.DefaultVisit(node);
		public virtual void VisitPropertyOppositeGreen(PropertyOppositeGreen node) => this.DefaultVisit(node);
		public virtual void VisitPropertySubsetsGreen(PropertySubsetsGreen node) => this.DefaultVisit(node);
		public virtual void VisitPropertyRedefinesGreen(PropertyRedefinesGreen node) => this.DefaultVisit(node);
		public virtual void VisitPropertyOppositeOppositePropertiesBlockGreen(PropertyOppositeOppositePropertiesBlockGreen node) => this.DefaultVisit(node);
		public virtual void VisitPropertySubsetsSubsettedPropertiesBlockGreen(PropertySubsetsSubsettedPropertiesBlockGreen node) => this.DefaultVisit(node);
		public virtual void VisitPropertyRedefinesRedefinedPropertiesBlockGreen(PropertyRedefinesRedefinedPropertiesBlockGreen node) => this.DefaultVisit(node);
		public virtual void VisitMetaOperationParameterListBlockGreen(MetaOperationParameterListBlockGreen node) => this.DefaultVisit(node);
		public virtual void VisitQualifierQualifierBlockGreen(QualifierQualifierBlockGreen node) => this.DefaultVisit(node);
	}

	internal class MetaInternalSyntaxVisitor<TResult> : global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.InternalSyntaxVisitor<TResult>
	{
		public virtual TResult VisitSkippedTokensTrivia(GreenSkippedTokensTriviaSyntax node) => this.DefaultVisit(node);
		public virtual TResult VisitMainGreen(MainGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitUsingGreen(UsingGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitDeclarationsGreen(DeclarationsGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitMetaModelGreen(MetaModelGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitMetaConstantGreen(MetaConstantGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitMetaEnumGreen(MetaEnumGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitMetaClassGreen(MetaClassGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitEnumBodyGreen(EnumBodyGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitMetaEnumLiteralGreen(MetaEnumLiteralGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitClassNameAlt1Green(ClassNameAlt1Green node) => this.DefaultVisit(node);
		public virtual TResult VisitClassNameAlt2Green(ClassNameAlt2Green node) => this.DefaultVisit(node);
		public virtual TResult VisitBaseClassesGreen(BaseClassesGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitClassBodyGreen(ClassBodyGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitClassMemberAlt1Green(ClassMemberAlt1Green node) => this.DefaultVisit(node);
		public virtual TResult VisitClassMemberAlt2Green(ClassMemberAlt2Green node) => this.DefaultVisit(node);
		public virtual TResult VisitMetaPropertyGreen(MetaPropertyGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitPropertyNameAlt1Green(PropertyNameAlt1Green node) => this.DefaultVisit(node);
		public virtual TResult VisitPropertyNameAlt2Green(PropertyNameAlt2Green node) => this.DefaultVisit(node);
		public virtual TResult VisitMetaOperationGreen(MetaOperationGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitMetaParameterGreen(MetaParameterGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitTypeReferenceTokensGreen(TypeReferenceTokensGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitSimpleTypeReferenceAlt2Green(SimpleTypeReferenceAlt2Green node) => this.DefaultVisit(node);
		public virtual TResult VisitMetaArrayTypeGreen(MetaArrayTypeGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitMetaNullableTypeGreen(MetaNullableTypeGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitNameGreen(NameGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitQualifierGreen(QualifierGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitIdentifierGreen(IdentifierGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitEnumBodyEnumLiteralsBlockGreen(EnumBodyEnumLiteralsBlockGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitBaseClassesBaseTypesBlockGreen(BaseClassesBaseTypesBlockGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitPropertyOppositeGreen(PropertyOppositeGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitPropertySubsetsGreen(PropertySubsetsGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitPropertyRedefinesGreen(PropertyRedefinesGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitPropertyOppositeOppositePropertiesBlockGreen(PropertyOppositeOppositePropertiesBlockGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitPropertySubsetsSubsettedPropertiesBlockGreen(PropertySubsetsSubsettedPropertiesBlockGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitPropertyRedefinesRedefinedPropertiesBlockGreen(PropertyRedefinesRedefinedPropertiesBlockGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitMetaOperationParameterListBlockGreen(MetaOperationParameterListBlockGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitQualifierQualifierBlockGreen(QualifierQualifierBlockGreen node) => this.DefaultVisit(node);
	}
}
