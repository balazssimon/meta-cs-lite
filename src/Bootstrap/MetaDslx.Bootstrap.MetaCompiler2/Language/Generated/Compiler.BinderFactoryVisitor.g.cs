using System;
using System.Collections.Immutable;
using MetaDslx.CodeAnalysis;

#nullable enable

namespace MetaDslx.Bootstrap.MetaCompiler2.Compiler.Binding
{
    using global::MetaDslx.Bootstrap.MetaCompiler2.Compiler.Syntax;

    public class CompilerBinderFactoryVisitor : MetaDslx.CodeAnalysis.Binding.BinderFactoryVisitor, ICompilerSyntaxVisitor
    {
        internal CompilerBinderFactoryVisitor(MetaDslx.CodeAnalysis.Binding.BinderFactory binderFactory)
            : base(binderFactory)
        {
        }


        public virtual void VisitMain(MainSyntax node)
        {
        }

        public virtual void VisitUsing(UsingSyntax node)
        {
        }

        public virtual void VisitLanguageDeclaration(LanguageDeclarationSyntax node)
        {
        }

        public virtual void VisitGrammar(GrammarSyntax node)
        {
        }

        public virtual void VisitGrammarRuleAlt1(GrammarRuleAlt1Syntax node)
        {
        }

        public virtual void VisitGrammarRuleAlt2(GrammarRuleAlt2Syntax node)
        {
        }

        public virtual void VisitRule(RuleSyntax node)
        {
        }

        public virtual void VisitAlternative(AlternativeSyntax node)
        {
        }

        public virtual void VisitElement(ElementSyntax node)
        {
        }

        public virtual void VisitElementValueAlt1(ElementValueAlt1Syntax node)
        {
        }

        public virtual void VisitElementValueAlt2(ElementValueAlt2Syntax node)
        {
        }

        public virtual void VisitElementValueAlt3(ElementValueAlt3Syntax node)
        {
        }

        public virtual void VisitElementValueAlt4(ElementValueAlt4Syntax node)
        {
        }

        public virtual void VisitBlock(BlockSyntax node)
        {
        }

        public virtual void VisitBlockAlternative(BlockAlternativeSyntax node)
        {
        }

        public virtual void VisitRuleRefAlt1(RuleRefAlt1Syntax node)
        {
        }

        public virtual void VisitRuleRefAlt2(RuleRefAlt2Syntax node)
        {
        }

        public virtual void VisitRuleRefAlt3(RuleRefAlt3Syntax node)
        {
        }

        public virtual void VisitEof1(Eof1Syntax node)
        {
        }

        public virtual void VisitFixed(FixedSyntax node)
        {
        }

        public virtual void VisitLexerRuleAlt1(LexerRuleAlt1Syntax node)
        {
        }

        public virtual void VisitLexerRuleAlt2(LexerRuleAlt2Syntax node)
        {
        }

        public virtual void VisitToken(TokenSyntax node)
        {
        }

        public virtual void VisitFragment(FragmentSyntax node)
        {
        }

        public virtual void VisitLAlternative(LAlternativeSyntax node)
        {
        }

        public virtual void VisitLElement(LElementSyntax node)
        {
        }

        public virtual void VisitLElementValueAlt1(LElementValueAlt1Syntax node)
        {
        }

        public virtual void VisitLElementValueAlt2(LElementValueAlt2Syntax node)
        {
        }

        public virtual void VisitLElementValueAlt3(LElementValueAlt3Syntax node)
        {
        }

        public virtual void VisitLElementValueAlt4(LElementValueAlt4Syntax node)
        {
        }

        public virtual void VisitLElementValueAlt5(LElementValueAlt5Syntax node)
        {
        }

        public virtual void VisitLReference(LReferenceSyntax node)
        {
        }

        public virtual void VisitLFixed(LFixedSyntax node)
        {
        }

        public virtual void VisitLWildCard(LWildCardSyntax node)
        {
        }

        public virtual void VisitLRange(LRangeSyntax node)
        {
        }

        public virtual void VisitLBlock(LBlockSyntax node)
        {
        }

        public virtual void VisitExpressionAlt1(ExpressionAlt1Syntax node)
        {
        }

        public virtual void VisitExpressionAlt2(ExpressionAlt2Syntax node)
        {
        }

        public virtual void VisitSingleExpressionAlt1(SingleExpressionAlt1Syntax node)
        {
        }

        public virtual void VisitSingleExpressionAlt2(SingleExpressionAlt2Syntax node)
        {
        }

        public virtual void VisitArrayExpression(ArrayExpressionSyntax node)
        {
        }

        public virtual void VisitParserAnnotation(ParserAnnotationSyntax node)
        {
        }

        public virtual void VisitLexerAnnotation(LexerAnnotationSyntax node)
        {
        }

        public virtual void VisitAnnotationArgument(AnnotationArgumentSyntax node)
        {
        }

        public virtual void VisitAssignment(AssignmentSyntax node)
        {
        }

        public virtual void VisitMultiplicity(MultiplicitySyntax node)
        {
        }

        public virtual void VisitTypeReferenceIdentifierAlt1(TypeReferenceIdentifierAlt1Syntax node)
        {
        }

        public virtual void VisitTypeReferenceIdentifierAlt2(TypeReferenceIdentifierAlt2Syntax node)
        {
        }

        public virtual void VisitTypeReferenceAlt1(TypeReferenceAlt1Syntax node)
        {
        }

        public virtual void VisitTypeReferenceAlt2(TypeReferenceAlt2Syntax node)
        {
        }

        public virtual void VisitPrimitiveType(PrimitiveTypeSyntax node)
        {
        }

        public virtual void VisitName(NameSyntax node)
        {
        }

        public virtual void VisitQualifier(QualifierSyntax node)
        {
        }

        public virtual void VisitIdentifier(IdentifierSyntax node)
        {
        }

        public virtual void VisitMainBlock1(MainBlock1Syntax node)
        {
        }

        public virtual void VisitGrammarBlock1(GrammarBlock1Syntax node)
        {
        }

        public virtual void VisitRuleBlock1Alt1(RuleBlock1Alt1Syntax node)
        {
        }

        public virtual void VisitRuleBlock1Alt2(RuleBlock1Alt2Syntax node)
        {
        }

        public virtual void VisitRulealternativesBlock(RulealternativesBlockSyntax node)
        {
        }

        public virtual void VisitAlternativeBlock1(AlternativeBlock1Syntax node)
        {
        }

        public virtual void VisitAlternativeBlock1Block1(AlternativeBlock1Block1Syntax node)
        {
        }

        public virtual void VisitAlternativeBlock2(AlternativeBlock2Syntax node)
        {
        }

        public virtual void VisitElementBlock1(ElementBlock1Syntax node)
        {
        }

        public virtual void VisitBlockalternativesBlock(BlockalternativesBlockSyntax node)
        {
        }

        public virtual void VisitBlockAlternativeBlock1(BlockAlternativeBlock1Syntax node)
        {
        }

        public virtual void VisitRuleRefAlt3referencedTypesBlock(RuleRefAlt3referencedTypesBlockSyntax node)
        {
        }

        public virtual void VisitRuleRefAlt3Block1(RuleRefAlt3Block1Syntax node)
        {
        }

        public virtual void VisitTokenBlock1Alt1(TokenBlock1Alt1Syntax node)
        {
        }

        public virtual void VisitTokenBlock1Alt2(TokenBlock1Alt2Syntax node)
        {
        }

        public virtual void VisitTokenBlock1Alt1Block1(TokenBlock1Alt1Block1Syntax node)
        {
        }

        public virtual void VisitTokenalternativesBlock(TokenalternativesBlockSyntax node)
        {
        }

        public virtual void VisitFragmentalternativesBlock(FragmentalternativesBlockSyntax node)
        {
        }

        public virtual void VisitLBlockalternativesBlock(LBlockalternativesBlockSyntax node)
        {
        }

        public virtual void VisitSingleExpressionAlt1Block1Alt1(SingleExpressionAlt1Block1Alt1Syntax node)
        {
        }

        public virtual void VisitSingleExpressionAlt1Block1Alt2(SingleExpressionAlt1Block1Alt2Syntax node)
        {
        }

        public virtual void VisitSingleExpressionAlt1Block1Alt3(SingleExpressionAlt1Block1Alt3Syntax node)
        {
        }

        public virtual void VisitSingleExpressionAlt1Block1Alt4(SingleExpressionAlt1Block1Alt4Syntax node)
        {
        }

        public virtual void VisitSingleExpressionAlt1Block1Alt5(SingleExpressionAlt1Block1Alt5Syntax node)
        {
        }

        public virtual void VisitSingleExpressionAlt1Block1Alt6(SingleExpressionAlt1Block1Alt6Syntax node)
        {
        }

        public virtual void VisitSingleExpressionAlt1Block1Alt7(SingleExpressionAlt1Block1Alt7Syntax node)
        {
        }

        public virtual void VisitArrayExpressionBlock1(ArrayExpressionBlock1Syntax node)
        {
        }

        public virtual void VisitArrayExpressionBlock1itemsBlock(ArrayExpressionBlock1itemsBlockSyntax node)
        {
        }

        public virtual void VisitParserAnnotationBlock1(ParserAnnotationBlock1Syntax node)
        {
        }

        public virtual void VisitParserAnnotationBlock1argumentsBlock(ParserAnnotationBlock1argumentsBlockSyntax node)
        {
        }

        public virtual void VisitLexerAnnotationBlock1(LexerAnnotationBlock1Syntax node)
        {
        }

        public virtual void VisitLexerAnnotationBlock1argumentsBlock(LexerAnnotationBlock1argumentsBlockSyntax node)
        {
        }

        public virtual void VisitAnnotationArgumentBlock1(AnnotationArgumentBlock1Syntax node)
        {
        }

        public virtual void VisitQualifierIdentifierBlock(QualifierIdentifierBlockSyntax node)
        {
        }

        public virtual void VisitSkippedTokensTrivia(CompilerSkippedTokensTriviaSyntax node)
        {
        }
    }
}
