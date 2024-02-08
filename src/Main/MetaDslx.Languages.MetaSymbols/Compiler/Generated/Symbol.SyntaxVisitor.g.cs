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

namespace MetaDslx.Languages.MetaSymbols.Compiler.Syntax
{

    public interface ISymbolSyntaxVisitor
    {
        void VisitSkippedTokensTrivia(SymbolSkippedTokensTriviaSyntax node);
        void VisitMain(MainSyntax node);
        void VisitUsing(UsingSyntax node);
        void VisitSymbol(SymbolSyntax node);
        void VisitProperty(PropertySyntax node);
        void VisitOperation(OperationSyntax node);
        void VisitParameter(ParameterSyntax node);
        void VisitTypeReference(TypeReferenceSyntax node);
        void VisitArrayDimensions(ArrayDimensionsSyntax node);
        void VisitSimpleTypeReferenceAlt1(SimpleTypeReferenceAlt1Syntax node);
        void VisitSimpleTypeReferenceAlt2(SimpleTypeReferenceAlt2Syntax node);
        void VisitPrimitiveType(PrimitiveTypeSyntax node);
        void VisitValueAlt1(ValueAlt1Syntax node);
        void VisitValueAlt2(ValueAlt2Syntax node);
        void VisitValueAlt3(ValueAlt3Syntax node);
        void VisitValueAlt4(ValueAlt4Syntax node);
        void VisitValueAlt5(ValueAlt5Syntax node);
        void VisitValueAlt6(ValueAlt6Syntax node);
        void VisitName(NameSyntax node);
        void VisitQualifier(QualifierSyntax node);
        void VisitIdentifier(IdentifierSyntax node);
        void VisitTBoolean(TBooleanSyntax node);
        void VisitMainBlock1(MainBlock1Syntax node);
        void VisitSymbolBlock1(SymbolBlock1Syntax node);
        void VisitSymbolBlock1baseTypesBlock(SymbolBlock1baseTypesBlockSyntax node);
        void VisitSymbolBlock2(SymbolBlock2Syntax node);
        void VisitSymbolBlock2Block1Alt1(SymbolBlock2Block1Alt1Syntax node);
        void VisitSymbolBlock2Block1Alt2(SymbolBlock2Block1Alt2Syntax node);
        void VisitPropertyBlock1Alt1(PropertyBlock1Alt1Syntax node);
        void VisitPropertyBlock1Alt2(PropertyBlock1Alt2Syntax node);
        void VisitPropertyBlock2(PropertyBlock2Syntax node);
        void VisitOperationBlock1(OperationBlock1Syntax node);
        void VisitOperationBlock1parametersBlock(OperationBlock1parametersBlockSyntax node);
        void VisitTypeReferenceBlock1(TypeReferenceBlock1Syntax node);
        void VisitArrayDimensionsBlock1(ArrayDimensionsBlock1Syntax node);
        void VisitQualifierIdentifierBlock(QualifierIdentifierBlockSyntax node);
    }

    public class SymbolSyntaxVisitor : SyntaxVisitor, ISymbolSyntaxVisitor
    {
        public virtual void VisitSkippedTokensTrivia(SymbolSkippedTokensTriviaSyntax node)
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

        public virtual void VisitSymbol(SymbolSyntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitProperty(PropertySyntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitOperation(OperationSyntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitParameter(ParameterSyntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitTypeReference(TypeReferenceSyntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitArrayDimensions(ArrayDimensionsSyntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitSimpleTypeReferenceAlt1(SimpleTypeReferenceAlt1Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitSimpleTypeReferenceAlt2(SimpleTypeReferenceAlt2Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitPrimitiveType(PrimitiveTypeSyntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitValueAlt1(ValueAlt1Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitValueAlt2(ValueAlt2Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitValueAlt3(ValueAlt3Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitValueAlt4(ValueAlt4Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitValueAlt5(ValueAlt5Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitValueAlt6(ValueAlt6Syntax node)
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

        public virtual void VisitTBoolean(TBooleanSyntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitMainBlock1(MainBlock1Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitSymbolBlock1(SymbolBlock1Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitSymbolBlock1baseTypesBlock(SymbolBlock1baseTypesBlockSyntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitSymbolBlock2(SymbolBlock2Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitSymbolBlock2Block1Alt1(SymbolBlock2Block1Alt1Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitSymbolBlock2Block1Alt2(SymbolBlock2Block1Alt2Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitPropertyBlock1Alt1(PropertyBlock1Alt1Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitPropertyBlock1Alt2(PropertyBlock1Alt2Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitPropertyBlock2(PropertyBlock2Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitOperationBlock1(OperationBlock1Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitOperationBlock1parametersBlock(OperationBlock1parametersBlockSyntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitTypeReferenceBlock1(TypeReferenceBlock1Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitArrayDimensionsBlock1(ArrayDimensionsBlock1Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitQualifierIdentifierBlock(QualifierIdentifierBlockSyntax node)
        {
            this.DefaultVisit(node);
        }

    }

    public interface ISymbolSyntaxVisitor<TResult> 
    {
        TResult VisitSkippedTokensTrivia(SymbolSkippedTokensTriviaSyntax node);
        TResult VisitMain(MainSyntax node);
        TResult VisitUsing(UsingSyntax node);
        TResult VisitSymbol(SymbolSyntax node);
        TResult VisitProperty(PropertySyntax node);
        TResult VisitOperation(OperationSyntax node);
        TResult VisitParameter(ParameterSyntax node);
        TResult VisitTypeReference(TypeReferenceSyntax node);
        TResult VisitArrayDimensions(ArrayDimensionsSyntax node);
        TResult VisitSimpleTypeReferenceAlt1(SimpleTypeReferenceAlt1Syntax node);
        TResult VisitSimpleTypeReferenceAlt2(SimpleTypeReferenceAlt2Syntax node);
        TResult VisitPrimitiveType(PrimitiveTypeSyntax node);
        TResult VisitValueAlt1(ValueAlt1Syntax node);
        TResult VisitValueAlt2(ValueAlt2Syntax node);
        TResult VisitValueAlt3(ValueAlt3Syntax node);
        TResult VisitValueAlt4(ValueAlt4Syntax node);
        TResult VisitValueAlt5(ValueAlt5Syntax node);
        TResult VisitValueAlt6(ValueAlt6Syntax node);
        TResult VisitName(NameSyntax node);
        TResult VisitQualifier(QualifierSyntax node);
        TResult VisitIdentifier(IdentifierSyntax node);
        TResult VisitTBoolean(TBooleanSyntax node);
        TResult VisitMainBlock1(MainBlock1Syntax node);
        TResult VisitSymbolBlock1(SymbolBlock1Syntax node);
        TResult VisitSymbolBlock1baseTypesBlock(SymbolBlock1baseTypesBlockSyntax node);
        TResult VisitSymbolBlock2(SymbolBlock2Syntax node);
        TResult VisitSymbolBlock2Block1Alt1(SymbolBlock2Block1Alt1Syntax node);
        TResult VisitSymbolBlock2Block1Alt2(SymbolBlock2Block1Alt2Syntax node);
        TResult VisitPropertyBlock1Alt1(PropertyBlock1Alt1Syntax node);
        TResult VisitPropertyBlock1Alt2(PropertyBlock1Alt2Syntax node);
        TResult VisitPropertyBlock2(PropertyBlock2Syntax node);
        TResult VisitOperationBlock1(OperationBlock1Syntax node);
        TResult VisitOperationBlock1parametersBlock(OperationBlock1parametersBlockSyntax node);
        TResult VisitTypeReferenceBlock1(TypeReferenceBlock1Syntax node);
        TResult VisitArrayDimensionsBlock1(ArrayDimensionsBlock1Syntax node);
        TResult VisitQualifierIdentifierBlock(QualifierIdentifierBlockSyntax node);
    }

    public class SymbolSyntaxVisitor<TResult> : SyntaxVisitor<TResult>, ISymbolSyntaxVisitor<TResult>
    {
        public virtual TResult VisitSkippedTokensTrivia(SymbolSkippedTokensTriviaSyntax node)
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

        public virtual TResult VisitSymbol(SymbolSyntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitProperty(PropertySyntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitOperation(OperationSyntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitParameter(ParameterSyntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitTypeReference(TypeReferenceSyntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitArrayDimensions(ArrayDimensionsSyntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitSimpleTypeReferenceAlt1(SimpleTypeReferenceAlt1Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitSimpleTypeReferenceAlt2(SimpleTypeReferenceAlt2Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitPrimitiveType(PrimitiveTypeSyntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitValueAlt1(ValueAlt1Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitValueAlt2(ValueAlt2Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitValueAlt3(ValueAlt3Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitValueAlt4(ValueAlt4Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitValueAlt5(ValueAlt5Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitValueAlt6(ValueAlt6Syntax node)
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

        public virtual TResult VisitTBoolean(TBooleanSyntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitMainBlock1(MainBlock1Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitSymbolBlock1(SymbolBlock1Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitSymbolBlock1baseTypesBlock(SymbolBlock1baseTypesBlockSyntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitSymbolBlock2(SymbolBlock2Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitSymbolBlock2Block1Alt1(SymbolBlock2Block1Alt1Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitSymbolBlock2Block1Alt2(SymbolBlock2Block1Alt2Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitPropertyBlock1Alt1(PropertyBlock1Alt1Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitPropertyBlock1Alt2(PropertyBlock1Alt2Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitPropertyBlock2(PropertyBlock2Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitOperationBlock1(OperationBlock1Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitOperationBlock1parametersBlock(OperationBlock1parametersBlockSyntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitTypeReferenceBlock1(TypeReferenceBlock1Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitArrayDimensionsBlock1(ArrayDimensionsBlock1Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitQualifierIdentifierBlock(QualifierIdentifierBlockSyntax node)
        {
            return this.DefaultVisit(node);
        }

    }

    public interface ISymbolSyntaxVisitor<TArg, TResult> 
    {
        TResult VisitSkippedTokensTrivia(SymbolSkippedTokensTriviaSyntax node, TArg argument);
        TResult VisitMain(MainSyntax node, TArg argument);
        TResult VisitUsing(UsingSyntax node, TArg argument);
        TResult VisitSymbol(SymbolSyntax node, TArg argument);
        TResult VisitProperty(PropertySyntax node, TArg argument);
        TResult VisitOperation(OperationSyntax node, TArg argument);
        TResult VisitParameter(ParameterSyntax node, TArg argument);
        TResult VisitTypeReference(TypeReferenceSyntax node, TArg argument);
        TResult VisitArrayDimensions(ArrayDimensionsSyntax node, TArg argument);
        TResult VisitSimpleTypeReferenceAlt1(SimpleTypeReferenceAlt1Syntax node, TArg argument);
        TResult VisitSimpleTypeReferenceAlt2(SimpleTypeReferenceAlt2Syntax node, TArg argument);
        TResult VisitPrimitiveType(PrimitiveTypeSyntax node, TArg argument);
        TResult VisitValueAlt1(ValueAlt1Syntax node, TArg argument);
        TResult VisitValueAlt2(ValueAlt2Syntax node, TArg argument);
        TResult VisitValueAlt3(ValueAlt3Syntax node, TArg argument);
        TResult VisitValueAlt4(ValueAlt4Syntax node, TArg argument);
        TResult VisitValueAlt5(ValueAlt5Syntax node, TArg argument);
        TResult VisitValueAlt6(ValueAlt6Syntax node, TArg argument);
        TResult VisitName(NameSyntax node, TArg argument);
        TResult VisitQualifier(QualifierSyntax node, TArg argument);
        TResult VisitIdentifier(IdentifierSyntax node, TArg argument);
        TResult VisitTBoolean(TBooleanSyntax node, TArg argument);
        TResult VisitMainBlock1(MainBlock1Syntax node, TArg argument);
        TResult VisitSymbolBlock1(SymbolBlock1Syntax node, TArg argument);
        TResult VisitSymbolBlock1baseTypesBlock(SymbolBlock1baseTypesBlockSyntax node, TArg argument);
        TResult VisitSymbolBlock2(SymbolBlock2Syntax node, TArg argument);
        TResult VisitSymbolBlock2Block1Alt1(SymbolBlock2Block1Alt1Syntax node, TArg argument);
        TResult VisitSymbolBlock2Block1Alt2(SymbolBlock2Block1Alt2Syntax node, TArg argument);
        TResult VisitPropertyBlock1Alt1(PropertyBlock1Alt1Syntax node, TArg argument);
        TResult VisitPropertyBlock1Alt2(PropertyBlock1Alt2Syntax node, TArg argument);
        TResult VisitPropertyBlock2(PropertyBlock2Syntax node, TArg argument);
        TResult VisitOperationBlock1(OperationBlock1Syntax node, TArg argument);
        TResult VisitOperationBlock1parametersBlock(OperationBlock1parametersBlockSyntax node, TArg argument);
        TResult VisitTypeReferenceBlock1(TypeReferenceBlock1Syntax node, TArg argument);
        TResult VisitArrayDimensionsBlock1(ArrayDimensionsBlock1Syntax node, TArg argument);
        TResult VisitQualifierIdentifierBlock(QualifierIdentifierBlockSyntax node, TArg argument);
    }

    public class SymbolSyntaxVisitor<TArg, TResult> : SyntaxVisitor<TArg, TResult>, ISymbolSyntaxVisitor<TArg, TResult>
    {
        public virtual TResult VisitSkippedTokensTrivia(SymbolSkippedTokensTriviaSyntax node, TArg argument)
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

        public virtual TResult VisitSymbol(SymbolSyntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitProperty(PropertySyntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitOperation(OperationSyntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitParameter(ParameterSyntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitTypeReference(TypeReferenceSyntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitArrayDimensions(ArrayDimensionsSyntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitSimpleTypeReferenceAlt1(SimpleTypeReferenceAlt1Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitSimpleTypeReferenceAlt2(SimpleTypeReferenceAlt2Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitPrimitiveType(PrimitiveTypeSyntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitValueAlt1(ValueAlt1Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitValueAlt2(ValueAlt2Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitValueAlt3(ValueAlt3Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitValueAlt4(ValueAlt4Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitValueAlt5(ValueAlt5Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitValueAlt6(ValueAlt6Syntax node, TArg argument)
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

        public virtual TResult VisitTBoolean(TBooleanSyntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitMainBlock1(MainBlock1Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitSymbolBlock1(SymbolBlock1Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitSymbolBlock1baseTypesBlock(SymbolBlock1baseTypesBlockSyntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitSymbolBlock2(SymbolBlock2Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitSymbolBlock2Block1Alt1(SymbolBlock2Block1Alt1Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitSymbolBlock2Block1Alt2(SymbolBlock2Block1Alt2Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitPropertyBlock1Alt1(PropertyBlock1Alt1Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitPropertyBlock1Alt2(PropertyBlock1Alt2Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitPropertyBlock2(PropertyBlock2Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitOperationBlock1(OperationBlock1Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitOperationBlock1parametersBlock(OperationBlock1parametersBlockSyntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitTypeReferenceBlock1(TypeReferenceBlock1Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitArrayDimensionsBlock1(ArrayDimensionsBlock1Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitQualifierIdentifierBlock(QualifierIdentifierBlockSyntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

    }

    public class SymbolSyntaxRewriter : SyntaxRewriter, ISymbolSyntaxVisitor<SyntaxNode?>
    {
        public SymbolSyntaxRewriter(bool visitIntoStructuredTrivia = false)
            : base(SymbolLanguage.Instance, visitIntoStructuredTrivia)
        {
        }
    
        public virtual SyntaxNode VisitSkippedTokensTrivia(SymbolSkippedTokensTriviaSyntax node)
        {
          var tokens = this.VisitList(node.Tokens);
          return node.Update(tokens);
        }

        public virtual SyntaxNode VisitMain(MainSyntax node)
        {
            var kNamespace = this.VisitToken(node.KNamespace);
            var qualifier = (QualifierSyntax)this.Visit(node.Qualifier);
            var usingList = this.VisitList(node.UsingList);
            var block = (MainBlock1Syntax)this.Visit(node.Block);
            var endOfFileToken = this.VisitToken(node.EndOfFileToken);
            return node.Update(kNamespace, qualifier, usingList, block, endOfFileToken);
        }

        public virtual SyntaxNode VisitUsing(UsingSyntax node)
        {
            var kUsing = this.VisitToken(node.KUsing);
            var namespaces = (QualifierSyntax)this.Visit(node.Namespaces);
            return node.Update(kUsing, namespaces);
        }

        public virtual SyntaxNode VisitSymbol(SymbolSyntax node)
        {
            var isAbstract = this.VisitToken(node.IsAbstract);
            var kSymbol = this.VisitToken(node.KSymbol);
            var name = (NameSyntax)this.Visit(node.Name);
            var block1 = (SymbolBlock1Syntax)this.Visit(node.Block1);
            var block2 = (SymbolBlock2Syntax)this.Visit(node.Block2);
            return node.Update(isAbstract, kSymbol, name, block1, block2);
        }

        public virtual SyntaxNode VisitProperty(PropertySyntax node)
        {
            var block1 = (PropertyBlock1Syntax)this.Visit(node.Block1);
            var type = (TypeReferenceSyntax)this.Visit(node.Type);
            var name = (NameSyntax)this.Visit(node.Name);
            var block2 = (PropertyBlock2Syntax)this.Visit(node.Block2);
            return node.Update(block1, type, name, block2);
        }

        public virtual SyntaxNode VisitOperation(OperationSyntax node)
        {
            var returnType = (TypeReferenceSyntax)this.Visit(node.ReturnType);
            var name = (NameSyntax)this.Visit(node.Name);
            var tLParen = this.VisitToken(node.TLParen);
            var block = (OperationBlock1Syntax)this.Visit(node.Block);
            var tRParen = this.VisitToken(node.TRParen);
            return node.Update(returnType, name, tLParen, block, tRParen);
        }

        public virtual SyntaxNode VisitParameter(ParameterSyntax node)
        {
            var type = (TypeReferenceSyntax)this.Visit(node.Type);
            var name = (NameSyntax)this.Visit(node.Name);
            return node.Update(type, name);
        }

        public virtual SyntaxNode VisitTypeReference(TypeReferenceSyntax node)
        {
            var type = (SimpleTypeReferenceSyntax)this.Visit(node.Type);
            var block = (TypeReferenceBlock1Syntax)this.Visit(node.Block);
            var dimensions = (ArrayDimensionsSyntax)this.Visit(node.Dimensions);
            return node.Update(type, block, dimensions);
        }

        public virtual SyntaxNode VisitArrayDimensions(ArrayDimensionsSyntax node)
        {
            var block = this.VisitList(node.Block);
            return node.Update(block);
        }

        public virtual SyntaxNode VisitSimpleTypeReferenceAlt1(SimpleTypeReferenceAlt1Syntax node)
        {
            var primitiveType = (PrimitiveTypeSyntax)this.Visit(node.PrimitiveType);
            return node.Update(primitiveType);
        }

        public virtual SyntaxNode VisitSimpleTypeReferenceAlt2(SimpleTypeReferenceAlt2Syntax node)
        {
            var qualifier = (QualifierSyntax)this.Visit(node.Qualifier);
            return node.Update(qualifier);
        }

        public virtual SyntaxNode VisitPrimitiveType(PrimitiveTypeSyntax node)
        {
            var token = this.VisitToken(node.Token);
            return node.Update(token);
        }

        public virtual SyntaxNode VisitValueAlt1(ValueAlt1Syntax node)
        {
            var tString = this.VisitToken(node.TString);
            return node.Update(tString);
        }

        public virtual SyntaxNode VisitValueAlt2(ValueAlt2Syntax node)
        {
            var tInteger = this.VisitToken(node.TInteger);
            return node.Update(tInteger);
        }

        public virtual SyntaxNode VisitValueAlt3(ValueAlt3Syntax node)
        {
            var tDecimal = this.VisitToken(node.TDecimal);
            return node.Update(tDecimal);
        }

        public virtual SyntaxNode VisitValueAlt4(ValueAlt4Syntax node)
        {
            var tBoolean = (TBooleanSyntax)this.Visit(node.TBoolean);
            return node.Update(tBoolean);
        }

        public virtual SyntaxNode VisitValueAlt5(ValueAlt5Syntax node)
        {
            var kNull = this.VisitToken(node.KNull);
            return node.Update(kNull);
        }

        public virtual SyntaxNode VisitValueAlt6(ValueAlt6Syntax node)
        {
            var qualifier = (QualifierSyntax)this.Visit(node.Qualifier);
            return node.Update(qualifier);
        }

        public virtual SyntaxNode VisitName(NameSyntax node)
        {
            var identifier = (IdentifierSyntax)this.Visit(node.Identifier);
            return node.Update(identifier);
        }

        public virtual SyntaxNode VisitQualifier(QualifierSyntax node)
        {
            var identifier = this.VisitList(node.Identifier);
            return node.Update(identifier);
        }

        public virtual SyntaxNode VisitIdentifier(IdentifierSyntax node)
        {
            var token = this.VisitToken(node.Token);
            return node.Update(token);
        }

        public virtual SyntaxNode VisitTBoolean(TBooleanSyntax node)
        {
            var token = this.VisitToken(node.Token);
            return node.Update(token);
        }

        public virtual SyntaxNode VisitMainBlock1(MainBlock1Syntax node)
        {
            var declarations = this.VisitList(node.Declarations);
            return node.Update(declarations);
        }

        public virtual SyntaxNode VisitSymbolBlock1(SymbolBlock1Syntax node)
        {
            var tColon = this.VisitToken(node.TColon);
            var baseTypes = this.VisitList(node.BaseTypes);
            return node.Update(tColon, baseTypes);
        }

        public virtual SyntaxNode VisitSymbolBlock1baseTypesBlock(SymbolBlock1baseTypesBlockSyntax node)
        {
            var tComma = this.VisitToken(node.TComma);
            var baseTypes = (QualifierSyntax)this.Visit(node.BaseTypes);
            return node.Update(tComma, baseTypes);
        }

        public virtual SyntaxNode VisitSymbolBlock2(SymbolBlock2Syntax node)
        {
            var tLBrace = this.VisitToken(node.TLBrace);
            var block = this.VisitList(node.Block);
            var tRBrace = this.VisitToken(node.TRBrace);
            return node.Update(tLBrace, block, tRBrace);
        }

        public virtual SyntaxNode VisitSymbolBlock2Block1Alt1(SymbolBlock2Block1Alt1Syntax node)
        {
            var properties = (PropertySyntax)this.Visit(node.Properties);
            return node.Update(properties);
        }

        public virtual SyntaxNode VisitSymbolBlock2Block1Alt2(SymbolBlock2Block1Alt2Syntax node)
        {
            var operations = (OperationSyntax)this.Visit(node.Operations);
            return node.Update(operations);
        }

        public virtual SyntaxNode VisitPropertyBlock1Alt1(PropertyBlock1Alt1Syntax node)
        {
            var isWeak = this.VisitToken(node.IsWeak);
            return node.Update(isWeak);
        }

        public virtual SyntaxNode VisitPropertyBlock1Alt2(PropertyBlock1Alt2Syntax node)
        {
            var isDerived = this.VisitToken(node.IsDerived);
            return node.Update(isDerived);
        }

        public virtual SyntaxNode VisitPropertyBlock2(PropertyBlock2Syntax node)
        {
            var tEq = this.VisitToken(node.TEq);
            var defaultValue = (ValueSyntax)this.Visit(node.DefaultValue);
            return node.Update(tEq, defaultValue);
        }

        public virtual SyntaxNode VisitOperationBlock1(OperationBlock1Syntax node)
        {
            var parameters = this.VisitList(node.Parameters);
            return node.Update(parameters);
        }

        public virtual SyntaxNode VisitOperationBlock1parametersBlock(OperationBlock1parametersBlockSyntax node)
        {
            var tComma = this.VisitToken(node.TComma);
            var parameters = (ParameterSyntax)this.Visit(node.Parameters);
            return node.Update(tComma, parameters);
        }

        public virtual SyntaxNode VisitTypeReferenceBlock1(TypeReferenceBlock1Syntax node)
        {
            var isNullable = this.VisitToken(node.IsNullable);
            return node.Update(isNullable);
        }

        public virtual SyntaxNode VisitArrayDimensionsBlock1(ArrayDimensionsBlock1Syntax node)
        {
            var tLBracket = this.VisitToken(node.TLBracket);
            var tRBracket = this.VisitToken(node.TRBracket);
            return node.Update(tLBracket, tRBracket);
        }

        public virtual SyntaxNode VisitQualifierIdentifierBlock(QualifierIdentifierBlockSyntax node)
        {
            var tDot = this.VisitToken(node.TDot);
            var identifier = (IdentifierSyntax)this.Visit(node.Identifier);
            return node.Update(tDot, identifier);
        }

    }
}
