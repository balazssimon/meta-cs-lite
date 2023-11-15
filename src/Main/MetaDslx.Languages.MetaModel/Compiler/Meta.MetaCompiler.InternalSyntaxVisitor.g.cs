using System;

#nullable enable

namespace MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax
{
    using MetaDslx.CodeAnalysis.Syntax.InternalSyntax;

	internal class MetaInternalSyntaxVisitor : InternalSyntaxVisitor
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
		public virtual void VisitEnumLiteralsGreen(EnumLiteralsGreen node) => this.DefaultVisit(node);
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
		public virtual void VisitPropertyOppositeGreen(PropertyOppositeGreen node) => this.DefaultVisit(node);
		public virtual void VisitPropertySubsetsGreen(PropertySubsetsGreen node) => this.DefaultVisit(node);
		public virtual void VisitPropertyRedefinesGreen(PropertyRedefinesGreen node) => this.DefaultVisit(node);
		public virtual void VisitMetaOperationGreen(MetaOperationGreen node) => this.DefaultVisit(node);
		public virtual void VisitParameterListGreen(ParameterListGreen node) => this.DefaultVisit(node);
		public virtual void VisitMetaParameterGreen(MetaParameterGreen node) => this.DefaultVisit(node);
		public virtual void VisitMetaArrayTypeGreen(MetaArrayTypeGreen node) => this.DefaultVisit(node);
		public virtual void VisitMetaNullableTypeGreen(MetaNullableTypeGreen node) => this.DefaultVisit(node);
		public virtual void VisitTypeReferenceAlt4Green(TypeReferenceAlt4Green node) => this.DefaultVisit(node);
		public virtual void VisitTypeReferenceTokensGreen(TypeReferenceTokensGreen node) => this.DefaultVisit(node);
		public virtual void VisitNameGreen(NameGreen node) => this.DefaultVisit(node);
		public virtual void VisitQualifierGreen(QualifierGreen node) => this.DefaultVisit(node);
		public virtual void VisitQualifierListGreen(QualifierListGreen node) => this.DefaultVisit(node);
		public virtual void VisitIdentifierGreen(IdentifierGreen node) => this.DefaultVisit(node);
		public virtual void VisitEnumLiteralsBlock1Green(EnumLiteralsBlock1Green node) => this.DefaultVisit(node);
		public virtual void VisitBaseClassesBlock1Green(BaseClassesBlock1Green node) => this.DefaultVisit(node);
		public virtual void VisitMetaPropertyBlock2Alt1Green(MetaPropertyBlock2Alt1Green node) => this.DefaultVisit(node);
		public virtual void VisitMetaPropertyBlock2Alt2Green(MetaPropertyBlock2Alt2Green node) => this.DefaultVisit(node);
		public virtual void VisitMetaPropertyBlock2Alt3Green(MetaPropertyBlock2Alt3Green node) => this.DefaultVisit(node);
		public virtual void VisitPropertyOppositeBlock1Green(PropertyOppositeBlock1Green node) => this.DefaultVisit(node);
		public virtual void VisitPropertySubsetsBlock1Green(PropertySubsetsBlock1Green node) => this.DefaultVisit(node);
		public virtual void VisitPropertyRedefinesBlock1Green(PropertyRedefinesBlock1Green node) => this.DefaultVisit(node);
		public virtual void VisitParameterListBlock1Green(ParameterListBlock1Green node) => this.DefaultVisit(node);
		public virtual void VisitQualifierBlock1Green(QualifierBlock1Green node) => this.DefaultVisit(node);
		public virtual void VisitQualifierListBlock1Green(QualifierListBlock1Green node) => this.DefaultVisit(node);
	}

	internal class MetaInternalSyntaxVisitor<TResult> : InternalSyntaxVisitor<TResult>
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
		public virtual TResult VisitEnumLiteralsGreen(EnumLiteralsGreen node) => this.DefaultVisit(node);
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
		public virtual TResult VisitPropertyOppositeGreen(PropertyOppositeGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitPropertySubsetsGreen(PropertySubsetsGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitPropertyRedefinesGreen(PropertyRedefinesGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitMetaOperationGreen(MetaOperationGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitParameterListGreen(ParameterListGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitMetaParameterGreen(MetaParameterGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitMetaArrayTypeGreen(MetaArrayTypeGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitMetaNullableTypeGreen(MetaNullableTypeGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitTypeReferenceAlt4Green(TypeReferenceAlt4Green node) => this.DefaultVisit(node);
		public virtual TResult VisitTypeReferenceTokensGreen(TypeReferenceTokensGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitNameGreen(NameGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitQualifierGreen(QualifierGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitQualifierListGreen(QualifierListGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitIdentifierGreen(IdentifierGreen node) => this.DefaultVisit(node);
		public virtual TResult VisitEnumLiteralsBlock1Green(EnumLiteralsBlock1Green node) => this.DefaultVisit(node);
		public virtual TResult VisitBaseClassesBlock1Green(BaseClassesBlock1Green node) => this.DefaultVisit(node);
		public virtual TResult VisitMetaPropertyBlock2Alt1Green(MetaPropertyBlock2Alt1Green node) => this.DefaultVisit(node);
		public virtual TResult VisitMetaPropertyBlock2Alt2Green(MetaPropertyBlock2Alt2Green node) => this.DefaultVisit(node);
		public virtual TResult VisitMetaPropertyBlock2Alt3Green(MetaPropertyBlock2Alt3Green node) => this.DefaultVisit(node);
		public virtual TResult VisitPropertyOppositeBlock1Green(PropertyOppositeBlock1Green node) => this.DefaultVisit(node);
		public virtual TResult VisitPropertySubsetsBlock1Green(PropertySubsetsBlock1Green node) => this.DefaultVisit(node);
		public virtual TResult VisitPropertyRedefinesBlock1Green(PropertyRedefinesBlock1Green node) => this.DefaultVisit(node);
		public virtual TResult VisitParameterListBlock1Green(ParameterListBlock1Green node) => this.DefaultVisit(node);
		public virtual TResult VisitQualifierBlock1Green(QualifierBlock1Green node) => this.DefaultVisit(node);
		public virtual TResult VisitQualifierListBlock1Green(QualifierListBlock1Green node) => this.DefaultVisit(node);
	}
}
