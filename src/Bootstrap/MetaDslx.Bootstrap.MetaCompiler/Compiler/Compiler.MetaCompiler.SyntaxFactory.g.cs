using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Syntax;
using MetaDslx.CodeAnalysis.Syntax.InternalSyntax;
using MetaDslx.CodeAnalysis.Text;
using MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax;

#nullable enable

namespace MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax
{

	public class CompilerSyntaxFactory : SyntaxFactory
	{
		public CompilerSyntaxFactory(InternalSyntaxFactory internalSyntaxFactory) 
			: base(internalSyntaxFactory)
		{
		}
	    
        public override Language Language => CompilerLanguage.Instance;

	    public override ParseOptions DefaultParseOptions => CompilerParseOptions.Default;

		/// <summary>
		/// Create a new syntax tree from a syntax node.
		/// </summary>
		public CompilerSyntaxTree SyntaxTree(SyntaxNode root, CompilerParseOptions? options = null, string? path = "", Encoding? encoding = null)
		{
			return CompilerSyntaxTree.Create((CompilerSyntaxNode)root, IncrementalParseData.Empty, options, path, null, encoding);
		}

		/// <summary>
		/// Produces a syntax tree by parsing the source text.
		/// </summary>
		public CompilerSyntaxTree ParseSyntaxTree(
			string text,
			CompilerParseOptions options = null,
			string path = "",
			Encoding encoding = null,
			CancellationToken cancellationToken = default(CancellationToken))
		{
			return (CompilerSyntaxTree)this.ParseSyntaxTreeCore(SourceText.From(text, encoding), options, path, cancellationToken);
		}

		/// <summary>
		/// Produces a syntax tree by parsing the source text.
		/// </summary>
		public CompilerSyntaxTree ParseSyntaxTree(
			SourceText text,
			CompilerParseOptions? options = null,
			string path = "",
			CancellationToken cancellationToken = default(CancellationToken))
		{
			return (CompilerSyntaxTree)this.ParseSyntaxTreeCore(text, options, path, cancellationToken);
		}

		protected override SyntaxTree ParseSyntaxTreeCore(
			SourceText text,
			ParseOptions? options = null,
			string path = "",
			CancellationToken cancellationToken = default(CancellationToken))
		{
			return CompilerSyntaxTree.ParseText(text, (CompilerParseOptions?)options, path, cancellationToken);
		}
	
		public override SyntaxTree MakeSyntaxTree(SyntaxNode root, ParseOptions? options = null, string path = "", Encoding? encoding = null)
		{
			return CompilerSyntaxTree.Create((CompilerSyntaxNode)root, IncrementalParseData.Empty, (CompilerParseOptions)options, path, null, encoding);
		}

        /// <summary>
        /// Creates a token corresponding to a syntax kind. This method can be used for token syntax kinds whose text
        /// can be inferred by the kind alone.
        /// </summary>
        /// <param name="kind">A syntax kind value for a token. These have the suffix Token or Keyword.</param>
        /// <returns></returns>
        public virtual SyntaxToken Token(CompilerSyntaxKind kind)
        {
            return this.Token((int)kind);
        }

        /// <summary>
        /// Creates a token corresponding to syntax kind. This method can be used for token syntax kinds whose text can
        /// be inferred by the kind alone.
        /// </summary>
        /// <param name="leading">A list of trivia immediately preceding the token.</param>
        /// <param name="kind">A syntax kind value for a token. These have the suffix Token or Keyword.</param>
        /// <param name="trailing">A list of trivia immediately following the token.</param>
        public virtual SyntaxToken Token(SyntaxTriviaList leading, CompilerSyntaxKind kind, SyntaxTriviaList trailing)
        {
            return this.Token(leading, (int)kind, trailing);
        }

        /// <summary>
        /// Creates a token corresponding to syntax kind. This method gives control over token Text and ValueText.
        /// 
        /// For example, consider the text '&lt;see cref="operator &amp;#43;"/&gt;'.  To create a token for the value of
        /// the operator symbol (&amp;#43;), one would call 
        /// Token(default(SyntaxTriviaList), int.PlusToken, "&amp;#43;", "+", default(SyntaxTriviaList)).
        /// </summary>
        /// <param name="leading">A list of trivia immediately preceding the token.</param>
        /// <param name="kind">A syntax kind value for a token. These have the suffix Token or Keyword.</param>
        /// <param name="text">The text from which this token was created (e.g. lexed).</param>
        /// <param name="valueText">How C# should interpret the text of this token.</param>
        /// <param name="trailing">A list of trivia immediately following the token.</param>
        public virtual SyntaxToken Token(SyntaxTriviaList leading, CompilerSyntaxKind kind, string text, string valueText, SyntaxTriviaList trailing)
        {
            return this.Token(leading, (int)kind, text, valueText, trailing);
        }

        /// <summary>
        /// Creates a missing token corresponding to syntax kind. A missing token is produced by the parser when an
        /// expected token is not found. A missing token has no text and normally has associated diagnostics.
        /// </summary>
        /// <param name="kind">A syntax kind value for a token. These have the suffix Token or Keyword.</param>
        public virtual SyntaxToken MissingToken(CompilerSyntaxKind kind)
        {
            return this.MissingToken((int)kind);
        }

        /// <summary>
        /// Creates a missing token corresponding to syntax kind. A missing token is produced by the parser when an
        /// expected token is not found. A missing token has no text and normally has associated diagnostics.
        /// </summary>
        /// <param name="leading">A list of trivia immediately preceding the token.</param>
        /// <param name="kind">A syntax kind value for a token. These have the suffix Token or Keyword.</param>
        /// <param name="trailing">A list of trivia immediately following the token.</param>
        public virtual SyntaxToken MissingToken(SyntaxTriviaList leading, CompilerSyntaxKind kind, SyntaxTriviaList trailing)
        {
            return this.MissingToken(leading, (int)kind, trailing);
        }


        public SyntaxToken TInteger(string text)
        {
            return new SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.TInteger(text));
        }

        public SyntaxToken TInteger(string text, object value)
        {
            return new SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.TInteger(text, value));
        }

        public SyntaxToken TDecimal(string text)
        {
            return new SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.TDecimal(text));
        }

        public SyntaxToken TDecimal(string text, object value)
        {
            return new SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.TDecimal(text, value));
        }

        public SyntaxToken TIdentifier(string text)
        {
            return new SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.TIdentifier(text));
        }

        public SyntaxToken TIdentifier(string text, object value)
        {
            return new SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.TIdentifier(text, value));
        }

        public SyntaxToken TString(string text)
        {
            return new SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.TString(text));
        }

        public SyntaxToken TString(string text, object value)
        {
            return new SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.TString(text, value));
        }

        public SyntaxToken TWhitespace(string text)
        {
            return new SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.TWhitespace(text));
        }

        public SyntaxToken TWhitespace(string text, object value)
        {
            return new SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.TWhitespace(text, value));
        }

        public SyntaxToken TLineEnd(string text)
        {
            return new SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.TLineEnd(text));
        }

        public SyntaxToken TLineEnd(string text, object value)
        {
            return new SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.TLineEnd(text, value));
        }

        public SyntaxToken TSingleLineComment(string text)
        {
            return new SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.TSingleLineComment(text));
        }

        public SyntaxToken TSingleLineComment(string text, object value)
        {
            return new SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.TSingleLineComment(text, value));
        }

        public SyntaxToken TMultiLineComment(string text)
        {
            return new SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.TMultiLineComment(text));
        }

        public SyntaxToken TMultiLineComment(string text, object value)
        {
            return new SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.TMultiLineComment(text, value));
        }

        public MainSyntax Main(SyntaxToken kNamespace, QualifierSyntax qualifier, SyntaxToken tSemicolon, MetaDslx.CodeAnalysis.SyntaxList<UsingSyntax> @using, DeclarationsSyntax declarations, SyntaxToken eof)
        {
        	if (kNamespace.RawKind != (int)CompilerSyntaxKind.KNamespace) throw new ArgumentException(nameof(kNamespace));
        	if (qualifier is null) throw new ArgumentNullException(nameof(qualifier));
        	if (tSemicolon.RawKind != (int)CompilerSyntaxKind.TSemicolon) throw new ArgumentException(nameof(tSemicolon));
        	if (declarations is null) throw new ArgumentNullException(nameof(declarations));
        	if (eof.RawKind != (int)CompilerSyntaxKind.Eof) throw new ArgumentException(nameof(eof));
            return (MainSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.Main((InternalSyntaxToken)kNamespace.Node, (QualifierGreen)qualifier.Green, (InternalSyntaxToken)tSemicolon.Node, @using.Node.ToGreenList<UsingGreen>(), (DeclarationsGreen)declarations.Green, (InternalSyntaxToken)eof.Node).CreateRed();
        }
        
        public MainSyntax Main(QualifierSyntax qualifier, MetaDslx.CodeAnalysis.SyntaxList<UsingSyntax> @using, DeclarationsSyntax declarations)
        {
        	return this.Main(this.Token(CompilerSyntaxKind.KNamespace), qualifier, this.Token(CompilerSyntaxKind.TSemicolon), @using, declarations, this.Token(CompilerSyntaxKind.Eof));
        }

        public UsingSyntax Using(SyntaxToken kUsing, UsingBlock1Syntax usingBlock1, SyntaxToken tSemicolon)
        {
        	if (kUsing.RawKind != (int)CompilerSyntaxKind.KUsing) throw new ArgumentException(nameof(kUsing));
        	if (usingBlock1 is null) throw new ArgumentNullException(nameof(usingBlock1));
        	if (tSemicolon.RawKind != (int)CompilerSyntaxKind.TSemicolon) throw new ArgumentException(nameof(tSemicolon));
            return (UsingSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.Using((InternalSyntaxToken)kUsing.Node, (UsingBlock1Green)usingBlock1.Green, (InternalSyntaxToken)tSemicolon.Node).CreateRed();
        }
        
        public UsingSyntax Using(UsingBlock1Syntax usingBlock1)
        {
        	return this.Using(this.Token(CompilerSyntaxKind.KUsing), usingBlock1, this.Token(CompilerSyntaxKind.TSemicolon));
        }

        public DeclarationsSyntax Declarations(LanguageDeclarationSyntax declarations, MetaDslx.CodeAnalysis.SyntaxList<RuleSyntax> declarations1)
        {
        	if (declarations is null) throw new ArgumentNullException(nameof(declarations));
            return (DeclarationsSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.Declarations((LanguageDeclarationGreen)declarations.Green, declarations1.Node.ToGreenList<RuleGreen>()).CreateRed();
        }

        public LanguageDeclarationSyntax LanguageDeclaration(SyntaxToken kLanguage, NameSyntax name, SyntaxToken tSemicolon)
        {
        	if (kLanguage.RawKind != (int)CompilerSyntaxKind.KLanguage) throw new ArgumentException(nameof(kLanguage));
        	if (name is null) throw new ArgumentNullException(nameof(name));
        	if (tSemicolon.RawKind != (int)CompilerSyntaxKind.TSemicolon) throw new ArgumentException(nameof(tSemicolon));
            return (LanguageDeclarationSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.LanguageDeclaration((InternalSyntaxToken)kLanguage.Node, (NameGreen)name.Green, (InternalSyntaxToken)tSemicolon.Node).CreateRed();
        }
        
        public LanguageDeclarationSyntax LanguageDeclaration(NameSyntax name)
        {
        	return this.LanguageDeclaration(this.Token(CompilerSyntaxKind.KLanguage), name, this.Token(CompilerSyntaxKind.TSemicolon));
        }

        public ParserRuleSyntax ParserRule(NameSyntax name, ParserRuleBlock1Syntax parserRuleBlock1, SyntaxToken tColon, MetaDslx.CodeAnalysis.SeparatedSyntaxList<ParserRuleAlternativeSyntax> parserRuleAlternativeList, SyntaxToken tSemicolon)
        {
        	if (name is null) throw new ArgumentNullException(nameof(name));
        	if (tColon.RawKind != (int)CompilerSyntaxKind.TColon) throw new ArgumentException(nameof(tColon));
        	if (tSemicolon.RawKind != (int)CompilerSyntaxKind.TSemicolon) throw new ArgumentException(nameof(tSemicolon));
            return (ParserRuleSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.ParserRule((NameGreen)name.Green, (ParserRuleBlock1Green?)parserRuleBlock1?.Green, (InternalSyntaxToken)tColon.Node, parserRuleAlternativeList.Node.ToGreenSeparatedList<ParserRuleAlternativeGreen>(reversed: false), (InternalSyntaxToken)tSemicolon.Node).CreateRed();
        }
        
        public ParserRuleSyntax ParserRule(NameSyntax name, MetaDslx.CodeAnalysis.SeparatedSyntaxList<ParserRuleAlternativeSyntax> parserRuleAlternativeList)
        {
        	return this.ParserRule(name, default, this.Token(CompilerSyntaxKind.TColon), parserRuleAlternativeList, this.Token(CompilerSyntaxKind.TSemicolon));
        }

        public BlockRuleSyntax BlockRule(SyntaxToken isBlock, NameSyntax name, SyntaxToken tColon, MetaDslx.CodeAnalysis.SeparatedSyntaxList<ParserRuleAlternativeSyntax> parserRuleAlternativeList, SyntaxToken tSemicolon)
        {
        	if (isBlock.RawKind != (int)CompilerSyntaxKind.KBlock) throw new ArgumentException(nameof(isBlock));
        	if (name is null) throw new ArgumentNullException(nameof(name));
        	if (tColon.RawKind != (int)CompilerSyntaxKind.TColon) throw new ArgumentException(nameof(tColon));
        	if (tSemicolon.RawKind != (int)CompilerSyntaxKind.TSemicolon) throw new ArgumentException(nameof(tSemicolon));
            return (BlockRuleSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.BlockRule((InternalSyntaxToken)isBlock.Node, (NameGreen)name.Green, (InternalSyntaxToken)tColon.Node, parserRuleAlternativeList.Node.ToGreenSeparatedList<ParserRuleAlternativeGreen>(reversed: false), (InternalSyntaxToken)tSemicolon.Node).CreateRed();
        }
        
        public BlockRuleSyntax BlockRule(NameSyntax name, MetaDslx.CodeAnalysis.SeparatedSyntaxList<ParserRuleAlternativeSyntax> parserRuleAlternativeList)
        {
        	return this.BlockRule(this.Token(CompilerSyntaxKind.KBlock), name, this.Token(CompilerSyntaxKind.TColon), parserRuleAlternativeList, this.Token(CompilerSyntaxKind.TSemicolon));
        }

        public ParserRuleAlternativeSyntax ParserRuleAlternative(ParserRuleAlternativeBlock1Syntax parserRuleAlternativeBlock1, MetaDslx.CodeAnalysis.SyntaxList<ParserRuleElementSyntax> elements, ParserRuleAlternativeBlock2Syntax parserRuleAlternativeBlock2)
        {
        	if (parserRuleAlternativeBlock2 is null) throw new ArgumentNullException(nameof(parserRuleAlternativeBlock2));
            return (ParserRuleAlternativeSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.ParserRuleAlternative((ParserRuleAlternativeBlock1Green?)parserRuleAlternativeBlock1?.Green, elements.Node.ToGreenList<ParserRuleElementGreen>(), (ParserRuleAlternativeBlock2Green)parserRuleAlternativeBlock2.Green).CreateRed();
        }
        
        public ParserRuleAlternativeSyntax ParserRuleAlternative(MetaDslx.CodeAnalysis.SyntaxList<ParserRuleElementSyntax> elements, ParserRuleAlternativeBlock2Syntax parserRuleAlternativeBlock2)
        {
        	return this.ParserRuleAlternative(default, elements, parserRuleAlternativeBlock2);
        }

        public ParserRuleElementSyntax ParserRuleElement(NameSyntax name)
        {
        	if (name is null) throw new ArgumentNullException(nameof(name));
            return (ParserRuleElementSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.ParserRuleElement((NameGreen)name.Green).CreateRed();
        }

        public IntExpressionSyntax IntExpression(SyntaxToken intValue)
        {
        	if (intValue.RawKind != (int)CompilerSyntaxKind.TInteger) throw new ArgumentException(nameof(intValue));
            return (IntExpressionSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.IntExpression((InternalSyntaxToken)intValue.Node).CreateRed();
        }

        public StringExpressionSyntax StringExpression(SyntaxToken stringValue)
        {
        	if (stringValue.RawKind != (int)CompilerSyntaxKind.TString) throw new ArgumentException(nameof(stringValue));
            return (StringExpressionSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.StringExpression((InternalSyntaxToken)stringValue.Node).CreateRed();
        }

        public ReferenceExpressionSyntax ReferenceExpression(QualifierSyntax qualifier)
        {
        	if (qualifier is null) throw new ArgumentNullException(nameof(qualifier));
            return (ReferenceExpressionSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.ReferenceExpression((QualifierGreen)qualifier.Green).CreateRed();
        }

        public ExpressionTokensSyntax ExpressionTokens(SyntaxToken tokens)
        {
        	if (tokens.RawKind != (int)CompilerSyntaxKind.KNull && tokens.RawKind != (int)CompilerSyntaxKind.KTrue && tokens.RawKind != (int)CompilerSyntaxKind.KFalse) throw new ArgumentException(nameof(tokens));
            return (ExpressionTokensSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.ExpressionTokens((InternalSyntaxToken)tokens.Node).CreateRed();
        }

        public NameSyntax Name(IdentifierSyntax identifier)
        {
        	if (identifier is null) throw new ArgumentNullException(nameof(identifier));
            return (NameSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.Name((IdentifierGreen)identifier.Green).CreateRed();
        }

        public QualifierSyntax Qualifier(MetaDslx.CodeAnalysis.SeparatedSyntaxList<IdentifierSyntax> identifierList)
        {
            return (QualifierSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.Qualifier(identifierList.Node.ToGreenSeparatedList<IdentifierGreen>(reversed: false)).CreateRed();
        }

        public QualifierListSyntax QualifierList(MetaDslx.CodeAnalysis.SeparatedSyntaxList<QualifierSyntax> qualifierList)
        {
            return (QualifierListSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.QualifierList(qualifierList.Node.ToGreenSeparatedList<QualifierGreen>(reversed: false)).CreateRed();
        }

        public IdentifierSyntax Identifier(SyntaxToken tIdentifier)
        {
        	if (tIdentifier.RawKind != (int)CompilerSyntaxKind.TIdentifier) throw new ArgumentException(nameof(tIdentifier));
            return (IdentifierSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.Identifier((InternalSyntaxToken)tIdentifier.Node).CreateRed();
        }

        public UsingBlock1Alt1Syntax UsingBlock1Alt1(QualifierSyntax namespaces)
        {
        	if (namespaces is null) throw new ArgumentNullException(nameof(namespaces));
            return (UsingBlock1Alt1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.UsingBlock1Alt1((QualifierGreen)namespaces.Green).CreateRed();
        }

        public UsingBlock1Alt2Syntax UsingBlock1Alt2(SyntaxToken kMetamodel, QualifierSyntax metaModels)
        {
        	if (kMetamodel.RawKind != (int)CompilerSyntaxKind.KMetamodel) throw new ArgumentException(nameof(kMetamodel));
        	if (metaModels is null) throw new ArgumentNullException(nameof(metaModels));
            return (UsingBlock1Alt2Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.UsingBlock1Alt2((InternalSyntaxToken)kMetamodel.Node, (QualifierGreen)metaModels.Green).CreateRed();
        }
        
        public UsingBlock1Alt2Syntax UsingBlock1Alt2(QualifierSyntax metaModels)
        {
        	return this.UsingBlock1Alt2(this.Token(CompilerSyntaxKind.KMetamodel), metaModels);
        }

        public ParserRuleBlock1Syntax ParserRuleBlock1(SyntaxToken kReturns, QualifierSyntax returnType)
        {
        	if (kReturns.RawKind != (int)CompilerSyntaxKind.KReturns) throw new ArgumentException(nameof(kReturns));
        	if (returnType is null) throw new ArgumentNullException(nameof(returnType));
            return (ParserRuleBlock1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.ParserRuleBlock1((InternalSyntaxToken)kReturns.Node, (QualifierGreen)returnType.Green).CreateRed();
        }
        
        public ParserRuleBlock1Syntax ParserRuleBlock1(QualifierSyntax returnType)
        {
        	return this.ParserRuleBlock1(this.Token(CompilerSyntaxKind.KReturns), returnType);
        }

        public ParserRuleBlock2Syntax ParserRuleBlock2(SyntaxToken tBar, ParserRuleAlternativeSyntax alternatives)
        {
        	if (tBar.RawKind != (int)CompilerSyntaxKind.TBar) throw new ArgumentException(nameof(tBar));
        	if (alternatives is null) throw new ArgumentNullException(nameof(alternatives));
            return (ParserRuleBlock2Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.ParserRuleBlock2((InternalSyntaxToken)tBar.Node, (ParserRuleAlternativeGreen)alternatives.Green).CreateRed();
        }
        
        public ParserRuleBlock2Syntax ParserRuleBlock2(ParserRuleAlternativeSyntax alternatives)
        {
        	return this.ParserRuleBlock2(this.Token(CompilerSyntaxKind.TBar), alternatives);
        }

        public BlockRuleBlock1Syntax BlockRuleBlock1(SyntaxToken tBar, ParserRuleAlternativeSyntax alternatives)
        {
        	if (tBar.RawKind != (int)CompilerSyntaxKind.TBar) throw new ArgumentException(nameof(tBar));
        	if (alternatives is null) throw new ArgumentNullException(nameof(alternatives));
            return (BlockRuleBlock1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.BlockRuleBlock1((InternalSyntaxToken)tBar.Node, (ParserRuleAlternativeGreen)alternatives.Green).CreateRed();
        }
        
        public BlockRuleBlock1Syntax BlockRuleBlock1(ParserRuleAlternativeSyntax alternatives)
        {
        	return this.BlockRuleBlock1(this.Token(CompilerSyntaxKind.TBar), alternatives);
        }

        public ParserRuleAlternativeBlock1Syntax ParserRuleAlternativeBlock1(SyntaxToken tLBrace, QualifierSyntax returnType, SyntaxToken tRBrace)
        {
        	if (tLBrace.RawKind != (int)CompilerSyntaxKind.TLBrace) throw new ArgumentException(nameof(tLBrace));
        	if (returnType is null) throw new ArgumentNullException(nameof(returnType));
        	if (tRBrace.RawKind != (int)CompilerSyntaxKind.TRBrace) throw new ArgumentException(nameof(tRBrace));
            return (ParserRuleAlternativeBlock1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.ParserRuleAlternativeBlock1((InternalSyntaxToken)tLBrace.Node, (QualifierGreen)returnType.Green, (InternalSyntaxToken)tRBrace.Node).CreateRed();
        }
        
        public ParserRuleAlternativeBlock1Syntax ParserRuleAlternativeBlock1(QualifierSyntax returnType)
        {
        	return this.ParserRuleAlternativeBlock1(this.Token(CompilerSyntaxKind.TLBrace), returnType, this.Token(CompilerSyntaxKind.TRBrace));
        }

        public ParserRuleAlternativeBlock2Syntax ParserRuleAlternativeBlock2(SyntaxToken tEqGt, ExpressionSyntax returnValue)
        {
        	if (tEqGt.RawKind != (int)CompilerSyntaxKind.TEqGt) throw new ArgumentException(nameof(tEqGt));
        	if (returnValue is null) throw new ArgumentNullException(nameof(returnValue));
            return (ParserRuleAlternativeBlock2Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.ParserRuleAlternativeBlock2((InternalSyntaxToken)tEqGt.Node, (ExpressionGreen)returnValue.Green).CreateRed();
        }
        
        public ParserRuleAlternativeBlock2Syntax ParserRuleAlternativeBlock2(ExpressionSyntax returnValue)
        {
        	return this.ParserRuleAlternativeBlock2(this.Token(CompilerSyntaxKind.TEqGt), returnValue);
        }

        public QualifierBlock1Syntax QualifierBlock1(SyntaxToken tDot, IdentifierSyntax identifier)
        {
        	if (tDot.RawKind != (int)CompilerSyntaxKind.TDot) throw new ArgumentException(nameof(tDot));
        	if (identifier is null) throw new ArgumentNullException(nameof(identifier));
            return (QualifierBlock1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.QualifierBlock1((InternalSyntaxToken)tDot.Node, (IdentifierGreen)identifier.Green).CreateRed();
        }
        
        public QualifierBlock1Syntax QualifierBlock1(IdentifierSyntax identifier)
        {
        	return this.QualifierBlock1(this.Token(CompilerSyntaxKind.TDot), identifier);
        }

        public QualifierListBlock1Syntax QualifierListBlock1(SyntaxToken tComma, QualifierSyntax qualifier)
        {
        	if (tComma.RawKind != (int)CompilerSyntaxKind.TComma) throw new ArgumentException(nameof(tComma));
        	if (qualifier is null) throw new ArgumentNullException(nameof(qualifier));
            return (QualifierListBlock1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.QualifierListBlock1((InternalSyntaxToken)tComma.Node, (QualifierGreen)qualifier.Green).CreateRed();
        }
        
        public QualifierListBlock1Syntax QualifierListBlock1(QualifierSyntax qualifier)
        {
        	return this.QualifierListBlock1(this.Token(CompilerSyntaxKind.TComma), qualifier);
        }
				

        internal static IEnumerable<Type> GetNodeTypes()
        {
            return new Type[] {
		        typeof(MainSyntax),
		        typeof(UsingSyntax),
		        typeof(DeclarationsSyntax),
		        typeof(LanguageDeclarationSyntax),
		        typeof(ParserRuleSyntax),
		        typeof(BlockRuleSyntax),
		        typeof(ParserRuleAlternativeSyntax),
		        typeof(ParserRuleElementSyntax),
		        typeof(IntExpressionSyntax),
		        typeof(StringExpressionSyntax),
		        typeof(ReferenceExpressionSyntax),
		        typeof(ExpressionTokensSyntax),
		        typeof(NameSyntax),
		        typeof(QualifierSyntax),
		        typeof(QualifierListSyntax),
		        typeof(IdentifierSyntax),
		        typeof(UsingBlock1Alt1Syntax),
		        typeof(UsingBlock1Alt2Syntax),
		        typeof(ParserRuleBlock1Syntax),
		        typeof(ParserRuleBlock2Syntax),
		        typeof(BlockRuleBlock1Syntax),
		        typeof(ParserRuleAlternativeBlock1Syntax),
		        typeof(ParserRuleAlternativeBlock2Syntax),
		        typeof(QualifierBlock1Syntax),
		        typeof(QualifierListBlock1Syntax),
		    };
        }

    }
}	
