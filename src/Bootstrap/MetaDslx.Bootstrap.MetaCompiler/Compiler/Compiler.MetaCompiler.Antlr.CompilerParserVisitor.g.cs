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

namespace MetaDslx.Bootstrap.MetaCompiler.Compiler {
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
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_Using"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_Using([NotNull] CompilerParser.Pr_UsingContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_Declarations"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_Declarations([NotNull] CompilerParser.Pr_DeclarationsContext context);
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
	/// Visit a parse tree produced by the <c>pr_Block</c>
	/// labeled alternative in <see cref="CompilerParser.pr_GrammarRule"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_Block([NotNull] CompilerParser.Pr_BlockContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_Token</c>
	/// labeled alternative in <see cref="CompilerParser.pr_GrammarRule"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_Token([NotNull] CompilerParser.Pr_TokenContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_Fragment</c>
	/// labeled alternative in <see cref="CompilerParser.pr_GrammarRule"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_Fragment([NotNull] CompilerParser.Pr_FragmentContext context);
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
	/// Visit a parse tree produced by the <c>pr_ElementValueTokens</c>
	/// labeled alternative in <see cref="CompilerParser.pr_ElementValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_ElementValueTokens([NotNull] CompilerParser.Pr_ElementValueTokensContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_BlockInline</c>
	/// labeled alternative in <see cref="CompilerParser.pr_ElementValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_BlockInline([NotNull] CompilerParser.Pr_BlockInlineContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_RuleRefAlt1</c>
	/// labeled alternative in <see cref="CompilerParser.pr_ElementValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_RuleRefAlt1([NotNull] CompilerParser.Pr_RuleRefAlt1Context context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_RuleRefAlt2</c>
	/// labeled alternative in <see cref="CompilerParser.pr_ElementValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_RuleRefAlt2([NotNull] CompilerParser.Pr_RuleRefAlt2Context context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_RuleRefAlt3</c>
	/// labeled alternative in <see cref="CompilerParser.pr_ElementValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_RuleRefAlt3([NotNull] CompilerParser.Pr_RuleRefAlt3Context context);
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
	/// Visit a parse tree produced by the <c>pr_LElementValueTokens</c>
	/// labeled alternative in <see cref="CompilerParser.pr_LElementValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_LElementValueTokens([NotNull] CompilerParser.Pr_LElementValueTokensContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_LBlock</c>
	/// labeled alternative in <see cref="CompilerParser.pr_LElementValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_LBlock([NotNull] CompilerParser.Pr_LBlockContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_LRange</c>
	/// labeled alternative in <see cref="CompilerParser.pr_LElementValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_LRange([NotNull] CompilerParser.Pr_LRangeContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_LReference</c>
	/// labeled alternative in <see cref="CompilerParser.pr_LElementValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_LReference([NotNull] CompilerParser.Pr_LReferenceContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_ExpressionAlt1</c>
	/// labeled alternative in <see cref="CompilerParser.pr_Expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_ExpressionAlt1([NotNull] CompilerParser.Pr_ExpressionAlt1Context context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_ArrayExpression</c>
	/// labeled alternative in <see cref="CompilerParser.pr_Expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_ArrayExpression([NotNull] CompilerParser.Pr_ArrayExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_SingleExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_SingleExpression([NotNull] CompilerParser.Pr_SingleExpressionContext context);
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
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_AnnotationArguments"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_AnnotationArguments([NotNull] CompilerParser.Pr_AnnotationArgumentsContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_AnnotationArgument"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_AnnotationArgument([NotNull] CompilerParser.Pr_AnnotationArgumentContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_ReturnTypeIdentifierAlt1</c>
	/// labeled alternative in <see cref="CompilerParser.pr_ReturnTypeIdentifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_ReturnTypeIdentifierAlt1([NotNull] CompilerParser.Pr_ReturnTypeIdentifierAlt1Context context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_ReturnTypeIdentifierAlt2</c>
	/// labeled alternative in <see cref="CompilerParser.pr_ReturnTypeIdentifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_ReturnTypeIdentifierAlt2([NotNull] CompilerParser.Pr_ReturnTypeIdentifierAlt2Context context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_ReturnTypeQualifierAlt1</c>
	/// labeled alternative in <see cref="CompilerParser.pr_ReturnTypeQualifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_ReturnTypeQualifierAlt1([NotNull] CompilerParser.Pr_ReturnTypeQualifierAlt1Context context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_ReturnTypeQualifierAlt2</c>
	/// labeled alternative in <see cref="CompilerParser.pr_ReturnTypeQualifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_ReturnTypeQualifierAlt2([NotNull] CompilerParser.Pr_ReturnTypeQualifierAlt2Context context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_Name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_Name([NotNull] CompilerParser.Pr_NameContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_Identifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_Identifier([NotNull] CompilerParser.Pr_IdentifierContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_SimpleIdentifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_SimpleIdentifier([NotNull] CompilerParser.Pr_SimpleIdentifierContext context);
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
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_RuleAlternativesBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_RuleAlternativesBlock([NotNull] CompilerParser.Pr_RuleAlternativesBlockContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_BlockBlock1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_BlockBlock1([NotNull] CompilerParser.Pr_BlockBlock1Context context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_BlockAlternativesBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_BlockAlternativesBlock([NotNull] CompilerParser.Pr_BlockAlternativesBlockContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_BlockInlineAlternativesBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_BlockInlineAlternativesBlock([NotNull] CompilerParser.Pr_BlockInlineAlternativesBlockContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_AlternativeBlock1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_AlternativeBlock1([NotNull] CompilerParser.Pr_AlternativeBlock1Context context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_AlternativeBlock1Block1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_AlternativeBlock1Block1([NotNull] CompilerParser.Pr_AlternativeBlock1Block1Context context);
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
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_RuleRefAlt3ReferencedTypesBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_RuleRefAlt3ReferencedTypesBlock([NotNull] CompilerParser.Pr_RuleRefAlt3ReferencedTypesBlockContext context);
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
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_TokenAlternativesBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_TokenAlternativesBlock([NotNull] CompilerParser.Pr_TokenAlternativesBlockContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_FragmentAlternativesBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_FragmentAlternativesBlock([NotNull] CompilerParser.Pr_FragmentAlternativesBlockContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_LBlockAlternativesBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_LBlockAlternativesBlock([NotNull] CompilerParser.Pr_LBlockAlternativesBlockContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_Tokens</c>
	/// labeled alternative in <see cref="CompilerParser.pr_SingleExpressionBlock1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_Tokens([NotNull] CompilerParser.Pr_TokensContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_SingleExpressionBlock1Alt2</c>
	/// labeled alternative in <see cref="CompilerParser.pr_SingleExpressionBlock1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_SingleExpressionBlock1Alt2([NotNull] CompilerParser.Pr_SingleExpressionBlock1Alt2Context context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_SingleExpressionBlock1Alt3</c>
	/// labeled alternative in <see cref="CompilerParser.pr_SingleExpressionBlock1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_SingleExpressionBlock1Alt3([NotNull] CompilerParser.Pr_SingleExpressionBlock1Alt3Context context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_ArrayExpressionItemsBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_ArrayExpressionItemsBlock([NotNull] CompilerParser.Pr_ArrayExpressionItemsBlockContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_AnnotationArgumentsArgumentsBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_AnnotationArgumentsArgumentsBlock([NotNull] CompilerParser.Pr_AnnotationArgumentsArgumentsBlockContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_AnnotationArgumentBlock1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_AnnotationArgumentBlock1([NotNull] CompilerParser.Pr_AnnotationArgumentBlock1Context context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_MainQualifierBlock4"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_MainQualifierBlock4([NotNull] CompilerParser.Pr_MainQualifierBlock4Context context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_SingleExpressionBlock1Alt3SimpleQualifierBlock1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_SingleExpressionBlock1Alt3SimpleQualifierBlock1([NotNull] CompilerParser.Pr_SingleExpressionBlock1Alt3SimpleQualifierBlock1Context context);
}
} // namespace MetaDslx.Bootstrap.MetaCompiler.Compiler
