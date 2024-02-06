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

namespace MetaDslx.Languages.MetaCompiler.Compiler.Syntax
{

    public interface ICompilerSyntaxVisitor
    {
        void VisitSkippedTokensTrivia(CompilerSkippedTokensTriviaSyntax node);
        void VisitMain(MainSyntax node);
        void VisitUsingMetaModel(UsingMetaModelSyntax node);
        void VisitUsingAlt2(UsingAlt2Syntax node);
        void VisitLanguageDeclaration(LanguageDeclarationSyntax node);
        void VisitGrammar(GrammarSyntax node);
        void VisitGrammarRuleAlt1(GrammarRuleAlt1Syntax node);
        void VisitGrammarRuleAlt2(GrammarRuleAlt2Syntax node);
        void VisitRule(RuleSyntax node);
        void VisitAlternative(AlternativeSyntax node);
        void VisitElement(ElementSyntax node);
        void VisitElementValueAlt1(ElementValueAlt1Syntax node);
        void VisitElementValueAlt2(ElementValueAlt2Syntax node);
        void VisitElementValueAlt3(ElementValueAlt3Syntax node);
        void VisitElementValueAlt4(ElementValueAlt4Syntax node);
        void VisitBlock(BlockSyntax node);
        void VisitBlockAlternative(BlockAlternativeSyntax node);
        void VisitRuleRefAlt1(RuleRefAlt1Syntax node);
        void VisitRuleRefAlt2(RuleRefAlt2Syntax node);
        void VisitRuleRefAlt3(RuleRefAlt3Syntax node);
        void VisitEof1(Eof1Syntax node);
        void VisitFixed(FixedSyntax node);
        void VisitLexerRuleAlt1(LexerRuleAlt1Syntax node);
        void VisitLexerRuleAlt2(LexerRuleAlt2Syntax node);
        void VisitToken(TokenSyntax node);
        void VisitFragment(FragmentSyntax node);
        void VisitLAlternative(LAlternativeSyntax node);
        void VisitLElement(LElementSyntax node);
        void VisitLElementValueAlt1(LElementValueAlt1Syntax node);
        void VisitLElementValueAlt2(LElementValueAlt2Syntax node);
        void VisitLElementValueAlt3(LElementValueAlt3Syntax node);
        void VisitLElementValueAlt4(LElementValueAlt4Syntax node);
        void VisitLElementValueAlt5(LElementValueAlt5Syntax node);
        void VisitLReference(LReferenceSyntax node);
        void VisitLFixed(LFixedSyntax node);
        void VisitLWildCard(LWildCardSyntax node);
        void VisitLRange(LRangeSyntax node);
        void VisitLBlock(LBlockSyntax node);
        void VisitExpressionAlt1(ExpressionAlt1Syntax node);
        void VisitExpressionAlt2(ExpressionAlt2Syntax node);
        void VisitSingleExpressionAlt1(SingleExpressionAlt1Syntax node);
        void VisitSingleExpressionAlt2(SingleExpressionAlt2Syntax node);
        void VisitArrayExpression(ArrayExpressionSyntax node);
        void VisitParserAnnotation(ParserAnnotationSyntax node);
        void VisitLexerAnnotation(LexerAnnotationSyntax node);
        void VisitAnnotationArgument(AnnotationArgumentSyntax node);
        void VisitAssignment(AssignmentSyntax node);
        void VisitMultiplicity(MultiplicitySyntax node);
        void VisitTypeReferenceIdentifierAlt1(TypeReferenceIdentifierAlt1Syntax node);
        void VisitTypeReferenceIdentifierAlt2(TypeReferenceIdentifierAlt2Syntax node);
        void VisitTypeReferenceAlt1(TypeReferenceAlt1Syntax node);
        void VisitTypeReferenceAlt2(TypeReferenceAlt2Syntax node);
        void VisitPrimitiveType(PrimitiveTypeSyntax node);
        void VisitName(NameSyntax node);
        void VisitQualifier(QualifierSyntax node);
        void VisitIdentifier(IdentifierSyntax node);
        void VisitMainBlock1(MainBlock1Syntax node);
        void VisitMainBlock2(MainBlock2Syntax node);
        void VisitLanguageDeclarationBlock1(LanguageDeclarationBlock1Syntax node);
        void VisitLanguageDeclarationBlock1baseLanguagesBlock(LanguageDeclarationBlock1baseLanguagesBlockSyntax node);
        void VisitGrammarBlock1(GrammarBlock1Syntax node);
        void VisitRuleBlock1Alt1(RuleBlock1Alt1Syntax node);
        void VisitRuleBlock1Alt2(RuleBlock1Alt2Syntax node);
        void VisitRulealternativesBlock(RulealternativesBlockSyntax node);
        void VisitAlternativeBlock1(AlternativeBlock1Syntax node);
        void VisitAlternativeBlock1Block1Alt1(AlternativeBlock1Block1Alt1Syntax node);
        void VisitAlternativeBlock1Block1Alt2(AlternativeBlock1Block1Alt2Syntax node);
        void VisitAlternativeBlock2(AlternativeBlock2Syntax node);
        void VisitElementBlock1(ElementBlock1Syntax node);
        void VisitBlockalternativesBlock(BlockalternativesBlockSyntax node);
        void VisitBlockAlternativeBlock1(BlockAlternativeBlock1Syntax node);
        void VisitRuleRefAlt3referencedTypesBlock(RuleRefAlt3referencedTypesBlockSyntax node);
        void VisitRuleRefAlt3Block1(RuleRefAlt3Block1Syntax node);
        void VisitTokenBlock1Alt1(TokenBlock1Alt1Syntax node);
        void VisitTokenBlock1Alt2(TokenBlock1Alt2Syntax node);
        void VisitTokenBlock1Alt1Block1(TokenBlock1Alt1Block1Syntax node);
        void VisitTokenalternativesBlock(TokenalternativesBlockSyntax node);
        void VisitFragmentalternativesBlock(FragmentalternativesBlockSyntax node);
        void VisitLBlockalternativesBlock(LBlockalternativesBlockSyntax node);
        void VisitSingleExpressionAlt1Block1Alt1(SingleExpressionAlt1Block1Alt1Syntax node);
        void VisitSingleExpressionAlt1Block1Alt2(SingleExpressionAlt1Block1Alt2Syntax node);
        void VisitSingleExpressionAlt1Block1Alt3(SingleExpressionAlt1Block1Alt3Syntax node);
        void VisitSingleExpressionAlt1Block1Alt4(SingleExpressionAlt1Block1Alt4Syntax node);
        void VisitSingleExpressionAlt1Block1Alt5(SingleExpressionAlt1Block1Alt5Syntax node);
        void VisitSingleExpressionAlt1Block1Alt6(SingleExpressionAlt1Block1Alt6Syntax node);
        void VisitSingleExpressionAlt1Block1Alt7(SingleExpressionAlt1Block1Alt7Syntax node);
        void VisitArrayExpressionBlock1(ArrayExpressionBlock1Syntax node);
        void VisitArrayExpressionBlock1itemsBlock(ArrayExpressionBlock1itemsBlockSyntax node);
        void VisitParserAnnotationBlock1(ParserAnnotationBlock1Syntax node);
        void VisitParserAnnotationBlock1argumentsBlock(ParserAnnotationBlock1argumentsBlockSyntax node);
        void VisitLexerAnnotationBlock1(LexerAnnotationBlock1Syntax node);
        void VisitLexerAnnotationBlock1argumentsBlock(LexerAnnotationBlock1argumentsBlockSyntax node);
        void VisitAnnotationArgumentBlock1(AnnotationArgumentBlock1Syntax node);
        void VisitQualifierIdentifierBlock(QualifierIdentifierBlockSyntax node);
    }

    public class CompilerSyntaxVisitor : SyntaxVisitor, ICompilerSyntaxVisitor
    {
        public virtual void VisitSkippedTokensTrivia(CompilerSkippedTokensTriviaSyntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitMain(MainSyntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitUsingMetaModel(UsingMetaModelSyntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitUsingAlt2(UsingAlt2Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitLanguageDeclaration(LanguageDeclarationSyntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitGrammar(GrammarSyntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitGrammarRuleAlt1(GrammarRuleAlt1Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitGrammarRuleAlt2(GrammarRuleAlt2Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitRule(RuleSyntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitAlternative(AlternativeSyntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitElement(ElementSyntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitElementValueAlt1(ElementValueAlt1Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitElementValueAlt2(ElementValueAlt2Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitElementValueAlt3(ElementValueAlt3Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitElementValueAlt4(ElementValueAlt4Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitBlock(BlockSyntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitBlockAlternative(BlockAlternativeSyntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitRuleRefAlt1(RuleRefAlt1Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitRuleRefAlt2(RuleRefAlt2Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitRuleRefAlt3(RuleRefAlt3Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitEof1(Eof1Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitFixed(FixedSyntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitLexerRuleAlt1(LexerRuleAlt1Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitLexerRuleAlt2(LexerRuleAlt2Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitToken(TokenSyntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitFragment(FragmentSyntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitLAlternative(LAlternativeSyntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitLElement(LElementSyntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitLElementValueAlt1(LElementValueAlt1Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitLElementValueAlt2(LElementValueAlt2Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitLElementValueAlt3(LElementValueAlt3Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitLElementValueAlt4(LElementValueAlt4Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitLElementValueAlt5(LElementValueAlt5Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitLReference(LReferenceSyntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitLFixed(LFixedSyntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitLWildCard(LWildCardSyntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitLRange(LRangeSyntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitLBlock(LBlockSyntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitExpressionAlt1(ExpressionAlt1Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitExpressionAlt2(ExpressionAlt2Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitSingleExpressionAlt1(SingleExpressionAlt1Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitSingleExpressionAlt2(SingleExpressionAlt2Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitArrayExpression(ArrayExpressionSyntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitParserAnnotation(ParserAnnotationSyntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitLexerAnnotation(LexerAnnotationSyntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitAnnotationArgument(AnnotationArgumentSyntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitAssignment(AssignmentSyntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitMultiplicity(MultiplicitySyntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitTypeReferenceIdentifierAlt1(TypeReferenceIdentifierAlt1Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitTypeReferenceIdentifierAlt2(TypeReferenceIdentifierAlt2Syntax node)
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

        public virtual void VisitMainBlock2(MainBlock2Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitLanguageDeclarationBlock1(LanguageDeclarationBlock1Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitLanguageDeclarationBlock1baseLanguagesBlock(LanguageDeclarationBlock1baseLanguagesBlockSyntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitGrammarBlock1(GrammarBlock1Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitRuleBlock1Alt1(RuleBlock1Alt1Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitRuleBlock1Alt2(RuleBlock1Alt2Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitRulealternativesBlock(RulealternativesBlockSyntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitAlternativeBlock1(AlternativeBlock1Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitAlternativeBlock1Block1Alt1(AlternativeBlock1Block1Alt1Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitAlternativeBlock1Block1Alt2(AlternativeBlock1Block1Alt2Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitAlternativeBlock2(AlternativeBlock2Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitElementBlock1(ElementBlock1Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitBlockalternativesBlock(BlockalternativesBlockSyntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitBlockAlternativeBlock1(BlockAlternativeBlock1Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitRuleRefAlt3referencedTypesBlock(RuleRefAlt3referencedTypesBlockSyntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitRuleRefAlt3Block1(RuleRefAlt3Block1Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitTokenBlock1Alt1(TokenBlock1Alt1Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitTokenBlock1Alt2(TokenBlock1Alt2Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitTokenBlock1Alt1Block1(TokenBlock1Alt1Block1Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitTokenalternativesBlock(TokenalternativesBlockSyntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitFragmentalternativesBlock(FragmentalternativesBlockSyntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitLBlockalternativesBlock(LBlockalternativesBlockSyntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitSingleExpressionAlt1Block1Alt1(SingleExpressionAlt1Block1Alt1Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitSingleExpressionAlt1Block1Alt2(SingleExpressionAlt1Block1Alt2Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitSingleExpressionAlt1Block1Alt3(SingleExpressionAlt1Block1Alt3Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitSingleExpressionAlt1Block1Alt4(SingleExpressionAlt1Block1Alt4Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitSingleExpressionAlt1Block1Alt5(SingleExpressionAlt1Block1Alt5Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitSingleExpressionAlt1Block1Alt6(SingleExpressionAlt1Block1Alt6Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitSingleExpressionAlt1Block1Alt7(SingleExpressionAlt1Block1Alt7Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitArrayExpressionBlock1(ArrayExpressionBlock1Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitArrayExpressionBlock1itemsBlock(ArrayExpressionBlock1itemsBlockSyntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitParserAnnotationBlock1(ParserAnnotationBlock1Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitParserAnnotationBlock1argumentsBlock(ParserAnnotationBlock1argumentsBlockSyntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitLexerAnnotationBlock1(LexerAnnotationBlock1Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitLexerAnnotationBlock1argumentsBlock(LexerAnnotationBlock1argumentsBlockSyntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitAnnotationArgumentBlock1(AnnotationArgumentBlock1Syntax node)
        {
            this.DefaultVisit(node);
        }

        public virtual void VisitQualifierIdentifierBlock(QualifierIdentifierBlockSyntax node)
        {
            this.DefaultVisit(node);
        }

    }

    public interface ICompilerSyntaxVisitor<TResult> 
    {
        TResult VisitSkippedTokensTrivia(CompilerSkippedTokensTriviaSyntax node);
        TResult VisitMain(MainSyntax node);
        TResult VisitUsingMetaModel(UsingMetaModelSyntax node);
        TResult VisitUsingAlt2(UsingAlt2Syntax node);
        TResult VisitLanguageDeclaration(LanguageDeclarationSyntax node);
        TResult VisitGrammar(GrammarSyntax node);
        TResult VisitGrammarRuleAlt1(GrammarRuleAlt1Syntax node);
        TResult VisitGrammarRuleAlt2(GrammarRuleAlt2Syntax node);
        TResult VisitRule(RuleSyntax node);
        TResult VisitAlternative(AlternativeSyntax node);
        TResult VisitElement(ElementSyntax node);
        TResult VisitElementValueAlt1(ElementValueAlt1Syntax node);
        TResult VisitElementValueAlt2(ElementValueAlt2Syntax node);
        TResult VisitElementValueAlt3(ElementValueAlt3Syntax node);
        TResult VisitElementValueAlt4(ElementValueAlt4Syntax node);
        TResult VisitBlock(BlockSyntax node);
        TResult VisitBlockAlternative(BlockAlternativeSyntax node);
        TResult VisitRuleRefAlt1(RuleRefAlt1Syntax node);
        TResult VisitRuleRefAlt2(RuleRefAlt2Syntax node);
        TResult VisitRuleRefAlt3(RuleRefAlt3Syntax node);
        TResult VisitEof1(Eof1Syntax node);
        TResult VisitFixed(FixedSyntax node);
        TResult VisitLexerRuleAlt1(LexerRuleAlt1Syntax node);
        TResult VisitLexerRuleAlt2(LexerRuleAlt2Syntax node);
        TResult VisitToken(TokenSyntax node);
        TResult VisitFragment(FragmentSyntax node);
        TResult VisitLAlternative(LAlternativeSyntax node);
        TResult VisitLElement(LElementSyntax node);
        TResult VisitLElementValueAlt1(LElementValueAlt1Syntax node);
        TResult VisitLElementValueAlt2(LElementValueAlt2Syntax node);
        TResult VisitLElementValueAlt3(LElementValueAlt3Syntax node);
        TResult VisitLElementValueAlt4(LElementValueAlt4Syntax node);
        TResult VisitLElementValueAlt5(LElementValueAlt5Syntax node);
        TResult VisitLReference(LReferenceSyntax node);
        TResult VisitLFixed(LFixedSyntax node);
        TResult VisitLWildCard(LWildCardSyntax node);
        TResult VisitLRange(LRangeSyntax node);
        TResult VisitLBlock(LBlockSyntax node);
        TResult VisitExpressionAlt1(ExpressionAlt1Syntax node);
        TResult VisitExpressionAlt2(ExpressionAlt2Syntax node);
        TResult VisitSingleExpressionAlt1(SingleExpressionAlt1Syntax node);
        TResult VisitSingleExpressionAlt2(SingleExpressionAlt2Syntax node);
        TResult VisitArrayExpression(ArrayExpressionSyntax node);
        TResult VisitParserAnnotation(ParserAnnotationSyntax node);
        TResult VisitLexerAnnotation(LexerAnnotationSyntax node);
        TResult VisitAnnotationArgument(AnnotationArgumentSyntax node);
        TResult VisitAssignment(AssignmentSyntax node);
        TResult VisitMultiplicity(MultiplicitySyntax node);
        TResult VisitTypeReferenceIdentifierAlt1(TypeReferenceIdentifierAlt1Syntax node);
        TResult VisitTypeReferenceIdentifierAlt2(TypeReferenceIdentifierAlt2Syntax node);
        TResult VisitTypeReferenceAlt1(TypeReferenceAlt1Syntax node);
        TResult VisitTypeReferenceAlt2(TypeReferenceAlt2Syntax node);
        TResult VisitPrimitiveType(PrimitiveTypeSyntax node);
        TResult VisitName(NameSyntax node);
        TResult VisitQualifier(QualifierSyntax node);
        TResult VisitIdentifier(IdentifierSyntax node);
        TResult VisitMainBlock1(MainBlock1Syntax node);
        TResult VisitMainBlock2(MainBlock2Syntax node);
        TResult VisitLanguageDeclarationBlock1(LanguageDeclarationBlock1Syntax node);
        TResult VisitLanguageDeclarationBlock1baseLanguagesBlock(LanguageDeclarationBlock1baseLanguagesBlockSyntax node);
        TResult VisitGrammarBlock1(GrammarBlock1Syntax node);
        TResult VisitRuleBlock1Alt1(RuleBlock1Alt1Syntax node);
        TResult VisitRuleBlock1Alt2(RuleBlock1Alt2Syntax node);
        TResult VisitRulealternativesBlock(RulealternativesBlockSyntax node);
        TResult VisitAlternativeBlock1(AlternativeBlock1Syntax node);
        TResult VisitAlternativeBlock1Block1Alt1(AlternativeBlock1Block1Alt1Syntax node);
        TResult VisitAlternativeBlock1Block1Alt2(AlternativeBlock1Block1Alt2Syntax node);
        TResult VisitAlternativeBlock2(AlternativeBlock2Syntax node);
        TResult VisitElementBlock1(ElementBlock1Syntax node);
        TResult VisitBlockalternativesBlock(BlockalternativesBlockSyntax node);
        TResult VisitBlockAlternativeBlock1(BlockAlternativeBlock1Syntax node);
        TResult VisitRuleRefAlt3referencedTypesBlock(RuleRefAlt3referencedTypesBlockSyntax node);
        TResult VisitRuleRefAlt3Block1(RuleRefAlt3Block1Syntax node);
        TResult VisitTokenBlock1Alt1(TokenBlock1Alt1Syntax node);
        TResult VisitTokenBlock1Alt2(TokenBlock1Alt2Syntax node);
        TResult VisitTokenBlock1Alt1Block1(TokenBlock1Alt1Block1Syntax node);
        TResult VisitTokenalternativesBlock(TokenalternativesBlockSyntax node);
        TResult VisitFragmentalternativesBlock(FragmentalternativesBlockSyntax node);
        TResult VisitLBlockalternativesBlock(LBlockalternativesBlockSyntax node);
        TResult VisitSingleExpressionAlt1Block1Alt1(SingleExpressionAlt1Block1Alt1Syntax node);
        TResult VisitSingleExpressionAlt1Block1Alt2(SingleExpressionAlt1Block1Alt2Syntax node);
        TResult VisitSingleExpressionAlt1Block1Alt3(SingleExpressionAlt1Block1Alt3Syntax node);
        TResult VisitSingleExpressionAlt1Block1Alt4(SingleExpressionAlt1Block1Alt4Syntax node);
        TResult VisitSingleExpressionAlt1Block1Alt5(SingleExpressionAlt1Block1Alt5Syntax node);
        TResult VisitSingleExpressionAlt1Block1Alt6(SingleExpressionAlt1Block1Alt6Syntax node);
        TResult VisitSingleExpressionAlt1Block1Alt7(SingleExpressionAlt1Block1Alt7Syntax node);
        TResult VisitArrayExpressionBlock1(ArrayExpressionBlock1Syntax node);
        TResult VisitArrayExpressionBlock1itemsBlock(ArrayExpressionBlock1itemsBlockSyntax node);
        TResult VisitParserAnnotationBlock1(ParserAnnotationBlock1Syntax node);
        TResult VisitParserAnnotationBlock1argumentsBlock(ParserAnnotationBlock1argumentsBlockSyntax node);
        TResult VisitLexerAnnotationBlock1(LexerAnnotationBlock1Syntax node);
        TResult VisitLexerAnnotationBlock1argumentsBlock(LexerAnnotationBlock1argumentsBlockSyntax node);
        TResult VisitAnnotationArgumentBlock1(AnnotationArgumentBlock1Syntax node);
        TResult VisitQualifierIdentifierBlock(QualifierIdentifierBlockSyntax node);
    }

    public class CompilerSyntaxVisitor<TResult> : SyntaxVisitor<TResult>, ICompilerSyntaxVisitor<TResult>
    {
        public virtual TResult VisitSkippedTokensTrivia(CompilerSkippedTokensTriviaSyntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitMain(MainSyntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitUsingMetaModel(UsingMetaModelSyntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitUsingAlt2(UsingAlt2Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitLanguageDeclaration(LanguageDeclarationSyntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitGrammar(GrammarSyntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitGrammarRuleAlt1(GrammarRuleAlt1Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitGrammarRuleAlt2(GrammarRuleAlt2Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitRule(RuleSyntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitAlternative(AlternativeSyntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitElement(ElementSyntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitElementValueAlt1(ElementValueAlt1Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitElementValueAlt2(ElementValueAlt2Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitElementValueAlt3(ElementValueAlt3Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitElementValueAlt4(ElementValueAlt4Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitBlock(BlockSyntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitBlockAlternative(BlockAlternativeSyntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitRuleRefAlt1(RuleRefAlt1Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitRuleRefAlt2(RuleRefAlt2Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitRuleRefAlt3(RuleRefAlt3Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitEof1(Eof1Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitFixed(FixedSyntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitLexerRuleAlt1(LexerRuleAlt1Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitLexerRuleAlt2(LexerRuleAlt2Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitToken(TokenSyntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitFragment(FragmentSyntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitLAlternative(LAlternativeSyntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitLElement(LElementSyntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitLElementValueAlt1(LElementValueAlt1Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitLElementValueAlt2(LElementValueAlt2Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitLElementValueAlt3(LElementValueAlt3Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitLElementValueAlt4(LElementValueAlt4Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitLElementValueAlt5(LElementValueAlt5Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitLReference(LReferenceSyntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitLFixed(LFixedSyntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitLWildCard(LWildCardSyntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitLRange(LRangeSyntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitLBlock(LBlockSyntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitExpressionAlt1(ExpressionAlt1Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitExpressionAlt2(ExpressionAlt2Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitSingleExpressionAlt1(SingleExpressionAlt1Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitSingleExpressionAlt2(SingleExpressionAlt2Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitArrayExpression(ArrayExpressionSyntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitParserAnnotation(ParserAnnotationSyntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitLexerAnnotation(LexerAnnotationSyntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitAnnotationArgument(AnnotationArgumentSyntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitAssignment(AssignmentSyntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitMultiplicity(MultiplicitySyntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitTypeReferenceIdentifierAlt1(TypeReferenceIdentifierAlt1Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitTypeReferenceIdentifierAlt2(TypeReferenceIdentifierAlt2Syntax node)
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

        public virtual TResult VisitMainBlock2(MainBlock2Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitLanguageDeclarationBlock1(LanguageDeclarationBlock1Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitLanguageDeclarationBlock1baseLanguagesBlock(LanguageDeclarationBlock1baseLanguagesBlockSyntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitGrammarBlock1(GrammarBlock1Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitRuleBlock1Alt1(RuleBlock1Alt1Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitRuleBlock1Alt2(RuleBlock1Alt2Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitRulealternativesBlock(RulealternativesBlockSyntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitAlternativeBlock1(AlternativeBlock1Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitAlternativeBlock1Block1Alt1(AlternativeBlock1Block1Alt1Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitAlternativeBlock1Block1Alt2(AlternativeBlock1Block1Alt2Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitAlternativeBlock2(AlternativeBlock2Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitElementBlock1(ElementBlock1Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitBlockalternativesBlock(BlockalternativesBlockSyntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitBlockAlternativeBlock1(BlockAlternativeBlock1Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitRuleRefAlt3referencedTypesBlock(RuleRefAlt3referencedTypesBlockSyntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitRuleRefAlt3Block1(RuleRefAlt3Block1Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitTokenBlock1Alt1(TokenBlock1Alt1Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitTokenBlock1Alt2(TokenBlock1Alt2Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitTokenBlock1Alt1Block1(TokenBlock1Alt1Block1Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitTokenalternativesBlock(TokenalternativesBlockSyntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitFragmentalternativesBlock(FragmentalternativesBlockSyntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitLBlockalternativesBlock(LBlockalternativesBlockSyntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitSingleExpressionAlt1Block1Alt1(SingleExpressionAlt1Block1Alt1Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitSingleExpressionAlt1Block1Alt2(SingleExpressionAlt1Block1Alt2Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitSingleExpressionAlt1Block1Alt3(SingleExpressionAlt1Block1Alt3Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitSingleExpressionAlt1Block1Alt4(SingleExpressionAlt1Block1Alt4Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitSingleExpressionAlt1Block1Alt5(SingleExpressionAlt1Block1Alt5Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitSingleExpressionAlt1Block1Alt6(SingleExpressionAlt1Block1Alt6Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitSingleExpressionAlt1Block1Alt7(SingleExpressionAlt1Block1Alt7Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitArrayExpressionBlock1(ArrayExpressionBlock1Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitArrayExpressionBlock1itemsBlock(ArrayExpressionBlock1itemsBlockSyntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitParserAnnotationBlock1(ParserAnnotationBlock1Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitParserAnnotationBlock1argumentsBlock(ParserAnnotationBlock1argumentsBlockSyntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitLexerAnnotationBlock1(LexerAnnotationBlock1Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitLexerAnnotationBlock1argumentsBlock(LexerAnnotationBlock1argumentsBlockSyntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitAnnotationArgumentBlock1(AnnotationArgumentBlock1Syntax node)
        {
            return this.DefaultVisit(node);
        }

        public virtual TResult VisitQualifierIdentifierBlock(QualifierIdentifierBlockSyntax node)
        {
            return this.DefaultVisit(node);
        }

    }

    public interface ICompilerSyntaxVisitor<TArg, TResult> 
    {
        TResult VisitSkippedTokensTrivia(CompilerSkippedTokensTriviaSyntax node, TArg argument);
        TResult VisitMain(MainSyntax node, TArg argument);
        TResult VisitUsingMetaModel(UsingMetaModelSyntax node, TArg argument);
        TResult VisitUsingAlt2(UsingAlt2Syntax node, TArg argument);
        TResult VisitLanguageDeclaration(LanguageDeclarationSyntax node, TArg argument);
        TResult VisitGrammar(GrammarSyntax node, TArg argument);
        TResult VisitGrammarRuleAlt1(GrammarRuleAlt1Syntax node, TArg argument);
        TResult VisitGrammarRuleAlt2(GrammarRuleAlt2Syntax node, TArg argument);
        TResult VisitRule(RuleSyntax node, TArg argument);
        TResult VisitAlternative(AlternativeSyntax node, TArg argument);
        TResult VisitElement(ElementSyntax node, TArg argument);
        TResult VisitElementValueAlt1(ElementValueAlt1Syntax node, TArg argument);
        TResult VisitElementValueAlt2(ElementValueAlt2Syntax node, TArg argument);
        TResult VisitElementValueAlt3(ElementValueAlt3Syntax node, TArg argument);
        TResult VisitElementValueAlt4(ElementValueAlt4Syntax node, TArg argument);
        TResult VisitBlock(BlockSyntax node, TArg argument);
        TResult VisitBlockAlternative(BlockAlternativeSyntax node, TArg argument);
        TResult VisitRuleRefAlt1(RuleRefAlt1Syntax node, TArg argument);
        TResult VisitRuleRefAlt2(RuleRefAlt2Syntax node, TArg argument);
        TResult VisitRuleRefAlt3(RuleRefAlt3Syntax node, TArg argument);
        TResult VisitEof1(Eof1Syntax node, TArg argument);
        TResult VisitFixed(FixedSyntax node, TArg argument);
        TResult VisitLexerRuleAlt1(LexerRuleAlt1Syntax node, TArg argument);
        TResult VisitLexerRuleAlt2(LexerRuleAlt2Syntax node, TArg argument);
        TResult VisitToken(TokenSyntax node, TArg argument);
        TResult VisitFragment(FragmentSyntax node, TArg argument);
        TResult VisitLAlternative(LAlternativeSyntax node, TArg argument);
        TResult VisitLElement(LElementSyntax node, TArg argument);
        TResult VisitLElementValueAlt1(LElementValueAlt1Syntax node, TArg argument);
        TResult VisitLElementValueAlt2(LElementValueAlt2Syntax node, TArg argument);
        TResult VisitLElementValueAlt3(LElementValueAlt3Syntax node, TArg argument);
        TResult VisitLElementValueAlt4(LElementValueAlt4Syntax node, TArg argument);
        TResult VisitLElementValueAlt5(LElementValueAlt5Syntax node, TArg argument);
        TResult VisitLReference(LReferenceSyntax node, TArg argument);
        TResult VisitLFixed(LFixedSyntax node, TArg argument);
        TResult VisitLWildCard(LWildCardSyntax node, TArg argument);
        TResult VisitLRange(LRangeSyntax node, TArg argument);
        TResult VisitLBlock(LBlockSyntax node, TArg argument);
        TResult VisitExpressionAlt1(ExpressionAlt1Syntax node, TArg argument);
        TResult VisitExpressionAlt2(ExpressionAlt2Syntax node, TArg argument);
        TResult VisitSingleExpressionAlt1(SingleExpressionAlt1Syntax node, TArg argument);
        TResult VisitSingleExpressionAlt2(SingleExpressionAlt2Syntax node, TArg argument);
        TResult VisitArrayExpression(ArrayExpressionSyntax node, TArg argument);
        TResult VisitParserAnnotation(ParserAnnotationSyntax node, TArg argument);
        TResult VisitLexerAnnotation(LexerAnnotationSyntax node, TArg argument);
        TResult VisitAnnotationArgument(AnnotationArgumentSyntax node, TArg argument);
        TResult VisitAssignment(AssignmentSyntax node, TArg argument);
        TResult VisitMultiplicity(MultiplicitySyntax node, TArg argument);
        TResult VisitTypeReferenceIdentifierAlt1(TypeReferenceIdentifierAlt1Syntax node, TArg argument);
        TResult VisitTypeReferenceIdentifierAlt2(TypeReferenceIdentifierAlt2Syntax node, TArg argument);
        TResult VisitTypeReferenceAlt1(TypeReferenceAlt1Syntax node, TArg argument);
        TResult VisitTypeReferenceAlt2(TypeReferenceAlt2Syntax node, TArg argument);
        TResult VisitPrimitiveType(PrimitiveTypeSyntax node, TArg argument);
        TResult VisitName(NameSyntax node, TArg argument);
        TResult VisitQualifier(QualifierSyntax node, TArg argument);
        TResult VisitIdentifier(IdentifierSyntax node, TArg argument);
        TResult VisitMainBlock1(MainBlock1Syntax node, TArg argument);
        TResult VisitMainBlock2(MainBlock2Syntax node, TArg argument);
        TResult VisitLanguageDeclarationBlock1(LanguageDeclarationBlock1Syntax node, TArg argument);
        TResult VisitLanguageDeclarationBlock1baseLanguagesBlock(LanguageDeclarationBlock1baseLanguagesBlockSyntax node, TArg argument);
        TResult VisitGrammarBlock1(GrammarBlock1Syntax node, TArg argument);
        TResult VisitRuleBlock1Alt1(RuleBlock1Alt1Syntax node, TArg argument);
        TResult VisitRuleBlock1Alt2(RuleBlock1Alt2Syntax node, TArg argument);
        TResult VisitRulealternativesBlock(RulealternativesBlockSyntax node, TArg argument);
        TResult VisitAlternativeBlock1(AlternativeBlock1Syntax node, TArg argument);
        TResult VisitAlternativeBlock1Block1Alt1(AlternativeBlock1Block1Alt1Syntax node, TArg argument);
        TResult VisitAlternativeBlock1Block1Alt2(AlternativeBlock1Block1Alt2Syntax node, TArg argument);
        TResult VisitAlternativeBlock2(AlternativeBlock2Syntax node, TArg argument);
        TResult VisitElementBlock1(ElementBlock1Syntax node, TArg argument);
        TResult VisitBlockalternativesBlock(BlockalternativesBlockSyntax node, TArg argument);
        TResult VisitBlockAlternativeBlock1(BlockAlternativeBlock1Syntax node, TArg argument);
        TResult VisitRuleRefAlt3referencedTypesBlock(RuleRefAlt3referencedTypesBlockSyntax node, TArg argument);
        TResult VisitRuleRefAlt3Block1(RuleRefAlt3Block1Syntax node, TArg argument);
        TResult VisitTokenBlock1Alt1(TokenBlock1Alt1Syntax node, TArg argument);
        TResult VisitTokenBlock1Alt2(TokenBlock1Alt2Syntax node, TArg argument);
        TResult VisitTokenBlock1Alt1Block1(TokenBlock1Alt1Block1Syntax node, TArg argument);
        TResult VisitTokenalternativesBlock(TokenalternativesBlockSyntax node, TArg argument);
        TResult VisitFragmentalternativesBlock(FragmentalternativesBlockSyntax node, TArg argument);
        TResult VisitLBlockalternativesBlock(LBlockalternativesBlockSyntax node, TArg argument);
        TResult VisitSingleExpressionAlt1Block1Alt1(SingleExpressionAlt1Block1Alt1Syntax node, TArg argument);
        TResult VisitSingleExpressionAlt1Block1Alt2(SingleExpressionAlt1Block1Alt2Syntax node, TArg argument);
        TResult VisitSingleExpressionAlt1Block1Alt3(SingleExpressionAlt1Block1Alt3Syntax node, TArg argument);
        TResult VisitSingleExpressionAlt1Block1Alt4(SingleExpressionAlt1Block1Alt4Syntax node, TArg argument);
        TResult VisitSingleExpressionAlt1Block1Alt5(SingleExpressionAlt1Block1Alt5Syntax node, TArg argument);
        TResult VisitSingleExpressionAlt1Block1Alt6(SingleExpressionAlt1Block1Alt6Syntax node, TArg argument);
        TResult VisitSingleExpressionAlt1Block1Alt7(SingleExpressionAlt1Block1Alt7Syntax node, TArg argument);
        TResult VisitArrayExpressionBlock1(ArrayExpressionBlock1Syntax node, TArg argument);
        TResult VisitArrayExpressionBlock1itemsBlock(ArrayExpressionBlock1itemsBlockSyntax node, TArg argument);
        TResult VisitParserAnnotationBlock1(ParserAnnotationBlock1Syntax node, TArg argument);
        TResult VisitParserAnnotationBlock1argumentsBlock(ParserAnnotationBlock1argumentsBlockSyntax node, TArg argument);
        TResult VisitLexerAnnotationBlock1(LexerAnnotationBlock1Syntax node, TArg argument);
        TResult VisitLexerAnnotationBlock1argumentsBlock(LexerAnnotationBlock1argumentsBlockSyntax node, TArg argument);
        TResult VisitAnnotationArgumentBlock1(AnnotationArgumentBlock1Syntax node, TArg argument);
        TResult VisitQualifierIdentifierBlock(QualifierIdentifierBlockSyntax node, TArg argument);
    }

    public class CompilerSyntaxVisitor<TArg, TResult> : SyntaxVisitor<TArg, TResult>, ICompilerSyntaxVisitor<TArg, TResult>
    {
        public virtual TResult VisitSkippedTokensTrivia(CompilerSkippedTokensTriviaSyntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitMain(MainSyntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitUsingMetaModel(UsingMetaModelSyntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitUsingAlt2(UsingAlt2Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitLanguageDeclaration(LanguageDeclarationSyntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitGrammar(GrammarSyntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitGrammarRuleAlt1(GrammarRuleAlt1Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitGrammarRuleAlt2(GrammarRuleAlt2Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitRule(RuleSyntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitAlternative(AlternativeSyntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitElement(ElementSyntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitElementValueAlt1(ElementValueAlt1Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitElementValueAlt2(ElementValueAlt2Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitElementValueAlt3(ElementValueAlt3Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitElementValueAlt4(ElementValueAlt4Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitBlock(BlockSyntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitBlockAlternative(BlockAlternativeSyntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitRuleRefAlt1(RuleRefAlt1Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitRuleRefAlt2(RuleRefAlt2Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitRuleRefAlt3(RuleRefAlt3Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitEof1(Eof1Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitFixed(FixedSyntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitLexerRuleAlt1(LexerRuleAlt1Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitLexerRuleAlt2(LexerRuleAlt2Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitToken(TokenSyntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitFragment(FragmentSyntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitLAlternative(LAlternativeSyntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitLElement(LElementSyntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitLElementValueAlt1(LElementValueAlt1Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitLElementValueAlt2(LElementValueAlt2Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitLElementValueAlt3(LElementValueAlt3Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitLElementValueAlt4(LElementValueAlt4Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitLElementValueAlt5(LElementValueAlt5Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitLReference(LReferenceSyntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitLFixed(LFixedSyntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitLWildCard(LWildCardSyntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitLRange(LRangeSyntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitLBlock(LBlockSyntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitExpressionAlt1(ExpressionAlt1Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitExpressionAlt2(ExpressionAlt2Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitSingleExpressionAlt1(SingleExpressionAlt1Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitSingleExpressionAlt2(SingleExpressionAlt2Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitArrayExpression(ArrayExpressionSyntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitParserAnnotation(ParserAnnotationSyntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitLexerAnnotation(LexerAnnotationSyntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitAnnotationArgument(AnnotationArgumentSyntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitAssignment(AssignmentSyntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitMultiplicity(MultiplicitySyntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitTypeReferenceIdentifierAlt1(TypeReferenceIdentifierAlt1Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitTypeReferenceIdentifierAlt2(TypeReferenceIdentifierAlt2Syntax node, TArg argument)
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

        public virtual TResult VisitMainBlock2(MainBlock2Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitLanguageDeclarationBlock1(LanguageDeclarationBlock1Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitLanguageDeclarationBlock1baseLanguagesBlock(LanguageDeclarationBlock1baseLanguagesBlockSyntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitGrammarBlock1(GrammarBlock1Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitRuleBlock1Alt1(RuleBlock1Alt1Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitRuleBlock1Alt2(RuleBlock1Alt2Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitRulealternativesBlock(RulealternativesBlockSyntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitAlternativeBlock1(AlternativeBlock1Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitAlternativeBlock1Block1Alt1(AlternativeBlock1Block1Alt1Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitAlternativeBlock1Block1Alt2(AlternativeBlock1Block1Alt2Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitAlternativeBlock2(AlternativeBlock2Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitElementBlock1(ElementBlock1Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitBlockalternativesBlock(BlockalternativesBlockSyntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitBlockAlternativeBlock1(BlockAlternativeBlock1Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitRuleRefAlt3referencedTypesBlock(RuleRefAlt3referencedTypesBlockSyntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitRuleRefAlt3Block1(RuleRefAlt3Block1Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitTokenBlock1Alt1(TokenBlock1Alt1Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitTokenBlock1Alt2(TokenBlock1Alt2Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitTokenBlock1Alt1Block1(TokenBlock1Alt1Block1Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitTokenalternativesBlock(TokenalternativesBlockSyntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitFragmentalternativesBlock(FragmentalternativesBlockSyntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitLBlockalternativesBlock(LBlockalternativesBlockSyntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitSingleExpressionAlt1Block1Alt1(SingleExpressionAlt1Block1Alt1Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitSingleExpressionAlt1Block1Alt2(SingleExpressionAlt1Block1Alt2Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitSingleExpressionAlt1Block1Alt3(SingleExpressionAlt1Block1Alt3Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitSingleExpressionAlt1Block1Alt4(SingleExpressionAlt1Block1Alt4Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitSingleExpressionAlt1Block1Alt5(SingleExpressionAlt1Block1Alt5Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitSingleExpressionAlt1Block1Alt6(SingleExpressionAlt1Block1Alt6Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitSingleExpressionAlt1Block1Alt7(SingleExpressionAlt1Block1Alt7Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitArrayExpressionBlock1(ArrayExpressionBlock1Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitArrayExpressionBlock1itemsBlock(ArrayExpressionBlock1itemsBlockSyntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitParserAnnotationBlock1(ParserAnnotationBlock1Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitParserAnnotationBlock1argumentsBlock(ParserAnnotationBlock1argumentsBlockSyntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitLexerAnnotationBlock1(LexerAnnotationBlock1Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitLexerAnnotationBlock1argumentsBlock(LexerAnnotationBlock1argumentsBlockSyntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitAnnotationArgumentBlock1(AnnotationArgumentBlock1Syntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

        public virtual TResult VisitQualifierIdentifierBlock(QualifierIdentifierBlockSyntax node, TArg argument)
        {
            return this.DefaultVisit(node, argument);
        }

    }

    public class CompilerSyntaxRewriter : SyntaxRewriter, ICompilerSyntaxVisitor<SyntaxNode?>
    {
        public CompilerSyntaxRewriter(bool visitIntoStructuredTrivia = false)
            : base(CompilerLanguage.Instance, visitIntoStructuredTrivia)
        {
        }
    
        public virtual SyntaxNode VisitSkippedTokensTrivia(CompilerSkippedTokensTriviaSyntax node)
        {
          var tokens = this.VisitList(node.Tokens);
          return node.Update(tokens);
        }

        public virtual SyntaxNode VisitMain(MainSyntax node)
        {
            var kNamespace = this.VisitToken(node.KNamespace);
            var qualifier = (QualifierSyntax)this.Visit(node.Qualifier);
            var tSemicolon = this.VisitToken(node.TSemicolon);
            var block1 = this.VisitList(node.Block1);
            var block2 = (MainBlock2Syntax)this.Visit(node.Block2);
            var endOfFileToken = this.VisitToken(node.EndOfFileToken);
            return node.Update(kNamespace, qualifier, tSemicolon, block1, block2, endOfFileToken);
        }

        public virtual SyntaxNode VisitUsingMetaModel(UsingMetaModelSyntax node)
        {
            var kMetamodel = this.VisitToken(node.KMetamodel);
            var metaModelSymbols = (QualifierSyntax)this.Visit(node.MetaModelSymbols);
            return node.Update(kMetamodel, metaModelSymbols);
        }

        public virtual SyntaxNode VisitUsingAlt2(UsingAlt2Syntax node)
        {
            var namespaces = (QualifierSyntax)this.Visit(node.Namespaces);
            return node.Update(namespaces);
        }

        public virtual SyntaxNode VisitLanguageDeclaration(LanguageDeclarationSyntax node)
        {
            var kLanguage = this.VisitToken(node.KLanguage);
            var name = (NameSyntax)this.Visit(node.Name);
            var block = (LanguageDeclarationBlock1Syntax)this.Visit(node.Block);
            var tSemicolon = this.VisitToken(node.TSemicolon);
            var grammar = (GrammarSyntax)this.Visit(node.Grammar);
            return node.Update(kLanguage, name, block, tSemicolon, grammar);
        }

        public virtual SyntaxNode VisitGrammar(GrammarSyntax node)
        {
            var block = (GrammarBlock1Syntax)this.Visit(node.Block);
            return node.Update(block);
        }

        public virtual SyntaxNode VisitGrammarRuleAlt1(GrammarRuleAlt1Syntax node)
        {
            var rule = (RuleSyntax)this.Visit(node.Rule);
            return node.Update(rule);
        }

        public virtual SyntaxNode VisitGrammarRuleAlt2(GrammarRuleAlt2Syntax node)
        {
            var lexerRule = (LexerRuleSyntax)this.Visit(node.LexerRule);
            return node.Update(lexerRule);
        }

        public virtual SyntaxNode VisitRule(RuleSyntax node)
        {
            var annotations1 = this.VisitList(node.Annotations1);
            var block = (RuleBlock1Syntax)this.Visit(node.Block);
            var tColon = this.VisitToken(node.TColon);
            var alternatives = this.VisitList(node.Alternatives);
            var tSemicolon = this.VisitToken(node.TSemicolon);
            return node.Update(annotations1, block, tColon, alternatives, tSemicolon);
        }

        public virtual SyntaxNode VisitAlternative(AlternativeSyntax node)
        {
            var block1 = (AlternativeBlock1Syntax)this.Visit(node.Block1);
            var elements = this.VisitList(node.Elements);
            var block2 = (AlternativeBlock2Syntax)this.Visit(node.Block2);
            return node.Update(block1, elements, block2);
        }

        public virtual SyntaxNode VisitElement(ElementSyntax node)
        {
            var block = (ElementBlock1Syntax)this.Visit(node.Block);
            var value = (ElementValueSyntax)this.Visit(node.Value);
            return node.Update(block, value);
        }

        public virtual SyntaxNode VisitElementValueAlt1(ElementValueAlt1Syntax node)
        {
            var block = (BlockSyntax)this.Visit(node.Block);
            return node.Update(block);
        }

        public virtual SyntaxNode VisitElementValueAlt2(ElementValueAlt2Syntax node)
        {
            var eof1 = (Eof1Syntax)this.Visit(node.Eof1);
            return node.Update(eof1);
        }

        public virtual SyntaxNode VisitElementValueAlt3(ElementValueAlt3Syntax node)
        {
            var @fixed = (FixedSyntax)this.Visit(node.Fixed);
            return node.Update(@fixed);
        }

        public virtual SyntaxNode VisitElementValueAlt4(ElementValueAlt4Syntax node)
        {
            var ruleRef = (RuleRefSyntax)this.Visit(node.RuleRef);
            return node.Update(ruleRef);
        }

        public virtual SyntaxNode VisitBlock(BlockSyntax node)
        {
            var annotations1 = this.VisitList(node.Annotations1);
            var tLParen = this.VisitToken(node.TLParen);
            var alternatives = this.VisitList(node.Alternatives);
            var tRParen = this.VisitToken(node.TRParen);
            var multiplicity = (MultiplicitySyntax)this.Visit(node.Multiplicity);
            return node.Update(annotations1, tLParen, alternatives, tRParen, multiplicity);
        }

        public virtual SyntaxNode VisitBlockAlternative(BlockAlternativeSyntax node)
        {
            var elements = this.VisitList(node.Elements);
            var block = (BlockAlternativeBlock1Syntax)this.Visit(node.Block);
            return node.Update(elements, block);
        }

        public virtual SyntaxNode VisitRuleRefAlt1(RuleRefAlt1Syntax node)
        {
            var annotations1 = this.VisitList(node.Annotations1);
            var grammarRule = (IdentifierSyntax)this.Visit(node.GrammarRule);
            var multiplicity = (MultiplicitySyntax)this.Visit(node.Multiplicity);
            return node.Update(annotations1, grammarRule, multiplicity);
        }

        public virtual SyntaxNode VisitRuleRefAlt2(RuleRefAlt2Syntax node)
        {
            var annotations1 = this.VisitList(node.Annotations1);
            var tHash = this.VisitToken(node.THash);
            var referencedTypes = (TypeReferenceSyntax)this.Visit(node.ReferencedTypes);
            var multiplicity = (MultiplicitySyntax)this.Visit(node.Multiplicity);
            return node.Update(annotations1, tHash, referencedTypes, multiplicity);
        }

        public virtual SyntaxNode VisitRuleRefAlt3(RuleRefAlt3Syntax node)
        {
            var annotations1 = this.VisitList(node.Annotations1);
            var tHashLBrace = this.VisitToken(node.THashLBrace);
            var referencedTypes = this.VisitList(node.ReferencedTypes);
            var block = (RuleRefAlt3Block1Syntax)this.Visit(node.Block);
            var tRBrace = this.VisitToken(node.TRBrace);
            var multiplicity = (MultiplicitySyntax)this.Visit(node.Multiplicity);
            return node.Update(annotations1, tHashLBrace, referencedTypes, block, tRBrace, multiplicity);
        }

        public virtual SyntaxNode VisitEof1(Eof1Syntax node)
        {
            var kEof = this.VisitToken(node.KEof);
            return node.Update(kEof);
        }

        public virtual SyntaxNode VisitFixed(FixedSyntax node)
        {
            var annotations1 = this.VisitList(node.Annotations1);
            var text = this.VisitToken(node.Text);
            var multiplicity = (MultiplicitySyntax)this.Visit(node.Multiplicity);
            return node.Update(annotations1, text, multiplicity);
        }

        public virtual SyntaxNode VisitLexerRuleAlt1(LexerRuleAlt1Syntax node)
        {
            var token = (TokenSyntax)this.Visit(node.Token);
            return node.Update(token);
        }

        public virtual SyntaxNode VisitLexerRuleAlt2(LexerRuleAlt2Syntax node)
        {
            var fragment = (FragmentSyntax)this.Visit(node.Fragment);
            return node.Update(fragment);
        }

        public virtual SyntaxNode VisitToken(TokenSyntax node)
        {
            var annotations1 = this.VisitList(node.Annotations1);
            var block = (TokenBlock1Syntax)this.Visit(node.Block);
            var tColon = this.VisitToken(node.TColon);
            var alternatives = this.VisitList(node.Alternatives);
            var tSemicolon = this.VisitToken(node.TSemicolon);
            return node.Update(annotations1, block, tColon, alternatives, tSemicolon);
        }

        public virtual SyntaxNode VisitFragment(FragmentSyntax node)
        {
            var kFragment = this.VisitToken(node.KFragment);
            var name = (NameSyntax)this.Visit(node.Name);
            var tColon = this.VisitToken(node.TColon);
            var alternatives = this.VisitList(node.Alternatives);
            var tSemicolon = this.VisitToken(node.TSemicolon);
            return node.Update(kFragment, name, tColon, alternatives, tSemicolon);
        }

        public virtual SyntaxNode VisitLAlternative(LAlternativeSyntax node)
        {
            var elements = this.VisitList(node.Elements);
            return node.Update(elements);
        }

        public virtual SyntaxNode VisitLElement(LElementSyntax node)
        {
            var isNegated = this.VisitToken(node.IsNegated);
            var value = (LElementValueSyntax)this.Visit(node.Value);
            var multiplicity = (MultiplicitySyntax)this.Visit(node.Multiplicity);
            return node.Update(isNegated, value, multiplicity);
        }

        public virtual SyntaxNode VisitLElementValueAlt1(LElementValueAlt1Syntax node)
        {
            var lBlock = (LBlockSyntax)this.Visit(node.LBlock);
            return node.Update(lBlock);
        }

        public virtual SyntaxNode VisitLElementValueAlt2(LElementValueAlt2Syntax node)
        {
            var lFixed = (LFixedSyntax)this.Visit(node.LFixed);
            return node.Update(lFixed);
        }

        public virtual SyntaxNode VisitLElementValueAlt3(LElementValueAlt3Syntax node)
        {
            var lWildCard = (LWildCardSyntax)this.Visit(node.LWildCard);
            return node.Update(lWildCard);
        }

        public virtual SyntaxNode VisitLElementValueAlt4(LElementValueAlt4Syntax node)
        {
            var lRange = (LRangeSyntax)this.Visit(node.LRange);
            return node.Update(lRange);
        }

        public virtual SyntaxNode VisitLElementValueAlt5(LElementValueAlt5Syntax node)
        {
            var lReference = (LReferenceSyntax)this.Visit(node.LReference);
            return node.Update(lReference);
        }

        public virtual SyntaxNode VisitLReference(LReferenceSyntax node)
        {
            var rule = (IdentifierSyntax)this.Visit(node.Rule);
            return node.Update(rule);
        }

        public virtual SyntaxNode VisitLFixed(LFixedSyntax node)
        {
            var text = this.VisitToken(node.Text);
            return node.Update(text);
        }

        public virtual SyntaxNode VisitLWildCard(LWildCardSyntax node)
        {
            var tDot = this.VisitToken(node.TDot);
            return node.Update(tDot);
        }

        public virtual SyntaxNode VisitLRange(LRangeSyntax node)
        {
            var startChar = this.VisitToken(node.StartChar);
            var tDotDot = this.VisitToken(node.TDotDot);
            var endChar = this.VisitToken(node.EndChar);
            return node.Update(startChar, tDotDot, endChar);
        }

        public virtual SyntaxNode VisitLBlock(LBlockSyntax node)
        {
            var tLParen = this.VisitToken(node.TLParen);
            var alternatives = this.VisitList(node.Alternatives);
            var tRParen = this.VisitToken(node.TRParen);
            return node.Update(tLParen, alternatives, tRParen);
        }

        public virtual SyntaxNode VisitExpressionAlt1(ExpressionAlt1Syntax node)
        {
            var singleExpression = (SingleExpressionSyntax)this.Visit(node.SingleExpression);
            return node.Update(singleExpression);
        }

        public virtual SyntaxNode VisitExpressionAlt2(ExpressionAlt2Syntax node)
        {
            var arrayExpression = (ArrayExpressionSyntax)this.Visit(node.ArrayExpression);
            return node.Update(arrayExpression);
        }

        public virtual SyntaxNode VisitSingleExpressionAlt1(SingleExpressionAlt1Syntax node)
        {
            var value = (SingleExpressionAlt1Block1Syntax)this.Visit(node.Value);
            return node.Update(value);
        }

        public virtual SyntaxNode VisitSingleExpressionAlt2(SingleExpressionAlt2Syntax node)
        {
            var value = (QualifierSyntax)this.Visit(node.Value);
            return node.Update(value);
        }

        public virtual SyntaxNode VisitArrayExpression(ArrayExpressionSyntax node)
        {
            var tLBrace = this.VisitToken(node.TLBrace);
            var block = (ArrayExpressionBlock1Syntax)this.Visit(node.Block);
            var tRBrace = this.VisitToken(node.TRBrace);
            return node.Update(tLBrace, block, tRBrace);
        }

        public virtual SyntaxNode VisitParserAnnotation(ParserAnnotationSyntax node)
        {
            var tLBracket = this.VisitToken(node.TLBracket);
            var attributeClass = (QualifierSyntax)this.Visit(node.AttributeClass);
            var block = (ParserAnnotationBlock1Syntax)this.Visit(node.Block);
            var tRBracket = this.VisitToken(node.TRBracket);
            return node.Update(tLBracket, attributeClass, block, tRBracket);
        }

        public virtual SyntaxNode VisitLexerAnnotation(LexerAnnotationSyntax node)
        {
            var tLBracket = this.VisitToken(node.TLBracket);
            var attributeClass = (QualifierSyntax)this.Visit(node.AttributeClass);
            var block = (LexerAnnotationBlock1Syntax)this.Visit(node.Block);
            var tRBracket = this.VisitToken(node.TRBracket);
            return node.Update(tLBracket, attributeClass, block, tRBracket);
        }

        public virtual SyntaxNode VisitAnnotationArgument(AnnotationArgumentSyntax node)
        {
            var block = (AnnotationArgumentBlock1Syntax)this.Visit(node.Block);
            var value = (ExpressionSyntax)this.Visit(node.Value);
            return node.Update(block, value);
        }

        public virtual SyntaxNode VisitAssignment(AssignmentSyntax node)
        {
            var token = this.VisitToken(node.Token);
            return node.Update(token);
        }

        public virtual SyntaxNode VisitMultiplicity(MultiplicitySyntax node)
        {
            var token = this.VisitToken(node.Token);
            return node.Update(token);
        }

        public virtual SyntaxNode VisitTypeReferenceIdentifierAlt1(TypeReferenceIdentifierAlt1Syntax node)
        {
            var primitiveType = (PrimitiveTypeSyntax)this.Visit(node.PrimitiveType);
            return node.Update(primitiveType);
        }

        public virtual SyntaxNode VisitTypeReferenceIdentifierAlt2(TypeReferenceIdentifierAlt2Syntax node)
        {
            var identifier = (IdentifierSyntax)this.Visit(node.Identifier);
            return node.Update(identifier);
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
            var kUsing = this.VisitToken(node.KUsing);
            var @using = (UsingSyntax)this.Visit(node.Using);
            var tSemicolon = this.VisitToken(node.TSemicolon);
            return node.Update(kUsing, @using, tSemicolon);
        }

        public virtual SyntaxNode VisitMainBlock2(MainBlock2Syntax node)
        {
            var declarations = (LanguageDeclarationSyntax)this.Visit(node.Declarations);
            return node.Update(declarations);
        }

        public virtual SyntaxNode VisitLanguageDeclarationBlock1(LanguageDeclarationBlock1Syntax node)
        {
            var tColon = this.VisitToken(node.TColon);
            var baseLanguages = this.VisitList(node.BaseLanguages);
            return node.Update(tColon, baseLanguages);
        }

        public virtual SyntaxNode VisitLanguageDeclarationBlock1baseLanguagesBlock(LanguageDeclarationBlock1baseLanguagesBlockSyntax node)
        {
            var tComma = this.VisitToken(node.TComma);
            var baseLanguages = (QualifierSyntax)this.Visit(node.BaseLanguages);
            return node.Update(tComma, baseLanguages);
        }

        public virtual SyntaxNode VisitGrammarBlock1(GrammarBlock1Syntax node)
        {
            var grammarRules = this.VisitList(node.GrammarRules);
            return node.Update(grammarRules);
        }

        public virtual SyntaxNode VisitRuleBlock1Alt1(RuleBlock1Alt1Syntax node)
        {
            var returnType = (TypeReferenceIdentifierSyntax)this.Visit(node.ReturnType);
            return node.Update(returnType);
        }

        public virtual SyntaxNode VisitRuleBlock1Alt2(RuleBlock1Alt2Syntax node)
        {
            var identifier = (IdentifierSyntax)this.Visit(node.Identifier);
            var kReturns = this.VisitToken(node.KReturns);
            var returnType = (TypeReferenceSyntax)this.Visit(node.ReturnType);
            return node.Update(identifier, kReturns, returnType);
        }

        public virtual SyntaxNode VisitRulealternativesBlock(RulealternativesBlockSyntax node)
        {
            var tBar = this.VisitToken(node.TBar);
            var alternatives = (AlternativeSyntax)this.Visit(node.Alternatives);
            return node.Update(tBar, alternatives);
        }

        public virtual SyntaxNode VisitAlternativeBlock1(AlternativeBlock1Syntax node)
        {
            var annotations1 = this.VisitList(node.Annotations1);
            var kAlt = this.VisitToken(node.KAlt);
            var block = (AlternativeBlock1Block1Syntax)this.Visit(node.Block);
            var tColon = this.VisitToken(node.TColon);
            return node.Update(annotations1, kAlt, block, tColon);
        }

        public virtual SyntaxNode VisitAlternativeBlock1Block1Alt1(AlternativeBlock1Block1Alt1Syntax node)
        {
            var returnType = (TypeReferenceIdentifierSyntax)this.Visit(node.ReturnType);
            return node.Update(returnType);
        }

        public virtual SyntaxNode VisitAlternativeBlock1Block1Alt2(AlternativeBlock1Block1Alt2Syntax node)
        {
            var identifier = (IdentifierSyntax)this.Visit(node.Identifier);
            var kReturns = this.VisitToken(node.KReturns);
            var returnType = (TypeReferenceSyntax)this.Visit(node.ReturnType);
            return node.Update(identifier, kReturns, returnType);
        }

        public virtual SyntaxNode VisitAlternativeBlock2(AlternativeBlock2Syntax node)
        {
            var tEqGt = this.VisitToken(node.TEqGt);
            var returnValue = (ExpressionSyntax)this.Visit(node.ReturnValue);
            return node.Update(tEqGt, returnValue);
        }

        public virtual SyntaxNode VisitElementBlock1(ElementBlock1Syntax node)
        {
            var annotations1 = this.VisitList(node.Annotations1);
            var name = (NameSyntax)this.Visit(node.Name);
            var assignment = (AssignmentSyntax)this.Visit(node.Assignment);
            return node.Update(annotations1, name, assignment);
        }

        public virtual SyntaxNode VisitBlockalternativesBlock(BlockalternativesBlockSyntax node)
        {
            var tBar = this.VisitToken(node.TBar);
            var alternatives = (BlockAlternativeSyntax)this.Visit(node.Alternatives);
            return node.Update(tBar, alternatives);
        }

        public virtual SyntaxNode VisitBlockAlternativeBlock1(BlockAlternativeBlock1Syntax node)
        {
            var tEqGt = this.VisitToken(node.TEqGt);
            var returnValue = (ExpressionSyntax)this.Visit(node.ReturnValue);
            return node.Update(tEqGt, returnValue);
        }

        public virtual SyntaxNode VisitRuleRefAlt3referencedTypesBlock(RuleRefAlt3referencedTypesBlockSyntax node)
        {
            var tComma = this.VisitToken(node.TComma);
            var referencedTypes = (TypeReferenceSyntax)this.Visit(node.ReferencedTypes);
            return node.Update(tComma, referencedTypes);
        }

        public virtual SyntaxNode VisitRuleRefAlt3Block1(RuleRefAlt3Block1Syntax node)
        {
            var tBar = this.VisitToken(node.TBar);
            var grammarRule = (IdentifierSyntax)this.Visit(node.GrammarRule);
            return node.Update(tBar, grammarRule);
        }

        public virtual SyntaxNode VisitTokenBlock1Alt1(TokenBlock1Alt1Syntax node)
        {
            var kToken = this.VisitToken(node.KToken);
            var name = (NameSyntax)this.Visit(node.Name);
            var block = (TokenBlock1Alt1Block1Syntax)this.Visit(node.Block);
            return node.Update(kToken, name, block);
        }

        public virtual SyntaxNode VisitTokenBlock1Alt2(TokenBlock1Alt2Syntax node)
        {
            var isTrivia = this.VisitToken(node.IsTrivia);
            var name = (NameSyntax)this.Visit(node.Name);
            return node.Update(isTrivia, name);
        }

        public virtual SyntaxNode VisitTokenBlock1Alt1Block1(TokenBlock1Alt1Block1Syntax node)
        {
            var kReturns = this.VisitToken(node.KReturns);
            var returnType = (TypeReferenceSyntax)this.Visit(node.ReturnType);
            return node.Update(kReturns, returnType);
        }

        public virtual SyntaxNode VisitTokenalternativesBlock(TokenalternativesBlockSyntax node)
        {
            var tBar = this.VisitToken(node.TBar);
            var alternatives = (LAlternativeSyntax)this.Visit(node.Alternatives);
            return node.Update(tBar, alternatives);
        }

        public virtual SyntaxNode VisitFragmentalternativesBlock(FragmentalternativesBlockSyntax node)
        {
            var tBar = this.VisitToken(node.TBar);
            var alternatives = (LAlternativeSyntax)this.Visit(node.Alternatives);
            return node.Update(tBar, alternatives);
        }

        public virtual SyntaxNode VisitLBlockalternativesBlock(LBlockalternativesBlockSyntax node)
        {
            var tBar = this.VisitToken(node.TBar);
            var alternatives = (LAlternativeSyntax)this.Visit(node.Alternatives);
            return node.Update(tBar, alternatives);
        }

        public virtual SyntaxNode VisitSingleExpressionAlt1Block1Alt1(SingleExpressionAlt1Block1Alt1Syntax node)
        {
            var kNull = this.VisitToken(node.KNull);
            return node.Update(kNull);
        }

        public virtual SyntaxNode VisitSingleExpressionAlt1Block1Alt2(SingleExpressionAlt1Block1Alt2Syntax node)
        {
            var kTrue = this.VisitToken(node.KTrue);
            return node.Update(kTrue);
        }

        public virtual SyntaxNode VisitSingleExpressionAlt1Block1Alt3(SingleExpressionAlt1Block1Alt3Syntax node)
        {
            var kFalse = this.VisitToken(node.KFalse);
            return node.Update(kFalse);
        }

        public virtual SyntaxNode VisitSingleExpressionAlt1Block1Alt4(SingleExpressionAlt1Block1Alt4Syntax node)
        {
            var tString = this.VisitToken(node.TString);
            return node.Update(tString);
        }

        public virtual SyntaxNode VisitSingleExpressionAlt1Block1Alt5(SingleExpressionAlt1Block1Alt5Syntax node)
        {
            var tInteger = this.VisitToken(node.TInteger);
            return node.Update(tInteger);
        }

        public virtual SyntaxNode VisitSingleExpressionAlt1Block1Alt6(SingleExpressionAlt1Block1Alt6Syntax node)
        {
            var tDecimal = this.VisitToken(node.TDecimal);
            return node.Update(tDecimal);
        }

        public virtual SyntaxNode VisitSingleExpressionAlt1Block1Alt7(SingleExpressionAlt1Block1Alt7Syntax node)
        {
            var primitiveType = (PrimitiveTypeSyntax)this.Visit(node.PrimitiveType);
            return node.Update(primitiveType);
        }

        public virtual SyntaxNode VisitArrayExpressionBlock1(ArrayExpressionBlock1Syntax node)
        {
            var items = this.VisitList(node.Items);
            return node.Update(items);
        }

        public virtual SyntaxNode VisitArrayExpressionBlock1itemsBlock(ArrayExpressionBlock1itemsBlockSyntax node)
        {
            var tComma = this.VisitToken(node.TComma);
            var items = (SingleExpressionSyntax)this.Visit(node.Items);
            return node.Update(tComma, items);
        }

        public virtual SyntaxNode VisitParserAnnotationBlock1(ParserAnnotationBlock1Syntax node)
        {
            var tLParen = this.VisitToken(node.TLParen);
            var arguments = this.VisitList(node.Arguments);
            var tRParen = this.VisitToken(node.TRParen);
            return node.Update(tLParen, arguments, tRParen);
        }

        public virtual SyntaxNode VisitParserAnnotationBlock1argumentsBlock(ParserAnnotationBlock1argumentsBlockSyntax node)
        {
            var tComma = this.VisitToken(node.TComma);
            var arguments = (AnnotationArgumentSyntax)this.Visit(node.Arguments);
            return node.Update(tComma, arguments);
        }

        public virtual SyntaxNode VisitLexerAnnotationBlock1(LexerAnnotationBlock1Syntax node)
        {
            var tLParen = this.VisitToken(node.TLParen);
            var arguments = this.VisitList(node.Arguments);
            var tRParen = this.VisitToken(node.TRParen);
            return node.Update(tLParen, arguments, tRParen);
        }

        public virtual SyntaxNode VisitLexerAnnotationBlock1argumentsBlock(LexerAnnotationBlock1argumentsBlockSyntax node)
        {
            var tComma = this.VisitToken(node.TComma);
            var arguments = (AnnotationArgumentSyntax)this.Visit(node.Arguments);
            return node.Update(tComma, arguments);
        }

        public virtual SyntaxNode VisitAnnotationArgumentBlock1(AnnotationArgumentBlock1Syntax node)
        {
            var namedParameter = (IdentifierSyntax)this.Visit(node.NamedParameter);
            var tColon = this.VisitToken(node.TColon);
            return node.Update(namedParameter, tColon);
        }

        public virtual SyntaxNode VisitQualifierIdentifierBlock(QualifierIdentifierBlockSyntax node)
        {
            var tDot = this.VisitToken(node.TDot);
            var identifier = (IdentifierSyntax)this.Visit(node.Identifier);
            return node.Update(tDot, identifier);
        }

    }
}
