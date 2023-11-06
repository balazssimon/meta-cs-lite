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
using MetaDslx.Languages.MetaCompiler.Antlr;
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
                var kNamespace = this.VisitTerminal(context.kNamespace, MetaSyntaxKind.KNamespace);
                QualifierGreen? name = null;
                if (context.nameAntlr1 is not null) name = (QualifierGreen?)this.Visit(context.nameAntlr1) ?? QualifierGreen.__Missing;
                else name = QualifierGreen.__Missing;
                var tSemicolon = this.VisitTerminal(context.tSemicolon, MetaSyntaxKind.TSemicolon);
                var @usingContext = context._usingAntlr1;
                var @usingBuilder = _pool.Allocate<UsingGreen>();
                for (int i = 0; i < @usingContext.Count; ++i)
                {
                    if (@usingContext[i] is not null) @usingBuilder.Add((UsingGreen?)this.Visit(@usingContext[i]) ?? UsingGreen.__Missing);
                    else @usingBuilder.Add(UsingGreen.__Missing);
                }
                var @using = @usingBuilder.ToList();
                _pool.Free(@usingBuilder);
                DeclarationsGreen? declarations = null;
                if (context.declarationsAntlr1 is not null) declarations = (DeclarationsGreen?)this.Visit(context.declarationsAntlr1) ?? DeclarationsGreen.__Missing;
                else declarations = DeclarationsGreen.__Missing;
                var eof = this.VisitTerminal(context.eof, MetaSyntaxKind.Eof);
            	return _factory.Main((InternalSyntaxToken)kNamespace, name, (InternalSyntaxToken)tSemicolon, @using, declarations, (InternalSyntaxToken)eof);
            }
            public override GreenNode? VisitPr_Using(MetaParser.Pr_UsingContext? context)
            {
               	if (context == null) return UsingGreen.__Missing;
                var kUsing = this.VisitTerminal(context.kUsing, MetaSyntaxKind.KUsing);
                QualifierGreen? namespaces = null;
                if (context.namespacesAntlr1 is not null) namespaces = (QualifierGreen?)this.Visit(context.namespacesAntlr1) ?? QualifierGreen.__Missing;
                else namespaces = QualifierGreen.__Missing;
                var tSemicolon = this.VisitTerminal(context.tSemicolon, MetaSyntaxKind.TSemicolon);
            	return _factory.Using((InternalSyntaxToken)kUsing, namespaces, (InternalSyntaxToken)tSemicolon);
            }
            public override GreenNode? VisitPr_Declarations(MetaParser.Pr_DeclarationsContext? context)
            {
               	if (context == null) return DeclarationsGreen.__Missing;
                var declarationsContext = context._declarationsAntlr1;
                var declarationsBuilder = _pool.Allocate<MetaDeclarationGreen>();
                for (int i = 0; i < declarationsContext.Count; ++i)
                {
                    if (declarationsContext[i] is not null) declarationsBuilder.Add((MetaDeclarationGreen?)this.Visit(declarationsContext[i]) ?? MetaDeclarationGreen.__Missing);
                    else declarationsBuilder.Add(MetaDeclarationGreen.__Missing);
                }
                var declarations = declarationsBuilder.ToList();
                _pool.Free(declarationsBuilder);
            	return _factory.Declarations(declarations);
            }
            public override GreenNode? VisitPr_MetaModel(MetaParser.Pr_MetaModelContext? context)
            {
               	if (context == null) return MetaModelGreen.__Missing;
                var kMetamodel = this.VisitTerminal(context.kMetamodel, MetaSyntaxKind.KMetamodel);
                NameGreen? name = null;
                if (context.nameAntlr1 is not null) name = (NameGreen?)this.Visit(context.nameAntlr1) ?? NameGreen.__Missing;
                else name = NameGreen.__Missing;
                var tSemicolon = this.VisitTerminal(context.tSemicolon, MetaSyntaxKind.TSemicolon);
            	return _factory.MetaModel((InternalSyntaxToken)kMetamodel, name, (InternalSyntaxToken)tSemicolon);
            }
            public override GreenNode? VisitPr_MetaConstant(MetaParser.Pr_MetaConstantContext? context)
            {
               	if (context == null) return MetaConstantGreen.__Missing;
                var kConst = this.VisitTerminal(context.kConst, MetaSyntaxKind.KConst);
                TypeReferenceGreen? type = null;
                if (context.typeAntlr1 is not null) type = (TypeReferenceGreen?)this.Visit(context.typeAntlr1) ?? TypeReferenceGreen.__Missing;
                else type = TypeReferenceGreen.__Missing;
                NameGreen? name = null;
                if (context.nameAntlr1 is not null) name = (NameGreen?)this.Visit(context.nameAntlr1) ?? NameGreen.__Missing;
                else name = NameGreen.__Missing;
                var tSemicolon = this.VisitTerminal(context.tSemicolon, MetaSyntaxKind.TSemicolon);
            	return _factory.MetaConstant((InternalSyntaxToken)kConst, type, name, (InternalSyntaxToken)tSemicolon);
            }
            public override GreenNode? VisitPr_MetaEnumType(MetaParser.Pr_MetaEnumTypeContext? context)
            {
               	if (context == null) return MetaEnumTypeGreen.__Missing;
                var kEnum = this.VisitTerminal(context.kEnum, MetaSyntaxKind.KEnum);
                NameGreen? name = null;
                if (context.nameAntlr1 is not null) name = (NameGreen?)this.Visit(context.nameAntlr1) ?? NameGreen.__Missing;
                else name = NameGreen.__Missing;
                EnumBodyGreen? enumBody = null;
                if (context.enumBodyAntlr1 is not null) enumBody = (EnumBodyGreen?)this.Visit(context.enumBodyAntlr1) ?? EnumBodyGreen.__Missing;
                else enumBody = EnumBodyGreen.__Missing;
            	return _factory.MetaEnumType((InternalSyntaxToken)kEnum, name, enumBody);
            }
            public override GreenNode? VisitPr_MetaClass(MetaParser.Pr_MetaClassContext? context)
            {
               	if (context == null) return MetaClassGreen.__Missing;
                var isAbstract = this.VisitTerminal(context.isAbstract);
                var kClass = this.VisitTerminal(context.kClass, MetaSyntaxKind.KClass);
                ClassNameGreen? name = null;
                if (context.nameAntlr1 is not null) name = (ClassNameGreen?)this.Visit(context.nameAntlr1) ?? ClassNameGreen.__Missing;
                else name = ClassNameGreen.__Missing;
                BaseClassesGreen? baseClasses = null;
                if (context.baseClassesAntlr1 is not null) baseClasses = (BaseClassesGreen?)this.Visit(context.baseClassesAntlr1);
                ClassBodyGreen? classBody = null;
                if (context.classBodyAntlr1 is not null) classBody = (ClassBodyGreen?)this.Visit(context.classBodyAntlr1) ?? ClassBodyGreen.__Missing;
                else classBody = ClassBodyGreen.__Missing;
            	return _factory.MetaClass((InternalSyntaxToken)isAbstract, (InternalSyntaxToken)kClass, name, baseClasses, classBody);
            }
            public override GreenNode? VisitPr_EnumBody(MetaParser.Pr_EnumBodyContext? context)
            {
               	if (context == null) return EnumBodyGreen.__Missing;
                var tLBrace = this.VisitTerminal(context.tLBrace, MetaSyntaxKind.TLBrace);
                EnumLiteralsGreen? enumLiterals = null;
                if (context.enumLiteralsAntlr1 is not null) enumLiterals = (EnumLiteralsGreen?)this.Visit(context.enumLiteralsAntlr1);
                var tRBrace = this.VisitTerminal(context.tRBrace, MetaSyntaxKind.TRBrace);
            	return _factory.EnumBody((InternalSyntaxToken)tLBrace, enumLiterals, (InternalSyntaxToken)tRBrace);
            }
            public override GreenNode? VisitPr_EnumLiterals(MetaParser.Pr_EnumLiteralsContext? context)
            {
               	if (context == null) return EnumLiteralsGreen.__Missing;
                var metaEnumLiteralListBuilder = _pool.AllocateSeparated<MetaEnumLiteralGreen>(reversed: false);
                var literalsContext = context.literalsAntlr1;
                if (literalsContext is not null) metaEnumLiteralListBuilder.Add((MetaEnumLiteralGreen?)this.Visit(literalsContext) ?? MetaEnumLiteralGreen.__Missing);
                else metaEnumLiteralListBuilder.Add(MetaEnumLiteralGreen.__Missing);
                var metaEnumLiteralListContext = context._enumLiteralsBlock1Antlr1;
                for (int i = 0; i < metaEnumLiteralListContext.Count; ++i)
                {
                    var itemContext = metaEnumLiteralListContext[i];
                    if (itemContext is not null)
                    {
                        var item = itemContext.literalsAntlr1;
                        var separator = itemContext.tComma;
                        metaEnumLiteralListBuilder.AddSeparator(this.VisitTerminal(separator, MetaSyntaxKind.TComma));
                        if (item is not null) metaEnumLiteralListBuilder.Add((MetaEnumLiteralGreen?)this.Visit(item) ?? MetaEnumLiteralGreen.__Missing);
                        else metaEnumLiteralListBuilder.Add(MetaEnumLiteralGreen.__Missing);
                    }
                }
                var metaEnumLiteralList = metaEnumLiteralListBuilder.ToList();
                _pool.Free(metaEnumLiteralListBuilder);
            	return _factory.EnumLiterals(metaEnumLiteralList);
            }
            public override GreenNode? VisitPr_MetaEnumLiteral(MetaParser.Pr_MetaEnumLiteralContext? context)
            {
               	if (context == null) return MetaEnumLiteralGreen.__Missing;
                NameGreen? name = null;
                if (context.nameAntlr1 is not null) name = (NameGreen?)this.Visit(context.nameAntlr1) ?? NameGreen.__Missing;
                else name = NameGreen.__Missing;
            	return _factory.MetaEnumLiteral(name);
            }
            public override GreenNode? VisitPr_ClassNameAlt1(MetaParser.Pr_ClassNameAlt1Context? context)
            {
               	if (context == null) return ClassNameAlt1Green.__Missing;
                var tIdentifier = this.VisitTerminal(context.tIdentifierAntlr1);
                var tDollar = this.VisitTerminal(context.tDollar, MetaSyntaxKind.TDollar);
                IdentifierGreen? symbolType = null;
                if (context.symbolTypeAntlr1 is not null) symbolType = (IdentifierGreen?)this.Visit(context.symbolTypeAntlr1) ?? IdentifierGreen.__Missing;
                else symbolType = IdentifierGreen.__Missing;
            	return _factory.ClassNameAlt1((InternalSyntaxToken)tIdentifier, (InternalSyntaxToken)tDollar, symbolType);
            }
            public override GreenNode? VisitPr_ClassNameAlt2(MetaParser.Pr_ClassNameAlt2Context? context)
            {
               	if (context == null) return ClassNameAlt2Green.__Missing;
                var tIdentifier = this.VisitTerminal(context.tIdentifierAntlr1, MetaSyntaxKind.TIdentifier);
            	return _factory.ClassNameAlt2((InternalSyntaxToken)tIdentifier);
            }
            public override GreenNode? VisitPr_BaseClasses(MetaParser.Pr_BaseClassesContext? context)
            {
               	if (context == null) return BaseClassesGreen.__Missing;
                BaseClassesBlock1Green? baseClassesBlock1 = null;
                if (context.baseClassesBlock1Antlr1 is not null) baseClassesBlock1 = (BaseClassesBlock1Green?)this.Visit(context.baseClassesBlock1Antlr1) ?? BaseClassesBlock1Green.__Missing;
                else baseClassesBlock1 = BaseClassesBlock1Green.__Missing;
            	return _factory.BaseClasses(baseClassesBlock1);
            }
            public override GreenNode? VisitPr_ClassBody(MetaParser.Pr_ClassBodyContext? context)
            {
               	if (context == null) return ClassBodyGreen.__Missing;
                var tLBrace = this.VisitTerminal(context.tLBrace, MetaSyntaxKind.TLBrace);
                var propertiesContext = context._propertiesAntlr1;
                var propertiesBuilder = _pool.Allocate<MetaPropertyGreen>();
                for (int i = 0; i < propertiesContext.Count; ++i)
                {
                    if (propertiesContext[i] is not null) propertiesBuilder.Add((MetaPropertyGreen?)this.Visit(propertiesContext[i]) ?? MetaPropertyGreen.__Missing);
                    else propertiesBuilder.Add(MetaPropertyGreen.__Missing);
                }
                var properties = propertiesBuilder.ToList();
                _pool.Free(propertiesBuilder);
                var tRBrace = this.VisitTerminal(context.tRBrace, MetaSyntaxKind.TRBrace);
            	return _factory.ClassBody((InternalSyntaxToken)tLBrace, properties, (InternalSyntaxToken)tRBrace);
            }
            public override GreenNode? VisitPr_MetaProperty(MetaParser.Pr_MetaPropertyContext? context)
            {
               	if (context == null) return MetaPropertyGreen.__Missing;
                InternalSyntaxToken? element = null;
                if (context.isContainment is not null) element = (InternalSyntaxToken)this.VisitTerminal(context.isContainment);
                if (context.isDerived is not null) element = (InternalSyntaxToken)this.VisitTerminal(context.isDerived);
                TypeReferenceGreen? type = null;
                if (context.typeAntlr1 is not null) type = (TypeReferenceGreen?)this.Visit(context.typeAntlr1) ?? TypeReferenceGreen.__Missing;
                else type = TypeReferenceGreen.__Missing;
                PropertyNameGreen? name = null;
                if (context.nameAntlr1 is not null) name = (PropertyNameGreen?)this.Visit(context.nameAntlr1) ?? PropertyNameGreen.__Missing;
                else name = PropertyNameGreen.__Missing;
                PropertyOppositeGreen? propertyOpposite = null;
                if (context.propertyOppositeAntlr1 is not null) propertyOpposite = (PropertyOppositeGreen?)this.Visit(context.propertyOppositeAntlr1);
                var tSemicolon = this.VisitTerminal(context.tSemicolon, MetaSyntaxKind.TSemicolon);
            	return _factory.MetaProperty((InternalSyntaxToken)element, type, name, propertyOpposite, (InternalSyntaxToken)tSemicolon);
            }
            public override GreenNode? VisitPr_PropertyNameAlt1(MetaParser.Pr_PropertyNameAlt1Context? context)
            {
               	if (context == null) return PropertyNameAlt1Green.__Missing;
                var tIdentifier = this.VisitTerminal(context.tIdentifierAntlr1);
                var tDollar = this.VisitTerminal(context.tDollar, MetaSyntaxKind.TDollar);
                var symbolProperty = this.VisitTerminal(context.symbolPropertyAntlr1, MetaSyntaxKind.TIdentifier);
            	return _factory.PropertyNameAlt1((InternalSyntaxToken)tIdentifier, (InternalSyntaxToken)tDollar, (InternalSyntaxToken)symbolProperty);
            }
            public override GreenNode? VisitPr_PropertyNameAlt2(MetaParser.Pr_PropertyNameAlt2Context? context)
            {
               	if (context == null) return PropertyNameAlt2Green.__Missing;
                var tIdentifier = this.VisitTerminal(context.tIdentifierAntlr1, MetaSyntaxKind.TIdentifier);
            	return _factory.PropertyNameAlt2((InternalSyntaxToken)tIdentifier);
            }
            public override GreenNode? VisitPr_PropertyOpposite(MetaParser.Pr_PropertyOppositeContext? context)
            {
               	if (context == null) return PropertyOppositeGreen.__Missing;
                var kOpposite = this.VisitTerminal(context.kOpposite, MetaSyntaxKind.KOpposite);
                QualifierGreen? opposite = null;
                if (context.OppositeAntlr1 is not null) opposite = (QualifierGreen?)this.Visit(context.OppositeAntlr1) ?? QualifierGreen.__Missing;
                else opposite = QualifierGreen.__Missing;
            	return _factory.PropertyOpposite((InternalSyntaxToken)kOpposite, opposite);
            }
            public override GreenNode? VisitPr_MetaOperation(MetaParser.Pr_MetaOperationContext? context)
            {
               	if (context == null) return MetaOperationGreen.__Missing;
                TypeReferenceGreen? returnType = null;
                if (context.returnTypeAntlr1 is not null) returnType = (TypeReferenceGreen?)this.Visit(context.returnTypeAntlr1) ?? TypeReferenceGreen.__Missing;
                else returnType = TypeReferenceGreen.__Missing;
                NameGreen? name = null;
                if (context.nameAntlr1 is not null) name = (NameGreen?)this.Visit(context.nameAntlr1) ?? NameGreen.__Missing;
                else name = NameGreen.__Missing;
                var tLParen = this.VisitTerminal(context.tLParen, MetaSyntaxKind.TLParen);
                ParameterListGreen? parameterList = null;
                if (context.parameterListAntlr1 is not null) parameterList = (ParameterListGreen?)this.Visit(context.parameterListAntlr1);
                var tRParen = this.VisitTerminal(context.tRParen, MetaSyntaxKind.TRParen);
            	return _factory.MetaOperation(returnType, name, (InternalSyntaxToken)tLParen, parameterList, (InternalSyntaxToken)tRParen);
            }
            public override GreenNode? VisitPr_ParameterList(MetaParser.Pr_ParameterListContext? context)
            {
               	if (context == null) return ParameterListGreen.__Missing;
                var metaParameterListBuilder = _pool.AllocateSeparated<MetaParameterGreen>(reversed: false);
                var parametersContext = context.parametersAntlr1;
                if (parametersContext is not null) metaParameterListBuilder.Add((MetaParameterGreen?)this.Visit(parametersContext) ?? MetaParameterGreen.__Missing);
                else metaParameterListBuilder.Add(MetaParameterGreen.__Missing);
                var metaParameterListContext = context._parameterListBlock1Antlr1;
                for (int i = 0; i < metaParameterListContext.Count; ++i)
                {
                    var itemContext = metaParameterListContext[i];
                    if (itemContext is not null)
                    {
                        var item = itemContext.parametersAntlr1;
                        var separator = itemContext.tComma;
                        metaParameterListBuilder.AddSeparator(this.VisitTerminal(separator, MetaSyntaxKind.TComma));
                        if (item is not null) metaParameterListBuilder.Add((MetaParameterGreen?)this.Visit(item) ?? MetaParameterGreen.__Missing);
                        else metaParameterListBuilder.Add(MetaParameterGreen.__Missing);
                    }
                }
                var metaParameterList = metaParameterListBuilder.ToList();
                _pool.Free(metaParameterListBuilder);
            	return _factory.ParameterList(metaParameterList);
            }
            public override GreenNode? VisitPr_MetaParameter(MetaParser.Pr_MetaParameterContext? context)
            {
               	if (context == null) return MetaParameterGreen.__Missing;
                TypeReferenceGreen? type = null;
                if (context.typeAntlr1 is not null) type = (TypeReferenceGreen?)this.Visit(context.typeAntlr1) ?? TypeReferenceGreen.__Missing;
                else type = TypeReferenceGreen.__Missing;
                NameGreen? name = null;
                if (context.nameAntlr1 is not null) name = (NameGreen?)this.Visit(context.nameAntlr1) ?? NameGreen.__Missing;
                else name = NameGreen.__Missing;
            	return _factory.MetaParameter(type, name);
            }
            public override GreenNode? VisitPr_MetaArrayType(MetaParser.Pr_MetaArrayTypeContext? context)
            {
               	if (context == null) return MetaArrayTypeGreen.__Missing;
                TypeReferenceGreen? itemType = null;
                if (context.itemTypeAntlr1 is not null) itemType = (TypeReferenceGreen?)this.Visit(context.itemTypeAntlr1) ?? TypeReferenceGreen.__Missing;
                else itemType = TypeReferenceGreen.__Missing;
                var tLBracket = this.VisitTerminal(context.tLBracket, MetaSyntaxKind.TLBracket);
                var tRBracket = this.VisitTerminal(context.tRBracket, MetaSyntaxKind.TRBracket);
            	return _factory.MetaArrayType(itemType, (InternalSyntaxToken)tLBracket, (InternalSyntaxToken)tRBracket);
            }
            public override GreenNode? VisitPr_TypeReferenceAlt3(MetaParser.Pr_TypeReferenceAlt3Context? context)
            {
               	if (context == null) return TypeReferenceAlt3Green.__Missing;
                QualifierGreen? qualifier = null;
                if (context.qualifierAntlr1 is not null) qualifier = (QualifierGreen?)this.Visit(context.qualifierAntlr1) ?? QualifierGreen.__Missing;
                else qualifier = QualifierGreen.__Missing;
            	return _factory.TypeReferenceAlt3(qualifier);
            }
            public override GreenNode? VisitPr_TypeReferenceTokens(MetaParser.Pr_TypeReferenceTokensContext? context)
            {
               	if (context == null) return TypeReferenceTokensGreen.__Missing;
                InternalSyntaxToken? tokens = null;
                if (context.kBool is not null) tokens = (InternalSyntaxToken)this.VisitTerminal(context.kBool);
                if (context.kInt is not null) tokens = (InternalSyntaxToken)this.VisitTerminal(context.kInt);
                if (context.kString is not null) tokens = (InternalSyntaxToken)this.VisitTerminal(context.kString);
                if (context.kType is not null) tokens = (InternalSyntaxToken)this.VisitTerminal(context.kType);
                if (context.kVoid is not null) tokens = (InternalSyntaxToken)this.VisitTerminal(context.kVoid);
            	return _factory.TypeReferenceTokens((InternalSyntaxToken)tokens);
            }
            public override GreenNode? VisitPr_Name(MetaParser.Pr_NameContext? context)
            {
               	if (context == null) return NameGreen.__Missing;
                IdentifierGreen? identifier = null;
                if (context.identifierAntlr1 is not null) identifier = (IdentifierGreen?)this.Visit(context.identifierAntlr1) ?? IdentifierGreen.__Missing;
                else identifier = IdentifierGreen.__Missing;
            	return _factory.Name(identifier);
            }
            public override GreenNode? VisitPr_Qualifier(MetaParser.Pr_QualifierContext? context)
            {
               	if (context == null) return QualifierGreen.__Missing;
                var identifierListBuilder = _pool.AllocateSeparated<IdentifierGreen>(reversed: false);
                var identifierContext = context.identifierAntlr1;
                if (identifierContext is not null) identifierListBuilder.Add((IdentifierGreen?)this.Visit(identifierContext) ?? IdentifierGreen.__Missing);
                else identifierListBuilder.Add(IdentifierGreen.__Missing);
                var identifierListContext = context._qualifierBlock1Antlr1;
                for (int i = 0; i < identifierListContext.Count; ++i)
                {
                    var itemContext = identifierListContext[i];
                    if (itemContext is not null)
                    {
                        var item = itemContext.identifierAntlr1;
                        var separator = itemContext.tDot;
                        identifierListBuilder.AddSeparator(this.VisitTerminal(separator, MetaSyntaxKind.TDot));
                        if (item is not null) identifierListBuilder.Add((IdentifierGreen?)this.Visit(item) ?? IdentifierGreen.__Missing);
                        else identifierListBuilder.Add(IdentifierGreen.__Missing);
                    }
                }
                var identifierList = identifierListBuilder.ToList();
                _pool.Free(identifierListBuilder);
            	return _factory.Qualifier(identifierList);
            }
            public override GreenNode? VisitPr_QualifierList(MetaParser.Pr_QualifierListContext? context)
            {
               	if (context == null) return QualifierListGreen.__Missing;
                var qualifierListBuilder = _pool.AllocateSeparated<QualifierGreen>(reversed: false);
                var qualifierContext = context.qualifierAntlr1;
                if (qualifierContext is not null) qualifierListBuilder.Add((QualifierGreen?)this.Visit(qualifierContext) ?? QualifierGreen.__Missing);
                else qualifierListBuilder.Add(QualifierGreen.__Missing);
                var qualifierListContext = context._qualifierListBlock1Antlr1;
                for (int i = 0; i < qualifierListContext.Count; ++i)
                {
                    var itemContext = qualifierListContext[i];
                    if (itemContext is not null)
                    {
                        var item = itemContext.qualifierAntlr1;
                        var separator = itemContext.tComma;
                        qualifierListBuilder.AddSeparator(this.VisitTerminal(separator, MetaSyntaxKind.TComma));
                        if (item is not null) qualifierListBuilder.Add((QualifierGreen?)this.Visit(item) ?? QualifierGreen.__Missing);
                        else qualifierListBuilder.Add(QualifierGreen.__Missing);
                    }
                }
                var qualifierList = qualifierListBuilder.ToList();
                _pool.Free(qualifierListBuilder);
            	return _factory.QualifierList(qualifierList);
            }
            public override GreenNode? VisitPr_Identifier(MetaParser.Pr_IdentifierContext? context)
            {
               	if (context == null) return IdentifierGreen.__Missing;
                var tIdentifier = this.VisitTerminal(context.tIdentifierAntlr1, MetaSyntaxKind.TIdentifier);
            	return _factory.Identifier((InternalSyntaxToken)tIdentifier);
            }
            public override GreenNode? VisitPr_EnumLiteralsBlock1(MetaParser.Pr_EnumLiteralsBlock1Context? context)
            {
               	if (context == null) return EnumLiteralsBlock1Green.__Missing;
                var tComma = this.VisitTerminal(context.tComma, MetaSyntaxKind.TComma);
                MetaEnumLiteralGreen? literals = null;
                if (context.literalsAntlr1 is not null) literals = (MetaEnumLiteralGreen?)this.Visit(context.literalsAntlr1) ?? MetaEnumLiteralGreen.__Missing;
                else literals = MetaEnumLiteralGreen.__Missing;
            	return _factory.EnumLiteralsBlock1((InternalSyntaxToken)tComma, literals);
            }
            public override GreenNode? VisitPr_BaseClassesBlock1(MetaParser.Pr_BaseClassesBlock1Context? context)
            {
               	if (context == null) return BaseClassesBlock1Green.__Missing;
                var tColon = this.VisitTerminal(context.tColon, MetaSyntaxKind.TColon);
                QualifierListGreen? baseTypes = null;
                if (context.baseTypesAntlr1 is not null) baseTypes = (QualifierListGreen?)this.Visit(context.baseTypesAntlr1) ?? QualifierListGreen.__Missing;
                else baseTypes = QualifierListGreen.__Missing;
            	return _factory.BaseClassesBlock1((InternalSyntaxToken)tColon, baseTypes);
            }
            public override GreenNode? VisitPr_ParameterListBlock1(MetaParser.Pr_ParameterListBlock1Context? context)
            {
               	if (context == null) return ParameterListBlock1Green.__Missing;
                var tComma = this.VisitTerminal(context.tComma, MetaSyntaxKind.TComma);
                MetaParameterGreen? parameters = null;
                if (context.parametersAntlr1 is not null) parameters = (MetaParameterGreen?)this.Visit(context.parametersAntlr1) ?? MetaParameterGreen.__Missing;
                else parameters = MetaParameterGreen.__Missing;
            	return _factory.ParameterListBlock1((InternalSyntaxToken)tComma, parameters);
            }
            public override GreenNode? VisitPr_QualifierBlock1(MetaParser.Pr_QualifierBlock1Context? context)
            {
               	if (context == null) return QualifierBlock1Green.__Missing;
                var tDot = this.VisitTerminal(context.tDot, MetaSyntaxKind.TDot);
                IdentifierGreen? identifier = null;
                if (context.identifierAntlr1 is not null) identifier = (IdentifierGreen?)this.Visit(context.identifierAntlr1) ?? IdentifierGreen.__Missing;
                else identifier = IdentifierGreen.__Missing;
            	return _factory.QualifierBlock1((InternalSyntaxToken)tDot, identifier);
            }
            public override GreenNode? VisitPr_QualifierListBlock1(MetaParser.Pr_QualifierListBlock1Context? context)
            {
               	if (context == null) return QualifierListBlock1Green.__Missing;
                var tComma = this.VisitTerminal(context.tComma, MetaSyntaxKind.TComma);
                QualifierGreen? qualifier = null;
                if (context.qualifierAntlr1 is not null) qualifier = (QualifierGreen?)this.Visit(context.qualifierAntlr1) ?? QualifierGreen.__Missing;
                else qualifier = QualifierGreen.__Missing;
            	return _factory.QualifierListBlock1((InternalSyntaxToken)tComma, qualifier);
            }
        }
    }
}
