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

		internal MainGreen Main(InternalSyntaxToken kNamespace, QualifierGreen name, InternalSyntaxToken tSemicolon, MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<UsingGreen> @using, InternalSyntaxToken eof)
		{
#if DEBUG
			if (kNamespace is null) throw new ArgumentNullException(nameof(kNamespace));
			if (kNamespace.RawKind != (int)CompilerSyntaxKind.KNamespace) throw new ArgumentException(nameof(kNamespace));
			if (name is null) throw new ArgumentNullException(nameof(name));
			if (tSemicolon is null) throw new ArgumentNullException(nameof(tSemicolon));
			if (tSemicolon.RawKind != (int)CompilerSyntaxKind.TSemicolon) throw new ArgumentException(nameof(tSemicolon));
			if (eof is null) throw new ArgumentNullException(nameof(eof));
			if (eof.RawKind != (int)CompilerSyntaxKind.Eof) throw new ArgumentException(nameof(eof));
#endif
			return new MainGreen(CompilerSyntaxKind.Main, kNamespace, name, tSemicolon, @using.Node, eof);
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

	}
}
