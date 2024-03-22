#pragma warning disable CS8669

namespace MetaDslx.Examples.Soal.Compiler.Syntax.InternalSyntax
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

    public partial class SoalInternalSyntaxFactory : global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.InternalSyntaxFactory
    {
        public SoalInternalSyntaxFactory(__SyntaxFacts syntaxFacts) 
            : base(syntaxFacts)
        {
        }

        public override __SyntaxLexer CreateLexer(__SourceText text, __ParseOptions? options)
        {
            return new SoalSyntaxLexer(text, (SoalParseOptions)(options ?? SoalParseOptions.Default));
        }

        public override __SyntaxParser CreateParser(__SyntaxLexer lexer, __IncrementalParseData? oldParseData, global::System.Collections.Generic.IEnumerable<__TextChangeRange>? changes, __CancellationToken cancellationToken = default)
        {
            return new SoalSyntaxParser((SoalSyntaxLexer)lexer, oldParseData, changes, cancellationToken);
        }

        public __InternalSyntaxTrivia Trivia(SoalSyntaxKind kind, string text, bool elastic = false)
        {
            var trivia = GreenSyntaxTrivia.Create(kind, text);
            if (!elastic) return trivia;
            return global::MetaDslx.CodeAnalysis.GreenNodeExtensions.WithAnnotationsGreen(trivia, new[] { __SyntaxAnnotation.ElasticAnnotation });
        }

        protected override __InternalSyntaxTrivia Trivia(int kind, string text, bool elastic = false)
        {
            return Trivia((SoalSyntaxKind)kind, text, elastic);
        }

        public override __InternalSyntaxNode SkippedTokensTrivia(__GreenNode token)
        {
            return new GreenSkippedTokensTriviaSyntax((SoalSyntaxKind)__InternalSyntaxKind.SkippedTokensTrivia, token);
        }
    
        public __InternalSyntaxToken Token(SoalSyntaxKind kind)
        {
            return GreenSyntaxToken.Create(kind);
        }

        protected override __InternalSyntaxToken Token(int kind)
        {
            return Token((SoalSyntaxKind)kind);
        }

        public __InternalSyntaxToken Token(__GreenNode? leading, SoalSyntaxKind kind, __GreenNode? trailing)
        {
            return GreenSyntaxToken.Create(kind, leading, trailing);
        }

        protected override __InternalSyntaxToken Token(__GreenNode? leading, int kind, __GreenNode? trailing)
        {
            return Token(leading, (SoalSyntaxKind)kind, trailing);
        }

        public __InternalSyntaxToken Token(__GreenNode? leading, SoalSyntaxKind kind, string text, __GreenNode? trailing)
        {
            __Debug.Assert(SoalLanguage.Instance.SyntaxFacts.IsToken(kind));
            string defaultText = SoalLanguage.Instance.SyntaxFacts.GetText(kind);
            return kind >= GreenSyntaxToken.FirstTokenWithWellKnownText && kind <= GreenSyntaxToken.LastTokenWithWellKnownText && text == defaultText
                ? Token(leading, kind, trailing)
                : GreenSyntaxToken.Identifier(kind, leading, text, trailing);
        }

        protected override __InternalSyntaxToken Token(__GreenNode? leading, int kind, string text, __GreenNode? trailing)
        {
            return Token(leading, (SoalSyntaxKind)kind, text, trailing);
        }

        public __InternalSyntaxToken Token(__GreenNode? leading, SoalSyntaxKind kind, string text, string valueText, __GreenNode? trailing)
        {
            __Debug.Assert(SoalLanguage.Instance.SyntaxFacts.IsToken(kind));
            string defaultText = SoalLanguage.Instance.SyntaxFacts.GetText(kind);
            return kind >= GreenSyntaxToken.FirstTokenWithWellKnownText && kind <= GreenSyntaxToken.LastTokenWithWellKnownText && text == defaultText && valueText == defaultText
                ? Token(leading, kind, trailing)
                : GreenSyntaxToken.WithValue(kind, leading, text, valueText, trailing);
        }

        protected override __InternalSyntaxToken Token(__GreenNode? leading, int kind, string text, string valueText, __GreenNode? trailing)
        {
            return Token(leading, (SoalSyntaxKind)kind, text, valueText, trailing);
        }

        public __InternalSyntaxToken Token(__GreenNode? leading, SoalSyntaxKind kind, string text, object value, __GreenNode? trailing)
        {
            __Debug.Assert(SoalLanguage.Instance.SyntaxFacts.IsToken(kind));
            string defaultText = SoalLanguage.Instance.SyntaxFacts.GetText(kind);
            return kind >= GreenSyntaxToken.FirstTokenWithWellKnownText && kind <= GreenSyntaxToken.LastTokenWithWellKnownText && text == defaultText && defaultText.Equals(value)
                ? Token(leading, kind, trailing)
                : GreenSyntaxToken.WithValue(kind, leading, text, value, trailing);
        }

        protected override __InternalSyntaxToken Token(__GreenNode? leading, int kind, string text, object value, __GreenNode? trailing)
        {
            return Token(leading, (SoalSyntaxKind)kind, text, value, trailing);
        }

        public __InternalSyntaxToken MissingToken(SoalSyntaxKind kind)
        {
            return GreenSyntaxToken.CreateMissing(kind, null, null);
        }

        protected override __InternalSyntaxToken MissingToken(int kind)
        {
            return MissingToken((SoalSyntaxKind)kind);
        }

        public __InternalSyntaxToken MissingToken(__GreenNode? leading, SoalSyntaxKind kind, __GreenNode? trailing)
        {
            return GreenSyntaxToken.CreateMissing(kind, leading, trailing);
        }

        protected override __InternalSyntaxToken MissingToken(__GreenNode? leading, int kind, __GreenNode? trailing)
        {
            return MissingToken(leading, (SoalSyntaxKind)kind, trailing);
        }

        public override __InternalSyntaxToken BadToken(__GreenNode? leading, string text, __GreenNode? trailing)
        {
            return GreenSyntaxToken.WithValue((SoalSyntaxKind)__InternalSyntaxKind.BadToken, leading, text, text, trailing);
        }

        public override global::System.Collections.Generic.IEnumerable<__InternalSyntaxToken> GetWellKnownTokens()
        {
            return GreenSyntaxToken.GetWellKnownTokens();
        }

        public __InternalSyntaxToken TInteger(string text)
        {
            return Token(null, SoalSyntaxKind.TInteger, text, null);
        }

        public __InternalSyntaxToken TInteger(string text, object value)
        {
            return Token(null, SoalSyntaxKind.TInteger, text, value, null);
        }

        public __InternalSyntaxToken TDecimal(string text)
        {
            return Token(null, SoalSyntaxKind.TDecimal, text, null);
        }

        public __InternalSyntaxToken TDecimal(string text, object value)
        {
            return Token(null, SoalSyntaxKind.TDecimal, text, value, null);
        }

        public __InternalSyntaxToken TIdentifier(string text)
        {
            return Token(null, SoalSyntaxKind.TIdentifier, text, null);
        }

        public __InternalSyntaxToken TIdentifier(string text, object value)
        {
            return Token(null, SoalSyntaxKind.TIdentifier, text, value, null);
        }

        public __InternalSyntaxToken TVerbatimIdentifier(string text)
        {
            return Token(null, SoalSyntaxKind.TVerbatimIdentifier, text, null);
        }

        public __InternalSyntaxToken TVerbatimIdentifier(string text, object value)
        {
            return Token(null, SoalSyntaxKind.TVerbatimIdentifier, text, value, null);
        }

        public __InternalSyntaxToken TString(string text)
        {
            return Token(null, SoalSyntaxKind.TString, text, null);
        }

        public __InternalSyntaxToken TString(string text, object value)
        {
            return Token(null, SoalSyntaxKind.TString, text, value, null);
        }

        public __InternalSyntaxToken TWhitespace(string text)
        {
            return Token(null, SoalSyntaxKind.TWhitespace, text, null);
        }

        public __InternalSyntaxToken TWhitespace(string text, object value)
        {
            return Token(null, SoalSyntaxKind.TWhitespace, text, value, null);
        }

        public __InternalSyntaxToken TLineEnd(string text)
        {
            return Token(null, SoalSyntaxKind.TLineEnd, text, null);
        }

        public __InternalSyntaxToken TLineEnd(string text, object value)
        {
            return Token(null, SoalSyntaxKind.TLineEnd, text, value, null);
        }

        public __InternalSyntaxToken TSingleLineComment(string text)
        {
            return Token(null, SoalSyntaxKind.TSingleLineComment, text, null);
        }

        public __InternalSyntaxToken TSingleLineComment(string text, object value)
        {
            return Token(null, SoalSyntaxKind.TSingleLineComment, text, value, null);
        }

        public __InternalSyntaxToken TMultiLineComment(string text)
        {
            return Token(null, SoalSyntaxKind.TMultiLineComment, text, null);
        }

        public __InternalSyntaxToken TMultiLineComment(string text, object value)
        {
            return Token(null, SoalSyntaxKind.TMultiLineComment, text, value, null);
        }

        public __InternalSyntaxToken TInvalidToken(string text)
        {
            return Token(null, SoalSyntaxKind.TInvalidToken, text, null);
        }

        public __InternalSyntaxToken TInvalidToken(string text, object value)
        {
            return Token(null, SoalSyntaxKind.TInvalidToken, text, value, null);
        }

        internal MainGreen Main(__InternalSyntaxToken kNamespace, QualifierGreen qualifier, __InternalSyntaxToken tSemicolon, global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<UsingGreen> usingList, MainBlock1Green block, __InternalSyntaxToken endOfFileToken)
        {
            #if DEBUG
                if (kNamespace is null) throw new __ArgumentNullException(nameof(kNamespace));
                if (kNamespace.RawKind != (int)SoalSyntaxKind.KNamespace) throw new __ArgumentException(nameof(kNamespace));
                if (qualifier is null) throw new __ArgumentNullException(nameof(qualifier));
                if (tSemicolon is null) throw new __ArgumentNullException(nameof(tSemicolon));
                if (tSemicolon.RawKind != (int)SoalSyntaxKind.TSemicolon) throw new __ArgumentException(nameof(tSemicolon));
                if (block is null) throw new __ArgumentNullException(nameof(block));
                if (endOfFileToken is null) throw new __ArgumentNullException(nameof(endOfFileToken));
                if (endOfFileToken.RawKind != (int)__InternalSyntaxKind.Eof) throw new __ArgumentException(nameof(endOfFileToken));
            #endif
            return new MainGreen(SoalSyntaxKind.Main, kNamespace, qualifier, tSemicolon, usingList.Node, block, endOfFileToken);
        }
        internal UsingGreen Using(__InternalSyntaxToken kUsing, QualifierGreen namespaces, __InternalSyntaxToken tSemicolon)
        {
            #if DEBUG
                if (kUsing is null) throw new __ArgumentNullException(nameof(kUsing));
                if (kUsing.RawKind != (int)SoalSyntaxKind.KUsing) throw new __ArgumentException(nameof(kUsing));
                if (namespaces is null) throw new __ArgumentNullException(nameof(namespaces));
                if (tSemicolon is null) throw new __ArgumentNullException(nameof(tSemicolon));
                if (tSemicolon.RawKind != (int)SoalSyntaxKind.TSemicolon) throw new __ArgumentException(nameof(tSemicolon));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(SoalSyntaxKind)SoalSyntaxKind.Using, kUsing, namespaces, tSemicolon, out hash);
            if (cached != null) return (UsingGreen)cached;
        
            var result = new UsingGreen(SoalSyntaxKind.Using, kUsing, namespaces, tSemicolon);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal DeclarationAlt1Green DeclarationAlt1(EnumTypeGreen enumType)
        {
            #if DEBUG
                if (enumType is null) throw new __ArgumentNullException(nameof(enumType));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(SoalSyntaxKind)SoalSyntaxKind.DeclarationAlt1, enumType, out hash);
            if (cached != null) return (DeclarationAlt1Green)cached;
        
            var result = new DeclarationAlt1Green(SoalSyntaxKind.DeclarationAlt1, enumType);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal DeclarationAlt2Green DeclarationAlt2(StructTypeGreen structType)
        {
            #if DEBUG
                if (structType is null) throw new __ArgumentNullException(nameof(structType));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(SoalSyntaxKind)SoalSyntaxKind.DeclarationAlt2, structType, out hash);
            if (cached != null) return (DeclarationAlt2Green)cached;
        
            var result = new DeclarationAlt2Green(SoalSyntaxKind.DeclarationAlt2, structType);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal DeclarationAlt3Green DeclarationAlt3(InterfaceGreen @interface)
        {
            #if DEBUG
                if (@interface is null) throw new __ArgumentNullException(nameof(@interface));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(SoalSyntaxKind)SoalSyntaxKind.DeclarationAlt3, @interface, out hash);
            if (cached != null) return (DeclarationAlt3Green)cached;
        
            var result = new DeclarationAlt3Green(SoalSyntaxKind.DeclarationAlt3, @interface);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal DeclarationAlt4Green DeclarationAlt4(ServiceGreen service)
        {
            #if DEBUG
                if (service is null) throw new __ArgumentNullException(nameof(service));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(SoalSyntaxKind)SoalSyntaxKind.DeclarationAlt4, service, out hash);
            if (cached != null) return (DeclarationAlt4Green)cached;
        
            var result = new DeclarationAlt4Green(SoalSyntaxKind.DeclarationAlt4, service);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal EnumTypeGreen EnumType(__InternalSyntaxToken kEnum, NameGreen name, __InternalSyntaxToken tLBrace, EnumTypeBlock1Green block, __InternalSyntaxToken tRBrace)
        {
            #if DEBUG
                if (kEnum is null) throw new __ArgumentNullException(nameof(kEnum));
                if (kEnum.RawKind != (int)SoalSyntaxKind.KEnum) throw new __ArgumentException(nameof(kEnum));
                if (name is null) throw new __ArgumentNullException(nameof(name));
                if (tLBrace is null) throw new __ArgumentNullException(nameof(tLBrace));
                if (tLBrace.RawKind != (int)SoalSyntaxKind.TLBrace) throw new __ArgumentException(nameof(tLBrace));
                if (tRBrace is null) throw new __ArgumentNullException(nameof(tRBrace));
                if (tRBrace.RawKind != (int)SoalSyntaxKind.TRBrace) throw new __ArgumentException(nameof(tRBrace));
            #endif
            return new EnumTypeGreen(SoalSyntaxKind.EnumType, kEnum, name, tLBrace, block, tRBrace);
        }
        internal EnumLiteralGreen EnumLiteral(NameGreen name)
        {
            #if DEBUG
                if (name is null) throw new __ArgumentNullException(nameof(name));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(SoalSyntaxKind)SoalSyntaxKind.EnumLiteral, name, out hash);
            if (cached != null) return (EnumLiteralGreen)cached;
        
            var result = new EnumLiteralGreen(SoalSyntaxKind.EnumLiteral, name);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal StructTypeGreen StructType(__InternalSyntaxToken kStruct, NameGreen name, StructTypeBlock1Green block, __InternalSyntaxToken tLBrace, global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<PropertyGreen> fields, __InternalSyntaxToken tRBrace)
        {
            #if DEBUG
                if (kStruct is null) throw new __ArgumentNullException(nameof(kStruct));
                if (kStruct.RawKind != (int)SoalSyntaxKind.KStruct) throw new __ArgumentException(nameof(kStruct));
                if (name is null) throw new __ArgumentNullException(nameof(name));
                if (tLBrace is null) throw new __ArgumentNullException(nameof(tLBrace));
                if (tLBrace.RawKind != (int)SoalSyntaxKind.TLBrace) throw new __ArgumentException(nameof(tLBrace));
                if (tRBrace is null) throw new __ArgumentNullException(nameof(tRBrace));
                if (tRBrace.RawKind != (int)SoalSyntaxKind.TRBrace) throw new __ArgumentException(nameof(tRBrace));
            #endif
            return new StructTypeGreen(SoalSyntaxKind.StructType, kStruct, name, block, tLBrace, fields.Node, tRBrace);
        }
        internal PropertyGreen Property(TypeReferenceGreen type, NameGreen name, __InternalSyntaxToken tSemicolon)
        {
            #if DEBUG
                if (type is null) throw new __ArgumentNullException(nameof(type));
                if (name is null) throw new __ArgumentNullException(nameof(name));
                if (tSemicolon is null) throw new __ArgumentNullException(nameof(tSemicolon));
                if (tSemicolon.RawKind != (int)SoalSyntaxKind.TSemicolon) throw new __ArgumentException(nameof(tSemicolon));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(SoalSyntaxKind)SoalSyntaxKind.Property, type, name, tSemicolon, out hash);
            if (cached != null) return (PropertyGreen)cached;
        
            var result = new PropertyGreen(SoalSyntaxKind.Property, type, name, tSemicolon);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal InterfaceGreen Interface(__InternalSyntaxToken kInterface, NameGreen name, __InternalSyntaxToken tLBrace, global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<ResourceGreen> resources, global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<OperationGreen> operations, __InternalSyntaxToken tRBrace)
        {
            #if DEBUG
                if (kInterface is null) throw new __ArgumentNullException(nameof(kInterface));
                if (kInterface.RawKind != (int)SoalSyntaxKind.KInterface) throw new __ArgumentException(nameof(kInterface));
                if (name is null) throw new __ArgumentNullException(nameof(name));
                if (tLBrace is null) throw new __ArgumentNullException(nameof(tLBrace));
                if (tLBrace.RawKind != (int)SoalSyntaxKind.TLBrace) throw new __ArgumentException(nameof(tLBrace));
                if (tRBrace is null) throw new __ArgumentNullException(nameof(tRBrace));
                if (tRBrace.RawKind != (int)SoalSyntaxKind.TRBrace) throw new __ArgumentException(nameof(tRBrace));
            #endif
            return new InterfaceGreen(SoalSyntaxKind.Interface, kInterface, name, tLBrace, resources.Node, operations.Node, tRBrace);
        }
        internal ResourceGreen Resource(__InternalSyntaxToken isReadOnly, __InternalSyntaxToken kResource, QualifierGreen entity, ResourceBlock1Green block, __InternalSyntaxToken tSemicolon)
        {
            #if DEBUG
                if (isReadOnly is not null && (isReadOnly.RawKind != (int)SoalSyntaxKind.KReadonly)) throw new __ArgumentException(nameof(isReadOnly));
                if (kResource is null) throw new __ArgumentNullException(nameof(kResource));
                if (kResource.RawKind != (int)SoalSyntaxKind.KResource) throw new __ArgumentException(nameof(kResource));
                if (entity is null) throw new __ArgumentNullException(nameof(entity));
                if (tSemicolon is null) throw new __ArgumentNullException(nameof(tSemicolon));
                if (tSemicolon.RawKind != (int)SoalSyntaxKind.TSemicolon) throw new __ArgumentException(nameof(tSemicolon));
            #endif
            return new ResourceGreen(SoalSyntaxKind.Resource, isReadOnly, kResource, entity, block, tSemicolon);
        }
        internal OperationGreen Operation(__InternalSyntaxToken isAsync, OutputParameterListGreen responseParameters, NameGreen name, InputParameterListGreen requestParameters, OperationBlock1Green block, __InternalSyntaxToken tSemicolon)
        {
            #if DEBUG
                if (isAsync is not null && (isAsync.RawKind != (int)SoalSyntaxKind.KAsync)) throw new __ArgumentException(nameof(isAsync));
                if (responseParameters is null) throw new __ArgumentNullException(nameof(responseParameters));
                if (name is null) throw new __ArgumentNullException(nameof(name));
                if (requestParameters is null) throw new __ArgumentNullException(nameof(requestParameters));
                if (tSemicolon is null) throw new __ArgumentNullException(nameof(tSemicolon));
                if (tSemicolon.RawKind != (int)SoalSyntaxKind.TSemicolon) throw new __ArgumentException(nameof(tSemicolon));
            #endif
            return new OperationGreen(SoalSyntaxKind.Operation, isAsync, responseParameters, name, requestParameters, block, tSemicolon);
        }
        internal InputParameterListGreen InputParameterList(__InternalSyntaxToken tLParen, InputParameterListBlock1Green block, __InternalSyntaxToken tRParen)
        {
            #if DEBUG
                if (tLParen is null) throw new __ArgumentNullException(nameof(tLParen));
                if (tLParen.RawKind != (int)SoalSyntaxKind.TLParen) throw new __ArgumentException(nameof(tLParen));
                if (tRParen is null) throw new __ArgumentNullException(nameof(tRParen));
                if (tRParen.RawKind != (int)SoalSyntaxKind.TRParen) throw new __ArgumentException(nameof(tRParen));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(SoalSyntaxKind)SoalSyntaxKind.InputParameterList, tLParen, block, tRParen, out hash);
            if (cached != null) return (InputParameterListGreen)cached;
        
            var result = new InputParameterListGreen(SoalSyntaxKind.InputParameterList, tLParen, block, tRParen);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal OutputParameterListAlt1Green OutputParameterListAlt1(__InternalSyntaxToken kVoid)
        {
            #if DEBUG
                if (kVoid is null) throw new __ArgumentNullException(nameof(kVoid));
                if (kVoid.RawKind != (int)SoalSyntaxKind.KVoid) throw new __ArgumentException(nameof(kVoid));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(SoalSyntaxKind)SoalSyntaxKind.OutputParameterListAlt1, kVoid, out hash);
            if (cached != null) return (OutputParameterListAlt1Green)cached;
        
            var result = new OutputParameterListAlt1Green(SoalSyntaxKind.OutputParameterListAlt1, kVoid);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal OutputParameterListAlt2Green OutputParameterListAlt2(SingleReturnParameterGreen parameters)
        {
            #if DEBUG
                if (parameters is null) throw new __ArgumentNullException(nameof(parameters));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(SoalSyntaxKind)SoalSyntaxKind.OutputParameterListAlt2, parameters, out hash);
            if (cached != null) return (OutputParameterListAlt2Green)cached;
        
            var result = new OutputParameterListAlt2Green(SoalSyntaxKind.OutputParameterListAlt2, parameters);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal OutputParameterListAlt3Green OutputParameterListAlt3(__InternalSyntaxToken tLParen, global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<ParameterGreen> parameters, __InternalSyntaxToken tRParen)
        {
            #if DEBUG
                if (tLParen is null) throw new __ArgumentNullException(nameof(tLParen));
                if (tLParen.RawKind != (int)SoalSyntaxKind.TLParen) throw new __ArgumentException(nameof(tLParen));
                if (tRParen is null) throw new __ArgumentNullException(nameof(tRParen));
                if (tRParen.RawKind != (int)SoalSyntaxKind.TRParen) throw new __ArgumentException(nameof(tRParen));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(SoalSyntaxKind)SoalSyntaxKind.OutputParameterListAlt3, tLParen, parameters.Node, tRParen, out hash);
            if (cached != null) return (OutputParameterListAlt3Green)cached;
        
            var result = new OutputParameterListAlt3Green(SoalSyntaxKind.OutputParameterListAlt3, tLParen, parameters.Node, tRParen);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal ParameterGreen Parameter(TypeReferenceGreen type, NameGreen name)
        {
            #if DEBUG
                if (type is null) throw new __ArgumentNullException(nameof(type));
                if (name is null) throw new __ArgumentNullException(nameof(name));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(SoalSyntaxKind)SoalSyntaxKind.Parameter, type, name, out hash);
            if (cached != null) return (ParameterGreen)cached;
        
            var result = new ParameterGreen(SoalSyntaxKind.Parameter, type, name);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal SingleReturnParameterGreen SingleReturnParameter(TypeReferenceGreen type)
        {
            #if DEBUG
                if (type is null) throw new __ArgumentNullException(nameof(type));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(SoalSyntaxKind)SoalSyntaxKind.SingleReturnParameter, type, out hash);
            if (cached != null) return (SingleReturnParameterGreen)cached;
        
            var result = new SingleReturnParameterGreen(SoalSyntaxKind.SingleReturnParameter, type);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal ServiceGreen Service(__InternalSyntaxToken kService, NameGreen name, __InternalSyntaxToken tColon, QualifierGreen @interface, __InternalSyntaxToken tLBrace, __InternalSyntaxToken kBinding, BindingKindGreen binding, __InternalSyntaxToken tSemicolon, __InternalSyntaxToken tRBrace)
        {
            #if DEBUG
                if (kService is null) throw new __ArgumentNullException(nameof(kService));
                if (kService.RawKind != (int)SoalSyntaxKind.KService) throw new __ArgumentException(nameof(kService));
                if (name is null) throw new __ArgumentNullException(nameof(name));
                if (tColon is null) throw new __ArgumentNullException(nameof(tColon));
                if (tColon.RawKind != (int)SoalSyntaxKind.TColon) throw new __ArgumentException(nameof(tColon));
                if (@interface is null) throw new __ArgumentNullException(nameof(@interface));
                if (tLBrace is null) throw new __ArgumentNullException(nameof(tLBrace));
                if (tLBrace.RawKind != (int)SoalSyntaxKind.TLBrace) throw new __ArgumentException(nameof(tLBrace));
                if (kBinding is null) throw new __ArgumentNullException(nameof(kBinding));
                if (kBinding.RawKind != (int)SoalSyntaxKind.KBinding) throw new __ArgumentException(nameof(kBinding));
                if (binding is null) throw new __ArgumentNullException(nameof(binding));
                if (tSemicolon is null) throw new __ArgumentNullException(nameof(tSemicolon));
                if (tSemicolon.RawKind != (int)SoalSyntaxKind.TSemicolon) throw new __ArgumentException(nameof(tSemicolon));
                if (tRBrace is null) throw new __ArgumentNullException(nameof(tRBrace));
                if (tRBrace.RawKind != (int)SoalSyntaxKind.TRBrace) throw new __ArgumentException(nameof(tRBrace));
            #endif
            return new ServiceGreen(SoalSyntaxKind.Service, kService, name, tColon, @interface, tLBrace, kBinding, binding, tSemicolon, tRBrace);
        }
        internal BindingKindGreen BindingKind(__InternalSyntaxToken token)
        {
            #if DEBUG
                if (token is null) throw new __ArgumentNullException(nameof(token));
                if (token.RawKind != (int)SoalSyntaxKind.KREST && token.RawKind != (int)SoalSyntaxKind.KSOAP) throw new __ArgumentException(nameof(token));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(SoalSyntaxKind)SoalSyntaxKind.BindingKind, token, out hash);
            if (cached != null) return (BindingKindGreen)cached;
        
            var result = new BindingKindGreen(SoalSyntaxKind.BindingKind, token);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal TypeReferenceGreen TypeReference(SimpleTypeGreen type, __InternalSyntaxToken isNullable, TypeReferenceBlock1Green isArray)
        {
            #if DEBUG
                if (type is null) throw new __ArgumentNullException(nameof(type));
                if (isNullable is not null && (isNullable.RawKind != (int)SoalSyntaxKind.TQuestion)) throw new __ArgumentException(nameof(isNullable));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(SoalSyntaxKind)SoalSyntaxKind.TypeReference, type, isNullable, isArray, out hash);
            if (cached != null) return (TypeReferenceGreen)cached;
        
            var result = new TypeReferenceGreen(SoalSyntaxKind.TypeReference, type, isNullable, isArray);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal SimpleTypeAlt1Green SimpleTypeAlt1(__InternalSyntaxToken kObject)
        {
            #if DEBUG
                if (kObject is null) throw new __ArgumentNullException(nameof(kObject));
                if (kObject.RawKind != (int)SoalSyntaxKind.KObject) throw new __ArgumentException(nameof(kObject));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(SoalSyntaxKind)SoalSyntaxKind.SimpleTypeAlt1, kObject, out hash);
            if (cached != null) return (SimpleTypeAlt1Green)cached;
        
            var result = new SimpleTypeAlt1Green(SoalSyntaxKind.SimpleTypeAlt1, kObject);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal SimpleTypeAlt2Green SimpleTypeAlt2(__InternalSyntaxToken kBinary)
        {
            #if DEBUG
                if (kBinary is null) throw new __ArgumentNullException(nameof(kBinary));
                if (kBinary.RawKind != (int)SoalSyntaxKind.KBinary) throw new __ArgumentException(nameof(kBinary));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(SoalSyntaxKind)SoalSyntaxKind.SimpleTypeAlt2, kBinary, out hash);
            if (cached != null) return (SimpleTypeAlt2Green)cached;
        
            var result = new SimpleTypeAlt2Green(SoalSyntaxKind.SimpleTypeAlt2, kBinary);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal SimpleTypeAlt3Green SimpleTypeAlt3(__InternalSyntaxToken kBool)
        {
            #if DEBUG
                if (kBool is null) throw new __ArgumentNullException(nameof(kBool));
                if (kBool.RawKind != (int)SoalSyntaxKind.KBool) throw new __ArgumentException(nameof(kBool));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(SoalSyntaxKind)SoalSyntaxKind.SimpleTypeAlt3, kBool, out hash);
            if (cached != null) return (SimpleTypeAlt3Green)cached;
        
            var result = new SimpleTypeAlt3Green(SoalSyntaxKind.SimpleTypeAlt3, kBool);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal SimpleTypeAlt4Green SimpleTypeAlt4(__InternalSyntaxToken kString)
        {
            #if DEBUG
                if (kString is null) throw new __ArgumentNullException(nameof(kString));
                if (kString.RawKind != (int)SoalSyntaxKind.KString) throw new __ArgumentException(nameof(kString));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(SoalSyntaxKind)SoalSyntaxKind.SimpleTypeAlt4, kString, out hash);
            if (cached != null) return (SimpleTypeAlt4Green)cached;
        
            var result = new SimpleTypeAlt4Green(SoalSyntaxKind.SimpleTypeAlt4, kString);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal SimpleTypeAlt5Green SimpleTypeAlt5(__InternalSyntaxToken kInt)
        {
            #if DEBUG
                if (kInt is null) throw new __ArgumentNullException(nameof(kInt));
                if (kInt.RawKind != (int)SoalSyntaxKind.KInt) throw new __ArgumentException(nameof(kInt));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(SoalSyntaxKind)SoalSyntaxKind.SimpleTypeAlt5, kInt, out hash);
            if (cached != null) return (SimpleTypeAlt5Green)cached;
        
            var result = new SimpleTypeAlt5Green(SoalSyntaxKind.SimpleTypeAlt5, kInt);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal SimpleTypeAlt6Green SimpleTypeAlt6(__InternalSyntaxToken kLong)
        {
            #if DEBUG
                if (kLong is null) throw new __ArgumentNullException(nameof(kLong));
                if (kLong.RawKind != (int)SoalSyntaxKind.KLong) throw new __ArgumentException(nameof(kLong));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(SoalSyntaxKind)SoalSyntaxKind.SimpleTypeAlt6, kLong, out hash);
            if (cached != null) return (SimpleTypeAlt6Green)cached;
        
            var result = new SimpleTypeAlt6Green(SoalSyntaxKind.SimpleTypeAlt6, kLong);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal SimpleTypeAlt7Green SimpleTypeAlt7(__InternalSyntaxToken kFloat)
        {
            #if DEBUG
                if (kFloat is null) throw new __ArgumentNullException(nameof(kFloat));
                if (kFloat.RawKind != (int)SoalSyntaxKind.KFloat) throw new __ArgumentException(nameof(kFloat));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(SoalSyntaxKind)SoalSyntaxKind.SimpleTypeAlt7, kFloat, out hash);
            if (cached != null) return (SimpleTypeAlt7Green)cached;
        
            var result = new SimpleTypeAlt7Green(SoalSyntaxKind.SimpleTypeAlt7, kFloat);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal SimpleTypeAlt8Green SimpleTypeAlt8(__InternalSyntaxToken kDouble)
        {
            #if DEBUG
                if (kDouble is null) throw new __ArgumentNullException(nameof(kDouble));
                if (kDouble.RawKind != (int)SoalSyntaxKind.KDouble) throw new __ArgumentException(nameof(kDouble));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(SoalSyntaxKind)SoalSyntaxKind.SimpleTypeAlt8, kDouble, out hash);
            if (cached != null) return (SimpleTypeAlt8Green)cached;
        
            var result = new SimpleTypeAlt8Green(SoalSyntaxKind.SimpleTypeAlt8, kDouble);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal SimpleTypeAlt9Green SimpleTypeAlt9(__InternalSyntaxToken kDate)
        {
            #if DEBUG
                if (kDate is null) throw new __ArgumentNullException(nameof(kDate));
                if (kDate.RawKind != (int)SoalSyntaxKind.KDate) throw new __ArgumentException(nameof(kDate));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(SoalSyntaxKind)SoalSyntaxKind.SimpleTypeAlt9, kDate, out hash);
            if (cached != null) return (SimpleTypeAlt9Green)cached;
        
            var result = new SimpleTypeAlt9Green(SoalSyntaxKind.SimpleTypeAlt9, kDate);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal SimpleTypeAlt10Green SimpleTypeAlt10(__InternalSyntaxToken kTime)
        {
            #if DEBUG
                if (kTime is null) throw new __ArgumentNullException(nameof(kTime));
                if (kTime.RawKind != (int)SoalSyntaxKind.KTime) throw new __ArgumentException(nameof(kTime));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(SoalSyntaxKind)SoalSyntaxKind.SimpleTypeAlt10, kTime, out hash);
            if (cached != null) return (SimpleTypeAlt10Green)cached;
        
            var result = new SimpleTypeAlt10Green(SoalSyntaxKind.SimpleTypeAlt10, kTime);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal SimpleTypeAlt11Green SimpleTypeAlt11(__InternalSyntaxToken kDatetime)
        {
            #if DEBUG
                if (kDatetime is null) throw new __ArgumentNullException(nameof(kDatetime));
                if (kDatetime.RawKind != (int)SoalSyntaxKind.KDatetime) throw new __ArgumentException(nameof(kDatetime));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(SoalSyntaxKind)SoalSyntaxKind.SimpleTypeAlt11, kDatetime, out hash);
            if (cached != null) return (SimpleTypeAlt11Green)cached;
        
            var result = new SimpleTypeAlt11Green(SoalSyntaxKind.SimpleTypeAlt11, kDatetime);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal SimpleTypeAlt12Green SimpleTypeAlt12(__InternalSyntaxToken kDuration)
        {
            #if DEBUG
                if (kDuration is null) throw new __ArgumentNullException(nameof(kDuration));
                if (kDuration.RawKind != (int)SoalSyntaxKind.KDuration) throw new __ArgumentException(nameof(kDuration));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(SoalSyntaxKind)SoalSyntaxKind.SimpleTypeAlt12, kDuration, out hash);
            if (cached != null) return (SimpleTypeAlt12Green)cached;
        
            var result = new SimpleTypeAlt12Green(SoalSyntaxKind.SimpleTypeAlt12, kDuration);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal SimpleTypeAlt13Green SimpleTypeAlt13(QualifierGreen qualifier)
        {
            #if DEBUG
                if (qualifier is null) throw new __ArgumentNullException(nameof(qualifier));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(SoalSyntaxKind)SoalSyntaxKind.SimpleTypeAlt13, qualifier, out hash);
            if (cached != null) return (SimpleTypeAlt13Green)cached;
        
            var result = new SimpleTypeAlt13Green(SoalSyntaxKind.SimpleTypeAlt13, qualifier);
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
            var cached = __SyntaxNodeCache.TryGetNode((int)(SoalSyntaxKind)SoalSyntaxKind.Name, identifier, out hash);
            if (cached != null) return (NameGreen)cached;
        
            var result = new NameGreen(SoalSyntaxKind.Name, identifier);
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
            var cached = __SyntaxNodeCache.TryGetNode((int)(SoalSyntaxKind)SoalSyntaxKind.Qualifier, identifier.Node, out hash);
            if (cached != null) return (QualifierGreen)cached;
        
            var result = new QualifierGreen(SoalSyntaxKind.Qualifier, identifier.Node);
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
                if (token.RawKind != (int)SoalSyntaxKind.TIdentifier && token.RawKind != (int)SoalSyntaxKind.TVerbatimIdentifier) throw new __ArgumentException(nameof(token));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(SoalSyntaxKind)SoalSyntaxKind.Identifier, token, out hash);
            if (cached != null) return (IdentifierGreen)cached;
        
            var result = new IdentifierGreen(SoalSyntaxKind.Identifier, token);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal MainBlock1Green MainBlock1(global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<DeclarationGreen> declarationList)
        {
            #if DEBUG
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(SoalSyntaxKind)SoalSyntaxKind.MainBlock1, declarationList.Node, out hash);
            if (cached != null) return (MainBlock1Green)cached;
        
            var result = new MainBlock1Green(SoalSyntaxKind.MainBlock1, declarationList.Node);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal EnumTypeBlock1Green EnumTypeBlock1(global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<EnumLiteralGreen> literals)
        {
            #if DEBUG
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(SoalSyntaxKind)SoalSyntaxKind.EnumTypeBlock1, literals.Node, out hash);
            if (cached != null) return (EnumTypeBlock1Green)cached;
        
            var result = new EnumTypeBlock1Green(SoalSyntaxKind.EnumTypeBlock1, literals.Node);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal EnumTypeBlock1literalsBlockGreen EnumTypeBlock1literalsBlock(__InternalSyntaxToken tComma, EnumLiteralGreen literals)
        {
            #if DEBUG
                if (tComma is null) throw new __ArgumentNullException(nameof(tComma));
                if (tComma.RawKind != (int)SoalSyntaxKind.TComma) throw new __ArgumentException(nameof(tComma));
                if (literals is null) throw new __ArgumentNullException(nameof(literals));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(SoalSyntaxKind)SoalSyntaxKind.EnumTypeBlock1literalsBlock, tComma, literals, out hash);
            if (cached != null) return (EnumTypeBlock1literalsBlockGreen)cached;
        
            var result = new EnumTypeBlock1literalsBlockGreen(SoalSyntaxKind.EnumTypeBlock1literalsBlock, tComma, literals);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal StructTypeBlock1Green StructTypeBlock1(__InternalSyntaxToken tColon, QualifierGreen baseType)
        {
            #if DEBUG
                if (tColon is null) throw new __ArgumentNullException(nameof(tColon));
                if (tColon.RawKind != (int)SoalSyntaxKind.TColon) throw new __ArgumentException(nameof(tColon));
                if (baseType is null) throw new __ArgumentNullException(nameof(baseType));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(SoalSyntaxKind)SoalSyntaxKind.StructTypeBlock1, tColon, baseType, out hash);
            if (cached != null) return (StructTypeBlock1Green)cached;
        
            var result = new StructTypeBlock1Green(SoalSyntaxKind.StructTypeBlock1, tColon, baseType);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal ResourceBlock1Green ResourceBlock1(__InternalSyntaxToken kThrows, global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<QualifierGreen> exceptions)
        {
            #if DEBUG
                if (kThrows is null) throw new __ArgumentNullException(nameof(kThrows));
                if (kThrows.RawKind != (int)SoalSyntaxKind.KThrows) throw new __ArgumentException(nameof(kThrows));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(SoalSyntaxKind)SoalSyntaxKind.ResourceBlock1, kThrows, exceptions.Node, out hash);
            if (cached != null) return (ResourceBlock1Green)cached;
        
            var result = new ResourceBlock1Green(SoalSyntaxKind.ResourceBlock1, kThrows, exceptions.Node);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal ResourceBlock1exceptionsBlockGreen ResourceBlock1exceptionsBlock(__InternalSyntaxToken tComma, QualifierGreen exceptions)
        {
            #if DEBUG
                if (tComma is null) throw new __ArgumentNullException(nameof(tComma));
                if (tComma.RawKind != (int)SoalSyntaxKind.TComma) throw new __ArgumentException(nameof(tComma));
                if (exceptions is null) throw new __ArgumentNullException(nameof(exceptions));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(SoalSyntaxKind)SoalSyntaxKind.ResourceBlock1exceptionsBlock, tComma, exceptions, out hash);
            if (cached != null) return (ResourceBlock1exceptionsBlockGreen)cached;
        
            var result = new ResourceBlock1exceptionsBlockGreen(SoalSyntaxKind.ResourceBlock1exceptionsBlock, tComma, exceptions);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal OperationBlock1Green OperationBlock1(__InternalSyntaxToken kThrows, global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<QualifierGreen> exceptions)
        {
            #if DEBUG
                if (kThrows is null) throw new __ArgumentNullException(nameof(kThrows));
                if (kThrows.RawKind != (int)SoalSyntaxKind.KThrows) throw new __ArgumentException(nameof(kThrows));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(SoalSyntaxKind)SoalSyntaxKind.OperationBlock1, kThrows, exceptions.Node, out hash);
            if (cached != null) return (OperationBlock1Green)cached;
        
            var result = new OperationBlock1Green(SoalSyntaxKind.OperationBlock1, kThrows, exceptions.Node);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal OperationBlock1exceptionsBlockGreen OperationBlock1exceptionsBlock(__InternalSyntaxToken tComma, QualifierGreen exceptions)
        {
            #if DEBUG
                if (tComma is null) throw new __ArgumentNullException(nameof(tComma));
                if (tComma.RawKind != (int)SoalSyntaxKind.TComma) throw new __ArgumentException(nameof(tComma));
                if (exceptions is null) throw new __ArgumentNullException(nameof(exceptions));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(SoalSyntaxKind)SoalSyntaxKind.OperationBlock1exceptionsBlock, tComma, exceptions, out hash);
            if (cached != null) return (OperationBlock1exceptionsBlockGreen)cached;
        
            var result = new OperationBlock1exceptionsBlockGreen(SoalSyntaxKind.OperationBlock1exceptionsBlock, tComma, exceptions);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal InputParameterListBlock1Green InputParameterListBlock1(global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<ParameterGreen> parameters)
        {
            #if DEBUG
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(SoalSyntaxKind)SoalSyntaxKind.InputParameterListBlock1, parameters.Node, out hash);
            if (cached != null) return (InputParameterListBlock1Green)cached;
        
            var result = new InputParameterListBlock1Green(SoalSyntaxKind.InputParameterListBlock1, parameters.Node);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal InputParameterListBlock1parametersBlockGreen InputParameterListBlock1parametersBlock(__InternalSyntaxToken tComma, ParameterGreen parameters)
        {
            #if DEBUG
                if (tComma is null) throw new __ArgumentNullException(nameof(tComma));
                if (tComma.RawKind != (int)SoalSyntaxKind.TComma) throw new __ArgumentException(nameof(tComma));
                if (parameters is null) throw new __ArgumentNullException(nameof(parameters));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(SoalSyntaxKind)SoalSyntaxKind.InputParameterListBlock1parametersBlock, tComma, parameters, out hash);
            if (cached != null) return (InputParameterListBlock1parametersBlockGreen)cached;
        
            var result = new InputParameterListBlock1parametersBlockGreen(SoalSyntaxKind.InputParameterListBlock1parametersBlock, tComma, parameters);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal OutputParameterListAlt3parametersBlockGreen OutputParameterListAlt3parametersBlock(__InternalSyntaxToken tComma, ParameterGreen parameters)
        {
            #if DEBUG
                if (tComma is null) throw new __ArgumentNullException(nameof(tComma));
                if (tComma.RawKind != (int)SoalSyntaxKind.TComma) throw new __ArgumentException(nameof(tComma));
                if (parameters is null) throw new __ArgumentNullException(nameof(parameters));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(SoalSyntaxKind)SoalSyntaxKind.OutputParameterListAlt3parametersBlock, tComma, parameters, out hash);
            if (cached != null) return (OutputParameterListAlt3parametersBlockGreen)cached;
        
            var result = new OutputParameterListAlt3parametersBlockGreen(SoalSyntaxKind.OutputParameterListAlt3parametersBlock, tComma, parameters);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
        internal TypeReferenceBlock1Green TypeReferenceBlock1(__InternalSyntaxToken tLBracket, __InternalSyntaxToken tRBracket)
        {
            #if DEBUG
                if (tLBracket is null) throw new __ArgumentNullException(nameof(tLBracket));
                if (tLBracket.RawKind != (int)SoalSyntaxKind.TLBracket) throw new __ArgumentException(nameof(tLBracket));
                if (tRBracket is null) throw new __ArgumentNullException(nameof(tRBracket));
                if (tRBracket.RawKind != (int)SoalSyntaxKind.TRBracket) throw new __ArgumentException(nameof(tRBracket));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(SoalSyntaxKind)SoalSyntaxKind.TypeReferenceBlock1, tLBracket, tRBracket, out hash);
            if (cached != null) return (TypeReferenceBlock1Green)cached;
        
            var result = new TypeReferenceBlock1Green(SoalSyntaxKind.TypeReferenceBlock1, tLBracket, tRBracket);
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
                if (tDot.RawKind != (int)SoalSyntaxKind.TDot) throw new __ArgumentException(nameof(tDot));
                if (identifier is null) throw new __ArgumentNullException(nameof(identifier));
            #endif
            int hash;
            var cached = __SyntaxNodeCache.TryGetNode((int)(SoalSyntaxKind)SoalSyntaxKind.QualifierIdentifierBlock, tDot, identifier, out hash);
            if (cached != null) return (QualifierIdentifierBlockGreen)cached;
        
            var result = new QualifierIdentifierBlockGreen(SoalSyntaxKind.QualifierIdentifierBlock, tDot, identifier);
            if (hash >= 0)
            {
                __SyntaxNodeCache.AddNode(result, hash);
            }
        
            return result;
        }
    }
}
