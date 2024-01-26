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
	/// Visit a parse tree produced by the <c>pr_Rule</c>
	/// labeled alternative in <see cref="CompilerParser.pr_GrammarRule"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_Rule([NotNull] CompilerParser.Pr_RuleContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_Token</c>
	/// labeled alternative in <see cref="CompilerParser.pr_GrammarRule"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_Token([NotNull] CompilerParser.Pr_TokenContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_Fragment</c>
	/// labeled alternative in <see cref="CompilerParser.pr_GrammarRule"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_Fragment([NotNull] CompilerParser.Pr_FragmentContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_Alternative"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_Alternative([NotNull] CompilerParser.Pr_AlternativeContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_Element"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_Element([NotNull] CompilerParser.Pr_ElementContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_Block</c>
	/// labeled alternative in <see cref="CompilerParser.pr_ElementValue"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_Block([NotNull] CompilerParser.Pr_BlockContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_Eof1</c>
	/// labeled alternative in <see cref="CompilerParser.pr_ElementValue"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_Eof1([NotNull] CompilerParser.Pr_Eof1Context context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_Fixed</c>
	/// labeled alternative in <see cref="CompilerParser.pr_ElementValue"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_Fixed([NotNull] CompilerParser.Pr_FixedContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_RuleRefAlt1</c>
	/// labeled alternative in <see cref="CompilerParser.pr_ElementValue"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_RuleRefAlt1([NotNull] CompilerParser.Pr_RuleRefAlt1Context context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_RuleRefAlt2</c>
	/// labeled alternative in <see cref="CompilerParser.pr_ElementValue"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_RuleRefAlt2([NotNull] CompilerParser.Pr_RuleRefAlt2Context context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_RuleRefAlt3</c>
	/// labeled alternative in <see cref="CompilerParser.pr_ElementValue"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_RuleRefAlt3([NotNull] CompilerParser.Pr_RuleRefAlt3Context context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_BlockAlternative"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_BlockAlternative([NotNull] CompilerParser.Pr_BlockAlternativeContext context) { return VisitChildren(context); }
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
	/// Visit a parse tree produced by the <c>pr_LElementValueTokens</c>
	/// labeled alternative in <see cref="CompilerParser.pr_LElementValue"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_LElementValueTokens([NotNull] CompilerParser.Pr_LElementValueTokensContext context) { return VisitChildren(context); }
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
	/// Visit a parse tree produced by the <c>pr_ExpressionAlt1</c>
	/// labeled alternative in <see cref="CompilerParser.pr_Expression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_ExpressionAlt1([NotNull] CompilerParser.Pr_ExpressionAlt1Context context) { return VisitChildren(context); }
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
	/// Visit a parse tree produced by the <c>pr_SingleExpressionAlt1</c>
	/// labeled alternative in <see cref="CompilerParser.pr_SingleExpression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_SingleExpressionAlt1([NotNull] CompilerParser.Pr_SingleExpressionAlt1Context context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_SingleExpressionAlt2</c>
	/// labeled alternative in <see cref="CompilerParser.pr_SingleExpression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_SingleExpressionAlt2([NotNull] CompilerParser.Pr_SingleExpressionAlt2Context context) { return VisitChildren(context); }
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
	/// Visit a parse tree produced by the <c>pr_TypeReferenceIdentifierAlt1</c>
	/// labeled alternative in <see cref="CompilerParser.pr_TypeReferenceIdentifier"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_TypeReferenceIdentifierAlt1([NotNull] CompilerParser.Pr_TypeReferenceIdentifierAlt1Context context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_TypeReferenceIdentifierAlt2</c>
	/// labeled alternative in <see cref="CompilerParser.pr_TypeReferenceIdentifier"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_TypeReferenceIdentifierAlt2([NotNull] CompilerParser.Pr_TypeReferenceIdentifierAlt2Context context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_TypeReferenceAlt1</c>
	/// labeled alternative in <see cref="CompilerParser.pr_TypeReference"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_TypeReferenceAlt1([NotNull] CompilerParser.Pr_TypeReferenceAlt1Context context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_TypeReferenceAlt2</c>
	/// labeled alternative in <see cref="CompilerParser.pr_TypeReference"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_TypeReferenceAlt2([NotNull] CompilerParser.Pr_TypeReferenceAlt2Context context) { return VisitChildren(context); }
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
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_Identifier"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_Identifier([NotNull] CompilerParser.Pr_IdentifierContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_MainBlock1"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_MainBlock1([NotNull] CompilerParser.Pr_MainBlock1Context context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_RuleBlock1Alt1</c>
	/// labeled alternative in <see cref="CompilerParser.pr_RuleBlock1"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_RuleBlock1Alt1([NotNull] CompilerParser.Pr_RuleBlock1Alt1Context context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_RuleBlock1Alt2</c>
	/// labeled alternative in <see cref="CompilerParser.pr_RuleBlock1"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_RuleBlock1Alt2([NotNull] CompilerParser.Pr_RuleBlock1Alt2Context context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_RuleAlternativesBlock"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_RuleAlternativesBlock([NotNull] CompilerParser.Pr_RuleAlternativesBlockContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_AlternativeBlock1"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_AlternativeBlock1([NotNull] CompilerParser.Pr_AlternativeBlock1Context context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_AlternativeBlock2"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_AlternativeBlock2([NotNull] CompilerParser.Pr_AlternativeBlock2Context context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_ElementBlock1"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_ElementBlock1([NotNull] CompilerParser.Pr_ElementBlock1Context context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_BlockAlternativesBlock"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_BlockAlternativesBlock([NotNull] CompilerParser.Pr_BlockAlternativesBlockContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_BlockAlternativeBlock1"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_BlockAlternativeBlock1([NotNull] CompilerParser.Pr_BlockAlternativeBlock1Context context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_RuleRefAlt3ReferencedTypesBlock"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_RuleRefAlt3ReferencedTypesBlock([NotNull] CompilerParser.Pr_RuleRefAlt3ReferencedTypesBlockContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_RuleRefAlt3Block1"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_RuleRefAlt3Block1([NotNull] CompilerParser.Pr_RuleRefAlt3Block1Context context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_TokenBlock1Alt1</c>
	/// labeled alternative in <see cref="CompilerParser.pr_TokenBlock1"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_TokenBlock1Alt1([NotNull] CompilerParser.Pr_TokenBlock1Alt1Context context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_TokenBlock1Alt2</c>
	/// labeled alternative in <see cref="CompilerParser.pr_TokenBlock1"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_TokenBlock1Alt2([NotNull] CompilerParser.Pr_TokenBlock1Alt2Context context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_TokenAlternativesBlock"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_TokenAlternativesBlock([NotNull] CompilerParser.Pr_TokenAlternativesBlockContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_FragmentAlternativesBlock"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_FragmentAlternativesBlock([NotNull] CompilerParser.Pr_FragmentAlternativesBlockContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_LBlockAlternativesBlock"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_LBlockAlternativesBlock([NotNull] CompilerParser.Pr_LBlockAlternativesBlockContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_Tokens</c>
	/// labeled alternative in <see cref="CompilerParser.pr_SingleExpressionAlt1Block1"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_Tokens([NotNull] CompilerParser.Pr_TokensContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_SingleExpressionAlt1Block1Alt2</c>
	/// labeled alternative in <see cref="CompilerParser.pr_SingleExpressionAlt1Block1"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_SingleExpressionAlt1Block1Alt2([NotNull] CompilerParser.Pr_SingleExpressionAlt1Block1Alt2Context context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_ParserAnnotationBlock1"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_ParserAnnotationBlock1([NotNull] CompilerParser.Pr_ParserAnnotationBlock1Context context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_LexerAnnotationBlock1"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_LexerAnnotationBlock1([NotNull] CompilerParser.Pr_LexerAnnotationBlock1Context context) { return VisitChildren(context); }
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
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_MainQualifierBlock5"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_MainQualifierBlock5([NotNull] CompilerParser.Pr_MainQualifierBlock5Context context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_AlternativeBlock1Block1"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_AlternativeBlock1Block1([NotNull] CompilerParser.Pr_AlternativeBlock1Block1Context context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_TokenBlock1Alt1Block1"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_TokenBlock1Alt1Block1([NotNull] CompilerParser.Pr_TokenBlock1Alt1Block1Context context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_ArrayExpressionItemsBlock"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_ArrayExpressionItemsBlock([NotNull] CompilerParser.Pr_ArrayExpressionItemsBlockContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_ParserAnnotationBlock1ArgumentsBlock1"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_ParserAnnotationBlock1ArgumentsBlock1([NotNull] CompilerParser.Pr_ParserAnnotationBlock1ArgumentsBlock1Context context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_LexerAnnotationBlock1ArgumentsBlock1"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_LexerAnnotationBlock1ArgumentsBlock1([NotNull] CompilerParser.Pr_LexerAnnotationBlock1ArgumentsBlock1Context context) { return VisitChildren(context); }
}
} // namespace MetaDslx.Bootstrap.MetaCompiler.Compiler
