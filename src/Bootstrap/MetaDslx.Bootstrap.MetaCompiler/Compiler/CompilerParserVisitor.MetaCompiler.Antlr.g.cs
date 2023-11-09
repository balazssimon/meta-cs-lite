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
}
} // namespace MetaDslx.Bootstrap.MetaCompiler.Compiler