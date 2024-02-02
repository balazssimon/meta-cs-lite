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

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="MetaParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.13.0")]
[System.CLSCompliant(false)]
public interface IMetaParserVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="MetaParser.pr_Main"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_Main([NotNull] MetaParser.Pr_MainContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MetaParser.pr_Using"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_Using([NotNull] MetaParser.Pr_UsingContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MetaParser.pr_MetaModel"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_MetaModel([NotNull] MetaParser.Pr_MetaModelContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_MetaDeclarationAlt1</c>
	/// labeled alternative in <see cref="MetaParser.pr_MetaDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_MetaDeclarationAlt1([NotNull] MetaParser.Pr_MetaDeclarationAlt1Context context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_MetaDeclarationAlt2</c>
	/// labeled alternative in <see cref="MetaParser.pr_MetaDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_MetaDeclarationAlt2([NotNull] MetaParser.Pr_MetaDeclarationAlt2Context context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_MetaDeclarationAlt3</c>
	/// labeled alternative in <see cref="MetaParser.pr_MetaDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_MetaDeclarationAlt3([NotNull] MetaParser.Pr_MetaDeclarationAlt3Context context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MetaParser.pr_MetaConstant"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_MetaConstant([NotNull] MetaParser.Pr_MetaConstantContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MetaParser.pr_MetaEnum"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_MetaEnum([NotNull] MetaParser.Pr_MetaEnumContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MetaParser.pr_MetaEnumLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_MetaEnumLiteral([NotNull] MetaParser.Pr_MetaEnumLiteralContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MetaParser.pr_MetaClass"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_MetaClass([NotNull] MetaParser.Pr_MetaClassContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MetaParser.pr_MetaProperty"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_MetaProperty([NotNull] MetaParser.Pr_MetaPropertyContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MetaParser.pr_MetaOperation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_MetaOperation([NotNull] MetaParser.Pr_MetaOperationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MetaParser.pr_MetaParameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_MetaParameter([NotNull] MetaParser.Pr_MetaParameterContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_SimpleTypeReference</c>
	/// labeled alternative in <see cref="MetaParser.pr_MetaTypeReference"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_SimpleTypeReference([NotNull] MetaParser.Pr_SimpleTypeReferenceContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_MetaNullableType</c>
	/// labeled alternative in <see cref="MetaParser.pr_MetaTypeReference"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_MetaNullableType([NotNull] MetaParser.Pr_MetaNullableTypeContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_MetaArrayType</c>
	/// labeled alternative in <see cref="MetaParser.pr_MetaTypeReference"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_MetaArrayType([NotNull] MetaParser.Pr_MetaArrayTypeContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_TypeReferenceAlt1</c>
	/// labeled alternative in <see cref="MetaParser.pr_TypeReference"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_TypeReferenceAlt1([NotNull] MetaParser.Pr_TypeReferenceAlt1Context context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_TypeReferenceAlt2</c>
	/// labeled alternative in <see cref="MetaParser.pr_TypeReference"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_TypeReferenceAlt2([NotNull] MetaParser.Pr_TypeReferenceAlt2Context context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MetaParser.pr_PrimitiveType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_PrimitiveType([NotNull] MetaParser.Pr_PrimitiveTypeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MetaParser.pr_Name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_Name([NotNull] MetaParser.Pr_NameContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MetaParser.pr_Qualifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_Qualifier([NotNull] MetaParser.Pr_QualifierContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MetaParser.pr_Identifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_Identifier([NotNull] MetaParser.Pr_IdentifierContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MetaParser.pr_MetaEnumliteralsBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_MetaEnumliteralsBlock([NotNull] MetaParser.Pr_MetaEnumliteralsBlockContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_MetaClassBlock1Alt1</c>
	/// labeled alternative in <see cref="MetaParser.pr_MetaClassBlock1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_MetaClassBlock1Alt1([NotNull] MetaParser.Pr_MetaClassBlock1Alt1Context context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_MetaClassBlock1Alt2</c>
	/// labeled alternative in <see cref="MetaParser.pr_MetaClassBlock1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_MetaClassBlock1Alt2([NotNull] MetaParser.Pr_MetaClassBlock1Alt2Context context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MetaParser.pr_MetaClassBlock2"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_MetaClassBlock2([NotNull] MetaParser.Pr_MetaClassBlock2Context context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MetaParser.pr_MetaClassBlock2baseTypesBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_MetaClassBlock2baseTypesBlock([NotNull] MetaParser.Pr_MetaClassBlock2baseTypesBlockContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MetaParser.pr_MetaClassBlock3"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_MetaClassBlock3([NotNull] MetaParser.Pr_MetaClassBlock3Context context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_MetaClassBlock3Block1Alt1</c>
	/// labeled alternative in <see cref="MetaParser.pr_MetaClassBlock3Block1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_MetaClassBlock3Block1Alt1([NotNull] MetaParser.Pr_MetaClassBlock3Block1Alt1Context context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_MetaClassBlock3Block1Alt2</c>
	/// labeled alternative in <see cref="MetaParser.pr_MetaClassBlock3Block1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_MetaClassBlock3Block1Alt2([NotNull] MetaParser.Pr_MetaClassBlock3Block1Alt2Context context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_MetaPropertyBlock1Alt1</c>
	/// labeled alternative in <see cref="MetaParser.pr_MetaPropertyBlock1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_MetaPropertyBlock1Alt1([NotNull] MetaParser.Pr_MetaPropertyBlock1Alt1Context context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_MetaPropertyBlock1Alt2</c>
	/// labeled alternative in <see cref="MetaParser.pr_MetaPropertyBlock1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_MetaPropertyBlock1Alt2([NotNull] MetaParser.Pr_MetaPropertyBlock1Alt2Context context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_MetaPropertyBlock2Alt1</c>
	/// labeled alternative in <see cref="MetaParser.pr_MetaPropertyBlock2"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_MetaPropertyBlock2Alt1([NotNull] MetaParser.Pr_MetaPropertyBlock2Alt1Context context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_MetaPropertyBlock2Alt2</c>
	/// labeled alternative in <see cref="MetaParser.pr_MetaPropertyBlock2"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_MetaPropertyBlock2Alt2([NotNull] MetaParser.Pr_MetaPropertyBlock2Alt2Context context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_MetaPropertyBlock3Alt1</c>
	/// labeled alternative in <see cref="MetaParser.pr_MetaPropertyBlock3"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_MetaPropertyBlock3Alt1([NotNull] MetaParser.Pr_MetaPropertyBlock3Alt1Context context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_MetaPropertyBlock3Alt2</c>
	/// labeled alternative in <see cref="MetaParser.pr_MetaPropertyBlock3"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_MetaPropertyBlock3Alt2([NotNull] MetaParser.Pr_MetaPropertyBlock3Alt2Context context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pr_MetaPropertyBlock3Alt3</c>
	/// labeled alternative in <see cref="MetaParser.pr_MetaPropertyBlock3"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_MetaPropertyBlock3Alt3([NotNull] MetaParser.Pr_MetaPropertyBlock3Alt3Context context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MetaParser.pr_MetaPropertyBlock3Alt1oppositePropertiesBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_MetaPropertyBlock3Alt1oppositePropertiesBlock([NotNull] MetaParser.Pr_MetaPropertyBlock3Alt1oppositePropertiesBlockContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MetaParser.pr_MetaPropertyBlock3Alt2subsettedPropertiesBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_MetaPropertyBlock3Alt2subsettedPropertiesBlock([NotNull] MetaParser.Pr_MetaPropertyBlock3Alt2subsettedPropertiesBlockContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MetaParser.pr_MetaPropertyBlock3Alt3redefinedPropertiesBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_MetaPropertyBlock3Alt3redefinedPropertiesBlock([NotNull] MetaParser.Pr_MetaPropertyBlock3Alt3redefinedPropertiesBlockContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MetaParser.pr_MetaOperationBlock1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_MetaOperationBlock1([NotNull] MetaParser.Pr_MetaOperationBlock1Context context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MetaParser.pr_MetaOperationBlock1parametersBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_MetaOperationBlock1parametersBlock([NotNull] MetaParser.Pr_MetaOperationBlock1parametersBlockContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MetaParser.pr_QualifierIdentifierBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPr_QualifierIdentifierBlock([NotNull] MetaParser.Pr_QualifierIdentifierBlockContext context);
}
} // namespace MetaDslx.Languages.MetaModel.Compiler
