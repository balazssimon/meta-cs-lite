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
        void VisitMetaModel(MetaModelSyntax node);
        void VisitMetaDeclarationAlt1(MetaDeclarationAlt1Syntax node);
        void VisitMetaDeclarationAlt2(MetaDeclarationAlt2Syntax node);
        void VisitMetaDeclarationAlt3(MetaDeclarationAlt3Syntax node);
        void VisitMetaConstant(MetaConstantSyntax node);
        void VisitMetaEnum(MetaEnumSyntax node);
        void VisitMetaEnumLiteral(MetaEnumLiteralSyntax node);
        void VisitMetaClass(MetaClassSyntax node);
        void VisitMetaProperty(MetaPropertySyntax node);
        void VisitMetaOperation(MetaOperationSyntax node);
        void VisitMetaParameter(MetaParameterSyntax node);
        void VisitSimpleTypeReference(SimpleTypeReferenceSyntax node);
        void VisitMetaArrayType(MetaArrayTypeSyntax node);
        void VisitMetaNullableType(MetaNullableTypeSyntax node);
        void VisitTypeReferenceAlt1(TypeReferenceAlt1Syntax node);
        void VisitTypeReferenceAlt2(TypeReferenceAlt2Syntax node);
        void VisitPrimitiveType(PrimitiveTypeSyntax node);
        void VisitName(NameSyntax node);
        void VisitQualifier(QualifierSyntax node);
        void VisitIdentifier(IdentifierSyntax node);
        void VisitMainBlock1(MainBlock1Syntax node);
        void VisitMetaEnumBlock1(MetaEnumBlock1Syntax node);
        void VisitMetaEnumBlock1literalsBlock(MetaEnumBlock1literalsBlockSyntax node);
        void VisitMetaClassBlock1Alt1(MetaClassBlock1Alt1Syntax node);
        void VisitMetaClassBlock1Alt2(MetaClassBlock1Alt2Syntax node);
        void VisitMetaClassBlock2(MetaClassBlock2Syntax node);
        void VisitMetaClassBlock2baseTypesBlock(MetaClassBlock2baseTypesBlockSyntax node);
        void VisitMetaClassBlock3(MetaClassBlock3Syntax node);
        void VisitMetaClassBlock3Block1Alt1(MetaClassBlock3Block1Alt1Syntax node);
        void VisitMetaClassBlock3Block1Alt2(MetaClassBlock3Block1Alt2Syntax node);
        void VisitMetaPropertyBlock1Alt1(MetaPropertyBlock1Alt1Syntax node);
        void VisitMetaPropertyBlock1Alt2(MetaPropertyBlock1Alt2Syntax node);
        void VisitMetaPropertyBlock2Alt1(MetaPropertyBlock2Alt1Syntax node);
        void VisitMetaPropertyBlock2Alt2(MetaPropertyBlock2Alt2Syntax node);
        void VisitMetaPropertyBlock3Alt1(MetaPropertyBlock3Alt1Syntax node);
        void VisitMetaPropertyBlock3Alt2(MetaPropertyBlock3Alt2Syntax node);
        void VisitMetaPropertyBlock3Alt3(MetaPropertyBlock3Alt3Syntax node);
        void VisitMetaPropertyBlock3Alt1oppositePropertiesBlock(MetaPropertyBlock3Alt1oppositePropertiesBlockSyntax node);
        void VisitMetaPropertyBlock3Alt2subsettedPropertiesBlock(MetaPropertyBlock3Alt2subsettedPropertiesBlockSyntax node);
        void VisitMetaPropertyBlock3Alt3redefinedPropertiesBlock(MetaPropertyBlock3Alt3redefinedPropertiesBlockSyntax node);
        void VisitMetaOperationBlock1(MetaOperationBlock1Syntax node);
        void VisitMetaOperationBlock1parametersBlock(MetaOperationBlock1parametersBlockSyntax node);
        void VisitQualifierIdentifierBlock(QualifierIdentifierBlockSyntax node);
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

        public virtual void VisitMetaModel(MetaModelSyntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitMetaDeclarationAlt1(MetaDeclarationAlt1Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitMetaDeclarationAlt2(MetaDeclarationAlt2Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitMetaDeclarationAlt3(MetaDeclarationAlt3Syntax node)
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

        public virtual void VisitMetaEnumLiteral(MetaEnumLiteralSyntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitMetaClass(MetaClassSyntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitMetaProperty(MetaPropertySyntax node)
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

        public virtual void VisitSimpleTypeReference(SimpleTypeReferenceSyntax node)
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

        public virtual void VisitTypeReferenceAlt1(TypeReferenceAlt1Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitTypeReferenceAlt2(TypeReferenceAlt2Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitPrimitiveType(PrimitiveTypeSyntax node)
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

        public virtual void VisitMetaEnumBlock1(MetaEnumBlock1Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitMetaEnumBlock1literalsBlock(MetaEnumBlock1literalsBlockSyntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitMetaClassBlock1Alt1(MetaClassBlock1Alt1Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitMetaClassBlock1Alt2(MetaClassBlock1Alt2Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitMetaClassBlock2(MetaClassBlock2Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitMetaClassBlock2baseTypesBlock(MetaClassBlock2baseTypesBlockSyntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitMetaClassBlock3(MetaClassBlock3Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitMetaClassBlock3Block1Alt1(MetaClassBlock3Block1Alt1Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitMetaClassBlock3Block1Alt2(MetaClassBlock3Block1Alt2Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitMetaPropertyBlock1Alt1(MetaPropertyBlock1Alt1Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitMetaPropertyBlock1Alt2(MetaPropertyBlock1Alt2Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitMetaPropertyBlock2Alt1(MetaPropertyBlock2Alt1Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitMetaPropertyBlock2Alt2(MetaPropertyBlock2Alt2Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitMetaPropertyBlock3Alt1(MetaPropertyBlock3Alt1Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitMetaPropertyBlock3Alt2(MetaPropertyBlock3Alt2Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitMetaPropertyBlock3Alt3(MetaPropertyBlock3Alt3Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitMetaPropertyBlock3Alt1oppositePropertiesBlock(MetaPropertyBlock3Alt1oppositePropertiesBlockSyntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitMetaPropertyBlock3Alt2subsettedPropertiesBlock(MetaPropertyBlock3Alt2subsettedPropertiesBlockSyntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitMetaPropertyBlock3Alt3redefinedPropertiesBlock(MetaPropertyBlock3Alt3redefinedPropertiesBlockSyntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitMetaOperationBlock1(MetaOperationBlock1Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitMetaOperationBlock1parametersBlock(MetaOperationBlock1parametersBlockSyntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitQualifierIdentifierBlock(QualifierIdentifierBlockSyntax node)
        {
            this.DefaultVisit(node);
        }

    }

    public interface IMetaSyntaxVisitor<TResult> 
    {
        TResult VisitSkippedTokensTrivia(MetaSkippedTokensTriviaSyntax node);
        TResult VisitMain(MainSyntax node);
        TResult VisitUsing(UsingSyntax node);
        TResult VisitMetaModel(MetaModelSyntax node);
        TResult VisitMetaDeclarationAlt1(MetaDeclarationAlt1Syntax node);
        TResult VisitMetaDeclarationAlt2(MetaDeclarationAlt2Syntax node);
        TResult VisitMetaDeclarationAlt3(MetaDeclarationAlt3Syntax node);
        TResult VisitMetaConstant(MetaConstantSyntax node);
        TResult VisitMetaEnum(MetaEnumSyntax node);
        TResult VisitMetaEnumLiteral(MetaEnumLiteralSyntax node);
        TResult VisitMetaClass(MetaClassSyntax node);
        TResult VisitMetaProperty(MetaPropertySyntax node);
        TResult VisitMetaOperation(MetaOperationSyntax node);
        TResult VisitMetaParameter(MetaParameterSyntax node);
        TResult VisitSimpleTypeReference(SimpleTypeReferenceSyntax node);
        TResult VisitMetaArrayType(MetaArrayTypeSyntax node);
        TResult VisitMetaNullableType(MetaNullableTypeSyntax node);
        TResult VisitTypeReferenceAlt1(TypeReferenceAlt1Syntax node);
        TResult VisitTypeReferenceAlt2(TypeReferenceAlt2Syntax node);
        TResult VisitPrimitiveType(PrimitiveTypeSyntax node);
        TResult VisitName(NameSyntax node);
        TResult VisitQualifier(QualifierSyntax node);
        TResult VisitIdentifier(IdentifierSyntax node);
        TResult VisitMainBlock1(MainBlock1Syntax node);
        TResult VisitMetaEnumBlock1(MetaEnumBlock1Syntax node);
        TResult VisitMetaEnumBlock1literalsBlock(MetaEnumBlock1literalsBlockSyntax node);
        TResult VisitMetaClassBlock1Alt1(MetaClassBlock1Alt1Syntax node);
        TResult VisitMetaClassBlock1Alt2(MetaClassBlock1Alt2Syntax node);
        TResult VisitMetaClassBlock2(MetaClassBlock2Syntax node);
        TResult VisitMetaClassBlock2baseTypesBlock(MetaClassBlock2baseTypesBlockSyntax node);
        TResult VisitMetaClassBlock3(MetaClassBlock3Syntax node);
        TResult VisitMetaClassBlock3Block1Alt1(MetaClassBlock3Block1Alt1Syntax node);
        TResult VisitMetaClassBlock3Block1Alt2(MetaClassBlock3Block1Alt2Syntax node);
        TResult VisitMetaPropertyBlock1Alt1(MetaPropertyBlock1Alt1Syntax node);
        TResult VisitMetaPropertyBlock1Alt2(MetaPropertyBlock1Alt2Syntax node);
        TResult VisitMetaPropertyBlock2Alt1(MetaPropertyBlock2Alt1Syntax node);
        TResult VisitMetaPropertyBlock2Alt2(MetaPropertyBlock2Alt2Syntax node);
        TResult VisitMetaPropertyBlock3Alt1(MetaPropertyBlock3Alt1Syntax node);
        TResult VisitMetaPropertyBlock3Alt2(MetaPropertyBlock3Alt2Syntax node);
        TResult VisitMetaPropertyBlock3Alt3(MetaPropertyBlock3Alt3Syntax node);
        TResult VisitMetaPropertyBlock3Alt1oppositePropertiesBlock(MetaPropertyBlock3Alt1oppositePropertiesBlockSyntax node);
        TResult VisitMetaPropertyBlock3Alt2subsettedPropertiesBlock(MetaPropertyBlock3Alt2subsettedPropertiesBlockSyntax node);
        TResult VisitMetaPropertyBlock3Alt3redefinedPropertiesBlock(MetaPropertyBlock3Alt3redefinedPropertiesBlockSyntax node);
        TResult VisitMetaOperationBlock1(MetaOperationBlock1Syntax node);
        TResult VisitMetaOperationBlock1parametersBlock(MetaOperationBlock1parametersBlockSyntax node);
        TResult VisitQualifierIdentifierBlock(QualifierIdentifierBlockSyntax node);
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

        public virtual TResult VisitMetaModel(MetaModelSyntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitMetaDeclarationAlt1(MetaDeclarationAlt1Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitMetaDeclarationAlt2(MetaDeclarationAlt2Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitMetaDeclarationAlt3(MetaDeclarationAlt3Syntax node)
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

        public virtual TResult VisitMetaEnumLiteral(MetaEnumLiteralSyntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitMetaClass(MetaClassSyntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitMetaProperty(MetaPropertySyntax node)
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

        public virtual TResult VisitSimpleTypeReference(SimpleTypeReferenceSyntax node)
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

        public virtual TResult VisitTypeReferenceAlt1(TypeReferenceAlt1Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitTypeReferenceAlt2(TypeReferenceAlt2Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitPrimitiveType(PrimitiveTypeSyntax node)
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

        public virtual TResult VisitMetaEnumBlock1(MetaEnumBlock1Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitMetaEnumBlock1literalsBlock(MetaEnumBlock1literalsBlockSyntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitMetaClassBlock1Alt1(MetaClassBlock1Alt1Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitMetaClassBlock1Alt2(MetaClassBlock1Alt2Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitMetaClassBlock2(MetaClassBlock2Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitMetaClassBlock2baseTypesBlock(MetaClassBlock2baseTypesBlockSyntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitMetaClassBlock3(MetaClassBlock3Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitMetaClassBlock3Block1Alt1(MetaClassBlock3Block1Alt1Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitMetaClassBlock3Block1Alt2(MetaClassBlock3Block1Alt2Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitMetaPropertyBlock1Alt1(MetaPropertyBlock1Alt1Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitMetaPropertyBlock1Alt2(MetaPropertyBlock1Alt2Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitMetaPropertyBlock2Alt1(MetaPropertyBlock2Alt1Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitMetaPropertyBlock2Alt2(MetaPropertyBlock2Alt2Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitMetaPropertyBlock3Alt1(MetaPropertyBlock3Alt1Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitMetaPropertyBlock3Alt2(MetaPropertyBlock3Alt2Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitMetaPropertyBlock3Alt3(MetaPropertyBlock3Alt3Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitMetaPropertyBlock3Alt1oppositePropertiesBlock(MetaPropertyBlock3Alt1oppositePropertiesBlockSyntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitMetaPropertyBlock3Alt2subsettedPropertiesBlock(MetaPropertyBlock3Alt2subsettedPropertiesBlockSyntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitMetaPropertyBlock3Alt3redefinedPropertiesBlock(MetaPropertyBlock3Alt3redefinedPropertiesBlockSyntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitMetaOperationBlock1(MetaOperationBlock1Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitMetaOperationBlock1parametersBlock(MetaOperationBlock1parametersBlockSyntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitQualifierIdentifierBlock(QualifierIdentifierBlockSyntax node)
        {
            return this.DefaultVisit(node);
        }

    }

    public interface IMetaSyntaxVisitor<TArg, TResult> 
    {
        TResult VisitSkippedTokensTrivia(MetaSkippedTokensTriviaSyntax node, TArg argument);
        TResult VisitMain(MainSyntax node, TArg argument);
        TResult VisitUsing(UsingSyntax node, TArg argument);
        TResult VisitMetaModel(MetaModelSyntax node, TArg argument);
        TResult VisitMetaDeclarationAlt1(MetaDeclarationAlt1Syntax node, TArg argument);
        TResult VisitMetaDeclarationAlt2(MetaDeclarationAlt2Syntax node, TArg argument);
        TResult VisitMetaDeclarationAlt3(MetaDeclarationAlt3Syntax node, TArg argument);
        TResult VisitMetaConstant(MetaConstantSyntax node, TArg argument);
        TResult VisitMetaEnum(MetaEnumSyntax node, TArg argument);
        TResult VisitMetaEnumLiteral(MetaEnumLiteralSyntax node, TArg argument);
        TResult VisitMetaClass(MetaClassSyntax node, TArg argument);
        TResult VisitMetaProperty(MetaPropertySyntax node, TArg argument);
        TResult VisitMetaOperation(MetaOperationSyntax node, TArg argument);
        TResult VisitMetaParameter(MetaParameterSyntax node, TArg argument);
        TResult VisitSimpleTypeReference(SimpleTypeReferenceSyntax node, TArg argument);
        TResult VisitMetaArrayType(MetaArrayTypeSyntax node, TArg argument);
        TResult VisitMetaNullableType(MetaNullableTypeSyntax node, TArg argument);
        TResult VisitTypeReferenceAlt1(TypeReferenceAlt1Syntax node, TArg argument);
        TResult VisitTypeReferenceAlt2(TypeReferenceAlt2Syntax node, TArg argument);
        TResult VisitPrimitiveType(PrimitiveTypeSyntax node, TArg argument);
        TResult VisitName(NameSyntax node, TArg argument);
        TResult VisitQualifier(QualifierSyntax node, TArg argument);
        TResult VisitIdentifier(IdentifierSyntax node, TArg argument);
        TResult VisitMainBlock1(MainBlock1Syntax node, TArg argument);
        TResult VisitMetaEnumBlock1(MetaEnumBlock1Syntax node, TArg argument);
        TResult VisitMetaEnumBlock1literalsBlock(MetaEnumBlock1literalsBlockSyntax node, TArg argument);
        TResult VisitMetaClassBlock1Alt1(MetaClassBlock1Alt1Syntax node, TArg argument);
        TResult VisitMetaClassBlock1Alt2(MetaClassBlock1Alt2Syntax node, TArg argument);
        TResult VisitMetaClassBlock2(MetaClassBlock2Syntax node, TArg argument);
        TResult VisitMetaClassBlock2baseTypesBlock(MetaClassBlock2baseTypesBlockSyntax node, TArg argument);
        TResult VisitMetaClassBlock3(MetaClassBlock3Syntax node, TArg argument);
        TResult VisitMetaClassBlock3Block1Alt1(MetaClassBlock3Block1Alt1Syntax node, TArg argument);
        TResult VisitMetaClassBlock3Block1Alt2(MetaClassBlock3Block1Alt2Syntax node, TArg argument);
        TResult VisitMetaPropertyBlock1Alt1(MetaPropertyBlock1Alt1Syntax node, TArg argument);
        TResult VisitMetaPropertyBlock1Alt2(MetaPropertyBlock1Alt2Syntax node, TArg argument);
        TResult VisitMetaPropertyBlock2Alt1(MetaPropertyBlock2Alt1Syntax node, TArg argument);
        TResult VisitMetaPropertyBlock2Alt2(MetaPropertyBlock2Alt2Syntax node, TArg argument);
        TResult VisitMetaPropertyBlock3Alt1(MetaPropertyBlock3Alt1Syntax node, TArg argument);
        TResult VisitMetaPropertyBlock3Alt2(MetaPropertyBlock3Alt2Syntax node, TArg argument);
        TResult VisitMetaPropertyBlock3Alt3(MetaPropertyBlock3Alt3Syntax node, TArg argument);
        TResult VisitMetaPropertyBlock3Alt1oppositePropertiesBlock(MetaPropertyBlock3Alt1oppositePropertiesBlockSyntax node, TArg argument);
        TResult VisitMetaPropertyBlock3Alt2subsettedPropertiesBlock(MetaPropertyBlock3Alt2subsettedPropertiesBlockSyntax node, TArg argument);
        TResult VisitMetaPropertyBlock3Alt3redefinedPropertiesBlock(MetaPropertyBlock3Alt3redefinedPropertiesBlockSyntax node, TArg argument);
        TResult VisitMetaOperationBlock1(MetaOperationBlock1Syntax node, TArg argument);
        TResult VisitMetaOperationBlock1parametersBlock(MetaOperationBlock1parametersBlockSyntax node, TArg argument);
        TResult VisitQualifierIdentifierBlock(QualifierIdentifierBlockSyntax node, TArg argument);
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

        public virtual TResult VisitMetaModel(MetaModelSyntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitMetaDeclarationAlt1(MetaDeclarationAlt1Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitMetaDeclarationAlt2(MetaDeclarationAlt2Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitMetaDeclarationAlt3(MetaDeclarationAlt3Syntax node, TArg argument)
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

        public virtual TResult VisitMetaEnumLiteral(MetaEnumLiteralSyntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitMetaClass(MetaClassSyntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitMetaProperty(MetaPropertySyntax node, TArg argument)
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

        public virtual TResult VisitSimpleTypeReference(SimpleTypeReferenceSyntax node, TArg argument)
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

        public virtual TResult VisitTypeReferenceAlt1(TypeReferenceAlt1Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitTypeReferenceAlt2(TypeReferenceAlt2Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitPrimitiveType(PrimitiveTypeSyntax node, TArg argument)
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

        public virtual TResult VisitMetaEnumBlock1(MetaEnumBlock1Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitMetaEnumBlock1literalsBlock(MetaEnumBlock1literalsBlockSyntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitMetaClassBlock1Alt1(MetaClassBlock1Alt1Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitMetaClassBlock1Alt2(MetaClassBlock1Alt2Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitMetaClassBlock2(MetaClassBlock2Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitMetaClassBlock2baseTypesBlock(MetaClassBlock2baseTypesBlockSyntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitMetaClassBlock3(MetaClassBlock3Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitMetaClassBlock3Block1Alt1(MetaClassBlock3Block1Alt1Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitMetaClassBlock3Block1Alt2(MetaClassBlock3Block1Alt2Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitMetaPropertyBlock1Alt1(MetaPropertyBlock1Alt1Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitMetaPropertyBlock1Alt2(MetaPropertyBlock1Alt2Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitMetaPropertyBlock2Alt1(MetaPropertyBlock2Alt1Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitMetaPropertyBlock2Alt2(MetaPropertyBlock2Alt2Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitMetaPropertyBlock3Alt1(MetaPropertyBlock3Alt1Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitMetaPropertyBlock3Alt2(MetaPropertyBlock3Alt2Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitMetaPropertyBlock3Alt3(MetaPropertyBlock3Alt3Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitMetaPropertyBlock3Alt1oppositePropertiesBlock(MetaPropertyBlock3Alt1oppositePropertiesBlockSyntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitMetaPropertyBlock3Alt2subsettedPropertiesBlock(MetaPropertyBlock3Alt2subsettedPropertiesBlockSyntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitMetaPropertyBlock3Alt3redefinedPropertiesBlock(MetaPropertyBlock3Alt3redefinedPropertiesBlockSyntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitMetaOperationBlock1(MetaOperationBlock1Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitMetaOperationBlock1parametersBlock(MetaOperationBlock1parametersBlockSyntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitQualifierIdentifierBlock(QualifierIdentifierBlockSyntax node, TArg argument)
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

        public virtual SyntaxNode VisitMetaModel(MetaModelSyntax node)
        {
            var kMetamodel = this.VisitToken(node.KMetamodel);
            var name = (NameSyntax)this.Visit(node.Name);
            var tSemicolon = this.VisitToken(node.TSemicolon);
            return node.Update(kMetamodel, name, tSemicolon);
        }

        public virtual SyntaxNode VisitMetaDeclarationAlt1(MetaDeclarationAlt1Syntax node)
        {
            var metaConstant = (MetaConstantSyntax)this.Visit(node.MetaConstant);
            return node.Update(metaConstant);
        }

        public virtual SyntaxNode VisitMetaDeclarationAlt2(MetaDeclarationAlt2Syntax node)
        {
            var metaEnum = (MetaEnumSyntax)this.Visit(node.MetaEnum);
            return node.Update(metaEnum);
        }

        public virtual SyntaxNode VisitMetaDeclarationAlt3(MetaDeclarationAlt3Syntax node)
        {
            var metaClass = (MetaClassSyntax)this.Visit(node.MetaClass);
            return node.Update(metaClass);
        }

        public virtual SyntaxNode VisitMetaConstant(MetaConstantSyntax node)
        {
            var kConst = this.VisitToken(node.KConst);
            var type = (MetaTypeReferenceSyntax)this.Visit(node.Type);
            var name = (NameSyntax)this.Visit(node.Name);
            var tSemicolon = this.VisitToken(node.TSemicolon);
            return node.Update(kConst, type, name, tSemicolon);
        }

        public virtual SyntaxNode VisitMetaEnum(MetaEnumSyntax node)
        {
            var kEnum = this.VisitToken(node.KEnum);
            var name = (NameSyntax)this.Visit(node.Name);
            var block = (MetaEnumBlock1Syntax)this.Visit(node.Block);
            return node.Update(kEnum, name, block);
        }

        public virtual SyntaxNode VisitMetaEnumLiteral(MetaEnumLiteralSyntax node)
        {
            var name = (NameSyntax)this.Visit(node.Name);
            return node.Update(name);
        }

        public virtual SyntaxNode VisitMetaClass(MetaClassSyntax node)
        {
            var isAbstract = this.VisitToken(node.IsAbstract);
            var kClass = this.VisitToken(node.KClass);
            var block1 = (MetaClassBlock1Syntax)this.Visit(node.Block1);
            var block2 = (MetaClassBlock2Syntax)this.Visit(node.Block2);
            var block3 = (MetaClassBlock3Syntax)this.Visit(node.Block3);
            return node.Update(isAbstract, kClass, block1, block2, block3);
        }

        public virtual SyntaxNode VisitMetaProperty(MetaPropertySyntax node)
        {
            var block1 = (MetaPropertyBlock1Syntax)this.Visit(node.Block1);
            var type = (MetaTypeReferenceSyntax)this.Visit(node.Type);
            var block2 = (MetaPropertyBlock2Syntax)this.Visit(node.Block2);
            var block3 = this.VisitList(node.Block3);
            var tSemicolon = this.VisitToken(node.TSemicolon);
            return node.Update(block1, type, block2, block3, tSemicolon);
        }

        public virtual SyntaxNode VisitMetaOperation(MetaOperationSyntax node)
        {
            var returnType = (MetaTypeReferenceSyntax)this.Visit(node.ReturnType);
            var name = (NameSyntax)this.Visit(node.Name);
            var tLParen = this.VisitToken(node.TLParen);
            var block = (MetaOperationBlock1Syntax)this.Visit(node.Block);
            var tRParen = this.VisitToken(node.TRParen);
            var tSemicolon = this.VisitToken(node.TSemicolon);
            return node.Update(returnType, name, tLParen, block, tRParen, tSemicolon);
        }

        public virtual SyntaxNode VisitMetaParameter(MetaParameterSyntax node)
        {
            var type = (MetaTypeReferenceSyntax)this.Visit(node.Type);
            var name = (NameSyntax)this.Visit(node.Name);
            return node.Update(type, name);
        }

        public virtual SyntaxNode VisitSimpleTypeReference(SimpleTypeReferenceSyntax node)
        {
            var typeReference = (TypeReferenceSyntax)this.Visit(node.TypeReference);
            return node.Update(typeReference);
        }

        public virtual SyntaxNode VisitMetaArrayType(MetaArrayTypeSyntax node)
        {
            var itemType = (MetaTypeReferenceSyntax)this.Visit(node.ItemType);
            var tLBracket = this.VisitToken(node.TLBracket);
            var tRBracket = this.VisitToken(node.TRBracket);
            return node.Update(itemType, tLBracket, tRBracket);
        }

        public virtual SyntaxNode VisitMetaNullableType(MetaNullableTypeSyntax node)
        {
            var innerType = (MetaTypeReferenceSyntax)this.Visit(node.InnerType);
            var tQuestion = this.VisitToken(node.TQuestion);
            return node.Update(innerType, tQuestion);
        }

        public virtual SyntaxNode VisitTypeReferenceAlt1(TypeReferenceAlt1Syntax node)
        {
            var primitiveType = (PrimitiveTypeSyntax)this.Visit(node.PrimitiveType);
            return node.Update(primitiveType);
        }

        public virtual SyntaxNode VisitTypeReferenceAlt2(TypeReferenceAlt2Syntax node)
        {
            var qualifier = (QualifierSyntax)this.Visit(node.Qualifier);
            return node.Update(qualifier);
        }

        public virtual SyntaxNode VisitPrimitiveType(PrimitiveTypeSyntax node)
        {
            var token = this.VisitToken(node.Token);
            return node.Update(token);
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
            var declarations1 = (MetaModelSyntax)this.Visit(node.Declarations1);
            var declarations2 = this.VisitList(node.Declarations2);
            return node.Update(declarations1, declarations2);
        }

        public virtual SyntaxNode VisitMetaEnumBlock1(MetaEnumBlock1Syntax node)
        {
            var tLBrace = this.VisitToken(node.TLBrace);
            var literals = this.VisitList(node.Literals);
            var tRBrace = this.VisitToken(node.TRBrace);
            return node.Update(tLBrace, literals, tRBrace);
        }

        public virtual SyntaxNode VisitMetaEnumBlock1literalsBlock(MetaEnumBlock1literalsBlockSyntax node)
        {
            var tComma = this.VisitToken(node.TComma);
            var literals = (MetaEnumLiteralSyntax)this.Visit(node.Literals);
            return node.Update(tComma, literals);
        }

        public virtual SyntaxNode VisitMetaClassBlock1Alt1(MetaClassBlock1Alt1Syntax node)
        {
            var identifier = (IdentifierSyntax)this.Visit(node.Identifier);
            var tDollar = this.VisitToken(node.TDollar);
            var symbolType = (IdentifierSyntax)this.Visit(node.SymbolType);
            return node.Update(identifier, tDollar, symbolType);
        }

        public virtual SyntaxNode VisitMetaClassBlock1Alt2(MetaClassBlock1Alt2Syntax node)
        {
            var identifier = (IdentifierSyntax)this.Visit(node.Identifier);
            return node.Update(identifier);
        }

        public virtual SyntaxNode VisitMetaClassBlock2(MetaClassBlock2Syntax node)
        {
            var tColon = this.VisitToken(node.TColon);
            var baseTypes = this.VisitList(node.BaseTypes);
            return node.Update(tColon, baseTypes);
        }

        public virtual SyntaxNode VisitMetaClassBlock2baseTypesBlock(MetaClassBlock2baseTypesBlockSyntax node)
        {
            var tComma = this.VisitToken(node.TComma);
            var baseTypes = (QualifierSyntax)this.Visit(node.BaseTypes);
            return node.Update(tComma, baseTypes);
        }

        public virtual SyntaxNode VisitMetaClassBlock3(MetaClassBlock3Syntax node)
        {
            var tLBrace = this.VisitToken(node.TLBrace);
            var block = this.VisitList(node.Block);
            var tRBrace = this.VisitToken(node.TRBrace);
            return node.Update(tLBrace, block, tRBrace);
        }

        public virtual SyntaxNode VisitMetaClassBlock3Block1Alt1(MetaClassBlock3Block1Alt1Syntax node)
        {
            var properties = (MetaPropertySyntax)this.Visit(node.Properties);
            return node.Update(properties);
        }

        public virtual SyntaxNode VisitMetaClassBlock3Block1Alt2(MetaClassBlock3Block1Alt2Syntax node)
        {
            var operations = (MetaOperationSyntax)this.Visit(node.Operations);
            return node.Update(operations);
        }

        public virtual SyntaxNode VisitMetaPropertyBlock1Alt1(MetaPropertyBlock1Alt1Syntax node)
        {
            var isContainment = this.VisitToken(node.IsContainment);
            return node.Update(isContainment);
        }

        public virtual SyntaxNode VisitMetaPropertyBlock1Alt2(MetaPropertyBlock1Alt2Syntax node)
        {
            var isDerived = this.VisitToken(node.IsDerived);
            return node.Update(isDerived);
        }

        public virtual SyntaxNode VisitMetaPropertyBlock2Alt1(MetaPropertyBlock2Alt1Syntax node)
        {
            var identifier = (IdentifierSyntax)this.Visit(node.Identifier);
            var tDollar = this.VisitToken(node.TDollar);
            var symbolProperty = (IdentifierSyntax)this.Visit(node.SymbolProperty);
            return node.Update(identifier, tDollar, symbolProperty);
        }

        public virtual SyntaxNode VisitMetaPropertyBlock2Alt2(MetaPropertyBlock2Alt2Syntax node)
        {
            var identifier = (IdentifierSyntax)this.Visit(node.Identifier);
            return node.Update(identifier);
        }

        public virtual SyntaxNode VisitMetaPropertyBlock3Alt1(MetaPropertyBlock3Alt1Syntax node)
        {
            var kOpposite = this.VisitToken(node.KOpposite);
            var oppositeProperties = this.VisitList(node.OppositeProperties);
            return node.Update(kOpposite, oppositeProperties);
        }

        public virtual SyntaxNode VisitMetaPropertyBlock3Alt2(MetaPropertyBlock3Alt2Syntax node)
        {
            var kSubsets = this.VisitToken(node.KSubsets);
            var subsettedProperties = this.VisitList(node.SubsettedProperties);
            return node.Update(kSubsets, subsettedProperties);
        }

        public virtual SyntaxNode VisitMetaPropertyBlock3Alt3(MetaPropertyBlock3Alt3Syntax node)
        {
            var kRedefines = this.VisitToken(node.KRedefines);
            var redefinedProperties = this.VisitList(node.RedefinedProperties);
            return node.Update(kRedefines, redefinedProperties);
        }

        public virtual SyntaxNode VisitMetaPropertyBlock3Alt1oppositePropertiesBlock(MetaPropertyBlock3Alt1oppositePropertiesBlockSyntax node)
        {
            var tComma = this.VisitToken(node.TComma);
            var oppositeProperties = (QualifierSyntax)this.Visit(node.OppositeProperties);
            return node.Update(tComma, oppositeProperties);
        }

        public virtual SyntaxNode VisitMetaPropertyBlock3Alt2subsettedPropertiesBlock(MetaPropertyBlock3Alt2subsettedPropertiesBlockSyntax node)
        {
            var tComma = this.VisitToken(node.TComma);
            var subsettedProperties = (QualifierSyntax)this.Visit(node.SubsettedProperties);
            return node.Update(tComma, subsettedProperties);
        }

        public virtual SyntaxNode VisitMetaPropertyBlock3Alt3redefinedPropertiesBlock(MetaPropertyBlock3Alt3redefinedPropertiesBlockSyntax node)
        {
            var tComma = this.VisitToken(node.TComma);
            var redefinedProperties = (QualifierSyntax)this.Visit(node.RedefinedProperties);
            return node.Update(tComma, redefinedProperties);
        }

        public virtual SyntaxNode VisitMetaOperationBlock1(MetaOperationBlock1Syntax node)
        {
            var parameters = this.VisitList(node.Parameters);
            return node.Update(parameters);
        }

        public virtual SyntaxNode VisitMetaOperationBlock1parametersBlock(MetaOperationBlock1parametersBlockSyntax node)
        {
            var tComma = this.VisitToken(node.TComma);
            var parameters = (MetaParameterSyntax)this.Visit(node.Parameters);
            return node.Update(tComma, parameters);
        }

        public virtual SyntaxNode VisitQualifierIdentifierBlock(QualifierIdentifierBlockSyntax node)
        {
            var tDot = this.VisitToken(node.TDot);
            var identifier = (IdentifierSyntax)this.Visit(node.Identifier);
            return node.Update(tDot, identifier);
        }

    }
}