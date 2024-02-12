//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.13.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from SymbolParser.g4 by ANTLR 4.13.0

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace MetaDslx.Languages.MetaSymbols.Compiler {
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="ISymbolParserVisitor{Result}"/>,
/// which can be extended to create a visitor which only needs to handle a subset
/// of the available methods.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.13.0")]
[System.Diagnostics.DebuggerNonUserCode]
[System.CLSCompliant(false)]
public partial class SymbolParserBaseVisitor<Result> : AbstractParseTreeVisitor<Result>, ISymbolParserVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="SymbolParser.pr_Main"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_Main([NotNull] SymbolParser.Pr_MainContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="SymbolParser.pr_Using"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_Using([NotNull] SymbolParser.Pr_UsingContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="SymbolParser.pr_Symbol"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_Symbol([NotNull] SymbolParser.Pr_SymbolContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="SymbolParser.pr_Property"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_Property([NotNull] SymbolParser.Pr_PropertyContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="SymbolParser.pr_Operation"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_Operation([NotNull] SymbolParser.Pr_OperationContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="SymbolParser.pr_Parameter"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_Parameter([NotNull] SymbolParser.Pr_ParameterContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="SymbolParser.pr_TypeReference"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_TypeReference([NotNull] SymbolParser.Pr_TypeReferenceContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="SymbolParser.pr_ArrayDimensions"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_ArrayDimensions([NotNull] SymbolParser.Pr_ArrayDimensionsContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_SimpleTypeReferenceAlt1</c>
	/// labeled alternative in <see cref="SymbolParser.pr_SimpleTypeReference"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_SimpleTypeReferenceAlt1([NotNull] SymbolParser.Pr_SimpleTypeReferenceAlt1Context context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_SimpleTypeReferenceAlt2</c>
	/// labeled alternative in <see cref="SymbolParser.pr_SimpleTypeReference"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_SimpleTypeReferenceAlt2([NotNull] SymbolParser.Pr_SimpleTypeReferenceAlt2Context context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="SymbolParser.pr_PrimitiveType"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_PrimitiveType([NotNull] SymbolParser.Pr_PrimitiveTypeContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_ValueAlt1</c>
	/// labeled alternative in <see cref="SymbolParser.pr_Value"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_ValueAlt1([NotNull] SymbolParser.Pr_ValueAlt1Context context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_ValueAlt2</c>
	/// labeled alternative in <see cref="SymbolParser.pr_Value"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_ValueAlt2([NotNull] SymbolParser.Pr_ValueAlt2Context context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_ValueAlt3</c>
	/// labeled alternative in <see cref="SymbolParser.pr_Value"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_ValueAlt3([NotNull] SymbolParser.Pr_ValueAlt3Context context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_ValueAlt4</c>
	/// labeled alternative in <see cref="SymbolParser.pr_Value"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_ValueAlt4([NotNull] SymbolParser.Pr_ValueAlt4Context context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_ValueAlt5</c>
	/// labeled alternative in <see cref="SymbolParser.pr_Value"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_ValueAlt5([NotNull] SymbolParser.Pr_ValueAlt5Context context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_ValueAlt6</c>
	/// labeled alternative in <see cref="SymbolParser.pr_Value"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_ValueAlt6([NotNull] SymbolParser.Pr_ValueAlt6Context context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="SymbolParser.pr_Name"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_Name([NotNull] SymbolParser.Pr_NameContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="SymbolParser.pr_Qualifier"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_Qualifier([NotNull] SymbolParser.Pr_QualifierContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="SymbolParser.pr_Identifier"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_Identifier([NotNull] SymbolParser.Pr_IdentifierContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="SymbolParser.pr_TBoolean"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_TBoolean([NotNull] SymbolParser.Pr_TBooleanContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="SymbolParser.pr_MainBlock1"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_MainBlock1([NotNull] SymbolParser.Pr_MainBlock1Context context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="SymbolParser.pr_SymbolBlock1"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_SymbolBlock1([NotNull] SymbolParser.Pr_SymbolBlock1Context context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="SymbolParser.pr_SymbolBlock1baseTypesBlock"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_SymbolBlock1baseTypesBlock([NotNull] SymbolParser.Pr_SymbolBlock1baseTypesBlockContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="SymbolParser.pr_SymbolBlock2"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_SymbolBlock2([NotNull] SymbolParser.Pr_SymbolBlock2Context context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_SymbolBlock2Block1Alt1</c>
	/// labeled alternative in <see cref="SymbolParser.pr_SymbolBlock2Block1"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_SymbolBlock2Block1Alt1([NotNull] SymbolParser.Pr_SymbolBlock2Block1Alt1Context context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_SymbolBlock2Block1Alt2</c>
	/// labeled alternative in <see cref="SymbolParser.pr_SymbolBlock2Block1"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_SymbolBlock2Block1Alt2([NotNull] SymbolParser.Pr_SymbolBlock2Block1Alt2Context context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_PropertyBlock1Alt1</c>
	/// labeled alternative in <see cref="SymbolParser.pr_PropertyBlock1"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_PropertyBlock1Alt1([NotNull] SymbolParser.Pr_PropertyBlock1Alt1Context context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_PropertyBlock1Alt2</c>
	/// labeled alternative in <see cref="SymbolParser.pr_PropertyBlock1"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_PropertyBlock1Alt2([NotNull] SymbolParser.Pr_PropertyBlock1Alt2Context context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="SymbolParser.pr_PropertyBlock2"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_PropertyBlock2([NotNull] SymbolParser.Pr_PropertyBlock2Context context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="SymbolParser.pr_PropertyBlock3"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_PropertyBlock3([NotNull] SymbolParser.Pr_PropertyBlock3Context context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="SymbolParser.pr_OperationBlock1"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_OperationBlock1([NotNull] SymbolParser.Pr_OperationBlock1Context context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="SymbolParser.pr_OperationBlock1parametersBlock"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_OperationBlock1parametersBlock([NotNull] SymbolParser.Pr_OperationBlock1parametersBlockContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="SymbolParser.pr_TypeReferenceBlock1"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_TypeReferenceBlock1([NotNull] SymbolParser.Pr_TypeReferenceBlock1Context context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="SymbolParser.pr_ArrayDimensionsBlock1"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_ArrayDimensionsBlock1([NotNull] SymbolParser.Pr_ArrayDimensionsBlock1Context context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="SymbolParser.pr_QualifierIdentifierBlock"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_QualifierIdentifierBlock([NotNull] SymbolParser.Pr_QualifierIdentifierBlockContext context) { return VisitChildren(context); }
}
} // namespace MetaDslx.Languages.MetaSymbols.Compiler