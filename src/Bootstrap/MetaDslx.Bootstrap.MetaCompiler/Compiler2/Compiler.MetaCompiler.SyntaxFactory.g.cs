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
			CancellationToken cancellationToken = default(CancellationToken))
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
			CancellationToken cancellationToken = default(CancellationToken))
		{
			return (CompilerSyntaxTree)this.ParseSyntaxTreeCore(text, options, path, cancellationToken);
		}

		protected override __SyntaxTree ParseSyntaxTreeCore(
			__SourceText text,
			__ParseOptions? options = null,
			string path = "",
			CancellationToken cancellationToken = default(CancellationToken))
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
        
		
			

        public MainSyntax Main(__SyntaxToken kNamespace, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<IdentifierSyntax> qualifier, __SyntaxToken tSemicolon, global::MetaDslx.CodeAnalysis.SyntaxList<UsingSyntax> usingList, DeclarationsSyntax declarations, __SyntaxToken endOfFileToken)
 {
 		
 		
 	if (kNamespace.RawKind != (int)__InternalSyntaxKind.None) throw new ArgumentNullException(nameof(kNamespace));
 		
 		
 		
 	if (kNamespace.RawKind != (int)CompilerSyntaxKind.KNamespace) throw new ArgumentException(nameof(kNamespace));
 		
 		
 		
 		
 		
 		
 		
 	if (tSemicolon.RawKind != (int)__InternalSyntaxKind.None) throw new ArgumentNullException(nameof(tSemicolon));
 		
 		
 		
 	if (tSemicolon.RawKind != (int)CompilerSyntaxKind.TSemicolon) throw new ArgumentException(nameof(tSemicolon));
 		
 		
 		
 		
 		
 		
 		
 	if (declarations is null) throw new ArgumentNullException(nameof(declarations));
 		
 		
 		
 		
 		
 	if (endOfFileToken.RawKind != (int)__InternalSyntaxKind.None) throw new ArgumentNullException(nameof(endOfFileToken));
 		
 		
 		
 	if (endOfFileToken.RawKind != (int)__InternalSyntaxKind.Eof) throw new ArgumentException(nameof(endOfFileToken));
 		
     return (MainSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.Main((__InternalSyntaxToken)kNamespace.Node, __GreenNodeExtensions.ToGreenSeparatedList<InternalSyntax.IdentifierGreen>(qualifier.Node, reversed: false), (__InternalSyntaxToken)tSemicolon.Node, __GreenNodeExtensions.ToGreenList<InternalSyntax.UsingGreen>(usingList.Node), (InternalSyntax.DeclarationsGreen)declarations.Green, (__InternalSyntaxToken)endOfFileToken.Node).CreateRed();
 }
 
 public MainSyntax Main(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<IdentifierSyntax> qualifier, global::MetaDslx.CodeAnalysis.SyntaxList<UsingSyntax> usingList, DeclarationsSyntax declarations, __SyntaxToken endOfFileToken)
 {
 	return this.Main(this.Token(CompilerSyntaxKind.KNamespace), qualifier, this.Token(CompilerSyntaxKind.TSemicolon), usingList, declarations, this.Token(CompilerSyntaxKind.Eof));
 }
			
		
			

        public UsingSyntax Using(__SyntaxToken kUsing, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<IdentifierSyntax> qualifier, __SyntaxToken tSemicolon)
 {
 		
 		
 	if (kUsing.RawKind != (int)__InternalSyntaxKind.None) throw new ArgumentNullException(nameof(kUsing));
 		
 		
 		
 	if (kUsing.RawKind != (int)CompilerSyntaxKind.KUsing) throw new ArgumentException(nameof(kUsing));
 		
 		
 		
 		
 		
 		
 		
 	if (tSemicolon.RawKind != (int)__InternalSyntaxKind.None) throw new ArgumentNullException(nameof(tSemicolon));
 		
 		
 		
 	if (tSemicolon.RawKind != (int)CompilerSyntaxKind.TSemicolon) throw new ArgumentException(nameof(tSemicolon));
 		
     return (UsingSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.Using((__InternalSyntaxToken)kUsing.Node, __GreenNodeExtensions.ToGreenSeparatedList<InternalSyntax.IdentifierGreen>(qualifier.Node, reversed: false), (__InternalSyntaxToken)tSemicolon.Node).CreateRed();
 }
 
 public UsingSyntax Using(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<IdentifierSyntax> qualifier)
 {
 	return this.Using(this.Token(CompilerSyntaxKind.KUsing), qualifier, this.Token(CompilerSyntaxKind.TSemicolon));
 }
			
		
			

        public DeclarationsSyntax Declarations(LanguageDeclarationSyntax declarations1, global::MetaDslx.CodeAnalysis.SyntaxList<RuleSyntax> declarations2)
 {
 		
 		
 	if (declarations1 is null) throw new ArgumentNullException(nameof(declarations1));
 		
 		
 		
 		
 		
 		
 		
     return (DeclarationsSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.Declarations((InternalSyntax.LanguageDeclarationGreen)declarations1.Green, __GreenNodeExtensions.ToGreenList<InternalSyntax.RuleGreen>(declarations2.Node)).CreateRed();
 }
			
		
			

        public LanguageDeclarationSyntax LanguageDeclaration(__SyntaxToken kLanguage, NameSyntax name, __SyntaxToken tSemicolon, GrammarSyntax grammar)
 {
 		
 		
 	if (kLanguage.RawKind != (int)__InternalSyntaxKind.None) throw new ArgumentNullException(nameof(kLanguage));
 		
 		
 		
 	if (kLanguage.RawKind != (int)CompilerSyntaxKind.KLanguage) throw new ArgumentException(nameof(kLanguage));
 		
 		
 		
 	if (name is null) throw new ArgumentNullException(nameof(name));
 		
 		
 		
 		
 		
 	if (tSemicolon.RawKind != (int)__InternalSyntaxKind.None) throw new ArgumentNullException(nameof(tSemicolon));
 		
 		
 		
 	if (tSemicolon.RawKind != (int)CompilerSyntaxKind.TSemicolon) throw new ArgumentException(nameof(tSemicolon));
 		
 		
 		
 	if (grammar is null) throw new ArgumentNullException(nameof(grammar));
 		
 		
 		
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
			
		
			

        public GrammarRuleAlt1Syntax GrammarRuleAlt1(RuleSyntax rule)
 {
 		
 		
 	if (rule is null) throw new ArgumentNullException(nameof(rule));
 		
 		
 		
     return (GrammarRuleAlt1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.GrammarRuleAlt1((InternalSyntax.RuleGreen)rule.Green).CreateRed();
 }
			

        public BlockSyntax Block(global::MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> annotations1, __SyntaxToken kBlock, NameSyntax name, BlockBlock1Syntax block, __SyntaxToken tColon, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<AlternativeSyntax> alternatives, __SyntaxToken tSemicolon)
 {
 		
 		
 		
 		
 		
 		
 	if (kBlock.RawKind != (int)__InternalSyntaxKind.None) throw new ArgumentNullException(nameof(kBlock));
 		
 		
 		
 	if (kBlock.RawKind != (int)CompilerSyntaxKind.KBlock) throw new ArgumentException(nameof(kBlock));
 		
 		
 		
 	if (name is null) throw new ArgumentNullException(nameof(name));
 		
 		
 		
 		
 		
 		
 		
 		
 		
 	if (tColon.RawKind != (int)__InternalSyntaxKind.None) throw new ArgumentNullException(nameof(tColon));
 		
 		
 		
 	if (tColon.RawKind != (int)CompilerSyntaxKind.TColon) throw new ArgumentException(nameof(tColon));
 		
 		
 		
 		
 		
 		
 		
 	if (tSemicolon.RawKind != (int)__InternalSyntaxKind.None) throw new ArgumentNullException(nameof(tSemicolon));
 		
 		
 		
 	if (tSemicolon.RawKind != (int)CompilerSyntaxKind.TSemicolon) throw new ArgumentException(nameof(tSemicolon));
 		
     return (BlockSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.Block(__GreenNodeExtensions.ToGreenList<InternalSyntax.ParserAnnotationGreen>(annotations1.Node), (__InternalSyntaxToken)kBlock.Node, (InternalSyntax.NameGreen)name.Green, (InternalSyntax.BlockBlock1Green)block.Green, (__InternalSyntaxToken)tColon.Node, __GreenNodeExtensions.ToGreenSeparatedList<InternalSyntax.AlternativeGreen>(alternatives.Node, reversed: false), (__InternalSyntaxToken)tSemicolon.Node).CreateRed();
 }
 
 public BlockSyntax Block(global::MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> annotations1, NameSyntax name, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<AlternativeSyntax> alternatives)
 {
 	return this.Block(annotations1, this.Token(CompilerSyntaxKind.KBlock), name, default, this.Token(CompilerSyntaxKind.TColon), alternatives, this.Token(CompilerSyntaxKind.TSemicolon));
 }
			

        public TokenSyntax Token(global::MetaDslx.CodeAnalysis.SyntaxList<LexerAnnotationSyntax> annotations1, TokenBlock1Syntax block, __SyntaxToken tColon, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<LAlternativeSyntax> alternatives, __SyntaxToken tSemicolon)
 {
 		
 		
 		
 		
 		
 		
 	if (block is null) throw new ArgumentNullException(nameof(block));
 		
 		
 		
 		
 		
 	if (tColon.RawKind != (int)__InternalSyntaxKind.None) throw new ArgumentNullException(nameof(tColon));
 		
 		
 		
 	if (tColon.RawKind != (int)CompilerSyntaxKind.TColon) throw new ArgumentException(nameof(tColon));
 		
 		
 		
 		
 		
 		
 		
 	if (tSemicolon.RawKind != (int)__InternalSyntaxKind.None) throw new ArgumentNullException(nameof(tSemicolon));
 		
 		
 		
 	if (tSemicolon.RawKind != (int)CompilerSyntaxKind.TSemicolon) throw new ArgumentException(nameof(tSemicolon));
 		
     return (TokenSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.Token(__GreenNodeExtensions.ToGreenList<InternalSyntax.LexerAnnotationGreen>(annotations1.Node), (InternalSyntax.TokenBlock1Green)block.Green, (__InternalSyntaxToken)tColon.Node, __GreenNodeExtensions.ToGreenSeparatedList<InternalSyntax.LAlternativeGreen>(alternatives.Node, reversed: false), (__InternalSyntaxToken)tSemicolon.Node).CreateRed();
 }
 
 public TokenSyntax Token(global::MetaDslx.CodeAnalysis.SyntaxList<LexerAnnotationSyntax> annotations1, TokenBlock1Syntax block, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<LAlternativeSyntax> alternatives)
 {
 	return this.Token(annotations1, block, this.Token(CompilerSyntaxKind.TColon), alternatives, this.Token(CompilerSyntaxKind.TSemicolon));
 }
			

        public FragmentSyntax Fragment(__SyntaxToken kFragment, NameSyntax name, __SyntaxToken tColon, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<LAlternativeSyntax> alternatives, __SyntaxToken tSemicolon)
 {
 		
 		
 	if (kFragment.RawKind != (int)__InternalSyntaxKind.None) throw new ArgumentNullException(nameof(kFragment));
 		
 		
 		
 	if (kFragment.RawKind != (int)CompilerSyntaxKind.KFragment) throw new ArgumentException(nameof(kFragment));
 		
 		
 		
 	if (name is null) throw new ArgumentNullException(nameof(name));
 		
 		
 		
 		
 		
 	if (tColon.RawKind != (int)__InternalSyntaxKind.None) throw new ArgumentNullException(nameof(tColon));
 		
 		
 		
 	if (tColon.RawKind != (int)CompilerSyntaxKind.TColon) throw new ArgumentException(nameof(tColon));
 		
 		
 		
 		
 		
 		
 		
 	if (tSemicolon.RawKind != (int)__InternalSyntaxKind.None) throw new ArgumentNullException(nameof(tSemicolon));
 		
 		
 		
 	if (tSemicolon.RawKind != (int)CompilerSyntaxKind.TSemicolon) throw new ArgumentException(nameof(tSemicolon));
 		
     return (FragmentSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.Fragment((__InternalSyntaxToken)kFragment.Node, (InternalSyntax.NameGreen)name.Green, (__InternalSyntaxToken)tColon.Node, __GreenNodeExtensions.ToGreenSeparatedList<InternalSyntax.LAlternativeGreen>(alternatives.Node, reversed: false), (__InternalSyntaxToken)tSemicolon.Node).CreateRed();
 }
 
 public FragmentSyntax Fragment(NameSyntax name, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<LAlternativeSyntax> alternatives)
 {
 	return this.Fragment(this.Token(CompilerSyntaxKind.KFragment), name, this.Token(CompilerSyntaxKind.TColon), alternatives, this.Token(CompilerSyntaxKind.TSemicolon));
 }
			
		
			

        public RuleSyntax Rule(global::MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> annotations1, RuleBlock1Syntax block, __SyntaxToken tColon, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<AlternativeSyntax> alternatives, __SyntaxToken tSemicolon)
 {
 		
 		
 		
 		
 		
 		
 	if (block is null) throw new ArgumentNullException(nameof(block));
 		
 		
 		
 		
 		
 	if (tColon.RawKind != (int)__InternalSyntaxKind.None) throw new ArgumentNullException(nameof(tColon));
 		
 		
 		
 	if (tColon.RawKind != (int)CompilerSyntaxKind.TColon) throw new ArgumentException(nameof(tColon));
 		
 		
 		
 		
 		
 		
 		
 	if (tSemicolon.RawKind != (int)__InternalSyntaxKind.None) throw new ArgumentNullException(nameof(tSemicolon));
 		
 		
 		
 	if (tSemicolon.RawKind != (int)CompilerSyntaxKind.TSemicolon) throw new ArgumentException(nameof(tSemicolon));
 		
     return (RuleSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.Rule(__GreenNodeExtensions.ToGreenList<InternalSyntax.ParserAnnotationGreen>(annotations1.Node), (InternalSyntax.RuleBlock1Green)block.Green, (__InternalSyntaxToken)tColon.Node, __GreenNodeExtensions.ToGreenSeparatedList<InternalSyntax.AlternativeGreen>(alternatives.Node, reversed: false), (__InternalSyntaxToken)tSemicolon.Node).CreateRed();
 }
 
 public RuleSyntax Rule(global::MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> annotations1, RuleBlock1Syntax block, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<AlternativeSyntax> alternatives)
 {
 	return this.Rule(annotations1, block, this.Token(CompilerSyntaxKind.TColon), alternatives, this.Token(CompilerSyntaxKind.TSemicolon));
 }
			
		
			

        public AlternativeSyntax Alternative(AlternativeBlock1Syntax block1, global::MetaDslx.CodeAnalysis.SyntaxList<ElementSyntax> elements, AlternativeBlock2Syntax block2)
 {
 		
 		
 		
 		
 		
 		
 		
 		
 		
 		
 		
 		
     return (AlternativeSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.Alternative((InternalSyntax.AlternativeBlock1Green)block1.Green, __GreenNodeExtensions.ToGreenList<InternalSyntax.ElementGreen>(elements.Node), (InternalSyntax.AlternativeBlock2Green)block2.Green).CreateRed();
 }
 
 public AlternativeSyntax Alternative(global::MetaDslx.CodeAnalysis.SyntaxList<ElementSyntax> elements)
 {
 	return this.Alternative(default, elements, default);
 }
			
		
			

        public ElementSyntax Element(ElementBlock1Syntax block, global::MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> valueAnnotations, ElementValueSyntax value, __SyntaxToken multiplicity)
 {
 		
 		
 		
 		
 		
 		
 		
 		
 		
 		
 	if (value is null) throw new ArgumentNullException(nameof(value));
 		
 		
 		
 		
 		
 		
 		
 	if (multiplicity.RawKind != (int)__InternalSyntaxKind.None && (multiplicity.RawKind != (int)CompilerSyntaxKind.TQuestion && multiplicity.RawKind != (int)CompilerSyntaxKind.TAsterisk && multiplicity.RawKind != (int)CompilerSyntaxKind.TPlus && multiplicity.RawKind != (int)CompilerSyntaxKind.TQuestionQuestion && multiplicity.RawKind != (int)CompilerSyntaxKind.TAsteriskQuestion && multiplicity.RawKind != (int)CompilerSyntaxKind.TPlusQuestion)) throw new ArgumentException(nameof(multiplicity));
 		
     return (ElementSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.Element((InternalSyntax.ElementBlock1Green)block.Green, __GreenNodeExtensions.ToGreenList<InternalSyntax.ParserAnnotationGreen>(valueAnnotations.Node), (InternalSyntax.ElementValueGreen)value.Green, (__InternalSyntaxToken)multiplicity.Node).CreateRed();
 }
 
 public ElementSyntax Element(global::MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> valueAnnotations, ElementValueSyntax value)
 {
 	return this.Element(default, valueAnnotations, value, default);
 }
			
		
			

        public ElementValueTokensSyntax ElementValueTokens(__SyntaxToken token)
 {
 		
 		
 	if (token.RawKind != (int)__InternalSyntaxKind.None) throw new ArgumentNullException(nameof(token));
 		
 		
 		
 	if (token.RawKind != (int)CompilerSyntaxKind.KEof && token.RawKind != (int)CompilerSyntaxKind.TString) throw new ArgumentException(nameof(token));
 		
     return (ElementValueTokensSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.ElementValueTokens((__InternalSyntaxToken)token.Node).CreateRed();
 }
			

        public BlockInlineSyntax BlockInline(__SyntaxToken tLParen, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<AlternativeSyntax> alternatives, __SyntaxToken tRParen)
 {
 		
 		
 	if (tLParen.RawKind != (int)__InternalSyntaxKind.None) throw new ArgumentNullException(nameof(tLParen));
 		
 		
 		
 	if (tLParen.RawKind != (int)CompilerSyntaxKind.TLParen) throw new ArgumentException(nameof(tLParen));
 		
 		
 		
 		
 		
 		
 		
 	if (tRParen.RawKind != (int)__InternalSyntaxKind.None) throw new ArgumentNullException(nameof(tRParen));
 		
 		
 		
 	if (tRParen.RawKind != (int)CompilerSyntaxKind.TRParen) throw new ArgumentException(nameof(tRParen));
 		
     return (BlockInlineSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.BlockInline((__InternalSyntaxToken)tLParen.Node, __GreenNodeExtensions.ToGreenSeparatedList<InternalSyntax.AlternativeGreen>(alternatives.Node, reversed: false), (__InternalSyntaxToken)tRParen.Node).CreateRed();
 }
 
 public BlockInlineSyntax BlockInline(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<AlternativeSyntax> alternatives)
 {
 	return this.BlockInline(this.Token(CompilerSyntaxKind.TLParen), alternatives, this.Token(CompilerSyntaxKind.TRParen));
 }
			

        public RuleRefAlt1Syntax RuleRefAlt1(IdentifierSyntax grammarRule)
 {
 		
 		
 	if (grammarRule is null) throw new ArgumentNullException(nameof(grammarRule));
 		
 		
 		
     return (RuleRefAlt1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.RuleRefAlt1((InternalSyntax.IdentifierGreen)grammarRule.Green).CreateRed();
 }
			

        public RuleRefAlt2Syntax RuleRefAlt2(__SyntaxToken tHash, ReturnTypeQualifierSyntax referencedTypes)
 {
 		
 		
 	if (tHash.RawKind != (int)__InternalSyntaxKind.None) throw new ArgumentNullException(nameof(tHash));
 		
 		
 		
 	if (tHash.RawKind != (int)CompilerSyntaxKind.THash) throw new ArgumentException(nameof(tHash));
 		
 		
 		
 	if (referencedTypes is null) throw new ArgumentNullException(nameof(referencedTypes));
 		
 		
 		
     return (RuleRefAlt2Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.RuleRefAlt2((__InternalSyntaxToken)tHash.Node, (InternalSyntax.ReturnTypeQualifierGreen)referencedTypes.Green).CreateRed();
 }
 
 public RuleRefAlt2Syntax RuleRefAlt2(ReturnTypeQualifierSyntax referencedTypes)
 {
 	return this.RuleRefAlt2(this.Token(CompilerSyntaxKind.THash), referencedTypes);
 }
			

        public RuleRefAlt3Syntax RuleRefAlt3(__SyntaxToken tHashLBrace, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<ReturnTypeQualifierSyntax> referencedTypes, __SyntaxToken tRBrace)
 {
 		
 		
 	if (tHashLBrace.RawKind != (int)__InternalSyntaxKind.None) throw new ArgumentNullException(nameof(tHashLBrace));
 		
 		
 		
 	if (tHashLBrace.RawKind != (int)CompilerSyntaxKind.THashLBrace) throw new ArgumentException(nameof(tHashLBrace));
 		
 		
 		
 		
 		
 		
 		
 	if (tRBrace.RawKind != (int)__InternalSyntaxKind.None) throw new ArgumentNullException(nameof(tRBrace));
 		
 		
 		
 	if (tRBrace.RawKind != (int)CompilerSyntaxKind.TRBrace) throw new ArgumentException(nameof(tRBrace));
 		
     return (RuleRefAlt3Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.RuleRefAlt3((__InternalSyntaxToken)tHashLBrace.Node, __GreenNodeExtensions.ToGreenSeparatedList<InternalSyntax.ReturnTypeQualifierGreen>(referencedTypes.Node, reversed: false), (__InternalSyntaxToken)tRBrace.Node).CreateRed();
 }
 
 public RuleRefAlt3Syntax RuleRefAlt3(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<ReturnTypeQualifierSyntax> referencedTypes)
 {
 	return this.RuleRefAlt3(this.Token(CompilerSyntaxKind.THashLBrace), referencedTypes, this.Token(CompilerSyntaxKind.TRBrace));
 }
			
		
			

        public LAlternativeSyntax LAlternative(global::MetaDslx.CodeAnalysis.SyntaxList<LElementSyntax> elements)
 {
 		
 		
 		
 		
     return (LAlternativeSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.LAlternative(__GreenNodeExtensions.ToGreenList<InternalSyntax.LElementGreen>(elements.Node)).CreateRed();
 }
			
		
			

        public LElementSyntax LElement(__SyntaxToken isNegated, LElementValueSyntax value, __SyntaxToken multiplicity)
 {
 		
 		
 		
 		
 	if (isNegated.RawKind != (int)__InternalSyntaxKind.None && (isNegated.RawKind != (int)CompilerSyntaxKind.TTilde)) throw new ArgumentException(nameof(isNegated));
 		
 		
 		
 	if (value is null) throw new ArgumentNullException(nameof(value));
 		
 		
 		
 		
 		
 		
 		
 	if (multiplicity.RawKind != (int)__InternalSyntaxKind.None && (multiplicity.RawKind != (int)CompilerSyntaxKind.TQuestion && multiplicity.RawKind != (int)CompilerSyntaxKind.TAsterisk && multiplicity.RawKind != (int)CompilerSyntaxKind.TPlus && multiplicity.RawKind != (int)CompilerSyntaxKind.TQuestionQuestion && multiplicity.RawKind != (int)CompilerSyntaxKind.TAsteriskQuestion && multiplicity.RawKind != (int)CompilerSyntaxKind.TPlusQuestion)) throw new ArgumentException(nameof(multiplicity));
 		
     return (LElementSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.LElement((__InternalSyntaxToken)isNegated.Node, (InternalSyntax.LElementValueGreen)value.Green, (__InternalSyntaxToken)multiplicity.Node).CreateRed();
 }
 
 public LElementSyntax LElement(LElementValueSyntax value)
 {
 	return this.LElement(default, value, default);
 }
			
		
			

        public LElementValueTokensSyntax LElementValueTokens(__SyntaxToken token)
 {
 		
 		
 	if (token.RawKind != (int)__InternalSyntaxKind.None) throw new ArgumentNullException(nameof(token));
 		
 		
 		
 	if (token.RawKind != (int)CompilerSyntaxKind.TString && token.RawKind != (int)CompilerSyntaxKind.TDot) throw new ArgumentException(nameof(token));
 		
     return (LElementValueTokensSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.LElementValueTokens((__InternalSyntaxToken)token.Node).CreateRed();
 }
			

        public LBlockSyntax LBlock(__SyntaxToken tLParen, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<LAlternativeSyntax> alternatives, __SyntaxToken tRParen)
 {
 		
 		
 	if (tLParen.RawKind != (int)__InternalSyntaxKind.None) throw new ArgumentNullException(nameof(tLParen));
 		
 		
 		
 	if (tLParen.RawKind != (int)CompilerSyntaxKind.TLParen) throw new ArgumentException(nameof(tLParen));
 		
 		
 		
 		
 		
 		
 		
 	if (tRParen.RawKind != (int)__InternalSyntaxKind.None) throw new ArgumentNullException(nameof(tRParen));
 		
 		
 		
 	if (tRParen.RawKind != (int)CompilerSyntaxKind.TRParen) throw new ArgumentException(nameof(tRParen));
 		
     return (LBlockSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.LBlock((__InternalSyntaxToken)tLParen.Node, __GreenNodeExtensions.ToGreenSeparatedList<InternalSyntax.LAlternativeGreen>(alternatives.Node, reversed: false), (__InternalSyntaxToken)tRParen.Node).CreateRed();
 }
 
 public LBlockSyntax LBlock(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<LAlternativeSyntax> alternatives)
 {
 	return this.LBlock(this.Token(CompilerSyntaxKind.TLParen), alternatives, this.Token(CompilerSyntaxKind.TRParen));
 }
			

        public LRangeSyntax LRange(__SyntaxToken startChar, __SyntaxToken tDotDot, __SyntaxToken endChar)
 {
 		
 		
 	if (startChar.RawKind != (int)__InternalSyntaxKind.None) throw new ArgumentNullException(nameof(startChar));
 		
 		
 		
 	if (startChar.RawKind != (int)CompilerSyntaxKind.TString) throw new ArgumentException(nameof(startChar));
 		
 		
 		
 	if (tDotDot.RawKind != (int)__InternalSyntaxKind.None) throw new ArgumentNullException(nameof(tDotDot));
 		
 		
 		
 	if (tDotDot.RawKind != (int)CompilerSyntaxKind.TDotDot) throw new ArgumentException(nameof(tDotDot));
 		
 		
 		
 	if (endChar.RawKind != (int)__InternalSyntaxKind.None) throw new ArgumentNullException(nameof(endChar));
 		
 		
 		
 	if (endChar.RawKind != (int)CompilerSyntaxKind.TString) throw new ArgumentException(nameof(endChar));
 		
     return (LRangeSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.LRange((__InternalSyntaxToken)startChar.Node, (__InternalSyntaxToken)tDotDot.Node, (__InternalSyntaxToken)endChar.Node).CreateRed();
 }
 
 public LRangeSyntax LRange(__SyntaxToken startChar, __SyntaxToken endChar)
 {
 	return this.LRange(this.Token(CompilerSyntaxKind.TString), this.Token(CompilerSyntaxKind.TDotDot), this.Token(CompilerSyntaxKind.TString));
 }
			

        public LReferenceSyntax LReference(IdentifierSyntax rule)
 {
 		
 		
 	if (rule is null) throw new ArgumentNullException(nameof(rule));
 		
 		
 		
     return (LReferenceSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.LReference((InternalSyntax.IdentifierGreen)rule.Green).CreateRed();
 }
			
		
			

        public ExpressionAlt1Syntax ExpressionAlt1(SingleExpressionSyntax singleExpression)
 {
 		
 		
 	if (singleExpression is null) throw new ArgumentNullException(nameof(singleExpression));
 		
 		
 		
     return (ExpressionAlt1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.ExpressionAlt1((InternalSyntax.SingleExpressionGreen)singleExpression.Green).CreateRed();
 }
			

        public ArrayExpressionSyntax ArrayExpression(__SyntaxToken tLBrace, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<SingleExpressionSyntax> items, __SyntaxToken tRBrace)
 {
 		
 		
 	if (tLBrace.RawKind != (int)__InternalSyntaxKind.None) throw new ArgumentNullException(nameof(tLBrace));
 		
 		
 		
 	if (tLBrace.RawKind != (int)CompilerSyntaxKind.TLBrace) throw new ArgumentException(nameof(tLBrace));
 		
 		
 		
 		
 		
 		
 		
 	if (tRBrace.RawKind != (int)__InternalSyntaxKind.None) throw new ArgumentNullException(nameof(tRBrace));
 		
 		
 		
 	if (tRBrace.RawKind != (int)CompilerSyntaxKind.TRBrace) throw new ArgumentException(nameof(tRBrace));
 		
     return (ArrayExpressionSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.ArrayExpression((__InternalSyntaxToken)tLBrace.Node, __GreenNodeExtensions.ToGreenSeparatedList<InternalSyntax.SingleExpressionGreen>(items.Node, reversed: false), (__InternalSyntaxToken)tRBrace.Node).CreateRed();
 }
 
 public ArrayExpressionSyntax ArrayExpression()
 {
 	return this.ArrayExpression(this.Token(CompilerSyntaxKind.TLBrace), default, this.Token(CompilerSyntaxKind.TRBrace));
 }
			
		
			

        public SingleExpressionSyntax SingleExpression(SingleExpressionBlock1Syntax value)
 {
 		
 		
 	if (value is null) throw new ArgumentNullException(nameof(value));
 		
 		
 		
     return (SingleExpressionSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.SingleExpression((InternalSyntax.SingleExpressionBlock1Green)value.Green).CreateRed();
 }
			
		
			

        public ParserAnnotationSyntax ParserAnnotation(__SyntaxToken tLBracket, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<IdentifierSyntax> qualifier, AnnotationArgumentsSyntax annotationArguments, __SyntaxToken tRBracket)
 {
 		
 		
 	if (tLBracket.RawKind != (int)__InternalSyntaxKind.None) throw new ArgumentNullException(nameof(tLBracket));
 		
 		
 		
 	if (tLBracket.RawKind != (int)CompilerSyntaxKind.TLBracket) throw new ArgumentException(nameof(tLBracket));
 		
 		
 		
 		
 		
 		
 		
 		
 		
 		
 		
 	if (tRBracket.RawKind != (int)__InternalSyntaxKind.None) throw new ArgumentNullException(nameof(tRBracket));
 		
 		
 		
 	if (tRBracket.RawKind != (int)CompilerSyntaxKind.TRBracket) throw new ArgumentException(nameof(tRBracket));
 		
     return (ParserAnnotationSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.ParserAnnotation((__InternalSyntaxToken)tLBracket.Node, __GreenNodeExtensions.ToGreenSeparatedList<InternalSyntax.IdentifierGreen>(qualifier.Node, reversed: false), (InternalSyntax.AnnotationArgumentsGreen)annotationArguments.Green, (__InternalSyntaxToken)tRBracket.Node).CreateRed();
 }
 
 public ParserAnnotationSyntax ParserAnnotation(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<IdentifierSyntax> qualifier)
 {
 	return this.ParserAnnotation(this.Token(CompilerSyntaxKind.TLBracket), qualifier, default, this.Token(CompilerSyntaxKind.TRBracket));
 }
			
		
			

        public LexerAnnotationSyntax LexerAnnotation(__SyntaxToken tLBracket, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<IdentifierSyntax> qualifier, AnnotationArgumentsSyntax annotationArguments, __SyntaxToken tRBracket)
 {
 		
 		
 	if (tLBracket.RawKind != (int)__InternalSyntaxKind.None) throw new ArgumentNullException(nameof(tLBracket));
 		
 		
 		
 	if (tLBracket.RawKind != (int)CompilerSyntaxKind.TLBracket) throw new ArgumentException(nameof(tLBracket));
 		
 		
 		
 		
 		
 		
 		
 		
 		
 		
 		
 	if (tRBracket.RawKind != (int)__InternalSyntaxKind.None) throw new ArgumentNullException(nameof(tRBracket));
 		
 		
 		
 	if (tRBracket.RawKind != (int)CompilerSyntaxKind.TRBracket) throw new ArgumentException(nameof(tRBracket));
 		
     return (LexerAnnotationSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.LexerAnnotation((__InternalSyntaxToken)tLBracket.Node, __GreenNodeExtensions.ToGreenSeparatedList<InternalSyntax.IdentifierGreen>(qualifier.Node, reversed: false), (InternalSyntax.AnnotationArgumentsGreen)annotationArguments.Green, (__InternalSyntaxToken)tRBracket.Node).CreateRed();
 }
 
 public LexerAnnotationSyntax LexerAnnotation(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<IdentifierSyntax> qualifier)
 {
 	return this.LexerAnnotation(this.Token(CompilerSyntaxKind.TLBracket), qualifier, default, this.Token(CompilerSyntaxKind.TRBracket));
 }
			
		
			

        public AnnotationArgumentsSyntax AnnotationArguments(__SyntaxToken tLParen, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<AnnotationArgumentSyntax> arguments, __SyntaxToken tRParen)
 {
 		
 		
 	if (tLParen.RawKind != (int)__InternalSyntaxKind.None) throw new ArgumentNullException(nameof(tLParen));
 		
 		
 		
 	if (tLParen.RawKind != (int)CompilerSyntaxKind.TLParen) throw new ArgumentException(nameof(tLParen));
 		
 		
 		
 		
 		
 		
 		
 	if (tRParen.RawKind != (int)__InternalSyntaxKind.None) throw new ArgumentNullException(nameof(tRParen));
 		
 		
 		
 	if (tRParen.RawKind != (int)CompilerSyntaxKind.TRParen) throw new ArgumentException(nameof(tRParen));
 		
     return (AnnotationArgumentsSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.AnnotationArguments((__InternalSyntaxToken)tLParen.Node, __GreenNodeExtensions.ToGreenSeparatedList<InternalSyntax.AnnotationArgumentGreen>(arguments.Node, reversed: false), (__InternalSyntaxToken)tRParen.Node).CreateRed();
 }
 
 public AnnotationArgumentsSyntax AnnotationArguments(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<AnnotationArgumentSyntax> arguments)
 {
 	return this.AnnotationArguments(this.Token(CompilerSyntaxKind.TLParen), arguments, this.Token(CompilerSyntaxKind.TRParen));
 }
			
		
			

        public AnnotationArgumentSyntax AnnotationArgument(AnnotationArgumentBlock1Syntax block, ExpressionSyntax value)
 {
 		
 		
 		
 		
 		
 		
 	if (value is null) throw new ArgumentNullException(nameof(value));
 		
 		
 		
     return (AnnotationArgumentSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.AnnotationArgument((InternalSyntax.AnnotationArgumentBlock1Green)block.Green, (InternalSyntax.ExpressionGreen)value.Green).CreateRed();
 }
 
 public AnnotationArgumentSyntax AnnotationArgument(ExpressionSyntax value)
 {
 	return this.AnnotationArgument(default, value);
 }
			
		
			

        public ReturnTypeIdentifierAlt1Syntax ReturnTypeIdentifierAlt1(__SyntaxToken tokens)
 {
 		
 		
 	if (tokens.RawKind != (int)__InternalSyntaxKind.None) throw new ArgumentNullException(nameof(tokens));
 		
 		
 		
 	if (tokens.RawKind != (int)CompilerSyntaxKind.KBool && tokens.RawKind != (int)CompilerSyntaxKind.KInt && tokens.RawKind != (int)CompilerSyntaxKind.KString && tokens.RawKind != (int)CompilerSyntaxKind.KType && tokens.RawKind != (int)CompilerSyntaxKind.KSymbol && tokens.RawKind != (int)CompilerSyntaxKind.KObject && tokens.RawKind != (int)CompilerSyntaxKind.KVoid) throw new ArgumentException(nameof(tokens));
 		
     return (ReturnTypeIdentifierAlt1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.ReturnTypeIdentifierAlt1((__InternalSyntaxToken)tokens.Node).CreateRed();
 }
			

        public ReturnTypeIdentifierAlt2Syntax ReturnTypeIdentifierAlt2(IdentifierSyntax identifier)
 {
 		
 		
 	if (identifier is null) throw new ArgumentNullException(nameof(identifier));
 		
 		
 		
     return (ReturnTypeIdentifierAlt2Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.ReturnTypeIdentifierAlt2((InternalSyntax.IdentifierGreen)identifier.Green).CreateRed();
 }
			
		
			

        public ReturnTypeQualifierAlt1Syntax ReturnTypeQualifierAlt1(__SyntaxToken tokens)
 {
 		
 		
 	if (tokens.RawKind != (int)__InternalSyntaxKind.None) throw new ArgumentNullException(nameof(tokens));
 		
 		
 		
 	if (tokens.RawKind != (int)CompilerSyntaxKind.KBool && tokens.RawKind != (int)CompilerSyntaxKind.KInt && tokens.RawKind != (int)CompilerSyntaxKind.KString && tokens.RawKind != (int)CompilerSyntaxKind.KType && tokens.RawKind != (int)CompilerSyntaxKind.KSymbol && tokens.RawKind != (int)CompilerSyntaxKind.KObject && tokens.RawKind != (int)CompilerSyntaxKind.KVoid) throw new ArgumentException(nameof(tokens));
 		
     return (ReturnTypeQualifierAlt1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.ReturnTypeQualifierAlt1((__InternalSyntaxToken)tokens.Node).CreateRed();
 }
			

        public ReturnTypeQualifierAlt2Syntax ReturnTypeQualifierAlt2(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<IdentifierSyntax> qualifier)
 {
 		
 		
 		
 		
     return (ReturnTypeQualifierAlt2Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.ReturnTypeQualifierAlt2(__GreenNodeExtensions.ToGreenSeparatedList<InternalSyntax.IdentifierGreen>(qualifier.Node, reversed: false)).CreateRed();
 }
			
		
			

        public NameSyntax Name(IdentifierSyntax identifier)
 {
 		
 		
 	if (identifier is null) throw new ArgumentNullException(nameof(identifier));
 		
 		
 		
     return (NameSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.Name((InternalSyntax.IdentifierGreen)identifier.Green).CreateRed();
 }
			
		
			

        public IdentifierSyntax Identifier(__SyntaxToken token)
 {
 		
 		
 	if (token.RawKind != (int)__InternalSyntaxKind.None) throw new ArgumentNullException(nameof(token));
 		
 		
 		
 	if (token.RawKind != (int)CompilerSyntaxKind.TIdentifier && token.RawKind != (int)CompilerSyntaxKind.TVerbatimIdentifier) throw new ArgumentException(nameof(token));
 		
     return (IdentifierSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.Identifier((__InternalSyntaxToken)token.Node).CreateRed();
 }
			
		
			

        public SimpleIdentifierSyntax SimpleIdentifier(__SyntaxToken tIdentifier)
 {
 		
 		
 	if (tIdentifier.RawKind != (int)__InternalSyntaxKind.None) throw new ArgumentNullException(nameof(tIdentifier));
 		
 		
 		
 	if (tIdentifier.RawKind != (int)CompilerSyntaxKind.TIdentifier) throw new ArgumentException(nameof(tIdentifier));
 		
     return (SimpleIdentifierSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.SimpleIdentifier((__InternalSyntaxToken)tIdentifier.Node).CreateRed();
 }
			
		
			

        public RuleBlock1Alt1Syntax RuleBlock1Alt1(ReturnTypeIdentifierSyntax returnType)
 {
 		
 		
 	if (returnType is null) throw new ArgumentNullException(nameof(returnType));
 		
 		
 		
     return (RuleBlock1Alt1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.RuleBlock1Alt1((InternalSyntax.ReturnTypeIdentifierGreen)returnType.Green).CreateRed();
 }
			

        public RuleBlock1Alt2Syntax RuleBlock1Alt2(IdentifierSyntax identifier, __SyntaxToken kReturns, ReturnTypeQualifierSyntax returnType)
 {
 		
 		
 	if (identifier is null) throw new ArgumentNullException(nameof(identifier));
 		
 		
 		
 		
 		
 	if (kReturns.RawKind != (int)__InternalSyntaxKind.None) throw new ArgumentNullException(nameof(kReturns));
 		
 		
 		
 	if (kReturns.RawKind != (int)CompilerSyntaxKind.KReturns) throw new ArgumentException(nameof(kReturns));
 		
 		
 		
 	if (returnType is null) throw new ArgumentNullException(nameof(returnType));
 		
 		
 		
     return (RuleBlock1Alt2Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.RuleBlock1Alt2((InternalSyntax.IdentifierGreen)identifier.Green, (__InternalSyntaxToken)kReturns.Node, (InternalSyntax.ReturnTypeQualifierGreen)returnType.Green).CreateRed();
 }
 
 public RuleBlock1Alt2Syntax RuleBlock1Alt2(IdentifierSyntax identifier, ReturnTypeQualifierSyntax returnType)
 {
 	return this.RuleBlock1Alt2(identifier, this.Token(CompilerSyntaxKind.KReturns), returnType);
 }
			
		
			

        public RuleAlternativesBlockSyntax RuleAlternativesBlock(__SyntaxToken tBar, AlternativeSyntax alternatives)
 {
 		
 		
 	if (tBar.RawKind != (int)__InternalSyntaxKind.None) throw new ArgumentNullException(nameof(tBar));
 		
 		
 		
 	if (tBar.RawKind != (int)CompilerSyntaxKind.TBar) throw new ArgumentException(nameof(tBar));
 		
 		
 		
 	if (alternatives is null) throw new ArgumentNullException(nameof(alternatives));
 		
 		
 		
     return (RuleAlternativesBlockSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.RuleAlternativesBlock((__InternalSyntaxToken)tBar.Node, (InternalSyntax.AlternativeGreen)alternatives.Green).CreateRed();
 }
 
 public RuleAlternativesBlockSyntax RuleAlternativesBlock(AlternativeSyntax alternatives)
 {
 	return this.RuleAlternativesBlock(this.Token(CompilerSyntaxKind.TBar), alternatives);
 }
			
		
			

        public BlockBlock1Syntax BlockBlock1(__SyntaxToken kReturns, ReturnTypeQualifierSyntax returnType)
 {
 		
 		
 	if (kReturns.RawKind != (int)__InternalSyntaxKind.None) throw new ArgumentNullException(nameof(kReturns));
 		
 		
 		
 	if (kReturns.RawKind != (int)CompilerSyntaxKind.KReturns) throw new ArgumentException(nameof(kReturns));
 		
 		
 		
 	if (returnType is null) throw new ArgumentNullException(nameof(returnType));
 		
 		
 		
     return (BlockBlock1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.BlockBlock1((__InternalSyntaxToken)kReturns.Node, (InternalSyntax.ReturnTypeQualifierGreen)returnType.Green).CreateRed();
 }
 
 public BlockBlock1Syntax BlockBlock1(ReturnTypeQualifierSyntax returnType)
 {
 	return this.BlockBlock1(this.Token(CompilerSyntaxKind.KReturns), returnType);
 }
			
		
			

        public BlockAlternativesBlockSyntax BlockAlternativesBlock(__SyntaxToken tBar, AlternativeSyntax alternatives)
 {
 		
 		
 	if (tBar.RawKind != (int)__InternalSyntaxKind.None) throw new ArgumentNullException(nameof(tBar));
 		
 		
 		
 	if (tBar.RawKind != (int)CompilerSyntaxKind.TBar) throw new ArgumentException(nameof(tBar));
 		
 		
 		
 	if (alternatives is null) throw new ArgumentNullException(nameof(alternatives));
 		
 		
 		
     return (BlockAlternativesBlockSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.BlockAlternativesBlock((__InternalSyntaxToken)tBar.Node, (InternalSyntax.AlternativeGreen)alternatives.Green).CreateRed();
 }
 
 public BlockAlternativesBlockSyntax BlockAlternativesBlock(AlternativeSyntax alternatives)
 {
 	return this.BlockAlternativesBlock(this.Token(CompilerSyntaxKind.TBar), alternatives);
 }
			
		
			

        public BlockInlineAlternativesBlockSyntax BlockInlineAlternativesBlock(__SyntaxToken tBar, AlternativeSyntax alternatives)
 {
 		
 		
 	if (tBar.RawKind != (int)__InternalSyntaxKind.None) throw new ArgumentNullException(nameof(tBar));
 		
 		
 		
 	if (tBar.RawKind != (int)CompilerSyntaxKind.TBar) throw new ArgumentException(nameof(tBar));
 		
 		
 		
 	if (alternatives is null) throw new ArgumentNullException(nameof(alternatives));
 		
 		
 		
     return (BlockInlineAlternativesBlockSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.BlockInlineAlternativesBlock((__InternalSyntaxToken)tBar.Node, (InternalSyntax.AlternativeGreen)alternatives.Green).CreateRed();
 }
 
 public BlockInlineAlternativesBlockSyntax BlockInlineAlternativesBlock(AlternativeSyntax alternatives)
 {
 	return this.BlockInlineAlternativesBlock(this.Token(CompilerSyntaxKind.TBar), alternatives);
 }
			
		
			

        public AlternativeBlock1Syntax AlternativeBlock1(global::MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> annotations1, __SyntaxToken kAlt, NameSyntax name, AlternativeBlock1Block1Syntax block, __SyntaxToken tColon)
 {
 		
 		
 		
 		
 		
 		
 	if (kAlt.RawKind != (int)__InternalSyntaxKind.None) throw new ArgumentNullException(nameof(kAlt));
 		
 		
 		
 	if (kAlt.RawKind != (int)CompilerSyntaxKind.KAlt) throw new ArgumentException(nameof(kAlt));
 		
 		
 		
 	if (name is null) throw new ArgumentNullException(nameof(name));
 		
 		
 		
 		
 		
 		
 		
 		
 		
 	if (tColon.RawKind != (int)__InternalSyntaxKind.None) throw new ArgumentNullException(nameof(tColon));
 		
 		
 		
 	if (tColon.RawKind != (int)CompilerSyntaxKind.TColon) throw new ArgumentException(nameof(tColon));
 		
     return (AlternativeBlock1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.AlternativeBlock1(__GreenNodeExtensions.ToGreenList<InternalSyntax.ParserAnnotationGreen>(annotations1.Node), (__InternalSyntaxToken)kAlt.Node, (InternalSyntax.NameGreen)name.Green, (InternalSyntax.AlternativeBlock1Block1Green)block.Green, (__InternalSyntaxToken)tColon.Node).CreateRed();
 }
 
 public AlternativeBlock1Syntax AlternativeBlock1(global::MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> annotations1, NameSyntax name)
 {
 	return this.AlternativeBlock1(annotations1, this.Token(CompilerSyntaxKind.KAlt), name, default, this.Token(CompilerSyntaxKind.TColon));
 }
			
		
			

        public AlternativeBlock1Block1Syntax AlternativeBlock1Block1(__SyntaxToken kReturns, ReturnTypeQualifierSyntax returnType)
 {
 		
 		
 	if (kReturns.RawKind != (int)__InternalSyntaxKind.None) throw new ArgumentNullException(nameof(kReturns));
 		
 		
 		
 	if (kReturns.RawKind != (int)CompilerSyntaxKind.KReturns) throw new ArgumentException(nameof(kReturns));
 		
 		
 		
 	if (returnType is null) throw new ArgumentNullException(nameof(returnType));
 		
 		
 		
     return (AlternativeBlock1Block1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.AlternativeBlock1Block1((__InternalSyntaxToken)kReturns.Node, (InternalSyntax.ReturnTypeQualifierGreen)returnType.Green).CreateRed();
 }
 
 public AlternativeBlock1Block1Syntax AlternativeBlock1Block1(ReturnTypeQualifierSyntax returnType)
 {
 	return this.AlternativeBlock1Block1(this.Token(CompilerSyntaxKind.KReturns), returnType);
 }
			
		
			

        public AlternativeBlock2Syntax AlternativeBlock2(__SyntaxToken tEqGt, ExpressionSyntax returnValue)
 {
 		
 		
 	if (tEqGt.RawKind != (int)__InternalSyntaxKind.None) throw new ArgumentNullException(nameof(tEqGt));
 		
 		
 		
 	if (tEqGt.RawKind != (int)CompilerSyntaxKind.TEqGt) throw new ArgumentException(nameof(tEqGt));
 		
 		
 		
 	if (returnValue is null) throw new ArgumentNullException(nameof(returnValue));
 		
 		
 		
     return (AlternativeBlock2Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.AlternativeBlock2((__InternalSyntaxToken)tEqGt.Node, (InternalSyntax.ExpressionGreen)returnValue.Green).CreateRed();
 }
 
 public AlternativeBlock2Syntax AlternativeBlock2(ExpressionSyntax returnValue)
 {
 	return this.AlternativeBlock2(this.Token(CompilerSyntaxKind.TEqGt), returnValue);
 }
			
		
			

        public ElementBlock1Syntax ElementBlock1(global::MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> nameAnnotations, IdentifierSyntax symbolProperty, __SyntaxToken assignment)
 {
 		
 		
 		
 		
 		
 		
 	if (symbolProperty is null) throw new ArgumentNullException(nameof(symbolProperty));
 		
 		
 		
 		
 		
 	if (assignment.RawKind != (int)__InternalSyntaxKind.None) throw new ArgumentNullException(nameof(assignment));
 		
 		
 		
 	if (assignment.RawKind != (int)CompilerSyntaxKind.TEq && assignment.RawKind != (int)CompilerSyntaxKind.TQuestionEq && assignment.RawKind != (int)CompilerSyntaxKind.TExclEq && assignment.RawKind != (int)CompilerSyntaxKind.TPlusEq) throw new ArgumentException(nameof(assignment));
 		
     return (ElementBlock1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.ElementBlock1(__GreenNodeExtensions.ToGreenList<InternalSyntax.ParserAnnotationGreen>(nameAnnotations.Node), (InternalSyntax.IdentifierGreen)symbolProperty.Green, (__InternalSyntaxToken)assignment.Node).CreateRed();
 }
			
		
			

        public RuleRefAlt3ReferencedTypesBlockSyntax RuleRefAlt3ReferencedTypesBlock(__SyntaxToken tComma, ReturnTypeQualifierSyntax referencedTypes)
 {
 		
 		
 	if (tComma.RawKind != (int)__InternalSyntaxKind.None) throw new ArgumentNullException(nameof(tComma));
 		
 		
 		
 	if (tComma.RawKind != (int)CompilerSyntaxKind.TComma) throw new ArgumentException(nameof(tComma));
 		
 		
 		
 	if (referencedTypes is null) throw new ArgumentNullException(nameof(referencedTypes));
 		
 		
 		
     return (RuleRefAlt3ReferencedTypesBlockSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.RuleRefAlt3ReferencedTypesBlock((__InternalSyntaxToken)tComma.Node, (InternalSyntax.ReturnTypeQualifierGreen)referencedTypes.Green).CreateRed();
 }
 
 public RuleRefAlt3ReferencedTypesBlockSyntax RuleRefAlt3ReferencedTypesBlock(ReturnTypeQualifierSyntax referencedTypes)
 {
 	return this.RuleRefAlt3ReferencedTypesBlock(this.Token(CompilerSyntaxKind.TComma), referencedTypes);
 }
			
		
			

        public TokenBlock1Alt1Syntax TokenBlock1Alt1(__SyntaxToken kToken, NameSyntax name, TokenBlock1Alt1Block1Syntax block)
 {
 		
 		
 	if (kToken.RawKind != (int)__InternalSyntaxKind.None) throw new ArgumentNullException(nameof(kToken));
 		
 		
 		
 	if (kToken.RawKind != (int)CompilerSyntaxKind.KToken) throw new ArgumentException(nameof(kToken));
 		
 		
 		
 	if (name is null) throw new ArgumentNullException(nameof(name));
 		
 		
 		
 		
 		
 		
 		
     return (TokenBlock1Alt1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.TokenBlock1Alt1((__InternalSyntaxToken)kToken.Node, (InternalSyntax.NameGreen)name.Green, (InternalSyntax.TokenBlock1Alt1Block1Green)block.Green).CreateRed();
 }
 
 public TokenBlock1Alt1Syntax TokenBlock1Alt1(NameSyntax name)
 {
 	return this.TokenBlock1Alt1(this.Token(CompilerSyntaxKind.KToken), name, default);
 }
			

        public TokenBlock1Alt2Syntax TokenBlock1Alt2(__SyntaxToken isTrivia, NameSyntax name)
 {
 		
 		
 	if (isTrivia.RawKind != (int)__InternalSyntaxKind.None) throw new ArgumentNullException(nameof(isTrivia));
 		
 		
 		
 	if (isTrivia.RawKind != (int)CompilerSyntaxKind.KHidden) throw new ArgumentException(nameof(isTrivia));
 		
 		
 		
 	if (name is null) throw new ArgumentNullException(nameof(name));
 		
 		
 		
     return (TokenBlock1Alt2Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.TokenBlock1Alt2((__InternalSyntaxToken)isTrivia.Node, (InternalSyntax.NameGreen)name.Green).CreateRed();
 }
 
 public TokenBlock1Alt2Syntax TokenBlock1Alt2(NameSyntax name)
 {
 	return this.TokenBlock1Alt2(this.Token(CompilerSyntaxKind.KHidden), name);
 }
			
		
			

        public TokenBlock1Alt1Block1Syntax TokenBlock1Alt1Block1(__SyntaxToken kReturns, ReturnTypeQualifierSyntax returnType)
 {
 		
 		
 	if (kReturns.RawKind != (int)__InternalSyntaxKind.None) throw new ArgumentNullException(nameof(kReturns));
 		
 		
 		
 	if (kReturns.RawKind != (int)CompilerSyntaxKind.KReturns) throw new ArgumentException(nameof(kReturns));
 		
 		
 		
 	if (returnType is null) throw new ArgumentNullException(nameof(returnType));
 		
 		
 		
     return (TokenBlock1Alt1Block1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.TokenBlock1Alt1Block1((__InternalSyntaxToken)kReturns.Node, (InternalSyntax.ReturnTypeQualifierGreen)returnType.Green).CreateRed();
 }
 
 public TokenBlock1Alt1Block1Syntax TokenBlock1Alt1Block1(ReturnTypeQualifierSyntax returnType)
 {
 	return this.TokenBlock1Alt1Block1(this.Token(CompilerSyntaxKind.KReturns), returnType);
 }
			
		
			

        public TokenAlternativesBlockSyntax TokenAlternativesBlock(__SyntaxToken tBar, LAlternativeSyntax alternatives)
 {
 		
 		
 	if (tBar.RawKind != (int)__InternalSyntaxKind.None) throw new ArgumentNullException(nameof(tBar));
 		
 		
 		
 	if (tBar.RawKind != (int)CompilerSyntaxKind.TBar) throw new ArgumentException(nameof(tBar));
 		
 		
 		
 	if (alternatives is null) throw new ArgumentNullException(nameof(alternatives));
 		
 		
 		
     return (TokenAlternativesBlockSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.TokenAlternativesBlock((__InternalSyntaxToken)tBar.Node, (InternalSyntax.LAlternativeGreen)alternatives.Green).CreateRed();
 }
 
 public TokenAlternativesBlockSyntax TokenAlternativesBlock(LAlternativeSyntax alternatives)
 {
 	return this.TokenAlternativesBlock(this.Token(CompilerSyntaxKind.TBar), alternatives);
 }
			
		
			

        public FragmentAlternativesBlockSyntax FragmentAlternativesBlock(__SyntaxToken tBar, LAlternativeSyntax alternatives)
 {
 		
 		
 	if (tBar.RawKind != (int)__InternalSyntaxKind.None) throw new ArgumentNullException(nameof(tBar));
 		
 		
 		
 	if (tBar.RawKind != (int)CompilerSyntaxKind.TBar) throw new ArgumentException(nameof(tBar));
 		
 		
 		
 	if (alternatives is null) throw new ArgumentNullException(nameof(alternatives));
 		
 		
 		
     return (FragmentAlternativesBlockSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.FragmentAlternativesBlock((__InternalSyntaxToken)tBar.Node, (InternalSyntax.LAlternativeGreen)alternatives.Green).CreateRed();
 }
 
 public FragmentAlternativesBlockSyntax FragmentAlternativesBlock(LAlternativeSyntax alternatives)
 {
 	return this.FragmentAlternativesBlock(this.Token(CompilerSyntaxKind.TBar), alternatives);
 }
			
		
			

        public LBlockAlternativesBlockSyntax LBlockAlternativesBlock(__SyntaxToken tBar, LAlternativeSyntax alternatives)
 {
 		
 		
 	if (tBar.RawKind != (int)__InternalSyntaxKind.None) throw new ArgumentNullException(nameof(tBar));
 		
 		
 		
 	if (tBar.RawKind != (int)CompilerSyntaxKind.TBar) throw new ArgumentException(nameof(tBar));
 		
 		
 		
 	if (alternatives is null) throw new ArgumentNullException(nameof(alternatives));
 		
 		
 		
     return (LBlockAlternativesBlockSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.LBlockAlternativesBlock((__InternalSyntaxToken)tBar.Node, (InternalSyntax.LAlternativeGreen)alternatives.Green).CreateRed();
 }
 
 public LBlockAlternativesBlockSyntax LBlockAlternativesBlock(LAlternativeSyntax alternatives)
 {
 	return this.LBlockAlternativesBlock(this.Token(CompilerSyntaxKind.TBar), alternatives);
 }
			
		
			

        public TokensSyntax Tokens(__SyntaxToken token)
 {
 		
 		
 	if (token.RawKind != (int)__InternalSyntaxKind.None) throw new ArgumentNullException(nameof(token));
 		
 		
 		
 	if (token.RawKind != (int)CompilerSyntaxKind.KNull && token.RawKind != (int)CompilerSyntaxKind.KTrue && token.RawKind != (int)CompilerSyntaxKind.KFalse && token.RawKind != (int)CompilerSyntaxKind.TInteger && token.RawKind != (int)CompilerSyntaxKind.TString) throw new ArgumentException(nameof(token));
 		
     return (TokensSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.Tokens((__InternalSyntaxToken)token.Node).CreateRed();
 }
			

        public SingleExpressionBlock1Alt2Syntax SingleExpressionBlock1Alt2(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<SimpleIdentifierSyntax> simpleQualifier)
 {
 		
 		
 		
 		
     return (SingleExpressionBlock1Alt2Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.SingleExpressionBlock1Alt2(__GreenNodeExtensions.ToGreenSeparatedList<InternalSyntax.SimpleIdentifierGreen>(simpleQualifier.Node, reversed: false)).CreateRed();
 }
			
		
			

        public ArrayExpressionItemsBlockSyntax ArrayExpressionItemsBlock(__SyntaxToken tComma, SingleExpressionSyntax items)
 {
 		
 		
 	if (tComma.RawKind != (int)__InternalSyntaxKind.None) throw new ArgumentNullException(nameof(tComma));
 		
 		
 		
 	if (tComma.RawKind != (int)CompilerSyntaxKind.TComma) throw new ArgumentException(nameof(tComma));
 		
 		
 		
 	if (items is null) throw new ArgumentNullException(nameof(items));
 		
 		
 		
     return (ArrayExpressionItemsBlockSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.ArrayExpressionItemsBlock((__InternalSyntaxToken)tComma.Node, (InternalSyntax.SingleExpressionGreen)items.Green).CreateRed();
 }
 
 public ArrayExpressionItemsBlockSyntax ArrayExpressionItemsBlock(SingleExpressionSyntax items)
 {
 	return this.ArrayExpressionItemsBlock(this.Token(CompilerSyntaxKind.TComma), items);
 }
			
		
			

        public AnnotationArgumentsArgumentsBlockSyntax AnnotationArgumentsArgumentsBlock(__SyntaxToken tComma, AnnotationArgumentSyntax arguments)
 {
 		
 		
 	if (tComma.RawKind != (int)__InternalSyntaxKind.None) throw new ArgumentNullException(nameof(tComma));
 		
 		
 		
 	if (tComma.RawKind != (int)CompilerSyntaxKind.TComma) throw new ArgumentException(nameof(tComma));
 		
 		
 		
 	if (arguments is null) throw new ArgumentNullException(nameof(arguments));
 		
 		
 		
     return (AnnotationArgumentsArgumentsBlockSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.AnnotationArgumentsArgumentsBlock((__InternalSyntaxToken)tComma.Node, (InternalSyntax.AnnotationArgumentGreen)arguments.Green).CreateRed();
 }
 
 public AnnotationArgumentsArgumentsBlockSyntax AnnotationArgumentsArgumentsBlock(AnnotationArgumentSyntax arguments)
 {
 	return this.AnnotationArgumentsArgumentsBlock(this.Token(CompilerSyntaxKind.TComma), arguments);
 }
			
		
			

        public AnnotationArgumentBlock1Syntax AnnotationArgumentBlock1(IdentifierSyntax namedParameter, __SyntaxToken tColon)
 {
 		
 		
 	if (namedParameter is null) throw new ArgumentNullException(nameof(namedParameter));
 		
 		
 		
 		
 		
 	if (tColon.RawKind != (int)__InternalSyntaxKind.None) throw new ArgumentNullException(nameof(tColon));
 		
 		
 		
 	if (tColon.RawKind != (int)CompilerSyntaxKind.TColon) throw new ArgumentException(nameof(tColon));
 		
     return (AnnotationArgumentBlock1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.AnnotationArgumentBlock1((InternalSyntax.IdentifierGreen)namedParameter.Green, (__InternalSyntaxToken)tColon.Node).CreateRed();
 }
 
 public AnnotationArgumentBlock1Syntax AnnotationArgumentBlock1(IdentifierSyntax namedParameter)
 {
 	return this.AnnotationArgumentBlock1(namedParameter, this.Token(CompilerSyntaxKind.TColon));
 }
			
		
			

        public MainQualifierBlockSyntax MainQualifierBlock(__SyntaxToken tDot, IdentifierSyntax identifier)
 {
 		
 		
 	if (tDot.RawKind != (int)__InternalSyntaxKind.None) throw new ArgumentNullException(nameof(tDot));
 		
 		
 		
 	if (tDot.RawKind != (int)CompilerSyntaxKind.TDot) throw new ArgumentException(nameof(tDot));
 		
 		
 		
 	if (identifier is null) throw new ArgumentNullException(nameof(identifier));
 		
 		
 		
     return (MainQualifierBlockSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.MainQualifierBlock((__InternalSyntaxToken)tDot.Node, (InternalSyntax.IdentifierGreen)identifier.Green).CreateRed();
 }
 
 public MainQualifierBlockSyntax MainQualifierBlock(IdentifierSyntax identifier)
 {
 	return this.MainQualifierBlock(this.Token(CompilerSyntaxKind.TDot), identifier);
 }
			
		
			

        public SingleExpressionBlock1Alt2SimpleQualifierBlockSyntax SingleExpressionBlock1Alt2SimpleQualifierBlock(__SyntaxToken tDot, SimpleIdentifierSyntax simpleIdentifier)
 {
 		
 		
 	if (tDot.RawKind != (int)__InternalSyntaxKind.None) throw new ArgumentNullException(nameof(tDot));
 		
 		
 		
 	if (tDot.RawKind != (int)CompilerSyntaxKind.TDot) throw new ArgumentException(nameof(tDot));
 		
 		
 		
 	if (simpleIdentifier is null) throw new ArgumentNullException(nameof(simpleIdentifier));
 		
 		
 		
     return (SingleExpressionBlock1Alt2SimpleQualifierBlockSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.SingleExpressionBlock1Alt2SimpleQualifierBlock((__InternalSyntaxToken)tDot.Node, (InternalSyntax.SimpleIdentifierGreen)simpleIdentifier.Green).CreateRed();
 }
 
 public SingleExpressionBlock1Alt2SimpleQualifierBlockSyntax SingleExpressionBlock1Alt2SimpleQualifierBlock(SimpleIdentifierSyntax simpleIdentifier)
 {
 	return this.SingleExpressionBlock1Alt2SimpleQualifierBlock(this.Token(CompilerSyntaxKind.TDot), simpleIdentifier);
 }
			
				

        internal static IEnumerable<__Type> GetNodeTypes()
        {
            return new __Type[] {
            
		        
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
		        
            
		        
		        typeof(ElementValueTokensSyntax),
		        
		        typeof(BlockInlineSyntax),
		        
		        typeof(RuleRefAlt1Syntax),
		        
		        typeof(RuleRefAlt2Syntax),
		        
		        typeof(RuleRefAlt3Syntax),
		        
            
		        
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
		        
            
		        
		        typeof(AnnotationArgumentsSyntax),
		        
            
		        
		        typeof(AnnotationArgumentSyntax),
		        
            
		        
		        typeof(ReturnTypeIdentifierAlt1Syntax),
		        
		        typeof(ReturnTypeIdentifierAlt2Syntax),
		        
            
		        
		        typeof(ReturnTypeQualifierAlt1Syntax),
		        
		        typeof(ReturnTypeQualifierAlt2Syntax),
		        
            
		        
		        typeof(NameSyntax),
		        
            
		        
		        typeof(IdentifierSyntax),
		        
            
		        
		        typeof(SimpleIdentifierSyntax),
		        
            
		        
		        typeof(RuleBlock1Alt1Syntax),
		        
		        typeof(RuleBlock1Alt2Syntax),
		        
            
		        
		        typeof(RuleAlternativesBlockSyntax),
		        
            
		        
		        typeof(BlockBlock1Syntax),
		        
            
		        
		        typeof(BlockAlternativesBlockSyntax),
		        
            
		        
		        typeof(BlockInlineAlternativesBlockSyntax),
		        
            
		        
		        typeof(AlternativeBlock1Syntax),
		        
            
		        
		        typeof(AlternativeBlock1Block1Syntax),
		        
            
		        
		        typeof(AlternativeBlock2Syntax),
		        
            
		        
		        typeof(ElementBlock1Syntax),
		        
            
		        
		        typeof(RuleRefAlt3ReferencedTypesBlockSyntax),
		        
            
		        
		        typeof(TokenBlock1Alt1Syntax),
		        
		        typeof(TokenBlock1Alt2Syntax),
		        
            
		        
		        typeof(TokenBlock1Alt1Block1Syntax),
		        
            
		        
		        typeof(TokenAlternativesBlockSyntax),
		        
            
		        
		        typeof(FragmentAlternativesBlockSyntax),
		        
            
		        
		        typeof(LBlockAlternativesBlockSyntax),
		        
            
		        
		        typeof(TokensSyntax),
		        
		        typeof(SingleExpressionBlock1Alt2Syntax),
		        
            
		        
		        typeof(ArrayExpressionItemsBlockSyntax),
		        
            
		        
		        typeof(AnnotationArgumentsArgumentsBlockSyntax),
		        
            
		        
		        typeof(AnnotationArgumentBlock1Syntax),
		        
            
		        
		        typeof(MainQualifierBlockSyntax),
		        
            
		        
		        typeof(SingleExpressionBlock1Alt2SimpleQualifierBlockSyntax),
		        
            
		    };
        }

    }
}	
