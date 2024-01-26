#nullable enable

namespace MetaDslx.Bootstrap.MetaCompiler2.Compiler.Syntax
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

    public class CompilerSyntaxFactory : global::MetaDslx.CodeAnalysis.Syntax.SyntaxFactory
    {
        public CompilerSyntaxFactory(global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.InternalSyntaxFactory internalSyntaxFactory) 
            : base(internalSyntaxFactory)
        {
        }

        public override __Language Language => CompilerLanguage.Instance;

        public override __ParseOptions DefaultParseOptions => CompilerParseOptions.Default;

        /// <summary>
        /// Create a new syntax tree from a syntax node.
        /// </summary>
        public CompilerSyntaxTree SyntaxTree(__SyntaxNode root, CompilerParseOptions? options = null, string? path = "", __Encoding? encoding = null)
        {
            return CompilerSyntaxTree.Create((CompilerSyntaxNode)root, __IncrementalParseData.Empty, options, path, null, encoding);
        }

        /// <summary>
        /// Produces a syntax tree by parsing the source text.
        /// </summary>
        public CompilerSyntaxTree ParseSyntaxTree(
            string text,
            CompilerParseOptions options = null,
            string path = "",
            __Encoding encoding = null,
            __CancellationToken cancellationToken = default)
        {
            return (CompilerSyntaxTree)this.ParseSyntaxTreeCore(__SourceText.From(text, encoding), options, path, cancellationToken);
        }

        /// <summary>
        /// Produces a syntax tree by parsing the source text.
        /// </summary>
        public CompilerSyntaxTree ParseSyntaxTree(
            __SourceText text,
            CompilerParseOptions? options = null,
            string path = "",
            __CancellationToken cancellationToken = default)
        {
            return (CompilerSyntaxTree)this.ParseSyntaxTreeCore(text, options, path, cancellationToken);
        }

        protected override __SyntaxTree ParseSyntaxTreeCore(
            __SourceText text,
            __ParseOptions? options = null,
            string path = "",
            __CancellationToken cancellationToken = default)
        {
            return CompilerSyntaxTree.ParseText(text, (CompilerParseOptions?)options, path, cancellationToken);
        }

        public override __SyntaxTree MakeSyntaxTree(__SyntaxNode root, __ParseOptions? options = null, string path = "", __Encoding? encoding = null)
        {
            return CompilerSyntaxTree.Create((CompilerSyntaxNode)root, __IncrementalParseData.Empty, (CompilerParseOptions)options, path, null, encoding);
        }

        /// <summary>
        /// Creates a token corresponding to a syntax kind. This method can be used for token syntax kinds whose text
        /// can be inferred by the kind alone.
        /// </summary>
        /// <param name="kind">A syntax kind value for a token. These have the suffix Token or Keyword.</param>
        /// <returns></returns>
        public virtual __SyntaxToken Token(CompilerSyntaxKind kind)
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
        public virtual __SyntaxToken Token(__SyntaxTriviaList leading, CompilerSyntaxKind kind, __SyntaxTriviaList trailing)
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
        public virtual __SyntaxToken Token(__SyntaxTriviaList leading, CompilerSyntaxKind kind, string text, string valueText, __SyntaxTriviaList trailing)
        {
            return this.Token(leading, (int)kind, text, valueText, trailing);
        }

        /// <summary>
        /// Creates a missing token corresponding to syntax kind. A missing token is produced by the parser when an
        /// expected token is not found. A missing token has no text and normally has associated diagnostics.
        /// </summary>
        /// <param name="kind">A syntax kind value for a token. These have the suffix Token or Keyword.</param>
        public virtual __SyntaxToken MissingToken(CompilerSyntaxKind kind)
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
        public virtual __SyntaxToken MissingToken(__SyntaxTriviaList leading, CompilerSyntaxKind kind, __SyntaxTriviaList trailing)
        {
            return this.MissingToken(leading, (int)kind, trailing);
        }


        public __SyntaxToken TInteger(string text)
        {
            return new __SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.TInteger(text));
        }

        public __SyntaxToken TInteger(string text, object value)
        {
            return new __SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.TInteger(text, value));
        }

        public __SyntaxToken TDecimal(string text)
        {
            return new __SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.TDecimal(text));
        }

        public __SyntaxToken TDecimal(string text, object value)
        {
            return new __SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.TDecimal(text, value));
        }

        public __SyntaxToken TIdentifier(string text)
        {
            return new __SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.TIdentifier(text));
        }

        public __SyntaxToken TIdentifier(string text, object value)
        {
            return new __SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.TIdentifier(text, value));
        }

        public __SyntaxToken TVerbatimIdentifier(string text)
        {
            return new __SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.TVerbatimIdentifier(text));
        }

        public __SyntaxToken TVerbatimIdentifier(string text, object value)
        {
            return new __SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.TVerbatimIdentifier(text, value));
        }

        public __SyntaxToken TString(string text)
        {
            return new __SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.TString(text));
        }

        public __SyntaxToken TString(string text, object value)
        {
            return new __SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.TString(text, value));
        }

        public __SyntaxToken TWhitespace(string text)
        {
            return new __SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.TWhitespace(text));
        }

        public __SyntaxToken TWhitespace(string text, object value)
        {
            return new __SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.TWhitespace(text, value));
        }

        public __SyntaxToken TLineEnd(string text)
        {
            return new __SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.TLineEnd(text));
        }

        public __SyntaxToken TLineEnd(string text, object value)
        {
            return new __SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.TLineEnd(text, value));
        }

        public __SyntaxToken TSingleLineComment(string text)
        {
            return new __SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.TSingleLineComment(text));
        }

        public __SyntaxToken TSingleLineComment(string text, object value)
        {
            return new __SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.TSingleLineComment(text, value));
        }

        public __SyntaxToken TMultiLineComment(string text)
        {
            return new __SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.TMultiLineComment(text));
        }

        public __SyntaxToken TMultiLineComment(string text, object value)
        {
            return new __SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.TMultiLineComment(text, value));
        }

        public __SyntaxToken TInvalidToken(string text)
        {
            return new __SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.TInvalidToken(text));
        }

        public __SyntaxToken TInvalidToken(string text, object value)
        {
            return new __SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.TInvalidToken(text, value));
        }

        public MainSyntax Main(__SyntaxToken kNamespace, QualifierSyntax qualifier, __SyntaxToken tSemicolon, global::MetaDslx.CodeAnalysis.SyntaxList<UsingSyntax> usingList, MainBlock1Syntax block, __SyntaxToken endOfFileToken)
        {
            if (kNamespace.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(kNamespace));
            if (kNamespace.RawKind != (int)CompilerSyntaxKind.KNamespace) throw new __ArgumentException(nameof(kNamespace));
            if (qualifier is null) throw new __ArgumentNullException(nameof(qualifier));
            if (tSemicolon.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tSemicolon));
            if (tSemicolon.RawKind != (int)CompilerSyntaxKind.TSemicolon) throw new __ArgumentException(nameof(tSemicolon));
            if (block is null) throw new __ArgumentNullException(nameof(block));
            if (endOfFileToken.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(endOfFileToken));
            if (endOfFileToken.RawKind != (int)__InternalSyntaxKind.Eof) throw new __ArgumentException(nameof(endOfFileToken));
            return (MainSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.Main((__InternalSyntaxToken)kNamespace.Node, (InternalSyntax.QualifierGreen)qualifier.Green, (__InternalSyntaxToken)tSemicolon.Node, __GreenNodeExtensions.ToGreenList<InternalSyntax.UsingGreen>(usingList.Node), block, (__InternalSyntaxToken)endOfFileToken.Node).CreateRed();
        }
        
        public MainSyntax Main(QualifierSyntax qualifier, global::MetaDslx.CodeAnalysis.SyntaxList<UsingSyntax> usingList, MainBlock1Syntax block, __SyntaxToken endOfFileToken)
        {
            return this.Main(this.Token(CompilerSyntaxKind.KNamespace), qualifier, this.Token(CompilerSyntaxKind.TSemicolon), usingList, block, this.Token(CompilerSyntaxKind.Eof));
        }

        public UsingSyntax Using(__SyntaxToken kUsing, QualifierSyntax namespaces, __SyntaxToken tSemicolon)
        {
            if (kUsing.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(kUsing));
            if (kUsing.RawKind != (int)CompilerSyntaxKind.KUsing) throw new __ArgumentException(nameof(kUsing));
            if (namespaces is null) throw new __ArgumentNullException(nameof(namespaces));
            if (tSemicolon.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tSemicolon));
            if (tSemicolon.RawKind != (int)CompilerSyntaxKind.TSemicolon) throw new __ArgumentException(nameof(tSemicolon));
            return (UsingSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.Using((__InternalSyntaxToken)kUsing.Node, (InternalSyntax.QualifierGreen)namespaces.Green, (__InternalSyntaxToken)tSemicolon.Node).CreateRed();
        }
        
        public UsingSyntax Using(QualifierSyntax namespaces)
        {
            return this.Using(this.Token(CompilerSyntaxKind.KUsing), namespaces, this.Token(CompilerSyntaxKind.TSemicolon));
        }

        public LanguageDeclarationSyntax LanguageDeclaration(__SyntaxToken kLanguage, NameSyntax name, __SyntaxToken tSemicolon, GrammarSyntax grammar)
        {
            if (kLanguage.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(kLanguage));
            if (kLanguage.RawKind != (int)CompilerSyntaxKind.KLanguage) throw new __ArgumentException(nameof(kLanguage));
            if (name is null) throw new __ArgumentNullException(nameof(name));
            if (tSemicolon.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tSemicolon));
            if (tSemicolon.RawKind != (int)CompilerSyntaxKind.TSemicolon) throw new __ArgumentException(nameof(tSemicolon));
            if (grammar is null) throw new __ArgumentNullException(nameof(grammar));
            return (LanguageDeclarationSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.LanguageDeclaration((__InternalSyntaxToken)kLanguage.Node, (InternalSyntax.NameGreen)name.Green, (__InternalSyntaxToken)tSemicolon.Node, (InternalSyntax.GrammarGreen)grammar.Green).CreateRed();
        }
        
        public LanguageDeclarationSyntax LanguageDeclaration(NameSyntax name, GrammarSyntax grammar)
        {
            return this.LanguageDeclaration(this.Token(CompilerSyntaxKind.KLanguage), name, this.Token(CompilerSyntaxKind.TSemicolon), grammar);
        }

        public GrammarSyntax Grammar(GrammarBlock1Syntax block)
        {
            if (block is null) throw new __ArgumentNullException(nameof(block));
            return (GrammarSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.Grammar(block).CreateRed();
        }

        public GrammarRuleAlt1Syntax GrammarRuleAlt1(RuleSyntax rule)
        {
            if (rule is null) throw new __ArgumentNullException(nameof(rule));
            return (GrammarRuleAlt1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.GrammarRuleAlt1((InternalSyntax.RuleGreen)rule.Green).CreateRed();
        }

        public GrammarRuleAlt2Syntax GrammarRuleAlt2(LexerRuleSyntax lexerRule)
        {
            if (lexerRule is null) throw new __ArgumentNullException(nameof(lexerRule));
            return (GrammarRuleAlt2Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.GrammarRuleAlt2((InternalSyntax.LexerRuleGreen)lexerRule.Green).CreateRed();
        }

        public RuleSyntax Rule(global::MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> annotations1, RuleBlock1Syntax block, __SyntaxToken tColon, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<AlternativeSyntax> alternatives, __SyntaxToken tSemicolon)
        {
            if (block is null) throw new __ArgumentNullException(nameof(block));
            if (tColon.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tColon));
            if (tColon.RawKind != (int)CompilerSyntaxKind.TColon) throw new __ArgumentException(nameof(tColon));
            if (tSemicolon.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tSemicolon));
            if (tSemicolon.RawKind != (int)CompilerSyntaxKind.TSemicolon) throw new __ArgumentException(nameof(tSemicolon));
            return (RuleSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.Rule(__GreenNodeExtensions.ToGreenList<InternalSyntax.ParserAnnotationGreen>(annotations1.Node), block, (__InternalSyntaxToken)tColon.Node, __GreenNodeExtensions.ToGreenSeparatedList<InternalSyntax.AlternativeGreen>(alternatives.Node, reversed: false), (__InternalSyntaxToken)tSemicolon.Node).CreateRed();
        }
        
        public RuleSyntax Rule(global::MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> annotations1, RuleBlock1Syntax block, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<AlternativeSyntax> alternatives)
        {
            return this.Rule(annotations1, block, this.Token(CompilerSyntaxKind.TColon), alternatives, this.Token(CompilerSyntaxKind.TSemicolon));
        }

        public AlternativeSyntax Alternative(AlternativeBlock1Syntax block1, global::MetaDslx.CodeAnalysis.SyntaxList<ElementSyntax> elements, AlternativeBlock2Syntax block2)
        {
            return (AlternativeSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.Alternative(block1, __GreenNodeExtensions.ToGreenList<InternalSyntax.ElementGreen>(elements.Node), block2).CreateRed();
        }
        
        public AlternativeSyntax Alternative(global::MetaDslx.CodeAnalysis.SyntaxList<ElementSyntax> elements)
        {
            return this.Alternative(default, elements, default);
        }

        public ElementSyntax Element(ElementBlock1Syntax block, ElementValueSyntax value)
        {
            if (value is null) throw new __ArgumentNullException(nameof(value));
            return (ElementSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.Element(block, (InternalSyntax.ElementValueGreen)value.Green).CreateRed();
        }
        
        public ElementSyntax Element(ElementValueSyntax value)
        {
            return this.Element(default, value);
        }

        public ElementValueAlt1Syntax ElementValueAlt1(BlockSyntax block)
        {
            if (block is null) throw new __ArgumentNullException(nameof(block));
            return (ElementValueAlt1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.ElementValueAlt1((InternalSyntax.BlockGreen)block.Green).CreateRed();
        }

        public ElementValueAlt2Syntax ElementValueAlt2(Eof1Syntax eof1)
        {
            if (eof1 is null) throw new __ArgumentNullException(nameof(eof1));
            return (ElementValueAlt2Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.ElementValueAlt2((InternalSyntax.Eof1Green)eof1.Green).CreateRed();
        }

        public ElementValueAlt3Syntax ElementValueAlt3(FixedSyntax @fixed)
        {
            if (@fixed is null) throw new __ArgumentNullException(nameof(@fixed));
            return (ElementValueAlt3Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.ElementValueAlt3((InternalSyntax.FixedGreen)@fixed.Green).CreateRed();
        }

        public ElementValueAlt4Syntax ElementValueAlt4(RuleRefSyntax ruleRef)
        {
            if (ruleRef is null) throw new __ArgumentNullException(nameof(ruleRef));
            return (ElementValueAlt4Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.ElementValueAlt4((InternalSyntax.RuleRefGreen)ruleRef.Green).CreateRed();
        }

        public BlockSyntax Block(global::MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> annotations1, __SyntaxToken tLParen, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<BlockAlternativeSyntax> alternatives, __SyntaxToken tRParen, MultiplicitySyntax multiplicity)
        {
            if (tLParen.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tLParen));
            if (tLParen.RawKind != (int)CompilerSyntaxKind.TLParen) throw new __ArgumentException(nameof(tLParen));
            if (tRParen.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tRParen));
            if (tRParen.RawKind != (int)CompilerSyntaxKind.TRParen) throw new __ArgumentException(nameof(tRParen));
            return (BlockSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.Block(__GreenNodeExtensions.ToGreenList<InternalSyntax.ParserAnnotationGreen>(annotations1.Node), (__InternalSyntaxToken)tLParen.Node, __GreenNodeExtensions.ToGreenSeparatedList<InternalSyntax.BlockAlternativeGreen>(alternatives.Node, reversed: false), (__InternalSyntaxToken)tRParen.Node, (InternalSyntax.MultiplicityGreen)multiplicity.Green).CreateRed();
        }
        
        public BlockSyntax Block(global::MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> annotations1, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<BlockAlternativeSyntax> alternatives)
        {
            return this.Block(annotations1, this.Token(CompilerSyntaxKind.TLParen), alternatives, this.Token(CompilerSyntaxKind.TRParen), default);
        }

        public BlockAlternativeSyntax BlockAlternative(global::MetaDslx.CodeAnalysis.SyntaxList<ElementSyntax> elements, BlockAlternativeBlock1Syntax block)
        {
            return (BlockAlternativeSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.BlockAlternative(__GreenNodeExtensions.ToGreenList<InternalSyntax.ElementGreen>(elements.Node), block).CreateRed();
        }
        
        public BlockAlternativeSyntax BlockAlternative(global::MetaDslx.CodeAnalysis.SyntaxList<ElementSyntax> elements)
        {
            return this.BlockAlternative(elements, default);
        }

        public RuleRefAlt1Syntax RuleRefAlt1(global::MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> annotations1, IdentifierSyntax grammarRule, MultiplicitySyntax multiplicity)
        {
            if (grammarRule is null) throw new __ArgumentNullException(nameof(grammarRule));
            return (RuleRefAlt1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.RuleRefAlt1(__GreenNodeExtensions.ToGreenList<InternalSyntax.ParserAnnotationGreen>(annotations1.Node), (InternalSyntax.IdentifierGreen)grammarRule.Green, (InternalSyntax.MultiplicityGreen)multiplicity.Green).CreateRed();
        }
        
        public RuleRefAlt1Syntax RuleRefAlt1(global::MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> annotations1, IdentifierSyntax grammarRule)
        {
            return this.RuleRefAlt1(annotations1, grammarRule, default);
        }

        public RuleRefAlt2Syntax RuleRefAlt2(global::MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> annotations1, __SyntaxToken tHash, TypeReferenceSyntax referencedTypes, MultiplicitySyntax multiplicity)
        {
            if (tHash.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tHash));
            if (tHash.RawKind != (int)CompilerSyntaxKind.THash) throw new __ArgumentException(nameof(tHash));
            if (referencedTypes is null) throw new __ArgumentNullException(nameof(referencedTypes));
            return (RuleRefAlt2Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.RuleRefAlt2(__GreenNodeExtensions.ToGreenList<InternalSyntax.ParserAnnotationGreen>(annotations1.Node), (__InternalSyntaxToken)tHash.Node, (InternalSyntax.TypeReferenceGreen)referencedTypes.Green, (InternalSyntax.MultiplicityGreen)multiplicity.Green).CreateRed();
        }
        
        public RuleRefAlt2Syntax RuleRefAlt2(global::MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> annotations1, TypeReferenceSyntax referencedTypes)
        {
            return this.RuleRefAlt2(annotations1, this.Token(CompilerSyntaxKind.THash), referencedTypes, default);
        }

        public RuleRefAlt3Syntax RuleRefAlt3(global::MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> annotations1, __SyntaxToken tHashLBrace, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<TypeReferenceSyntax> referencedTypes, RuleRefAlt3Block1Syntax block, __SyntaxToken tRBrace, MultiplicitySyntax multiplicity)
        {
            if (tHashLBrace.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tHashLBrace));
            if (tHashLBrace.RawKind != (int)CompilerSyntaxKind.THashLBrace) throw new __ArgumentException(nameof(tHashLBrace));
            if (tRBrace.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tRBrace));
            if (tRBrace.RawKind != (int)CompilerSyntaxKind.TRBrace) throw new __ArgumentException(nameof(tRBrace));
            return (RuleRefAlt3Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.RuleRefAlt3(__GreenNodeExtensions.ToGreenList<InternalSyntax.ParserAnnotationGreen>(annotations1.Node), (__InternalSyntaxToken)tHashLBrace.Node, __GreenNodeExtensions.ToGreenSeparatedList<InternalSyntax.TypeReferenceGreen>(referencedTypes.Node, reversed: false), block, (__InternalSyntaxToken)tRBrace.Node, (InternalSyntax.MultiplicityGreen)multiplicity.Green).CreateRed();
        }
        
        public RuleRefAlt3Syntax RuleRefAlt3(global::MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> annotations1, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<TypeReferenceSyntax> referencedTypes)
        {
            return this.RuleRefAlt3(annotations1, this.Token(CompilerSyntaxKind.THashLBrace), referencedTypes, default, this.Token(CompilerSyntaxKind.TRBrace), default);
        }

        public Eof1Syntax Eof1(__SyntaxToken kEof)
        {
            if (kEof.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(kEof));
            if (kEof.RawKind != (int)CompilerSyntaxKind.KEof) throw new __ArgumentException(nameof(kEof));
            return (Eof1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.Eof1((__InternalSyntaxToken)kEof.Node).CreateRed();
        }
        
        public Eof1Syntax Eof1()
        {
            return this.Eof1(this.Token(CompilerSyntaxKind.KEof));
        }

        public FixedSyntax Fixed(global::MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> annotations1, __SyntaxToken text, MultiplicitySyntax multiplicity)
        {
            if (text.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(text));
            if (text.RawKind != (int)CompilerSyntaxKind.TString) throw new __ArgumentException(nameof(text));
            return (FixedSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.Fixed(__GreenNodeExtensions.ToGreenList<InternalSyntax.ParserAnnotationGreen>(annotations1.Node), (__InternalSyntaxToken)text.Node, (InternalSyntax.MultiplicityGreen)multiplicity.Green).CreateRed();
        }
        
        public FixedSyntax Fixed(global::MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> annotations1, __SyntaxToken text)
        {
            return this.Fixed(annotations1, this.Token(CompilerSyntaxKind.TString), default);
        }

        public LexerRuleAlt1Syntax LexerRuleAlt1(TokenSyntax token)
        {
            if (token is null) throw new __ArgumentNullException(nameof(token));
            return (LexerRuleAlt1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.LexerRuleAlt1((InternalSyntax.TokenGreen)token.Green).CreateRed();
        }

        public LexerRuleAlt2Syntax LexerRuleAlt2(FragmentSyntax fragment)
        {
            if (fragment is null) throw new __ArgumentNullException(nameof(fragment));
            return (LexerRuleAlt2Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.LexerRuleAlt2((InternalSyntax.FragmentGreen)fragment.Green).CreateRed();
        }

        public TokenSyntax Token(global::MetaDslx.CodeAnalysis.SyntaxList<LexerAnnotationSyntax> annotations1, TokenBlock1Syntax block, __SyntaxToken tColon, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<LAlternativeSyntax> alternatives, __SyntaxToken tSemicolon)
        {
            if (block is null) throw new __ArgumentNullException(nameof(block));
            if (tColon.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tColon));
            if (tColon.RawKind != (int)CompilerSyntaxKind.TColon) throw new __ArgumentException(nameof(tColon));
            if (tSemicolon.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tSemicolon));
            if (tSemicolon.RawKind != (int)CompilerSyntaxKind.TSemicolon) throw new __ArgumentException(nameof(tSemicolon));
            return (TokenSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.Token(__GreenNodeExtensions.ToGreenList<InternalSyntax.LexerAnnotationGreen>(annotations1.Node), block, (__InternalSyntaxToken)tColon.Node, __GreenNodeExtensions.ToGreenSeparatedList<InternalSyntax.LAlternativeGreen>(alternatives.Node, reversed: false), (__InternalSyntaxToken)tSemicolon.Node).CreateRed();
        }
        
        public TokenSyntax Token(global::MetaDslx.CodeAnalysis.SyntaxList<LexerAnnotationSyntax> annotations1, TokenBlock1Syntax block, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<LAlternativeSyntax> alternatives)
        {
            return this.Token(annotations1, block, this.Token(CompilerSyntaxKind.TColon), alternatives, this.Token(CompilerSyntaxKind.TSemicolon));
        }

        public FragmentSyntax Fragment(__SyntaxToken kFragment, NameSyntax name, __SyntaxToken tColon, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<LAlternativeSyntax> alternatives, __SyntaxToken tSemicolon)
        {
            if (kFragment.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(kFragment));
            if (kFragment.RawKind != (int)CompilerSyntaxKind.KFragment) throw new __ArgumentException(nameof(kFragment));
            if (name is null) throw new __ArgumentNullException(nameof(name));
            if (tColon.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tColon));
            if (tColon.RawKind != (int)CompilerSyntaxKind.TColon) throw new __ArgumentException(nameof(tColon));
            if (tSemicolon.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tSemicolon));
            if (tSemicolon.RawKind != (int)CompilerSyntaxKind.TSemicolon) throw new __ArgumentException(nameof(tSemicolon));
            return (FragmentSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.Fragment((__InternalSyntaxToken)kFragment.Node, (InternalSyntax.NameGreen)name.Green, (__InternalSyntaxToken)tColon.Node, __GreenNodeExtensions.ToGreenSeparatedList<InternalSyntax.LAlternativeGreen>(alternatives.Node, reversed: false), (__InternalSyntaxToken)tSemicolon.Node).CreateRed();
        }
        
        public FragmentSyntax Fragment(NameSyntax name, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<LAlternativeSyntax> alternatives)
        {
            return this.Fragment(this.Token(CompilerSyntaxKind.KFragment), name, this.Token(CompilerSyntaxKind.TColon), alternatives, this.Token(CompilerSyntaxKind.TSemicolon));
        }

        public LAlternativeSyntax LAlternative(global::MetaDslx.CodeAnalysis.SyntaxList<LElementSyntax> elements)
        {
            return (LAlternativeSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.LAlternative(__GreenNodeExtensions.ToGreenList<InternalSyntax.LElementGreen>(elements.Node)).CreateRed();
        }

        public LElementSyntax LElement(__SyntaxToken isNegated, LElementValueSyntax value, MultiplicitySyntax multiplicity)
        {
            if (isNegated.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(isNegated));
            if (isNegated.RawKind != (int)CompilerSyntaxKind.TTilde) throw new __ArgumentException(nameof(isNegated));
            if (value is null) throw new __ArgumentNullException(nameof(value));
            return (LElementSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.LElement((__InternalSyntaxToken)isNegated.Node, (InternalSyntax.LElementValueGreen)value.Green, (InternalSyntax.MultiplicityGreen)multiplicity.Green).CreateRed();
        }
        
        public LElementSyntax LElement(LElementValueSyntax value)
        {
            return this.LElement(this.Token(CompilerSyntaxKind.TTilde), value, default);
        }

        public LElementValueAlt1Syntax LElementValueAlt1(LBlockSyntax lBlock)
        {
            if (lBlock is null) throw new __ArgumentNullException(nameof(lBlock));
            return (LElementValueAlt1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.LElementValueAlt1((InternalSyntax.LBlockGreen)lBlock.Green).CreateRed();
        }

        public LElementValueAlt2Syntax LElementValueAlt2(LFixedSyntax lFixed)
        {
            if (lFixed is null) throw new __ArgumentNullException(nameof(lFixed));
            return (LElementValueAlt2Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.LElementValueAlt2((InternalSyntax.LFixedGreen)lFixed.Green).CreateRed();
        }

        public LElementValueAlt3Syntax LElementValueAlt3(LWildCardSyntax lWildCard)
        {
            if (lWildCard is null) throw new __ArgumentNullException(nameof(lWildCard));
            return (LElementValueAlt3Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.LElementValueAlt3((InternalSyntax.LWildCardGreen)lWildCard.Green).CreateRed();
        }

        public LElementValueAlt4Syntax LElementValueAlt4(LRangeSyntax lRange)
        {
            if (lRange is null) throw new __ArgumentNullException(nameof(lRange));
            return (LElementValueAlt4Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.LElementValueAlt4((InternalSyntax.LRangeGreen)lRange.Green).CreateRed();
        }

        public LElementValueAlt5Syntax LElementValueAlt5(LReferenceSyntax lReference)
        {
            if (lReference is null) throw new __ArgumentNullException(nameof(lReference));
            return (LElementValueAlt5Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.LElementValueAlt5((InternalSyntax.LReferenceGreen)lReference.Green).CreateRed();
        }

        public LReferenceSyntax LReference(IdentifierSyntax rule)
        {
            if (rule is null) throw new __ArgumentNullException(nameof(rule));
            return (LReferenceSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.LReference((InternalSyntax.IdentifierGreen)rule.Green).CreateRed();
        }

        public LFixedSyntax LFixed(__SyntaxToken text)
        {
            if (text.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(text));
            if (text.RawKind != (int)CompilerSyntaxKind.TString) throw new __ArgumentException(nameof(text));
            return (LFixedSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.LFixed((__InternalSyntaxToken)text.Node).CreateRed();
        }

        public LWildCardSyntax LWildCard(__SyntaxToken tDot)
        {
            if (tDot.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tDot));
            if (tDot.RawKind != (int)CompilerSyntaxKind.TDot) throw new __ArgumentException(nameof(tDot));
            return (LWildCardSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.LWildCard((__InternalSyntaxToken)tDot.Node).CreateRed();
        }
        
        public LWildCardSyntax LWildCard()
        {
            return this.LWildCard(this.Token(CompilerSyntaxKind.TDot));
        }

        public LRangeSyntax LRange(__SyntaxToken startChar, __SyntaxToken tDotDot, __SyntaxToken endChar)
        {
            if (startChar.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(startChar));
            if (startChar.RawKind != (int)CompilerSyntaxKind.TString) throw new __ArgumentException(nameof(startChar));
            if (tDotDot.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tDotDot));
            if (tDotDot.RawKind != (int)CompilerSyntaxKind.TDotDot) throw new __ArgumentException(nameof(tDotDot));
            if (endChar.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(endChar));
            if (endChar.RawKind != (int)CompilerSyntaxKind.TString) throw new __ArgumentException(nameof(endChar));
            return (LRangeSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.LRange((__InternalSyntaxToken)startChar.Node, (__InternalSyntaxToken)tDotDot.Node, (__InternalSyntaxToken)endChar.Node).CreateRed();
        }
        
        public LRangeSyntax LRange(__SyntaxToken startChar, __SyntaxToken endChar)
        {
            return this.LRange(this.Token(CompilerSyntaxKind.TString), this.Token(CompilerSyntaxKind.TDotDot), this.Token(CompilerSyntaxKind.TString));
        }

        public LBlockSyntax LBlock(__SyntaxToken tLParen, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<LAlternativeSyntax> alternatives, __SyntaxToken tRParen)
        {
            if (tLParen.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tLParen));
            if (tLParen.RawKind != (int)CompilerSyntaxKind.TLParen) throw new __ArgumentException(nameof(tLParen));
            if (tRParen.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tRParen));
            if (tRParen.RawKind != (int)CompilerSyntaxKind.TRParen) throw new __ArgumentException(nameof(tRParen));
            return (LBlockSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.LBlock((__InternalSyntaxToken)tLParen.Node, __GreenNodeExtensions.ToGreenSeparatedList<InternalSyntax.LAlternativeGreen>(alternatives.Node, reversed: false), (__InternalSyntaxToken)tRParen.Node).CreateRed();
        }
        
        public LBlockSyntax LBlock(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<LAlternativeSyntax> alternatives)
        {
            return this.LBlock(this.Token(CompilerSyntaxKind.TLParen), alternatives, this.Token(CompilerSyntaxKind.TRParen));
        }

        public ExpressionAlt1Syntax ExpressionAlt1(SingleExpressionSyntax singleExpression)
        {
            if (singleExpression is null) throw new __ArgumentNullException(nameof(singleExpression));
            return (ExpressionAlt1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.ExpressionAlt1((InternalSyntax.SingleExpressionGreen)singleExpression.Green).CreateRed();
        }

        public ExpressionAlt2Syntax ExpressionAlt2(ArrayExpressionSyntax arrayExpression)
        {
            if (arrayExpression is null) throw new __ArgumentNullException(nameof(arrayExpression));
            return (ExpressionAlt2Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.ExpressionAlt2((InternalSyntax.ArrayExpressionGreen)arrayExpression.Green).CreateRed();
        }

        public SingleExpressionAlt1Syntax SingleExpressionAlt1(SingleExpressionAlt1Block1Syntax value)
        {
            if (value is null) throw new __ArgumentNullException(nameof(value));
            return (SingleExpressionAlt1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.SingleExpressionAlt1(value).CreateRed();
        }

        public SingleExpressionAlt2Syntax SingleExpressionAlt2(QualifierSyntax value)
        {
            if (value is null) throw new __ArgumentNullException(nameof(value));
            return (SingleExpressionAlt2Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.SingleExpressionAlt2((InternalSyntax.QualifierGreen)value.Green).CreateRed();
        }

        public ArrayExpressionSyntax ArrayExpression(__SyntaxToken tLBrace, ArrayExpressionBlock1Syntax block, __SyntaxToken tRBrace)
        {
            if (tLBrace.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tLBrace));
            if (tLBrace.RawKind != (int)CompilerSyntaxKind.TLBrace) throw new __ArgumentException(nameof(tLBrace));
            if (tRBrace.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tRBrace));
            if (tRBrace.RawKind != (int)CompilerSyntaxKind.TRBrace) throw new __ArgumentException(nameof(tRBrace));
            return (ArrayExpressionSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.ArrayExpression((__InternalSyntaxToken)tLBrace.Node, block, (__InternalSyntaxToken)tRBrace.Node).CreateRed();
        }
        
        public ArrayExpressionSyntax ArrayExpression()
        {
            return this.ArrayExpression(this.Token(CompilerSyntaxKind.TLBrace), default, this.Token(CompilerSyntaxKind.TRBrace));
        }

        public ParserAnnotationSyntax ParserAnnotation(__SyntaxToken tLBracket, QualifierSyntax attributeClass, ParserAnnotationBlock1Syntax block, __SyntaxToken tRBracket)
        {
            if (tLBracket.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tLBracket));
            if (tLBracket.RawKind != (int)CompilerSyntaxKind.TLBracket) throw new __ArgumentException(nameof(tLBracket));
            if (attributeClass is null) throw new __ArgumentNullException(nameof(attributeClass));
            if (tRBracket.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tRBracket));
            if (tRBracket.RawKind != (int)CompilerSyntaxKind.TRBracket) throw new __ArgumentException(nameof(tRBracket));
            return (ParserAnnotationSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.ParserAnnotation((__InternalSyntaxToken)tLBracket.Node, (InternalSyntax.QualifierGreen)attributeClass.Green, block, (__InternalSyntaxToken)tRBracket.Node).CreateRed();
        }
        
        public ParserAnnotationSyntax ParserAnnotation(QualifierSyntax attributeClass)
        {
            return this.ParserAnnotation(this.Token(CompilerSyntaxKind.TLBracket), attributeClass, default, this.Token(CompilerSyntaxKind.TRBracket));
        }

        public LexerAnnotationSyntax LexerAnnotation(__SyntaxToken tLBracket, QualifierSyntax attributeClass, LexerAnnotationBlock1Syntax block, __SyntaxToken tRBracket)
        {
            if (tLBracket.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tLBracket));
            if (tLBracket.RawKind != (int)CompilerSyntaxKind.TLBracket) throw new __ArgumentException(nameof(tLBracket));
            if (attributeClass is null) throw new __ArgumentNullException(nameof(attributeClass));
            if (tRBracket.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tRBracket));
            if (tRBracket.RawKind != (int)CompilerSyntaxKind.TRBracket) throw new __ArgumentException(nameof(tRBracket));
            return (LexerAnnotationSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.LexerAnnotation((__InternalSyntaxToken)tLBracket.Node, (InternalSyntax.QualifierGreen)attributeClass.Green, block, (__InternalSyntaxToken)tRBracket.Node).CreateRed();
        }
        
        public LexerAnnotationSyntax LexerAnnotation(QualifierSyntax attributeClass)
        {
            return this.LexerAnnotation(this.Token(CompilerSyntaxKind.TLBracket), attributeClass, default, this.Token(CompilerSyntaxKind.TRBracket));
        }

        public AnnotationArgumentSyntax AnnotationArgument(AnnotationArgumentBlock1Syntax block, ExpressionSyntax value)
        {
            if (value is null) throw new __ArgumentNullException(nameof(value));
            return (AnnotationArgumentSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.AnnotationArgument(block, (InternalSyntax.ExpressionGreen)value.Green).CreateRed();
        }
        
        public AnnotationArgumentSyntax AnnotationArgument(ExpressionSyntax value)
        {
            return this.AnnotationArgument(default, value);
        }

        public AssignmentSyntax Assignment(__SyntaxToken token)
        {
            if (token.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(token));
            if (token.RawKind != (int)CompilerSyntaxKind.TEq && token.RawKind != (int)CompilerSyntaxKind.TQuestionEq && token.RawKind != (int)CompilerSyntaxKind.TExclEq && token.RawKind != (int)CompilerSyntaxKind.TPlusEq) throw new __ArgumentException(nameof(token));
            return (AssignmentSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.Assignment((__InternalSyntaxToken)token.Node).CreateRed();
        }

        public MultiplicitySyntax Multiplicity(__SyntaxToken token)
        {
            if (token.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(token));
            if (token.RawKind != (int)CompilerSyntaxKind.TQuestion && token.RawKind != (int)CompilerSyntaxKind.TAsterisk && token.RawKind != (int)CompilerSyntaxKind.TPlus && token.RawKind != (int)CompilerSyntaxKind.TQuestionQuestion && token.RawKind != (int)CompilerSyntaxKind.TAsteriskQuestion && token.RawKind != (int)CompilerSyntaxKind.TPlusQuestion) throw new __ArgumentException(nameof(token));
            return (MultiplicitySyntax)CompilerLanguage.Instance.InternalSyntaxFactory.Multiplicity((__InternalSyntaxToken)token.Node).CreateRed();
        }

        public TypeReferenceIdentifierAlt1Syntax TypeReferenceIdentifierAlt1(PrimitiveTypeSyntax primitiveType)
        {
            if (primitiveType is null) throw new __ArgumentNullException(nameof(primitiveType));
            return (TypeReferenceIdentifierAlt1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.TypeReferenceIdentifierAlt1((InternalSyntax.PrimitiveTypeGreen)primitiveType.Green).CreateRed();
        }

        public TypeReferenceIdentifierAlt2Syntax TypeReferenceIdentifierAlt2(IdentifierSyntax identifier)
        {
            if (identifier is null) throw new __ArgumentNullException(nameof(identifier));
            return (TypeReferenceIdentifierAlt2Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.TypeReferenceIdentifierAlt2((InternalSyntax.IdentifierGreen)identifier.Green).CreateRed();
        }

        public TypeReferenceAlt1Syntax TypeReferenceAlt1(PrimitiveTypeSyntax primitiveType)
        {
            if (primitiveType is null) throw new __ArgumentNullException(nameof(primitiveType));
            return (TypeReferenceAlt1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.TypeReferenceAlt1((InternalSyntax.PrimitiveTypeGreen)primitiveType.Green).CreateRed();
        }

        public TypeReferenceAlt2Syntax TypeReferenceAlt2(QualifierSyntax qualifier)
        {
            if (qualifier is null) throw new __ArgumentNullException(nameof(qualifier));
            return (TypeReferenceAlt2Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.TypeReferenceAlt2((InternalSyntax.QualifierGreen)qualifier.Green).CreateRed();
        }

        public PrimitiveTypeSyntax PrimitiveType(__SyntaxToken token)
        {
            if (token.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(token));
            if (token.RawKind != (int)CompilerSyntaxKind.KBool && token.RawKind != (int)CompilerSyntaxKind.KInt && token.RawKind != (int)CompilerSyntaxKind.KDouble && token.RawKind != (int)CompilerSyntaxKind.KString && token.RawKind != (int)CompilerSyntaxKind.KType && token.RawKind != (int)CompilerSyntaxKind.KSymbol && token.RawKind != (int)CompilerSyntaxKind.KObject && token.RawKind != (int)CompilerSyntaxKind.KVoid) throw new __ArgumentException(nameof(token));
            return (PrimitiveTypeSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.PrimitiveType((__InternalSyntaxToken)token.Node).CreateRed();
        }

        public NameSyntax Name(IdentifierSyntax identifier)
        {
            if (identifier is null) throw new __ArgumentNullException(nameof(identifier));
            return (NameSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.Name((InternalSyntax.IdentifierGreen)identifier.Green).CreateRed();
        }

        public QualifierSyntax Qualifier(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<IdentifierSyntax> identifier)
        {
            return (QualifierSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.Qualifier(__GreenNodeExtensions.ToGreenSeparatedList<InternalSyntax.IdentifierGreen>(identifier.Node, reversed: false)).CreateRed();
        }

        public IdentifierSyntax Identifier(__SyntaxToken token)
        {
            if (token.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(token));
            if (token.RawKind != (int)CompilerSyntaxKind.TIdentifier && token.RawKind != (int)CompilerSyntaxKind.TVerbatimIdentifier) throw new __ArgumentException(nameof(token));
            return (IdentifierSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.Identifier((__InternalSyntaxToken)token.Node).CreateRed();
        }

        public MainBlock1Syntax MainBlock1(LanguageDeclarationSyntax declarations)
        {
            if (declarations is null) throw new __ArgumentNullException(nameof(declarations));
            return (MainBlock1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.MainBlock1((InternalSyntax.LanguageDeclarationGreen)declarations.Green).CreateRed();
        }

        public GrammarBlock1Syntax GrammarBlock1(global::MetaDslx.CodeAnalysis.SyntaxList<GrammarRuleSyntax> grammarRules)
        {
            return (GrammarBlock1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.GrammarBlock1(__GreenNodeExtensions.ToGreenList<InternalSyntax.GrammarRuleGreen>(grammarRules.Node)).CreateRed();
        }

        public RuleBlock1Alt1Syntax RuleBlock1Alt1(TypeReferenceIdentifierSyntax returnType)
        {
            if (returnType is null) throw new __ArgumentNullException(nameof(returnType));
            return (RuleBlock1Alt1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.RuleBlock1Alt1((InternalSyntax.TypeReferenceIdentifierGreen)returnType.Green).CreateRed();
        }

        public RuleBlock1Alt2Syntax RuleBlock1Alt2(IdentifierSyntax identifier, __SyntaxToken kReturns, TypeReferenceSyntax returnType)
        {
            if (identifier is null) throw new __ArgumentNullException(nameof(identifier));
            if (kReturns.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(kReturns));
            if (kReturns.RawKind != (int)CompilerSyntaxKind.KReturns) throw new __ArgumentException(nameof(kReturns));
            if (returnType is null) throw new __ArgumentNullException(nameof(returnType));
            return (RuleBlock1Alt2Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.RuleBlock1Alt2((InternalSyntax.IdentifierGreen)identifier.Green, (__InternalSyntaxToken)kReturns.Node, (InternalSyntax.TypeReferenceGreen)returnType.Green).CreateRed();
        }
        
        public RuleBlock1Alt2Syntax RuleBlock1Alt2(IdentifierSyntax identifier, TypeReferenceSyntax returnType)
        {
            return this.RuleBlock1Alt2(identifier, this.Token(CompilerSyntaxKind.KReturns), returnType);
        }

        public RulealternativesBlockSyntax RulealternativesBlock(__SyntaxToken tBar, AlternativeSyntax alternatives)
        {
            if (tBar.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tBar));
            if (tBar.RawKind != (int)CompilerSyntaxKind.TBar) throw new __ArgumentException(nameof(tBar));
            if (alternatives is null) throw new __ArgumentNullException(nameof(alternatives));
            return (RulealternativesBlockSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.RulealternativesBlock((__InternalSyntaxToken)tBar.Node, (InternalSyntax.AlternativeGreen)alternatives.Green).CreateRed();
        }
        
        public RulealternativesBlockSyntax RulealternativesBlock(AlternativeSyntax alternatives)
        {
            return this.RulealternativesBlock(this.Token(CompilerSyntaxKind.TBar), alternatives);
        }

        public AlternativeBlock1Syntax AlternativeBlock1(global::MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> annotations1, __SyntaxToken kAlt, NameSyntax name, AlternativeBlock1Block1Syntax block, __SyntaxToken tColon)
        {
            if (kAlt.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(kAlt));
            if (kAlt.RawKind != (int)CompilerSyntaxKind.KAlt) throw new __ArgumentException(nameof(kAlt));
            if (name is null) throw new __ArgumentNullException(nameof(name));
            if (tColon.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tColon));
            if (tColon.RawKind != (int)CompilerSyntaxKind.TColon) throw new __ArgumentException(nameof(tColon));
            return (AlternativeBlock1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.AlternativeBlock1(__GreenNodeExtensions.ToGreenList<InternalSyntax.ParserAnnotationGreen>(annotations1.Node), (__InternalSyntaxToken)kAlt.Node, (InternalSyntax.NameGreen)name.Green, block, (__InternalSyntaxToken)tColon.Node).CreateRed();
        }
        
        public AlternativeBlock1Syntax AlternativeBlock1(global::MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> annotations1, NameSyntax name)
        {
            return this.AlternativeBlock1(annotations1, this.Token(CompilerSyntaxKind.KAlt), name, default, this.Token(CompilerSyntaxKind.TColon));
        }

        public AlternativeBlock1Block1Syntax AlternativeBlock1Block1(__SyntaxToken kReturns, TypeReferenceSyntax returnType)
        {
            if (kReturns.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(kReturns));
            if (kReturns.RawKind != (int)CompilerSyntaxKind.KReturns) throw new __ArgumentException(nameof(kReturns));
            if (returnType is null) throw new __ArgumentNullException(nameof(returnType));
            return (AlternativeBlock1Block1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.AlternativeBlock1Block1((__InternalSyntaxToken)kReturns.Node, (InternalSyntax.TypeReferenceGreen)returnType.Green).CreateRed();
        }
        
        public AlternativeBlock1Block1Syntax AlternativeBlock1Block1(TypeReferenceSyntax returnType)
        {
            return this.AlternativeBlock1Block1(this.Token(CompilerSyntaxKind.KReturns), returnType);
        }

        public AlternativeBlock2Syntax AlternativeBlock2(__SyntaxToken tEqGt, ExpressionSyntax returnValue)
        {
            if (tEqGt.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tEqGt));
            if (tEqGt.RawKind != (int)CompilerSyntaxKind.TEqGt) throw new __ArgumentException(nameof(tEqGt));
            if (returnValue is null) throw new __ArgumentNullException(nameof(returnValue));
            return (AlternativeBlock2Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.AlternativeBlock2((__InternalSyntaxToken)tEqGt.Node, (InternalSyntax.ExpressionGreen)returnValue.Green).CreateRed();
        }
        
        public AlternativeBlock2Syntax AlternativeBlock2(ExpressionSyntax returnValue)
        {
            return this.AlternativeBlock2(this.Token(CompilerSyntaxKind.TEqGt), returnValue);
        }

        public ElementBlock1Syntax ElementBlock1(global::MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> annotations1, NameSyntax name, AssignmentSyntax assignment)
        {
            if (name is null) throw new __ArgumentNullException(nameof(name));
            if (assignment is null) throw new __ArgumentNullException(nameof(assignment));
            return (ElementBlock1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.ElementBlock1(__GreenNodeExtensions.ToGreenList<InternalSyntax.ParserAnnotationGreen>(annotations1.Node), (InternalSyntax.NameGreen)name.Green, (InternalSyntax.AssignmentGreen)assignment.Green).CreateRed();
        }

        public BlockalternativesBlockSyntax BlockalternativesBlock(__SyntaxToken tBar, BlockAlternativeSyntax alternatives)
        {
            if (tBar.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tBar));
            if (tBar.RawKind != (int)CompilerSyntaxKind.TBar) throw new __ArgumentException(nameof(tBar));
            if (alternatives is null) throw new __ArgumentNullException(nameof(alternatives));
            return (BlockalternativesBlockSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.BlockalternativesBlock((__InternalSyntaxToken)tBar.Node, (InternalSyntax.BlockAlternativeGreen)alternatives.Green).CreateRed();
        }
        
        public BlockalternativesBlockSyntax BlockalternativesBlock(BlockAlternativeSyntax alternatives)
        {
            return this.BlockalternativesBlock(this.Token(CompilerSyntaxKind.TBar), alternatives);
        }

        public BlockAlternativeBlock1Syntax BlockAlternativeBlock1(__SyntaxToken tEqGt, ExpressionSyntax returnValue)
        {
            if (tEqGt.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tEqGt));
            if (tEqGt.RawKind != (int)CompilerSyntaxKind.TEqGt) throw new __ArgumentException(nameof(tEqGt));
            if (returnValue is null) throw new __ArgumentNullException(nameof(returnValue));
            return (BlockAlternativeBlock1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.BlockAlternativeBlock1((__InternalSyntaxToken)tEqGt.Node, (InternalSyntax.ExpressionGreen)returnValue.Green).CreateRed();
        }
        
        public BlockAlternativeBlock1Syntax BlockAlternativeBlock1(ExpressionSyntax returnValue)
        {
            return this.BlockAlternativeBlock1(this.Token(CompilerSyntaxKind.TEqGt), returnValue);
        }

        public RuleRefAlt3referencedTypesBlockSyntax RuleRefAlt3referencedTypesBlock(__SyntaxToken tComma, TypeReferenceSyntax referencedTypes)
        {
            if (tComma.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tComma));
            if (tComma.RawKind != (int)CompilerSyntaxKind.TComma) throw new __ArgumentException(nameof(tComma));
            if (referencedTypes is null) throw new __ArgumentNullException(nameof(referencedTypes));
            return (RuleRefAlt3referencedTypesBlockSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.RuleRefAlt3referencedTypesBlock((__InternalSyntaxToken)tComma.Node, (InternalSyntax.TypeReferenceGreen)referencedTypes.Green).CreateRed();
        }
        
        public RuleRefAlt3referencedTypesBlockSyntax RuleRefAlt3referencedTypesBlock(TypeReferenceSyntax referencedTypes)
        {
            return this.RuleRefAlt3referencedTypesBlock(this.Token(CompilerSyntaxKind.TComma), referencedTypes);
        }

        public RuleRefAlt3Block1Syntax RuleRefAlt3Block1(__SyntaxToken tBar, IdentifierSyntax grammarRule)
        {
            if (tBar.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tBar));
            if (tBar.RawKind != (int)CompilerSyntaxKind.TBar) throw new __ArgumentException(nameof(tBar));
            if (grammarRule is null) throw new __ArgumentNullException(nameof(grammarRule));
            return (RuleRefAlt3Block1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.RuleRefAlt3Block1((__InternalSyntaxToken)tBar.Node, (InternalSyntax.IdentifierGreen)grammarRule.Green).CreateRed();
        }
        
        public RuleRefAlt3Block1Syntax RuleRefAlt3Block1(IdentifierSyntax grammarRule)
        {
            return this.RuleRefAlt3Block1(this.Token(CompilerSyntaxKind.TBar), grammarRule);
        }

        public TokenBlock1Alt1Syntax TokenBlock1Alt1(__SyntaxToken kToken, NameSyntax name, TokenBlock1Alt1Block1Syntax block)
        {
            if (kToken.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(kToken));
            if (kToken.RawKind != (int)CompilerSyntaxKind.KToken) throw new __ArgumentException(nameof(kToken));
            if (name is null) throw new __ArgumentNullException(nameof(name));
            return (TokenBlock1Alt1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.TokenBlock1Alt1((__InternalSyntaxToken)kToken.Node, (InternalSyntax.NameGreen)name.Green, block).CreateRed();
        }
        
        public TokenBlock1Alt1Syntax TokenBlock1Alt1(NameSyntax name)
        {
            return this.TokenBlock1Alt1(this.Token(CompilerSyntaxKind.KToken), name, default);
        }

        public TokenBlock1Alt2Syntax TokenBlock1Alt2(__SyntaxToken isTrivia, NameSyntax name)
        {
            if (isTrivia.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(isTrivia));
            if (isTrivia.RawKind != (int)CompilerSyntaxKind.KHidden) throw new __ArgumentException(nameof(isTrivia));
            if (name is null) throw new __ArgumentNullException(nameof(name));
            return (TokenBlock1Alt2Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.TokenBlock1Alt2((__InternalSyntaxToken)isTrivia.Node, (InternalSyntax.NameGreen)name.Green).CreateRed();
        }
        
        public TokenBlock1Alt2Syntax TokenBlock1Alt2(NameSyntax name)
        {
            return this.TokenBlock1Alt2(this.Token(CompilerSyntaxKind.KHidden), name);
        }

        public TokenBlock1Alt1Block1Syntax TokenBlock1Alt1Block1(__SyntaxToken kReturns, TypeReferenceSyntax returnType)
        {
            if (kReturns.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(kReturns));
            if (kReturns.RawKind != (int)CompilerSyntaxKind.KReturns) throw new __ArgumentException(nameof(kReturns));
            if (returnType is null) throw new __ArgumentNullException(nameof(returnType));
            return (TokenBlock1Alt1Block1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.TokenBlock1Alt1Block1((__InternalSyntaxToken)kReturns.Node, (InternalSyntax.TypeReferenceGreen)returnType.Green).CreateRed();
        }
        
        public TokenBlock1Alt1Block1Syntax TokenBlock1Alt1Block1(TypeReferenceSyntax returnType)
        {
            return this.TokenBlock1Alt1Block1(this.Token(CompilerSyntaxKind.KReturns), returnType);
        }

        public TokenalternativesBlockSyntax TokenalternativesBlock(__SyntaxToken tBar, LAlternativeSyntax alternatives)
        {
            if (tBar.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tBar));
            if (tBar.RawKind != (int)CompilerSyntaxKind.TBar) throw new __ArgumentException(nameof(tBar));
            if (alternatives is null) throw new __ArgumentNullException(nameof(alternatives));
            return (TokenalternativesBlockSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.TokenalternativesBlock((__InternalSyntaxToken)tBar.Node, (InternalSyntax.LAlternativeGreen)alternatives.Green).CreateRed();
        }
        
        public TokenalternativesBlockSyntax TokenalternativesBlock(LAlternativeSyntax alternatives)
        {
            return this.TokenalternativesBlock(this.Token(CompilerSyntaxKind.TBar), alternatives);
        }

        public FragmentalternativesBlockSyntax FragmentalternativesBlock(__SyntaxToken tBar, LAlternativeSyntax alternatives)
        {
            if (tBar.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tBar));
            if (tBar.RawKind != (int)CompilerSyntaxKind.TBar) throw new __ArgumentException(nameof(tBar));
            if (alternatives is null) throw new __ArgumentNullException(nameof(alternatives));
            return (FragmentalternativesBlockSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.FragmentalternativesBlock((__InternalSyntaxToken)tBar.Node, (InternalSyntax.LAlternativeGreen)alternatives.Green).CreateRed();
        }
        
        public FragmentalternativesBlockSyntax FragmentalternativesBlock(LAlternativeSyntax alternatives)
        {
            return this.FragmentalternativesBlock(this.Token(CompilerSyntaxKind.TBar), alternatives);
        }

        public LBlockalternativesBlockSyntax LBlockalternativesBlock(__SyntaxToken tBar, LAlternativeSyntax alternatives)
        {
            if (tBar.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tBar));
            if (tBar.RawKind != (int)CompilerSyntaxKind.TBar) throw new __ArgumentException(nameof(tBar));
            if (alternatives is null) throw new __ArgumentNullException(nameof(alternatives));
            return (LBlockalternativesBlockSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.LBlockalternativesBlock((__InternalSyntaxToken)tBar.Node, (InternalSyntax.LAlternativeGreen)alternatives.Green).CreateRed();
        }
        
        public LBlockalternativesBlockSyntax LBlockalternativesBlock(LAlternativeSyntax alternatives)
        {
            return this.LBlockalternativesBlock(this.Token(CompilerSyntaxKind.TBar), alternatives);
        }

        public SingleExpressionAlt1Block1Alt1Syntax SingleExpressionAlt1Block1Alt1(__SyntaxToken kNull)
        {
            if (kNull.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(kNull));
            if (kNull.RawKind != (int)CompilerSyntaxKind.KNull) throw new __ArgumentException(nameof(kNull));
            return (SingleExpressionAlt1Block1Alt1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.SingleExpressionAlt1Block1Alt1((__InternalSyntaxToken)kNull.Node).CreateRed();
        }
        
        public SingleExpressionAlt1Block1Alt1Syntax SingleExpressionAlt1Block1Alt1()
        {
            return this.SingleExpressionAlt1Block1Alt1(this.Token(CompilerSyntaxKind.KNull));
        }

        public SingleExpressionAlt1Block1Alt2Syntax SingleExpressionAlt1Block1Alt2(__SyntaxToken kTrue)
        {
            if (kTrue.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(kTrue));
            if (kTrue.RawKind != (int)CompilerSyntaxKind.KTrue) throw new __ArgumentException(nameof(kTrue));
            return (SingleExpressionAlt1Block1Alt2Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.SingleExpressionAlt1Block1Alt2((__InternalSyntaxToken)kTrue.Node).CreateRed();
        }
        
        public SingleExpressionAlt1Block1Alt2Syntax SingleExpressionAlt1Block1Alt2()
        {
            return this.SingleExpressionAlt1Block1Alt2(this.Token(CompilerSyntaxKind.KTrue));
        }

        public SingleExpressionAlt1Block1Alt3Syntax SingleExpressionAlt1Block1Alt3(__SyntaxToken kFalse)
        {
            if (kFalse.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(kFalse));
            if (kFalse.RawKind != (int)CompilerSyntaxKind.KFalse) throw new __ArgumentException(nameof(kFalse));
            return (SingleExpressionAlt1Block1Alt3Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.SingleExpressionAlt1Block1Alt3((__InternalSyntaxToken)kFalse.Node).CreateRed();
        }
        
        public SingleExpressionAlt1Block1Alt3Syntax SingleExpressionAlt1Block1Alt3()
        {
            return this.SingleExpressionAlt1Block1Alt3(this.Token(CompilerSyntaxKind.KFalse));
        }

        public SingleExpressionAlt1Block1Alt4Syntax SingleExpressionAlt1Block1Alt4(__SyntaxToken tString)
        {
            if (tString.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tString));
            if (tString.RawKind != (int)CompilerSyntaxKind.TString) throw new __ArgumentException(nameof(tString));
            return (SingleExpressionAlt1Block1Alt4Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.SingleExpressionAlt1Block1Alt4((__InternalSyntaxToken)tString.Node).CreateRed();
        }

        public SingleExpressionAlt1Block1Alt5Syntax SingleExpressionAlt1Block1Alt5(__SyntaxToken tInteger)
        {
            if (tInteger.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tInteger));
            if (tInteger.RawKind != (int)CompilerSyntaxKind.TInteger) throw new __ArgumentException(nameof(tInteger));
            return (SingleExpressionAlt1Block1Alt5Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.SingleExpressionAlt1Block1Alt5((__InternalSyntaxToken)tInteger.Node).CreateRed();
        }

        public SingleExpressionAlt1Block1Alt6Syntax SingleExpressionAlt1Block1Alt6(__SyntaxToken tDecimal)
        {
            if (tDecimal.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tDecimal));
            if (tDecimal.RawKind != (int)CompilerSyntaxKind.TDecimal) throw new __ArgumentException(nameof(tDecimal));
            return (SingleExpressionAlt1Block1Alt6Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.SingleExpressionAlt1Block1Alt6((__InternalSyntaxToken)tDecimal.Node).CreateRed();
        }

        public SingleExpressionAlt1Block1Alt7Syntax SingleExpressionAlt1Block1Alt7(PrimitiveTypeSyntax primitiveType)
        {
            if (primitiveType is null) throw new __ArgumentNullException(nameof(primitiveType));
            return (SingleExpressionAlt1Block1Alt7Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.SingleExpressionAlt1Block1Alt7((InternalSyntax.PrimitiveTypeGreen)primitiveType.Green).CreateRed();
        }

        public ArrayExpressionBlock1Syntax ArrayExpressionBlock1(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<SingleExpressionSyntax> items)
        {
            return (ArrayExpressionBlock1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.ArrayExpressionBlock1(__GreenNodeExtensions.ToGreenSeparatedList<InternalSyntax.SingleExpressionGreen>(items.Node, reversed: false)).CreateRed();
        }

        public ArrayExpressionBlock1itemsBlockSyntax ArrayExpressionBlock1itemsBlock(__SyntaxToken tComma, SingleExpressionSyntax items)
        {
            if (tComma.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tComma));
            if (tComma.RawKind != (int)CompilerSyntaxKind.TComma) throw new __ArgumentException(nameof(tComma));
            if (items is null) throw new __ArgumentNullException(nameof(items));
            return (ArrayExpressionBlock1itemsBlockSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.ArrayExpressionBlock1itemsBlock((__InternalSyntaxToken)tComma.Node, (InternalSyntax.SingleExpressionGreen)items.Green).CreateRed();
        }
        
        public ArrayExpressionBlock1itemsBlockSyntax ArrayExpressionBlock1itemsBlock(SingleExpressionSyntax items)
        {
            return this.ArrayExpressionBlock1itemsBlock(this.Token(CompilerSyntaxKind.TComma), items);
        }

        public ParserAnnotationBlock1Syntax ParserAnnotationBlock1(__SyntaxToken tLParen, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<AnnotationArgumentSyntax> arguments, __SyntaxToken tRParen)
        {
            if (tLParen.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tLParen));
            if (tLParen.RawKind != (int)CompilerSyntaxKind.TLParen) throw new __ArgumentException(nameof(tLParen));
            if (tRParen.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tRParen));
            if (tRParen.RawKind != (int)CompilerSyntaxKind.TRParen) throw new __ArgumentException(nameof(tRParen));
            return (ParserAnnotationBlock1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.ParserAnnotationBlock1((__InternalSyntaxToken)tLParen.Node, __GreenNodeExtensions.ToGreenSeparatedList<InternalSyntax.AnnotationArgumentGreen>(arguments.Node, reversed: false), (__InternalSyntaxToken)tRParen.Node).CreateRed();
        }
        
        public ParserAnnotationBlock1Syntax ParserAnnotationBlock1(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<AnnotationArgumentSyntax> arguments)
        {
            return this.ParserAnnotationBlock1(this.Token(CompilerSyntaxKind.TLParen), arguments, this.Token(CompilerSyntaxKind.TRParen));
        }

        public ParserAnnotationBlock1argumentsBlockSyntax ParserAnnotationBlock1argumentsBlock(__SyntaxToken tComma, AnnotationArgumentSyntax arguments)
        {
            if (tComma.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tComma));
            if (tComma.RawKind != (int)CompilerSyntaxKind.TComma) throw new __ArgumentException(nameof(tComma));
            if (arguments is null) throw new __ArgumentNullException(nameof(arguments));
            return (ParserAnnotationBlock1argumentsBlockSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.ParserAnnotationBlock1argumentsBlock((__InternalSyntaxToken)tComma.Node, (InternalSyntax.AnnotationArgumentGreen)arguments.Green).CreateRed();
        }
        
        public ParserAnnotationBlock1argumentsBlockSyntax ParserAnnotationBlock1argumentsBlock(AnnotationArgumentSyntax arguments)
        {
            return this.ParserAnnotationBlock1argumentsBlock(this.Token(CompilerSyntaxKind.TComma), arguments);
        }

        public LexerAnnotationBlock1Syntax LexerAnnotationBlock1(__SyntaxToken tLParen, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<AnnotationArgumentSyntax> arguments, __SyntaxToken tRParen)
        {
            if (tLParen.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tLParen));
            if (tLParen.RawKind != (int)CompilerSyntaxKind.TLParen) throw new __ArgumentException(nameof(tLParen));
            if (tRParen.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tRParen));
            if (tRParen.RawKind != (int)CompilerSyntaxKind.TRParen) throw new __ArgumentException(nameof(tRParen));
            return (LexerAnnotationBlock1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.LexerAnnotationBlock1((__InternalSyntaxToken)tLParen.Node, __GreenNodeExtensions.ToGreenSeparatedList<InternalSyntax.AnnotationArgumentGreen>(arguments.Node, reversed: false), (__InternalSyntaxToken)tRParen.Node).CreateRed();
        }
        
        public LexerAnnotationBlock1Syntax LexerAnnotationBlock1(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<AnnotationArgumentSyntax> arguments)
        {
            return this.LexerAnnotationBlock1(this.Token(CompilerSyntaxKind.TLParen), arguments, this.Token(CompilerSyntaxKind.TRParen));
        }

        public LexerAnnotationBlock1argumentsBlockSyntax LexerAnnotationBlock1argumentsBlock(__SyntaxToken tComma, AnnotationArgumentSyntax arguments)
        {
            if (tComma.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tComma));
            if (tComma.RawKind != (int)CompilerSyntaxKind.TComma) throw new __ArgumentException(nameof(tComma));
            if (arguments is null) throw new __ArgumentNullException(nameof(arguments));
            return (LexerAnnotationBlock1argumentsBlockSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.LexerAnnotationBlock1argumentsBlock((__InternalSyntaxToken)tComma.Node, (InternalSyntax.AnnotationArgumentGreen)arguments.Green).CreateRed();
        }
        
        public LexerAnnotationBlock1argumentsBlockSyntax LexerAnnotationBlock1argumentsBlock(AnnotationArgumentSyntax arguments)
        {
            return this.LexerAnnotationBlock1argumentsBlock(this.Token(CompilerSyntaxKind.TComma), arguments);
        }

        public AnnotationArgumentBlock1Syntax AnnotationArgumentBlock1(IdentifierSyntax namedParameter, __SyntaxToken tColon)
        {
            if (namedParameter is null) throw new __ArgumentNullException(nameof(namedParameter));
            if (tColon.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tColon));
            if (tColon.RawKind != (int)CompilerSyntaxKind.TColon) throw new __ArgumentException(nameof(tColon));
            return (AnnotationArgumentBlock1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.AnnotationArgumentBlock1((InternalSyntax.IdentifierGreen)namedParameter.Green, (__InternalSyntaxToken)tColon.Node).CreateRed();
        }
        
        public AnnotationArgumentBlock1Syntax AnnotationArgumentBlock1(IdentifierSyntax namedParameter)
        {
            return this.AnnotationArgumentBlock1(namedParameter, this.Token(CompilerSyntaxKind.TColon));
        }

        public QualifierIdentifierBlockSyntax QualifierIdentifierBlock(__SyntaxToken tDot, IdentifierSyntax identifier)
        {
            if (tDot.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tDot));
            if (tDot.RawKind != (int)CompilerSyntaxKind.TDot) throw new __ArgumentException(nameof(tDot));
            if (identifier is null) throw new __ArgumentNullException(nameof(identifier));
            return (QualifierIdentifierBlockSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.QualifierIdentifierBlock((__InternalSyntaxToken)tDot.Node, (InternalSyntax.IdentifierGreen)identifier.Green).CreateRed();
        }
        
        public QualifierIdentifierBlockSyntax QualifierIdentifierBlock(IdentifierSyntax identifier)
        {
            return this.QualifierIdentifierBlock(this.Token(CompilerSyntaxKind.TDot), identifier);
        }

        internal static global::System.Collections.Generic.IEnumerable<__Type> GetNodeTypes()
        {
            return new __Type[] {
                typeof(MainSyntax),
                typeof(UsingSyntax),
                typeof(LanguageDeclarationSyntax),
                typeof(GrammarSyntax),
                typeof(GrammarRuleAlt1Syntax),
                typeof(GrammarRuleAlt2Syntax),
                typeof(RuleSyntax),
                typeof(AlternativeSyntax),
                typeof(ElementSyntax),
                typeof(ElementValueAlt1Syntax),
                typeof(ElementValueAlt2Syntax),
                typeof(ElementValueAlt3Syntax),
                typeof(ElementValueAlt4Syntax),
                typeof(BlockSyntax),
                typeof(BlockAlternativeSyntax),
                typeof(RuleRefAlt1Syntax),
                typeof(RuleRefAlt2Syntax),
                typeof(RuleRefAlt3Syntax),
                typeof(Eof1Syntax),
                typeof(FixedSyntax),
                typeof(LexerRuleAlt1Syntax),
                typeof(LexerRuleAlt2Syntax),
                typeof(TokenSyntax),
                typeof(FragmentSyntax),
                typeof(LAlternativeSyntax),
                typeof(LElementSyntax),
                typeof(LElementValueAlt1Syntax),
                typeof(LElementValueAlt2Syntax),
                typeof(LElementValueAlt3Syntax),
                typeof(LElementValueAlt4Syntax),
                typeof(LElementValueAlt5Syntax),
                typeof(LReferenceSyntax),
                typeof(LFixedSyntax),
                typeof(LWildCardSyntax),
                typeof(LRangeSyntax),
                typeof(LBlockSyntax),
                typeof(ExpressionAlt1Syntax),
                typeof(ExpressionAlt2Syntax),
                typeof(SingleExpressionAlt1Syntax),
                typeof(SingleExpressionAlt2Syntax),
                typeof(ArrayExpressionSyntax),
                typeof(ParserAnnotationSyntax),
                typeof(LexerAnnotationSyntax),
                typeof(AnnotationArgumentSyntax),
                typeof(AssignmentSyntax),
                typeof(MultiplicitySyntax),
                typeof(TypeReferenceIdentifierAlt1Syntax),
                typeof(TypeReferenceIdentifierAlt2Syntax),
                typeof(TypeReferenceAlt1Syntax),
                typeof(TypeReferenceAlt2Syntax),
                typeof(PrimitiveTypeSyntax),
                typeof(NameSyntax),
                typeof(QualifierSyntax),
                typeof(IdentifierSyntax),
                typeof(MainBlock1Syntax),
                typeof(GrammarBlock1Syntax),
                typeof(RuleBlock1Alt1Syntax),
                typeof(RuleBlock1Alt2Syntax),
                typeof(RulealternativesBlockSyntax),
                typeof(AlternativeBlock1Syntax),
                typeof(AlternativeBlock1Block1Syntax),
                typeof(AlternativeBlock2Syntax),
                typeof(ElementBlock1Syntax),
                typeof(BlockalternativesBlockSyntax),
                typeof(BlockAlternativeBlock1Syntax),
                typeof(RuleRefAlt3referencedTypesBlockSyntax),
                typeof(RuleRefAlt3Block1Syntax),
                typeof(TokenBlock1Alt1Syntax),
                typeof(TokenBlock1Alt2Syntax),
                typeof(TokenBlock1Alt1Block1Syntax),
                typeof(TokenalternativesBlockSyntax),
                typeof(FragmentalternativesBlockSyntax),
                typeof(LBlockalternativesBlockSyntax),
                typeof(SingleExpressionAlt1Block1Alt1Syntax),
                typeof(SingleExpressionAlt1Block1Alt2Syntax),
                typeof(SingleExpressionAlt1Block1Alt3Syntax),
                typeof(SingleExpressionAlt1Block1Alt4Syntax),
                typeof(SingleExpressionAlt1Block1Alt5Syntax),
                typeof(SingleExpressionAlt1Block1Alt6Syntax),
                typeof(SingleExpressionAlt1Block1Alt7Syntax),
                typeof(ArrayExpressionBlock1Syntax),
                typeof(ArrayExpressionBlock1itemsBlockSyntax),
                typeof(ParserAnnotationBlock1Syntax),
                typeof(ParserAnnotationBlock1argumentsBlockSyntax),
                typeof(LexerAnnotationBlock1Syntax),
                typeof(LexerAnnotationBlock1argumentsBlockSyntax),
                typeof(AnnotationArgumentBlock1Syntax),
                typeof(QualifierIdentifierBlockSyntax),
            };
        }

    }
}    
