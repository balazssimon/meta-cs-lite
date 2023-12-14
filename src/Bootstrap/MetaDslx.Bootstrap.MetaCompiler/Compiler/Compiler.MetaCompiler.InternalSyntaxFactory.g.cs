using System;
using System.Threading;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;

#nullable enable

namespace MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax
{
    using MetaDslx.CodeAnalysis;
    using MetaDslx.CodeAnalysis.Syntax;
    using MetaDslx.CodeAnalysis.Syntax.InternalSyntax;
    using MetaDslx.CodeAnalysis.Text;

	public partial class CompilerInternalSyntaxFactory : InternalSyntaxFactory
	{
		public CompilerInternalSyntaxFactory(SyntaxFacts syntaxFacts) 
		    : base(syntaxFacts)
		{
		}
	
		public override SyntaxLexer CreateLexer(SourceText text, ParseOptions? options)
		{
			return new CompilerSyntaxLexer(text, (CompilerParseOptions)(options ?? CompilerParseOptions.Default));
		}

		public override SyntaxParser CreateParser(SyntaxLexer lexer, IncrementalParseData? oldParseData, IEnumerable<TextChangeRange>? changes, CancellationToken cancellationToken = default)
        {
			return new CompilerSyntaxParser((CompilerSyntaxLexer)lexer, oldParseData, changes, cancellationToken);
		}

		public InternalSyntaxTrivia Trivia(CompilerSyntaxKind kind, string text, bool elastic = false)
        {
			var trivia = GreenSyntaxTrivia.Create(kind, text);
			if (!elastic) return trivia;
			return trivia.WithAnnotationsGreen(new[] { SyntaxAnnotation.ElasticAnnotation });
		}

		protected override InternalSyntaxTrivia Trivia(int kind, string text, bool elastic = false)
	    {
	        return Trivia((CompilerSyntaxKind)kind, text, elastic);
	    }
	
		public override InternalSyntaxNode SkippedTokensTrivia(GreenNode token)
		{
			return new GreenSkippedTokensTriviaSyntax((CompilerSyntaxKind)InternalSyntaxKind.SkippedTokensTrivia, token);
		}
	
	    public InternalSyntaxToken Token(CompilerSyntaxKind kind)
	    {
	        return GreenSyntaxToken.Create(kind);
	    }

        protected override InternalSyntaxToken Token(int kind)
        {
			return Token((CompilerSyntaxKind)kind);
        }

        public InternalSyntaxToken Token(GreenNode? leading, CompilerSyntaxKind kind, GreenNode? trailing)
	    {
	        return GreenSyntaxToken.Create(kind, leading, trailing);
	    }

        protected override InternalSyntaxToken Token(GreenNode? leading, int kind, GreenNode? trailing)
        {
			return Token(leading, (CompilerSyntaxKind)kind, trailing);
        }

        public InternalSyntaxToken Token(GreenNode? leading, CompilerSyntaxKind kind, string text, GreenNode? trailing)
	    {
	        Debug.Assert(CompilerLanguage.Instance.SyntaxFacts.IsToken(kind));
	        string defaultText = CompilerLanguage.Instance.SyntaxFacts.GetText(kind);
	        return kind >= GreenSyntaxToken.FirstTokenWithWellKnownText && kind <= GreenSyntaxToken.LastTokenWithWellKnownText && text == defaultText
	            ? Token(leading, kind, trailing)
	            : GreenSyntaxToken.Identifier(kind, leading, text, trailing);
	    }

        protected override InternalSyntaxToken Token(GreenNode? leading, int kind, string text, GreenNode? trailing)
        {
            return Token(leading, (CompilerSyntaxKind)kind, text, trailing);
        }

        public InternalSyntaxToken Token(GreenNode? leading, CompilerSyntaxKind kind, string text, string valueText, GreenNode? trailing)
	    {
	        Debug.Assert(CompilerLanguage.Instance.SyntaxFacts.IsToken(kind));
	        string defaultText = CompilerLanguage.Instance.SyntaxFacts.GetText(kind);
	        return kind >= GreenSyntaxToken.FirstTokenWithWellKnownText && kind <= GreenSyntaxToken.LastTokenWithWellKnownText && text == defaultText && valueText == defaultText
	            ? Token(leading, kind, trailing)
	            : GreenSyntaxToken.WithValue(kind, leading, text, valueText, trailing);
	    }

		protected override InternalSyntaxToken Token(GreenNode? leading, int kind, string text, string valueText, GreenNode? trailing)
		{
			return Token(leading, (CompilerSyntaxKind)kind, text, valueText, trailing);
		}

		public InternalSyntaxToken Token(GreenNode? leading, CompilerSyntaxKind kind, string text, object value, GreenNode? trailing)
	    {
	        Debug.Assert(CompilerLanguage.Instance.SyntaxFacts.IsToken(kind));
	        string defaultText = CompilerLanguage.Instance.SyntaxFacts.GetText(kind);
	        return kind >= GreenSyntaxToken.FirstTokenWithWellKnownText && kind <= GreenSyntaxToken.LastTokenWithWellKnownText && text == defaultText && defaultText.Equals(value)
	            ? Token(leading, kind, trailing)
	            : GreenSyntaxToken.WithValue(kind, leading, text, value, trailing);
	    }

		protected override InternalSyntaxToken Token(GreenNode? leading, int kind, string text, object value, GreenNode? trailing)
		{
			return Token(leading, (CompilerSyntaxKind)kind, text, value, trailing);
		}

		public InternalSyntaxToken MissingToken(CompilerSyntaxKind kind)
	    {
	        return GreenSyntaxToken.CreateMissing(kind, null, null);
	    }

        protected override InternalSyntaxToken MissingToken(int kind)
        {
			return MissingToken((CompilerSyntaxKind)kind);
        }

        public InternalSyntaxToken MissingToken(GreenNode? leading, CompilerSyntaxKind kind, GreenNode? trailing)
	    {
	        return GreenSyntaxToken.CreateMissing(kind, leading, trailing);
	    }

        protected override InternalSyntaxToken MissingToken(GreenNode? leading, int kind, GreenNode? trailing)
        {
			return MissingToken(leading, (CompilerSyntaxKind)kind, trailing);
        }

        public override InternalSyntaxToken BadToken(GreenNode? leading, string text, GreenNode? trailing)
	    {
	        return GreenSyntaxToken.WithValue((CompilerSyntaxKind)InternalSyntaxKind.BadToken, leading, text, text, trailing);
	    }

        public override IEnumerable<InternalSyntaxToken> GetWellKnownTokens()
	    {
	        return GreenSyntaxToken.GetWellKnownTokens();
	    }

		public InternalSyntaxToken TInteger(string text)
		{
			return Token(null, CompilerSyntaxKind.TInteger, text, null);
		}

		public InternalSyntaxToken TInteger(string text, object value)
		{
			return Token(null, CompilerSyntaxKind.TInteger, text, value, null);
		}

		public InternalSyntaxToken TDecimal(string text)
		{
			return Token(null, CompilerSyntaxKind.TDecimal, text, null);
		}

		public InternalSyntaxToken TDecimal(string text, object value)
		{
			return Token(null, CompilerSyntaxKind.TDecimal, text, value, null);
		}

		public InternalSyntaxToken TPrimitiveType(string text)
		{
			return Token(null, CompilerSyntaxKind.TPrimitiveType, text, null);
		}

		public InternalSyntaxToken TPrimitiveType(string text, object value)
		{
			return Token(null, CompilerSyntaxKind.TPrimitiveType, text, value, null);
		}

		public InternalSyntaxToken TIdentifier(string text)
		{
			return Token(null, CompilerSyntaxKind.TIdentifier, text, null);
		}

		public InternalSyntaxToken TIdentifier(string text, object value)
		{
			return Token(null, CompilerSyntaxKind.TIdentifier, text, value, null);
		}

		public InternalSyntaxToken TVerbatimIdentifier(string text)
		{
			return Token(null, CompilerSyntaxKind.TVerbatimIdentifier, text, null);
		}

		public InternalSyntaxToken TVerbatimIdentifier(string text, object value)
		{
			return Token(null, CompilerSyntaxKind.TVerbatimIdentifier, text, value, null);
		}

		public InternalSyntaxToken TString(string text)
		{
			return Token(null, CompilerSyntaxKind.TString, text, null);
		}

		public InternalSyntaxToken TString(string text, object value)
		{
			return Token(null, CompilerSyntaxKind.TString, text, value, null);
		}

		public InternalSyntaxToken DoubleQuoteTextCharacter(string text)
		{
			return Token(null, CompilerSyntaxKind.DoubleQuoteTextCharacter, text, null);
		}

		public InternalSyntaxToken DoubleQuoteTextCharacter(string text, object value)
		{
			return Token(null, CompilerSyntaxKind.DoubleQuoteTextCharacter, text, value, null);
		}

		public InternalSyntaxToken DoubleQuoteTextSimple(string text)
		{
			return Token(null, CompilerSyntaxKind.DoubleQuoteTextSimple, text, null);
		}

		public InternalSyntaxToken DoubleQuoteTextSimple(string text, object value)
		{
			return Token(null, CompilerSyntaxKind.DoubleQuoteTextSimple, text, value, null);
		}

		public InternalSyntaxToken SingleQuoteTextCharacter(string text)
		{
			return Token(null, CompilerSyntaxKind.SingleQuoteTextCharacter, text, null);
		}

		public InternalSyntaxToken SingleQuoteTextCharacter(string text, object value)
		{
			return Token(null, CompilerSyntaxKind.SingleQuoteTextCharacter, text, value, null);
		}

		public InternalSyntaxToken SingleQuoteTextSimple(string text)
		{
			return Token(null, CompilerSyntaxKind.SingleQuoteTextSimple, text, null);
		}

		public InternalSyntaxToken SingleQuoteTextSimple(string text, object value)
		{
			return Token(null, CompilerSyntaxKind.SingleQuoteTextSimple, text, value, null);
		}

		public InternalSyntaxToken CharacterEscapeSimple(string text)
		{
			return Token(null, CompilerSyntaxKind.CharacterEscapeSimple, text, null);
		}

		public InternalSyntaxToken CharacterEscapeSimple(string text, object value)
		{
			return Token(null, CompilerSyntaxKind.CharacterEscapeSimple, text, value, null);
		}

		public InternalSyntaxToken CharacterEscapeSimpleCharacter(string text)
		{
			return Token(null, CompilerSyntaxKind.CharacterEscapeSimpleCharacter, text, null);
		}

		public InternalSyntaxToken CharacterEscapeSimpleCharacter(string text, object value)
		{
			return Token(null, CompilerSyntaxKind.CharacterEscapeSimpleCharacter, text, value, null);
		}

		public InternalSyntaxToken CharacterEscapeUnicode(string text)
		{
			return Token(null, CompilerSyntaxKind.CharacterEscapeUnicode, text, null);
		}

		public InternalSyntaxToken CharacterEscapeUnicode(string text, object value)
		{
			return Token(null, CompilerSyntaxKind.CharacterEscapeUnicode, text, value, null);
		}

		public InternalSyntaxToken HexDigit(string text)
		{
			return Token(null, CompilerSyntaxKind.HexDigit, text, null);
		}

		public InternalSyntaxToken HexDigit(string text, object value)
		{
			return Token(null, CompilerSyntaxKind.HexDigit, text, value, null);
		}

		public InternalSyntaxToken TWhitespace(string text)
		{
			return Token(null, CompilerSyntaxKind.TWhitespace, text, null);
		}

		public InternalSyntaxToken TWhitespace(string text, object value)
		{
			return Token(null, CompilerSyntaxKind.TWhitespace, text, value, null);
		}

		public InternalSyntaxToken TLineEnd(string text)
		{
			return Token(null, CompilerSyntaxKind.TLineEnd, text, null);
		}

		public InternalSyntaxToken TLineEnd(string text, object value)
		{
			return Token(null, CompilerSyntaxKind.TLineEnd, text, value, null);
		}

		public InternalSyntaxToken TSingleLineComment(string text)
		{
			return Token(null, CompilerSyntaxKind.TSingleLineComment, text, null);
		}

		public InternalSyntaxToken TSingleLineComment(string text, object value)
		{
			return Token(null, CompilerSyntaxKind.TSingleLineComment, text, value, null);
		}

		public InternalSyntaxToken TMultiLineComment(string text)
		{
			return Token(null, CompilerSyntaxKind.TMultiLineComment, text, null);
		}

		public InternalSyntaxToken TMultiLineComment(string text, object value)
		{
			return Token(null, CompilerSyntaxKind.TMultiLineComment, text, value, null);
		}

		public InternalSyntaxToken TInvalidToken(string text)
		{
			return Token(null, CompilerSyntaxKind.TInvalidToken, text, null);
		}

		public InternalSyntaxToken TInvalidToken(string text, object value)
		{
			return Token(null, CompilerSyntaxKind.TInvalidToken, text, value, null);
		}

		internal MainGreen Main(InternalSyntaxToken kNamespace, QualifierGreen name, InternalSyntaxToken tSemicolon, MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<UsingGreen> @using, DeclarationsGreen declarations, InternalSyntaxToken eof)
		{
#if DEBUG
			if (kNamespace is null) throw new ArgumentNullException(nameof(kNamespace));
			if (kNamespace.RawKind != (int)CompilerSyntaxKind.KNamespace) throw new ArgumentException(nameof(kNamespace));
			if (name is null) throw new ArgumentNullException(nameof(name));
			if (tSemicolon is null) throw new ArgumentNullException(nameof(tSemicolon));
			if (tSemicolon.RawKind != (int)CompilerSyntaxKind.TSemicolon) throw new ArgumentException(nameof(tSemicolon));
			if (declarations is null) throw new ArgumentNullException(nameof(declarations));
			if (eof is null) throw new ArgumentNullException(nameof(eof));
			if (eof.RawKind != (int)CompilerSyntaxKind.Eof) throw new ArgumentException(nameof(eof));
#endif
			return new MainGreen(CompilerSyntaxKind.Main, kNamespace, name, tSemicolon, @using.Node, declarations, eof);
		}

		internal UsingGreen Using(InternalSyntaxToken kUsing, QualifierGreen namespaces, InternalSyntaxToken tSemicolon)
		{
#if DEBUG
			if (kUsing is null) throw new ArgumentNullException(nameof(kUsing));
			if (kUsing.RawKind != (int)CompilerSyntaxKind.KUsing) throw new ArgumentException(nameof(kUsing));
			if (namespaces is null) throw new ArgumentNullException(nameof(namespaces));
			if (tSemicolon is null) throw new ArgumentNullException(nameof(tSemicolon));
			if (tSemicolon.RawKind != (int)CompilerSyntaxKind.TSemicolon) throw new ArgumentException(nameof(tSemicolon));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.Using, kUsing, namespaces, tSemicolon, out hash);
			if (cached != null) return (UsingGreen)cached;
		
			var result = new UsingGreen(CompilerSyntaxKind.Using, kUsing, namespaces, tSemicolon);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal DeclarationsGreen Declarations(LanguageDeclarationGreen declarations, MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<RuleGreen> declarations1)
		{
#if DEBUG
			if (declarations is null) throw new ArgumentNullException(nameof(declarations));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.Declarations, declarations, declarations1.Node, out hash);
			if (cached != null) return (DeclarationsGreen)cached;
		
			var result = new DeclarationsGreen(CompilerSyntaxKind.Declarations, declarations, declarations1.Node);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal LanguageDeclarationGreen LanguageDeclaration(InternalSyntaxToken kLanguage, NameGreen name, InternalSyntaxToken tSemicolon, GrammarGreen grammar)
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

		internal GrammarGreen Grammar(GrammarBlock1Green grammarBlock1)
		{
#if DEBUG
			if (grammarBlock1 is null) throw new ArgumentNullException(nameof(grammarBlock1));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.Grammar, grammarBlock1, out hash);
			if (cached != null) return (GrammarGreen)cached;
		
			var result = new GrammarGreen(CompilerSyntaxKind.Grammar, grammarBlock1);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal GrammarRuleAlt1Green GrammarRuleAlt1(RuleGreen rule)
		{
#if DEBUG
			if (rule is null) throw new ArgumentNullException(nameof(rule));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.GrammarRuleAlt1, rule, out hash);
			if (cached != null) return (GrammarRuleAlt1Green)cached;
		
			var result = new GrammarRuleAlt1Green(CompilerSyntaxKind.GrammarRuleAlt1, rule);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal BlockGreen Block(MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<ParserAnnotationGreen> annotations1, InternalSyntaxToken kBlock, NameGreen name, BlockBlock1Green blockBlock1, InternalSyntaxToken tColon, MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<AlternativeGreen> alternativeList, InternalSyntaxToken tSemicolon)
		{
#if DEBUG
			if (kBlock is null) throw new ArgumentNullException(nameof(kBlock));
			if (kBlock.RawKind != (int)CompilerSyntaxKind.KBlock) throw new ArgumentException(nameof(kBlock));
			if (name is null) throw new ArgumentNullException(nameof(name));
			if (tColon is null) throw new ArgumentNullException(nameof(tColon));
			if (tColon.RawKind != (int)CompilerSyntaxKind.TColon) throw new ArgumentException(nameof(tColon));
			if (alternativeList.IsReversed) throw new ArgumentException(nameof(alternativeList));
			if (tSemicolon is null) throw new ArgumentNullException(nameof(tSemicolon));
			if (tSemicolon.RawKind != (int)CompilerSyntaxKind.TSemicolon) throw new ArgumentException(nameof(tSemicolon));
#endif
			return new BlockGreen(CompilerSyntaxKind.Block, annotations1.Node, kBlock, name, blockBlock1, tColon, alternativeList.Node, tSemicolon);
		}

		internal TokenGreen Token(MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<LexerAnnotationGreen> annotations1, TokenBlock1Green tokenBlock1, InternalSyntaxToken tColon, MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<LAlternativeGreen> lAlternativeList, InternalSyntaxToken tSemicolon)
		{
#if DEBUG
			if (tokenBlock1 is null) throw new ArgumentNullException(nameof(tokenBlock1));
			if (tColon is null) throw new ArgumentNullException(nameof(tColon));
			if (tColon.RawKind != (int)CompilerSyntaxKind.TColon) throw new ArgumentException(nameof(tColon));
			if (lAlternativeList.IsReversed) throw new ArgumentException(nameof(lAlternativeList));
			if (tSemicolon is null) throw new ArgumentNullException(nameof(tSemicolon));
			if (tSemicolon.RawKind != (int)CompilerSyntaxKind.TSemicolon) throw new ArgumentException(nameof(tSemicolon));
#endif
			return new TokenGreen(CompilerSyntaxKind.Token, annotations1.Node, tokenBlock1, tColon, lAlternativeList.Node, tSemicolon);
		}

		internal FragmentGreen Fragment(InternalSyntaxToken kFragment, NameGreen name, InternalSyntaxToken tColon, MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<LAlternativeGreen> lAlternativeList, InternalSyntaxToken tSemicolon)
		{
#if DEBUG
			if (kFragment is null) throw new ArgumentNullException(nameof(kFragment));
			if (kFragment.RawKind != (int)CompilerSyntaxKind.KFragment) throw new ArgumentException(nameof(kFragment));
			if (name is null) throw new ArgumentNullException(nameof(name));
			if (tColon is null) throw new ArgumentNullException(nameof(tColon));
			if (tColon.RawKind != (int)CompilerSyntaxKind.TColon) throw new ArgumentException(nameof(tColon));
			if (lAlternativeList.IsReversed) throw new ArgumentException(nameof(lAlternativeList));
			if (tSemicolon is null) throw new ArgumentNullException(nameof(tSemicolon));
			if (tSemicolon.RawKind != (int)CompilerSyntaxKind.TSemicolon) throw new ArgumentException(nameof(tSemicolon));
#endif
			return new FragmentGreen(CompilerSyntaxKind.Fragment, kFragment, name, tColon, lAlternativeList.Node, tSemicolon);
		}

		internal RuleGreen Rule(MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<ParserAnnotationGreen> annotations1, RuleBlock1Green ruleBlock1, InternalSyntaxToken tColon, MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<AlternativeGreen> alternativeList, InternalSyntaxToken tSemicolon)
		{
#if DEBUG
			if (ruleBlock1 is null) throw new ArgumentNullException(nameof(ruleBlock1));
			if (tColon is null) throw new ArgumentNullException(nameof(tColon));
			if (tColon.RawKind != (int)CompilerSyntaxKind.TColon) throw new ArgumentException(nameof(tColon));
			if (alternativeList.IsReversed) throw new ArgumentException(nameof(alternativeList));
			if (tSemicolon is null) throw new ArgumentNullException(nameof(tSemicolon));
			if (tSemicolon.RawKind != (int)CompilerSyntaxKind.TSemicolon) throw new ArgumentException(nameof(tSemicolon));
#endif
			return new RuleGreen(CompilerSyntaxKind.Rule, annotations1.Node, ruleBlock1, tColon, alternativeList.Node, tSemicolon);
		}

		internal AlternativeGreen Alternative(AlternativeBlock1Green alternativeBlock1, MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<ElementGreen> elements, AlternativeBlock2Green alternativeBlock2)
		{
#if DEBUG
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.Alternative, alternativeBlock1, elements.Node, alternativeBlock2, out hash);
			if (cached != null) return (AlternativeGreen)cached;
		
			var result = new AlternativeGreen(CompilerSyntaxKind.Alternative, alternativeBlock1, elements.Node, alternativeBlock2);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal ElementGreen Element(ElementBlock1Green elementBlock1, MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<ParserAnnotationGreen> valueAnnotations, ElementValueGreen value, InternalSyntaxToken multiplicity)
		{
#if DEBUG
			if (value is null) throw new ArgumentNullException(nameof(value));
			if (multiplicity is not null && multiplicity.RawKind != (int)CompilerSyntaxKind.TQuestion && multiplicity.RawKind != (int)CompilerSyntaxKind.TAsterisk && multiplicity.RawKind != (int)CompilerSyntaxKind.TPlus && multiplicity.RawKind != (int)CompilerSyntaxKind.TQuestionQuestion && multiplicity.RawKind != (int)CompilerSyntaxKind.TAsteriskQuestion && multiplicity.RawKind != (int)CompilerSyntaxKind.TPlusQuestion) throw new ArgumentException(nameof(multiplicity));
#endif
			return new ElementGreen(CompilerSyntaxKind.Element, elementBlock1, valueAnnotations.Node, value, multiplicity);
		}

		internal BlockInlineGreen BlockInline(InternalSyntaxToken tLParen, MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<AlternativeGreen> alternativeList, InternalSyntaxToken tRParen)
		{
#if DEBUG
			if (tLParen is null) throw new ArgumentNullException(nameof(tLParen));
			if (tLParen.RawKind != (int)CompilerSyntaxKind.TLParen) throw new ArgumentException(nameof(tLParen));
			if (alternativeList.IsReversed) throw new ArgumentException(nameof(alternativeList));
			if (tRParen is null) throw new ArgumentNullException(nameof(tRParen));
			if (tRParen.RawKind != (int)CompilerSyntaxKind.TRParen) throw new ArgumentException(nameof(tRParen));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.BlockInline, tLParen, alternativeList.Node, tRParen, out hash);
			if (cached != null) return (BlockInlineGreen)cached;
		
			var result = new BlockInlineGreen(CompilerSyntaxKind.BlockInline, tLParen, alternativeList.Node, tRParen);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal Eof1Green Eof1(InternalSyntaxToken kEof)
		{
#if DEBUG
			if (kEof is null) throw new ArgumentNullException(nameof(kEof));
			if (kEof.RawKind != (int)CompilerSyntaxKind.KEof) throw new ArgumentException(nameof(kEof));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.Eof1, kEof, out hash);
			if (cached != null) return (Eof1Green)cached;
		
			var result = new Eof1Green(CompilerSyntaxKind.Eof1, kEof);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal KeywordGreen Keyword(InternalSyntaxToken text)
		{
#if DEBUG
			if (text is null) throw new ArgumentNullException(nameof(text));
			if (text.RawKind != (int)CompilerSyntaxKind.TString) throw new ArgumentException(nameof(text));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.Keyword, text, out hash);
			if (cached != null) return (KeywordGreen)cached;
		
			var result = new KeywordGreen(CompilerSyntaxKind.Keyword, text);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal RuleRefAlt1Green RuleRefAlt1(IdentifierGreen grammarRule)
		{
#if DEBUG
			if (grammarRule is null) throw new ArgumentNullException(nameof(grammarRule));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.RuleRefAlt1, grammarRule, out hash);
			if (cached != null) return (RuleRefAlt1Green)cached;
		
			var result = new RuleRefAlt1Green(CompilerSyntaxKind.RuleRefAlt1, grammarRule);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal RuleRefAlt2Green RuleRefAlt2(InternalSyntaxToken tHash, ReturnTypeQualifierGreen referencedTypes)
		{
#if DEBUG
			if (tHash is null) throw new ArgumentNullException(nameof(tHash));
			if (tHash.RawKind != (int)CompilerSyntaxKind.THash) throw new ArgumentException(nameof(tHash));
			if (referencedTypes is null) throw new ArgumentNullException(nameof(referencedTypes));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.RuleRefAlt2, tHash, referencedTypes, out hash);
			if (cached != null) return (RuleRefAlt2Green)cached;
		
			var result = new RuleRefAlt2Green(CompilerSyntaxKind.RuleRefAlt2, tHash, referencedTypes);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal RuleRefAlt3Green RuleRefAlt3(InternalSyntaxToken tHashLBrace, MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<ReturnTypeQualifierGreen> returnTypeQualifierList, InternalSyntaxToken tRBrace)
		{
#if DEBUG
			if (tHashLBrace is null) throw new ArgumentNullException(nameof(tHashLBrace));
			if (tHashLBrace.RawKind != (int)CompilerSyntaxKind.THashLBrace) throw new ArgumentException(nameof(tHashLBrace));
			if (returnTypeQualifierList.IsReversed) throw new ArgumentException(nameof(returnTypeQualifierList));
			if (tRBrace is null) throw new ArgumentNullException(nameof(tRBrace));
			if (tRBrace.RawKind != (int)CompilerSyntaxKind.TRBrace) throw new ArgumentException(nameof(tRBrace));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.RuleRefAlt3, tHashLBrace, returnTypeQualifierList.Node, tRBrace, out hash);
			if (cached != null) return (RuleRefAlt3Green)cached;
		
			var result = new RuleRefAlt3Green(CompilerSyntaxKind.RuleRefAlt3, tHashLBrace, returnTypeQualifierList.Node, tRBrace);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal LAlternativeGreen LAlternative(MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<LElementGreen> elements)
		{
#if DEBUG
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.LAlternative, elements.Node, out hash);
			if (cached != null) return (LAlternativeGreen)cached;
		
			var result = new LAlternativeGreen(CompilerSyntaxKind.LAlternative, elements.Node);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal LElementGreen LElement(InternalSyntaxToken isNegated, LElementValueGreen value, InternalSyntaxToken multiplicity)
		{
#if DEBUG
			if (isNegated is not null && isNegated.RawKind != (int)CompilerSyntaxKind.TTilde) throw new ArgumentException(nameof(isNegated));
			if (value is null) throw new ArgumentNullException(nameof(value));
			if (multiplicity is not null && multiplicity.RawKind != (int)CompilerSyntaxKind.TQuestion && multiplicity.RawKind != (int)CompilerSyntaxKind.TAsterisk && multiplicity.RawKind != (int)CompilerSyntaxKind.TPlus && multiplicity.RawKind != (int)CompilerSyntaxKind.TQuestionQuestion && multiplicity.RawKind != (int)CompilerSyntaxKind.TAsteriskQuestion && multiplicity.RawKind != (int)CompilerSyntaxKind.TPlusQuestion) throw new ArgumentException(nameof(multiplicity));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.LElement, isNegated, value, multiplicity, out hash);
			if (cached != null) return (LElementGreen)cached;
		
			var result = new LElementGreen(CompilerSyntaxKind.LElement, isNegated, value, multiplicity);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal LBlockGreen LBlock(InternalSyntaxToken tLParen, MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<LAlternativeGreen> lAlternativeList, InternalSyntaxToken tRParen)
		{
#if DEBUG
			if (tLParen is null) throw new ArgumentNullException(nameof(tLParen));
			if (tLParen.RawKind != (int)CompilerSyntaxKind.TLParen) throw new ArgumentException(nameof(tLParen));
			if (lAlternativeList.IsReversed) throw new ArgumentException(nameof(lAlternativeList));
			if (tRParen is null) throw new ArgumentNullException(nameof(tRParen));
			if (tRParen.RawKind != (int)CompilerSyntaxKind.TRParen) throw new ArgumentException(nameof(tRParen));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.LBlock, tLParen, lAlternativeList.Node, tRParen, out hash);
			if (cached != null) return (LBlockGreen)cached;
		
			var result = new LBlockGreen(CompilerSyntaxKind.LBlock, tLParen, lAlternativeList.Node, tRParen);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal LFixedGreen LFixed(InternalSyntaxToken text)
		{
#if DEBUG
			if (text is null) throw new ArgumentNullException(nameof(text));
			if (text.RawKind != (int)CompilerSyntaxKind.TString) throw new ArgumentException(nameof(text));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.LFixed, text, out hash);
			if (cached != null) return (LFixedGreen)cached;
		
			var result = new LFixedGreen(CompilerSyntaxKind.LFixed, text);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal LWildCardGreen LWildCard(InternalSyntaxToken tDot)
		{
#if DEBUG
			if (tDot is null) throw new ArgumentNullException(nameof(tDot));
			if (tDot.RawKind != (int)CompilerSyntaxKind.TDot) throw new ArgumentException(nameof(tDot));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.LWildCard, tDot, out hash);
			if (cached != null) return (LWildCardGreen)cached;
		
			var result = new LWildCardGreen(CompilerSyntaxKind.LWildCard, tDot);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal LRangeGreen LRange(InternalSyntaxToken startChar, InternalSyntaxToken tDotDot, InternalSyntaxToken endChar)
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
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.LRange, startChar, tDotDot, endChar, out hash);
			if (cached != null) return (LRangeGreen)cached;
		
			var result = new LRangeGreen(CompilerSyntaxKind.LRange, startChar, tDotDot, endChar);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal LReferenceGreen LReference(IdentifierGreen rule)
		{
#if DEBUG
			if (rule is null) throw new ArgumentNullException(nameof(rule));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.LReference, rule, out hash);
			if (cached != null) return (LReferenceGreen)cached;
		
			var result = new LReferenceGreen(CompilerSyntaxKind.LReference, rule);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal ExpressionAlt1Green ExpressionAlt1(SingleExpressionGreen singleExpression)
		{
#if DEBUG
			if (singleExpression is null) throw new ArgumentNullException(nameof(singleExpression));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.ExpressionAlt1, singleExpression, out hash);
			if (cached != null) return (ExpressionAlt1Green)cached;
		
			var result = new ExpressionAlt1Green(CompilerSyntaxKind.ExpressionAlt1, singleExpression);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal ArrayExpressionGreen ArrayExpression(InternalSyntaxToken tLBrace, ArrayExpressionBlock1Green arrayExpressionBlock1, InternalSyntaxToken tRBrace)
		{
#if DEBUG
			if (tLBrace is null) throw new ArgumentNullException(nameof(tLBrace));
			if (tLBrace.RawKind != (int)CompilerSyntaxKind.TLBrace) throw new ArgumentException(nameof(tLBrace));
			if (tRBrace is null) throw new ArgumentNullException(nameof(tRBrace));
			if (tRBrace.RawKind != (int)CompilerSyntaxKind.TRBrace) throw new ArgumentException(nameof(tRBrace));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.ArrayExpression, tLBrace, arrayExpressionBlock1, tRBrace, out hash);
			if (cached != null) return (ArrayExpressionGreen)cached;
		
			var result = new ArrayExpressionGreen(CompilerSyntaxKind.ArrayExpression, tLBrace, arrayExpressionBlock1, tRBrace);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal SingleExpressionGreen SingleExpression(SingleExpressionBlock1Green value)
		{
#if DEBUG
			if (value is null) throw new ArgumentNullException(nameof(value));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.SingleExpression, value, out hash);
			if (cached != null) return (SingleExpressionGreen)cached;
		
			var result = new SingleExpressionGreen(CompilerSyntaxKind.SingleExpression, value);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal ParserAnnotationGreen ParserAnnotation(InternalSyntaxToken tLBracket, QualifierGreen attributeClass, AnnotationArgumentsGreen annotationArguments, InternalSyntaxToken tRBracket)
		{
#if DEBUG
			if (tLBracket is null) throw new ArgumentNullException(nameof(tLBracket));
			if (tLBracket.RawKind != (int)CompilerSyntaxKind.TLBracket) throw new ArgumentException(nameof(tLBracket));
			if (attributeClass is null) throw new ArgumentNullException(nameof(attributeClass));
			if (tRBracket is null) throw new ArgumentNullException(nameof(tRBracket));
			if (tRBracket.RawKind != (int)CompilerSyntaxKind.TRBracket) throw new ArgumentException(nameof(tRBracket));
#endif
			return new ParserAnnotationGreen(CompilerSyntaxKind.ParserAnnotation, tLBracket, attributeClass, annotationArguments, tRBracket);
		}

		internal LexerAnnotationGreen LexerAnnotation(InternalSyntaxToken tLBracket, QualifierGreen attributeClass, AnnotationArgumentsGreen annotationArguments, InternalSyntaxToken tRBracket)
		{
#if DEBUG
			if (tLBracket is null) throw new ArgumentNullException(nameof(tLBracket));
			if (tLBracket.RawKind != (int)CompilerSyntaxKind.TLBracket) throw new ArgumentException(nameof(tLBracket));
			if (attributeClass is null) throw new ArgumentNullException(nameof(attributeClass));
			if (tRBracket is null) throw new ArgumentNullException(nameof(tRBracket));
			if (tRBracket.RawKind != (int)CompilerSyntaxKind.TRBracket) throw new ArgumentException(nameof(tRBracket));
#endif
			return new LexerAnnotationGreen(CompilerSyntaxKind.LexerAnnotation, tLBracket, attributeClass, annotationArguments, tRBracket);
		}

		internal AnnotationArgumentsGreen AnnotationArguments(InternalSyntaxToken tLParen, MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<AnnotationArgumentGreen> annotationArgumentList, InternalSyntaxToken tRParen)
		{
#if DEBUG
			if (tLParen is null) throw new ArgumentNullException(nameof(tLParen));
			if (tLParen.RawKind != (int)CompilerSyntaxKind.TLParen) throw new ArgumentException(nameof(tLParen));
			if (annotationArgumentList.IsReversed) throw new ArgumentException(nameof(annotationArgumentList));
			if (tRParen is null) throw new ArgumentNullException(nameof(tRParen));
			if (tRParen.RawKind != (int)CompilerSyntaxKind.TRParen) throw new ArgumentException(nameof(tRParen));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.AnnotationArguments, tLParen, annotationArgumentList.Node, tRParen, out hash);
			if (cached != null) return (AnnotationArgumentsGreen)cached;
		
			var result = new AnnotationArgumentsGreen(CompilerSyntaxKind.AnnotationArguments, tLParen, annotationArgumentList.Node, tRParen);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal AnnotationArgumentGreen AnnotationArgument(AnnotationArgumentBlock1Green annotationArgumentBlock1, ExpressionGreen value)
		{
#if DEBUG
			if (value is null) throw new ArgumentNullException(nameof(value));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.AnnotationArgument, annotationArgumentBlock1, value, out hash);
			if (cached != null) return (AnnotationArgumentGreen)cached;
		
			var result = new AnnotationArgumentGreen(CompilerSyntaxKind.AnnotationArgument, annotationArgumentBlock1, value);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal ReturnTypeIdentifierAlt1Green ReturnTypeIdentifierAlt1(InternalSyntaxToken tPrimitiveType)
		{
#if DEBUG
			if (tPrimitiveType is null) throw new ArgumentNullException(nameof(tPrimitiveType));
			if (tPrimitiveType.RawKind != (int)CompilerSyntaxKind.TPrimitiveType) throw new ArgumentException(nameof(tPrimitiveType));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.ReturnTypeIdentifierAlt1, tPrimitiveType, out hash);
			if (cached != null) return (ReturnTypeIdentifierAlt1Green)cached;
		
			var result = new ReturnTypeIdentifierAlt1Green(CompilerSyntaxKind.ReturnTypeIdentifierAlt1, tPrimitiveType);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal ReturnTypeIdentifierAlt2Green ReturnTypeIdentifierAlt2(IdentifierGreen identifier)
		{
#if DEBUG
			if (identifier is null) throw new ArgumentNullException(nameof(identifier));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.ReturnTypeIdentifierAlt2, identifier, out hash);
			if (cached != null) return (ReturnTypeIdentifierAlt2Green)cached;
		
			var result = new ReturnTypeIdentifierAlt2Green(CompilerSyntaxKind.ReturnTypeIdentifierAlt2, identifier);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal ReturnTypeQualifierAlt1Green ReturnTypeQualifierAlt1(InternalSyntaxToken tPrimitiveType)
		{
#if DEBUG
			if (tPrimitiveType is null) throw new ArgumentNullException(nameof(tPrimitiveType));
			if (tPrimitiveType.RawKind != (int)CompilerSyntaxKind.TPrimitiveType) throw new ArgumentException(nameof(tPrimitiveType));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.ReturnTypeQualifierAlt1, tPrimitiveType, out hash);
			if (cached != null) return (ReturnTypeQualifierAlt1Green)cached;
		
			var result = new ReturnTypeQualifierAlt1Green(CompilerSyntaxKind.ReturnTypeQualifierAlt1, tPrimitiveType);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal ReturnTypeQualifierAlt2Green ReturnTypeQualifierAlt2(QualifierGreen qualifier)
		{
#if DEBUG
			if (qualifier is null) throw new ArgumentNullException(nameof(qualifier));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.ReturnTypeQualifierAlt2, qualifier, out hash);
			if (cached != null) return (ReturnTypeQualifierAlt2Green)cached;
		
			var result = new ReturnTypeQualifierAlt2Green(CompilerSyntaxKind.ReturnTypeQualifierAlt2, qualifier);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal NameGreen Name(IdentifierGreen identifier)
		{
#if DEBUG
			if (identifier is null) throw new ArgumentNullException(nameof(identifier));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.Name, identifier, out hash);
			if (cached != null) return (NameGreen)cached;
		
			var result = new NameGreen(CompilerSyntaxKind.Name, identifier);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal QualifierGreen Qualifier(MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<IdentifierGreen> identifierList)
		{
#if DEBUG
			if (identifierList.IsReversed) throw new ArgumentException(nameof(identifierList));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.Qualifier, identifierList.Node, out hash);
			if (cached != null) return (QualifierGreen)cached;
		
			var result = new QualifierGreen(CompilerSyntaxKind.Qualifier, identifierList.Node);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal QualifierListGreen QualifierList(MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<QualifierGreen> qualifierList)
		{
#if DEBUG
			if (qualifierList.IsReversed) throw new ArgumentException(nameof(qualifierList));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.QualifierList, qualifierList.Node, out hash);
			if (cached != null) return (QualifierListGreen)cached;
		
			var result = new QualifierListGreen(CompilerSyntaxKind.QualifierList, qualifierList.Node);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal IdentifierAlt1Green IdentifierAlt1(InternalSyntaxToken tIdentifier)
		{
#if DEBUG
			if (tIdentifier is null) throw new ArgumentNullException(nameof(tIdentifier));
			if (tIdentifier.RawKind != (int)CompilerSyntaxKind.TIdentifier) throw new ArgumentException(nameof(tIdentifier));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.IdentifierAlt1, tIdentifier, out hash);
			if (cached != null) return (IdentifierAlt1Green)cached;
		
			var result = new IdentifierAlt1Green(CompilerSyntaxKind.IdentifierAlt1, tIdentifier);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal IdentifierAlt2Green IdentifierAlt2(InternalSyntaxToken tVerbatimIdentifier)
		{
#if DEBUG
			if (tVerbatimIdentifier is null) throw new ArgumentNullException(nameof(tVerbatimIdentifier));
			if (tVerbatimIdentifier.RawKind != (int)CompilerSyntaxKind.TVerbatimIdentifier) throw new ArgumentException(nameof(tVerbatimIdentifier));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.IdentifierAlt2, tVerbatimIdentifier, out hash);
			if (cached != null) return (IdentifierAlt2Green)cached;
		
			var result = new IdentifierAlt2Green(CompilerSyntaxKind.IdentifierAlt2, tVerbatimIdentifier);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal SimpleQualifierGreen SimpleQualifier(MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<SimpleIdentifierGreen> simpleIdentifierList)
		{
#if DEBUG
			if (simpleIdentifierList.IsReversed) throw new ArgumentException(nameof(simpleIdentifierList));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.SimpleQualifier, simpleIdentifierList.Node, out hash);
			if (cached != null) return (SimpleQualifierGreen)cached;
		
			var result = new SimpleQualifierGreen(CompilerSyntaxKind.SimpleQualifier, simpleIdentifierList.Node);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal SimpleIdentifierGreen SimpleIdentifier(InternalSyntaxToken tIdentifier)
		{
#if DEBUG
			if (tIdentifier is null) throw new ArgumentNullException(nameof(tIdentifier));
			if (tIdentifier.RawKind != (int)CompilerSyntaxKind.TIdentifier) throw new ArgumentException(nameof(tIdentifier));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.SimpleIdentifier, tIdentifier, out hash);
			if (cached != null) return (SimpleIdentifierGreen)cached;
		
			var result = new SimpleIdentifierGreen(CompilerSyntaxKind.SimpleIdentifier, tIdentifier);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal GrammarBlock1Green GrammarBlock1(MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<GrammarRuleGreen> grammarRules)
		{
#if DEBUG
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.GrammarBlock1, grammarRules.Node, out hash);
			if (cached != null) return (GrammarBlock1Green)cached;
		
			var result = new GrammarBlock1Green(CompilerSyntaxKind.GrammarBlock1, grammarRules.Node);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal RuleBlock1Alt1Green RuleBlock1Alt1(ReturnTypeIdentifierGreen returnType)
		{
#if DEBUG
			if (returnType is null) throw new ArgumentNullException(nameof(returnType));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.RuleBlock1Alt1, returnType, out hash);
			if (cached != null) return (RuleBlock1Alt1Green)cached;
		
			var result = new RuleBlock1Alt1Green(CompilerSyntaxKind.RuleBlock1Alt1, returnType);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal RuleBlock1Alt2Green RuleBlock1Alt2(IdentifierGreen identifier, InternalSyntaxToken kReturns, ReturnTypeQualifierGreen returnType)
		{
#if DEBUG
			if (identifier is null) throw new ArgumentNullException(nameof(identifier));
			if (kReturns is null) throw new ArgumentNullException(nameof(kReturns));
			if (kReturns.RawKind != (int)CompilerSyntaxKind.KReturns) throw new ArgumentException(nameof(kReturns));
			if (returnType is null) throw new ArgumentNullException(nameof(returnType));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.RuleBlock1Alt2, identifier, kReturns, returnType, out hash);
			if (cached != null) return (RuleBlock1Alt2Green)cached;
		
			var result = new RuleBlock1Alt2Green(CompilerSyntaxKind.RuleBlock1Alt2, identifier, kReturns, returnType);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal RuleBlock2Green RuleBlock2(InternalSyntaxToken tBar, AlternativeGreen alternatives)
		{
#if DEBUG
			if (tBar is null) throw new ArgumentNullException(nameof(tBar));
			if (tBar.RawKind != (int)CompilerSyntaxKind.TBar) throw new ArgumentException(nameof(tBar));
			if (alternatives is null) throw new ArgumentNullException(nameof(alternatives));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.RuleBlock2, tBar, alternatives, out hash);
			if (cached != null) return (RuleBlock2Green)cached;
		
			var result = new RuleBlock2Green(CompilerSyntaxKind.RuleBlock2, tBar, alternatives);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal BlockBlock1Green BlockBlock1(InternalSyntaxToken kReturns, ReturnTypeQualifierGreen returnType)
		{
#if DEBUG
			if (kReturns is null) throw new ArgumentNullException(nameof(kReturns));
			if (kReturns.RawKind != (int)CompilerSyntaxKind.KReturns) throw new ArgumentException(nameof(kReturns));
			if (returnType is null) throw new ArgumentNullException(nameof(returnType));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.BlockBlock1, kReturns, returnType, out hash);
			if (cached != null) return (BlockBlock1Green)cached;
		
			var result = new BlockBlock1Green(CompilerSyntaxKind.BlockBlock1, kReturns, returnType);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal BlockBlock2Green BlockBlock2(InternalSyntaxToken tBar, AlternativeGreen alternatives)
		{
#if DEBUG
			if (tBar is null) throw new ArgumentNullException(nameof(tBar));
			if (tBar.RawKind != (int)CompilerSyntaxKind.TBar) throw new ArgumentException(nameof(tBar));
			if (alternatives is null) throw new ArgumentNullException(nameof(alternatives));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.BlockBlock2, tBar, alternatives, out hash);
			if (cached != null) return (BlockBlock2Green)cached;
		
			var result = new BlockBlock2Green(CompilerSyntaxKind.BlockBlock2, tBar, alternatives);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal BlockInlineBlock1Green BlockInlineBlock1(InternalSyntaxToken tBar, AlternativeGreen alternatives)
		{
#if DEBUG
			if (tBar is null) throw new ArgumentNullException(nameof(tBar));
			if (tBar.RawKind != (int)CompilerSyntaxKind.TBar) throw new ArgumentException(nameof(tBar));
			if (alternatives is null) throw new ArgumentNullException(nameof(alternatives));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.BlockInlineBlock1, tBar, alternatives, out hash);
			if (cached != null) return (BlockInlineBlock1Green)cached;
		
			var result = new BlockInlineBlock1Green(CompilerSyntaxKind.BlockInlineBlock1, tBar, alternatives);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal AlternativeBlock1Green AlternativeBlock1(MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<ParserAnnotationGreen> annotations1, InternalSyntaxToken kAlt, NameGreen name, AlternativeBlock1Block1Green alternativeBlock1Block1, InternalSyntaxToken tColon)
		{
#if DEBUG
			if (kAlt is null) throw new ArgumentNullException(nameof(kAlt));
			if (kAlt.RawKind != (int)CompilerSyntaxKind.KAlt) throw new ArgumentException(nameof(kAlt));
			if (name is null) throw new ArgumentNullException(nameof(name));
			if (tColon is null) throw new ArgumentNullException(nameof(tColon));
			if (tColon.RawKind != (int)CompilerSyntaxKind.TColon) throw new ArgumentException(nameof(tColon));
#endif
			return new AlternativeBlock1Green(CompilerSyntaxKind.AlternativeBlock1, annotations1.Node, kAlt, name, alternativeBlock1Block1, tColon);
		}

		internal AlternativeBlock2Green AlternativeBlock2(InternalSyntaxToken tEqGt, ExpressionGreen returnValue)
		{
#if DEBUG
			if (tEqGt is null) throw new ArgumentNullException(nameof(tEqGt));
			if (tEqGt.RawKind != (int)CompilerSyntaxKind.TEqGt) throw new ArgumentException(nameof(tEqGt));
			if (returnValue is null) throw new ArgumentNullException(nameof(returnValue));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.AlternativeBlock2, tEqGt, returnValue, out hash);
			if (cached != null) return (AlternativeBlock2Green)cached;
		
			var result = new AlternativeBlock2Green(CompilerSyntaxKind.AlternativeBlock2, tEqGt, returnValue);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal ElementBlock1Green ElementBlock1(MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<ParserAnnotationGreen> nameAnnotations, IdentifierGreen symbolProperty, InternalSyntaxToken assignment)
		{
#if DEBUG
			if (symbolProperty is null) throw new ArgumentNullException(nameof(symbolProperty));
			if (assignment is null) throw new ArgumentNullException(nameof(assignment));
			if (assignment.RawKind != (int)CompilerSyntaxKind.TEq && assignment.RawKind != (int)CompilerSyntaxKind.TQuestionEq && assignment.RawKind != (int)CompilerSyntaxKind.TExclEq && assignment.RawKind != (int)CompilerSyntaxKind.TPlusEq) throw new ArgumentException(nameof(assignment));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.ElementBlock1, nameAnnotations.Node, symbolProperty, assignment, out hash);
			if (cached != null) return (ElementBlock1Green)cached;
		
			var result = new ElementBlock1Green(CompilerSyntaxKind.ElementBlock1, nameAnnotations.Node, symbolProperty, assignment);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal RuleRefAlt3Block1Green RuleRefAlt3Block1(InternalSyntaxToken tComma, ReturnTypeQualifierGreen referencedTypes)
		{
#if DEBUG
			if (tComma is null) throw new ArgumentNullException(nameof(tComma));
			if (tComma.RawKind != (int)CompilerSyntaxKind.TComma) throw new ArgumentException(nameof(tComma));
			if (referencedTypes is null) throw new ArgumentNullException(nameof(referencedTypes));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.RuleRefAlt3Block1, tComma, referencedTypes, out hash);
			if (cached != null) return (RuleRefAlt3Block1Green)cached;
		
			var result = new RuleRefAlt3Block1Green(CompilerSyntaxKind.RuleRefAlt3Block1, tComma, referencedTypes);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal TokenBlock1Alt1Green TokenBlock1Alt1(InternalSyntaxToken kToken, NameGreen name, TokenBlock1Alt1Block1Green tokenBlock1Alt1Block1)
		{
#if DEBUG
			if (kToken is null) throw new ArgumentNullException(nameof(kToken));
			if (kToken.RawKind != (int)CompilerSyntaxKind.KToken) throw new ArgumentException(nameof(kToken));
			if (name is null) throw new ArgumentNullException(nameof(name));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.TokenBlock1Alt1, kToken, name, tokenBlock1Alt1Block1, out hash);
			if (cached != null) return (TokenBlock1Alt1Green)cached;
		
			var result = new TokenBlock1Alt1Green(CompilerSyntaxKind.TokenBlock1Alt1, kToken, name, tokenBlock1Alt1Block1);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal TokenBlock1Alt2Green TokenBlock1Alt2(InternalSyntaxToken isTrivia1, NameGreen name)
		{
#if DEBUG
			if (isTrivia1 is null) throw new ArgumentNullException(nameof(isTrivia1));
			if (isTrivia1.RawKind != (int)CompilerSyntaxKind.KHidden) throw new ArgumentException(nameof(isTrivia1));
			if (name is null) throw new ArgumentNullException(nameof(name));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.TokenBlock1Alt2, isTrivia1, name, out hash);
			if (cached != null) return (TokenBlock1Alt2Green)cached;
		
			var result = new TokenBlock1Alt2Green(CompilerSyntaxKind.TokenBlock1Alt2, isTrivia1, name);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal TokenBlock2Green TokenBlock2(InternalSyntaxToken tBar, LAlternativeGreen alternatives)
		{
#if DEBUG
			if (tBar is null) throw new ArgumentNullException(nameof(tBar));
			if (tBar.RawKind != (int)CompilerSyntaxKind.TBar) throw new ArgumentException(nameof(tBar));
			if (alternatives is null) throw new ArgumentNullException(nameof(alternatives));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.TokenBlock2, tBar, alternatives, out hash);
			if (cached != null) return (TokenBlock2Green)cached;
		
			var result = new TokenBlock2Green(CompilerSyntaxKind.TokenBlock2, tBar, alternatives);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal FragmentBlock1Green FragmentBlock1(InternalSyntaxToken tBar, LAlternativeGreen alternatives)
		{
#if DEBUG
			if (tBar is null) throw new ArgumentNullException(nameof(tBar));
			if (tBar.RawKind != (int)CompilerSyntaxKind.TBar) throw new ArgumentException(nameof(tBar));
			if (alternatives is null) throw new ArgumentNullException(nameof(alternatives));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.FragmentBlock1, tBar, alternatives, out hash);
			if (cached != null) return (FragmentBlock1Green)cached;
		
			var result = new FragmentBlock1Green(CompilerSyntaxKind.FragmentBlock1, tBar, alternatives);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal LBlockBlock1Green LBlockBlock1(InternalSyntaxToken tBar, LAlternativeGreen alternatives)
		{
#if DEBUG
			if (tBar is null) throw new ArgumentNullException(nameof(tBar));
			if (tBar.RawKind != (int)CompilerSyntaxKind.TBar) throw new ArgumentException(nameof(tBar));
			if (alternatives is null) throw new ArgumentNullException(nameof(alternatives));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.LBlockBlock1, tBar, alternatives, out hash);
			if (cached != null) return (LBlockBlock1Green)cached;
		
			var result = new LBlockBlock1Green(CompilerSyntaxKind.LBlockBlock1, tBar, alternatives);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal SingleExpressionBlock1Alt4Green SingleExpressionBlock1Alt4(InternalSyntaxToken tInteger)
		{
#if DEBUG
			if (tInteger is null) throw new ArgumentNullException(nameof(tInteger));
			if (tInteger.RawKind != (int)CompilerSyntaxKind.TInteger) throw new ArgumentException(nameof(tInteger));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.SingleExpressionBlock1Alt4, tInteger, out hash);
			if (cached != null) return (SingleExpressionBlock1Alt4Green)cached;
		
			var result = new SingleExpressionBlock1Alt4Green(CompilerSyntaxKind.SingleExpressionBlock1Alt4, tInteger);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal SingleExpressionBlock1Alt5Green SingleExpressionBlock1Alt5(InternalSyntaxToken tString)
		{
#if DEBUG
			if (tString is null) throw new ArgumentNullException(nameof(tString));
			if (tString.RawKind != (int)CompilerSyntaxKind.TString) throw new ArgumentException(nameof(tString));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.SingleExpressionBlock1Alt5, tString, out hash);
			if (cached != null) return (SingleExpressionBlock1Alt5Green)cached;
		
			var result = new SingleExpressionBlock1Alt5Green(CompilerSyntaxKind.SingleExpressionBlock1Alt5, tString);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal SingleExpressionBlock1Alt6Green SingleExpressionBlock1Alt6(SimpleQualifierGreen simpleQualifier)
		{
#if DEBUG
			if (simpleQualifier is null) throw new ArgumentNullException(nameof(simpleQualifier));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.SingleExpressionBlock1Alt6, simpleQualifier, out hash);
			if (cached != null) return (SingleExpressionBlock1Alt6Green)cached;
		
			var result = new SingleExpressionBlock1Alt6Green(CompilerSyntaxKind.SingleExpressionBlock1Alt6, simpleQualifier);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal SingleExpressionBlock1TokensGreen SingleExpressionBlock1Tokens(InternalSyntaxToken tokens)
		{
#if DEBUG
			if (tokens is null) throw new ArgumentNullException(nameof(tokens));
			if (tokens.RawKind != (int)CompilerSyntaxKind.KNull && tokens.RawKind != (int)CompilerSyntaxKind.KTrue && tokens.RawKind != (int)CompilerSyntaxKind.KFalse) throw new ArgumentException(nameof(tokens));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.SingleExpressionBlock1Tokens, tokens, out hash);
			if (cached != null) return (SingleExpressionBlock1TokensGreen)cached;
		
			var result = new SingleExpressionBlock1TokensGreen(CompilerSyntaxKind.SingleExpressionBlock1Tokens, tokens);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal ArrayExpressionBlock1Green ArrayExpressionBlock1(MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<SingleExpressionGreen> singleExpressionList)
		{
#if DEBUG
			if (singleExpressionList.IsReversed) throw new ArgumentException(nameof(singleExpressionList));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.ArrayExpressionBlock1, singleExpressionList.Node, out hash);
			if (cached != null) return (ArrayExpressionBlock1Green)cached;
		
			var result = new ArrayExpressionBlock1Green(CompilerSyntaxKind.ArrayExpressionBlock1, singleExpressionList.Node);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal AnnotationArgumentsBlock1Green AnnotationArgumentsBlock1(InternalSyntaxToken tComma, AnnotationArgumentGreen arguments)
		{
#if DEBUG
			if (tComma is null) throw new ArgumentNullException(nameof(tComma));
			if (tComma.RawKind != (int)CompilerSyntaxKind.TComma) throw new ArgumentException(nameof(tComma));
			if (arguments is null) throw new ArgumentNullException(nameof(arguments));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.AnnotationArgumentsBlock1, tComma, arguments, out hash);
			if (cached != null) return (AnnotationArgumentsBlock1Green)cached;
		
			var result = new AnnotationArgumentsBlock1Green(CompilerSyntaxKind.AnnotationArgumentsBlock1, tComma, arguments);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal AnnotationArgumentBlock1Green AnnotationArgumentBlock1(IdentifierGreen namedParameter, InternalSyntaxToken tColon)
		{
#if DEBUG
			if (namedParameter is null) throw new ArgumentNullException(nameof(namedParameter));
			if (tColon is null) throw new ArgumentNullException(nameof(tColon));
			if (tColon.RawKind != (int)CompilerSyntaxKind.TColon) throw new ArgumentException(nameof(tColon));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.AnnotationArgumentBlock1, namedParameter, tColon, out hash);
			if (cached != null) return (AnnotationArgumentBlock1Green)cached;
		
			var result = new AnnotationArgumentBlock1Green(CompilerSyntaxKind.AnnotationArgumentBlock1, namedParameter, tColon);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal QualifierBlock1Green QualifierBlock1(InternalSyntaxToken tDot, IdentifierGreen identifier)
		{
#if DEBUG
			if (tDot is null) throw new ArgumentNullException(nameof(tDot));
			if (tDot.RawKind != (int)CompilerSyntaxKind.TDot) throw new ArgumentException(nameof(tDot));
			if (identifier is null) throw new ArgumentNullException(nameof(identifier));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.QualifierBlock1, tDot, identifier, out hash);
			if (cached != null) return (QualifierBlock1Green)cached;
		
			var result = new QualifierBlock1Green(CompilerSyntaxKind.QualifierBlock1, tDot, identifier);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal QualifierListBlock1Green QualifierListBlock1(InternalSyntaxToken tComma, QualifierGreen qualifier)
		{
#if DEBUG
			if (tComma is null) throw new ArgumentNullException(nameof(tComma));
			if (tComma.RawKind != (int)CompilerSyntaxKind.TComma) throw new ArgumentException(nameof(tComma));
			if (qualifier is null) throw new ArgumentNullException(nameof(qualifier));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.QualifierListBlock1, tComma, qualifier, out hash);
			if (cached != null) return (QualifierListBlock1Green)cached;
		
			var result = new QualifierListBlock1Green(CompilerSyntaxKind.QualifierListBlock1, tComma, qualifier);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal SimpleQualifierBlock1Green SimpleQualifierBlock1(InternalSyntaxToken tDot, SimpleIdentifierGreen simpleIdentifier)
		{
#if DEBUG
			if (tDot is null) throw new ArgumentNullException(nameof(tDot));
			if (tDot.RawKind != (int)CompilerSyntaxKind.TDot) throw new ArgumentException(nameof(tDot));
			if (simpleIdentifier is null) throw new ArgumentNullException(nameof(simpleIdentifier));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.SimpleQualifierBlock1, tDot, simpleIdentifier, out hash);
			if (cached != null) return (SimpleQualifierBlock1Green)cached;
		
			var result = new SimpleQualifierBlock1Green(CompilerSyntaxKind.SimpleQualifierBlock1, tDot, simpleIdentifier);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal AlternativeBlock1Block1Green AlternativeBlock1Block1(InternalSyntaxToken kReturns, ReturnTypeQualifierGreen returnType)
		{
#if DEBUG
			if (kReturns is null) throw new ArgumentNullException(nameof(kReturns));
			if (kReturns.RawKind != (int)CompilerSyntaxKind.KReturns) throw new ArgumentException(nameof(kReturns));
			if (returnType is null) throw new ArgumentNullException(nameof(returnType));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.AlternativeBlock1Block1, kReturns, returnType, out hash);
			if (cached != null) return (AlternativeBlock1Block1Green)cached;
		
			var result = new AlternativeBlock1Block1Green(CompilerSyntaxKind.AlternativeBlock1Block1, kReturns, returnType);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal TokenBlock1Alt1Block1Green TokenBlock1Alt1Block1(InternalSyntaxToken kReturns, ReturnTypeQualifierGreen returnType)
		{
#if DEBUG
			if (kReturns is null) throw new ArgumentNullException(nameof(kReturns));
			if (kReturns.RawKind != (int)CompilerSyntaxKind.KReturns) throw new ArgumentException(nameof(kReturns));
			if (returnType is null) throw new ArgumentNullException(nameof(returnType));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.TokenBlock1Alt1Block1, kReturns, returnType, out hash);
			if (cached != null) return (TokenBlock1Alt1Block1Green)cached;
		
			var result = new TokenBlock1Alt1Block1Green(CompilerSyntaxKind.TokenBlock1Alt1Block1, kReturns, returnType);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal ArrayExpressionBlock1Block1Green ArrayExpressionBlock1Block1(InternalSyntaxToken tComma, SingleExpressionGreen items)
		{
#if DEBUG
			if (tComma is null) throw new ArgumentNullException(nameof(tComma));
			if (tComma.RawKind != (int)CompilerSyntaxKind.TComma) throw new ArgumentException(nameof(tComma));
			if (items is null) throw new ArgumentNullException(nameof(items));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.ArrayExpressionBlock1Block1, tComma, items, out hash);
			if (cached != null) return (ArrayExpressionBlock1Block1Green)cached;
		
			var result = new ArrayExpressionBlock1Block1Green(CompilerSyntaxKind.ArrayExpressionBlock1Block1, tComma, items);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

	}
}
