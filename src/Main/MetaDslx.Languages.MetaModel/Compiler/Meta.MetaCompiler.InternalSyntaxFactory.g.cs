using System;
using System.Threading;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;

#nullable enable

namespace MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax
{
    using MetaDslx.CodeAnalysis;
    using MetaDslx.CodeAnalysis.Syntax;
    using MetaDslx.CodeAnalysis.Syntax.InternalSyntax;
    using Roslyn.Utilities;
    using MetaDslx.CodeAnalysis.Text;

	public partial class MetaInternalSyntaxFactory : InternalSyntaxFactory
	{
		public MetaInternalSyntaxFactory(SyntaxFacts syntaxFacts) 
		    : base(syntaxFacts)
		{
		}
	
		public override SyntaxLexer CreateLexer(SourceText text, ParseOptions? options)
		{
			return new MetaSyntaxLexer(text, (MetaParseOptions)(options ?? MetaParseOptions.Default));
		}

		public override SyntaxParser CreateParser(SyntaxLexer lexer, IncrementalParseData? oldParseData, IEnumerable<TextChangeRange>? changes, CancellationToken cancellationToken = default)
        {
			return new MetaSyntaxParser((MetaSyntaxLexer)lexer, oldParseData, changes, cancellationToken);
		}

		public InternalSyntaxTrivia Trivia(MetaSyntaxKind kind, string text, bool elastic = false)
        {
			var trivia = GreenSyntaxTrivia.Create(kind, text);
			if (!elastic) return trivia;
			return trivia.WithAnnotationsGreen(new[] { SyntaxAnnotation.ElasticAnnotation });
		}

		protected override InternalSyntaxTrivia Trivia(int kind, string text, bool elastic = false)
	    {
	        return Trivia((MetaSyntaxKind)kind, text, elastic);
	    }
	
		public override InternalSyntaxNode SkippedTokensTrivia(GreenNode token)
		{
			return new GreenSkippedTokensTriviaSyntax((MetaSyntaxKind)InternalSyntaxKind.SkippedTokensTrivia, token);
		}
	
	    public InternalSyntaxToken Token(MetaSyntaxKind kind)
	    {
	        return GreenSyntaxToken.Create(kind);
	    }

        protected override InternalSyntaxToken Token(int kind)
        {
			return Token((MetaSyntaxKind)kind);
        }

        public InternalSyntaxToken Token(GreenNode? leading, MetaSyntaxKind kind, GreenNode? trailing)
	    {
	        return GreenSyntaxToken.Create(kind, leading, trailing);
	    }

        protected override InternalSyntaxToken Token(GreenNode? leading, int kind, GreenNode? trailing)
        {
			return Token(leading, (MetaSyntaxKind)kind, trailing);
        }

        public InternalSyntaxToken Token(GreenNode? leading, MetaSyntaxKind kind, string text, GreenNode? trailing)
	    {
	        Debug.Assert(MetaLanguage.Instance.SyntaxFacts.IsToken(kind));
	        string defaultText = MetaLanguage.Instance.SyntaxFacts.GetText(kind);
	        return kind >= GreenSyntaxToken.FirstTokenWithWellKnownText && kind <= GreenSyntaxToken.LastTokenWithWellKnownText && text == defaultText
	            ? Token(leading, kind, trailing)
	            : GreenSyntaxToken.Identifier(kind, leading, text, trailing);
	    }

        protected override InternalSyntaxToken Token(GreenNode? leading, int kind, string text, GreenNode? trailing)
        {
            return Token(leading, (MetaSyntaxKind)kind, text, trailing);
        }

        public InternalSyntaxToken Token(GreenNode? leading, MetaSyntaxKind kind, string text, string valueText, GreenNode? trailing)
	    {
	        Debug.Assert(MetaLanguage.Instance.SyntaxFacts.IsToken(kind));
	        string defaultText = MetaLanguage.Instance.SyntaxFacts.GetText(kind);
	        return kind >= GreenSyntaxToken.FirstTokenWithWellKnownText && kind <= GreenSyntaxToken.LastTokenWithWellKnownText && text == defaultText && valueText == defaultText
	            ? Token(leading, kind, trailing)
	            : GreenSyntaxToken.WithValue(kind, leading, text, valueText, trailing);
	    }

		protected override InternalSyntaxToken Token(GreenNode? leading, int kind, string text, string valueText, GreenNode? trailing)
		{
			return Token(leading, (MetaSyntaxKind)kind, text, valueText, trailing);
		}

		public InternalSyntaxToken Token(GreenNode? leading, MetaSyntaxKind kind, string text, object value, GreenNode? trailing)
	    {
	        Debug.Assert(MetaLanguage.Instance.SyntaxFacts.IsToken(kind));
	        string defaultText = MetaLanguage.Instance.SyntaxFacts.GetText(kind);
	        return kind >= GreenSyntaxToken.FirstTokenWithWellKnownText && kind <= GreenSyntaxToken.LastTokenWithWellKnownText && text == defaultText && defaultText.Equals(value)
	            ? Token(leading, kind, trailing)
	            : GreenSyntaxToken.WithValue(kind, leading, text, value, trailing);
	    }

		protected override InternalSyntaxToken Token(GreenNode? leading, int kind, string text, object value, GreenNode? trailing)
		{
			return Token(leading, (MetaSyntaxKind)kind, text, value, trailing);
		}

		public InternalSyntaxToken MissingToken(MetaSyntaxKind kind)
	    {
	        return GreenSyntaxToken.CreateMissing(kind, null, null);
	    }

        protected override InternalSyntaxToken MissingToken(int kind)
        {
			return MissingToken((MetaSyntaxKind)kind);
        }

        public InternalSyntaxToken MissingToken(GreenNode? leading, MetaSyntaxKind kind, GreenNode? trailing)
	    {
	        return GreenSyntaxToken.CreateMissing(kind, leading, trailing);
	    }

        protected override InternalSyntaxToken MissingToken(GreenNode? leading, int kind, GreenNode? trailing)
        {
			return MissingToken(leading, (MetaSyntaxKind)kind, trailing);
        }

        public override InternalSyntaxToken BadToken(GreenNode? leading, string text, GreenNode? trailing)
	    {
	        return GreenSyntaxToken.WithValue((MetaSyntaxKind)InternalSyntaxKind.BadToken, leading, text, text, trailing);
	    }

        public override IEnumerable<InternalSyntaxToken> GetWellKnownTokens()
	    {
	        return GreenSyntaxToken.GetWellKnownTokens();
	    }

		public InternalSyntaxToken TInteger(string text)
		{
			return Token(null, MetaSyntaxKind.TInteger, text, null);
		}

		public InternalSyntaxToken TInteger(string text, object value)
		{
			return Token(null, MetaSyntaxKind.TInteger, text, value, null);
		}

		public InternalSyntaxToken TDecimal(string text)
		{
			return Token(null, MetaSyntaxKind.TDecimal, text, null);
		}

		public InternalSyntaxToken TDecimal(string text, object value)
		{
			return Token(null, MetaSyntaxKind.TDecimal, text, value, null);
		}

		public InternalSyntaxToken TIdentifier(string text)
		{
			return Token(null, MetaSyntaxKind.TIdentifier, text, null);
		}

		public InternalSyntaxToken TIdentifier(string text, object value)
		{
			return Token(null, MetaSyntaxKind.TIdentifier, text, value, null);
		}

		public InternalSyntaxToken TString(string text)
		{
			return Token(null, MetaSyntaxKind.TString, text, null);
		}

		public InternalSyntaxToken TString(string text, object value)
		{
			return Token(null, MetaSyntaxKind.TString, text, value, null);
		}

		public InternalSyntaxToken TWhitespace(string text)
		{
			return Token(null, MetaSyntaxKind.TWhitespace, text, null);
		}

		public InternalSyntaxToken TWhitespace(string text, object value)
		{
			return Token(null, MetaSyntaxKind.TWhitespace, text, value, null);
		}

		public InternalSyntaxToken TLineEnd(string text)
		{
			return Token(null, MetaSyntaxKind.TLineEnd, text, null);
		}

		public InternalSyntaxToken TLineEnd(string text, object value)
		{
			return Token(null, MetaSyntaxKind.TLineEnd, text, value, null);
		}

		public InternalSyntaxToken TSingleLineComment(string text)
		{
			return Token(null, MetaSyntaxKind.TSingleLineComment, text, null);
		}

		public InternalSyntaxToken TSingleLineComment(string text, object value)
		{
			return Token(null, MetaSyntaxKind.TSingleLineComment, text, value, null);
		}

		public InternalSyntaxToken TMultiLineComment(string text)
		{
			return Token(null, MetaSyntaxKind.TMultiLineComment, text, null);
		}

		public InternalSyntaxToken TMultiLineComment(string text, object value)
		{
			return Token(null, MetaSyntaxKind.TMultiLineComment, text, value, null);
		}

		internal MainGreen Main(InternalSyntaxToken kNamespace, QualifierGreen name, InternalSyntaxToken tSemicolon, MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<UsingGreen> @using, DeclarationsGreen declarations, InternalSyntaxToken eof)
		{
#if DEBUG
			if (kNamespace is null) throw new ArgumentNullException(nameof(kNamespace));
			if (kNamespace.RawKind != (int)MetaSyntaxKind.KNamespace) throw new ArgumentException(nameof(kNamespace));
			if (name is null) throw new ArgumentNullException(nameof(name));
			if (tSemicolon is null) throw new ArgumentNullException(nameof(tSemicolon));
			if (tSemicolon.RawKind != (int)MetaSyntaxKind.TSemicolon) throw new ArgumentException(nameof(tSemicolon));
			if (declarations is null) throw new ArgumentNullException(nameof(declarations));
			if (eof is null) throw new ArgumentNullException(nameof(eof));
			if (eof.RawKind != (int)MetaSyntaxKind.Eof) throw new ArgumentException(nameof(eof));
#endif
			return new MainGreen(MetaSyntaxKind.Main, kNamespace, name, tSemicolon, @using.Node, declarations, eof);
		}

		internal UsingGreen Using(InternalSyntaxToken kUsing, QualifierGreen namespaces, InternalSyntaxToken tSemicolon)
		{
#if DEBUG
			if (kUsing is null) throw new ArgumentNullException(nameof(kUsing));
			if (kUsing.RawKind != (int)MetaSyntaxKind.KUsing) throw new ArgumentException(nameof(kUsing));
			if (namespaces is null) throw new ArgumentNullException(nameof(namespaces));
			if (tSemicolon is null) throw new ArgumentNullException(nameof(tSemicolon));
			if (tSemicolon.RawKind != (int)MetaSyntaxKind.TSemicolon) throw new ArgumentException(nameof(tSemicolon));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.Using, kUsing, namespaces, tSemicolon, out hash);
			if (cached != null) return (UsingGreen)cached;
		
			var result = new UsingGreen(MetaSyntaxKind.Using, kUsing, namespaces, tSemicolon);
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
			var cached = SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.Declarations, declarations.Node, out hash);
			if (cached != null) return (DeclarationsGreen)cached;
		
			var result = new DeclarationsGreen(MetaSyntaxKind.Declarations, declarations.Node);
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
			if (kMetamodel.RawKind != (int)MetaSyntaxKind.KMetamodel) throw new ArgumentException(nameof(kMetamodel));
			if (name is null) throw new ArgumentNullException(nameof(name));
			if (tSemicolon is null) throw new ArgumentNullException(nameof(tSemicolon));
			if (tSemicolon.RawKind != (int)MetaSyntaxKind.TSemicolon) throw new ArgumentException(nameof(tSemicolon));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.MetaModel, kMetamodel, name, tSemicolon, out hash);
			if (cached != null) return (MetaModelGreen)cached;
		
			var result = new MetaModelGreen(MetaSyntaxKind.MetaModel, kMetamodel, name, tSemicolon);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal MetaConstantGreen MetaConstant(InternalSyntaxToken kConst, TypeReferenceGreen type, NameGreen name, InternalSyntaxToken tSemicolon)
		{
#if DEBUG
			if (kConst is null) throw new ArgumentNullException(nameof(kConst));
			if (kConst.RawKind != (int)MetaSyntaxKind.KConst) throw new ArgumentException(nameof(kConst));
			if (type is null) throw new ArgumentNullException(nameof(type));
			if (name is null) throw new ArgumentNullException(nameof(name));
			if (tSemicolon is null) throw new ArgumentNullException(nameof(tSemicolon));
			if (tSemicolon.RawKind != (int)MetaSyntaxKind.TSemicolon) throw new ArgumentException(nameof(tSemicolon));
#endif
			return new MetaConstantGreen(MetaSyntaxKind.MetaConstant, kConst, type, name, tSemicolon);
		}

		internal MetaEnumGreen MetaEnum(InternalSyntaxToken kEnum, NameGreen name, EnumBodyGreen enumBody)
		{
#if DEBUG
			if (kEnum is null) throw new ArgumentNullException(nameof(kEnum));
			if (kEnum.RawKind != (int)MetaSyntaxKind.KEnum) throw new ArgumentException(nameof(kEnum));
			if (name is null) throw new ArgumentNullException(nameof(name));
			if (enumBody is null) throw new ArgumentNullException(nameof(enumBody));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.MetaEnum, kEnum, name, enumBody, out hash);
			if (cached != null) return (MetaEnumGreen)cached;
		
			var result = new MetaEnumGreen(MetaSyntaxKind.MetaEnum, kEnum, name, enumBody);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal MetaClassGreen MetaClass(InternalSyntaxToken isAbstract, InternalSyntaxToken kClass, ClassNameGreen name, BaseClassesGreen baseClasses, ClassBodyGreen classBody)
		{
#if DEBUG
			if (isAbstract is not null && isAbstract.RawKind != (int)MetaSyntaxKind.KAbstract) throw new ArgumentException(nameof(isAbstract));
			if (kClass is null) throw new ArgumentNullException(nameof(kClass));
			if (kClass.RawKind != (int)MetaSyntaxKind.KClass) throw new ArgumentException(nameof(kClass));
			if (name is null) throw new ArgumentNullException(nameof(name));
			if (classBody is null) throw new ArgumentNullException(nameof(classBody));
#endif
			return new MetaClassGreen(MetaSyntaxKind.MetaClass, isAbstract, kClass, name, baseClasses, classBody);
		}

		internal EnumBodyGreen EnumBody(InternalSyntaxToken tLBrace, EnumLiteralsGreen enumLiterals, InternalSyntaxToken tRBrace)
		{
#if DEBUG
			if (tLBrace is null) throw new ArgumentNullException(nameof(tLBrace));
			if (tLBrace.RawKind != (int)MetaSyntaxKind.TLBrace) throw new ArgumentException(nameof(tLBrace));
			if (tRBrace is null) throw new ArgumentNullException(nameof(tRBrace));
			if (tRBrace.RawKind != (int)MetaSyntaxKind.TRBrace) throw new ArgumentException(nameof(tRBrace));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.EnumBody, tLBrace, enumLiterals, tRBrace, out hash);
			if (cached != null) return (EnumBodyGreen)cached;
		
			var result = new EnumBodyGreen(MetaSyntaxKind.EnumBody, tLBrace, enumLiterals, tRBrace);
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
			var cached = SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.EnumLiterals, metaEnumLiteralList.Node, out hash);
			if (cached != null) return (EnumLiteralsGreen)cached;
		
			var result = new EnumLiteralsGreen(MetaSyntaxKind.EnumLiterals, metaEnumLiteralList.Node);
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
			var cached = SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.MetaEnumLiteral, name, out hash);
			if (cached != null) return (MetaEnumLiteralGreen)cached;
		
			var result = new MetaEnumLiteralGreen(MetaSyntaxKind.MetaEnumLiteral, name);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal ClassNameAlt1Green ClassNameAlt1(InternalSyntaxToken tIdentifier, InternalSyntaxToken tDollar, IdentifierGreen symbolType)
		{
#if DEBUG
			if (tIdentifier is not null && tIdentifier.RawKind != (int)MetaSyntaxKind.TIdentifier) throw new ArgumentException(nameof(tIdentifier));
			if (tDollar is null) throw new ArgumentNullException(nameof(tDollar));
			if (tDollar.RawKind != (int)MetaSyntaxKind.TDollar) throw new ArgumentException(nameof(tDollar));
			if (symbolType is null) throw new ArgumentNullException(nameof(symbolType));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.ClassNameAlt1, tIdentifier, tDollar, symbolType, out hash);
			if (cached != null) return (ClassNameAlt1Green)cached;
		
			var result = new ClassNameAlt1Green(MetaSyntaxKind.ClassNameAlt1, tIdentifier, tDollar, symbolType);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal ClassNameAlt2Green ClassNameAlt2(InternalSyntaxToken tIdentifier)
		{
#if DEBUG
			if (tIdentifier is null) throw new ArgumentNullException(nameof(tIdentifier));
			if (tIdentifier.RawKind != (int)MetaSyntaxKind.TIdentifier) throw new ArgumentException(nameof(tIdentifier));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.ClassNameAlt2, tIdentifier, out hash);
			if (cached != null) return (ClassNameAlt2Green)cached;
		
			var result = new ClassNameAlt2Green(MetaSyntaxKind.ClassNameAlt2, tIdentifier);
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
			var cached = SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.BaseClasses, baseClassesBlock1, out hash);
			if (cached != null) return (BaseClassesGreen)cached;
		
			var result = new BaseClassesGreen(MetaSyntaxKind.BaseClasses, baseClassesBlock1);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal ClassBodyGreen ClassBody(InternalSyntaxToken tLBrace, MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<ClassMemberGreen> classMember, InternalSyntaxToken tRBrace)
		{
#if DEBUG
			if (tLBrace is null) throw new ArgumentNullException(nameof(tLBrace));
			if (tLBrace.RawKind != (int)MetaSyntaxKind.TLBrace) throw new ArgumentException(nameof(tLBrace));
			if (tRBrace is null) throw new ArgumentNullException(nameof(tRBrace));
			if (tRBrace.RawKind != (int)MetaSyntaxKind.TRBrace) throw new ArgumentException(nameof(tRBrace));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.ClassBody, tLBrace, classMember.Node, tRBrace, out hash);
			if (cached != null) return (ClassBodyGreen)cached;
		
			var result = new ClassBodyGreen(MetaSyntaxKind.ClassBody, tLBrace, classMember.Node, tRBrace);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal ClassMemberAlt1Green ClassMemberAlt1(MetaPropertyGreen properties)
		{
#if DEBUG
			if (properties is null) throw new ArgumentNullException(nameof(properties));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.ClassMemberAlt1, properties, out hash);
			if (cached != null) return (ClassMemberAlt1Green)cached;
		
			var result = new ClassMemberAlt1Green(MetaSyntaxKind.ClassMemberAlt1, properties);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal ClassMemberAlt2Green ClassMemberAlt2(MetaOperationGreen operations)
		{
#if DEBUG
			if (operations is null) throw new ArgumentNullException(nameof(operations));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.ClassMemberAlt2, operations, out hash);
			if (cached != null) return (ClassMemberAlt2Green)cached;
		
			var result = new ClassMemberAlt2Green(MetaSyntaxKind.ClassMemberAlt2, operations);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal MetaPropertyGreen MetaProperty(InternalSyntaxToken element, TypeReferenceGreen type, PropertyNameGreen name, MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<MetaPropertyBlock2Green> metaPropertyBlock2, InternalSyntaxToken tSemicolon)
		{
#if DEBUG
			if (element is not null && element.RawKind != (int)MetaSyntaxKind.KContains && element.RawKind != (int)MetaSyntaxKind.KDerived) throw new ArgumentException(nameof(element));
			if (type is null) throw new ArgumentNullException(nameof(type));
			if (name is null) throw new ArgumentNullException(nameof(name));
			if (tSemicolon is null) throw new ArgumentNullException(nameof(tSemicolon));
			if (tSemicolon.RawKind != (int)MetaSyntaxKind.TSemicolon) throw new ArgumentException(nameof(tSemicolon));
#endif
			return new MetaPropertyGreen(MetaSyntaxKind.MetaProperty, element, type, name, metaPropertyBlock2.Node, tSemicolon);
		}

		internal PropertyNameAlt1Green PropertyNameAlt1(InternalSyntaxToken tIdentifier, InternalSyntaxToken tDollar, InternalSyntaxToken symbolProperty)
		{
#if DEBUG
			if (tIdentifier is not null && tIdentifier.RawKind != (int)MetaSyntaxKind.TIdentifier) throw new ArgumentException(nameof(tIdentifier));
			if (tDollar is null) throw new ArgumentNullException(nameof(tDollar));
			if (tDollar.RawKind != (int)MetaSyntaxKind.TDollar) throw new ArgumentException(nameof(tDollar));
			if (symbolProperty is null) throw new ArgumentNullException(nameof(symbolProperty));
			if (symbolProperty.RawKind != (int)MetaSyntaxKind.TIdentifier) throw new ArgumentException(nameof(symbolProperty));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.PropertyNameAlt1, tIdentifier, tDollar, symbolProperty, out hash);
			if (cached != null) return (PropertyNameAlt1Green)cached;
		
			var result = new PropertyNameAlt1Green(MetaSyntaxKind.PropertyNameAlt1, tIdentifier, tDollar, symbolProperty);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal PropertyNameAlt2Green PropertyNameAlt2(InternalSyntaxToken tIdentifier)
		{
#if DEBUG
			if (tIdentifier is null) throw new ArgumentNullException(nameof(tIdentifier));
			if (tIdentifier.RawKind != (int)MetaSyntaxKind.TIdentifier) throw new ArgumentException(nameof(tIdentifier));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.PropertyNameAlt2, tIdentifier, out hash);
			if (cached != null) return (PropertyNameAlt2Green)cached;
		
			var result = new PropertyNameAlt2Green(MetaSyntaxKind.PropertyNameAlt2, tIdentifier);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal PropertyOppositeGreen PropertyOpposite(InternalSyntaxToken kOpposite, MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<QualifierGreen> qualifierList)
		{
#if DEBUG
			if (kOpposite is null) throw new ArgumentNullException(nameof(kOpposite));
			if (kOpposite.RawKind != (int)MetaSyntaxKind.KOpposite) throw new ArgumentException(nameof(kOpposite));
			if (qualifierList.IsReversed) throw new ArgumentException(nameof(qualifierList));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.PropertyOpposite, kOpposite, qualifierList.Node, out hash);
			if (cached != null) return (PropertyOppositeGreen)cached;
		
			var result = new PropertyOppositeGreen(MetaSyntaxKind.PropertyOpposite, kOpposite, qualifierList.Node);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal PropertySubsetsGreen PropertySubsets(InternalSyntaxToken kSubsets, MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<QualifierGreen> qualifierList)
		{
#if DEBUG
			if (kSubsets is null) throw new ArgumentNullException(nameof(kSubsets));
			if (kSubsets.RawKind != (int)MetaSyntaxKind.KSubsets) throw new ArgumentException(nameof(kSubsets));
			if (qualifierList.IsReversed) throw new ArgumentException(nameof(qualifierList));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.PropertySubsets, kSubsets, qualifierList.Node, out hash);
			if (cached != null) return (PropertySubsetsGreen)cached;
		
			var result = new PropertySubsetsGreen(MetaSyntaxKind.PropertySubsets, kSubsets, qualifierList.Node);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal PropertyRedefinesGreen PropertyRedefines(InternalSyntaxToken kRedefines, MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<QualifierGreen> qualifierList)
		{
#if DEBUG
			if (kRedefines is null) throw new ArgumentNullException(nameof(kRedefines));
			if (kRedefines.RawKind != (int)MetaSyntaxKind.KRedefines) throw new ArgumentException(nameof(kRedefines));
			if (qualifierList.IsReversed) throw new ArgumentException(nameof(qualifierList));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.PropertyRedefines, kRedefines, qualifierList.Node, out hash);
			if (cached != null) return (PropertyRedefinesGreen)cached;
		
			var result = new PropertyRedefinesGreen(MetaSyntaxKind.PropertyRedefines, kRedefines, qualifierList.Node);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal MetaOperationGreen MetaOperation(TypeReferenceGreen returnType, NameGreen name, InternalSyntaxToken tLParen, ParameterListGreen parameterList, InternalSyntaxToken tRParen, InternalSyntaxToken tSemicolon)
		{
#if DEBUG
			if (returnType is null) throw new ArgumentNullException(nameof(returnType));
			if (name is null) throw new ArgumentNullException(nameof(name));
			if (tLParen is null) throw new ArgumentNullException(nameof(tLParen));
			if (tLParen.RawKind != (int)MetaSyntaxKind.TLParen) throw new ArgumentException(nameof(tLParen));
			if (tRParen is null) throw new ArgumentNullException(nameof(tRParen));
			if (tRParen.RawKind != (int)MetaSyntaxKind.TRParen) throw new ArgumentException(nameof(tRParen));
			if (tSemicolon is null) throw new ArgumentNullException(nameof(tSemicolon));
			if (tSemicolon.RawKind != (int)MetaSyntaxKind.TSemicolon) throw new ArgumentException(nameof(tSemicolon));
#endif
			return new MetaOperationGreen(MetaSyntaxKind.MetaOperation, returnType, name, tLParen, parameterList, tRParen, tSemicolon);
		}

		internal ParameterListGreen ParameterList(MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<MetaParameterGreen> metaParameterList)
		{
#if DEBUG
			if (metaParameterList.IsReversed) throw new ArgumentException(nameof(metaParameterList));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.ParameterList, metaParameterList.Node, out hash);
			if (cached != null) return (ParameterListGreen)cached;
		
			var result = new ParameterListGreen(MetaSyntaxKind.ParameterList, metaParameterList.Node);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal MetaParameterGreen MetaParameter(TypeReferenceGreen type, NameGreen name)
		{
#if DEBUG
			if (type is null) throw new ArgumentNullException(nameof(type));
			if (name is null) throw new ArgumentNullException(nameof(name));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.MetaParameter, type, name, out hash);
			if (cached != null) return (MetaParameterGreen)cached;
		
			var result = new MetaParameterGreen(MetaSyntaxKind.MetaParameter, type, name);
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
			if (tLBracket.RawKind != (int)MetaSyntaxKind.TLBracket) throw new ArgumentException(nameof(tLBracket));
			if (tRBracket is null) throw new ArgumentNullException(nameof(tRBracket));
			if (tRBracket.RawKind != (int)MetaSyntaxKind.TRBracket) throw new ArgumentException(nameof(tRBracket));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.MetaArrayType, itemType, tLBracket, tRBracket, out hash);
			if (cached != null) return (MetaArrayTypeGreen)cached;
		
			var result = new MetaArrayTypeGreen(MetaSyntaxKind.MetaArrayType, itemType, tLBracket, tRBracket);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal MetaNullableTypeGreen MetaNullableType(TypeReferenceGreen innerType, InternalSyntaxToken tQuestion)
		{
#if DEBUG
			if (innerType is null) throw new ArgumentNullException(nameof(innerType));
			if (tQuestion is null) throw new ArgumentNullException(nameof(tQuestion));
			if (tQuestion.RawKind != (int)MetaSyntaxKind.TQuestion) throw new ArgumentException(nameof(tQuestion));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.MetaNullableType, innerType, tQuestion, out hash);
			if (cached != null) return (MetaNullableTypeGreen)cached;
		
			var result = new MetaNullableTypeGreen(MetaSyntaxKind.MetaNullableType, innerType, tQuestion);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal TypeReferenceAlt4Green TypeReferenceAlt4(QualifierGreen qualifier)
		{
#if DEBUG
			if (qualifier is null) throw new ArgumentNullException(nameof(qualifier));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.TypeReferenceAlt4, qualifier, out hash);
			if (cached != null) return (TypeReferenceAlt4Green)cached;
		
			var result = new TypeReferenceAlt4Green(MetaSyntaxKind.TypeReferenceAlt4, qualifier);
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
			if (tokens.RawKind != (int)MetaSyntaxKind.KBool && tokens.RawKind != (int)MetaSyntaxKind.KInt && tokens.RawKind != (int)MetaSyntaxKind.KString && tokens.RawKind != (int)MetaSyntaxKind.KType && tokens.RawKind != (int)MetaSyntaxKind.KSymbol && tokens.RawKind != (int)MetaSyntaxKind.KObject && tokens.RawKind != (int)MetaSyntaxKind.KVoid) throw new ArgumentException(nameof(tokens));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.TypeReferenceTokens, tokens, out hash);
			if (cached != null) return (TypeReferenceTokensGreen)cached;
		
			var result = new TypeReferenceTokensGreen(MetaSyntaxKind.TypeReferenceTokens, tokens);
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
			var cached = SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.Name, identifier, out hash);
			if (cached != null) return (NameGreen)cached;
		
			var result = new NameGreen(MetaSyntaxKind.Name, identifier);
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
			var cached = SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.Qualifier, identifierList.Node, out hash);
			if (cached != null) return (QualifierGreen)cached;
		
			var result = new QualifierGreen(MetaSyntaxKind.Qualifier, identifierList.Node);
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
			var cached = SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.QualifierList, qualifierList.Node, out hash);
			if (cached != null) return (QualifierListGreen)cached;
		
			var result = new QualifierListGreen(MetaSyntaxKind.QualifierList, qualifierList.Node);
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
			if (tIdentifier.RawKind != (int)MetaSyntaxKind.TIdentifier) throw new ArgumentException(nameof(tIdentifier));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.Identifier, tIdentifier, out hash);
			if (cached != null) return (IdentifierGreen)cached;
		
			var result = new IdentifierGreen(MetaSyntaxKind.Identifier, tIdentifier);
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
			if (tComma.RawKind != (int)MetaSyntaxKind.TComma) throw new ArgumentException(nameof(tComma));
			if (literals is null) throw new ArgumentNullException(nameof(literals));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.EnumLiteralsBlock1, tComma, literals, out hash);
			if (cached != null) return (EnumLiteralsBlock1Green)cached;
		
			var result = new EnumLiteralsBlock1Green(MetaSyntaxKind.EnumLiteralsBlock1, tComma, literals);
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
			if (tColon.RawKind != (int)MetaSyntaxKind.TColon) throw new ArgumentException(nameof(tColon));
			if (baseTypes is null) throw new ArgumentNullException(nameof(baseTypes));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.BaseClassesBlock1, tColon, baseTypes, out hash);
			if (cached != null) return (BaseClassesBlock1Green)cached;
		
			var result = new BaseClassesBlock1Green(MetaSyntaxKind.BaseClassesBlock1, tColon, baseTypes);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal MetaPropertyBlock2Alt1Green MetaPropertyBlock2Alt1(PropertyOppositeGreen propertyOpposite)
		{
#if DEBUG
			if (propertyOpposite is null) throw new ArgumentNullException(nameof(propertyOpposite));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.MetaPropertyBlock2Alt1, propertyOpposite, out hash);
			if (cached != null) return (MetaPropertyBlock2Alt1Green)cached;
		
			var result = new MetaPropertyBlock2Alt1Green(MetaSyntaxKind.MetaPropertyBlock2Alt1, propertyOpposite);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal MetaPropertyBlock2Alt2Green MetaPropertyBlock2Alt2(PropertySubsetsGreen propertySubsets)
		{
#if DEBUG
			if (propertySubsets is null) throw new ArgumentNullException(nameof(propertySubsets));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.MetaPropertyBlock2Alt2, propertySubsets, out hash);
			if (cached != null) return (MetaPropertyBlock2Alt2Green)cached;
		
			var result = new MetaPropertyBlock2Alt2Green(MetaSyntaxKind.MetaPropertyBlock2Alt2, propertySubsets);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal MetaPropertyBlock2Alt3Green MetaPropertyBlock2Alt3(PropertyRedefinesGreen propertyRedefines)
		{
#if DEBUG
			if (propertyRedefines is null) throw new ArgumentNullException(nameof(propertyRedefines));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.MetaPropertyBlock2Alt3, propertyRedefines, out hash);
			if (cached != null) return (MetaPropertyBlock2Alt3Green)cached;
		
			var result = new MetaPropertyBlock2Alt3Green(MetaSyntaxKind.MetaPropertyBlock2Alt3, propertyRedefines);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal PropertyOppositeBlock1Green PropertyOppositeBlock1(InternalSyntaxToken tComma, QualifierGreen oppositeProperties)
		{
#if DEBUG
			if (tComma is null) throw new ArgumentNullException(nameof(tComma));
			if (tComma.RawKind != (int)MetaSyntaxKind.TComma) throw new ArgumentException(nameof(tComma));
			if (oppositeProperties is null) throw new ArgumentNullException(nameof(oppositeProperties));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.PropertyOppositeBlock1, tComma, oppositeProperties, out hash);
			if (cached != null) return (PropertyOppositeBlock1Green)cached;
		
			var result = new PropertyOppositeBlock1Green(MetaSyntaxKind.PropertyOppositeBlock1, tComma, oppositeProperties);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal PropertySubsetsBlock1Green PropertySubsetsBlock1(InternalSyntaxToken tComma, QualifierGreen subsettedProperties)
		{
#if DEBUG
			if (tComma is null) throw new ArgumentNullException(nameof(tComma));
			if (tComma.RawKind != (int)MetaSyntaxKind.TComma) throw new ArgumentException(nameof(tComma));
			if (subsettedProperties is null) throw new ArgumentNullException(nameof(subsettedProperties));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.PropertySubsetsBlock1, tComma, subsettedProperties, out hash);
			if (cached != null) return (PropertySubsetsBlock1Green)cached;
		
			var result = new PropertySubsetsBlock1Green(MetaSyntaxKind.PropertySubsetsBlock1, tComma, subsettedProperties);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal PropertyRedefinesBlock1Green PropertyRedefinesBlock1(InternalSyntaxToken tComma, QualifierGreen redefinedProperties)
		{
#if DEBUG
			if (tComma is null) throw new ArgumentNullException(nameof(tComma));
			if (tComma.RawKind != (int)MetaSyntaxKind.TComma) throw new ArgumentException(nameof(tComma));
			if (redefinedProperties is null) throw new ArgumentNullException(nameof(redefinedProperties));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.PropertyRedefinesBlock1, tComma, redefinedProperties, out hash);
			if (cached != null) return (PropertyRedefinesBlock1Green)cached;
		
			var result = new PropertyRedefinesBlock1Green(MetaSyntaxKind.PropertyRedefinesBlock1, tComma, redefinedProperties);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

		internal ParameterListBlock1Green ParameterListBlock1(InternalSyntaxToken tComma, MetaParameterGreen parameters)
		{
#if DEBUG
			if (tComma is null) throw new ArgumentNullException(nameof(tComma));
			if (tComma.RawKind != (int)MetaSyntaxKind.TComma) throw new ArgumentException(nameof(tComma));
			if (parameters is null) throw new ArgumentNullException(nameof(parameters));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.ParameterListBlock1, tComma, parameters, out hash);
			if (cached != null) return (ParameterListBlock1Green)cached;
		
			var result = new ParameterListBlock1Green(MetaSyntaxKind.ParameterListBlock1, tComma, parameters);
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
			if (tDot.RawKind != (int)MetaSyntaxKind.TDot) throw new ArgumentException(nameof(tDot));
			if (identifier is null) throw new ArgumentNullException(nameof(identifier));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.QualifierBlock1, tDot, identifier, out hash);
			if (cached != null) return (QualifierBlock1Green)cached;
		
			var result = new QualifierBlock1Green(MetaSyntaxKind.QualifierBlock1, tDot, identifier);
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
			if (tComma.RawKind != (int)MetaSyntaxKind.TComma) throw new ArgumentException(nameof(tComma));
			if (qualifier is null) throw new ArgumentNullException(nameof(qualifier));
#endif
			int hash;
			var cached = SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.QualifierListBlock1, tComma, qualifier, out hash);
			if (cached != null) return (QualifierListBlock1Green)cached;
		
			var result = new QualifierListBlock1Green(MetaSyntaxKind.QualifierListBlock1, tComma, qualifier);
			if (hash >= 0)
			{
				SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

	}
}
