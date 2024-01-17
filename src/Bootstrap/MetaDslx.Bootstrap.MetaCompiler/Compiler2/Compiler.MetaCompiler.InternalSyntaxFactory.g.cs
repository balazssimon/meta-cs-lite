#nullable enable

namespace MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax
{
	using __Debug = System.Diagnostics.Debug;
	using __Language = global::MetaDslx.CodeAnalysis.Language;
	using __ParseOptions = global::MetaDslx.CodeAnalysis.ParseOptions;
	using __DiagnosticInfo = global::MetaDslx.CodeAnalysis.DiagnosticInfo;
	using __SyntaxAnnotation = global::MetaDslx.CodeAnalysis.SyntaxAnnotation;
	using __GreenNode = global::MetaDslx.CodeAnalysis.GreenNode;
	using __SyntaxNodeCache = MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxNodeCache;
	using __InternalSyntaxKind = global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.InternalSyntaxKind;
	using __InternalSyntaxToken = global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.InternalSyntaxToken;
	using __InternalSyntaxTrivia = global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.InternalSyntaxTrivia;
	using __InternalSyntaxNode = global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.InternalSyntaxNode;
	using __IncrementalParseData = global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.IncrementalParseData;
	using __SyntaxLexer = global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxLexer;
	using __SyntaxParser = global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxParser;
	using __SyntaxFacts = global::MetaDslx.CodeAnalysis.Syntax.SyntaxFacts;
	using __SyntaxToken = global::MetaDslx.CodeAnalysis.SyntaxToken;
	using __SyntaxTrivia = global::MetaDslx.CodeAnalysis.SyntaxTrivia;
	using __SyntaxNode = global::MetaDslx.CodeAnalysis.SyntaxNode;
	using __SourceText = global::MetaDslx.CodeAnalysis.Text.SourceText;
	using __TextChangeRange = global::MetaDslx.CodeAnalysis.Text.TextChangeRange;

	public partial class CompilerInternalSyntaxFactory : global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.InternalSyntaxFactory
	{
		public CompilerInternalSyntaxFactory(__SyntaxFacts syntaxFacts) 
		    : base(syntaxFacts)
		{
		}
	
		public override __SyntaxLexer CreateLexer(__SourceText text, __ParseOptions? options)
		{
			return new CompilerSyntaxLexer(text, (CompilerParseOptions)(options ?? CompilerParseOptions.Default));
		}

		public override __SyntaxParser CreateParser(__SyntaxLexer lexer, __IncrementalParseData? oldParseData, IEnumerable<__TextChangeRange>? changes, CancellationToken cancellationToken = default)
        {
			return new CompilerSyntaxParser((CompilerSyntaxLexer)lexer, oldParseData, changes, cancellationToken);
		}

		public __InternalSyntaxTrivia Trivia(CompilerSyntaxKind kind, string text, bool elastic = false)
        {
			var trivia = GreenSyntaxTrivia.Create(kind, text);
			if (!elastic) return trivia;
			return global::MetaDslx.CodeAnalysis.GreenNodeExtensions.WithAnnotationsGreen(trivia, new[] { __SyntaxAnnotation.ElasticAnnotation });
		}

		protected override __InternalSyntaxTrivia Trivia(int kind, string text, bool elastic = false)
	    {
	        return Trivia((CompilerSyntaxKind)kind, text, elastic);
	    }
	
		public override __InternalSyntaxNode SkippedTokensTrivia(__GreenNode token)
		{
			return new GreenSkippedTokensTriviaSyntax((CompilerSyntaxKind)__InternalSyntaxKind.SkippedTokensTrivia, token);
		}
	
	    public __InternalSyntaxToken Token(CompilerSyntaxKind kind)
	    {
	        return GreenSyntaxToken.Create(kind);
	    }

        protected override __InternalSyntaxToken Token(int kind)
        {
			return Token((CompilerSyntaxKind)kind);
        }

        public __InternalSyntaxToken Token(__GreenNode? leading, CompilerSyntaxKind kind, __GreenNode? trailing)
	    {
	        return GreenSyntaxToken.Create(kind, leading, trailing);
	    }

        protected override __InternalSyntaxToken Token(__GreenNode? leading, int kind, __GreenNode? trailing)
        {
			return Token(leading, (CompilerSyntaxKind)kind, trailing);
        }

        public __InternalSyntaxToken Token(__GreenNode? leading, CompilerSyntaxKind kind, string text, __GreenNode? trailing)
	    {
	        __Debug.Assert(CompilerLanguage.Instance.SyntaxFacts.IsToken(kind));
	        string defaultText = CompilerLanguage.Instance.SyntaxFacts.GetText(kind);
	        return kind >= GreenSyntaxToken.FirstTokenWithWellKnownText && kind <= GreenSyntaxToken.LastTokenWithWellKnownText && text == defaultText
	            ? Token(leading, kind, trailing)
	            : GreenSyntaxToken.Identifier(kind, leading, text, trailing);
	    }

        protected override __InternalSyntaxToken Token(__GreenNode? leading, int kind, string text, __GreenNode? trailing)
        {
            return Token(leading, (CompilerSyntaxKind)kind, text, trailing);
        }

        public __InternalSyntaxToken Token(__GreenNode? leading, CompilerSyntaxKind kind, string text, string valueText, __GreenNode? trailing)
	    {
	        __Debug.Assert(CompilerLanguage.Instance.SyntaxFacts.IsToken(kind));
	        string defaultText = CompilerLanguage.Instance.SyntaxFacts.GetText(kind);
	        return kind >= GreenSyntaxToken.FirstTokenWithWellKnownText && kind <= GreenSyntaxToken.LastTokenWithWellKnownText && text == defaultText && valueText == defaultText
	            ? Token(leading, kind, trailing)
	            : GreenSyntaxToken.WithValue(kind, leading, text, valueText, trailing);
	    }

		protected override __InternalSyntaxToken Token(__GreenNode? leading, int kind, string text, string valueText, __GreenNode? trailing)
		{
			return Token(leading, (CompilerSyntaxKind)kind, text, valueText, trailing);
		}

		public __InternalSyntaxToken Token(__GreenNode? leading, CompilerSyntaxKind kind, string text, object value, __GreenNode? trailing)
	    {
	        __Debug.Assert(CompilerLanguage.Instance.SyntaxFacts.IsToken(kind));
	        string defaultText = CompilerLanguage.Instance.SyntaxFacts.GetText(kind);
	        return kind >= GreenSyntaxToken.FirstTokenWithWellKnownText && kind <= GreenSyntaxToken.LastTokenWithWellKnownText && text == defaultText && defaultText.Equals(value)
	            ? Token(leading, kind, trailing)
	            : GreenSyntaxToken.WithValue(kind, leading, text, value, trailing);
	    }

		protected override __InternalSyntaxToken Token(__GreenNode? leading, int kind, string text, object value, __GreenNode? trailing)
		{
			return Token(leading, (CompilerSyntaxKind)kind, text, value, trailing);
		}

		public __InternalSyntaxToken MissingToken(CompilerSyntaxKind kind)
	    {
	        return GreenSyntaxToken.CreateMissing(kind, null, null);
	    }

        protected override __InternalSyntaxToken MissingToken(int kind)
        {
			return MissingToken((CompilerSyntaxKind)kind);
        }

        public __InternalSyntaxToken MissingToken(__GreenNode? leading, CompilerSyntaxKind kind, __GreenNode? trailing)
	    {
	        return GreenSyntaxToken.CreateMissing(kind, leading, trailing);
	    }

        protected override __InternalSyntaxToken MissingToken(__GreenNode? leading, int kind, __GreenNode? trailing)
        {
			return MissingToken(leading, (CompilerSyntaxKind)kind, trailing);
        }

        public override __InternalSyntaxToken BadToken(__GreenNode? leading, string text, __GreenNode? trailing)
	    {
	        return GreenSyntaxToken.WithValue((CompilerSyntaxKind)__InternalSyntaxKind.BadToken, leading, text, text, trailing);
	    }

        public override IEnumerable<__InternalSyntaxToken> GetWellKnownTokens()
	    {
	        return GreenSyntaxToken.GetWellKnownTokens();
	    }

		
		public __InternalSyntaxToken TInteger(string text)
		{
			return Token(null, CompilerSyntaxKind.TInteger, text, null);
		}

		public __InternalSyntaxToken TInteger(string text, object value)
		{
			return Token(null, CompilerSyntaxKind.TInteger, text, value, null);
		}

		
		public __InternalSyntaxToken TDecimal(string text)
		{
			return Token(null, CompilerSyntaxKind.TDecimal, text, null);
		}

		public __InternalSyntaxToken TDecimal(string text, object value)
		{
			return Token(null, CompilerSyntaxKind.TDecimal, text, value, null);
		}

		
		public __InternalSyntaxToken TIdentifier(string text)
		{
			return Token(null, CompilerSyntaxKind.TIdentifier, text, null);
		}

		public __InternalSyntaxToken TIdentifier(string text, object value)
		{
			return Token(null, CompilerSyntaxKind.TIdentifier, text, value, null);
		}

		
		public __InternalSyntaxToken TVerbatimIdentifier(string text)
		{
			return Token(null, CompilerSyntaxKind.TVerbatimIdentifier, text, null);
		}

		public __InternalSyntaxToken TVerbatimIdentifier(string text, object value)
		{
			return Token(null, CompilerSyntaxKind.TVerbatimIdentifier, text, value, null);
		}

		
		public __InternalSyntaxToken TString(string text)
		{
			return Token(null, CompilerSyntaxKind.TString, text, null);
		}

		public __InternalSyntaxToken TString(string text, object value)
		{
			return Token(null, CompilerSyntaxKind.TString, text, value, null);
		}

		
		public __InternalSyntaxToken TWhitespace(string text)
		{
			return Token(null, CompilerSyntaxKind.TWhitespace, text, null);
		}

		public __InternalSyntaxToken TWhitespace(string text, object value)
		{
			return Token(null, CompilerSyntaxKind.TWhitespace, text, value, null);
		}

		
		public __InternalSyntaxToken TLineEnd(string text)
		{
			return Token(null, CompilerSyntaxKind.TLineEnd, text, null);
		}

		public __InternalSyntaxToken TLineEnd(string text, object value)
		{
			return Token(null, CompilerSyntaxKind.TLineEnd, text, value, null);
		}

		
		public __InternalSyntaxToken TSingleLineComment(string text)
		{
			return Token(null, CompilerSyntaxKind.TSingleLineComment, text, null);
		}

		public __InternalSyntaxToken TSingleLineComment(string text, object value)
		{
			return Token(null, CompilerSyntaxKind.TSingleLineComment, text, value, null);
		}

		
		public __InternalSyntaxToken TMultiLineComment(string text)
		{
			return Token(null, CompilerSyntaxKind.TMultiLineComment, text, null);
		}

		public __InternalSyntaxToken TMultiLineComment(string text, object value)
		{
			return Token(null, CompilerSyntaxKind.TMultiLineComment, text, value, null);
		}

		
		public __InternalSyntaxToken TInvalidToken(string text)
		{
			return Token(null, CompilerSyntaxKind.TInvalidToken, text, null);
		}

		public __InternalSyntaxToken TInvalidToken(string text, object value)
		{
			return Token(null, CompilerSyntaxKind.TInvalidToken, text, value, null);
		}

		
		
			
		internal MainGreen Main(__InternalSyntaxToken kNamespace, global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<IdentifierGreen> qualifier, __InternalSyntaxToken tSemicolon, global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<UsingGreen> usingList, DeclarationsGreen declarations, __InternalSyntaxToken endOfFileToken)
		{
#if DEBUG
			
				
				
			if (kNamespace is null) throw new ArgumentNullException(nameof(kNamespace));
				
				
				
			if (kNamespace.RawKind != (int)CompilerSyntaxKind.KNamespace) throw new ArgumentException(nameof(kNamespace));
				
			
				
				
				
				
			
				
				
			if (tSemicolon is null) throw new ArgumentNullException(nameof(tSemicolon));
				
				
				
			if (tSemicolon.RawKind != (int)CompilerSyntaxKind.TSemicolon) throw new ArgumentException(nameof(tSemicolon));
				
			
				
				
				
				
			
				
				
			if (declarations is null) throw new ArgumentNullException(nameof(declarations));
				
				
				
			
				
				
			if (endOfFileToken is null) throw new ArgumentNullException(nameof(endOfFileToken));
				
				
				
			if (endOfFileToken.RawKind != (int)__InternalSyntaxKind.Eof) throw new ArgumentException(nameof(endOfFileToken));
				
			
#endif
			
			return new MainGreen(CompilerSyntaxKind.Main, kNamespace, qualifier.Node, tSemicolon, usingList.Node, declarations, endOfFileToken);
			
		}

			
		
			
		internal UsingGreen Using(__InternalSyntaxToken kUsing, global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<IdentifierGreen> qualifier, __InternalSyntaxToken tSemicolon)
		{
#if DEBUG
			
				
				
			if (kUsing is null) throw new ArgumentNullException(nameof(kUsing));
				
				
				
			if (kUsing.RawKind != (int)CompilerSyntaxKind.KUsing) throw new ArgumentException(nameof(kUsing));
				
			
				
				
				
				
			
				
				
			if (tSemicolon is null) throw new ArgumentNullException(nameof(tSemicolon));
				
				
				
			if (tSemicolon.RawKind != (int)CompilerSyntaxKind.TSemicolon) throw new ArgumentException(nameof(tSemicolon));
				
			
#endif
			
			int hash;
			var cached = __SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.Using, kUsing, qualifier.Node, tSemicolon, out hash);
			if (cached != null) return (UsingGreen)cached;
		
			var result = new UsingGreen(CompilerSyntaxKind.Using, kUsing, qualifier.Node, tSemicolon);
			if (hash >= 0)
			{
				__SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
			
		}

			
		
			
		internal DeclarationsGreen Declarations(LanguageDeclarationGreen declarations1, global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<RuleGreen> declarations2)
		{
#if DEBUG
			
				
				
			if (declarations1 is null) throw new ArgumentNullException(nameof(declarations1));
				
				
				
			
				
				
				
				
			
#endif
			
			int hash;
			var cached = __SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.Declarations, declarations1, declarations2.Node, out hash);
			if (cached != null) return (DeclarationsGreen)cached;
		
			var result = new DeclarationsGreen(CompilerSyntaxKind.Declarations, declarations1, declarations2.Node);
			if (hash >= 0)
			{
				__SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
			
		}

			
		
			
		internal LanguageDeclarationGreen LanguageDeclaration(__InternalSyntaxToken kLanguage, NameGreen name, __InternalSyntaxToken tSemicolon, GrammarGreen grammar)
		{
#if DEBUG
			
				
				
			if (kLanguage is null) throw new ArgumentNullException(nameof(kLanguage));
				
				
				
			if (kLanguage.RawKind != (int)CompilerSyntaxKind.KLanguage) throw new ArgumentException(nameof(kLanguage));
				
			
				
				
			if (name is null) throw new ArgumentNullException(nameof(name));
				
				
				
			
				
				
			if (tSemicolon is null) throw new ArgumentNullException(nameof(tSemicolon));
				
				
				
			if (tSemicolon.RawKind != (int)CompilerSyntaxKind.TSemicolon) throw new ArgumentException(nameof(tSemicolon));
				
			
				
				
			if (grammar is null) throw new ArgumentNullException(nameof(grammar));
				
				
				
			
#endif
			
			return new LanguageDeclarationGreen(CompilerSyntaxKind.LanguageDeclaration, kLanguage, name, tSemicolon, grammar);
			
		}

			
		
			
		internal GrammarGreen Grammar(global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<GrammarRuleGreen> grammarRules)
		{
#if DEBUG
			
				
				
				
				
			
#endif
			
			int hash;
			var cached = __SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.Grammar, grammarRules.Node, out hash);
			if (cached != null) return (GrammarGreen)cached;
		
			var result = new GrammarGreen(CompilerSyntaxKind.Grammar, grammarRules.Node);
			if (hash >= 0)
			{
				__SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
			
		}

			
		
			
		internal GrammarRuleAlt1Green GrammarRuleAlt1(RuleGreen rule)
		{
#if DEBUG
			
				
				
			if (rule is null) throw new ArgumentNullException(nameof(rule));
				
				
				
			
#endif
			
			int hash;
			var cached = __SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.GrammarRuleAlt1, rule, out hash);
			if (cached != null) return (GrammarRuleAlt1Green)cached;
		
			var result = new GrammarRuleAlt1Green(CompilerSyntaxKind.GrammarRuleAlt1, rule);
			if (hash >= 0)
			{
				__SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
			
		}

			
		internal BlockGreen Block(global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<ParserAnnotationGreen> annotations1, __InternalSyntaxToken kBlock, NameGreen name, BlockBlock1Green block, __InternalSyntaxToken tColon, global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<AlternativeGreen> alternatives, __InternalSyntaxToken tSemicolon)
		{
#if DEBUG
			
				
				
				
				
			
				
				
			if (kBlock is null) throw new ArgumentNullException(nameof(kBlock));
				
				
				
			if (kBlock.RawKind != (int)CompilerSyntaxKind.KBlock) throw new ArgumentException(nameof(kBlock));
				
			
				
				
			if (name is null) throw new ArgumentNullException(nameof(name));
				
				
				
			
				
				
				
				
			
				
				
			if (tColon is null) throw new ArgumentNullException(nameof(tColon));
				
				
				
			if (tColon.RawKind != (int)CompilerSyntaxKind.TColon) throw new ArgumentException(nameof(tColon));
				
			
				
				
				
				
			
				
				
			if (tSemicolon is null) throw new ArgumentNullException(nameof(tSemicolon));
				
				
				
			if (tSemicolon.RawKind != (int)CompilerSyntaxKind.TSemicolon) throw new ArgumentException(nameof(tSemicolon));
				
			
#endif
			
			return new BlockGreen(CompilerSyntaxKind.Block, annotations1.Node, kBlock, name, block, tColon, alternatives.Node, tSemicolon);
			
		}

			
		internal TokenGreen Token(global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<LexerAnnotationGreen> annotations1, TokenBlock1Green block, __InternalSyntaxToken tColon, global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<LAlternativeGreen> alternatives, __InternalSyntaxToken tSemicolon)
		{
#if DEBUG
			
				
				
				
				
			
				
				
			if (block is null) throw new ArgumentNullException(nameof(block));
				
				
				
			
				
				
			if (tColon is null) throw new ArgumentNullException(nameof(tColon));
				
				
				
			if (tColon.RawKind != (int)CompilerSyntaxKind.TColon) throw new ArgumentException(nameof(tColon));
				
			
				
				
				
				
			
				
				
			if (tSemicolon is null) throw new ArgumentNullException(nameof(tSemicolon));
				
				
				
			if (tSemicolon.RawKind != (int)CompilerSyntaxKind.TSemicolon) throw new ArgumentException(nameof(tSemicolon));
				
			
#endif
			
			return new TokenGreen(CompilerSyntaxKind.Token, annotations1.Node, block, tColon, alternatives.Node, tSemicolon);
			
		}

			
		internal FragmentGreen Fragment(__InternalSyntaxToken kFragment, NameGreen name, __InternalSyntaxToken tColon, global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<LAlternativeGreen> alternatives, __InternalSyntaxToken tSemicolon)
		{
#if DEBUG
			
				
				
			if (kFragment is null) throw new ArgumentNullException(nameof(kFragment));
				
				
				
			if (kFragment.RawKind != (int)CompilerSyntaxKind.KFragment) throw new ArgumentException(nameof(kFragment));
				
			
				
				
			if (name is null) throw new ArgumentNullException(nameof(name));
				
				
				
			
				
				
			if (tColon is null) throw new ArgumentNullException(nameof(tColon));
				
				
				
			if (tColon.RawKind != (int)CompilerSyntaxKind.TColon) throw new ArgumentException(nameof(tColon));
				
			
				
				
				
				
			
				
				
			if (tSemicolon is null) throw new ArgumentNullException(nameof(tSemicolon));
				
				
				
			if (tSemicolon.RawKind != (int)CompilerSyntaxKind.TSemicolon) throw new ArgumentException(nameof(tSemicolon));
				
			
#endif
			
			return new FragmentGreen(CompilerSyntaxKind.Fragment, kFragment, name, tColon, alternatives.Node, tSemicolon);
			
		}

			
		
			
		internal RuleGreen Rule(global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<ParserAnnotationGreen> annotations1, RuleBlock1Green block, __InternalSyntaxToken tColon, global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<AlternativeGreen> alternatives, __InternalSyntaxToken tSemicolon)
		{
#if DEBUG
			
				
				
				
				
			
				
				
			if (block is null) throw new ArgumentNullException(nameof(block));
				
				
				
			
				
				
			if (tColon is null) throw new ArgumentNullException(nameof(tColon));
				
				
				
			if (tColon.RawKind != (int)CompilerSyntaxKind.TColon) throw new ArgumentException(nameof(tColon));
				
			
				
				
				
				
			
				
				
			if (tSemicolon is null) throw new ArgumentNullException(nameof(tSemicolon));
				
				
				
			if (tSemicolon.RawKind != (int)CompilerSyntaxKind.TSemicolon) throw new ArgumentException(nameof(tSemicolon));
				
			
#endif
			
			return new RuleGreen(CompilerSyntaxKind.Rule, annotations1.Node, block, tColon, alternatives.Node, tSemicolon);
			
		}

			
		
			
		internal AlternativeGreen Alternative(AlternativeBlock1Green block1, global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<ElementGreen> elements, AlternativeBlock2Green block2)
		{
#if DEBUG
			
				
				
				
				
			
				
				
				
				
			
				
				
				
				
			
#endif
			
			int hash;
			var cached = __SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.Alternative, block1, elements.Node, block2, out hash);
			if (cached != null) return (AlternativeGreen)cached;
		
			var result = new AlternativeGreen(CompilerSyntaxKind.Alternative, block1, elements.Node, block2);
			if (hash >= 0)
			{
				__SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
			
		}

			
		
			
		internal ElementGreen Element(ElementBlock1Green block, global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<ParserAnnotationGreen> valueAnnotations, ElementValueGreen value, __InternalSyntaxToken multiplicity)
		{
#if DEBUG
			
				
				
				
				
			
				
				
				
				
			
				
				
			if (value is null) throw new ArgumentNullException(nameof(value));
				
				
				
			
				
				
				
				
			if (multiplicity is not null && (multiplicity.RawKind != (int)CompilerSyntaxKind.TQuestion && multiplicity.RawKind != (int)CompilerSyntaxKind.TAsterisk && multiplicity.RawKind != (int)CompilerSyntaxKind.TPlus && multiplicity.RawKind != (int)CompilerSyntaxKind.TQuestionQuestion && multiplicity.RawKind != (int)CompilerSyntaxKind.TAsteriskQuestion && multiplicity.RawKind != (int)CompilerSyntaxKind.TPlusQuestion)) throw new ArgumentException(nameof(multiplicity));
				
			
#endif
			
			return new ElementGreen(CompilerSyntaxKind.Element, block, valueAnnotations.Node, value, multiplicity);
			
		}

			
		
			
		internal ElementValueTokensGreen ElementValueTokens(__InternalSyntaxToken token)
		{
#if DEBUG
			
				
				
			if (token is null) throw new ArgumentNullException(nameof(token));
				
				
				
			if (token.RawKind != (int)CompilerSyntaxKind.KEof && token.RawKind != (int)CompilerSyntaxKind.TString) throw new ArgumentException(nameof(token));
				
			
#endif
			
			int hash;
			var cached = __SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.ElementValueTokens, token, out hash);
			if (cached != null) return (ElementValueTokensGreen)cached;
		
			var result = new ElementValueTokensGreen(CompilerSyntaxKind.ElementValueTokens, token);
			if (hash >= 0)
			{
				__SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
			
		}

			
		internal BlockInlineGreen BlockInline(__InternalSyntaxToken tLParen, global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<AlternativeGreen> alternatives, __InternalSyntaxToken tRParen)
		{
#if DEBUG
			
				
				
			if (tLParen is null) throw new ArgumentNullException(nameof(tLParen));
				
				
				
			if (tLParen.RawKind != (int)CompilerSyntaxKind.TLParen) throw new ArgumentException(nameof(tLParen));
				
			
				
				
				
				
			
				
				
			if (tRParen is null) throw new ArgumentNullException(nameof(tRParen));
				
				
				
			if (tRParen.RawKind != (int)CompilerSyntaxKind.TRParen) throw new ArgumentException(nameof(tRParen));
				
			
#endif
			
			int hash;
			var cached = __SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.BlockInline, tLParen, alternatives.Node, tRParen, out hash);
			if (cached != null) return (BlockInlineGreen)cached;
		
			var result = new BlockInlineGreen(CompilerSyntaxKind.BlockInline, tLParen, alternatives.Node, tRParen);
			if (hash >= 0)
			{
				__SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
			
		}

			
		internal RuleRefAlt1Green RuleRefAlt1(IdentifierGreen grammarRule)
		{
#if DEBUG
			
				
				
			if (grammarRule is null) throw new ArgumentNullException(nameof(grammarRule));
				
				
				
			
#endif
			
			int hash;
			var cached = __SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.RuleRefAlt1, grammarRule, out hash);
			if (cached != null) return (RuleRefAlt1Green)cached;
		
			var result = new RuleRefAlt1Green(CompilerSyntaxKind.RuleRefAlt1, grammarRule);
			if (hash >= 0)
			{
				__SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
			
		}

			
		internal RuleRefAlt2Green RuleRefAlt2(__InternalSyntaxToken tHash, ReturnTypeQualifierGreen referencedTypes)
		{
#if DEBUG
			
				
				
			if (tHash is null) throw new ArgumentNullException(nameof(tHash));
				
				
				
			if (tHash.RawKind != (int)CompilerSyntaxKind.THash) throw new ArgumentException(nameof(tHash));
				
			
				
				
			if (referencedTypes is null) throw new ArgumentNullException(nameof(referencedTypes));
				
				
				
			
#endif
			
			int hash;
			var cached = __SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.RuleRefAlt2, tHash, referencedTypes, out hash);
			if (cached != null) return (RuleRefAlt2Green)cached;
		
			var result = new RuleRefAlt2Green(CompilerSyntaxKind.RuleRefAlt2, tHash, referencedTypes);
			if (hash >= 0)
			{
				__SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
			
		}

			
		internal RuleRefAlt3Green RuleRefAlt3(__InternalSyntaxToken tHashLBrace, global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<ReturnTypeQualifierGreen> referencedTypes, __InternalSyntaxToken tRBrace)
		{
#if DEBUG
			
				
				
			if (tHashLBrace is null) throw new ArgumentNullException(nameof(tHashLBrace));
				
				
				
			if (tHashLBrace.RawKind != (int)CompilerSyntaxKind.THashLBrace) throw new ArgumentException(nameof(tHashLBrace));
				
			
				
				
				
				
			
				
				
			if (tRBrace is null) throw new ArgumentNullException(nameof(tRBrace));
				
				
				
			if (tRBrace.RawKind != (int)CompilerSyntaxKind.TRBrace) throw new ArgumentException(nameof(tRBrace));
				
			
#endif
			
			int hash;
			var cached = __SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.RuleRefAlt3, tHashLBrace, referencedTypes.Node, tRBrace, out hash);
			if (cached != null) return (RuleRefAlt3Green)cached;
		
			var result = new RuleRefAlt3Green(CompilerSyntaxKind.RuleRefAlt3, tHashLBrace, referencedTypes.Node, tRBrace);
			if (hash >= 0)
			{
				__SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
			
		}

			
		
			
		internal LAlternativeGreen LAlternative(global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<LElementGreen> elements)
		{
#if DEBUG
			
				
				
				
				
			
#endif
			
			int hash;
			var cached = __SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.LAlternative, elements.Node, out hash);
			if (cached != null) return (LAlternativeGreen)cached;
		
			var result = new LAlternativeGreen(CompilerSyntaxKind.LAlternative, elements.Node);
			if (hash >= 0)
			{
				__SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
			
		}

			
		
			
		internal LElementGreen LElement(__InternalSyntaxToken isNegated, LElementValueGreen value, __InternalSyntaxToken multiplicity)
		{
#if DEBUG
			
				
				
				
				
			if (isNegated is not null && (isNegated.RawKind != (int)CompilerSyntaxKind.TTilde)) throw new ArgumentException(nameof(isNegated));
				
			
				
				
			if (value is null) throw new ArgumentNullException(nameof(value));
				
				
				
			
				
				
				
				
			if (multiplicity is not null && (multiplicity.RawKind != (int)CompilerSyntaxKind.TQuestion && multiplicity.RawKind != (int)CompilerSyntaxKind.TAsterisk && multiplicity.RawKind != (int)CompilerSyntaxKind.TPlus && multiplicity.RawKind != (int)CompilerSyntaxKind.TQuestionQuestion && multiplicity.RawKind != (int)CompilerSyntaxKind.TAsteriskQuestion && multiplicity.RawKind != (int)CompilerSyntaxKind.TPlusQuestion)) throw new ArgumentException(nameof(multiplicity));
				
			
#endif
			
			int hash;
			var cached = __SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.LElement, isNegated, value, multiplicity, out hash);
			if (cached != null) return (LElementGreen)cached;
		
			var result = new LElementGreen(CompilerSyntaxKind.LElement, isNegated, value, multiplicity);
			if (hash >= 0)
			{
				__SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
			
		}

			
		
			
		internal LElementValueTokensGreen LElementValueTokens(__InternalSyntaxToken token)
		{
#if DEBUG
			
				
				
			if (token is null) throw new ArgumentNullException(nameof(token));
				
				
				
			if (token.RawKind != (int)CompilerSyntaxKind.TString && token.RawKind != (int)CompilerSyntaxKind.TDot) throw new ArgumentException(nameof(token));
				
			
#endif
			
			int hash;
			var cached = __SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.LElementValueTokens, token, out hash);
			if (cached != null) return (LElementValueTokensGreen)cached;
		
			var result = new LElementValueTokensGreen(CompilerSyntaxKind.LElementValueTokens, token);
			if (hash >= 0)
			{
				__SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
			
		}

			
		internal LBlockGreen LBlock(__InternalSyntaxToken tLParen, global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<LAlternativeGreen> alternatives, __InternalSyntaxToken tRParen)
		{
#if DEBUG
			
				
				
			if (tLParen is null) throw new ArgumentNullException(nameof(tLParen));
				
				
				
			if (tLParen.RawKind != (int)CompilerSyntaxKind.TLParen) throw new ArgumentException(nameof(tLParen));
				
			
				
				
				
				
			
				
				
			if (tRParen is null) throw new ArgumentNullException(nameof(tRParen));
				
				
				
			if (tRParen.RawKind != (int)CompilerSyntaxKind.TRParen) throw new ArgumentException(nameof(tRParen));
				
			
#endif
			
			int hash;
			var cached = __SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.LBlock, tLParen, alternatives.Node, tRParen, out hash);
			if (cached != null) return (LBlockGreen)cached;
		
			var result = new LBlockGreen(CompilerSyntaxKind.LBlock, tLParen, alternatives.Node, tRParen);
			if (hash >= 0)
			{
				__SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
			
		}

			
		internal LRangeGreen LRange(__InternalSyntaxToken startChar, __InternalSyntaxToken tDotDot, __InternalSyntaxToken endChar)
		{
#if DEBUG
			
				
				
			if (startChar is null) throw new ArgumentNullException(nameof(startChar));
				
				
				
			if (startChar.RawKind != (int)CompilerSyntaxKind.TString) throw new ArgumentException(nameof(startChar));
				
			
				
				
			if (tDotDot is null) throw new ArgumentNullException(nameof(tDotDot));
				
				
				
			if (tDotDot.RawKind != (int)CompilerSyntaxKind.TDotDot) throw new ArgumentException(nameof(tDotDot));
				
			
				
				
			if (endChar is null) throw new ArgumentNullException(nameof(endChar));
				
				
				
			if (endChar.RawKind != (int)CompilerSyntaxKind.TString) throw new ArgumentException(nameof(endChar));
				
			
#endif
			
			int hash;
			var cached = __SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.LRange, startChar, tDotDot, endChar, out hash);
			if (cached != null) return (LRangeGreen)cached;
		
			var result = new LRangeGreen(CompilerSyntaxKind.LRange, startChar, tDotDot, endChar);
			if (hash >= 0)
			{
				__SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
			
		}

			
		internal LReferenceGreen LReference(IdentifierGreen rule)
		{
#if DEBUG
			
				
				
			if (rule is null) throw new ArgumentNullException(nameof(rule));
				
				
				
			
#endif
			
			int hash;
			var cached = __SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.LReference, rule, out hash);
			if (cached != null) return (LReferenceGreen)cached;
		
			var result = new LReferenceGreen(CompilerSyntaxKind.LReference, rule);
			if (hash >= 0)
			{
				__SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
			
		}

			
		
			
		internal ExpressionAlt1Green ExpressionAlt1(SingleExpressionGreen singleExpression)
		{
#if DEBUG
			
				
				
			if (singleExpression is null) throw new ArgumentNullException(nameof(singleExpression));
				
				
				
			
#endif
			
			int hash;
			var cached = __SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.ExpressionAlt1, singleExpression, out hash);
			if (cached != null) return (ExpressionAlt1Green)cached;
		
			var result = new ExpressionAlt1Green(CompilerSyntaxKind.ExpressionAlt1, singleExpression);
			if (hash >= 0)
			{
				__SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
			
		}

			
		internal ArrayExpressionGreen ArrayExpression(__InternalSyntaxToken tLBrace, global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<SingleExpressionGreen> items, __InternalSyntaxToken tRBrace)
		{
#if DEBUG
			
				
				
			if (tLBrace is null) throw new ArgumentNullException(nameof(tLBrace));
				
				
				
			if (tLBrace.RawKind != (int)CompilerSyntaxKind.TLBrace) throw new ArgumentException(nameof(tLBrace));
				
			
				
				
				
				
			
				
				
			if (tRBrace is null) throw new ArgumentNullException(nameof(tRBrace));
				
				
				
			if (tRBrace.RawKind != (int)CompilerSyntaxKind.TRBrace) throw new ArgumentException(nameof(tRBrace));
				
			
#endif
			
			int hash;
			var cached = __SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.ArrayExpression, tLBrace, items.Node, tRBrace, out hash);
			if (cached != null) return (ArrayExpressionGreen)cached;
		
			var result = new ArrayExpressionGreen(CompilerSyntaxKind.ArrayExpression, tLBrace, items.Node, tRBrace);
			if (hash >= 0)
			{
				__SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
			
		}

			
		
			
		internal SingleExpressionGreen SingleExpression(SingleExpressionBlock1Green value)
		{
#if DEBUG
			
				
				
			if (value is null) throw new ArgumentNullException(nameof(value));
				
				
				
			
#endif
			
			int hash;
			var cached = __SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.SingleExpression, value, out hash);
			if (cached != null) return (SingleExpressionGreen)cached;
		
			var result = new SingleExpressionGreen(CompilerSyntaxKind.SingleExpression, value);
			if (hash >= 0)
			{
				__SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
			
		}

			
		
			
		internal ParserAnnotationGreen ParserAnnotation(__InternalSyntaxToken tLBracket, global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<IdentifierGreen> qualifier, AnnotationArgumentsGreen annotationArguments, __InternalSyntaxToken tRBracket)
		{
#if DEBUG
			
				
				
			if (tLBracket is null) throw new ArgumentNullException(nameof(tLBracket));
				
				
				
			if (tLBracket.RawKind != (int)CompilerSyntaxKind.TLBracket) throw new ArgumentException(nameof(tLBracket));
				
			
				
				
				
				
			
				
				
				
				
			
				
				
			if (tRBracket is null) throw new ArgumentNullException(nameof(tRBracket));
				
				
				
			if (tRBracket.RawKind != (int)CompilerSyntaxKind.TRBracket) throw new ArgumentException(nameof(tRBracket));
				
			
#endif
			
			return new ParserAnnotationGreen(CompilerSyntaxKind.ParserAnnotation, tLBracket, qualifier.Node, annotationArguments, tRBracket);
			
		}

			
		
			
		internal LexerAnnotationGreen LexerAnnotation(__InternalSyntaxToken tLBracket, global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<IdentifierGreen> qualifier, AnnotationArgumentsGreen annotationArguments, __InternalSyntaxToken tRBracket)
		{
#if DEBUG
			
				
				
			if (tLBracket is null) throw new ArgumentNullException(nameof(tLBracket));
				
				
				
			if (tLBracket.RawKind != (int)CompilerSyntaxKind.TLBracket) throw new ArgumentException(nameof(tLBracket));
				
			
				
				
				
				
			
				
				
				
				
			
				
				
			if (tRBracket is null) throw new ArgumentNullException(nameof(tRBracket));
				
				
				
			if (tRBracket.RawKind != (int)CompilerSyntaxKind.TRBracket) throw new ArgumentException(nameof(tRBracket));
				
			
#endif
			
			return new LexerAnnotationGreen(CompilerSyntaxKind.LexerAnnotation, tLBracket, qualifier.Node, annotationArguments, tRBracket);
			
		}

			
		
			
		internal AnnotationArgumentsGreen AnnotationArguments(__InternalSyntaxToken tLParen, global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<AnnotationArgumentGreen> arguments, __InternalSyntaxToken tRParen)
		{
#if DEBUG
			
				
				
			if (tLParen is null) throw new ArgumentNullException(nameof(tLParen));
				
				
				
			if (tLParen.RawKind != (int)CompilerSyntaxKind.TLParen) throw new ArgumentException(nameof(tLParen));
				
			
				
				
				
				
			
				
				
			if (tRParen is null) throw new ArgumentNullException(nameof(tRParen));
				
				
				
			if (tRParen.RawKind != (int)CompilerSyntaxKind.TRParen) throw new ArgumentException(nameof(tRParen));
				
			
#endif
			
			int hash;
			var cached = __SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.AnnotationArguments, tLParen, arguments.Node, tRParen, out hash);
			if (cached != null) return (AnnotationArgumentsGreen)cached;
		
			var result = new AnnotationArgumentsGreen(CompilerSyntaxKind.AnnotationArguments, tLParen, arguments.Node, tRParen);
			if (hash >= 0)
			{
				__SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
			
		}

			
		
			
		internal AnnotationArgumentGreen AnnotationArgument(AnnotationArgumentBlock1Green block, ExpressionGreen value)
		{
#if DEBUG
			
				
				
				
				
			
				
				
			if (value is null) throw new ArgumentNullException(nameof(value));
				
				
				
			
#endif
			
			int hash;
			var cached = __SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.AnnotationArgument, block, value, out hash);
			if (cached != null) return (AnnotationArgumentGreen)cached;
		
			var result = new AnnotationArgumentGreen(CompilerSyntaxKind.AnnotationArgument, block, value);
			if (hash >= 0)
			{
				__SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
			
		}

			
		
			
		internal ReturnTypeIdentifierAlt1Green ReturnTypeIdentifierAlt1(__InternalSyntaxToken tokens)
		{
#if DEBUG
			
				
				
			if (tokens is null) throw new ArgumentNullException(nameof(tokens));
				
				
				
			if (tokens.RawKind != (int)CompilerSyntaxKind.KBool && tokens.RawKind != (int)CompilerSyntaxKind.KInt && tokens.RawKind != (int)CompilerSyntaxKind.KString && tokens.RawKind != (int)CompilerSyntaxKind.KType && tokens.RawKind != (int)CompilerSyntaxKind.KSymbol && tokens.RawKind != (int)CompilerSyntaxKind.KObject && tokens.RawKind != (int)CompilerSyntaxKind.KVoid) throw new ArgumentException(nameof(tokens));
				
			
#endif
			
			int hash;
			var cached = __SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.ReturnTypeIdentifierAlt1, tokens, out hash);
			if (cached != null) return (ReturnTypeIdentifierAlt1Green)cached;
		
			var result = new ReturnTypeIdentifierAlt1Green(CompilerSyntaxKind.ReturnTypeIdentifierAlt1, tokens);
			if (hash >= 0)
			{
				__SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
			
		}

			
		internal ReturnTypeIdentifierAlt2Green ReturnTypeIdentifierAlt2(IdentifierGreen identifier)
		{
#if DEBUG
			
				
				
			if (identifier is null) throw new ArgumentNullException(nameof(identifier));
				
				
				
			
#endif
			
			int hash;
			var cached = __SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.ReturnTypeIdentifierAlt2, identifier, out hash);
			if (cached != null) return (ReturnTypeIdentifierAlt2Green)cached;
		
			var result = new ReturnTypeIdentifierAlt2Green(CompilerSyntaxKind.ReturnTypeIdentifierAlt2, identifier);
			if (hash >= 0)
			{
				__SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
			
		}

			
		
			
		internal ReturnTypeQualifierAlt1Green ReturnTypeQualifierAlt1(__InternalSyntaxToken tokens)
		{
#if DEBUG
			
				
				
			if (tokens is null) throw new ArgumentNullException(nameof(tokens));
				
				
				
			if (tokens.RawKind != (int)CompilerSyntaxKind.KBool && tokens.RawKind != (int)CompilerSyntaxKind.KInt && tokens.RawKind != (int)CompilerSyntaxKind.KString && tokens.RawKind != (int)CompilerSyntaxKind.KType && tokens.RawKind != (int)CompilerSyntaxKind.KSymbol && tokens.RawKind != (int)CompilerSyntaxKind.KObject && tokens.RawKind != (int)CompilerSyntaxKind.KVoid) throw new ArgumentException(nameof(tokens));
				
			
#endif
			
			int hash;
			var cached = __SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.ReturnTypeQualifierAlt1, tokens, out hash);
			if (cached != null) return (ReturnTypeQualifierAlt1Green)cached;
		
			var result = new ReturnTypeQualifierAlt1Green(CompilerSyntaxKind.ReturnTypeQualifierAlt1, tokens);
			if (hash >= 0)
			{
				__SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
			
		}

			
		internal ReturnTypeQualifierAlt2Green ReturnTypeQualifierAlt2(global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<IdentifierGreen> qualifier)
		{
#if DEBUG
			
				
				
				
				
			
#endif
			
			int hash;
			var cached = __SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.ReturnTypeQualifierAlt2, qualifier.Node, out hash);
			if (cached != null) return (ReturnTypeQualifierAlt2Green)cached;
		
			var result = new ReturnTypeQualifierAlt2Green(CompilerSyntaxKind.ReturnTypeQualifierAlt2, qualifier.Node);
			if (hash >= 0)
			{
				__SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
			
		}

			
		
			
		internal NameGreen Name(IdentifierGreen identifier)
		{
#if DEBUG
			
				
				
			if (identifier is null) throw new ArgumentNullException(nameof(identifier));
				
				
				
			
#endif
			
			int hash;
			var cached = __SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.Name, identifier, out hash);
			if (cached != null) return (NameGreen)cached;
		
			var result = new NameGreen(CompilerSyntaxKind.Name, identifier);
			if (hash >= 0)
			{
				__SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
			
		}

			
		
			
		internal IdentifierGreen Identifier(__InternalSyntaxToken token)
		{
#if DEBUG
			
				
				
			if (token is null) throw new ArgumentNullException(nameof(token));
				
				
				
			if (token.RawKind != (int)CompilerSyntaxKind.TIdentifier && token.RawKind != (int)CompilerSyntaxKind.TVerbatimIdentifier) throw new ArgumentException(nameof(token));
				
			
#endif
			
			int hash;
			var cached = __SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.Identifier, token, out hash);
			if (cached != null) return (IdentifierGreen)cached;
		
			var result = new IdentifierGreen(CompilerSyntaxKind.Identifier, token);
			if (hash >= 0)
			{
				__SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
			
		}

			
		
			
		internal SimpleIdentifierGreen SimpleIdentifier(__InternalSyntaxToken tIdentifier)
		{
#if DEBUG
			
				
				
			if (tIdentifier is null) throw new ArgumentNullException(nameof(tIdentifier));
				
				
				
			if (tIdentifier.RawKind != (int)CompilerSyntaxKind.TIdentifier) throw new ArgumentException(nameof(tIdentifier));
				
			
#endif
			
			int hash;
			var cached = __SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.SimpleIdentifier, tIdentifier, out hash);
			if (cached != null) return (SimpleIdentifierGreen)cached;
		
			var result = new SimpleIdentifierGreen(CompilerSyntaxKind.SimpleIdentifier, tIdentifier);
			if (hash >= 0)
			{
				__SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
			
		}

			
		
			
		internal RuleBlock1Alt1Green RuleBlock1Alt1(ReturnTypeIdentifierGreen returnType)
		{
#if DEBUG
			
				
				
			if (returnType is null) throw new ArgumentNullException(nameof(returnType));
				
				
				
			
#endif
			
			int hash;
			var cached = __SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.RuleBlock1Alt1, returnType, out hash);
			if (cached != null) return (RuleBlock1Alt1Green)cached;
		
			var result = new RuleBlock1Alt1Green(CompilerSyntaxKind.RuleBlock1Alt1, returnType);
			if (hash >= 0)
			{
				__SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
			
		}

			
		internal RuleBlock1Alt2Green RuleBlock1Alt2(IdentifierGreen identifier, __InternalSyntaxToken kReturns, ReturnTypeQualifierGreen returnType)
		{
#if DEBUG
			
				
				
			if (identifier is null) throw new ArgumentNullException(nameof(identifier));
				
				
				
			
				
				
			if (kReturns is null) throw new ArgumentNullException(nameof(kReturns));
				
				
				
			if (kReturns.RawKind != (int)CompilerSyntaxKind.KReturns) throw new ArgumentException(nameof(kReturns));
				
			
				
				
			if (returnType is null) throw new ArgumentNullException(nameof(returnType));
				
				
				
			
#endif
			
			int hash;
			var cached = __SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.RuleBlock1Alt2, identifier, kReturns, returnType, out hash);
			if (cached != null) return (RuleBlock1Alt2Green)cached;
		
			var result = new RuleBlock1Alt2Green(CompilerSyntaxKind.RuleBlock1Alt2, identifier, kReturns, returnType);
			if (hash >= 0)
			{
				__SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
			
		}

			
		
			
		internal RuleAlternativesBlockGreen RuleAlternativesBlock(__InternalSyntaxToken tBar, AlternativeGreen alternatives)
		{
#if DEBUG
			
				
				
			if (tBar is null) throw new ArgumentNullException(nameof(tBar));
				
				
				
			if (tBar.RawKind != (int)CompilerSyntaxKind.TBar) throw new ArgumentException(nameof(tBar));
				
			
				
				
			if (alternatives is null) throw new ArgumentNullException(nameof(alternatives));
				
				
				
			
#endif
			
			int hash;
			var cached = __SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.RuleAlternativesBlock, tBar, alternatives, out hash);
			if (cached != null) return (RuleAlternativesBlockGreen)cached;
		
			var result = new RuleAlternativesBlockGreen(CompilerSyntaxKind.RuleAlternativesBlock, tBar, alternatives);
			if (hash >= 0)
			{
				__SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
			
		}

			
		
			
		internal BlockBlock1Green BlockBlock1(__InternalSyntaxToken kReturns, ReturnTypeQualifierGreen returnType)
		{
#if DEBUG
			
				
				
			if (kReturns is null) throw new ArgumentNullException(nameof(kReturns));
				
				
				
			if (kReturns.RawKind != (int)CompilerSyntaxKind.KReturns) throw new ArgumentException(nameof(kReturns));
				
			
				
				
			if (returnType is null) throw new ArgumentNullException(nameof(returnType));
				
				
				
			
#endif
			
			int hash;
			var cached = __SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.BlockBlock1, kReturns, returnType, out hash);
			if (cached != null) return (BlockBlock1Green)cached;
		
			var result = new BlockBlock1Green(CompilerSyntaxKind.BlockBlock1, kReturns, returnType);
			if (hash >= 0)
			{
				__SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
			
		}

			
		
			
		internal BlockAlternativesBlockGreen BlockAlternativesBlock(__InternalSyntaxToken tBar, AlternativeGreen alternatives)
		{
#if DEBUG
			
				
				
			if (tBar is null) throw new ArgumentNullException(nameof(tBar));
				
				
				
			if (tBar.RawKind != (int)CompilerSyntaxKind.TBar) throw new ArgumentException(nameof(tBar));
				
			
				
				
			if (alternatives is null) throw new ArgumentNullException(nameof(alternatives));
				
				
				
			
#endif
			
			int hash;
			var cached = __SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.BlockAlternativesBlock, tBar, alternatives, out hash);
			if (cached != null) return (BlockAlternativesBlockGreen)cached;
		
			var result = new BlockAlternativesBlockGreen(CompilerSyntaxKind.BlockAlternativesBlock, tBar, alternatives);
			if (hash >= 0)
			{
				__SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
			
		}

			
		
			
		internal BlockInlineAlternativesBlockGreen BlockInlineAlternativesBlock(__InternalSyntaxToken tBar, AlternativeGreen alternatives)
		{
#if DEBUG
			
				
				
			if (tBar is null) throw new ArgumentNullException(nameof(tBar));
				
				
				
			if (tBar.RawKind != (int)CompilerSyntaxKind.TBar) throw new ArgumentException(nameof(tBar));
				
			
				
				
			if (alternatives is null) throw new ArgumentNullException(nameof(alternatives));
				
				
				
			
#endif
			
			int hash;
			var cached = __SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.BlockInlineAlternativesBlock, tBar, alternatives, out hash);
			if (cached != null) return (BlockInlineAlternativesBlockGreen)cached;
		
			var result = new BlockInlineAlternativesBlockGreen(CompilerSyntaxKind.BlockInlineAlternativesBlock, tBar, alternatives);
			if (hash >= 0)
			{
				__SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
			
		}

			
		
			
		internal AlternativeBlock1Green AlternativeBlock1(global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<ParserAnnotationGreen> annotations1, __InternalSyntaxToken kAlt, NameGreen name, AlternativeBlock1Block1Green block, __InternalSyntaxToken tColon)
		{
#if DEBUG
			
				
				
				
				
			
				
				
			if (kAlt is null) throw new ArgumentNullException(nameof(kAlt));
				
				
				
			if (kAlt.RawKind != (int)CompilerSyntaxKind.KAlt) throw new ArgumentException(nameof(kAlt));
				
			
				
				
			if (name is null) throw new ArgumentNullException(nameof(name));
				
				
				
			
				
				
				
				
			
				
				
			if (tColon is null) throw new ArgumentNullException(nameof(tColon));
				
				
				
			if (tColon.RawKind != (int)CompilerSyntaxKind.TColon) throw new ArgumentException(nameof(tColon));
				
			
#endif
			
			return new AlternativeBlock1Green(CompilerSyntaxKind.AlternativeBlock1, annotations1.Node, kAlt, name, block, tColon);
			
		}

			
		
			
		internal AlternativeBlock1Block1Green AlternativeBlock1Block1(__InternalSyntaxToken kReturns, ReturnTypeQualifierGreen returnType)
		{
#if DEBUG
			
				
				
			if (kReturns is null) throw new ArgumentNullException(nameof(kReturns));
				
				
				
			if (kReturns.RawKind != (int)CompilerSyntaxKind.KReturns) throw new ArgumentException(nameof(kReturns));
				
			
				
				
			if (returnType is null) throw new ArgumentNullException(nameof(returnType));
				
				
				
			
#endif
			
			int hash;
			var cached = __SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.AlternativeBlock1Block1, kReturns, returnType, out hash);
			if (cached != null) return (AlternativeBlock1Block1Green)cached;
		
			var result = new AlternativeBlock1Block1Green(CompilerSyntaxKind.AlternativeBlock1Block1, kReturns, returnType);
			if (hash >= 0)
			{
				__SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
			
		}

			
		
			
		internal AlternativeBlock2Green AlternativeBlock2(__InternalSyntaxToken tEqGt, ExpressionGreen returnValue)
		{
#if DEBUG
			
				
				
			if (tEqGt is null) throw new ArgumentNullException(nameof(tEqGt));
				
				
				
			if (tEqGt.RawKind != (int)CompilerSyntaxKind.TEqGt) throw new ArgumentException(nameof(tEqGt));
				
			
				
				
			if (returnValue is null) throw new ArgumentNullException(nameof(returnValue));
				
				
				
			
#endif
			
			int hash;
			var cached = __SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.AlternativeBlock2, tEqGt, returnValue, out hash);
			if (cached != null) return (AlternativeBlock2Green)cached;
		
			var result = new AlternativeBlock2Green(CompilerSyntaxKind.AlternativeBlock2, tEqGt, returnValue);
			if (hash >= 0)
			{
				__SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
			
		}

			
		
			
		internal ElementBlock1Green ElementBlock1(global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<ParserAnnotationGreen> nameAnnotations, IdentifierGreen symbolProperty, __InternalSyntaxToken assignment)
		{
#if DEBUG
			
				
				
				
				
			
				
				
			if (symbolProperty is null) throw new ArgumentNullException(nameof(symbolProperty));
				
				
				
			
				
				
			if (assignment is null) throw new ArgumentNullException(nameof(assignment));
				
				
				
			if (assignment.RawKind != (int)CompilerSyntaxKind.TEq && assignment.RawKind != (int)CompilerSyntaxKind.TQuestionEq && assignment.RawKind != (int)CompilerSyntaxKind.TExclEq && assignment.RawKind != (int)CompilerSyntaxKind.TPlusEq) throw new ArgumentException(nameof(assignment));
				
			
#endif
			
			int hash;
			var cached = __SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.ElementBlock1, nameAnnotations.Node, symbolProperty, assignment, out hash);
			if (cached != null) return (ElementBlock1Green)cached;
		
			var result = new ElementBlock1Green(CompilerSyntaxKind.ElementBlock1, nameAnnotations.Node, symbolProperty, assignment);
			if (hash >= 0)
			{
				__SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
			
		}

			
		
			
		internal RuleRefAlt3ReferencedTypesBlockGreen RuleRefAlt3ReferencedTypesBlock(__InternalSyntaxToken tComma, ReturnTypeQualifierGreen referencedTypes)
		{
#if DEBUG
			
				
				
			if (tComma is null) throw new ArgumentNullException(nameof(tComma));
				
				
				
			if (tComma.RawKind != (int)CompilerSyntaxKind.TComma) throw new ArgumentException(nameof(tComma));
				
			
				
				
			if (referencedTypes is null) throw new ArgumentNullException(nameof(referencedTypes));
				
				
				
			
#endif
			
			int hash;
			var cached = __SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.RuleRefAlt3ReferencedTypesBlock, tComma, referencedTypes, out hash);
			if (cached != null) return (RuleRefAlt3ReferencedTypesBlockGreen)cached;
		
			var result = new RuleRefAlt3ReferencedTypesBlockGreen(CompilerSyntaxKind.RuleRefAlt3ReferencedTypesBlock, tComma, referencedTypes);
			if (hash >= 0)
			{
				__SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
			
		}

			
		
			
		internal TokenBlock1Alt1Green TokenBlock1Alt1(__InternalSyntaxToken kToken, NameGreen name, TokenBlock1Alt1Block1Green block)
		{
#if DEBUG
			
				
				
			if (kToken is null) throw new ArgumentNullException(nameof(kToken));
				
				
				
			if (kToken.RawKind != (int)CompilerSyntaxKind.KToken) throw new ArgumentException(nameof(kToken));
				
			
				
				
			if (name is null) throw new ArgumentNullException(nameof(name));
				
				
				
			
				
				
				
				
			
#endif
			
			int hash;
			var cached = __SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.TokenBlock1Alt1, kToken, name, block, out hash);
			if (cached != null) return (TokenBlock1Alt1Green)cached;
		
			var result = new TokenBlock1Alt1Green(CompilerSyntaxKind.TokenBlock1Alt1, kToken, name, block);
			if (hash >= 0)
			{
				__SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
			
		}

			
		internal TokenBlock1Alt2Green TokenBlock1Alt2(__InternalSyntaxToken isTrivia, NameGreen name)
		{
#if DEBUG
			
				
				
			if (isTrivia is null) throw new ArgumentNullException(nameof(isTrivia));
				
				
				
			if (isTrivia.RawKind != (int)CompilerSyntaxKind.KHidden) throw new ArgumentException(nameof(isTrivia));
				
			
				
				
			if (name is null) throw new ArgumentNullException(nameof(name));
				
				
				
			
#endif
			
			int hash;
			var cached = __SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.TokenBlock1Alt2, isTrivia, name, out hash);
			if (cached != null) return (TokenBlock1Alt2Green)cached;
		
			var result = new TokenBlock1Alt2Green(CompilerSyntaxKind.TokenBlock1Alt2, isTrivia, name);
			if (hash >= 0)
			{
				__SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
			
		}

			
		
			
		internal TokenBlock1Alt1Block1Green TokenBlock1Alt1Block1(__InternalSyntaxToken kReturns, ReturnTypeQualifierGreen returnType)
		{
#if DEBUG
			
				
				
			if (kReturns is null) throw new ArgumentNullException(nameof(kReturns));
				
				
				
			if (kReturns.RawKind != (int)CompilerSyntaxKind.KReturns) throw new ArgumentException(nameof(kReturns));
				
			
				
				
			if (returnType is null) throw new ArgumentNullException(nameof(returnType));
				
				
				
			
#endif
			
			int hash;
			var cached = __SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.TokenBlock1Alt1Block1, kReturns, returnType, out hash);
			if (cached != null) return (TokenBlock1Alt1Block1Green)cached;
		
			var result = new TokenBlock1Alt1Block1Green(CompilerSyntaxKind.TokenBlock1Alt1Block1, kReturns, returnType);
			if (hash >= 0)
			{
				__SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
			
		}

			
		
			
		internal TokenAlternativesBlockGreen TokenAlternativesBlock(__InternalSyntaxToken tBar, LAlternativeGreen alternatives)
		{
#if DEBUG
			
				
				
			if (tBar is null) throw new ArgumentNullException(nameof(tBar));
				
				
				
			if (tBar.RawKind != (int)CompilerSyntaxKind.TBar) throw new ArgumentException(nameof(tBar));
				
			
				
				
			if (alternatives is null) throw new ArgumentNullException(nameof(alternatives));
				
				
				
			
#endif
			
			int hash;
			var cached = __SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.TokenAlternativesBlock, tBar, alternatives, out hash);
			if (cached != null) return (TokenAlternativesBlockGreen)cached;
		
			var result = new TokenAlternativesBlockGreen(CompilerSyntaxKind.TokenAlternativesBlock, tBar, alternatives);
			if (hash >= 0)
			{
				__SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
			
		}

			
		
			
		internal FragmentAlternativesBlockGreen FragmentAlternativesBlock(__InternalSyntaxToken tBar, LAlternativeGreen alternatives)
		{
#if DEBUG
			
				
				
			if (tBar is null) throw new ArgumentNullException(nameof(tBar));
				
				
				
			if (tBar.RawKind != (int)CompilerSyntaxKind.TBar) throw new ArgumentException(nameof(tBar));
				
			
				
				
			if (alternatives is null) throw new ArgumentNullException(nameof(alternatives));
				
				
				
			
#endif
			
			int hash;
			var cached = __SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.FragmentAlternativesBlock, tBar, alternatives, out hash);
			if (cached != null) return (FragmentAlternativesBlockGreen)cached;
		
			var result = new FragmentAlternativesBlockGreen(CompilerSyntaxKind.FragmentAlternativesBlock, tBar, alternatives);
			if (hash >= 0)
			{
				__SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
			
		}

			
		
			
		internal LBlockAlternativesBlockGreen LBlockAlternativesBlock(__InternalSyntaxToken tBar, LAlternativeGreen alternatives)
		{
#if DEBUG
			
				
				
			if (tBar is null) throw new ArgumentNullException(nameof(tBar));
				
				
				
			if (tBar.RawKind != (int)CompilerSyntaxKind.TBar) throw new ArgumentException(nameof(tBar));
				
			
				
				
			if (alternatives is null) throw new ArgumentNullException(nameof(alternatives));
				
				
				
			
#endif
			
			int hash;
			var cached = __SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.LBlockAlternativesBlock, tBar, alternatives, out hash);
			if (cached != null) return (LBlockAlternativesBlockGreen)cached;
		
			var result = new LBlockAlternativesBlockGreen(CompilerSyntaxKind.LBlockAlternativesBlock, tBar, alternatives);
			if (hash >= 0)
			{
				__SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
			
		}

			
		
			
		internal TokensGreen Tokens(__InternalSyntaxToken token)
		{
#if DEBUG
			
				
				
			if (token is null) throw new ArgumentNullException(nameof(token));
				
				
				
			if (token.RawKind != (int)CompilerSyntaxKind.KNull && token.RawKind != (int)CompilerSyntaxKind.KTrue && token.RawKind != (int)CompilerSyntaxKind.KFalse && token.RawKind != (int)CompilerSyntaxKind.TInteger && token.RawKind != (int)CompilerSyntaxKind.TString) throw new ArgumentException(nameof(token));
				
			
#endif
			
			int hash;
			var cached = __SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.Tokens, token, out hash);
			if (cached != null) return (TokensGreen)cached;
		
			var result = new TokensGreen(CompilerSyntaxKind.Tokens, token);
			if (hash >= 0)
			{
				__SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
			
		}

			
		internal SingleExpressionBlock1Alt2Green SingleExpressionBlock1Alt2(global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<SimpleIdentifierGreen> simpleQualifier)
		{
#if DEBUG
			
				
				
				
				
			
#endif
			
			int hash;
			var cached = __SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.SingleExpressionBlock1Alt2, simpleQualifier.Node, out hash);
			if (cached != null) return (SingleExpressionBlock1Alt2Green)cached;
		
			var result = new SingleExpressionBlock1Alt2Green(CompilerSyntaxKind.SingleExpressionBlock1Alt2, simpleQualifier.Node);
			if (hash >= 0)
			{
				__SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
			
		}

			
		
			
		internal ArrayExpressionItemsBlockGreen ArrayExpressionItemsBlock(__InternalSyntaxToken tComma, SingleExpressionGreen items)
		{
#if DEBUG
			
				
				
			if (tComma is null) throw new ArgumentNullException(nameof(tComma));
				
				
				
			if (tComma.RawKind != (int)CompilerSyntaxKind.TComma) throw new ArgumentException(nameof(tComma));
				
			
				
				
			if (items is null) throw new ArgumentNullException(nameof(items));
				
				
				
			
#endif
			
			int hash;
			var cached = __SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.ArrayExpressionItemsBlock, tComma, items, out hash);
			if (cached != null) return (ArrayExpressionItemsBlockGreen)cached;
		
			var result = new ArrayExpressionItemsBlockGreen(CompilerSyntaxKind.ArrayExpressionItemsBlock, tComma, items);
			if (hash >= 0)
			{
				__SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
			
		}

			
		
			
		internal AnnotationArgumentsArgumentsBlockGreen AnnotationArgumentsArgumentsBlock(__InternalSyntaxToken tComma, AnnotationArgumentGreen arguments)
		{
#if DEBUG
			
				
				
			if (tComma is null) throw new ArgumentNullException(nameof(tComma));
				
				
				
			if (tComma.RawKind != (int)CompilerSyntaxKind.TComma) throw new ArgumentException(nameof(tComma));
				
			
				
				
			if (arguments is null) throw new ArgumentNullException(nameof(arguments));
				
				
				
			
#endif
			
			int hash;
			var cached = __SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.AnnotationArgumentsArgumentsBlock, tComma, arguments, out hash);
			if (cached != null) return (AnnotationArgumentsArgumentsBlockGreen)cached;
		
			var result = new AnnotationArgumentsArgumentsBlockGreen(CompilerSyntaxKind.AnnotationArgumentsArgumentsBlock, tComma, arguments);
			if (hash >= 0)
			{
				__SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
			
		}

			
		
			
		internal AnnotationArgumentBlock1Green AnnotationArgumentBlock1(IdentifierGreen namedParameter, __InternalSyntaxToken tColon)
		{
#if DEBUG
			
				
				
			if (namedParameter is null) throw new ArgumentNullException(nameof(namedParameter));
				
				
				
			
				
				
			if (tColon is null) throw new ArgumentNullException(nameof(tColon));
				
				
				
			if (tColon.RawKind != (int)CompilerSyntaxKind.TColon) throw new ArgumentException(nameof(tColon));
				
			
#endif
			
			int hash;
			var cached = __SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.AnnotationArgumentBlock1, namedParameter, tColon, out hash);
			if (cached != null) return (AnnotationArgumentBlock1Green)cached;
		
			var result = new AnnotationArgumentBlock1Green(CompilerSyntaxKind.AnnotationArgumentBlock1, namedParameter, tColon);
			if (hash >= 0)
			{
				__SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
			
		}

			
		
			
		internal MainQualifierBlockGreen MainQualifierBlock(__InternalSyntaxToken tDot, IdentifierGreen identifier)
		{
#if DEBUG
			
				
				
			if (tDot is null) throw new ArgumentNullException(nameof(tDot));
				
				
				
			if (tDot.RawKind != (int)CompilerSyntaxKind.TDot) throw new ArgumentException(nameof(tDot));
				
			
				
				
			if (identifier is null) throw new ArgumentNullException(nameof(identifier));
				
				
				
			
#endif
			
			int hash;
			var cached = __SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.MainQualifierBlock, tDot, identifier, out hash);
			if (cached != null) return (MainQualifierBlockGreen)cached;
		
			var result = new MainQualifierBlockGreen(CompilerSyntaxKind.MainQualifierBlock, tDot, identifier);
			if (hash >= 0)
			{
				__SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
			
		}

			
		
			
		internal SingleExpressionBlock1Alt2SimpleQualifierBlockGreen SingleExpressionBlock1Alt2SimpleQualifierBlock(__InternalSyntaxToken tDot, SimpleIdentifierGreen simpleIdentifier)
		{
#if DEBUG
			
				
				
			if (tDot is null) throw new ArgumentNullException(nameof(tDot));
				
				
				
			if (tDot.RawKind != (int)CompilerSyntaxKind.TDot) throw new ArgumentException(nameof(tDot));
				
			
				
				
			if (simpleIdentifier is null) throw new ArgumentNullException(nameof(simpleIdentifier));
				
				
				
			
#endif
			
			int hash;
			var cached = __SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.SingleExpressionBlock1Alt2SimpleQualifierBlock, tDot, simpleIdentifier, out hash);
			if (cached != null) return (SingleExpressionBlock1Alt2SimpleQualifierBlockGreen)cached;
		
			var result = new SingleExpressionBlock1Alt2SimpleQualifierBlockGreen(CompilerSyntaxKind.SingleExpressionBlock1Alt2SimpleQualifierBlock, tDot, simpleIdentifier);
			if (hash >= 0)
			{
				__SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
			
		}

			
		
	}
}
