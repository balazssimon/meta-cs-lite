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

        public SyntaxToken TPrimitiveType(string text)
        {
            return new SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.TPrimitiveType(text));
        }

        public SyntaxToken TPrimitiveType(string text, object value)
        {
            return new SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.TPrimitiveType(text, value));
        }

        public SyntaxToken TIdentifier(string text)
        {
            return new SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.TIdentifier(text));
        }

        public SyntaxToken TIdentifier(string text, object value)
        {
            return new SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.TIdentifier(text, value));
        }

        public SyntaxToken TVerbatimIdentifier(string text)
        {
            return new SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.TVerbatimIdentifier(text));
        }

        public SyntaxToken TVerbatimIdentifier(string text, object value)
        {
            return new SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.TVerbatimIdentifier(text, value));
        }

        public SyntaxToken TString(string text)
        {
            return new SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.TString(text));
        }

        public SyntaxToken TString(string text, object value)
        {
            return new SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.TString(text, value));
        }

        public SyntaxToken DoubleQuoteTextCharacter(string text)
        {
            return new SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.DoubleQuoteTextCharacter(text));
        }

        public SyntaxToken DoubleQuoteTextCharacter(string text, object value)
        {
            return new SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.DoubleQuoteTextCharacter(text, value));
        }

        public SyntaxToken DoubleQuoteTextSimple(string text)
        {
            return new SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.DoubleQuoteTextSimple(text));
        }

        public SyntaxToken DoubleQuoteTextSimple(string text, object value)
        {
            return new SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.DoubleQuoteTextSimple(text, value));
        }

        public SyntaxToken SingleQuoteTextCharacter(string text)
        {
            return new SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.SingleQuoteTextCharacter(text));
        }

        public SyntaxToken SingleQuoteTextCharacter(string text, object value)
        {
            return new SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.SingleQuoteTextCharacter(text, value));
        }

        public SyntaxToken SingleQuoteTextSimple(string text)
        {
            return new SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.SingleQuoteTextSimple(text));
        }

        public SyntaxToken SingleQuoteTextSimple(string text, object value)
        {
            return new SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.SingleQuoteTextSimple(text, value));
        }

        public SyntaxToken CharacterEscapeSimple(string text)
        {
            return new SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.CharacterEscapeSimple(text));
        }

        public SyntaxToken CharacterEscapeSimple(string text, object value)
        {
            return new SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.CharacterEscapeSimple(text, value));
        }

        public SyntaxToken CharacterEscapeSimpleCharacter(string text)
        {
            return new SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.CharacterEscapeSimpleCharacter(text));
        }

        public SyntaxToken CharacterEscapeSimpleCharacter(string text, object value)
        {
            return new SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.CharacterEscapeSimpleCharacter(text, value));
        }

        public SyntaxToken CharacterEscapeUnicode(string text)
        {
            return new SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.CharacterEscapeUnicode(text));
        }

        public SyntaxToken CharacterEscapeUnicode(string text, object value)
        {
            return new SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.CharacterEscapeUnicode(text, value));
        }

        public SyntaxToken HexDigit(string text)
        {
            return new SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.HexDigit(text));
        }

        public SyntaxToken HexDigit(string text, object value)
        {
            return new SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.HexDigit(text, value));
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

        public SyntaxToken TInvalidToken(string text)
        {
            return new SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.TInvalidToken(text));
        }

        public SyntaxToken TInvalidToken(string text, object value)
        {
            return new SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.TInvalidToken(text, value));
        }

        public MainSyntax Main(SyntaxToken kNamespace, QualifierSyntax name, SyntaxToken tSemicolon, MetaDslx.CodeAnalysis.SyntaxList<UsingSyntax> @using, DeclarationsSyntax declarations, SyntaxToken eof)
        {
        	if (kNamespace.RawKind != (int)CompilerSyntaxKind.KNamespace) throw new ArgumentException(nameof(kNamespace));
        	if (name is null) throw new ArgumentNullException(nameof(name));
        	if (tSemicolon.RawKind != (int)CompilerSyntaxKind.TSemicolon) throw new ArgumentException(nameof(tSemicolon));
        	if (declarations is null) throw new ArgumentNullException(nameof(declarations));
        	if (eof.RawKind != (int)CompilerSyntaxKind.Eof) throw new ArgumentException(nameof(eof));
            return (MainSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.Main((InternalSyntaxToken)kNamespace.Node, (QualifierGreen)name.Green, (InternalSyntaxToken)tSemicolon.Node, @using.Node.ToGreenList<UsingGreen>(), (DeclarationsGreen)declarations.Green, (InternalSyntaxToken)eof.Node).CreateRed();
        }
        
        public MainSyntax Main(QualifierSyntax name, MetaDslx.CodeAnalysis.SyntaxList<UsingSyntax> @using, DeclarationsSyntax declarations)
        {
        	return this.Main(this.Token(CompilerSyntaxKind.KNamespace), name, this.Token(CompilerSyntaxKind.TSemicolon), @using, declarations, this.Token(CompilerSyntaxKind.Eof));
        }

        public UsingSyntax Using(SyntaxToken kUsing, QualifierSyntax namespaces, SyntaxToken tSemicolon)
        {
        	if (kUsing.RawKind != (int)CompilerSyntaxKind.KUsing) throw new ArgumentException(nameof(kUsing));
        	if (namespaces is null) throw new ArgumentNullException(nameof(namespaces));
        	if (tSemicolon.RawKind != (int)CompilerSyntaxKind.TSemicolon) throw new ArgumentException(nameof(tSemicolon));
            return (UsingSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.Using((InternalSyntaxToken)kUsing.Node, (QualifierGreen)namespaces.Green, (InternalSyntaxToken)tSemicolon.Node).CreateRed();
        }
        
        public UsingSyntax Using(QualifierSyntax namespaces)
        {
        	return this.Using(this.Token(CompilerSyntaxKind.KUsing), namespaces, this.Token(CompilerSyntaxKind.TSemicolon));
        }

        public DeclarationsSyntax Declarations(LanguageDeclarationSyntax declarations, MetaDslx.CodeAnalysis.SyntaxList<RuleSyntax> declarations1)
        {
        	if (declarations is null) throw new ArgumentNullException(nameof(declarations));
            return (DeclarationsSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.Declarations((LanguageDeclarationGreen)declarations.Green, declarations1.Node.ToGreenList<RuleGreen>()).CreateRed();
        }

        public LanguageDeclarationSyntax LanguageDeclaration(SyntaxToken kLanguage, NameSyntax name, SyntaxToken tSemicolon, GrammarSyntax grammar)
        {
        	if (kLanguage.RawKind != (int)CompilerSyntaxKind.KLanguage) throw new ArgumentException(nameof(kLanguage));
        	if (name is null) throw new ArgumentNullException(nameof(name));
        	if (tSemicolon.RawKind != (int)CompilerSyntaxKind.TSemicolon) throw new ArgumentException(nameof(tSemicolon));
        	if (grammar is null) throw new ArgumentNullException(nameof(grammar));
            return (LanguageDeclarationSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.LanguageDeclaration((InternalSyntaxToken)kLanguage.Node, (NameGreen)name.Green, (InternalSyntaxToken)tSemicolon.Node, (GrammarGreen)grammar.Green).CreateRed();
        }
        
        public LanguageDeclarationSyntax LanguageDeclaration(NameSyntax name, GrammarSyntax grammar)
        {
        	return this.LanguageDeclaration(this.Token(CompilerSyntaxKind.KLanguage), name, this.Token(CompilerSyntaxKind.TSemicolon), grammar);
        }

        public GrammarSyntax Grammar(GrammarBlock1Syntax grammarBlock1)
        {
        	if (grammarBlock1 is null) throw new ArgumentNullException(nameof(grammarBlock1));
            return (GrammarSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.Grammar((GrammarBlock1Green)grammarBlock1.Green).CreateRed();
        }

        public GrammarRuleAlt1Syntax GrammarRuleAlt1(RuleSyntax rule)
        {
        	if (rule is null) throw new ArgumentNullException(nameof(rule));
            return (GrammarRuleAlt1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.GrammarRuleAlt1((RuleGreen)rule.Green).CreateRed();
        }

        public BlockSyntax Block(MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> annotations1, SyntaxToken kBlock, NameSyntax name, BlockBlock1Syntax blockBlock1, SyntaxToken tColon, MetaDslx.CodeAnalysis.SeparatedSyntaxList<AlternativeSyntax> alternativeList, SyntaxToken tSemicolon)
        {
        	if (kBlock.RawKind != (int)CompilerSyntaxKind.KBlock) throw new ArgumentException(nameof(kBlock));
        	if (name is null) throw new ArgumentNullException(nameof(name));
        	if (tColon.RawKind != (int)CompilerSyntaxKind.TColon) throw new ArgumentException(nameof(tColon));
        	if (tSemicolon.RawKind != (int)CompilerSyntaxKind.TSemicolon) throw new ArgumentException(nameof(tSemicolon));
            return (BlockSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.Block(annotations1.Node.ToGreenList<ParserAnnotationGreen>(), (InternalSyntaxToken)kBlock.Node, (NameGreen)name.Green, (BlockBlock1Green?)blockBlock1?.Green, (InternalSyntaxToken)tColon.Node, alternativeList.Node.ToGreenSeparatedList<AlternativeGreen>(reversed: false), (InternalSyntaxToken)tSemicolon.Node).CreateRed();
        }
        
        public BlockSyntax Block(MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> annotations1, NameSyntax name, MetaDslx.CodeAnalysis.SeparatedSyntaxList<AlternativeSyntax> alternativeList)
        {
        	return this.Block(annotations1, this.Token(CompilerSyntaxKind.KBlock), name, default, this.Token(CompilerSyntaxKind.TColon), alternativeList, this.Token(CompilerSyntaxKind.TSemicolon));
        }

        public TokenSyntax Token(MetaDslx.CodeAnalysis.SyntaxList<LexerAnnotationSyntax> annotations1, TokenBlock1Syntax tokenBlock1, SyntaxToken tColon, MetaDslx.CodeAnalysis.SeparatedSyntaxList<LAlternativeSyntax> lAlternativeList, SyntaxToken tSemicolon)
        {
        	if (tokenBlock1 is null) throw new ArgumentNullException(nameof(tokenBlock1));
        	if (tColon.RawKind != (int)CompilerSyntaxKind.TColon) throw new ArgumentException(nameof(tColon));
        	if (tSemicolon.RawKind != (int)CompilerSyntaxKind.TSemicolon) throw new ArgumentException(nameof(tSemicolon));
            return (TokenSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.Token(annotations1.Node.ToGreenList<LexerAnnotationGreen>(), (TokenBlock1Green)tokenBlock1.Green, (InternalSyntaxToken)tColon.Node, lAlternativeList.Node.ToGreenSeparatedList<LAlternativeGreen>(reversed: false), (InternalSyntaxToken)tSemicolon.Node).CreateRed();
        }
        
        public TokenSyntax Token(MetaDslx.CodeAnalysis.SyntaxList<LexerAnnotationSyntax> annotations1, TokenBlock1Syntax tokenBlock1, MetaDslx.CodeAnalysis.SeparatedSyntaxList<LAlternativeSyntax> lAlternativeList)
        {
        	return this.Token(annotations1, tokenBlock1, this.Token(CompilerSyntaxKind.TColon), lAlternativeList, this.Token(CompilerSyntaxKind.TSemicolon));
        }

        public FragmentSyntax Fragment(SyntaxToken kFragment, NameSyntax name, SyntaxToken tColon, MetaDslx.CodeAnalysis.SeparatedSyntaxList<LAlternativeSyntax> lAlternativeList, SyntaxToken tSemicolon)
        {
        	if (kFragment.RawKind != (int)CompilerSyntaxKind.KFragment) throw new ArgumentException(nameof(kFragment));
        	if (name is null) throw new ArgumentNullException(nameof(name));
        	if (tColon.RawKind != (int)CompilerSyntaxKind.TColon) throw new ArgumentException(nameof(tColon));
        	if (tSemicolon.RawKind != (int)CompilerSyntaxKind.TSemicolon) throw new ArgumentException(nameof(tSemicolon));
            return (FragmentSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.Fragment((InternalSyntaxToken)kFragment.Node, (NameGreen)name.Green, (InternalSyntaxToken)tColon.Node, lAlternativeList.Node.ToGreenSeparatedList<LAlternativeGreen>(reversed: false), (InternalSyntaxToken)tSemicolon.Node).CreateRed();
        }
        
        public FragmentSyntax Fragment(NameSyntax name, MetaDslx.CodeAnalysis.SeparatedSyntaxList<LAlternativeSyntax> lAlternativeList)
        {
        	return this.Fragment(this.Token(CompilerSyntaxKind.KFragment), name, this.Token(CompilerSyntaxKind.TColon), lAlternativeList, this.Token(CompilerSyntaxKind.TSemicolon));
        }

        public RuleSyntax Rule(MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> annotations1, RuleBlock1Syntax ruleBlock1, SyntaxToken tColon, MetaDslx.CodeAnalysis.SeparatedSyntaxList<AlternativeSyntax> alternativeList, SyntaxToken tSemicolon)
        {
        	if (ruleBlock1 is null) throw new ArgumentNullException(nameof(ruleBlock1));
        	if (tColon.RawKind != (int)CompilerSyntaxKind.TColon) throw new ArgumentException(nameof(tColon));
        	if (tSemicolon.RawKind != (int)CompilerSyntaxKind.TSemicolon) throw new ArgumentException(nameof(tSemicolon));
            return (RuleSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.Rule(annotations1.Node.ToGreenList<ParserAnnotationGreen>(), (RuleBlock1Green)ruleBlock1.Green, (InternalSyntaxToken)tColon.Node, alternativeList.Node.ToGreenSeparatedList<AlternativeGreen>(reversed: false), (InternalSyntaxToken)tSemicolon.Node).CreateRed();
        }
        
        public RuleSyntax Rule(MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> annotations1, RuleBlock1Syntax ruleBlock1, MetaDslx.CodeAnalysis.SeparatedSyntaxList<AlternativeSyntax> alternativeList)
        {
        	return this.Rule(annotations1, ruleBlock1, this.Token(CompilerSyntaxKind.TColon), alternativeList, this.Token(CompilerSyntaxKind.TSemicolon));
        }

        public AlternativeSyntax Alternative(AlternativeBlock1Syntax alternativeBlock1, MetaDslx.CodeAnalysis.SyntaxList<ElementSyntax> elements, AlternativeBlock2Syntax alternativeBlock2)
        {
            return (AlternativeSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.Alternative((AlternativeBlock1Green?)alternativeBlock1?.Green, elements.Node.ToGreenList<ElementGreen>(), (AlternativeBlock2Green?)alternativeBlock2?.Green).CreateRed();
        }
        
        public AlternativeSyntax Alternative(MetaDslx.CodeAnalysis.SyntaxList<ElementSyntax> elements)
        {
        	return this.Alternative(default, elements, default);
        }

        public ElementSyntax Element(ElementBlock1Syntax elementBlock1, MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> valueAnnotations, ElementValueSyntax value, SyntaxToken multiplicity)
        {
        	if (value is null) throw new ArgumentNullException(nameof(value));
        	if (multiplicity.RawKind != (int)CompilerSyntaxKind.TQuestion && multiplicity.RawKind != (int)CompilerSyntaxKind.TAsterisk && multiplicity.RawKind != (int)CompilerSyntaxKind.TPlus && multiplicity.RawKind != (int)CompilerSyntaxKind.TQuestionQuestion && multiplicity.RawKind != (int)CompilerSyntaxKind.TAsteriskQuestion && multiplicity.RawKind != (int)CompilerSyntaxKind.TPlusQuestion) throw new ArgumentException(nameof(multiplicity));
            return (ElementSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.Element((ElementBlock1Green?)elementBlock1?.Green, valueAnnotations.Node.ToGreenList<ParserAnnotationGreen>(), (ElementValueGreen)value.Green, (InternalSyntaxToken)multiplicity.Node).CreateRed();
        }
        
        public ElementSyntax Element(MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> valueAnnotations, ElementValueSyntax value)
        {
        	return this.Element(default, valueAnnotations, value, default);
        }

        public BlockInlineSyntax BlockInline(SyntaxToken tLParen, MetaDslx.CodeAnalysis.SeparatedSyntaxList<AlternativeSyntax> alternativeList, SyntaxToken tRParen)
        {
        	if (tLParen.RawKind != (int)CompilerSyntaxKind.TLParen) throw new ArgumentException(nameof(tLParen));
        	if (tRParen.RawKind != (int)CompilerSyntaxKind.TRParen) throw new ArgumentException(nameof(tRParen));
            return (BlockInlineSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.BlockInline((InternalSyntaxToken)tLParen.Node, alternativeList.Node.ToGreenSeparatedList<AlternativeGreen>(reversed: false), (InternalSyntaxToken)tRParen.Node).CreateRed();
        }
        
        public BlockInlineSyntax BlockInline(MetaDslx.CodeAnalysis.SeparatedSyntaxList<AlternativeSyntax> alternativeList)
        {
        	return this.BlockInline(this.Token(CompilerSyntaxKind.TLParen), alternativeList, this.Token(CompilerSyntaxKind.TRParen));
        }

        public Eof1Syntax Eof1(SyntaxToken kEof)
        {
        	if (kEof.RawKind != (int)CompilerSyntaxKind.KEof) throw new ArgumentException(nameof(kEof));
            return (Eof1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.Eof1((InternalSyntaxToken)kEof.Node).CreateRed();
        }
        
        public Eof1Syntax Eof1()
        {
        	return this.Eof1(this.Token(CompilerSyntaxKind.KEof));
        }

        public KeywordSyntax Keyword(SyntaxToken text)
        {
        	if (text.RawKind != (int)CompilerSyntaxKind.TString) throw new ArgumentException(nameof(text));
            return (KeywordSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.Keyword((InternalSyntaxToken)text.Node).CreateRed();
        }

        public RuleRefAlt1Syntax RuleRefAlt1(IdentifierSyntax grammarRule)
        {
        	if (grammarRule is null) throw new ArgumentNullException(nameof(grammarRule));
            return (RuleRefAlt1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.RuleRefAlt1((IdentifierGreen)grammarRule.Green).CreateRed();
        }

        public RuleRefAlt2Syntax RuleRefAlt2(SyntaxToken tHash, ReturnTypeQualifierSyntax referencedTypes)
        {
        	if (tHash.RawKind != (int)CompilerSyntaxKind.THash) throw new ArgumentException(nameof(tHash));
        	if (referencedTypes is null) throw new ArgumentNullException(nameof(referencedTypes));
            return (RuleRefAlt2Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.RuleRefAlt2((InternalSyntaxToken)tHash.Node, (ReturnTypeQualifierGreen)referencedTypes.Green).CreateRed();
        }
        
        public RuleRefAlt2Syntax RuleRefAlt2(ReturnTypeQualifierSyntax referencedTypes)
        {
        	return this.RuleRefAlt2(this.Token(CompilerSyntaxKind.THash), referencedTypes);
        }

        public RuleRefAlt3Syntax RuleRefAlt3(SyntaxToken tHashLBrace, MetaDslx.CodeAnalysis.SeparatedSyntaxList<ReturnTypeQualifierSyntax> returnTypeQualifierList, SyntaxToken tRBrace)
        {
        	if (tHashLBrace.RawKind != (int)CompilerSyntaxKind.THashLBrace) throw new ArgumentException(nameof(tHashLBrace));
        	if (tRBrace.RawKind != (int)CompilerSyntaxKind.TRBrace) throw new ArgumentException(nameof(tRBrace));
            return (RuleRefAlt3Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.RuleRefAlt3((InternalSyntaxToken)tHashLBrace.Node, returnTypeQualifierList.Node.ToGreenSeparatedList<ReturnTypeQualifierGreen>(reversed: false), (InternalSyntaxToken)tRBrace.Node).CreateRed();
        }
        
        public RuleRefAlt3Syntax RuleRefAlt3(MetaDslx.CodeAnalysis.SeparatedSyntaxList<ReturnTypeQualifierSyntax> returnTypeQualifierList)
        {
        	return this.RuleRefAlt3(this.Token(CompilerSyntaxKind.THashLBrace), returnTypeQualifierList, this.Token(CompilerSyntaxKind.TRBrace));
        }

        public LAlternativeSyntax LAlternative(MetaDslx.CodeAnalysis.SyntaxList<LElementSyntax> elements)
        {
            return (LAlternativeSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.LAlternative(elements.Node.ToGreenList<LElementGreen>()).CreateRed();
        }

        public LElementSyntax LElement(SyntaxToken isNegated, LElementValueSyntax value, SyntaxToken multiplicity)
        {
        	if (isNegated.RawKind != (int)CompilerSyntaxKind.TTilde) throw new ArgumentException(nameof(isNegated));
        	if (value is null) throw new ArgumentNullException(nameof(value));
        	if (multiplicity.RawKind != (int)CompilerSyntaxKind.TQuestion && multiplicity.RawKind != (int)CompilerSyntaxKind.TAsterisk && multiplicity.RawKind != (int)CompilerSyntaxKind.TPlus && multiplicity.RawKind != (int)CompilerSyntaxKind.TQuestionQuestion && multiplicity.RawKind != (int)CompilerSyntaxKind.TAsteriskQuestion && multiplicity.RawKind != (int)CompilerSyntaxKind.TPlusQuestion) throw new ArgumentException(nameof(multiplicity));
            return (LElementSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.LElement((InternalSyntaxToken)isNegated.Node, (LElementValueGreen)value.Green, (InternalSyntaxToken)multiplicity.Node).CreateRed();
        }
        
        public LElementSyntax LElement(LElementValueSyntax value)
        {
        	return this.LElement(default, value, default);
        }

        public LBlockSyntax LBlock(SyntaxToken tLParen, MetaDslx.CodeAnalysis.SeparatedSyntaxList<LAlternativeSyntax> lAlternativeList, SyntaxToken tRParen)
        {
        	if (tLParen.RawKind != (int)CompilerSyntaxKind.TLParen) throw new ArgumentException(nameof(tLParen));
        	if (tRParen.RawKind != (int)CompilerSyntaxKind.TRParen) throw new ArgumentException(nameof(tRParen));
            return (LBlockSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.LBlock((InternalSyntaxToken)tLParen.Node, lAlternativeList.Node.ToGreenSeparatedList<LAlternativeGreen>(reversed: false), (InternalSyntaxToken)tRParen.Node).CreateRed();
        }
        
        public LBlockSyntax LBlock(MetaDslx.CodeAnalysis.SeparatedSyntaxList<LAlternativeSyntax> lAlternativeList)
        {
        	return this.LBlock(this.Token(CompilerSyntaxKind.TLParen), lAlternativeList, this.Token(CompilerSyntaxKind.TRParen));
        }

        public LFixedSyntax LFixed(SyntaxToken text)
        {
        	if (text.RawKind != (int)CompilerSyntaxKind.TString) throw new ArgumentException(nameof(text));
            return (LFixedSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.LFixed((InternalSyntaxToken)text.Node).CreateRed();
        }

        public LWildCardSyntax LWildCard(SyntaxToken tDot)
        {
        	if (tDot.RawKind != (int)CompilerSyntaxKind.TDot) throw new ArgumentException(nameof(tDot));
            return (LWildCardSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.LWildCard((InternalSyntaxToken)tDot.Node).CreateRed();
        }
        
        public LWildCardSyntax LWildCard()
        {
        	return this.LWildCard(this.Token(CompilerSyntaxKind.TDot));
        }

        public LRangeSyntax LRange(SyntaxToken startChar, SyntaxToken tDotDot, SyntaxToken endChar)
        {
        	if (startChar.RawKind != (int)CompilerSyntaxKind.TString) throw new ArgumentException(nameof(startChar));
        	if (tDotDot.RawKind != (int)CompilerSyntaxKind.TDotDot) throw new ArgumentException(nameof(tDotDot));
        	if (endChar.RawKind != (int)CompilerSyntaxKind.TString) throw new ArgumentException(nameof(endChar));
            return (LRangeSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.LRange((InternalSyntaxToken)startChar.Node, (InternalSyntaxToken)tDotDot.Node, (InternalSyntaxToken)endChar.Node).CreateRed();
        }
        
        public LRangeSyntax LRange(SyntaxToken startChar, SyntaxToken endChar)
        {
        	return this.LRange(startChar, this.Token(CompilerSyntaxKind.TDotDot), endChar);
        }

        public LReferenceSyntax LReference(IdentifierSyntax rule)
        {
        	if (rule is null) throw new ArgumentNullException(nameof(rule));
            return (LReferenceSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.LReference((IdentifierGreen)rule.Green).CreateRed();
        }

        public ExpressionAlt1Syntax ExpressionAlt1(SingleExpressionSyntax singleExpression)
        {
        	if (singleExpression is null) throw new ArgumentNullException(nameof(singleExpression));
            return (ExpressionAlt1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.ExpressionAlt1((SingleExpressionGreen)singleExpression.Green).CreateRed();
        }

        public ArrayExpressionSyntax ArrayExpression(SyntaxToken tLBrace, ArrayExpressionBlock1Syntax arrayExpressionBlock1, SyntaxToken tRBrace)
        {
        	if (tLBrace.RawKind != (int)CompilerSyntaxKind.TLBrace) throw new ArgumentException(nameof(tLBrace));
        	if (tRBrace.RawKind != (int)CompilerSyntaxKind.TRBrace) throw new ArgumentException(nameof(tRBrace));
            return (ArrayExpressionSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.ArrayExpression((InternalSyntaxToken)tLBrace.Node, (ArrayExpressionBlock1Green?)arrayExpressionBlock1?.Green, (InternalSyntaxToken)tRBrace.Node).CreateRed();
        }
        
        public ArrayExpressionSyntax ArrayExpression()
        {
        	return this.ArrayExpression(this.Token(CompilerSyntaxKind.TLBrace), default, this.Token(CompilerSyntaxKind.TRBrace));
        }

        public SingleExpressionSyntax SingleExpression(SingleExpressionBlock1Syntax value)
        {
        	if (value is null) throw new ArgumentNullException(nameof(value));
            return (SingleExpressionSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.SingleExpression((SingleExpressionBlock1Green)value.Green).CreateRed();
        }

        public ParserAnnotationSyntax ParserAnnotation(SyntaxToken tLBracket, QualifierSyntax attributeClass, AnnotationArgumentsSyntax annotationArguments, SyntaxToken tRBracket)
        {
        	if (tLBracket.RawKind != (int)CompilerSyntaxKind.TLBracket) throw new ArgumentException(nameof(tLBracket));
        	if (attributeClass is null) throw new ArgumentNullException(nameof(attributeClass));
        	if (tRBracket.RawKind != (int)CompilerSyntaxKind.TRBracket) throw new ArgumentException(nameof(tRBracket));
            return (ParserAnnotationSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.ParserAnnotation((InternalSyntaxToken)tLBracket.Node, (QualifierGreen)attributeClass.Green, (AnnotationArgumentsGreen?)annotationArguments?.Green, (InternalSyntaxToken)tRBracket.Node).CreateRed();
        }
        
        public ParserAnnotationSyntax ParserAnnotation(QualifierSyntax attributeClass)
        {
        	return this.ParserAnnotation(this.Token(CompilerSyntaxKind.TLBracket), attributeClass, default, this.Token(CompilerSyntaxKind.TRBracket));
        }

        public LexerAnnotationSyntax LexerAnnotation(SyntaxToken tLBracket, QualifierSyntax attributeClass, AnnotationArgumentsSyntax annotationArguments, SyntaxToken tRBracket)
        {
        	if (tLBracket.RawKind != (int)CompilerSyntaxKind.TLBracket) throw new ArgumentException(nameof(tLBracket));
        	if (attributeClass is null) throw new ArgumentNullException(nameof(attributeClass));
        	if (tRBracket.RawKind != (int)CompilerSyntaxKind.TRBracket) throw new ArgumentException(nameof(tRBracket));
            return (LexerAnnotationSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.LexerAnnotation((InternalSyntaxToken)tLBracket.Node, (QualifierGreen)attributeClass.Green, (AnnotationArgumentsGreen?)annotationArguments?.Green, (InternalSyntaxToken)tRBracket.Node).CreateRed();
        }
        
        public LexerAnnotationSyntax LexerAnnotation(QualifierSyntax attributeClass)
        {
        	return this.LexerAnnotation(this.Token(CompilerSyntaxKind.TLBracket), attributeClass, default, this.Token(CompilerSyntaxKind.TRBracket));
        }

        public AnnotationArgumentsSyntax AnnotationArguments(SyntaxToken tLParen, MetaDslx.CodeAnalysis.SeparatedSyntaxList<AnnotationArgumentSyntax> annotationArgumentList, SyntaxToken tRParen)
        {
        	if (tLParen.RawKind != (int)CompilerSyntaxKind.TLParen) throw new ArgumentException(nameof(tLParen));
        	if (tRParen.RawKind != (int)CompilerSyntaxKind.TRParen) throw new ArgumentException(nameof(tRParen));
            return (AnnotationArgumentsSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.AnnotationArguments((InternalSyntaxToken)tLParen.Node, annotationArgumentList.Node.ToGreenSeparatedList<AnnotationArgumentGreen>(reversed: false), (InternalSyntaxToken)tRParen.Node).CreateRed();
        }
        
        public AnnotationArgumentsSyntax AnnotationArguments(MetaDslx.CodeAnalysis.SeparatedSyntaxList<AnnotationArgumentSyntax> annotationArgumentList)
        {
        	return this.AnnotationArguments(this.Token(CompilerSyntaxKind.TLParen), annotationArgumentList, this.Token(CompilerSyntaxKind.TRParen));
        }

        public AnnotationArgumentSyntax AnnotationArgument(AnnotationArgumentBlock1Syntax annotationArgumentBlock1, ExpressionSyntax value)
        {
        	if (value is null) throw new ArgumentNullException(nameof(value));
            return (AnnotationArgumentSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.AnnotationArgument((AnnotationArgumentBlock1Green?)annotationArgumentBlock1?.Green, (ExpressionGreen)value.Green).CreateRed();
        }
        
        public AnnotationArgumentSyntax AnnotationArgument(ExpressionSyntax value)
        {
        	return this.AnnotationArgument(default, value);
        }

        public ReturnTypeIdentifierAlt1Syntax ReturnTypeIdentifierAlt1(SyntaxToken tPrimitiveType)
        {
        	if (tPrimitiveType.RawKind != (int)CompilerSyntaxKind.TPrimitiveType) throw new ArgumentException(nameof(tPrimitiveType));
            return (ReturnTypeIdentifierAlt1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.ReturnTypeIdentifierAlt1((InternalSyntaxToken)tPrimitiveType.Node).CreateRed();
        }

        public ReturnTypeIdentifierAlt2Syntax ReturnTypeIdentifierAlt2(IdentifierSyntax identifier)
        {
        	if (identifier is null) throw new ArgumentNullException(nameof(identifier));
            return (ReturnTypeIdentifierAlt2Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.ReturnTypeIdentifierAlt2((IdentifierGreen)identifier.Green).CreateRed();
        }

        public ReturnTypeQualifierAlt1Syntax ReturnTypeQualifierAlt1(SyntaxToken tPrimitiveType)
        {
        	if (tPrimitiveType.RawKind != (int)CompilerSyntaxKind.TPrimitiveType) throw new ArgumentException(nameof(tPrimitiveType));
            return (ReturnTypeQualifierAlt1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.ReturnTypeQualifierAlt1((InternalSyntaxToken)tPrimitiveType.Node).CreateRed();
        }

        public ReturnTypeQualifierAlt2Syntax ReturnTypeQualifierAlt2(QualifierSyntax qualifier)
        {
        	if (qualifier is null) throw new ArgumentNullException(nameof(qualifier));
            return (ReturnTypeQualifierAlt2Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.ReturnTypeQualifierAlt2((QualifierGreen)qualifier.Green).CreateRed();
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

        public IdentifierAlt1Syntax IdentifierAlt1(SyntaxToken tIdentifier)
        {
        	if (tIdentifier.RawKind != (int)CompilerSyntaxKind.TIdentifier) throw new ArgumentException(nameof(tIdentifier));
            return (IdentifierAlt1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.IdentifierAlt1((InternalSyntaxToken)tIdentifier.Node).CreateRed();
        }

        public IdentifierAlt2Syntax IdentifierAlt2(SyntaxToken tVerbatimIdentifier)
        {
        	if (tVerbatimIdentifier.RawKind != (int)CompilerSyntaxKind.TVerbatimIdentifier) throw new ArgumentException(nameof(tVerbatimIdentifier));
            return (IdentifierAlt2Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.IdentifierAlt2((InternalSyntaxToken)tVerbatimIdentifier.Node).CreateRed();
        }

        public SimpleQualifierSyntax SimpleQualifier(MetaDslx.CodeAnalysis.SeparatedSyntaxList<SimpleIdentifierSyntax> simpleIdentifierList)
        {
            return (SimpleQualifierSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.SimpleQualifier(simpleIdentifierList.Node.ToGreenSeparatedList<SimpleIdentifierGreen>(reversed: false)).CreateRed();
        }

        public SimpleIdentifierSyntax SimpleIdentifier(SyntaxToken tIdentifier)
        {
        	if (tIdentifier.RawKind != (int)CompilerSyntaxKind.TIdentifier) throw new ArgumentException(nameof(tIdentifier));
            return (SimpleIdentifierSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.SimpleIdentifier((InternalSyntaxToken)tIdentifier.Node).CreateRed();
        }

        public GrammarBlock1Syntax GrammarBlock1(MetaDslx.CodeAnalysis.SyntaxList<GrammarRuleSyntax> grammarRules)
        {
            return (GrammarBlock1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.GrammarBlock1(grammarRules.Node.ToGreenList<GrammarRuleGreen>()).CreateRed();
        }

        public RuleBlock1Alt1Syntax RuleBlock1Alt1(ReturnTypeIdentifierSyntax returnType)
        {
        	if (returnType is null) throw new ArgumentNullException(nameof(returnType));
            return (RuleBlock1Alt1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.RuleBlock1Alt1((ReturnTypeIdentifierGreen)returnType.Green).CreateRed();
        }

        public RuleBlock1Alt2Syntax RuleBlock1Alt2(IdentifierSyntax identifier, SyntaxToken kReturns, ReturnTypeQualifierSyntax returnType)
        {
        	if (identifier is null) throw new ArgumentNullException(nameof(identifier));
        	if (kReturns.RawKind != (int)CompilerSyntaxKind.KReturns) throw new ArgumentException(nameof(kReturns));
        	if (returnType is null) throw new ArgumentNullException(nameof(returnType));
            return (RuleBlock1Alt2Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.RuleBlock1Alt2((IdentifierGreen)identifier.Green, (InternalSyntaxToken)kReturns.Node, (ReturnTypeQualifierGreen)returnType.Green).CreateRed();
        }
        
        public RuleBlock1Alt2Syntax RuleBlock1Alt2(IdentifierSyntax identifier, ReturnTypeQualifierSyntax returnType)
        {
        	return this.RuleBlock1Alt2(identifier, this.Token(CompilerSyntaxKind.KReturns), returnType);
        }

        public RuleBlock2Syntax RuleBlock2(SyntaxToken tBar, AlternativeSyntax alternatives)
        {
        	if (tBar.RawKind != (int)CompilerSyntaxKind.TBar) throw new ArgumentException(nameof(tBar));
        	if (alternatives is null) throw new ArgumentNullException(nameof(alternatives));
            return (RuleBlock2Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.RuleBlock2((InternalSyntaxToken)tBar.Node, (AlternativeGreen)alternatives.Green).CreateRed();
        }
        
        public RuleBlock2Syntax RuleBlock2(AlternativeSyntax alternatives)
        {
        	return this.RuleBlock2(this.Token(CompilerSyntaxKind.TBar), alternatives);
        }

        public BlockBlock1Syntax BlockBlock1(SyntaxToken kReturns, ReturnTypeQualifierSyntax returnType)
        {
        	if (kReturns.RawKind != (int)CompilerSyntaxKind.KReturns) throw new ArgumentException(nameof(kReturns));
        	if (returnType is null) throw new ArgumentNullException(nameof(returnType));
            return (BlockBlock1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.BlockBlock1((InternalSyntaxToken)kReturns.Node, (ReturnTypeQualifierGreen)returnType.Green).CreateRed();
        }
        
        public BlockBlock1Syntax BlockBlock1(ReturnTypeQualifierSyntax returnType)
        {
        	return this.BlockBlock1(this.Token(CompilerSyntaxKind.KReturns), returnType);
        }

        public BlockBlock2Syntax BlockBlock2(SyntaxToken tBar, AlternativeSyntax alternatives)
        {
        	if (tBar.RawKind != (int)CompilerSyntaxKind.TBar) throw new ArgumentException(nameof(tBar));
        	if (alternatives is null) throw new ArgumentNullException(nameof(alternatives));
            return (BlockBlock2Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.BlockBlock2((InternalSyntaxToken)tBar.Node, (AlternativeGreen)alternatives.Green).CreateRed();
        }
        
        public BlockBlock2Syntax BlockBlock2(AlternativeSyntax alternatives)
        {
        	return this.BlockBlock2(this.Token(CompilerSyntaxKind.TBar), alternatives);
        }

        public BlockInlineBlock1Syntax BlockInlineBlock1(SyntaxToken tBar, AlternativeSyntax alternatives)
        {
        	if (tBar.RawKind != (int)CompilerSyntaxKind.TBar) throw new ArgumentException(nameof(tBar));
        	if (alternatives is null) throw new ArgumentNullException(nameof(alternatives));
            return (BlockInlineBlock1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.BlockInlineBlock1((InternalSyntaxToken)tBar.Node, (AlternativeGreen)alternatives.Green).CreateRed();
        }
        
        public BlockInlineBlock1Syntax BlockInlineBlock1(AlternativeSyntax alternatives)
        {
        	return this.BlockInlineBlock1(this.Token(CompilerSyntaxKind.TBar), alternatives);
        }

        public AlternativeBlock1Syntax AlternativeBlock1(MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> annotations1, SyntaxToken kAlt, NameSyntax name, AlternativeBlock1Block1Syntax alternativeBlock1Block1, SyntaxToken tColon)
        {
        	if (kAlt.RawKind != (int)CompilerSyntaxKind.KAlt) throw new ArgumentException(nameof(kAlt));
        	if (name is null) throw new ArgumentNullException(nameof(name));
        	if (tColon.RawKind != (int)CompilerSyntaxKind.TColon) throw new ArgumentException(nameof(tColon));
            return (AlternativeBlock1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.AlternativeBlock1(annotations1.Node.ToGreenList<ParserAnnotationGreen>(), (InternalSyntaxToken)kAlt.Node, (NameGreen)name.Green, (AlternativeBlock1Block1Green?)alternativeBlock1Block1?.Green, (InternalSyntaxToken)tColon.Node).CreateRed();
        }
        
        public AlternativeBlock1Syntax AlternativeBlock1(MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> annotations1, NameSyntax name)
        {
        	return this.AlternativeBlock1(annotations1, this.Token(CompilerSyntaxKind.KAlt), name, default, this.Token(CompilerSyntaxKind.TColon));
        }

        public AlternativeBlock2Syntax AlternativeBlock2(SyntaxToken tEqGt, ExpressionSyntax returnValue)
        {
        	if (tEqGt.RawKind != (int)CompilerSyntaxKind.TEqGt) throw new ArgumentException(nameof(tEqGt));
        	if (returnValue is null) throw new ArgumentNullException(nameof(returnValue));
            return (AlternativeBlock2Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.AlternativeBlock2((InternalSyntaxToken)tEqGt.Node, (ExpressionGreen)returnValue.Green).CreateRed();
        }
        
        public AlternativeBlock2Syntax AlternativeBlock2(ExpressionSyntax returnValue)
        {
        	return this.AlternativeBlock2(this.Token(CompilerSyntaxKind.TEqGt), returnValue);
        }

        public ElementBlock1Syntax ElementBlock1(MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> nameAnnotations, IdentifierSyntax symbolProperty, SyntaxToken assignment)
        {
        	if (symbolProperty is null) throw new ArgumentNullException(nameof(symbolProperty));
        	if (assignment.RawKind != (int)CompilerSyntaxKind.TEq && assignment.RawKind != (int)CompilerSyntaxKind.TQuestionEq && assignment.RawKind != (int)CompilerSyntaxKind.TExclEq && assignment.RawKind != (int)CompilerSyntaxKind.TPlusEq) throw new ArgumentException(nameof(assignment));
            return (ElementBlock1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.ElementBlock1(nameAnnotations.Node.ToGreenList<ParserAnnotationGreen>(), (IdentifierGreen)symbolProperty.Green, (InternalSyntaxToken)assignment.Node).CreateRed();
        }

        public RuleRefAlt3Block1Syntax RuleRefAlt3Block1(SyntaxToken tComma, ReturnTypeQualifierSyntax referencedTypes)
        {
        	if (tComma.RawKind != (int)CompilerSyntaxKind.TComma) throw new ArgumentException(nameof(tComma));
        	if (referencedTypes is null) throw new ArgumentNullException(nameof(referencedTypes));
            return (RuleRefAlt3Block1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.RuleRefAlt3Block1((InternalSyntaxToken)tComma.Node, (ReturnTypeQualifierGreen)referencedTypes.Green).CreateRed();
        }
        
        public RuleRefAlt3Block1Syntax RuleRefAlt3Block1(ReturnTypeQualifierSyntax referencedTypes)
        {
        	return this.RuleRefAlt3Block1(this.Token(CompilerSyntaxKind.TComma), referencedTypes);
        }

        public TokenBlock1Alt1Syntax TokenBlock1Alt1(SyntaxToken kToken, NameSyntax name, TokenBlock1Alt1Block1Syntax tokenBlock1Alt1Block1)
        {
        	if (kToken.RawKind != (int)CompilerSyntaxKind.KToken) throw new ArgumentException(nameof(kToken));
        	if (name is null) throw new ArgumentNullException(nameof(name));
            return (TokenBlock1Alt1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.TokenBlock1Alt1((InternalSyntaxToken)kToken.Node, (NameGreen)name.Green, (TokenBlock1Alt1Block1Green?)tokenBlock1Alt1Block1?.Green).CreateRed();
        }
        
        public TokenBlock1Alt1Syntax TokenBlock1Alt1(NameSyntax name)
        {
        	return this.TokenBlock1Alt1(this.Token(CompilerSyntaxKind.KToken), name, default);
        }

        public TokenBlock1Alt2Syntax TokenBlock1Alt2(SyntaxToken isTrivia1, NameSyntax name)
        {
        	if (isTrivia1.RawKind != (int)CompilerSyntaxKind.KHidden) throw new ArgumentException(nameof(isTrivia1));
        	if (name is null) throw new ArgumentNullException(nameof(name));
            return (TokenBlock1Alt2Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.TokenBlock1Alt2((InternalSyntaxToken)isTrivia1.Node, (NameGreen)name.Green).CreateRed();
        }
        
        public TokenBlock1Alt2Syntax TokenBlock1Alt2(NameSyntax name)
        {
        	return this.TokenBlock1Alt2(this.Token(CompilerSyntaxKind.KHidden), name);
        }

        public TokenBlock2Syntax TokenBlock2(SyntaxToken tBar, LAlternativeSyntax alternatives)
        {
        	if (tBar.RawKind != (int)CompilerSyntaxKind.TBar) throw new ArgumentException(nameof(tBar));
        	if (alternatives is null) throw new ArgumentNullException(nameof(alternatives));
            return (TokenBlock2Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.TokenBlock2((InternalSyntaxToken)tBar.Node, (LAlternativeGreen)alternatives.Green).CreateRed();
        }
        
        public TokenBlock2Syntax TokenBlock2(LAlternativeSyntax alternatives)
        {
        	return this.TokenBlock2(this.Token(CompilerSyntaxKind.TBar), alternatives);
        }

        public FragmentBlock1Syntax FragmentBlock1(SyntaxToken tBar, LAlternativeSyntax alternatives)
        {
        	if (tBar.RawKind != (int)CompilerSyntaxKind.TBar) throw new ArgumentException(nameof(tBar));
        	if (alternatives is null) throw new ArgumentNullException(nameof(alternatives));
            return (FragmentBlock1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.FragmentBlock1((InternalSyntaxToken)tBar.Node, (LAlternativeGreen)alternatives.Green).CreateRed();
        }
        
        public FragmentBlock1Syntax FragmentBlock1(LAlternativeSyntax alternatives)
        {
        	return this.FragmentBlock1(this.Token(CompilerSyntaxKind.TBar), alternatives);
        }

        public LBlockBlock1Syntax LBlockBlock1(SyntaxToken tBar, LAlternativeSyntax alternatives)
        {
        	if (tBar.RawKind != (int)CompilerSyntaxKind.TBar) throw new ArgumentException(nameof(tBar));
        	if (alternatives is null) throw new ArgumentNullException(nameof(alternatives));
            return (LBlockBlock1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.LBlockBlock1((InternalSyntaxToken)tBar.Node, (LAlternativeGreen)alternatives.Green).CreateRed();
        }
        
        public LBlockBlock1Syntax LBlockBlock1(LAlternativeSyntax alternatives)
        {
        	return this.LBlockBlock1(this.Token(CompilerSyntaxKind.TBar), alternatives);
        }

        public SingleExpressionBlock1Alt4Syntax SingleExpressionBlock1Alt4(SyntaxToken tInteger)
        {
        	if (tInteger.RawKind != (int)CompilerSyntaxKind.TInteger) throw new ArgumentException(nameof(tInteger));
            return (SingleExpressionBlock1Alt4Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.SingleExpressionBlock1Alt4((InternalSyntaxToken)tInteger.Node).CreateRed();
        }

        public SingleExpressionBlock1Alt5Syntax SingleExpressionBlock1Alt5(SyntaxToken tString)
        {
        	if (tString.RawKind != (int)CompilerSyntaxKind.TString) throw new ArgumentException(nameof(tString));
            return (SingleExpressionBlock1Alt5Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.SingleExpressionBlock1Alt5((InternalSyntaxToken)tString.Node).CreateRed();
        }

        public SingleExpressionBlock1Alt6Syntax SingleExpressionBlock1Alt6(SimpleQualifierSyntax simpleQualifier)
        {
        	if (simpleQualifier is null) throw new ArgumentNullException(nameof(simpleQualifier));
            return (SingleExpressionBlock1Alt6Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.SingleExpressionBlock1Alt6((SimpleQualifierGreen)simpleQualifier.Green).CreateRed();
        }

        public SingleExpressionBlock1TokensSyntax SingleExpressionBlock1Tokens(SyntaxToken tokens)
        {
        	if (tokens.RawKind != (int)CompilerSyntaxKind.KNull && tokens.RawKind != (int)CompilerSyntaxKind.KTrue && tokens.RawKind != (int)CompilerSyntaxKind.KFalse) throw new ArgumentException(nameof(tokens));
            return (SingleExpressionBlock1TokensSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.SingleExpressionBlock1Tokens((InternalSyntaxToken)tokens.Node).CreateRed();
        }

        public ArrayExpressionBlock1Syntax ArrayExpressionBlock1(MetaDslx.CodeAnalysis.SeparatedSyntaxList<SingleExpressionSyntax> singleExpressionList)
        {
            return (ArrayExpressionBlock1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.ArrayExpressionBlock1(singleExpressionList.Node.ToGreenSeparatedList<SingleExpressionGreen>(reversed: false)).CreateRed();
        }

        public AnnotationArgumentsBlock1Syntax AnnotationArgumentsBlock1(SyntaxToken tComma, AnnotationArgumentSyntax arguments)
        {
        	if (tComma.RawKind != (int)CompilerSyntaxKind.TComma) throw new ArgumentException(nameof(tComma));
        	if (arguments is null) throw new ArgumentNullException(nameof(arguments));
            return (AnnotationArgumentsBlock1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.AnnotationArgumentsBlock1((InternalSyntaxToken)tComma.Node, (AnnotationArgumentGreen)arguments.Green).CreateRed();
        }
        
        public AnnotationArgumentsBlock1Syntax AnnotationArgumentsBlock1(AnnotationArgumentSyntax arguments)
        {
        	return this.AnnotationArgumentsBlock1(this.Token(CompilerSyntaxKind.TComma), arguments);
        }

        public AnnotationArgumentBlock1Syntax AnnotationArgumentBlock1(IdentifierSyntax namedParameter, SyntaxToken tColon)
        {
        	if (namedParameter is null) throw new ArgumentNullException(nameof(namedParameter));
        	if (tColon.RawKind != (int)CompilerSyntaxKind.TColon) throw new ArgumentException(nameof(tColon));
            return (AnnotationArgumentBlock1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.AnnotationArgumentBlock1((IdentifierGreen)namedParameter.Green, (InternalSyntaxToken)tColon.Node).CreateRed();
        }
        
        public AnnotationArgumentBlock1Syntax AnnotationArgumentBlock1(IdentifierSyntax namedParameter)
        {
        	return this.AnnotationArgumentBlock1(namedParameter, this.Token(CompilerSyntaxKind.TColon));
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

        public SimpleQualifierBlock1Syntax SimpleQualifierBlock1(SyntaxToken tDot, SimpleIdentifierSyntax simpleIdentifier)
        {
        	if (tDot.RawKind != (int)CompilerSyntaxKind.TDot) throw new ArgumentException(nameof(tDot));
        	if (simpleIdentifier is null) throw new ArgumentNullException(nameof(simpleIdentifier));
            return (SimpleQualifierBlock1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.SimpleQualifierBlock1((InternalSyntaxToken)tDot.Node, (SimpleIdentifierGreen)simpleIdentifier.Green).CreateRed();
        }
        
        public SimpleQualifierBlock1Syntax SimpleQualifierBlock1(SimpleIdentifierSyntax simpleIdentifier)
        {
        	return this.SimpleQualifierBlock1(this.Token(CompilerSyntaxKind.TDot), simpleIdentifier);
        }

        public AlternativeBlock1Block1Syntax AlternativeBlock1Block1(SyntaxToken kReturns, ReturnTypeQualifierSyntax returnType)
        {
        	if (kReturns.RawKind != (int)CompilerSyntaxKind.KReturns) throw new ArgumentException(nameof(kReturns));
        	if (returnType is null) throw new ArgumentNullException(nameof(returnType));
            return (AlternativeBlock1Block1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.AlternativeBlock1Block1((InternalSyntaxToken)kReturns.Node, (ReturnTypeQualifierGreen)returnType.Green).CreateRed();
        }
        
        public AlternativeBlock1Block1Syntax AlternativeBlock1Block1(ReturnTypeQualifierSyntax returnType)
        {
        	return this.AlternativeBlock1Block1(this.Token(CompilerSyntaxKind.KReturns), returnType);
        }

        public TokenBlock1Alt1Block1Syntax TokenBlock1Alt1Block1(SyntaxToken kReturns, ReturnTypeQualifierSyntax returnType)
        {
        	if (kReturns.RawKind != (int)CompilerSyntaxKind.KReturns) throw new ArgumentException(nameof(kReturns));
        	if (returnType is null) throw new ArgumentNullException(nameof(returnType));
            return (TokenBlock1Alt1Block1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.TokenBlock1Alt1Block1((InternalSyntaxToken)kReturns.Node, (ReturnTypeQualifierGreen)returnType.Green).CreateRed();
        }
        
        public TokenBlock1Alt1Block1Syntax TokenBlock1Alt1Block1(ReturnTypeQualifierSyntax returnType)
        {
        	return this.TokenBlock1Alt1Block1(this.Token(CompilerSyntaxKind.KReturns), returnType);
        }

        public ArrayExpressionBlock1Block1Syntax ArrayExpressionBlock1Block1(SyntaxToken tComma, SingleExpressionSyntax items)
        {
        	if (tComma.RawKind != (int)CompilerSyntaxKind.TComma) throw new ArgumentException(nameof(tComma));
        	if (items is null) throw new ArgumentNullException(nameof(items));
            return (ArrayExpressionBlock1Block1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.ArrayExpressionBlock1Block1((InternalSyntaxToken)tComma.Node, (SingleExpressionGreen)items.Green).CreateRed();
        }
        
        public ArrayExpressionBlock1Block1Syntax ArrayExpressionBlock1Block1(SingleExpressionSyntax items)
        {
        	return this.ArrayExpressionBlock1Block1(this.Token(CompilerSyntaxKind.TComma), items);
        }
				

        internal static IEnumerable<Type> GetNodeTypes()
        {
            return new Type[] {
		        typeof(MainSyntax),
		        typeof(UsingSyntax),
		        typeof(DeclarationsSyntax),
		        typeof(LanguageDeclarationSyntax),
		        typeof(GrammarSyntax),
		        typeof(GrammarRuleAlt1Syntax),
		        typeof(BlockSyntax),
		        typeof(TokenSyntax),
		        typeof(FragmentSyntax),
		        typeof(RuleSyntax),
		        typeof(AlternativeSyntax),
		        typeof(ElementSyntax),
		        typeof(BlockInlineSyntax),
		        typeof(Eof1Syntax),
		        typeof(KeywordSyntax),
		        typeof(RuleRefAlt1Syntax),
		        typeof(RuleRefAlt2Syntax),
		        typeof(RuleRefAlt3Syntax),
		        typeof(LAlternativeSyntax),
		        typeof(LElementSyntax),
		        typeof(LBlockSyntax),
		        typeof(LFixedSyntax),
		        typeof(LWildCardSyntax),
		        typeof(LRangeSyntax),
		        typeof(LReferenceSyntax),
		        typeof(ExpressionAlt1Syntax),
		        typeof(ArrayExpressionSyntax),
		        typeof(SingleExpressionSyntax),
		        typeof(ParserAnnotationSyntax),
		        typeof(LexerAnnotationSyntax),
		        typeof(AnnotationArgumentsSyntax),
		        typeof(AnnotationArgumentSyntax),
		        typeof(ReturnTypeIdentifierAlt1Syntax),
		        typeof(ReturnTypeIdentifierAlt2Syntax),
		        typeof(ReturnTypeQualifierAlt1Syntax),
		        typeof(ReturnTypeQualifierAlt2Syntax),
		        typeof(NameSyntax),
		        typeof(QualifierSyntax),
		        typeof(QualifierListSyntax),
		        typeof(IdentifierAlt1Syntax),
		        typeof(IdentifierAlt2Syntax),
		        typeof(SimpleQualifierSyntax),
		        typeof(SimpleIdentifierSyntax),
		        typeof(GrammarBlock1Syntax),
		        typeof(RuleBlock1Alt1Syntax),
		        typeof(RuleBlock1Alt2Syntax),
		        typeof(RuleBlock2Syntax),
		        typeof(BlockBlock1Syntax),
		        typeof(BlockBlock2Syntax),
		        typeof(BlockInlineBlock1Syntax),
		        typeof(AlternativeBlock1Syntax),
		        typeof(AlternativeBlock2Syntax),
		        typeof(ElementBlock1Syntax),
		        typeof(RuleRefAlt3Block1Syntax),
		        typeof(TokenBlock1Alt1Syntax),
		        typeof(TokenBlock1Alt2Syntax),
		        typeof(TokenBlock2Syntax),
		        typeof(FragmentBlock1Syntax),
		        typeof(LBlockBlock1Syntax),
		        typeof(SingleExpressionBlock1Alt4Syntax),
		        typeof(SingleExpressionBlock1Alt5Syntax),
		        typeof(SingleExpressionBlock1Alt6Syntax),
		        typeof(SingleExpressionBlock1TokensSyntax),
		        typeof(ArrayExpressionBlock1Syntax),
		        typeof(AnnotationArgumentsBlock1Syntax),
		        typeof(AnnotationArgumentBlock1Syntax),
		        typeof(QualifierBlock1Syntax),
		        typeof(QualifierListBlock1Syntax),
		        typeof(SimpleQualifierBlock1Syntax),
		        typeof(AlternativeBlock1Block1Syntax),
		        typeof(TokenBlock1Alt1Block1Syntax),
		        typeof(ArrayExpressionBlock1Block1Syntax),
		    };
        }

    }
}	
