//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.13.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from MetaParser.g4 by ANTLR 4.13.0

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace MetaDslx.Languages.MetaModel.Compiler {
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="IMetaParserVisitor{Result}"/>,
/// which can be extended to create a visitor which only needs to handle a subset
/// of the available methods.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.13.0")]
[System.Diagnostics.DebuggerNonUserCode]
[System.CLSCompliant(false)]
public partial class MetaParserBaseVisitor<Result> : AbstractParseTreeVisitor<Result>, IMetaParserVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="MetaParser.pr_Main"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_Main([NotNull] MetaParser.Pr_MainContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="MetaParser.pr_Using"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_Using([NotNull] MetaParser.Pr_UsingContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="MetaParser.pr_Declarations"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_Declarations([NotNull] MetaParser.Pr_DeclarationsContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_MetaModel</c>
	/// labeled alternative in <see cref="MetaParser.pr_MetaDeclaration"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_MetaModel([NotNull] MetaParser.Pr_MetaModelContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_MetaConstant</c>
	/// labeled alternative in <see cref="MetaParser.pr_MetaDeclaration"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_MetaConstant([NotNull] MetaParser.Pr_MetaConstantContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_MetaEnum</c>
	/// labeled alternative in <see cref="MetaParser.pr_MetaDeclaration"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_MetaEnum([NotNull] MetaParser.Pr_MetaEnumContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_MetaClass</c>
	/// labeled alternative in <see cref="MetaParser.pr_MetaDeclaration"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_MetaClass([NotNull] MetaParser.Pr_MetaClassContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="MetaParser.pr_EnumBody"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_EnumBody([NotNull] MetaParser.Pr_EnumBodyContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="MetaParser.pr_EnumLiterals"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_EnumLiterals([NotNull] MetaParser.Pr_EnumLiteralsContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="MetaParser.pr_MetaEnumLiteral"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_MetaEnumLiteral([NotNull] MetaParser.Pr_MetaEnumLiteralContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_ClassNameAlt1</c>
	/// labeled alternative in <see cref="MetaParser.pr_ClassName"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_ClassNameAlt1([NotNull] MetaParser.Pr_ClassNameAlt1Context context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_ClassNameAlt2</c>
	/// labeled alternative in <see cref="MetaParser.pr_ClassName"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_ClassNameAlt2([NotNull] MetaParser.Pr_ClassNameAlt2Context context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="MetaParser.pr_BaseClasses"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_BaseClasses([NotNull] MetaParser.Pr_BaseClassesContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="MetaParser.pr_ClassBody"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_ClassBody([NotNull] MetaParser.Pr_ClassBodyContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_ClassMemberAlt1</c>
	/// labeled alternative in <see cref="MetaParser.pr_ClassMember"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_ClassMemberAlt1([NotNull] MetaParser.Pr_ClassMemberAlt1Context context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_ClassMemberAlt2</c>
	/// labeled alternative in <see cref="MetaParser.pr_ClassMember"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_ClassMemberAlt2([NotNull] MetaParser.Pr_ClassMemberAlt2Context context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="MetaParser.pr_MetaProperty"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_MetaProperty([NotNull] MetaParser.Pr_MetaPropertyContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_PropertyNameAlt1</c>
	/// labeled alternative in <see cref="MetaParser.pr_PropertyName"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_PropertyNameAlt1([NotNull] MetaParser.Pr_PropertyNameAlt1Context context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_PropertyNameAlt2</c>
	/// labeled alternative in <see cref="MetaParser.pr_PropertyName"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_PropertyNameAlt2([NotNull] MetaParser.Pr_PropertyNameAlt2Context context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="MetaParser.pr_PropertyOpposite"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_PropertyOpposite([NotNull] MetaParser.Pr_PropertyOppositeContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="MetaParser.pr_PropertySubsets"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_PropertySubsets([NotNull] MetaParser.Pr_PropertySubsetsContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="MetaParser.pr_PropertyRedefines"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_PropertyRedefines([NotNull] MetaParser.Pr_PropertyRedefinesContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="MetaParser.pr_MetaOperation"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_MetaOperation([NotNull] MetaParser.Pr_MetaOperationContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="MetaParser.pr_ParameterList"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_ParameterList([NotNull] MetaParser.Pr_ParameterListContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="MetaParser.pr_MetaParameter"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_MetaParameter([NotNull] MetaParser.Pr_MetaParameterContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_MetaNullableType</c>
	/// labeled alternative in <see cref="MetaParser.pr_TypeReference"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_MetaNullableType([NotNull] MetaParser.Pr_MetaNullableTypeContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_TypeReferenceTokens</c>
	/// labeled alternative in <see cref="MetaParser.pr_TypeReference"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_TypeReferenceTokens([NotNull] MetaParser.Pr_TypeReferenceTokensContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_MetaArrayType</c>
	/// labeled alternative in <see cref="MetaParser.pr_TypeReference"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_MetaArrayType([NotNull] MetaParser.Pr_MetaArrayTypeContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_TypeReferenceAlt4</c>
	/// labeled alternative in <see cref="MetaParser.pr_TypeReference"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_TypeReferenceAlt4([NotNull] MetaParser.Pr_TypeReferenceAlt4Context context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="MetaParser.pr_Name"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_Name([NotNull] MetaParser.Pr_NameContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="MetaParser.pr_Qualifier"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_Qualifier([NotNull] MetaParser.Pr_QualifierContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="MetaParser.pr_QualifierList"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_QualifierList([NotNull] MetaParser.Pr_QualifierListContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="MetaParser.pr_Identifier"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_Identifier([NotNull] MetaParser.Pr_IdentifierContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="MetaParser.pr_EnumLiteralsBlock1"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_EnumLiteralsBlock1([NotNull] MetaParser.Pr_EnumLiteralsBlock1Context context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="MetaParser.pr_BaseClassesBlock1"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_BaseClassesBlock1([NotNull] MetaParser.Pr_BaseClassesBlock1Context context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_MetaPropertyBlock2Alt1</c>
	/// labeled alternative in <see cref="MetaParser.pr_MetaPropertyBlock2"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_MetaPropertyBlock2Alt1([NotNull] MetaParser.Pr_MetaPropertyBlock2Alt1Context context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_MetaPropertyBlock2Alt2</c>
	/// labeled alternative in <see cref="MetaParser.pr_MetaPropertyBlock2"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_MetaPropertyBlock2Alt2([NotNull] MetaParser.Pr_MetaPropertyBlock2Alt2Context context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_MetaPropertyBlock2Alt3</c>
	/// labeled alternative in <see cref="MetaParser.pr_MetaPropertyBlock2"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_MetaPropertyBlock2Alt3([NotNull] MetaParser.Pr_MetaPropertyBlock2Alt3Context context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="MetaParser.pr_PropertyOppositeBlock1"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_PropertyOppositeBlock1([NotNull] MetaParser.Pr_PropertyOppositeBlock1Context context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="MetaParser.pr_PropertySubsetsBlock1"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_PropertySubsetsBlock1([NotNull] MetaParser.Pr_PropertySubsetsBlock1Context context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="MetaParser.pr_PropertyRedefinesBlock1"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_PropertyRedefinesBlock1([NotNull] MetaParser.Pr_PropertyRedefinesBlock1Context context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="MetaParser.pr_ParameterListBlock1"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_ParameterListBlock1([NotNull] MetaParser.Pr_ParameterListBlock1Context context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="MetaParser.pr_QualifierBlock1"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_QualifierBlock1([NotNull] MetaParser.Pr_QualifierBlock1Context context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="MetaParser.pr_QualifierListBlock1"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPr_QualifierListBlock1([NotNull] MetaParser.Pr_QualifierListBlock1Context context) { return VisitChildren(context); }
}
} // namespace MetaDslx.Languages.MetaModel.Compiler
