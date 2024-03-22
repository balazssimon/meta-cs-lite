#pragma warning disable CS8669

namespace MetaDslx.Languages.MetaSymbols.Compiler.Syntax.InternalSyntax
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

    public partial class SymbolInternalSyntaxFactory : global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.InternalSyntaxFactory
    {
        public SymbolInternalSyntaxFactory(__SyntaxFacts syntaxFacts) 
            : base(syntaxFacts)
        {
        }

        public override __SyntaxLexer CreateLexer(__SourceText text, __ParseOptions? options)
        {
            return new SymbolSyntaxLexer(text, (SymbolParseOptions)(options ?? SymbolParseOptions.Default));
        }

        public override __SyntaxParser CreateParser(__SyntaxLexer lexer, __IncrementalParseData? oldParseData, global::System.Collections.Generic.IEnumerable<__TextChangeRange>? changes, __CancellationToken cancellationToken = default)
        {
            return new SymbolSyntaxParser((SymbolSyntaxLexer)lexer, oldParseData, changes, cancellationToken);
        }

        public __InternalSyntaxTrivia Trivia(SymbolSyntaxKind kind, string text, bool elastic = false)
        {
            var trivia = GreenSyntaxTrivia.Create(kind, text);
            if (!elastic) return trivia;
            return global::MetaDslx.CodeAnalysis.GreenNodeExtensions.WithAnnotationsGreen(trivia, new[] { __SyntaxAnnotation.ElasticAnnotation });
        }

        protected override __InternalSyntaxTrivia Trivia(int kind, string text, bool elastic = false)
        {
            return Trivia((SymbolSyntaxKind)kind, text, elastic);
        }

        public override __InternalSyntaxNode SkippedTokensTrivia(__GreenNode token)
        {
            return new GreenSkippedTokensTriviaSyntax((SymbolSyntaxKind)__InternalSyntaxKind.SkippedTokensTrivia, token);
        }
    
        public __InternalSyntaxToken Token(SymbolSyntaxKind kind)
        {
            return GreenSyntaxToken.Create(kind);
        }

        protected override __InternalSyntaxToken Token(int kind)
        {
            return Token((SymbolSyntaxKind)kind);
        }

        public __InternalSyntaxToken Token(__GreenNode? leading, SymbolSyntaxKind kind, __GreenNode? trailing)
        {
            return GreenSyntaxToken.Create(kind, leading, trailing);
        }

        protected override __InternalSyntaxToken Token(__GreenNode? leading, int kind, __GreenNode? trailing)
        {
            return Token(leading, (SymbolSyntaxKind)kind, trailing);
        }

        public __InternalSyntaxToken Token(__GreenNode? leading, SymbolSyntaxKind kind, string text, __GreenNode? trailing)
        {
            __Debug.Assert(SymbolLanguage.Instance.SyntaxFacts.IsToken(kind));
            string defaultText = SymbolLanguage.Instance.SyntaxFacts.GetText(kind);
            return kind >= GreenSyntaxToken.FirstTokenWithWellKnownText && kind <= GreenSyntaxToken.LastTokenWithWellKnownText && text == defaultText
                ? Token(leading, kind, trailing)
                : GreenSyntaxToken.Identifier(kind, leading, text, trailing);
        }

        protected override __InternalSyntaxToken Token(__GreenNode? leading, int kind, string text, __GreenNode? trailing)
        {
            return Token(leading, (SymbolSyntaxKind)kind, text, trailing);
        }

        public __InternalSyntaxToken Token(__GreenNode? leading, SymbolSyntaxKind kind, string text, string valueText, __GreenNode? trailing)
        {
            __Debug.Assert(SymbolLanguage.Instance.SyntaxFacts.IsToken(kind));
            string defaultText = SymbolLanguage.Instance.SyntaxFacts.GetText(kind);
            return kind >= GreenSyntaxToken.FirstTokenWithWellKnownText && kind <= GreenSyntaxToken.LastTokenWithWellKnownText && text == defaultText && valueText == defaultText
                ? Token(leading, kind, trailing)
                : GreenSyntaxToken.WithValue(kind, leading, text, valueText, trailing);
        }

        protected override __InternalSyntaxToken Token(__GreenNode? leading, int kind, string text, string valueText, __GreenNode? trailing)
        {
            return Token(leading, (SymbolSyntaxKind)kind, text, valueText, trailing);
        }

        public __InternalSyntaxToken Token(__GreenNode? leading, SymbolSyntaxKind kind, string text, object value, __GreenNode? trailing)
        {
            __Debug.Assert(SymbolLanguage.Instance.SyntaxFacts.IsToken(kind));
            string defaultText = SymbolLanguage.Instance.SyntaxFacts.GetText(kind);
            return kind >= GreenSyntaxToken.FirstTokenWithWellKnownText && kind <= GreenSyntaxToken.LastTokenWithWellKnownText && text == defaultText && defaultText.Equals(value)
                ? Token(leading, kind, trailing)
                : GreenSyntaxToken.WithValue(kind, leading, text, value, trailing);
        }

        protected override __InternalSyntaxToken Token(__GreenNode? leading, int kind, string text, object value, __GreenNode? trailing)
        {
            return Token(leading, (SymbolSyntaxKind)kind, text, value, trailing);
        }

        public __InternalSyntaxToken MissingToken(SymbolSyntaxKind kind)
        {
            return GreenSyntaxToken.CreateMissing(kind, null, null);
        }

        protected override __InternalSyntaxToken MissingToken(int kind)
        {
            return MissingToken((SymbolSyntaxKind)kind);
        }

        public __InternalSyntaxToken MissingToken(__GreenNode? leading, SymbolSyntaxKind kind, __GreenNode? trailing)
        {
            return GreenSyntaxToken.CreateMissing(kind, leading, trailing);
        }

        protected override __InternalSyntaxToken MissingToken(__GreenNode? leading, int kind, __GreenNode? trailing)
        {
            return MissingToken(leading, (SymbolSyntaxKind)kind, trailing);
        }

        public override __InternalSyntaxToken BadToken(__GreenNode? leading, string text, __GreenNode? trailing)
        {
            return GreenSyntaxToken.WithValue((SymbolSyntaxKind)__InternalSyntaxKind.BadToken, leading, text, text, trailing);
        }

        public override global::System.Collections.Generic.IEnumerable<__InternalSyntaxToken> GetWellKnownTokens()
        {
            return GreenSyntaxToken.GetWellKnownTokens();
        }

        public __InternalSyntaxToken TInteger(string text)
        {
            return Token(null, SymbolSyntaxKind.TInteger, text, null);
        }

        public __InternalSyntaxToken TInteger(string text, object value)
        {
            return Token(null, SymbolSyntaxKind.TInteger, text, value, null);
        }

        public __InternalSyntaxToken TDecimal(string text)
        {
            return Token(null, SymbolSyntaxKind.TDecimal, text, null);
        }

        public __InternalSyntaxToken TDecimal(string text, object value)
        {
            return Token(null, SymbolSyntaxKind.TDecimal, text, value, null);
        }

        public __InternalSyntaxToken TIdentifier(string text)
        {
            return Token(null, SymbolSyntaxKind.TIdentifier, text, null);
        }

        public __InternalSyntaxToken TIdentifier(string text, object value)
        {
            return Token(null, SymbolSyntaxKind.TIdentifier, text, value, null);
        }

        public __InternalSyntaxToken TVerbatimIdentifier(string text)
        {
            return Token(null, SymbolSyntaxKind.TVerbatimIdentifier, text, null);
        }

        public __InternalSyntaxToken TVerbatimIdentifier(string text, object value)
        {
            return Token(null, SymbolSyntaxKind.TVerbatimIdentifier, text, value, null);
        }

        public __InternalSyntaxToken TString(string text)
        {
            return Token(null, SymbolSyntaxKind.TString, text, null);
        }

        public __InternalSyntaxToken TString(string text, object value)
        {
            return Token(null, SymbolSyntaxKind.TString, text, value, null);
        }

        public __InternalSyntaxToken TWhitespace(string text)
        {
            return Token(null, SymbolSyntaxKind.TWhitespace, text, null);
        }

        public __InternalSyntaxToken TWhitespace(string text, object value)
        {
            return Token(null, SymbolSyntaxKind.TWhitespace, text, value, null);
        }

        public __InternalSyntaxToken TLineEnd(string text)
        {
            return Token(null, SymbolSyntaxKind.TLineEnd, text, null);
        }

        public __InternalSyntaxToken TLineEnd(string text, object value)
        {
            return Token(null, SymbolSyntaxKind.TLineEnd, text, value, null);
        }

        public __InternalSyntaxToken TSingleLineComment(string text)
        {
            return Token(null, SymbolSyntaxKind.TSingleLineComment, text, null);
        }

        public __InternalSyntaxToken TSingleLineComment(string text, object value)
        {
            return Token(null, SymbolSyntaxKind.TSingleLineComment, text, value, null);
        }

        public __InternalSyntaxToken TMultiLineComment(string text)
        {
            return Token(null, SymbolSyntaxKind.TMultiLineComment, text, null);
        }

        public __InternalSyntaxToken TMultiLineComment(string text, object value)
        {
            return Token(null, SymbolSyntaxKind.TMultiLineComment, text, value, null);
        }

        public __InternalSyntaxToken TInvalidToken(string text)
        {
            return Token(null, SymbolSyntaxKind.TInvalidToken, text, null);
        }

        public __InternalSyntaxToken TInvalidToken(string text, object value)
        {
            return Token(null, SymbolSyntaxKind.TInvalidToken, text, value, null);
        }

        internal MainGreen Main(__InternalSyntaxToken kNamespace, QualifierGreen qualifier, __InternalSyntaxToken tSemicolon, global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<UsingGreen> usingList, MainBlock1Green block, __InternalSyntaxToken endOfFileToken)
        {
            #if DEBUG
                if (kNamespace is null) throw new __ArgumentNullException(nameof(kNamespace));
                if (kNamespace.RawKind != (int)SymbolSyntaxKind.KNamespace) throw new __ArgumentException(nameof(kNamespace));
                if (qualifier is null) throw new __ArgumentNullException(nameof(qualifier));
                if (tSemicolon is null) throw new __ArgumentNullException(nameof(tSemicolon));
                if (tSemicolon.RawKind != (int)SymbolSyntaxKind.TSemicolon) throw new __ArgumentException(nameof(tSemicolon));
                if (block is null) throw new __ArgumentNullException(nameof(block));
                if (endOfFileToken is null) throw new __ArgumentNullException(nameof(endOfFileToken));
                if (endOfFileToken.RawKind != (int)__InternalSyntaxKind.Eof) throw new __ArgumentException(nameof(endOfFileToken));
            #endif
            return new MainGreen(SymbolSyntaxKind.Main, kNamespace, qualifier, tSemicolon, usingList.Node, block, endOfFileToken);
        }
        internal UsingGreen Using(__InternalSyntaxToken kUsing, QualifierGreen namespaces, __InternalSyntaxToken tSemicolon)
        {
            #if DEBUG
                if (kUsing is null) throw new __ArgumentNullException(nameof(kUsing));
                if (kUsing.RawKind != (int)SymbolSyntaxKind.KUsing) throw new __ArgumentException(nameof(kUsing));
                if (namespaces is null) throw new __ArgumentNullException(nameof(namespaces));
                if (tSemicolon is null) throw new __ArgumentNullException(nameof(tSemicolon));
                if (tSemicolon.RawKind != (int)SymbolSyntaxKind.TSemicolon) throw new __ArgumentException(nameof(tSemicolon));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(SymbolSyntaxKind)SymbolSyntaxKind.Using, kUsing, namespaces, tSemicolon, out hash);
            if (cached != null) return (UsingGreen)cached;
        
            var result = new UsingGreen(SymbolSyntaxKind.Using, kUsing, namespaces, tSemicolon);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal SymbolGreen Symbol(__InternalSyntaxToken isAbstract, __InternalSyntaxToken kSymbol, NameGreen name, SymbolBlock1Green block1, SymbolBlock2Green block2)
        {
            #if DEBUG
                if (isAbstract is not null && (isAbstract.RawKind != (int)SymbolSyntaxKind.KAbstract)) throw new __ArgumentException(nameof(isAbstract));
                if (kSymbol is null) throw new __ArgumentNullException(nameof(kSymbol));
                if (kSymbol.RawKind != (int)SymbolSyntaxKind.KSymbol) throw new __ArgumentException(nameof(kSymbol));
                if (name is null) throw new __ArgumentNullException(nameof(name));
                if (block2 is null) throw new __ArgumentNullException(nameof(block2));
            #endif
            return new SymbolGreen(SymbolSyntaxKind.Symbol, isAbstract, kSymbol, name, block1, block2);
        }
        internal PropertyGreen Property(PropertyBlock1Green block1, TypeReferenceGreen type, NameGreen name, PropertyBlock2Green block2, PropertyBlock3Green block3, __InternalSyntaxToken tSemicolon)
        {
            #if DEBUG
                if (type is null) throw new __ArgumentNullException(nameof(type));
                if (name is null) throw new __ArgumentNullException(nameof(name));
                if (tSemicolon is null) throw new __ArgumentNullException(nameof(tSemicolon));
                if (tSemicolon.RawKind != (int)SymbolSyntaxKind.TSemicolon) throw new __ArgumentException(nameof(tSemicolon));
            #endif
            return new PropertyGreen(SymbolSyntaxKind.Property, block1, type, name, block2, block3, tSemicolon);
        }
        internal OperationAlt1Green OperationAlt1(__InternalSyntaxToken isPhase, NameGreen name, __InternalSyntaxToken tLParen, __InternalSyntaxToken tRParen, __InternalSyntaxToken tSemicolon)
        {
            #if DEBUG
                if (isPhase is null) throw new __ArgumentNullException(nameof(isPhase));
                if (isPhase.RawKind != (int)SymbolSyntaxKind.KPhase) throw new __ArgumentException(nameof(isPhase));
                if (name is null) throw new __ArgumentNullException(nameof(name));
                if (tLParen is null) throw new __ArgumentNullException(nameof(tLParen));
                if (tLParen.RawKind != (int)SymbolSyntaxKind.TLParen) throw new __ArgumentException(nameof(tLParen));
                if (tRParen is null) throw new __ArgumentNullException(nameof(tRParen));
                if (tRParen.RawKind != (int)SymbolSyntaxKind.TRParen) throw new __ArgumentException(nameof(tRParen));
                if (tSemicolon is null) throw new __ArgumentNullException(nameof(tSemicolon));
                if (tSemicolon.RawKind != (int)SymbolSyntaxKind.TSemicolon) throw new __ArgumentException(nameof(tSemicolon));
            #endif
            return new OperationAlt1Green(SymbolSyntaxKind.OperationAlt1, isPhase, name, tLParen, tRParen, tSemicolon);
        }
        internal OperationAlt2Green OperationAlt2(__InternalSyntaxToken isCached, TypeReferenceGreen returnType, NameGreen name, __InternalSyntaxToken tLParen, OperationAlt2Block1Green block1, __InternalSyntaxToken tRParen, OperationAlt2Block2Green block2, __InternalSyntaxToken tSemicolon)
        {
            #if DEBUG
                if (isCached is not null && (isCached.RawKind != (int)SymbolSyntaxKind.KCached)) throw new __ArgumentException(nameof(isCached));
                if (returnType is null) throw new __ArgumentNullException(nameof(returnType));
                if (name is null) throw new __ArgumentNullException(nameof(name));
                if (tLParen is null) throw new __ArgumentNullException(nameof(tLParen));
                if (tLParen.RawKind != (int)SymbolSyntaxKind.TLParen) throw new __ArgumentException(nameof(tLParen));
                if (tRParen is null) throw new __ArgumentNullException(nameof(tRParen));
                if (tRParen.RawKind != (int)SymbolSyntaxKind.TRParen) throw new __ArgumentException(nameof(tRParen));
                if (tSemicolon is null) throw new __ArgumentNullException(nameof(tSemicolon));
                if (tSemicolon.RawKind != (int)SymbolSyntaxKind.TSemicolon) throw new __ArgumentException(nameof(tSemicolon));
            #endif
            return new OperationAlt2Green(SymbolSyntaxKind.OperationAlt2, isCached, returnType, name, tLParen, block1, tRParen, block2, tSemicolon);
        }
        internal ParameterGreen Parameter(TypeReferenceGreen type, NameGreen name)
        {
            #if DEBUG
                if (type is null) throw new __ArgumentNullException(nameof(type));
                if (name is null) throw new __ArgumentNullException(nameof(name));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(SymbolSyntaxKind)SymbolSyntaxKind.Parameter, type, name, out hash);
            if (cached != null) return (ParameterGreen)cached;
        
            var result = new ParameterGreen(SymbolSyntaxKind.Parameter, type, name);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal TypeReferenceGreen TypeReference(SimpleTypeReferenceGreen type, TypeReferenceBlock1Green block, ArrayDimensionsGreen dimensions)
        {
            #if DEBUG
                if (type is null) throw new __ArgumentNullException(nameof(type));
                if (dimensions is null) throw new __ArgumentNullException(nameof(dimensions));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(SymbolSyntaxKind)SymbolSyntaxKind.TypeReference, type, block, dimensions, out hash);
            if (cached != null) return (TypeReferenceGreen)cached;
        
            var result = new TypeReferenceGreen(SymbolSyntaxKind.TypeReference, type, block, dimensions);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal ArrayDimensionsGreen ArrayDimensions(global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<ArrayDimensionsBlock1Green> block)
        {
            #if DEBUG
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(SymbolSyntaxKind)SymbolSyntaxKind.ArrayDimensions, block.Node, out hash);
            if (cached != null) return (ArrayDimensionsGreen)cached;
        
            var result = new ArrayDimensionsGreen(SymbolSyntaxKind.ArrayDimensions, block.Node);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal SimpleTypeReferenceAlt1Green SimpleTypeReferenceAlt1(PrimitiveTypeGreen primitiveType)
        {
            #if DEBUG
                if (primitiveType is null) throw new __ArgumentNullException(nameof(primitiveType));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(SymbolSyntaxKind)SymbolSyntaxKind.SimpleTypeReferenceAlt1, primitiveType, out hash);
            if (cached != null) return (SimpleTypeReferenceAlt1Green)cached;
        
            var result = new SimpleTypeReferenceAlt1Green(SymbolSyntaxKind.SimpleTypeReferenceAlt1, primitiveType);
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
            var cached = __SyntaxNodeCache.TryGetNode((int)(SymbolSyntaxKind)SymbolSyntaxKind.SimpleTypeReferenceAlt2, qualifier, out hash);
            if (cached != null) return (SimpleTypeReferenceAlt2Green)cached;
        
            var result = new SimpleTypeReferenceAlt2Green(SymbolSyntaxKind.SimpleTypeReferenceAlt2, qualifier);
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
                if (token.RawKind != (int)SymbolSyntaxKind.KObject && token.RawKind != (int)SymbolSyntaxKind.KBool && token.RawKind != (int)SymbolSyntaxKind.KChar && token.RawKind != (int)SymbolSyntaxKind.KString && token.RawKind != (int)SymbolSyntaxKind.KByte && token.RawKind != (int)SymbolSyntaxKind.KSbyte && token.RawKind != (int)SymbolSyntaxKind.KShort && token.RawKind != (int)SymbolSyntaxKind.KUshort && token.RawKind != (int)SymbolSyntaxKind.KInt && token.RawKind != (int)SymbolSyntaxKind.KUint && token.RawKind != (int)SymbolSyntaxKind.KLong && token.RawKind != (int)SymbolSyntaxKind.KUlong && token.RawKind != (int)SymbolSyntaxKind.KFloat && token.RawKind != (int)SymbolSyntaxKind.KDouble && token.RawKind != (int)SymbolSyntaxKind.KDecimal && token.RawKind != (int)SymbolSyntaxKind.KType && token.RawKind != (int)SymbolSyntaxKind.KSymbol && token.RawKind != (int)SymbolSyntaxKind.KVoid) throw new __ArgumentException(nameof(token));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(SymbolSyntaxKind)SymbolSyntaxKind.PrimitiveType, token, out hash);
            if (cached != null) return (PrimitiveTypeGreen)cached;
        
            var result = new PrimitiveTypeGreen(SymbolSyntaxKind.PrimitiveType, token);
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
                if (tString.RawKind != (int)SymbolSyntaxKind.TString) throw new __ArgumentException(nameof(tString));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(SymbolSyntaxKind)SymbolSyntaxKind.ValueAlt1, tString, out hash);
            if (cached != null) return (ValueAlt1Green)cached;
        
            var result = new ValueAlt1Green(SymbolSyntaxKind.ValueAlt1, tString);
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
                if (tInteger.RawKind != (int)SymbolSyntaxKind.TInteger) throw new __ArgumentException(nameof(tInteger));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(SymbolSyntaxKind)SymbolSyntaxKind.ValueAlt2, tInteger, out hash);
            if (cached != null) return (ValueAlt2Green)cached;
        
            var result = new ValueAlt2Green(SymbolSyntaxKind.ValueAlt2, tInteger);
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
                if (tDecimal.RawKind != (int)SymbolSyntaxKind.TDecimal) throw new __ArgumentException(nameof(tDecimal));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(SymbolSyntaxKind)SymbolSyntaxKind.ValueAlt3, tDecimal, out hash);
            if (cached != null) return (ValueAlt3Green)cached;
        
            var result = new ValueAlt3Green(SymbolSyntaxKind.ValueAlt3, tDecimal);
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
            var cached = __SyntaxNodeCache.TryGetNode((int)(SymbolSyntaxKind)SymbolSyntaxKind.ValueAlt4, tBoolean, out hash);
            if (cached != null) return (ValueAlt4Green)cached;
        
            var result = new ValueAlt4Green(SymbolSyntaxKind.ValueAlt4, tBoolean);
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
                if (kNull.RawKind != (int)SymbolSyntaxKind.KNull) throw new __ArgumentException(nameof(kNull));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(SymbolSyntaxKind)SymbolSyntaxKind.ValueAlt5, kNull, out hash);
            if (cached != null) return (ValueAlt5Green)cached;
        
            var result = new ValueAlt5Green(SymbolSyntaxKind.ValueAlt5, kNull);
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
            var cached = __SyntaxNodeCache.TryGetNode((int)(SymbolSyntaxKind)SymbolSyntaxKind.ValueAlt6, qualifier, out hash);
            if (cached != null) return (ValueAlt6Green)cached;
        
            var result = new ValueAlt6Green(SymbolSyntaxKind.ValueAlt6, qualifier);
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
            var cached = __SyntaxNodeCache.TryGetNode((int)(SymbolSyntaxKind)SymbolSyntaxKind.Name, identifier, out hash);
            if (cached != null) return (NameGreen)cached;
        
            var result = new NameGreen(SymbolSyntaxKind.Name, identifier);
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
            var cached = __SyntaxNodeCache.TryGetNode((int)(SymbolSyntaxKind)SymbolSyntaxKind.Qualifier, identifier.Node, out hash);
            if (cached != null) return (QualifierGreen)cached;
        
            var result = new QualifierGreen(SymbolSyntaxKind.Qualifier, identifier.Node);
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
                if (token.RawKind != (int)SymbolSyntaxKind.TIdentifier && token.RawKind != (int)SymbolSyntaxKind.TVerbatimIdentifier) throw new __ArgumentException(nameof(token));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(SymbolSyntaxKind)SymbolSyntaxKind.Identifier, token, out hash);
            if (cached != null) return (IdentifierGreen)cached;
        
            var result = new IdentifierGreen(SymbolSyntaxKind.Identifier, token);
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
                if (token.RawKind != (int)SymbolSyntaxKind.KTrue && token.RawKind != (int)SymbolSyntaxKind.KFalse) throw new __ArgumentException(nameof(token));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(SymbolSyntaxKind)SymbolSyntaxKind.TBoolean, token, out hash);
            if (cached != null) return (TBooleanGreen)cached;
        
            var result = new TBooleanGreen(SymbolSyntaxKind.TBoolean, token);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal MainBlock1Green MainBlock1(global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<SymbolGreen> symbolList)
        {
            #if DEBUG
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(SymbolSyntaxKind)SymbolSyntaxKind.MainBlock1, symbolList.Node, out hash);
            if (cached != null) return (MainBlock1Green)cached;
        
            var result = new MainBlock1Green(SymbolSyntaxKind.MainBlock1, symbolList.Node);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal SymbolBlock1Green SymbolBlock1(__InternalSyntaxToken tColon, QualifierGreen baseTypes)
        {
            #if DEBUG
                if (tColon is null) throw new __ArgumentNullException(nameof(tColon));
                if (tColon.RawKind != (int)SymbolSyntaxKind.TColon) throw new __ArgumentException(nameof(tColon));
                if (baseTypes is null) throw new __ArgumentNullException(nameof(baseTypes));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(SymbolSyntaxKind)SymbolSyntaxKind.SymbolBlock1, tColon, baseTypes, out hash);
            if (cached != null) return (SymbolBlock1Green)cached;
        
            var result = new SymbolBlock1Green(SymbolSyntaxKind.SymbolBlock1, tColon, baseTypes);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal SymbolBlock2Green SymbolBlock2(__InternalSyntaxToken tLBrace, global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<SymbolBlock2Block1Green> block, __InternalSyntaxToken tRBrace)
        {
            #if DEBUG
                if (tLBrace is null) throw new __ArgumentNullException(nameof(tLBrace));
                if (tLBrace.RawKind != (int)SymbolSyntaxKind.TLBrace) throw new __ArgumentException(nameof(tLBrace));
                if (tRBrace is null) throw new __ArgumentNullException(nameof(tRBrace));
                if (tRBrace.RawKind != (int)SymbolSyntaxKind.TRBrace) throw new __ArgumentException(nameof(tRBrace));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(SymbolSyntaxKind)SymbolSyntaxKind.SymbolBlock2, tLBrace, block.Node, tRBrace, out hash);
            if (cached != null) return (SymbolBlock2Green)cached;
        
            var result = new SymbolBlock2Green(SymbolSyntaxKind.SymbolBlock2, tLBrace, block.Node, tRBrace);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal SymbolBlock2Block1Alt1Green SymbolBlock2Block1Alt1(PropertyGreen properties)
        {
            #if DEBUG
                if (properties is null) throw new __ArgumentNullException(nameof(properties));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(SymbolSyntaxKind)SymbolSyntaxKind.SymbolBlock2Block1Alt1, properties, out hash);
            if (cached != null) return (SymbolBlock2Block1Alt1Green)cached;
        
            var result = new SymbolBlock2Block1Alt1Green(SymbolSyntaxKind.SymbolBlock2Block1Alt1, properties);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal SymbolBlock2Block1Alt2Green SymbolBlock2Block1Alt2(OperationGreen operations)
        {
            #if DEBUG
                if (operations is null) throw new __ArgumentNullException(nameof(operations));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(SymbolSyntaxKind)SymbolSyntaxKind.SymbolBlock2Block1Alt2, operations, out hash);
            if (cached != null) return (SymbolBlock2Block1Alt2Green)cached;
        
            var result = new SymbolBlock2Block1Alt2Green(SymbolSyntaxKind.SymbolBlock2Block1Alt2, operations);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal PropertyBlock1Alt1Green PropertyBlock1Alt1(__InternalSyntaxToken isPlain, PropertyBlock1Alt1Block1Green block)
        {
            #if DEBUG
                if (isPlain is null) throw new __ArgumentNullException(nameof(isPlain));
                if (isPlain.RawKind != (int)SymbolSyntaxKind.KPlain) throw new __ArgumentException(nameof(isPlain));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(SymbolSyntaxKind)SymbolSyntaxKind.PropertyBlock1Alt1, isPlain, block, out hash);
            if (cached != null) return (PropertyBlock1Alt1Green)cached;
        
            var result = new PropertyBlock1Alt1Green(SymbolSyntaxKind.PropertyBlock1Alt1, isPlain, block);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal PropertyBlock1Alt2Green PropertyBlock1Alt2(__InternalSyntaxToken isDerived, __InternalSyntaxToken isCached, __InternalSyntaxToken isWeak)
        {
            #if DEBUG
                if (isDerived is null) throw new __ArgumentNullException(nameof(isDerived));
                if (isDerived.RawKind != (int)SymbolSyntaxKind.KDerived) throw new __ArgumentException(nameof(isDerived));
                if (isCached is not null && (isCached.RawKind != (int)SymbolSyntaxKind.KCached)) throw new __ArgumentException(nameof(isCached));
                if (isWeak is not null && (isWeak.RawKind != (int)SymbolSyntaxKind.KWeak)) throw new __ArgumentException(nameof(isWeak));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(SymbolSyntaxKind)SymbolSyntaxKind.PropertyBlock1Alt2, isDerived, isCached, isWeak, out hash);
            if (cached != null) return (PropertyBlock1Alt2Green)cached;
        
            var result = new PropertyBlock1Alt2Green(SymbolSyntaxKind.PropertyBlock1Alt2, isDerived, isCached, isWeak);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal PropertyBlock1Alt3Green PropertyBlock1Alt3(__InternalSyntaxToken isWeak)
        {
            #if DEBUG
                if (isWeak is null) throw new __ArgumentNullException(nameof(isWeak));
                if (isWeak.RawKind != (int)SymbolSyntaxKind.KWeak) throw new __ArgumentException(nameof(isWeak));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(SymbolSyntaxKind)SymbolSyntaxKind.PropertyBlock1Alt3, isWeak, out hash);
            if (cached != null) return (PropertyBlock1Alt3Green)cached;
        
            var result = new PropertyBlock1Alt3Green(SymbolSyntaxKind.PropertyBlock1Alt3, isWeak);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal PropertyBlock1Alt1Block1Alt1Green PropertyBlock1Alt1Block1Alt1(__InternalSyntaxToken isAbstract)
        {
            #if DEBUG
                if (isAbstract is null) throw new __ArgumentNullException(nameof(isAbstract));
                if (isAbstract.RawKind != (int)SymbolSyntaxKind.KAbstract) throw new __ArgumentException(nameof(isAbstract));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(SymbolSyntaxKind)SymbolSyntaxKind.PropertyBlock1Alt1Block1Alt1, isAbstract, out hash);
            if (cached != null) return (PropertyBlock1Alt1Block1Alt1Green)cached;
        
            var result = new PropertyBlock1Alt1Block1Alt1Green(SymbolSyntaxKind.PropertyBlock1Alt1Block1Alt1, isAbstract);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal PropertyBlock1Alt1Block1Alt2Green PropertyBlock1Alt1Block1Alt2(__InternalSyntaxToken isWeak)
        {
            #if DEBUG
                if (isWeak is null) throw new __ArgumentNullException(nameof(isWeak));
                if (isWeak.RawKind != (int)SymbolSyntaxKind.KWeak) throw new __ArgumentException(nameof(isWeak));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(SymbolSyntaxKind)SymbolSyntaxKind.PropertyBlock1Alt1Block1Alt2, isWeak, out hash);
            if (cached != null) return (PropertyBlock1Alt1Block1Alt2Green)cached;
        
            var result = new PropertyBlock1Alt1Block1Alt2Green(SymbolSyntaxKind.PropertyBlock1Alt1Block1Alt2, isWeak);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal PropertyBlock2Green PropertyBlock2(__InternalSyntaxToken tEq, ValueGreen defaultValue)
        {
            #if DEBUG
                if (tEq is null) throw new __ArgumentNullException(nameof(tEq));
                if (tEq.RawKind != (int)SymbolSyntaxKind.TEq) throw new __ArgumentException(nameof(tEq));
                if (defaultValue is null) throw new __ArgumentNullException(nameof(defaultValue));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(SymbolSyntaxKind)SymbolSyntaxKind.PropertyBlock2, tEq, defaultValue, out hash);
            if (cached != null) return (PropertyBlock2Green)cached;
        
            var result = new PropertyBlock2Green(SymbolSyntaxKind.PropertyBlock2, tEq, defaultValue);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal PropertyBlock3Green PropertyBlock3(__InternalSyntaxToken kPhase, IdentifierGreen phase)
        {
            #if DEBUG
                if (kPhase is null) throw new __ArgumentNullException(nameof(kPhase));
                if (kPhase.RawKind != (int)SymbolSyntaxKind.KPhase) throw new __ArgumentException(nameof(kPhase));
                if (phase is null) throw new __ArgumentNullException(nameof(phase));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(SymbolSyntaxKind)SymbolSyntaxKind.PropertyBlock3, kPhase, phase, out hash);
            if (cached != null) return (PropertyBlock3Green)cached;
        
            var result = new PropertyBlock3Green(SymbolSyntaxKind.PropertyBlock3, kPhase, phase);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal OperationAlt2Block1Green OperationAlt2Block1(global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<ParameterGreen> parameters)
        {
            #if DEBUG
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(SymbolSyntaxKind)SymbolSyntaxKind.OperationAlt2Block1, parameters.Node, out hash);
            if (cached != null) return (OperationAlt2Block1Green)cached;
        
            var result = new OperationAlt2Block1Green(SymbolSyntaxKind.OperationAlt2Block1, parameters.Node);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal OperationAlt2Block1parametersBlockGreen OperationAlt2Block1parametersBlock(__InternalSyntaxToken tComma, ParameterGreen parameters)
        {
            #if DEBUG
                if (tComma is null) throw new __ArgumentNullException(nameof(tComma));
                if (tComma.RawKind != (int)SymbolSyntaxKind.TComma) throw new __ArgumentException(nameof(tComma));
                if (parameters is null) throw new __ArgumentNullException(nameof(parameters));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(SymbolSyntaxKind)SymbolSyntaxKind.OperationAlt2Block1parametersBlock, tComma, parameters, out hash);
            if (cached != null) return (OperationAlt2Block1parametersBlockGreen)cached;
        
            var result = new OperationAlt2Block1parametersBlockGreen(SymbolSyntaxKind.OperationAlt2Block1parametersBlock, tComma, parameters);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal OperationAlt2Block2Green OperationAlt2Block2(__InternalSyntaxToken kIf, __InternalSyntaxToken cacheCondition)
        {
            #if DEBUG
                if (kIf is null) throw new __ArgumentNullException(nameof(kIf));
                if (kIf.RawKind != (int)SymbolSyntaxKind.KIf) throw new __ArgumentException(nameof(kIf));
                if (cacheCondition is null) throw new __ArgumentNullException(nameof(cacheCondition));
                if (cacheCondition.RawKind != (int)SymbolSyntaxKind.TString) throw new __ArgumentException(nameof(cacheCondition));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(SymbolSyntaxKind)SymbolSyntaxKind.OperationAlt2Block2, kIf, cacheCondition, out hash);
            if (cached != null) return (OperationAlt2Block2Green)cached;
        
            var result = new OperationAlt2Block2Green(SymbolSyntaxKind.OperationAlt2Block2, kIf, cacheCondition);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal TypeReferenceBlock1Green TypeReferenceBlock1(__InternalSyntaxToken isNullable)
        {
            #if DEBUG
                if (isNullable is null) throw new __ArgumentNullException(nameof(isNullable));
                if (isNullable.RawKind != (int)SymbolSyntaxKind.TQuestion) throw new __ArgumentException(nameof(isNullable));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(SymbolSyntaxKind)SymbolSyntaxKind.TypeReferenceBlock1, isNullable, out hash);
            if (cached != null) return (TypeReferenceBlock1Green)cached;
        
            var result = new TypeReferenceBlock1Green(SymbolSyntaxKind.TypeReferenceBlock1, isNullable);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal ArrayDimensionsBlock1Green ArrayDimensionsBlock1(__InternalSyntaxToken tLBracket, __InternalSyntaxToken tRBracket)
        {
            #if DEBUG
                if (tLBracket is null) throw new __ArgumentNullException(nameof(tLBracket));
                if (tLBracket.RawKind != (int)SymbolSyntaxKind.TLBracket) throw new __ArgumentException(nameof(tLBracket));
                if (tRBracket is null) throw new __ArgumentNullException(nameof(tRBracket));
                if (tRBracket.RawKind != (int)SymbolSyntaxKind.TRBracket) throw new __ArgumentException(nameof(tRBracket));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(SymbolSyntaxKind)SymbolSyntaxKind.ArrayDimensionsBlock1, tLBracket, tRBracket, out hash);
            if (cached != null) return (ArrayDimensionsBlock1Green)cached;
        
            var result = new ArrayDimensionsBlock1Green(SymbolSyntaxKind.ArrayDimensionsBlock1, tLBracket, tRBracket);
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
                if (tDot.RawKind != (int)SymbolSyntaxKind.TDot) throw new __ArgumentException(nameof(tDot));
                if (identifier is null) throw new __ArgumentNullException(nameof(identifier));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(SymbolSyntaxKind)SymbolSyntaxKind.QualifierIdentifierBlock, tDot, identifier, out hash);
            if (cached != null) return (QualifierIdentifierBlockGreen)cached;
        
            var result = new QualifierIdentifierBlockGreen(SymbolSyntaxKind.QualifierIdentifierBlock, tDot, identifier);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
    }
}
