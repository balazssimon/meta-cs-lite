#nullable enable

namespace MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax
{
    using __Type = global::System.Type;
	using __Debug = global::System.Diagnostics.Debug;
    using __Encoding = global::System.Text.Encoding;
	using __Language = global::MetaDslx.CodeAnalysis.Language;
	using __ParseOptions = global::MetaDslx.CodeAnalysis.ParseOptions;
	using __DiagnosticInfo = global::MetaDslx.CodeAnalysis.DiagnosticInfo;
	using __SyntaxAnnotation = global::MetaDslx.CodeAnalysis.SyntaxAnnotation;
	using __SyntaxNodeCache = MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxNodeCache;
	using __IncrementalParseData = global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.IncrementalParseData;
	using __InternalSyntaxKind = global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.InternalSyntaxKind;
	using __InternalSyntaxToken = global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.InternalSyntaxToken;
    using __GreenNodeExtensions = MetaDslx.CodeAnalysis.Syntax.InternalSyntax.GreenNodeExtensions;
	using __SyntaxLexer = global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxLexer;
	using __SyntaxParser = global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxParser;
    using __SyntaxTree = global::MetaDslx.CodeAnalysis.SyntaxTree;
	using __SyntaxFacts = global::MetaDslx.CodeAnalysis.Syntax.SyntaxFacts;
	using __SyntaxToken = global::MetaDslx.CodeAnalysis.SyntaxToken;
	using __SyntaxTrivia = global::MetaDslx.CodeAnalysis.SyntaxTrivia;
    using __SyntaxTriviaList = global::MetaDslx.CodeAnalysis.SyntaxTriviaList;
	using __SyntaxNode = global::MetaDslx.CodeAnalysis.SyntaxNode;
	using __SourceText = global::MetaDslx.CodeAnalysis.Text.SourceText;
	using __TextChangeRange = global::MetaDslx.CodeAnalysis.Text.TextChangeRange;
    using __CancellationToken = global::System.Threading.CancellationToken;
	using __ArgumentNullException = global::System.ArgumentNullException;
    using __ArgumentException = global::System.ArgumentException;

	public class CompilerSyntaxFactory : global::MetaDslx.CodeAnalysis.Syntax.SyntaxFactory
	{
		public CompilerSyntaxFactory(global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.InternalSyntaxFactory internalSyntaxFactory) 
			: base(internalSyntaxFactory)
		{
		}
	    
        public override __Language Language => CompilerLanguage.Instance;

	    public override __ParseOptions DefaultParseOptions => CompilerParseOptions.Default;

		/// <summary>
		/// Create a new syntax tree from a syntax node.
		/// </summary>
		public CompilerSyntaxTree SyntaxTree(__SyntaxNode root, CompilerParseOptions? options = null, string? path = "", __Encoding? encoding = null)
		{
			return CompilerSyntaxTree.Create((CompilerSyntaxNode)root, __IncrementalParseData.Empty, options, path, null, encoding);
		}

		/// <summary>
		/// Produces a syntax tree by parsing the source text.
		/// </summary>
		public CompilerSyntaxTree ParseSyntaxTree(
			string text,
			CompilerParseOptions options = null,
			string path = "",
			__Encoding encoding = null,
			__CancellationToken cancellationToken = default)
		{
			return (CompilerSyntaxTree)this.ParseSyntaxTreeCore(__SourceText.From(text, encoding), options, path, cancellationToken);
		}

		/// <summary>
		/// Produces a syntax tree by parsing the source text.
		/// </summary>
		public CompilerSyntaxTree ParseSyntaxTree(
			__SourceText text,
			CompilerParseOptions? options = null,
			string path = "",
			__CancellationToken cancellationToken = default)
		{
			return (CompilerSyntaxTree)this.ParseSyntaxTreeCore(text, options, path, cancellationToken);
		}

		protected override __SyntaxTree ParseSyntaxTreeCore(
			__SourceText text,
			__ParseOptions? options = null,
			string path = "",
			__CancellationToken cancellationToken = default)
		{
			return CompilerSyntaxTree.ParseText(text, (CompilerParseOptions?)options, path, cancellationToken);
		}
	
		public override __SyntaxTree MakeSyntaxTree(__SyntaxNode root, __ParseOptions? options = null, string path = "", __Encoding? encoding = null)
		{
			return CompilerSyntaxTree.Create((CompilerSyntaxNode)root, __IncrementalParseData.Empty, (CompilerParseOptions)options, path, null, encoding);
		}

        /// <summary>
        /// Creates a token corresponding to a syntax kind. This method can be used for token syntax kinds whose text
        /// can be inferred by the kind alone.
        /// </summary>
        /// <param name="kind">A syntax kind value for a token. These have the suffix Token or Keyword.</param>
        /// <returns></returns>
        public virtual __SyntaxToken Token(CompilerSyntaxKind kind)
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
        public virtual __SyntaxToken Token(__SyntaxTriviaList leading, CompilerSyntaxKind kind, __SyntaxTriviaList trailing)
        {
            return this.Token(leading, (int)kind, trailing);
        }

        /// <summary>
        /// Creates a token corresponding to syntax kind. This method gives control over token Text and ValueText.
        /// 
        /// For example, consider the text '&lt;see cref="operator &amp;#43;"/&gt;'.  To create a token for the value of
        /// the operator symbol (&amp;#43;), one would call 
        /// Token(default(__SyntaxTriviaList), int.PlusToken, "&amp;#43;", "+", default(__SyntaxTriviaList)).
        /// </summary>
        /// <param name="leading">A list of trivia immediately preceding the token.</param>
        /// <param name="kind">A syntax kind value for a token. These have the suffix Token or Keyword.</param>
        /// <param name="text">The text from which this token was created (e.g. lexed).</param>
        /// <param name="valueText">How C# should interpret the text of this token.</param>
        /// <param name="trailing">A list of trivia immediately following the token.</param>
        public virtual __SyntaxToken Token(__SyntaxTriviaList leading, CompilerSyntaxKind kind, string text, string valueText, __SyntaxTriviaList trailing)
        {
            return this.Token(leading, (int)kind, text, valueText, trailing);
        }

        /// <summary>
        /// Creates a missing token corresponding to syntax kind. A missing token is produced by the parser when an
        /// expected token is not found. A missing token has no text and normally has associated diagnostics.
        /// </summary>
        /// <param name="kind">A syntax kind value for a token. These have the suffix Token or Keyword.</param>
        public virtual __SyntaxToken MissingToken(CompilerSyntaxKind kind)
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
        public virtual __SyntaxToken MissingToken(__SyntaxTriviaList leading, CompilerSyntaxKind kind, __SyntaxTriviaList trailing)
        {
            return this.MissingToken(leading, (int)kind, trailing);
        }


public __SyntaxToken TInteger(string text)
{
    return new __SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.TInteger(text));
}

public __SyntaxToken TInteger(string text, object value)
{
    return new __SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.TInteger(text, value));
}

public __SyntaxToken TDecimal(string text)
{
    return new __SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.TDecimal(text));
}

public __SyntaxToken TDecimal(string text, object value)
{
    return new __SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.TDecimal(text, value));
}

public __SyntaxToken TIdentifier(string text)
{
    return new __SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.TIdentifier(text));
}

public __SyntaxToken TIdentifier(string text, object value)
{
    return new __SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.TIdentifier(text, value));
}

public __SyntaxToken TVerbatimIdentifier(string text)
{
    return new __SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.TVerbatimIdentifier(text));
}

public __SyntaxToken TVerbatimIdentifier(string text, object value)
{
    return new __SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.TVerbatimIdentifier(text, value));
}

public __SyntaxToken TString(string text)
{
    return new __SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.TString(text));
}

public __SyntaxToken TString(string text, object value)
{
    return new __SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.TString(text, value));
}

public __SyntaxToken TWhitespace(string text)
{
    return new __SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.TWhitespace(text));
}

public __SyntaxToken TWhitespace(string text, object value)
{
    return new __SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.TWhitespace(text, value));
}

public __SyntaxToken TLineEnd(string text)
{
    return new __SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.TLineEnd(text));
}

public __SyntaxToken TLineEnd(string text, object value)
{
    return new __SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.TLineEnd(text, value));
}

public __SyntaxToken TSingleLineComment(string text)
{
    return new __SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.TSingleLineComment(text));
}

public __SyntaxToken TSingleLineComment(string text, object value)
{
    return new __SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.TSingleLineComment(text, value));
}

public __SyntaxToken TMultiLineComment(string text)
{
    return new __SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.TMultiLineComment(text));
}

public __SyntaxToken TMultiLineComment(string text, object value)
{
    return new __SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.TMultiLineComment(text, value));
}

public __SyntaxToken TInvalidToken(string text)
{
    return new __SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.TInvalidToken(text));
}

public __SyntaxToken TInvalidToken(string text, object value)
{
    return new __SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.TInvalidToken(text, value));
}

public MainSyntax Main(__SyntaxToken kNamespace, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<IdentifierSyntax> qualifier, __SyntaxToken tSemicolon, global::MetaDslx.CodeAnalysis.SyntaxList<UsingSyntax> usingList, MainBlock1Syntax block, __SyntaxToken endOfFileToken)
{
	if (kNamespace.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(kNamespace));
	if (kNamespace.RawKind != (int)CompilerSyntaxKind.KNamespace) throw new __ArgumentException(nameof(kNamespace));
	if (tSemicolon.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tSemicolon));
	if (tSemicolon.RawKind != (int)CompilerSyntaxKind.TSemicolon) throw new __ArgumentException(nameof(tSemicolon));
	if (block is null) throw new __ArgumentNullException(nameof(block));
	if (endOfFileToken.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(endOfFileToken));
	if (endOfFileToken.RawKind != (int)__InternalSyntaxKind.Eof) throw new __ArgumentException(nameof(endOfFileToken));
    return (MainSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.Main((__InternalSyntaxToken)kNamespace.Node, __GreenNodeExtensions.ToGreenSeparatedList<InternalSyntax.IdentifierGreen>(qualifier.Node, reversed: false), (__InternalSyntaxToken)tSemicolon.Node, __GreenNodeExtensions.ToGreenList<InternalSyntax.UsingGreen>(usingList.Node), (InternalSyntax.MainBlock1Green)block.Green, (__InternalSyntaxToken)endOfFileToken.Node).CreateRed();
}

public MainSyntax Main(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<IdentifierSyntax> qualifier, global::MetaDslx.CodeAnalysis.SyntaxList<UsingSyntax> usingList, MainBlock1Syntax block, __SyntaxToken endOfFileToken)
{
	return this.Main(this.Token(CompilerSyntaxKind.KNamespace), qualifier, this.Token(CompilerSyntaxKind.TSemicolon), usingList, block, this.Token(CompilerSyntaxKind.Eof));
}

public UsingSyntax Using(__SyntaxToken kUsing, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<IdentifierSyntax> qualifier, __SyntaxToken tSemicolon)
{
	if (kUsing.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(kUsing));
	if (kUsing.RawKind != (int)CompilerSyntaxKind.KUsing) throw new __ArgumentException(nameof(kUsing));
	if (tSemicolon.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tSemicolon));
	if (tSemicolon.RawKind != (int)CompilerSyntaxKind.TSemicolon) throw new __ArgumentException(nameof(tSemicolon));
    return (UsingSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.Using((__InternalSyntaxToken)kUsing.Node, __GreenNodeExtensions.ToGreenSeparatedList<InternalSyntax.IdentifierGreen>(qualifier.Node, reversed: false), (__InternalSyntaxToken)tSemicolon.Node).CreateRed();
}

public UsingSyntax Using(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<IdentifierSyntax> qualifier)
{
	return this.Using(this.Token(CompilerSyntaxKind.KUsing), qualifier, this.Token(CompilerSyntaxKind.TSemicolon));
}

public LanguageDeclarationSyntax LanguageDeclaration(__SyntaxToken kLanguage, NameSyntax name, __SyntaxToken tSemicolon, GrammarSyntax grammar)
{
	if (kLanguage.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(kLanguage));
	if (kLanguage.RawKind != (int)CompilerSyntaxKind.KLanguage) throw new __ArgumentException(nameof(kLanguage));
	if (name is null) throw new __ArgumentNullException(nameof(name));
	if (tSemicolon.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tSemicolon));
	if (tSemicolon.RawKind != (int)CompilerSyntaxKind.TSemicolon) throw new __ArgumentException(nameof(tSemicolon));
	if (grammar is null) throw new __ArgumentNullException(nameof(grammar));
    return (LanguageDeclarationSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.LanguageDeclaration((__InternalSyntaxToken)kLanguage.Node, (InternalSyntax.NameGreen)name.Green, (__InternalSyntaxToken)tSemicolon.Node, (InternalSyntax.GrammarGreen)grammar.Green).CreateRed();
}

public LanguageDeclarationSyntax LanguageDeclaration(NameSyntax name, GrammarSyntax grammar)
{
	return this.LanguageDeclaration(this.Token(CompilerSyntaxKind.KLanguage), name, this.Token(CompilerSyntaxKind.TSemicolon), grammar);
}

public GrammarSyntax Grammar(global::MetaDslx.CodeAnalysis.SyntaxList<GrammarRuleSyntax> grammarRules)
{
    return (GrammarSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.Grammar(__GreenNodeExtensions.ToGreenList<InternalSyntax.GrammarRuleGreen>(grammarRules.Node)).CreateRed();
}

public RuleSyntax Rule(global::MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> annotations1, RuleBlock1Syntax block, __SyntaxToken tColon, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<AlternativeSyntax> alternatives, __SyntaxToken tSemicolon)
{
	if (block is null) throw new __ArgumentNullException(nameof(block));
	if (tColon.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tColon));
	if (tColon.RawKind != (int)CompilerSyntaxKind.TColon) throw new __ArgumentException(nameof(tColon));
	if (tSemicolon.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tSemicolon));
	if (tSemicolon.RawKind != (int)CompilerSyntaxKind.TSemicolon) throw new __ArgumentException(nameof(tSemicolon));
    return (RuleSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.Rule(__GreenNodeExtensions.ToGreenList<InternalSyntax.ParserAnnotationGreen>(annotations1.Node), (InternalSyntax.RuleBlock1Green)block.Green, (__InternalSyntaxToken)tColon.Node, __GreenNodeExtensions.ToGreenSeparatedList<InternalSyntax.AlternativeGreen>(alternatives.Node, reversed: false), (__InternalSyntaxToken)tSemicolon.Node).CreateRed();
}

public RuleSyntax Rule(global::MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> annotations1, RuleBlock1Syntax block, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<AlternativeSyntax> alternatives)
{
	return this.Rule(annotations1, block, this.Token(CompilerSyntaxKind.TColon), alternatives, this.Token(CompilerSyntaxKind.TSemicolon));
}

public TokenSyntax Token(global::MetaDslx.CodeAnalysis.SyntaxList<LexerAnnotationSyntax> annotations1, TokenBlock1Syntax block, __SyntaxToken tColon, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<LAlternativeSyntax> alternatives, __SyntaxToken tSemicolon)
{
	if (block is null) throw new __ArgumentNullException(nameof(block));
	if (tColon.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tColon));
	if (tColon.RawKind != (int)CompilerSyntaxKind.TColon) throw new __ArgumentException(nameof(tColon));
	if (tSemicolon.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tSemicolon));
	if (tSemicolon.RawKind != (int)CompilerSyntaxKind.TSemicolon) throw new __ArgumentException(nameof(tSemicolon));
    return (TokenSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.Token(__GreenNodeExtensions.ToGreenList<InternalSyntax.LexerAnnotationGreen>(annotations1.Node), (InternalSyntax.TokenBlock1Green)block.Green, (__InternalSyntaxToken)tColon.Node, __GreenNodeExtensions.ToGreenSeparatedList<InternalSyntax.LAlternativeGreen>(alternatives.Node, reversed: false), (__InternalSyntaxToken)tSemicolon.Node).CreateRed();
}

public TokenSyntax Token(global::MetaDslx.CodeAnalysis.SyntaxList<LexerAnnotationSyntax> annotations1, TokenBlock1Syntax block, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<LAlternativeSyntax> alternatives)
{
	return this.Token(annotations1, block, this.Token(CompilerSyntaxKind.TColon), alternatives, this.Token(CompilerSyntaxKind.TSemicolon));
}

public FragmentSyntax Fragment(__SyntaxToken kFragment, NameSyntax name, __SyntaxToken tColon, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<LAlternativeSyntax> alternatives, __SyntaxToken tSemicolon)
{
	if (kFragment.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(kFragment));
	if (kFragment.RawKind != (int)CompilerSyntaxKind.KFragment) throw new __ArgumentException(nameof(kFragment));
	if (name is null) throw new __ArgumentNullException(nameof(name));
	if (tColon.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tColon));
	if (tColon.RawKind != (int)CompilerSyntaxKind.TColon) throw new __ArgumentException(nameof(tColon));
	if (tSemicolon.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tSemicolon));
	if (tSemicolon.RawKind != (int)CompilerSyntaxKind.TSemicolon) throw new __ArgumentException(nameof(tSemicolon));
    return (FragmentSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.Fragment((__InternalSyntaxToken)kFragment.Node, (InternalSyntax.NameGreen)name.Green, (__InternalSyntaxToken)tColon.Node, __GreenNodeExtensions.ToGreenSeparatedList<InternalSyntax.LAlternativeGreen>(alternatives.Node, reversed: false), (__InternalSyntaxToken)tSemicolon.Node).CreateRed();
}

public FragmentSyntax Fragment(NameSyntax name, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<LAlternativeSyntax> alternatives)
{
	return this.Fragment(this.Token(CompilerSyntaxKind.KFragment), name, this.Token(CompilerSyntaxKind.TColon), alternatives, this.Token(CompilerSyntaxKind.TSemicolon));
}

public AlternativeSyntax Alternative(AlternativeBlock1Syntax block1, global::MetaDslx.CodeAnalysis.SyntaxList<ElementSyntax> elements, AlternativeBlock2Syntax block2)
{
    return (AlternativeSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.Alternative((InternalSyntax.AlternativeBlock1Green)block1.Green, __GreenNodeExtensions.ToGreenList<InternalSyntax.ElementGreen>(elements.Node), (InternalSyntax.AlternativeBlock2Green)block2.Green).CreateRed();
}

public AlternativeSyntax Alternative(global::MetaDslx.CodeAnalysis.SyntaxList<ElementSyntax> elements)
{
	return this.Alternative(default, elements, default);
}

public ElementSyntax Element(ElementBlock1Syntax block, ElementValueSyntax value, __SyntaxToken multiplicity)
{
	if (value is null) throw new __ArgumentNullException(nameof(value));
	if (multiplicity.RawKind != (int)__InternalSyntaxKind.None && (multiplicity.RawKind != (int)CompilerSyntaxKind.TQuestion && multiplicity.RawKind != (int)CompilerSyntaxKind.TAsterisk && multiplicity.RawKind != (int)CompilerSyntaxKind.TPlus && multiplicity.RawKind != (int)CompilerSyntaxKind.TQuestionQuestion && multiplicity.RawKind != (int)CompilerSyntaxKind.TAsteriskQuestion && multiplicity.RawKind != (int)CompilerSyntaxKind.TPlusQuestion)) throw new __ArgumentException(nameof(multiplicity));
    return (ElementSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.Element((InternalSyntax.ElementBlock1Green)block.Green, (InternalSyntax.ElementValueGreen)value.Green, (__InternalSyntaxToken)multiplicity.Node).CreateRed();
}

public ElementSyntax Element(ElementValueSyntax value)
{
	return this.Element(default, value, default);
}

public BlockSyntax Block(global::MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> annotations1, __SyntaxToken tLParen, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<BlockAlternativeSyntax> alternatives, __SyntaxToken tRParen)
{
	if (tLParen.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tLParen));
	if (tLParen.RawKind != (int)CompilerSyntaxKind.TLParen) throw new __ArgumentException(nameof(tLParen));
	if (tRParen.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tRParen));
	if (tRParen.RawKind != (int)CompilerSyntaxKind.TRParen) throw new __ArgumentException(nameof(tRParen));
    return (BlockSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.Block(__GreenNodeExtensions.ToGreenList<InternalSyntax.ParserAnnotationGreen>(annotations1.Node), (__InternalSyntaxToken)tLParen.Node, __GreenNodeExtensions.ToGreenSeparatedList<InternalSyntax.BlockAlternativeGreen>(alternatives.Node, reversed: false), (__InternalSyntaxToken)tRParen.Node).CreateRed();
}

public BlockSyntax Block(global::MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> annotations1, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<BlockAlternativeSyntax> alternatives)
{
	return this.Block(annotations1, this.Token(CompilerSyntaxKind.TLParen), alternatives, this.Token(CompilerSyntaxKind.TRParen));
}

public Eof1Syntax Eof1(__SyntaxToken kEof)
{
	if (kEof.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(kEof));
	if (kEof.RawKind != (int)CompilerSyntaxKind.KEof) throw new __ArgumentException(nameof(kEof));
    return (Eof1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.Eof1((__InternalSyntaxToken)kEof.Node).CreateRed();
}

public Eof1Syntax Eof1()
{
	return this.Eof1(this.Token(CompilerSyntaxKind.KEof));
}

public FixedSyntax Fixed(global::MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> annotations1, __SyntaxToken text)
{
	if (text.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(text));
	if (text.RawKind != (int)CompilerSyntaxKind.TString) throw new __ArgumentException(nameof(text));
    return (FixedSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.Fixed(__GreenNodeExtensions.ToGreenList<InternalSyntax.ParserAnnotationGreen>(annotations1.Node), (__InternalSyntaxToken)text.Node).CreateRed();
}

public RuleRefAlt1Syntax RuleRefAlt1(global::MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> annotations1, IdentifierSyntax grammarRule)
{
	if (grammarRule is null) throw new __ArgumentNullException(nameof(grammarRule));
    return (RuleRefAlt1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.RuleRefAlt1(__GreenNodeExtensions.ToGreenList<InternalSyntax.ParserAnnotationGreen>(annotations1.Node), (InternalSyntax.IdentifierGreen)grammarRule.Green).CreateRed();
}

public RuleRefAlt2Syntax RuleRefAlt2(global::MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> annotations1, __SyntaxToken tHash, TypeReferenceSyntax referencedTypes)
{
	if (tHash.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tHash));
	if (tHash.RawKind != (int)CompilerSyntaxKind.THash) throw new __ArgumentException(nameof(tHash));
	if (referencedTypes is null) throw new __ArgumentNullException(nameof(referencedTypes));
    return (RuleRefAlt2Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.RuleRefAlt2(__GreenNodeExtensions.ToGreenList<InternalSyntax.ParserAnnotationGreen>(annotations1.Node), (__InternalSyntaxToken)tHash.Node, (InternalSyntax.TypeReferenceGreen)referencedTypes.Green).CreateRed();
}

public RuleRefAlt2Syntax RuleRefAlt2(global::MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> annotations1, TypeReferenceSyntax referencedTypes)
{
	return this.RuleRefAlt2(annotations1, this.Token(CompilerSyntaxKind.THash), referencedTypes);
}

public RuleRefAlt3Syntax RuleRefAlt3(global::MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> annotations1, __SyntaxToken tHashLBrace, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<TypeReferenceSyntax> referencedTypes, RuleRefAlt3Block1Syntax block, __SyntaxToken tRBrace)
{
	if (tHashLBrace.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tHashLBrace));
	if (tHashLBrace.RawKind != (int)CompilerSyntaxKind.THashLBrace) throw new __ArgumentException(nameof(tHashLBrace));
	if (tRBrace.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tRBrace));
	if (tRBrace.RawKind != (int)CompilerSyntaxKind.TRBrace) throw new __ArgumentException(nameof(tRBrace));
    return (RuleRefAlt3Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.RuleRefAlt3(__GreenNodeExtensions.ToGreenList<InternalSyntax.ParserAnnotationGreen>(annotations1.Node), (__InternalSyntaxToken)tHashLBrace.Node, __GreenNodeExtensions.ToGreenSeparatedList<InternalSyntax.TypeReferenceGreen>(referencedTypes.Node, reversed: false), (InternalSyntax.RuleRefAlt3Block1Green)block.Green, (__InternalSyntaxToken)tRBrace.Node).CreateRed();
}

public RuleRefAlt3Syntax RuleRefAlt3(global::MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> annotations1, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<TypeReferenceSyntax> referencedTypes)
{
	return this.RuleRefAlt3(annotations1, this.Token(CompilerSyntaxKind.THashLBrace), referencedTypes, default, this.Token(CompilerSyntaxKind.TRBrace));
}

public BlockAlternativeSyntax BlockAlternative(global::MetaDslx.CodeAnalysis.SyntaxList<ElementSyntax> elements, BlockAlternativeBlock1Syntax block)
{
    return (BlockAlternativeSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.BlockAlternative(__GreenNodeExtensions.ToGreenList<InternalSyntax.ElementGreen>(elements.Node), (InternalSyntax.BlockAlternativeBlock1Green)block.Green).CreateRed();
}

public BlockAlternativeSyntax BlockAlternative(global::MetaDslx.CodeAnalysis.SyntaxList<ElementSyntax> elements)
{
	return this.BlockAlternative(elements, default);
}

public LAlternativeSyntax LAlternative(global::MetaDslx.CodeAnalysis.SyntaxList<LElementSyntax> elements)
{
    return (LAlternativeSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.LAlternative(__GreenNodeExtensions.ToGreenList<InternalSyntax.LElementGreen>(elements.Node)).CreateRed();
}

public LElementSyntax LElement(__SyntaxToken isNegated, LElementValueSyntax value, __SyntaxToken multiplicity)
{
	if (isNegated.RawKind != (int)__InternalSyntaxKind.None && (isNegated.RawKind != (int)CompilerSyntaxKind.TTilde)) throw new __ArgumentException(nameof(isNegated));
	if (value is null) throw new __ArgumentNullException(nameof(value));
	if (multiplicity.RawKind != (int)__InternalSyntaxKind.None && (multiplicity.RawKind != (int)CompilerSyntaxKind.TQuestion && multiplicity.RawKind != (int)CompilerSyntaxKind.TAsterisk && multiplicity.RawKind != (int)CompilerSyntaxKind.TPlus && multiplicity.RawKind != (int)CompilerSyntaxKind.TQuestionQuestion && multiplicity.RawKind != (int)CompilerSyntaxKind.TAsteriskQuestion && multiplicity.RawKind != (int)CompilerSyntaxKind.TPlusQuestion)) throw new __ArgumentException(nameof(multiplicity));
    return (LElementSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.LElement((__InternalSyntaxToken)isNegated.Node, (InternalSyntax.LElementValueGreen)value.Green, (__InternalSyntaxToken)multiplicity.Node).CreateRed();
}

public LElementSyntax LElement(LElementValueSyntax value)
{
	return this.LElement(default, value, default);
}

public LElementValueTokensSyntax LElementValueTokens(__SyntaxToken token)
{
	if (token.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(token));
	if (token.RawKind != (int)CompilerSyntaxKind.TString && token.RawKind != (int)CompilerSyntaxKind.TDot) throw new __ArgumentException(nameof(token));
    return (LElementValueTokensSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.LElementValueTokens((__InternalSyntaxToken)token.Node).CreateRed();
}

public LBlockSyntax LBlock(__SyntaxToken tLParen, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<LAlternativeSyntax> alternatives, __SyntaxToken tRParen)
{
	if (tLParen.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tLParen));
	if (tLParen.RawKind != (int)CompilerSyntaxKind.TLParen) throw new __ArgumentException(nameof(tLParen));
	if (tRParen.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tRParen));
	if (tRParen.RawKind != (int)CompilerSyntaxKind.TRParen) throw new __ArgumentException(nameof(tRParen));
    return (LBlockSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.LBlock((__InternalSyntaxToken)tLParen.Node, __GreenNodeExtensions.ToGreenSeparatedList<InternalSyntax.LAlternativeGreen>(alternatives.Node, reversed: false), (__InternalSyntaxToken)tRParen.Node).CreateRed();
}

public LBlockSyntax LBlock(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<LAlternativeSyntax> alternatives)
{
	return this.LBlock(this.Token(CompilerSyntaxKind.TLParen), alternatives, this.Token(CompilerSyntaxKind.TRParen));
}

public LRangeSyntax LRange(__SyntaxToken startChar, __SyntaxToken tDotDot, __SyntaxToken endChar)
{
	if (startChar.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(startChar));
	if (startChar.RawKind != (int)CompilerSyntaxKind.TString) throw new __ArgumentException(nameof(startChar));
	if (tDotDot.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tDotDot));
	if (tDotDot.RawKind != (int)CompilerSyntaxKind.TDotDot) throw new __ArgumentException(nameof(tDotDot));
	if (endChar.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(endChar));
	if (endChar.RawKind != (int)CompilerSyntaxKind.TString) throw new __ArgumentException(nameof(endChar));
    return (LRangeSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.LRange((__InternalSyntaxToken)startChar.Node, (__InternalSyntaxToken)tDotDot.Node, (__InternalSyntaxToken)endChar.Node).CreateRed();
}

public LRangeSyntax LRange(__SyntaxToken startChar, __SyntaxToken endChar)
{
	return this.LRange(this.Token(CompilerSyntaxKind.TString), this.Token(CompilerSyntaxKind.TDotDot), this.Token(CompilerSyntaxKind.TString));
}

public LReferenceSyntax LReference(IdentifierSyntax rule)
{
	if (rule is null) throw new __ArgumentNullException(nameof(rule));
    return (LReferenceSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.LReference((InternalSyntax.IdentifierGreen)rule.Green).CreateRed();
}

public ExpressionAlt1Syntax ExpressionAlt1(SingleExpressionSyntax singleExpression)
{
	if (singleExpression is null) throw new __ArgumentNullException(nameof(singleExpression));
    return (ExpressionAlt1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.ExpressionAlt1((InternalSyntax.SingleExpressionGreen)singleExpression.Green).CreateRed();
}

public ArrayExpressionSyntax ArrayExpression(__SyntaxToken tLBrace, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<SingleExpressionSyntax> items, __SyntaxToken tRBrace)
{
	if (tLBrace.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tLBrace));
	if (tLBrace.RawKind != (int)CompilerSyntaxKind.TLBrace) throw new __ArgumentException(nameof(tLBrace));
	if (tRBrace.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tRBrace));
	if (tRBrace.RawKind != (int)CompilerSyntaxKind.TRBrace) throw new __ArgumentException(nameof(tRBrace));
    return (ArrayExpressionSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.ArrayExpression((__InternalSyntaxToken)tLBrace.Node, __GreenNodeExtensions.ToGreenSeparatedList<InternalSyntax.SingleExpressionGreen>(items.Node, reversed: false), (__InternalSyntaxToken)tRBrace.Node).CreateRed();
}

public ArrayExpressionSyntax ArrayExpression()
{
	return this.ArrayExpression(this.Token(CompilerSyntaxKind.TLBrace), default, this.Token(CompilerSyntaxKind.TRBrace));
}

public SingleExpressionSyntax SingleExpression(SingleExpressionBlock1Syntax value)
{
	if (value is null) throw new __ArgumentNullException(nameof(value));
    return (SingleExpressionSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.SingleExpression((InternalSyntax.SingleExpressionBlock1Green)value.Green).CreateRed();
}

public ParserAnnotationSyntax ParserAnnotation(__SyntaxToken tLBracket, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<IdentifierSyntax> qualifier, __SyntaxToken tLParen, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<AnnotationArgumentSyntax> arguments, __SyntaxToken tRParen, __SyntaxToken tRBracket)
{
	if (tLBracket.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tLBracket));
	if (tLBracket.RawKind != (int)CompilerSyntaxKind.TLBracket) throw new __ArgumentException(nameof(tLBracket));
	if (tLParen.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tLParen));
	if (tLParen.RawKind != (int)CompilerSyntaxKind.TLParen) throw new __ArgumentException(nameof(tLParen));
	if (tRParen.RawKind != (int)__InternalSyntaxKind.None && (tRParen.RawKind != (int)CompilerSyntaxKind.TRParen)) throw new __ArgumentException(nameof(tRParen));
	if (tRBracket.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tRBracket));
	if (tRBracket.RawKind != (int)CompilerSyntaxKind.TRBracket) throw new __ArgumentException(nameof(tRBracket));
    return (ParserAnnotationSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.ParserAnnotation((__InternalSyntaxToken)tLBracket.Node, __GreenNodeExtensions.ToGreenSeparatedList<InternalSyntax.IdentifierGreen>(qualifier.Node, reversed: false), (__InternalSyntaxToken)tLParen.Node, __GreenNodeExtensions.ToGreenSeparatedList<InternalSyntax.AnnotationArgumentGreen>(arguments.Node, reversed: false), (__InternalSyntaxToken)tRParen.Node, (__InternalSyntaxToken)tRBracket.Node).CreateRed();
}

public ParserAnnotationSyntax ParserAnnotation(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<IdentifierSyntax> qualifier, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<AnnotationArgumentSyntax> arguments)
{
	return this.ParserAnnotation(this.Token(CompilerSyntaxKind.TLBracket), qualifier, this.Token(CompilerSyntaxKind.TLParen), arguments, default, this.Token(CompilerSyntaxKind.TRBracket));
}

public LexerAnnotationSyntax LexerAnnotation(__SyntaxToken tLBracket, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<IdentifierSyntax> qualifier, __SyntaxToken tLParen, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<AnnotationArgumentSyntax> arguments, __SyntaxToken tRParen, __SyntaxToken tRBracket)
{
	if (tLBracket.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tLBracket));
	if (tLBracket.RawKind != (int)CompilerSyntaxKind.TLBracket) throw new __ArgumentException(nameof(tLBracket));
	if (tLParen.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tLParen));
	if (tLParen.RawKind != (int)CompilerSyntaxKind.TLParen) throw new __ArgumentException(nameof(tLParen));
	if (tRParen.RawKind != (int)__InternalSyntaxKind.None && (tRParen.RawKind != (int)CompilerSyntaxKind.TRParen)) throw new __ArgumentException(nameof(tRParen));
	if (tRBracket.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tRBracket));
	if (tRBracket.RawKind != (int)CompilerSyntaxKind.TRBracket) throw new __ArgumentException(nameof(tRBracket));
    return (LexerAnnotationSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.LexerAnnotation((__InternalSyntaxToken)tLBracket.Node, __GreenNodeExtensions.ToGreenSeparatedList<InternalSyntax.IdentifierGreen>(qualifier.Node, reversed: false), (__InternalSyntaxToken)tLParen.Node, __GreenNodeExtensions.ToGreenSeparatedList<InternalSyntax.AnnotationArgumentGreen>(arguments.Node, reversed: false), (__InternalSyntaxToken)tRParen.Node, (__InternalSyntaxToken)tRBracket.Node).CreateRed();
}

public LexerAnnotationSyntax LexerAnnotation(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<IdentifierSyntax> qualifier, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<AnnotationArgumentSyntax> arguments)
{
	return this.LexerAnnotation(this.Token(CompilerSyntaxKind.TLBracket), qualifier, this.Token(CompilerSyntaxKind.TLParen), arguments, default, this.Token(CompilerSyntaxKind.TRBracket));
}

public AnnotationArgumentSyntax AnnotationArgument(AnnotationArgumentBlock1Syntax block, ExpressionSyntax value)
{
	if (value is null) throw new __ArgumentNullException(nameof(value));
    return (AnnotationArgumentSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.AnnotationArgument((InternalSyntax.AnnotationArgumentBlock1Green)block.Green, (InternalSyntax.ExpressionGreen)value.Green).CreateRed();
}

public AnnotationArgumentSyntax AnnotationArgument(ExpressionSyntax value)
{
	return this.AnnotationArgument(default, value);
}

public TypeReferenceIdentifierAlt1Syntax TypeReferenceIdentifierAlt1(__SyntaxToken tokens)
{
	if (tokens.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tokens));
	if (tokens.RawKind != (int)CompilerSyntaxKind.KBool && tokens.RawKind != (int)CompilerSyntaxKind.KInt && tokens.RawKind != (int)CompilerSyntaxKind.KString && tokens.RawKind != (int)CompilerSyntaxKind.KType && tokens.RawKind != (int)CompilerSyntaxKind.KSymbol && tokens.RawKind != (int)CompilerSyntaxKind.KObject && tokens.RawKind != (int)CompilerSyntaxKind.KVoid) throw new __ArgumentException(nameof(tokens));
    return (TypeReferenceIdentifierAlt1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.TypeReferenceIdentifierAlt1((__InternalSyntaxToken)tokens.Node).CreateRed();
}

public TypeReferenceIdentifierAlt2Syntax TypeReferenceIdentifierAlt2(IdentifierSyntax identifier)
{
	if (identifier is null) throw new __ArgumentNullException(nameof(identifier));
    return (TypeReferenceIdentifierAlt2Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.TypeReferenceIdentifierAlt2((InternalSyntax.IdentifierGreen)identifier.Green).CreateRed();
}

public TypeReferenceAlt1Syntax TypeReferenceAlt1(__SyntaxToken tokens)
{
	if (tokens.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tokens));
	if (tokens.RawKind != (int)CompilerSyntaxKind.KBool && tokens.RawKind != (int)CompilerSyntaxKind.KInt && tokens.RawKind != (int)CompilerSyntaxKind.KString && tokens.RawKind != (int)CompilerSyntaxKind.KType && tokens.RawKind != (int)CompilerSyntaxKind.KSymbol && tokens.RawKind != (int)CompilerSyntaxKind.KObject && tokens.RawKind != (int)CompilerSyntaxKind.KVoid) throw new __ArgumentException(nameof(tokens));
    return (TypeReferenceAlt1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.TypeReferenceAlt1((__InternalSyntaxToken)tokens.Node).CreateRed();
}

public TypeReferenceAlt2Syntax TypeReferenceAlt2(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<IdentifierSyntax> qualifier)
{
    return (TypeReferenceAlt2Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.TypeReferenceAlt2(__GreenNodeExtensions.ToGreenSeparatedList<InternalSyntax.IdentifierGreen>(qualifier.Node, reversed: false)).CreateRed();
}

public NameSyntax Name(IdentifierSyntax identifier)
{
	if (identifier is null) throw new __ArgumentNullException(nameof(identifier));
    return (NameSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.Name((InternalSyntax.IdentifierGreen)identifier.Green).CreateRed();
}

public IdentifierSyntax Identifier(__SyntaxToken token)
{
	if (token.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(token));
	if (token.RawKind != (int)CompilerSyntaxKind.TIdentifier && token.RawKind != (int)CompilerSyntaxKind.TVerbatimIdentifier) throw new __ArgumentException(nameof(token));
    return (IdentifierSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.Identifier((__InternalSyntaxToken)token.Node).CreateRed();
}

public MainBlock1Syntax MainBlock1(LanguageDeclarationSyntax declarations)
{
	if (declarations is null) throw new __ArgumentNullException(nameof(declarations));
    return (MainBlock1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.MainBlock1((InternalSyntax.LanguageDeclarationGreen)declarations.Green).CreateRed();
}

public RuleBlock1Alt1Syntax RuleBlock1Alt1(TypeReferenceIdentifierSyntax returnType)
{
	if (returnType is null) throw new __ArgumentNullException(nameof(returnType));
    return (RuleBlock1Alt1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.RuleBlock1Alt1((InternalSyntax.TypeReferenceIdentifierGreen)returnType.Green).CreateRed();
}

public RuleBlock1Alt2Syntax RuleBlock1Alt2(IdentifierSyntax identifier, __SyntaxToken kReturns, TypeReferenceSyntax returnType)
{
	if (identifier is null) throw new __ArgumentNullException(nameof(identifier));
	if (kReturns.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(kReturns));
	if (kReturns.RawKind != (int)CompilerSyntaxKind.KReturns) throw new __ArgumentException(nameof(kReturns));
	if (returnType is null) throw new __ArgumentNullException(nameof(returnType));
    return (RuleBlock1Alt2Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.RuleBlock1Alt2((InternalSyntax.IdentifierGreen)identifier.Green, (__InternalSyntaxToken)kReturns.Node, (InternalSyntax.TypeReferenceGreen)returnType.Green).CreateRed();
}

public RuleBlock1Alt2Syntax RuleBlock1Alt2(IdentifierSyntax identifier, TypeReferenceSyntax returnType)
{
	return this.RuleBlock1Alt2(identifier, this.Token(CompilerSyntaxKind.KReturns), returnType);
}

public RuleAlternativesBlockSyntax RuleAlternativesBlock(__SyntaxToken tBar, AlternativeSyntax alternatives)
{
	if (tBar.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tBar));
	if (tBar.RawKind != (int)CompilerSyntaxKind.TBar) throw new __ArgumentException(nameof(tBar));
	if (alternatives is null) throw new __ArgumentNullException(nameof(alternatives));
    return (RuleAlternativesBlockSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.RuleAlternativesBlock((__InternalSyntaxToken)tBar.Node, (InternalSyntax.AlternativeGreen)alternatives.Green).CreateRed();
}

public RuleAlternativesBlockSyntax RuleAlternativesBlock(AlternativeSyntax alternatives)
{
	return this.RuleAlternativesBlock(this.Token(CompilerSyntaxKind.TBar), alternatives);
}

public AlternativeBlock1Syntax AlternativeBlock1(global::MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> annotations1, __SyntaxToken kAlt, NameSyntax name, AlternativeBlock1Block1Syntax block, __SyntaxToken tColon)
{
	if (kAlt.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(kAlt));
	if (kAlt.RawKind != (int)CompilerSyntaxKind.KAlt) throw new __ArgumentException(nameof(kAlt));
	if (name is null) throw new __ArgumentNullException(nameof(name));
	if (tColon.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tColon));
	if (tColon.RawKind != (int)CompilerSyntaxKind.TColon) throw new __ArgumentException(nameof(tColon));
    return (AlternativeBlock1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.AlternativeBlock1(__GreenNodeExtensions.ToGreenList<InternalSyntax.ParserAnnotationGreen>(annotations1.Node), (__InternalSyntaxToken)kAlt.Node, (InternalSyntax.NameGreen)name.Green, (InternalSyntax.AlternativeBlock1Block1Green)block.Green, (__InternalSyntaxToken)tColon.Node).CreateRed();
}

public AlternativeBlock1Syntax AlternativeBlock1(global::MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> annotations1, NameSyntax name)
{
	return this.AlternativeBlock1(annotations1, this.Token(CompilerSyntaxKind.KAlt), name, default, this.Token(CompilerSyntaxKind.TColon));
}

public AlternativeBlock2Syntax AlternativeBlock2(__SyntaxToken tEqGt, ExpressionSyntax returnValue)
{
	if (tEqGt.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tEqGt));
	if (tEqGt.RawKind != (int)CompilerSyntaxKind.TEqGt) throw new __ArgumentException(nameof(tEqGt));
	if (returnValue is null) throw new __ArgumentNullException(nameof(returnValue));
    return (AlternativeBlock2Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.AlternativeBlock2((__InternalSyntaxToken)tEqGt.Node, (InternalSyntax.ExpressionGreen)returnValue.Green).CreateRed();
}

public AlternativeBlock2Syntax AlternativeBlock2(ExpressionSyntax returnValue)
{
	return this.AlternativeBlock2(this.Token(CompilerSyntaxKind.TEqGt), returnValue);
}

public ElementBlock1Syntax ElementBlock1(global::MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> annotations1, NameSyntax name, __SyntaxToken assignment)
{
	if (name is null) throw new __ArgumentNullException(nameof(name));
	if (assignment.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(assignment));
	if (assignment.RawKind != (int)CompilerSyntaxKind.TEq && assignment.RawKind != (int)CompilerSyntaxKind.TQuestionEq && assignment.RawKind != (int)CompilerSyntaxKind.TExclEq && assignment.RawKind != (int)CompilerSyntaxKind.TPlusEq) throw new __ArgumentException(nameof(assignment));
    return (ElementBlock1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.ElementBlock1(__GreenNodeExtensions.ToGreenList<InternalSyntax.ParserAnnotationGreen>(annotations1.Node), (InternalSyntax.NameGreen)name.Green, (__InternalSyntaxToken)assignment.Node).CreateRed();
}

public BlockAlternativesBlockSyntax BlockAlternativesBlock(__SyntaxToken tBar, BlockAlternativeSyntax alternatives)
{
	if (tBar.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tBar));
	if (tBar.RawKind != (int)CompilerSyntaxKind.TBar) throw new __ArgumentException(nameof(tBar));
	if (alternatives is null) throw new __ArgumentNullException(nameof(alternatives));
    return (BlockAlternativesBlockSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.BlockAlternativesBlock((__InternalSyntaxToken)tBar.Node, (InternalSyntax.BlockAlternativeGreen)alternatives.Green).CreateRed();
}

public BlockAlternativesBlockSyntax BlockAlternativesBlock(BlockAlternativeSyntax alternatives)
{
	return this.BlockAlternativesBlock(this.Token(CompilerSyntaxKind.TBar), alternatives);
}

public BlockAlternativeBlock1Syntax BlockAlternativeBlock1(__SyntaxToken tEqGt, ExpressionSyntax returnValue)
{
	if (tEqGt.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tEqGt));
	if (tEqGt.RawKind != (int)CompilerSyntaxKind.TEqGt) throw new __ArgumentException(nameof(tEqGt));
	if (returnValue is null) throw new __ArgumentNullException(nameof(returnValue));
    return (BlockAlternativeBlock1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.BlockAlternativeBlock1((__InternalSyntaxToken)tEqGt.Node, (InternalSyntax.ExpressionGreen)returnValue.Green).CreateRed();
}

public BlockAlternativeBlock1Syntax BlockAlternativeBlock1(ExpressionSyntax returnValue)
{
	return this.BlockAlternativeBlock1(this.Token(CompilerSyntaxKind.TEqGt), returnValue);
}

public RuleRefAlt3ReferencedTypesBlockSyntax RuleRefAlt3ReferencedTypesBlock(__SyntaxToken tComma, TypeReferenceSyntax referencedTypes)
{
	if (tComma.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tComma));
	if (tComma.RawKind != (int)CompilerSyntaxKind.TComma) throw new __ArgumentException(nameof(tComma));
	if (referencedTypes is null) throw new __ArgumentNullException(nameof(referencedTypes));
    return (RuleRefAlt3ReferencedTypesBlockSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.RuleRefAlt3ReferencedTypesBlock((__InternalSyntaxToken)tComma.Node, (InternalSyntax.TypeReferenceGreen)referencedTypes.Green).CreateRed();
}

public RuleRefAlt3ReferencedTypesBlockSyntax RuleRefAlt3ReferencedTypesBlock(TypeReferenceSyntax referencedTypes)
{
	return this.RuleRefAlt3ReferencedTypesBlock(this.Token(CompilerSyntaxKind.TComma), referencedTypes);
}

public RuleRefAlt3Block1Syntax RuleRefAlt3Block1(__SyntaxToken tBar, IdentifierSyntax grammarRule)
{
	if (tBar.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tBar));
	if (tBar.RawKind != (int)CompilerSyntaxKind.TBar) throw new __ArgumentException(nameof(tBar));
	if (grammarRule is null) throw new __ArgumentNullException(nameof(grammarRule));
    return (RuleRefAlt3Block1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.RuleRefAlt3Block1((__InternalSyntaxToken)tBar.Node, (InternalSyntax.IdentifierGreen)grammarRule.Green).CreateRed();
}

public RuleRefAlt3Block1Syntax RuleRefAlt3Block1(IdentifierSyntax grammarRule)
{
	return this.RuleRefAlt3Block1(this.Token(CompilerSyntaxKind.TBar), grammarRule);
}

public TokenBlock1Alt1Syntax TokenBlock1Alt1(__SyntaxToken kToken, NameSyntax name, TokenBlock1Alt1Block1Syntax block)
{
	if (kToken.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(kToken));
	if (kToken.RawKind != (int)CompilerSyntaxKind.KToken) throw new __ArgumentException(nameof(kToken));
	if (name is null) throw new __ArgumentNullException(nameof(name));
    return (TokenBlock1Alt1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.TokenBlock1Alt1((__InternalSyntaxToken)kToken.Node, (InternalSyntax.NameGreen)name.Green, (InternalSyntax.TokenBlock1Alt1Block1Green)block.Green).CreateRed();
}

public TokenBlock1Alt1Syntax TokenBlock1Alt1(NameSyntax name)
{
	return this.TokenBlock1Alt1(this.Token(CompilerSyntaxKind.KToken), name, default);
}

public TokenBlock1Alt2Syntax TokenBlock1Alt2(__SyntaxToken isTrivia, NameSyntax name)
{
	if (isTrivia.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(isTrivia));
	if (isTrivia.RawKind != (int)CompilerSyntaxKind.KHidden) throw new __ArgumentException(nameof(isTrivia));
	if (name is null) throw new __ArgumentNullException(nameof(name));
    return (TokenBlock1Alt2Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.TokenBlock1Alt2((__InternalSyntaxToken)isTrivia.Node, (InternalSyntax.NameGreen)name.Green).CreateRed();
}

public TokenBlock1Alt2Syntax TokenBlock1Alt2(NameSyntax name)
{
	return this.TokenBlock1Alt2(this.Token(CompilerSyntaxKind.KHidden), name);
}

public TokenAlternativesBlockSyntax TokenAlternativesBlock(__SyntaxToken tBar, LAlternativeSyntax alternatives)
{
	if (tBar.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tBar));
	if (tBar.RawKind != (int)CompilerSyntaxKind.TBar) throw new __ArgumentException(nameof(tBar));
	if (alternatives is null) throw new __ArgumentNullException(nameof(alternatives));
    return (TokenAlternativesBlockSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.TokenAlternativesBlock((__InternalSyntaxToken)tBar.Node, (InternalSyntax.LAlternativeGreen)alternatives.Green).CreateRed();
}

public TokenAlternativesBlockSyntax TokenAlternativesBlock(LAlternativeSyntax alternatives)
{
	return this.TokenAlternativesBlock(this.Token(CompilerSyntaxKind.TBar), alternatives);
}

public FragmentAlternativesBlockSyntax FragmentAlternativesBlock(__SyntaxToken tBar, LAlternativeSyntax alternatives)
{
	if (tBar.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tBar));
	if (tBar.RawKind != (int)CompilerSyntaxKind.TBar) throw new __ArgumentException(nameof(tBar));
	if (alternatives is null) throw new __ArgumentNullException(nameof(alternatives));
    return (FragmentAlternativesBlockSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.FragmentAlternativesBlock((__InternalSyntaxToken)tBar.Node, (InternalSyntax.LAlternativeGreen)alternatives.Green).CreateRed();
}

public FragmentAlternativesBlockSyntax FragmentAlternativesBlock(LAlternativeSyntax alternatives)
{
	return this.FragmentAlternativesBlock(this.Token(CompilerSyntaxKind.TBar), alternatives);
}

public LBlockAlternativesBlockSyntax LBlockAlternativesBlock(__SyntaxToken tBar, LAlternativeSyntax alternatives)
{
	if (tBar.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tBar));
	if (tBar.RawKind != (int)CompilerSyntaxKind.TBar) throw new __ArgumentException(nameof(tBar));
	if (alternatives is null) throw new __ArgumentNullException(nameof(alternatives));
    return (LBlockAlternativesBlockSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.LBlockAlternativesBlock((__InternalSyntaxToken)tBar.Node, (InternalSyntax.LAlternativeGreen)alternatives.Green).CreateRed();
}

public LBlockAlternativesBlockSyntax LBlockAlternativesBlock(LAlternativeSyntax alternatives)
{
	return this.LBlockAlternativesBlock(this.Token(CompilerSyntaxKind.TBar), alternatives);
}

public TokensSyntax Tokens(__SyntaxToken token)
{
	if (token.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(token));
	if (token.RawKind != (int)CompilerSyntaxKind.KNull && token.RawKind != (int)CompilerSyntaxKind.KTrue && token.RawKind != (int)CompilerSyntaxKind.KFalse && token.RawKind != (int)CompilerSyntaxKind.TString && token.RawKind != (int)CompilerSyntaxKind.TInteger && token.RawKind != (int)CompilerSyntaxKind.TDecimal) throw new __ArgumentException(nameof(token));
    return (TokensSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.Tokens((__InternalSyntaxToken)token.Node).CreateRed();
}

public SingleExpressionBlock1Alt2Syntax SingleExpressionBlock1Alt2(__SyntaxToken tokens)
{
	if (tokens.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tokens));
	if (tokens.RawKind != (int)CompilerSyntaxKind.KBool && tokens.RawKind != (int)CompilerSyntaxKind.KInt && tokens.RawKind != (int)CompilerSyntaxKind.KString && tokens.RawKind != (int)CompilerSyntaxKind.KType && tokens.RawKind != (int)CompilerSyntaxKind.KSymbol && tokens.RawKind != (int)CompilerSyntaxKind.KObject && tokens.RawKind != (int)CompilerSyntaxKind.KVoid) throw new __ArgumentException(nameof(tokens));
    return (SingleExpressionBlock1Alt2Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.SingleExpressionBlock1Alt2((__InternalSyntaxToken)tokens.Node).CreateRed();
}

public SingleExpressionBlock1Alt3Syntax SingleExpressionBlock1Alt3(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<IdentifierSyntax> qualifier)
{
    return (SingleExpressionBlock1Alt3Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.SingleExpressionBlock1Alt3(__GreenNodeExtensions.ToGreenSeparatedList<InternalSyntax.IdentifierGreen>(qualifier.Node, reversed: false)).CreateRed();
}

public ParserAnnotationArgumentsBlockSyntax ParserAnnotationArgumentsBlock(__SyntaxToken tComma, AnnotationArgumentSyntax arguments)
{
	if (tComma.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tComma));
	if (tComma.RawKind != (int)CompilerSyntaxKind.TComma) throw new __ArgumentException(nameof(tComma));
	if (arguments is null) throw new __ArgumentNullException(nameof(arguments));
    return (ParserAnnotationArgumentsBlockSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.ParserAnnotationArgumentsBlock((__InternalSyntaxToken)tComma.Node, (InternalSyntax.AnnotationArgumentGreen)arguments.Green).CreateRed();
}

public ParserAnnotationArgumentsBlockSyntax ParserAnnotationArgumentsBlock(AnnotationArgumentSyntax arguments)
{
	return this.ParserAnnotationArgumentsBlock(this.Token(CompilerSyntaxKind.TComma), arguments);
}

public LexerAnnotationArgumentsBlockSyntax LexerAnnotationArgumentsBlock(__SyntaxToken tComma, AnnotationArgumentSyntax arguments)
{
	if (tComma.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tComma));
	if (tComma.RawKind != (int)CompilerSyntaxKind.TComma) throw new __ArgumentException(nameof(tComma));
	if (arguments is null) throw new __ArgumentNullException(nameof(arguments));
    return (LexerAnnotationArgumentsBlockSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.LexerAnnotationArgumentsBlock((__InternalSyntaxToken)tComma.Node, (InternalSyntax.AnnotationArgumentGreen)arguments.Green).CreateRed();
}

public LexerAnnotationArgumentsBlockSyntax LexerAnnotationArgumentsBlock(AnnotationArgumentSyntax arguments)
{
	return this.LexerAnnotationArgumentsBlock(this.Token(CompilerSyntaxKind.TComma), arguments);
}

public AnnotationArgumentBlock1Syntax AnnotationArgumentBlock1(IdentifierSyntax namedParameter, __SyntaxToken tColon)
{
	if (namedParameter is null) throw new __ArgumentNullException(nameof(namedParameter));
	if (tColon.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tColon));
	if (tColon.RawKind != (int)CompilerSyntaxKind.TColon) throw new __ArgumentException(nameof(tColon));
    return (AnnotationArgumentBlock1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.AnnotationArgumentBlock1((InternalSyntax.IdentifierGreen)namedParameter.Green, (__InternalSyntaxToken)tColon.Node).CreateRed();
}

public AnnotationArgumentBlock1Syntax AnnotationArgumentBlock1(IdentifierSyntax namedParameter)
{
	return this.AnnotationArgumentBlock1(namedParameter, this.Token(CompilerSyntaxKind.TColon));
}

public MainQualifierBlockSyntax MainQualifierBlock(__SyntaxToken tDot, IdentifierSyntax identifiers)
{
	if (tDot.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tDot));
	if (tDot.RawKind != (int)CompilerSyntaxKind.TDot) throw new __ArgumentException(nameof(tDot));
	if (identifiers is null) throw new __ArgumentNullException(nameof(identifiers));
    return (MainQualifierBlockSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.MainQualifierBlock((__InternalSyntaxToken)tDot.Node, (InternalSyntax.IdentifierGreen)identifiers.Green).CreateRed();
}

public MainQualifierBlockSyntax MainQualifierBlock(IdentifierSyntax identifiers)
{
	return this.MainQualifierBlock(this.Token(CompilerSyntaxKind.TDot), identifiers);
}

public AlternativeBlock1Block1Syntax AlternativeBlock1Block1(__SyntaxToken kReturns, TypeReferenceSyntax returnType)
{
	if (kReturns.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(kReturns));
	if (kReturns.RawKind != (int)CompilerSyntaxKind.KReturns) throw new __ArgumentException(nameof(kReturns));
	if (returnType is null) throw new __ArgumentNullException(nameof(returnType));
    return (AlternativeBlock1Block1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.AlternativeBlock1Block1((__InternalSyntaxToken)kReturns.Node, (InternalSyntax.TypeReferenceGreen)returnType.Green).CreateRed();
}

public AlternativeBlock1Block1Syntax AlternativeBlock1Block1(TypeReferenceSyntax returnType)
{
	return this.AlternativeBlock1Block1(this.Token(CompilerSyntaxKind.KReturns), returnType);
}

public TokenBlock1Alt1Block1Syntax TokenBlock1Alt1Block1(__SyntaxToken kReturns, TypeReferenceSyntax returnType)
{
	if (kReturns.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(kReturns));
	if (kReturns.RawKind != (int)CompilerSyntaxKind.KReturns) throw new __ArgumentException(nameof(kReturns));
	if (returnType is null) throw new __ArgumentNullException(nameof(returnType));
    return (TokenBlock1Alt1Block1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.TokenBlock1Alt1Block1((__InternalSyntaxToken)kReturns.Node, (InternalSyntax.TypeReferenceGreen)returnType.Green).CreateRed();
}

public TokenBlock1Alt1Block1Syntax TokenBlock1Alt1Block1(TypeReferenceSyntax returnType)
{
	return this.TokenBlock1Alt1Block1(this.Token(CompilerSyntaxKind.KReturns), returnType);
}

public ArrayExpressionItemsBlockSyntax ArrayExpressionItemsBlock(__SyntaxToken tComma, SingleExpressionSyntax items)
{
	if (tComma.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tComma));
	if (tComma.RawKind != (int)CompilerSyntaxKind.TComma) throw new __ArgumentException(nameof(tComma));
	if (items is null) throw new __ArgumentNullException(nameof(items));
    return (ArrayExpressionItemsBlockSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.ArrayExpressionItemsBlock((__InternalSyntaxToken)tComma.Node, (InternalSyntax.SingleExpressionGreen)items.Green).CreateRed();
}

public ArrayExpressionItemsBlockSyntax ArrayExpressionItemsBlock(SingleExpressionSyntax items)
{
	return this.ArrayExpressionItemsBlock(this.Token(CompilerSyntaxKind.TComma), items);
}
		
        internal static global::System.Collections.Generic.IEnumerable<__Type> GetNodeTypes()
        {
            return new __Type[] {
typeof(MainSyntax),
typeof(UsingSyntax),
typeof(LanguageDeclarationSyntax),
typeof(GrammarSyntax),
typeof(RuleSyntax),
typeof(TokenSyntax),
typeof(FragmentSyntax),
typeof(AlternativeSyntax),
typeof(ElementSyntax),
typeof(BlockSyntax),
typeof(Eof1Syntax),
typeof(FixedSyntax),
typeof(RuleRefAlt1Syntax),
typeof(RuleRefAlt2Syntax),
typeof(RuleRefAlt3Syntax),
typeof(BlockAlternativeSyntax),
typeof(LAlternativeSyntax),
typeof(LElementSyntax),
typeof(LElementValueTokensSyntax),
typeof(LBlockSyntax),
typeof(LRangeSyntax),
typeof(LReferenceSyntax),
typeof(ExpressionAlt1Syntax),
typeof(ArrayExpressionSyntax),
typeof(SingleExpressionSyntax),
typeof(ParserAnnotationSyntax),
typeof(LexerAnnotationSyntax),
typeof(AnnotationArgumentSyntax),
typeof(TypeReferenceIdentifierAlt1Syntax),
typeof(TypeReferenceIdentifierAlt2Syntax),
typeof(TypeReferenceAlt1Syntax),
typeof(TypeReferenceAlt2Syntax),
typeof(NameSyntax),
typeof(IdentifierSyntax),
typeof(MainBlock1Syntax),
typeof(RuleBlock1Alt1Syntax),
typeof(RuleBlock1Alt2Syntax),
typeof(RuleAlternativesBlockSyntax),
typeof(AlternativeBlock1Syntax),
typeof(AlternativeBlock2Syntax),
typeof(ElementBlock1Syntax),
typeof(BlockAlternativesBlockSyntax),
typeof(BlockAlternativeBlock1Syntax),
typeof(RuleRefAlt3ReferencedTypesBlockSyntax),
typeof(RuleRefAlt3Block1Syntax),
typeof(TokenBlock1Alt1Syntax),
typeof(TokenBlock1Alt2Syntax),
typeof(TokenAlternativesBlockSyntax),
typeof(FragmentAlternativesBlockSyntax),
typeof(LBlockAlternativesBlockSyntax),
typeof(TokensSyntax),
typeof(SingleExpressionBlock1Alt2Syntax),
typeof(SingleExpressionBlock1Alt3Syntax),
typeof(ParserAnnotationArgumentsBlockSyntax),
typeof(LexerAnnotationArgumentsBlockSyntax),
typeof(AnnotationArgumentBlock1Syntax),
typeof(MainQualifierBlockSyntax),
typeof(AlternativeBlock1Block1Syntax),
typeof(TokenBlock1Alt1Block1Syntax),
typeof(ArrayExpressionItemsBlockSyntax),
};
        }

    }
}	
