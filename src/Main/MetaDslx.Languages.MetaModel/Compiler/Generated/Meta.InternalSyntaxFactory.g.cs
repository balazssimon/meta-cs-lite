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

        internal MainGreen Main(__InternalSyntaxToken kNamespace, QualifierGreen qualifier, global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<UsingGreen> usingList, MainBlock1Green block, __InternalSyntaxToken endOfFileToken)
        {
            #if DEBUG
                if (kNamespace is null) throw new __ArgumentNullException(nameof(kNamespace));
                if (kNamespace.RawKind != (int)MetaSyntaxKind.KNamespace) throw new __ArgumentException(nameof(kNamespace));
                if (qualifier is null) throw new __ArgumentNullException(nameof(qualifier));
                if (block is null) throw new __ArgumentNullException(nameof(block));
                if (endOfFileToken is null) throw new __ArgumentNullException(nameof(endOfFileToken));
                if (endOfFileToken.RawKind != (int)__InternalSyntaxKind.Eof) throw new __ArgumentException(nameof(endOfFileToken));
            #endif
            return new MainGreen(MetaSyntaxKind.Main, kNamespace, qualifier, usingList.Node, block, endOfFileToken);
        }
        internal UsingGreen Using(__InternalSyntaxToken kUsing, QualifierGreen namespaces)
        {
            #if DEBUG
                if (kUsing is null) throw new __ArgumentNullException(nameof(kUsing));
                if (kUsing.RawKind != (int)MetaSyntaxKind.KUsing) throw new __ArgumentException(nameof(kUsing));
                if (namespaces is null) throw new __ArgumentNullException(nameof(namespaces));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.Using, kUsing, namespaces, out hash);
            if (cached != null) return (UsingGreen)cached;
        
            var result = new UsingGreen(MetaSyntaxKind.Using, kUsing, namespaces);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal MetaModelGreen MetaModel(__InternalSyntaxToken kMetamodel, NameGreen name, MetaModelBlock1Green block)
        {
            #if DEBUG
                if (kMetamodel is null) throw new __ArgumentNullException(nameof(kMetamodel));
                if (kMetamodel.RawKind != (int)MetaSyntaxKind.KMetamodel) throw new __ArgumentException(nameof(kMetamodel));
                if (name is null) throw new __ArgumentNullException(nameof(name));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.MetaModel, kMetamodel, name, block, out hash);
            if (cached != null) return (MetaModelGreen)cached;
        
            var result = new MetaModelGreen(MetaSyntaxKind.MetaModel, kMetamodel, name, block);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal MetaDeclarationAlt1Green MetaDeclarationAlt1(MetaConstantGreen metaConstant)
        {
            #if DEBUG
                if (metaConstant is null) throw new __ArgumentNullException(nameof(metaConstant));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.MetaDeclarationAlt1, metaConstant, out hash);
            if (cached != null) return (MetaDeclarationAlt1Green)cached;
        
            var result = new MetaDeclarationAlt1Green(MetaSyntaxKind.MetaDeclarationAlt1, metaConstant);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal MetaDeclarationAlt2Green MetaDeclarationAlt2(MetaEnumGreen metaEnum)
        {
            #if DEBUG
                if (metaEnum is null) throw new __ArgumentNullException(nameof(metaEnum));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.MetaDeclarationAlt2, metaEnum, out hash);
            if (cached != null) return (MetaDeclarationAlt2Green)cached;
        
            var result = new MetaDeclarationAlt2Green(MetaSyntaxKind.MetaDeclarationAlt2, metaEnum);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal MetaDeclarationAlt3Green MetaDeclarationAlt3(MetaClassGreen metaClass)
        {
            #if DEBUG
                if (metaClass is null) throw new __ArgumentNullException(nameof(metaClass));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.MetaDeclarationAlt3, metaClass, out hash);
            if (cached != null) return (MetaDeclarationAlt3Green)cached;
        
            var result = new MetaDeclarationAlt3Green(MetaSyntaxKind.MetaDeclarationAlt3, metaClass);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal MetaConstantGreen MetaConstant(__InternalSyntaxToken kConst, MetaTypeReferenceGreen type, NameGreen name)
        {
            #if DEBUG
                if (kConst is null) throw new __ArgumentNullException(nameof(kConst));
                if (kConst.RawKind != (int)MetaSyntaxKind.KConst) throw new __ArgumentException(nameof(kConst));
                if (type is null) throw new __ArgumentNullException(nameof(type));
                if (name is null) throw new __ArgumentNullException(nameof(name));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.MetaConstant, kConst, type, name, out hash);
            if (cached != null) return (MetaConstantGreen)cached;
        
            var result = new MetaConstantGreen(MetaSyntaxKind.MetaConstant, kConst, type, name);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal MetaEnumGreen MetaEnum(__InternalSyntaxToken kEnum, NameGreen name, MetaEnumBlock1Green block)
        {
            #if DEBUG
                if (kEnum is null) throw new __ArgumentNullException(nameof(kEnum));
                if (kEnum.RawKind != (int)MetaSyntaxKind.KEnum) throw new __ArgumentException(nameof(kEnum));
                if (name is null) throw new __ArgumentNullException(nameof(name));
                if (block is null) throw new __ArgumentNullException(nameof(block));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.MetaEnum, kEnum, name, block, out hash);
            if (cached != null) return (MetaEnumGreen)cached;
        
            var result = new MetaEnumGreen(MetaSyntaxKind.MetaEnum, kEnum, name, block);
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
        internal MetaClassGreen MetaClass(__InternalSyntaxToken isAbstract, __InternalSyntaxToken kClass, MetaClassBlock1Green block1, MetaClassBlock2Green block2, MetaClassBlock3Green block3)
        {
            #if DEBUG
                if (isAbstract is not null && (isAbstract.RawKind != (int)MetaSyntaxKind.KAbstract)) throw new __ArgumentException(nameof(isAbstract));
                if (kClass is null) throw new __ArgumentNullException(nameof(kClass));
                if (kClass.RawKind != (int)MetaSyntaxKind.KClass) throw new __ArgumentException(nameof(kClass));
                if (block1 is null) throw new __ArgumentNullException(nameof(block1));
                if (block3 is null) throw new __ArgumentNullException(nameof(block3));
            #endif
            return new MetaClassGreen(MetaSyntaxKind.MetaClass, isAbstract, kClass, block1, block2, block3);
        }
        internal MetaPropertyGreen MetaProperty(MetaPropertyBlock1Green block1, MetaTypeReferenceGreen type, MetaPropertyBlock2Green block2, MetaPropertyBlock3Green block3, global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<MetaPropertyBlock4Green> block4)
        {
            #if DEBUG
                if (type is null) throw new __ArgumentNullException(nameof(type));
                if (block2 is null) throw new __ArgumentNullException(nameof(block2));
            #endif
            return new MetaPropertyGreen(MetaSyntaxKind.MetaProperty, block1, type, block2, block3, block4.Node);
        }
        internal MetaOperationGreen MetaOperation(MetaTypeReferenceGreen returnType, NameGreen name, __InternalSyntaxToken tLParen, MetaOperationBlock1Green block, __InternalSyntaxToken tRParen)
        {
            #if DEBUG
                if (returnType is null) throw new __ArgumentNullException(nameof(returnType));
                if (name is null) throw new __ArgumentNullException(nameof(name));
                if (tLParen is null) throw new __ArgumentNullException(nameof(tLParen));
                if (tLParen.RawKind != (int)MetaSyntaxKind.TLParen) throw new __ArgumentException(nameof(tLParen));
                if (tRParen is null) throw new __ArgumentNullException(nameof(tRParen));
                if (tRParen.RawKind != (int)MetaSyntaxKind.TRParen) throw new __ArgumentException(nameof(tRParen));
            #endif
            return new MetaOperationGreen(MetaSyntaxKind.MetaOperation, returnType, name, tLParen, block, tRParen);
        }
        internal MetaParameterGreen MetaParameter(MetaTypeReferenceGreen type, NameGreen name)
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
        internal SimpleTypeReferenceGreen SimpleTypeReference(TypeReferenceGreen typeReference)
        {
            #if DEBUG
                if (typeReference is null) throw new __ArgumentNullException(nameof(typeReference));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.SimpleTypeReference, typeReference, out hash);
            if (cached != null) return (SimpleTypeReferenceGreen)cached;
        
            var result = new SimpleTypeReferenceGreen(MetaSyntaxKind.SimpleTypeReference, typeReference);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal MetaArrayTypeGreen MetaArrayType(MetaTypeReferenceGreen itemType, __InternalSyntaxToken tLBracket, __InternalSyntaxToken tRBracket)
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
        internal MetaNullableTypeGreen MetaNullableType(MetaTypeReferenceGreen innerType, __InternalSyntaxToken tQuestion)
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
        internal TypeReferenceAlt1Green TypeReferenceAlt1(PrimitiveTypeGreen primitiveType)
        {
            #if DEBUG
                if (primitiveType is null) throw new __ArgumentNullException(nameof(primitiveType));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.TypeReferenceAlt1, primitiveType, out hash);
            if (cached != null) return (TypeReferenceAlt1Green)cached;
        
            var result = new TypeReferenceAlt1Green(MetaSyntaxKind.TypeReferenceAlt1, primitiveType);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal TypeReferenceAlt2Green TypeReferenceAlt2(QualifierGreen qualifier)
        {
            #if DEBUG
                if (qualifier is null) throw new __ArgumentNullException(nameof(qualifier));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.TypeReferenceAlt2, qualifier, out hash);
            if (cached != null) return (TypeReferenceAlt2Green)cached;
        
            var result = new TypeReferenceAlt2Green(MetaSyntaxKind.TypeReferenceAlt2, qualifier);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal PrimitiveTypeGreen PrimitiveType(__InternalSyntaxToken token)
        {
            #if DEBUG
                if (token is null) throw new __ArgumentNullException(nameof(token));
                if (token.RawKind != (int)MetaSyntaxKind.KObject && token.RawKind != (int)MetaSyntaxKind.KBool && token.RawKind != (int)MetaSyntaxKind.KChar && token.RawKind != (int)MetaSyntaxKind.KString && token.RawKind != (int)MetaSyntaxKind.KByte && token.RawKind != (int)MetaSyntaxKind.KSbyte && token.RawKind != (int)MetaSyntaxKind.KShort && token.RawKind != (int)MetaSyntaxKind.KUshort && token.RawKind != (int)MetaSyntaxKind.KInt && token.RawKind != (int)MetaSyntaxKind.KUint && token.RawKind != (int)MetaSyntaxKind.KLong && token.RawKind != (int)MetaSyntaxKind.KUlong && token.RawKind != (int)MetaSyntaxKind.KFloat && token.RawKind != (int)MetaSyntaxKind.KDouble && token.RawKind != (int)MetaSyntaxKind.KDecimal && token.RawKind != (int)MetaSyntaxKind.KType && token.RawKind != (int)MetaSyntaxKind.KSymbol && token.RawKind != (int)MetaSyntaxKind.KVoid) throw new __ArgumentException(nameof(token));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.PrimitiveType, token, out hash);
            if (cached != null) return (PrimitiveTypeGreen)cached;
        
            var result = new PrimitiveTypeGreen(MetaSyntaxKind.PrimitiveType, token);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal ValueAlt1Green ValueAlt1(__InternalSyntaxToken tString)
        {
            #if DEBUG
                if (tString is null) throw new __ArgumentNullException(nameof(tString));
                if (tString.RawKind != (int)MetaSyntaxKind.TString) throw new __ArgumentException(nameof(tString));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.ValueAlt1, tString, out hash);
            if (cached != null) return (ValueAlt1Green)cached;
        
            var result = new ValueAlt1Green(MetaSyntaxKind.ValueAlt1, tString);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal ValueAlt2Green ValueAlt2(__InternalSyntaxToken tInteger)
        {
            #if DEBUG
                if (tInteger is null) throw new __ArgumentNullException(nameof(tInteger));
                if (tInteger.RawKind != (int)MetaSyntaxKind.TInteger) throw new __ArgumentException(nameof(tInteger));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.ValueAlt2, tInteger, out hash);
            if (cached != null) return (ValueAlt2Green)cached;
        
            var result = new ValueAlt2Green(MetaSyntaxKind.ValueAlt2, tInteger);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal ValueAlt3Green ValueAlt3(__InternalSyntaxToken tDecimal)
        {
            #if DEBUG
                if (tDecimal is null) throw new __ArgumentNullException(nameof(tDecimal));
                if (tDecimal.RawKind != (int)MetaSyntaxKind.TDecimal) throw new __ArgumentException(nameof(tDecimal));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.ValueAlt3, tDecimal, out hash);
            if (cached != null) return (ValueAlt3Green)cached;
        
            var result = new ValueAlt3Green(MetaSyntaxKind.ValueAlt3, tDecimal);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal ValueAlt4Green ValueAlt4(TBooleanGreen tBoolean)
        {
            #if DEBUG
                if (tBoolean is null) throw new __ArgumentNullException(nameof(tBoolean));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.ValueAlt4, tBoolean, out hash);
            if (cached != null) return (ValueAlt4Green)cached;
        
            var result = new ValueAlt4Green(MetaSyntaxKind.ValueAlt4, tBoolean);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal ValueAlt5Green ValueAlt5(__InternalSyntaxToken kNull)
        {
            #if DEBUG
                if (kNull is null) throw new __ArgumentNullException(nameof(kNull));
                if (kNull.RawKind != (int)MetaSyntaxKind.KNull) throw new __ArgumentException(nameof(kNull));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.ValueAlt5, kNull, out hash);
            if (cached != null) return (ValueAlt5Green)cached;
        
            var result = new ValueAlt5Green(MetaSyntaxKind.ValueAlt5, kNull);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal ValueAlt6Green ValueAlt6(QualifierGreen qualifier)
        {
            #if DEBUG
                if (qualifier is null) throw new __ArgumentNullException(nameof(qualifier));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.ValueAlt6, qualifier, out hash);
            if (cached != null) return (ValueAlt6Green)cached;
        
            var result = new ValueAlt6Green(MetaSyntaxKind.ValueAlt6, qualifier);
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
        internal QualifierGreen Qualifier(global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<IdentifierGreen> identifier)
        {
            #if DEBUG
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.Qualifier, identifier.Node, out hash);
            if (cached != null) return (QualifierGreen)cached;
        
            var result = new QualifierGreen(MetaSyntaxKind.Qualifier, identifier.Node);
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
        internal TBooleanGreen TBoolean(__InternalSyntaxToken token)
        {
            #if DEBUG
                if (token is null) throw new __ArgumentNullException(nameof(token));
                if (token.RawKind != (int)MetaSyntaxKind.KTrue && token.RawKind != (int)MetaSyntaxKind.KFalse) throw new __ArgumentException(nameof(token));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.TBoolean, token, out hash);
            if (cached != null) return (TBooleanGreen)cached;
        
            var result = new TBooleanGreen(MetaSyntaxKind.TBoolean, token);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal MainBlock1Green MainBlock1(MetaModelGreen declarations1, global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<MetaDeclarationGreen> declarations2)
        {
            #if DEBUG
                if (declarations1 is null) throw new __ArgumentNullException(nameof(declarations1));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.MainBlock1, declarations1, declarations2.Node, out hash);
            if (cached != null) return (MainBlock1Green)cached;
        
            var result = new MainBlock1Green(MetaSyntaxKind.MainBlock1, declarations1, declarations2.Node);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal MetaModelBlock1Green MetaModelBlock1(__InternalSyntaxToken tEq, __InternalSyntaxToken uri)
        {
            #if DEBUG
                if (tEq is null) throw new __ArgumentNullException(nameof(tEq));
                if (tEq.RawKind != (int)MetaSyntaxKind.TEq) throw new __ArgumentException(nameof(tEq));
                if (uri is null) throw new __ArgumentNullException(nameof(uri));
                if (uri.RawKind != (int)MetaSyntaxKind.TString) throw new __ArgumentException(nameof(uri));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.MetaModelBlock1, tEq, uri, out hash);
            if (cached != null) return (MetaModelBlock1Green)cached;
        
            var result = new MetaModelBlock1Green(MetaSyntaxKind.MetaModelBlock1, tEq, uri);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal MetaEnumBlock1Green MetaEnumBlock1(__InternalSyntaxToken tLBrace, global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<MetaEnumLiteralGreen> literals, __InternalSyntaxToken tRBrace)
        {
            #if DEBUG
                if (tLBrace is null) throw new __ArgumentNullException(nameof(tLBrace));
                if (tLBrace.RawKind != (int)MetaSyntaxKind.TLBrace) throw new __ArgumentException(nameof(tLBrace));
                if (tRBrace is null) throw new __ArgumentNullException(nameof(tRBrace));
                if (tRBrace.RawKind != (int)MetaSyntaxKind.TRBrace) throw new __ArgumentException(nameof(tRBrace));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.MetaEnumBlock1, tLBrace, literals.Node, tRBrace, out hash);
            if (cached != null) return (MetaEnumBlock1Green)cached;
        
            var result = new MetaEnumBlock1Green(MetaSyntaxKind.MetaEnumBlock1, tLBrace, literals.Node, tRBrace);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal MetaEnumBlock1literalsBlockGreen MetaEnumBlock1literalsBlock(__InternalSyntaxToken tComma, MetaEnumLiteralGreen literals)
        {
            #if DEBUG
                if (tComma is null) throw new __ArgumentNullException(nameof(tComma));
                if (tComma.RawKind != (int)MetaSyntaxKind.TComma) throw new __ArgumentException(nameof(tComma));
                if (literals is null) throw new __ArgumentNullException(nameof(literals));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.MetaEnumBlock1literalsBlock, tComma, literals, out hash);
            if (cached != null) return (MetaEnumBlock1literalsBlockGreen)cached;
        
            var result = new MetaEnumBlock1literalsBlockGreen(MetaSyntaxKind.MetaEnumBlock1literalsBlock, tComma, literals);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal MetaClassBlock1Alt1Green MetaClassBlock1Alt1(IdentifierGreen identifier, __InternalSyntaxToken tDollar, IdentifierGreen symbolType)
        {
            #if DEBUG
                if (tDollar is null) throw new __ArgumentNullException(nameof(tDollar));
                if (tDollar.RawKind != (int)MetaSyntaxKind.TDollar) throw new __ArgumentException(nameof(tDollar));
                if (symbolType is null) throw new __ArgumentNullException(nameof(symbolType));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.MetaClassBlock1Alt1, identifier, tDollar, symbolType, out hash);
            if (cached != null) return (MetaClassBlock1Alt1Green)cached;
        
            var result = new MetaClassBlock1Alt1Green(MetaSyntaxKind.MetaClassBlock1Alt1, identifier, tDollar, symbolType);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal MetaClassBlock1Alt2Green MetaClassBlock1Alt2(IdentifierGreen identifier)
        {
            #if DEBUG
                if (identifier is null) throw new __ArgumentNullException(nameof(identifier));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.MetaClassBlock1Alt2, identifier, out hash);
            if (cached != null) return (MetaClassBlock1Alt2Green)cached;
        
            var result = new MetaClassBlock1Alt2Green(MetaSyntaxKind.MetaClassBlock1Alt2, identifier);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal MetaClassBlock2Green MetaClassBlock2(__InternalSyntaxToken tColon, global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<QualifierGreen> baseTypes)
        {
            #if DEBUG
                if (tColon is null) throw new __ArgumentNullException(nameof(tColon));
                if (tColon.RawKind != (int)MetaSyntaxKind.TColon) throw new __ArgumentException(nameof(tColon));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.MetaClassBlock2, tColon, baseTypes.Node, out hash);
            if (cached != null) return (MetaClassBlock2Green)cached;
        
            var result = new MetaClassBlock2Green(MetaSyntaxKind.MetaClassBlock2, tColon, baseTypes.Node);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal MetaClassBlock2baseTypesBlockGreen MetaClassBlock2baseTypesBlock(__InternalSyntaxToken tComma, QualifierGreen baseTypes)
        {
            #if DEBUG
                if (tComma is null) throw new __ArgumentNullException(nameof(tComma));
                if (tComma.RawKind != (int)MetaSyntaxKind.TComma) throw new __ArgumentException(nameof(tComma));
                if (baseTypes is null) throw new __ArgumentNullException(nameof(baseTypes));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.MetaClassBlock2baseTypesBlock, tComma, baseTypes, out hash);
            if (cached != null) return (MetaClassBlock2baseTypesBlockGreen)cached;
        
            var result = new MetaClassBlock2baseTypesBlockGreen(MetaSyntaxKind.MetaClassBlock2baseTypesBlock, tComma, baseTypes);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal MetaClassBlock3Green MetaClassBlock3(__InternalSyntaxToken tLBrace, global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<MetaClassBlock3Block1Green> block, __InternalSyntaxToken tRBrace)
        {
            #if DEBUG
                if (tLBrace is null) throw new __ArgumentNullException(nameof(tLBrace));
                if (tLBrace.RawKind != (int)MetaSyntaxKind.TLBrace) throw new __ArgumentException(nameof(tLBrace));
                if (tRBrace is null) throw new __ArgumentNullException(nameof(tRBrace));
                if (tRBrace.RawKind != (int)MetaSyntaxKind.TRBrace) throw new __ArgumentException(nameof(tRBrace));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.MetaClassBlock3, tLBrace, block.Node, tRBrace, out hash);
            if (cached != null) return (MetaClassBlock3Green)cached;
        
            var result = new MetaClassBlock3Green(MetaSyntaxKind.MetaClassBlock3, tLBrace, block.Node, tRBrace);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal MetaClassBlock3Block1Alt1Green MetaClassBlock3Block1Alt1(MetaPropertyGreen properties)
        {
            #if DEBUG
                if (properties is null) throw new __ArgumentNullException(nameof(properties));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.MetaClassBlock3Block1Alt1, properties, out hash);
            if (cached != null) return (MetaClassBlock3Block1Alt1Green)cached;
        
            var result = new MetaClassBlock3Block1Alt1Green(MetaSyntaxKind.MetaClassBlock3Block1Alt1, properties);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal MetaClassBlock3Block1Alt2Green MetaClassBlock3Block1Alt2(MetaOperationGreen operations)
        {
            #if DEBUG
                if (operations is null) throw new __ArgumentNullException(nameof(operations));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.MetaClassBlock3Block1Alt2, operations, out hash);
            if (cached != null) return (MetaClassBlock3Block1Alt2Green)cached;
        
            var result = new MetaClassBlock3Block1Alt2Green(MetaSyntaxKind.MetaClassBlock3Block1Alt2, operations);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal MetaPropertyBlock1Alt1Green MetaPropertyBlock1Alt1(__InternalSyntaxToken isContainment)
        {
            #if DEBUG
                if (isContainment is null) throw new __ArgumentNullException(nameof(isContainment));
                if (isContainment.RawKind != (int)MetaSyntaxKind.KContains) throw new __ArgumentException(nameof(isContainment));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.MetaPropertyBlock1Alt1, isContainment, out hash);
            if (cached != null) return (MetaPropertyBlock1Alt1Green)cached;
        
            var result = new MetaPropertyBlock1Alt1Green(MetaSyntaxKind.MetaPropertyBlock1Alt1, isContainment);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal MetaPropertyBlock1Alt2Green MetaPropertyBlock1Alt2(__InternalSyntaxToken isDerived)
        {
            #if DEBUG
                if (isDerived is null) throw new __ArgumentNullException(nameof(isDerived));
                if (isDerived.RawKind != (int)MetaSyntaxKind.KDerived) throw new __ArgumentException(nameof(isDerived));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.MetaPropertyBlock1Alt2, isDerived, out hash);
            if (cached != null) return (MetaPropertyBlock1Alt2Green)cached;
        
            var result = new MetaPropertyBlock1Alt2Green(MetaSyntaxKind.MetaPropertyBlock1Alt2, isDerived);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal MetaPropertyBlock1Alt3Green MetaPropertyBlock1Alt3(__InternalSyntaxToken isUnion)
        {
            #if DEBUG
                if (isUnion is null) throw new __ArgumentNullException(nameof(isUnion));
                if (isUnion.RawKind != (int)MetaSyntaxKind.KUnion) throw new __ArgumentException(nameof(isUnion));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.MetaPropertyBlock1Alt3, isUnion, out hash);
            if (cached != null) return (MetaPropertyBlock1Alt3Green)cached;
        
            var result = new MetaPropertyBlock1Alt3Green(MetaSyntaxKind.MetaPropertyBlock1Alt3, isUnion);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal MetaPropertyBlock1Alt4Green MetaPropertyBlock1Alt4(__InternalSyntaxToken isReadOnly)
        {
            #if DEBUG
                if (isReadOnly is null) throw new __ArgumentNullException(nameof(isReadOnly));
                if (isReadOnly.RawKind != (int)MetaSyntaxKind.KReadonly) throw new __ArgumentException(nameof(isReadOnly));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.MetaPropertyBlock1Alt4, isReadOnly, out hash);
            if (cached != null) return (MetaPropertyBlock1Alt4Green)cached;
        
            var result = new MetaPropertyBlock1Alt4Green(MetaSyntaxKind.MetaPropertyBlock1Alt4, isReadOnly);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal MetaPropertyBlock2Alt1Green MetaPropertyBlock2Alt1(IdentifierGreen identifier, __InternalSyntaxToken tDollar, IdentifierGreen symbolProperty)
        {
            #if DEBUG
                if (tDollar is null) throw new __ArgumentNullException(nameof(tDollar));
                if (tDollar.RawKind != (int)MetaSyntaxKind.TDollar) throw new __ArgumentException(nameof(tDollar));
                if (symbolProperty is null) throw new __ArgumentNullException(nameof(symbolProperty));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.MetaPropertyBlock2Alt1, identifier, tDollar, symbolProperty, out hash);
            if (cached != null) return (MetaPropertyBlock2Alt1Green)cached;
        
            var result = new MetaPropertyBlock2Alt1Green(MetaSyntaxKind.MetaPropertyBlock2Alt1, identifier, tDollar, symbolProperty);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal MetaPropertyBlock2Alt2Green MetaPropertyBlock2Alt2(IdentifierGreen identifier)
        {
            #if DEBUG
                if (identifier is null) throw new __ArgumentNullException(nameof(identifier));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.MetaPropertyBlock2Alt2, identifier, out hash);
            if (cached != null) return (MetaPropertyBlock2Alt2Green)cached;
        
            var result = new MetaPropertyBlock2Alt2Green(MetaSyntaxKind.MetaPropertyBlock2Alt2, identifier);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal MetaPropertyBlock3Green MetaPropertyBlock3(__InternalSyntaxToken tEq, ValueGreen defaultValue)
        {
            #if DEBUG
                if (tEq is null) throw new __ArgumentNullException(nameof(tEq));
                if (tEq.RawKind != (int)MetaSyntaxKind.TEq) throw new __ArgumentException(nameof(tEq));
                if (defaultValue is null) throw new __ArgumentNullException(nameof(defaultValue));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.MetaPropertyBlock3, tEq, defaultValue, out hash);
            if (cached != null) return (MetaPropertyBlock3Green)cached;
        
            var result = new MetaPropertyBlock3Green(MetaSyntaxKind.MetaPropertyBlock3, tEq, defaultValue);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal MetaPropertyBlock4Alt1Green MetaPropertyBlock4Alt1(__InternalSyntaxToken kOpposite, global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<QualifierGreen> oppositeProperties)
        {
            #if DEBUG
                if (kOpposite is null) throw new __ArgumentNullException(nameof(kOpposite));
                if (kOpposite.RawKind != (int)MetaSyntaxKind.KOpposite) throw new __ArgumentException(nameof(kOpposite));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.MetaPropertyBlock4Alt1, kOpposite, oppositeProperties.Node, out hash);
            if (cached != null) return (MetaPropertyBlock4Alt1Green)cached;
        
            var result = new MetaPropertyBlock4Alt1Green(MetaSyntaxKind.MetaPropertyBlock4Alt1, kOpposite, oppositeProperties.Node);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal MetaPropertyBlock4Alt2Green MetaPropertyBlock4Alt2(__InternalSyntaxToken kSubsets, global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<QualifierGreen> subsettedProperties)
        {
            #if DEBUG
                if (kSubsets is null) throw new __ArgumentNullException(nameof(kSubsets));
                if (kSubsets.RawKind != (int)MetaSyntaxKind.KSubsets) throw new __ArgumentException(nameof(kSubsets));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.MetaPropertyBlock4Alt2, kSubsets, subsettedProperties.Node, out hash);
            if (cached != null) return (MetaPropertyBlock4Alt2Green)cached;
        
            var result = new MetaPropertyBlock4Alt2Green(MetaSyntaxKind.MetaPropertyBlock4Alt2, kSubsets, subsettedProperties.Node);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal MetaPropertyBlock4Alt3Green MetaPropertyBlock4Alt3(__InternalSyntaxToken kRedefines, global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<QualifierGreen> redefinedProperties)
        {
            #if DEBUG
                if (kRedefines is null) throw new __ArgumentNullException(nameof(kRedefines));
                if (kRedefines.RawKind != (int)MetaSyntaxKind.KRedefines) throw new __ArgumentException(nameof(kRedefines));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.MetaPropertyBlock4Alt3, kRedefines, redefinedProperties.Node, out hash);
            if (cached != null) return (MetaPropertyBlock4Alt3Green)cached;
        
            var result = new MetaPropertyBlock4Alt3Green(MetaSyntaxKind.MetaPropertyBlock4Alt3, kRedefines, redefinedProperties.Node);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal MetaPropertyBlock4Alt1oppositePropertiesBlockGreen MetaPropertyBlock4Alt1oppositePropertiesBlock(__InternalSyntaxToken tComma, QualifierGreen oppositeProperties)
        {
            #if DEBUG
                if (tComma is null) throw new __ArgumentNullException(nameof(tComma));
                if (tComma.RawKind != (int)MetaSyntaxKind.TComma) throw new __ArgumentException(nameof(tComma));
                if (oppositeProperties is null) throw new __ArgumentNullException(nameof(oppositeProperties));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.MetaPropertyBlock4Alt1oppositePropertiesBlock, tComma, oppositeProperties, out hash);
            if (cached != null) return (MetaPropertyBlock4Alt1oppositePropertiesBlockGreen)cached;
        
            var result = new MetaPropertyBlock4Alt1oppositePropertiesBlockGreen(MetaSyntaxKind.MetaPropertyBlock4Alt1oppositePropertiesBlock, tComma, oppositeProperties);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal MetaPropertyBlock4Alt2subsettedPropertiesBlockGreen MetaPropertyBlock4Alt2subsettedPropertiesBlock(__InternalSyntaxToken tComma, QualifierGreen subsettedProperties)
        {
            #if DEBUG
                if (tComma is null) throw new __ArgumentNullException(nameof(tComma));
                if (tComma.RawKind != (int)MetaSyntaxKind.TComma) throw new __ArgumentException(nameof(tComma));
                if (subsettedProperties is null) throw new __ArgumentNullException(nameof(subsettedProperties));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.MetaPropertyBlock4Alt2subsettedPropertiesBlock, tComma, subsettedProperties, out hash);
            if (cached != null) return (MetaPropertyBlock4Alt2subsettedPropertiesBlockGreen)cached;
        
            var result = new MetaPropertyBlock4Alt2subsettedPropertiesBlockGreen(MetaSyntaxKind.MetaPropertyBlock4Alt2subsettedPropertiesBlock, tComma, subsettedProperties);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal MetaPropertyBlock4Alt3redefinedPropertiesBlockGreen MetaPropertyBlock4Alt3redefinedPropertiesBlock(__InternalSyntaxToken tComma, QualifierGreen redefinedProperties)
        {
            #if DEBUG
                if (tComma is null) throw new __ArgumentNullException(nameof(tComma));
                if (tComma.RawKind != (int)MetaSyntaxKind.TComma) throw new __ArgumentException(nameof(tComma));
                if (redefinedProperties is null) throw new __ArgumentNullException(nameof(redefinedProperties));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.MetaPropertyBlock4Alt3redefinedPropertiesBlock, tComma, redefinedProperties, out hash);
            if (cached != null) return (MetaPropertyBlock4Alt3redefinedPropertiesBlockGreen)cached;
        
            var result = new MetaPropertyBlock4Alt3redefinedPropertiesBlockGreen(MetaSyntaxKind.MetaPropertyBlock4Alt3redefinedPropertiesBlock, tComma, redefinedProperties);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal MetaOperationBlock1Green MetaOperationBlock1(global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<MetaParameterGreen> parameters)
        {
            #if DEBUG
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.MetaOperationBlock1, parameters.Node, out hash);
            if (cached != null) return (MetaOperationBlock1Green)cached;
        
            var result = new MetaOperationBlock1Green(MetaSyntaxKind.MetaOperationBlock1, parameters.Node);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal MetaOperationBlock1parametersBlockGreen MetaOperationBlock1parametersBlock(__InternalSyntaxToken tComma, MetaParameterGreen parameters)
        {
            #if DEBUG
                if (tComma is null) throw new __ArgumentNullException(nameof(tComma));
                if (tComma.RawKind != (int)MetaSyntaxKind.TComma) throw new __ArgumentException(nameof(tComma));
                if (parameters is null) throw new __ArgumentNullException(nameof(parameters));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.MetaOperationBlock1parametersBlock, tComma, parameters, out hash);
            if (cached != null) return (MetaOperationBlock1parametersBlockGreen)cached;
        
            var result = new MetaOperationBlock1parametersBlockGreen(MetaSyntaxKind.MetaOperationBlock1parametersBlock, tComma, parameters);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal QualifierIdentifierBlockGreen QualifierIdentifierBlock(__InternalSyntaxToken tDot, IdentifierGreen identifier)
        {
            #if DEBUG
                if (tDot is null) throw new __ArgumentNullException(nameof(tDot));
                if (tDot.RawKind != (int)MetaSyntaxKind.TDot) throw new __ArgumentException(nameof(tDot));
                if (identifier is null) throw new __ArgumentNullException(nameof(identifier));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(MetaSyntaxKind)MetaSyntaxKind.QualifierIdentifierBlock, tDot, identifier, out hash);
            if (cached != null) return (QualifierIdentifierBlockGreen)cached;
        
            var result = new QualifierIdentifierBlockGreen(MetaSyntaxKind.QualifierIdentifierBlock, tDot, identifier);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
    }
}
