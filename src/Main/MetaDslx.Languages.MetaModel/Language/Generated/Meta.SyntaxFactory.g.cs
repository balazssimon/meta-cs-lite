#nullable enable

namespace MetaDslx.Languages.MetaModel.Compiler.Syntax
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

    public class MetaSyntaxFactory : global::MetaDslx.CodeAnalysis.Syntax.SyntaxFactory
    {
        public MetaSyntaxFactory(global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.InternalSyntaxFactory internalSyntaxFactory) 
            : base(internalSyntaxFactory)
        {
        }

        public override __Language Language => MetaLanguage.Instance;

        public override __ParseOptions DefaultParseOptions => MetaParseOptions.Default;

        /// <summary>
        /// Create a new syntax tree from a syntax node.
        /// </summary>
        public MetaSyntaxTree SyntaxTree(__SyntaxNode root, MetaParseOptions? options = null, string? path = "", __Encoding? encoding = null)
        {
            return MetaSyntaxTree.Create((MetaSyntaxNode)root, __IncrementalParseData.Empty, options, path, null, encoding);
        }

        /// <summary>
        /// Produces a syntax tree by parsing the source text.
        /// </summary>
        public MetaSyntaxTree ParseSyntaxTree(
            string text,
            MetaParseOptions options = null,
            string path = "",
            __Encoding encoding = null,
            __CancellationToken cancellationToken = default)
        {
            return (MetaSyntaxTree)this.ParseSyntaxTreeCore(__SourceText.From(text, encoding), options, path, cancellationToken);
        }

        /// <summary>
        /// Produces a syntax tree by parsing the source text.
        /// </summary>
        public MetaSyntaxTree ParseSyntaxTree(
            __SourceText text,
            MetaParseOptions? options = null,
            string path = "",
            __CancellationToken cancellationToken = default)
        {
            return (MetaSyntaxTree)this.ParseSyntaxTreeCore(text, options, path, cancellationToken);
        }

        protected override __SyntaxTree ParseSyntaxTreeCore(
            __SourceText text,
            __ParseOptions? options = null,
            string path = "",
            __CancellationToken cancellationToken = default)
        {
            return MetaSyntaxTree.ParseText(text, (MetaParseOptions?)options, path, cancellationToken);
        }

        public override __SyntaxTree MakeSyntaxTree(__SyntaxNode root, __ParseOptions? options = null, string path = "", __Encoding? encoding = null)
        {
            return MetaSyntaxTree.Create((MetaSyntaxNode)root, __IncrementalParseData.Empty, (MetaParseOptions)options, path, null, encoding);
        }

        /// <summary>
        /// Creates a token corresponding to a syntax kind. This method can be used for token syntax kinds whose text
        /// can be inferred by the kind alone.
        /// </summary>
        /// <param name="kind">A syntax kind value for a token. These have the suffix Token or Keyword.</param>
        /// <returns></returns>
        public virtual __SyntaxToken Token(MetaSyntaxKind kind)
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
        public virtual __SyntaxToken Token(__SyntaxTriviaList leading, MetaSyntaxKind kind, __SyntaxTriviaList trailing)
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
        public virtual __SyntaxToken Token(__SyntaxTriviaList leading, MetaSyntaxKind kind, string text, string valueText, __SyntaxTriviaList trailing)
        {
            return this.Token(leading, (int)kind, text, valueText, trailing);
        }

        /// <summary>
        /// Creates a missing token corresponding to syntax kind. A missing token is produced by the parser when an
        /// expected token is not found. A missing token has no text and normally has associated diagnostics.
        /// </summary>
        /// <param name="kind">A syntax kind value for a token. These have the suffix Token or Keyword.</param>
        public virtual __SyntaxToken MissingToken(MetaSyntaxKind kind)
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
        public virtual __SyntaxToken MissingToken(__SyntaxTriviaList leading, MetaSyntaxKind kind, __SyntaxTriviaList trailing)
        {
            return this.MissingToken(leading, (int)kind, trailing);
        }


        public __SyntaxToken TInteger(string text)
        {
            return new __SyntaxToken(MetaLanguage.Instance.InternalSyntaxFactory.TInteger(text));
        }

        public __SyntaxToken TInteger(string text, object value)
        {
            return new __SyntaxToken(MetaLanguage.Instance.InternalSyntaxFactory.TInteger(text, value));
        }

        public __SyntaxToken TDecimal(string text)
        {
            return new __SyntaxToken(MetaLanguage.Instance.InternalSyntaxFactory.TDecimal(text));
        }

        public __SyntaxToken TDecimal(string text, object value)
        {
            return new __SyntaxToken(MetaLanguage.Instance.InternalSyntaxFactory.TDecimal(text, value));
        }

        public __SyntaxToken TIdentifier(string text)
        {
            return new __SyntaxToken(MetaLanguage.Instance.InternalSyntaxFactory.TIdentifier(text));
        }

        public __SyntaxToken TIdentifier(string text, object value)
        {
            return new __SyntaxToken(MetaLanguage.Instance.InternalSyntaxFactory.TIdentifier(text, value));
        }

        public __SyntaxToken TVerbatimIdentifier(string text)
        {
            return new __SyntaxToken(MetaLanguage.Instance.InternalSyntaxFactory.TVerbatimIdentifier(text));
        }

        public __SyntaxToken TVerbatimIdentifier(string text, object value)
        {
            return new __SyntaxToken(MetaLanguage.Instance.InternalSyntaxFactory.TVerbatimIdentifier(text, value));
        }

        public __SyntaxToken TString(string text)
        {
            return new __SyntaxToken(MetaLanguage.Instance.InternalSyntaxFactory.TString(text));
        }

        public __SyntaxToken TString(string text, object value)
        {
            return new __SyntaxToken(MetaLanguage.Instance.InternalSyntaxFactory.TString(text, value));
        }

        public __SyntaxToken TWhitespace(string text)
        {
            return new __SyntaxToken(MetaLanguage.Instance.InternalSyntaxFactory.TWhitespace(text));
        }

        public __SyntaxToken TWhitespace(string text, object value)
        {
            return new __SyntaxToken(MetaLanguage.Instance.InternalSyntaxFactory.TWhitespace(text, value));
        }

        public __SyntaxToken TLineEnd(string text)
        {
            return new __SyntaxToken(MetaLanguage.Instance.InternalSyntaxFactory.TLineEnd(text));
        }

        public __SyntaxToken TLineEnd(string text, object value)
        {
            return new __SyntaxToken(MetaLanguage.Instance.InternalSyntaxFactory.TLineEnd(text, value));
        }

        public __SyntaxToken TSingleLineComment(string text)
        {
            return new __SyntaxToken(MetaLanguage.Instance.InternalSyntaxFactory.TSingleLineComment(text));
        }

        public __SyntaxToken TSingleLineComment(string text, object value)
        {
            return new __SyntaxToken(MetaLanguage.Instance.InternalSyntaxFactory.TSingleLineComment(text, value));
        }

        public __SyntaxToken TMultiLineComment(string text)
        {
            return new __SyntaxToken(MetaLanguage.Instance.InternalSyntaxFactory.TMultiLineComment(text));
        }

        public __SyntaxToken TMultiLineComment(string text, object value)
        {
            return new __SyntaxToken(MetaLanguage.Instance.InternalSyntaxFactory.TMultiLineComment(text, value));
        }

        public __SyntaxToken TInvalidToken(string text)
        {
            return new __SyntaxToken(MetaLanguage.Instance.InternalSyntaxFactory.TInvalidToken(text));
        }

        public __SyntaxToken TInvalidToken(string text, object value)
        {
            return new __SyntaxToken(MetaLanguage.Instance.InternalSyntaxFactory.TInvalidToken(text, value));
        }

        public MainSyntax Main(__SyntaxToken kNamespace, QualifierSyntax qualifier, __SyntaxToken tSemicolon, global::MetaDslx.CodeAnalysis.SyntaxList<UsingSyntax> usingList, MetaModelSyntax declarations1, global::MetaDslx.CodeAnalysis.SyntaxList<MetaDeclarationSyntax> declarations2, __SyntaxToken endOfFileToken)
        {
            if (kNamespace.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(kNamespace));
            if (kNamespace.RawKind != (int)MetaSyntaxKind.KNamespace) throw new __ArgumentException(nameof(kNamespace));
            if (qualifier is null) throw new __ArgumentNullException(nameof(qualifier));
            if (tSemicolon.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tSemicolon));
            if (tSemicolon.RawKind != (int)MetaSyntaxKind.TSemicolon) throw new __ArgumentException(nameof(tSemicolon));
            if (declarations1 is null) throw new __ArgumentNullException(nameof(declarations1));
            if (endOfFileToken.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(endOfFileToken));
            if (endOfFileToken.RawKind != (int)__InternalSyntaxKind.Eof) throw new __ArgumentException(nameof(endOfFileToken));
            return (MainSyntax)MetaLanguage.Instance.InternalSyntaxFactory.Main((__InternalSyntaxToken)kNamespace.Node, (InternalSyntax.QualifierGreen)qualifier.Green, (__InternalSyntaxToken)tSemicolon.Node, __GreenNodeExtensions.ToGreenList<InternalSyntax.UsingGreen>(usingList.Node), (InternalSyntax.MetaModelGreen)declarations1.Green, __GreenNodeExtensions.ToGreenList<InternalSyntax.MetaDeclarationGreen>(declarations2.Node), (__InternalSyntaxToken)endOfFileToken.Node).CreateRed();
        }
        
        public MainSyntax Main(QualifierSyntax qualifier, global::MetaDslx.CodeAnalysis.SyntaxList<UsingSyntax> usingList, MetaModelSyntax declarations1, global::MetaDslx.CodeAnalysis.SyntaxList<MetaDeclarationSyntax> declarations2, __SyntaxToken endOfFileToken)
        {
            return this.Main(this.Token(MetaSyntaxKind.KNamespace), qualifier, this.Token(MetaSyntaxKind.TSemicolon), usingList, declarations1, declarations2, this.Token(MetaSyntaxKind.Eof));
        }

        public UsingSyntax Using(__SyntaxToken kUsing, QualifierSyntax namespaces, __SyntaxToken tSemicolon)
        {
            if (kUsing.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(kUsing));
            if (kUsing.RawKind != (int)MetaSyntaxKind.KUsing) throw new __ArgumentException(nameof(kUsing));
            if (namespaces is null) throw new __ArgumentNullException(nameof(namespaces));
            if (tSemicolon.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tSemicolon));
            if (tSemicolon.RawKind != (int)MetaSyntaxKind.TSemicolon) throw new __ArgumentException(nameof(tSemicolon));
            return (UsingSyntax)MetaLanguage.Instance.InternalSyntaxFactory.Using((__InternalSyntaxToken)kUsing.Node, (InternalSyntax.QualifierGreen)namespaces.Green, (__InternalSyntaxToken)tSemicolon.Node).CreateRed();
        }
        
        public UsingSyntax Using(QualifierSyntax namespaces)
        {
            return this.Using(this.Token(MetaSyntaxKind.KUsing), namespaces, this.Token(MetaSyntaxKind.TSemicolon));
        }

        public MetaModelSyntax MetaModel(__SyntaxToken kMetamodel, NameSyntax name, __SyntaxToken tSemicolon)
        {
            if (kMetamodel.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(kMetamodel));
            if (kMetamodel.RawKind != (int)MetaSyntaxKind.KMetamodel) throw new __ArgumentException(nameof(kMetamodel));
            if (name is null) throw new __ArgumentNullException(nameof(name));
            if (tSemicolon.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tSemicolon));
            if (tSemicolon.RawKind != (int)MetaSyntaxKind.TSemicolon) throw new __ArgumentException(nameof(tSemicolon));
            return (MetaModelSyntax)MetaLanguage.Instance.InternalSyntaxFactory.MetaModel((__InternalSyntaxToken)kMetamodel.Node, (InternalSyntax.NameGreen)name.Green, (__InternalSyntaxToken)tSemicolon.Node).CreateRed();
        }
        
        public MetaModelSyntax MetaModel(NameSyntax name)
        {
            return this.MetaModel(this.Token(MetaSyntaxKind.KMetamodel), name, this.Token(MetaSyntaxKind.TSemicolon));
        }

        public MetaDeclarationAlt1Syntax MetaDeclarationAlt1(MetaConstantSyntax metaConstant)
        {
            if (metaConstant is null) throw new __ArgumentNullException(nameof(metaConstant));
            return (MetaDeclarationAlt1Syntax)MetaLanguage.Instance.InternalSyntaxFactory.MetaDeclarationAlt1((InternalSyntax.MetaConstantGreen)metaConstant.Green).CreateRed();
        }

        public MetaDeclarationAlt2Syntax MetaDeclarationAlt2(MetaEnumSyntax metaEnum)
        {
            if (metaEnum is null) throw new __ArgumentNullException(nameof(metaEnum));
            return (MetaDeclarationAlt2Syntax)MetaLanguage.Instance.InternalSyntaxFactory.MetaDeclarationAlt2((InternalSyntax.MetaEnumGreen)metaEnum.Green).CreateRed();
        }

        public MetaDeclarationAlt3Syntax MetaDeclarationAlt3(MetaClassSyntax metaClass)
        {
            if (metaClass is null) throw new __ArgumentNullException(nameof(metaClass));
            return (MetaDeclarationAlt3Syntax)MetaLanguage.Instance.InternalSyntaxFactory.MetaDeclarationAlt3((InternalSyntax.MetaClassGreen)metaClass.Green).CreateRed();
        }

        public MetaConstantSyntax MetaConstant(__SyntaxToken kConst, MetaTypeReferenceSyntax type, NameSyntax name, __SyntaxToken tSemicolon)
        {
            if (kConst.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(kConst));
            if (kConst.RawKind != (int)MetaSyntaxKind.KConst) throw new __ArgumentException(nameof(kConst));
            if (type is null) throw new __ArgumentNullException(nameof(type));
            if (name is null) throw new __ArgumentNullException(nameof(name));
            if (tSemicolon.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tSemicolon));
            if (tSemicolon.RawKind != (int)MetaSyntaxKind.TSemicolon) throw new __ArgumentException(nameof(tSemicolon));
            return (MetaConstantSyntax)MetaLanguage.Instance.InternalSyntaxFactory.MetaConstant((__InternalSyntaxToken)kConst.Node, (InternalSyntax.MetaTypeReferenceGreen)type.Green, (InternalSyntax.NameGreen)name.Green, (__InternalSyntaxToken)tSemicolon.Node).CreateRed();
        }
        
        public MetaConstantSyntax MetaConstant(MetaTypeReferenceSyntax type, NameSyntax name)
        {
            return this.MetaConstant(this.Token(MetaSyntaxKind.KConst), type, name, this.Token(MetaSyntaxKind.TSemicolon));
        }

        public MetaEnumSyntax MetaEnum(__SyntaxToken kEnum, NameSyntax name, __SyntaxToken tLBrace, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<MetaEnumLiteralSyntax> literals, __SyntaxToken tRBrace)
        {
            if (kEnum.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(kEnum));
            if (kEnum.RawKind != (int)MetaSyntaxKind.KEnum) throw new __ArgumentException(nameof(kEnum));
            if (name is null) throw new __ArgumentNullException(nameof(name));
            if (tLBrace.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tLBrace));
            if (tLBrace.RawKind != (int)MetaSyntaxKind.TLBrace) throw new __ArgumentException(nameof(tLBrace));
            if (tRBrace.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tRBrace));
            if (tRBrace.RawKind != (int)MetaSyntaxKind.TRBrace) throw new __ArgumentException(nameof(tRBrace));
            return (MetaEnumSyntax)MetaLanguage.Instance.InternalSyntaxFactory.MetaEnum((__InternalSyntaxToken)kEnum.Node, (InternalSyntax.NameGreen)name.Green, (__InternalSyntaxToken)tLBrace.Node, __GreenNodeExtensions.ToGreenSeparatedList<InternalSyntax.MetaEnumLiteralGreen>(literals.Node, reversed: false), (__InternalSyntaxToken)tRBrace.Node).CreateRed();
        }
        
        public MetaEnumSyntax MetaEnum(NameSyntax name, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<MetaEnumLiteralSyntax> literals)
        {
            return this.MetaEnum(this.Token(MetaSyntaxKind.KEnum), name, this.Token(MetaSyntaxKind.TLBrace), literals, this.Token(MetaSyntaxKind.TRBrace));
        }

        public MetaEnumLiteralSyntax MetaEnumLiteral(NameSyntax name)
        {
            if (name is null) throw new __ArgumentNullException(nameof(name));
            return (MetaEnumLiteralSyntax)MetaLanguage.Instance.InternalSyntaxFactory.MetaEnumLiteral((InternalSyntax.NameGreen)name.Green).CreateRed();
        }

        public MetaClassSyntax MetaClass(__SyntaxToken isAbstract, __SyntaxToken kClass, MetaClassBlock1Syntax block1, MetaClassBlock2Syntax block2, MetaClassBlock3Syntax block3)
        {
            if (isAbstract.RawKind != (int)__InternalSyntaxKind.None && (isAbstract.RawKind != (int)MetaSyntaxKind.KAbstract)) throw new __ArgumentException(nameof(isAbstract));
            if (kClass.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(kClass));
            if (kClass.RawKind != (int)MetaSyntaxKind.KClass) throw new __ArgumentException(nameof(kClass));
            if (block1 is null) throw new __ArgumentNullException(nameof(block1));
            if (block3 is null) throw new __ArgumentNullException(nameof(block3));
            return (MetaClassSyntax)MetaLanguage.Instance.InternalSyntaxFactory.MetaClass((__InternalSyntaxToken)isAbstract.Node, (__InternalSyntaxToken)kClass.Node, (InternalSyntax.MetaClassBlock1Green)block1.Green, (InternalSyntax.MetaClassBlock2Green)block2.Green, (InternalSyntax.MetaClassBlock3Green)block3.Green).CreateRed();
        }
        
        public MetaClassSyntax MetaClass(MetaClassBlock1Syntax block1, MetaClassBlock3Syntax block3)
        {
            return this.MetaClass(default, this.Token(MetaSyntaxKind.KClass), block1, default, block3);
        }

        public MetaPropertySyntax MetaProperty(MetaPropertyBlock1Syntax block1, MetaTypeReferenceSyntax type, MetaPropertyBlock2Syntax block2, global::MetaDslx.CodeAnalysis.SyntaxList<MetaPropertyBlock3Syntax> block3, __SyntaxToken tSemicolon)
        {
            if (type is null) throw new __ArgumentNullException(nameof(type));
            if (block2 is null) throw new __ArgumentNullException(nameof(block2));
            if (tSemicolon.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tSemicolon));
            if (tSemicolon.RawKind != (int)MetaSyntaxKind.TSemicolon) throw new __ArgumentException(nameof(tSemicolon));
            return (MetaPropertySyntax)MetaLanguage.Instance.InternalSyntaxFactory.MetaProperty((InternalSyntax.MetaPropertyBlock1Green)block1.Green, (InternalSyntax.MetaTypeReferenceGreen)type.Green, (InternalSyntax.MetaPropertyBlock2Green)block2.Green, __GreenNodeExtensions.ToGreenList<InternalSyntax.MetaPropertyBlock3Green>(block3.Node), (__InternalSyntaxToken)tSemicolon.Node).CreateRed();
        }
        
        public MetaPropertySyntax MetaProperty(MetaTypeReferenceSyntax type, MetaPropertyBlock2Syntax block2, global::MetaDslx.CodeAnalysis.SyntaxList<MetaPropertyBlock3Syntax> block3)
        {
            return this.MetaProperty(default, type, block2, block3, this.Token(MetaSyntaxKind.TSemicolon));
        }

        public MetaOperationSyntax MetaOperation(MetaTypeReferenceSyntax returnType, NameSyntax name, __SyntaxToken tLParen, MetaOperationBlock1Syntax block, __SyntaxToken tRParen, __SyntaxToken tSemicolon)
        {
            if (returnType is null) throw new __ArgumentNullException(nameof(returnType));
            if (name is null) throw new __ArgumentNullException(nameof(name));
            if (tLParen.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tLParen));
            if (tLParen.RawKind != (int)MetaSyntaxKind.TLParen) throw new __ArgumentException(nameof(tLParen));
            if (tRParen.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tRParen));
            if (tRParen.RawKind != (int)MetaSyntaxKind.TRParen) throw new __ArgumentException(nameof(tRParen));
            if (tSemicolon.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tSemicolon));
            if (tSemicolon.RawKind != (int)MetaSyntaxKind.TSemicolon) throw new __ArgumentException(nameof(tSemicolon));
            return (MetaOperationSyntax)MetaLanguage.Instance.InternalSyntaxFactory.MetaOperation((InternalSyntax.MetaTypeReferenceGreen)returnType.Green, (InternalSyntax.NameGreen)name.Green, (__InternalSyntaxToken)tLParen.Node, (InternalSyntax.MetaOperationBlock1Green)block.Green, (__InternalSyntaxToken)tRParen.Node, (__InternalSyntaxToken)tSemicolon.Node).CreateRed();
        }
        
        public MetaOperationSyntax MetaOperation(MetaTypeReferenceSyntax returnType, NameSyntax name)
        {
            return this.MetaOperation(returnType, name, this.Token(MetaSyntaxKind.TLParen), default, this.Token(MetaSyntaxKind.TRParen), this.Token(MetaSyntaxKind.TSemicolon));
        }

        public MetaParameterSyntax MetaParameter(MetaTypeReferenceSyntax type, NameSyntax name)
        {
            if (type is null) throw new __ArgumentNullException(nameof(type));
            if (name is null) throw new __ArgumentNullException(nameof(name));
            return (MetaParameterSyntax)MetaLanguage.Instance.InternalSyntaxFactory.MetaParameter((InternalSyntax.MetaTypeReferenceGreen)type.Green, (InternalSyntax.NameGreen)name.Green).CreateRed();
        }

        public SimpleTypeReferenceSyntax SimpleTypeReference(TypeReferenceSyntax typeReference)
        {
            if (typeReference is null) throw new __ArgumentNullException(nameof(typeReference));
            return (SimpleTypeReferenceSyntax)MetaLanguage.Instance.InternalSyntaxFactory.SimpleTypeReference((InternalSyntax.TypeReferenceGreen)typeReference.Green).CreateRed();
        }

        public MetaArrayTypeSyntax MetaArrayType(MetaTypeReferenceSyntax itemType, __SyntaxToken tLBracket, __SyntaxToken tRBracket)
        {
            if (itemType is null) throw new __ArgumentNullException(nameof(itemType));
            if (tLBracket.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tLBracket));
            if (tLBracket.RawKind != (int)MetaSyntaxKind.TLBracket) throw new __ArgumentException(nameof(tLBracket));
            if (tRBracket.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tRBracket));
            if (tRBracket.RawKind != (int)MetaSyntaxKind.TRBracket) throw new __ArgumentException(nameof(tRBracket));
            return (MetaArrayTypeSyntax)MetaLanguage.Instance.InternalSyntaxFactory.MetaArrayType((InternalSyntax.MetaTypeReferenceGreen)itemType.Green, (__InternalSyntaxToken)tLBracket.Node, (__InternalSyntaxToken)tRBracket.Node).CreateRed();
        }
        
        public MetaArrayTypeSyntax MetaArrayType(MetaTypeReferenceSyntax itemType)
        {
            return this.MetaArrayType(itemType, this.Token(MetaSyntaxKind.TLBracket), this.Token(MetaSyntaxKind.TRBracket));
        }

        public MetaNullableTypeSyntax MetaNullableType(MetaTypeReferenceSyntax innerType, __SyntaxToken tQuestion)
        {
            if (innerType is null) throw new __ArgumentNullException(nameof(innerType));
            if (tQuestion.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tQuestion));
            if (tQuestion.RawKind != (int)MetaSyntaxKind.TQuestion) throw new __ArgumentException(nameof(tQuestion));
            return (MetaNullableTypeSyntax)MetaLanguage.Instance.InternalSyntaxFactory.MetaNullableType((InternalSyntax.MetaTypeReferenceGreen)innerType.Green, (__InternalSyntaxToken)tQuestion.Node).CreateRed();
        }
        
        public MetaNullableTypeSyntax MetaNullableType(MetaTypeReferenceSyntax innerType)
        {
            return this.MetaNullableType(innerType, this.Token(MetaSyntaxKind.TQuestion));
        }

        public TypeReferenceAlt1Syntax TypeReferenceAlt1(PrimitiveTypeSyntax primitiveType)
        {
            if (primitiveType is null) throw new __ArgumentNullException(nameof(primitiveType));
            return (TypeReferenceAlt1Syntax)MetaLanguage.Instance.InternalSyntaxFactory.TypeReferenceAlt1((InternalSyntax.PrimitiveTypeGreen)primitiveType.Green).CreateRed();
        }

        public TypeReferenceAlt2Syntax TypeReferenceAlt2(QualifierSyntax qualifier)
        {
            if (qualifier is null) throw new __ArgumentNullException(nameof(qualifier));
            return (TypeReferenceAlt2Syntax)MetaLanguage.Instance.InternalSyntaxFactory.TypeReferenceAlt2((InternalSyntax.QualifierGreen)qualifier.Green).CreateRed();
        }

        public PrimitiveTypeSyntax PrimitiveType(__SyntaxToken token)
        {
            if (token.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(token));
            if (token.RawKind != (int)MetaSyntaxKind.KObject && token.RawKind != (int)MetaSyntaxKind.KBool && token.RawKind != (int)MetaSyntaxKind.KChar && token.RawKind != (int)MetaSyntaxKind.KString && token.RawKind != (int)MetaSyntaxKind.KByte && token.RawKind != (int)MetaSyntaxKind.KSbyte && token.RawKind != (int)MetaSyntaxKind.KShort && token.RawKind != (int)MetaSyntaxKind.KUshort && token.RawKind != (int)MetaSyntaxKind.KInt && token.RawKind != (int)MetaSyntaxKind.KUint && token.RawKind != (int)MetaSyntaxKind.KLong && token.RawKind != (int)MetaSyntaxKind.KUlong && token.RawKind != (int)MetaSyntaxKind.KFloat && token.RawKind != (int)MetaSyntaxKind.KDouble && token.RawKind != (int)MetaSyntaxKind.KDecimal && token.RawKind != (int)MetaSyntaxKind.KType && token.RawKind != (int)MetaSyntaxKind.KSymbol && token.RawKind != (int)MetaSyntaxKind.KVoid) throw new __ArgumentException(nameof(token));
            return (PrimitiveTypeSyntax)MetaLanguage.Instance.InternalSyntaxFactory.PrimitiveType((__InternalSyntaxToken)token.Node).CreateRed();
        }

        public NameSyntax Name(IdentifierSyntax identifier)
        {
            if (identifier is null) throw new __ArgumentNullException(nameof(identifier));
            return (NameSyntax)MetaLanguage.Instance.InternalSyntaxFactory.Name((InternalSyntax.IdentifierGreen)identifier.Green).CreateRed();
        }

        public QualifierSyntax Qualifier(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<IdentifierSyntax> identifier)
        {
            return (QualifierSyntax)MetaLanguage.Instance.InternalSyntaxFactory.Qualifier(__GreenNodeExtensions.ToGreenSeparatedList<InternalSyntax.IdentifierGreen>(identifier.Node, reversed: false)).CreateRed();
        }

        public IdentifierSyntax Identifier(__SyntaxToken token)
        {
            if (token.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(token));
            if (token.RawKind != (int)MetaSyntaxKind.TIdentifier && token.RawKind != (int)MetaSyntaxKind.TVerbatimIdentifier) throw new __ArgumentException(nameof(token));
            return (IdentifierSyntax)MetaLanguage.Instance.InternalSyntaxFactory.Identifier((__InternalSyntaxToken)token.Node).CreateRed();
        }

        public MetaEnumliteralsBlockSyntax MetaEnumliteralsBlock(__SyntaxToken tComma, MetaEnumLiteralSyntax literals)
        {
            if (tComma.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tComma));
            if (tComma.RawKind != (int)MetaSyntaxKind.TComma) throw new __ArgumentException(nameof(tComma));
            if (literals is null) throw new __ArgumentNullException(nameof(literals));
            return (MetaEnumliteralsBlockSyntax)MetaLanguage.Instance.InternalSyntaxFactory.MetaEnumliteralsBlock((__InternalSyntaxToken)tComma.Node, (InternalSyntax.MetaEnumLiteralGreen)literals.Green).CreateRed();
        }
        
        public MetaEnumliteralsBlockSyntax MetaEnumliteralsBlock(MetaEnumLiteralSyntax literals)
        {
            return this.MetaEnumliteralsBlock(this.Token(MetaSyntaxKind.TComma), literals);
        }

        public MetaClassBlock1Alt1Syntax MetaClassBlock1Alt1(IdentifierSyntax identifier, __SyntaxToken tDollar, IdentifierSyntax symbolType)
        {
            if (tDollar.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tDollar));
            if (tDollar.RawKind != (int)MetaSyntaxKind.TDollar) throw new __ArgumentException(nameof(tDollar));
            if (symbolType is null) throw new __ArgumentNullException(nameof(symbolType));
            return (MetaClassBlock1Alt1Syntax)MetaLanguage.Instance.InternalSyntaxFactory.MetaClassBlock1Alt1((InternalSyntax.IdentifierGreen)identifier.Green, (__InternalSyntaxToken)tDollar.Node, (InternalSyntax.IdentifierGreen)symbolType.Green).CreateRed();
        }
        
        public MetaClassBlock1Alt1Syntax MetaClassBlock1Alt1(IdentifierSyntax symbolType)
        {
            return this.MetaClassBlock1Alt1(default, this.Token(MetaSyntaxKind.TDollar), symbolType);
        }

        public MetaClassBlock1Alt2Syntax MetaClassBlock1Alt2(IdentifierSyntax identifier)
        {
            if (identifier is null) throw new __ArgumentNullException(nameof(identifier));
            return (MetaClassBlock1Alt2Syntax)MetaLanguage.Instance.InternalSyntaxFactory.MetaClassBlock1Alt2((InternalSyntax.IdentifierGreen)identifier.Green).CreateRed();
        }

        public MetaClassBlock2Syntax MetaClassBlock2(__SyntaxToken tColon, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<QualifierSyntax> baseTypes)
        {
            if (tColon.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tColon));
            if (tColon.RawKind != (int)MetaSyntaxKind.TColon) throw new __ArgumentException(nameof(tColon));
            return (MetaClassBlock2Syntax)MetaLanguage.Instance.InternalSyntaxFactory.MetaClassBlock2((__InternalSyntaxToken)tColon.Node, __GreenNodeExtensions.ToGreenSeparatedList<InternalSyntax.QualifierGreen>(baseTypes.Node, reversed: false)).CreateRed();
        }
        
        public MetaClassBlock2Syntax MetaClassBlock2(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<QualifierSyntax> baseTypes)
        {
            return this.MetaClassBlock2(this.Token(MetaSyntaxKind.TColon), baseTypes);
        }

        public MetaClassBlock2baseTypesBlockSyntax MetaClassBlock2baseTypesBlock(__SyntaxToken tComma, QualifierSyntax baseTypes)
        {
            if (tComma.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tComma));
            if (tComma.RawKind != (int)MetaSyntaxKind.TComma) throw new __ArgumentException(nameof(tComma));
            if (baseTypes is null) throw new __ArgumentNullException(nameof(baseTypes));
            return (MetaClassBlock2baseTypesBlockSyntax)MetaLanguage.Instance.InternalSyntaxFactory.MetaClassBlock2baseTypesBlock((__InternalSyntaxToken)tComma.Node, (InternalSyntax.QualifierGreen)baseTypes.Green).CreateRed();
        }
        
        public MetaClassBlock2baseTypesBlockSyntax MetaClassBlock2baseTypesBlock(QualifierSyntax baseTypes)
        {
            return this.MetaClassBlock2baseTypesBlock(this.Token(MetaSyntaxKind.TComma), baseTypes);
        }

        public MetaClassBlock3Syntax MetaClassBlock3(__SyntaxToken tLBrace, global::MetaDslx.CodeAnalysis.SyntaxList<MetaClassBlock3Block1Syntax> block, __SyntaxToken tRBrace)
        {
            if (tLBrace.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tLBrace));
            if (tLBrace.RawKind != (int)MetaSyntaxKind.TLBrace) throw new __ArgumentException(nameof(tLBrace));
            if (tRBrace.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tRBrace));
            if (tRBrace.RawKind != (int)MetaSyntaxKind.TRBrace) throw new __ArgumentException(nameof(tRBrace));
            return (MetaClassBlock3Syntax)MetaLanguage.Instance.InternalSyntaxFactory.MetaClassBlock3((__InternalSyntaxToken)tLBrace.Node, __GreenNodeExtensions.ToGreenList<InternalSyntax.MetaClassBlock3Block1Green>(block.Node), (__InternalSyntaxToken)tRBrace.Node).CreateRed();
        }
        
        public MetaClassBlock3Syntax MetaClassBlock3(global::MetaDslx.CodeAnalysis.SyntaxList<MetaClassBlock3Block1Syntax> block)
        {
            return this.MetaClassBlock3(this.Token(MetaSyntaxKind.TLBrace), block, this.Token(MetaSyntaxKind.TRBrace));
        }

        public MetaClassBlock3Block1Alt1Syntax MetaClassBlock3Block1Alt1(MetaPropertySyntax properties)
        {
            if (properties is null) throw new __ArgumentNullException(nameof(properties));
            return (MetaClassBlock3Block1Alt1Syntax)MetaLanguage.Instance.InternalSyntaxFactory.MetaClassBlock3Block1Alt1((InternalSyntax.MetaPropertyGreen)properties.Green).CreateRed();
        }

        public MetaClassBlock3Block1Alt2Syntax MetaClassBlock3Block1Alt2(MetaOperationSyntax operations)
        {
            if (operations is null) throw new __ArgumentNullException(nameof(operations));
            return (MetaClassBlock3Block1Alt2Syntax)MetaLanguage.Instance.InternalSyntaxFactory.MetaClassBlock3Block1Alt2((InternalSyntax.MetaOperationGreen)operations.Green).CreateRed();
        }

        public MetaPropertyBlock1Alt1Syntax MetaPropertyBlock1Alt1(__SyntaxToken isContainment)
        {
            if (isContainment.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(isContainment));
            if (isContainment.RawKind != (int)MetaSyntaxKind.KContains) throw new __ArgumentException(nameof(isContainment));
            return (MetaPropertyBlock1Alt1Syntax)MetaLanguage.Instance.InternalSyntaxFactory.MetaPropertyBlock1Alt1((__InternalSyntaxToken)isContainment.Node).CreateRed();
        }
        
        public MetaPropertyBlock1Alt1Syntax MetaPropertyBlock1Alt1()
        {
            return this.MetaPropertyBlock1Alt1(this.Token(MetaSyntaxKind.KContains));
        }

        public MetaPropertyBlock1Alt2Syntax MetaPropertyBlock1Alt2(__SyntaxToken isDerived)
        {
            if (isDerived.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(isDerived));
            if (isDerived.RawKind != (int)MetaSyntaxKind.KDerived) throw new __ArgumentException(nameof(isDerived));
            return (MetaPropertyBlock1Alt2Syntax)MetaLanguage.Instance.InternalSyntaxFactory.MetaPropertyBlock1Alt2((__InternalSyntaxToken)isDerived.Node).CreateRed();
        }
        
        public MetaPropertyBlock1Alt2Syntax MetaPropertyBlock1Alt2()
        {
            return this.MetaPropertyBlock1Alt2(this.Token(MetaSyntaxKind.KDerived));
        }

        public MetaPropertyBlock2Alt1Syntax MetaPropertyBlock2Alt1(IdentifierSyntax identifier, __SyntaxToken tDollar, IdentifierSyntax symbolProperty)
        {
            if (tDollar.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tDollar));
            if (tDollar.RawKind != (int)MetaSyntaxKind.TDollar) throw new __ArgumentException(nameof(tDollar));
            if (symbolProperty is null) throw new __ArgumentNullException(nameof(symbolProperty));
            return (MetaPropertyBlock2Alt1Syntax)MetaLanguage.Instance.InternalSyntaxFactory.MetaPropertyBlock2Alt1((InternalSyntax.IdentifierGreen)identifier.Green, (__InternalSyntaxToken)tDollar.Node, (InternalSyntax.IdentifierGreen)symbolProperty.Green).CreateRed();
        }
        
        public MetaPropertyBlock2Alt1Syntax MetaPropertyBlock2Alt1(IdentifierSyntax symbolProperty)
        {
            return this.MetaPropertyBlock2Alt1(default, this.Token(MetaSyntaxKind.TDollar), symbolProperty);
        }

        public MetaPropertyBlock2Alt2Syntax MetaPropertyBlock2Alt2(IdentifierSyntax identifier)
        {
            if (identifier is null) throw new __ArgumentNullException(nameof(identifier));
            return (MetaPropertyBlock2Alt2Syntax)MetaLanguage.Instance.InternalSyntaxFactory.MetaPropertyBlock2Alt2((InternalSyntax.IdentifierGreen)identifier.Green).CreateRed();
        }

        public MetaPropertyBlock3Alt1Syntax MetaPropertyBlock3Alt1(__SyntaxToken kOpposite, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<QualifierSyntax> oppositeProperties)
        {
            if (kOpposite.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(kOpposite));
            if (kOpposite.RawKind != (int)MetaSyntaxKind.KOpposite) throw new __ArgumentException(nameof(kOpposite));
            return (MetaPropertyBlock3Alt1Syntax)MetaLanguage.Instance.InternalSyntaxFactory.MetaPropertyBlock3Alt1((__InternalSyntaxToken)kOpposite.Node, __GreenNodeExtensions.ToGreenSeparatedList<InternalSyntax.QualifierGreen>(oppositeProperties.Node, reversed: false)).CreateRed();
        }
        
        public MetaPropertyBlock3Alt1Syntax MetaPropertyBlock3Alt1(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<QualifierSyntax> oppositeProperties)
        {
            return this.MetaPropertyBlock3Alt1(this.Token(MetaSyntaxKind.KOpposite), oppositeProperties);
        }

        public MetaPropertyBlock3Alt2Syntax MetaPropertyBlock3Alt2(__SyntaxToken kSubsets, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<QualifierSyntax> subsettedProperties)
        {
            if (kSubsets.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(kSubsets));
            if (kSubsets.RawKind != (int)MetaSyntaxKind.KSubsets) throw new __ArgumentException(nameof(kSubsets));
            return (MetaPropertyBlock3Alt2Syntax)MetaLanguage.Instance.InternalSyntaxFactory.MetaPropertyBlock3Alt2((__InternalSyntaxToken)kSubsets.Node, __GreenNodeExtensions.ToGreenSeparatedList<InternalSyntax.QualifierGreen>(subsettedProperties.Node, reversed: false)).CreateRed();
        }
        
        public MetaPropertyBlock3Alt2Syntax MetaPropertyBlock3Alt2(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<QualifierSyntax> subsettedProperties)
        {
            return this.MetaPropertyBlock3Alt2(this.Token(MetaSyntaxKind.KSubsets), subsettedProperties);
        }

        public MetaPropertyBlock3Alt3Syntax MetaPropertyBlock3Alt3(__SyntaxToken kRedefines, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<QualifierSyntax> redefinedProperties)
        {
            if (kRedefines.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(kRedefines));
            if (kRedefines.RawKind != (int)MetaSyntaxKind.KRedefines) throw new __ArgumentException(nameof(kRedefines));
            return (MetaPropertyBlock3Alt3Syntax)MetaLanguage.Instance.InternalSyntaxFactory.MetaPropertyBlock3Alt3((__InternalSyntaxToken)kRedefines.Node, __GreenNodeExtensions.ToGreenSeparatedList<InternalSyntax.QualifierGreen>(redefinedProperties.Node, reversed: false)).CreateRed();
        }
        
        public MetaPropertyBlock3Alt3Syntax MetaPropertyBlock3Alt3(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<QualifierSyntax> redefinedProperties)
        {
            return this.MetaPropertyBlock3Alt3(this.Token(MetaSyntaxKind.KRedefines), redefinedProperties);
        }

        public MetaPropertyBlock3Alt1oppositePropertiesBlockSyntax MetaPropertyBlock3Alt1oppositePropertiesBlock(__SyntaxToken tComma, QualifierSyntax oppositeProperties)
        {
            if (tComma.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tComma));
            if (tComma.RawKind != (int)MetaSyntaxKind.TComma) throw new __ArgumentException(nameof(tComma));
            if (oppositeProperties is null) throw new __ArgumentNullException(nameof(oppositeProperties));
            return (MetaPropertyBlock3Alt1oppositePropertiesBlockSyntax)MetaLanguage.Instance.InternalSyntaxFactory.MetaPropertyBlock3Alt1oppositePropertiesBlock((__InternalSyntaxToken)tComma.Node, (InternalSyntax.QualifierGreen)oppositeProperties.Green).CreateRed();
        }
        
        public MetaPropertyBlock3Alt1oppositePropertiesBlockSyntax MetaPropertyBlock3Alt1oppositePropertiesBlock(QualifierSyntax oppositeProperties)
        {
            return this.MetaPropertyBlock3Alt1oppositePropertiesBlock(this.Token(MetaSyntaxKind.TComma), oppositeProperties);
        }

        public MetaPropertyBlock3Alt2subsettedPropertiesBlockSyntax MetaPropertyBlock3Alt2subsettedPropertiesBlock(__SyntaxToken tComma, QualifierSyntax subsettedProperties)
        {
            if (tComma.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tComma));
            if (tComma.RawKind != (int)MetaSyntaxKind.TComma) throw new __ArgumentException(nameof(tComma));
            if (subsettedProperties is null) throw new __ArgumentNullException(nameof(subsettedProperties));
            return (MetaPropertyBlock3Alt2subsettedPropertiesBlockSyntax)MetaLanguage.Instance.InternalSyntaxFactory.MetaPropertyBlock3Alt2subsettedPropertiesBlock((__InternalSyntaxToken)tComma.Node, (InternalSyntax.QualifierGreen)subsettedProperties.Green).CreateRed();
        }
        
        public MetaPropertyBlock3Alt2subsettedPropertiesBlockSyntax MetaPropertyBlock3Alt2subsettedPropertiesBlock(QualifierSyntax subsettedProperties)
        {
            return this.MetaPropertyBlock3Alt2subsettedPropertiesBlock(this.Token(MetaSyntaxKind.TComma), subsettedProperties);
        }

        public MetaPropertyBlock3Alt3redefinedPropertiesBlockSyntax MetaPropertyBlock3Alt3redefinedPropertiesBlock(__SyntaxToken tComma, QualifierSyntax redefinedProperties)
        {
            if (tComma.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tComma));
            if (tComma.RawKind != (int)MetaSyntaxKind.TComma) throw new __ArgumentException(nameof(tComma));
            if (redefinedProperties is null) throw new __ArgumentNullException(nameof(redefinedProperties));
            return (MetaPropertyBlock3Alt3redefinedPropertiesBlockSyntax)MetaLanguage.Instance.InternalSyntaxFactory.MetaPropertyBlock3Alt3redefinedPropertiesBlock((__InternalSyntaxToken)tComma.Node, (InternalSyntax.QualifierGreen)redefinedProperties.Green).CreateRed();
        }
        
        public MetaPropertyBlock3Alt3redefinedPropertiesBlockSyntax MetaPropertyBlock3Alt3redefinedPropertiesBlock(QualifierSyntax redefinedProperties)
        {
            return this.MetaPropertyBlock3Alt3redefinedPropertiesBlock(this.Token(MetaSyntaxKind.TComma), redefinedProperties);
        }

        public MetaOperationBlock1Syntax MetaOperationBlock1(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<MetaParameterSyntax> parameters)
        {
            return (MetaOperationBlock1Syntax)MetaLanguage.Instance.InternalSyntaxFactory.MetaOperationBlock1(__GreenNodeExtensions.ToGreenSeparatedList<InternalSyntax.MetaParameterGreen>(parameters.Node, reversed: false)).CreateRed();
        }

        public MetaOperationBlock1parametersBlockSyntax MetaOperationBlock1parametersBlock(__SyntaxToken tComma, MetaParameterSyntax parameters)
        {
            if (tComma.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tComma));
            if (tComma.RawKind != (int)MetaSyntaxKind.TComma) throw new __ArgumentException(nameof(tComma));
            if (parameters is null) throw new __ArgumentNullException(nameof(parameters));
            return (MetaOperationBlock1parametersBlockSyntax)MetaLanguage.Instance.InternalSyntaxFactory.MetaOperationBlock1parametersBlock((__InternalSyntaxToken)tComma.Node, (InternalSyntax.MetaParameterGreen)parameters.Green).CreateRed();
        }
        
        public MetaOperationBlock1parametersBlockSyntax MetaOperationBlock1parametersBlock(MetaParameterSyntax parameters)
        {
            return this.MetaOperationBlock1parametersBlock(this.Token(MetaSyntaxKind.TComma), parameters);
        }

        public QualifierIdentifierBlockSyntax QualifierIdentifierBlock(__SyntaxToken tDot, IdentifierSyntax identifier)
        {
            if (tDot.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tDot));
            if (tDot.RawKind != (int)MetaSyntaxKind.TDot) throw new __ArgumentException(nameof(tDot));
            if (identifier is null) throw new __ArgumentNullException(nameof(identifier));
            return (QualifierIdentifierBlockSyntax)MetaLanguage.Instance.InternalSyntaxFactory.QualifierIdentifierBlock((__InternalSyntaxToken)tDot.Node, (InternalSyntax.IdentifierGreen)identifier.Green).CreateRed();
        }
        
        public QualifierIdentifierBlockSyntax QualifierIdentifierBlock(IdentifierSyntax identifier)
        {
            return this.QualifierIdentifierBlock(this.Token(MetaSyntaxKind.TDot), identifier);
        }

        internal static global::System.Collections.Generic.IEnumerable<__Type> GetNodeTypes()
        {
            return new __Type[] {
                typeof(MainSyntax),
                typeof(UsingSyntax),
                typeof(MetaModelSyntax),
                typeof(MetaDeclarationAlt1Syntax),
                typeof(MetaDeclarationAlt2Syntax),
                typeof(MetaDeclarationAlt3Syntax),
                typeof(MetaConstantSyntax),
                typeof(MetaEnumSyntax),
                typeof(MetaEnumLiteralSyntax),
                typeof(MetaClassSyntax),
                typeof(MetaPropertySyntax),
                typeof(MetaOperationSyntax),
                typeof(MetaParameterSyntax),
                typeof(SimpleTypeReferenceSyntax),
                typeof(MetaArrayTypeSyntax),
                typeof(MetaNullableTypeSyntax),
                typeof(TypeReferenceAlt1Syntax),
                typeof(TypeReferenceAlt2Syntax),
                typeof(PrimitiveTypeSyntax),
                typeof(NameSyntax),
                typeof(QualifierSyntax),
                typeof(IdentifierSyntax),
                typeof(MetaEnumliteralsBlockSyntax),
                typeof(MetaClassBlock1Alt1Syntax),
                typeof(MetaClassBlock1Alt2Syntax),
                typeof(MetaClassBlock2Syntax),
                typeof(MetaClassBlock2baseTypesBlockSyntax),
                typeof(MetaClassBlock3Syntax),
                typeof(MetaClassBlock3Block1Alt1Syntax),
                typeof(MetaClassBlock3Block1Alt2Syntax),
                typeof(MetaPropertyBlock1Alt1Syntax),
                typeof(MetaPropertyBlock1Alt2Syntax),
                typeof(MetaPropertyBlock2Alt1Syntax),
                typeof(MetaPropertyBlock2Alt2Syntax),
                typeof(MetaPropertyBlock3Alt1Syntax),
                typeof(MetaPropertyBlock3Alt2Syntax),
                typeof(MetaPropertyBlock3Alt3Syntax),
                typeof(MetaPropertyBlock3Alt1oppositePropertiesBlockSyntax),
                typeof(MetaPropertyBlock3Alt2subsettedPropertiesBlockSyntax),
                typeof(MetaPropertyBlock3Alt3redefinedPropertiesBlockSyntax),
                typeof(MetaOperationBlock1Syntax),
                typeof(MetaOperationBlock1parametersBlockSyntax),
                typeof(QualifierIdentifierBlockSyntax),
            };
        }

    }
}    
