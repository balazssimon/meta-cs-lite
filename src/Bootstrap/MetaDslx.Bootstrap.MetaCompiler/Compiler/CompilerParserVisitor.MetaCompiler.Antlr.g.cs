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
	/// Visit a parse tree produced by the <c>pr_ParserRule</c>
	/// labeled alternative in <see cref="CompilerParser.pr_Rule"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_ParserRule([NotNull] CompilerParser.Pr_ParserRuleContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_LexerRule</c>
	/// labeled alternative in <see cref="CompilerParser.pr_Rule"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_LexerRule([NotNull] CompilerParser.Pr_LexerRuleContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_PAlternative"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_PAlternative([NotNull] CompilerParser.Pr_PAlternativeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_PElement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_PElement([NotNull] CompilerParser.Pr_PElementContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_PReferenceAlt1</c>
	/// labeled alternative in <see cref="CompilerParser.pr_PElementValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_PReferenceAlt1([NotNull] CompilerParser.Pr_PReferenceAlt1Context context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_PReferenceAlt2</c>
	/// labeled alternative in <see cref="CompilerParser.pr_PElementValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_PReferenceAlt2([NotNull] CompilerParser.Pr_PReferenceAlt2Context context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_PReferenceAlt3</c>
	/// labeled alternative in <see cref="CompilerParser.pr_PElementValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_PReferenceAlt3([NotNull] CompilerParser.Pr_PReferenceAlt3Context context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_PEof</c>
	/// labeled alternative in <see cref="CompilerParser.pr_PElementValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_PEof([NotNull] CompilerParser.Pr_PEofContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_PKeyword</c>
	/// labeled alternative in <see cref="CompilerParser.pr_PElementValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_PKeyword([NotNull] CompilerParser.Pr_PKeywordContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_PBlock</c>
	/// labeled alternative in <see cref="CompilerParser.pr_PElementValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_PBlock([NotNull] CompilerParser.Pr_PBlockContext context);
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
	/// Visit a parse tree produced by the <c>pr_LReference</c>
	/// labeled alternative in <see cref="CompilerParser.pr_LElementValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_LReference([NotNull] CompilerParser.Pr_LReferenceContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_LFixed</c>
	/// labeled alternative in <see cref="CompilerParser.pr_LElementValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_LFixed([NotNull] CompilerParser.Pr_LFixedContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_LWildCard</c>
	/// labeled alternative in <see cref="CompilerParser.pr_LElementValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_LWildCard([NotNull] CompilerParser.Pr_LWildCardContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_LRange</c>
	/// labeled alternative in <see cref="CompilerParser.pr_LElementValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_LRange([NotNull] CompilerParser.Pr_LRangeContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_LBlock</c>
	/// labeled alternative in <see cref="CompilerParser.pr_LElementValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_LBlock([NotNull] CompilerParser.Pr_LBlockContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_IntExpression</c>
	/// labeled alternative in <see cref="CompilerParser.pr_Expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_IntExpression([NotNull] CompilerParser.Pr_IntExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_StringExpression</c>
	/// labeled alternative in <see cref="CompilerParser.pr_Expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_StringExpression([NotNull] CompilerParser.Pr_StringExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_ReferenceExpression</c>
	/// labeled alternative in <see cref="CompilerParser.pr_Expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_ReferenceExpression([NotNull] CompilerParser.Pr_ReferenceExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_ExpressionTokens</c>
	/// labeled alternative in <see cref="CompilerParser.pr_Expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_ExpressionTokens([NotNull] CompilerParser.Pr_ExpressionTokensContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_Annotation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_Annotation([NotNull] CompilerParser.Pr_AnnotationContext context);
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
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_QualifierList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_QualifierList([NotNull] CompilerParser.Pr_QualifierListContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_Identifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_Identifier([NotNull] CompilerParser.Pr_IdentifierContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_UsingBlock1Alt1</c>
	/// labeled alternative in <see cref="CompilerParser.pr_UsingBlock1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_UsingBlock1Alt1([NotNull] CompilerParser.Pr_UsingBlock1Alt1Context context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_UsingBlock1Alt2</c>
	/// labeled alternative in <see cref="CompilerParser.pr_UsingBlock1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_UsingBlock1Alt2([NotNull] CompilerParser.Pr_UsingBlock1Alt2Context context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_GrammarBlock1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_GrammarBlock1([NotNull] CompilerParser.Pr_GrammarBlock1Context context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_ParserRuleBlock1Alt1</c>
	/// labeled alternative in <see cref="CompilerParser.pr_ParserRuleBlock1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_ParserRuleBlock1Alt1([NotNull] CompilerParser.Pr_ParserRuleBlock1Alt1Context context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_ParserRuleBlock1Alt2</c>
	/// labeled alternative in <see cref="CompilerParser.pr_ParserRuleBlock1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_ParserRuleBlock1Alt2([NotNull] CompilerParser.Pr_ParserRuleBlock1Alt2Context context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_ParserRuleBlock1Alt3</c>
	/// labeled alternative in <see cref="CompilerParser.pr_ParserRuleBlock1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_ParserRuleBlock1Alt3([NotNull] CompilerParser.Pr_ParserRuleBlock1Alt3Context context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_ParserRuleBlock2"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_ParserRuleBlock2([NotNull] CompilerParser.Pr_ParserRuleBlock2Context context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_PAlternativeBlock1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_PAlternativeBlock1([NotNull] CompilerParser.Pr_PAlternativeBlock1Context context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_PAlternativeBlock2"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_PAlternativeBlock2([NotNull] CompilerParser.Pr_PAlternativeBlock2Context context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_PElementBlock1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_PElementBlock1([NotNull] CompilerParser.Pr_PElementBlock1Context context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_PReferenceAlt3Block1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_PReferenceAlt3Block1([NotNull] CompilerParser.Pr_PReferenceAlt3Block1Context context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_PBlockBlock1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_PBlockBlock1([NotNull] CompilerParser.Pr_PBlockBlock1Context context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_LexerRuleBlock1Alt1</c>
	/// labeled alternative in <see cref="CompilerParser.pr_LexerRuleBlock1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_LexerRuleBlock1Alt1([NotNull] CompilerParser.Pr_LexerRuleBlock1Alt1Context context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_LexerRuleBlock1Alt2</c>
	/// labeled alternative in <see cref="CompilerParser.pr_LexerRuleBlock1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_LexerRuleBlock1Alt2([NotNull] CompilerParser.Pr_LexerRuleBlock1Alt2Context context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_LexerRuleBlock1Alt3</c>
	/// labeled alternative in <see cref="CompilerParser.pr_LexerRuleBlock1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_LexerRuleBlock1Alt3([NotNull] CompilerParser.Pr_LexerRuleBlock1Alt3Context context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_LexerRuleBlock2"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_LexerRuleBlock2([NotNull] CompilerParser.Pr_LexerRuleBlock2Context context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_LBlockBlock1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_LBlockBlock1([NotNull] CompilerParser.Pr_LBlockBlock1Context context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_AnnotationArgumentsBlock1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_AnnotationArgumentsBlock1([NotNull] CompilerParser.Pr_AnnotationArgumentsBlock1Context context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_AnnotationArgumentBlock1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_AnnotationArgumentBlock1([NotNull] CompilerParser.Pr_AnnotationArgumentBlock1Context context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_QualifierBlock1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_QualifierBlock1([NotNull] CompilerParser.Pr_QualifierBlock1Context context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_QualifierListBlock1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_QualifierListBlock1([NotNull] CompilerParser.Pr_QualifierListBlock1Context context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_LexerRuleBlock1Alt1Block1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_LexerRuleBlock1Alt1Block1([NotNull] CompilerParser.Pr_LexerRuleBlock1Alt1Block1Context context);
}
} // namespace MetaDslx.Bootstrap.MetaCompiler.Compiler
