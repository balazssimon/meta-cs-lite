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

        public SyntaxToken TIdentifier(string text)
        {
            return new SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.TIdentifier(text));
        }

        public SyntaxToken TIdentifier(string text, object value)
        {
            return new SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.TIdentifier(text, value));
        }

        public SyntaxToken TString(string text)
        {
            return new SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.TString(text));
        }

        public SyntaxToken TString(string text, object value)
        {
            return new SyntaxToken(CompilerLanguage.Instance.InternalSyntaxFactory.TString(text, value));
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

        public MainSyntax Main(SyntaxToken kNamespace, QualifierSyntax name, SyntaxToken tSemicolon, MetaDslx.CodeAnalysis.SyntaxList<UsingSyntax> @using, SyntaxToken eof)
        {
        	if (kNamespace.RawKind != (int)CompilerSyntaxKind.KNamespace) throw new ArgumentException(nameof(kNamespace));
        	if (name is null) throw new ArgumentNullException(nameof(name));
        	if (tSemicolon.RawKind != (int)CompilerSyntaxKind.TSemicolon) throw new ArgumentException(nameof(tSemicolon));
        	if (eof.RawKind != (int)CompilerSyntaxKind.Eof) throw new ArgumentException(nameof(eof));
            return (MainSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.Main((InternalSyntaxToken)kNamespace.Node, (QualifierGreen)name.Green, (InternalSyntaxToken)tSemicolon.Node, @using.Node.ToGreenList<UsingGreen>(), (InternalSyntaxToken)eof.Node).CreateRed();
        }
        
        public MainSyntax Main(QualifierSyntax name, MetaDslx.CodeAnalysis.SyntaxList<UsingSyntax> @using)
        {
        	return this.Main(this.Token(CompilerSyntaxKind.KNamespace), name, this.Token(CompilerSyntaxKind.TSemicolon), @using, this.Token(CompilerSyntaxKind.Eof));
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

        public IdentifierSyntax Identifier(SyntaxToken tIdentifier)
        {
        	if (tIdentifier.RawKind != (int)CompilerSyntaxKind.TIdentifier) throw new ArgumentException(nameof(tIdentifier));
            return (IdentifierSyntax)CompilerLanguage.Instance.InternalSyntaxFactory.Identifier((InternalSyntaxToken)tIdentifier.Node).CreateRed();
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
				

        internal static IEnumerable<Type> GetNodeTypes()
        {
            return new Type[] {
		        typeof(MainSyntax),
		        typeof(UsingSyntax),
		        typeof(NameSyntax),
		        typeof(QualifierSyntax),
		        typeof(QualifierListSyntax),
		        typeof(IdentifierSyntax),
		        typeof(QualifierBlock1Syntax),
		        typeof(QualifierListBlock1Syntax),
		    };
        }

    }
}	
