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

public MainSyntax Main(__SyntaxToken kNamespace, QualifierSyntax name, __SyntaxToken tSemicolon, global::MetaDslx.CodeAnalysis.SyntaxList<UsingSyntax> usingList, DeclarationsSyntax declarations, __SyntaxToken endOfFileToken)
{
	if (kNamespace.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(kNamespace));
	if (kNamespace.RawKind != (int)MetaSyntaxKind.KNamespace) throw new __ArgumentException(nameof(kNamespace));
	if (name is null) throw new __ArgumentNullException(nameof(name));
	if (tSemicolon.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tSemicolon));
	if (tSemicolon.RawKind != (int)MetaSyntaxKind.TSemicolon) throw new __ArgumentException(nameof(tSemicolon));
	if (declarations is null) throw new __ArgumentNullException(nameof(declarations));
	if (endOfFileToken.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(endOfFileToken));
	if (endOfFileToken.RawKind != (int)__InternalSyntaxKind.Eof) throw new __ArgumentException(nameof(endOfFileToken));
    return (MainSyntax)MetaLanguage.Instance.InternalSyntaxFactory.Main((__InternalSyntaxToken)kNamespace.Node, (InternalSyntax.QualifierGreen)name.Green, (__InternalSyntaxToken)tSemicolon.Node, __GreenNodeExtensions.ToGreenList<InternalSyntax.UsingGreen>(usingList.Node), (InternalSyntax.DeclarationsGreen)declarations.Green, (__InternalSyntaxToken)endOfFileToken.Node).CreateRed();
}

public MainSyntax Main(QualifierSyntax name, global::MetaDslx.CodeAnalysis.SyntaxList<UsingSyntax> usingList, DeclarationsSyntax declarations, __SyntaxToken endOfFileToken)
{
	return this.Main(this.Token(MetaSyntaxKind.KNamespace), name, this.Token(MetaSyntaxKind.TSemicolon), usingList, declarations, this.Token(MetaSyntaxKind.Eof));
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

public DeclarationsSyntax Declarations(global::MetaDslx.CodeAnalysis.SyntaxList<MetaDeclarationSyntax> declarations)
{
    return (DeclarationsSyntax)MetaLanguage.Instance.InternalSyntaxFactory.Declarations(__GreenNodeExtensions.ToGreenList<InternalSyntax.MetaDeclarationGreen>(declarations.Node)).CreateRed();
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

public MetaConstantSyntax MetaConstant(__SyntaxToken kConst, TypeReferenceSyntax type, NameSyntax name, __SyntaxToken tSemicolon)
{
	if (kConst.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(kConst));
	if (kConst.RawKind != (int)MetaSyntaxKind.KConst) throw new __ArgumentException(nameof(kConst));
	if (type is null) throw new __ArgumentNullException(nameof(type));
	if (name is null) throw new __ArgumentNullException(nameof(name));
	if (tSemicolon.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tSemicolon));
	if (tSemicolon.RawKind != (int)MetaSyntaxKind.TSemicolon) throw new __ArgumentException(nameof(tSemicolon));
    return (MetaConstantSyntax)MetaLanguage.Instance.InternalSyntaxFactory.MetaConstant((__InternalSyntaxToken)kConst.Node, (InternalSyntax.TypeReferenceGreen)type.Green, (InternalSyntax.NameGreen)name.Green, (__InternalSyntaxToken)tSemicolon.Node).CreateRed();
}

public MetaConstantSyntax MetaConstant(TypeReferenceSyntax type, NameSyntax name)
{
	return this.MetaConstant(this.Token(MetaSyntaxKind.KConst), type, name, this.Token(MetaSyntaxKind.TSemicolon));
}

public MetaEnumSyntax MetaEnum(__SyntaxToken kEnum, NameSyntax name, EnumBodySyntax enumBody)
{
	if (kEnum.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(kEnum));
	if (kEnum.RawKind != (int)MetaSyntaxKind.KEnum) throw new __ArgumentException(nameof(kEnum));
	if (name is null) throw new __ArgumentNullException(nameof(name));
	if (enumBody is null) throw new __ArgumentNullException(nameof(enumBody));
    return (MetaEnumSyntax)MetaLanguage.Instance.InternalSyntaxFactory.MetaEnum((__InternalSyntaxToken)kEnum.Node, (InternalSyntax.NameGreen)name.Green, (InternalSyntax.EnumBodyGreen)enumBody.Green).CreateRed();
}

public MetaEnumSyntax MetaEnum(NameSyntax name, EnumBodySyntax enumBody)
{
	return this.MetaEnum(this.Token(MetaSyntaxKind.KEnum), name, enumBody);
}

public MetaClassSyntax MetaClass(__SyntaxToken isAbstract, __SyntaxToken kClass, ClassNameSyntax className, BaseClassesSyntax baseClasses, ClassBodySyntax classBody)
{
	if (isAbstract.RawKind != (int)__InternalSyntaxKind.None && (isAbstract.RawKind != (int)MetaSyntaxKind.KAbstract)) throw new __ArgumentException(nameof(isAbstract));
	if (kClass.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(kClass));
	if (kClass.RawKind != (int)MetaSyntaxKind.KClass) throw new __ArgumentException(nameof(kClass));
	if (className is null) throw new __ArgumentNullException(nameof(className));
	if (classBody is null) throw new __ArgumentNullException(nameof(classBody));
    return (MetaClassSyntax)MetaLanguage.Instance.InternalSyntaxFactory.MetaClass((__InternalSyntaxToken)isAbstract.Node, (__InternalSyntaxToken)kClass.Node, (InternalSyntax.ClassNameGreen)className.Green, (InternalSyntax.BaseClassesGreen)baseClasses.Green, (InternalSyntax.ClassBodyGreen)classBody.Green).CreateRed();
}

public MetaClassSyntax MetaClass(ClassNameSyntax className, ClassBodySyntax classBody)
{
	return this.MetaClass(default, this.Token(MetaSyntaxKind.KClass), className, default, classBody);
}

public EnumBodySyntax EnumBody(__SyntaxToken tLBrace, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<MetaEnumLiteralSyntax> enumLiterals, __SyntaxToken tRBrace)
{
	if (tLBrace.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tLBrace));
	if (tLBrace.RawKind != (int)MetaSyntaxKind.TLBrace) throw new __ArgumentException(nameof(tLBrace));
	if (tRBrace.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tRBrace));
	if (tRBrace.RawKind != (int)MetaSyntaxKind.TRBrace) throw new __ArgumentException(nameof(tRBrace));
    return (EnumBodySyntax)MetaLanguage.Instance.InternalSyntaxFactory.EnumBody((__InternalSyntaxToken)tLBrace.Node, __GreenNodeExtensions.ToGreenSeparatedList<InternalSyntax.MetaEnumLiteralGreen>(enumLiterals.Node, reversed: false), (__InternalSyntaxToken)tRBrace.Node).CreateRed();
}

public EnumBodySyntax EnumBody()
{
	return this.EnumBody(this.Token(MetaSyntaxKind.TLBrace), default, this.Token(MetaSyntaxKind.TRBrace));
}

public MetaEnumLiteralSyntax MetaEnumLiteral(NameSyntax name)
{
	if (name is null) throw new __ArgumentNullException(nameof(name));
    return (MetaEnumLiteralSyntax)MetaLanguage.Instance.InternalSyntaxFactory.MetaEnumLiteral((InternalSyntax.NameGreen)name.Green).CreateRed();
}

public ClassNameAlt1Syntax ClassNameAlt1(IdentifierSyntax identifier, __SyntaxToken tDollar, IdentifierSyntax symbolType)
{
	if (tDollar.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tDollar));
	if (tDollar.RawKind != (int)MetaSyntaxKind.TDollar) throw new __ArgumentException(nameof(tDollar));
	if (symbolType is null) throw new __ArgumentNullException(nameof(symbolType));
    return (ClassNameAlt1Syntax)MetaLanguage.Instance.InternalSyntaxFactory.ClassNameAlt1((InternalSyntax.IdentifierGreen)identifier.Green, (__InternalSyntaxToken)tDollar.Node, (InternalSyntax.IdentifierGreen)symbolType.Green).CreateRed();
}

public ClassNameAlt1Syntax ClassNameAlt1(IdentifierSyntax symbolType)
{
	return this.ClassNameAlt1(default, this.Token(MetaSyntaxKind.TDollar), symbolType);
}

public ClassNameAlt2Syntax ClassNameAlt2(IdentifierSyntax identifier)
{
	if (identifier is null) throw new __ArgumentNullException(nameof(identifier));
    return (ClassNameAlt2Syntax)MetaLanguage.Instance.InternalSyntaxFactory.ClassNameAlt2((InternalSyntax.IdentifierGreen)identifier.Green).CreateRed();
}

public BaseClassesSyntax BaseClasses(__SyntaxToken tColon, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<QualifierSyntax> baseTypes)
{
	if (tColon.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tColon));
	if (tColon.RawKind != (int)MetaSyntaxKind.TColon) throw new __ArgumentException(nameof(tColon));
    return (BaseClassesSyntax)MetaLanguage.Instance.InternalSyntaxFactory.BaseClasses((__InternalSyntaxToken)tColon.Node, __GreenNodeExtensions.ToGreenSeparatedList<InternalSyntax.QualifierGreen>(baseTypes.Node, reversed: false)).CreateRed();
}

public BaseClassesSyntax BaseClasses(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<QualifierSyntax> baseTypes)
{
	return this.BaseClasses(this.Token(MetaSyntaxKind.TColon), baseTypes);
}

public ClassBodySyntax ClassBody(__SyntaxToken tLBrace, global::MetaDslx.CodeAnalysis.SyntaxList<ClassMemberSyntax> classMemberList, __SyntaxToken tRBrace)
{
	if (tLBrace.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tLBrace));
	if (tLBrace.RawKind != (int)MetaSyntaxKind.TLBrace) throw new __ArgumentException(nameof(tLBrace));
	if (tRBrace.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tRBrace));
	if (tRBrace.RawKind != (int)MetaSyntaxKind.TRBrace) throw new __ArgumentException(nameof(tRBrace));
    return (ClassBodySyntax)MetaLanguage.Instance.InternalSyntaxFactory.ClassBody((__InternalSyntaxToken)tLBrace.Node, __GreenNodeExtensions.ToGreenList<InternalSyntax.ClassMemberGreen>(classMemberList.Node), (__InternalSyntaxToken)tRBrace.Node).CreateRed();
}

public ClassBodySyntax ClassBody(global::MetaDslx.CodeAnalysis.SyntaxList<ClassMemberSyntax> classMemberList)
{
	return this.ClassBody(this.Token(MetaSyntaxKind.TLBrace), classMemberList, this.Token(MetaSyntaxKind.TRBrace));
}

public ClassMemberAlt1Syntax ClassMemberAlt1(MetaPropertySyntax properties)
{
	if (properties is null) throw new __ArgumentNullException(nameof(properties));
    return (ClassMemberAlt1Syntax)MetaLanguage.Instance.InternalSyntaxFactory.ClassMemberAlt1((InternalSyntax.MetaPropertyGreen)properties.Green).CreateRed();
}

public ClassMemberAlt2Syntax ClassMemberAlt2(MetaOperationSyntax operations)
{
	if (operations is null) throw new __ArgumentNullException(nameof(operations));
    return (ClassMemberAlt2Syntax)MetaLanguage.Instance.InternalSyntaxFactory.ClassMemberAlt2((InternalSyntax.MetaOperationGreen)operations.Green).CreateRed();
}

public MetaPropertySyntax MetaProperty(__SyntaxToken tokens, TypeReferenceSyntax type, PropertyNameSyntax propertyName, global::MetaDslx.CodeAnalysis.SyntaxList<MetaPropertyBlock1Syntax> block, __SyntaxToken tSemicolon)
{
	if (tokens.RawKind != (int)__InternalSyntaxKind.None && (tokens.RawKind != (int)MetaSyntaxKind.KContains && tokens.RawKind != (int)MetaSyntaxKind.KDerived)) throw new __ArgumentException(nameof(tokens));
	if (type is null) throw new __ArgumentNullException(nameof(type));
	if (propertyName is null) throw new __ArgumentNullException(nameof(propertyName));
	if (tSemicolon.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tSemicolon));
	if (tSemicolon.RawKind != (int)MetaSyntaxKind.TSemicolon) throw new __ArgumentException(nameof(tSemicolon));
    return (MetaPropertySyntax)MetaLanguage.Instance.InternalSyntaxFactory.MetaProperty((__InternalSyntaxToken)tokens.Node, (InternalSyntax.TypeReferenceGreen)type.Green, (InternalSyntax.PropertyNameGreen)propertyName.Green, __GreenNodeExtensions.ToGreenList<InternalSyntax.MetaPropertyBlock1Green>(block.Node), (__InternalSyntaxToken)tSemicolon.Node).CreateRed();
}

public MetaPropertySyntax MetaProperty(TypeReferenceSyntax type, PropertyNameSyntax propertyName, global::MetaDslx.CodeAnalysis.SyntaxList<MetaPropertyBlock1Syntax> block)
{
	return this.MetaProperty(default, type, propertyName, block, this.Token(MetaSyntaxKind.TSemicolon));
}

public PropertyNameAlt1Syntax PropertyNameAlt1(IdentifierSyntax identifier, __SyntaxToken tDollar, IdentifierSyntax symbolProperty)
{
	if (tDollar.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tDollar));
	if (tDollar.RawKind != (int)MetaSyntaxKind.TDollar) throw new __ArgumentException(nameof(tDollar));
	if (symbolProperty is null) throw new __ArgumentNullException(nameof(symbolProperty));
    return (PropertyNameAlt1Syntax)MetaLanguage.Instance.InternalSyntaxFactory.PropertyNameAlt1((InternalSyntax.IdentifierGreen)identifier.Green, (__InternalSyntaxToken)tDollar.Node, (InternalSyntax.IdentifierGreen)symbolProperty.Green).CreateRed();
}

public PropertyNameAlt1Syntax PropertyNameAlt1(IdentifierSyntax symbolProperty)
{
	return this.PropertyNameAlt1(default, this.Token(MetaSyntaxKind.TDollar), symbolProperty);
}

public PropertyNameAlt2Syntax PropertyNameAlt2(IdentifierSyntax identifier)
{
	if (identifier is null) throw new __ArgumentNullException(nameof(identifier));
    return (PropertyNameAlt2Syntax)MetaLanguage.Instance.InternalSyntaxFactory.PropertyNameAlt2((InternalSyntax.IdentifierGreen)identifier.Green).CreateRed();
}

public MetaOperationSyntax MetaOperation(TypeReferenceSyntax returnType, NameSyntax name, __SyntaxToken tLParen, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<MetaParameterSyntax> parameterList, __SyntaxToken tRParen, __SyntaxToken tSemicolon)
{
	if (returnType is null) throw new __ArgumentNullException(nameof(returnType));
	if (name is null) throw new __ArgumentNullException(nameof(name));
	if (tLParen.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tLParen));
	if (tLParen.RawKind != (int)MetaSyntaxKind.TLParen) throw new __ArgumentException(nameof(tLParen));
	if (tRParen.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tRParen));
	if (tRParen.RawKind != (int)MetaSyntaxKind.TRParen) throw new __ArgumentException(nameof(tRParen));
	if (tSemicolon.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tSemicolon));
	if (tSemicolon.RawKind != (int)MetaSyntaxKind.TSemicolon) throw new __ArgumentException(nameof(tSemicolon));
    return (MetaOperationSyntax)MetaLanguage.Instance.InternalSyntaxFactory.MetaOperation((InternalSyntax.TypeReferenceGreen)returnType.Green, (InternalSyntax.NameGreen)name.Green, (__InternalSyntaxToken)tLParen.Node, __GreenNodeExtensions.ToGreenSeparatedList<InternalSyntax.MetaParameterGreen>(parameterList.Node, reversed: false), (__InternalSyntaxToken)tRParen.Node, (__InternalSyntaxToken)tSemicolon.Node).CreateRed();
}

public MetaOperationSyntax MetaOperation(TypeReferenceSyntax returnType, NameSyntax name)
{
	return this.MetaOperation(returnType, name, this.Token(MetaSyntaxKind.TLParen), default, this.Token(MetaSyntaxKind.TRParen), this.Token(MetaSyntaxKind.TSemicolon));
}

public MetaParameterSyntax MetaParameter(TypeReferenceSyntax type, NameSyntax name)
{
	if (type is null) throw new __ArgumentNullException(nameof(type));
	if (name is null) throw new __ArgumentNullException(nameof(name));
    return (MetaParameterSyntax)MetaLanguage.Instance.InternalSyntaxFactory.MetaParameter((InternalSyntax.TypeReferenceGreen)type.Green, (InternalSyntax.NameGreen)name.Green).CreateRed();
}

public TypeReferenceTokensSyntax TypeReferenceTokens(__SyntaxToken token)
{
	if (token.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(token));
	if (token.RawKind != (int)MetaSyntaxKind.KBool && token.RawKind != (int)MetaSyntaxKind.KInt && token.RawKind != (int)MetaSyntaxKind.KString && token.RawKind != (int)MetaSyntaxKind.KType && token.RawKind != (int)MetaSyntaxKind.KSymbol && token.RawKind != (int)MetaSyntaxKind.KObject && token.RawKind != (int)MetaSyntaxKind.KVoid) throw new __ArgumentException(nameof(token));
    return (TypeReferenceTokensSyntax)MetaLanguage.Instance.InternalSyntaxFactory.TypeReferenceTokens((__InternalSyntaxToken)token.Node).CreateRed();
}

public SimpleTypeReferenceAlt2Syntax SimpleTypeReferenceAlt2(QualifierSyntax qualifier)
{
	if (qualifier is null) throw new __ArgumentNullException(nameof(qualifier));
    return (SimpleTypeReferenceAlt2Syntax)MetaLanguage.Instance.InternalSyntaxFactory.SimpleTypeReferenceAlt2((InternalSyntax.QualifierGreen)qualifier.Green).CreateRed();
}

public MetaArrayTypeSyntax MetaArrayType(TypeReferenceSyntax itemType, __SyntaxToken tLBracket, __SyntaxToken tRBracket)
{
	if (itemType is null) throw new __ArgumentNullException(nameof(itemType));
	if (tLBracket.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tLBracket));
	if (tLBracket.RawKind != (int)MetaSyntaxKind.TLBracket) throw new __ArgumentException(nameof(tLBracket));
	if (tRBracket.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tRBracket));
	if (tRBracket.RawKind != (int)MetaSyntaxKind.TRBracket) throw new __ArgumentException(nameof(tRBracket));
    return (MetaArrayTypeSyntax)MetaLanguage.Instance.InternalSyntaxFactory.MetaArrayType((InternalSyntax.TypeReferenceGreen)itemType.Green, (__InternalSyntaxToken)tLBracket.Node, (__InternalSyntaxToken)tRBracket.Node).CreateRed();
}

public MetaArrayTypeSyntax MetaArrayType(TypeReferenceSyntax itemType)
{
	return this.MetaArrayType(itemType, this.Token(MetaSyntaxKind.TLBracket), this.Token(MetaSyntaxKind.TRBracket));
}

public MetaNullableTypeSyntax MetaNullableType(TypeReferenceSyntax innerType, __SyntaxToken tQuestion)
{
	if (innerType is null) throw new __ArgumentNullException(nameof(innerType));
	if (tQuestion.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tQuestion));
	if (tQuestion.RawKind != (int)MetaSyntaxKind.TQuestion) throw new __ArgumentException(nameof(tQuestion));
    return (MetaNullableTypeSyntax)MetaLanguage.Instance.InternalSyntaxFactory.MetaNullableType((InternalSyntax.TypeReferenceGreen)innerType.Green, (__InternalSyntaxToken)tQuestion.Node).CreateRed();
}

public MetaNullableTypeSyntax MetaNullableType(TypeReferenceSyntax innerType)
{
	return this.MetaNullableType(innerType, this.Token(MetaSyntaxKind.TQuestion));
}

public NameSyntax Name(IdentifierSyntax identifier)
{
	if (identifier is null) throw new __ArgumentNullException(nameof(identifier));
    return (NameSyntax)MetaLanguage.Instance.InternalSyntaxFactory.Name((InternalSyntax.IdentifierGreen)identifier.Green).CreateRed();
}

public QualifierSyntax Qualifier(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<IdentifierSyntax> qualifier)
{
    return (QualifierSyntax)MetaLanguage.Instance.InternalSyntaxFactory.Qualifier(__GreenNodeExtensions.ToGreenSeparatedList<InternalSyntax.IdentifierGreen>(qualifier.Node, reversed: false)).CreateRed();
}

public IdentifierSyntax Identifier(__SyntaxToken token)
{
	if (token.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(token));
	if (token.RawKind != (int)MetaSyntaxKind.TIdentifier && token.RawKind != (int)MetaSyntaxKind.TVerbatimIdentifier) throw new __ArgumentException(nameof(token));
    return (IdentifierSyntax)MetaLanguage.Instance.InternalSyntaxFactory.Identifier((__InternalSyntaxToken)token.Node).CreateRed();
}

public EnumBodyEnumLiteralsBlockSyntax EnumBodyEnumLiteralsBlock(__SyntaxToken tComma, MetaEnumLiteralSyntax literals)
{
	if (tComma.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tComma));
	if (tComma.RawKind != (int)MetaSyntaxKind.TComma) throw new __ArgumentException(nameof(tComma));
	if (literals is null) throw new __ArgumentNullException(nameof(literals));
    return (EnumBodyEnumLiteralsBlockSyntax)MetaLanguage.Instance.InternalSyntaxFactory.EnumBodyEnumLiteralsBlock((__InternalSyntaxToken)tComma.Node, (InternalSyntax.MetaEnumLiteralGreen)literals.Green).CreateRed();
}

public EnumBodyEnumLiteralsBlockSyntax EnumBodyEnumLiteralsBlock(MetaEnumLiteralSyntax literals)
{
	return this.EnumBodyEnumLiteralsBlock(this.Token(MetaSyntaxKind.TComma), literals);
}

public BaseClassesBaseTypesBlockSyntax BaseClassesBaseTypesBlock(__SyntaxToken tComma, QualifierSyntax baseTypes)
{
	if (tComma.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tComma));
	if (tComma.RawKind != (int)MetaSyntaxKind.TComma) throw new __ArgumentException(nameof(tComma));
	if (baseTypes is null) throw new __ArgumentNullException(nameof(baseTypes));
    return (BaseClassesBaseTypesBlockSyntax)MetaLanguage.Instance.InternalSyntaxFactory.BaseClassesBaseTypesBlock((__InternalSyntaxToken)tComma.Node, (InternalSyntax.QualifierGreen)baseTypes.Green).CreateRed();
}

public BaseClassesBaseTypesBlockSyntax BaseClassesBaseTypesBlock(QualifierSyntax baseTypes)
{
	return this.BaseClassesBaseTypesBlock(this.Token(MetaSyntaxKind.TComma), baseTypes);
}

public PropertyOppositeSyntax PropertyOpposite(__SyntaxToken kOpposite, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<QualifierSyntax> oppositeProperties)
{
	if (kOpposite.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(kOpposite));
	if (kOpposite.RawKind != (int)MetaSyntaxKind.KOpposite) throw new __ArgumentException(nameof(kOpposite));
    return (PropertyOppositeSyntax)MetaLanguage.Instance.InternalSyntaxFactory.PropertyOpposite((__InternalSyntaxToken)kOpposite.Node, __GreenNodeExtensions.ToGreenSeparatedList<InternalSyntax.QualifierGreen>(oppositeProperties.Node, reversed: false)).CreateRed();
}

public PropertyOppositeSyntax PropertyOpposite(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<QualifierSyntax> oppositeProperties)
{
	return this.PropertyOpposite(this.Token(MetaSyntaxKind.KOpposite), oppositeProperties);
}

public PropertySubsetsSyntax PropertySubsets(__SyntaxToken kSubsets, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<QualifierSyntax> subsettedProperties)
{
	if (kSubsets.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(kSubsets));
	if (kSubsets.RawKind != (int)MetaSyntaxKind.KSubsets) throw new __ArgumentException(nameof(kSubsets));
    return (PropertySubsetsSyntax)MetaLanguage.Instance.InternalSyntaxFactory.PropertySubsets((__InternalSyntaxToken)kSubsets.Node, __GreenNodeExtensions.ToGreenSeparatedList<InternalSyntax.QualifierGreen>(subsettedProperties.Node, reversed: false)).CreateRed();
}

public PropertySubsetsSyntax PropertySubsets(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<QualifierSyntax> subsettedProperties)
{
	return this.PropertySubsets(this.Token(MetaSyntaxKind.KSubsets), subsettedProperties);
}

public PropertyRedefinesSyntax PropertyRedefines(__SyntaxToken kRedefines, global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<QualifierSyntax> redefinedProperties)
{
	if (kRedefines.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(kRedefines));
	if (kRedefines.RawKind != (int)MetaSyntaxKind.KRedefines) throw new __ArgumentException(nameof(kRedefines));
    return (PropertyRedefinesSyntax)MetaLanguage.Instance.InternalSyntaxFactory.PropertyRedefines((__InternalSyntaxToken)kRedefines.Node, __GreenNodeExtensions.ToGreenSeparatedList<InternalSyntax.QualifierGreen>(redefinedProperties.Node, reversed: false)).CreateRed();
}

public PropertyRedefinesSyntax PropertyRedefines(global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<QualifierSyntax> redefinedProperties)
{
	return this.PropertyRedefines(this.Token(MetaSyntaxKind.KRedefines), redefinedProperties);
}

public PropertyOppositeOppositePropertiesBlockSyntax PropertyOppositeOppositePropertiesBlock(__SyntaxToken tComma, QualifierSyntax oppositeProperties)
{
	if (tComma.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tComma));
	if (tComma.RawKind != (int)MetaSyntaxKind.TComma) throw new __ArgumentException(nameof(tComma));
	if (oppositeProperties is null) throw new __ArgumentNullException(nameof(oppositeProperties));
    return (PropertyOppositeOppositePropertiesBlockSyntax)MetaLanguage.Instance.InternalSyntaxFactory.PropertyOppositeOppositePropertiesBlock((__InternalSyntaxToken)tComma.Node, (InternalSyntax.QualifierGreen)oppositeProperties.Green).CreateRed();
}

public PropertyOppositeOppositePropertiesBlockSyntax PropertyOppositeOppositePropertiesBlock(QualifierSyntax oppositeProperties)
{
	return this.PropertyOppositeOppositePropertiesBlock(this.Token(MetaSyntaxKind.TComma), oppositeProperties);
}

public PropertySubsetsSubsettedPropertiesBlockSyntax PropertySubsetsSubsettedPropertiesBlock(__SyntaxToken tComma, QualifierSyntax subsettedProperties)
{
	if (tComma.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tComma));
	if (tComma.RawKind != (int)MetaSyntaxKind.TComma) throw new __ArgumentException(nameof(tComma));
	if (subsettedProperties is null) throw new __ArgumentNullException(nameof(subsettedProperties));
    return (PropertySubsetsSubsettedPropertiesBlockSyntax)MetaLanguage.Instance.InternalSyntaxFactory.PropertySubsetsSubsettedPropertiesBlock((__InternalSyntaxToken)tComma.Node, (InternalSyntax.QualifierGreen)subsettedProperties.Green).CreateRed();
}

public PropertySubsetsSubsettedPropertiesBlockSyntax PropertySubsetsSubsettedPropertiesBlock(QualifierSyntax subsettedProperties)
{
	return this.PropertySubsetsSubsettedPropertiesBlock(this.Token(MetaSyntaxKind.TComma), subsettedProperties);
}

public PropertyRedefinesRedefinedPropertiesBlockSyntax PropertyRedefinesRedefinedPropertiesBlock(__SyntaxToken tComma, QualifierSyntax redefinedProperties)
{
	if (tComma.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tComma));
	if (tComma.RawKind != (int)MetaSyntaxKind.TComma) throw new __ArgumentException(nameof(tComma));
	if (redefinedProperties is null) throw new __ArgumentNullException(nameof(redefinedProperties));
    return (PropertyRedefinesRedefinedPropertiesBlockSyntax)MetaLanguage.Instance.InternalSyntaxFactory.PropertyRedefinesRedefinedPropertiesBlock((__InternalSyntaxToken)tComma.Node, (InternalSyntax.QualifierGreen)redefinedProperties.Green).CreateRed();
}

public PropertyRedefinesRedefinedPropertiesBlockSyntax PropertyRedefinesRedefinedPropertiesBlock(QualifierSyntax redefinedProperties)
{
	return this.PropertyRedefinesRedefinedPropertiesBlock(this.Token(MetaSyntaxKind.TComma), redefinedProperties);
}

public MetaOperationParameterListBlockSyntax MetaOperationParameterListBlock(__SyntaxToken tComma, MetaParameterSyntax parameters)
{
	if (tComma.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tComma));
	if (tComma.RawKind != (int)MetaSyntaxKind.TComma) throw new __ArgumentException(nameof(tComma));
	if (parameters is null) throw new __ArgumentNullException(nameof(parameters));
    return (MetaOperationParameterListBlockSyntax)MetaLanguage.Instance.InternalSyntaxFactory.MetaOperationParameterListBlock((__InternalSyntaxToken)tComma.Node, (InternalSyntax.MetaParameterGreen)parameters.Green).CreateRed();
}

public MetaOperationParameterListBlockSyntax MetaOperationParameterListBlock(MetaParameterSyntax parameters)
{
	return this.MetaOperationParameterListBlock(this.Token(MetaSyntaxKind.TComma), parameters);
}

public QualifierQualifierBlockSyntax QualifierQualifierBlock(__SyntaxToken tDot, IdentifierSyntax identifier)
{
	if (tDot.RawKind != (int)__InternalSyntaxKind.None) throw new __ArgumentNullException(nameof(tDot));
	if (tDot.RawKind != (int)MetaSyntaxKind.TDot) throw new __ArgumentException(nameof(tDot));
	if (identifier is null) throw new __ArgumentNullException(nameof(identifier));
    return (QualifierQualifierBlockSyntax)MetaLanguage.Instance.InternalSyntaxFactory.QualifierQualifierBlock((__InternalSyntaxToken)tDot.Node, (InternalSyntax.IdentifierGreen)identifier.Green).CreateRed();
}

public QualifierQualifierBlockSyntax QualifierQualifierBlock(IdentifierSyntax identifier)
{
	return this.QualifierQualifierBlock(this.Token(MetaSyntaxKind.TDot), identifier);
}
		
        internal static global::System.Collections.Generic.IEnumerable<__Type> GetNodeTypes()
        {
            return new __Type[] {
typeof(MainSyntax),
typeof(UsingSyntax),
typeof(DeclarationsSyntax),
typeof(MetaModelSyntax),
typeof(MetaConstantSyntax),
typeof(MetaEnumSyntax),
typeof(MetaClassSyntax),
typeof(EnumBodySyntax),
typeof(MetaEnumLiteralSyntax),
typeof(ClassNameAlt1Syntax),
typeof(ClassNameAlt2Syntax),
typeof(BaseClassesSyntax),
typeof(ClassBodySyntax),
typeof(ClassMemberAlt1Syntax),
typeof(ClassMemberAlt2Syntax),
typeof(MetaPropertySyntax),
typeof(PropertyNameAlt1Syntax),
typeof(PropertyNameAlt2Syntax),
typeof(MetaOperationSyntax),
typeof(MetaParameterSyntax),
typeof(TypeReferenceTokensSyntax),
typeof(SimpleTypeReferenceAlt2Syntax),
typeof(MetaArrayTypeSyntax),
typeof(MetaNullableTypeSyntax),
typeof(NameSyntax),
typeof(QualifierSyntax),
typeof(IdentifierSyntax),
typeof(EnumBodyEnumLiteralsBlockSyntax),
typeof(BaseClassesBaseTypesBlockSyntax),
typeof(PropertyOppositeSyntax),
typeof(PropertySubsetsSyntax),
typeof(PropertyRedefinesSyntax),
typeof(PropertyOppositeOppositePropertiesBlockSyntax),
typeof(PropertySubsetsSubsettedPropertiesBlockSyntax),
typeof(PropertyRedefinesRedefinedPropertiesBlockSyntax),
typeof(MetaOperationParameterListBlockSyntax),
typeof(QualifierQualifierBlockSyntax),
};
        }

    }
}	
