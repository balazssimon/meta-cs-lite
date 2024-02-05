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
                var kNamespace = (InternalSyntaxToken?)this.VisitTerminal(context.E_KNamespace, MetaSyntaxKind.KNamespace);
                QualifierGreen? qualifier = null;
                if (context.E_Qualifier is not null) qualifier = (QualifierGreen?)this.Visit(context.E_Qualifier) ?? QualifierGreen.__Missing;
                else qualifier = QualifierGreen.__Missing;
                var tSemicolon = (InternalSyntaxToken?)this.VisitTerminal(context.E_TSemicolon, MetaSyntaxKind.TSemicolon);
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
                var endOfFileToken = (InternalSyntaxToken?)this.VisitTerminal(context.E_EndOfFileToken, MetaSyntaxKind.Eof);
                return _factory.Main(kNamespace, qualifier, tSemicolon, usingList, block, endOfFileToken);
            }
            
            public override GreenNode? VisitPr_Using(MetaParser.Pr_UsingContext? context)
            {
                if (context == null) return UsingGreen.__Missing;
                var kUsing = (InternalSyntaxToken?)this.VisitTerminal(context.E_KUsing, MetaSyntaxKind.KUsing);
                QualifierGreen? namespaces = null;
                if (context.E_namespaces is not null) namespaces = (QualifierGreen?)this.Visit(context.E_namespaces) ?? QualifierGreen.__Missing;
                else namespaces = QualifierGreen.__Missing;
                var tSemicolon = (InternalSyntaxToken?)this.VisitTerminal(context.E_TSemicolon, MetaSyntaxKind.TSemicolon);
                return _factory.Using(kUsing, namespaces, tSemicolon);
            }
            
            public override GreenNode? VisitPr_MetaModel(MetaParser.Pr_MetaModelContext? context)
            {
                if (context == null) return MetaModelGreen.__Missing;
                var kMetamodel = (InternalSyntaxToken?)this.VisitTerminal(context.E_KMetamodel, MetaSyntaxKind.KMetamodel);
                NameGreen? name = null;
                if (context.E_Name is not null) name = (NameGreen?)this.Visit(context.E_Name) ?? NameGreen.__Missing;
                else name = NameGreen.__Missing;
                MetaModelBlock1Green? block = null;
                if (context.E_Block is not null) block = (MetaModelBlock1Green?)this.Visit(context.E_Block);
                var tSemicolon = (InternalSyntaxToken?)this.VisitTerminal(context.E_TSemicolon, MetaSyntaxKind.TSemicolon);
                return _factory.MetaModel(kMetamodel, name, block, tSemicolon);
            }
            
            public override GreenNode? VisitPr_MetaDeclarationAlt1(MetaParser.Pr_MetaDeclarationAlt1Context? context)
            {
                if (context == null) return MetaDeclarationAlt1Green.__Missing;
                MetaConstantGreen? metaConstant = null;
                if (context.E_MetaConstant is not null) metaConstant = (MetaConstantGreen?)this.Visit(context.E_MetaConstant) ?? MetaConstantGreen.__Missing;
                else metaConstant = MetaConstantGreen.__Missing;
                return _factory.MetaDeclarationAlt1(metaConstant);
            }
            
            public override GreenNode? VisitPr_MetaDeclarationAlt2(MetaParser.Pr_MetaDeclarationAlt2Context? context)
            {
                if (context == null) return MetaDeclarationAlt2Green.__Missing;
                MetaEnumGreen? metaEnum = null;
                if (context.E_MetaEnum is not null) metaEnum = (MetaEnumGreen?)this.Visit(context.E_MetaEnum) ?? MetaEnumGreen.__Missing;
                else metaEnum = MetaEnumGreen.__Missing;
                return _factory.MetaDeclarationAlt2(metaEnum);
            }
            
            public override GreenNode? VisitPr_MetaDeclarationAlt3(MetaParser.Pr_MetaDeclarationAlt3Context? context)
            {
                if (context == null) return MetaDeclarationAlt3Green.__Missing;
                MetaClassGreen? metaClass = null;
                if (context.E_MetaClass is not null) metaClass = (MetaClassGreen?)this.Visit(context.E_MetaClass) ?? MetaClassGreen.__Missing;
                else metaClass = MetaClassGreen.__Missing;
                return _factory.MetaDeclarationAlt3(metaClass);
            }
            
            public override GreenNode? VisitPr_MetaConstant(MetaParser.Pr_MetaConstantContext? context)
            {
                if (context == null) return MetaConstantGreen.__Missing;
                var kConst = (InternalSyntaxToken?)this.VisitTerminal(context.E_KConst, MetaSyntaxKind.KConst);
                MetaTypeReferenceGreen? type = null;
                if (context.E_type is not null) type = (MetaTypeReferenceGreen?)this.Visit(context.E_type) ?? MetaTypeReferenceGreen.__Missing;
                else type = MetaTypeReferenceGreen.__Missing;
                NameGreen? name = null;
                if (context.E_Name is not null) name = (NameGreen?)this.Visit(context.E_Name) ?? NameGreen.__Missing;
                else name = NameGreen.__Missing;
                var tSemicolon = (InternalSyntaxToken?)this.VisitTerminal(context.E_TSemicolon, MetaSyntaxKind.TSemicolon);
                return _factory.MetaConstant(kConst, type, name, tSemicolon);
            }
            
            public override GreenNode? VisitPr_MetaEnum(MetaParser.Pr_MetaEnumContext? context)
            {
                if (context == null) return MetaEnumGreen.__Missing;
                var kEnum = (InternalSyntaxToken?)this.VisitTerminal(context.E_KEnum, MetaSyntaxKind.KEnum);
                NameGreen? name = null;
                if (context.E_Name is not null) name = (NameGreen?)this.Visit(context.E_Name) ?? NameGreen.__Missing;
                else name = NameGreen.__Missing;
                MetaEnumBlock1Green? block = null;
                if (context.E_Block is not null) block = (MetaEnumBlock1Green?)this.Visit(context.E_Block) ?? MetaEnumBlock1Green.__Missing;
                else block = MetaEnumBlock1Green.__Missing;
                return _factory.MetaEnum(kEnum, name, block);
            }
            
            public override GreenNode? VisitPr_MetaEnumLiteral(MetaParser.Pr_MetaEnumLiteralContext? context)
            {
                if (context == null) return MetaEnumLiteralGreen.__Missing;
                NameGreen? name = null;
                if (context.E_Name is not null) name = (NameGreen?)this.Visit(context.E_Name) ?? NameGreen.__Missing;
                else name = NameGreen.__Missing;
                return _factory.MetaEnumLiteral(name);
            }
            
            public override GreenNode? VisitPr_MetaClass(MetaParser.Pr_MetaClassContext? context)
            {
                if (context == null) return MetaClassGreen.__Missing;
                var isAbstract = (InternalSyntaxToken?)this.VisitTerminal(context.E_isAbstract);
                var kClass = (InternalSyntaxToken?)this.VisitTerminal(context.E_KClass, MetaSyntaxKind.KClass);
                MetaClassBlock1Green? block1 = null;
                if (context.E_Block is not null) block1 = (MetaClassBlock1Green?)this.Visit(context.E_Block) ?? MetaClassBlock1Green.__Missing;
                else block1 = MetaClassBlock1Green.__Missing;
                MetaClassBlock2Green? block2 = null;
                if (context.E_Block1 is not null) block2 = (MetaClassBlock2Green?)this.Visit(context.E_Block1);
                MetaClassBlock3Green? block3 = null;
                if (context.E_Block2 is not null) block3 = (MetaClassBlock3Green?)this.Visit(context.E_Block2) ?? MetaClassBlock3Green.__Missing;
                else block3 = MetaClassBlock3Green.__Missing;
                return _factory.MetaClass(isAbstract, kClass, block1, block2, block3);
            }
            
            public override GreenNode? VisitPr_MetaProperty(MetaParser.Pr_MetaPropertyContext? context)
            {
                if (context == null) return MetaPropertyGreen.__Missing;
                MetaPropertyBlock1Green? block1 = null;
                if (context.E_Block is not null) block1 = (MetaPropertyBlock1Green?)this.Visit(context.E_Block);
                MetaTypeReferenceGreen? type = null;
                if (context.E_type is not null) type = (MetaTypeReferenceGreen?)this.Visit(context.E_type) ?? MetaTypeReferenceGreen.__Missing;
                else type = MetaTypeReferenceGreen.__Missing;
                MetaPropertyBlock2Green? block2 = null;
                if (context.E_Block1 is not null) block2 = (MetaPropertyBlock2Green?)this.Visit(context.E_Block1) ?? MetaPropertyBlock2Green.__Missing;
                else block2 = MetaPropertyBlock2Green.__Missing;
                MetaPropertyBlock3Green? block3 = null;
                if (context.E_Block2 is not null) block3 = (MetaPropertyBlock3Green?)this.Visit(context.E_Block2);
                var E_Block3Context = context._E_Block3;
                var block4Builder = _pool.Allocate<MetaPropertyBlock4Green>();
                for (int i = 0; i < E_Block3Context.Count; ++i)
                {
                    if (E_Block3Context[i] is not null) block4Builder.Add((MetaPropertyBlock4Green?)this.Visit(E_Block3Context[i]) ?? MetaPropertyBlock4Green.__Missing);
                    else block4Builder.Add(MetaPropertyBlock4Green.__Missing);
                }
                var block4 = block4Builder.ToList();
                _pool.Free(block4Builder);
                var tSemicolon = (InternalSyntaxToken?)this.VisitTerminal(context.E_TSemicolon, MetaSyntaxKind.TSemicolon);
                return _factory.MetaProperty(block1, type, block2, block3, block4, tSemicolon);
            }
            
            public override GreenNode? VisitPr_MetaOperation(MetaParser.Pr_MetaOperationContext? context)
            {
                if (context == null) return MetaOperationGreen.__Missing;
                MetaTypeReferenceGreen? returnType = null;
                if (context.E_returnType is not null) returnType = (MetaTypeReferenceGreen?)this.Visit(context.E_returnType) ?? MetaTypeReferenceGreen.__Missing;
                else returnType = MetaTypeReferenceGreen.__Missing;
                NameGreen? name = null;
                if (context.E_Name is not null) name = (NameGreen?)this.Visit(context.E_Name) ?? NameGreen.__Missing;
                else name = NameGreen.__Missing;
                var tLParen = (InternalSyntaxToken?)this.VisitTerminal(context.E_TLParen, MetaSyntaxKind.TLParen);
                MetaOperationBlock1Green? block = null;
                if (context.E_Block is not null) block = (MetaOperationBlock1Green?)this.Visit(context.E_Block);
                var tRParen = (InternalSyntaxToken?)this.VisitTerminal(context.E_TRParen, MetaSyntaxKind.TRParen);
                var tSemicolon = (InternalSyntaxToken?)this.VisitTerminal(context.E_TSemicolon, MetaSyntaxKind.TSemicolon);
                return _factory.MetaOperation(returnType, name, tLParen, block, tRParen, tSemicolon);
            }
            
            public override GreenNode? VisitPr_MetaParameter(MetaParser.Pr_MetaParameterContext? context)
            {
                if (context == null) return MetaParameterGreen.__Missing;
                MetaTypeReferenceGreen? type = null;
                if (context.E_type is not null) type = (MetaTypeReferenceGreen?)this.Visit(context.E_type) ?? MetaTypeReferenceGreen.__Missing;
                else type = MetaTypeReferenceGreen.__Missing;
                NameGreen? name = null;
                if (context.E_Name is not null) name = (NameGreen?)this.Visit(context.E_Name) ?? NameGreen.__Missing;
                else name = NameGreen.__Missing;
                return _factory.MetaParameter(type, name);
            }
            
            public override GreenNode? VisitPr_SimpleTypeReference(MetaParser.Pr_SimpleTypeReferenceContext? context)
            {
                if (context == null) return SimpleTypeReferenceGreen.__Missing;
                TypeReferenceGreen? typeReference = null;
                if (context.E_TypeReference is not null) typeReference = (TypeReferenceGreen?)this.Visit(context.E_TypeReference) ?? TypeReferenceGreen.__Missing;
                else typeReference = TypeReferenceGreen.__Missing;
                return _factory.SimpleTypeReference(typeReference);
            }
            
            public override GreenNode? VisitPr_MetaArrayType(MetaParser.Pr_MetaArrayTypeContext? context)
            {
                if (context == null) return MetaArrayTypeGreen.__Missing;
                MetaTypeReferenceGreen? itemType = null;
                if (context.E_itemType is not null) itemType = (MetaTypeReferenceGreen?)this.Visit(context.E_itemType) ?? MetaTypeReferenceGreen.__Missing;
                else itemType = MetaTypeReferenceGreen.__Missing;
                var tLBracket = (InternalSyntaxToken?)this.VisitTerminal(context.E_TLBracket, MetaSyntaxKind.TLBracket);
                var tRBracket = (InternalSyntaxToken?)this.VisitTerminal(context.E_TRBracket, MetaSyntaxKind.TRBracket);
                return _factory.MetaArrayType(itemType, tLBracket, tRBracket);
            }
            
            public override GreenNode? VisitPr_MetaNullableType(MetaParser.Pr_MetaNullableTypeContext? context)
            {
                if (context == null) return MetaNullableTypeGreen.__Missing;
                MetaTypeReferenceGreen? innerType = null;
                if (context.E_innerType is not null) innerType = (MetaTypeReferenceGreen?)this.Visit(context.E_innerType) ?? MetaTypeReferenceGreen.__Missing;
                else innerType = MetaTypeReferenceGreen.__Missing;
                var tQuestion = (InternalSyntaxToken?)this.VisitTerminal(context.E_TQuestion, MetaSyntaxKind.TQuestion);
                return _factory.MetaNullableType(innerType, tQuestion);
            }
            
            public override GreenNode? VisitPr_TypeReferenceAlt1(MetaParser.Pr_TypeReferenceAlt1Context? context)
            {
                if (context == null) return TypeReferenceAlt1Green.__Missing;
                PrimitiveTypeGreen? primitiveType = null;
                if (context.E_PrimitiveType is not null) primitiveType = (PrimitiveTypeGreen?)this.Visit(context.E_PrimitiveType) ?? PrimitiveTypeGreen.__Missing;
                else primitiveType = PrimitiveTypeGreen.__Missing;
                return _factory.TypeReferenceAlt1(primitiveType);
            }
            
            public override GreenNode? VisitPr_TypeReferenceAlt2(MetaParser.Pr_TypeReferenceAlt2Context? context)
            {
                if (context == null) return TypeReferenceAlt2Green.__Missing;
                QualifierGreen? qualifier = null;
                if (context.E_Qualifier is not null) qualifier = (QualifierGreen?)this.Visit(context.E_Qualifier) ?? QualifierGreen.__Missing;
                else qualifier = QualifierGreen.__Missing;
                return _factory.TypeReferenceAlt2(qualifier);
            }
            
            public override GreenNode? VisitPr_PrimitiveType(MetaParser.Pr_PrimitiveTypeContext? context)
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
            
            public override GreenNode? VisitPr_ValueAlt1(MetaParser.Pr_ValueAlt1Context? context)
            {
                if (context == null) return ValueAlt1Green.__Missing;
                var tString = (InternalSyntaxToken?)this.VisitTerminal(context.E_TString, MetaSyntaxKind.TString);
                return _factory.ValueAlt1(tString);
            }
            
            public override GreenNode? VisitPr_ValueAlt2(MetaParser.Pr_ValueAlt2Context? context)
            {
                if (context == null) return ValueAlt2Green.__Missing;
                var tInteger = (InternalSyntaxToken?)this.VisitTerminal(context.E_TInteger, MetaSyntaxKind.TInteger);
                return _factory.ValueAlt2(tInteger);
            }
            
            public override GreenNode? VisitPr_ValueAlt3(MetaParser.Pr_ValueAlt3Context? context)
            {
                if (context == null) return ValueAlt3Green.__Missing;
                var tDecimal = (InternalSyntaxToken?)this.VisitTerminal(context.E_TDecimal, MetaSyntaxKind.TDecimal);
                return _factory.ValueAlt3(tDecimal);
            }
            
            public override GreenNode? VisitPr_ValueAlt4(MetaParser.Pr_ValueAlt4Context? context)
            {
                if (context == null) return ValueAlt4Green.__Missing;
                TBooleanGreen? tBoolean = null;
                if (context.E_TBoolean is not null) tBoolean = (TBooleanGreen?)this.Visit(context.E_TBoolean) ?? TBooleanGreen.__Missing;
                else tBoolean = TBooleanGreen.__Missing;
                return _factory.ValueAlt4(tBoolean);
            }
            
            public override GreenNode? VisitPr_ValueAlt5(MetaParser.Pr_ValueAlt5Context? context)
            {
                if (context == null) return ValueAlt5Green.__Missing;
                var kNull = (InternalSyntaxToken?)this.VisitTerminal(context.E_KNull, MetaSyntaxKind.KNull);
                return _factory.ValueAlt5(kNull);
            }
            
            public override GreenNode? VisitPr_Name(MetaParser.Pr_NameContext? context)
            {
                if (context == null) return NameGreen.__Missing;
                IdentifierGreen? identifier = null;
                if (context.E_Identifier is not null) identifier = (IdentifierGreen?)this.Visit(context.E_Identifier) ?? IdentifierGreen.__Missing;
                else identifier = IdentifierGreen.__Missing;
                return _factory.Name(identifier);
            }
            
            public override GreenNode? VisitPr_Qualifier(MetaParser.Pr_QualifierContext? context)
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
                        identifierBuilder.AddSeparator((InternalSyntaxToken?)this.VisitTerminal(_separator, MetaSyntaxKind.TDot));
                    }
                    else
                    {
                        identifierBuilder.AddSeparator((InternalSyntaxToken?)this.VisitTerminal((IToken?)null, MetaSyntaxKind.TDot));
                    }
                    var _item = E_Identifier2Context[i];
                    if (_item is not null) identifierBuilder.Add((IdentifierGreen?)this.Visit(_item) ?? IdentifierGreen.__Missing);
                    else identifierBuilder.Add(IdentifierGreen.__Missing);
                }
                var identifier = identifierBuilder.ToList();
                _pool.Free(identifierBuilder);
                return _factory.Qualifier(identifier);
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
            
            public override GreenNode? VisitPr_TBoolean(MetaParser.Pr_TBooleanContext? context)
            {
                if (context == null) return TBooleanGreen.__Missing;
                InternalSyntaxToken? token = null;
                if (context.LR_KTrue() is not null) token = (InternalSyntaxToken?)this.VisitTerminal(context.LR_KTrue());
                if (context.LR_KFalse() is not null) token = (InternalSyntaxToken?)this.VisitTerminal(context.LR_KFalse());
                if (token is null) token = _factory.None;
                return _factory.TBoolean(token);
            }
            
            public override GreenNode? VisitPr_MainBlock1(MetaParser.Pr_MainBlock1Context? context)
            {
                if (context == null) return MainBlock1Green.__Missing;
                MetaModelGreen? declarations1 = null;
                if (context.E_declarations is not null) declarations1 = (MetaModelGreen?)this.Visit(context.E_declarations) ?? MetaModelGreen.__Missing;
                else declarations1 = MetaModelGreen.__Missing;
                var E_declarations1Context = context._E_declarations1;
                var declarations2Builder = _pool.Allocate<MetaDeclarationGreen>();
                for (int i = 0; i < E_declarations1Context.Count; ++i)
                {
                    if (E_declarations1Context[i] is not null) declarations2Builder.Add((MetaDeclarationGreen?)this.Visit(E_declarations1Context[i]) ?? MetaDeclarationGreen.__Missing);
                    else declarations2Builder.Add(MetaDeclarationGreen.__Missing);
                }
                var declarations2 = declarations2Builder.ToList();
                _pool.Free(declarations2Builder);
                return _factory.MainBlock1(declarations1, declarations2);
            }
            
            public override GreenNode? VisitPr_MetaModelBlock1(MetaParser.Pr_MetaModelBlock1Context? context)
            {
                if (context == null) return MetaModelBlock1Green.__Missing;
                var tEq = (InternalSyntaxToken?)this.VisitTerminal(context.E_TEq, MetaSyntaxKind.TEq);
                var uri = (InternalSyntaxToken?)this.VisitTerminal(context.E_uri, MetaSyntaxKind.TString);
                return _factory.MetaModelBlock1(tEq, uri);
            }
            
            public override GreenNode? VisitPr_MetaEnumBlock1(MetaParser.Pr_MetaEnumBlock1Context? context)
            {
                if (context == null) return MetaEnumBlock1Green.__Missing;
                var tLBrace = (InternalSyntaxToken?)this.VisitTerminal(context.E_TLBrace, MetaSyntaxKind.TLBrace);
                var literalsBuilder = _pool.AllocateSeparated<MetaEnumLiteralGreen>(reversed: false);
                var E_literals1Context = context.E_literals1;
                if (E_literals1Context is not null) literalsBuilder.Add((MetaEnumLiteralGreen?)this.Visit(E_literals1Context) ?? MetaEnumLiteralGreen.__Missing);
                else literalsBuilder.Add(MetaEnumLiteralGreen.__Missing);
                var E_literals2Context = context._E_literals2;
                var E_TComma1Context = context._E_TComma1;
                for (int i = 0; i < E_literals2Context.Count; ++i)
                {
                    if (i < E_TComma1Context.Count)
                    {
                        var _separator = E_TComma1Context[i];
                        literalsBuilder.AddSeparator((InternalSyntaxToken?)this.VisitTerminal(_separator, MetaSyntaxKind.TComma));
                    }
                    else
                    {
                        literalsBuilder.AddSeparator((InternalSyntaxToken?)this.VisitTerminal((IToken?)null, MetaSyntaxKind.TComma));
                    }
                    var _item = E_literals2Context[i];
                    if (_item is not null) literalsBuilder.Add((MetaEnumLiteralGreen?)this.Visit(_item) ?? MetaEnumLiteralGreen.__Missing);
                    else literalsBuilder.Add(MetaEnumLiteralGreen.__Missing);
                }
                var literals = literalsBuilder.ToList();
                _pool.Free(literalsBuilder);
                var tRBrace = (InternalSyntaxToken?)this.VisitTerminal(context.E_TRBrace, MetaSyntaxKind.TRBrace);
                return _factory.MetaEnumBlock1(tLBrace, literals, tRBrace);
            }
            
            public override GreenNode? VisitPr_MetaEnumBlock1literalsBlock(MetaParser.Pr_MetaEnumBlock1literalsBlockContext? context)
            {
                if (context == null) return MetaEnumBlock1literalsBlockGreen.__Missing;
                var tComma = (InternalSyntaxToken?)this.VisitTerminal(context.E_TComma1, MetaSyntaxKind.TComma);
                MetaEnumLiteralGreen? literals = null;
                if (context.E_literals2 is not null) literals = (MetaEnumLiteralGreen?)this.Visit(context.E_literals2) ?? MetaEnumLiteralGreen.__Missing;
                else literals = MetaEnumLiteralGreen.__Missing;
                return _factory.MetaEnumBlock1literalsBlock(tComma, literals);
            }
            
            public override GreenNode? VisitPr_MetaClassBlock1Alt1(MetaParser.Pr_MetaClassBlock1Alt1Context? context)
            {
                if (context == null) return MetaClassBlock1Alt1Green.__Missing;
                IdentifierGreen? identifier = null;
                if (context.E_Identifier is not null) identifier = (IdentifierGreen?)this.Visit(context.E_Identifier);
                var tDollar = (InternalSyntaxToken?)this.VisitTerminal(context.E_TDollar, MetaSyntaxKind.TDollar);
                IdentifierGreen? symbolType = null;
                if (context.E_symbolType is not null) symbolType = (IdentifierGreen?)this.Visit(context.E_symbolType) ?? IdentifierGreen.__Missing;
                else symbolType = IdentifierGreen.__Missing;
                return _factory.MetaClassBlock1Alt1(identifier, tDollar, symbolType);
            }
            
            public override GreenNode? VisitPr_MetaClassBlock1Alt2(MetaParser.Pr_MetaClassBlock1Alt2Context? context)
            {
                if (context == null) return MetaClassBlock1Alt2Green.__Missing;
                IdentifierGreen? identifier = null;
                if (context.E_Identifier1 is not null) identifier = (IdentifierGreen?)this.Visit(context.E_Identifier1) ?? IdentifierGreen.__Missing;
                else identifier = IdentifierGreen.__Missing;
                return _factory.MetaClassBlock1Alt2(identifier);
            }
            
            public override GreenNode? VisitPr_MetaClassBlock2(MetaParser.Pr_MetaClassBlock2Context? context)
            {
                if (context == null) return MetaClassBlock2Green.__Missing;
                var tColon = (InternalSyntaxToken?)this.VisitTerminal(context.E_TColon, MetaSyntaxKind.TColon);
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
                        baseTypesBuilder.AddSeparator((InternalSyntaxToken?)this.VisitTerminal(_separator, MetaSyntaxKind.TComma));
                    }
                    else
                    {
                        baseTypesBuilder.AddSeparator((InternalSyntaxToken?)this.VisitTerminal((IToken?)null, MetaSyntaxKind.TComma));
                    }
                    var _item = E_baseTypes2Context[i];
                    if (_item is not null) baseTypesBuilder.Add((QualifierGreen?)this.Visit(_item) ?? QualifierGreen.__Missing);
                    else baseTypesBuilder.Add(QualifierGreen.__Missing);
                }
                var baseTypes = baseTypesBuilder.ToList();
                _pool.Free(baseTypesBuilder);
                return _factory.MetaClassBlock2(tColon, baseTypes);
            }
            
            public override GreenNode? VisitPr_MetaClassBlock2baseTypesBlock(MetaParser.Pr_MetaClassBlock2baseTypesBlockContext? context)
            {
                if (context == null) return MetaClassBlock2baseTypesBlockGreen.__Missing;
                var tComma = (InternalSyntaxToken?)this.VisitTerminal(context.E_TComma1, MetaSyntaxKind.TComma);
                QualifierGreen? baseTypes = null;
                if (context.E_baseTypes2 is not null) baseTypes = (QualifierGreen?)this.Visit(context.E_baseTypes2) ?? QualifierGreen.__Missing;
                else baseTypes = QualifierGreen.__Missing;
                return _factory.MetaClassBlock2baseTypesBlock(tComma, baseTypes);
            }
            
            public override GreenNode? VisitPr_MetaClassBlock3(MetaParser.Pr_MetaClassBlock3Context? context)
            {
                if (context == null) return MetaClassBlock3Green.__Missing;
                var tLBrace = (InternalSyntaxToken?)this.VisitTerminal(context.E_TLBrace, MetaSyntaxKind.TLBrace);
                var E_BlockContext = context._E_Block;
                var blockBuilder = _pool.Allocate<MetaClassBlock3Block1Green>();
                for (int i = 0; i < E_BlockContext.Count; ++i)
                {
                    if (E_BlockContext[i] is not null) blockBuilder.Add((MetaClassBlock3Block1Green?)this.Visit(E_BlockContext[i]) ?? MetaClassBlock3Block1Green.__Missing);
                    else blockBuilder.Add(MetaClassBlock3Block1Green.__Missing);
                }
                var block = blockBuilder.ToList();
                _pool.Free(blockBuilder);
                var tRBrace = (InternalSyntaxToken?)this.VisitTerminal(context.E_TRBrace, MetaSyntaxKind.TRBrace);
                return _factory.MetaClassBlock3(tLBrace, block, tRBrace);
            }
            
            public override GreenNode? VisitPr_MetaClassBlock3Block1Alt1(MetaParser.Pr_MetaClassBlock3Block1Alt1Context? context)
            {
                if (context == null) return MetaClassBlock3Block1Alt1Green.__Missing;
                MetaPropertyGreen? properties = null;
                if (context.E_properties is not null) properties = (MetaPropertyGreen?)this.Visit(context.E_properties) ?? MetaPropertyGreen.__Missing;
                else properties = MetaPropertyGreen.__Missing;
                return _factory.MetaClassBlock3Block1Alt1(properties);
            }
            
            public override GreenNode? VisitPr_MetaClassBlock3Block1Alt2(MetaParser.Pr_MetaClassBlock3Block1Alt2Context? context)
            {
                if (context == null) return MetaClassBlock3Block1Alt2Green.__Missing;
                MetaOperationGreen? operations = null;
                if (context.E_operations is not null) operations = (MetaOperationGreen?)this.Visit(context.E_operations) ?? MetaOperationGreen.__Missing;
                else operations = MetaOperationGreen.__Missing;
                return _factory.MetaClassBlock3Block1Alt2(operations);
            }
            
            public override GreenNode? VisitPr_MetaPropertyBlock1Alt1(MetaParser.Pr_MetaPropertyBlock1Alt1Context? context)
            {
                if (context == null) return MetaPropertyBlock1Alt1Green.__Missing;
                var isContainment = (InternalSyntaxToken?)this.VisitTerminal(context.E_isContainment, MetaSyntaxKind.KContains);
                return _factory.MetaPropertyBlock1Alt1(isContainment);
            }
            
            public override GreenNode? VisitPr_MetaPropertyBlock1Alt2(MetaParser.Pr_MetaPropertyBlock1Alt2Context? context)
            {
                if (context == null) return MetaPropertyBlock1Alt2Green.__Missing;
                var isDerived = (InternalSyntaxToken?)this.VisitTerminal(context.E_isDerived, MetaSyntaxKind.KDerived);
                return _factory.MetaPropertyBlock1Alt2(isDerived);
            }
            
            public override GreenNode? VisitPr_MetaPropertyBlock1Alt3(MetaParser.Pr_MetaPropertyBlock1Alt3Context? context)
            {
                if (context == null) return MetaPropertyBlock1Alt3Green.__Missing;
                var isReadOnly = (InternalSyntaxToken?)this.VisitTerminal(context.E_isReadOnly, MetaSyntaxKind.KReadonly);
                return _factory.MetaPropertyBlock1Alt3(isReadOnly);
            }
            
            public override GreenNode? VisitPr_MetaPropertyBlock2Alt1(MetaParser.Pr_MetaPropertyBlock2Alt1Context? context)
            {
                if (context == null) return MetaPropertyBlock2Alt1Green.__Missing;
                IdentifierGreen? identifier = null;
                if (context.E_Identifier is not null) identifier = (IdentifierGreen?)this.Visit(context.E_Identifier);
                var tDollar = (InternalSyntaxToken?)this.VisitTerminal(context.E_TDollar, MetaSyntaxKind.TDollar);
                IdentifierGreen? symbolProperty = null;
                if (context.E_symbolProperty is not null) symbolProperty = (IdentifierGreen?)this.Visit(context.E_symbolProperty) ?? IdentifierGreen.__Missing;
                else symbolProperty = IdentifierGreen.__Missing;
                return _factory.MetaPropertyBlock2Alt1(identifier, tDollar, symbolProperty);
            }
            
            public override GreenNode? VisitPr_MetaPropertyBlock2Alt2(MetaParser.Pr_MetaPropertyBlock2Alt2Context? context)
            {
                if (context == null) return MetaPropertyBlock2Alt2Green.__Missing;
                IdentifierGreen? identifier = null;
                if (context.E_Identifier1 is not null) identifier = (IdentifierGreen?)this.Visit(context.E_Identifier1) ?? IdentifierGreen.__Missing;
                else identifier = IdentifierGreen.__Missing;
                return _factory.MetaPropertyBlock2Alt2(identifier);
            }
            
            public override GreenNode? VisitPr_MetaPropertyBlock3(MetaParser.Pr_MetaPropertyBlock3Context? context)
            {
                if (context == null) return MetaPropertyBlock3Green.__Missing;
                var tEq = (InternalSyntaxToken?)this.VisitTerminal(context.E_TEq, MetaSyntaxKind.TEq);
                ValueGreen? defaultValue = null;
                if (context.E_defaultValue is not null) defaultValue = (ValueGreen?)this.Visit(context.E_defaultValue) ?? ValueGreen.__Missing;
                else defaultValue = ValueGreen.__Missing;
                return _factory.MetaPropertyBlock3(tEq, defaultValue);
            }
            
            public override GreenNode? VisitPr_MetaPropertyBlock4Alt1(MetaParser.Pr_MetaPropertyBlock4Alt1Context? context)
            {
                if (context == null) return MetaPropertyBlock4Alt1Green.__Missing;
                var kOpposite = (InternalSyntaxToken?)this.VisitTerminal(context.E_KOpposite, MetaSyntaxKind.KOpposite);
                var oppositePropertiesBuilder = _pool.AllocateSeparated<QualifierGreen>(reversed: false);
                var E_oppositeProperties1Context = context.E_oppositeProperties1;
                if (E_oppositeProperties1Context is not null) oppositePropertiesBuilder.Add((QualifierGreen?)this.Visit(E_oppositeProperties1Context) ?? QualifierGreen.__Missing);
                else oppositePropertiesBuilder.Add(QualifierGreen.__Missing);
                var E_oppositeProperties2Context = context._E_oppositeProperties2;
                var E_TComma1Context = context._E_TComma1;
                for (int i = 0; i < E_oppositeProperties2Context.Count; ++i)
                {
                    if (i < E_TComma1Context.Count)
                    {
                        var _separator = E_TComma1Context[i];
                        oppositePropertiesBuilder.AddSeparator((InternalSyntaxToken?)this.VisitTerminal(_separator, MetaSyntaxKind.TComma));
                    }
                    else
                    {
                        oppositePropertiesBuilder.AddSeparator((InternalSyntaxToken?)this.VisitTerminal((IToken?)null, MetaSyntaxKind.TComma));
                    }
                    var _item = E_oppositeProperties2Context[i];
                    if (_item is not null) oppositePropertiesBuilder.Add((QualifierGreen?)this.Visit(_item) ?? QualifierGreen.__Missing);
                    else oppositePropertiesBuilder.Add(QualifierGreen.__Missing);
                }
                var oppositeProperties = oppositePropertiesBuilder.ToList();
                _pool.Free(oppositePropertiesBuilder);
                return _factory.MetaPropertyBlock4Alt1(kOpposite, oppositeProperties);
            }
            
            public override GreenNode? VisitPr_MetaPropertyBlock4Alt2(MetaParser.Pr_MetaPropertyBlock4Alt2Context? context)
            {
                if (context == null) return MetaPropertyBlock4Alt2Green.__Missing;
                var kSubsets = (InternalSyntaxToken?)this.VisitTerminal(context.E_KSubsets, MetaSyntaxKind.KSubsets);
                var subsettedPropertiesBuilder = _pool.AllocateSeparated<QualifierGreen>(reversed: false);
                var E_subsettedProperties1Context = context.E_subsettedProperties1;
                if (E_subsettedProperties1Context is not null) subsettedPropertiesBuilder.Add((QualifierGreen?)this.Visit(E_subsettedProperties1Context) ?? QualifierGreen.__Missing);
                else subsettedPropertiesBuilder.Add(QualifierGreen.__Missing);
                var E_subsettedProperties2Context = context._E_subsettedProperties2;
                var E_TComma2Context = context._E_TComma2;
                for (int i = 0; i < E_subsettedProperties2Context.Count; ++i)
                {
                    if (i < E_TComma2Context.Count)
                    {
                        var _separator = E_TComma2Context[i];
                        subsettedPropertiesBuilder.AddSeparator((InternalSyntaxToken?)this.VisitTerminal(_separator, MetaSyntaxKind.TComma));
                    }
                    else
                    {
                        subsettedPropertiesBuilder.AddSeparator((InternalSyntaxToken?)this.VisitTerminal((IToken?)null, MetaSyntaxKind.TComma));
                    }
                    var _item = E_subsettedProperties2Context[i];
                    if (_item is not null) subsettedPropertiesBuilder.Add((QualifierGreen?)this.Visit(_item) ?? QualifierGreen.__Missing);
                    else subsettedPropertiesBuilder.Add(QualifierGreen.__Missing);
                }
                var subsettedProperties = subsettedPropertiesBuilder.ToList();
                _pool.Free(subsettedPropertiesBuilder);
                return _factory.MetaPropertyBlock4Alt2(kSubsets, subsettedProperties);
            }
            
            public override GreenNode? VisitPr_MetaPropertyBlock4Alt3(MetaParser.Pr_MetaPropertyBlock4Alt3Context? context)
            {
                if (context == null) return MetaPropertyBlock4Alt3Green.__Missing;
                var kRedefines = (InternalSyntaxToken?)this.VisitTerminal(context.E_KRedefines, MetaSyntaxKind.KRedefines);
                var redefinedPropertiesBuilder = _pool.AllocateSeparated<QualifierGreen>(reversed: false);
                var E_redefinedProperties1Context = context.E_redefinedProperties1;
                if (E_redefinedProperties1Context is not null) redefinedPropertiesBuilder.Add((QualifierGreen?)this.Visit(E_redefinedProperties1Context) ?? QualifierGreen.__Missing);
                else redefinedPropertiesBuilder.Add(QualifierGreen.__Missing);
                var E_redefinedProperties2Context = context._E_redefinedProperties2;
                var E_TComma3Context = context._E_TComma3;
                for (int i = 0; i < E_redefinedProperties2Context.Count; ++i)
                {
                    if (i < E_TComma3Context.Count)
                    {
                        var _separator = E_TComma3Context[i];
                        redefinedPropertiesBuilder.AddSeparator((InternalSyntaxToken?)this.VisitTerminal(_separator, MetaSyntaxKind.TComma));
                    }
                    else
                    {
                        redefinedPropertiesBuilder.AddSeparator((InternalSyntaxToken?)this.VisitTerminal((IToken?)null, MetaSyntaxKind.TComma));
                    }
                    var _item = E_redefinedProperties2Context[i];
                    if (_item is not null) redefinedPropertiesBuilder.Add((QualifierGreen?)this.Visit(_item) ?? QualifierGreen.__Missing);
                    else redefinedPropertiesBuilder.Add(QualifierGreen.__Missing);
                }
                var redefinedProperties = redefinedPropertiesBuilder.ToList();
                _pool.Free(redefinedPropertiesBuilder);
                return _factory.MetaPropertyBlock4Alt3(kRedefines, redefinedProperties);
            }
            
            public override GreenNode? VisitPr_MetaPropertyBlock4Alt1oppositePropertiesBlock(MetaParser.Pr_MetaPropertyBlock4Alt1oppositePropertiesBlockContext? context)
            {
                if (context == null) return MetaPropertyBlock4Alt1oppositePropertiesBlockGreen.__Missing;
                var tComma = (InternalSyntaxToken?)this.VisitTerminal(context.E_TComma1, MetaSyntaxKind.TComma);
                QualifierGreen? oppositeProperties = null;
                if (context.E_oppositeProperties2 is not null) oppositeProperties = (QualifierGreen?)this.Visit(context.E_oppositeProperties2) ?? QualifierGreen.__Missing;
                else oppositeProperties = QualifierGreen.__Missing;
                return _factory.MetaPropertyBlock4Alt1oppositePropertiesBlock(tComma, oppositeProperties);
            }
            
            public override GreenNode? VisitPr_MetaPropertyBlock4Alt2subsettedPropertiesBlock(MetaParser.Pr_MetaPropertyBlock4Alt2subsettedPropertiesBlockContext? context)
            {
                if (context == null) return MetaPropertyBlock4Alt2subsettedPropertiesBlockGreen.__Missing;
                var tComma = (InternalSyntaxToken?)this.VisitTerminal(context.E_TComma2, MetaSyntaxKind.TComma);
                QualifierGreen? subsettedProperties = null;
                if (context.E_subsettedProperties2 is not null) subsettedProperties = (QualifierGreen?)this.Visit(context.E_subsettedProperties2) ?? QualifierGreen.__Missing;
                else subsettedProperties = QualifierGreen.__Missing;
                return _factory.MetaPropertyBlock4Alt2subsettedPropertiesBlock(tComma, subsettedProperties);
            }
            
            public override GreenNode? VisitPr_MetaPropertyBlock4Alt3redefinedPropertiesBlock(MetaParser.Pr_MetaPropertyBlock4Alt3redefinedPropertiesBlockContext? context)
            {
                if (context == null) return MetaPropertyBlock4Alt3redefinedPropertiesBlockGreen.__Missing;
                var tComma = (InternalSyntaxToken?)this.VisitTerminal(context.E_TComma3, MetaSyntaxKind.TComma);
                QualifierGreen? redefinedProperties = null;
                if (context.E_redefinedProperties2 is not null) redefinedProperties = (QualifierGreen?)this.Visit(context.E_redefinedProperties2) ?? QualifierGreen.__Missing;
                else redefinedProperties = QualifierGreen.__Missing;
                return _factory.MetaPropertyBlock4Alt3redefinedPropertiesBlock(tComma, redefinedProperties);
            }
            
            public override GreenNode? VisitPr_MetaOperationBlock1(MetaParser.Pr_MetaOperationBlock1Context? context)
            {
                if (context == null) return MetaOperationBlock1Green.__Missing;
                var parametersBuilder = _pool.AllocateSeparated<MetaParameterGreen>(reversed: false);
                var E_parameters1Context = context.E_parameters1;
                if (E_parameters1Context is not null) parametersBuilder.Add((MetaParameterGreen?)this.Visit(E_parameters1Context) ?? MetaParameterGreen.__Missing);
                else parametersBuilder.Add(MetaParameterGreen.__Missing);
                var E_parameters2Context = context._E_parameters2;
                var E_TComma1Context = context._E_TComma1;
                for (int i = 0; i < E_parameters2Context.Count; ++i)
                {
                    if (i < E_TComma1Context.Count)
                    {
                        var _separator = E_TComma1Context[i];
                        parametersBuilder.AddSeparator((InternalSyntaxToken?)this.VisitTerminal(_separator, MetaSyntaxKind.TComma));
                    }
                    else
                    {
                        parametersBuilder.AddSeparator((InternalSyntaxToken?)this.VisitTerminal((IToken?)null, MetaSyntaxKind.TComma));
                    }
                    var _item = E_parameters2Context[i];
                    if (_item is not null) parametersBuilder.Add((MetaParameterGreen?)this.Visit(_item) ?? MetaParameterGreen.__Missing);
                    else parametersBuilder.Add(MetaParameterGreen.__Missing);
                }
                var parameters = parametersBuilder.ToList();
                _pool.Free(parametersBuilder);
                return _factory.MetaOperationBlock1(parameters);
            }
            
            public override GreenNode? VisitPr_MetaOperationBlock1parametersBlock(MetaParser.Pr_MetaOperationBlock1parametersBlockContext? context)
            {
                if (context == null) return MetaOperationBlock1parametersBlockGreen.__Missing;
                var tComma = (InternalSyntaxToken?)this.VisitTerminal(context.E_TComma1, MetaSyntaxKind.TComma);
                MetaParameterGreen? parameters = null;
                if (context.E_parameters2 is not null) parameters = (MetaParameterGreen?)this.Visit(context.E_parameters2) ?? MetaParameterGreen.__Missing;
                else parameters = MetaParameterGreen.__Missing;
                return _factory.MetaOperationBlock1parametersBlock(tComma, parameters);
            }
            
            public override GreenNode? VisitPr_QualifierIdentifierBlock(MetaParser.Pr_QualifierIdentifierBlockContext? context)
            {
                if (context == null) return QualifierIdentifierBlockGreen.__Missing;
                var tDot = (InternalSyntaxToken?)this.VisitTerminal(context.E_TDot1, MetaSyntaxKind.TDot);
                IdentifierGreen? identifier = null;
                if (context.E_Identifier2 is not null) identifier = (IdentifierGreen?)this.Visit(context.E_Identifier2) ?? IdentifierGreen.__Missing;
                else identifier = IdentifierGreen.__Missing;
                return _factory.QualifierIdentifierBlock(tDot, identifier);
            }
        }
    }
}
