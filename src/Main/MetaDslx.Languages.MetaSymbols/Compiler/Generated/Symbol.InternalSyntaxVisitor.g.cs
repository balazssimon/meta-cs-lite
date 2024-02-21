#nullable enable

namespace MetaDslx.Languages.MetaSymbols.Compiler.Syntax.InternalSyntax
{
    internal class SymbolInternalSyntaxVisitor : global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.InternalSyntaxVisitor
    {
        public virtual void VisitSkippedTokensTrivia(GreenSkippedTokensTriviaSyntax node) => this.DefaultVisit(node);
        public virtual void VisitMainGreen(MainGreen node) => this.DefaultVisit(node);
        public virtual void VisitUsingGreen(UsingGreen node) => this.DefaultVisit(node);
        public virtual void VisitSymbolGreen(SymbolGreen node) => this.DefaultVisit(node);
        public virtual void VisitPropertyGreen(PropertyGreen node) => this.DefaultVisit(node);
        public virtual void VisitOperationAlt1Green(OperationAlt1Green node) => this.DefaultVisit(node);
        public virtual void VisitOperationAlt2Green(OperationAlt2Green node) => this.DefaultVisit(node);
        public virtual void VisitParameterGreen(ParameterGreen node) => this.DefaultVisit(node);
        public virtual void VisitTypeReferenceGreen(TypeReferenceGreen node) => this.DefaultVisit(node);
        public virtual void VisitArrayDimensionsGreen(ArrayDimensionsGreen node) => this.DefaultVisit(node);
        public virtual void VisitSimpleTypeReferenceAlt1Green(SimpleTypeReferenceAlt1Green node) => this.DefaultVisit(node);
        public virtual void VisitSimpleTypeReferenceAlt2Green(SimpleTypeReferenceAlt2Green node) => this.DefaultVisit(node);
        public virtual void VisitPrimitiveTypeGreen(PrimitiveTypeGreen node) => this.DefaultVisit(node);
        public virtual void VisitValueAlt1Green(ValueAlt1Green node) => this.DefaultVisit(node);
        public virtual void VisitValueAlt2Green(ValueAlt2Green node) => this.DefaultVisit(node);
        public virtual void VisitValueAlt3Green(ValueAlt3Green node) => this.DefaultVisit(node);
        public virtual void VisitValueAlt4Green(ValueAlt4Green node) => this.DefaultVisit(node);
        public virtual void VisitValueAlt5Green(ValueAlt5Green node) => this.DefaultVisit(node);
        public virtual void VisitValueAlt6Green(ValueAlt6Green node) => this.DefaultVisit(node);
        public virtual void VisitNameGreen(NameGreen node) => this.DefaultVisit(node);
        public virtual void VisitQualifierGreen(QualifierGreen node) => this.DefaultVisit(node);
        public virtual void VisitIdentifierGreen(IdentifierGreen node) => this.DefaultVisit(node);
        public virtual void VisitTBooleanGreen(TBooleanGreen node) => this.DefaultVisit(node);
        public virtual void VisitMainBlock1Green(MainBlock1Green node) => this.DefaultVisit(node);
        public virtual void VisitSymbolBlock1Green(SymbolBlock1Green node) => this.DefaultVisit(node);
        public virtual void VisitSymbolBlock2Green(SymbolBlock2Green node) => this.DefaultVisit(node);
        public virtual void VisitSymbolBlock2Block1Alt1Green(SymbolBlock2Block1Alt1Green node) => this.DefaultVisit(node);
        public virtual void VisitSymbolBlock2Block1Alt2Green(SymbolBlock2Block1Alt2Green node) => this.DefaultVisit(node);
        public virtual void VisitPropertyBlock1Green(PropertyBlock1Green node) => this.DefaultVisit(node);
        public virtual void VisitPropertyBlock2Green(PropertyBlock2Green node) => this.DefaultVisit(node);
        public virtual void VisitOperationAlt2Block1Green(OperationAlt2Block1Green node) => this.DefaultVisit(node);
        public virtual void VisitOperationAlt2Block1parametersBlockGreen(OperationAlt2Block1parametersBlockGreen node) => this.DefaultVisit(node);
        public virtual void VisitOperationAlt2Block2Green(OperationAlt2Block2Green node) => this.DefaultVisit(node);
        public virtual void VisitTypeReferenceBlock1Green(TypeReferenceBlock1Green node) => this.DefaultVisit(node);
        public virtual void VisitArrayDimensionsBlock1Green(ArrayDimensionsBlock1Green node) => this.DefaultVisit(node);
        public virtual void VisitQualifierIdentifierBlockGreen(QualifierIdentifierBlockGreen node) => this.DefaultVisit(node);
    }

    internal class SymbolInternalSyntaxVisitor<TResult> : global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.InternalSyntaxVisitor<TResult>
    {
        public virtual TResult VisitSkippedTokensTrivia(GreenSkippedTokensTriviaSyntax node) => this.DefaultVisit(node);
        public virtual TResult VisitMainGreen(MainGreen node) => this.DefaultVisit(node);
        public virtual TResult VisitUsingGreen(UsingGreen node) => this.DefaultVisit(node);
        public virtual TResult VisitSymbolGreen(SymbolGreen node) => this.DefaultVisit(node);
        public virtual TResult VisitPropertyGreen(PropertyGreen node) => this.DefaultVisit(node);
        public virtual TResult VisitOperationAlt1Green(OperationAlt1Green node) => this.DefaultVisit(node);
        public virtual TResult VisitOperationAlt2Green(OperationAlt2Green node) => this.DefaultVisit(node);
        public virtual TResult VisitParameterGreen(ParameterGreen node) => this.DefaultVisit(node);
        public virtual TResult VisitTypeReferenceGreen(TypeReferenceGreen node) => this.DefaultVisit(node);
        public virtual TResult VisitArrayDimensionsGreen(ArrayDimensionsGreen node) => this.DefaultVisit(node);
        public virtual TResult VisitSimpleTypeReferenceAlt1Green(SimpleTypeReferenceAlt1Green node) => this.DefaultVisit(node);
        public virtual TResult VisitSimpleTypeReferenceAlt2Green(SimpleTypeReferenceAlt2Green node) => this.DefaultVisit(node);
        public virtual TResult VisitPrimitiveTypeGreen(PrimitiveTypeGreen node) => this.DefaultVisit(node);
        public virtual TResult VisitValueAlt1Green(ValueAlt1Green node) => this.DefaultVisit(node);
        public virtual TResult VisitValueAlt2Green(ValueAlt2Green node) => this.DefaultVisit(node);
        public virtual TResult VisitValueAlt3Green(ValueAlt3Green node) => this.DefaultVisit(node);
        public virtual TResult VisitValueAlt4Green(ValueAlt4Green node) => this.DefaultVisit(node);
        public virtual TResult VisitValueAlt5Green(ValueAlt5Green node) => this.DefaultVisit(node);
        public virtual TResult VisitValueAlt6Green(ValueAlt6Green node) => this.DefaultVisit(node);
        public virtual TResult VisitNameGreen(NameGreen node) => this.DefaultVisit(node);
        public virtual TResult VisitQualifierGreen(QualifierGreen node) => this.DefaultVisit(node);
        public virtual TResult VisitIdentifierGreen(IdentifierGreen node) => this.DefaultVisit(node);
        public virtual TResult VisitTBooleanGreen(TBooleanGreen node) => this.DefaultVisit(node);
        public virtual TResult VisitMainBlock1Green(MainBlock1Green node) => this.DefaultVisit(node);
        public virtual TResult VisitSymbolBlock1Green(SymbolBlock1Green node) => this.DefaultVisit(node);
        public virtual TResult VisitSymbolBlock2Green(SymbolBlock2Green node) => this.DefaultVisit(node);
        public virtual TResult VisitSymbolBlock2Block1Alt1Green(SymbolBlock2Block1Alt1Green node) => this.DefaultVisit(node);
        public virtual TResult VisitSymbolBlock2Block1Alt2Green(SymbolBlock2Block1Alt2Green node) => this.DefaultVisit(node);
        public virtual TResult VisitPropertyBlock1Green(PropertyBlock1Green node) => this.DefaultVisit(node);
        public virtual TResult VisitPropertyBlock2Green(PropertyBlock2Green node) => this.DefaultVisit(node);
        public virtual TResult VisitOperationAlt2Block1Green(OperationAlt2Block1Green node) => this.DefaultVisit(node);
        public virtual TResult VisitOperationAlt2Block1parametersBlockGreen(OperationAlt2Block1parametersBlockGreen node) => this.DefaultVisit(node);
        public virtual TResult VisitOperationAlt2Block2Green(OperationAlt2Block2Green node) => this.DefaultVisit(node);
        public virtual TResult VisitTypeReferenceBlock1Green(TypeReferenceBlock1Green node) => this.DefaultVisit(node);
        public virtual TResult VisitArrayDimensionsBlock1Green(ArrayDimensionsBlock1Green node) => this.DefaultVisit(node);
        public virtual TResult VisitQualifierIdentifierBlockGreen(QualifierIdentifierBlockGreen node) => this.DefaultVisit(node);
    }
}
