using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Syntax;
using MetaDslx.CodeAnalysis.Syntax.InternalSyntax;
using MetaDslx.CodeAnalysis.Text;
using MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax;

#nullable enable

namespace MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax
{

	public class CompilerSyntaxFactory : SyntaxFactory
	{
		public CompilerSyntaxFactory(InternalSyntaxFactory internalSyntaxFactory) 
			: base(internalSyntaxFactory)
		{
		}
	    
        public override Language Language => CompilerLanguage.Instance;

	    public override ParseOptions DefaultParseOptions => CompilerParseOptions.Default;

		/// <summary>
		/// Create a new syntax tree from a syntax node.
		/// </summary>
		public CompilerSyntaxTree SyntaxTree(SyntaxNode root, CompilerParseOptions? options = null, string? path = "", Encoding? encoding = null)
		{
			return CompilerSyntaxTree.Create((CompilerSyntaxNode)root, IncrementalParseData.Empty, options, path, null, encoding);
		}

		/// <summary>
		/// Produces a syntax tree by parsing the source text.
		/// </summary>
		public CompilerSyntaxTree ParseSyntaxTree(
			string text,
			CompilerParseOptions options = null,
			string path = "",
			Encoding encoding = null,
			CancellationToken cancellationToken = default(CancellationToken))
		{
			return (CompilerSyntaxTree)this.ParseSyntaxTreeCore(SourceText.From(text, encoding), options, path, cancellationToken);
		}

		/// <summary>
		/// Produces a syntax tree by parsing the source text.
		/// </summary>
		public CompilerSyntaxTree ParseSyntaxTree(
			SourceText text,
			CompilerParseOptions? options = null,
			string path = "",
			CancellationToken cancellationToken = default(CancellationToken))
		{
			return (CompilerSyntaxTree)this.ParseSyntaxTreeCore(text, options, path, cancellationToken);
		}

		protected override SyntaxTree ParseSyntaxTreeCore(
			SourceText text,
			ParseOptions? options = null,
			string path = "",
			CancellationToken cancellationToken = default(CancellationToken))
		{
			return CompilerSyntaxTree.ParseText(text, (CompilerParseOptions?)options, path, cancellationToken);
		}
	
		public override SyntaxTree MakeSyntaxTree(SyntaxNode root, ParseOptions? options = null, string path = "", Encoding? encoding = null)
		{
			return CompilerSyntaxTree.Create((CompilerSyntaxNode)root, IncrementalParseData.Empty, (CompilerParseOptions)options, path, null, encoding);
		}

        /// <summary>
        /// Creates a token corresponding to a syntax kind. This method can be used for token syntax kinds whose text
        /// can be inferred by the kind alone.
        /// </summary>
        /// <param name="kind">A syntax kind value for a token. These have the suffix Token or Keyword.</param>
        /// <returns></returns>
        public virtual SyntaxToken Token(CompilerSyntaxKind kind)
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
        public virtual SyntaxToken Token(SyntaxTriviaList leading, CompilerSyntaxKind kind, SyntaxTriviaList trailing)
        {
            return this.Token(leading, (int)kind, trailing);
        }

        /// <summary>
        /// Creates a token corresponding to syntax kind. This method gives control over token Text and ValueText.
        /// 
        /// For example, consider the text '&lt;see cref="operator &amp;#43;"/&gt;'.  To create a token for the value of
        /// the operator symbol (&amp;#43;), one would call 
        /// Token(default(SyntaxTriviaList), int.PlusToken, "&amp;#43;", "+", default(SyntaxTriviaList)).
        /// </summary>
        /// <param name="leading">A list of trivia immediately preceding the token.</param>
        /// <param name="kind">A syntax kind value for a token. These have the suffix Token or Keyword.</param>
        /// <param name="text">The text from which this token was created (e.g. lexed).</param>
        /// <param name="valueText">How C# should interpret the text of this token.</param>
        /// <param name="trailing">A list of trivia immediately following the token.</param>
        public virtual SyntaxToken Token(SyntaxTriviaList leading, CompilerSyntaxKind kind, string text, string valueText, SyntaxTriviaList trailing)
        {
            return this.Token(leading, (int)kind, text, valueText, trailing);
        }

        /// <summary>
        /// Creates a missing token corresponding to syntax kind. A missing token is produced by the parser when an
        /// expected token is not found. A missing token has no text and normally has associated diagnostics.
        /// </summary>
        /// <param name="kind">A syntax kind value for a token. These have the suffix Token or Keyword.</param>
        public virtual SyntaxToken MissingToken(CompilerSyntaxKind kind)
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
        public virtual SyntaxToken MissingToken(SyntaxTriviaList leading, CompilerSyntaxKind kind, SyntaxTriviaList trailing)
        {
            return this.MissingToken(leading, (int)kind, trailing);
        }


        public SyntaxToken TInteger(string text)
        {
            return new SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.TInteger(text));
        }

        public SyntaxToken TInteger(string text, object value)
        {
            return new SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.TInteger(text, value));
        }

        public SyntaxToken TDecimal(string text)
        {
            return new SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.TDecimal(text));
        }

        public SyntaxToken TDecimal(string text, object value)
        {
            return new SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.TDecimal(text, value));
        }

        public SyntaxToken TPrimitiveType(string text)
        {
            return new SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.TPrimitiveType(text));
        }

        public SyntaxToken TPrimitiveType(string text, object value)
        {
            return new SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.TPrimitiveType(text, value));
        }

        public SyntaxToken TIdentifier(string text)
        {
            return new SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.TIdentifier(text));
        }

        public SyntaxToken TIdentifier(string text, object value)
        {
            return new SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.TIdentifier(text, value));
        }

        public SyntaxToken TVerbatimIdentifier(string text)
        {
            return new SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.TVerbatimIdentifier(text));
        }

        public SyntaxToken TVerbatimIdentifier(string text, object value)
        {
            return new SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.TVerbatimIdentifier(text, value));
        }

        public SyntaxToken TString(string text)
        {
            return new SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.TString(text));
        }

        public SyntaxToken TString(string text, object value)
        {
            return new SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.TString(text, value));
        }

        public SyntaxToken DoubleQuoteTextCharacter(string text)
        {
            return new SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.DoubleQuoteTextCharacter(text));
        }

        public SyntaxToken DoubleQuoteTextCharacter(string text, object value)
        {
            return new SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.DoubleQuoteTextCharacter(text, value));
        }

        public SyntaxToken DoubleQuoteTextSimple(string text)
        {
            return new SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.DoubleQuoteTextSimple(text));
        }

        public SyntaxToken DoubleQuoteTextSimple(string text, object value)
        {
            return new SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.DoubleQuoteTextSimple(text, value));
        }

        public SyntaxToken SingleQuoteTextCharacter(string text)
        {
            return new SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.SingleQuoteTextCharacter(text));
        }

        public SyntaxToken SingleQuoteTextCharacter(string text, object value)
        {
            return new SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.SingleQuoteTextCharacter(text, value));
        }

        public SyntaxToken SingleQuoteTextSimple(string text)
        {
            return new SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.SingleQuoteTextSimple(text));
        }

        public SyntaxToken SingleQuoteTextSimple(string text, object value)
        {
            return new SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.SingleQuoteTextSimple(text, value));
        }

        public SyntaxToken CharacterEscapeSimple(string text)
        {
            return new SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.CharacterEscapeSimple(text));
        }

        public SyntaxToken CharacterEscapeSimple(string text, object value)
        {
            return new SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.CharacterEscapeSimple(text, value));
        }

        public SyntaxToken CharacterEscapeSimpleCharacter(string text)
        {
            return new SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.CharacterEscapeSimpleCharacter(text));
        }

        public SyntaxToken CharacterEscapeSimpleCharacter(string text, object value)
        {
            return new SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.CharacterEscapeSimpleCharacter(text, value));
        }

        public SyntaxToken CharacterEscapeUnicode(string text)
        {
            return new SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.CharacterEscapeUnicode(text));
        }

        public SyntaxToken CharacterEscapeUnicode(string text, object value)
        {
            return new SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.CharacterEscapeUnicode(text, value));
        }

        public SyntaxToken HexDigit(string text)
        {
            return new SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.HexDigit(text));
        }

        public SyntaxToken HexDigit(string text, object value)
        {
            return new SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.HexDigit(text, value));
        }

        public SyntaxToken TWhitespace(string text)
        {
            return new SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.TWhitespace(text));
        }

        public SyntaxToken TWhitespace(string text, object value)
        {
            return new SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.TWhitespace(text, value));
        }

        public SyntaxToken TLineEnd(string text)
        {
            return new SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.TLineEnd(text));
        }

        public SyntaxToken TLineEnd(string text, object value)
        {
            return new SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.TLineEnd(text, value));
        }

        public SyntaxToken TSingleLineComment(string text)
        {
            return new SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.TSingleLineComment(text));
        }

        public SyntaxToken TSingleLineComment(string text, object value)
        {
            return new SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.TSingleLineComment(text, value));
        }

        public SyntaxToken TMultiLineComment(string text)
        {
            return new SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.TMultiLineComment(text));
        }

        public SyntaxToken TMultiLineComment(string text, object value)
        {
            return new SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.TMultiLineComment(text, value));
        }

        public SyntaxToken TInvalidToken(string text)
        {
            return new SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.TInvalidToken(text));
        }

        public SyntaxToken TInvalidToken(string text, object value)
        {
            return new SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.TInvalidToken(text, value));
        }

        public MainSyntax Main(SyntaxToken kNamespace, QualifierSyntax name, SyntaxToken tSemicolon, MetaDslx.CodeAnalysis.SyntaxList<UsingSyntax> @using, DeclarationsSyntax declarations, SyntaxToken eof)
        {
        	if (kNamespace.RawKind != (int)CompilerSyntaxKind.KNamespace) throw new ArgumentException(nameof(kNamespace));
        	if (name is null) throw new ArgumentNullException(nameof(name));
        	if (tSemicolon.RawKind != (int)CompilerSyntaxKind.TSemicolon) throw new ArgumentException(nameof(tSemicolon));
        	if (declarations is null) throw new ArgumentNullException(nameof(declarations));
        	if (eof.RawKind != (int)CompilerSyntaxKind.Eof) throw new ArgumentException(nameof(eof));
            return (MainSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.Main((InternalSyntaxToken)kNamespace.Node, (QualifierGreen)name.Green, (InternalSyntaxToken)tSemicolon.Node, @using.Node.ToGreenList<UsingGreen>(), (DeclarationsGreen)declarations.Green, (InternalSyntaxToken)eof.Node).CreateRed();
        }
        
        public MainSyntax Main(QualifierSyntax name, MetaDslx.CodeAnalysis.SyntaxList<UsingSyntax> @using, DeclarationsSyntax declarations)
        {
        	return this.Main(this.Token(CompilerSyntaxKind.KNamespace), name, this.Token(CompilerSyntaxKind.TSemicolon), @using, declarations, this.Token(CompilerSyntaxKind.Eof));
        }

        public UsingSyntax Using(SyntaxToken kUsing, QualifierSyntax namespaces, SyntaxToken tSemicolon)
        {
        	if (kUsing.RawKind != (int)CompilerSyntaxKind.KUsing) throw new ArgumentException(nameof(kUsing));
        	if (namespaces is null) throw new ArgumentNullException(nameof(namespaces));
        	if (tSemicolon.RawKind != (int)CompilerSyntaxKind.TSemicolon) throw new ArgumentException(nameof(tSemicolon));
            return (UsingSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.Using((InternalSyntaxToken)kUsing.Node, (QualifierGreen)namespaces.Green, (InternalSyntaxToken)tSemicolon.Node).CreateRed();
        }
        
        public UsingSyntax Using(QualifierSyntax namespaces)
        {
        	return this.Using(this.Token(CompilerSyntaxKind.KUsing), namespaces, this.Token(CompilerSyntaxKind.TSemicolon));
        }

        public DeclarationsSyntax Declarations(LanguageDeclarationSyntax declarations, MetaDslx.CodeAnalysis.SyntaxList<RuleSyntax> declarations1)
        {
        	if (declarations is null) throw new ArgumentNullException(nameof(declarations));
            return (DeclarationsSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.Declarations((LanguageDeclarationGreen)declarations.Green, declarations1.Node.ToGreenList<RuleGreen>()).CreateRed();
        }

        public LanguageDeclarationSyntax LanguageDeclaration(SyntaxToken kLanguage, NameSyntax name, SyntaxToken tSemicolon, GrammarSyntax grammar)
        {
        	if (kLanguage.RawKind != (int)CompilerSyntaxKind.KLanguage) throw new ArgumentException(nameof(kLanguage));
        	if (name is null) throw new ArgumentNullException(nameof(name));
        	if (tSemicolon.RawKind != (int)CompilerSyntaxKind.TSemicolon) throw new ArgumentException(nameof(tSemicolon));
        	if (grammar is null) throw new ArgumentNullException(nameof(grammar));
            return (LanguageDeclarationSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.LanguageDeclaration((InternalSyntaxToken)kLanguage.Node, (NameGreen)name.Green, (InternalSyntaxToken)tSemicolon.Node, (GrammarGreen)grammar.Green).CreateRed();
        }
        
        public LanguageDeclarationSyntax LanguageDeclaration(NameSyntax name, GrammarSyntax grammar)
        {
        	return this.LanguageDeclaration(this.Token(CompilerSyntaxKind.KLanguage), name, this.Token(CompilerSyntaxKind.TSemicolon), grammar);
        }

        public GrammarSyntax Grammar(GrammarBlock1Syntax grammarBlock1)
        {
        	if (grammarBlock1 is null) throw new ArgumentNullException(nameof(grammarBlock1));
            return (GrammarSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.Grammar((GrammarBlock1Green)grammarBlock1.Green).CreateRed();
        }

        public ParserRuleSyntax ParserRule(MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> annotations1, ParserRuleBlock1Syntax parserRuleBlock1, SyntaxToken tColon, MetaDslx.CodeAnalysis.SeparatedSyntaxList<PAlternativeSyntax> pAlternativeList, SyntaxToken tSemicolon)
        {
        	if (parserRuleBlock1 is null) throw new ArgumentNullException(nameof(parserRuleBlock1));
        	if (tColon.RawKind != (int)CompilerSyntaxKind.TColon) throw new ArgumentException(nameof(tColon));
        	if (tSemicolon.RawKind != (int)CompilerSyntaxKind.TSemicolon) throw new ArgumentException(nameof(tSemicolon));
            return (ParserRuleSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.ParserRule(annotations1.Node.ToGreenList<ParserAnnotationGreen>(), (ParserRuleBlock1Green)parserRuleBlock1.Green, (InternalSyntaxToken)tColon.Node, pAlternativeList.Node.ToGreenSeparatedList<PAlternativeGreen>(reversed: false), (InternalSyntaxToken)tSemicolon.Node).CreateRed();
        }
        
        public ParserRuleSyntax ParserRule(MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> annotations1, ParserRuleBlock1Syntax parserRuleBlock1, MetaDslx.CodeAnalysis.SeparatedSyntaxList<PAlternativeSyntax> pAlternativeList)
        {
        	return this.ParserRule(annotations1, parserRuleBlock1, this.Token(CompilerSyntaxKind.TColon), pAlternativeList, this.Token(CompilerSyntaxKind.TSemicolon));
        }

        public PBlockSyntax PBlock(MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> annotations1, SyntaxToken kBlock, NameSyntax name, PBlockBlock1Syntax pBlockBlock1, SyntaxToken tColon, MetaDslx.CodeAnalysis.SeparatedSyntaxList<PAlternativeSyntax> pAlternativeList, SyntaxToken tSemicolon)
        {
        	if (kBlock.RawKind != (int)CompilerSyntaxKind.KBlock) throw new ArgumentException(nameof(kBlock));
        	if (name is null) throw new ArgumentNullException(nameof(name));
        	if (tColon.RawKind != (int)CompilerSyntaxKind.TColon) throw new ArgumentException(nameof(tColon));
        	if (tSemicolon.RawKind != (int)CompilerSyntaxKind.TSemicolon) throw new ArgumentException(nameof(tSemicolon));
            return (PBlockSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.PBlock(annotations1.Node.ToGreenList<ParserAnnotationGreen>(), (InternalSyntaxToken)kBlock.Node, (NameGreen)name.Green, (PBlockBlock1Green?)pBlockBlock1?.Green, (InternalSyntaxToken)tColon.Node, pAlternativeList.Node.ToGreenSeparatedList<PAlternativeGreen>(reversed: false), (InternalSyntaxToken)tSemicolon.Node).CreateRed();
        }
        
        public PBlockSyntax PBlock(MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> annotations1, NameSyntax name, MetaDslx.CodeAnalysis.SeparatedSyntaxList<PAlternativeSyntax> pAlternativeList)
        {
        	return this.PBlock(annotations1, this.Token(CompilerSyntaxKind.KBlock), name, default, this.Token(CompilerSyntaxKind.TColon), pAlternativeList, this.Token(CompilerSyntaxKind.TSemicolon));
        }

        public LexerRuleSyntax LexerRule(MetaDslx.CodeAnalysis.SyntaxList<LexerAnnotationSyntax> annotations1, LexerRuleBlock1Syntax lexerRuleBlock1, SyntaxToken tColon, MetaDslx.CodeAnalysis.SeparatedSyntaxList<LAlternativeSyntax> lAlternativeList, SyntaxToken tSemicolon)
        {
        	if (lexerRuleBlock1 is null) throw new ArgumentNullException(nameof(lexerRuleBlock1));
        	if (tColon.RawKind != (int)CompilerSyntaxKind.TColon) throw new ArgumentException(nameof(tColon));
        	if (tSemicolon.RawKind != (int)CompilerSyntaxKind.TSemicolon) throw new ArgumentException(nameof(tSemicolon));
            return (LexerRuleSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.LexerRule(annotations1.Node.ToGreenList<LexerAnnotationGreen>(), (LexerRuleBlock1Green)lexerRuleBlock1.Green, (InternalSyntaxToken)tColon.Node, lAlternativeList.Node.ToGreenSeparatedList<LAlternativeGreen>(reversed: false), (InternalSyntaxToken)tSemicolon.Node).CreateRed();
        }
        
        public LexerRuleSyntax LexerRule(MetaDslx.CodeAnalysis.SyntaxList<LexerAnnotationSyntax> annotations1, LexerRuleBlock1Syntax lexerRuleBlock1, MetaDslx.CodeAnalysis.SeparatedSyntaxList<LAlternativeSyntax> lAlternativeList)
        {
        	return this.LexerRule(annotations1, lexerRuleBlock1, this.Token(CompilerSyntaxKind.TColon), lAlternativeList, this.Token(CompilerSyntaxKind.TSemicolon));
        }

        public PAlternativeSyntax PAlternative(PAlternativeBlock1Syntax pAlternativeBlock1, MetaDslx.CodeAnalysis.SyntaxList<PElementSyntax> elements, PAlternativeBlock2Syntax pAlternativeBlock2)
        {
            return (PAlternativeSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.PAlternative((PAlternativeBlock1Green?)pAlternativeBlock1?.Green, elements.Node.ToGreenList<PElementGreen>(), (PAlternativeBlock2Green?)pAlternativeBlock2?.Green).CreateRed();
        }
        
        public PAlternativeSyntax PAlternative(MetaDslx.CodeAnalysis.SyntaxList<PElementSyntax> elements)
        {
        	return this.PAlternative(default, elements, default);
        }

        public PElementSyntax PElement(PElementBlock1Syntax pElementBlock1, MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> valueAnnotations, PElementValueSyntax value, SyntaxToken multiplicity)
        {
        	if (value is null) throw new ArgumentNullException(nameof(value));
        	if (multiplicity.RawKind != (int)CompilerSyntaxKind.TQuestion && multiplicity.RawKind != (int)CompilerSyntaxKind.TAsterisk && multiplicity.RawKind != (int)CompilerSyntaxKind.TPlus && multiplicity.RawKind != (int)CompilerSyntaxKind.TQuestionQuestion && multiplicity.RawKind != (int)CompilerSyntaxKind.TAsteriskQuestion && multiplicity.RawKind != (int)CompilerSyntaxKind.TPlusQuestion) throw new ArgumentException(nameof(multiplicity));
            return (PElementSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.PElement((PElementBlock1Green?)pElementBlock1?.Green, valueAnnotations.Node.ToGreenList<ParserAnnotationGreen>(), (PElementValueGreen)value.Green, (InternalSyntaxToken)multiplicity.Node).CreateRed();
        }
        
        public PElementSyntax PElement(MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> valueAnnotations, PElementValueSyntax value)
        {
        	return this.PElement(default, valueAnnotations, value, default);
        }

        public PBlockInlineSyntax PBlockInline(SyntaxToken tLParen, MetaDslx.CodeAnalysis.SeparatedSyntaxList<PAlternativeSyntax> pAlternativeList, SyntaxToken tRParen)
        {
        	if (tLParen.RawKind != (int)CompilerSyntaxKind.TLParen) throw new ArgumentException(nameof(tLParen));
        	if (tRParen.RawKind != (int)CompilerSyntaxKind.TRParen) throw new ArgumentException(nameof(tRParen));
            return (PBlockInlineSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.PBlockInline((InternalSyntaxToken)tLParen.Node, pAlternativeList.Node.ToGreenSeparatedList<PAlternativeGreen>(reversed: false), (InternalSyntaxToken)tRParen.Node).CreateRed();
        }
        
        public PBlockInlineSyntax PBlockInline(MetaDslx.CodeAnalysis.SeparatedSyntaxList<PAlternativeSyntax> pAlternativeList)
        {
        	return this.PBlockInline(this.Token(CompilerSyntaxKind.TLParen), pAlternativeList, this.Token(CompilerSyntaxKind.TRParen));
        }

        public PEofSyntax PEof(SyntaxToken kEof)
        {
        	if (kEof.RawKind != (int)CompilerSyntaxKind.KEof) throw new ArgumentException(nameof(kEof));
            return (PEofSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.PEof((InternalSyntaxToken)kEof.Node).CreateRed();
        }
        
        public PEofSyntax PEof()
        {
        	return this.PEof(this.Token(CompilerSyntaxKind.KEof));
        }

        public PKeywordSyntax PKeyword(SyntaxToken text)
        {
        	if (text.RawKind != (int)CompilerSyntaxKind.TString) throw new ArgumentException(nameof(text));
            return (PKeywordSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.PKeyword((InternalSyntaxToken)text.Node).CreateRed();
        }

        public PReferenceAlt1Syntax PReferenceAlt1(IdentifierSyntax rule)
        {
        	if (rule is null) throw new ArgumentNullException(nameof(rule));
            return (PReferenceAlt1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.PReferenceAlt1((IdentifierGreen)rule.Green).CreateRed();
        }

        public PReferenceAlt2Syntax PReferenceAlt2(SyntaxToken tHash, ReturnTypeQualifierSyntax referencedTypes)
        {
        	if (tHash.RawKind != (int)CompilerSyntaxKind.THash) throw new ArgumentException(nameof(tHash));
        	if (referencedTypes is null) throw new ArgumentNullException(nameof(referencedTypes));
            return (PReferenceAlt2Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.PReferenceAlt2((InternalSyntaxToken)tHash.Node, (ReturnTypeQualifierGreen)referencedTypes.Green).CreateRed();
        }
        
        public PReferenceAlt2Syntax PReferenceAlt2(ReturnTypeQualifierSyntax referencedTypes)
        {
        	return this.PReferenceAlt2(this.Token(CompilerSyntaxKind.THash), referencedTypes);
        }

        public PReferenceAlt3Syntax PReferenceAlt3(SyntaxToken tHashLBrace, MetaDslx.CodeAnalysis.SeparatedSyntaxList<ReturnTypeQualifierSyntax> returnTypeQualifierList, SyntaxToken tRBrace)
        {
        	if (tHashLBrace.RawKind != (int)CompilerSyntaxKind.THashLBrace) throw new ArgumentException(nameof(tHashLBrace));
        	if (tRBrace.RawKind != (int)CompilerSyntaxKind.TRBrace) throw new ArgumentException(nameof(tRBrace));
            return (PReferenceAlt3Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.PReferenceAlt3((InternalSyntaxToken)tHashLBrace.Node, returnTypeQualifierList.Node.ToGreenSeparatedList<ReturnTypeQualifierGreen>(reversed: false), (InternalSyntaxToken)tRBrace.Node).CreateRed();
        }
        
        public PReferenceAlt3Syntax PReferenceAlt3(MetaDslx.CodeAnalysis.SeparatedSyntaxList<ReturnTypeQualifierSyntax> returnTypeQualifierList)
        {
        	return this.PReferenceAlt3(this.Token(CompilerSyntaxKind.THashLBrace), returnTypeQualifierList, this.Token(CompilerSyntaxKind.TRBrace));
        }

        public LAlternativeSyntax LAlternative(MetaDslx.CodeAnalysis.SyntaxList<LElementSyntax> elements)
        {
            return (LAlternativeSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.LAlternative(elements.Node.ToGreenList<LElementGreen>()).CreateRed();
        }

        public LElementSyntax LElement(SyntaxToken isNegated, LElementValueSyntax value, SyntaxToken multiplicity)
        {
        	if (isNegated.RawKind != (int)CompilerSyntaxKind.TTilde) throw new ArgumentException(nameof(isNegated));
        	if (value is null) throw new ArgumentNullException(nameof(value));
        	if (multiplicity.RawKind != (int)CompilerSyntaxKind.TQuestion && multiplicity.RawKind != (int)CompilerSyntaxKind.TAsterisk && multiplicity.RawKind != (int)CompilerSyntaxKind.TPlus && multiplicity.RawKind != (int)CompilerSyntaxKind.TQuestionQuestion && multiplicity.RawKind != (int)CompilerSyntaxKind.TAsteriskQuestion && multiplicity.RawKind != (int)CompilerSyntaxKind.TPlusQuestion) throw new ArgumentException(nameof(multiplicity));
            return (LElementSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.LElement((InternalSyntaxToken)isNegated.Node, (LElementValueGreen)value.Green, (InternalSyntaxToken)multiplicity.Node).CreateRed();
        }
        
        public LElementSyntax LElement(LElementValueSyntax value)
        {
        	return this.LElement(default, value, default);
        }

        public LBlockSyntax LBlock(SyntaxToken tLParen, MetaDslx.CodeAnalysis.SeparatedSyntaxList<LAlternativeSyntax> lAlternativeList, SyntaxToken tRParen)
        {
        	if (tLParen.RawKind != (int)CompilerSyntaxKind.TLParen) throw new ArgumentException(nameof(tLParen));
        	if (tRParen.RawKind != (int)CompilerSyntaxKind.TRParen) throw new ArgumentException(nameof(tRParen));
            return (LBlockSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.LBlock((InternalSyntaxToken)tLParen.Node, lAlternativeList.Node.ToGreenSeparatedList<LAlternativeGreen>(reversed: false), (InternalSyntaxToken)tRParen.Node).CreateRed();
        }
        
        public LBlockSyntax LBlock(MetaDslx.CodeAnalysis.SeparatedSyntaxList<LAlternativeSyntax> lAlternativeList)
        {
        	return this.LBlock(this.Token(CompilerSyntaxKind.TLParen), lAlternativeList, this.Token(CompilerSyntaxKind.TRParen));
        }

        public LFixedSyntax LFixed(SyntaxToken text)
        {
        	if (text.RawKind != (int)CompilerSyntaxKind.TString) throw new ArgumentException(nameof(text));
            return (LFixedSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.LFixed((InternalSyntaxToken)text.Node).CreateRed();
        }

        public LWildCardSyntax LWildCard(SyntaxToken tDot)
        {
        	if (tDot.RawKind != (int)CompilerSyntaxKind.TDot) throw new ArgumentException(nameof(tDot));
            return (LWildCardSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.LWildCard((InternalSyntaxToken)tDot.Node).CreateRed();
        }
        
        public LWildCardSyntax LWildCard()
        {
        	return this.LWildCard(this.Token(CompilerSyntaxKind.TDot));
        }

        public LRangeSyntax LRange(SyntaxToken startChar, SyntaxToken tDotDot, SyntaxToken endChar)
        {
        	if (startChar.RawKind != (int)CompilerSyntaxKind.TString) throw new ArgumentException(nameof(startChar));
        	if (tDotDot.RawKind != (int)CompilerSyntaxKind.TDotDot) throw new ArgumentException(nameof(tDotDot));
        	if (endChar.RawKind != (int)CompilerSyntaxKind.TString) throw new ArgumentException(nameof(endChar));
            return (LRangeSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.LRange((InternalSyntaxToken)startChar.Node, (InternalSyntaxToken)tDotDot.Node, (InternalSyntaxToken)endChar.Node).CreateRed();
        }
        
        public LRangeSyntax LRange(SyntaxToken startChar, SyntaxToken endChar)
        {
        	return this.LRange(startChar, this.Token(CompilerSyntaxKind.TDotDot), endChar);
        }

        public LReferenceSyntax LReference(IdentifierSyntax rule)
        {
        	if (rule is null) throw new ArgumentNullException(nameof(rule));
            return (LReferenceSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.LReference((IdentifierGreen)rule.Green).CreateRed();
        }

        public ExpressionAlt1Syntax ExpressionAlt1(SingleExpressionSyntax singleExpression)
        {
        	if (singleExpression is null) throw new ArgumentNullException(nameof(singleExpression));
            return (ExpressionAlt1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.ExpressionAlt1((SingleExpressionGreen)singleExpression.Green).CreateRed();
        }

        public ArrayExpressionSyntax ArrayExpression(SyntaxToken tLBrace, ArrayExpressionBlock1Syntax arrayExpressionBlock1, SyntaxToken tRBrace)
        {
        	if (tLBrace.RawKind != (int)CompilerSyntaxKind.TLBrace) throw new ArgumentException(nameof(tLBrace));
        	if (tRBrace.RawKind != (int)CompilerSyntaxKind.TRBrace) throw new ArgumentException(nameof(tRBrace));
            return (ArrayExpressionSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.ArrayExpression((InternalSyntaxToken)tLBrace.Node, (ArrayExpressionBlock1Green?)arrayExpressionBlock1?.Green, (InternalSyntaxToken)tRBrace.Node).CreateRed();
        }
        
        public ArrayExpressionSyntax ArrayExpression()
        {
        	return this.ArrayExpression(this.Token(CompilerSyntaxKind.TLBrace), default, this.Token(CompilerSyntaxKind.TRBrace));
        }

        public SingleExpressionSyntax SingleExpression(SingleExpressionBlock1Syntax value)
        {
        	if (value is null) throw new ArgumentNullException(nameof(value));
            return (SingleExpressionSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.SingleExpression((SingleExpressionBlock1Green)value.Green).CreateRed();
        }

        public ParserAnnotationSyntax ParserAnnotation(SyntaxToken tLBracket, QualifierSyntax attributeClass, AnnotationArgumentsSyntax annotationArguments, SyntaxToken tRBracket)
        {
        	if (tLBracket.RawKind != (int)CompilerSyntaxKind.TLBracket) throw new ArgumentException(nameof(tLBracket));
        	if (attributeClass is null) throw new ArgumentNullException(nameof(attributeClass));
        	if (tRBracket.RawKind != (int)CompilerSyntaxKind.TRBracket) throw new ArgumentException(nameof(tRBracket));
            return (ParserAnnotationSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.ParserAnnotation((InternalSyntaxToken)tLBracket.Node, (QualifierGreen)attributeClass.Green, (AnnotationArgumentsGreen?)annotationArguments?.Green, (InternalSyntaxToken)tRBracket.Node).CreateRed();
        }
        
        public ParserAnnotationSyntax ParserAnnotation(QualifierSyntax attributeClass)
        {
        	return this.ParserAnnotation(this.Token(CompilerSyntaxKind.TLBracket), attributeClass, default, this.Token(CompilerSyntaxKind.TRBracket));
        }

        public LexerAnnotationSyntax LexerAnnotation(SyntaxToken tLBracket, QualifierSyntax attributeClass, AnnotationArgumentsSyntax annotationArguments, SyntaxToken tRBracket)
        {
        	if (tLBracket.RawKind != (int)CompilerSyntaxKind.TLBracket) throw new ArgumentException(nameof(tLBracket));
        	if (attributeClass is null) throw new ArgumentNullException(nameof(attributeClass));
        	if (tRBracket.RawKind != (int)CompilerSyntaxKind.TRBracket) throw new ArgumentException(nameof(tRBracket));
            return (LexerAnnotationSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.LexerAnnotation((InternalSyntaxToken)tLBracket.Node, (QualifierGreen)attributeClass.Green, (AnnotationArgumentsGreen?)annotationArguments?.Green, (InternalSyntaxToken)tRBracket.Node).CreateRed();
        }
        
        public LexerAnnotationSyntax LexerAnnotation(QualifierSyntax attributeClass)
        {
        	return this.LexerAnnotation(this.Token(CompilerSyntaxKind.TLBracket), attributeClass, default, this.Token(CompilerSyntaxKind.TRBracket));
        }

        public AnnotationArgumentsSyntax AnnotationArguments(SyntaxToken tLParen, MetaDslx.CodeAnalysis.SeparatedSyntaxList<AnnotationArgumentSyntax> annotationArgumentList, SyntaxToken tRParen)
        {
        	if (tLParen.RawKind != (int)CompilerSyntaxKind.TLParen) throw new ArgumentException(nameof(tLParen));
        	if (tRParen.RawKind != (int)CompilerSyntaxKind.TRParen) throw new ArgumentException(nameof(tRParen));
            return (AnnotationArgumentsSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.AnnotationArguments((InternalSyntaxToken)tLParen.Node, annotationArgumentList.Node.ToGreenSeparatedList<AnnotationArgumentGreen>(reversed: false), (InternalSyntaxToken)tRParen.Node).CreateRed();
        }
        
        public AnnotationArgumentsSyntax AnnotationArguments(MetaDslx.CodeAnalysis.SeparatedSyntaxList<AnnotationArgumentSyntax> annotationArgumentList)
        {
        	return this.AnnotationArguments(this.Token(CompilerSyntaxKind.TLParen), annotationArgumentList, this.Token(CompilerSyntaxKind.TRParen));
        }

        public AnnotationArgumentSyntax AnnotationArgument(AnnotationArgumentBlock1Syntax annotationArgumentBlock1, ExpressionSyntax value)
        {
        	if (value is null) throw new ArgumentNullException(nameof(value));
            return (AnnotationArgumentSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.AnnotationArgument((AnnotationArgumentBlock1Green?)annotationArgumentBlock1?.Green, (ExpressionGreen)value.Green).CreateRed();
        }
        
        public AnnotationArgumentSyntax AnnotationArgument(ExpressionSyntax value)
        {
        	return this.AnnotationArgument(default, value);
        }

        public ReturnTypeIdentifierAlt1Syntax ReturnTypeIdentifierAlt1(SyntaxToken tPrimitiveType)
        {
        	if (tPrimitiveType.RawKind != (int)CompilerSyntaxKind.TPrimitiveType) throw new ArgumentException(nameof(tPrimitiveType));
            return (ReturnTypeIdentifierAlt1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.ReturnTypeIdentifierAlt1((InternalSyntaxToken)tPrimitiveType.Node).CreateRed();
        }

        public ReturnTypeIdentifierAlt2Syntax ReturnTypeIdentifierAlt2(IdentifierSyntax identifier)
        {
        	if (identifier is null) throw new ArgumentNullException(nameof(identifier));
            return (ReturnTypeIdentifierAlt2Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.ReturnTypeIdentifierAlt2((IdentifierGreen)identifier.Green).CreateRed();
        }

        public ReturnTypeQualifierAlt1Syntax ReturnTypeQualifierAlt1(SyntaxToken tPrimitiveType)
        {
        	if (tPrimitiveType.RawKind != (int)CompilerSyntaxKind.TPrimitiveType) throw new ArgumentException(nameof(tPrimitiveType));
            return (ReturnTypeQualifierAlt1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.ReturnTypeQualifierAlt1((InternalSyntaxToken)tPrimitiveType.Node).CreateRed();
        }

        public ReturnTypeQualifierAlt2Syntax ReturnTypeQualifierAlt2(QualifierSyntax qualifier)
        {
        	if (qualifier is null) throw new ArgumentNullException(nameof(qualifier));
            return (ReturnTypeQualifierAlt2Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.ReturnTypeQualifierAlt2((QualifierGreen)qualifier.Green).CreateRed();
        }

        public NameSyntax Name(IdentifierSyntax identifier)
        {
        	if (identifier is null) throw new ArgumentNullException(nameof(identifier));
            return (NameSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.Name((IdentifierGreen)identifier.Green).CreateRed();
        }

        public QualifierSyntax Qualifier(MetaDslx.CodeAnalysis.SeparatedSyntaxList<IdentifierSyntax> identifierList)
        {
            return (QualifierSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.Qualifier(identifierList.Node.ToGreenSeparatedList<IdentifierGreen>(reversed: false)).CreateRed();
        }

        public QualifierListSyntax QualifierList(MetaDslx.CodeAnalysis.SeparatedSyntaxList<QualifierSyntax> qualifierList)
        {
            return (QualifierListSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.QualifierList(qualifierList.Node.ToGreenSeparatedList<QualifierGreen>(reversed: false)).CreateRed();
        }

        public IdentifierAlt1Syntax IdentifierAlt1(SyntaxToken tIdentifier)
        {
        	if (tIdentifier.RawKind != (int)CompilerSyntaxKind.TIdentifier) throw new ArgumentException(nameof(tIdentifier));
            return (IdentifierAlt1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.IdentifierAlt1((InternalSyntaxToken)tIdentifier.Node).CreateRed();
        }

        public IdentifierAlt2Syntax IdentifierAlt2(SyntaxToken tVerbatimIdentifier)
        {
        	if (tVerbatimIdentifier.RawKind != (int)CompilerSyntaxKind.TVerbatimIdentifier) throw new ArgumentException(nameof(tVerbatimIdentifier));
            return (IdentifierAlt2Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.IdentifierAlt2((InternalSyntaxToken)tVerbatimIdentifier.Node).CreateRed();
        }

        public GrammarBlock1Syntax GrammarBlock1(MetaDslx.CodeAnalysis.SyntaxList<RuleSyntax> rules)
        {
            return (GrammarBlock1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.GrammarBlock1(rules.Node.ToGreenList<RuleGreen>()).CreateRed();
        }

        public ParserRuleBlock1Alt1Syntax ParserRuleBlock1Alt1(ReturnTypeIdentifierSyntax returnType)
        {
        	if (returnType is null) throw new ArgumentNullException(nameof(returnType));
            return (ParserRuleBlock1Alt1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.ParserRuleBlock1Alt1((ReturnTypeIdentifierGreen)returnType.Green).CreateRed();
        }

        public ParserRuleBlock1Alt2Syntax ParserRuleBlock1Alt2(IdentifierSyntax identifier, SyntaxToken kReturns, ReturnTypeQualifierSyntax returnType)
        {
        	if (identifier is null) throw new ArgumentNullException(nameof(identifier));
        	if (kReturns.RawKind != (int)CompilerSyntaxKind.KReturns) throw new ArgumentException(nameof(kReturns));
        	if (returnType is null) throw new ArgumentNullException(nameof(returnType));
            return (ParserRuleBlock1Alt2Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.ParserRuleBlock1Alt2((IdentifierGreen)identifier.Green, (InternalSyntaxToken)kReturns.Node, (ReturnTypeQualifierGreen)returnType.Green).CreateRed();
        }
        
        public ParserRuleBlock1Alt2Syntax ParserRuleBlock1Alt2(IdentifierSyntax identifier, ReturnTypeQualifierSyntax returnType)
        {
        	return this.ParserRuleBlock1Alt2(identifier, this.Token(CompilerSyntaxKind.KReturns), returnType);
        }

        public ParserRuleBlock2Syntax ParserRuleBlock2(SyntaxToken tBar, PAlternativeSyntax alternatives)
        {
        	if (tBar.RawKind != (int)CompilerSyntaxKind.TBar) throw new ArgumentException(nameof(tBar));
        	if (alternatives is null) throw new ArgumentNullException(nameof(alternatives));
            return (ParserRuleBlock2Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.ParserRuleBlock2((InternalSyntaxToken)tBar.Node, (PAlternativeGreen)alternatives.Green).CreateRed();
        }
        
        public ParserRuleBlock2Syntax ParserRuleBlock2(PAlternativeSyntax alternatives)
        {
        	return this.ParserRuleBlock2(this.Token(CompilerSyntaxKind.TBar), alternatives);
        }

        public PBlockBlock1Syntax PBlockBlock1(SyntaxToken kReturns, ReturnTypeQualifierSyntax returnType)
        {
        	if (kReturns.RawKind != (int)CompilerSyntaxKind.KReturns) throw new ArgumentException(nameof(kReturns));
        	if (returnType is null) throw new ArgumentNullException(nameof(returnType));
            return (PBlockBlock1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.PBlockBlock1((InternalSyntaxToken)kReturns.Node, (ReturnTypeQualifierGreen)returnType.Green).CreateRed();
        }
        
        public PBlockBlock1Syntax PBlockBlock1(ReturnTypeQualifierSyntax returnType)
        {
        	return this.PBlockBlock1(this.Token(CompilerSyntaxKind.KReturns), returnType);
        }

        public PBlockBlock2Syntax PBlockBlock2(SyntaxToken tBar, PAlternativeSyntax alternatives)
        {
        	if (tBar.RawKind != (int)CompilerSyntaxKind.TBar) throw new ArgumentException(nameof(tBar));
        	if (alternatives is null) throw new ArgumentNullException(nameof(alternatives));
            return (PBlockBlock2Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.PBlockBlock2((InternalSyntaxToken)tBar.Node, (PAlternativeGreen)alternatives.Green).CreateRed();
        }
        
        public PBlockBlock2Syntax PBlockBlock2(PAlternativeSyntax alternatives)
        {
        	return this.PBlockBlock2(this.Token(CompilerSyntaxKind.TBar), alternatives);
        }

        public PBlockInlineBlock1Syntax PBlockInlineBlock1(SyntaxToken tBar, PAlternativeSyntax alternatives)
        {
        	if (tBar.RawKind != (int)CompilerSyntaxKind.TBar) throw new ArgumentException(nameof(tBar));
        	if (alternatives is null) throw new ArgumentNullException(nameof(alternatives));
            return (PBlockInlineBlock1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.PBlockInlineBlock1((InternalSyntaxToken)tBar.Node, (PAlternativeGreen)alternatives.Green).CreateRed();
        }
        
        public PBlockInlineBlock1Syntax PBlockInlineBlock1(PAlternativeSyntax alternatives)
        {
        	return this.PBlockInlineBlock1(this.Token(CompilerSyntaxKind.TBar), alternatives);
        }

        public PAlternativeBlock1Syntax PAlternativeBlock1(MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> annotations1, SyntaxToken kAlt, NameSyntax name, PAlternativeBlock1Block1Syntax pAlternativeBlock1Block1, SyntaxToken tColon)
        {
        	if (kAlt.RawKind != (int)CompilerSyntaxKind.KAlt) throw new ArgumentException(nameof(kAlt));
        	if (name is null) throw new ArgumentNullException(nameof(name));
        	if (tColon.RawKind != (int)CompilerSyntaxKind.TColon) throw new ArgumentException(nameof(tColon));
            return (PAlternativeBlock1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.PAlternativeBlock1(annotations1.Node.ToGreenList<ParserAnnotationGreen>(), (InternalSyntaxToken)kAlt.Node, (NameGreen)name.Green, (PAlternativeBlock1Block1Green?)pAlternativeBlock1Block1?.Green, (InternalSyntaxToken)tColon.Node).CreateRed();
        }
        
        public PAlternativeBlock1Syntax PAlternativeBlock1(MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> annotations1, NameSyntax name)
        {
        	return this.PAlternativeBlock1(annotations1, this.Token(CompilerSyntaxKind.KAlt), name, default, this.Token(CompilerSyntaxKind.TColon));
        }

        public PAlternativeBlock2Syntax PAlternativeBlock2(SyntaxToken tEqGt, ExpressionSyntax returnValue)
        {
        	if (tEqGt.RawKind != (int)CompilerSyntaxKind.TEqGt) throw new ArgumentException(nameof(tEqGt));
        	if (returnValue is null) throw new ArgumentNullException(nameof(returnValue));
            return (PAlternativeBlock2Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.PAlternativeBlock2((InternalSyntaxToken)tEqGt.Node, (ExpressionGreen)returnValue.Green).CreateRed();
        }
        
        public PAlternativeBlock2Syntax PAlternativeBlock2(ExpressionSyntax returnValue)
        {
        	return this.PAlternativeBlock2(this.Token(CompilerSyntaxKind.TEqGt), returnValue);
        }

        public PElementBlock1Syntax PElementBlock1(MetaDslx.CodeAnalysis.SyntaxList<ParserAnnotationSyntax> nameAnnotations, IdentifierSyntax symbolProperty, SyntaxToken assignment)
        {
        	if (symbolProperty is null) throw new ArgumentNullException(nameof(symbolProperty));
        	if (assignment.RawKind != (int)CompilerSyntaxKind.TEq && assignment.RawKind != (int)CompilerSyntaxKind.TQuestionEq && assignment.RawKind != (int)CompilerSyntaxKind.TExclEq && assignment.RawKind != (int)CompilerSyntaxKind.TPlusEq) throw new ArgumentException(nameof(assignment));
            return (PElementBlock1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.PElementBlock1(nameAnnotations.Node.ToGreenList<ParserAnnotationGreen>(), (IdentifierGreen)symbolProperty.Green, (InternalSyntaxToken)assignment.Node).CreateRed();
        }

        public PReferenceAlt3Block1Syntax PReferenceAlt3Block1(SyntaxToken tComma, ReturnTypeQualifierSyntax referencedTypes)
        {
        	if (tComma.RawKind != (int)CompilerSyntaxKind.TComma) throw new ArgumentException(nameof(tComma));
        	if (referencedTypes is null) throw new ArgumentNullException(nameof(referencedTypes));
            return (PReferenceAlt3Block1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.PReferenceAlt3Block1((InternalSyntaxToken)tComma.Node, (ReturnTypeQualifierGreen)referencedTypes.Green).CreateRed();
        }
        
        public PReferenceAlt3Block1Syntax PReferenceAlt3Block1(ReturnTypeQualifierSyntax referencedTypes)
        {
        	return this.PReferenceAlt3Block1(this.Token(CompilerSyntaxKind.TComma), referencedTypes);
        }

        public LexerRuleBlock1Alt1Syntax LexerRuleBlock1Alt1(SyntaxToken kToken, NameSyntax name, LexerRuleBlock1Alt1Block1Syntax lexerRuleBlock1Alt1Block1)
        {
        	if (kToken.RawKind != (int)CompilerSyntaxKind.KToken) throw new ArgumentException(nameof(kToken));
        	if (name is null) throw new ArgumentNullException(nameof(name));
            return (LexerRuleBlock1Alt1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.LexerRuleBlock1Alt1((InternalSyntaxToken)kToken.Node, (NameGreen)name.Green, (LexerRuleBlock1Alt1Block1Green?)lexerRuleBlock1Alt1Block1?.Green).CreateRed();
        }
        
        public LexerRuleBlock1Alt1Syntax LexerRuleBlock1Alt1(NameSyntax name)
        {
        	return this.LexerRuleBlock1Alt1(this.Token(CompilerSyntaxKind.KToken), name, default);
        }

        public LexerRuleBlock1Alt2Syntax LexerRuleBlock1Alt2(SyntaxToken isHidden, NameSyntax name)
        {
        	if (isHidden.RawKind != (int)CompilerSyntaxKind.KHidden) throw new ArgumentException(nameof(isHidden));
        	if (name is null) throw new ArgumentNullException(nameof(name));
            return (LexerRuleBlock1Alt2Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.LexerRuleBlock1Alt2((InternalSyntaxToken)isHidden.Node, (NameGreen)name.Green).CreateRed();
        }
        
        public LexerRuleBlock1Alt2Syntax LexerRuleBlock1Alt2(NameSyntax name)
        {
        	return this.LexerRuleBlock1Alt2(this.Token(CompilerSyntaxKind.KHidden), name);
        }

        public LexerRuleBlock1Alt3Syntax LexerRuleBlock1Alt3(SyntaxToken isFragment, NameSyntax name)
        {
        	if (isFragment.RawKind != (int)CompilerSyntaxKind.KFragment) throw new ArgumentException(nameof(isFragment));
        	if (name is null) throw new ArgumentNullException(nameof(name));
            return (LexerRuleBlock1Alt3Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.LexerRuleBlock1Alt3((InternalSyntaxToken)isFragment.Node, (NameGreen)name.Green).CreateRed();
        }
        
        public LexerRuleBlock1Alt3Syntax LexerRuleBlock1Alt3(NameSyntax name)
        {
        	return this.LexerRuleBlock1Alt3(this.Token(CompilerSyntaxKind.KFragment), name);
        }

        public LexerRuleBlock2Syntax LexerRuleBlock2(SyntaxToken tBar, LAlternativeSyntax alternatives)
        {
        	if (tBar.RawKind != (int)CompilerSyntaxKind.TBar) throw new ArgumentException(nameof(tBar));
        	if (alternatives is null) throw new ArgumentNullException(nameof(alternatives));
            return (LexerRuleBlock2Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.LexerRuleBlock2((InternalSyntaxToken)tBar.Node, (LAlternativeGreen)alternatives.Green).CreateRed();
        }
        
        public LexerRuleBlock2Syntax LexerRuleBlock2(LAlternativeSyntax alternatives)
        {
        	return this.LexerRuleBlock2(this.Token(CompilerSyntaxKind.TBar), alternatives);
        }

        public LBlockBlock1Syntax LBlockBlock1(SyntaxToken tBar, LAlternativeSyntax alternatives)
        {
        	if (tBar.RawKind != (int)CompilerSyntaxKind.TBar) throw new ArgumentException(nameof(tBar));
        	if (alternatives is null) throw new ArgumentNullException(nameof(alternatives));
            return (LBlockBlock1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.LBlockBlock1((InternalSyntaxToken)tBar.Node, (LAlternativeGreen)alternatives.Green).CreateRed();
        }
        
        public LBlockBlock1Syntax LBlockBlock1(LAlternativeSyntax alternatives)
        {
        	return this.LBlockBlock1(this.Token(CompilerSyntaxKind.TBar), alternatives);
        }

        public SingleExpressionBlock1Alt4Syntax SingleExpressionBlock1Alt4(SyntaxToken tInteger)
        {
        	if (tInteger.RawKind != (int)CompilerSyntaxKind.TInteger) throw new ArgumentException(nameof(tInteger));
            return (SingleExpressionBlock1Alt4Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.SingleExpressionBlock1Alt4((InternalSyntaxToken)tInteger.Node).CreateRed();
        }

        public SingleExpressionBlock1Alt5Syntax SingleExpressionBlock1Alt5(SyntaxToken tString)
        {
        	if (tString.RawKind != (int)CompilerSyntaxKind.TString) throw new ArgumentException(nameof(tString));
            return (SingleExpressionBlock1Alt5Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.SingleExpressionBlock1Alt5((InternalSyntaxToken)tString.Node).CreateRed();
        }

        public SingleExpressionBlock1Alt6Syntax SingleExpressionBlock1Alt6(QualifierSyntax qualifier)
        {
        	if (qualifier is null) throw new ArgumentNullException(nameof(qualifier));
            return (SingleExpressionBlock1Alt6Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.SingleExpressionBlock1Alt6((QualifierGreen)qualifier.Green).CreateRed();
        }

        public SingleExpressionBlock1TokensSyntax SingleExpressionBlock1Tokens(SyntaxToken tokens)
        {
        	if (tokens.RawKind != (int)CompilerSyntaxKind.KNull && tokens.RawKind != (int)CompilerSyntaxKind.KTrue && tokens.RawKind != (int)CompilerSyntaxKind.KFalse) throw new ArgumentException(nameof(tokens));
            return (SingleExpressionBlock1TokensSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.SingleExpressionBlock1Tokens((InternalSyntaxToken)tokens.Node).CreateRed();
        }

        public ArrayExpressionBlock1Syntax ArrayExpressionBlock1(MetaDslx.CodeAnalysis.SeparatedSyntaxList<SingleExpressionSyntax> singleExpressionList)
        {
            return (ArrayExpressionBlock1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.ArrayExpressionBlock1(singleExpressionList.Node.ToGreenSeparatedList<SingleExpressionGreen>(reversed: false)).CreateRed();
        }

        public AnnotationArgumentsBlock1Syntax AnnotationArgumentsBlock1(SyntaxToken tComma, AnnotationArgumentSyntax arguments)
        {
        	if (tComma.RawKind != (int)CompilerSyntaxKind.TComma) throw new ArgumentException(nameof(tComma));
        	if (arguments is null) throw new ArgumentNullException(nameof(arguments));
            return (AnnotationArgumentsBlock1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.AnnotationArgumentsBlock1((InternalSyntaxToken)tComma.Node, (AnnotationArgumentGreen)arguments.Green).CreateRed();
        }
        
        public AnnotationArgumentsBlock1Syntax AnnotationArgumentsBlock1(AnnotationArgumentSyntax arguments)
        {
        	return this.AnnotationArgumentsBlock1(this.Token(CompilerSyntaxKind.TComma), arguments);
        }

        public AnnotationArgumentBlock1Syntax AnnotationArgumentBlock1(NameSyntax name, SyntaxToken tColon)
        {
        	if (name is null) throw new ArgumentNullException(nameof(name));
        	if (tColon.RawKind != (int)CompilerSyntaxKind.TColon) throw new ArgumentException(nameof(tColon));
            return (AnnotationArgumentBlock1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.AnnotationArgumentBlock1((NameGreen)name.Green, (InternalSyntaxToken)tColon.Node).CreateRed();
        }
        
        public AnnotationArgumentBlock1Syntax AnnotationArgumentBlock1(NameSyntax name)
        {
        	return this.AnnotationArgumentBlock1(name, this.Token(CompilerSyntaxKind.TColon));
        }

        public QualifierBlock1Syntax QualifierBlock1(SyntaxToken tDot, IdentifierSyntax identifier)
        {
        	if (tDot.RawKind != (int)CompilerSyntaxKind.TDot) throw new ArgumentException(nameof(tDot));
        	if (identifier is null) throw new ArgumentNullException(nameof(identifier));
            return (QualifierBlock1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.QualifierBlock1((InternalSyntaxToken)tDot.Node, (IdentifierGreen)identifier.Green).CreateRed();
        }
        
        public QualifierBlock1Syntax QualifierBlock1(IdentifierSyntax identifier)
        {
        	return this.QualifierBlock1(this.Token(CompilerSyntaxKind.TDot), identifier);
        }

        public QualifierListBlock1Syntax QualifierListBlock1(SyntaxToken tComma, QualifierSyntax qualifier)
        {
        	if (tComma.RawKind != (int)CompilerSyntaxKind.TComma) throw new ArgumentException(nameof(tComma));
        	if (qualifier is null) throw new ArgumentNullException(nameof(qualifier));
            return (QualifierListBlock1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.QualifierListBlock1((InternalSyntaxToken)tComma.Node, (QualifierGreen)qualifier.Green).CreateRed();
        }
        
        public QualifierListBlock1Syntax QualifierListBlock1(QualifierSyntax qualifier)
        {
        	return this.QualifierListBlock1(this.Token(CompilerSyntaxKind.TComma), qualifier);
        }

        public PAlternativeBlock1Block1Syntax PAlternativeBlock1Block1(SyntaxToken kReturns, ReturnTypeQualifierSyntax returnType)
        {
        	if (kReturns.RawKind != (int)CompilerSyntaxKind.KReturns) throw new ArgumentException(nameof(kReturns));
        	if (returnType is null) throw new ArgumentNullException(nameof(returnType));
            return (PAlternativeBlock1Block1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.PAlternativeBlock1Block1((InternalSyntaxToken)kReturns.Node, (ReturnTypeQualifierGreen)returnType.Green).CreateRed();
        }
        
        public PAlternativeBlock1Block1Syntax PAlternativeBlock1Block1(ReturnTypeQualifierSyntax returnType)
        {
        	return this.PAlternativeBlock1Block1(this.Token(CompilerSyntaxKind.KReturns), returnType);
        }

        public LexerRuleBlock1Alt1Block1Syntax LexerRuleBlock1Alt1Block1(SyntaxToken kReturns, ReturnTypeQualifierSyntax returnType)
        {
        	if (kReturns.RawKind != (int)CompilerSyntaxKind.KReturns) throw new ArgumentException(nameof(kReturns));
        	if (returnType is null) throw new ArgumentNullException(nameof(returnType));
            return (LexerRuleBlock1Alt1Block1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.LexerRuleBlock1Alt1Block1((InternalSyntaxToken)kReturns.Node, (ReturnTypeQualifierGreen)returnType.Green).CreateRed();
        }
        
        public LexerRuleBlock1Alt1Block1Syntax LexerRuleBlock1Alt1Block1(ReturnTypeQualifierSyntax returnType)
        {
        	return this.LexerRuleBlock1Alt1Block1(this.Token(CompilerSyntaxKind.KReturns), returnType);
        }

        public ArrayExpressionBlock1Block1Syntax ArrayExpressionBlock1Block1(SyntaxToken tComma, SingleExpressionSyntax items)
        {
        	if (tComma.RawKind != (int)CompilerSyntaxKind.TComma) throw new ArgumentException(nameof(tComma));
        	if (items is null) throw new ArgumentNullException(nameof(items));
            return (ArrayExpressionBlock1Block1Syntax)CompilerLanguage.Instance.InternalSyntaxFactory.ArrayExpressionBlock1Block1((InternalSyntaxToken)tComma.Node, (SingleExpressionGreen)items.Green).CreateRed();
        }
        
        public ArrayExpressionBlock1Block1Syntax ArrayExpressionBlock1Block1(SingleExpressionSyntax items)
        {
        	return this.ArrayExpressionBlock1Block1(this.Token(CompilerSyntaxKind.TComma), items);
        }
				

        internal static IEnumerable<Type> GetNodeTypes()
        {
            return new Type[] {
		        typeof(MainSyntax),
		        typeof(UsingSyntax),
		        typeof(DeclarationsSyntax),
		        typeof(LanguageDeclarationSyntax),
		        typeof(GrammarSyntax),
		        typeof(ParserRuleSyntax),
		        typeof(PBlockSyntax),
		        typeof(LexerRuleSyntax),
		        typeof(PAlternativeSyntax),
		        typeof(PElementSyntax),
		        typeof(PBlockInlineSyntax),
		        typeof(PEofSyntax),
		        typeof(PKeywordSyntax),
		        typeof(PReferenceAlt1Syntax),
		        typeof(PReferenceAlt2Syntax),
		        typeof(PReferenceAlt3Syntax),
		        typeof(LAlternativeSyntax),
		        typeof(LElementSyntax),
		        typeof(LBlockSyntax),
		        typeof(LFixedSyntax),
		        typeof(LWildCardSyntax),
		        typeof(LRangeSyntax),
		        typeof(LReferenceSyntax),
		        typeof(ExpressionAlt1Syntax),
		        typeof(ArrayExpressionSyntax),
		        typeof(SingleExpressionSyntax),
		        typeof(ParserAnnotationSyntax),
		        typeof(LexerAnnotationSyntax),
		        typeof(AnnotationArgumentsSyntax),
		        typeof(AnnotationArgumentSyntax),
		        typeof(ReturnTypeIdentifierAlt1Syntax),
		        typeof(ReturnTypeIdentifierAlt2Syntax),
		        typeof(ReturnTypeQualifierAlt1Syntax),
		        typeof(ReturnTypeQualifierAlt2Syntax),
		        typeof(NameSyntax),
		        typeof(QualifierSyntax),
		        typeof(QualifierListSyntax),
		        typeof(IdentifierAlt1Syntax),
		        typeof(IdentifierAlt2Syntax),
		        typeof(GrammarBlock1Syntax),
		        typeof(ParserRuleBlock1Alt1Syntax),
		        typeof(ParserRuleBlock1Alt2Syntax),
		        typeof(ParserRuleBlock2Syntax),
		        typeof(PBlockBlock1Syntax),
		        typeof(PBlockBlock2Syntax),
		        typeof(PBlockInlineBlock1Syntax),
		        typeof(PAlternativeBlock1Syntax),
		        typeof(PAlternativeBlock2Syntax),
		        typeof(PElementBlock1Syntax),
		        typeof(PReferenceAlt3Block1Syntax),
		        typeof(LexerRuleBlock1Alt1Syntax),
		        typeof(LexerRuleBlock1Alt2Syntax),
		        typeof(LexerRuleBlock1Alt3Syntax),
		        typeof(LexerRuleBlock2Syntax),
		        typeof(LBlockBlock1Syntax),
		        typeof(SingleExpressionBlock1Alt4Syntax),
		        typeof(SingleExpressionBlock1Alt5Syntax),
		        typeof(SingleExpressionBlock1Alt6Syntax),
		        typeof(SingleExpressionBlock1TokensSyntax),
		        typeof(ArrayExpressionBlock1Syntax),
		        typeof(AnnotationArgumentsBlock1Syntax),
		        typeof(AnnotationArgumentBlock1Syntax),
		        typeof(QualifierBlock1Syntax),
		        typeof(QualifierListBlock1Syntax),
		        typeof(PAlternativeBlock1Block1Syntax),
		        typeof(LexerRuleBlock1Alt1Block1Syntax),
		        typeof(ArrayExpressionBlock1Block1Syntax),
		    };
        }

    }
}	
