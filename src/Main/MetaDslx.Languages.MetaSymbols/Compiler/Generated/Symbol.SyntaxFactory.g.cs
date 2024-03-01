#nullable enable

namespace MetaDslx.Languages.MetaSymbols.Compiler.Syntax
{
    using __Type = global::System.Type;
    using __Debug = global::System.Diagnostics.Debug;
    using __Encoding = global::System.Text.Encoding;
    using __Language = global::MetaDslx.CodeAnalysis.Language;
    using __ParseOptions = global::MetaDslx.CodeAnalysis.ParseOptions;
    using __DiagnosticInfo = global::MetaDslx.CodeAnalysis.DiagnosticInfo;
    using __SyntaxAnnotation = global::MetaDslx.CodeAnalysis.SyntaxAnnotation;
    using __SyntaxNodeCache = MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxNodeCache;
    using __IncrementalParseData = global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.IncrementalParseData;
    using __InternalSyntaxKind = global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.InternalSyntaxKind;
    using __InternalSyntaxToken = global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.InternalSyntaxToken;
    using __GreenNodeExtensions = MetaDslx.CodeAnalysis.Syntax.InternalSyntax.GreenNodeExtensions;
    using __SyntaxLexer = global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxLexer;
    using __SyntaxParser = global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxParser;
    using __SyntaxTree = global::MetaDslx.CodeAnalysis.SyntaxTree;
    using __SyntaxFacts = global::MetaDslx.CodeAnalysis.Syntax.SyntaxFacts;
    using __SyntaxToken = global::MetaDslx.CodeAnalysis.SyntaxToken;
    using __SyntaxTrivia = global::MetaDslx.CodeAnalysis.SyntaxTrivia;
    using __SyntaxTriviaList = global::MetaDslx.CodeAnalysis.SyntaxTriviaList;
    using __SyntaxNode = global::MetaDslx.CodeAnalysis.SyntaxNode;
    using __SourceText = global::MetaDslx.CodeAnalysis.Text.SourceText;
    using __TextChangeRange = global::MetaDslx.CodeAnalysis.Text.TextChangeRange;
    using __CancellationToken = global::System.Threading.CancellationToken;
    using __ArgumentNullException = global::System.ArgumentNullException;
    using __ArgumentException = global::System.ArgumentException;
    using __BinderFactory = global::MetaDslx.CodeAnalysis.Binding.BinderFactory;
    using __BinderFactoryVisitor = global::MetaDslx.CodeAnalysis.Binding.BinderFactoryVisitor;

    public class SymbolSyntaxFactory : global::MetaDslx.CodeAnalysis.Syntax.SyntaxFactory
    {
        public SymbolSyntaxFactory(global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.InternalSyntaxFactory internalSyntaxFactory) 
            : base(internalSyntaxFactory)
        {
        }

        public override __Language Language => SymbolLanguage.Instance;

        public override __ParseOptions DefaultParseOptions => SymbolParseOptions.Default;

        /// <summary>
        /// Create a new syntax tree from a syntax node.
        /// </summary>
        public SymbolSyntaxTree SyntaxTree(__SyntaxNode root, SymbolParseOptions? options = null, string? path = "", __Encoding? encoding = null)
        {
            return SymbolSyntaxTree.Create((SymbolSyntaxNode)root, __IncrementalParseData.Empty, options, path, null, encoding);
        }

        /// <summary>
        /// Produces a syntax tree by parsing the source text.
        /// </summary>
        public SymbolSyntaxTree ParseSyntaxTree(
            string text,
            SymbolParseOptions options = null,
            string path = "",
            __Encoding encoding = null,
            __CancellationToken cancellationToken = default)
        {
            return (SymbolSyntaxTree)this.ParseSyntaxTreeCore(__SourceText.From(text, encoding), options, path, cancellationToken);
        }

        /// <summary>
        /// Produces a syntax tree by parsing the source text.
        /// </summary>
        public SymbolSyntaxTree ParseSyntaxTree(
            __SourceText text,
            SymbolParseOptions? options = null,
            string path = "",
            __CancellationToken cancellationToken = default)
        {
            return (SymbolSyntaxTree)this.ParseSyntaxTreeCore(text, options, path, cancellationToken);
        }

        protected override __SyntaxTree ParseSyntaxTreeCore(
            __SourceText text,
            __ParseOptions? options = null,
            string path = "",
            __CancellationToken cancellationToken = default)
        {
            return SymbolSyntaxTree.ParseText(text, (SymbolParseOptions?)options, path, cancellationToken);
        }

        public override __SyntaxTree MakeSyntaxTree(__SyntaxNode root, __ParseOptions? options = null, string path = "", __Encoding? encoding = null)
        {
            return SymbolSyntaxTree.Create((SymbolSyntaxNode)root, __IncrementalParseData.Empty, (SymbolParseOptions)options, path, null, encoding);
        }

        /// <summary>
        /// Creates a token corresponding to a syntax kind. This method can be used for token syntax kinds whose text
        /// can be inferred by the kind alone.
        /// </summary>
        /// <param name="kind">A syntax kind value for a token. These have the suffix Token or Keyword.</param>
        /// <returns></returns>
        public virtual __SyntaxToken Token(SymbolSyntaxKind kind)
        {
            return this.Token((int)kind);
        }

        /// <summary>
        /// Creates a token corresponding to syntax kind. This method can be used for token syntax kinds whose text can
        /// be inferred by the kind alone.
        /// </summary>
        /// <param name="leading">A list of trivia immediately preceding the token.</param>
        /// <param name="kind">A syntax kind value for a token. These have the suffix Token or Keyword.</param>
        /// <param name="trailing">A list of trivia immediately following the token.</param>
        public virtual __SyntaxToken Token(__SyntaxTriviaList leading, SymbolSyntaxKind kind, __SyntaxTriviaList trailing)
        {
            return this.Token(leading, (int)kind, trailing);
        }

        /// <summary>
        /// Creates a token corresponding to syntax kind. This method gives control over token Text and ValueText.
        /// 
        /// For example, consider the text '&lt;see cref="operator &amp;#43;"/&gt;'.  To create a token for the value of
        /// the operator symbol (&amp;#43;), one would call 
        /// Token(default(__SyntaxTriviaList), int.PlusToken, "&amp;#43;", "+", default(__SyntaxTriviaList)).
        /// </summary>
        /// <param name="leading">A list of trivia immediately preceding the token.</param>
        /// <param name="kind">A syntax kind value for a token. These have the suffix Token or Keyword.</param>
        /// <param name="text">The text from which this token was created (e.g. lexed).</param>
        /// <param name="valueText">How C# should interpret the text of this token.</param>
        /// <param name="trailing">A list of trivia immediately following the token.</param>
        public virtual __SyntaxToken Token(__SyntaxTriviaList leading, SymbolSyntaxKind kind, string text, string valueText, __SyntaxTriviaList trailing)
        {
            return this.Token(leading, (int)kind, text, valueText, trailing);
        }

        /// <summary>
        /// Creates a missing token corresponding to syntax kind. A missing token is produced by the parser when an
        /// expected token is not found. A missing token has no text and normally has associated diagnostics.
        /// </summary>
        /// <param name="kind">A syntax kind value for a token. These have the suffix Token or Keyword.</param>
        public virtual __SyntaxToken MissingToken(SymbolSyntaxKind kind)
        {
            return this.MissingToken((int)kind);
        }

        /// <summary>
        /// Creates a missing token corresponding to syntax kind. A missing token is produced by the parser when an
        /// expected token is not found. A missing token has no text and normally has associated diagnostics.
        /// </summary>
        /// <param name="leading">A list of trivia immediately preceding the token.</param>
        /// <param name="kind">A syntax kind value for a token. These have the suffix Token or Keyword.</param>
        /// <param name="trailing">A list of trivia immediately following the token.</param>
        public virtual __SyntaxToken MissingToken(__SyntaxTriviaList leading, SymbolSyntaxKind kind, __SyntaxTriviaList trailing)
        {
            return this.MissingToken(leading, (int)kind, trailing);
        }


        public __SyntaxToken TInteger(string text)
        {
            return new __SyntaxToken(SymbolLanguage.Instance.InternalSyntaxFactory.TInteger(text));
        }

        public __SyntaxToken TInteger(string text, object value)
        {
            return new __SyntaxToken(SymbolLanguage.Instance.InternalSyntaxFactory.TInteger(text, value));
        }

        public __SyntaxToken TDecimal(string text)
        {
            return new __SyntaxToken(SymbolLanguage.Instance.InternalSyntaxFactory.TDecimal(text));
        }

        public __SyntaxToken TDecimal(string text, object value)
        {
            return new __SyntaxToken(SymbolLanguage.Instance.InternalSyntaxFactory.TDecimal(text, value));
        }

        public __SyntaxToken TIdentifier(string text)
        {
            return new __SyntaxToken(SymbolLanguage.Instance.InternalSyntaxFactory.TIdentifier(text));
        }

        public __SyntaxToken TIdentifier(string text, object value)
        {
            return new __SyntaxToken(SymbolLanguage.Instance.InternalSyntaxFactory.TIdentifier(text, value));
        }

        public __SyntaxToken TVerbatimIdentifier(string text)
        {
            return new __SyntaxToken(SymbolLanguage.Instance.InternalSyntaxFactory.TVerbatimIdentifier(text));
        }

        public __SyntaxToken TVerbatimIdentifier(string text, object value)
        {
            return new __SyntaxToken(SymbolLanguage.Instance.InternalSyntaxFactory.TVerbatimIdentifier(text, value));
        }

        public __SyntaxToken TString(string text)
        {
            return new __SyntaxToken(SymbolLanguage.Instance.InternalSyntaxFactory.TString(text));
        }

        public __SyntaxToken TString(string text, object value)
        {
            return new __SyntaxToken(SymbolLanguage.Instance.InternalSyntaxFactory.TString(text, value));
        }

        public __SyntaxToken TWhitespace(string text)
        {
            return new __SyntaxToken(SymbolLanguage.Instance.InternalSyntaxFactory.TWhitespace(text));
        }

        public __SyntaxToken TWhitespace(string text, object value)
        {
            return new __SyntaxToken(SymbolLanguage.Instance.InternalSyntaxFactory.TWhitespace(text, value));
        }

        public __SyntaxToken TLineEnd(string text)
        {
            return new __SyntaxToken(SymbolLanguage.Instance.InternalSyntaxFactory.TLineEnd(text));
        }

        public __SyntaxToken TLineEnd(string text, object value)
        {
            return new __SyntaxToken(SymbolLanguage.Instance.InternalSyntaxFactory.TLineEnd(text, value));
        }

        public __SyntaxToken TSingleLineComment(string text)
        {
            return new __SyntaxToken(SymbolLanguage.Instance.InternalSyntaxFactory.TSingleLineComment(text));
        }

        public __SyntaxToken TSingleLineComment(string text, object value)
        {
            return new __SyntaxToken(SymbolLanguage.Instance.InternalSyntaxFactory.TSingleLineComment(text, value));
        }

        public __SyntaxToken TMultiLineComment(string text)
        {
            return new __SyntaxToken(SymbolLanguage.Instance.InternalSyntaxFactory.TMultiLineComment(text));
        }

        public __SyntaxToken TMultiLineComment(string text, object value)
        {
            return new __SyntaxToken(SymbolLanguage.Instance.InternalSyntaxFactory.TMultiLineComment(text, value));
        }

        public __SyntaxToken TInvalidToken(string text)
        {
            return new __SyntaxToken(SymbolLanguage.Instance.InternalSyntaxFactory.TInvalidToken(text));
        }

        public __SyntaxToken TInvalidToken(string text, object value)
        {
            return new __SyntaxToken(SymbolLanguage.Instance.InternalSyntaxFactory.TInvalidToken(text, value));
        }

        public MainSyntax Main(__SyntaxToken kNamespace, QualifierSyntax qualifier, global::MetaDslx.CodeAnalysis.SyntaxList<UsingSyntax> usingList, MainBlock1Syntax block, __SyntaxToken endOfFileToken)
        {
            if (kNamespace.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(kNamespace));
            if (kNamespace.RawKind != (int)SymbolSyntaxKind.KNamespace) throw new __ArgumentException(nameof(kNamespace));
            if (qualifier is null) throw new __ArgumentNullException(nameof(qualifier));
            if (block is null) throw new __ArgumentNullException(nameof(block));
            if (endOfFileToken.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(endOfFileToken));
            if (endOfFileToken.RawKind != (int)__InternalSyntaxKind.Eof) throw new __ArgumentException(nameof(endOfFileToken));
            return (MainSyntax)SymbolLanguage.Instance.InternalSyntaxFactory.Main((__InternalSyntaxToken)kNamespace.Node, (InternalSyntax.QualifierGreen)qualifier.Green, __GreenNodeExtensions.ToGreenList<InternalSyntax.UsingGreen>(usingList.Node), (InternalSyntax.MainBlock1Green)block.Green, (__InternalSyntaxToken)endOfFileToken.Node).CreateRed();
        }
        
        public MainSyntax Main(QualifierSyntax qualifier, global::MetaDslx.CodeAnalysis.SyntaxList<UsingSyntax> usingList, MainBlock1Syntax block, __SyntaxToken endOfFileToken)
        {
            return this.Main(this.Token(SymbolSyntaxKind.KNamespace), qualifier, usingList, block, this.Token(SymbolSyntaxKind.Eof));
        }

        public UsingSyntax Using(__SyntaxToken kUsing, QualifierSyntax namespaces)
        {
            if (kUsing.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(kUsing));
            if (kUsing.RawKind != (int)SymbolSyntaxKind.KUsing) throw new __ArgumentException(nameof(kUsing));
            if (namespaces is null) throw new __ArgumentNullException(nameof(namespaces));
            return (UsingSyntax)SymbolLanguage.Instance.InternalSyntaxFactory.Using((__InternalSyntaxToken)kUsing.Node, (InternalSyntax.QualifierGreen)namespaces.Green).CreateRed();
        }
        
        public UsingSyntax Using(QualifierSyntax namespaces)
        {
            return this.Using(this.Token(SymbolSyntaxKind.KUsing), namespaces);
        }

        public SymbolSyntax Symbol(__SyntaxToken isAbstract, __SyntaxToken kSymbol, NameSyntax name, SymbolBlock1Syntax block1, SymbolBlock2Syntax block2)
        {
            if (isAbstract.RawKind != (int)__InternalSyntaxKind.None && (isAbstract.RawKind != (int)SymbolSyntaxKind.KAbstract)) throw new __ArgumentException(nameof(isAbstract));
            if (kSymbol.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(kSymbol));
            if (kSymbol.RawKind != (int)SymbolSyntaxKind.KSymbol) throw new __ArgumentException(nameof(kSymbol));
            if (name is null) throw new __ArgumentNullException(nameof(name));
            if (block2 is null) throw new __ArgumentNullException(nameof(block2));
            return (SymbolSyntax)SymbolLanguage.Instance.InternalSyntaxFactory.Symbol((__InternalSyntaxToken)isAbstract.Node, (__InternalSyntaxToken)kSymbol.Node, (InternalSyntax.NameGreen)name.Green, (InternalSyntax.SymbolBlock1Green)block1.Green, (InternalSyntax.SymbolBlock2Green)block2.Green).CreateRed();
        }
        
        public SymbolSyntax Symbol(NameSyntax name, SymbolBlock2Syntax block2)
        {
            return this.Symbol(default, this.Token(SymbolSyntaxKind.KSymbol), name, default, block2);
        }

        public PropertySyntax Property(PropertyBlock1Syntax block1, TypeReferenceSyntax type, NameSyntax name, PropertyBlock2Syntax block2, PropertyBlock3Syntax block3)
        {
            if (type is null) throw new __ArgumentNullException(nameof(type));
            if (name is null) throw new __ArgumentNullException(nameof(name));
            return (PropertySyntax)SymbolLanguage.Instance.InternalSyntaxFactory.Property((InternalSyntax.PropertyBlock1Green)block1.Green, (InternalSyntax.TypeReferenceGreen)type.Green, (InternalSyntax.NameGreen)name.Green, (InternalSyntax.PropertyBlock2Green)block2.Green, (InternalSyntax.PropertyBlock3Green)block3.Green).CreateRed();
        }
        
        public PropertySyntax Property(TypeReferenceSyntax type, NameSyntax name)
        {
            return this.Property(default, type, name, default, default);
        }

        public OperationAlt1Syntax OperationAlt1(__SyntaxToken isPhase, NameSyntax name, __SyntaxToken tLParen, __SyntaxToken tRParen)
        {
            if (isPhase.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(isPhase));
            if (isPhase.RawKind != (int)SymbolSyntaxKind.KPhase) throw new __ArgumentException(nameof(isPhase));
            if (name is null) throw new __ArgumentNullException(nameof(name));
            if (tLParen.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tLParen));
            if (tLParen.RawKind != (int)SymbolSyntaxKind.TLParen) throw new __ArgumentException(nameof(tLParen));
            if (tRParen.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tRParen));
            if (tRParen.RawKind != (int)SymbolSyntaxKind.TRParen) throw new __ArgumentException(nameof(tRParen));
            return (OperationAlt1Syntax)SymbolLanguage.Instance.InternalSyntaxFactory.OperationAlt1((__InternalSyntaxToken)isPhase.Node, (InternalSyntax.NameGreen)name.Green, (__InternalSyntaxToken)tLParen.Node, (__InternalSyntaxToken)tRParen.Node).CreateRed();
        }
        
        public OperationAlt1Syntax OperationAlt1(NameSyntax name)
        {
            return this.OperationAlt1(this.Token(SymbolSyntaxKind.KPhase), name, this.Token(SymbolSyntaxKind.TLParen), this.Token(SymbolSyntaxKind.TRParen));
        }

        public OperationAlt2Syntax OperationAlt2(__SyntaxToken isCached, TypeReferenceSyntax returnType, NameSyntax name, __SyntaxToken tLParen, OperationAlt2Block1Syntax block1, __SyntaxToken tRParen, OperationAlt2Block2Syntax block2)
        {
            if (isCached.RawKind != (int)__InternalSyntaxKind.None && (isCached.RawKind != (int)SymbolSyntaxKind.KCached)) throw new __ArgumentException(nameof(isCached));
            if (returnType is null) throw new __ArgumentNullException(nameof(returnType));
            if (name is null) throw new __ArgumentNullException(nameof(name));
            if (tLParen.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tLParen));
            if (tLParen.RawKind != (int)SymbolSyntaxKind.TLParen) throw new __ArgumentException(nameof(tLParen));
            if (tRParen.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tRParen));
            if (tRParen.RawKind != (int)SymbolSyntaxKind.TRParen) throw new __ArgumentException(nameof(tRParen));
            return (OperationAlt2Syntax)SymbolLanguage.Instance.InternalSyntaxFactory.OperationAlt2((__InternalSyntaxToken)isCached.Node, (InternalSyntax.TypeReferenceGreen)returnType.Green, (InternalSyntax.NameGreen)name.Green, (__InternalSyntaxToken)tLParen.Node, (InternalSyntax.OperationAlt2Block1Green)block1.Green, (__InternalSyntaxToken)tRParen.Node, (InternalSyntax.OperationAlt2Block2Green)block2.Green).CreateRed();
        }
        
        public OperationAlt2Syntax OperationAlt2(TypeReferenceSyntax returnType, NameSyntax name)
        {
            return this.OperationAlt2(default, returnType, name, this.Token(SymbolSyntaxKind.TLParen), default, this.Token(SymbolSyntaxKind.TRParen), default);
        }

        public ParameterSyntax Parameter(TypeReferenceSyntax type, NameSyntax name)
        {
            if (type is null) throw new __ArgumentNullException(nameof(type));
            if (name is null) throw new __ArgumentNullException(nameof(name));
            return (ParameterSyntax)SymbolLanguage.Instance.InternalSyntaxFactory.Parameter((InternalSyntax.TypeReferenceGreen)type.Green, (InternalSyntax.NameGreen)name.Green).CreateRed();
        }

        public TypeReferenceSyntax TypeReference(SimpleTypeReferenceSyntax type, TypeReferenceBlock1Syntax block, ArrayDimensionsSyntax dimensions)
        {
            if (type is null) throw new __ArgumentNullException(nameof(type));
            if (dimensions is null) throw new __ArgumentNullException(nameof(dimensions));
            return (TypeReferenceSyntax)SymbolLanguage.Instance.InternalSyntaxFactory.TypeReference((InternalSyntax.SimpleTypeReferenceGreen)type.Green, (InternalSyntax.TypeReferenceBlock1Green)block.Green, (InternalSyntax.ArrayDimensionsGreen)dimensions.Green).CreateRed();
        }
        
        public TypeReferenceSyntax TypeReference(SimpleTypeReferenceSyntax type, ArrayDimensionsSyntax dimensions)
        {
            return this.TypeReference(type, default, dimensions);
        }

        public ArrayDimensionsSyntax ArrayDimensions(global::MetaDslx.CodeAnalysis.SyntaxList<ArrayDimensionsBlock1Syntax> block)
        {
            return (ArrayDimensionsSyntax)SymbolLanguage.Instance.InternalSyntaxFactory.ArrayDimensions(__GreenNodeExtensions.ToGreenList<InternalSyntax.ArrayDimensionsBlock1Green>(block.Node)).CreateRed();
        }

        public SimpleTypeReferenceAlt1Syntax SimpleTypeReferenceAlt1(PrimitiveTypeSyntax primitiveType)
        {
            if (primitiveType is null) throw new __ArgumentNullException(nameof(primitiveType));
            return (SimpleTypeReferenceAlt1Syntax)SymbolLanguage.Instance.InternalSyntaxFactory.SimpleTypeReferenceAlt1((InternalSyntax.PrimitiveTypeGreen)primitiveType.Green).CreateRed();
        }

        public SimpleTypeReferenceAlt2Syntax SimpleTypeReferenceAlt2(QualifierSyntax qualifier)
        {
            if (qualifier is null) throw new __ArgumentNullException(nameof(qualifier));
            return (SimpleTypeReferenceAlt2Syntax)SymbolLanguage.Instance.InternalSyntaxFactory.SimpleTypeReferenceAlt2((InternalSyntax.QualifierGreen)qualifier.Green).CreateRed();
        }

        public PrimitiveTypeSyntax PrimitiveType(__SyntaxToken token)
        {
            if (token.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(token));
            if (token.RawKind != (int)SymbolSyntaxKind.KObject && token.RawKind != (int)SymbolSyntaxKind.KBool && token.RawKind != (int)SymbolSyntaxKind.KChar && token.RawKind != (int)SymbolSyntaxKind.KString && token.RawKind != (int)SymbolSyntaxKind.KByte && token.RawKind != (int)SymbolSyntaxKind.KSbyte && token.RawKind != (int)SymbolSyntaxKind.KShort && token.RawKind != (int)SymbolSyntaxKind.KUshort && token.RawKind != (int)SymbolSyntaxKind.KInt && token.RawKind != (int)SymbolSyntaxKind.KUint && token.RawKind != (int)SymbolSyntaxKind.KLong && token.RawKind != (int)SymbolSyntaxKind.KUlong && token.RawKind != (int)SymbolSyntaxKind.KFloat && token.RawKind != (int)SymbolSyntaxKind.KDouble && token.RawKind != (int)SymbolSyntaxKind.KDecimal && token.RawKind != (int)SymbolSyntaxKind.KType && token.RawKind != (int)SymbolSyntaxKind.KSymbol && token.RawKind != (int)SymbolSyntaxKind.KVoid) throw new __ArgumentException(nameof(token));
            return (PrimitiveTypeSyntax)SymbolLanguage.Instance.InternalSyntaxFactory.PrimitiveType((__InternalSyntaxToken)token.Node).CreateRed();
        }

        public ValueAlt1Syntax ValueAlt1(__SyntaxToken tString)
        {
            if (tString.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tString));
            if (tString.RawKind != (int)SymbolSyntaxKind.TString) throw new __ArgumentException(nameof(tString));
            return (ValueAlt1Syntax)SymbolLanguage.Instance.InternalSyntaxFactory.ValueAlt1((__InternalSyntaxToken)tString.Node).CreateRed();
        }

        public ValueAlt2Syntax ValueAlt2(__SyntaxToken tInteger)
        {
            if (tInteger.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tInteger));
            if (tInteger.RawKind != (int)SymbolSyntaxKind.TInteger) throw new __ArgumentException(nameof(tInteger));
            return (ValueAlt2Syntax)SymbolLanguage.Instance.InternalSyntaxFactory.ValueAlt2((__InternalSyntaxToken)tInteger.Node).CreateRed();
        }

        public ValueAlt3Syntax ValueAlt3(__SyntaxToken tDecimal)
        {
            if (tDecimal.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tDecimal));
            if (tDecimal.RawKind != (int)SymbolSyntaxKind.TDecimal) throw new __ArgumentException(nameof(tDecimal));
            return (ValueAlt3Syntax)SymbolLanguage.Instance.InternalSyntaxFactory.ValueAlt3((__InternalSyntaxToken)tDecimal.Node).CreateRed();
        }

        public ValueAlt4Syntax ValueAlt4(TBooleanSyntax tBoolean)
        {
            if (tBoolean is null) throw new __ArgumentNullException(nameof(tBoolean));
            return (ValueAlt4Syntax)SymbolLanguage.Instance.InternalSyntaxFactory.ValueAlt4((InternalSyntax.TBooleanGreen)tBoolean.Green).CreateRed();
        }

        public ValueAlt5Syntax ValueAlt5(__SyntaxToken kNull)
        {
            if (kNull.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(kNull));
            if (kNull.RawKind != (int)SymbolSyntaxKind.KNull) throw new __ArgumentException(nameof(kNull));
            return (ValueAlt5Syntax)SymbolLanguage.Instance.InternalSyntaxFactory.ValueAlt5((__InternalSyntaxToken)kNull.Node).CreateRed();
        }
        
        public ValueAlt5Syntax ValueAlt5()
        {
            return this.ValueAlt5(this.Token(SymbolSyntaxKind.KNull));
        }

        public ValueAlt6Syntax ValueAlt6(QualifierSyntax qualifier)
        {
            if (qualifier is null) throw new __ArgumentNullException(nameof(qualifier));
            return (ValueAlt6Syntax)SymbolLanguage.Instance.InternalSyntaxFactory.ValueAlt6((InternalSyntax.QualifierGreen)qualifier.Green).CreateRed();
        }

        public NameSyntax Name(IdentifierSyntax identifier)
        {
            if (identifier is null) throw new __ArgumentNullException(nameof(identifier));
            return (NameSyntax)SymbolLanguage.Instance.InternalSyntaxFactory.Name((InternalSyntax.IdentifierGreen)identifier.Green).CreateRed();
        }

        public QualifierSyntax Qualifier(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<IdentifierSyntax> identifier)
        {
            return (QualifierSyntax)SymbolLanguage.Instance.InternalSyntaxFactory.Qualifier(__GreenNodeExtensions.ToGreenSeparatedList<InternalSyntax.IdentifierGreen>(identifier.Node, reversed: false)).CreateRed();
        }

        public IdentifierSyntax Identifier(__SyntaxToken token)
        {
            if (token.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(token));
            if (token.RawKind != (int)SymbolSyntaxKind.TIdentifier && token.RawKind != (int)SymbolSyntaxKind.TVerbatimIdentifier) throw new __ArgumentException(nameof(token));
            return (IdentifierSyntax)SymbolLanguage.Instance.InternalSyntaxFactory.Identifier((__InternalSyntaxToken)token.Node).CreateRed();
        }

        public TBooleanSyntax TBoolean(__SyntaxToken token)
        {
            if (token.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(token));
            if (token.RawKind != (int)SymbolSyntaxKind.KTrue && token.RawKind != (int)SymbolSyntaxKind.KFalse) throw new __ArgumentException(nameof(token));
            return (TBooleanSyntax)SymbolLanguage.Instance.InternalSyntaxFactory.TBoolean((__InternalSyntaxToken)token.Node).CreateRed();
        }

        public MainBlock1Syntax MainBlock1(global::MetaDslx.CodeAnalysis.SyntaxList<SymbolSyntax> declarations)
        {
            return (MainBlock1Syntax)SymbolLanguage.Instance.InternalSyntaxFactory.MainBlock1(__GreenNodeExtensions.ToGreenList<InternalSyntax.SymbolGreen>(declarations.Node)).CreateRed();
        }

        public SymbolBlock1Syntax SymbolBlock1(__SyntaxToken tColon, QualifierSyntax baseTypes)
        {
            if (tColon.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tColon));
            if (tColon.RawKind != (int)SymbolSyntaxKind.TColon) throw new __ArgumentException(nameof(tColon));
            if (baseTypes is null) throw new __ArgumentNullException(nameof(baseTypes));
            return (SymbolBlock1Syntax)SymbolLanguage.Instance.InternalSyntaxFactory.SymbolBlock1((__InternalSyntaxToken)tColon.Node, (InternalSyntax.QualifierGreen)baseTypes.Green).CreateRed();
        }
        
        public SymbolBlock1Syntax SymbolBlock1(QualifierSyntax baseTypes)
        {
            return this.SymbolBlock1(this.Token(SymbolSyntaxKind.TColon), baseTypes);
        }

        public SymbolBlock2Syntax SymbolBlock2(__SyntaxToken tLBrace, global::MetaDslx.CodeAnalysis.SyntaxList<SymbolBlock2Block1Syntax> block, __SyntaxToken tRBrace)
        {
            if (tLBrace.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tLBrace));
            if (tLBrace.RawKind != (int)SymbolSyntaxKind.TLBrace) throw new __ArgumentException(nameof(tLBrace));
            if (tRBrace.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tRBrace));
            if (tRBrace.RawKind != (int)SymbolSyntaxKind.TRBrace) throw new __ArgumentException(nameof(tRBrace));
            return (SymbolBlock2Syntax)SymbolLanguage.Instance.InternalSyntaxFactory.SymbolBlock2((__InternalSyntaxToken)tLBrace.Node, __GreenNodeExtensions.ToGreenList<InternalSyntax.SymbolBlock2Block1Green>(block.Node), (__InternalSyntaxToken)tRBrace.Node).CreateRed();
        }
        
        public SymbolBlock2Syntax SymbolBlock2(global::MetaDslx.CodeAnalysis.SyntaxList<SymbolBlock2Block1Syntax> block)
        {
            return this.SymbolBlock2(this.Token(SymbolSyntaxKind.TLBrace), block, this.Token(SymbolSyntaxKind.TRBrace));
        }

        public SymbolBlock2Block1Alt1Syntax SymbolBlock2Block1Alt1(PropertySyntax properties)
        {
            if (properties is null) throw new __ArgumentNullException(nameof(properties));
            return (SymbolBlock2Block1Alt1Syntax)SymbolLanguage.Instance.InternalSyntaxFactory.SymbolBlock2Block1Alt1((InternalSyntax.PropertyGreen)properties.Green).CreateRed();
        }

        public SymbolBlock2Block1Alt2Syntax SymbolBlock2Block1Alt2(OperationSyntax operations)
        {
            if (operations is null) throw new __ArgumentNullException(nameof(operations));
            return (SymbolBlock2Block1Alt2Syntax)SymbolLanguage.Instance.InternalSyntaxFactory.SymbolBlock2Block1Alt2((InternalSyntax.OperationGreen)operations.Green).CreateRed();
        }

        public PropertyBlock1Alt1Syntax PropertyBlock1Alt1(__SyntaxToken isPlain, PropertyBlock1Alt1Block1Syntax block)
        {
            if (isPlain.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(isPlain));
            if (isPlain.RawKind != (int)SymbolSyntaxKind.KPlain) throw new __ArgumentException(nameof(isPlain));
            return (PropertyBlock1Alt1Syntax)SymbolLanguage.Instance.InternalSyntaxFactory.PropertyBlock1Alt1((__InternalSyntaxToken)isPlain.Node, (InternalSyntax.PropertyBlock1Alt1Block1Green)block.Green).CreateRed();
        }
        
        public PropertyBlock1Alt1Syntax PropertyBlock1Alt1()
        {
            return this.PropertyBlock1Alt1(this.Token(SymbolSyntaxKind.KPlain), default);
        }

        public PropertyBlock1Alt2Syntax PropertyBlock1Alt2(__SyntaxToken isDerived, __SyntaxToken isCached, __SyntaxToken isWeak)
        {
            if (isDerived.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(isDerived));
            if (isDerived.RawKind != (int)SymbolSyntaxKind.KDerived) throw new __ArgumentException(nameof(isDerived));
            if (isCached.RawKind != (int)__InternalSyntaxKind.None && (isCached.RawKind != (int)SymbolSyntaxKind.KCached)) throw new __ArgumentException(nameof(isCached));
            if (isWeak.RawKind != (int)__InternalSyntaxKind.None && (isWeak.RawKind != (int)SymbolSyntaxKind.KWeak)) throw new __ArgumentException(nameof(isWeak));
            return (PropertyBlock1Alt2Syntax)SymbolLanguage.Instance.InternalSyntaxFactory.PropertyBlock1Alt2((__InternalSyntaxToken)isDerived.Node, (__InternalSyntaxToken)isCached.Node, (__InternalSyntaxToken)isWeak.Node).CreateRed();
        }
        
        public PropertyBlock1Alt2Syntax PropertyBlock1Alt2()
        {
            return this.PropertyBlock1Alt2(this.Token(SymbolSyntaxKind.KDerived), default, default);
        }

        public PropertyBlock1Alt3Syntax PropertyBlock1Alt3(__SyntaxToken isWeak)
        {
            if (isWeak.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(isWeak));
            if (isWeak.RawKind != (int)SymbolSyntaxKind.KWeak) throw new __ArgumentException(nameof(isWeak));
            return (PropertyBlock1Alt3Syntax)SymbolLanguage.Instance.InternalSyntaxFactory.PropertyBlock1Alt3((__InternalSyntaxToken)isWeak.Node).CreateRed();
        }
        
        public PropertyBlock1Alt3Syntax PropertyBlock1Alt3()
        {
            return this.PropertyBlock1Alt3(this.Token(SymbolSyntaxKind.KWeak));
        }

        public PropertyBlock1Alt1Block1Alt1Syntax PropertyBlock1Alt1Block1Alt1(__SyntaxToken isAbstract)
        {
            if (isAbstract.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(isAbstract));
            if (isAbstract.RawKind != (int)SymbolSyntaxKind.KAbstract) throw new __ArgumentException(nameof(isAbstract));
            return (PropertyBlock1Alt1Block1Alt1Syntax)SymbolLanguage.Instance.InternalSyntaxFactory.PropertyBlock1Alt1Block1Alt1((__InternalSyntaxToken)isAbstract.Node).CreateRed();
        }
        
        public PropertyBlock1Alt1Block1Alt1Syntax PropertyBlock1Alt1Block1Alt1()
        {
            return this.PropertyBlock1Alt1Block1Alt1(this.Token(SymbolSyntaxKind.KAbstract));
        }

        public PropertyBlock1Alt1Block1Alt2Syntax PropertyBlock1Alt1Block1Alt2(__SyntaxToken isWeak)
        {
            if (isWeak.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(isWeak));
            if (isWeak.RawKind != (int)SymbolSyntaxKind.KWeak) throw new __ArgumentException(nameof(isWeak));
            return (PropertyBlock1Alt1Block1Alt2Syntax)SymbolLanguage.Instance.InternalSyntaxFactory.PropertyBlock1Alt1Block1Alt2((__InternalSyntaxToken)isWeak.Node).CreateRed();
        }
        
        public PropertyBlock1Alt1Block1Alt2Syntax PropertyBlock1Alt1Block1Alt2()
        {
            return this.PropertyBlock1Alt1Block1Alt2(this.Token(SymbolSyntaxKind.KWeak));
        }

        public PropertyBlock2Syntax PropertyBlock2(__SyntaxToken tEq, ValueSyntax defaultValue)
        {
            if (tEq.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tEq));
            if (tEq.RawKind != (int)SymbolSyntaxKind.TEq) throw new __ArgumentException(nameof(tEq));
            if (defaultValue is null) throw new __ArgumentNullException(nameof(defaultValue));
            return (PropertyBlock2Syntax)SymbolLanguage.Instance.InternalSyntaxFactory.PropertyBlock2((__InternalSyntaxToken)tEq.Node, (InternalSyntax.ValueGreen)defaultValue.Green).CreateRed();
        }
        
        public PropertyBlock2Syntax PropertyBlock2(ValueSyntax defaultValue)
        {
            return this.PropertyBlock2(this.Token(SymbolSyntaxKind.TEq), defaultValue);
        }

        public PropertyBlock3Syntax PropertyBlock3(__SyntaxToken kPhase, IdentifierSyntax phase)
        {
            if (kPhase.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(kPhase));
            if (kPhase.RawKind != (int)SymbolSyntaxKind.KPhase) throw new __ArgumentException(nameof(kPhase));
            if (phase is null) throw new __ArgumentNullException(nameof(phase));
            return (PropertyBlock3Syntax)SymbolLanguage.Instance.InternalSyntaxFactory.PropertyBlock3((__InternalSyntaxToken)kPhase.Node, (InternalSyntax.IdentifierGreen)phase.Green).CreateRed();
        }
        
        public PropertyBlock3Syntax PropertyBlock3(IdentifierSyntax phase)
        {
            return this.PropertyBlock3(this.Token(SymbolSyntaxKind.KPhase), phase);
        }

        public OperationAlt2Block1Syntax OperationAlt2Block1(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<ParameterSyntax> parameters)
        {
            return (OperationAlt2Block1Syntax)SymbolLanguage.Instance.InternalSyntaxFactory.OperationAlt2Block1(__GreenNodeExtensions.ToGreenSeparatedList<InternalSyntax.ParameterGreen>(parameters.Node, reversed: false)).CreateRed();
        }

        public OperationAlt2Block1parametersBlockSyntax OperationAlt2Block1parametersBlock(__SyntaxToken tComma, ParameterSyntax parameters)
        {
            if (tComma.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tComma));
            if (tComma.RawKind != (int)SymbolSyntaxKind.TComma) throw new __ArgumentException(nameof(tComma));
            if (parameters is null) throw new __ArgumentNullException(nameof(parameters));
            return (OperationAlt2Block1parametersBlockSyntax)SymbolLanguage.Instance.InternalSyntaxFactory.OperationAlt2Block1parametersBlock((__InternalSyntaxToken)tComma.Node, (InternalSyntax.ParameterGreen)parameters.Green).CreateRed();
        }
        
        public OperationAlt2Block1parametersBlockSyntax OperationAlt2Block1parametersBlock(ParameterSyntax parameters)
        {
            return this.OperationAlt2Block1parametersBlock(this.Token(SymbolSyntaxKind.TComma), parameters);
        }

        public OperationAlt2Block2Syntax OperationAlt2Block2(__SyntaxToken kIf, __SyntaxToken cacheCondition)
        {
            if (kIf.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(kIf));
            if (kIf.RawKind != (int)SymbolSyntaxKind.KIf) throw new __ArgumentException(nameof(kIf));
            if (cacheCondition.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(cacheCondition));
            if (cacheCondition.RawKind != (int)SymbolSyntaxKind.TString) throw new __ArgumentException(nameof(cacheCondition));
            return (OperationAlt2Block2Syntax)SymbolLanguage.Instance.InternalSyntaxFactory.OperationAlt2Block2((__InternalSyntaxToken)kIf.Node, (__InternalSyntaxToken)cacheCondition.Node).CreateRed();
        }
        
        public OperationAlt2Block2Syntax OperationAlt2Block2(__SyntaxToken cacheCondition)
        {
            return this.OperationAlt2Block2(this.Token(SymbolSyntaxKind.KIf), this.Token(SymbolSyntaxKind.TString));
        }

        public TypeReferenceBlock1Syntax TypeReferenceBlock1(__SyntaxToken isNullable)
        {
            if (isNullable.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(isNullable));
            if (isNullable.RawKind != (int)SymbolSyntaxKind.TQuestion) throw new __ArgumentException(nameof(isNullable));
            return (TypeReferenceBlock1Syntax)SymbolLanguage.Instance.InternalSyntaxFactory.TypeReferenceBlock1((__InternalSyntaxToken)isNullable.Node).CreateRed();
        }
        
        public TypeReferenceBlock1Syntax TypeReferenceBlock1()
        {
            return this.TypeReferenceBlock1(this.Token(SymbolSyntaxKind.TQuestion));
        }

        public ArrayDimensionsBlock1Syntax ArrayDimensionsBlock1(__SyntaxToken tLBracket, __SyntaxToken tRBracket)
        {
            if (tLBracket.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tLBracket));
            if (tLBracket.RawKind != (int)SymbolSyntaxKind.TLBracket) throw new __ArgumentException(nameof(tLBracket));
            if (tRBracket.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tRBracket));
            if (tRBracket.RawKind != (int)SymbolSyntaxKind.TRBracket) throw new __ArgumentException(nameof(tRBracket));
            return (ArrayDimensionsBlock1Syntax)SymbolLanguage.Instance.InternalSyntaxFactory.ArrayDimensionsBlock1((__InternalSyntaxToken)tLBracket.Node, (__InternalSyntaxToken)tRBracket.Node).CreateRed();
        }
        
        public ArrayDimensionsBlock1Syntax ArrayDimensionsBlock1()
        {
            return this.ArrayDimensionsBlock1(this.Token(SymbolSyntaxKind.TLBracket), this.Token(SymbolSyntaxKind.TRBracket));
        }

        public QualifierIdentifierBlockSyntax QualifierIdentifierBlock(__SyntaxToken tDot, IdentifierSyntax identifier)
        {
            if (tDot.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tDot));
            if (tDot.RawKind != (int)SymbolSyntaxKind.TDot) throw new __ArgumentException(nameof(tDot));
            if (identifier is null) throw new __ArgumentNullException(nameof(identifier));
            return (QualifierIdentifierBlockSyntax)SymbolLanguage.Instance.InternalSyntaxFactory.QualifierIdentifierBlock((__InternalSyntaxToken)tDot.Node, (InternalSyntax.IdentifierGreen)identifier.Green).CreateRed();
        }
        
        public QualifierIdentifierBlockSyntax QualifierIdentifierBlock(IdentifierSyntax identifier)
        {
            return this.QualifierIdentifierBlock(this.Token(SymbolSyntaxKind.TDot), identifier);
        }

        public override __BinderFactoryVisitor CreateBinderFactoryVisitor(__BinderFactory binderFactory)
        {
            return new global::MetaDslx.Languages.MetaSymbols.Compiler.Binding.SymbolBinderFactoryVisitor(binderFactory);
        }

        internal static global::System.Collections.Generic.IEnumerable<__Type> GetNodeTypes()
        {
            return new __Type[] {
                typeof(MainSyntax),
                typeof(UsingSyntax),
                typeof(SymbolSyntax),
                typeof(PropertySyntax),
                typeof(OperationAlt1Syntax),
                typeof(OperationAlt2Syntax),
                typeof(ParameterSyntax),
                typeof(TypeReferenceSyntax),
                typeof(ArrayDimensionsSyntax),
                typeof(SimpleTypeReferenceAlt1Syntax),
                typeof(SimpleTypeReferenceAlt2Syntax),
                typeof(PrimitiveTypeSyntax),
                typeof(ValueAlt1Syntax),
                typeof(ValueAlt2Syntax),
                typeof(ValueAlt3Syntax),
                typeof(ValueAlt4Syntax),
                typeof(ValueAlt5Syntax),
                typeof(ValueAlt6Syntax),
                typeof(NameSyntax),
                typeof(QualifierSyntax),
                typeof(IdentifierSyntax),
                typeof(TBooleanSyntax),
                typeof(MainBlock1Syntax),
                typeof(SymbolBlock1Syntax),
                typeof(SymbolBlock2Syntax),
                typeof(SymbolBlock2Block1Alt1Syntax),
                typeof(SymbolBlock2Block1Alt2Syntax),
                typeof(PropertyBlock1Alt1Syntax),
                typeof(PropertyBlock1Alt2Syntax),
                typeof(PropertyBlock1Alt3Syntax),
                typeof(PropertyBlock1Alt1Block1Alt1Syntax),
                typeof(PropertyBlock1Alt1Block1Alt2Syntax),
                typeof(PropertyBlock2Syntax),
                typeof(PropertyBlock3Syntax),
                typeof(OperationAlt2Block1Syntax),
                typeof(OperationAlt2Block1parametersBlockSyntax),
                typeof(OperationAlt2Block2Syntax),
                typeof(TypeReferenceBlock1Syntax),
                typeof(ArrayDimensionsBlock1Syntax),
                typeof(QualifierIdentifierBlockSyntax),
            };
        }

    }
}    
