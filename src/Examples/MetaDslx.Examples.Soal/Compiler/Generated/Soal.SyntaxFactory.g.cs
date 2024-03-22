namespace MetaDslx.Examples.Soal.Compiler.Syntax
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

    public class SoalSyntaxFactory : global::MetaDslx.CodeAnalysis.Syntax.SyntaxFactory
    {
        public SoalSyntaxFactory(global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.InternalSyntaxFactory internalSyntaxFactory) 
            : base(internalSyntaxFactory)
        {
        }

        public override __Language Language => SoalLanguage.Instance;

        public override __ParseOptions DefaultParseOptions => SoalParseOptions.Default;

        /// <summary>
        /// Create a new syntax tree from a syntax node.
        /// </summary>
        public SoalSyntaxTree SyntaxTree(__SyntaxNode root, SoalParseOptions? options = null, string? path = "", __Encoding? encoding = null)
        {
            return SoalSyntaxTree.Create((SoalSyntaxNode)root, __IncrementalParseData.Empty, options, path, null, encoding);
        }

        /// <summary>
        /// Produces a syntax tree by parsing the source text.
        /// </summary>
        public SoalSyntaxTree ParseSyntaxTree(
            string text,
            SoalParseOptions options = null,
            string path = "",
            __Encoding encoding = null,
            __CancellationToken cancellationToken = default)
        {
            return (SoalSyntaxTree)this.ParseSyntaxTreeCore(__SourceText.From(text, encoding), options, path, cancellationToken);
        }

        /// <summary>
        /// Produces a syntax tree by parsing the source text.
        /// </summary>
        public SoalSyntaxTree ParseSyntaxTree(
            __SourceText text,
            SoalParseOptions? options = null,
            string path = "",
            __CancellationToken cancellationToken = default)
        {
            return (SoalSyntaxTree)this.ParseSyntaxTreeCore(text, options, path, cancellationToken);
        }

        protected override __SyntaxTree ParseSyntaxTreeCore(
            __SourceText text,
            __ParseOptions? options = null,
            string path = "",
            __CancellationToken cancellationToken = default)
        {
            return SoalSyntaxTree.ParseText(text, (SoalParseOptions?)options, path, cancellationToken);
        }

        public override __SyntaxTree MakeSyntaxTree(__SyntaxNode root, __ParseOptions? options = null, string path = "", __Encoding? encoding = null)
        {
            return SoalSyntaxTree.Create((SoalSyntaxNode)root, __IncrementalParseData.Empty, (SoalParseOptions)options, path, null, encoding);
        }

        /// <summary>
        /// Creates a token corresponding to a syntax kind. This method can be used for token syntax kinds whose text
        /// can be inferred by the kind alone.
        /// </summary>
        /// <param name="kind">A syntax kind value for a token. These have the suffix Token or Keyword.</param>
        /// <returns></returns>
        public virtual __SyntaxToken Token(SoalSyntaxKind kind)
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
        public virtual __SyntaxToken Token(__SyntaxTriviaList leading, SoalSyntaxKind kind, __SyntaxTriviaList trailing)
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
        public virtual __SyntaxToken Token(__SyntaxTriviaList leading, SoalSyntaxKind kind, string text, string valueText, __SyntaxTriviaList trailing)
        {
            return this.Token(leading, (int)kind, text, valueText, trailing);
        }

        /// <summary>
        /// Creates a missing token corresponding to syntax kind. A missing token is produced by the parser when an
        /// expected token is not found. A missing token has no text and normally has associated diagnostics.
        /// </summary>
        /// <param name="kind">A syntax kind value for a token. These have the suffix Token or Keyword.</param>
        public virtual __SyntaxToken MissingToken(SoalSyntaxKind kind)
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
        public virtual __SyntaxToken MissingToken(__SyntaxTriviaList leading, SoalSyntaxKind kind, __SyntaxTriviaList trailing)
        {
            return this.MissingToken(leading, (int)kind, trailing);
        }


        public __SyntaxToken TInteger(string text)
        {
            return new __SyntaxToken(SoalLanguage.Instance.InternalSyntaxFactory.TInteger(text));
        }

        public __SyntaxToken TInteger(string text, object value)
        {
            return new __SyntaxToken(SoalLanguage.Instance.InternalSyntaxFactory.TInteger(text, value));
        }

        public __SyntaxToken TDecimal(string text)
        {
            return new __SyntaxToken(SoalLanguage.Instance.InternalSyntaxFactory.TDecimal(text));
        }

        public __SyntaxToken TDecimal(string text, object value)
        {
            return new __SyntaxToken(SoalLanguage.Instance.InternalSyntaxFactory.TDecimal(text, value));
        }

        public __SyntaxToken TIdentifier(string text)
        {
            return new __SyntaxToken(SoalLanguage.Instance.InternalSyntaxFactory.TIdentifier(text));
        }

        public __SyntaxToken TIdentifier(string text, object value)
        {
            return new __SyntaxToken(SoalLanguage.Instance.InternalSyntaxFactory.TIdentifier(text, value));
        }

        public __SyntaxToken TVerbatimIdentifier(string text)
        {
            return new __SyntaxToken(SoalLanguage.Instance.InternalSyntaxFactory.TVerbatimIdentifier(text));
        }

        public __SyntaxToken TVerbatimIdentifier(string text, object value)
        {
            return new __SyntaxToken(SoalLanguage.Instance.InternalSyntaxFactory.TVerbatimIdentifier(text, value));
        }

        public __SyntaxToken TString(string text)
        {
            return new __SyntaxToken(SoalLanguage.Instance.InternalSyntaxFactory.TString(text));
        }

        public __SyntaxToken TString(string text, object value)
        {
            return new __SyntaxToken(SoalLanguage.Instance.InternalSyntaxFactory.TString(text, value));
        }

        public __SyntaxToken TWhitespace(string text)
        {
            return new __SyntaxToken(SoalLanguage.Instance.InternalSyntaxFactory.TWhitespace(text));
        }

        public __SyntaxToken TWhitespace(string text, object value)
        {
            return new __SyntaxToken(SoalLanguage.Instance.InternalSyntaxFactory.TWhitespace(text, value));
        }

        public __SyntaxToken TLineEnd(string text)
        {
            return new __SyntaxToken(SoalLanguage.Instance.InternalSyntaxFactory.TLineEnd(text));
        }

        public __SyntaxToken TLineEnd(string text, object value)
        {
            return new __SyntaxToken(SoalLanguage.Instance.InternalSyntaxFactory.TLineEnd(text, value));
        }

        public __SyntaxToken TSingleLineComment(string text)
        {
            return new __SyntaxToken(SoalLanguage.Instance.InternalSyntaxFactory.TSingleLineComment(text));
        }

        public __SyntaxToken TSingleLineComment(string text, object value)
        {
            return new __SyntaxToken(SoalLanguage.Instance.InternalSyntaxFactory.TSingleLineComment(text, value));
        }

        public __SyntaxToken TMultiLineComment(string text)
        {
            return new __SyntaxToken(SoalLanguage.Instance.InternalSyntaxFactory.TMultiLineComment(text));
        }

        public __SyntaxToken TMultiLineComment(string text, object value)
        {
            return new __SyntaxToken(SoalLanguage.Instance.InternalSyntaxFactory.TMultiLineComment(text, value));
        }

        public __SyntaxToken TInvalidToken(string text)
        {
            return new __SyntaxToken(SoalLanguage.Instance.InternalSyntaxFactory.TInvalidToken(text));
        }

        public __SyntaxToken TInvalidToken(string text, object value)
        {
            return new __SyntaxToken(SoalLanguage.Instance.InternalSyntaxFactory.TInvalidToken(text, value));
        }

        public MainSyntax Main(__SyntaxToken kNamespace, QualifierSyntax qualifier, __SyntaxToken tSemicolon, global::MetaDslx.CodeAnalysis.SyntaxList<UsingSyntax> usingList, MainBlock1Syntax block, __SyntaxToken endOfFileToken)
        {
            if (kNamespace.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(kNamespace));
            if (kNamespace.RawKind != (int)SoalSyntaxKind.KNamespace) throw new __ArgumentException(nameof(kNamespace));
            if (qualifier is null) throw new __ArgumentNullException(nameof(qualifier));
            if (tSemicolon.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tSemicolon));
            if (tSemicolon.RawKind != (int)SoalSyntaxKind.TSemicolon) throw new __ArgumentException(nameof(tSemicolon));
            if (block is null) throw new __ArgumentNullException(nameof(block));
            if (endOfFileToken.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(endOfFileToken));
            if (endOfFileToken.RawKind != (int)__InternalSyntaxKind.Eof) throw new __ArgumentException(nameof(endOfFileToken));
            return (MainSyntax)SoalLanguage.Instance.InternalSyntaxFactory.Main((__InternalSyntaxToken)kNamespace.Node, (InternalSyntax.QualifierGreen)qualifier.Green, (__InternalSyntaxToken)tSemicolon.Node, __GreenNodeExtensions.ToGreenList<InternalSyntax.UsingGreen>(usingList.Node), (InternalSyntax.MainBlock1Green)block.Green, (__InternalSyntaxToken)endOfFileToken.Node).CreateRed();
        }
        
        public MainSyntax Main(QualifierSyntax qualifier, global::MetaDslx.CodeAnalysis.SyntaxList<UsingSyntax> usingList, MainBlock1Syntax block, __SyntaxToken endOfFileToken)
        {
            return this.Main(this.Token(SoalSyntaxKind.KNamespace), qualifier, this.Token(SoalSyntaxKind.TSemicolon), usingList, block, this.Token(SoalSyntaxKind.Eof));
        }

        public UsingSyntax Using(__SyntaxToken kUsing, QualifierSyntax namespaces, __SyntaxToken tSemicolon)
        {
            if (kUsing.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(kUsing));
            if (kUsing.RawKind != (int)SoalSyntaxKind.KUsing) throw new __ArgumentException(nameof(kUsing));
            if (namespaces is null) throw new __ArgumentNullException(nameof(namespaces));
            if (tSemicolon.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tSemicolon));
            if (tSemicolon.RawKind != (int)SoalSyntaxKind.TSemicolon) throw new __ArgumentException(nameof(tSemicolon));
            return (UsingSyntax)SoalLanguage.Instance.InternalSyntaxFactory.Using((__InternalSyntaxToken)kUsing.Node, (InternalSyntax.QualifierGreen)namespaces.Green, (__InternalSyntaxToken)tSemicolon.Node).CreateRed();
        }
        
        public UsingSyntax Using(QualifierSyntax namespaces)
        {
            return this.Using(this.Token(SoalSyntaxKind.KUsing), namespaces, this.Token(SoalSyntaxKind.TSemicolon));
        }

        public DeclarationAlt1Syntax DeclarationAlt1(EnumTypeSyntax enumType)
        {
            if (enumType is null) throw new __ArgumentNullException(nameof(enumType));
            return (DeclarationAlt1Syntax)SoalLanguage.Instance.InternalSyntaxFactory.DeclarationAlt1((InternalSyntax.EnumTypeGreen)enumType.Green).CreateRed();
        }

        public DeclarationAlt2Syntax DeclarationAlt2(StructTypeSyntax structType)
        {
            if (structType is null) throw new __ArgumentNullException(nameof(structType));
            return (DeclarationAlt2Syntax)SoalLanguage.Instance.InternalSyntaxFactory.DeclarationAlt2((InternalSyntax.StructTypeGreen)structType.Green).CreateRed();
        }

        public DeclarationAlt3Syntax DeclarationAlt3(InterfaceSyntax @interface)
        {
            if (@interface is null) throw new __ArgumentNullException(nameof(@interface));
            return (DeclarationAlt3Syntax)SoalLanguage.Instance.InternalSyntaxFactory.DeclarationAlt3((InternalSyntax.InterfaceGreen)@interface.Green).CreateRed();
        }

        public DeclarationAlt4Syntax DeclarationAlt4(ServiceSyntax service)
        {
            if (service is null) throw new __ArgumentNullException(nameof(service));
            return (DeclarationAlt4Syntax)SoalLanguage.Instance.InternalSyntaxFactory.DeclarationAlt4((InternalSyntax.ServiceGreen)service.Green).CreateRed();
        }

        public EnumTypeSyntax EnumType(__SyntaxToken kEnum, NameSyntax name, __SyntaxToken tLBrace, EnumTypeBlock1Syntax block, __SyntaxToken tRBrace)
        {
            if (kEnum.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(kEnum));
            if (kEnum.RawKind != (int)SoalSyntaxKind.KEnum) throw new __ArgumentException(nameof(kEnum));
            if (name is null) throw new __ArgumentNullException(nameof(name));
            if (tLBrace.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tLBrace));
            if (tLBrace.RawKind != (int)SoalSyntaxKind.TLBrace) throw new __ArgumentException(nameof(tLBrace));
            if (tRBrace.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tRBrace));
            if (tRBrace.RawKind != (int)SoalSyntaxKind.TRBrace) throw new __ArgumentException(nameof(tRBrace));
            return (EnumTypeSyntax)SoalLanguage.Instance.InternalSyntaxFactory.EnumType((__InternalSyntaxToken)kEnum.Node, (InternalSyntax.NameGreen)name.Green, (__InternalSyntaxToken)tLBrace.Node, (InternalSyntax.EnumTypeBlock1Green)block.Green, (__InternalSyntaxToken)tRBrace.Node).CreateRed();
        }
        
        public EnumTypeSyntax EnumType(NameSyntax name)
        {
            return this.EnumType(this.Token(SoalSyntaxKind.KEnum), name, this.Token(SoalSyntaxKind.TLBrace), default, this.Token(SoalSyntaxKind.TRBrace));
        }

        public EnumLiteralSyntax EnumLiteral(NameSyntax name)
        {
            if (name is null) throw new __ArgumentNullException(nameof(name));
            return (EnumLiteralSyntax)SoalLanguage.Instance.InternalSyntaxFactory.EnumLiteral((InternalSyntax.NameGreen)name.Green).CreateRed();
        }

        public StructTypeSyntax StructType(__SyntaxToken kStruct, NameSyntax name, StructTypeBlock1Syntax block, __SyntaxToken tLBrace, global::MetaDslx.CodeAnalysis.SyntaxList<PropertySyntax> fields, __SyntaxToken tRBrace)
        {
            if (kStruct.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(kStruct));
            if (kStruct.RawKind != (int)SoalSyntaxKind.KStruct) throw new __ArgumentException(nameof(kStruct));
            if (name is null) throw new __ArgumentNullException(nameof(name));
            if (tLBrace.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tLBrace));
            if (tLBrace.RawKind != (int)SoalSyntaxKind.TLBrace) throw new __ArgumentException(nameof(tLBrace));
            if (tRBrace.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tRBrace));
            if (tRBrace.RawKind != (int)SoalSyntaxKind.TRBrace) throw new __ArgumentException(nameof(tRBrace));
            return (StructTypeSyntax)SoalLanguage.Instance.InternalSyntaxFactory.StructType((__InternalSyntaxToken)kStruct.Node, (InternalSyntax.NameGreen)name.Green, (InternalSyntax.StructTypeBlock1Green)block.Green, (__InternalSyntaxToken)tLBrace.Node, __GreenNodeExtensions.ToGreenList<InternalSyntax.PropertyGreen>(fields.Node), (__InternalSyntaxToken)tRBrace.Node).CreateRed();
        }
        
        public StructTypeSyntax StructType(NameSyntax name, global::MetaDslx.CodeAnalysis.SyntaxList<PropertySyntax> fields)
        {
            return this.StructType(this.Token(SoalSyntaxKind.KStruct), name, default, this.Token(SoalSyntaxKind.TLBrace), fields, this.Token(SoalSyntaxKind.TRBrace));
        }

        public PropertySyntax Property(TypeReferenceSyntax type, NameSyntax name, __SyntaxToken tSemicolon)
        {
            if (type is null) throw new __ArgumentNullException(nameof(type));
            if (name is null) throw new __ArgumentNullException(nameof(name));
            if (tSemicolon.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tSemicolon));
            if (tSemicolon.RawKind != (int)SoalSyntaxKind.TSemicolon) throw new __ArgumentException(nameof(tSemicolon));
            return (PropertySyntax)SoalLanguage.Instance.InternalSyntaxFactory.Property((InternalSyntax.TypeReferenceGreen)type.Green, (InternalSyntax.NameGreen)name.Green, (__InternalSyntaxToken)tSemicolon.Node).CreateRed();
        }
        
        public PropertySyntax Property(TypeReferenceSyntax type, NameSyntax name)
        {
            return this.Property(type, name, this.Token(SoalSyntaxKind.TSemicolon));
        }

        public InterfaceSyntax Interface(__SyntaxToken kInterface, NameSyntax name, __SyntaxToken tLBrace, global::MetaDslx.CodeAnalysis.SyntaxList<ResourceSyntax> resources, global::MetaDslx.CodeAnalysis.SyntaxList<OperationSyntax> operations, __SyntaxToken tRBrace)
        {
            if (kInterface.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(kInterface));
            if (kInterface.RawKind != (int)SoalSyntaxKind.KInterface) throw new __ArgumentException(nameof(kInterface));
            if (name is null) throw new __ArgumentNullException(nameof(name));
            if (tLBrace.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tLBrace));
            if (tLBrace.RawKind != (int)SoalSyntaxKind.TLBrace) throw new __ArgumentException(nameof(tLBrace));
            if (tRBrace.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tRBrace));
            if (tRBrace.RawKind != (int)SoalSyntaxKind.TRBrace) throw new __ArgumentException(nameof(tRBrace));
            return (InterfaceSyntax)SoalLanguage.Instance.InternalSyntaxFactory.Interface((__InternalSyntaxToken)kInterface.Node, (InternalSyntax.NameGreen)name.Green, (__InternalSyntaxToken)tLBrace.Node, __GreenNodeExtensions.ToGreenList<InternalSyntax.ResourceGreen>(resources.Node), __GreenNodeExtensions.ToGreenList<InternalSyntax.OperationGreen>(operations.Node), (__InternalSyntaxToken)tRBrace.Node).CreateRed();
        }
        
        public InterfaceSyntax Interface(NameSyntax name, global::MetaDslx.CodeAnalysis.SyntaxList<ResourceSyntax> resources, global::MetaDslx.CodeAnalysis.SyntaxList<OperationSyntax> operations)
        {
            return this.Interface(this.Token(SoalSyntaxKind.KInterface), name, this.Token(SoalSyntaxKind.TLBrace), resources, operations, this.Token(SoalSyntaxKind.TRBrace));
        }

        public ResourceSyntax Resource(__SyntaxToken isReadOnly, __SyntaxToken kResource, QualifierSyntax entity, ResourceBlock1Syntax block, __SyntaxToken tSemicolon)
        {
            if (isReadOnly.RawKind != (int)__InternalSyntaxKind.None && (isReadOnly.RawKind != (int)SoalSyntaxKind.KReadonly)) throw new __ArgumentException(nameof(isReadOnly));
            if (kResource.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(kResource));
            if (kResource.RawKind != (int)SoalSyntaxKind.KResource) throw new __ArgumentException(nameof(kResource));
            if (entity is null) throw new __ArgumentNullException(nameof(entity));
            if (tSemicolon.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tSemicolon));
            if (tSemicolon.RawKind != (int)SoalSyntaxKind.TSemicolon) throw new __ArgumentException(nameof(tSemicolon));
            return (ResourceSyntax)SoalLanguage.Instance.InternalSyntaxFactory.Resource((__InternalSyntaxToken)isReadOnly.Node, (__InternalSyntaxToken)kResource.Node, (InternalSyntax.QualifierGreen)entity.Green, (InternalSyntax.ResourceBlock1Green)block.Green, (__InternalSyntaxToken)tSemicolon.Node).CreateRed();
        }
        
        public ResourceSyntax Resource(QualifierSyntax entity)
        {
            return this.Resource(default, this.Token(SoalSyntaxKind.KResource), entity, default, this.Token(SoalSyntaxKind.TSemicolon));
        }

        public OperationSyntax Operation(__SyntaxToken isAsync, OutputParameterListSyntax responseParameters, NameSyntax name, InputParameterListSyntax requestParameters, OperationBlock1Syntax block, __SyntaxToken tSemicolon)
        {
            if (isAsync.RawKind != (int)__InternalSyntaxKind.None && (isAsync.RawKind != (int)SoalSyntaxKind.KAsync)) throw new __ArgumentException(nameof(isAsync));
            if (responseParameters is null) throw new __ArgumentNullException(nameof(responseParameters));
            if (name is null) throw new __ArgumentNullException(nameof(name));
            if (requestParameters is null) throw new __ArgumentNullException(nameof(requestParameters));
            if (tSemicolon.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tSemicolon));
            if (tSemicolon.RawKind != (int)SoalSyntaxKind.TSemicolon) throw new __ArgumentException(nameof(tSemicolon));
            return (OperationSyntax)SoalLanguage.Instance.InternalSyntaxFactory.Operation((__InternalSyntaxToken)isAsync.Node, (InternalSyntax.OutputParameterListGreen)responseParameters.Green, (InternalSyntax.NameGreen)name.Green, (InternalSyntax.InputParameterListGreen)requestParameters.Green, (InternalSyntax.OperationBlock1Green)block.Green, (__InternalSyntaxToken)tSemicolon.Node).CreateRed();
        }
        
        public OperationSyntax Operation(OutputParameterListSyntax responseParameters, NameSyntax name, InputParameterListSyntax requestParameters)
        {
            return this.Operation(default, responseParameters, name, requestParameters, default, this.Token(SoalSyntaxKind.TSemicolon));
        }

        public InputParameterListSyntax InputParameterList(__SyntaxToken tLParen, InputParameterListBlock1Syntax block, __SyntaxToken tRParen)
        {
            if (tLParen.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tLParen));
            if (tLParen.RawKind != (int)SoalSyntaxKind.TLParen) throw new __ArgumentException(nameof(tLParen));
            if (tRParen.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tRParen));
            if (tRParen.RawKind != (int)SoalSyntaxKind.TRParen) throw new __ArgumentException(nameof(tRParen));
            return (InputParameterListSyntax)SoalLanguage.Instance.InternalSyntaxFactory.InputParameterList((__InternalSyntaxToken)tLParen.Node, (InternalSyntax.InputParameterListBlock1Green)block.Green, (__InternalSyntaxToken)tRParen.Node).CreateRed();
        }
        
        public InputParameterListSyntax InputParameterList()
        {
            return this.InputParameterList(this.Token(SoalSyntaxKind.TLParen), default, this.Token(SoalSyntaxKind.TRParen));
        }

        public OutputParameterListAlt1Syntax OutputParameterListAlt1(__SyntaxToken kVoid)
        {
            if (kVoid.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(kVoid));
            if (kVoid.RawKind != (int)SoalSyntaxKind.KVoid) throw new __ArgumentException(nameof(kVoid));
            return (OutputParameterListAlt1Syntax)SoalLanguage.Instance.InternalSyntaxFactory.OutputParameterListAlt1((__InternalSyntaxToken)kVoid.Node).CreateRed();
        }
        
        public OutputParameterListAlt1Syntax OutputParameterListAlt1()
        {
            return this.OutputParameterListAlt1(this.Token(SoalSyntaxKind.KVoid));
        }

        public OutputParameterListAlt2Syntax OutputParameterListAlt2(SingleReturnParameterSyntax parameters)
        {
            if (parameters is null) throw new __ArgumentNullException(nameof(parameters));
            return (OutputParameterListAlt2Syntax)SoalLanguage.Instance.InternalSyntaxFactory.OutputParameterListAlt2((InternalSyntax.SingleReturnParameterGreen)parameters.Green).CreateRed();
        }

        public OutputParameterListAlt3Syntax OutputParameterListAlt3(__SyntaxToken tLParen, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<ParameterSyntax> parameters, __SyntaxToken tRParen)
        {
            if (tLParen.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tLParen));
            if (tLParen.RawKind != (int)SoalSyntaxKind.TLParen) throw new __ArgumentException(nameof(tLParen));
            if (tRParen.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tRParen));
            if (tRParen.RawKind != (int)SoalSyntaxKind.TRParen) throw new __ArgumentException(nameof(tRParen));
            return (OutputParameterListAlt3Syntax)SoalLanguage.Instance.InternalSyntaxFactory.OutputParameterListAlt3((__InternalSyntaxToken)tLParen.Node, __GreenNodeExtensions.ToGreenSeparatedList<InternalSyntax.ParameterGreen>(parameters.Node, reversed: false), (__InternalSyntaxToken)tRParen.Node).CreateRed();
        }
        
        public OutputParameterListAlt3Syntax OutputParameterListAlt3(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<ParameterSyntax> parameters)
        {
            return this.OutputParameterListAlt3(this.Token(SoalSyntaxKind.TLParen), parameters, this.Token(SoalSyntaxKind.TRParen));
        }

        public ParameterSyntax Parameter(TypeReferenceSyntax type, NameSyntax name)
        {
            if (type is null) throw new __ArgumentNullException(nameof(type));
            if (name is null) throw new __ArgumentNullException(nameof(name));
            return (ParameterSyntax)SoalLanguage.Instance.InternalSyntaxFactory.Parameter((InternalSyntax.TypeReferenceGreen)type.Green, (InternalSyntax.NameGreen)name.Green).CreateRed();
        }

        public SingleReturnParameterSyntax SingleReturnParameter(TypeReferenceSyntax type)
        {
            if (type is null) throw new __ArgumentNullException(nameof(type));
            return (SingleReturnParameterSyntax)SoalLanguage.Instance.InternalSyntaxFactory.SingleReturnParameter((InternalSyntax.TypeReferenceGreen)type.Green).CreateRed();
        }

        public ServiceSyntax Service(__SyntaxToken kService, NameSyntax name, __SyntaxToken tColon, QualifierSyntax @interface, __SyntaxToken tLBrace, __SyntaxToken kBinding, BindingKindSyntax binding, __SyntaxToken tSemicolon, __SyntaxToken tRBrace)
        {
            if (kService.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(kService));
            if (kService.RawKind != (int)SoalSyntaxKind.KService) throw new __ArgumentException(nameof(kService));
            if (name is null) throw new __ArgumentNullException(nameof(name));
            if (tColon.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tColon));
            if (tColon.RawKind != (int)SoalSyntaxKind.TColon) throw new __ArgumentException(nameof(tColon));
            if (@interface is null) throw new __ArgumentNullException(nameof(@interface));
            if (tLBrace.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tLBrace));
            if (tLBrace.RawKind != (int)SoalSyntaxKind.TLBrace) throw new __ArgumentException(nameof(tLBrace));
            if (kBinding.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(kBinding));
            if (kBinding.RawKind != (int)SoalSyntaxKind.KBinding) throw new __ArgumentException(nameof(kBinding));
            if (binding is null) throw new __ArgumentNullException(nameof(binding));
            if (tSemicolon.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tSemicolon));
            if (tSemicolon.RawKind != (int)SoalSyntaxKind.TSemicolon) throw new __ArgumentException(nameof(tSemicolon));
            if (tRBrace.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tRBrace));
            if (tRBrace.RawKind != (int)SoalSyntaxKind.TRBrace) throw new __ArgumentException(nameof(tRBrace));
            return (ServiceSyntax)SoalLanguage.Instance.InternalSyntaxFactory.Service((__InternalSyntaxToken)kService.Node, (InternalSyntax.NameGreen)name.Green, (__InternalSyntaxToken)tColon.Node, (InternalSyntax.QualifierGreen)@interface.Green, (__InternalSyntaxToken)tLBrace.Node, (__InternalSyntaxToken)kBinding.Node, (InternalSyntax.BindingKindGreen)binding.Green, (__InternalSyntaxToken)tSemicolon.Node, (__InternalSyntaxToken)tRBrace.Node).CreateRed();
        }
        
        public ServiceSyntax Service(NameSyntax name, QualifierSyntax @interface, BindingKindSyntax binding)
        {
            return this.Service(this.Token(SoalSyntaxKind.KService), name, this.Token(SoalSyntaxKind.TColon), @interface, this.Token(SoalSyntaxKind.TLBrace), this.Token(SoalSyntaxKind.KBinding), binding, this.Token(SoalSyntaxKind.TSemicolon), this.Token(SoalSyntaxKind.TRBrace));
        }

        public BindingKindSyntax BindingKind(__SyntaxToken token)
        {
            if (token.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(token));
            if (token.RawKind != (int)SoalSyntaxKind.KREST && token.RawKind != (int)SoalSyntaxKind.KSOAP) throw new __ArgumentException(nameof(token));
            return (BindingKindSyntax)SoalLanguage.Instance.InternalSyntaxFactory.BindingKind((__InternalSyntaxToken)token.Node).CreateRed();
        }

        public TypeReferenceSyntax TypeReference(SimpleTypeSyntax type, __SyntaxToken isNullable, TypeReferenceBlock1Syntax isArray)
        {
            if (type is null) throw new __ArgumentNullException(nameof(type));
            if (isNullable.RawKind != (int)__InternalSyntaxKind.None && (isNullable.RawKind != (int)SoalSyntaxKind.TQuestion)) throw new __ArgumentException(nameof(isNullable));
            return (TypeReferenceSyntax)SoalLanguage.Instance.InternalSyntaxFactory.TypeReference((InternalSyntax.SimpleTypeGreen)type.Green, (__InternalSyntaxToken)isNullable.Node, (InternalSyntax.TypeReferenceBlock1Green)isArray.Green).CreateRed();
        }
        
        public TypeReferenceSyntax TypeReference(SimpleTypeSyntax type)
        {
            return this.TypeReference(type, default, default);
        }

        public SimpleTypeAlt1Syntax SimpleTypeAlt1(__SyntaxToken kObject)
        {
            if (kObject.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(kObject));
            if (kObject.RawKind != (int)SoalSyntaxKind.KObject) throw new __ArgumentException(nameof(kObject));
            return (SimpleTypeAlt1Syntax)SoalLanguage.Instance.InternalSyntaxFactory.SimpleTypeAlt1((__InternalSyntaxToken)kObject.Node).CreateRed();
        }
        
        public SimpleTypeAlt1Syntax SimpleTypeAlt1()
        {
            return this.SimpleTypeAlt1(this.Token(SoalSyntaxKind.KObject));
        }

        public SimpleTypeAlt2Syntax SimpleTypeAlt2(__SyntaxToken kBinary)
        {
            if (kBinary.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(kBinary));
            if (kBinary.RawKind != (int)SoalSyntaxKind.KBinary) throw new __ArgumentException(nameof(kBinary));
            return (SimpleTypeAlt2Syntax)SoalLanguage.Instance.InternalSyntaxFactory.SimpleTypeAlt2((__InternalSyntaxToken)kBinary.Node).CreateRed();
        }
        
        public SimpleTypeAlt2Syntax SimpleTypeAlt2()
        {
            return this.SimpleTypeAlt2(this.Token(SoalSyntaxKind.KBinary));
        }

        public SimpleTypeAlt3Syntax SimpleTypeAlt3(__SyntaxToken kBool)
        {
            if (kBool.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(kBool));
            if (kBool.RawKind != (int)SoalSyntaxKind.KBool) throw new __ArgumentException(nameof(kBool));
            return (SimpleTypeAlt3Syntax)SoalLanguage.Instance.InternalSyntaxFactory.SimpleTypeAlt3((__InternalSyntaxToken)kBool.Node).CreateRed();
        }
        
        public SimpleTypeAlt3Syntax SimpleTypeAlt3()
        {
            return this.SimpleTypeAlt3(this.Token(SoalSyntaxKind.KBool));
        }

        public SimpleTypeAlt4Syntax SimpleTypeAlt4(__SyntaxToken kString)
        {
            if (kString.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(kString));
            if (kString.RawKind != (int)SoalSyntaxKind.KString) throw new __ArgumentException(nameof(kString));
            return (SimpleTypeAlt4Syntax)SoalLanguage.Instance.InternalSyntaxFactory.SimpleTypeAlt4((__InternalSyntaxToken)kString.Node).CreateRed();
        }
        
        public SimpleTypeAlt4Syntax SimpleTypeAlt4()
        {
            return this.SimpleTypeAlt4(this.Token(SoalSyntaxKind.KString));
        }

        public SimpleTypeAlt5Syntax SimpleTypeAlt5(__SyntaxToken kInt)
        {
            if (kInt.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(kInt));
            if (kInt.RawKind != (int)SoalSyntaxKind.KInt) throw new __ArgumentException(nameof(kInt));
            return (SimpleTypeAlt5Syntax)SoalLanguage.Instance.InternalSyntaxFactory.SimpleTypeAlt5((__InternalSyntaxToken)kInt.Node).CreateRed();
        }
        
        public SimpleTypeAlt5Syntax SimpleTypeAlt5()
        {
            return this.SimpleTypeAlt5(this.Token(SoalSyntaxKind.KInt));
        }

        public SimpleTypeAlt6Syntax SimpleTypeAlt6(__SyntaxToken kLong)
        {
            if (kLong.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(kLong));
            if (kLong.RawKind != (int)SoalSyntaxKind.KLong) throw new __ArgumentException(nameof(kLong));
            return (SimpleTypeAlt6Syntax)SoalLanguage.Instance.InternalSyntaxFactory.SimpleTypeAlt6((__InternalSyntaxToken)kLong.Node).CreateRed();
        }
        
        public SimpleTypeAlt6Syntax SimpleTypeAlt6()
        {
            return this.SimpleTypeAlt6(this.Token(SoalSyntaxKind.KLong));
        }

        public SimpleTypeAlt7Syntax SimpleTypeAlt7(__SyntaxToken kFloat)
        {
            if (kFloat.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(kFloat));
            if (kFloat.RawKind != (int)SoalSyntaxKind.KFloat) throw new __ArgumentException(nameof(kFloat));
            return (SimpleTypeAlt7Syntax)SoalLanguage.Instance.InternalSyntaxFactory.SimpleTypeAlt7((__InternalSyntaxToken)kFloat.Node).CreateRed();
        }
        
        public SimpleTypeAlt7Syntax SimpleTypeAlt7()
        {
            return this.SimpleTypeAlt7(this.Token(SoalSyntaxKind.KFloat));
        }

        public SimpleTypeAlt8Syntax SimpleTypeAlt8(__SyntaxToken kDouble)
        {
            if (kDouble.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(kDouble));
            if (kDouble.RawKind != (int)SoalSyntaxKind.KDouble) throw new __ArgumentException(nameof(kDouble));
            return (SimpleTypeAlt8Syntax)SoalLanguage.Instance.InternalSyntaxFactory.SimpleTypeAlt8((__InternalSyntaxToken)kDouble.Node).CreateRed();
        }
        
        public SimpleTypeAlt8Syntax SimpleTypeAlt8()
        {
            return this.SimpleTypeAlt8(this.Token(SoalSyntaxKind.KDouble));
        }

        public SimpleTypeAlt9Syntax SimpleTypeAlt9(__SyntaxToken kDate)
        {
            if (kDate.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(kDate));
            if (kDate.RawKind != (int)SoalSyntaxKind.KDate) throw new __ArgumentException(nameof(kDate));
            return (SimpleTypeAlt9Syntax)SoalLanguage.Instance.InternalSyntaxFactory.SimpleTypeAlt9((__InternalSyntaxToken)kDate.Node).CreateRed();
        }
        
        public SimpleTypeAlt9Syntax SimpleTypeAlt9()
        {
            return this.SimpleTypeAlt9(this.Token(SoalSyntaxKind.KDate));
        }

        public SimpleTypeAlt10Syntax SimpleTypeAlt10(__SyntaxToken kTime)
        {
            if (kTime.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(kTime));
            if (kTime.RawKind != (int)SoalSyntaxKind.KTime) throw new __ArgumentException(nameof(kTime));
            return (SimpleTypeAlt10Syntax)SoalLanguage.Instance.InternalSyntaxFactory.SimpleTypeAlt10((__InternalSyntaxToken)kTime.Node).CreateRed();
        }
        
        public SimpleTypeAlt10Syntax SimpleTypeAlt10()
        {
            return this.SimpleTypeAlt10(this.Token(SoalSyntaxKind.KTime));
        }

        public SimpleTypeAlt11Syntax SimpleTypeAlt11(__SyntaxToken kDatetime)
        {
            if (kDatetime.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(kDatetime));
            if (kDatetime.RawKind != (int)SoalSyntaxKind.KDatetime) throw new __ArgumentException(nameof(kDatetime));
            return (SimpleTypeAlt11Syntax)SoalLanguage.Instance.InternalSyntaxFactory.SimpleTypeAlt11((__InternalSyntaxToken)kDatetime.Node).CreateRed();
        }
        
        public SimpleTypeAlt11Syntax SimpleTypeAlt11()
        {
            return this.SimpleTypeAlt11(this.Token(SoalSyntaxKind.KDatetime));
        }

        public SimpleTypeAlt12Syntax SimpleTypeAlt12(__SyntaxToken kDuration)
        {
            if (kDuration.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(kDuration));
            if (kDuration.RawKind != (int)SoalSyntaxKind.KDuration) throw new __ArgumentException(nameof(kDuration));
            return (SimpleTypeAlt12Syntax)SoalLanguage.Instance.InternalSyntaxFactory.SimpleTypeAlt12((__InternalSyntaxToken)kDuration.Node).CreateRed();
        }
        
        public SimpleTypeAlt12Syntax SimpleTypeAlt12()
        {
            return this.SimpleTypeAlt12(this.Token(SoalSyntaxKind.KDuration));
        }

        public SimpleTypeAlt13Syntax SimpleTypeAlt13(QualifierSyntax qualifier)
        {
            if (qualifier is null) throw new __ArgumentNullException(nameof(qualifier));
            return (SimpleTypeAlt13Syntax)SoalLanguage.Instance.InternalSyntaxFactory.SimpleTypeAlt13((InternalSyntax.QualifierGreen)qualifier.Green).CreateRed();
        }

        public NameSyntax Name(IdentifierSyntax identifier)
        {
            if (identifier is null) throw new __ArgumentNullException(nameof(identifier));
            return (NameSyntax)SoalLanguage.Instance.InternalSyntaxFactory.Name((InternalSyntax.IdentifierGreen)identifier.Green).CreateRed();
        }

        public QualifierSyntax Qualifier(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<IdentifierSyntax> identifier)
        {
            return (QualifierSyntax)SoalLanguage.Instance.InternalSyntaxFactory.Qualifier(__GreenNodeExtensions.ToGreenSeparatedList<InternalSyntax.IdentifierGreen>(identifier.Node, reversed: false)).CreateRed();
        }

        public IdentifierSyntax Identifier(__SyntaxToken token)
        {
            if (token.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(token));
            if (token.RawKind != (int)SoalSyntaxKind.TIdentifier && token.RawKind != (int)SoalSyntaxKind.TVerbatimIdentifier) throw new __ArgumentException(nameof(token));
            return (IdentifierSyntax)SoalLanguage.Instance.InternalSyntaxFactory.Identifier((__InternalSyntaxToken)token.Node).CreateRed();
        }

        public MainBlock1Syntax MainBlock1(global::MetaDslx.CodeAnalysis.SyntaxList<DeclarationSyntax> declarationList)
        {
            return (MainBlock1Syntax)SoalLanguage.Instance.InternalSyntaxFactory.MainBlock1(__GreenNodeExtensions.ToGreenList<InternalSyntax.DeclarationGreen>(declarationList.Node)).CreateRed();
        }

        public EnumTypeBlock1Syntax EnumTypeBlock1(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<EnumLiteralSyntax> literals)
        {
            return (EnumTypeBlock1Syntax)SoalLanguage.Instance.InternalSyntaxFactory.EnumTypeBlock1(__GreenNodeExtensions.ToGreenSeparatedList<InternalSyntax.EnumLiteralGreen>(literals.Node, reversed: false)).CreateRed();
        }

        public EnumTypeBlock1literalsBlockSyntax EnumTypeBlock1literalsBlock(__SyntaxToken tComma, EnumLiteralSyntax literals)
        {
            if (tComma.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tComma));
            if (tComma.RawKind != (int)SoalSyntaxKind.TComma) throw new __ArgumentException(nameof(tComma));
            if (literals is null) throw new __ArgumentNullException(nameof(literals));
            return (EnumTypeBlock1literalsBlockSyntax)SoalLanguage.Instance.InternalSyntaxFactory.EnumTypeBlock1literalsBlock((__InternalSyntaxToken)tComma.Node, (InternalSyntax.EnumLiteralGreen)literals.Green).CreateRed();
        }
        
        public EnumTypeBlock1literalsBlockSyntax EnumTypeBlock1literalsBlock(EnumLiteralSyntax literals)
        {
            return this.EnumTypeBlock1literalsBlock(this.Token(SoalSyntaxKind.TComma), literals);
        }

        public StructTypeBlock1Syntax StructTypeBlock1(__SyntaxToken tColon, QualifierSyntax baseType)
        {
            if (tColon.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tColon));
            if (tColon.RawKind != (int)SoalSyntaxKind.TColon) throw new __ArgumentException(nameof(tColon));
            if (baseType is null) throw new __ArgumentNullException(nameof(baseType));
            return (StructTypeBlock1Syntax)SoalLanguage.Instance.InternalSyntaxFactory.StructTypeBlock1((__InternalSyntaxToken)tColon.Node, (InternalSyntax.QualifierGreen)baseType.Green).CreateRed();
        }
        
        public StructTypeBlock1Syntax StructTypeBlock1(QualifierSyntax baseType)
        {
            return this.StructTypeBlock1(this.Token(SoalSyntaxKind.TColon), baseType);
        }

        public ResourceBlock1Syntax ResourceBlock1(__SyntaxToken kThrows, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<QualifierSyntax> exceptions)
        {
            if (kThrows.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(kThrows));
            if (kThrows.RawKind != (int)SoalSyntaxKind.KThrows) throw new __ArgumentException(nameof(kThrows));
            return (ResourceBlock1Syntax)SoalLanguage.Instance.InternalSyntaxFactory.ResourceBlock1((__InternalSyntaxToken)kThrows.Node, __GreenNodeExtensions.ToGreenSeparatedList<InternalSyntax.QualifierGreen>(exceptions.Node, reversed: false)).CreateRed();
        }
        
        public ResourceBlock1Syntax ResourceBlock1(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<QualifierSyntax> exceptions)
        {
            return this.ResourceBlock1(this.Token(SoalSyntaxKind.KThrows), exceptions);
        }

        public ResourceBlock1exceptionsBlockSyntax ResourceBlock1exceptionsBlock(__SyntaxToken tComma, QualifierSyntax exceptions)
        {
            if (tComma.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tComma));
            if (tComma.RawKind != (int)SoalSyntaxKind.TComma) throw new __ArgumentException(nameof(tComma));
            if (exceptions is null) throw new __ArgumentNullException(nameof(exceptions));
            return (ResourceBlock1exceptionsBlockSyntax)SoalLanguage.Instance.InternalSyntaxFactory.ResourceBlock1exceptionsBlock((__InternalSyntaxToken)tComma.Node, (InternalSyntax.QualifierGreen)exceptions.Green).CreateRed();
        }
        
        public ResourceBlock1exceptionsBlockSyntax ResourceBlock1exceptionsBlock(QualifierSyntax exceptions)
        {
            return this.ResourceBlock1exceptionsBlock(this.Token(SoalSyntaxKind.TComma), exceptions);
        }

        public OperationBlock1Syntax OperationBlock1(__SyntaxToken kThrows, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<QualifierSyntax> exceptions)
        {
            if (kThrows.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(kThrows));
            if (kThrows.RawKind != (int)SoalSyntaxKind.KThrows) throw new __ArgumentException(nameof(kThrows));
            return (OperationBlock1Syntax)SoalLanguage.Instance.InternalSyntaxFactory.OperationBlock1((__InternalSyntaxToken)kThrows.Node, __GreenNodeExtensions.ToGreenSeparatedList<InternalSyntax.QualifierGreen>(exceptions.Node, reversed: false)).CreateRed();
        }
        
        public OperationBlock1Syntax OperationBlock1(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<QualifierSyntax> exceptions)
        {
            return this.OperationBlock1(this.Token(SoalSyntaxKind.KThrows), exceptions);
        }

        public OperationBlock1exceptionsBlockSyntax OperationBlock1exceptionsBlock(__SyntaxToken tComma, QualifierSyntax exceptions)
        {
            if (tComma.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tComma));
            if (tComma.RawKind != (int)SoalSyntaxKind.TComma) throw new __ArgumentException(nameof(tComma));
            if (exceptions is null) throw new __ArgumentNullException(nameof(exceptions));
            return (OperationBlock1exceptionsBlockSyntax)SoalLanguage.Instance.InternalSyntaxFactory.OperationBlock1exceptionsBlock((__InternalSyntaxToken)tComma.Node, (InternalSyntax.QualifierGreen)exceptions.Green).CreateRed();
        }
        
        public OperationBlock1exceptionsBlockSyntax OperationBlock1exceptionsBlock(QualifierSyntax exceptions)
        {
            return this.OperationBlock1exceptionsBlock(this.Token(SoalSyntaxKind.TComma), exceptions);
        }

        public InputParameterListBlock1Syntax InputParameterListBlock1(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<ParameterSyntax> parameters)
        {
            return (InputParameterListBlock1Syntax)SoalLanguage.Instance.InternalSyntaxFactory.InputParameterListBlock1(__GreenNodeExtensions.ToGreenSeparatedList<InternalSyntax.ParameterGreen>(parameters.Node, reversed: false)).CreateRed();
        }

        public InputParameterListBlock1parametersBlockSyntax InputParameterListBlock1parametersBlock(__SyntaxToken tComma, ParameterSyntax parameters)
        {
            if (tComma.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tComma));
            if (tComma.RawKind != (int)SoalSyntaxKind.TComma) throw new __ArgumentException(nameof(tComma));
            if (parameters is null) throw new __ArgumentNullException(nameof(parameters));
            return (InputParameterListBlock1parametersBlockSyntax)SoalLanguage.Instance.InternalSyntaxFactory.InputParameterListBlock1parametersBlock((__InternalSyntaxToken)tComma.Node, (InternalSyntax.ParameterGreen)parameters.Green).CreateRed();
        }
        
        public InputParameterListBlock1parametersBlockSyntax InputParameterListBlock1parametersBlock(ParameterSyntax parameters)
        {
            return this.InputParameterListBlock1parametersBlock(this.Token(SoalSyntaxKind.TComma), parameters);
        }

        public OutputParameterListAlt3parametersBlockSyntax OutputParameterListAlt3parametersBlock(__SyntaxToken tComma, ParameterSyntax parameters)
        {
            if (tComma.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tComma));
            if (tComma.RawKind != (int)SoalSyntaxKind.TComma) throw new __ArgumentException(nameof(tComma));
            if (parameters is null) throw new __ArgumentNullException(nameof(parameters));
            return (OutputParameterListAlt3parametersBlockSyntax)SoalLanguage.Instance.InternalSyntaxFactory.OutputParameterListAlt3parametersBlock((__InternalSyntaxToken)tComma.Node, (InternalSyntax.ParameterGreen)parameters.Green).CreateRed();
        }
        
        public OutputParameterListAlt3parametersBlockSyntax OutputParameterListAlt3parametersBlock(ParameterSyntax parameters)
        {
            return this.OutputParameterListAlt3parametersBlock(this.Token(SoalSyntaxKind.TComma), parameters);
        }

        public TypeReferenceBlock1Syntax TypeReferenceBlock1(__SyntaxToken tLBracket, __SyntaxToken tRBracket)
        {
            if (tLBracket.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tLBracket));
            if (tLBracket.RawKind != (int)SoalSyntaxKind.TLBracket) throw new __ArgumentException(nameof(tLBracket));
            if (tRBracket.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tRBracket));
            if (tRBracket.RawKind != (int)SoalSyntaxKind.TRBracket) throw new __ArgumentException(nameof(tRBracket));
            return (TypeReferenceBlock1Syntax)SoalLanguage.Instance.InternalSyntaxFactory.TypeReferenceBlock1((__InternalSyntaxToken)tLBracket.Node, (__InternalSyntaxToken)tRBracket.Node).CreateRed();
        }
        
        public TypeReferenceBlock1Syntax TypeReferenceBlock1()
        {
            return this.TypeReferenceBlock1(this.Token(SoalSyntaxKind.TLBracket), this.Token(SoalSyntaxKind.TRBracket));
        }

        public QualifierIdentifierBlockSyntax QualifierIdentifierBlock(__SyntaxToken tDot, IdentifierSyntax identifier)
        {
            if (tDot.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tDot));
            if (tDot.RawKind != (int)SoalSyntaxKind.TDot) throw new __ArgumentException(nameof(tDot));
            if (identifier is null) throw new __ArgumentNullException(nameof(identifier));
            return (QualifierIdentifierBlockSyntax)SoalLanguage.Instance.InternalSyntaxFactory.QualifierIdentifierBlock((__InternalSyntaxToken)tDot.Node, (InternalSyntax.IdentifierGreen)identifier.Green).CreateRed();
        }
        
        public QualifierIdentifierBlockSyntax QualifierIdentifierBlock(IdentifierSyntax identifier)
        {
            return this.QualifierIdentifierBlock(this.Token(SoalSyntaxKind.TDot), identifier);
        }

        public override __BinderFactoryVisitor CreateBinderFactoryVisitor(__BinderFactory binderFactory)
        {
            return new global::MetaDslx.Examples.Soal.Compiler.Binding.SoalBinderFactoryVisitor(binderFactory);
        }

        internal static global::System.Collections.Generic.IEnumerable<__Type> GetNodeTypes()
        {
            return new __Type[] {
                typeof(MainSyntax),
                typeof(UsingSyntax),
                typeof(DeclarationAlt1Syntax),
                typeof(DeclarationAlt2Syntax),
                typeof(DeclarationAlt3Syntax),
                typeof(DeclarationAlt4Syntax),
                typeof(EnumTypeSyntax),
                typeof(EnumLiteralSyntax),
                typeof(StructTypeSyntax),
                typeof(PropertySyntax),
                typeof(InterfaceSyntax),
                typeof(ResourceSyntax),
                typeof(OperationSyntax),
                typeof(InputParameterListSyntax),
                typeof(OutputParameterListAlt1Syntax),
                typeof(OutputParameterListAlt2Syntax),
                typeof(OutputParameterListAlt3Syntax),
                typeof(ParameterSyntax),
                typeof(SingleReturnParameterSyntax),
                typeof(ServiceSyntax),
                typeof(BindingKindSyntax),
                typeof(TypeReferenceSyntax),
                typeof(SimpleTypeAlt1Syntax),
                typeof(SimpleTypeAlt2Syntax),
                typeof(SimpleTypeAlt3Syntax),
                typeof(SimpleTypeAlt4Syntax),
                typeof(SimpleTypeAlt5Syntax),
                typeof(SimpleTypeAlt6Syntax),
                typeof(SimpleTypeAlt7Syntax),
                typeof(SimpleTypeAlt8Syntax),
                typeof(SimpleTypeAlt9Syntax),
                typeof(SimpleTypeAlt10Syntax),
                typeof(SimpleTypeAlt11Syntax),
                typeof(SimpleTypeAlt12Syntax),
                typeof(SimpleTypeAlt13Syntax),
                typeof(NameSyntax),
                typeof(QualifierSyntax),
                typeof(IdentifierSyntax),
                typeof(MainBlock1Syntax),
                typeof(EnumTypeBlock1Syntax),
                typeof(EnumTypeBlock1literalsBlockSyntax),
                typeof(StructTypeBlock1Syntax),
                typeof(ResourceBlock1Syntax),
                typeof(ResourceBlock1exceptionsBlockSyntax),
                typeof(OperationBlock1Syntax),
                typeof(OperationBlock1exceptionsBlockSyntax),
                typeof(InputParameterListBlock1Syntax),
                typeof(InputParameterListBlock1parametersBlockSyntax),
                typeof(OutputParameterListAlt3parametersBlockSyntax),
                typeof(TypeReferenceBlock1Syntax),
                typeof(QualifierIdentifierBlockSyntax),
            };
        }

    }
}    
