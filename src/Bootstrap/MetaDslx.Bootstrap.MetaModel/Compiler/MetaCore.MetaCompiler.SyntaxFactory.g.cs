using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Syntax;
using MetaDslx.CodeAnalysis.Syntax.InternalSyntax;
using MetaDslx.CodeAnalysis.Text;
using MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.InternalSyntax;

#nullable enable

namespace MetaDslx.Bootstrap.MetaModel.Compiler.Syntax
{

	public class MetaCoreSyntaxFactory : SyntaxFactory
	{
		public MetaCoreSyntaxFactory(InternalSyntaxFactory internalSyntaxFactory) 
			: base(internalSyntaxFactory)
		{
		}
	    
        public override MetaCoreLanguage Language => MetaCoreLanguage.Instance;

	    public override MetaCoreParseOptions DefaultParseOptions => MetaCoreParseOptions.Default;

		/// <summary>
		/// Create a new syntax tree from a syntax node.
		/// </summary>
		public MetaCoreSyntaxTree SyntaxTree(SyntaxNode root, MetaCoreParseOptions? options = null, string? path = "", Encoding? encoding = null)
		{
			return MetaCoreSyntaxTree.Create((MetaCoreSyntaxNode)root, IncrementalParseData.Empty, options, path, null, encoding);
		}

		/// <summary>
		/// Produces a syntax tree by parsing the source text.
		/// </summary>
		public MetaCoreSyntaxTree ParseSyntaxTree(
			string text,
			MetaCoreParseOptions options = null,
			string path = "",
			Encoding encoding = null,
			CancellationToken cancellationToken = default(CancellationToken))
		{
			return (MetaCoreSyntaxTree)this.ParseSyntaxTreeCore(SourceText.From(text, encoding), options, path, cancellationToken);
		}

		/// <summary>
		/// Produces a syntax tree by parsing the source text.
		/// </summary>
		public MetaCoreSyntaxTree ParseSyntaxTree(
			SourceText text,
			MetaCoreParseOptions? options = null,
			string path = "",
			CancellationToken cancellationToken = default(CancellationToken))
		{
			return (MetaCoreSyntaxTree)this.ParseSyntaxTreeCore(text, options, path, cancellationToken);
		}

		protected override SyntaxTree ParseSyntaxTreeCore(
			SourceText text,
			ParseOptions? options = null,
			string path = "",
			CancellationToken cancellationToken = default(CancellationToken))
		{
			return MetaCoreSyntaxTree.ParseText(text, (MetaCoreParseOptions?)options, path, cancellationToken);
		}
	
		public override MetaCoreSyntaxTree MakeSyntaxTree(SyntaxNode root, ParseOptions? options = null, string path = "", Encoding? encoding = null)
		{
			return MetaCoreSyntaxTree.Create((MetaCoreSyntaxNode)root, IncrementalParseData.Empty, (MetaCoreParseOptions)options, path, null, encoding);
		}

        /// <summary>
        /// Creates a token corresponding to a syntax kind. This method can be used for token syntax kinds whose text
        /// can be inferred by the kind alone.
        /// </summary>
        /// <param name="kind">A syntax kind value for a token. These have the suffix Token or Keyword.</param>
        /// <returns></returns>
        public virtual SyntaxToken Token(MetaCoreSyntaxKind kind)
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
        public virtual SyntaxToken Token(SyntaxTriviaList leading, MetaCoreSyntaxKind kind, SyntaxTriviaList trailing)
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
        public virtual SyntaxToken Token(SyntaxTriviaList leading, MetaCoreSyntaxKind kind, string text, string valueText, SyntaxTriviaList trailing)
        {
            return this.Token(leading, (int)kind, text, valueText, trailing);
        }

        /// <summary>
        /// Creates a missing token corresponding to syntax kind. A missing token is produced by the parser when an
        /// expected token is not found. A missing token has no text and normally has associated diagnostics.
        /// </summary>
        /// <param name="kind">A syntax kind value for a token. These have the suffix Token or Keyword.</param>
        public virtual SyntaxToken MissingToken(MetaCoreSyntaxKind kind)
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
        public virtual SyntaxToken MissingToken(SyntaxTriviaList leading, MetaCoreSyntaxKind kind, SyntaxTriviaList trailing)
        {
            return this.MissingToken(leading, (int)kind, trailing);
        }


        public SyntaxToken TInteger(string text)
        {
            return new SyntaxToken(MetaCoreLanguage.Instance.InternalSyntaxFactory.TInteger(text));
        }

        public SyntaxToken TInteger(string text, object value)
        {
            return new SyntaxToken(MetaCoreLanguage.Instance.InternalSyntaxFactory.TInteger(text, value));
        }

        public SyntaxToken TDecimal(string text)
        {
            return new SyntaxToken(MetaCoreLanguage.Instance.InternalSyntaxFactory.TDecimal(text));
        }

        public SyntaxToken TDecimal(string text, object value)
        {
            return new SyntaxToken(MetaCoreLanguage.Instance.InternalSyntaxFactory.TDecimal(text, value));
        }

        public SyntaxToken TIdentifier(string text)
        {
            return new SyntaxToken(MetaCoreLanguage.Instance.InternalSyntaxFactory.TIdentifier(text));
        }

        public SyntaxToken TIdentifier(string text, object value)
        {
            return new SyntaxToken(MetaCoreLanguage.Instance.InternalSyntaxFactory.TIdentifier(text, value));
        }

        public SyntaxToken TString(string text)
        {
            return new SyntaxToken(MetaCoreLanguage.Instance.InternalSyntaxFactory.TString(text));
        }

        public SyntaxToken TString(string text, object value)
        {
            return new SyntaxToken(MetaCoreLanguage.Instance.InternalSyntaxFactory.TString(text, value));
        }

        public SyntaxToken TWhitespace(string text)
        {
            return new SyntaxToken(MetaCoreLanguage.Instance.InternalSyntaxFactory.TWhitespace(text));
        }

        public SyntaxToken TWhitespace(string text, object value)
        {
            return new SyntaxToken(MetaCoreLanguage.Instance.InternalSyntaxFactory.TWhitespace(text, value));
        }

        public SyntaxToken TLineEnd(string text)
        {
            return new SyntaxToken(MetaCoreLanguage.Instance.InternalSyntaxFactory.TLineEnd(text));
        }

        public SyntaxToken TLineEnd(string text, object value)
        {
            return new SyntaxToken(MetaCoreLanguage.Instance.InternalSyntaxFactory.TLineEnd(text, value));
        }

        public SyntaxToken TSingleLineComment(string text)
        {
            return new SyntaxToken(MetaCoreLanguage.Instance.InternalSyntaxFactory.TSingleLineComment(text));
        }

        public SyntaxToken TSingleLineComment(string text, object value)
        {
            return new SyntaxToken(MetaCoreLanguage.Instance.InternalSyntaxFactory.TSingleLineComment(text, value));
        }

        public SyntaxToken TMultiLineComment(string text)
        {
            return new SyntaxToken(MetaCoreLanguage.Instance.InternalSyntaxFactory.TMultiLineComment(text));
        }

        public SyntaxToken TMultiLineComment(string text, object value)
        {
            return new SyntaxToken(MetaCoreLanguage.Instance.InternalSyntaxFactory.TMultiLineComment(text, value));
        }

        public MainSyntax Main(SyntaxToken kNamespace, QualifierSyntax name, SyntaxToken tSemicolon, MetaDslx.CodeAnalysis.SyntaxList<UsingSyntax> @using, DeclarationsSyntax declarations, SyntaxToken eof)
        {
        	if (kNamespace.RawKind != (int)MetaCoreSyntaxKind.KNamespace) throw new ArgumentException(nameof(kNamespace));
        	if (name is null) throw new ArgumentNullException(nameof(name));
        	if (tSemicolon.RawKind != (int)MetaCoreSyntaxKind.TSemicolon) throw new ArgumentException(nameof(tSemicolon));
        	if (declarations is null) throw new ArgumentNullException(nameof(declarations));
        	if (eof.RawKind != (int)MetaCoreSyntaxKind.Eof) throw new ArgumentException(nameof(eof));
            return (MainSyntax)MetaCoreLanguage.Instance.InternalSyntaxFactory.Main((InternalSyntaxToken)kNamespace.Node, (QualifierGreen)name.Green, (InternalSyntaxToken)tSemicolon.Node, @using.Node.ToGreenList<UsingGreen>(), (DeclarationsGreen)declarations.Green, (InternalSyntaxToken)eof.Node).CreateRed();
        }
        
        public MainSyntax Main(QualifierSyntax name, MetaDslx.CodeAnalysis.SyntaxList<UsingSyntax> @using, DeclarationsSyntax declarations)
        {
        	return this.Main(this.Token(MetaCoreSyntaxKind.KNamespace), name, this.Token(MetaCoreSyntaxKind.TSemicolon), @using, declarations, this.Token(MetaCoreSyntaxKind.Eof));
        }

        public UsingSyntax Using(SyntaxToken kUsing, QualifierSyntax namespaces, SyntaxToken tSemicolon)
        {
        	if (kUsing.RawKind != (int)MetaCoreSyntaxKind.KUsing) throw new ArgumentException(nameof(kUsing));
        	if (namespaces is null) throw new ArgumentNullException(nameof(namespaces));
        	if (tSemicolon.RawKind != (int)MetaCoreSyntaxKind.TSemicolon) throw new ArgumentException(nameof(tSemicolon));
            return (UsingSyntax)MetaCoreLanguage.Instance.InternalSyntaxFactory.Using((InternalSyntaxToken)kUsing.Node, (QualifierGreen)namespaces.Green, (InternalSyntaxToken)tSemicolon.Node).CreateRed();
        }
        
        public UsingSyntax Using(QualifierSyntax namespaces)
        {
        	return this.Using(this.Token(MetaCoreSyntaxKind.KUsing), namespaces, this.Token(MetaCoreSyntaxKind.TSemicolon));
        }

        public DeclarationsSyntax Declarations(MetaDslx.CodeAnalysis.SyntaxList<MetaDeclarationSyntax> declarations)
        {
            return (DeclarationsSyntax)MetaCoreLanguage.Instance.InternalSyntaxFactory.Declarations(declarations.Node.ToGreenList<MetaDeclarationGreen>()).CreateRed();
        }

        public MetaModelSyntax MetaModel(SyntaxToken kMetamodel, NameSyntax name, SyntaxToken tSemicolon)
        {
        	if (kMetamodel.RawKind != (int)MetaCoreSyntaxKind.KMetamodel) throw new ArgumentException(nameof(kMetamodel));
        	if (name is null) throw new ArgumentNullException(nameof(name));
        	if (tSemicolon.RawKind != (int)MetaCoreSyntaxKind.TSemicolon) throw new ArgumentException(nameof(tSemicolon));
            return (MetaModelSyntax)MetaCoreLanguage.Instance.InternalSyntaxFactory.MetaModel((InternalSyntaxToken)kMetamodel.Node, (NameGreen)name.Green, (InternalSyntaxToken)tSemicolon.Node).CreateRed();
        }
        
        public MetaModelSyntax MetaModel(NameSyntax name)
        {
        	return this.MetaModel(this.Token(MetaCoreSyntaxKind.KMetamodel), name, this.Token(MetaCoreSyntaxKind.TSemicolon));
        }

        public MetaEnumTypeSyntax MetaEnumType(SyntaxToken kEnum, NameSyntax name, EnumBodySyntax enumBody)
        {
        	if (kEnum.RawKind != (int)MetaCoreSyntaxKind.KEnum) throw new ArgumentException(nameof(kEnum));
        	if (name is null) throw new ArgumentNullException(nameof(name));
        	if (enumBody is null) throw new ArgumentNullException(nameof(enumBody));
            return (MetaEnumTypeSyntax)MetaCoreLanguage.Instance.InternalSyntaxFactory.MetaEnumType((InternalSyntaxToken)kEnum.Node, (NameGreen)name.Green, (EnumBodyGreen)enumBody.Green).CreateRed();
        }
        
        public MetaEnumTypeSyntax MetaEnumType(NameSyntax name, EnumBodySyntax enumBody)
        {
        	return this.MetaEnumType(this.Token(MetaCoreSyntaxKind.KEnum), name, enumBody);
        }

        public MetaClassSyntax MetaClass(SyntaxToken isAbstract, SyntaxToken kClass, ClassNameSyntax name, BaseClassesSyntax baseClasses, ClassBodySyntax classBody)
        {
        	if (isAbstract.RawKind != (int)MetaCoreSyntaxKind.KAbstract) throw new ArgumentException(nameof(isAbstract));
        	if (kClass.RawKind != (int)MetaCoreSyntaxKind.KClass) throw new ArgumentException(nameof(kClass));
        	if (name is null) throw new ArgumentNullException(nameof(name));
        	if (classBody is null) throw new ArgumentNullException(nameof(classBody));
            return (MetaClassSyntax)MetaCoreLanguage.Instance.InternalSyntaxFactory.MetaClass((InternalSyntaxToken)isAbstract.Node, (InternalSyntaxToken)kClass.Node, (ClassNameGreen)name.Green, (BaseClassesGreen?)baseClasses?.Green, (ClassBodyGreen)classBody.Green).CreateRed();
        }
        
        public MetaClassSyntax MetaClass(ClassNameSyntax name, ClassBodySyntax classBody)
        {
        	return this.MetaClass(default, this.Token(MetaCoreSyntaxKind.KClass), name, default, classBody);
        }

        public EnumBodySyntax EnumBody(SyntaxToken tLBrace, EnumLiteralsSyntax enumLiterals, SyntaxToken tRBrace)
        {
        	if (tLBrace.RawKind != (int)MetaCoreSyntaxKind.TLBrace) throw new ArgumentException(nameof(tLBrace));
        	if (tRBrace.RawKind != (int)MetaCoreSyntaxKind.TRBrace) throw new ArgumentException(nameof(tRBrace));
            return (EnumBodySyntax)MetaCoreLanguage.Instance.InternalSyntaxFactory.EnumBody((InternalSyntaxToken)tLBrace.Node, (EnumLiteralsGreen?)enumLiterals?.Green, (InternalSyntaxToken)tRBrace.Node).CreateRed();
        }
        
        public EnumBodySyntax EnumBody()
        {
        	return this.EnumBody(this.Token(MetaCoreSyntaxKind.TLBrace), default, this.Token(MetaCoreSyntaxKind.TRBrace));
        }

        public EnumLiteralsSyntax EnumLiterals(MetaDslx.CodeAnalysis.SeparatedSyntaxList<MetaEnumLiteralSyntax> metaEnumLiteralList)
        {
            return (EnumLiteralsSyntax)MetaCoreLanguage.Instance.InternalSyntaxFactory.EnumLiterals(metaEnumLiteralList.Node.ToGreenSeparatedList<MetaEnumLiteralGreen>(reversed: false)).CreateRed();
        }

        public MetaEnumLiteralSyntax MetaEnumLiteral(NameSyntax name)
        {
        	if (name is null) throw new ArgumentNullException(nameof(name));
            return (MetaEnumLiteralSyntax)MetaCoreLanguage.Instance.InternalSyntaxFactory.MetaEnumLiteral((NameGreen)name.Green).CreateRed();
        }

        public ClassNameAlt1Syntax ClassNameAlt1(SyntaxToken tIdentifier, SyntaxToken tHash, IdentifierSyntax symbolType)
        {
        	if (tIdentifier.RawKind != (int)MetaCoreSyntaxKind.TIdentifier) throw new ArgumentException(nameof(tIdentifier));
        	if (tHash.RawKind != (int)MetaCoreSyntaxKind.THash) throw new ArgumentException(nameof(tHash));
        	if (symbolType is null) throw new ArgumentNullException(nameof(symbolType));
            return (ClassNameAlt1Syntax)MetaCoreLanguage.Instance.InternalSyntaxFactory.ClassNameAlt1((InternalSyntaxToken)tIdentifier.Node, (InternalSyntaxToken)tHash.Node, (IdentifierGreen)symbolType.Green).CreateRed();
        }
        
        public ClassNameAlt1Syntax ClassNameAlt1(IdentifierSyntax symbolType)
        {
        	return this.ClassNameAlt1(default, this.Token(MetaCoreSyntaxKind.THash), symbolType);
        }

        public ClassNameAlt2Syntax ClassNameAlt2(SyntaxToken tIdentifier)
        {
        	if (tIdentifier.RawKind != (int)MetaCoreSyntaxKind.TIdentifier) throw new ArgumentException(nameof(tIdentifier));
            return (ClassNameAlt2Syntax)MetaCoreLanguage.Instance.InternalSyntaxFactory.ClassNameAlt2((InternalSyntaxToken)tIdentifier.Node).CreateRed();
        }

        public BaseClassesSyntax BaseClasses(BaseClassesBlock1Syntax baseClassesBlock1)
        {
        	if (baseClassesBlock1 is null) throw new ArgumentNullException(nameof(baseClassesBlock1));
            return (BaseClassesSyntax)MetaCoreLanguage.Instance.InternalSyntaxFactory.BaseClasses((BaseClassesBlock1Green)baseClassesBlock1.Green).CreateRed();
        }

        public ClassBodySyntax ClassBody(SyntaxToken tLBrace, MetaDslx.CodeAnalysis.SyntaxList<MetaPropertySyntax> properties, SyntaxToken tRBrace)
        {
        	if (tLBrace.RawKind != (int)MetaCoreSyntaxKind.TLBrace) throw new ArgumentException(nameof(tLBrace));
        	if (tRBrace.RawKind != (int)MetaCoreSyntaxKind.TRBrace) throw new ArgumentException(nameof(tRBrace));
            return (ClassBodySyntax)MetaCoreLanguage.Instance.InternalSyntaxFactory.ClassBody((InternalSyntaxToken)tLBrace.Node, properties.Node.ToGreenList<MetaPropertyGreen>(), (InternalSyntaxToken)tRBrace.Node).CreateRed();
        }
        
        public ClassBodySyntax ClassBody(MetaDslx.CodeAnalysis.SyntaxList<MetaPropertySyntax> properties)
        {
        	return this.ClassBody(this.Token(MetaCoreSyntaxKind.TLBrace), properties, this.Token(MetaCoreSyntaxKind.TRBrace));
        }

        public MetaPropertySyntax MetaProperty(SyntaxToken element, TypeReferenceSyntax type, PropertyNameSyntax name, PropertyOppositeSyntax propertyOpposite, SyntaxToken tSemicolon)
        {
        	if (element.RawKind != (int)MetaCoreSyntaxKind.KContains && element.RawKind != (int)MetaCoreSyntaxKind.KDerived) throw new ArgumentException(nameof(element));
        	if (type is null) throw new ArgumentNullException(nameof(type));
        	if (name is null) throw new ArgumentNullException(nameof(name));
        	if (tSemicolon.RawKind != (int)MetaCoreSyntaxKind.TSemicolon) throw new ArgumentException(nameof(tSemicolon));
            return (MetaPropertySyntax)MetaCoreLanguage.Instance.InternalSyntaxFactory.MetaProperty((InternalSyntaxToken)element.Node, (TypeReferenceGreen)type.Green, (PropertyNameGreen)name.Green, (PropertyOppositeGreen?)propertyOpposite?.Green, (InternalSyntaxToken)tSemicolon.Node).CreateRed();
        }
        
        public MetaPropertySyntax MetaProperty(TypeReferenceSyntax type, PropertyNameSyntax name)
        {
        	return this.MetaProperty(default, type, name, default, this.Token(MetaCoreSyntaxKind.TSemicolon));
        }

        public PropertyNameAlt1Syntax PropertyNameAlt1(SyntaxToken tIdentifier, SyntaxToken tHash, SyntaxToken symbolProperty)
        {
        	if (tIdentifier.RawKind != (int)MetaCoreSyntaxKind.TIdentifier) throw new ArgumentException(nameof(tIdentifier));
        	if (tHash.RawKind != (int)MetaCoreSyntaxKind.THash) throw new ArgumentException(nameof(tHash));
        	if (symbolProperty.RawKind != (int)MetaCoreSyntaxKind.TIdentifier) throw new ArgumentException(nameof(symbolProperty));
            return (PropertyNameAlt1Syntax)MetaCoreLanguage.Instance.InternalSyntaxFactory.PropertyNameAlt1((InternalSyntaxToken)tIdentifier.Node, (InternalSyntaxToken)tHash.Node, (InternalSyntaxToken)symbolProperty.Node).CreateRed();
        }
        
        public PropertyNameAlt1Syntax PropertyNameAlt1(SyntaxToken symbolProperty)
        {
        	return this.PropertyNameAlt1(default, this.Token(MetaCoreSyntaxKind.THash), symbolProperty);
        }

        public PropertyNameAlt2Syntax PropertyNameAlt2(SyntaxToken tIdentifier)
        {
        	if (tIdentifier.RawKind != (int)MetaCoreSyntaxKind.TIdentifier) throw new ArgumentException(nameof(tIdentifier));
            return (PropertyNameAlt2Syntax)MetaCoreLanguage.Instance.InternalSyntaxFactory.PropertyNameAlt2((InternalSyntaxToken)tIdentifier.Node).CreateRed();
        }

        public PropertyOppositeSyntax PropertyOpposite(SyntaxToken kOpposite, QualifierSyntax opposite)
        {
        	if (kOpposite.RawKind != (int)MetaCoreSyntaxKind.KOpposite) throw new ArgumentException(nameof(kOpposite));
        	if (opposite is null) throw new ArgumentNullException(nameof(opposite));
            return (PropertyOppositeSyntax)MetaCoreLanguage.Instance.InternalSyntaxFactory.PropertyOpposite((InternalSyntaxToken)kOpposite.Node, (QualifierGreen)opposite.Green).CreateRed();
        }
        
        public PropertyOppositeSyntax PropertyOpposite(QualifierSyntax opposite)
        {
        	return this.PropertyOpposite(this.Token(MetaCoreSyntaxKind.KOpposite), opposite);
        }

        public MetaArrayTypeSyntax MetaArrayType(TypeReferenceSyntax itemType, SyntaxToken tLBracket, SyntaxToken tRBracket)
        {
        	if (itemType is null) throw new ArgumentNullException(nameof(itemType));
        	if (tLBracket.RawKind != (int)MetaCoreSyntaxKind.TLBracket) throw new ArgumentException(nameof(tLBracket));
        	if (tRBracket.RawKind != (int)MetaCoreSyntaxKind.TRBracket) throw new ArgumentException(nameof(tRBracket));
            return (MetaArrayTypeSyntax)MetaCoreLanguage.Instance.InternalSyntaxFactory.MetaArrayType((TypeReferenceGreen)itemType.Green, (InternalSyntaxToken)tLBracket.Node, (InternalSyntaxToken)tRBracket.Node).CreateRed();
        }
        
        public MetaArrayTypeSyntax MetaArrayType(TypeReferenceSyntax itemType)
        {
        	return this.MetaArrayType(itemType, this.Token(MetaCoreSyntaxKind.TLBracket), this.Token(MetaCoreSyntaxKind.TRBracket));
        }

        public TypeReferenceAlt3Syntax TypeReferenceAlt3(QualifierSyntax qualifier)
        {
        	if (qualifier is null) throw new ArgumentNullException(nameof(qualifier));
            return (TypeReferenceAlt3Syntax)MetaCoreLanguage.Instance.InternalSyntaxFactory.TypeReferenceAlt3((QualifierGreen)qualifier.Green).CreateRed();
        }

        public TypeReferenceTokensSyntax TypeReferenceTokens(SyntaxToken tokens)
        {
        	if (tokens.RawKind != (int)MetaCoreSyntaxKind.KBool && tokens.RawKind != (int)MetaCoreSyntaxKind.KInt && tokens.RawKind != (int)MetaCoreSyntaxKind.KString && tokens.RawKind != (int)MetaCoreSyntaxKind.KType) throw new ArgumentException(nameof(tokens));
            return (TypeReferenceTokensSyntax)MetaCoreLanguage.Instance.InternalSyntaxFactory.TypeReferenceTokens((InternalSyntaxToken)tokens.Node).CreateRed();
        }

        public NameSyntax Name(IdentifierSyntax identifier)
        {
        	if (identifier is null) throw new ArgumentNullException(nameof(identifier));
            return (NameSyntax)MetaCoreLanguage.Instance.InternalSyntaxFactory.Name((IdentifierGreen)identifier.Green).CreateRed();
        }

        public QualifierSyntax Qualifier(MetaDslx.CodeAnalysis.SeparatedSyntaxList<IdentifierSyntax> identifierList)
        {
            return (QualifierSyntax)MetaCoreLanguage.Instance.InternalSyntaxFactory.Qualifier(identifierList.Node.ToGreenSeparatedList<IdentifierGreen>(reversed: false)).CreateRed();
        }

        public QualifierListSyntax QualifierList(MetaDslx.CodeAnalysis.SeparatedSyntaxList<QualifierSyntax> qualifierList)
        {
            return (QualifierListSyntax)MetaCoreLanguage.Instance.InternalSyntaxFactory.QualifierList(qualifierList.Node.ToGreenSeparatedList<QualifierGreen>(reversed: false)).CreateRed();
        }

        public IdentifierSyntax Identifier(SyntaxToken tIdentifier)
        {
        	if (tIdentifier.RawKind != (int)MetaCoreSyntaxKind.TIdentifier) throw new ArgumentException(nameof(tIdentifier));
            return (IdentifierSyntax)MetaCoreLanguage.Instance.InternalSyntaxFactory.Identifier((InternalSyntaxToken)tIdentifier.Node).CreateRed();
        }

        public EnumLiteralsBlock1Syntax EnumLiteralsBlock1(SyntaxToken tComma, MetaEnumLiteralSyntax literals)
        {
        	if (tComma.RawKind != (int)MetaCoreSyntaxKind.TComma) throw new ArgumentException(nameof(tComma));
        	if (literals is null) throw new ArgumentNullException(nameof(literals));
            return (EnumLiteralsBlock1Syntax)MetaCoreLanguage.Instance.InternalSyntaxFactory.EnumLiteralsBlock1((InternalSyntaxToken)tComma.Node, (MetaEnumLiteralGreen)literals.Green).CreateRed();
        }
        
        public EnumLiteralsBlock1Syntax EnumLiteralsBlock1(MetaEnumLiteralSyntax literals)
        {
        	return this.EnumLiteralsBlock1(this.Token(MetaCoreSyntaxKind.TComma), literals);
        }

        public BaseClassesBlock1Syntax BaseClassesBlock1(SyntaxToken tColon, QualifierListSyntax baseTypes)
        {
        	if (tColon.RawKind != (int)MetaCoreSyntaxKind.TColon) throw new ArgumentException(nameof(tColon));
        	if (baseTypes is null) throw new ArgumentNullException(nameof(baseTypes));
            return (BaseClassesBlock1Syntax)MetaCoreLanguage.Instance.InternalSyntaxFactory.BaseClassesBlock1((InternalSyntaxToken)tColon.Node, (QualifierListGreen)baseTypes.Green).CreateRed();
        }
        
        public BaseClassesBlock1Syntax BaseClassesBlock1(QualifierListSyntax baseTypes)
        {
        	return this.BaseClassesBlock1(this.Token(MetaCoreSyntaxKind.TColon), baseTypes);
        }

        public QualifierBlock1Syntax QualifierBlock1(SyntaxToken tDot, IdentifierSyntax identifier)
        {
        	if (tDot.RawKind != (int)MetaCoreSyntaxKind.TDot) throw new ArgumentException(nameof(tDot));
        	if (identifier is null) throw new ArgumentNullException(nameof(identifier));
            return (QualifierBlock1Syntax)MetaCoreLanguage.Instance.InternalSyntaxFactory.QualifierBlock1((InternalSyntaxToken)tDot.Node, (IdentifierGreen)identifier.Green).CreateRed();
        }
        
        public QualifierBlock1Syntax QualifierBlock1(IdentifierSyntax identifier)
        {
        	return this.QualifierBlock1(this.Token(MetaCoreSyntaxKind.TDot), identifier);
        }

        public QualifierListBlock1Syntax QualifierListBlock1(SyntaxToken tComma, QualifierSyntax qualifier)
        {
        	if (tComma.RawKind != (int)MetaCoreSyntaxKind.TComma) throw new ArgumentException(nameof(tComma));
        	if (qualifier is null) throw new ArgumentNullException(nameof(qualifier));
            return (QualifierListBlock1Syntax)MetaCoreLanguage.Instance.InternalSyntaxFactory.QualifierListBlock1((InternalSyntaxToken)tComma.Node, (QualifierGreen)qualifier.Green).CreateRed();
        }
        
        public QualifierListBlock1Syntax QualifierListBlock1(QualifierSyntax qualifier)
        {
        	return this.QualifierListBlock1(this.Token(MetaCoreSyntaxKind.TComma), qualifier);
        }
				

        internal static IEnumerable<Type> GetNodeTypes()
        {
            return new Type[] {
		        typeof(MainSyntax),
		        typeof(UsingSyntax),
		        typeof(DeclarationsSyntax),
		        typeof(MetaModelSyntax),
		        typeof(MetaEnumTypeSyntax),
		        typeof(MetaClassSyntax),
		        typeof(EnumBodySyntax),
		        typeof(EnumLiteralsSyntax),
		        typeof(MetaEnumLiteralSyntax),
		        typeof(ClassNameAlt1Syntax),
		        typeof(ClassNameAlt2Syntax),
		        typeof(BaseClassesSyntax),
		        typeof(ClassBodySyntax),
		        typeof(MetaPropertySyntax),
		        typeof(PropertyNameAlt1Syntax),
		        typeof(PropertyNameAlt2Syntax),
		        typeof(PropertyOppositeSyntax),
		        typeof(MetaArrayTypeSyntax),
		        typeof(TypeReferenceAlt3Syntax),
		        typeof(TypeReferenceTokensSyntax),
		        typeof(NameSyntax),
		        typeof(QualifierSyntax),
		        typeof(QualifierListSyntax),
		        typeof(IdentifierSyntax),
		        typeof(EnumLiteralsBlock1Syntax),
		        typeof(BaseClassesBlock1Syntax),
		        typeof(QualifierBlock1Syntax),
		        typeof(QualifierListBlock1Syntax),
		    };
        }

    }
}	
