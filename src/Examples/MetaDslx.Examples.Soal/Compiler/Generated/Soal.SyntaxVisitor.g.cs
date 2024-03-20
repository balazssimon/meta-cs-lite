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

namespace MetaDslx.Examples.Soal.Compiler.Syntax
{

    public interface ISoalSyntaxVisitor
    {
        void VisitSkippedTokensTrivia(SoalSkippedTokensTriviaSyntax node);
        void VisitMain(MainSyntax node);
        void VisitUsing(UsingSyntax node);
        void VisitDeclarationAlt1(DeclarationAlt1Syntax node);
        void VisitDeclarationAlt2(DeclarationAlt2Syntax node);
        void VisitDeclarationAlt3(DeclarationAlt3Syntax node);
        void VisitDeclarationAlt4(DeclarationAlt4Syntax node);
        void VisitEnumType(EnumTypeSyntax node);
        void VisitEnumLiteral(EnumLiteralSyntax node);
        void VisitStructType(StructTypeSyntax node);
        void VisitProperty(PropertySyntax node);
        void VisitInterface(InterfaceSyntax node);
        void VisitResource(ResourceSyntax node);
        void VisitOperation(OperationSyntax node);
        void VisitInputParameterList(InputParameterListSyntax node);
        void VisitOutputParameterListAlt1(OutputParameterListAlt1Syntax node);
        void VisitOutputParameterListAlt2(OutputParameterListAlt2Syntax node);
        void VisitOutputParameterListAlt3(OutputParameterListAlt3Syntax node);
        void VisitParameter(ParameterSyntax node);
        void VisitSingleReturnParameter(SingleReturnParameterSyntax node);
        void VisitService(ServiceSyntax node);
        void VisitBindingKind(BindingKindSyntax node);
        void VisitTypeReference(TypeReferenceSyntax node);
        void VisitSimpleTypeAlt1(SimpleTypeAlt1Syntax node);
        void VisitSimpleTypeAlt2(SimpleTypeAlt2Syntax node);
        void VisitSimpleTypeAlt3(SimpleTypeAlt3Syntax node);
        void VisitSimpleTypeAlt4(SimpleTypeAlt4Syntax node);
        void VisitSimpleTypeAlt5(SimpleTypeAlt5Syntax node);
        void VisitSimpleTypeAlt6(SimpleTypeAlt6Syntax node);
        void VisitSimpleTypeAlt7(SimpleTypeAlt7Syntax node);
        void VisitSimpleTypeAlt8(SimpleTypeAlt8Syntax node);
        void VisitSimpleTypeAlt9(SimpleTypeAlt9Syntax node);
        void VisitSimpleTypeAlt10(SimpleTypeAlt10Syntax node);
        void VisitSimpleTypeAlt11(SimpleTypeAlt11Syntax node);
        void VisitSimpleTypeAlt12(SimpleTypeAlt12Syntax node);
        void VisitSimpleTypeAlt13(SimpleTypeAlt13Syntax node);
        void VisitName(NameSyntax node);
        void VisitQualifier(QualifierSyntax node);
        void VisitIdentifier(IdentifierSyntax node);
        void VisitMainBlock1(MainBlock1Syntax node);
        void VisitEnumTypeBlock1(EnumTypeBlock1Syntax node);
        void VisitEnumTypeBlock1literalsBlock(EnumTypeBlock1literalsBlockSyntax node);
        void VisitStructTypeBlock1(StructTypeBlock1Syntax node);
        void VisitResourceBlock1(ResourceBlock1Syntax node);
        void VisitResourceBlock1exceptionsBlock(ResourceBlock1exceptionsBlockSyntax node);
        void VisitOperationBlock1(OperationBlock1Syntax node);
        void VisitOperationBlock1exceptionsBlock(OperationBlock1exceptionsBlockSyntax node);
        void VisitInputParameterListBlock1(InputParameterListBlock1Syntax node);
        void VisitInputParameterListBlock1parametersBlock(InputParameterListBlock1parametersBlockSyntax node);
        void VisitOutputParameterListAlt3parametersBlock(OutputParameterListAlt3parametersBlockSyntax node);
        void VisitTypeReferenceBlock1(TypeReferenceBlock1Syntax node);
        void VisitQualifierIdentifierBlock(QualifierIdentifierBlockSyntax node);
    }

    public class SoalSyntaxVisitor : SyntaxVisitor, ISoalSyntaxVisitor
    {
        public virtual void VisitSkippedTokensTrivia(SoalSkippedTokensTriviaSyntax node)
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

        public virtual void VisitDeclarationAlt1(DeclarationAlt1Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitDeclarationAlt2(DeclarationAlt2Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitDeclarationAlt3(DeclarationAlt3Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitDeclarationAlt4(DeclarationAlt4Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitEnumType(EnumTypeSyntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitEnumLiteral(EnumLiteralSyntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitStructType(StructTypeSyntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitProperty(PropertySyntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitInterface(InterfaceSyntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitResource(ResourceSyntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitOperation(OperationSyntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitInputParameterList(InputParameterListSyntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitOutputParameterListAlt1(OutputParameterListAlt1Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitOutputParameterListAlt2(OutputParameterListAlt2Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitOutputParameterListAlt3(OutputParameterListAlt3Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitParameter(ParameterSyntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitSingleReturnParameter(SingleReturnParameterSyntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitService(ServiceSyntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitBindingKind(BindingKindSyntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitTypeReference(TypeReferenceSyntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitSimpleTypeAlt1(SimpleTypeAlt1Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitSimpleTypeAlt2(SimpleTypeAlt2Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitSimpleTypeAlt3(SimpleTypeAlt3Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitSimpleTypeAlt4(SimpleTypeAlt4Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitSimpleTypeAlt5(SimpleTypeAlt5Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitSimpleTypeAlt6(SimpleTypeAlt6Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitSimpleTypeAlt7(SimpleTypeAlt7Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitSimpleTypeAlt8(SimpleTypeAlt8Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitSimpleTypeAlt9(SimpleTypeAlt9Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitSimpleTypeAlt10(SimpleTypeAlt10Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitSimpleTypeAlt11(SimpleTypeAlt11Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitSimpleTypeAlt12(SimpleTypeAlt12Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitSimpleTypeAlt13(SimpleTypeAlt13Syntax node)
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

        public virtual void VisitMainBlock1(MainBlock1Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitEnumTypeBlock1(EnumTypeBlock1Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitEnumTypeBlock1literalsBlock(EnumTypeBlock1literalsBlockSyntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitStructTypeBlock1(StructTypeBlock1Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitResourceBlock1(ResourceBlock1Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitResourceBlock1exceptionsBlock(ResourceBlock1exceptionsBlockSyntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitOperationBlock1(OperationBlock1Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitOperationBlock1exceptionsBlock(OperationBlock1exceptionsBlockSyntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitInputParameterListBlock1(InputParameterListBlock1Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitInputParameterListBlock1parametersBlock(InputParameterListBlock1parametersBlockSyntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitOutputParameterListAlt3parametersBlock(OutputParameterListAlt3parametersBlockSyntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitTypeReferenceBlock1(TypeReferenceBlock1Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitQualifierIdentifierBlock(QualifierIdentifierBlockSyntax node)
        {
            this.DefaultVisit(node);
        }

    }

    public interface ISoalSyntaxVisitor<TResult> 
    {
        TResult VisitSkippedTokensTrivia(SoalSkippedTokensTriviaSyntax node);
        TResult VisitMain(MainSyntax node);
        TResult VisitUsing(UsingSyntax node);
        TResult VisitDeclarationAlt1(DeclarationAlt1Syntax node);
        TResult VisitDeclarationAlt2(DeclarationAlt2Syntax node);
        TResult VisitDeclarationAlt3(DeclarationAlt3Syntax node);
        TResult VisitDeclarationAlt4(DeclarationAlt4Syntax node);
        TResult VisitEnumType(EnumTypeSyntax node);
        TResult VisitEnumLiteral(EnumLiteralSyntax node);
        TResult VisitStructType(StructTypeSyntax node);
        TResult VisitProperty(PropertySyntax node);
        TResult VisitInterface(InterfaceSyntax node);
        TResult VisitResource(ResourceSyntax node);
        TResult VisitOperation(OperationSyntax node);
        TResult VisitInputParameterList(InputParameterListSyntax node);
        TResult VisitOutputParameterListAlt1(OutputParameterListAlt1Syntax node);
        TResult VisitOutputParameterListAlt2(OutputParameterListAlt2Syntax node);
        TResult VisitOutputParameterListAlt3(OutputParameterListAlt3Syntax node);
        TResult VisitParameter(ParameterSyntax node);
        TResult VisitSingleReturnParameter(SingleReturnParameterSyntax node);
        TResult VisitService(ServiceSyntax node);
        TResult VisitBindingKind(BindingKindSyntax node);
        TResult VisitTypeReference(TypeReferenceSyntax node);
        TResult VisitSimpleTypeAlt1(SimpleTypeAlt1Syntax node);
        TResult VisitSimpleTypeAlt2(SimpleTypeAlt2Syntax node);
        TResult VisitSimpleTypeAlt3(SimpleTypeAlt3Syntax node);
        TResult VisitSimpleTypeAlt4(SimpleTypeAlt4Syntax node);
        TResult VisitSimpleTypeAlt5(SimpleTypeAlt5Syntax node);
        TResult VisitSimpleTypeAlt6(SimpleTypeAlt6Syntax node);
        TResult VisitSimpleTypeAlt7(SimpleTypeAlt7Syntax node);
        TResult VisitSimpleTypeAlt8(SimpleTypeAlt8Syntax node);
        TResult VisitSimpleTypeAlt9(SimpleTypeAlt9Syntax node);
        TResult VisitSimpleTypeAlt10(SimpleTypeAlt10Syntax node);
        TResult VisitSimpleTypeAlt11(SimpleTypeAlt11Syntax node);
        TResult VisitSimpleTypeAlt12(SimpleTypeAlt12Syntax node);
        TResult VisitSimpleTypeAlt13(SimpleTypeAlt13Syntax node);
        TResult VisitName(NameSyntax node);
        TResult VisitQualifier(QualifierSyntax node);
        TResult VisitIdentifier(IdentifierSyntax node);
        TResult VisitMainBlock1(MainBlock1Syntax node);
        TResult VisitEnumTypeBlock1(EnumTypeBlock1Syntax node);
        TResult VisitEnumTypeBlock1literalsBlock(EnumTypeBlock1literalsBlockSyntax node);
        TResult VisitStructTypeBlock1(StructTypeBlock1Syntax node);
        TResult VisitResourceBlock1(ResourceBlock1Syntax node);
        TResult VisitResourceBlock1exceptionsBlock(ResourceBlock1exceptionsBlockSyntax node);
        TResult VisitOperationBlock1(OperationBlock1Syntax node);
        TResult VisitOperationBlock1exceptionsBlock(OperationBlock1exceptionsBlockSyntax node);
        TResult VisitInputParameterListBlock1(InputParameterListBlock1Syntax node);
        TResult VisitInputParameterListBlock1parametersBlock(InputParameterListBlock1parametersBlockSyntax node);
        TResult VisitOutputParameterListAlt3parametersBlock(OutputParameterListAlt3parametersBlockSyntax node);
        TResult VisitTypeReferenceBlock1(TypeReferenceBlock1Syntax node);
        TResult VisitQualifierIdentifierBlock(QualifierIdentifierBlockSyntax node);
    }

    public class SoalSyntaxVisitor<TResult> : SyntaxVisitor<TResult>, ISoalSyntaxVisitor<TResult>
    {
        public virtual TResult VisitSkippedTokensTrivia(SoalSkippedTokensTriviaSyntax node)
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

        public virtual TResult VisitDeclarationAlt1(DeclarationAlt1Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitDeclarationAlt2(DeclarationAlt2Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitDeclarationAlt3(DeclarationAlt3Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitDeclarationAlt4(DeclarationAlt4Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitEnumType(EnumTypeSyntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitEnumLiteral(EnumLiteralSyntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitStructType(StructTypeSyntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitProperty(PropertySyntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitInterface(InterfaceSyntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitResource(ResourceSyntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitOperation(OperationSyntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitInputParameterList(InputParameterListSyntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitOutputParameterListAlt1(OutputParameterListAlt1Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitOutputParameterListAlt2(OutputParameterListAlt2Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitOutputParameterListAlt3(OutputParameterListAlt3Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitParameter(ParameterSyntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitSingleReturnParameter(SingleReturnParameterSyntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitService(ServiceSyntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitBindingKind(BindingKindSyntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitTypeReference(TypeReferenceSyntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitSimpleTypeAlt1(SimpleTypeAlt1Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitSimpleTypeAlt2(SimpleTypeAlt2Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitSimpleTypeAlt3(SimpleTypeAlt3Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitSimpleTypeAlt4(SimpleTypeAlt4Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitSimpleTypeAlt5(SimpleTypeAlt5Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitSimpleTypeAlt6(SimpleTypeAlt6Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitSimpleTypeAlt7(SimpleTypeAlt7Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitSimpleTypeAlt8(SimpleTypeAlt8Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitSimpleTypeAlt9(SimpleTypeAlt9Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitSimpleTypeAlt10(SimpleTypeAlt10Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitSimpleTypeAlt11(SimpleTypeAlt11Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitSimpleTypeAlt12(SimpleTypeAlt12Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitSimpleTypeAlt13(SimpleTypeAlt13Syntax node)
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

        public virtual TResult VisitMainBlock1(MainBlock1Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitEnumTypeBlock1(EnumTypeBlock1Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitEnumTypeBlock1literalsBlock(EnumTypeBlock1literalsBlockSyntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitStructTypeBlock1(StructTypeBlock1Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitResourceBlock1(ResourceBlock1Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitResourceBlock1exceptionsBlock(ResourceBlock1exceptionsBlockSyntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitOperationBlock1(OperationBlock1Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitOperationBlock1exceptionsBlock(OperationBlock1exceptionsBlockSyntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitInputParameterListBlock1(InputParameterListBlock1Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitInputParameterListBlock1parametersBlock(InputParameterListBlock1parametersBlockSyntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitOutputParameterListAlt3parametersBlock(OutputParameterListAlt3parametersBlockSyntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitTypeReferenceBlock1(TypeReferenceBlock1Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitQualifierIdentifierBlock(QualifierIdentifierBlockSyntax node)
        {
            return this.DefaultVisit(node);
        }

    }

    public interface ISoalSyntaxVisitor<TArg, TResult> 
    {
        TResult VisitSkippedTokensTrivia(SoalSkippedTokensTriviaSyntax node, TArg argument);
        TResult VisitMain(MainSyntax node, TArg argument);
        TResult VisitUsing(UsingSyntax node, TArg argument);
        TResult VisitDeclarationAlt1(DeclarationAlt1Syntax node, TArg argument);
        TResult VisitDeclarationAlt2(DeclarationAlt2Syntax node, TArg argument);
        TResult VisitDeclarationAlt3(DeclarationAlt3Syntax node, TArg argument);
        TResult VisitDeclarationAlt4(DeclarationAlt4Syntax node, TArg argument);
        TResult VisitEnumType(EnumTypeSyntax node, TArg argument);
        TResult VisitEnumLiteral(EnumLiteralSyntax node, TArg argument);
        TResult VisitStructType(StructTypeSyntax node, TArg argument);
        TResult VisitProperty(PropertySyntax node, TArg argument);
        TResult VisitInterface(InterfaceSyntax node, TArg argument);
        TResult VisitResource(ResourceSyntax node, TArg argument);
        TResult VisitOperation(OperationSyntax node, TArg argument);
        TResult VisitInputParameterList(InputParameterListSyntax node, TArg argument);
        TResult VisitOutputParameterListAlt1(OutputParameterListAlt1Syntax node, TArg argument);
        TResult VisitOutputParameterListAlt2(OutputParameterListAlt2Syntax node, TArg argument);
        TResult VisitOutputParameterListAlt3(OutputParameterListAlt3Syntax node, TArg argument);
        TResult VisitParameter(ParameterSyntax node, TArg argument);
        TResult VisitSingleReturnParameter(SingleReturnParameterSyntax node, TArg argument);
        TResult VisitService(ServiceSyntax node, TArg argument);
        TResult VisitBindingKind(BindingKindSyntax node, TArg argument);
        TResult VisitTypeReference(TypeReferenceSyntax node, TArg argument);
        TResult VisitSimpleTypeAlt1(SimpleTypeAlt1Syntax node, TArg argument);
        TResult VisitSimpleTypeAlt2(SimpleTypeAlt2Syntax node, TArg argument);
        TResult VisitSimpleTypeAlt3(SimpleTypeAlt3Syntax node, TArg argument);
        TResult VisitSimpleTypeAlt4(SimpleTypeAlt4Syntax node, TArg argument);
        TResult VisitSimpleTypeAlt5(SimpleTypeAlt5Syntax node, TArg argument);
        TResult VisitSimpleTypeAlt6(SimpleTypeAlt6Syntax node, TArg argument);
        TResult VisitSimpleTypeAlt7(SimpleTypeAlt7Syntax node, TArg argument);
        TResult VisitSimpleTypeAlt8(SimpleTypeAlt8Syntax node, TArg argument);
        TResult VisitSimpleTypeAlt9(SimpleTypeAlt9Syntax node, TArg argument);
        TResult VisitSimpleTypeAlt10(SimpleTypeAlt10Syntax node, TArg argument);
        TResult VisitSimpleTypeAlt11(SimpleTypeAlt11Syntax node, TArg argument);
        TResult VisitSimpleTypeAlt12(SimpleTypeAlt12Syntax node, TArg argument);
        TResult VisitSimpleTypeAlt13(SimpleTypeAlt13Syntax node, TArg argument);
        TResult VisitName(NameSyntax node, TArg argument);
        TResult VisitQualifier(QualifierSyntax node, TArg argument);
        TResult VisitIdentifier(IdentifierSyntax node, TArg argument);
        TResult VisitMainBlock1(MainBlock1Syntax node, TArg argument);
        TResult VisitEnumTypeBlock1(EnumTypeBlock1Syntax node, TArg argument);
        TResult VisitEnumTypeBlock1literalsBlock(EnumTypeBlock1literalsBlockSyntax node, TArg argument);
        TResult VisitStructTypeBlock1(StructTypeBlock1Syntax node, TArg argument);
        TResult VisitResourceBlock1(ResourceBlock1Syntax node, TArg argument);
        TResult VisitResourceBlock1exceptionsBlock(ResourceBlock1exceptionsBlockSyntax node, TArg argument);
        TResult VisitOperationBlock1(OperationBlock1Syntax node, TArg argument);
        TResult VisitOperationBlock1exceptionsBlock(OperationBlock1exceptionsBlockSyntax node, TArg argument);
        TResult VisitInputParameterListBlock1(InputParameterListBlock1Syntax node, TArg argument);
        TResult VisitInputParameterListBlock1parametersBlock(InputParameterListBlock1parametersBlockSyntax node, TArg argument);
        TResult VisitOutputParameterListAlt3parametersBlock(OutputParameterListAlt3parametersBlockSyntax node, TArg argument);
        TResult VisitTypeReferenceBlock1(TypeReferenceBlock1Syntax node, TArg argument);
        TResult VisitQualifierIdentifierBlock(QualifierIdentifierBlockSyntax node, TArg argument);
    }

    public class SoalSyntaxVisitor<TArg, TResult> : SyntaxVisitor<TArg, TResult>, ISoalSyntaxVisitor<TArg, TResult>
    {
        public virtual TResult VisitSkippedTokensTrivia(SoalSkippedTokensTriviaSyntax node, TArg argument)
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

        public virtual TResult VisitDeclarationAlt1(DeclarationAlt1Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitDeclarationAlt2(DeclarationAlt2Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitDeclarationAlt3(DeclarationAlt3Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitDeclarationAlt4(DeclarationAlt4Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitEnumType(EnumTypeSyntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitEnumLiteral(EnumLiteralSyntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitStructType(StructTypeSyntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitProperty(PropertySyntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitInterface(InterfaceSyntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitResource(ResourceSyntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitOperation(OperationSyntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitInputParameterList(InputParameterListSyntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitOutputParameterListAlt1(OutputParameterListAlt1Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitOutputParameterListAlt2(OutputParameterListAlt2Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitOutputParameterListAlt3(OutputParameterListAlt3Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitParameter(ParameterSyntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitSingleReturnParameter(SingleReturnParameterSyntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitService(ServiceSyntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitBindingKind(BindingKindSyntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitTypeReference(TypeReferenceSyntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitSimpleTypeAlt1(SimpleTypeAlt1Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitSimpleTypeAlt2(SimpleTypeAlt2Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitSimpleTypeAlt3(SimpleTypeAlt3Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitSimpleTypeAlt4(SimpleTypeAlt4Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitSimpleTypeAlt5(SimpleTypeAlt5Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitSimpleTypeAlt6(SimpleTypeAlt6Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitSimpleTypeAlt7(SimpleTypeAlt7Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitSimpleTypeAlt8(SimpleTypeAlt8Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitSimpleTypeAlt9(SimpleTypeAlt9Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitSimpleTypeAlt10(SimpleTypeAlt10Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitSimpleTypeAlt11(SimpleTypeAlt11Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitSimpleTypeAlt12(SimpleTypeAlt12Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitSimpleTypeAlt13(SimpleTypeAlt13Syntax node, TArg argument)
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

        public virtual TResult VisitMainBlock1(MainBlock1Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitEnumTypeBlock1(EnumTypeBlock1Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitEnumTypeBlock1literalsBlock(EnumTypeBlock1literalsBlockSyntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitStructTypeBlock1(StructTypeBlock1Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitResourceBlock1(ResourceBlock1Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitResourceBlock1exceptionsBlock(ResourceBlock1exceptionsBlockSyntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitOperationBlock1(OperationBlock1Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitOperationBlock1exceptionsBlock(OperationBlock1exceptionsBlockSyntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitInputParameterListBlock1(InputParameterListBlock1Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitInputParameterListBlock1parametersBlock(InputParameterListBlock1parametersBlockSyntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitOutputParameterListAlt3parametersBlock(OutputParameterListAlt3parametersBlockSyntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitTypeReferenceBlock1(TypeReferenceBlock1Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitQualifierIdentifierBlock(QualifierIdentifierBlockSyntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

    }

    public class SoalSyntaxRewriter : SyntaxRewriter, ISoalSyntaxVisitor<SyntaxNode?>
    {
        public SoalSyntaxRewriter(bool visitIntoStructuredTrivia = false)
            : base(SoalLanguage.Instance, visitIntoStructuredTrivia)
        {
        }
    
        public virtual SyntaxNode VisitSkippedTokensTrivia(SoalSkippedTokensTriviaSyntax node)
        {
          var tokens = this.VisitList(node.Tokens);
          return node.Update(tokens);
        }

        public virtual SyntaxNode VisitMain(MainSyntax node)
        {
            var kNamespace = this.VisitToken(node.KNamespace);
            var qualifier = (QualifierSyntax)this.Visit(node.Qualifier);
            var tSemicolon = this.VisitToken(node.TSemicolon);
            var usingList = this.VisitList(node.UsingList);
            var block = (MainBlock1Syntax)this.Visit(node.Block);
            var endOfFileToken = this.VisitToken(node.EndOfFileToken);
            return node.Update(kNamespace, qualifier, tSemicolon, usingList, block, endOfFileToken);
        }

        public virtual SyntaxNode VisitUsing(UsingSyntax node)
        {
            var kUsing = this.VisitToken(node.KUsing);
            var namespaces = (QualifierSyntax)this.Visit(node.Namespaces);
            var tSemicolon = this.VisitToken(node.TSemicolon);
            return node.Update(kUsing, namespaces, tSemicolon);
        }

        public virtual SyntaxNode VisitDeclarationAlt1(DeclarationAlt1Syntax node)
        {
            var enumType = (EnumTypeSyntax)this.Visit(node.EnumType);
            return node.Update(enumType);
        }

        public virtual SyntaxNode VisitDeclarationAlt2(DeclarationAlt2Syntax node)
        {
            var structType = (StructTypeSyntax)this.Visit(node.StructType);
            return node.Update(structType);
        }

        public virtual SyntaxNode VisitDeclarationAlt3(DeclarationAlt3Syntax node)
        {
            var @interface = (InterfaceSyntax)this.Visit(node.Interface);
            return node.Update(@interface);
        }

        public virtual SyntaxNode VisitDeclarationAlt4(DeclarationAlt4Syntax node)
        {
            var service = (ServiceSyntax)this.Visit(node.Service);
            return node.Update(service);
        }

        public virtual SyntaxNode VisitEnumType(EnumTypeSyntax node)
        {
            var kEnum = this.VisitToken(node.KEnum);
            var name = (NameSyntax)this.Visit(node.Name);
            var tLBrace = this.VisitToken(node.TLBrace);
            var block = (EnumTypeBlock1Syntax)this.Visit(node.Block);
            var tRBrace = this.VisitToken(node.TRBrace);
            return node.Update(kEnum, name, tLBrace, block, tRBrace);
        }

        public virtual SyntaxNode VisitEnumLiteral(EnumLiteralSyntax node)
        {
            var name = (NameSyntax)this.Visit(node.Name);
            return node.Update(name);
        }

        public virtual SyntaxNode VisitStructType(StructTypeSyntax node)
        {
            var kStruct = this.VisitToken(node.KStruct);
            var name = (NameSyntax)this.Visit(node.Name);
            var block = (StructTypeBlock1Syntax)this.Visit(node.Block);
            var tLBrace = this.VisitToken(node.TLBrace);
            var fields = this.VisitList(node.Fields);
            var tRBrace = this.VisitToken(node.TRBrace);
            return node.Update(kStruct, name, block, tLBrace, fields, tRBrace);
        }

        public virtual SyntaxNode VisitProperty(PropertySyntax node)
        {
            var type = (TypeReferenceSyntax)this.Visit(node.Type);
            var name = (NameSyntax)this.Visit(node.Name);
            var tSemicolon = this.VisitToken(node.TSemicolon);
            return node.Update(type, name, tSemicolon);
        }

        public virtual SyntaxNode VisitInterface(InterfaceSyntax node)
        {
            var kInterface = this.VisitToken(node.KInterface);
            var name = (NameSyntax)this.Visit(node.Name);
            var tLBrace = this.VisitToken(node.TLBrace);
            var resources = this.VisitList(node.Resources);
            var operations = this.VisitList(node.Operations);
            var tRBrace = this.VisitToken(node.TRBrace);
            return node.Update(kInterface, name, tLBrace, resources, operations, tRBrace);
        }

        public virtual SyntaxNode VisitResource(ResourceSyntax node)
        {
            var isReadOnly = this.VisitToken(node.IsReadOnly);
            var kResource = this.VisitToken(node.KResource);
            var entity = (QualifierSyntax)this.Visit(node.Entity);
            var block = (ResourceBlock1Syntax)this.Visit(node.Block);
            var tSemicolon = this.VisitToken(node.TSemicolon);
            return node.Update(isReadOnly, kResource, entity, block, tSemicolon);
        }

        public virtual SyntaxNode VisitOperation(OperationSyntax node)
        {
            var isAsync = this.VisitToken(node.IsAsync);
            var responseParameters = (OutputParameterListSyntax)this.Visit(node.ResponseParameters);
            var name = (NameSyntax)this.Visit(node.Name);
            var requestParameters = (InputParameterListSyntax)this.Visit(node.RequestParameters);
            var block = (OperationBlock1Syntax)this.Visit(node.Block);
            var tSemicolon = this.VisitToken(node.TSemicolon);
            return node.Update(isAsync, responseParameters, name, requestParameters, block, tSemicolon);
        }

        public virtual SyntaxNode VisitInputParameterList(InputParameterListSyntax node)
        {
            var tLParen = this.VisitToken(node.TLParen);
            var block = (InputParameterListBlock1Syntax)this.Visit(node.Block);
            var tRParen = this.VisitToken(node.TRParen);
            return node.Update(tLParen, block, tRParen);
        }

        public virtual SyntaxNode VisitOutputParameterListAlt1(OutputParameterListAlt1Syntax node)
        {
            var kVoid = this.VisitToken(node.KVoid);
            return node.Update(kVoid);
        }

        public virtual SyntaxNode VisitOutputParameterListAlt2(OutputParameterListAlt2Syntax node)
        {
            var parameters = (SingleReturnParameterSyntax)this.Visit(node.Parameters);
            return node.Update(parameters);
        }

        public virtual SyntaxNode VisitOutputParameterListAlt3(OutputParameterListAlt3Syntax node)
        {
            var tLParen = this.VisitToken(node.TLParen);
            var parameters = this.VisitList(node.Parameters);
            var tRParen = this.VisitToken(node.TRParen);
            return node.Update(tLParen, parameters, tRParen);
        }

        public virtual SyntaxNode VisitParameter(ParameterSyntax node)
        {
            var type = (TypeReferenceSyntax)this.Visit(node.Type);
            var name = (NameSyntax)this.Visit(node.Name);
            return node.Update(type, name);
        }

        public virtual SyntaxNode VisitSingleReturnParameter(SingleReturnParameterSyntax node)
        {
            var type = (TypeReferenceSyntax)this.Visit(node.Type);
            return node.Update(type);
        }

        public virtual SyntaxNode VisitService(ServiceSyntax node)
        {
            var kService = this.VisitToken(node.KService);
            var name = (NameSyntax)this.Visit(node.Name);
            var tColon = this.VisitToken(node.TColon);
            var @interface = (QualifierSyntax)this.Visit(node.Interface);
            var tLBrace = this.VisitToken(node.TLBrace);
            var kBinding = this.VisitToken(node.KBinding);
            var binding = (BindingKindSyntax)this.Visit(node.Binding);
            var tSemicolon = this.VisitToken(node.TSemicolon);
            var tRBrace = this.VisitToken(node.TRBrace);
            return node.Update(kService, name, tColon, @interface, tLBrace, kBinding, binding, tSemicolon, tRBrace);
        }

        public virtual SyntaxNode VisitBindingKind(BindingKindSyntax node)
        {
            var token = this.VisitToken(node.Token);
            return node.Update(token);
        }

        public virtual SyntaxNode VisitTypeReference(TypeReferenceSyntax node)
        {
            var type = (SimpleTypeSyntax)this.Visit(node.Type);
            var isNullable = this.VisitToken(node.IsNullable);
            var isArray = (TypeReferenceBlock1Syntax)this.Visit(node.IsArray);
            return node.Update(type, isNullable, isArray);
        }

        public virtual SyntaxNode VisitSimpleTypeAlt1(SimpleTypeAlt1Syntax node)
        {
            var kObject = this.VisitToken(node.KObject);
            return node.Update(kObject);
        }

        public virtual SyntaxNode VisitSimpleTypeAlt2(SimpleTypeAlt2Syntax node)
        {
            var kBinary = this.VisitToken(node.KBinary);
            return node.Update(kBinary);
        }

        public virtual SyntaxNode VisitSimpleTypeAlt3(SimpleTypeAlt3Syntax node)
        {
            var kBool = this.VisitToken(node.KBool);
            return node.Update(kBool);
        }

        public virtual SyntaxNode VisitSimpleTypeAlt4(SimpleTypeAlt4Syntax node)
        {
            var kString = this.VisitToken(node.KString);
            return node.Update(kString);
        }

        public virtual SyntaxNode VisitSimpleTypeAlt5(SimpleTypeAlt5Syntax node)
        {
            var kInt = this.VisitToken(node.KInt);
            return node.Update(kInt);
        }

        public virtual SyntaxNode VisitSimpleTypeAlt6(SimpleTypeAlt6Syntax node)
        {
            var kLong = this.VisitToken(node.KLong);
            return node.Update(kLong);
        }

        public virtual SyntaxNode VisitSimpleTypeAlt7(SimpleTypeAlt7Syntax node)
        {
            var kFloat = this.VisitToken(node.KFloat);
            return node.Update(kFloat);
        }

        public virtual SyntaxNode VisitSimpleTypeAlt8(SimpleTypeAlt8Syntax node)
        {
            var kDouble = this.VisitToken(node.KDouble);
            return node.Update(kDouble);
        }

        public virtual SyntaxNode VisitSimpleTypeAlt9(SimpleTypeAlt9Syntax node)
        {
            var kDate = this.VisitToken(node.KDate);
            return node.Update(kDate);
        }

        public virtual SyntaxNode VisitSimpleTypeAlt10(SimpleTypeAlt10Syntax node)
        {
            var kTime = this.VisitToken(node.KTime);
            return node.Update(kTime);
        }

        public virtual SyntaxNode VisitSimpleTypeAlt11(SimpleTypeAlt11Syntax node)
        {
            var kDatetime = this.VisitToken(node.KDatetime);
            return node.Update(kDatetime);
        }

        public virtual SyntaxNode VisitSimpleTypeAlt12(SimpleTypeAlt12Syntax node)
        {
            var kDuration = this.VisitToken(node.KDuration);
            return node.Update(kDuration);
        }

        public virtual SyntaxNode VisitSimpleTypeAlt13(SimpleTypeAlt13Syntax node)
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

        public virtual SyntaxNode VisitMainBlock1(MainBlock1Syntax node)
        {
            var declarationList = this.VisitList(node.DeclarationList);
            return node.Update(declarationList);
        }

        public virtual SyntaxNode VisitEnumTypeBlock1(EnumTypeBlock1Syntax node)
        {
            var literals = this.VisitList(node.Literals);
            return node.Update(literals);
        }

        public virtual SyntaxNode VisitEnumTypeBlock1literalsBlock(EnumTypeBlock1literalsBlockSyntax node)
        {
            var tComma = this.VisitToken(node.TComma);
            var literals = (EnumLiteralSyntax)this.Visit(node.Literals);
            return node.Update(tComma, literals);
        }

        public virtual SyntaxNode VisitStructTypeBlock1(StructTypeBlock1Syntax node)
        {
            var tColon = this.VisitToken(node.TColon);
            var baseType = (QualifierSyntax)this.Visit(node.BaseType);
            return node.Update(tColon, baseType);
        }

        public virtual SyntaxNode VisitResourceBlock1(ResourceBlock1Syntax node)
        {
            var kThrows = this.VisitToken(node.KThrows);
            var exceptions = this.VisitList(node.Exceptions);
            return node.Update(kThrows, exceptions);
        }

        public virtual SyntaxNode VisitResourceBlock1exceptionsBlock(ResourceBlock1exceptionsBlockSyntax node)
        {
            var tComma = this.VisitToken(node.TComma);
            var exceptions = (QualifierSyntax)this.Visit(node.Exceptions);
            return node.Update(tComma, exceptions);
        }

        public virtual SyntaxNode VisitOperationBlock1(OperationBlock1Syntax node)
        {
            var kThrows = this.VisitToken(node.KThrows);
            var exceptions = this.VisitList(node.Exceptions);
            return node.Update(kThrows, exceptions);
        }

        public virtual SyntaxNode VisitOperationBlock1exceptionsBlock(OperationBlock1exceptionsBlockSyntax node)
        {
            var tComma = this.VisitToken(node.TComma);
            var exceptions = (QualifierSyntax)this.Visit(node.Exceptions);
            return node.Update(tComma, exceptions);
        }

        public virtual SyntaxNode VisitInputParameterListBlock1(InputParameterListBlock1Syntax node)
        {
            var parameters = this.VisitList(node.Parameters);
            return node.Update(parameters);
        }

        public virtual SyntaxNode VisitInputParameterListBlock1parametersBlock(InputParameterListBlock1parametersBlockSyntax node)
        {
            var tComma = this.VisitToken(node.TComma);
            var parameters = (ParameterSyntax)this.Visit(node.Parameters);
            return node.Update(tComma, parameters);
        }

        public virtual SyntaxNode VisitOutputParameterListAlt3parametersBlock(OutputParameterListAlt3parametersBlockSyntax node)
        {
            var tComma = this.VisitToken(node.TComma);
            var parameters = (ParameterSyntax)this.Visit(node.Parameters);
            return node.Update(tComma, parameters);
        }

        public virtual SyntaxNode VisitTypeReferenceBlock1(TypeReferenceBlock1Syntax node)
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
