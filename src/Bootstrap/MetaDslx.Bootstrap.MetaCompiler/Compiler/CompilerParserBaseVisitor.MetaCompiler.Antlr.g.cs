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
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="ICompilerParserVisitor{Result}"/>,
/// which can be extended to create a visitor which only needs to handle a subset
/// of the available methods.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.13.0")]
[System.Diagnostics.DebuggerNonUserCode]
[System.CLSCompliant(false)]
public partial class CompilerParserBaseVisitor<Result> : AbstractParseTreeVisitor<Result>, ICompilerParserVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_Main"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_Main([NotNull] CompilerParser.Pr_MainContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_Using"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_Using([NotNull] CompilerParser.Pr_UsingContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_Declarations"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_Declarations([NotNull] CompilerParser.Pr_DeclarationsContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_LanguageDeclaration"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_LanguageDeclaration([NotNull] CompilerParser.Pr_LanguageDeclarationContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_Grammar"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_Grammar([NotNull] CompilerParser.Pr_GrammarContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_ParserRule</c>
	/// labeled alternative in <see cref="CompilerParser.pr_Rule"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_ParserRule([NotNull] CompilerParser.Pr_ParserRuleContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_PBlock</c>
	/// labeled alternative in <see cref="CompilerParser.pr_Rule"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_PBlock([NotNull] CompilerParser.Pr_PBlockContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_LexerRule</c>
	/// labeled alternative in <see cref="CompilerParser.pr_Rule"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_LexerRule([NotNull] CompilerParser.Pr_LexerRuleContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_PAlternative"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_PAlternative([NotNull] CompilerParser.Pr_PAlternativeContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_PElement"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_PElement([NotNull] CompilerParser.Pr_PElementContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_PBlockInline</c>
	/// labeled alternative in <see cref="CompilerParser.pr_PElementValue"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_PBlockInline([NotNull] CompilerParser.Pr_PBlockInlineContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_PEof</c>
	/// labeled alternative in <see cref="CompilerParser.pr_PElementValue"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_PEof([NotNull] CompilerParser.Pr_PEofContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_PKeyword</c>
	/// labeled alternative in <see cref="CompilerParser.pr_PElementValue"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_PKeyword([NotNull] CompilerParser.Pr_PKeywordContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_PReferenceAlt1</c>
	/// labeled alternative in <see cref="CompilerParser.pr_PElementValue"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_PReferenceAlt1([NotNull] CompilerParser.Pr_PReferenceAlt1Context context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_PReferenceAlt2</c>
	/// labeled alternative in <see cref="CompilerParser.pr_PElementValue"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_PReferenceAlt2([NotNull] CompilerParser.Pr_PReferenceAlt2Context context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_PReferenceAlt3</c>
	/// labeled alternative in <see cref="CompilerParser.pr_PElementValue"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_PReferenceAlt3([NotNull] CompilerParser.Pr_PReferenceAlt3Context context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_LAlternative"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_LAlternative([NotNull] CompilerParser.Pr_LAlternativeContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_LElement"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_LElement([NotNull] CompilerParser.Pr_LElementContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_LBlock</c>
	/// labeled alternative in <see cref="CompilerParser.pr_LElementValue"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_LBlock([NotNull] CompilerParser.Pr_LBlockContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_LFixed</c>
	/// labeled alternative in <see cref="CompilerParser.pr_LElementValue"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_LFixed([NotNull] CompilerParser.Pr_LFixedContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_LWildCard</c>
	/// labeled alternative in <see cref="CompilerParser.pr_LElementValue"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_LWildCard([NotNull] CompilerParser.Pr_LWildCardContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_LRange</c>
	/// labeled alternative in <see cref="CompilerParser.pr_LElementValue"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_LRange([NotNull] CompilerParser.Pr_LRangeContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_LReference</c>
	/// labeled alternative in <see cref="CompilerParser.pr_LElementValue"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_LReference([NotNull] CompilerParser.Pr_LReferenceContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_IntExpression</c>
	/// labeled alternative in <see cref="CompilerParser.pr_Expression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_IntExpression([NotNull] CompilerParser.Pr_IntExpressionContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_StringExpression</c>
	/// labeled alternative in <see cref="CompilerParser.pr_Expression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_StringExpression([NotNull] CompilerParser.Pr_StringExpressionContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_ReferenceExpression</c>
	/// labeled alternative in <see cref="CompilerParser.pr_Expression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_ReferenceExpression([NotNull] CompilerParser.Pr_ReferenceExpressionContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_ArrayExpression</c>
	/// labeled alternative in <see cref="CompilerParser.pr_Expression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_ArrayExpression([NotNull] CompilerParser.Pr_ArrayExpressionContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_ExpressionTokens</c>
	/// labeled alternative in <see cref="CompilerParser.pr_Expression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_ExpressionTokens([NotNull] CompilerParser.Pr_ExpressionTokensContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_ParserAnnotation"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_ParserAnnotation([NotNull] CompilerParser.Pr_ParserAnnotationContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_LexerAnnotation"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_LexerAnnotation([NotNull] CompilerParser.Pr_LexerAnnotationContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_AnnotationArguments"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_AnnotationArguments([NotNull] CompilerParser.Pr_AnnotationArgumentsContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_AnnotationArgument"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_AnnotationArgument([NotNull] CompilerParser.Pr_AnnotationArgumentContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_Name"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_Name([NotNull] CompilerParser.Pr_NameContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_Qualifier"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_Qualifier([NotNull] CompilerParser.Pr_QualifierContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_QualifierList"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_QualifierList([NotNull] CompilerParser.Pr_QualifierListContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_IdentifierAlt1</c>
	/// labeled alternative in <see cref="CompilerParser.pr_Identifier"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_IdentifierAlt1([NotNull] CompilerParser.Pr_IdentifierAlt1Context context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_IdentifierAlt2</c>
	/// labeled alternative in <see cref="CompilerParser.pr_Identifier"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_IdentifierAlt2([NotNull] CompilerParser.Pr_IdentifierAlt2Context context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_IdentifierAlt3</c>
	/// labeled alternative in <see cref="CompilerParser.pr_Identifier"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_IdentifierAlt3([NotNull] CompilerParser.Pr_IdentifierAlt3Context context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_GrammarBlock1"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_GrammarBlock1([NotNull] CompilerParser.Pr_GrammarBlock1Context context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_ParserRuleBlock1Alt1</c>
	/// labeled alternative in <see cref="CompilerParser.pr_ParserRuleBlock1"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_ParserRuleBlock1Alt1([NotNull] CompilerParser.Pr_ParserRuleBlock1Alt1Context context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_ParserRuleBlock1Alt2</c>
	/// labeled alternative in <see cref="CompilerParser.pr_ParserRuleBlock1"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_ParserRuleBlock1Alt2([NotNull] CompilerParser.Pr_ParserRuleBlock1Alt2Context context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_ParserRuleBlock2"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_ParserRuleBlock2([NotNull] CompilerParser.Pr_ParserRuleBlock2Context context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_PBlockBlock1"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_PBlockBlock1([NotNull] CompilerParser.Pr_PBlockBlock1Context context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_PBlockInlineBlock1"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_PBlockInlineBlock1([NotNull] CompilerParser.Pr_PBlockInlineBlock1Context context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_PAlternativeBlock1"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_PAlternativeBlock1([NotNull] CompilerParser.Pr_PAlternativeBlock1Context context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_PAlternativeBlock2"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_PAlternativeBlock2([NotNull] CompilerParser.Pr_PAlternativeBlock2Context context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_PElementBlock1"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_PElementBlock1([NotNull] CompilerParser.Pr_PElementBlock1Context context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_PReferenceAlt3Block1"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_PReferenceAlt3Block1([NotNull] CompilerParser.Pr_PReferenceAlt3Block1Context context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_LexerRuleBlock1Alt1</c>
	/// labeled alternative in <see cref="CompilerParser.pr_LexerRuleBlock1"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_LexerRuleBlock1Alt1([NotNull] CompilerParser.Pr_LexerRuleBlock1Alt1Context context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_LexerRuleBlock1Alt2</c>
	/// labeled alternative in <see cref="CompilerParser.pr_LexerRuleBlock1"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_LexerRuleBlock1Alt2([NotNull] CompilerParser.Pr_LexerRuleBlock1Alt2Context context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_LexerRuleBlock1Alt3</c>
	/// labeled alternative in <see cref="CompilerParser.pr_LexerRuleBlock1"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_LexerRuleBlock1Alt3([NotNull] CompilerParser.Pr_LexerRuleBlock1Alt3Context context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_LexerRuleBlock2"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_LexerRuleBlock2([NotNull] CompilerParser.Pr_LexerRuleBlock2Context context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_LBlockBlock1"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_LBlockBlock1([NotNull] CompilerParser.Pr_LBlockBlock1Context context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_ArrayExpressionBlock1"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_ArrayExpressionBlock1([NotNull] CompilerParser.Pr_ArrayExpressionBlock1Context context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_AnnotationArgumentsBlock1"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_AnnotationArgumentsBlock1([NotNull] CompilerParser.Pr_AnnotationArgumentsBlock1Context context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_AnnotationArgumentBlock1"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_AnnotationArgumentBlock1([NotNull] CompilerParser.Pr_AnnotationArgumentBlock1Context context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_QualifierBlock1"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_QualifierBlock1([NotNull] CompilerParser.Pr_QualifierBlock1Context context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_QualifierListBlock1"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_QualifierListBlock1([NotNull] CompilerParser.Pr_QualifierListBlock1Context context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_PAlternativeBlock1Block1"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_PAlternativeBlock1Block1([NotNull] CompilerParser.Pr_PAlternativeBlock1Block1Context context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_LexerRuleBlock1Alt1Block1"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_LexerRuleBlock1Alt1Block1([NotNull] CompilerParser.Pr_LexerRuleBlock1Alt1Block1Context context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_ArrayExpressionBlock1Block1"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_ArrayExpressionBlock1Block1([NotNull] CompilerParser.Pr_ArrayExpressionBlock1Block1Context context) { return VisitChildren(context); }
}
} // namespace MetaDslx.Bootstrap.MetaCompiler.Compiler
