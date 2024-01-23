using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Syntax;
using MetaDslx.CodeAnalysis.Syntax.InternalSyntax;
using MetaDslx.CodeAnalysis.Text;
using MetaDslx.CodeAnalysis.Parsers.Antlr;
using MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax;

#nullable enable

namespace MetaDslx.Languages.MetaModel.Compiler.Syntax
{
    public partial class MetaSyntaxParser : AntlrSyntaxParser
    {
        private readonly AntlrToRoslynVisitor _visitor;

        public MetaSyntaxParser(
            MetaSyntaxLexer lexer,
			IncrementalParseData? oldParseData,
            IEnumerable<TextChangeRange> changes,
            CancellationToken cancellationToken = default)
            : base(lexer, oldParseData, changes, cancellationToken)
        {
            _visitor = new AntlrToRoslynVisitor(this);
        }

        protected new MetaParser AntlrParser => (MetaParser)base.AntlrParser;

		protected override SyntaxNode ParseRoot()
		{
            ParserState? state = null;
			GreenNode? green = this.ParseMain(ref state);
			var red = (MetaSyntaxNode)green!.CreateRed();
			return red;
		}

        private GreenNode? ParseMain(ref ParserState? state)
        {
            return _visitor.VisitPr_Main(AntlrParser.pr_Main());
        }

        private class AntlrToRoslynVisitor : MetaParserBaseVisitor<GreenNode?>
        {
			// list pools - allocators for lists that are used to build sequences of nodes. The lists
			// can be reused (hence pooled) since the syntax factory methods don't keep references to
			// them
			private readonly SyntaxListPool _pool = new SyntaxListPool(); // Don't need to reset this.

            private readonly MetaSyntaxParser _parser;
            private readonly AntlrTokenStream _tokenStream;
			private readonly MetaInternalSyntaxFactory _factory;

            public AntlrToRoslynVisitor(MetaSyntaxParser parser)
            {
                _parser = parser;
                _tokenStream = (AntlrTokenStream)_parser.AntlrParser.InputStream;
				_factory = (MetaInternalSyntaxFactory)_parser.Language.InternalSyntaxFactory;
            }

            private GreenNode? VisitTerminal(IToken? token, MetaSyntaxKind kind)
            {
				if (token == null)
				{
					if (kind != MetaSyntaxKind.None) return _tokenStream.ConsumeGreenToken(_factory.MissingToken(kind), _parser);
					else return null;
				}
                var green = _tokenStream.ConsumeGreenToken(token, _parser);
				Debug.Assert(kind == MetaSyntaxKind.None || green.RawKind == (int)kind);
				return green;
            }

            public GreenNode? VisitTerminal(IToken? token)
            {
				return VisitTerminal(token, MetaSyntaxKind.None);
            }

            private GreenNode? VisitTerminal(ITerminalNode? node, MetaSyntaxKind kind)
            {
                if (node?.Symbol == null)
				{
					if (kind != MetaSyntaxKind.None) return _factory.MissingToken(kind);
					else return null;
				}
                var green = _tokenStream.ConsumeGreenToken(node.Symbol, _parser);
				Debug.Assert(kind == MetaSyntaxKind.None || green.RawKind == (int)kind);
				return green;
			}

            public override GreenNode? VisitTerminal(ITerminalNode? node)
            {
                return VisitTerminal(node, MetaSyntaxKind.None);
            }


public override GreenNode? VisitPr_Main(MetaParser.Pr_MainContext? context)
{
   	if (context == null) return MainGreen.__Missing;
    var kNamespace = (InternalSyntaxToken?)this.VisitTerminal(context.e_KNamespace, MetaSyntaxKind.KNamespace);
    QualifierGreen? name = null;
    if (context.e_Name is not null) name = (QualifierGreen?)this.Visit(context.e_Name) ?? QualifierGreen.__Missing;
    else name = QualifierGreen.__Missing;
    var tSemicolon = (InternalSyntaxToken?)this.VisitTerminal(context.e_TSemicolon, MetaSyntaxKind.TSemicolon);
    var e_UsingListContext = context._e_UsingList;
    var usingListBuilder = _pool.Allocate<UsingGreen>();
    for (int i = 0; i < e_UsingListContext.Count; ++i)
    {
        if (e_UsingListContext[i] is not null) usingListBuilder.Add((UsingGreen?)this.Visit(e_UsingListContext[i]) ?? UsingGreen.__Missing);
        else usingListBuilder.Add(UsingGreen.__Missing);
    }
    var usingList = usingListBuilder.ToList();
    _pool.Free(usingListBuilder);
    DeclarationsGreen? declarations = null;
    if (context.e_Declarations is not null) declarations = (DeclarationsGreen?)this.Visit(context.e_Declarations) ?? DeclarationsGreen.__Missing;
    else declarations = DeclarationsGreen.__Missing;
    var endOfFileToken = (InternalSyntaxToken?)this.VisitTerminal(context.e_EndOfFileToken, MetaSyntaxKind.Eof);
	return _factory.Main(kNamespace, name, tSemicolon, usingList, declarations, endOfFileToken);
}

public override GreenNode? VisitPr_Using(MetaParser.Pr_UsingContext? context)
{
   	if (context == null) return UsingGreen.__Missing;
    var kUsing = (InternalSyntaxToken?)this.VisitTerminal(context.e_KUsing, MetaSyntaxKind.KUsing);
    QualifierGreen? namespaces = null;
    if (context.e_Namespaces is not null) namespaces = (QualifierGreen?)this.Visit(context.e_Namespaces) ?? QualifierGreen.__Missing;
    else namespaces = QualifierGreen.__Missing;
    var tSemicolon = (InternalSyntaxToken?)this.VisitTerminal(context.e_TSemicolon, MetaSyntaxKind.TSemicolon);
	return _factory.Using(kUsing, namespaces, tSemicolon);
}

public override GreenNode? VisitPr_Declarations(MetaParser.Pr_DeclarationsContext? context)
{
   	if (context == null) return DeclarationsGreen.__Missing;
    var e_DeclarationsContext = context._e_Declarations;
    var declarationsBuilder = _pool.Allocate<MetaDeclarationGreen>();
    for (int i = 0; i < e_DeclarationsContext.Count; ++i)
    {
        if (e_DeclarationsContext[i] is not null) declarationsBuilder.Add((MetaDeclarationGreen?)this.Visit(e_DeclarationsContext[i]) ?? MetaDeclarationGreen.__Missing);
        else declarationsBuilder.Add(MetaDeclarationGreen.__Missing);
    }
    var declarations = declarationsBuilder.ToList();
    _pool.Free(declarationsBuilder);
	return _factory.Declarations(declarations);
}

public override GreenNode? VisitPr_MetaModel(MetaParser.Pr_MetaModelContext? context)
{
   	if (context == null) return MetaModelGreen.__Missing;
    var kMetamodel = (InternalSyntaxToken?)this.VisitTerminal(context.e_KMetamodel, MetaSyntaxKind.KMetamodel);
    NameGreen? name = null;
    if (context.e_Name is not null) name = (NameGreen?)this.Visit(context.e_Name) ?? NameGreen.__Missing;
    else name = NameGreen.__Missing;
    var tSemicolon = (InternalSyntaxToken?)this.VisitTerminal(context.e_TSemicolon, MetaSyntaxKind.TSemicolon);
	return _factory.MetaModel(kMetamodel, name, tSemicolon);
}

public override GreenNode? VisitPr_MetaConstant(MetaParser.Pr_MetaConstantContext? context)
{
   	if (context == null) return MetaConstantGreen.__Missing;
    var kConst = (InternalSyntaxToken?)this.VisitTerminal(context.e_KConst, MetaSyntaxKind.KConst);
    TypeReferenceGreen? type = null;
    if (context.e_Type is not null) type = (TypeReferenceGreen?)this.Visit(context.e_Type) ?? TypeReferenceGreen.__Missing;
    else type = TypeReferenceGreen.__Missing;
    NameGreen? name = null;
    if (context.e_Name1 is not null) name = (NameGreen?)this.Visit(context.e_Name1) ?? NameGreen.__Missing;
    else name = NameGreen.__Missing;
    var tSemicolon = (InternalSyntaxToken?)this.VisitTerminal(context.e_TSemicolon1, MetaSyntaxKind.TSemicolon);
	return _factory.MetaConstant(kConst, type, name, tSemicolon);
}

public override GreenNode? VisitPr_MetaEnum(MetaParser.Pr_MetaEnumContext? context)
{
   	if (context == null) return MetaEnumGreen.__Missing;
    var kEnum = (InternalSyntaxToken?)this.VisitTerminal(context.e_KEnum, MetaSyntaxKind.KEnum);
    NameGreen? name = null;
    if (context.e_Name2 is not null) name = (NameGreen?)this.Visit(context.e_Name2) ?? NameGreen.__Missing;
    else name = NameGreen.__Missing;
    EnumBodyGreen? enumBody = null;
    if (context.e_EnumBody is not null) enumBody = (EnumBodyGreen?)this.Visit(context.e_EnumBody) ?? EnumBodyGreen.__Missing;
    else enumBody = EnumBodyGreen.__Missing;
	return _factory.MetaEnum(kEnum, name, enumBody);
}

public override GreenNode? VisitPr_MetaClass(MetaParser.Pr_MetaClassContext? context)
{
   	if (context == null) return MetaClassGreen.__Missing;
    var isAbstract = (InternalSyntaxToken?)this.VisitTerminal(context.e_IsAbstract);
    var kClass = (InternalSyntaxToken?)this.VisitTerminal(context.e_KClass, MetaSyntaxKind.KClass);
    ClassNameGreen? className = null;
    if (context.e_ClassName is not null) className = (ClassNameGreen?)this.Visit(context.e_ClassName) ?? ClassNameGreen.__Missing;
    else className = ClassNameGreen.__Missing;
    BaseClassesGreen? baseClasses = null;
    if (context.e_BaseClasses is not null) baseClasses = (BaseClassesGreen?)this.Visit(context.e_BaseClasses);
    ClassBodyGreen? classBody = null;
    if (context.e_ClassBody is not null) classBody = (ClassBodyGreen?)this.Visit(context.e_ClassBody) ?? ClassBodyGreen.__Missing;
    else classBody = ClassBodyGreen.__Missing;
	return _factory.MetaClass(isAbstract, kClass, className, baseClasses, classBody);
}

public override GreenNode? VisitPr_EnumBody(MetaParser.Pr_EnumBodyContext? context)
{
   	if (context == null) return EnumBodyGreen.__Missing;
    var tLBrace = (InternalSyntaxToken?)this.VisitTerminal(context.e_TLBrace, MetaSyntaxKind.TLBrace);
    var enumLiteralsBuilder = _pool.AllocateSeparated<MetaEnumLiteralGreen>(reversed: false);
    var e_Literals1Context = context.e_Literals1;
    if (e_Literals1Context is not null) enumLiteralsBuilder.Add((MetaEnumLiteralGreen?)this.Visit(e_Literals1Context) ?? MetaEnumLiteralGreen.__Missing);
    else enumLiteralsBuilder.Add(MetaEnumLiteralGreen.__Missing);
    var e_Literals2Context = context._e_Literals2;
    var e_TComma1Context = context._e_TComma1;
    for (int i = 0; i < e_Literals2Context.Count; ++i)
    {
        if (i < e_TComma1Context.Count)
        {
            var _separator = e_TComma1Context[i];
            enumLiteralsBuilder.AddSeparator((InternalSyntaxToken?)this.VisitTerminal(_separator, MetaSyntaxKind.TComma));
        }
        else
        {
            enumLiteralsBuilder.AddSeparator((InternalSyntaxToken?)this.VisitTerminal((IToken?)null, MetaSyntaxKind.TComma));
        }
        var _item = e_Literals2Context[i];
        if (_item is not null) enumLiteralsBuilder.Add((MetaEnumLiteralGreen?)this.Visit(_item) ?? MetaEnumLiteralGreen.__Missing);
        else enumLiteralsBuilder.Add(MetaEnumLiteralGreen.__Missing);
    }
    var enumLiterals = enumLiteralsBuilder.ToList();
    _pool.Free(enumLiteralsBuilder);
    var tRBrace = (InternalSyntaxToken?)this.VisitTerminal(context.e_TRBrace, MetaSyntaxKind.TRBrace);
	return _factory.EnumBody(tLBrace, enumLiterals, tRBrace);
}

public override GreenNode? VisitPr_MetaEnumLiteral(MetaParser.Pr_MetaEnumLiteralContext? context)
{
   	if (context == null) return MetaEnumLiteralGreen.__Missing;
    NameGreen? name = null;
    if (context.e_Name is not null) name = (NameGreen?)this.Visit(context.e_Name) ?? NameGreen.__Missing;
    else name = NameGreen.__Missing;
	return _factory.MetaEnumLiteral(name);
}

public override GreenNode? VisitPr_ClassNameAlt1(MetaParser.Pr_ClassNameAlt1Context? context)
{
   	if (context == null) return ClassNameAlt1Green.__Missing;
    IdentifierGreen? identifier = null;
    if (context.e_Identifier is not null) identifier = (IdentifierGreen?)this.Visit(context.e_Identifier);
    var tDollar = (InternalSyntaxToken?)this.VisitTerminal(context.e_TDollar, MetaSyntaxKind.TDollar);
    IdentifierGreen? symbolType = null;
    if (context.e_SymbolType is not null) symbolType = (IdentifierGreen?)this.Visit(context.e_SymbolType) ?? IdentifierGreen.__Missing;
    else symbolType = IdentifierGreen.__Missing;
	return _factory.ClassNameAlt1(identifier, tDollar, symbolType);
}

public override GreenNode? VisitPr_ClassNameAlt2(MetaParser.Pr_ClassNameAlt2Context? context)
{
   	if (context == null) return ClassNameAlt2Green.__Missing;
    IdentifierGreen? identifier = null;
    if (context.e_Identifier1 is not null) identifier = (IdentifierGreen?)this.Visit(context.e_Identifier1) ?? IdentifierGreen.__Missing;
    else identifier = IdentifierGreen.__Missing;
	return _factory.ClassNameAlt2(identifier);
}

public override GreenNode? VisitPr_BaseClasses(MetaParser.Pr_BaseClassesContext? context)
{
   	if (context == null) return BaseClassesGreen.__Missing;
    var tColon = (InternalSyntaxToken?)this.VisitTerminal(context.e_TColon, MetaSyntaxKind.TColon);
    var baseTypesBuilder = _pool.AllocateSeparated<QualifierGreen>(reversed: false);
    var e_BaseTypes1Context = context.e_BaseTypes1;
    if (e_BaseTypes1Context is not null) baseTypesBuilder.Add((QualifierGreen?)this.Visit(e_BaseTypes1Context) ?? QualifierGreen.__Missing);
    else baseTypesBuilder.Add(QualifierGreen.__Missing);
    var e_BaseTypes2Context = context._e_BaseTypes2;
    var e_TComma1Context = context._e_TComma1;
    for (int i = 0; i < e_BaseTypes2Context.Count; ++i)
    {
        if (i < e_TComma1Context.Count)
        {
            var _separator = e_TComma1Context[i];
            baseTypesBuilder.AddSeparator((InternalSyntaxToken?)this.VisitTerminal(_separator, MetaSyntaxKind.TComma));
        }
        else
        {
            baseTypesBuilder.AddSeparator((InternalSyntaxToken?)this.VisitTerminal((IToken?)null, MetaSyntaxKind.TComma));
        }
        var _item = e_BaseTypes2Context[i];
        if (_item is not null) baseTypesBuilder.Add((QualifierGreen?)this.Visit(_item) ?? QualifierGreen.__Missing);
        else baseTypesBuilder.Add(QualifierGreen.__Missing);
    }
    var baseTypes = baseTypesBuilder.ToList();
    _pool.Free(baseTypesBuilder);
	return _factory.BaseClasses(tColon, baseTypes);
}

public override GreenNode? VisitPr_ClassBody(MetaParser.Pr_ClassBodyContext? context)
{
   	if (context == null) return ClassBodyGreen.__Missing;
    var tLBrace = (InternalSyntaxToken?)this.VisitTerminal(context.e_TLBrace, MetaSyntaxKind.TLBrace);
    var e_ClassMemberListContext = context._e_ClassMemberList;
    var classMemberListBuilder = _pool.Allocate<ClassMemberGreen>();
    for (int i = 0; i < e_ClassMemberListContext.Count; ++i)
    {
        if (e_ClassMemberListContext[i] is not null) classMemberListBuilder.Add((ClassMemberGreen?)this.Visit(e_ClassMemberListContext[i]) ?? ClassMemberGreen.__Missing);
        else classMemberListBuilder.Add(ClassMemberGreen.__Missing);
    }
    var classMemberList = classMemberListBuilder.ToList();
    _pool.Free(classMemberListBuilder);
    var tRBrace = (InternalSyntaxToken?)this.VisitTerminal(context.e_TRBrace, MetaSyntaxKind.TRBrace);
	return _factory.ClassBody(tLBrace, classMemberList, tRBrace);
}

public override GreenNode? VisitPr_ClassMemberAlt1(MetaParser.Pr_ClassMemberAlt1Context? context)
{
   	if (context == null) return ClassMemberAlt1Green.__Missing;
    MetaPropertyGreen? properties = null;
    if (context.e_Properties is not null) properties = (MetaPropertyGreen?)this.Visit(context.e_Properties) ?? MetaPropertyGreen.__Missing;
    else properties = MetaPropertyGreen.__Missing;
	return _factory.ClassMemberAlt1(properties);
}

public override GreenNode? VisitPr_ClassMemberAlt2(MetaParser.Pr_ClassMemberAlt2Context? context)
{
   	if (context == null) return ClassMemberAlt2Green.__Missing;
    MetaOperationGreen? operations = null;
    if (context.e_Operations is not null) operations = (MetaOperationGreen?)this.Visit(context.e_Operations) ?? MetaOperationGreen.__Missing;
    else operations = MetaOperationGreen.__Missing;
	return _factory.ClassMemberAlt2(operations);
}

public override GreenNode? VisitPr_MetaProperty(MetaParser.Pr_MetaPropertyContext? context)
{
   	if (context == null) return MetaPropertyGreen.__Missing;
    InternalSyntaxToken? tokens = null;
    if (context.LR_KContains() is not null) tokens = (InternalSyntaxToken?)this.VisitTerminal(context.LR_KContains());
    if (context.LR_KDerived() is not null) tokens = (InternalSyntaxToken?)this.VisitTerminal(context.LR_KDerived());
    TypeReferenceGreen? type = null;
    if (context.e_Type is not null) type = (TypeReferenceGreen?)this.Visit(context.e_Type) ?? TypeReferenceGreen.__Missing;
    else type = TypeReferenceGreen.__Missing;
    PropertyNameGreen? propertyName = null;
    if (context.e_PropertyName is not null) propertyName = (PropertyNameGreen?)this.Visit(context.e_PropertyName) ?? PropertyNameGreen.__Missing;
    else propertyName = PropertyNameGreen.__Missing;
    var e_BlockContext = context._e_Block;
    var blockBuilder = _pool.Allocate<MetaPropertyBlock1Green>();
    for (int i = 0; i < e_BlockContext.Count; ++i)
    {
        if (e_BlockContext[i] is not null) blockBuilder.Add((MetaPropertyBlock1Green?)this.Visit(e_BlockContext[i]) ?? MetaPropertyBlock1Green.__Missing);
        else blockBuilder.Add(MetaPropertyBlock1Green.__Missing);
    }
    var block = blockBuilder.ToList();
    _pool.Free(blockBuilder);
    var tSemicolon = (InternalSyntaxToken?)this.VisitTerminal(context.e_TSemicolon, MetaSyntaxKind.TSemicolon);
	return _factory.MetaProperty(tokens, type, propertyName, block, tSemicolon);
}

public override GreenNode? VisitPr_PropertyNameAlt1(MetaParser.Pr_PropertyNameAlt1Context? context)
{
   	if (context == null) return PropertyNameAlt1Green.__Missing;
    IdentifierGreen? identifier = null;
    if (context.e_Identifier is not null) identifier = (IdentifierGreen?)this.Visit(context.e_Identifier);
    var tDollar = (InternalSyntaxToken?)this.VisitTerminal(context.e_TDollar, MetaSyntaxKind.TDollar);
    IdentifierGreen? symbolProperty = null;
    if (context.e_SymbolProperty is not null) symbolProperty = (IdentifierGreen?)this.Visit(context.e_SymbolProperty) ?? IdentifierGreen.__Missing;
    else symbolProperty = IdentifierGreen.__Missing;
	return _factory.PropertyNameAlt1(identifier, tDollar, symbolProperty);
}

public override GreenNode? VisitPr_PropertyNameAlt2(MetaParser.Pr_PropertyNameAlt2Context? context)
{
   	if (context == null) return PropertyNameAlt2Green.__Missing;
    IdentifierGreen? identifier = null;
    if (context.e_Identifier1 is not null) identifier = (IdentifierGreen?)this.Visit(context.e_Identifier1) ?? IdentifierGreen.__Missing;
    else identifier = IdentifierGreen.__Missing;
	return _factory.PropertyNameAlt2(identifier);
}

public override GreenNode? VisitPr_MetaOperation(MetaParser.Pr_MetaOperationContext? context)
{
   	if (context == null) return MetaOperationGreen.__Missing;
    TypeReferenceGreen? returnType = null;
    if (context.e_ReturnType is not null) returnType = (TypeReferenceGreen?)this.Visit(context.e_ReturnType) ?? TypeReferenceGreen.__Missing;
    else returnType = TypeReferenceGreen.__Missing;
    NameGreen? name = null;
    if (context.e_Name is not null) name = (NameGreen?)this.Visit(context.e_Name) ?? NameGreen.__Missing;
    else name = NameGreen.__Missing;
    var tLParen = (InternalSyntaxToken?)this.VisitTerminal(context.e_TLParen, MetaSyntaxKind.TLParen);
    var parameterListBuilder = _pool.AllocateSeparated<MetaParameterGreen>(reversed: false);
    var e_Parameters1Context = context.e_Parameters1;
    if (e_Parameters1Context is not null) parameterListBuilder.Add((MetaParameterGreen?)this.Visit(e_Parameters1Context) ?? MetaParameterGreen.__Missing);
    else parameterListBuilder.Add(MetaParameterGreen.__Missing);
    var e_Parameters2Context = context._e_Parameters2;
    var e_TComma1Context = context._e_TComma1;
    for (int i = 0; i < e_Parameters2Context.Count; ++i)
    {
        if (i < e_TComma1Context.Count)
        {
            var _separator = e_TComma1Context[i];
            parameterListBuilder.AddSeparator((InternalSyntaxToken?)this.VisitTerminal(_separator, MetaSyntaxKind.TComma));
        }
        else
        {
            parameterListBuilder.AddSeparator((InternalSyntaxToken?)this.VisitTerminal((IToken?)null, MetaSyntaxKind.TComma));
        }
        var _item = e_Parameters2Context[i];
        if (_item is not null) parameterListBuilder.Add((MetaParameterGreen?)this.Visit(_item) ?? MetaParameterGreen.__Missing);
        else parameterListBuilder.Add(MetaParameterGreen.__Missing);
    }
    var parameterList = parameterListBuilder.ToList();
    _pool.Free(parameterListBuilder);
    var tRParen = (InternalSyntaxToken?)this.VisitTerminal(context.e_TRParen, MetaSyntaxKind.TRParen);
    var tSemicolon = (InternalSyntaxToken?)this.VisitTerminal(context.e_TSemicolon, MetaSyntaxKind.TSemicolon);
	return _factory.MetaOperation(returnType, name, tLParen, parameterList, tRParen, tSemicolon);
}

public override GreenNode? VisitPr_MetaParameter(MetaParser.Pr_MetaParameterContext? context)
{
   	if (context == null) return MetaParameterGreen.__Missing;
    TypeReferenceGreen? type = null;
    if (context.e_Type is not null) type = (TypeReferenceGreen?)this.Visit(context.e_Type) ?? TypeReferenceGreen.__Missing;
    else type = TypeReferenceGreen.__Missing;
    NameGreen? name = null;
    if (context.e_Name is not null) name = (NameGreen?)this.Visit(context.e_Name) ?? NameGreen.__Missing;
    else name = NameGreen.__Missing;
	return _factory.MetaParameter(type, name);
}

public override GreenNode? VisitPr_TypeReferenceTokens(MetaParser.Pr_TypeReferenceTokensContext? context)
{
   	if (context == null) return TypeReferenceTokensGreen.__Missing;
    InternalSyntaxToken? token = null;
    if (context.LR_KBool() is not null) token = (InternalSyntaxToken?)this.VisitTerminal(context.LR_KBool());
    if (context.LR_KInt() is not null) token = (InternalSyntaxToken?)this.VisitTerminal(context.LR_KInt());
    if (context.LR_KString() is not null) token = (InternalSyntaxToken?)this.VisitTerminal(context.LR_KString());
    if (context.LR_KType() is not null) token = (InternalSyntaxToken?)this.VisitTerminal(context.LR_KType());
    if (context.LR_KSymbol() is not null) token = (InternalSyntaxToken?)this.VisitTerminal(context.LR_KSymbol());
    if (context.LR_KObject() is not null) token = (InternalSyntaxToken?)this.VisitTerminal(context.LR_KObject());
    if (context.LR_KVoid() is not null) token = (InternalSyntaxToken?)this.VisitTerminal(context.LR_KVoid());
    if (token is null) token = _factory.None;
	return _factory.TypeReferenceTokens(token);
}

public override GreenNode? VisitPr_SimpleTypeReferenceAlt2(MetaParser.Pr_SimpleTypeReferenceAlt2Context? context)
{
   	if (context == null) return SimpleTypeReferenceAlt2Green.__Missing;
    QualifierGreen? qualifier = null;
    if (context.e_Qualifier is not null) qualifier = (QualifierGreen?)this.Visit(context.e_Qualifier) ?? QualifierGreen.__Missing;
    else qualifier = QualifierGreen.__Missing;
	return _factory.SimpleTypeReferenceAlt2(qualifier);
}

public override GreenNode? VisitPr_MetaArrayType(MetaParser.Pr_MetaArrayTypeContext? context)
{
   	if (context == null) return MetaArrayTypeGreen.__Missing;
    TypeReferenceGreen? itemType = null;
    if (context.e_ItemType is not null) itemType = (TypeReferenceGreen?)this.Visit(context.e_ItemType) ?? TypeReferenceGreen.__Missing;
    else itemType = TypeReferenceGreen.__Missing;
    var tLBracket = (InternalSyntaxToken?)this.VisitTerminal(context.e_TLBracket, MetaSyntaxKind.TLBracket);
    var tRBracket = (InternalSyntaxToken?)this.VisitTerminal(context.e_TRBracket, MetaSyntaxKind.TRBracket);
	return _factory.MetaArrayType(itemType, tLBracket, tRBracket);
}

public override GreenNode? VisitPr_MetaNullableType(MetaParser.Pr_MetaNullableTypeContext? context)
{
   	if (context == null) return MetaNullableTypeGreen.__Missing;
    TypeReferenceGreen? innerType = null;
    if (context.e_InnerType is not null) innerType = (TypeReferenceGreen?)this.Visit(context.e_InnerType) ?? TypeReferenceGreen.__Missing;
    else innerType = TypeReferenceGreen.__Missing;
    var tQuestion = (InternalSyntaxToken?)this.VisitTerminal(context.e_TQuestion, MetaSyntaxKind.TQuestion);
	return _factory.MetaNullableType(innerType, tQuestion);
}

public override GreenNode? VisitPr_Name(MetaParser.Pr_NameContext? context)
{
   	if (context == null) return NameGreen.__Missing;
    IdentifierGreen? identifier = null;
    if (context.e_Identifier is not null) identifier = (IdentifierGreen?)this.Visit(context.e_Identifier) ?? IdentifierGreen.__Missing;
    else identifier = IdentifierGreen.__Missing;
	return _factory.Name(identifier);
}

public override GreenNode? VisitPr_Qualifier(MetaParser.Pr_QualifierContext? context)
{
   	if (context == null) return QualifierGreen.__Missing;
    var qualifierBuilder = _pool.AllocateSeparated<IdentifierGreen>(reversed: false);
    var e_Identifier1Context = context.e_Identifier1;
    if (e_Identifier1Context is not null) qualifierBuilder.Add((IdentifierGreen?)this.Visit(e_Identifier1Context) ?? IdentifierGreen.__Missing);
    else qualifierBuilder.Add(IdentifierGreen.__Missing);
    var e_Identifier2Context = context._e_Identifier2;
    var e_TDot1Context = context._e_TDot1;
    for (int i = 0; i < e_Identifier2Context.Count; ++i)
    {
        if (i < e_TDot1Context.Count)
        {
            var _separator = e_TDot1Context[i];
            qualifierBuilder.AddSeparator((InternalSyntaxToken?)this.VisitTerminal(_separator, MetaSyntaxKind.TDot));
        }
        else
        {
            qualifierBuilder.AddSeparator((InternalSyntaxToken?)this.VisitTerminal((IToken?)null, MetaSyntaxKind.TDot));
        }
        var _item = e_Identifier2Context[i];
        if (_item is not null) qualifierBuilder.Add((IdentifierGreen?)this.Visit(_item) ?? IdentifierGreen.__Missing);
        else qualifierBuilder.Add(IdentifierGreen.__Missing);
    }
    var qualifier = qualifierBuilder.ToList();
    _pool.Free(qualifierBuilder);
	return _factory.Qualifier(qualifier);
}

public override GreenNode? VisitPr_Identifier(MetaParser.Pr_IdentifierContext? context)
{
   	if (context == null) return IdentifierGreen.__Missing;
    InternalSyntaxToken? token = null;
    if (context.LR_TIdentifier() is not null) token = (InternalSyntaxToken?)this.VisitTerminal(context.LR_TIdentifier());
    if (context.LR_TVerbatimIdentifier() is not null) token = (InternalSyntaxToken?)this.VisitTerminal(context.LR_TVerbatimIdentifier());
    if (token is null) token = _factory.None;
	return _factory.Identifier(token);
}

public override GreenNode? VisitPr_EnumBodyEnumLiteralsBlock(MetaParser.Pr_EnumBodyEnumLiteralsBlockContext? context)
{
   	if (context == null) return EnumBodyEnumLiteralsBlockGreen.__Missing;
    var tComma = (InternalSyntaxToken?)this.VisitTerminal(context.e_TComma1, MetaSyntaxKind.TComma);
    MetaEnumLiteralGreen? literals = null;
    if (context.e_Literals2 is not null) literals = (MetaEnumLiteralGreen?)this.Visit(context.e_Literals2) ?? MetaEnumLiteralGreen.__Missing;
    else literals = MetaEnumLiteralGreen.__Missing;
	return _factory.EnumBodyEnumLiteralsBlock(tComma, literals);
}

public override GreenNode? VisitPr_BaseClassesBaseTypesBlock(MetaParser.Pr_BaseClassesBaseTypesBlockContext? context)
{
   	if (context == null) return BaseClassesBaseTypesBlockGreen.__Missing;
    var tComma = (InternalSyntaxToken?)this.VisitTerminal(context.e_TComma1, MetaSyntaxKind.TComma);
    QualifierGreen? baseTypes = null;
    if (context.e_BaseTypes2 is not null) baseTypes = (QualifierGreen?)this.Visit(context.e_BaseTypes2) ?? QualifierGreen.__Missing;
    else baseTypes = QualifierGreen.__Missing;
	return _factory.BaseClassesBaseTypesBlock(tComma, baseTypes);
}

public override GreenNode? VisitPr_PropertyOpposite(MetaParser.Pr_PropertyOppositeContext? context)
{
   	if (context == null) return PropertyOppositeGreen.__Missing;
    var kOpposite = (InternalSyntaxToken?)this.VisitTerminal(context.e_KOpposite, MetaSyntaxKind.KOpposite);
    var oppositePropertiesBuilder = _pool.AllocateSeparated<QualifierGreen>(reversed: false);
    var e_OppositeProperties1Context = context.e_OppositeProperties1;
    if (e_OppositeProperties1Context is not null) oppositePropertiesBuilder.Add((QualifierGreen?)this.Visit(e_OppositeProperties1Context) ?? QualifierGreen.__Missing);
    else oppositePropertiesBuilder.Add(QualifierGreen.__Missing);
    var e_OppositeProperties2Context = context._e_OppositeProperties2;
    var e_TComma1Context = context._e_TComma1;
    for (int i = 0; i < e_OppositeProperties2Context.Count; ++i)
    {
        if (i < e_TComma1Context.Count)
        {
            var _separator = e_TComma1Context[i];
            oppositePropertiesBuilder.AddSeparator((InternalSyntaxToken?)this.VisitTerminal(_separator, MetaSyntaxKind.TComma));
        }
        else
        {
            oppositePropertiesBuilder.AddSeparator((InternalSyntaxToken?)this.VisitTerminal((IToken?)null, MetaSyntaxKind.TComma));
        }
        var _item = e_OppositeProperties2Context[i];
        if (_item is not null) oppositePropertiesBuilder.Add((QualifierGreen?)this.Visit(_item) ?? QualifierGreen.__Missing);
        else oppositePropertiesBuilder.Add(QualifierGreen.__Missing);
    }
    var oppositeProperties = oppositePropertiesBuilder.ToList();
    _pool.Free(oppositePropertiesBuilder);
	return _factory.PropertyOpposite(kOpposite, oppositeProperties);
}

public override GreenNode? VisitPr_PropertySubsets(MetaParser.Pr_PropertySubsetsContext? context)
{
   	if (context == null) return PropertySubsetsGreen.__Missing;
    var kSubsets = (InternalSyntaxToken?)this.VisitTerminal(context.e_KSubsets, MetaSyntaxKind.KSubsets);
    var subsettedPropertiesBuilder = _pool.AllocateSeparated<QualifierGreen>(reversed: false);
    var e_SubsettedProperties1Context = context.e_SubsettedProperties1;
    if (e_SubsettedProperties1Context is not null) subsettedPropertiesBuilder.Add((QualifierGreen?)this.Visit(e_SubsettedProperties1Context) ?? QualifierGreen.__Missing);
    else subsettedPropertiesBuilder.Add(QualifierGreen.__Missing);
    var e_SubsettedProperties2Context = context._e_SubsettedProperties2;
    var e_TComma2Context = context._e_TComma2;
    for (int i = 0; i < e_SubsettedProperties2Context.Count; ++i)
    {
        if (i < e_TComma2Context.Count)
        {
            var _separator = e_TComma2Context[i];
            subsettedPropertiesBuilder.AddSeparator((InternalSyntaxToken?)this.VisitTerminal(_separator, MetaSyntaxKind.TComma));
        }
        else
        {
            subsettedPropertiesBuilder.AddSeparator((InternalSyntaxToken?)this.VisitTerminal((IToken?)null, MetaSyntaxKind.TComma));
        }
        var _item = e_SubsettedProperties2Context[i];
        if (_item is not null) subsettedPropertiesBuilder.Add((QualifierGreen?)this.Visit(_item) ?? QualifierGreen.__Missing);
        else subsettedPropertiesBuilder.Add(QualifierGreen.__Missing);
    }
    var subsettedProperties = subsettedPropertiesBuilder.ToList();
    _pool.Free(subsettedPropertiesBuilder);
	return _factory.PropertySubsets(kSubsets, subsettedProperties);
}

public override GreenNode? VisitPr_PropertyRedefines(MetaParser.Pr_PropertyRedefinesContext? context)
{
   	if (context == null) return PropertyRedefinesGreen.__Missing;
    var kRedefines = (InternalSyntaxToken?)this.VisitTerminal(context.e_KRedefines, MetaSyntaxKind.KRedefines);
    var redefinedPropertiesBuilder = _pool.AllocateSeparated<QualifierGreen>(reversed: false);
    var e_RedefinedProperties1Context = context.e_RedefinedProperties1;
    if (e_RedefinedProperties1Context is not null) redefinedPropertiesBuilder.Add((QualifierGreen?)this.Visit(e_RedefinedProperties1Context) ?? QualifierGreen.__Missing);
    else redefinedPropertiesBuilder.Add(QualifierGreen.__Missing);
    var e_RedefinedProperties2Context = context._e_RedefinedProperties2;
    var e_TComma3Context = context._e_TComma3;
    for (int i = 0; i < e_RedefinedProperties2Context.Count; ++i)
    {
        if (i < e_TComma3Context.Count)
        {
            var _separator = e_TComma3Context[i];
            redefinedPropertiesBuilder.AddSeparator((InternalSyntaxToken?)this.VisitTerminal(_separator, MetaSyntaxKind.TComma));
        }
        else
        {
            redefinedPropertiesBuilder.AddSeparator((InternalSyntaxToken?)this.VisitTerminal((IToken?)null, MetaSyntaxKind.TComma));
        }
        var _item = e_RedefinedProperties2Context[i];
        if (_item is not null) redefinedPropertiesBuilder.Add((QualifierGreen?)this.Visit(_item) ?? QualifierGreen.__Missing);
        else redefinedPropertiesBuilder.Add(QualifierGreen.__Missing);
    }
    var redefinedProperties = redefinedPropertiesBuilder.ToList();
    _pool.Free(redefinedPropertiesBuilder);
	return _factory.PropertyRedefines(kRedefines, redefinedProperties);
}

public override GreenNode? VisitPr_PropertyOppositeOppositePropertiesBlock1(MetaParser.Pr_PropertyOppositeOppositePropertiesBlock1Context? context)
{
   	if (context == null) return PropertyOppositeOppositePropertiesBlockGreen.__Missing;
    var tComma = (InternalSyntaxToken?)this.VisitTerminal(context.e_TComma1, MetaSyntaxKind.TComma);
    QualifierGreen? oppositeProperties = null;
    if (context.e_OppositeProperties2 is not null) oppositeProperties = (QualifierGreen?)this.Visit(context.e_OppositeProperties2) ?? QualifierGreen.__Missing;
    else oppositeProperties = QualifierGreen.__Missing;
	return _factory.PropertyOppositeOppositePropertiesBlock(tComma, oppositeProperties);
}

public override GreenNode? VisitPr_PropertySubsetsSubsettedPropertiesBlock1(MetaParser.Pr_PropertySubsetsSubsettedPropertiesBlock1Context? context)
{
   	if (context == null) return PropertySubsetsSubsettedPropertiesBlockGreen.__Missing;
    var tComma = (InternalSyntaxToken?)this.VisitTerminal(context.e_TComma2, MetaSyntaxKind.TComma);
    QualifierGreen? subsettedProperties = null;
    if (context.e_SubsettedProperties2 is not null) subsettedProperties = (QualifierGreen?)this.Visit(context.e_SubsettedProperties2) ?? QualifierGreen.__Missing;
    else subsettedProperties = QualifierGreen.__Missing;
	return _factory.PropertySubsetsSubsettedPropertiesBlock(tComma, subsettedProperties);
}

public override GreenNode? VisitPr_PropertyRedefinesRedefinedPropertiesBlock1(MetaParser.Pr_PropertyRedefinesRedefinedPropertiesBlock1Context? context)
{
   	if (context == null) return PropertyRedefinesRedefinedPropertiesBlockGreen.__Missing;
    var tComma = (InternalSyntaxToken?)this.VisitTerminal(context.e_TComma3, MetaSyntaxKind.TComma);
    QualifierGreen? redefinedProperties = null;
    if (context.e_RedefinedProperties2 is not null) redefinedProperties = (QualifierGreen?)this.Visit(context.e_RedefinedProperties2) ?? QualifierGreen.__Missing;
    else redefinedProperties = QualifierGreen.__Missing;
	return _factory.PropertyRedefinesRedefinedPropertiesBlock(tComma, redefinedProperties);
}

public override GreenNode? VisitPr_MetaOperationParameterListBlock(MetaParser.Pr_MetaOperationParameterListBlockContext? context)
{
   	if (context == null) return MetaOperationParameterListBlockGreen.__Missing;
    var tComma = (InternalSyntaxToken?)this.VisitTerminal(context.e_TComma1, MetaSyntaxKind.TComma);
    MetaParameterGreen? parameters = null;
    if (context.e_Parameters2 is not null) parameters = (MetaParameterGreen?)this.Visit(context.e_Parameters2) ?? MetaParameterGreen.__Missing;
    else parameters = MetaParameterGreen.__Missing;
	return _factory.MetaOperationParameterListBlock(tComma, parameters);
}

public override GreenNode? VisitPr_QualifierQualifierBlock(MetaParser.Pr_QualifierQualifierBlockContext? context)
{
   	if (context == null) return QualifierQualifierBlockGreen.__Missing;
    var tDot = (InternalSyntaxToken?)this.VisitTerminal(context.e_TDot1, MetaSyntaxKind.TDot);
    IdentifierGreen? identifier = null;
    if (context.e_Identifier2 is not null) identifier = (IdentifierGreen?)this.Visit(context.e_Identifier2) ?? IdentifierGreen.__Missing;
    else identifier = IdentifierGreen.__Missing;
	return _factory.QualifierQualifierBlock(tDot, identifier);
}
}
}
}
