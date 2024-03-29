//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.13.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from CompilerParser.g4 by ANTLR 4.13.0

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace MetaDslx.Bootstrap.MetaCompiler2.Compiler {
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="CompilerParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.13.0")]
[System.CLSCompliant(false)]
public interface ICompilerParserVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_Main"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_Main([NotNull] CompilerParser.Pr_MainContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_UsingMetaModel</c>
	/// labeled alternative in <see cref="CompilerParser.pr_Using"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_UsingMetaModel([NotNull] CompilerParser.Pr_UsingMetaModelContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_UsingAlt2</c>
	/// labeled alternative in <see cref="CompilerParser.pr_Using"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_UsingAlt2([NotNull] CompilerParser.Pr_UsingAlt2Context context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_LanguageDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_LanguageDeclaration([NotNull] CompilerParser.Pr_LanguageDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_Grammar"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_Grammar([NotNull] CompilerParser.Pr_GrammarContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_GrammarRuleAlt1</c>
	/// labeled alternative in <see cref="CompilerParser.pr_GrammarRule"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_GrammarRuleAlt1([NotNull] CompilerParser.Pr_GrammarRuleAlt1Context context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_GrammarRuleAlt2</c>
	/// labeled alternative in <see cref="CompilerParser.pr_GrammarRule"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_GrammarRuleAlt2([NotNull] CompilerParser.Pr_GrammarRuleAlt2Context context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_Rule"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_Rule([NotNull] CompilerParser.Pr_RuleContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_Alternative"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_Alternative([NotNull] CompilerParser.Pr_AlternativeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_Element"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_Element([NotNull] CompilerParser.Pr_ElementContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_ElementValueAlt1</c>
	/// labeled alternative in <see cref="CompilerParser.pr_ElementValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_ElementValueAlt1([NotNull] CompilerParser.Pr_ElementValueAlt1Context context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_ElementValueAlt2</c>
	/// labeled alternative in <see cref="CompilerParser.pr_ElementValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_ElementValueAlt2([NotNull] CompilerParser.Pr_ElementValueAlt2Context context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_ElementValueAlt3</c>
	/// labeled alternative in <see cref="CompilerParser.pr_ElementValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_ElementValueAlt3([NotNull] CompilerParser.Pr_ElementValueAlt3Context context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_ElementValueAlt4</c>
	/// labeled alternative in <see cref="CompilerParser.pr_ElementValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_ElementValueAlt4([NotNull] CompilerParser.Pr_ElementValueAlt4Context context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_Block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_Block([NotNull] CompilerParser.Pr_BlockContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_BlockAlternative"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_BlockAlternative([NotNull] CompilerParser.Pr_BlockAlternativeContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_RuleRefAlt1</c>
	/// labeled alternative in <see cref="CompilerParser.pr_RuleRef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_RuleRefAlt1([NotNull] CompilerParser.Pr_RuleRefAlt1Context context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_RuleRefAlt2</c>
	/// labeled alternative in <see cref="CompilerParser.pr_RuleRef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_RuleRefAlt2([NotNull] CompilerParser.Pr_RuleRefAlt2Context context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_RuleRefAlt3</c>
	/// labeled alternative in <see cref="CompilerParser.pr_RuleRef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_RuleRefAlt3([NotNull] CompilerParser.Pr_RuleRefAlt3Context context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_Eof1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_Eof1([NotNull] CompilerParser.Pr_Eof1Context context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_Fixed"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_Fixed([NotNull] CompilerParser.Pr_FixedContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_LexerRuleAlt1</c>
	/// labeled alternative in <see cref="CompilerParser.pr_LexerRule"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_LexerRuleAlt1([NotNull] CompilerParser.Pr_LexerRuleAlt1Context context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_LexerRuleAlt2</c>
	/// labeled alternative in <see cref="CompilerParser.pr_LexerRule"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_LexerRuleAlt2([NotNull] CompilerParser.Pr_LexerRuleAlt2Context context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_Token"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_Token([NotNull] CompilerParser.Pr_TokenContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_Fragment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_Fragment([NotNull] CompilerParser.Pr_FragmentContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_LAlternative"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_LAlternative([NotNull] CompilerParser.Pr_LAlternativeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_LElement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_LElement([NotNull] CompilerParser.Pr_LElementContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_LElementValueAlt1</c>
	/// labeled alternative in <see cref="CompilerParser.pr_LElementValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_LElementValueAlt1([NotNull] CompilerParser.Pr_LElementValueAlt1Context context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_LElementValueAlt2</c>
	/// labeled alternative in <see cref="CompilerParser.pr_LElementValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_LElementValueAlt2([NotNull] CompilerParser.Pr_LElementValueAlt2Context context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_LElementValueAlt3</c>
	/// labeled alternative in <see cref="CompilerParser.pr_LElementValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_LElementValueAlt3([NotNull] CompilerParser.Pr_LElementValueAlt3Context context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_LElementValueAlt4</c>
	/// labeled alternative in <see cref="CompilerParser.pr_LElementValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_LElementValueAlt4([NotNull] CompilerParser.Pr_LElementValueAlt4Context context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_LElementValueAlt5</c>
	/// labeled alternative in <see cref="CompilerParser.pr_LElementValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_LElementValueAlt5([NotNull] CompilerParser.Pr_LElementValueAlt5Context context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_LReference"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_LReference([NotNull] CompilerParser.Pr_LReferenceContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_LFixed"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_LFixed([NotNull] CompilerParser.Pr_LFixedContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_LWildCard"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_LWildCard([NotNull] CompilerParser.Pr_LWildCardContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_LRange"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_LRange([NotNull] CompilerParser.Pr_LRangeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_LBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_LBlock([NotNull] CompilerParser.Pr_LBlockContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_ExpressionAlt1</c>
	/// labeled alternative in <see cref="CompilerParser.pr_Expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_ExpressionAlt1([NotNull] CompilerParser.Pr_ExpressionAlt1Context context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_ExpressionAlt2</c>
	/// labeled alternative in <see cref="CompilerParser.pr_Expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_ExpressionAlt2([NotNull] CompilerParser.Pr_ExpressionAlt2Context context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_SingleExpressionAlt1</c>
	/// labeled alternative in <see cref="CompilerParser.pr_SingleExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_SingleExpressionAlt1([NotNull] CompilerParser.Pr_SingleExpressionAlt1Context context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_SingleExpressionAlt2</c>
	/// labeled alternative in <see cref="CompilerParser.pr_SingleExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_SingleExpressionAlt2([NotNull] CompilerParser.Pr_SingleExpressionAlt2Context context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_ArrayExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_ArrayExpression([NotNull] CompilerParser.Pr_ArrayExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_ParserAnnotation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_ParserAnnotation([NotNull] CompilerParser.Pr_ParserAnnotationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_LexerAnnotation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_LexerAnnotation([NotNull] CompilerParser.Pr_LexerAnnotationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_AnnotationArgument"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_AnnotationArgument([NotNull] CompilerParser.Pr_AnnotationArgumentContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_Assignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_Assignment([NotNull] CompilerParser.Pr_AssignmentContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_Multiplicity"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_Multiplicity([NotNull] CompilerParser.Pr_MultiplicityContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_TypeReferenceIdentifierAlt1</c>
	/// labeled alternative in <see cref="CompilerParser.pr_TypeReferenceIdentifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_TypeReferenceIdentifierAlt1([NotNull] CompilerParser.Pr_TypeReferenceIdentifierAlt1Context context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_TypeReferenceIdentifierAlt2</c>
	/// labeled alternative in <see cref="CompilerParser.pr_TypeReferenceIdentifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_TypeReferenceIdentifierAlt2([NotNull] CompilerParser.Pr_TypeReferenceIdentifierAlt2Context context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_TypeReferenceAlt1</c>
	/// labeled alternative in <see cref="CompilerParser.pr_TypeReference"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_TypeReferenceAlt1([NotNull] CompilerParser.Pr_TypeReferenceAlt1Context context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_TypeReferenceAlt2</c>
	/// labeled alternative in <see cref="CompilerParser.pr_TypeReference"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_TypeReferenceAlt2([NotNull] CompilerParser.Pr_TypeReferenceAlt2Context context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_PrimitiveType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_PrimitiveType([NotNull] CompilerParser.Pr_PrimitiveTypeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_Name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_Name([NotNull] CompilerParser.Pr_NameContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_Qualifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_Qualifier([NotNull] CompilerParser.Pr_QualifierContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_Identifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_Identifier([NotNull] CompilerParser.Pr_IdentifierContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_MainBlock1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_MainBlock1([NotNull] CompilerParser.Pr_MainBlock1Context context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_MainBlock2"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_MainBlock2([NotNull] CompilerParser.Pr_MainBlock2Context context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_LanguageDeclarationBlock1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_LanguageDeclarationBlock1([NotNull] CompilerParser.Pr_LanguageDeclarationBlock1Context context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_LanguageDeclarationBlock1baseLanguagesBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_LanguageDeclarationBlock1baseLanguagesBlock([NotNull] CompilerParser.Pr_LanguageDeclarationBlock1baseLanguagesBlockContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_GrammarBlock1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_GrammarBlock1([NotNull] CompilerParser.Pr_GrammarBlock1Context context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_RuleBlock1Alt1</c>
	/// labeled alternative in <see cref="CompilerParser.pr_RuleBlock1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_RuleBlock1Alt1([NotNull] CompilerParser.Pr_RuleBlock1Alt1Context context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_RuleBlock1Alt2</c>
	/// labeled alternative in <see cref="CompilerParser.pr_RuleBlock1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_RuleBlock1Alt2([NotNull] CompilerParser.Pr_RuleBlock1Alt2Context context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_RulealternativesBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_RulealternativesBlock([NotNull] CompilerParser.Pr_RulealternativesBlockContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_AlternativeBlock1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_AlternativeBlock1([NotNull] CompilerParser.Pr_AlternativeBlock1Context context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_AlternativeBlock1Block1Alt1</c>
	/// labeled alternative in <see cref="CompilerParser.pr_AlternativeBlock1Block1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_AlternativeBlock1Block1Alt1([NotNull] CompilerParser.Pr_AlternativeBlock1Block1Alt1Context context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_AlternativeBlock1Block1Alt2</c>
	/// labeled alternative in <see cref="CompilerParser.pr_AlternativeBlock1Block1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_AlternativeBlock1Block1Alt2([NotNull] CompilerParser.Pr_AlternativeBlock1Block1Alt2Context context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_AlternativeBlock2"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_AlternativeBlock2([NotNull] CompilerParser.Pr_AlternativeBlock2Context context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_ElementBlock1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_ElementBlock1([NotNull] CompilerParser.Pr_ElementBlock1Context context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_BlockalternativesBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_BlockalternativesBlock([NotNull] CompilerParser.Pr_BlockalternativesBlockContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_BlockAlternativeBlock1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_BlockAlternativeBlock1([NotNull] CompilerParser.Pr_BlockAlternativeBlock1Context context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_RuleRefAlt3referencedTypesBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_RuleRefAlt3referencedTypesBlock([NotNull] CompilerParser.Pr_RuleRefAlt3referencedTypesBlockContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_RuleRefAlt3Block1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_RuleRefAlt3Block1([NotNull] CompilerParser.Pr_RuleRefAlt3Block1Context context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_TokenBlock1Alt1</c>
	/// labeled alternative in <see cref="CompilerParser.pr_TokenBlock1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_TokenBlock1Alt1([NotNull] CompilerParser.Pr_TokenBlock1Alt1Context context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_TokenBlock1Alt2</c>
	/// labeled alternative in <see cref="CompilerParser.pr_TokenBlock1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_TokenBlock1Alt2([NotNull] CompilerParser.Pr_TokenBlock1Alt2Context context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_TokenBlock1Alt1Block1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_TokenBlock1Alt1Block1([NotNull] CompilerParser.Pr_TokenBlock1Alt1Block1Context context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_TokenalternativesBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_TokenalternativesBlock([NotNull] CompilerParser.Pr_TokenalternativesBlockContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_FragmentalternativesBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_FragmentalternativesBlock([NotNull] CompilerParser.Pr_FragmentalternativesBlockContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_LBlockalternativesBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_LBlockalternativesBlock([NotNull] CompilerParser.Pr_LBlockalternativesBlockContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_SingleExpressionAlt1Block1Alt1</c>
	/// labeled alternative in <see cref="CompilerParser.pr_SingleExpressionAlt1Block1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_SingleExpressionAlt1Block1Alt1([NotNull] CompilerParser.Pr_SingleExpressionAlt1Block1Alt1Context context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_SingleExpressionAlt1Block1Alt2</c>
	/// labeled alternative in <see cref="CompilerParser.pr_SingleExpressionAlt1Block1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_SingleExpressionAlt1Block1Alt2([NotNull] CompilerParser.Pr_SingleExpressionAlt1Block1Alt2Context context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_SingleExpressionAlt1Block1Alt3</c>
	/// labeled alternative in <see cref="CompilerParser.pr_SingleExpressionAlt1Block1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_SingleExpressionAlt1Block1Alt3([NotNull] CompilerParser.Pr_SingleExpressionAlt1Block1Alt3Context context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_SingleExpressionAlt1Block1Alt4</c>
	/// labeled alternative in <see cref="CompilerParser.pr_SingleExpressionAlt1Block1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_SingleExpressionAlt1Block1Alt4([NotNull] CompilerParser.Pr_SingleExpressionAlt1Block1Alt4Context context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_SingleExpressionAlt1Block1Alt5</c>
	/// labeled alternative in <see cref="CompilerParser.pr_SingleExpressionAlt1Block1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_SingleExpressionAlt1Block1Alt5([NotNull] CompilerParser.Pr_SingleExpressionAlt1Block1Alt5Context context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_SingleExpressionAlt1Block1Alt6</c>
	/// labeled alternative in <see cref="CompilerParser.pr_SingleExpressionAlt1Block1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_SingleExpressionAlt1Block1Alt6([NotNull] CompilerParser.Pr_SingleExpressionAlt1Block1Alt6Context context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_SingleExpressionAlt1Block1Alt7</c>
	/// labeled alternative in <see cref="CompilerParser.pr_SingleExpressionAlt1Block1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_SingleExpressionAlt1Block1Alt7([NotNull] CompilerParser.Pr_SingleExpressionAlt1Block1Alt7Context context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_ArrayExpressionBlock1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_ArrayExpressionBlock1([NotNull] CompilerParser.Pr_ArrayExpressionBlock1Context context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_ArrayExpressionBlock1itemsBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_ArrayExpressionBlock1itemsBlock([NotNull] CompilerParser.Pr_ArrayExpressionBlock1itemsBlockContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_ParserAnnotationBlock1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_ParserAnnotationBlock1([NotNull] CompilerParser.Pr_ParserAnnotationBlock1Context context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_ParserAnnotationBlock1argumentsBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_ParserAnnotationBlock1argumentsBlock([NotNull] CompilerParser.Pr_ParserAnnotationBlock1argumentsBlockContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_LexerAnnotationBlock1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_LexerAnnotationBlock1([NotNull] CompilerParser.Pr_LexerAnnotationBlock1Context context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_LexerAnnotationBlock1argumentsBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_LexerAnnotationBlock1argumentsBlock([NotNull] CompilerParser.Pr_LexerAnnotationBlock1argumentsBlockContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_AnnotationArgumentBlock1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_AnnotationArgumentBlock1([NotNull] CompilerParser.Pr_AnnotationArgumentBlock1Context context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_QualifierIdentifierBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_QualifierIdentifierBlock([NotNull] CompilerParser.Pr_QualifierIdentifierBlockContext context);
}
} // namespace MetaDslx.Bootstrap.MetaCompiler2.Compiler
