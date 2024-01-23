#nullable enable

namespace MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax
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
	using __CancellationToken = global::System.Threading.CancellationToken;
	using __ArgumentNullException = global::System.ArgumentNullException;
    using __ArgumentException = global::System.ArgumentException;

	public partial class MetaInternalSyntaxFactory : global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.InternalSyntaxFactory
	{
		public MetaInternalSyntaxFactory(__SyntaxFacts syntaxFacts) 
		    : base(syntaxFacts)
		{
		}
	
		public override __SyntaxLexer CreateLexer(__SourceText text, __ParseOptions? options)
		{
			return new MetaSyntaxLexer(text, (MetaParseOptions)(options ?? MetaParseOptions.Default));
		}

		public override __SyntaxParser CreateParser(__SyntaxLexer lexer, __IncrementalParseData? oldParseData, global::System.Collections.Generic.IEnumerable<__TextChangeRange>? changes, __CancellationToken cancellationToken = default)
        {
			return new MetaSyntaxParser((MetaSyntaxLexer)lexer, oldParseData, changes, cancellationToken);
		}

		public __InternalSyntaxTrivia Trivia(MetaSyntaxKind kind, string text, bool elastic = false)
        {
			var trivia = GreenSyntaxTrivia.Create(kind, text);
			if (!elastic) return trivia;
			return global::MetaDslx.CodeAnalysis.GreenNodeExtensions.WithAnnotationsGreen(trivia, new[] { __SyntaxAnnotation.ElasticAnnotation });
		}

		protected override __InternalSyntaxTrivia Trivia(int kind, string text, bool elastic = false)
	    {
	        return Trivia((MetaSyntaxKind)kind, text, elastic);
	    }
	
		public override __InternalSyntaxNode SkippedTokensTrivia(__GreenNode token)
		{
			return new GreenSkippedTokensTriviaSyntax((MetaSyntaxKind)__InternalSyntaxKind.SkippedTokensTrivia, token);
		}
	
	    public __InternalSyntaxToken Token(MetaSyntaxKind kind)
	    {
	        return GreenSyntaxToken.Create(kind);
	    }

        protected override __InternalSyntaxToken Token(int kind)
        {
			return Token((MetaSyntaxKind)kind);
        }

        public __InternalSyntaxToken Token(__GreenNode? leading, MetaSyntaxKind kind, __GreenNode? trailing)
	    {
	        return GreenSyntaxToken.Create(kind, leading, trailing);
	    }

        protected override __InternalSyntaxToken Token(__GreenNode? leading, int kind, __GreenNode? trailing)
        {
			return Token(leading, (MetaSyntaxKind)kind, trailing);
        }

        public __InternalSyntaxToken Token(__GreenNode? leading, MetaSyntaxKind kind, string text, __GreenNode? trailing)
	    {
	        __Debug.Assert(MetaLanguage.Instance.SyntaxFacts.IsToken(kind));
	        string defaultText = MetaLanguage.Instance.SyntaxFacts.GetText(kind);
	        return kind >= GreenSyntaxToken.FirstTokenWithWellKnownText && kind <= GreenSyntaxToken.LastTokenWithWellKnownText && text == defaultText
	            ? Token(leading, kind, trailing)
	            : GreenSyntaxToken.Identifier(kind, leading, text, trailing);
	    }

        protected override __InternalSyntaxToken Token(__GreenNode? leading, int kind, string text, __GreenNode? trailing)
        {
            return Token(leading, (MetaSyntaxKind)kind, text, trailing);
        }

        public __InternalSyntaxToken Token(__GreenNode? leading, MetaSyntaxKind kind, string text, string valueText, __GreenNode? trailing)
	    {
	        __Debug.Assert(MetaLanguage.Instance.SyntaxFacts.IsToken(kind));
	        string defaultText = MetaLanguage.Instance.SyntaxFacts.GetText(kind);
	        return kind >= GreenSyntaxToken.FirstTokenWithWellKnownText && kind <= GreenSyntaxToken.LastTokenWithWellKnownText && text == defaultText && valueText == defaultText
	            ? Token(leading, kind, trailing)
	            : GreenSyntaxToken.WithValue(kind, leading, text, valueText, trailing);
	    }

		protected override __InternalSyntaxToken Token(__GreenNode? leading, int kind, string text, string valueText, __GreenNode? trailing)
		{
			return Token(leading, (MetaSyntaxKind)kind, text, valueText, trailing);
		}

		public __InternalSyntaxToken Token(__GreenNode? leading, MetaSyntaxKind kind, string text, object value, __GreenNode? trailing)
	    {
	        __Debug.Assert(MetaLanguage.Instance.SyntaxFacts.IsToken(kind));
	        string defaultText = MetaLanguage.Instance.SyntaxFacts.GetText(kind);
	        return kind >= GreenSyntaxToken.FirstTokenWithWellKnownText && kind <= GreenSyntaxToken.LastTokenWithWellKnownText && text == defaultText && defaultText.Equals(value)
	            ? Token(leading, kind, trailing)
	            : GreenSyntaxToken.WithValue(kind, leading, text, value, trailing);
	    }

		protected override __InternalSyntaxToken Token(__GreenNode? leading, int kind, string text, object value, __GreenNode? trailing)
		{
			return Token(leading, (MetaSyntaxKind)kind, text, value, trailing);
		}

		public __InternalSyntaxToken MissingToken(MetaSyntaxKind kind)
	    {
	        return GreenSyntaxToken.CreateMissing(kind, null, null);
	    }

        protected override __InternalSyntaxToken MissingToken(int kind)
        {
			return MissingToken((MetaSyntaxKind)kind);
        }

        public __InternalSyntaxToken MissingToken(__GreenNode? leading, MetaSyntaxKind kind, __GreenNode? trailing)
	    {
	        return GreenSyntaxToken.CreateMissing(kind, leading, trailing);
	    }

        protected override __InternalSyntaxToken MissingToken(__GreenNode? leading, int kind, __GreenNode? trailing)
        {
			return MissingToken(leading, (MetaSyntaxKind)kind, trailing);
        }

        public override __InternalSyntaxToken BadToken(__GreenNode? leading, string text, __GreenNode? trailing)
	    {
	        return GreenSyntaxToken.WithValue((MetaSyntaxKind)__InternalSyntaxKind.BadToken, leading, text, text, trailing);
	    }

        public override global::System.Collections.Generic.IEnumerable<__InternalSyntaxToken> GetWellKnownTokens()
	    {
	        return GreenSyntaxToken.GetWellKnownTokens();
	    }

		public __InternalSyntaxToken TInteger(string text)
		{
			return Token(null, MetaSyntaxKind.TInteger, text, null);
		}

		public __InternalSyntaxToken TInteger(string text, object value)
		{
			return Token(null, MetaSyntaxKind.TInteger, text, value, null);
		}

		public __InternalSyntaxToken TDecimal(string text)
		{
			return Token(null, MetaSyntaxKind.TDecimal, text, null);
		}

		public __InternalSyntaxToken TDecimal(string text, object value)
		{
			return Token(null, MetaSyntaxKind.TDecimal, text, value, null);
		}

		public __InternalSyntaxToken TIdentifier(string text)
		{
			return Token(null, MetaSyntaxKind.TIdentifier, text, null);
		}

		public __InternalSyntaxToken TIdentifier(string text, object value)
		{
			return Token(null, MetaSyntaxKind.TIdentifier, text, value, null);
		}

		public __InternalSyntaxToken TVerbatimIdentifier(string text)
		{
			return Token(null, MetaSyntaxKind.TVerbatimIdentifier, text, null);
		}

		public __InternalSyntaxToken TVerbatimIdentifier(string text, object value)
		{
			return Token(null, MetaSyntaxKind.TVerbatimIdentifier, text, value, null);
		}

		public __InternalSyntaxToken TString(string text)
		{
			return Token(null, MetaSyntaxKind.TString, text, null);
		}

		public __InternalSyntaxToken TString(string text, object value)
		{
			return Token(null, MetaSyntaxKind.TString, text, value, null);
		}

		public __InternalSyntaxToken TWhitespace(string text)
		{
			return Token(null, MetaSyntaxKind.TWhitespace, text, null);
		}

		public __InternalSyntaxToken TWhitespace(string text, object value)
		{
			return Token(null, MetaSyntaxKind.TWhitespace, text, value, null);
		}

		public __InternalSyntaxToken TLineEnd(string text)
		{
			return Token(null, MetaSyntaxKind.TLineEnd, text, null);
		}

		public __InternalSyntaxToken TLineEnd(string text, object value)
		{
			return Token(null, MetaSyntaxKind.TLineEnd, text, value, null);
		}

		public __InternalSyntaxToken TSingleLineComment(string text)
		{
			return Token(null, MetaSyntaxKind.TSingleLineComment, text, null);
		}

		public __InternalSyntaxToken TSingleLineComment(string text, object value)
		{
			return Token(null, MetaSyntaxKind.TSingleLineComment, text, value, null);
		}

		public __InternalSyntaxToken TMultiLineComment(string text)
		{
			return Token(null, MetaSyntaxKind.TMultiLineComment, text, null);
		}

		public __InternalSyntaxToken TMultiLineComment(string text, object value)
		{
			return Token(null, MetaSyntaxKind.TMultiLineComment, text, value, null);
		}

		public __InternalSyntaxToken TInvalidToken(string text)
		{
			return Token(null, MetaSyntaxKind.TInvalidToken, text, null);
		}

		public __InternalSyntaxToken TInvalidToken(string text, object value)
		{
			return Token(null, MetaSyntaxKind.TInvalidToken, text, value, null);
		}

internal MainGreen Main(__InternalSyntaxToken kNamespace, QualifierGreen name, __InternalSyntaxToken tSemicolon, global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<UsingGreen> usingList, DeclarationsGreen declarations, __InternalSyntaxToken endOfFileToken)
{
#if DEBUG
			if (kNamespace is null) throw new __ArgumentNullException(nameof(kNamespace));
			if (kNamespace.RawKind != (int)MetaSyntaxKind.KNamespace) throw new __ArgumentException(nameof(kNamespace));
			if (name is null) throw new __ArgumentNullException(nameof(name));
			if (tSemicolon is null) throw new __ArgumentNullException(nameof(tSemicolon));
			if (tSemicolon.RawKind != (int)MetaSyntaxKind.TSemicolon) throw new __ArgumentException(nameof(tSemicolon));
			if (declarations is null) throw new __ArgumentNullException(nameof(declarations));
			if (endOfFileToken is null) throw new __ArgumentNullException(nameof(endOfFileToken));
			if (endOfFileToken.RawKind != (int)__InternalSyntaxKind.Eof) throw new __ArgumentException(nameof(endOfFileToken));
#endif
			return new MainGreen(MetaSyntaxKind.Main, kNamespace, name, tSemicolon, usingList.Node, declarations, endOfFileToken);
		}

internal UsingGreen Using(__InternalSyntaxToken kUsing, QualifierGreen namespaces, __InternalSyntaxToken tSemicolon)
{
#if DEBUG
			if (kUsing is null) throw new __ArgumentNullException(nameof(kUsing));
			if (kUsing.RawKind != (int)MetaSyntaxKind.KUsing) throw new __ArgumentException(nameof(kUsing));
			if (namespaces is null) throw new __ArgumentNullException(nameof(namespaces));
			if (tSemicolon is null) throw new __ArgumentNullException(nameof(tSemicolon));
			if (tSemicolon.RawKind != (int)MetaSyntaxKind.TSemicolon) throw new __ArgumentException(nameof(tSemicolon));
#endif
			int hash;
			var cached = __SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.Using, kUsing, namespaces, tSemicolon, out hash);
			if (cached != null) return (UsingGreen)cached;
		
			var result = new UsingGreen(MetaSyntaxKind.Using, kUsing, namespaces, tSemicolon);
			if (hash >= 0)
			{
				__SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

internal DeclarationsGreen Declarations(global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<MetaDeclarationGreen> declarations)
{
#if DEBUG
#endif
			int hash;
			var cached = __SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.Declarations, declarations.Node, out hash);
			if (cached != null) return (DeclarationsGreen)cached;
		
			var result = new DeclarationsGreen(MetaSyntaxKind.Declarations, declarations.Node);
			if (hash >= 0)
			{
				__SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

internal MetaModelGreen MetaModel(__InternalSyntaxToken kMetamodel, NameGreen name, __InternalSyntaxToken tSemicolon)
{
#if DEBUG
			if (kMetamodel is null) throw new __ArgumentNullException(nameof(kMetamodel));
			if (kMetamodel.RawKind != (int)MetaSyntaxKind.KMetamodel) throw new __ArgumentException(nameof(kMetamodel));
			if (name is null) throw new __ArgumentNullException(nameof(name));
			if (tSemicolon is null) throw new __ArgumentNullException(nameof(tSemicolon));
			if (tSemicolon.RawKind != (int)MetaSyntaxKind.TSemicolon) throw new __ArgumentException(nameof(tSemicolon));
#endif
			int hash;
			var cached = __SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.MetaModel, kMetamodel, name, tSemicolon, out hash);
			if (cached != null) return (MetaModelGreen)cached;
		
			var result = new MetaModelGreen(MetaSyntaxKind.MetaModel, kMetamodel, name, tSemicolon);
			if (hash >= 0)
			{
				__SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

internal MetaConstantGreen MetaConstant(__InternalSyntaxToken kConst, TypeReferenceGreen type, NameGreen name, __InternalSyntaxToken tSemicolon)
{
#if DEBUG
			if (kConst is null) throw new __ArgumentNullException(nameof(kConst));
			if (kConst.RawKind != (int)MetaSyntaxKind.KConst) throw new __ArgumentException(nameof(kConst));
			if (type is null) throw new __ArgumentNullException(nameof(type));
			if (name is null) throw new __ArgumentNullException(nameof(name));
			if (tSemicolon is null) throw new __ArgumentNullException(nameof(tSemicolon));
			if (tSemicolon.RawKind != (int)MetaSyntaxKind.TSemicolon) throw new __ArgumentException(nameof(tSemicolon));
#endif
			return new MetaConstantGreen(MetaSyntaxKind.MetaConstant, kConst, type, name, tSemicolon);
		}

internal MetaEnumGreen MetaEnum(__InternalSyntaxToken kEnum, NameGreen name, EnumBodyGreen enumBody)
{
#if DEBUG
			if (kEnum is null) throw new __ArgumentNullException(nameof(kEnum));
			if (kEnum.RawKind != (int)MetaSyntaxKind.KEnum) throw new __ArgumentException(nameof(kEnum));
			if (name is null) throw new __ArgumentNullException(nameof(name));
			if (enumBody is null) throw new __ArgumentNullException(nameof(enumBody));
#endif
			int hash;
			var cached = __SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.MetaEnum, kEnum, name, enumBody, out hash);
			if (cached != null) return (MetaEnumGreen)cached;
		
			var result = new MetaEnumGreen(MetaSyntaxKind.MetaEnum, kEnum, name, enumBody);
			if (hash >= 0)
			{
				__SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

internal MetaClassGreen MetaClass(__InternalSyntaxToken isAbstract, __InternalSyntaxToken kClass, ClassNameGreen className, BaseClassesGreen baseClasses, ClassBodyGreen classBody)
{
#if DEBUG
			if (isAbstract is not null && (isAbstract.RawKind != (int)MetaSyntaxKind.KAbstract)) throw new __ArgumentException(nameof(isAbstract));
			if (kClass is null) throw new __ArgumentNullException(nameof(kClass));
			if (kClass.RawKind != (int)MetaSyntaxKind.KClass) throw new __ArgumentException(nameof(kClass));
			if (className is null) throw new __ArgumentNullException(nameof(className));
			if (classBody is null) throw new __ArgumentNullException(nameof(classBody));
#endif
			return new MetaClassGreen(MetaSyntaxKind.MetaClass, isAbstract, kClass, className, baseClasses, classBody);
		}

internal EnumBodyGreen EnumBody(__InternalSyntaxToken tLBrace, global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<MetaEnumLiteralGreen> enumLiterals, __InternalSyntaxToken tRBrace)
{
#if DEBUG
			if (tLBrace is null) throw new __ArgumentNullException(nameof(tLBrace));
			if (tLBrace.RawKind != (int)MetaSyntaxKind.TLBrace) throw new __ArgumentException(nameof(tLBrace));
			if (tRBrace is null) throw new __ArgumentNullException(nameof(tRBrace));
			if (tRBrace.RawKind != (int)MetaSyntaxKind.TRBrace) throw new __ArgumentException(nameof(tRBrace));
#endif
			int hash;
			var cached = __SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.EnumBody, tLBrace, enumLiterals.Node, tRBrace, out hash);
			if (cached != null) return (EnumBodyGreen)cached;
		
			var result = new EnumBodyGreen(MetaSyntaxKind.EnumBody, tLBrace, enumLiterals.Node, tRBrace);
			if (hash >= 0)
			{
				__SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

internal MetaEnumLiteralGreen MetaEnumLiteral(NameGreen name)
{
#if DEBUG
			if (name is null) throw new __ArgumentNullException(nameof(name));
#endif
			int hash;
			var cached = __SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.MetaEnumLiteral, name, out hash);
			if (cached != null) return (MetaEnumLiteralGreen)cached;
		
			var result = new MetaEnumLiteralGreen(MetaSyntaxKind.MetaEnumLiteral, name);
			if (hash >= 0)
			{
				__SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

internal ClassNameAlt1Green ClassNameAlt1(IdentifierGreen identifier, __InternalSyntaxToken tDollar, IdentifierGreen symbolType)
{
#if DEBUG
			if (tDollar is null) throw new __ArgumentNullException(nameof(tDollar));
			if (tDollar.RawKind != (int)MetaSyntaxKind.TDollar) throw new __ArgumentException(nameof(tDollar));
			if (symbolType is null) throw new __ArgumentNullException(nameof(symbolType));
#endif
			int hash;
			var cached = __SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.ClassNameAlt1, identifier, tDollar, symbolType, out hash);
			if (cached != null) return (ClassNameAlt1Green)cached;
		
			var result = new ClassNameAlt1Green(MetaSyntaxKind.ClassNameAlt1, identifier, tDollar, symbolType);
			if (hash >= 0)
			{
				__SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

internal ClassNameAlt2Green ClassNameAlt2(IdentifierGreen identifier)
{
#if DEBUG
			if (identifier is null) throw new __ArgumentNullException(nameof(identifier));
#endif
			int hash;
			var cached = __SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.ClassNameAlt2, identifier, out hash);
			if (cached != null) return (ClassNameAlt2Green)cached;
		
			var result = new ClassNameAlt2Green(MetaSyntaxKind.ClassNameAlt2, identifier);
			if (hash >= 0)
			{
				__SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

internal BaseClassesGreen BaseClasses(__InternalSyntaxToken tColon, global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<QualifierGreen> baseTypes)
{
#if DEBUG
			if (tColon is null) throw new __ArgumentNullException(nameof(tColon));
			if (tColon.RawKind != (int)MetaSyntaxKind.TColon) throw new __ArgumentException(nameof(tColon));
#endif
			int hash;
			var cached = __SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.BaseClasses, tColon, baseTypes.Node, out hash);
			if (cached != null) return (BaseClassesGreen)cached;
		
			var result = new BaseClassesGreen(MetaSyntaxKind.BaseClasses, tColon, baseTypes.Node);
			if (hash >= 0)
			{
				__SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

internal ClassBodyGreen ClassBody(__InternalSyntaxToken tLBrace, global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<ClassMemberGreen> classMemberList, __InternalSyntaxToken tRBrace)
{
#if DEBUG
			if (tLBrace is null) throw new __ArgumentNullException(nameof(tLBrace));
			if (tLBrace.RawKind != (int)MetaSyntaxKind.TLBrace) throw new __ArgumentException(nameof(tLBrace));
			if (tRBrace is null) throw new __ArgumentNullException(nameof(tRBrace));
			if (tRBrace.RawKind != (int)MetaSyntaxKind.TRBrace) throw new __ArgumentException(nameof(tRBrace));
#endif
			int hash;
			var cached = __SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.ClassBody, tLBrace, classMemberList.Node, tRBrace, out hash);
			if (cached != null) return (ClassBodyGreen)cached;
		
			var result = new ClassBodyGreen(MetaSyntaxKind.ClassBody, tLBrace, classMemberList.Node, tRBrace);
			if (hash >= 0)
			{
				__SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

internal ClassMemberAlt1Green ClassMemberAlt1(MetaPropertyGreen properties)
{
#if DEBUG
			if (properties is null) throw new __ArgumentNullException(nameof(properties));
#endif
			int hash;
			var cached = __SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.ClassMemberAlt1, properties, out hash);
			if (cached != null) return (ClassMemberAlt1Green)cached;
		
			var result = new ClassMemberAlt1Green(MetaSyntaxKind.ClassMemberAlt1, properties);
			if (hash >= 0)
			{
				__SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

internal ClassMemberAlt2Green ClassMemberAlt2(MetaOperationGreen operations)
{
#if DEBUG
			if (operations is null) throw new __ArgumentNullException(nameof(operations));
#endif
			int hash;
			var cached = __SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.ClassMemberAlt2, operations, out hash);
			if (cached != null) return (ClassMemberAlt2Green)cached;
		
			var result = new ClassMemberAlt2Green(MetaSyntaxKind.ClassMemberAlt2, operations);
			if (hash >= 0)
			{
				__SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

internal MetaPropertyGreen MetaProperty(__InternalSyntaxToken tokens, TypeReferenceGreen type, PropertyNameGreen propertyName, global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<MetaPropertyBlock1Green> block, __InternalSyntaxToken tSemicolon)
{
#if DEBUG
			if (tokens is not null && (tokens.RawKind != (int)MetaSyntaxKind.KContains && tokens.RawKind != (int)MetaSyntaxKind.KDerived)) throw new __ArgumentException(nameof(tokens));
			if (type is null) throw new __ArgumentNullException(nameof(type));
			if (propertyName is null) throw new __ArgumentNullException(nameof(propertyName));
			if (tSemicolon is null) throw new __ArgumentNullException(nameof(tSemicolon));
			if (tSemicolon.RawKind != (int)MetaSyntaxKind.TSemicolon) throw new __ArgumentException(nameof(tSemicolon));
#endif
			return new MetaPropertyGreen(MetaSyntaxKind.MetaProperty, tokens, type, propertyName, block.Node, tSemicolon);
		}

internal PropertyNameAlt1Green PropertyNameAlt1(IdentifierGreen identifier, __InternalSyntaxToken tDollar, IdentifierGreen symbolProperty)
{
#if DEBUG
			if (tDollar is null) throw new __ArgumentNullException(nameof(tDollar));
			if (tDollar.RawKind != (int)MetaSyntaxKind.TDollar) throw new __ArgumentException(nameof(tDollar));
			if (symbolProperty is null) throw new __ArgumentNullException(nameof(symbolProperty));
#endif
			int hash;
			var cached = __SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.PropertyNameAlt1, identifier, tDollar, symbolProperty, out hash);
			if (cached != null) return (PropertyNameAlt1Green)cached;
		
			var result = new PropertyNameAlt1Green(MetaSyntaxKind.PropertyNameAlt1, identifier, tDollar, symbolProperty);
			if (hash >= 0)
			{
				__SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

internal PropertyNameAlt2Green PropertyNameAlt2(IdentifierGreen identifier)
{
#if DEBUG
			if (identifier is null) throw new __ArgumentNullException(nameof(identifier));
#endif
			int hash;
			var cached = __SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.PropertyNameAlt2, identifier, out hash);
			if (cached != null) return (PropertyNameAlt2Green)cached;
		
			var result = new PropertyNameAlt2Green(MetaSyntaxKind.PropertyNameAlt2, identifier);
			if (hash >= 0)
			{
				__SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

internal MetaOperationGreen MetaOperation(TypeReferenceGreen returnType, NameGreen name, __InternalSyntaxToken tLParen, global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<MetaParameterGreen> parameterList, __InternalSyntaxToken tRParen, __InternalSyntaxToken tSemicolon)
{
#if DEBUG
			if (returnType is null) throw new __ArgumentNullException(nameof(returnType));
			if (name is null) throw new __ArgumentNullException(nameof(name));
			if (tLParen is null) throw new __ArgumentNullException(nameof(tLParen));
			if (tLParen.RawKind != (int)MetaSyntaxKind.TLParen) throw new __ArgumentException(nameof(tLParen));
			if (tRParen is null) throw new __ArgumentNullException(nameof(tRParen));
			if (tRParen.RawKind != (int)MetaSyntaxKind.TRParen) throw new __ArgumentException(nameof(tRParen));
			if (tSemicolon is null) throw new __ArgumentNullException(nameof(tSemicolon));
			if (tSemicolon.RawKind != (int)MetaSyntaxKind.TSemicolon) throw new __ArgumentException(nameof(tSemicolon));
#endif
			return new MetaOperationGreen(MetaSyntaxKind.MetaOperation, returnType, name, tLParen, parameterList.Node, tRParen, tSemicolon);
		}

internal MetaParameterGreen MetaParameter(TypeReferenceGreen type, NameGreen name)
{
#if DEBUG
			if (type is null) throw new __ArgumentNullException(nameof(type));
			if (name is null) throw new __ArgumentNullException(nameof(name));
#endif
			int hash;
			var cached = __SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.MetaParameter, type, name, out hash);
			if (cached != null) return (MetaParameterGreen)cached;
		
			var result = new MetaParameterGreen(MetaSyntaxKind.MetaParameter, type, name);
			if (hash >= 0)
			{
				__SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

internal TypeReferenceTokensGreen TypeReferenceTokens(__InternalSyntaxToken token)
{
#if DEBUG
			if (token is null) throw new __ArgumentNullException(nameof(token));
			if (token.RawKind != (int)MetaSyntaxKind.KBool && token.RawKind != (int)MetaSyntaxKind.KInt && token.RawKind != (int)MetaSyntaxKind.KString && token.RawKind != (int)MetaSyntaxKind.KType && token.RawKind != (int)MetaSyntaxKind.KSymbol && token.RawKind != (int)MetaSyntaxKind.KObject && token.RawKind != (int)MetaSyntaxKind.KVoid) throw new __ArgumentException(nameof(token));
#endif
			int hash;
			var cached = __SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.TypeReferenceTokens, token, out hash);
			if (cached != null) return (TypeReferenceTokensGreen)cached;
		
			var result = new TypeReferenceTokensGreen(MetaSyntaxKind.TypeReferenceTokens, token);
			if (hash >= 0)
			{
				__SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

internal SimpleTypeReferenceAlt2Green SimpleTypeReferenceAlt2(QualifierGreen qualifier)
{
#if DEBUG
			if (qualifier is null) throw new __ArgumentNullException(nameof(qualifier));
#endif
			int hash;
			var cached = __SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.SimpleTypeReferenceAlt2, qualifier, out hash);
			if (cached != null) return (SimpleTypeReferenceAlt2Green)cached;
		
			var result = new SimpleTypeReferenceAlt2Green(MetaSyntaxKind.SimpleTypeReferenceAlt2, qualifier);
			if (hash >= 0)
			{
				__SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

internal MetaArrayTypeGreen MetaArrayType(TypeReferenceGreen itemType, __InternalSyntaxToken tLBracket, __InternalSyntaxToken tRBracket)
{
#if DEBUG
			if (itemType is null) throw new __ArgumentNullException(nameof(itemType));
			if (tLBracket is null) throw new __ArgumentNullException(nameof(tLBracket));
			if (tLBracket.RawKind != (int)MetaSyntaxKind.TLBracket) throw new __ArgumentException(nameof(tLBracket));
			if (tRBracket is null) throw new __ArgumentNullException(nameof(tRBracket));
			if (tRBracket.RawKind != (int)MetaSyntaxKind.TRBracket) throw new __ArgumentException(nameof(tRBracket));
#endif
			int hash;
			var cached = __SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.MetaArrayType, itemType, tLBracket, tRBracket, out hash);
			if (cached != null) return (MetaArrayTypeGreen)cached;
		
			var result = new MetaArrayTypeGreen(MetaSyntaxKind.MetaArrayType, itemType, tLBracket, tRBracket);
			if (hash >= 0)
			{
				__SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

internal MetaNullableTypeGreen MetaNullableType(TypeReferenceGreen innerType, __InternalSyntaxToken tQuestion)
{
#if DEBUG
			if (innerType is null) throw new __ArgumentNullException(nameof(innerType));
			if (tQuestion is null) throw new __ArgumentNullException(nameof(tQuestion));
			if (tQuestion.RawKind != (int)MetaSyntaxKind.TQuestion) throw new __ArgumentException(nameof(tQuestion));
#endif
			int hash;
			var cached = __SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.MetaNullableType, innerType, tQuestion, out hash);
			if (cached != null) return (MetaNullableTypeGreen)cached;
		
			var result = new MetaNullableTypeGreen(MetaSyntaxKind.MetaNullableType, innerType, tQuestion);
			if (hash >= 0)
			{
				__SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

internal NameGreen Name(IdentifierGreen identifier)
{
#if DEBUG
			if (identifier is null) throw new __ArgumentNullException(nameof(identifier));
#endif
			int hash;
			var cached = __SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.Name, identifier, out hash);
			if (cached != null) return (NameGreen)cached;
		
			var result = new NameGreen(MetaSyntaxKind.Name, identifier);
			if (hash >= 0)
			{
				__SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

internal QualifierGreen Qualifier(global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<IdentifierGreen> qualifier)
{
#if DEBUG
#endif
			int hash;
			var cached = __SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.Qualifier, qualifier.Node, out hash);
			if (cached != null) return (QualifierGreen)cached;
		
			var result = new QualifierGreen(MetaSyntaxKind.Qualifier, qualifier.Node);
			if (hash >= 0)
			{
				__SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

internal IdentifierGreen Identifier(__InternalSyntaxToken token)
{
#if DEBUG
			if (token is null) throw new __ArgumentNullException(nameof(token));
			if (token.RawKind != (int)MetaSyntaxKind.TIdentifier && token.RawKind != (int)MetaSyntaxKind.TVerbatimIdentifier) throw new __ArgumentException(nameof(token));
#endif
			int hash;
			var cached = __SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.Identifier, token, out hash);
			if (cached != null) return (IdentifierGreen)cached;
		
			var result = new IdentifierGreen(MetaSyntaxKind.Identifier, token);
			if (hash >= 0)
			{
				__SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

internal EnumBodyEnumLiteralsBlockGreen EnumBodyEnumLiteralsBlock(__InternalSyntaxToken tComma, MetaEnumLiteralGreen literals)
{
#if DEBUG
			if (tComma is null) throw new __ArgumentNullException(nameof(tComma));
			if (tComma.RawKind != (int)MetaSyntaxKind.TComma) throw new __ArgumentException(nameof(tComma));
			if (literals is null) throw new __ArgumentNullException(nameof(literals));
#endif
			int hash;
			var cached = __SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.EnumBodyEnumLiteralsBlock, tComma, literals, out hash);
			if (cached != null) return (EnumBodyEnumLiteralsBlockGreen)cached;
		
			var result = new EnumBodyEnumLiteralsBlockGreen(MetaSyntaxKind.EnumBodyEnumLiteralsBlock, tComma, literals);
			if (hash >= 0)
			{
				__SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

internal BaseClassesBaseTypesBlockGreen BaseClassesBaseTypesBlock(__InternalSyntaxToken tComma, QualifierGreen baseTypes)
{
#if DEBUG
			if (tComma is null) throw new __ArgumentNullException(nameof(tComma));
			if (tComma.RawKind != (int)MetaSyntaxKind.TComma) throw new __ArgumentException(nameof(tComma));
			if (baseTypes is null) throw new __ArgumentNullException(nameof(baseTypes));
#endif
			int hash;
			var cached = __SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.BaseClassesBaseTypesBlock, tComma, baseTypes, out hash);
			if (cached != null) return (BaseClassesBaseTypesBlockGreen)cached;
		
			var result = new BaseClassesBaseTypesBlockGreen(MetaSyntaxKind.BaseClassesBaseTypesBlock, tComma, baseTypes);
			if (hash >= 0)
			{
				__SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

internal PropertyOppositeGreen PropertyOpposite(__InternalSyntaxToken kOpposite, global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<QualifierGreen> oppositeProperties)
{
#if DEBUG
			if (kOpposite is null) throw new __ArgumentNullException(nameof(kOpposite));
			if (kOpposite.RawKind != (int)MetaSyntaxKind.KOpposite) throw new __ArgumentException(nameof(kOpposite));
#endif
			int hash;
			var cached = __SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.PropertyOpposite, kOpposite, oppositeProperties.Node, out hash);
			if (cached != null) return (PropertyOppositeGreen)cached;
		
			var result = new PropertyOppositeGreen(MetaSyntaxKind.PropertyOpposite, kOpposite, oppositeProperties.Node);
			if (hash >= 0)
			{
				__SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

internal PropertySubsetsGreen PropertySubsets(__InternalSyntaxToken kSubsets, global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<QualifierGreen> subsettedProperties)
{
#if DEBUG
			if (kSubsets is null) throw new __ArgumentNullException(nameof(kSubsets));
			if (kSubsets.RawKind != (int)MetaSyntaxKind.KSubsets) throw new __ArgumentException(nameof(kSubsets));
#endif
			int hash;
			var cached = __SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.PropertySubsets, kSubsets, subsettedProperties.Node, out hash);
			if (cached != null) return (PropertySubsetsGreen)cached;
		
			var result = new PropertySubsetsGreen(MetaSyntaxKind.PropertySubsets, kSubsets, subsettedProperties.Node);
			if (hash >= 0)
			{
				__SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

internal PropertyRedefinesGreen PropertyRedefines(__InternalSyntaxToken kRedefines, global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<QualifierGreen> redefinedProperties)
{
#if DEBUG
			if (kRedefines is null) throw new __ArgumentNullException(nameof(kRedefines));
			if (kRedefines.RawKind != (int)MetaSyntaxKind.KRedefines) throw new __ArgumentException(nameof(kRedefines));
#endif
			int hash;
			var cached = __SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.PropertyRedefines, kRedefines, redefinedProperties.Node, out hash);
			if (cached != null) return (PropertyRedefinesGreen)cached;
		
			var result = new PropertyRedefinesGreen(MetaSyntaxKind.PropertyRedefines, kRedefines, redefinedProperties.Node);
			if (hash >= 0)
			{
				__SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

internal PropertyOppositeOppositePropertiesBlockGreen PropertyOppositeOppositePropertiesBlock(__InternalSyntaxToken tComma, QualifierGreen oppositeProperties)
{
#if DEBUG
			if (tComma is null) throw new __ArgumentNullException(nameof(tComma));
			if (tComma.RawKind != (int)MetaSyntaxKind.TComma) throw new __ArgumentException(nameof(tComma));
			if (oppositeProperties is null) throw new __ArgumentNullException(nameof(oppositeProperties));
#endif
			int hash;
			var cached = __SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.PropertyOppositeOppositePropertiesBlock, tComma, oppositeProperties, out hash);
			if (cached != null) return (PropertyOppositeOppositePropertiesBlockGreen)cached;
		
			var result = new PropertyOppositeOppositePropertiesBlockGreen(MetaSyntaxKind.PropertyOppositeOppositePropertiesBlock, tComma, oppositeProperties);
			if (hash >= 0)
			{
				__SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

internal PropertySubsetsSubsettedPropertiesBlockGreen PropertySubsetsSubsettedPropertiesBlock(__InternalSyntaxToken tComma, QualifierGreen subsettedProperties)
{
#if DEBUG
			if (tComma is null) throw new __ArgumentNullException(nameof(tComma));
			if (tComma.RawKind != (int)MetaSyntaxKind.TComma) throw new __ArgumentException(nameof(tComma));
			if (subsettedProperties is null) throw new __ArgumentNullException(nameof(subsettedProperties));
#endif
			int hash;
			var cached = __SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.PropertySubsetsSubsettedPropertiesBlock, tComma, subsettedProperties, out hash);
			if (cached != null) return (PropertySubsetsSubsettedPropertiesBlockGreen)cached;
		
			var result = new PropertySubsetsSubsettedPropertiesBlockGreen(MetaSyntaxKind.PropertySubsetsSubsettedPropertiesBlock, tComma, subsettedProperties);
			if (hash >= 0)
			{
				__SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

internal PropertyRedefinesRedefinedPropertiesBlockGreen PropertyRedefinesRedefinedPropertiesBlock(__InternalSyntaxToken tComma, QualifierGreen redefinedProperties)
{
#if DEBUG
			if (tComma is null) throw new __ArgumentNullException(nameof(tComma));
			if (tComma.RawKind != (int)MetaSyntaxKind.TComma) throw new __ArgumentException(nameof(tComma));
			if (redefinedProperties is null) throw new __ArgumentNullException(nameof(redefinedProperties));
#endif
			int hash;
			var cached = __SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.PropertyRedefinesRedefinedPropertiesBlock, tComma, redefinedProperties, out hash);
			if (cached != null) return (PropertyRedefinesRedefinedPropertiesBlockGreen)cached;
		
			var result = new PropertyRedefinesRedefinedPropertiesBlockGreen(MetaSyntaxKind.PropertyRedefinesRedefinedPropertiesBlock, tComma, redefinedProperties);
			if (hash >= 0)
			{
				__SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

internal MetaOperationParameterListBlockGreen MetaOperationParameterListBlock(__InternalSyntaxToken tComma, MetaParameterGreen parameters)
{
#if DEBUG
			if (tComma is null) throw new __ArgumentNullException(nameof(tComma));
			if (tComma.RawKind != (int)MetaSyntaxKind.TComma) throw new __ArgumentException(nameof(tComma));
			if (parameters is null) throw new __ArgumentNullException(nameof(parameters));
#endif
			int hash;
			var cached = __SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.MetaOperationParameterListBlock, tComma, parameters, out hash);
			if (cached != null) return (MetaOperationParameterListBlockGreen)cached;
		
			var result = new MetaOperationParameterListBlockGreen(MetaSyntaxKind.MetaOperationParameterListBlock, tComma, parameters);
			if (hash >= 0)
			{
				__SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

internal QualifierQualifierBlockGreen QualifierQualifierBlock(__InternalSyntaxToken tDot, IdentifierGreen identifier)
{
#if DEBUG
			if (tDot is null) throw new __ArgumentNullException(nameof(tDot));
			if (tDot.RawKind != (int)MetaSyntaxKind.TDot) throw new __ArgumentException(nameof(tDot));
			if (identifier is null) throw new __ArgumentNullException(nameof(identifier));
#endif
			int hash;
			var cached = __SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.QualifierQualifierBlock, tDot, identifier, out hash);
			if (cached != null) return (QualifierQualifierBlockGreen)cached;
		
			var result = new QualifierQualifierBlockGreen(MetaSyntaxKind.QualifierQualifierBlock, tDot, identifier);
			if (hash >= 0)
			{
				__SyntaxNodeCache.AddNode(result, hash);
			}
		
			return result;
		}

	}
}
