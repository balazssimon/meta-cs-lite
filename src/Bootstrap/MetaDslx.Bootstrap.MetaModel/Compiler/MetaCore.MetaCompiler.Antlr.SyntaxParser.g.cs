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
using MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.InternalSyntax;

#nullable enable

namespace MetaDslx.Bootstrap.MetaModel.Compiler.Syntax
{
    public partial class MetaCoreSyntaxParser : AntlrSyntaxParser
    {
        private readonly AntlrToRoslynVisitor _visitor;

        public MetaCoreSyntaxParser(
            MetaCoreSyntaxLexer lexer,
			IncrementalParseData? oldParseData,
            IEnumerable<TextChangeRange> changes,
            CancellationToken cancellationToken = default)
            : base(lexer, oldParseData, changes, cancellationToken)
        {
            _visitor = new AntlrToRoslynVisitor(this);
        }

        protected new MetaCoreParser AntlrParser => (MetaCoreParser)base.AntlrParser;

		protected override SyntaxNode ParseRoot()
		{
            ParserState? state = null;
			GreenNode? green = this.ParseMain(ref state);
			var red = (MetaCoreSyntaxNode)green!.CreateRed();
			return red;
		}

        private MainGreen? ParseMain(ref ParserState? state)
        {
            return _visitor.VisitPr_Main(AntlrParser.pr_Main());
        }

        private class AntlrToRoslynVisitor : MetaCoreParserBaseVisitor<GreenNode?>
        {
			// list pools - allocators for lists that are used to build sequences of nodes. The lists
			// can be reused (hence pooled) since the syntax factory methods don't keep references to
			// them
			private readonly SyntaxListPool _pool = new SyntaxListPool(); // Don't need to reset this.

            private readonly MetaCoreSyntaxParser _parser;
            private readonly AntlrTokenStream _tokenStream;
			private readonly MetaCoreInternalSyntaxFactory _factory;

            public AntlrToRoslynVisitor(MetaCoreSyntaxParser parser)
            {
                _parser = parser;
                _tokenStream = (AntlrTokenStream)_parser.AntlrParser.InputStream;
				_factory = (MetaCoreInternalSyntaxFactory)_parser.Language.InternalSyntaxFactory;
            }

            private InternalSyntaxToken? VisitTerminal(IToken? token, MetaCoreSyntaxKind kind)
            {
				if (token == null)
				{
					if (kind != MetaCoreSyntaxKind.None) return _tokenStream.ConsumeGreenToken(_factory.MissingToken(kind), _parser);
					else return null;
				}
                var green = _tokenStream.ConsumeGreenToken(token, _parser);
				Debug.Assert(kind == MetaCoreSyntaxKind.None || green.RawKind == (int)kind);
				return green;
            }

            public InternalSyntaxToken? VisitTerminal(IToken? token)
            {
				return VisitTerminal(token, MetaCoreSyntaxKind.None);
            }

            private InternalSyntaxToken? VisitTerminal(ITerminalNode? node, MetaCoreSyntaxKind kind)
            {
                if (node?.Symbol == null)
				{
					if (kind != MetaCoreSyntaxKind.None) return _factory.MissingToken(kind);
					else return null;
				}
                var green = _tokenStream.ConsumeGreenToken(node.Symbol, _parser);
				Debug.Assert(kind == MetaCoreSyntaxKind.None || green.RawKind == (int)kind);
				return green;
			}

            public override InternalSyntaxToken? VisitTerminal(ITerminalNode? node)
            {
                return VisitTerminal(node, MetaCoreSyntaxKind.None);
            }

            public override MainGreen? VisitPr_Main(MetaCoreParser.Pr_MainContext? context)
            {
               	if (context == null) return MainGreen.__Missing;
                var kNamespace = this.VisitTerminal(context.kNamespace, MetaCoreSyntaxKind.KNamespace);
                QualifierGreen? name = null;
                if (context.nameAntlr1 is not null) name = (QualifierGreen?)this.Visit(context.nameAntlr1) ?? QualifierGreen.__Missing;
                else name = QualifierGreen.__Missing;
                var tSemicolon = this.VisitTerminal(context.tSemicolon, MetaCoreSyntaxKind.TSemicolon);
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
                var eof = this.VisitTerminal(context.eof, MetaCoreSyntaxKind.Eof);
            	return _factory.Main(kNamespace, name, tSemicolon, @using, declarations, eof);
            }
            public override UsingGreen? VisitPr_Using(MetaCoreParser.Pr_UsingContext? context)
            {
               	if (context == null) return UsingGreen.__Missing;
                var kUsing = this.VisitTerminal(context.kUsing, MetaCoreSyntaxKind.KUsing);
                QualifierGreen? namespaces = null;
                if (context.namespacesAntlr1 is not null) namespaces = (QualifierGreen?)this.Visit(context.namespacesAntlr1) ?? QualifierGreen.__Missing;
                else namespaces = QualifierGreen.__Missing;
                var tSemicolon = this.VisitTerminal(context.tSemicolon, MetaCoreSyntaxKind.TSemicolon);
            	return _factory.Using(kUsing, namespaces, tSemicolon);
            }
            public override DeclarationsGreen? VisitPr_Declarations(MetaCoreParser.Pr_DeclarationsContext? context)
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
            public override MetaModelGreen? VisitPr_MetaModel(MetaCoreParser.Pr_MetaModelContext? context)
            {
               	if (context == null) return MetaModelGreen.__Missing;
                var kMetamodel = this.VisitTerminal(context.kMetamodel, MetaCoreSyntaxKind.KMetamodel);
                NameGreen? name = null;
                if (context.nameAntlr1 is not null) name = (NameGreen?)this.Visit(context.nameAntlr1) ?? NameGreen.__Missing;
                else name = NameGreen.__Missing;
                var tSemicolon = this.VisitTerminal(context.tSemicolon, MetaCoreSyntaxKind.TSemicolon);
            	return _factory.MetaModel(kMetamodel, name, tSemicolon);
            }
            public override MetaEnumTypeGreen? VisitPr_MetaEnumType(MetaCoreParser.Pr_MetaEnumTypeContext? context)
            {
               	if (context == null) return MetaEnumTypeGreen.__Missing;
                var kEnum = this.VisitTerminal(context.kEnum, MetaCoreSyntaxKind.KEnum);
                NameGreen? name = null;
                if (context.nameAntlr1 is not null) name = (NameGreen?)this.Visit(context.nameAntlr1) ?? NameGreen.__Missing;
                else name = NameGreen.__Missing;
                EnumBodyGreen? enumBody = null;
                if (context.enumBodyAntlr1 is not null) enumBody = (EnumBodyGreen?)this.Visit(context.enumBodyAntlr1) ?? EnumBodyGreen.__Missing;
                else enumBody = EnumBodyGreen.__Missing;
            	return _factory.MetaEnumType(kEnum, name, enumBody);
            }
            public override MetaClassGreen? VisitPr_MetaClass(MetaCoreParser.Pr_MetaClassContext? context)
            {
               	if (context == null) return MetaClassGreen.__Missing;
                var isAbstract = this.VisitTerminal(context.isAbstract);
                var kClass = this.VisitTerminal(context.kClass, MetaCoreSyntaxKind.KClass);
                NameGreen? name = null;
                if (context.nameAntlr1 is not null) name = (NameGreen?)this.Visit(context.nameAntlr1) ?? NameGreen.__Missing;
                else name = NameGreen.__Missing;
                BaseClassesGreen? baseClasses = null;
                if (context.baseClassesAntlr1 is not null) baseClasses = (BaseClassesGreen?)this.Visit(context.baseClassesAntlr1);
                ClassBodyGreen? classBody = null;
                if (context.classBodyAntlr1 is not null) classBody = (ClassBodyGreen?)this.Visit(context.classBodyAntlr1) ?? ClassBodyGreen.__Missing;
                else classBody = ClassBodyGreen.__Missing;
            	return _factory.MetaClass(isAbstract, kClass, name, baseClasses, classBody);
            }
            public override EnumBodyGreen? VisitPr_EnumBody(MetaCoreParser.Pr_EnumBodyContext? context)
            {
               	if (context == null) return EnumBodyGreen.__Missing;
                var tLBrace = this.VisitTerminal(context.tLBrace, MetaCoreSyntaxKind.TLBrace);
                EnumLiteralsGreen? enumLiterals = null;
                if (context.enumLiteralsAntlr1 is not null) enumLiterals = (EnumLiteralsGreen?)this.Visit(context.enumLiteralsAntlr1);
                var tRBrace = this.VisitTerminal(context.tRBrace, MetaCoreSyntaxKind.TRBrace);
            	return _factory.EnumBody(tLBrace, enumLiterals, tRBrace);
            }
            public override EnumLiteralsGreen? VisitPr_EnumLiterals(MetaCoreParser.Pr_EnumLiteralsContext? context)
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
                        metaEnumLiteralListBuilder.AddSeparator(this.VisitTerminal(separator, MetaCoreSyntaxKind.TComma));
                        if (item is not null) metaEnumLiteralListBuilder.Add((MetaEnumLiteralGreen?)this.Visit(item) ?? MetaEnumLiteralGreen.__Missing);
                        else metaEnumLiteralListBuilder.Add(MetaEnumLiteralGreen.__Missing);
                    }
                }
                var metaEnumLiteralList = metaEnumLiteralListBuilder.ToList();
                _pool.Free(metaEnumLiteralListBuilder);
            	return _factory.EnumLiterals(metaEnumLiteralList);
            }
            public override MetaEnumLiteralGreen? VisitPr_MetaEnumLiteral(MetaCoreParser.Pr_MetaEnumLiteralContext? context)
            {
               	if (context == null) return MetaEnumLiteralGreen.__Missing;
                NameGreen? name = null;
                if (context.nameAntlr1 is not null) name = (NameGreen?)this.Visit(context.nameAntlr1) ?? NameGreen.__Missing;
                else name = NameGreen.__Missing;
            	return _factory.MetaEnumLiteral(name);
            }
            public override BaseClassesGreen? VisitPr_BaseClasses(MetaCoreParser.Pr_BaseClassesContext? context)
            {
               	if (context == null) return BaseClassesGreen.__Missing;
                BaseClassesBlock1Green? baseClassesBlock1 = null;
                if (context.baseClassesBlock1Antlr1 is not null) baseClassesBlock1 = (BaseClassesBlock1Green?)this.Visit(context.baseClassesBlock1Antlr1) ?? BaseClassesBlock1Green.__Missing;
                else baseClassesBlock1 = BaseClassesBlock1Green.__Missing;
            	return _factory.BaseClasses(baseClassesBlock1);
            }
            public override ClassBodyGreen? VisitPr_ClassBody(MetaCoreParser.Pr_ClassBodyContext? context)
            {
               	if (context == null) return ClassBodyGreen.__Missing;
                var tLBrace = this.VisitTerminal(context.tLBrace, MetaCoreSyntaxKind.TLBrace);
                var propertiesContext = context._propertiesAntlr1;
                var propertiesBuilder = _pool.Allocate<MetaPropertyGreen>();
                for (int i = 0; i < propertiesContext.Count; ++i)
                {
                    if (propertiesContext[i] is not null) propertiesBuilder.Add((MetaPropertyGreen?)this.Visit(propertiesContext[i]) ?? MetaPropertyGreen.__Missing);
                    else propertiesBuilder.Add(MetaPropertyGreen.__Missing);
                }
                var properties = propertiesBuilder.ToList();
                _pool.Free(propertiesBuilder);
                var tRBrace = this.VisitTerminal(context.tRBrace, MetaCoreSyntaxKind.TRBrace);
            	return _factory.ClassBody(tLBrace, properties, tRBrace);
            }
            public override MetaPropertyGreen? VisitPr_MetaProperty(MetaCoreParser.Pr_MetaPropertyContext? context)
            {
               	if (context == null) return MetaPropertyGreen.__Missing;
                var isContainment = this.VisitTerminal(context.isContainment);
                TypeReferenceGreen? type = null;
                if (context.typeAntlr1 is not null) type = (TypeReferenceGreen?)this.Visit(context.typeAntlr1) ?? TypeReferenceGreen.__Missing;
                else type = TypeReferenceGreen.__Missing;
                NameGreen? name = null;
                if (context.nameAntlr1 is not null) name = (NameGreen?)this.Visit(context.nameAntlr1) ?? NameGreen.__Missing;
                else name = NameGreen.__Missing;
                PropertyOppositeGreen? propertyOpposite = null;
                if (context.propertyOppositeAntlr1 is not null) propertyOpposite = (PropertyOppositeGreen?)this.Visit(context.propertyOppositeAntlr1);
                var tSemicolon = this.VisitTerminal(context.tSemicolon, MetaCoreSyntaxKind.TSemicolon);
            	return _factory.MetaProperty(isContainment, type, name, propertyOpposite, tSemicolon);
            }
            public override PropertyOppositeGreen? VisitPr_PropertyOpposite(MetaCoreParser.Pr_PropertyOppositeContext? context)
            {
               	if (context == null) return PropertyOppositeGreen.__Missing;
                var kOpposite = this.VisitTerminal(context.kOpposite, MetaCoreSyntaxKind.KOpposite);
                QualifierGreen? opposite = null;
                if (context.OppositeAntlr1 is not null) opposite = (QualifierGreen?)this.Visit(context.OppositeAntlr1) ?? QualifierGreen.__Missing;
                else opposite = QualifierGreen.__Missing;
            	return _factory.PropertyOpposite(kOpposite, opposite);
            }
            public override MetaArrayTypeGreen? VisitPr_MetaArrayType(MetaCoreParser.Pr_MetaArrayTypeContext? context)
            {
               	if (context == null) return MetaArrayTypeGreen.__Missing;
                TypeReferenceGreen? itemType = null;
                if (context.itemTypeAntlr1 is not null) itemType = (TypeReferenceGreen?)this.Visit(context.itemTypeAntlr1) ?? TypeReferenceGreen.__Missing;
                else itemType = TypeReferenceGreen.__Missing;
                var tLBracket = this.VisitTerminal(context.tLBracket, MetaCoreSyntaxKind.TLBracket);
                var tRBracket = this.VisitTerminal(context.tRBracket, MetaCoreSyntaxKind.TRBracket);
            	return _factory.MetaArrayType(itemType, tLBracket, tRBracket);
            }
            public override TypeReferenceAlt3Green? VisitPr_TypeReferenceAlt3(MetaCoreParser.Pr_TypeReferenceAlt3Context? context)
            {
               	if (context == null) return TypeReferenceAlt3Green.__Missing;
                QualifierGreen? qualifier = null;
                if (context.qualifierAntlr1 is not null) qualifier = (QualifierGreen?)this.Visit(context.qualifierAntlr1) ?? QualifierGreen.__Missing;
                else qualifier = QualifierGreen.__Missing;
            	return _factory.TypeReferenceAlt3(qualifier);
            }
            public override TypeReferenceTokensGreen? VisitPr_TypeReferenceTokens(MetaCoreParser.Pr_TypeReferenceTokensContext? context)
            {
               	if (context == null) return TypeReferenceTokensGreen.__Missing;
                InternalSyntaxToken? tokens = null;
                if (context.kBool is not null) tokens = this.VisitTerminal(context.kBool);
                if (context.kInt is not null) tokens = this.VisitTerminal(context.kInt);
                if (context.kString is not null) tokens = this.VisitTerminal(context.kString);
            	return _factory.TypeReferenceTokens(tokens);
            }
            public override NameGreen? VisitPr_Name(MetaCoreParser.Pr_NameContext? context)
            {
               	if (context == null) return NameGreen.__Missing;
                IdentifierGreen? identifier = null;
                if (context.identifierAntlr1 is not null) identifier = (IdentifierGreen?)this.Visit(context.identifierAntlr1) ?? IdentifierGreen.__Missing;
                else identifier = IdentifierGreen.__Missing;
            	return _factory.Name(identifier);
            }
            public override QualifierGreen? VisitPr_Qualifier(MetaCoreParser.Pr_QualifierContext? context)
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
                        identifierListBuilder.AddSeparator(this.VisitTerminal(separator, MetaCoreSyntaxKind.TDot));
                        if (item is not null) identifierListBuilder.Add((IdentifierGreen?)this.Visit(item) ?? IdentifierGreen.__Missing);
                        else identifierListBuilder.Add(IdentifierGreen.__Missing);
                    }
                }
                var identifierList = identifierListBuilder.ToList();
                _pool.Free(identifierListBuilder);
            	return _factory.Qualifier(identifierList);
            }
            public override QualifierListGreen? VisitPr_QualifierList(MetaCoreParser.Pr_QualifierListContext? context)
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
                        qualifierListBuilder.AddSeparator(this.VisitTerminal(separator, MetaCoreSyntaxKind.TComma));
                        if (item is not null) qualifierListBuilder.Add((QualifierGreen?)this.Visit(item) ?? QualifierGreen.__Missing);
                        else qualifierListBuilder.Add(QualifierGreen.__Missing);
                    }
                }
                var qualifierList = qualifierListBuilder.ToList();
                _pool.Free(qualifierListBuilder);
            	return _factory.QualifierList(qualifierList);
            }
            public override IdentifierGreen? VisitPr_Identifier(MetaCoreParser.Pr_IdentifierContext? context)
            {
               	if (context == null) return IdentifierGreen.__Missing;
                var tIdentifier = this.VisitTerminal(context.tIdentifierAntlr1, MetaCoreSyntaxKind.TIdentifier);
            	return _factory.Identifier(tIdentifier);
            }
            public override EnumLiteralsBlock1Green? VisitPr_EnumLiteralsBlock1(MetaCoreParser.Pr_EnumLiteralsBlock1Context? context)
            {
               	if (context == null) return EnumLiteralsBlock1Green.__Missing;
                var tComma = this.VisitTerminal(context.tComma, MetaCoreSyntaxKind.TComma);
                MetaEnumLiteralGreen? literals = null;
                if (context.literalsAntlr1 is not null) literals = (MetaEnumLiteralGreen?)this.Visit(context.literalsAntlr1) ?? MetaEnumLiteralGreen.__Missing;
                else literals = MetaEnumLiteralGreen.__Missing;
            	return _factory.EnumLiteralsBlock1(tComma, literals);
            }
            public override BaseClassesBlock1Green? VisitPr_BaseClassesBlock1(MetaCoreParser.Pr_BaseClassesBlock1Context? context)
            {
               	if (context == null) return BaseClassesBlock1Green.__Missing;
                var tColon = this.VisitTerminal(context.tColon, MetaCoreSyntaxKind.TColon);
                QualifierListGreen? baseTypes = null;
                if (context.baseTypesAntlr1 is not null) baseTypes = (QualifierListGreen?)this.Visit(context.baseTypesAntlr1) ?? QualifierListGreen.__Missing;
                else baseTypes = QualifierListGreen.__Missing;
            	return _factory.BaseClassesBlock1(tColon, baseTypes);
            }
            public override QualifierBlock1Green? VisitPr_QualifierBlock1(MetaCoreParser.Pr_QualifierBlock1Context? context)
            {
               	if (context == null) return QualifierBlock1Green.__Missing;
                var tDot = this.VisitTerminal(context.tDot, MetaCoreSyntaxKind.TDot);
                IdentifierGreen? identifier = null;
                if (context.identifierAntlr1 is not null) identifier = (IdentifierGreen?)this.Visit(context.identifierAntlr1) ?? IdentifierGreen.__Missing;
                else identifier = IdentifierGreen.__Missing;
            	return _factory.QualifierBlock1(tDot, identifier);
            }
            public override QualifierListBlock1Green? VisitPr_QualifierListBlock1(MetaCoreParser.Pr_QualifierListBlock1Context? context)
            {
               	if (context == null) return QualifierListBlock1Green.__Missing;
                var tComma = this.VisitTerminal(context.tComma, MetaCoreSyntaxKind.TComma);
                QualifierGreen? qualifier = null;
                if (context.qualifierAntlr1 is not null) qualifier = (QualifierGreen?)this.Visit(context.qualifierAntlr1) ?? QualifierGreen.__Missing;
                else qualifier = QualifierGreen.__Missing;
            	return _factory.QualifierListBlock1(tComma, qualifier);
            }
        }
    }
}
