#nullable enable

namespace MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax
{
    internal class MetaInternalSyntaxVisitor : global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.InternalSyntaxVisitor
    {
        public virtual void VisitSkippedTokensTrivia(GreenSkippedTokensTriviaSyntax node) => this.DefaultVisit(node);
        public virtual void VisitMainGreen(MainGreen node) => this.DefaultVisit(node);
        public virtual void VisitUsingGreen(UsingGreen node) => this.DefaultVisit(node);
        public virtual void VisitMetaModelGreen(MetaModelGreen node) => this.DefaultVisit(node);
        public virtual void VisitMetaDeclarationAlt1Green(MetaDeclarationAlt1Green node) => this.DefaultVisit(node);
        public virtual void VisitMetaDeclarationAlt2Green(MetaDeclarationAlt2Green node) => this.DefaultVisit(node);
        public virtual void VisitMetaDeclarationAlt3Green(MetaDeclarationAlt3Green node) => this.DefaultVisit(node);
        public virtual void VisitMetaConstantGreen(MetaConstantGreen node) => this.DefaultVisit(node);
        public virtual void VisitMetaEnumGreen(MetaEnumGreen node) => this.DefaultVisit(node);
        public virtual void VisitMetaEnumLiteralGreen(MetaEnumLiteralGreen node) => this.DefaultVisit(node);
        public virtual void VisitMetaClassGreen(MetaClassGreen node) => this.DefaultVisit(node);
        public virtual void VisitMetaPropertyGreen(MetaPropertyGreen node) => this.DefaultVisit(node);
        public virtual void VisitMetaOperationGreen(MetaOperationGreen node) => this.DefaultVisit(node);
        public virtual void VisitMetaParameterGreen(MetaParameterGreen node) => this.DefaultVisit(node);
        public virtual void VisitSimpleTypeReferenceGreen(SimpleTypeReferenceGreen node) => this.DefaultVisit(node);
        public virtual void VisitMetaArrayTypeGreen(MetaArrayTypeGreen node) => this.DefaultVisit(node);
        public virtual void VisitMetaNullableTypeGreen(MetaNullableTypeGreen node) => this.DefaultVisit(node);
        public virtual void VisitTypeReferenceAlt1Green(TypeReferenceAlt1Green node) => this.DefaultVisit(node);
        public virtual void VisitTypeReferenceAlt2Green(TypeReferenceAlt2Green node) => this.DefaultVisit(node);
        public virtual void VisitPrimitiveTypeGreen(PrimitiveTypeGreen node) => this.DefaultVisit(node);
        public virtual void VisitNameGreen(NameGreen node) => this.DefaultVisit(node);
        public virtual void VisitQualifierGreen(QualifierGreen node) => this.DefaultVisit(node);
        public virtual void VisitIdentifierGreen(IdentifierGreen node) => this.DefaultVisit(node);
        public virtual void VisitMainBlock1Green(MainBlock1Green node) => this.DefaultVisit(node);
        public virtual void VisitMetaEnumliteralsBlockGreen(MetaEnumliteralsBlockGreen node) => this.DefaultVisit(node);
        public virtual void VisitMetaClassBlock1Alt1Green(MetaClassBlock1Alt1Green node) => this.DefaultVisit(node);
        public virtual void VisitMetaClassBlock1Alt2Green(MetaClassBlock1Alt2Green node) => this.DefaultVisit(node);
        public virtual void VisitMetaClassBlock2Green(MetaClassBlock2Green node) => this.DefaultVisit(node);
        public virtual void VisitMetaClassBlock2baseTypesBlockGreen(MetaClassBlock2baseTypesBlockGreen node) => this.DefaultVisit(node);
        public virtual void VisitMetaClassBlock3Green(MetaClassBlock3Green node) => this.DefaultVisit(node);
        public virtual void VisitMetaClassBlock3Block1Alt1Green(MetaClassBlock3Block1Alt1Green node) => this.DefaultVisit(node);
        public virtual void VisitMetaClassBlock3Block1Alt2Green(MetaClassBlock3Block1Alt2Green node) => this.DefaultVisit(node);
        public virtual void VisitMetaPropertyBlock1Alt1Green(MetaPropertyBlock1Alt1Green node) => this.DefaultVisit(node);
        public virtual void VisitMetaPropertyBlock1Alt2Green(MetaPropertyBlock1Alt2Green node) => this.DefaultVisit(node);
        public virtual void VisitMetaPropertyBlock2Alt1Green(MetaPropertyBlock2Alt1Green node) => this.DefaultVisit(node);
        public virtual void VisitMetaPropertyBlock2Alt2Green(MetaPropertyBlock2Alt2Green node) => this.DefaultVisit(node);
        public virtual void VisitMetaPropertyBlock3Alt1Green(MetaPropertyBlock3Alt1Green node) => this.DefaultVisit(node);
        public virtual void VisitMetaPropertyBlock3Alt2Green(MetaPropertyBlock3Alt2Green node) => this.DefaultVisit(node);
        public virtual void VisitMetaPropertyBlock3Alt3Green(MetaPropertyBlock3Alt3Green node) => this.DefaultVisit(node);
        public virtual void VisitMetaPropertyBlock3Alt1oppositePropertiesBlockGreen(MetaPropertyBlock3Alt1oppositePropertiesBlockGreen node) => this.DefaultVisit(node);
        public virtual void VisitMetaPropertyBlock3Alt2subsettedPropertiesBlockGreen(MetaPropertyBlock3Alt2subsettedPropertiesBlockGreen node) => this.DefaultVisit(node);
        public virtual void VisitMetaPropertyBlock3Alt3redefinedPropertiesBlockGreen(MetaPropertyBlock3Alt3redefinedPropertiesBlockGreen node) => this.DefaultVisit(node);
        public virtual void VisitMetaOperationBlock1Green(MetaOperationBlock1Green node) => this.DefaultVisit(node);
        public virtual void VisitMetaOperationBlock1parametersBlockGreen(MetaOperationBlock1parametersBlockGreen node) => this.DefaultVisit(node);
        public virtual void VisitQualifierIdentifierBlockGreen(QualifierIdentifierBlockGreen node) => this.DefaultVisit(node);
    }

    internal class MetaInternalSyntaxVisitor<TResult> : global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.InternalSyntaxVisitor<TResult>
    {
        public virtual TResult VisitSkippedTokensTrivia(GreenSkippedTokensTriviaSyntax node) => this.DefaultVisit(node);
        public virtual TResult VisitMainGreen(MainGreen node) => this.DefaultVisit(node);
        public virtual TResult VisitUsingGreen(UsingGreen node) => this.DefaultVisit(node);
        public virtual TResult VisitMetaModelGreen(MetaModelGreen node) => this.DefaultVisit(node);
        public virtual TResult VisitMetaDeclarationAlt1Green(MetaDeclarationAlt1Green node) => this.DefaultVisit(node);
        public virtual TResult VisitMetaDeclarationAlt2Green(MetaDeclarationAlt2Green node) => this.DefaultVisit(node);
        public virtual TResult VisitMetaDeclarationAlt3Green(MetaDeclarationAlt3Green node) => this.DefaultVisit(node);
        public virtual TResult VisitMetaConstantGreen(MetaConstantGreen node) => this.DefaultVisit(node);
        public virtual TResult VisitMetaEnumGreen(MetaEnumGreen node) => this.DefaultVisit(node);
        public virtual TResult VisitMetaEnumLiteralGreen(MetaEnumLiteralGreen node) => this.DefaultVisit(node);
        public virtual TResult VisitMetaClassGreen(MetaClassGreen node) => this.DefaultVisit(node);
        public virtual TResult VisitMetaPropertyGreen(MetaPropertyGreen node) => this.DefaultVisit(node);
        public virtual TResult VisitMetaOperationGreen(MetaOperationGreen node) => this.DefaultVisit(node);
        public virtual TResult VisitMetaParameterGreen(MetaParameterGreen node) => this.DefaultVisit(node);
        public virtual TResult VisitSimpleTypeReferenceGreen(SimpleTypeReferenceGreen node) => this.DefaultVisit(node);
        public virtual TResult VisitMetaArrayTypeGreen(MetaArrayTypeGreen node) => this.DefaultVisit(node);
        public virtual TResult VisitMetaNullableTypeGreen(MetaNullableTypeGreen node) => this.DefaultVisit(node);
        public virtual TResult VisitTypeReferenceAlt1Green(TypeReferenceAlt1Green node) => this.DefaultVisit(node);
        public virtual TResult VisitTypeReferenceAlt2Green(TypeReferenceAlt2Green node) => this.DefaultVisit(node);
        public virtual TResult VisitPrimitiveTypeGreen(PrimitiveTypeGreen node) => this.DefaultVisit(node);
        public virtual TResult VisitNameGreen(NameGreen node) => this.DefaultVisit(node);
        public virtual TResult VisitQualifierGreen(QualifierGreen node) => this.DefaultVisit(node);
        public virtual TResult VisitIdentifierGreen(IdentifierGreen node) => this.DefaultVisit(node);
        public virtual TResult VisitMainBlock1Green(MainBlock1Green node) => this.DefaultVisit(node);
        public virtual TResult VisitMetaEnumliteralsBlockGreen(MetaEnumliteralsBlockGreen node) => this.DefaultVisit(node);
        public virtual TResult VisitMetaClassBlock1Alt1Green(MetaClassBlock1Alt1Green node) => this.DefaultVisit(node);
        public virtual TResult VisitMetaClassBlock1Alt2Green(MetaClassBlock1Alt2Green node) => this.DefaultVisit(node);
        public virtual TResult VisitMetaClassBlock2Green(MetaClassBlock2Green node) => this.DefaultVisit(node);
        public virtual TResult VisitMetaClassBlock2baseTypesBlockGreen(MetaClassBlock2baseTypesBlockGreen node) => this.DefaultVisit(node);
        public virtual TResult VisitMetaClassBlock3Green(MetaClassBlock3Green node) => this.DefaultVisit(node);
        public virtual TResult VisitMetaClassBlock3Block1Alt1Green(MetaClassBlock3Block1Alt1Green node) => this.DefaultVisit(node);
        public virtual TResult VisitMetaClassBlock3Block1Alt2Green(MetaClassBlock3Block1Alt2Green node) => this.DefaultVisit(node);
        public virtual TResult VisitMetaPropertyBlock1Alt1Green(MetaPropertyBlock1Alt1Green node) => this.DefaultVisit(node);
        public virtual TResult VisitMetaPropertyBlock1Alt2Green(MetaPropertyBlock1Alt2Green node) => this.DefaultVisit(node);
        public virtual TResult VisitMetaPropertyBlock2Alt1Green(MetaPropertyBlock2Alt1Green node) => this.DefaultVisit(node);
        public virtual TResult VisitMetaPropertyBlock2Alt2Green(MetaPropertyBlock2Alt2Green node) => this.DefaultVisit(node);
        public virtual TResult VisitMetaPropertyBlock3Alt1Green(MetaPropertyBlock3Alt1Green node) => this.DefaultVisit(node);
        public virtual TResult VisitMetaPropertyBlock3Alt2Green(MetaPropertyBlock3Alt2Green node) => this.DefaultVisit(node);
        public virtual TResult VisitMetaPropertyBlock3Alt3Green(MetaPropertyBlock3Alt3Green node) => this.DefaultVisit(node);
        public virtual TResult VisitMetaPropertyBlock3Alt1oppositePropertiesBlockGreen(MetaPropertyBlock3Alt1oppositePropertiesBlockGreen node) => this.DefaultVisit(node);
        public virtual TResult VisitMetaPropertyBlock3Alt2subsettedPropertiesBlockGreen(MetaPropertyBlock3Alt2subsettedPropertiesBlockGreen node) => this.DefaultVisit(node);
        public virtual TResult VisitMetaPropertyBlock3Alt3redefinedPropertiesBlockGreen(MetaPropertyBlock3Alt3redefinedPropertiesBlockGreen node) => this.DefaultVisit(node);
        public virtual TResult VisitMetaOperationBlock1Green(MetaOperationBlock1Green node) => this.DefaultVisit(node);
        public virtual TResult VisitMetaOperationBlock1parametersBlockGreen(MetaOperationBlock1parametersBlockGreen node) => this.DefaultVisit(node);
        public virtual TResult VisitQualifierIdentifierBlockGreen(QualifierIdentifierBlockGreen node) => this.DefaultVisit(node);
    }
}
