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
    using Roslyn.Utilities;
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

		public InternalSyntaxToken TIdentifier(string text)
		{
			return Token(null, CompilerSyntaxKind.TIdentifier, text, null);
		}

		public InternalSyntaxToken TIdentifier(string text, object value)
		{
			return Token(null, CompilerSyntaxKind.TIdentifier, text, value, null);
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

		internal UsingGreen Using(InternalSyntaxToken kUsing, UsingBlock1Green usingBlock1, InternalSyntaxToken tSemicolon)
		{
#if DEBUG
			if (kUsing is null) throw new ArgumentNullException(nameof(kUsing));
			if (kUsing.RawKind != (int)CompilerSyntaxKind.KUsing) throw new ArgumentException(nameof(kUsing));
			if (usingBlock1 is null) throw new ArgumentNullException(nameof(usingBlock1));
			if (tSemicolon is null) throw new ArgumentNullException(nameof(tSemicolon));
			if (tSemicolon.RawKind != (int)CompilerSyntaxKind.TSemicolon) throw new ArgumentException(nameof(tSemicolon));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.Using, kUsing, usingBlock1, tSemicolon, out hash);
			if (cached != null) return (UsingGreen)cached;
		
			var result = new UsingGreen(CompilerSyntaxKind.Using, kUsing, usingBlock1, tSemicolon);
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

		internal ParserRuleGreen ParserRule(MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<AnnotationGreen> annotations1, ParserRuleBlock1Green parserRuleBlock1, InternalSyntaxToken tColon, MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<PAlternativeGreen> pAlternativeList, InternalSyntaxToken tSemicolon)
		{
#if DEBUG
			if (parserRuleBlock1 is null) throw new ArgumentNullException(nameof(parserRuleBlock1));
			if (tColon is null) throw new ArgumentNullException(nameof(tColon));
			if (tColon.RawKind != (int)CompilerSyntaxKind.TColon) throw new ArgumentException(nameof(tColon));
			if (pAlternativeList.IsReversed) throw new ArgumentException(nameof(pAlternativeList));
			if (tSemicolon is null) throw new ArgumentNullException(nameof(tSemicolon));
			if (tSemicolon.RawKind != (int)CompilerSyntaxKind.TSemicolon) throw new ArgumentException(nameof(tSemicolon));
#endif
			return new ParserRuleGreen(CompilerSyntaxKind.ParserRule, annotations1.Node, parserRuleBlock1, tColon, pAlternativeList.Node, tSemicolon);
		}

		internal LexerRuleGreen LexerRule(MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<AnnotationGreen> annotations1, LexerRuleBlock1Green lexerRuleBlock1, InternalSyntaxToken tColon, MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<LAlternativeGreen> lAlternativeList, InternalSyntaxToken tSemicolon)
		{
#if DEBUG
			if (lexerRuleBlock1 is null) throw new ArgumentNullException(nameof(lexerRuleBlock1));
			if (tColon is null) throw new ArgumentNullException(nameof(tColon));
			if (tColon.RawKind != (int)CompilerSyntaxKind.TColon) throw new ArgumentException(nameof(tColon));
			if (lAlternativeList.IsReversed) throw new ArgumentException(nameof(lAlternativeList));
			if (tSemicolon is null) throw new ArgumentNullException(nameof(tSemicolon));
			if (tSemicolon.RawKind != (int)CompilerSyntaxKind.TSemicolon) throw new ArgumentException(nameof(tSemicolon));
#endif
			return new LexerRuleGreen(CompilerSyntaxKind.LexerRule, annotations1.Node, lexerRuleBlock1, tColon, lAlternativeList.Node, tSemicolon);
		}

		internal PAlternativeGreen PAlternative(PAlternativeBlock1Green pAlternativeBlock1, MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<PElementGreen> elements, PAlternativeBlock2Green pAlternativeBlock2)
		{
#if DEBUG
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.PAlternative, pAlternativeBlock1, elements.Node, pAlternativeBlock2, out hash);
			if (cached != null) return (PAlternativeGreen)cached;
		
			var result = new PAlternativeGreen(CompilerSyntaxKind.PAlternative, pAlternativeBlock1, elements.Node, pAlternativeBlock2);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal PElementGreen PElement(PElementBlock1Green pElementBlock1, MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<AnnotationGreen> valueAnnotations, PElementValueGreen value, InternalSyntaxToken multiplicity)
		{
#if DEBUG
			if (value is null) throw new ArgumentNullException(nameof(value));
			if (multiplicity is not null && multiplicity.RawKind != (int)CompilerSyntaxKind.TQuestion && multiplicity.RawKind != (int)CompilerSyntaxKind.TAsterisk && multiplicity.RawKind != (int)CompilerSyntaxKind.TPlus && multiplicity.RawKind != (int)CompilerSyntaxKind.TQuestionQuestion && multiplicity.RawKind != (int)CompilerSyntaxKind.TAsteriskQuestion && multiplicity.RawKind != (int)CompilerSyntaxKind.TPlusQuestion) throw new ArgumentException(nameof(multiplicity));
#endif
			return new PElementGreen(CompilerSyntaxKind.PElement, pElementBlock1, valueAnnotations.Node, value, multiplicity);
		}

		internal PReferenceAlt1Green PReferenceAlt1(IdentifierGreen rule)
		{
#if DEBUG
			if (rule is null) throw new ArgumentNullException(nameof(rule));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.PReferenceAlt1, rule, out hash);
			if (cached != null) return (PReferenceAlt1Green)cached;
		
			var result = new PReferenceAlt1Green(CompilerSyntaxKind.PReferenceAlt1, rule);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal PReferenceAlt2Green PReferenceAlt2(InternalSyntaxToken tHash, QualifierGreen referencedTypes)
		{
#if DEBUG
			if (tHash is null) throw new ArgumentNullException(nameof(tHash));
			if (tHash.RawKind != (int)CompilerSyntaxKind.THash) throw new ArgumentException(nameof(tHash));
			if (referencedTypes is null) throw new ArgumentNullException(nameof(referencedTypes));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.PReferenceAlt2, tHash, referencedTypes, out hash);
			if (cached != null) return (PReferenceAlt2Green)cached;
		
			var result = new PReferenceAlt2Green(CompilerSyntaxKind.PReferenceAlt2, tHash, referencedTypes);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal PReferenceAlt3Green PReferenceAlt3(InternalSyntaxToken tHashLBrace, MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<QualifierGreen> qualifierList, InternalSyntaxToken tRBrace)
		{
#if DEBUG
			if (tHashLBrace is null) throw new ArgumentNullException(nameof(tHashLBrace));
			if (tHashLBrace.RawKind != (int)CompilerSyntaxKind.THashLBrace) throw new ArgumentException(nameof(tHashLBrace));
			if (qualifierList.IsReversed) throw new ArgumentException(nameof(qualifierList));
			if (tRBrace is null) throw new ArgumentNullException(nameof(tRBrace));
			if (tRBrace.RawKind != (int)CompilerSyntaxKind.TRBrace) throw new ArgumentException(nameof(tRBrace));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.PReferenceAlt3, tHashLBrace, qualifierList.Node, tRBrace, out hash);
			if (cached != null) return (PReferenceAlt3Green)cached;
		
			var result = new PReferenceAlt3Green(CompilerSyntaxKind.PReferenceAlt3, tHashLBrace, qualifierList.Node, tRBrace);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal PEofGreen PEof(InternalSyntaxToken kEof)
		{
#if DEBUG
			if (kEof is null) throw new ArgumentNullException(nameof(kEof));
			if (kEof.RawKind != (int)CompilerSyntaxKind.KEof) throw new ArgumentException(nameof(kEof));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.PEof, kEof, out hash);
			if (cached != null) return (PEofGreen)cached;
		
			var result = new PEofGreen(CompilerSyntaxKind.PEof, kEof);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal PKeywordGreen PKeyword(InternalSyntaxToken text)
		{
#if DEBUG
			if (text is null) throw new ArgumentNullException(nameof(text));
			if (text.RawKind != (int)CompilerSyntaxKind.TString) throw new ArgumentException(nameof(text));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.PKeyword, text, out hash);
			if (cached != null) return (PKeywordGreen)cached;
		
			var result = new PKeywordGreen(CompilerSyntaxKind.PKeyword, text);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal PBlockGreen PBlock(InternalSyntaxToken tLParen, MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<PAlternativeGreen> pAlternativeList, InternalSyntaxToken tRParen)
		{
#if DEBUG
			if (tLParen is null) throw new ArgumentNullException(nameof(tLParen));
			if (tLParen.RawKind != (int)CompilerSyntaxKind.TLParen) throw new ArgumentException(nameof(tLParen));
			if (pAlternativeList.IsReversed) throw new ArgumentException(nameof(pAlternativeList));
			if (tRParen is null) throw new ArgumentNullException(nameof(tRParen));
			if (tRParen.RawKind != (int)CompilerSyntaxKind.TRParen) throw new ArgumentException(nameof(tRParen));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.PBlock, tLParen, pAlternativeList.Node, tRParen, out hash);
			if (cached != null) return (PBlockGreen)cached;
		
			var result = new PBlockGreen(CompilerSyntaxKind.PBlock, tLParen, pAlternativeList.Node, tRParen);
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

		internal IntExpressionGreen IntExpression(InternalSyntaxToken intValue)
		{
#if DEBUG
			if (intValue is null) throw new ArgumentNullException(nameof(intValue));
			if (intValue.RawKind != (int)CompilerSyntaxKind.TInteger) throw new ArgumentException(nameof(intValue));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.IntExpression, intValue, out hash);
			if (cached != null) return (IntExpressionGreen)cached;
		
			var result = new IntExpressionGreen(CompilerSyntaxKind.IntExpression, intValue);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal StringExpressionGreen StringExpression(InternalSyntaxToken stringValue)
		{
#if DEBUG
			if (stringValue is null) throw new ArgumentNullException(nameof(stringValue));
			if (stringValue.RawKind != (int)CompilerSyntaxKind.TString) throw new ArgumentException(nameof(stringValue));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.StringExpression, stringValue, out hash);
			if (cached != null) return (StringExpressionGreen)cached;
		
			var result = new StringExpressionGreen(CompilerSyntaxKind.StringExpression, stringValue);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal ReferenceExpressionGreen ReferenceExpression(QualifierGreen qualifier)
		{
#if DEBUG
			if (qualifier is null) throw new ArgumentNullException(nameof(qualifier));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.ReferenceExpression, qualifier, out hash);
			if (cached != null) return (ReferenceExpressionGreen)cached;
		
			var result = new ReferenceExpressionGreen(CompilerSyntaxKind.ReferenceExpression, qualifier);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal ExpressionTokensGreen ExpressionTokens(InternalSyntaxToken tokens)
		{
#if DEBUG
			if (tokens is null) throw new ArgumentNullException(nameof(tokens));
			if (tokens.RawKind != (int)CompilerSyntaxKind.KNull && tokens.RawKind != (int)CompilerSyntaxKind.KTrue && tokens.RawKind != (int)CompilerSyntaxKind.KFalse) throw new ArgumentException(nameof(tokens));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.ExpressionTokens, tokens, out hash);
			if (cached != null) return (ExpressionTokensGreen)cached;
		
			var result = new ExpressionTokensGreen(CompilerSyntaxKind.ExpressionTokens, tokens);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal AnnotationGreen Annotation(InternalSyntaxToken tLBracket, QualifierGreen type, AnnotationArgumentsGreen annotationArguments, InternalSyntaxToken tRBracket)
		{
#if DEBUG
			if (tLBracket is null) throw new ArgumentNullException(nameof(tLBracket));
			if (tLBracket.RawKind != (int)CompilerSyntaxKind.TLBracket) throw new ArgumentException(nameof(tLBracket));
			if (type is null) throw new ArgumentNullException(nameof(type));
			if (tRBracket is null) throw new ArgumentNullException(nameof(tRBracket));
			if (tRBracket.RawKind != (int)CompilerSyntaxKind.TRBracket) throw new ArgumentException(nameof(tRBracket));
#endif
			return new AnnotationGreen(CompilerSyntaxKind.Annotation, tLBracket, type, annotationArguments, tRBracket);
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

		internal IdentifierGreen Identifier(InternalSyntaxToken tIdentifier)
		{
#if DEBUG
			if (tIdentifier is null) throw new ArgumentNullException(nameof(tIdentifier));
			if (tIdentifier.RawKind != (int)CompilerSyntaxKind.TIdentifier) throw new ArgumentException(nameof(tIdentifier));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.Identifier, tIdentifier, out hash);
			if (cached != null) return (IdentifierGreen)cached;
		
			var result = new IdentifierGreen(CompilerSyntaxKind.Identifier, tIdentifier);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal UsingBlock1Alt1Green UsingBlock1Alt1(QualifierGreen namespaces)
		{
#if DEBUG
			if (namespaces is null) throw new ArgumentNullException(nameof(namespaces));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.UsingBlock1Alt1, namespaces, out hash);
			if (cached != null) return (UsingBlock1Alt1Green)cached;
		
			var result = new UsingBlock1Alt1Green(CompilerSyntaxKind.UsingBlock1Alt1, namespaces);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal UsingBlock1Alt2Green UsingBlock1Alt2(InternalSyntaxToken kMetamodel, QualifierGreen metaModelSymbols)
		{
#if DEBUG
			if (kMetamodel is null) throw new ArgumentNullException(nameof(kMetamodel));
			if (kMetamodel.RawKind != (int)CompilerSyntaxKind.KMetamodel) throw new ArgumentException(nameof(kMetamodel));
			if (metaModelSymbols is null) throw new ArgumentNullException(nameof(metaModelSymbols));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.UsingBlock1Alt2, kMetamodel, metaModelSymbols, out hash);
			if (cached != null) return (UsingBlock1Alt2Green)cached;
		
			var result = new UsingBlock1Alt2Green(CompilerSyntaxKind.UsingBlock1Alt2, kMetamodel, metaModelSymbols);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal GrammarBlock1Green GrammarBlock1(MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<RuleGreen> rules)
		{
#if DEBUG
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.GrammarBlock1, rules.Node, out hash);
			if (cached != null) return (GrammarBlock1Green)cached;
		
			var result = new GrammarBlock1Green(CompilerSyntaxKind.GrammarBlock1, rules.Node);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal ParserRuleBlock1Alt1Green ParserRuleBlock1Alt1(InternalSyntaxToken isBlock, NameGreen name)
		{
#if DEBUG
			if (isBlock is null) throw new ArgumentNullException(nameof(isBlock));
			if (isBlock.RawKind != (int)CompilerSyntaxKind.KBlock) throw new ArgumentException(nameof(isBlock));
			if (name is null) throw new ArgumentNullException(nameof(name));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.ParserRuleBlock1Alt1, isBlock, name, out hash);
			if (cached != null) return (ParserRuleBlock1Alt1Green)cached;
		
			var result = new ParserRuleBlock1Alt1Green(CompilerSyntaxKind.ParserRuleBlock1Alt1, isBlock, name);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal ParserRuleBlock1Alt2Green ParserRuleBlock1Alt2(IdentifierGreen returnType)
		{
#if DEBUG
			if (returnType is null) throw new ArgumentNullException(nameof(returnType));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.ParserRuleBlock1Alt2, returnType, out hash);
			if (cached != null) return (ParserRuleBlock1Alt2Green)cached;
		
			var result = new ParserRuleBlock1Alt2Green(CompilerSyntaxKind.ParserRuleBlock1Alt2, returnType);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal ParserRuleBlock1Alt3Green ParserRuleBlock1Alt3(NameGreen name, InternalSyntaxToken kReturns, QualifierGreen returnType)
		{
#if DEBUG
			if (name is null) throw new ArgumentNullException(nameof(name));
			if (kReturns is null) throw new ArgumentNullException(nameof(kReturns));
			if (kReturns.RawKind != (int)CompilerSyntaxKind.KReturns) throw new ArgumentException(nameof(kReturns));
			if (returnType is null) throw new ArgumentNullException(nameof(returnType));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.ParserRuleBlock1Alt3, name, kReturns, returnType, out hash);
			if (cached != null) return (ParserRuleBlock1Alt3Green)cached;
		
			var result = new ParserRuleBlock1Alt3Green(CompilerSyntaxKind.ParserRuleBlock1Alt3, name, kReturns, returnType);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal ParserRuleBlock2Green ParserRuleBlock2(InternalSyntaxToken tBar, PAlternativeGreen alternatives)
		{
#if DEBUG
			if (tBar is null) throw new ArgumentNullException(nameof(tBar));
			if (tBar.RawKind != (int)CompilerSyntaxKind.TBar) throw new ArgumentException(nameof(tBar));
			if (alternatives is null) throw new ArgumentNullException(nameof(alternatives));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.ParserRuleBlock2, tBar, alternatives, out hash);
			if (cached != null) return (ParserRuleBlock2Green)cached;
		
			var result = new ParserRuleBlock2Green(CompilerSyntaxKind.ParserRuleBlock2, tBar, alternatives);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal PAlternativeBlock1Green PAlternativeBlock1(InternalSyntaxToken tLBrace, QualifierGreen returnType, InternalSyntaxToken tRBrace)
		{
#if DEBUG
			if (tLBrace is null) throw new ArgumentNullException(nameof(tLBrace));
			if (tLBrace.RawKind != (int)CompilerSyntaxKind.TLBrace) throw new ArgumentException(nameof(tLBrace));
			if (returnType is null) throw new ArgumentNullException(nameof(returnType));
			if (tRBrace is null) throw new ArgumentNullException(nameof(tRBrace));
			if (tRBrace.RawKind != (int)CompilerSyntaxKind.TRBrace) throw new ArgumentException(nameof(tRBrace));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.PAlternativeBlock1, tLBrace, returnType, tRBrace, out hash);
			if (cached != null) return (PAlternativeBlock1Green)cached;
		
			var result = new PAlternativeBlock1Green(CompilerSyntaxKind.PAlternativeBlock1, tLBrace, returnType, tRBrace);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal PAlternativeBlock2Green PAlternativeBlock2(InternalSyntaxToken tEqGt, ExpressionGreen returnValue)
		{
#if DEBUG
			if (tEqGt is null) throw new ArgumentNullException(nameof(tEqGt));
			if (tEqGt.RawKind != (int)CompilerSyntaxKind.TEqGt) throw new ArgumentException(nameof(tEqGt));
			if (returnValue is null) throw new ArgumentNullException(nameof(returnValue));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.PAlternativeBlock2, tEqGt, returnValue, out hash);
			if (cached != null) return (PAlternativeBlock2Green)cached;
		
			var result = new PAlternativeBlock2Green(CompilerSyntaxKind.PAlternativeBlock2, tEqGt, returnValue);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal PElementBlock1Green PElementBlock1(MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<AnnotationGreen> nameAnnotations, NameGreen name, InternalSyntaxToken assignment)
		{
#if DEBUG
			if (name is null) throw new ArgumentNullException(nameof(name));
			if (assignment is null) throw new ArgumentNullException(nameof(assignment));
			if (assignment.RawKind != (int)CompilerSyntaxKind.TEq && assignment.RawKind != (int)CompilerSyntaxKind.TQuestionEq && assignment.RawKind != (int)CompilerSyntaxKind.TExclEq && assignment.RawKind != (int)CompilerSyntaxKind.TPlusEq) throw new ArgumentException(nameof(assignment));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.PElementBlock1, nameAnnotations.Node, name, assignment, out hash);
			if (cached != null) return (PElementBlock1Green)cached;
		
			var result = new PElementBlock1Green(CompilerSyntaxKind.PElementBlock1, nameAnnotations.Node, name, assignment);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal PReferenceAlt3Block1Green PReferenceAlt3Block1(InternalSyntaxToken tComma, QualifierGreen referencedTypes)
		{
#if DEBUG
			if (tComma is null) throw new ArgumentNullException(nameof(tComma));
			if (tComma.RawKind != (int)CompilerSyntaxKind.TComma) throw new ArgumentException(nameof(tComma));
			if (referencedTypes is null) throw new ArgumentNullException(nameof(referencedTypes));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.PReferenceAlt3Block1, tComma, referencedTypes, out hash);
			if (cached != null) return (PReferenceAlt3Block1Green)cached;
		
			var result = new PReferenceAlt3Block1Green(CompilerSyntaxKind.PReferenceAlt3Block1, tComma, referencedTypes);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal PBlockBlock1Green PBlockBlock1(InternalSyntaxToken tBar, PAlternativeGreen alternatives)
		{
#if DEBUG
			if (tBar is null) throw new ArgumentNullException(nameof(tBar));
			if (tBar.RawKind != (int)CompilerSyntaxKind.TBar) throw new ArgumentException(nameof(tBar));
			if (alternatives is null) throw new ArgumentNullException(nameof(alternatives));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.PBlockBlock1, tBar, alternatives, out hash);
			if (cached != null) return (PBlockBlock1Green)cached;
		
			var result = new PBlockBlock1Green(CompilerSyntaxKind.PBlockBlock1, tBar, alternatives);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal LexerRuleBlock1Alt1Green LexerRuleBlock1Alt1(InternalSyntaxToken kToken, NameGreen name, LexerRuleBlock1Alt1Block1Green lexerRuleBlock1Alt1Block1)
		{
#if DEBUG
			if (kToken is null) throw new ArgumentNullException(nameof(kToken));
			if (kToken.RawKind != (int)CompilerSyntaxKind.KToken) throw new ArgumentException(nameof(kToken));
			if (name is null) throw new ArgumentNullException(nameof(name));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.LexerRuleBlock1Alt1, kToken, name, lexerRuleBlock1Alt1Block1, out hash);
			if (cached != null) return (LexerRuleBlock1Alt1Green)cached;
		
			var result = new LexerRuleBlock1Alt1Green(CompilerSyntaxKind.LexerRuleBlock1Alt1, kToken, name, lexerRuleBlock1Alt1Block1);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal LexerRuleBlock1Alt2Green LexerRuleBlock1Alt2(InternalSyntaxToken isHidden, NameGreen name)
		{
#if DEBUG
			if (isHidden is null) throw new ArgumentNullException(nameof(isHidden));
			if (isHidden.RawKind != (int)CompilerSyntaxKind.KHidden) throw new ArgumentException(nameof(isHidden));
			if (name is null) throw new ArgumentNullException(nameof(name));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.LexerRuleBlock1Alt2, isHidden, name, out hash);
			if (cached != null) return (LexerRuleBlock1Alt2Green)cached;
		
			var result = new LexerRuleBlock1Alt2Green(CompilerSyntaxKind.LexerRuleBlock1Alt2, isHidden, name);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal LexerRuleBlock1Alt3Green LexerRuleBlock1Alt3(InternalSyntaxToken isFragment, NameGreen name)
		{
#if DEBUG
			if (isFragment is null) throw new ArgumentNullException(nameof(isFragment));
			if (isFragment.RawKind != (int)CompilerSyntaxKind.KFragment) throw new ArgumentException(nameof(isFragment));
			if (name is null) throw new ArgumentNullException(nameof(name));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.LexerRuleBlock1Alt3, isFragment, name, out hash);
			if (cached != null) return (LexerRuleBlock1Alt3Green)cached;
		
			var result = new LexerRuleBlock1Alt3Green(CompilerSyntaxKind.LexerRuleBlock1Alt3, isFragment, name);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal LexerRuleBlock2Green LexerRuleBlock2(InternalSyntaxToken tBar, LAlternativeGreen alternatives)
		{
#if DEBUG
			if (tBar is null) throw new ArgumentNullException(nameof(tBar));
			if (tBar.RawKind != (int)CompilerSyntaxKind.TBar) throw new ArgumentException(nameof(tBar));
			if (alternatives is null) throw new ArgumentNullException(nameof(alternatives));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.LexerRuleBlock2, tBar, alternatives, out hash);
			if (cached != null) return (LexerRuleBlock2Green)cached;
		
			var result = new LexerRuleBlock2Green(CompilerSyntaxKind.LexerRuleBlock2, tBar, alternatives);
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

		internal AnnotationArgumentBlock1Green AnnotationArgumentBlock1(IdentifierGreen name, InternalSyntaxToken tColon)
		{
#if DEBUG
			if (name is null) throw new ArgumentNullException(nameof(name));
			if (tColon is null) throw new ArgumentNullException(nameof(tColon));
			if (tColon.RawKind != (int)CompilerSyntaxKind.TColon) throw new ArgumentException(nameof(tColon));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.AnnotationArgumentBlock1, name, tColon, out hash);
			if (cached != null) return (AnnotationArgumentBlock1Green)cached;
		
			var result = new AnnotationArgumentBlock1Green(CompilerSyntaxKind.AnnotationArgumentBlock1, name, tColon);
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

		internal LexerRuleBlock1Alt1Block1Green LexerRuleBlock1Alt1Block1(InternalSyntaxToken kReturns, QualifierGreen returnType)
		{
#if DEBUG
			if (kReturns is null) throw new ArgumentNullException(nameof(kReturns));
			if (kReturns.RawKind != (int)CompilerSyntaxKind.KReturns) throw new ArgumentException(nameof(kReturns));
			if (returnType is null) throw new ArgumentNullException(nameof(returnType));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.LexerRuleBlock1Alt1Block1, kReturns, returnType, out hash);
			if (cached != null) return (LexerRuleBlock1Alt1Block1Green)cached;
		
			var result = new LexerRuleBlock1Alt1Block1Green(CompilerSyntaxKind.LexerRuleBlock1Alt1Block1, kReturns, returnType);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

	}
}
