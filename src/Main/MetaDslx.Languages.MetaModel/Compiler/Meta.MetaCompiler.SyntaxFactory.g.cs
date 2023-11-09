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
using MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax;

#nullable enable

namespace MetaDslx.Languages.MetaModel.Compiler.Syntax
{

	public class MetaSyntaxFactory : SyntaxFactory
	{
		public MetaSyntaxFactory(InternalSyntaxFactory internalSyntaxFactory) 
			: base(internalSyntaxFactory)
		{
		}
	    
        public override Language Language => MetaLanguage.Instance;

	    public override ParseOptions DefaultParseOptions => MetaParseOptions.Default;

		/// <summary>
		/// Create a new syntax tree from a syntax node.
		/// </summary>
		public MetaSyntaxTree SyntaxTree(SyntaxNode root, MetaParseOptions? options = null, string? path = "", Encoding? encoding = null)
		{
			return MetaSyntaxTree.Create((MetaSyntaxNode)root, IncrementalParseData.Empty, options, path, null, encoding);
		}

		/// <summary>
		/// Produces a syntax tree by parsing the source text.
		/// </summary>
		public MetaSyntaxTree ParseSyntaxTree(
			string text,
			MetaParseOptions options = null,
			string path = "",
			Encoding encoding = null,
			CancellationToken cancellationToken = default(CancellationToken))
		{
			return (MetaSyntaxTree)this.ParseSyntaxTreeCore(SourceText.From(text, encoding), options, path, cancellationToken);
		}

		/// <summary>
		/// Produces a syntax tree by parsing the source text.
		/// </summary>
		public MetaSyntaxTree ParseSyntaxTree(
			SourceText text,
			MetaParseOptions? options = null,
			string path = "",
			CancellationToken cancellationToken = default(CancellationToken))
		{
			return (MetaSyntaxTree)this.ParseSyntaxTreeCore(text, options, path, cancellationToken);
		}

		protected override SyntaxTree ParseSyntaxTreeCore(
			SourceText text,
			ParseOptions? options = null,
			string path = "",
			CancellationToken cancellationToken = default(CancellationToken))
		{
			return MetaSyntaxTree.ParseText(text, (MetaParseOptions?)options, path, cancellationToken);
		}
	
		public override SyntaxTree MakeSyntaxTree(SyntaxNode root, ParseOptions? options = null, string path = "", Encoding? encoding = null)
		{
			return MetaSyntaxTree.Create((MetaSyntaxNode)root, IncrementalParseData.Empty, (MetaParseOptions)options, path, null, encoding);
		}

        /// <summary>
        /// Creates a token corresponding to a syntax kind. This method can be used for token syntax kinds whose text
        /// can be inferred by the kind alone.
        /// </summary>
        /// <param name="kind">A syntax kind value for a token. These have the suffix Token or Keyword.</param>
        /// <returns></returns>
        public virtual SyntaxToken Token(MetaSyntaxKind kind)
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
        public virtual SyntaxToken Token(SyntaxTriviaList leading, MetaSyntaxKind kind, SyntaxTriviaList trailing)
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
        public virtual SyntaxToken Token(SyntaxTriviaList leading, MetaSyntaxKind kind, string text, string valueText, SyntaxTriviaList trailing)
        {
            return this.Token(leading, (int)kind, text, valueText, trailing);
        }

        /// <summary>
        /// Creates a missing token corresponding to syntax kind. A missing token is produced by the parser when an
        /// expected token is not found. A missing token has no text and normally has associated diagnostics.
        /// </summary>
        /// <param name="kind">A syntax kind value for a token. These have the suffix Token or Keyword.</param>
        public virtual SyntaxToken MissingToken(MetaSyntaxKind kind)
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
        public virtual SyntaxToken MissingToken(SyntaxTriviaList leading, MetaSyntaxKind kind, SyntaxTriviaList trailing)
        {
            return this.MissingToken(leading, (int)kind, trailing);
        }


        public SyntaxToken TInteger(string text)
        {
            return new SyntaxToken(MetaLanguage.Instance.InternalSyntaxFactory.TInteger(text));
        }

        public SyntaxToken TInteger(string text, object value)
        {
            return new SyntaxToken(MetaLanguage.Instance.InternalSyntaxFactory.TInteger(text, value));
        }

        public SyntaxToken TDecimal(string text)
        {
            return new SyntaxToken(MetaLanguage.Instance.InternalSyntaxFactory.TDecimal(text));
        }

        public SyntaxToken TDecimal(string text, object value)
        {
            return new SyntaxToken(MetaLanguage.Instance.InternalSyntaxFactory.TDecimal(text, value));
        }

        public SyntaxToken TIdentifier(string text)
        {
            return new SyntaxToken(MetaLanguage.Instance.InternalSyntaxFactory.TIdentifier(text));
        }

        public SyntaxToken TIdentifier(string text, object value)
        {
            return new SyntaxToken(MetaLanguage.Instance.InternalSyntaxFactory.TIdentifier(text, value));
        }

        public SyntaxToken TString(string text)
        {
            return new SyntaxToken(MetaLanguage.Instance.InternalSyntaxFactory.TString(text));
        }

        public SyntaxToken TString(string text, object value)
        {
            return new SyntaxToken(MetaLanguage.Instance.InternalSyntaxFactory.TString(text, value));
        }

        public SyntaxToken TWhitespace(string text)
        {
            return new SyntaxToken(MetaLanguage.Instance.InternalSyntaxFactory.TWhitespace(text));
        }

        public SyntaxToken TWhitespace(string text, object value)
        {
            return new SyntaxToken(MetaLanguage.Instance.InternalSyntaxFactory.TWhitespace(text, value));
        }

        public SyntaxToken TLineEnd(string text)
        {
            return new SyntaxToken(MetaLanguage.Instance.InternalSyntaxFactory.TLineEnd(text));
        }

        public SyntaxToken TLineEnd(string text, object value)
        {
            return new SyntaxToken(MetaLanguage.Instance.InternalSyntaxFactory.TLineEnd(text, value));
        }

        public SyntaxToken TSingleLineComment(string text)
        {
            return new SyntaxToken(MetaLanguage.Instance.InternalSyntaxFactory.TSingleLineComment(text));
        }

        public SyntaxToken TSingleLineComment(string text, object value)
        {
            return new SyntaxToken(MetaLanguage.Instance.InternalSyntaxFactory.TSingleLineComment(text, value));
        }

        public SyntaxToken TMultiLineComment(string text)
        {
            return new SyntaxToken(MetaLanguage.Instance.InternalSyntaxFactory.TMultiLineComment(text));
        }

        public SyntaxToken TMultiLineComment(string text, object value)
        {
            return new SyntaxToken(MetaLanguage.Instance.InternalSyntaxFactory.TMultiLineComment(text, value));
        }

        public MainSyntax Main(SyntaxToken kNamespace, QualifierSyntax name, SyntaxToken tSemicolon, MetaDslx.CodeAnalysis.SyntaxList<UsingSyntax> @using, DeclarationsSyntax declarations, SyntaxToken eof)
        {
        	if (kNamespace.RawKind != (int)MetaSyntaxKind.KNamespace) throw new ArgumentException(nameof(kNamespace));
        	if (name is null) throw new ArgumentNullException(nameof(name));
        	if (tSemicolon.RawKind != (int)MetaSyntaxKind.TSemicolon) throw new ArgumentException(nameof(tSemicolon));
        	if (declarations is null) throw new ArgumentNullException(nameof(declarations));
        	if (eof.RawKind != (int)MetaSyntaxKind.Eof) throw new ArgumentException(nameof(eof));
            return (MainSyntax)MetaLanguage.Instance.InternalSyntaxFactory.Main((InternalSyntaxToken)kNamespace.Node, (QualifierGreen)name.Green, (InternalSyntaxToken)tSemicolon.Node, @using.Node.ToGreenList<UsingGreen>(), (DeclarationsGreen)declarations.Green, (InternalSyntaxToken)eof.Node).CreateRed();
        }
        
        public MainSyntax Main(QualifierSyntax name, MetaDslx.CodeAnalysis.SyntaxList<UsingSyntax> @using, DeclarationsSyntax declarations)
        {
        	return this.Main(this.Token(MetaSyntaxKind.KNamespace), name, this.Token(MetaSyntaxKind.TSemicolon), @using, declarations, this.Token(MetaSyntaxKind.Eof));
        }

        public UsingSyntax Using(SyntaxToken kUsing, QualifierSyntax namespaces, SyntaxToken tSemicolon)
        {
        	if (kUsing.RawKind != (int)MetaSyntaxKind.KUsing) throw new ArgumentException(nameof(kUsing));
        	if (namespaces is null) throw new ArgumentNullException(nameof(namespaces));
        	if (tSemicolon.RawKind != (int)MetaSyntaxKind.TSemicolon) throw new ArgumentException(nameof(tSemicolon));
            return (UsingSyntax)MetaLanguage.Instance.InternalSyntaxFactory.Using((InternalSyntaxToken)kUsing.Node, (QualifierGreen)namespaces.Green, (InternalSyntaxToken)tSemicolon.Node).CreateRed();
        }
        
        public UsingSyntax Using(QualifierSyntax namespaces)
        {
        	return this.Using(this.Token(MetaSyntaxKind.KUsing), namespaces, this.Token(MetaSyntaxKind.TSemicolon));
        }

        public DeclarationsSyntax Declarations(MetaDslx.CodeAnalysis.SyntaxList<MetaDeclarationSyntax> declarations)
        {
            return (DeclarationsSyntax)MetaLanguage.Instance.InternalSyntaxFactory.Declarations(declarations.Node.ToGreenList<MetaDeclarationGreen>()).CreateRed();
        }

        public MetaModelSyntax MetaModel(SyntaxToken kMetamodel, NameSyntax name, SyntaxToken tSemicolon)
        {
        	if (kMetamodel.RawKind != (int)MetaSyntaxKind.KMetamodel) throw new ArgumentException(nameof(kMetamodel));
        	if (name is null) throw new ArgumentNullException(nameof(name));
        	if (tSemicolon.RawKind != (int)MetaSyntaxKind.TSemicolon) throw new ArgumentException(nameof(tSemicolon));
            return (MetaModelSyntax)MetaLanguage.Instance.InternalSyntaxFactory.MetaModel((InternalSyntaxToken)kMetamodel.Node, (NameGreen)name.Green, (InternalSyntaxToken)tSemicolon.Node).CreateRed();
        }
        
        public MetaModelSyntax MetaModel(NameSyntax name)
        {
        	return this.MetaModel(this.Token(MetaSyntaxKind.KMetamodel), name, this.Token(MetaSyntaxKind.TSemicolon));
        }

        public MetaConstantSyntax MetaConstant(SyntaxToken kConst, TypeReferenceSyntax type, NameSyntax name, SyntaxToken tSemicolon)
        {
        	if (kConst.RawKind != (int)MetaSyntaxKind.KConst) throw new ArgumentException(nameof(kConst));
        	if (type is null) throw new ArgumentNullException(nameof(type));
        	if (name is null) throw new ArgumentNullException(nameof(name));
        	if (tSemicolon.RawKind != (int)MetaSyntaxKind.TSemicolon) throw new ArgumentException(nameof(tSemicolon));
            return (MetaConstantSyntax)MetaLanguage.Instance.InternalSyntaxFactory.MetaConstant((InternalSyntaxToken)kConst.Node, (TypeReferenceGreen)type.Green, (NameGreen)name.Green, (InternalSyntaxToken)tSemicolon.Node).CreateRed();
        }
        
        public MetaConstantSyntax MetaConstant(TypeReferenceSyntax type, NameSyntax name)
        {
        	return this.MetaConstant(this.Token(MetaSyntaxKind.KConst), type, name, this.Token(MetaSyntaxKind.TSemicolon));
        }

        public MetaEnumTypeSyntax MetaEnumType(SyntaxToken kEnum, NameSyntax name, EnumBodySyntax enumBody)
        {
        	if (kEnum.RawKind != (int)MetaSyntaxKind.KEnum) throw new ArgumentException(nameof(kEnum));
        	if (name is null) throw new ArgumentNullException(nameof(name));
        	if (enumBody is null) throw new ArgumentNullException(nameof(enumBody));
            return (MetaEnumTypeSyntax)MetaLanguage.Instance.InternalSyntaxFactory.MetaEnumType((InternalSyntaxToken)kEnum.Node, (NameGreen)name.Green, (EnumBodyGreen)enumBody.Green).CreateRed();
        }
        
        public MetaEnumTypeSyntax MetaEnumType(NameSyntax name, EnumBodySyntax enumBody)
        {
        	return this.MetaEnumType(this.Token(MetaSyntaxKind.KEnum), name, enumBody);
        }

        public MetaClassSyntax MetaClass(SyntaxToken isAbstract, SyntaxToken kClass, ClassNameSyntax name, BaseClassesSyntax baseClasses, ClassBodySyntax classBody)
        {
        	if (isAbstract.RawKind != (int)MetaSyntaxKind.KAbstract) throw new ArgumentException(nameof(isAbstract));
        	if (kClass.RawKind != (int)MetaSyntaxKind.KClass) throw new ArgumentException(nameof(kClass));
        	if (name is null) throw new ArgumentNullException(nameof(name));
        	if (classBody is null) throw new ArgumentNullException(nameof(classBody));
            return (MetaClassSyntax)MetaLanguage.Instance.InternalSyntaxFactory.MetaClass((InternalSyntaxToken)isAbstract.Node, (InternalSyntaxToken)kClass.Node, (ClassNameGreen)name.Green, (BaseClassesGreen?)baseClasses?.Green, (ClassBodyGreen)classBody.Green).CreateRed();
        }
        
        public MetaClassSyntax MetaClass(ClassNameSyntax name, ClassBodySyntax classBody)
        {
        	return this.MetaClass(default, this.Token(MetaSyntaxKind.KClass), name, default, classBody);
        }

        public EnumBodySyntax EnumBody(SyntaxToken tLBrace, EnumLiteralsSyntax enumLiterals, SyntaxToken tRBrace)
        {
        	if (tLBrace.RawKind != (int)MetaSyntaxKind.TLBrace) throw new ArgumentException(nameof(tLBrace));
        	if (tRBrace.RawKind != (int)MetaSyntaxKind.TRBrace) throw new ArgumentException(nameof(tRBrace));
            return (EnumBodySyntax)MetaLanguage.Instance.InternalSyntaxFactory.EnumBody((InternalSyntaxToken)tLBrace.Node, (EnumLiteralsGreen?)enumLiterals?.Green, (InternalSyntaxToken)tRBrace.Node).CreateRed();
        }
        
        public EnumBodySyntax EnumBody()
        {
        	return this.EnumBody(this.Token(MetaSyntaxKind.TLBrace), default, this.Token(MetaSyntaxKind.TRBrace));
        }

        public EnumLiteralsSyntax EnumLiterals(MetaDslx.CodeAnalysis.SeparatedSyntaxList<MetaEnumLiteralSyntax> metaEnumLiteralList)
        {
            return (EnumLiteralsSyntax)MetaLanguage.Instance.InternalSyntaxFactory.EnumLiterals(metaEnumLiteralList.Node.ToGreenSeparatedList<MetaEnumLiteralGreen>(reversed: false)).CreateRed();
        }

        public MetaEnumLiteralSyntax MetaEnumLiteral(NameSyntax name)
        {
        	if (name is null) throw new ArgumentNullException(nameof(name));
            return (MetaEnumLiteralSyntax)MetaLanguage.Instance.InternalSyntaxFactory.MetaEnumLiteral((NameGreen)name.Green).CreateRed();
        }

        public ClassNameAlt1Syntax ClassNameAlt1(SyntaxToken tIdentifier, SyntaxToken tDollar, IdentifierSyntax symbolType)
        {
        	if (tIdentifier.RawKind != (int)MetaSyntaxKind.TIdentifier) throw new ArgumentException(nameof(tIdentifier));
        	if (tDollar.RawKind != (int)MetaSyntaxKind.TDollar) throw new ArgumentException(nameof(tDollar));
        	if (symbolType is null) throw new ArgumentNullException(nameof(symbolType));
            return (ClassNameAlt1Syntax)MetaLanguage.Instance.InternalSyntaxFactory.ClassNameAlt1((InternalSyntaxToken)tIdentifier.Node, (InternalSyntaxToken)tDollar.Node, (IdentifierGreen)symbolType.Green).CreateRed();
        }
        
        public ClassNameAlt1Syntax ClassNameAlt1(IdentifierSyntax symbolType)
        {
        	return this.ClassNameAlt1(default, this.Token(MetaSyntaxKind.TDollar), symbolType);
        }

        public ClassNameAlt2Syntax ClassNameAlt2(SyntaxToken tIdentifier)
        {
        	if (tIdentifier.RawKind != (int)MetaSyntaxKind.TIdentifier) throw new ArgumentException(nameof(tIdentifier));
            return (ClassNameAlt2Syntax)MetaLanguage.Instance.InternalSyntaxFactory.ClassNameAlt2((InternalSyntaxToken)tIdentifier.Node).CreateRed();
        }

        public BaseClassesSyntax BaseClasses(BaseClassesBlock1Syntax baseClassesBlock1)
        {
        	if (baseClassesBlock1 is null) throw new ArgumentNullException(nameof(baseClassesBlock1));
            return (BaseClassesSyntax)MetaLanguage.Instance.InternalSyntaxFactory.BaseClasses((BaseClassesBlock1Green)baseClassesBlock1.Green).CreateRed();
        }

        public ClassBodySyntax ClassBody(SyntaxToken tLBrace, MetaDslx.CodeAnalysis.SyntaxList<ClassMemberSyntax> classMember, SyntaxToken tRBrace)
        {
        	if (tLBrace.RawKind != (int)MetaSyntaxKind.TLBrace) throw new ArgumentException(nameof(tLBrace));
        	if (tRBrace.RawKind != (int)MetaSyntaxKind.TRBrace) throw new ArgumentException(nameof(tRBrace));
            return (ClassBodySyntax)MetaLanguage.Instance.InternalSyntaxFactory.ClassBody((InternalSyntaxToken)tLBrace.Node, classMember.Node.ToGreenList<ClassMemberGreen>(), (InternalSyntaxToken)tRBrace.Node).CreateRed();
        }
        
        public ClassBodySyntax ClassBody(MetaDslx.CodeAnalysis.SyntaxList<ClassMemberSyntax> classMember)
        {
        	return this.ClassBody(this.Token(MetaSyntaxKind.TLBrace), classMember, this.Token(MetaSyntaxKind.TRBrace));
        }

        public ClassMemberAlt1Syntax ClassMemberAlt1(MetaPropertySyntax properties)
        {
        	if (properties is null) throw new ArgumentNullException(nameof(properties));
            return (ClassMemberAlt1Syntax)MetaLanguage.Instance.InternalSyntaxFactory.ClassMemberAlt1((MetaPropertyGreen)properties.Green).CreateRed();
        }

        public ClassMemberAlt2Syntax ClassMemberAlt2(MetaOperationSyntax operations)
        {
        	if (operations is null) throw new ArgumentNullException(nameof(operations));
            return (ClassMemberAlt2Syntax)MetaLanguage.Instance.InternalSyntaxFactory.ClassMemberAlt2((MetaOperationGreen)operations.Green).CreateRed();
        }

        public MetaPropertySyntax MetaProperty(SyntaxToken element, TypeReferenceSyntax type, PropertyNameSyntax name, MetaDslx.CodeAnalysis.SyntaxList<MetaPropertyBlock2Syntax> metaPropertyBlock2, SyntaxToken tSemicolon)
        {
        	if (element.RawKind != (int)MetaSyntaxKind.KContains && element.RawKind != (int)MetaSyntaxKind.KDerived) throw new ArgumentException(nameof(element));
        	if (type is null) throw new ArgumentNullException(nameof(type));
        	if (name is null) throw new ArgumentNullException(nameof(name));
        	if (tSemicolon.RawKind != (int)MetaSyntaxKind.TSemicolon) throw new ArgumentException(nameof(tSemicolon));
            return (MetaPropertySyntax)MetaLanguage.Instance.InternalSyntaxFactory.MetaProperty((InternalSyntaxToken)element.Node, (TypeReferenceGreen)type.Green, (PropertyNameGreen)name.Green, metaPropertyBlock2.Node.ToGreenList<MetaPropertyBlock2Green>(), (InternalSyntaxToken)tSemicolon.Node).CreateRed();
        }
        
        public MetaPropertySyntax MetaProperty(TypeReferenceSyntax type, PropertyNameSyntax name, MetaDslx.CodeAnalysis.SyntaxList<MetaPropertyBlock2Syntax> metaPropertyBlock2)
        {
        	return this.MetaProperty(default, type, name, metaPropertyBlock2, this.Token(MetaSyntaxKind.TSemicolon));
        }

        public PropertyNameAlt1Syntax PropertyNameAlt1(SyntaxToken tIdentifier, SyntaxToken tDollar, SyntaxToken symbolProperty)
        {
        	if (tIdentifier.RawKind != (int)MetaSyntaxKind.TIdentifier) throw new ArgumentException(nameof(tIdentifier));
        	if (tDollar.RawKind != (int)MetaSyntaxKind.TDollar) throw new ArgumentException(nameof(tDollar));
        	if (symbolProperty.RawKind != (int)MetaSyntaxKind.TIdentifier) throw new ArgumentException(nameof(symbolProperty));
            return (PropertyNameAlt1Syntax)MetaLanguage.Instance.InternalSyntaxFactory.PropertyNameAlt1((InternalSyntaxToken)tIdentifier.Node, (InternalSyntaxToken)tDollar.Node, (InternalSyntaxToken)symbolProperty.Node).CreateRed();
        }
        
        public PropertyNameAlt1Syntax PropertyNameAlt1(SyntaxToken symbolProperty)
        {
        	return this.PropertyNameAlt1(default, this.Token(MetaSyntaxKind.TDollar), symbolProperty);
        }

        public PropertyNameAlt2Syntax PropertyNameAlt2(SyntaxToken tIdentifier)
        {
        	if (tIdentifier.RawKind != (int)MetaSyntaxKind.TIdentifier) throw new ArgumentException(nameof(tIdentifier));
            return (PropertyNameAlt2Syntax)MetaLanguage.Instance.InternalSyntaxFactory.PropertyNameAlt2((InternalSyntaxToken)tIdentifier.Node).CreateRed();
        }

        public PropertyOppositeSyntax PropertyOpposite(SyntaxToken kOpposite, MetaDslx.CodeAnalysis.SeparatedSyntaxList<QualifierSyntax> qualifierList)
        {
        	if (kOpposite.RawKind != (int)MetaSyntaxKind.KOpposite) throw new ArgumentException(nameof(kOpposite));
            return (PropertyOppositeSyntax)MetaLanguage.Instance.InternalSyntaxFactory.PropertyOpposite((InternalSyntaxToken)kOpposite.Node, qualifierList.Node.ToGreenSeparatedList<QualifierGreen>(reversed: false)).CreateRed();
        }
        
        public PropertyOppositeSyntax PropertyOpposite(MetaDslx.CodeAnalysis.SeparatedSyntaxList<QualifierSyntax> qualifierList)
        {
        	return this.PropertyOpposite(this.Token(MetaSyntaxKind.KOpposite), qualifierList);
        }

        public PropertySubsetsSyntax PropertySubsets(SyntaxToken kSubsets, MetaDslx.CodeAnalysis.SeparatedSyntaxList<QualifierSyntax> qualifierList)
        {
        	if (kSubsets.RawKind != (int)MetaSyntaxKind.KSubsets) throw new ArgumentException(nameof(kSubsets));
            return (PropertySubsetsSyntax)MetaLanguage.Instance.InternalSyntaxFactory.PropertySubsets((InternalSyntaxToken)kSubsets.Node, qualifierList.Node.ToGreenSeparatedList<QualifierGreen>(reversed: false)).CreateRed();
        }
        
        public PropertySubsetsSyntax PropertySubsets(MetaDslx.CodeAnalysis.SeparatedSyntaxList<QualifierSyntax> qualifierList)
        {
        	return this.PropertySubsets(this.Token(MetaSyntaxKind.KSubsets), qualifierList);
        }

        public PropertyRedefinesSyntax PropertyRedefines(SyntaxToken kRedefines, MetaDslx.CodeAnalysis.SeparatedSyntaxList<QualifierSyntax> qualifierList)
        {
        	if (kRedefines.RawKind != (int)MetaSyntaxKind.KRedefines) throw new ArgumentException(nameof(kRedefines));
            return (PropertyRedefinesSyntax)MetaLanguage.Instance.InternalSyntaxFactory.PropertyRedefines((InternalSyntaxToken)kRedefines.Node, qualifierList.Node.ToGreenSeparatedList<QualifierGreen>(reversed: false)).CreateRed();
        }
        
        public PropertyRedefinesSyntax PropertyRedefines(MetaDslx.CodeAnalysis.SeparatedSyntaxList<QualifierSyntax> qualifierList)
        {
        	return this.PropertyRedefines(this.Token(MetaSyntaxKind.KRedefines), qualifierList);
        }

        public MetaOperationSyntax MetaOperation(TypeReferenceSyntax returnType, NameSyntax name, SyntaxToken tLParen, ParameterListSyntax parameterList, SyntaxToken tRParen, SyntaxToken tSemicolon)
        {
        	if (returnType is null) throw new ArgumentNullException(nameof(returnType));
        	if (name is null) throw new ArgumentNullException(nameof(name));
        	if (tLParen.RawKind != (int)MetaSyntaxKind.TLParen) throw new ArgumentException(nameof(tLParen));
        	if (tRParen.RawKind != (int)MetaSyntaxKind.TRParen) throw new ArgumentException(nameof(tRParen));
        	if (tSemicolon.RawKind != (int)MetaSyntaxKind.TSemicolon) throw new ArgumentException(nameof(tSemicolon));
            return (MetaOperationSyntax)MetaLanguage.Instance.InternalSyntaxFactory.MetaOperation((TypeReferenceGreen)returnType.Green, (NameGreen)name.Green, (InternalSyntaxToken)tLParen.Node, (ParameterListGreen?)parameterList?.Green, (InternalSyntaxToken)tRParen.Node, (InternalSyntaxToken)tSemicolon.Node).CreateRed();
        }
        
        public MetaOperationSyntax MetaOperation(TypeReferenceSyntax returnType, NameSyntax name)
        {
        	return this.MetaOperation(returnType, name, this.Token(MetaSyntaxKind.TLParen), default, this.Token(MetaSyntaxKind.TRParen), this.Token(MetaSyntaxKind.TSemicolon));
        }

        public ParameterListSyntax ParameterList(MetaDslx.CodeAnalysis.SeparatedSyntaxList<MetaParameterSyntax> metaParameterList)
        {
            return (ParameterListSyntax)MetaLanguage.Instance.InternalSyntaxFactory.ParameterList(metaParameterList.Node.ToGreenSeparatedList<MetaParameterGreen>(reversed: false)).CreateRed();
        }

        public MetaParameterSyntax MetaParameter(TypeReferenceSyntax type, NameSyntax name)
        {
        	if (type is null) throw new ArgumentNullException(nameof(type));
        	if (name is null) throw new ArgumentNullException(nameof(name));
            return (MetaParameterSyntax)MetaLanguage.Instance.InternalSyntaxFactory.MetaParameter((TypeReferenceGreen)type.Green, (NameGreen)name.Green).CreateRed();
        }

        public MetaArrayTypeSyntax MetaArrayType(TypeReferenceSyntax itemType, SyntaxToken tLBracket, SyntaxToken tRBracket)
        {
        	if (itemType is null) throw new ArgumentNullException(nameof(itemType));
        	if (tLBracket.RawKind != (int)MetaSyntaxKind.TLBracket) throw new ArgumentException(nameof(tLBracket));
        	if (tRBracket.RawKind != (int)MetaSyntaxKind.TRBracket) throw new ArgumentException(nameof(tRBracket));
            return (MetaArrayTypeSyntax)MetaLanguage.Instance.InternalSyntaxFactory.MetaArrayType((TypeReferenceGreen)itemType.Green, (InternalSyntaxToken)tLBracket.Node, (InternalSyntaxToken)tRBracket.Node).CreateRed();
        }
        
        public MetaArrayTypeSyntax MetaArrayType(TypeReferenceSyntax itemType)
        {
        	return this.MetaArrayType(itemType, this.Token(MetaSyntaxKind.TLBracket), this.Token(MetaSyntaxKind.TRBracket));
        }

        public TypeReferenceAlt3Syntax TypeReferenceAlt3(QualifierSyntax qualifier)
        {
        	if (qualifier is null) throw new ArgumentNullException(nameof(qualifier));
            return (TypeReferenceAlt3Syntax)MetaLanguage.Instance.InternalSyntaxFactory.TypeReferenceAlt3((QualifierGreen)qualifier.Green).CreateRed();
        }

        public TypeReferenceTokensSyntax TypeReferenceTokens(SyntaxToken tokens)
        {
        	if (tokens.RawKind != (int)MetaSyntaxKind.KBool && tokens.RawKind != (int)MetaSyntaxKind.KInt && tokens.RawKind != (int)MetaSyntaxKind.KString && tokens.RawKind != (int)MetaSyntaxKind.KType && tokens.RawKind != (int)MetaSyntaxKind.KSymbol && tokens.RawKind != (int)MetaSyntaxKind.KVoid) throw new ArgumentException(nameof(tokens));
            return (TypeReferenceTokensSyntax)MetaLanguage.Instance.InternalSyntaxFactory.TypeReferenceTokens((InternalSyntaxToken)tokens.Node).CreateRed();
        }

        public NameSyntax Name(IdentifierSyntax identifier)
        {
        	if (identifier is null) throw new ArgumentNullException(nameof(identifier));
            return (NameSyntax)MetaLanguage.Instance.InternalSyntaxFactory.Name((IdentifierGreen)identifier.Green).CreateRed();
        }

        public QualifierSyntax Qualifier(MetaDslx.CodeAnalysis.SeparatedSyntaxList<IdentifierSyntax> identifierList)
        {
            return (QualifierSyntax)MetaLanguage.Instance.InternalSyntaxFactory.Qualifier(identifierList.Node.ToGreenSeparatedList<IdentifierGreen>(reversed: false)).CreateRed();
        }

        public QualifierListSyntax QualifierList(MetaDslx.CodeAnalysis.SeparatedSyntaxList<QualifierSyntax> qualifierList)
        {
            return (QualifierListSyntax)MetaLanguage.Instance.InternalSyntaxFactory.QualifierList(qualifierList.Node.ToGreenSeparatedList<QualifierGreen>(reversed: false)).CreateRed();
        }

        public IdentifierSyntax Identifier(SyntaxToken tIdentifier)
        {
        	if (tIdentifier.RawKind != (int)MetaSyntaxKind.TIdentifier) throw new ArgumentException(nameof(tIdentifier));
            return (IdentifierSyntax)MetaLanguage.Instance.InternalSyntaxFactory.Identifier((InternalSyntaxToken)tIdentifier.Node).CreateRed();
        }

        public EnumLiteralsBlock1Syntax EnumLiteralsBlock1(SyntaxToken tComma, MetaEnumLiteralSyntax literals)
        {
        	if (tComma.RawKind != (int)MetaSyntaxKind.TComma) throw new ArgumentException(nameof(tComma));
        	if (literals is null) throw new ArgumentNullException(nameof(literals));
            return (EnumLiteralsBlock1Syntax)MetaLanguage.Instance.InternalSyntaxFactory.EnumLiteralsBlock1((InternalSyntaxToken)tComma.Node, (MetaEnumLiteralGreen)literals.Green).CreateRed();
        }
        
        public EnumLiteralsBlock1Syntax EnumLiteralsBlock1(MetaEnumLiteralSyntax literals)
        {
        	return this.EnumLiteralsBlock1(this.Token(MetaSyntaxKind.TComma), literals);
        }

        public BaseClassesBlock1Syntax BaseClassesBlock1(SyntaxToken tColon, QualifierListSyntax baseTypes)
        {
        	if (tColon.RawKind != (int)MetaSyntaxKind.TColon) throw new ArgumentException(nameof(tColon));
        	if (baseTypes is null) throw new ArgumentNullException(nameof(baseTypes));
            return (BaseClassesBlock1Syntax)MetaLanguage.Instance.InternalSyntaxFactory.BaseClassesBlock1((InternalSyntaxToken)tColon.Node, (QualifierListGreen)baseTypes.Green).CreateRed();
        }
        
        public BaseClassesBlock1Syntax BaseClassesBlock1(QualifierListSyntax baseTypes)
        {
        	return this.BaseClassesBlock1(this.Token(MetaSyntaxKind.TColon), baseTypes);
        }

        public MetaPropertyBlock2Alt1Syntax MetaPropertyBlock2Alt1(PropertyOppositeSyntax propertyOpposite)
        {
        	if (propertyOpposite is null) throw new ArgumentNullException(nameof(propertyOpposite));
            return (MetaPropertyBlock2Alt1Syntax)MetaLanguage.Instance.InternalSyntaxFactory.MetaPropertyBlock2Alt1((PropertyOppositeGreen)propertyOpposite.Green).CreateRed();
        }

        public MetaPropertyBlock2Alt2Syntax MetaPropertyBlock2Alt2(PropertySubsetsSyntax propertySubsets)
        {
        	if (propertySubsets is null) throw new ArgumentNullException(nameof(propertySubsets));
            return (MetaPropertyBlock2Alt2Syntax)MetaLanguage.Instance.InternalSyntaxFactory.MetaPropertyBlock2Alt2((PropertySubsetsGreen)propertySubsets.Green).CreateRed();
        }

        public MetaPropertyBlock2Alt3Syntax MetaPropertyBlock2Alt3(PropertyRedefinesSyntax propertyRedefines)
        {
        	if (propertyRedefines is null) throw new ArgumentNullException(nameof(propertyRedefines));
            return (MetaPropertyBlock2Alt3Syntax)MetaLanguage.Instance.InternalSyntaxFactory.MetaPropertyBlock2Alt3((PropertyRedefinesGreen)propertyRedefines.Green).CreateRed();
        }

        public PropertyOppositeBlock1Syntax PropertyOppositeBlock1(SyntaxToken tComma, QualifierSyntax oppositeProperties)
        {
        	if (tComma.RawKind != (int)MetaSyntaxKind.TComma) throw new ArgumentException(nameof(tComma));
        	if (oppositeProperties is null) throw new ArgumentNullException(nameof(oppositeProperties));
            return (PropertyOppositeBlock1Syntax)MetaLanguage.Instance.InternalSyntaxFactory.PropertyOppositeBlock1((InternalSyntaxToken)tComma.Node, (QualifierGreen)oppositeProperties.Green).CreateRed();
        }
        
        public PropertyOppositeBlock1Syntax PropertyOppositeBlock1(QualifierSyntax oppositeProperties)
        {
        	return this.PropertyOppositeBlock1(this.Token(MetaSyntaxKind.TComma), oppositeProperties);
        }

        public PropertySubsetsBlock1Syntax PropertySubsetsBlock1(SyntaxToken tComma, QualifierSyntax subsettedProperties)
        {
        	if (tComma.RawKind != (int)MetaSyntaxKind.TComma) throw new ArgumentException(nameof(tComma));
        	if (subsettedProperties is null) throw new ArgumentNullException(nameof(subsettedProperties));
            return (PropertySubsetsBlock1Syntax)MetaLanguage.Instance.InternalSyntaxFactory.PropertySubsetsBlock1((InternalSyntaxToken)tComma.Node, (QualifierGreen)subsettedProperties.Green).CreateRed();
        }
        
        public PropertySubsetsBlock1Syntax PropertySubsetsBlock1(QualifierSyntax subsettedProperties)
        {
        	return this.PropertySubsetsBlock1(this.Token(MetaSyntaxKind.TComma), subsettedProperties);
        }

        public PropertyRedefinesBlock1Syntax PropertyRedefinesBlock1(SyntaxToken tComma, QualifierSyntax redefinedProperties)
        {
        	if (tComma.RawKind != (int)MetaSyntaxKind.TComma) throw new ArgumentException(nameof(tComma));
        	if (redefinedProperties is null) throw new ArgumentNullException(nameof(redefinedProperties));
            return (PropertyRedefinesBlock1Syntax)MetaLanguage.Instance.InternalSyntaxFactory.PropertyRedefinesBlock1((InternalSyntaxToken)tComma.Node, (QualifierGreen)redefinedProperties.Green).CreateRed();
        }
        
        public PropertyRedefinesBlock1Syntax PropertyRedefinesBlock1(QualifierSyntax redefinedProperties)
        {
        	return this.PropertyRedefinesBlock1(this.Token(MetaSyntaxKind.TComma), redefinedProperties);
        }

        public ParameterListBlock1Syntax ParameterListBlock1(SyntaxToken tComma, MetaParameterSyntax parameters)
        {
        	if (tComma.RawKind != (int)MetaSyntaxKind.TComma) throw new ArgumentException(nameof(tComma));
        	if (parameters is null) throw new ArgumentNullException(nameof(parameters));
            return (ParameterListBlock1Syntax)MetaLanguage.Instance.InternalSyntaxFactory.ParameterListBlock1((InternalSyntaxToken)tComma.Node, (MetaParameterGreen)parameters.Green).CreateRed();
        }
        
        public ParameterListBlock1Syntax ParameterListBlock1(MetaParameterSyntax parameters)
        {
        	return this.ParameterListBlock1(this.Token(MetaSyntaxKind.TComma), parameters);
        }

        public QualifierBlock1Syntax QualifierBlock1(SyntaxToken tDot, IdentifierSyntax identifier)
        {
        	if (tDot.RawKind != (int)MetaSyntaxKind.TDot) throw new ArgumentException(nameof(tDot));
        	if (identifier is null) throw new ArgumentNullException(nameof(identifier));
            return (QualifierBlock1Syntax)MetaLanguage.Instance.InternalSyntaxFactory.QualifierBlock1((InternalSyntaxToken)tDot.Node, (IdentifierGreen)identifier.Green).CreateRed();
        }
        
        public QualifierBlock1Syntax QualifierBlock1(IdentifierSyntax identifier)
        {
        	return this.QualifierBlock1(this.Token(MetaSyntaxKind.TDot), identifier);
        }

        public QualifierListBlock1Syntax QualifierListBlock1(SyntaxToken tComma, QualifierSyntax qualifier)
        {
        	if (tComma.RawKind != (int)MetaSyntaxKind.TComma) throw new ArgumentException(nameof(tComma));
        	if (qualifier is null) throw new ArgumentNullException(nameof(qualifier));
            return (QualifierListBlock1Syntax)MetaLanguage.Instance.InternalSyntaxFactory.QualifierListBlock1((InternalSyntaxToken)tComma.Node, (QualifierGreen)qualifier.Green).CreateRed();
        }
        
        public QualifierListBlock1Syntax QualifierListBlock1(QualifierSyntax qualifier)
        {
        	return this.QualifierListBlock1(this.Token(MetaSyntaxKind.TComma), qualifier);
        }
				

        internal static IEnumerable<Type> GetNodeTypes()
        {
            return new Type[] {
		        typeof(MainSyntax),
		        typeof(UsingSyntax),
		        typeof(DeclarationsSyntax),
		        typeof(MetaModelSyntax),
		        typeof(MetaConstantSyntax),
		        typeof(MetaEnumTypeSyntax),
		        typeof(MetaClassSyntax),
		        typeof(EnumBodySyntax),
		        typeof(EnumLiteralsSyntax),
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
		        typeof(PropertyOppositeSyntax),
		        typeof(PropertySubsetsSyntax),
		        typeof(PropertyRedefinesSyntax),
		        typeof(MetaOperationSyntax),
		        typeof(ParameterListSyntax),
		        typeof(MetaParameterSyntax),
		        typeof(MetaArrayTypeSyntax),
		        typeof(TypeReferenceAlt3Syntax),
		        typeof(TypeReferenceTokensSyntax),
		        typeof(NameSyntax),
		        typeof(QualifierSyntax),
		        typeof(QualifierListSyntax),
		        typeof(IdentifierSyntax),
		        typeof(EnumLiteralsBlock1Syntax),
		        typeof(BaseClassesBlock1Syntax),
		        typeof(MetaPropertyBlock2Alt1Syntax),
		        typeof(MetaPropertyBlock2Alt2Syntax),
		        typeof(MetaPropertyBlock2Alt3Syntax),
		        typeof(PropertyOppositeBlock1Syntax),
		        typeof(PropertySubsetsBlock1Syntax),
		        typeof(PropertyRedefinesBlock1Syntax),
		        typeof(ParameterListBlock1Syntax),
		        typeof(QualifierBlock1Syntax),
		        typeof(QualifierListBlock1Syntax),
		    };
        }

    }
}	
