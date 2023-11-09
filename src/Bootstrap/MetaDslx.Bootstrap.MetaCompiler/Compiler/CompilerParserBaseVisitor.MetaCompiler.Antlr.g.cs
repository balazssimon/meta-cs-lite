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
	/// Visit a parse tree produced by the <c>pr_BlockRule</c>
	/// labeled alternative in <see cref="CompilerParser.pr_Rule"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_BlockRule([NotNull] CompilerParser.Pr_BlockRuleContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_ParserRuleAlternative"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_ParserRuleAlternative([NotNull] CompilerParser.Pr_ParserRuleAlternativeContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_ParserRuleElement"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_ParserRuleElement([NotNull] CompilerParser.Pr_ParserRuleElementContext context) { return VisitChildren(context); }
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
	/// Visit a parse tree produced by the <c>pr_UsingBlock1Alt1</c>
	/// labeled alternative in <see cref="CompilerParser.pr_UsingBlock1"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_UsingBlock1Alt1([NotNull] CompilerParser.Pr_UsingBlock1Alt1Context context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_UsingBlock1Alt2</c>
	/// labeled alternative in <see cref="CompilerParser.pr_UsingBlock1"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_UsingBlock1Alt2([NotNull] CompilerParser.Pr_UsingBlock1Alt2Context context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_ParserRuleBlock1"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_ParserRuleBlock1([NotNull] CompilerParser.Pr_ParserRuleBlock1Context context) { return VisitChildren(context); }
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
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_BlockRuleBlock1"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_BlockRuleBlock1([NotNull] CompilerParser.Pr_BlockRuleBlock1Context context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_ParserRuleAlternativeBlock1"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_ParserRuleAlternativeBlock1([NotNull] CompilerParser.Pr_ParserRuleAlternativeBlock1Context context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="CompilerParser.pr_ParserRuleAlternativeBlock2"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_ParserRuleAlternativeBlock2([NotNull] CompilerParser.Pr_ParserRuleAlternativeBlock2Context context) { return VisitChildren(context); }
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
}
} // namespace MetaDslx.Bootstrap.MetaCompiler.Compiler
