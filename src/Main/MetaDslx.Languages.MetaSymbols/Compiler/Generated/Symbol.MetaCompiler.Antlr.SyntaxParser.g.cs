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
using MetaDslx.Languages.MetaSymbols.Compiler.Syntax.InternalSyntax;

#nullable enable

namespace MetaDslx.Languages.MetaSymbols.Compiler.Syntax
{
    public partial class SymbolSyntaxParser : AntlrSyntaxParser
    {
        private readonly AntlrToRoslynVisitor _visitor;

        public SymbolSyntaxParser(
            SymbolSyntaxLexer lexer,
            IncrementalParseData? oldParseData,
            IEnumerable<TextChangeRange> changes,
            CancellationToken cancellationToken = default)
            : base(lexer, oldParseData, changes, cancellationToken)
        {
            _visitor = new AntlrToRoslynVisitor(this);
        }

        protected new SymbolParser AntlrParser => (SymbolParser)base.AntlrParser;

        protected override SyntaxNode ParseRoot()
        {
            ParserState? state = null;
            GreenNode? green = this.ParseMain(ref state);
            var red = (SymbolSyntaxNode)green!.CreateRed();
            return red;
        }

        private GreenNode? ParseMain(ref ParserState? state)
        {
            return _visitor.VisitPr_Main(AntlrParser.pr_Main());
        }

        private class AntlrToRoslynVisitor : SymbolParserBaseVisitor<GreenNode?>
        {
            // list pools - allocators for lists that are used to build sequences of nodes. The lists
            // can be reused (hence pooled) since the syntax factory methods don't keep references to
            // them
            private readonly SyntaxListPool _pool = new SyntaxListPool(); // Don't need to reset this.

            private readonly SymbolSyntaxParser _parser;
            private readonly AntlrTokenStream _tokenStream;
            private readonly SymbolInternalSyntaxFactory _factory;

            public AntlrToRoslynVisitor(SymbolSyntaxParser parser)
            {
                _parser = parser;
                _tokenStream = (AntlrTokenStream)_parser.AntlrParser.InputStream;
                _factory = (SymbolInternalSyntaxFactory)_parser.Language.InternalSyntaxFactory;
            }

            private GreenNode? VisitTerminal(IToken? token, SymbolSyntaxKind kind)
            {
                if (token == null)
                {
                    if (kind != SymbolSyntaxKind.None) return _tokenStream.ConsumeGreenToken(_factory.MissingToken(kind), _parser);
                    else return null;
                }
                var green = _tokenStream.ConsumeGreenToken(token, _parser);
                Debug.Assert(kind == SymbolSyntaxKind.None || green.RawKind == (int)kind);
                return green;
            }

            public GreenNode? VisitTerminal(IToken? token)
            {
                return VisitTerminal(token, SymbolSyntaxKind.None);
            }

            private GreenNode? VisitTerminal(ITerminalNode? node, SymbolSyntaxKind kind)
            {
                if (node?.Symbol == null)
                {
                    if (kind != SymbolSyntaxKind.None) return _factory.MissingToken(kind);
                    else return null;
                }
                var green = _tokenStream.ConsumeGreenToken(node.Symbol, _parser);
                Debug.Assert(kind == SymbolSyntaxKind.None || green.RawKind == (int)kind);
                return green;
            }

            public override GreenNode? VisitTerminal(ITerminalNode? node)
            {
                return VisitTerminal(node, SymbolSyntaxKind.None);
            }
            
            public override GreenNode? VisitPr_Main(SymbolParser.Pr_MainContext? context)
            {
                if (context == null) return MainGreen.__Missing;
                var kNamespace = (InternalSyntaxToken?)this.VisitTerminal(context.E_KNamespace, SymbolSyntaxKind.KNamespace);
                QualifierGreen? qualifier = null;
                if (context.E_Qualifier is not null) qualifier = (QualifierGreen?)this.Visit(context.E_Qualifier) ?? QualifierGreen.__Missing;
                else qualifier = QualifierGreen.__Missing;
                var E_UsingListContext = context._E_UsingList;
                var usingListBuilder = _pool.Allocate<UsingGreen>();
                for (int i = 0; i < E_UsingListContext.Count; ++i)
                {
                    if (E_UsingListContext[i] is not null) usingListBuilder.Add((UsingGreen?)this.Visit(E_UsingListContext[i]) ?? UsingGreen.__Missing);
                    else usingListBuilder.Add(UsingGreen.__Missing);
                }
                var usingList = usingListBuilder.ToList();
                _pool.Free(usingListBuilder);
                MainBlock1Green? block = null;
                if (context.E_Block is not null) block = (MainBlock1Green?)this.Visit(context.E_Block) ?? MainBlock1Green.__Missing;
                else block = MainBlock1Green.__Missing;
                var endOfFileToken = (InternalSyntaxToken?)this.VisitTerminal(context.E_EndOfFileToken, SymbolSyntaxKind.Eof);
                return _factory.Main(kNamespace, qualifier, usingList, block, endOfFileToken);
            }
            
            public override GreenNode? VisitPr_Using(SymbolParser.Pr_UsingContext? context)
            {
                if (context == null) return UsingGreen.__Missing;
                var kUsing = (InternalSyntaxToken?)this.VisitTerminal(context.E_KUsing, SymbolSyntaxKind.KUsing);
                QualifierGreen? namespaces = null;
                if (context.E_namespaces is not null) namespaces = (QualifierGreen?)this.Visit(context.E_namespaces) ?? QualifierGreen.__Missing;
                else namespaces = QualifierGreen.__Missing;
                return _factory.Using(kUsing, namespaces);
            }
            
            public override GreenNode? VisitPr_Symbol(SymbolParser.Pr_SymbolContext? context)
            {
                if (context == null) return SymbolGreen.__Missing;
                var isAbstract = (InternalSyntaxToken?)this.VisitTerminal(context.E_isAbstract);
                var kSymbol = (InternalSyntaxToken?)this.VisitTerminal(context.E_KSymbol, SymbolSyntaxKind.KSymbol);
                NameGreen? name = null;
                if (context.E_Name is not null) name = (NameGreen?)this.Visit(context.E_Name) ?? NameGreen.__Missing;
                else name = NameGreen.__Missing;
                SymbolBlock1Green? block1 = null;
                if (context.E_Block is not null) block1 = (SymbolBlock1Green?)this.Visit(context.E_Block);
                SymbolBlock2Green? block2 = null;
                if (context.E_Block1 is not null) block2 = (SymbolBlock2Green?)this.Visit(context.E_Block1) ?? SymbolBlock2Green.__Missing;
                else block2 = SymbolBlock2Green.__Missing;
                return _factory.Symbol(isAbstract, kSymbol, name, block1, block2);
            }
            
            public override GreenNode? VisitPr_Property(SymbolParser.Pr_PropertyContext? context)
            {
                if (context == null) return PropertyGreen.__Missing;
                PropertyBlock1Green? block1 = null;
                if (context.E_Block is not null) block1 = (PropertyBlock1Green?)this.Visit(context.E_Block);
                TypeReferenceGreen? type = null;
                if (context.E_type is not null) type = (TypeReferenceGreen?)this.Visit(context.E_type) ?? TypeReferenceGreen.__Missing;
                else type = TypeReferenceGreen.__Missing;
                NameGreen? name = null;
                if (context.E_Name is not null) name = (NameGreen?)this.Visit(context.E_Name) ?? NameGreen.__Missing;
                else name = NameGreen.__Missing;
                PropertyBlock2Green? block2 = null;
                if (context.E_Block1 is not null) block2 = (PropertyBlock2Green?)this.Visit(context.E_Block1);
                PropertyBlock3Green? block3 = null;
                if (context.E_Block2 is not null) block3 = (PropertyBlock3Green?)this.Visit(context.E_Block2);
                return _factory.Property(block1, type, name, block2, block3);
            }
            
            public override GreenNode? VisitPr_Operation(SymbolParser.Pr_OperationContext? context)
            {
                if (context == null) return OperationGreen.__Missing;
                TypeReferenceGreen? returnType = null;
                if (context.E_returnType is not null) returnType = (TypeReferenceGreen?)this.Visit(context.E_returnType) ?? TypeReferenceGreen.__Missing;
                else returnType = TypeReferenceGreen.__Missing;
                NameGreen? name = null;
                if (context.E_Name is not null) name = (NameGreen?)this.Visit(context.E_Name) ?? NameGreen.__Missing;
                else name = NameGreen.__Missing;
                var tLParen = (InternalSyntaxToken?)this.VisitTerminal(context.E_TLParen, SymbolSyntaxKind.TLParen);
                OperationBlock1Green? block = null;
                if (context.E_Block is not null) block = (OperationBlock1Green?)this.Visit(context.E_Block);
                var tRParen = (InternalSyntaxToken?)this.VisitTerminal(context.E_TRParen, SymbolSyntaxKind.TRParen);
                return _factory.Operation(returnType, name, tLParen, block, tRParen);
            }
            
            public override GreenNode? VisitPr_Parameter(SymbolParser.Pr_ParameterContext? context)
            {
                if (context == null) return ParameterGreen.__Missing;
                TypeReferenceGreen? type = null;
                if (context.E_type is not null) type = (TypeReferenceGreen?)this.Visit(context.E_type) ?? TypeReferenceGreen.__Missing;
                else type = TypeReferenceGreen.__Missing;
                NameGreen? name = null;
                if (context.E_Name is not null) name = (NameGreen?)this.Visit(context.E_Name) ?? NameGreen.__Missing;
                else name = NameGreen.__Missing;
                return _factory.Parameter(type, name);
            }
            
            public override GreenNode? VisitPr_TypeReference(SymbolParser.Pr_TypeReferenceContext? context)
            {
                if (context == null) return TypeReferenceGreen.__Missing;
                SimpleTypeReferenceGreen? type = null;
                if (context.E_type is not null) type = (SimpleTypeReferenceGreen?)this.Visit(context.E_type) ?? SimpleTypeReferenceGreen.__Missing;
                else type = SimpleTypeReferenceGreen.__Missing;
                TypeReferenceBlock1Green? block = null;
                if (context.E_Block is not null) block = (TypeReferenceBlock1Green?)this.Visit(context.E_Block) ?? TypeReferenceBlock1Green.__Missing;
                else block = TypeReferenceBlock1Green.__Missing;
                ArrayDimensionsGreen? dimensions = null;
                if (context.E_dimensions is not null) dimensions = (ArrayDimensionsGreen?)this.Visit(context.E_dimensions) ?? ArrayDimensionsGreen.__Missing;
                else dimensions = ArrayDimensionsGreen.__Missing;
                return _factory.TypeReference(type, block, dimensions);
            }
            
            public override GreenNode? VisitPr_ArrayDimensions(SymbolParser.Pr_ArrayDimensionsContext? context)
            {
                if (context == null) return ArrayDimensionsGreen.__Missing;
                var E_BlockContext = context._E_Block;
                var blockBuilder = _pool.Allocate<ArrayDimensionsBlock1Green>();
                for (int i = 0; i < E_BlockContext.Count; ++i)
                {
                    if (E_BlockContext[i] is not null) blockBuilder.Add((ArrayDimensionsBlock1Green?)this.Visit(E_BlockContext[i]) ?? ArrayDimensionsBlock1Green.__Missing);
                    else blockBuilder.Add(ArrayDimensionsBlock1Green.__Missing);
                }
                var block = blockBuilder.ToList();
                _pool.Free(blockBuilder);
                return _factory.ArrayDimensions(block);
            }
            
            public override GreenNode? VisitPr_SimpleTypeReferenceAlt1(SymbolParser.Pr_SimpleTypeReferenceAlt1Context? context)
            {
                if (context == null) return SimpleTypeReferenceAlt1Green.__Missing;
                PrimitiveTypeGreen? primitiveType = null;
                if (context.E_PrimitiveType is not null) primitiveType = (PrimitiveTypeGreen?)this.Visit(context.E_PrimitiveType) ?? PrimitiveTypeGreen.__Missing;
                else primitiveType = PrimitiveTypeGreen.__Missing;
                return _factory.SimpleTypeReferenceAlt1(primitiveType);
            }
            
            public override GreenNode? VisitPr_SimpleTypeReferenceAlt2(SymbolParser.Pr_SimpleTypeReferenceAlt2Context? context)
            {
                if (context == null) return SimpleTypeReferenceAlt2Green.__Missing;
                QualifierGreen? qualifier = null;
                if (context.E_Qualifier is not null) qualifier = (QualifierGreen?)this.Visit(context.E_Qualifier) ?? QualifierGreen.__Missing;
                else qualifier = QualifierGreen.__Missing;
                return _factory.SimpleTypeReferenceAlt2(qualifier);
            }
            
            public override GreenNode? VisitPr_PrimitiveType(SymbolParser.Pr_PrimitiveTypeContext? context)
            {
                if (context == null) return PrimitiveTypeGreen.__Missing;
                InternalSyntaxToken? token = null;
                if (context.LR_KObject() is not null) token = (InternalSyntaxToken?)this.VisitTerminal(context.LR_KObject());
                if (context.LR_KBool() is not null) token = (InternalSyntaxToken?)this.VisitTerminal(context.LR_KBool());
                if (context.LR_KChar() is not null) token = (InternalSyntaxToken?)this.VisitTerminal(context.LR_KChar());
                if (context.LR_KString() is not null) token = (InternalSyntaxToken?)this.VisitTerminal(context.LR_KString());
                if (context.LR_KByte() is not null) token = (InternalSyntaxToken?)this.VisitTerminal(context.LR_KByte());
                if (context.LR_KSbyte() is not null) token = (InternalSyntaxToken?)this.VisitTerminal(context.LR_KSbyte());
                if (context.LR_KShort() is not null) token = (InternalSyntaxToken?)this.VisitTerminal(context.LR_KShort());
                if (context.LR_KUshort() is not null) token = (InternalSyntaxToken?)this.VisitTerminal(context.LR_KUshort());
                if (context.LR_KInt() is not null) token = (InternalSyntaxToken?)this.VisitTerminal(context.LR_KInt());
                if (context.LR_KUint() is not null) token = (InternalSyntaxToken?)this.VisitTerminal(context.LR_KUint());
                if (context.LR_KLong() is not null) token = (InternalSyntaxToken?)this.VisitTerminal(context.LR_KLong());
                if (context.LR_KUlong() is not null) token = (InternalSyntaxToken?)this.VisitTerminal(context.LR_KUlong());
                if (context.LR_KFloat() is not null) token = (InternalSyntaxToken?)this.VisitTerminal(context.LR_KFloat());
                if (context.LR_KDouble() is not null) token = (InternalSyntaxToken?)this.VisitTerminal(context.LR_KDouble());
                if (context.LR_KDecimal() is not null) token = (InternalSyntaxToken?)this.VisitTerminal(context.LR_KDecimal());
                if (context.LR_KType() is not null) token = (InternalSyntaxToken?)this.VisitTerminal(context.LR_KType());
                if (context.LR_KSymbol() is not null) token = (InternalSyntaxToken?)this.VisitTerminal(context.LR_KSymbol());
                if (context.LR_KVoid() is not null) token = (InternalSyntaxToken?)this.VisitTerminal(context.LR_KVoid());
                if (token is null) token = _factory.None;
                return _factory.PrimitiveType(token);
            }
            
            public override GreenNode? VisitPr_ValueAlt1(SymbolParser.Pr_ValueAlt1Context? context)
            {
                if (context == null) return ValueAlt1Green.__Missing;
                var tString = (InternalSyntaxToken?)this.VisitTerminal(context.E_TString, SymbolSyntaxKind.TString);
                return _factory.ValueAlt1(tString);
            }
            
            public override GreenNode? VisitPr_ValueAlt2(SymbolParser.Pr_ValueAlt2Context? context)
            {
                if (context == null) return ValueAlt2Green.__Missing;
                var tInteger = (InternalSyntaxToken?)this.VisitTerminal(context.E_TInteger, SymbolSyntaxKind.TInteger);
                return _factory.ValueAlt2(tInteger);
            }
            
            public override GreenNode? VisitPr_ValueAlt3(SymbolParser.Pr_ValueAlt3Context? context)
            {
                if (context == null) return ValueAlt3Green.__Missing;
                var tDecimal = (InternalSyntaxToken?)this.VisitTerminal(context.E_TDecimal, SymbolSyntaxKind.TDecimal);
                return _factory.ValueAlt3(tDecimal);
            }
            
            public override GreenNode? VisitPr_ValueAlt4(SymbolParser.Pr_ValueAlt4Context? context)
            {
                if (context == null) return ValueAlt4Green.__Missing;
                TBooleanGreen? tBoolean = null;
                if (context.E_TBoolean is not null) tBoolean = (TBooleanGreen?)this.Visit(context.E_TBoolean) ?? TBooleanGreen.__Missing;
                else tBoolean = TBooleanGreen.__Missing;
                return _factory.ValueAlt4(tBoolean);
            }
            
            public override GreenNode? VisitPr_ValueAlt5(SymbolParser.Pr_ValueAlt5Context? context)
            {
                if (context == null) return ValueAlt5Green.__Missing;
                var kNull = (InternalSyntaxToken?)this.VisitTerminal(context.E_KNull, SymbolSyntaxKind.KNull);
                return _factory.ValueAlt5(kNull);
            }
            
            public override GreenNode? VisitPr_ValueAlt6(SymbolParser.Pr_ValueAlt6Context? context)
            {
                if (context == null) return ValueAlt6Green.__Missing;
                QualifierGreen? qualifier = null;
                if (context.E_Qualifier is not null) qualifier = (QualifierGreen?)this.Visit(context.E_Qualifier) ?? QualifierGreen.__Missing;
                else qualifier = QualifierGreen.__Missing;
                return _factory.ValueAlt6(qualifier);
            }
            
            public override GreenNode? VisitPr_Name(SymbolParser.Pr_NameContext? context)
            {
                if (context == null) return NameGreen.__Missing;
                IdentifierGreen? identifier = null;
                if (context.E_Identifier is not null) identifier = (IdentifierGreen?)this.Visit(context.E_Identifier) ?? IdentifierGreen.__Missing;
                else identifier = IdentifierGreen.__Missing;
                return _factory.Name(identifier);
            }
            
            public override GreenNode? VisitPr_Qualifier(SymbolParser.Pr_QualifierContext? context)
            {
                if (context == null) return QualifierGreen.__Missing;
                var identifierBuilder = _pool.AllocateSeparated<IdentifierGreen>(reversed: false);
                var E_Identifier1Context = context.E_Identifier1;
                if (E_Identifier1Context is not null) identifierBuilder.Add((IdentifierGreen?)this.Visit(E_Identifier1Context) ?? IdentifierGreen.__Missing);
                else identifierBuilder.Add(IdentifierGreen.__Missing);
                var E_Identifier2Context = context._E_Identifier2;
                var E_TDot1Context = context._E_TDot1;
                for (int i = 0; i < E_Identifier2Context.Count; ++i)
                {
                    if (i < E_TDot1Context.Count)
                    {
                        var _separator = E_TDot1Context[i];
                        identifierBuilder.AddSeparator((InternalSyntaxToken?)this.VisitTerminal(_separator, SymbolSyntaxKind.TDot));
                    }
                    else
                    {
                        identifierBuilder.AddSeparator((InternalSyntaxToken?)this.VisitTerminal((IToken?)null, SymbolSyntaxKind.TDot));
                    }
                    var _item = E_Identifier2Context[i];
                    if (_item is not null) identifierBuilder.Add((IdentifierGreen?)this.Visit(_item) ?? IdentifierGreen.__Missing);
                    else identifierBuilder.Add(IdentifierGreen.__Missing);
                }
                var identifier = identifierBuilder.ToList();
                _pool.Free(identifierBuilder);
                return _factory.Qualifier(identifier);
            }
            
            public override GreenNode? VisitPr_Identifier(SymbolParser.Pr_IdentifierContext? context)
            {
                if (context == null) return IdentifierGreen.__Missing;
                InternalSyntaxToken? token = null;
                if (context.LR_TIdentifier() is not null) token = (InternalSyntaxToken?)this.VisitTerminal(context.LR_TIdentifier());
                if (context.LR_TVerbatimIdentifier() is not null) token = (InternalSyntaxToken?)this.VisitTerminal(context.LR_TVerbatimIdentifier());
                if (token is null) token = _factory.None;
                return _factory.Identifier(token);
            }
            
            public override GreenNode? VisitPr_TBoolean(SymbolParser.Pr_TBooleanContext? context)
            {
                if (context == null) return TBooleanGreen.__Missing;
                InternalSyntaxToken? token = null;
                if (context.LR_KTrue() is not null) token = (InternalSyntaxToken?)this.VisitTerminal(context.LR_KTrue());
                if (context.LR_KFalse() is not null) token = (InternalSyntaxToken?)this.VisitTerminal(context.LR_KFalse());
                if (token is null) token = _factory.None;
                return _factory.TBoolean(token);
            }
            
            public override GreenNode? VisitPr_MainBlock1(SymbolParser.Pr_MainBlock1Context? context)
            {
                if (context == null) return MainBlock1Green.__Missing;
                var E_declarationsContext = context._E_declarations;
                var declarationsBuilder = _pool.Allocate<SymbolGreen>();
                for (int i = 0; i < E_declarationsContext.Count; ++i)
                {
                    if (E_declarationsContext[i] is not null) declarationsBuilder.Add((SymbolGreen?)this.Visit(E_declarationsContext[i]) ?? SymbolGreen.__Missing);
                    else declarationsBuilder.Add(SymbolGreen.__Missing);
                }
                var declarations = declarationsBuilder.ToList();
                _pool.Free(declarationsBuilder);
                return _factory.MainBlock1(declarations);
            }
            
            public override GreenNode? VisitPr_SymbolBlock1(SymbolParser.Pr_SymbolBlock1Context? context)
            {
                if (context == null) return SymbolBlock1Green.__Missing;
                var tColon = (InternalSyntaxToken?)this.VisitTerminal(context.E_TColon, SymbolSyntaxKind.TColon);
                var baseTypesBuilder = _pool.AllocateSeparated<QualifierGreen>(reversed: false);
                var E_baseTypes1Context = context.E_baseTypes1;
                if (E_baseTypes1Context is not null) baseTypesBuilder.Add((QualifierGreen?)this.Visit(E_baseTypes1Context) ?? QualifierGreen.__Missing);
                else baseTypesBuilder.Add(QualifierGreen.__Missing);
                var E_baseTypes2Context = context._E_baseTypes2;
                var E_TComma1Context = context._E_TComma1;
                for (int i = 0; i < E_baseTypes2Context.Count; ++i)
                {
                    if (i < E_TComma1Context.Count)
                    {
                        var _separator = E_TComma1Context[i];
                        baseTypesBuilder.AddSeparator((InternalSyntaxToken?)this.VisitTerminal(_separator, SymbolSyntaxKind.TComma));
                    }
                    else
                    {
                        baseTypesBuilder.AddSeparator((InternalSyntaxToken?)this.VisitTerminal((IToken?)null, SymbolSyntaxKind.TComma));
                    }
                    var _item = E_baseTypes2Context[i];
                    if (_item is not null) baseTypesBuilder.Add((QualifierGreen?)this.Visit(_item) ?? QualifierGreen.__Missing);
                    else baseTypesBuilder.Add(QualifierGreen.__Missing);
                }
                var baseTypes = baseTypesBuilder.ToList();
                _pool.Free(baseTypesBuilder);
                return _factory.SymbolBlock1(tColon, baseTypes);
            }
            
            public override GreenNode? VisitPr_SymbolBlock1baseTypesBlock(SymbolParser.Pr_SymbolBlock1baseTypesBlockContext? context)
            {
                if (context == null) return SymbolBlock1baseTypesBlockGreen.__Missing;
                var tComma = (InternalSyntaxToken?)this.VisitTerminal(context.E_TComma1, SymbolSyntaxKind.TComma);
                QualifierGreen? baseTypes = null;
                if (context.E_baseTypes2 is not null) baseTypes = (QualifierGreen?)this.Visit(context.E_baseTypes2) ?? QualifierGreen.__Missing;
                else baseTypes = QualifierGreen.__Missing;
                return _factory.SymbolBlock1baseTypesBlock(tComma, baseTypes);
            }
            
            public override GreenNode? VisitPr_SymbolBlock2(SymbolParser.Pr_SymbolBlock2Context? context)
            {
                if (context == null) return SymbolBlock2Green.__Missing;
                var tLBrace = (InternalSyntaxToken?)this.VisitTerminal(context.E_TLBrace, SymbolSyntaxKind.TLBrace);
                var E_BlockContext = context._E_Block;
                var blockBuilder = _pool.Allocate<SymbolBlock2Block1Green>();
                for (int i = 0; i < E_BlockContext.Count; ++i)
                {
                    if (E_BlockContext[i] is not null) blockBuilder.Add((SymbolBlock2Block1Green?)this.Visit(E_BlockContext[i]) ?? SymbolBlock2Block1Green.__Missing);
                    else blockBuilder.Add(SymbolBlock2Block1Green.__Missing);
                }
                var block = blockBuilder.ToList();
                _pool.Free(blockBuilder);
                var tRBrace = (InternalSyntaxToken?)this.VisitTerminal(context.E_TRBrace, SymbolSyntaxKind.TRBrace);
                return _factory.SymbolBlock2(tLBrace, block, tRBrace);
            }
            
            public override GreenNode? VisitPr_SymbolBlock2Block1Alt1(SymbolParser.Pr_SymbolBlock2Block1Alt1Context? context)
            {
                if (context == null) return SymbolBlock2Block1Alt1Green.__Missing;
                PropertyGreen? properties = null;
                if (context.E_properties is not null) properties = (PropertyGreen?)this.Visit(context.E_properties) ?? PropertyGreen.__Missing;
                else properties = PropertyGreen.__Missing;
                return _factory.SymbolBlock2Block1Alt1(properties);
            }
            
            public override GreenNode? VisitPr_SymbolBlock2Block1Alt2(SymbolParser.Pr_SymbolBlock2Block1Alt2Context? context)
            {
                if (context == null) return SymbolBlock2Block1Alt2Green.__Missing;
                OperationGreen? operations = null;
                if (context.E_operations is not null) operations = (OperationGreen?)this.Visit(context.E_operations) ?? OperationGreen.__Missing;
                else operations = OperationGreen.__Missing;
                return _factory.SymbolBlock2Block1Alt2(operations);
            }
            
            public override GreenNode? VisitPr_PropertyBlock1Alt1(SymbolParser.Pr_PropertyBlock1Alt1Context? context)
            {
                if (context == null) return PropertyBlock1Alt1Green.__Missing;
                var isWeak = (InternalSyntaxToken?)this.VisitTerminal(context.E_isWeak, SymbolSyntaxKind.KWeak);
                return _factory.PropertyBlock1Alt1(isWeak);
            }
            
            public override GreenNode? VisitPr_PropertyBlock1Alt2(SymbolParser.Pr_PropertyBlock1Alt2Context? context)
            {
                if (context == null) return PropertyBlock1Alt2Green.__Missing;
                var isDerived = (InternalSyntaxToken?)this.VisitTerminal(context.E_isDerived, SymbolSyntaxKind.KDerived);
                return _factory.PropertyBlock1Alt2(isDerived);
            }
            
            public override GreenNode? VisitPr_PropertyBlock2(SymbolParser.Pr_PropertyBlock2Context? context)
            {
                if (context == null) return PropertyBlock2Green.__Missing;
                var tEq = (InternalSyntaxToken?)this.VisitTerminal(context.E_TEq, SymbolSyntaxKind.TEq);
                ValueGreen? defaultValue = null;
                if (context.E_defaultValue is not null) defaultValue = (ValueGreen?)this.Visit(context.E_defaultValue) ?? ValueGreen.__Missing;
                else defaultValue = ValueGreen.__Missing;
                return _factory.PropertyBlock2(tEq, defaultValue);
            }
            
            public override GreenNode? VisitPr_PropertyBlock3(SymbolParser.Pr_PropertyBlock3Context? context)
            {
                if (context == null) return PropertyBlock3Green.__Missing;
                var kPhase = (InternalSyntaxToken?)this.VisitTerminal(context.E_KPhase, SymbolSyntaxKind.KPhase);
                IdentifierGreen? phase = null;
                if (context.E_phase is not null) phase = (IdentifierGreen?)this.Visit(context.E_phase) ?? IdentifierGreen.__Missing;
                else phase = IdentifierGreen.__Missing;
                return _factory.PropertyBlock3(kPhase, phase);
            }
            
            public override GreenNode? VisitPr_OperationBlock1(SymbolParser.Pr_OperationBlock1Context? context)
            {
                if (context == null) return OperationBlock1Green.__Missing;
                var parametersBuilder = _pool.AllocateSeparated<ParameterGreen>(reversed: false);
                var E_parameters1Context = context.E_parameters1;
                if (E_parameters1Context is not null) parametersBuilder.Add((ParameterGreen?)this.Visit(E_parameters1Context) ?? ParameterGreen.__Missing);
                else parametersBuilder.Add(ParameterGreen.__Missing);
                var E_parameters2Context = context._E_parameters2;
                var E_TComma1Context = context._E_TComma1;
                for (int i = 0; i < E_parameters2Context.Count; ++i)
                {
                    if (i < E_TComma1Context.Count)
                    {
                        var _separator = E_TComma1Context[i];
                        parametersBuilder.AddSeparator((InternalSyntaxToken?)this.VisitTerminal(_separator, SymbolSyntaxKind.TComma));
                    }
                    else
                    {
                        parametersBuilder.AddSeparator((InternalSyntaxToken?)this.VisitTerminal((IToken?)null, SymbolSyntaxKind.TComma));
                    }
                    var _item = E_parameters2Context[i];
                    if (_item is not null) parametersBuilder.Add((ParameterGreen?)this.Visit(_item) ?? ParameterGreen.__Missing);
                    else parametersBuilder.Add(ParameterGreen.__Missing);
                }
                var parameters = parametersBuilder.ToList();
                _pool.Free(parametersBuilder);
                return _factory.OperationBlock1(parameters);
            }
            
            public override GreenNode? VisitPr_OperationBlock1parametersBlock(SymbolParser.Pr_OperationBlock1parametersBlockContext? context)
            {
                if (context == null) return OperationBlock1parametersBlockGreen.__Missing;
                var tComma = (InternalSyntaxToken?)this.VisitTerminal(context.E_TComma1, SymbolSyntaxKind.TComma);
                ParameterGreen? parameters = null;
                if (context.E_parameters2 is not null) parameters = (ParameterGreen?)this.Visit(context.E_parameters2) ?? ParameterGreen.__Missing;
                else parameters = ParameterGreen.__Missing;
                return _factory.OperationBlock1parametersBlock(tComma, parameters);
            }
            
            public override GreenNode? VisitPr_TypeReferenceBlock1(SymbolParser.Pr_TypeReferenceBlock1Context? context)
            {
                if (context == null) return TypeReferenceBlock1Green.__Missing;
                var isNullable = (InternalSyntaxToken?)this.VisitTerminal(context.E_isNullable, SymbolSyntaxKind.TQuestion);
                return _factory.TypeReferenceBlock1(isNullable);
            }
            
            public override GreenNode? VisitPr_ArrayDimensionsBlock1(SymbolParser.Pr_ArrayDimensionsBlock1Context? context)
            {
                if (context == null) return ArrayDimensionsBlock1Green.__Missing;
                var tLBracket = (InternalSyntaxToken?)this.VisitTerminal(context.E_TLBracket, SymbolSyntaxKind.TLBracket);
                var tRBracket = (InternalSyntaxToken?)this.VisitTerminal(context.E_TRBracket, SymbolSyntaxKind.TRBracket);
                return _factory.ArrayDimensionsBlock1(tLBracket, tRBracket);
            }
            
            public override GreenNode? VisitPr_QualifierIdentifierBlock(SymbolParser.Pr_QualifierIdentifierBlockContext? context)
            {
                if (context == null) return QualifierIdentifierBlockGreen.__Missing;
                var tDot = (InternalSyntaxToken?)this.VisitTerminal(context.E_TDot1, SymbolSyntaxKind.TDot);
                IdentifierGreen? identifier = null;
                if (context.E_Identifier2 is not null) identifier = (IdentifierGreen?)this.Visit(context.E_Identifier2) ?? IdentifierGreen.__Missing;
                else identifier = IdentifierGreen.__Missing;
                return _factory.QualifierIdentifierBlock(tDot, identifier);
            }
        }
    }
}
