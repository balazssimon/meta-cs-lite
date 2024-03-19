#nullable enable

namespace MetaDslx.Examples.Soal.Compiler.Syntax.InternalSyntax
{
    internal class SoalInternalSyntaxVisitor : global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.InternalSyntaxVisitor
    {
        public virtual void VisitSkippedTokensTrivia(GreenSkippedTokensTriviaSyntax node) => this.DefaultVisit(node);
        public virtual void VisitMainGreen(MainGreen node) => this.DefaultVisit(node);
        public virtual void VisitUsingGreen(UsingGreen node) => this.DefaultVisit(node);
        public virtual void VisitDeclarationAlt1Green(DeclarationAlt1Green node) => this.DefaultVisit(node);
        public virtual void VisitDeclarationAlt2Green(DeclarationAlt2Green node) => this.DefaultVisit(node);
        public virtual void VisitDeclarationAlt3Green(DeclarationAlt3Green node) => this.DefaultVisit(node);
        public virtual void VisitDeclarationAlt4Green(DeclarationAlt4Green node) => this.DefaultVisit(node);
        public virtual void VisitEnumTypeGreen(EnumTypeGreen node) => this.DefaultVisit(node);
        public virtual void VisitEnumLiteralGreen(EnumLiteralGreen node) => this.DefaultVisit(node);
        public virtual void VisitStructTypeGreen(StructTypeGreen node) => this.DefaultVisit(node);
        public virtual void VisitPropertyGreen(PropertyGreen node) => this.DefaultVisit(node);
        public virtual void VisitInterfaceGreen(InterfaceGreen node) => this.DefaultVisit(node);
        public virtual void VisitResourceGreen(ResourceGreen node) => this.DefaultVisit(node);
        public virtual void VisitOperationGreen(OperationGreen node) => this.DefaultVisit(node);
        public virtual void VisitInputParameterListGreen(InputParameterListGreen node) => this.DefaultVisit(node);
        public virtual void VisitOutputParameterListAlt1Green(OutputParameterListAlt1Green node) => this.DefaultVisit(node);
        public virtual void VisitOutputParameterListAlt2Green(OutputParameterListAlt2Green node) => this.DefaultVisit(node);
        public virtual void VisitOutputParameterListAlt3Green(OutputParameterListAlt3Green node) => this.DefaultVisit(node);
        public virtual void VisitParameterGreen(ParameterGreen node) => this.DefaultVisit(node);
        public virtual void VisitSingleReturnParameterGreen(SingleReturnParameterGreen node) => this.DefaultVisit(node);
        public virtual void VisitServiceGreen(ServiceGreen node) => this.DefaultVisit(node);
        public virtual void VisitBindingKindGreen(BindingKindGreen node) => this.DefaultVisit(node);
        public virtual void VisitTypeReferenceGreen(TypeReferenceGreen node) => this.DefaultVisit(node);
        public virtual void VisitSimpleTypeAlt1Green(SimpleTypeAlt1Green node) => this.DefaultVisit(node);
        public virtual void VisitSimpleTypeAlt2Green(SimpleTypeAlt2Green node) => this.DefaultVisit(node);
        public virtual void VisitSimpleTypeAlt3Green(SimpleTypeAlt3Green node) => this.DefaultVisit(node);
        public virtual void VisitSimpleTypeAlt4Green(SimpleTypeAlt4Green node) => this.DefaultVisit(node);
        public virtual void VisitSimpleTypeAlt5Green(SimpleTypeAlt5Green node) => this.DefaultVisit(node);
        public virtual void VisitSimpleTypeAlt6Green(SimpleTypeAlt6Green node) => this.DefaultVisit(node);
        public virtual void VisitSimpleTypeAlt7Green(SimpleTypeAlt7Green node) => this.DefaultVisit(node);
        public virtual void VisitSimpleTypeAlt8Green(SimpleTypeAlt8Green node) => this.DefaultVisit(node);
        public virtual void VisitSimpleTypeAlt9Green(SimpleTypeAlt9Green node) => this.DefaultVisit(node);
        public virtual void VisitSimpleTypeAlt10Green(SimpleTypeAlt10Green node) => this.DefaultVisit(node);
        public virtual void VisitSimpleTypeAlt11Green(SimpleTypeAlt11Green node) => this.DefaultVisit(node);
        public virtual void VisitSimpleTypeAlt12Green(SimpleTypeAlt12Green node) => this.DefaultVisit(node);
        public virtual void VisitSimpleTypeAlt13Green(SimpleTypeAlt13Green node) => this.DefaultVisit(node);
        public virtual void VisitNameGreen(NameGreen node) => this.DefaultVisit(node);
        public virtual void VisitQualifierGreen(QualifierGreen node) => this.DefaultVisit(node);
        public virtual void VisitIdentifierGreen(IdentifierGreen node) => this.DefaultVisit(node);
        public virtual void VisitMainBlock1Green(MainBlock1Green node) => this.DefaultVisit(node);
        public virtual void VisitEnumTypeBlock1Green(EnumTypeBlock1Green node) => this.DefaultVisit(node);
        public virtual void VisitEnumTypeBlock1literalsBlockGreen(EnumTypeBlock1literalsBlockGreen node) => this.DefaultVisit(node);
        public virtual void VisitStructTypeBlock1Green(StructTypeBlock1Green node) => this.DefaultVisit(node);
        public virtual void VisitResourceBlock1Green(ResourceBlock1Green node) => this.DefaultVisit(node);
        public virtual void VisitResourceBlock1exceptionsBlockGreen(ResourceBlock1exceptionsBlockGreen node) => this.DefaultVisit(node);
        public virtual void VisitOperationBlock1Green(OperationBlock1Green node) => this.DefaultVisit(node);
        public virtual void VisitOperationBlock1exceptionsBlockGreen(OperationBlock1exceptionsBlockGreen node) => this.DefaultVisit(node);
        public virtual void VisitInputParameterListBlock1Green(InputParameterListBlock1Green node) => this.DefaultVisit(node);
        public virtual void VisitInputParameterListBlock1parametersBlockGreen(InputParameterListBlock1parametersBlockGreen node) => this.DefaultVisit(node);
        public virtual void VisitOutputParameterListAlt3parametersBlockGreen(OutputParameterListAlt3parametersBlockGreen node) => this.DefaultVisit(node);
        public virtual void VisitTypeReferenceBlock1Green(TypeReferenceBlock1Green node) => this.DefaultVisit(node);
        public virtual void VisitQualifierIdentifierBlockGreen(QualifierIdentifierBlockGreen node) => this.DefaultVisit(node);
    }

    internal class SoalInternalSyntaxVisitor<TResult> : global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.InternalSyntaxVisitor<TResult>
    {
        public virtual TResult VisitSkippedTokensTrivia(GreenSkippedTokensTriviaSyntax node) => this.DefaultVisit(node);
        public virtual TResult VisitMainGreen(MainGreen node) => this.DefaultVisit(node);
        public virtual TResult VisitUsingGreen(UsingGreen node) => this.DefaultVisit(node);
        public virtual TResult VisitDeclarationAlt1Green(DeclarationAlt1Green node) => this.DefaultVisit(node);
        public virtual TResult VisitDeclarationAlt2Green(DeclarationAlt2Green node) => this.DefaultVisit(node);
        public virtual TResult VisitDeclarationAlt3Green(DeclarationAlt3Green node) => this.DefaultVisit(node);
        public virtual TResult VisitDeclarationAlt4Green(DeclarationAlt4Green node) => this.DefaultVisit(node);
        public virtual TResult VisitEnumTypeGreen(EnumTypeGreen node) => this.DefaultVisit(node);
        public virtual TResult VisitEnumLiteralGreen(EnumLiteralGreen node) => this.DefaultVisit(node);
        public virtual TResult VisitStructTypeGreen(StructTypeGreen node) => this.DefaultVisit(node);
        public virtual TResult VisitPropertyGreen(PropertyGreen node) => this.DefaultVisit(node);
        public virtual TResult VisitInterfaceGreen(InterfaceGreen node) => this.DefaultVisit(node);
        public virtual TResult VisitResourceGreen(ResourceGreen node) => this.DefaultVisit(node);
        public virtual TResult VisitOperationGreen(OperationGreen node) => this.DefaultVisit(node);
        public virtual TResult VisitInputParameterListGreen(InputParameterListGreen node) => this.DefaultVisit(node);
        public virtual TResult VisitOutputParameterListAlt1Green(OutputParameterListAlt1Green node) => this.DefaultVisit(node);
        public virtual TResult VisitOutputParameterListAlt2Green(OutputParameterListAlt2Green node) => this.DefaultVisit(node);
        public virtual TResult VisitOutputParameterListAlt3Green(OutputParameterListAlt3Green node) => this.DefaultVisit(node);
        public virtual TResult VisitParameterGreen(ParameterGreen node) => this.DefaultVisit(node);
        public virtual TResult VisitSingleReturnParameterGreen(SingleReturnParameterGreen node) => this.DefaultVisit(node);
        public virtual TResult VisitServiceGreen(ServiceGreen node) => this.DefaultVisit(node);
        public virtual TResult VisitBindingKindGreen(BindingKindGreen node) => this.DefaultVisit(node);
        public virtual TResult VisitTypeReferenceGreen(TypeReferenceGreen node) => this.DefaultVisit(node);
        public virtual TResult VisitSimpleTypeAlt1Green(SimpleTypeAlt1Green node) => this.DefaultVisit(node);
        public virtual TResult VisitSimpleTypeAlt2Green(SimpleTypeAlt2Green node) => this.DefaultVisit(node);
        public virtual TResult VisitSimpleTypeAlt3Green(SimpleTypeAlt3Green node) => this.DefaultVisit(node);
        public virtual TResult VisitSimpleTypeAlt4Green(SimpleTypeAlt4Green node) => this.DefaultVisit(node);
        public virtual TResult VisitSimpleTypeAlt5Green(SimpleTypeAlt5Green node) => this.DefaultVisit(node);
        public virtual TResult VisitSimpleTypeAlt6Green(SimpleTypeAlt6Green node) => this.DefaultVisit(node);
        public virtual TResult VisitSimpleTypeAlt7Green(SimpleTypeAlt7Green node) => this.DefaultVisit(node);
        public virtual TResult VisitSimpleTypeAlt8Green(SimpleTypeAlt8Green node) => this.DefaultVisit(node);
        public virtual TResult VisitSimpleTypeAlt9Green(SimpleTypeAlt9Green node) => this.DefaultVisit(node);
        public virtual TResult VisitSimpleTypeAlt10Green(SimpleTypeAlt10Green node) => this.DefaultVisit(node);
        public virtual TResult VisitSimpleTypeAlt11Green(SimpleTypeAlt11Green node) => this.DefaultVisit(node);
        public virtual TResult VisitSimpleTypeAlt12Green(SimpleTypeAlt12Green node) => this.DefaultVisit(node);
        public virtual TResult VisitSimpleTypeAlt13Green(SimpleTypeAlt13Green node) => this.DefaultVisit(node);
        public virtual TResult VisitNameGreen(NameGreen node) => this.DefaultVisit(node);
        public virtual TResult VisitQualifierGreen(QualifierGreen node) => this.DefaultVisit(node);
        public virtual TResult VisitIdentifierGreen(IdentifierGreen node) => this.DefaultVisit(node);
        public virtual TResult VisitMainBlock1Green(MainBlock1Green node) => this.DefaultVisit(node);
        public virtual TResult VisitEnumTypeBlock1Green(EnumTypeBlock1Green node) => this.DefaultVisit(node);
        public virtual TResult VisitEnumTypeBlock1literalsBlockGreen(EnumTypeBlock1literalsBlockGreen node) => this.DefaultVisit(node);
        public virtual TResult VisitStructTypeBlock1Green(StructTypeBlock1Green node) => this.DefaultVisit(node);
        public virtual TResult VisitResourceBlock1Green(ResourceBlock1Green node) => this.DefaultVisit(node);
        public virtual TResult VisitResourceBlock1exceptionsBlockGreen(ResourceBlock1exceptionsBlockGreen node) => this.DefaultVisit(node);
        public virtual TResult VisitOperationBlock1Green(OperationBlock1Green node) => this.DefaultVisit(node);
        public virtual TResult VisitOperationBlock1exceptionsBlockGreen(OperationBlock1exceptionsBlockGreen node) => this.DefaultVisit(node);
        public virtual TResult VisitInputParameterListBlock1Green(InputParameterListBlock1Green node) => this.DefaultVisit(node);
        public virtual TResult VisitInputParameterListBlock1parametersBlockGreen(InputParameterListBlock1parametersBlockGreen node) => this.DefaultVisit(node);
        public virtual TResult VisitOutputParameterListAlt3parametersBlockGreen(OutputParameterListAlt3parametersBlockGreen node) => this.DefaultVisit(node);
        public virtual TResult VisitTypeReferenceBlock1Green(TypeReferenceBlock1Green node) => this.DefaultVisit(node);
        public virtual TResult VisitQualifierIdentifierBlockGreen(QualifierIdentifierBlockGreen node) => this.DefaultVisit(node);
    }
}
