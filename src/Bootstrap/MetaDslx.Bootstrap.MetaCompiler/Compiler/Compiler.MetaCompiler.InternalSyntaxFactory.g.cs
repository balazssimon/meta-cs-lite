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

		public InternalSyntaxToken TInvalidToken(string text)
		{
			return Token(null, CompilerSyntaxKind.TInvalidToken, text, null);
		}

		public InternalSyntaxToken TInvalidToken(string text, object value)
		{
			return Token(null, CompilerSyntaxKind.TInvalidToken, text, value, null);
		}

		internal MainGreen Main(InternalSyntaxToken kNamespace, QualifierGreen qualifier, InternalSyntaxToken tSemicolon, MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<UsingGreen> @using, DeclarationsGreen declarations, InternalSyntaxToken eof)
		{
#if DEBUG
			if (kNamespace is null) throw new ArgumentNullException(nameof(kNamespace));
			if (kNamespace.RawKind != (int)CompilerSyntaxKind.KNamespace) throw new ArgumentException(nameof(kNamespace));
			if (qualifier is null) throw new ArgumentNullException(nameof(qualifier));
			if (tSemicolon is null) throw new ArgumentNullException(nameof(tSemicolon));
			if (tSemicolon.RawKind != (int)CompilerSyntaxKind.TSemicolon) throw new ArgumentException(nameof(tSemicolon));
			if (declarations is null) throw new ArgumentNullException(nameof(declarations));
			if (eof is null) throw new ArgumentNullException(nameof(eof));
			if (eof.RawKind != (int)CompilerSyntaxKind.Eof) throw new ArgumentException(nameof(eof));
#endif
			return new MainGreen(CompilerSyntaxKind.Main, kNamespace, qualifier, tSemicolon, @using.Node, declarations, eof);
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

		internal LanguageDeclarationGreen LanguageDeclaration(InternalSyntaxToken kLanguage, NameGreen name, InternalSyntaxToken tSemicolon)
		{
#if DEBUG
			if (kLanguage is null) throw new ArgumentNullException(nameof(kLanguage));
			if (kLanguage.RawKind != (int)CompilerSyntaxKind.KLanguage) throw new ArgumentException(nameof(kLanguage));
			if (name is null) throw new ArgumentNullException(nameof(name));
			if (tSemicolon is null) throw new ArgumentNullException(nameof(tSemicolon));
			if (tSemicolon.RawKind != (int)CompilerSyntaxKind.TSemicolon) throw new ArgumentException(nameof(tSemicolon));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.LanguageDeclaration, kLanguage, name, tSemicolon, out hash);
			if (cached != null) return (LanguageDeclarationGreen)cached;
		
			var result = new LanguageDeclarationGreen(CompilerSyntaxKind.LanguageDeclaration, kLanguage, name, tSemicolon);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal ParserRuleGreen ParserRule(NameGreen name, ParserRuleBlock1Green parserRuleBlock1, InternalSyntaxToken tColon, MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<ParserRuleAlternativeGreen> parserRuleAlternativeList, InternalSyntaxToken tSemicolon)
		{
#if DEBUG
			if (name is null) throw new ArgumentNullException(nameof(name));
			if (tColon is null) throw new ArgumentNullException(nameof(tColon));
			if (tColon.RawKind != (int)CompilerSyntaxKind.TColon) throw new ArgumentException(nameof(tColon));
			if (parserRuleAlternativeList.IsReversed) throw new ArgumentException(nameof(parserRuleAlternativeList));
			if (tSemicolon is null) throw new ArgumentNullException(nameof(tSemicolon));
			if (tSemicolon.RawKind != (int)CompilerSyntaxKind.TSemicolon) throw new ArgumentException(nameof(tSemicolon));
#endif
			return new ParserRuleGreen(CompilerSyntaxKind.ParserRule, name, parserRuleBlock1, tColon, parserRuleAlternativeList.Node, tSemicolon);
		}

		internal BlockRuleGreen BlockRule(InternalSyntaxToken isBlock, NameGreen name, InternalSyntaxToken tColon, MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<ParserRuleAlternativeGreen> parserRuleAlternativeList, InternalSyntaxToken tSemicolon)
		{
#if DEBUG
			if (isBlock is null) throw new ArgumentNullException(nameof(isBlock));
			if (isBlock.RawKind != (int)CompilerSyntaxKind.KBlock) throw new ArgumentException(nameof(isBlock));
			if (name is null) throw new ArgumentNullException(nameof(name));
			if (tColon is null) throw new ArgumentNullException(nameof(tColon));
			if (tColon.RawKind != (int)CompilerSyntaxKind.TColon) throw new ArgumentException(nameof(tColon));
			if (parserRuleAlternativeList.IsReversed) throw new ArgumentException(nameof(parserRuleAlternativeList));
			if (tSemicolon is null) throw new ArgumentNullException(nameof(tSemicolon));
			if (tSemicolon.RawKind != (int)CompilerSyntaxKind.TSemicolon) throw new ArgumentException(nameof(tSemicolon));
#endif
			return new BlockRuleGreen(CompilerSyntaxKind.BlockRule, isBlock, name, tColon, parserRuleAlternativeList.Node, tSemicolon);
		}

		internal ParserRuleAlternativeGreen ParserRuleAlternative(ParserRuleAlternativeBlock1Green parserRuleAlternativeBlock1, MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<ParserRuleElementGreen> elements, ParserRuleAlternativeBlock2Green parserRuleAlternativeBlock2)
		{
#if DEBUG
			if (parserRuleAlternativeBlock2 is null) throw new ArgumentNullException(nameof(parserRuleAlternativeBlock2));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.ParserRuleAlternative, parserRuleAlternativeBlock1, elements.Node, parserRuleAlternativeBlock2, out hash);
			if (cached != null) return (ParserRuleAlternativeGreen)cached;
		
			var result = new ParserRuleAlternativeGreen(CompilerSyntaxKind.ParserRuleAlternative, parserRuleAlternativeBlock1, elements.Node, parserRuleAlternativeBlock2);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal ParserRuleElementGreen ParserRuleElement(NameGreen name)
		{
#if DEBUG
			if (name is null) throw new ArgumentNullException(nameof(name));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.ParserRuleElement, name, out hash);
			if (cached != null) return (ParserRuleElementGreen)cached;
		
			var result = new ParserRuleElementGreen(CompilerSyntaxKind.ParserRuleElement, name);
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

		internal UsingBlock1Alt2Green UsingBlock1Alt2(InternalSyntaxToken kMetamodel, QualifierGreen metaModels)
		{
#if DEBUG
			if (kMetamodel is null) throw new ArgumentNullException(nameof(kMetamodel));
			if (kMetamodel.RawKind != (int)CompilerSyntaxKind.KMetamodel) throw new ArgumentException(nameof(kMetamodel));
			if (metaModels is null) throw new ArgumentNullException(nameof(metaModels));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.UsingBlock1Alt2, kMetamodel, metaModels, out hash);
			if (cached != null) return (UsingBlock1Alt2Green)cached;
		
			var result = new UsingBlock1Alt2Green(CompilerSyntaxKind.UsingBlock1Alt2, kMetamodel, metaModels);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal ParserRuleBlock1Green ParserRuleBlock1(InternalSyntaxToken kReturns, QualifierGreen returnType)
		{
#if DEBUG
			if (kReturns is null) throw new ArgumentNullException(nameof(kReturns));
			if (kReturns.RawKind != (int)CompilerSyntaxKind.KReturns) throw new ArgumentException(nameof(kReturns));
			if (returnType is null) throw new ArgumentNullException(nameof(returnType));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.ParserRuleBlock1, kReturns, returnType, out hash);
			if (cached != null) return (ParserRuleBlock1Green)cached;
		
			var result = new ParserRuleBlock1Green(CompilerSyntaxKind.ParserRuleBlock1, kReturns, returnType);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal ParserRuleBlock2Green ParserRuleBlock2(InternalSyntaxToken tBar, ParserRuleAlternativeGreen alternatives)
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

		internal BlockRuleBlock1Green BlockRuleBlock1(InternalSyntaxToken tBar, ParserRuleAlternativeGreen alternatives)
		{
#if DEBUG
			if (tBar is null) throw new ArgumentNullException(nameof(tBar));
			if (tBar.RawKind != (int)CompilerSyntaxKind.TBar) throw new ArgumentException(nameof(tBar));
			if (alternatives is null) throw new ArgumentNullException(nameof(alternatives));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.BlockRuleBlock1, tBar, alternatives, out hash);
			if (cached != null) return (BlockRuleBlock1Green)cached;
		
			var result = new BlockRuleBlock1Green(CompilerSyntaxKind.BlockRuleBlock1, tBar, alternatives);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal ParserRuleAlternativeBlock1Green ParserRuleAlternativeBlock1(InternalSyntaxToken tLBrace, QualifierGreen returnType, InternalSyntaxToken tRBrace)
		{
#if DEBUG
			if (tLBrace is null) throw new ArgumentNullException(nameof(tLBrace));
			if (tLBrace.RawKind != (int)CompilerSyntaxKind.TLBrace) throw new ArgumentException(nameof(tLBrace));
			if (returnType is null) throw new ArgumentNullException(nameof(returnType));
			if (tRBrace is null) throw new ArgumentNullException(nameof(tRBrace));
			if (tRBrace.RawKind != (int)CompilerSyntaxKind.TRBrace) throw new ArgumentException(nameof(tRBrace));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.ParserRuleAlternativeBlock1, tLBrace, returnType, tRBrace, out hash);
			if (cached != null) return (ParserRuleAlternativeBlock1Green)cached;
		
			var result = new ParserRuleAlternativeBlock1Green(CompilerSyntaxKind.ParserRuleAlternativeBlock1, tLBrace, returnType, tRBrace);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal ParserRuleAlternativeBlock2Green ParserRuleAlternativeBlock2(InternalSyntaxToken tEqGt, ExpressionGreen returnValue)
		{
#if DEBUG
			if (tEqGt is null) throw new ArgumentNullException(nameof(tEqGt));
			if (tEqGt.RawKind != (int)CompilerSyntaxKind.TEqGt) throw new ArgumentException(nameof(tEqGt));
			if (returnValue is null) throw new ArgumentNullException(nameof(returnValue));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(CompilerSyntaxKind)CompilerSyntaxKind.ParserRuleAlternativeBlock2, tEqGt, returnValue, out hash);
			if (cached != null) return (ParserRuleAlternativeBlock2Green)cached;
		
			var result = new ParserRuleAlternativeBlock2Green(CompilerSyntaxKind.ParserRuleAlternativeBlock2, tEqGt, returnValue);
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
