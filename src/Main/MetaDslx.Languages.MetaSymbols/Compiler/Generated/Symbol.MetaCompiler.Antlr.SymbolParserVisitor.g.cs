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

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="SymbolParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.13.0")]
[System.CLSCompliant(false)]
public interface ISymbolParserVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="SymbolParser.pr_Main"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_Main([NotNull] SymbolParser.Pr_MainContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SymbolParser.pr_Using"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_Using([NotNull] SymbolParser.Pr_UsingContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SymbolParser.pr_Symbol"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_Symbol([NotNull] SymbolParser.Pr_SymbolContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SymbolParser.pr_Property"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_Property([NotNull] SymbolParser.Pr_PropertyContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_OperationAlt1</c>
	/// labeled alternative in <see cref="SymbolParser.pr_Operation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_OperationAlt1([NotNull] SymbolParser.Pr_OperationAlt1Context context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_OperationAlt2</c>
	/// labeled alternative in <see cref="SymbolParser.pr_Operation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_OperationAlt2([NotNull] SymbolParser.Pr_OperationAlt2Context context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SymbolParser.pr_Parameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_Parameter([NotNull] SymbolParser.Pr_ParameterContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SymbolParser.pr_TypeReference"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_TypeReference([NotNull] SymbolParser.Pr_TypeReferenceContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SymbolParser.pr_ArrayDimensions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_ArrayDimensions([NotNull] SymbolParser.Pr_ArrayDimensionsContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_SimpleTypeReferenceAlt1</c>
	/// labeled alternative in <see cref="SymbolParser.pr_SimpleTypeReference"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_SimpleTypeReferenceAlt1([NotNull] SymbolParser.Pr_SimpleTypeReferenceAlt1Context context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_SimpleTypeReferenceAlt2</c>
	/// labeled alternative in <see cref="SymbolParser.pr_SimpleTypeReference"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_SimpleTypeReferenceAlt2([NotNull] SymbolParser.Pr_SimpleTypeReferenceAlt2Context context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SymbolParser.pr_PrimitiveType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_PrimitiveType([NotNull] SymbolParser.Pr_PrimitiveTypeContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_ValueAlt1</c>
	/// labeled alternative in <see cref="SymbolParser.pr_Value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_ValueAlt1([NotNull] SymbolParser.Pr_ValueAlt1Context context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_ValueAlt2</c>
	/// labeled alternative in <see cref="SymbolParser.pr_Value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_ValueAlt2([NotNull] SymbolParser.Pr_ValueAlt2Context context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_ValueAlt3</c>
	/// labeled alternative in <see cref="SymbolParser.pr_Value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_ValueAlt3([NotNull] SymbolParser.Pr_ValueAlt3Context context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_ValueAlt4</c>
	/// labeled alternative in <see cref="SymbolParser.pr_Value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_ValueAlt4([NotNull] SymbolParser.Pr_ValueAlt4Context context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_ValueAlt5</c>
	/// labeled alternative in <see cref="SymbolParser.pr_Value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_ValueAlt5([NotNull] SymbolParser.Pr_ValueAlt5Context context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_ValueAlt6</c>
	/// labeled alternative in <see cref="SymbolParser.pr_Value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_ValueAlt6([NotNull] SymbolParser.Pr_ValueAlt6Context context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SymbolParser.pr_Name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_Name([NotNull] SymbolParser.Pr_NameContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SymbolParser.pr_Qualifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_Qualifier([NotNull] SymbolParser.Pr_QualifierContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SymbolParser.pr_Identifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_Identifier([NotNull] SymbolParser.Pr_IdentifierContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SymbolParser.pr_TBoolean"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_TBoolean([NotNull] SymbolParser.Pr_TBooleanContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SymbolParser.pr_MainBlock1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_MainBlock1([NotNull] SymbolParser.Pr_MainBlock1Context context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SymbolParser.pr_SymbolBlock1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_SymbolBlock1([NotNull] SymbolParser.Pr_SymbolBlock1Context context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SymbolParser.pr_SymbolBlock2"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_SymbolBlock2([NotNull] SymbolParser.Pr_SymbolBlock2Context context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_SymbolBlock2Block1Alt1</c>
	/// labeled alternative in <see cref="SymbolParser.pr_SymbolBlock2Block1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_SymbolBlock2Block1Alt1([NotNull] SymbolParser.Pr_SymbolBlock2Block1Alt1Context context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_SymbolBlock2Block1Alt2</c>
	/// labeled alternative in <see cref="SymbolParser.pr_SymbolBlock2Block1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_SymbolBlock2Block1Alt2([NotNull] SymbolParser.Pr_SymbolBlock2Block1Alt2Context context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_PropertyBlock1Alt1</c>
	/// labeled alternative in <see cref="SymbolParser.pr_PropertyBlock1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_PropertyBlock1Alt1([NotNull] SymbolParser.Pr_PropertyBlock1Alt1Context context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_PropertyBlock1Alt2</c>
	/// labeled alternative in <see cref="SymbolParser.pr_PropertyBlock1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_PropertyBlock1Alt2([NotNull] SymbolParser.Pr_PropertyBlock1Alt2Context context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_PropertyBlock1Alt3</c>
	/// labeled alternative in <see cref="SymbolParser.pr_PropertyBlock1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_PropertyBlock1Alt3([NotNull] SymbolParser.Pr_PropertyBlock1Alt3Context context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_PropertyBlock1Alt1Block1Alt1</c>
	/// labeled alternative in <see cref="SymbolParser.pr_PropertyBlock1Alt1Block1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_PropertyBlock1Alt1Block1Alt1([NotNull] SymbolParser.Pr_PropertyBlock1Alt1Block1Alt1Context context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_PropertyBlock1Alt1Block1Alt2</c>
	/// labeled alternative in <see cref="SymbolParser.pr_PropertyBlock1Alt1Block1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_PropertyBlock1Alt1Block1Alt2([NotNull] SymbolParser.Pr_PropertyBlock1Alt1Block1Alt2Context context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SymbolParser.pr_PropertyBlock2"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_PropertyBlock2([NotNull] SymbolParser.Pr_PropertyBlock2Context context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SymbolParser.pr_PropertyBlock3"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_PropertyBlock3([NotNull] SymbolParser.Pr_PropertyBlock3Context context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SymbolParser.pr_OperationAlt2Block1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_OperationAlt2Block1([NotNull] SymbolParser.Pr_OperationAlt2Block1Context context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SymbolParser.pr_OperationAlt2Block1parametersBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_OperationAlt2Block1parametersBlock([NotNull] SymbolParser.Pr_OperationAlt2Block1parametersBlockContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SymbolParser.pr_OperationAlt2Block2"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_OperationAlt2Block2([NotNull] SymbolParser.Pr_OperationAlt2Block2Context context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SymbolParser.pr_TypeReferenceBlock1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_TypeReferenceBlock1([NotNull] SymbolParser.Pr_TypeReferenceBlock1Context context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SymbolParser.pr_ArrayDimensionsBlock1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_ArrayDimensionsBlock1([NotNull] SymbolParser.Pr_ArrayDimensionsBlock1Context context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SymbolParser.pr_QualifierIdentifierBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_QualifierIdentifierBlock([NotNull] SymbolParser.Pr_QualifierIdentifierBlockContext context);
}
} // namespace MetaDslx.Languages.MetaSymbols.Compiler
