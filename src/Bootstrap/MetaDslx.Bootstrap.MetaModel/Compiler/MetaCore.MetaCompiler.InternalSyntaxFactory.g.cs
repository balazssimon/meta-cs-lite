using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;

#nullable enable

namespace MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.InternalSyntax
{
    using MetaDslx.CodeAnalysis;
    using MetaDslx.CodeAnalysis.Syntax;
    using MetaDslx.CodeAnalysis.Syntax.InternalSyntax;
    using Roslyn.Utilities;
    using MetaDslx.CodeAnalysis.Text;

	public partial class MetaCoreInternalSyntaxFactory : InternalSyntaxFactory
	{
		public MetaCoreInternalSyntaxFactory(SyntaxFacts syntaxFacts) 
		    : base(syntaxFacts)
		{
		}
	
		public override MetaCoreSyntaxLexer CreateLexer(SourceText text, ParseOptions? options)
		{
			return new MetaCoreSyntaxLexer(text, (MetaCoreParseOptions)(options ?? MetaCoreParseOptions.Default));
		}

		public override MetaCoreSyntaxParser CreateParser(SyntaxLexer lexer, IncrementalParseData? oldParseData, IEnumerable<TextChangeRange>? changes, CancellationToken cancellationToken = default)
        {
			return new MetaCoreSyntaxParser((MetaCoreSyntaxLexer)lexer, oldParseData, changes, cancellationToken);
		}

		public InternalSyntaxTrivia Trivia(MetaCoreSyntaxKind kind, string text, bool elastic = false)
        {
			var trivia = GreenSyntaxTrivia.Create(kind, text);
			if (!elastic) return trivia;
			return trivia.WithAnnotationsGreen(new[] { SyntaxAnnotation.ElasticAnnotation });
		}

		protected override InternalSyntaxTrivia Trivia(int kind, string text, bool elastic = false)
	    {
	        return Trivia((MetaCoreSyntaxKind)kind, text, elastic);
	    }
	
		public override InternalSyntaxNode SkippedTokensTrivia(GreenNode token)
		{
			return new GreenSkippedTokensTriviaSyntax((MetaCoreSyntaxKind)InternalSyntaxKind.SkippedTokensTrivia, token);
		}
	
	    public InternalSyntaxToken Token(MetaCoreSyntaxKind kind)
	    {
	        return GreenSyntaxToken.Create(kind);
	    }

        protected override InternalSyntaxToken Token(int kind)
        {
			return Token((MetaCoreSyntaxKind)kind);
        }

        public InternalSyntaxToken Token(GreenNode? leading, MetaCoreSyntaxKind kind, GreenNode? trailing)
	    {
	        return GreenSyntaxToken.Create(kind, leading, trailing);
	    }

        protected override InternalSyntaxToken Token(GreenNode? leading, int kind, GreenNode? trailing)
        {
			return Token(leading, (MetaCoreSyntaxKind)kind, trailing);
        }

        public InternalSyntaxToken Token(GreenNode? leading, MetaCoreSyntaxKind kind, string text, GreenNode? trailing)
	    {
	        Debug.Assert(MetaCoreLanguage.Instance.SyntaxFacts.IsToken(kind));
	        string defaultText = MetaCoreLanguage.Instance.SyntaxFacts.GetText(kind);
	        return kind >= GreenSyntaxToken.FirstTokenWithWellKnownText && kind <= GreenSyntaxToken.LastTokenWithWellKnownText && text == defaultText
	            ? Token(leading, kind, trailing)
	            : GreenSyntaxToken.Identifier(kind, leading, text, trailing);
	    }

        protected override InternalSyntaxToken Token(GreenNode? leading, int kind, string text, GreenNode? trailing)
        {
            return Token(leading, (MetaCoreSyntaxKind)kind, text, trailing);
        }

        public InternalSyntaxToken Token(GreenNode? leading, MetaCoreSyntaxKind kind, string text, string valueText, GreenNode? trailing)
	    {
	        Debug.Assert(MetaCoreLanguage.Instance.SyntaxFacts.IsToken(kind));
	        string defaultText = MetaCoreLanguage.Instance.SyntaxFacts.GetText(kind);
	        return kind >= GreenSyntaxToken.FirstTokenWithWellKnownText && kind <= GreenSyntaxToken.LastTokenWithWellKnownText && text == defaultText && valueText == defaultText
	            ? Token(leading, kind, trailing)
	            : GreenSyntaxToken.WithValue(kind, leading, text, valueText, trailing);
	    }

		protected override InternalSyntaxToken Token(GreenNode? leading, int kind, string text, string valueText, GreenNode? trailing)
		{
			return Token(leading, (MetaCoreSyntaxKind)kind, text, valueText, trailing);
		}

		public InternalSyntaxToken Token(GreenNode? leading, MetaCoreSyntaxKind kind, string text, object value, GreenNode? trailing)
	    {
	        Debug.Assert(MetaCoreLanguage.Instance.SyntaxFacts.IsToken(kind));
	        string defaultText = MetaCoreLanguage.Instance.SyntaxFacts.GetText(kind);
	        return kind >= GreenSyntaxToken.FirstTokenWithWellKnownText && kind <= GreenSyntaxToken.LastTokenWithWellKnownText && text == defaultText && defaultText.Equals(value)
	            ? Token(leading, kind, trailing)
	            : GreenSyntaxToken.WithValue(kind, leading, text, value, trailing);
	    }

		protected override InternalSyntaxToken Token(GreenNode? leading, int kind, string text, object value, GreenNode? trailing)
		{
			return Token(leading, (MetaCoreSyntaxKind)kind, text, value, trailing);
		}

		public InternalSyntaxToken MissingToken(MetaCoreSyntaxKind kind)
	    {
	        return GreenSyntaxToken.CreateMissing(kind, null, null);
	    }

        protected override InternalSyntaxToken MissingToken(int kind)
        {
			return MissingToken((MetaCoreSyntaxKind)kind);
        }

        public InternalSyntaxToken MissingToken(GreenNode? leading, MetaCoreSyntaxKind kind, GreenNode? trailing)
	    {
	        return GreenSyntaxToken.CreateMissing(kind, leading, trailing);
	    }

        protected override InternalSyntaxToken MissingToken(GreenNode? leading, int kind, GreenNode? trailing)
        {
			return MissingToken(leading, (MetaCoreSyntaxKind)kind, trailing);
        }

        public override InternalSyntaxToken BadToken(GreenNode? leading, string text, GreenNode? trailing)
	    {
	        return GreenSyntaxToken.WithValue((MetaCoreSyntaxKind)InternalSyntaxKind.BadToken, leading, text, text, trailing);
	    }

        public override IEnumerable<InternalSyntaxToken> GetWellKnownTokens()
	    {
	        return GreenSyntaxToken.GetWellKnownTokens();
	    }

		public InternalSyntaxToken TInteger(string text)
		{
			return Token(null, MetaCoreSyntaxKind.TInteger, text, null);
		}

		public InternalSyntaxToken TInteger(string text, object value)
		{
			return Token(null, MetaCoreSyntaxKind.TInteger, text, value, null);
		}

		public InternalSyntaxToken TDecimal(string text)
		{
			return Token(null, MetaCoreSyntaxKind.TDecimal, text, null);
		}

		public InternalSyntaxToken TDecimal(string text, object value)
		{
			return Token(null, MetaCoreSyntaxKind.TDecimal, text, value, null);
		}

		public InternalSyntaxToken TIdentifier(string text)
		{
			return Token(null, MetaCoreSyntaxKind.TIdentifier, text, null);
		}

		public InternalSyntaxToken TIdentifier(string text, object value)
		{
			return Token(null, MetaCoreSyntaxKind.TIdentifier, text, value, null);
		}

		public InternalSyntaxToken TString(string text)
		{
			return Token(null, MetaCoreSyntaxKind.TString, text, null);
		}

		public InternalSyntaxToken TString(string text, object value)
		{
			return Token(null, MetaCoreSyntaxKind.TString, text, value, null);
		}

		public InternalSyntaxToken TWhitespace(string text)
		{
			return Token(null, MetaCoreSyntaxKind.TWhitespace, text, null);
		}

		public InternalSyntaxToken TWhitespace(string text, object value)
		{
			return Token(null, MetaCoreSyntaxKind.TWhitespace, text, value, null);
		}

		public InternalSyntaxToken TLineEnd(string text)
		{
			return Token(null, MetaCoreSyntaxKind.TLineEnd, text, null);
		}

		public InternalSyntaxToken TLineEnd(string text, object value)
		{
			return Token(null, MetaCoreSyntaxKind.TLineEnd, text, value, null);
		}

		public InternalSyntaxToken TSingleLineComment(string text)
		{
			return Token(null, MetaCoreSyntaxKind.TSingleLineComment, text, null);
		}

		public InternalSyntaxToken TSingleLineComment(string text, object value)
		{
			return Token(null, MetaCoreSyntaxKind.TSingleLineComment, text, value, null);
		}

		public InternalSyntaxToken TMultiLineComment(string text)
		{
			return Token(null, MetaCoreSyntaxKind.TMultiLineComment, text, null);
		}

		public InternalSyntaxToken TMultiLineComment(string text, object value)
		{
			return Token(null, MetaCoreSyntaxKind.TMultiLineComment, text, value, null);
		}

		internal MainGreen Main(InternalSyntaxToken kNamespace, QualifierGreen name, InternalSyntaxToken tSemicolon, MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<UsingGreen> @using, DeclarationsGreen declarations, InternalSyntaxToken eof)
		{
#if DEBUG
			if (kNamespace is null) throw new ArgumentNullException(nameof(kNamespace));
			if (kNamespace.RawKind != (int)MetaCoreSyntaxKind.KNamespace) throw new ArgumentException(nameof(kNamespace));
			if (name is null) throw new ArgumentNullException(nameof(name));
			if (tSemicolon is null) throw new ArgumentNullException(nameof(tSemicolon));
			if (tSemicolon.RawKind != (int)MetaCoreSyntaxKind.TSemicolon) throw new ArgumentException(nameof(tSemicolon));
			if (declarations is null) throw new ArgumentNullException(nameof(declarations));
			if (eof is null) throw new ArgumentNullException(nameof(eof));
			if (eof.RawKind != (int)MetaCoreSyntaxKind.Eof) throw new ArgumentException(nameof(eof));
#endif
			return new MainGreen(MetaCoreSyntaxKind.Main, kNamespace, name, tSemicolon, @using.Node, declarations, eof);
		}

		internal UsingGreen Using(InternalSyntaxToken kUsing, QualifierGreen namespaces, InternalSyntaxToken tSemicolon)
		{
#if DEBUG
			if (kUsing is null) throw new ArgumentNullException(nameof(kUsing));
			if (kUsing.RawKind != (int)MetaCoreSyntaxKind.KUsing) throw new ArgumentException(nameof(kUsing));
			if (namespaces is null) throw new ArgumentNullException(nameof(namespaces));
			if (tSemicolon is null) throw new ArgumentNullException(nameof(tSemicolon));
			if (tSemicolon.RawKind != (int)MetaCoreSyntaxKind.TSemicolon) throw new ArgumentException(nameof(tSemicolon));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(MetaCoreSyntaxKind)MetaCoreSyntaxKind.Using, kUsing, namespaces, tSemicolon, out hash);
			if (cached != null) return (UsingGreen)cached;
		
			var result = new UsingGreen(MetaCoreSyntaxKind.Using, kUsing, namespaces, tSemicolon);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal DeclarationsGreen Declarations(MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<MetaDeclarationGreen> declarations)
		{
#if DEBUG
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(MetaCoreSyntaxKind)MetaCoreSyntaxKind.Declarations, declarations.Node, out hash);
			if (cached != null) return (DeclarationsGreen)cached;
		
			var result = new DeclarationsGreen(MetaCoreSyntaxKind.Declarations, declarations.Node);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal MetaModelGreen MetaModel(InternalSyntaxToken kMetamodel, NameGreen name, InternalSyntaxToken tSemicolon)
		{
#if DEBUG
			if (kMetamodel is null) throw new ArgumentNullException(nameof(kMetamodel));
			if (kMetamodel.RawKind != (int)MetaCoreSyntaxKind.KMetamodel) throw new ArgumentException(nameof(kMetamodel));
			if (name is null) throw new ArgumentNullException(nameof(name));
			if (tSemicolon is null) throw new ArgumentNullException(nameof(tSemicolon));
			if (tSemicolon.RawKind != (int)MetaCoreSyntaxKind.TSemicolon) throw new ArgumentException(nameof(tSemicolon));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(MetaCoreSyntaxKind)MetaCoreSyntaxKind.MetaModel, kMetamodel, name, tSemicolon, out hash);
			if (cached != null) return (MetaModelGreen)cached;
		
			var result = new MetaModelGreen(MetaCoreSyntaxKind.MetaModel, kMetamodel, name, tSemicolon);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal MetaEnumTypeGreen MetaEnumType(InternalSyntaxToken kEnum, NameGreen name, EnumBodyGreen enumBody)
		{
#if DEBUG
			if (kEnum is null) throw new ArgumentNullException(nameof(kEnum));
			if (kEnum.RawKind != (int)MetaCoreSyntaxKind.KEnum) throw new ArgumentException(nameof(kEnum));
			if (name is null) throw new ArgumentNullException(nameof(name));
			if (enumBody is null) throw new ArgumentNullException(nameof(enumBody));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(MetaCoreSyntaxKind)MetaCoreSyntaxKind.MetaEnumType, kEnum, name, enumBody, out hash);
			if (cached != null) return (MetaEnumTypeGreen)cached;
		
			var result = new MetaEnumTypeGreen(MetaCoreSyntaxKind.MetaEnumType, kEnum, name, enumBody);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal MetaClassGreen MetaClass(InternalSyntaxToken isAbstract, InternalSyntaxToken kClass, NameGreen name, BaseClassesGreen baseClasses, ClassBodyGreen classBody)
		{
#if DEBUG
			if (isAbstract is not null && isAbstract.RawKind != (int)MetaCoreSyntaxKind.KAbstract) throw new ArgumentException(nameof(isAbstract));
			if (kClass is null) throw new ArgumentNullException(nameof(kClass));
			if (kClass.RawKind != (int)MetaCoreSyntaxKind.KClass) throw new ArgumentException(nameof(kClass));
			if (name is null) throw new ArgumentNullException(nameof(name));
			if (classBody is null) throw new ArgumentNullException(nameof(classBody));
#endif
			return new MetaClassGreen(MetaCoreSyntaxKind.MetaClass, isAbstract, kClass, name, baseClasses, classBody);
		}

		internal EnumBodyGreen EnumBody(InternalSyntaxToken tLBrace, EnumLiteralsGreen enumLiterals, InternalSyntaxToken tRBrace)
		{
#if DEBUG
			if (tLBrace is null) throw new ArgumentNullException(nameof(tLBrace));
			if (tLBrace.RawKind != (int)MetaCoreSyntaxKind.TLBrace) throw new ArgumentException(nameof(tLBrace));
			if (tRBrace is null) throw new ArgumentNullException(nameof(tRBrace));
			if (tRBrace.RawKind != (int)MetaCoreSyntaxKind.TRBrace) throw new ArgumentException(nameof(tRBrace));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(MetaCoreSyntaxKind)MetaCoreSyntaxKind.EnumBody, tLBrace, enumLiterals, tRBrace, out hash);
			if (cached != null) return (EnumBodyGreen)cached;
		
			var result = new EnumBodyGreen(MetaCoreSyntaxKind.EnumBody, tLBrace, enumLiterals, tRBrace);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal EnumLiteralsGreen EnumLiterals(MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<MetaEnumLiteralGreen> metaEnumLiteralList)
		{
#if DEBUG
			if (metaEnumLiteralList.IsReversed) throw new ArgumentException(nameof(metaEnumLiteralList));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(MetaCoreSyntaxKind)MetaCoreSyntaxKind.EnumLiterals, metaEnumLiteralList.Node, out hash);
			if (cached != null) return (EnumLiteralsGreen)cached;
		
			var result = new EnumLiteralsGreen(MetaCoreSyntaxKind.EnumLiterals, metaEnumLiteralList.Node);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal MetaEnumLiteralGreen MetaEnumLiteral(NameGreen name)
		{
#if DEBUG
			if (name is null) throw new ArgumentNullException(nameof(name));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(MetaCoreSyntaxKind)MetaCoreSyntaxKind.MetaEnumLiteral, name, out hash);
			if (cached != null) return (MetaEnumLiteralGreen)cached;
		
			var result = new MetaEnumLiteralGreen(MetaCoreSyntaxKind.MetaEnumLiteral, name);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal BaseClassesGreen BaseClasses(BaseClassesBlock1Green baseClassesBlock1)
		{
#if DEBUG
			if (baseClassesBlock1 is null) throw new ArgumentNullException(nameof(baseClassesBlock1));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(MetaCoreSyntaxKind)MetaCoreSyntaxKind.BaseClasses, baseClassesBlock1, out hash);
			if (cached != null) return (BaseClassesGreen)cached;
		
			var result = new BaseClassesGreen(MetaCoreSyntaxKind.BaseClasses, baseClassesBlock1);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal ClassBodyGreen ClassBody(InternalSyntaxToken tLBrace, MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<MetaPropertyGreen> properties, InternalSyntaxToken tRBrace)
		{
#if DEBUG
			if (tLBrace is null) throw new ArgumentNullException(nameof(tLBrace));
			if (tLBrace.RawKind != (int)MetaCoreSyntaxKind.TLBrace) throw new ArgumentException(nameof(tLBrace));
			if (tRBrace is null) throw new ArgumentNullException(nameof(tRBrace));
			if (tRBrace.RawKind != (int)MetaCoreSyntaxKind.TRBrace) throw new ArgumentException(nameof(tRBrace));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(MetaCoreSyntaxKind)MetaCoreSyntaxKind.ClassBody, tLBrace, properties.Node, tRBrace, out hash);
			if (cached != null) return (ClassBodyGreen)cached;
		
			var result = new ClassBodyGreen(MetaCoreSyntaxKind.ClassBody, tLBrace, properties.Node, tRBrace);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal MetaPropertyGreen MetaProperty(InternalSyntaxToken isContainment, TypeReferenceGreen type, NameGreen name, PropertyOppositeGreen propertyOpposite, InternalSyntaxToken tSemicolon)
		{
#if DEBUG
			if (isContainment is not null && isContainment.RawKind != (int)MetaCoreSyntaxKind.KContains) throw new ArgumentException(nameof(isContainment));
			if (type is null) throw new ArgumentNullException(nameof(type));
			if (name is null) throw new ArgumentNullException(nameof(name));
			if (tSemicolon is null) throw new ArgumentNullException(nameof(tSemicolon));
			if (tSemicolon.RawKind != (int)MetaCoreSyntaxKind.TSemicolon) throw new ArgumentException(nameof(tSemicolon));
#endif
			return new MetaPropertyGreen(MetaCoreSyntaxKind.MetaProperty, isContainment, type, name, propertyOpposite, tSemicolon);
		}

		internal PropertyOppositeGreen PropertyOpposite(InternalSyntaxToken kOpposite, QualifierGreen opposite)
		{
#if DEBUG
			if (kOpposite is null) throw new ArgumentNullException(nameof(kOpposite));
			if (kOpposite.RawKind != (int)MetaCoreSyntaxKind.KOpposite) throw new ArgumentException(nameof(kOpposite));
			if (opposite is null) throw new ArgumentNullException(nameof(opposite));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(MetaCoreSyntaxKind)MetaCoreSyntaxKind.PropertyOpposite, kOpposite, opposite, out hash);
			if (cached != null) return (PropertyOppositeGreen)cached;
		
			var result = new PropertyOppositeGreen(MetaCoreSyntaxKind.PropertyOpposite, kOpposite, opposite);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal MetaArrayTypeGreen MetaArrayType(TypeReferenceGreen itemType, InternalSyntaxToken tLBracket, InternalSyntaxToken tRBracket)
		{
#if DEBUG
			if (itemType is null) throw new ArgumentNullException(nameof(itemType));
			if (tLBracket is null) throw new ArgumentNullException(nameof(tLBracket));
			if (tLBracket.RawKind != (int)MetaCoreSyntaxKind.TLBracket) throw new ArgumentException(nameof(tLBracket));
			if (tRBracket is null) throw new ArgumentNullException(nameof(tRBracket));
			if (tRBracket.RawKind != (int)MetaCoreSyntaxKind.TRBracket) throw new ArgumentException(nameof(tRBracket));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(MetaCoreSyntaxKind)MetaCoreSyntaxKind.MetaArrayType, itemType, tLBracket, tRBracket, out hash);
			if (cached != null) return (MetaArrayTypeGreen)cached;
		
			var result = new MetaArrayTypeGreen(MetaCoreSyntaxKind.MetaArrayType, itemType, tLBracket, tRBracket);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal TypeReferenceAlt3Green TypeReferenceAlt3(QualifierGreen qualifier)
		{
#if DEBUG
			if (qualifier is null) throw new ArgumentNullException(nameof(qualifier));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(MetaCoreSyntaxKind)MetaCoreSyntaxKind.TypeReferenceAlt3, qualifier, out hash);
			if (cached != null) return (TypeReferenceAlt3Green)cached;
		
			var result = new TypeReferenceAlt3Green(MetaCoreSyntaxKind.TypeReferenceAlt3, qualifier);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal TypeReferenceTokensGreen TypeReferenceTokens(InternalSyntaxToken tokens)
		{
#if DEBUG
			if (tokens is null) throw new ArgumentNullException(nameof(tokens));
			if (tokens.RawKind != (int)MetaCoreSyntaxKind.KBool && tokens.RawKind != (int)MetaCoreSyntaxKind.KInt && tokens.RawKind != (int)MetaCoreSyntaxKind.KString && tokens.RawKind != (int)MetaCoreSyntaxKind.KType) throw new ArgumentException(nameof(tokens));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(MetaCoreSyntaxKind)MetaCoreSyntaxKind.TypeReferenceTokens, tokens, out hash);
			if (cached != null) return (TypeReferenceTokensGreen)cached;
		
			var result = new TypeReferenceTokensGreen(MetaCoreSyntaxKind.TypeReferenceTokens, tokens);
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
			var cached = SyntaxNodeCache.TryGetNode((int)(MetaCoreSyntaxKind)MetaCoreSyntaxKind.Name, identifier, out hash);
			if (cached != null) return (NameGreen)cached;
		
			var result = new NameGreen(MetaCoreSyntaxKind.Name, identifier);
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
			var cached = SyntaxNodeCache.TryGetNode((int)(MetaCoreSyntaxKind)MetaCoreSyntaxKind.Qualifier, identifierList.Node, out hash);
			if (cached != null) return (QualifierGreen)cached;
		
			var result = new QualifierGreen(MetaCoreSyntaxKind.Qualifier, identifierList.Node);
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
			var cached = SyntaxNodeCache.TryGetNode((int)(MetaCoreSyntaxKind)MetaCoreSyntaxKind.QualifierList, qualifierList.Node, out hash);
			if (cached != null) return (QualifierListGreen)cached;
		
			var result = new QualifierListGreen(MetaCoreSyntaxKind.QualifierList, qualifierList.Node);
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
			if (tIdentifier.RawKind != (int)MetaCoreSyntaxKind.TIdentifier) throw new ArgumentException(nameof(tIdentifier));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(MetaCoreSyntaxKind)MetaCoreSyntaxKind.Identifier, tIdentifier, out hash);
			if (cached != null) return (IdentifierGreen)cached;
		
			var result = new IdentifierGreen(MetaCoreSyntaxKind.Identifier, tIdentifier);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal EnumLiteralsBlock1Green EnumLiteralsBlock1(InternalSyntaxToken tComma, MetaEnumLiteralGreen literals)
		{
#if DEBUG
			if (tComma is null) throw new ArgumentNullException(nameof(tComma));
			if (tComma.RawKind != (int)MetaCoreSyntaxKind.TComma) throw new ArgumentException(nameof(tComma));
			if (literals is null) throw new ArgumentNullException(nameof(literals));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(MetaCoreSyntaxKind)MetaCoreSyntaxKind.EnumLiteralsBlock1, tComma, literals, out hash);
			if (cached != null) return (EnumLiteralsBlock1Green)cached;
		
			var result = new EnumLiteralsBlock1Green(MetaCoreSyntaxKind.EnumLiteralsBlock1, tComma, literals);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal BaseClassesBlock1Green BaseClassesBlock1(InternalSyntaxToken tColon, QualifierListGreen baseTypes)
		{
#if DEBUG
			if (tColon is null) throw new ArgumentNullException(nameof(tColon));
			if (tColon.RawKind != (int)MetaCoreSyntaxKind.TColon) throw new ArgumentException(nameof(tColon));
			if (baseTypes is null) throw new ArgumentNullException(nameof(baseTypes));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(MetaCoreSyntaxKind)MetaCoreSyntaxKind.BaseClassesBlock1, tColon, baseTypes, out hash);
			if (cached != null) return (BaseClassesBlock1Green)cached;
		
			var result = new BaseClassesBlock1Green(MetaCoreSyntaxKind.BaseClassesBlock1, tColon, baseTypes);
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
			if (tDot.RawKind != (int)MetaCoreSyntaxKind.TDot) throw new ArgumentException(nameof(tDot));
			if (identifier is null) throw new ArgumentNullException(nameof(identifier));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(MetaCoreSyntaxKind)MetaCoreSyntaxKind.QualifierBlock1, tDot, identifier, out hash);
			if (cached != null) return (QualifierBlock1Green)cached;
		
			var result = new QualifierBlock1Green(MetaCoreSyntaxKind.QualifierBlock1, tDot, identifier);
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
			if (tComma.RawKind != (int)MetaCoreSyntaxKind.TComma) throw new ArgumentException(nameof(tComma));
			if (qualifier is null) throw new ArgumentNullException(nameof(qualifier));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(MetaCoreSyntaxKind)MetaCoreSyntaxKind.QualifierListBlock1, tComma, qualifier, out hash);
			if (cached != null) return (QualifierListBlock1Green)cached;
		
			var result = new QualifierListBlock1Green(MetaCoreSyntaxKind.QualifierListBlock1, tComma, qualifier);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

	}
}
