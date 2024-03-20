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
using MetaDslx.Examples.Soal.Compiler.Syntax.InternalSyntax;

#nullable enable

namespace MetaDslx.Examples.Soal.Compiler.Syntax
{
    public partial class SoalSyntaxParser : AntlrSyntaxParser
    {
        private readonly AntlrToRoslynVisitor _visitor;

        public SoalSyntaxParser(
            SoalSyntaxLexer lexer,
            IncrementalParseData? oldParseData,
            IEnumerable<TextChangeRange> changes,
            CancellationToken cancellationToken = default)
            : base(lexer, oldParseData, changes, cancellationToken)
        {
            _visitor = new AntlrToRoslynVisitor(this);
        }

        protected new SoalParser AntlrParser => (SoalParser)base.AntlrParser;

        protected override SyntaxNode ParseRoot()
        {
            ParserState? state = null;
            GreenNode? green = this.ParseMain(ref state);
            var red = (SoalSyntaxNode)green!.CreateRed();
            return red;
        }

        private GreenNode? ParseMain(ref ParserState? state)
        {
            return _visitor.VisitPr_Main(AntlrParser.pr_Main());
        }

        private class AntlrToRoslynVisitor : SoalParserBaseVisitor<GreenNode?>
        {
            // list pools - allocators for lists that are used to build sequences of nodes. The lists
            // can be reused (hence pooled) since the syntax factory methods don't keep references to
            // them
            private readonly SyntaxListPool _pool = new SyntaxListPool(); // Don't need to reset this.

            private readonly SoalSyntaxParser _parser;
            private readonly AntlrTokenStream _tokenStream;
            private readonly SoalInternalSyntaxFactory _factory;

            public AntlrToRoslynVisitor(SoalSyntaxParser parser)
            {
                _parser = parser;
                _tokenStream = (AntlrTokenStream)_parser.AntlrParser.InputStream;
                _factory = (SoalInternalSyntaxFactory)_parser.Language.InternalSyntaxFactory;
            }

            private GreenNode? VisitTerminal(IToken? token, SoalSyntaxKind kind)
            {
                if (token == null)
                {
                    if (kind != SoalSyntaxKind.None) return _tokenStream.ConsumeGreenToken(_factory.MissingToken(kind), _parser);
                    else return null;
                }
                var green = _tokenStream.ConsumeGreenToken(token, _parser);
                Debug.Assert(kind == SoalSyntaxKind.None || green.RawKind == (int)kind);
                return green;
            }

            public GreenNode? VisitTerminal(IToken? token)
            {
                return VisitTerminal(token, SoalSyntaxKind.None);
            }

            private GreenNode? VisitTerminal(ITerminalNode? node, SoalSyntaxKind kind)
            {
                if (node?.Symbol == null)
                {
                    if (kind != SoalSyntaxKind.None) return _tokenStream.ConsumeGreenToken(_factory.MissingToken(kind), _parser);
                    else return null;
                }
                var green = _tokenStream.ConsumeGreenToken(node.Symbol, _parser);
                Debug.Assert(kind == SoalSyntaxKind.None || green.RawKind == (int)kind);
                return green;
            }

            public override GreenNode? VisitTerminal(ITerminalNode? node)
            {
                return VisitTerminal(node, SoalSyntaxKind.None);
            }
            
            public override GreenNode? VisitPr_Main(SoalParser.Pr_MainContext? context)
            {
                if (context == null) return MainGreen.__Missing;
                var kNamespace = (InternalSyntaxToken?)this.VisitTerminal(context.E_KNamespace, SoalSyntaxKind.KNamespace);
                QualifierGreen? qualifier = null;
                if (context.E_Qualifier is not null) qualifier = (QualifierGreen?)this.Visit(context.E_Qualifier) ?? QualifierGreen.__Missing;
                else qualifier = QualifierGreen.__Missing;
                var tSemicolon = (InternalSyntaxToken?)this.VisitTerminal(context.E_TSemicolon, SoalSyntaxKind.TSemicolon);
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
                var endOfFileToken = (InternalSyntaxToken?)this.VisitTerminal(context.E_EndOfFileToken, SoalSyntaxKind.Eof);
                return _factory.Main(kNamespace, qualifier, tSemicolon, usingList, block, endOfFileToken);
            }
            
            public override GreenNode? VisitPr_Using(SoalParser.Pr_UsingContext? context)
            {
                if (context == null) return UsingGreen.__Missing;
                var kUsing = (InternalSyntaxToken?)this.VisitTerminal(context.E_KUsing, SoalSyntaxKind.KUsing);
                QualifierGreen? namespaces = null;
                if (context.E_namespaces is not null) namespaces = (QualifierGreen?)this.Visit(context.E_namespaces) ?? QualifierGreen.__Missing;
                else namespaces = QualifierGreen.__Missing;
                var tSemicolon = (InternalSyntaxToken?)this.VisitTerminal(context.E_TSemicolon, SoalSyntaxKind.TSemicolon);
                return _factory.Using(kUsing, namespaces, tSemicolon);
            }
            
            public override GreenNode? VisitPr_DeclarationAlt1(SoalParser.Pr_DeclarationAlt1Context? context)
            {
                if (context == null) return DeclarationAlt1Green.__Missing;
                EnumTypeGreen? enumType = null;
                if (context.E_EnumType is not null) enumType = (EnumTypeGreen?)this.Visit(context.E_EnumType) ?? EnumTypeGreen.__Missing;
                else enumType = EnumTypeGreen.__Missing;
                return _factory.DeclarationAlt1(enumType);
            }
            
            public override GreenNode? VisitPr_DeclarationAlt2(SoalParser.Pr_DeclarationAlt2Context? context)
            {
                if (context == null) return DeclarationAlt2Green.__Missing;
                StructTypeGreen? structType = null;
                if (context.E_StructType is not null) structType = (StructTypeGreen?)this.Visit(context.E_StructType) ?? StructTypeGreen.__Missing;
                else structType = StructTypeGreen.__Missing;
                return _factory.DeclarationAlt2(structType);
            }
            
            public override GreenNode? VisitPr_DeclarationAlt3(SoalParser.Pr_DeclarationAlt3Context? context)
            {
                if (context == null) return DeclarationAlt3Green.__Missing;
                InterfaceGreen? @interface = null;
                if (context.E_Interface is not null) @interface = (InterfaceGreen?)this.Visit(context.E_Interface) ?? InterfaceGreen.__Missing;
                else @interface = InterfaceGreen.__Missing;
                return _factory.DeclarationAlt3(@interface);
            }
            
            public override GreenNode? VisitPr_DeclarationAlt4(SoalParser.Pr_DeclarationAlt4Context? context)
            {
                if (context == null) return DeclarationAlt4Green.__Missing;
                ServiceGreen? service = null;
                if (context.E_Service is not null) service = (ServiceGreen?)this.Visit(context.E_Service) ?? ServiceGreen.__Missing;
                else service = ServiceGreen.__Missing;
                return _factory.DeclarationAlt4(service);
            }
            
            public override GreenNode? VisitPr_EnumType(SoalParser.Pr_EnumTypeContext? context)
            {
                if (context == null) return EnumTypeGreen.__Missing;
                var kEnum = (InternalSyntaxToken?)this.VisitTerminal(context.E_KEnum, SoalSyntaxKind.KEnum);
                NameGreen? name = null;
                if (context.E_Name is not null) name = (NameGreen?)this.Visit(context.E_Name) ?? NameGreen.__Missing;
                else name = NameGreen.__Missing;
                var tLBrace = (InternalSyntaxToken?)this.VisitTerminal(context.E_TLBrace, SoalSyntaxKind.TLBrace);
                EnumTypeBlock1Green? block = null;
                if (context.E_Block is not null) block = (EnumTypeBlock1Green?)this.Visit(context.E_Block);
                var tRBrace = (InternalSyntaxToken?)this.VisitTerminal(context.E_TRBrace, SoalSyntaxKind.TRBrace);
                return _factory.EnumType(kEnum, name, tLBrace, block, tRBrace);
            }
            
            public override GreenNode? VisitPr_EnumLiteral(SoalParser.Pr_EnumLiteralContext? context)
            {
                if (context == null) return EnumLiteralGreen.__Missing;
                NameGreen? name = null;
                if (context.E_Name is not null) name = (NameGreen?)this.Visit(context.E_Name) ?? NameGreen.__Missing;
                else name = NameGreen.__Missing;
                return _factory.EnumLiteral(name);
            }
            
            public override GreenNode? VisitPr_StructType(SoalParser.Pr_StructTypeContext? context)
            {
                if (context == null) return StructTypeGreen.__Missing;
                var kStruct = (InternalSyntaxToken?)this.VisitTerminal(context.E_KStruct, SoalSyntaxKind.KStruct);
                NameGreen? name = null;
                if (context.E_Name is not null) name = (NameGreen?)this.Visit(context.E_Name) ?? NameGreen.__Missing;
                else name = NameGreen.__Missing;
                StructTypeBlock1Green? block = null;
                if (context.E_Block is not null) block = (StructTypeBlock1Green?)this.Visit(context.E_Block);
                var tLBrace = (InternalSyntaxToken?)this.VisitTerminal(context.E_TLBrace, SoalSyntaxKind.TLBrace);
                var E_fieldsContext = context._E_fields;
                var fieldsBuilder = _pool.Allocate<PropertyGreen>();
                for (int i = 0; i < E_fieldsContext.Count; ++i)
                {
                    if (E_fieldsContext[i] is not null) fieldsBuilder.Add((PropertyGreen?)this.Visit(E_fieldsContext[i]) ?? PropertyGreen.__Missing);
                    else fieldsBuilder.Add(PropertyGreen.__Missing);
                }
                var fields = fieldsBuilder.ToList();
                _pool.Free(fieldsBuilder);
                var tRBrace = (InternalSyntaxToken?)this.VisitTerminal(context.E_TRBrace, SoalSyntaxKind.TRBrace);
                return _factory.StructType(kStruct, name, block, tLBrace, fields, tRBrace);
            }
            
            public override GreenNode? VisitPr_Property(SoalParser.Pr_PropertyContext? context)
            {
                if (context == null) return PropertyGreen.__Missing;
                TypeReferenceGreen? type = null;
                if (context.E_type is not null) type = (TypeReferenceGreen?)this.Visit(context.E_type) ?? TypeReferenceGreen.__Missing;
                else type = TypeReferenceGreen.__Missing;
                NameGreen? name = null;
                if (context.E_Name is not null) name = (NameGreen?)this.Visit(context.E_Name) ?? NameGreen.__Missing;
                else name = NameGreen.__Missing;
                var tSemicolon = (InternalSyntaxToken?)this.VisitTerminal(context.E_TSemicolon, SoalSyntaxKind.TSemicolon);
                return _factory.Property(type, name, tSemicolon);
            }
            
            public override GreenNode? VisitPr_Interface(SoalParser.Pr_InterfaceContext? context)
            {
                if (context == null) return InterfaceGreen.__Missing;
                var kInterface = (InternalSyntaxToken?)this.VisitTerminal(context.E_KInterface, SoalSyntaxKind.KInterface);
                NameGreen? name = null;
                if (context.E_Name is not null) name = (NameGreen?)this.Visit(context.E_Name) ?? NameGreen.__Missing;
                else name = NameGreen.__Missing;
                var tLBrace = (InternalSyntaxToken?)this.VisitTerminal(context.E_TLBrace, SoalSyntaxKind.TLBrace);
                var E_resourcesContext = context._E_resources;
                var resourcesBuilder = _pool.Allocate<ResourceGreen>();
                for (int i = 0; i < E_resourcesContext.Count; ++i)
                {
                    if (E_resourcesContext[i] is not null) resourcesBuilder.Add((ResourceGreen?)this.Visit(E_resourcesContext[i]) ?? ResourceGreen.__Missing);
                    else resourcesBuilder.Add(ResourceGreen.__Missing);
                }
                var resources = resourcesBuilder.ToList();
                _pool.Free(resourcesBuilder);
                var E_operationsContext = context._E_operations;
                var operationsBuilder = _pool.Allocate<OperationGreen>();
                for (int i = 0; i < E_operationsContext.Count; ++i)
                {
                    if (E_operationsContext[i] is not null) operationsBuilder.Add((OperationGreen?)this.Visit(E_operationsContext[i]) ?? OperationGreen.__Missing);
                    else operationsBuilder.Add(OperationGreen.__Missing);
                }
                var operations = operationsBuilder.ToList();
                _pool.Free(operationsBuilder);
                var tRBrace = (InternalSyntaxToken?)this.VisitTerminal(context.E_TRBrace, SoalSyntaxKind.TRBrace);
                return _factory.Interface(kInterface, name, tLBrace, resources, operations, tRBrace);
            }
            
            public override GreenNode? VisitPr_Resource(SoalParser.Pr_ResourceContext? context)
            {
                if (context == null) return ResourceGreen.__Missing;
                var isReadOnly = (InternalSyntaxToken?)this.VisitTerminal(context.E_isReadOnly);
                var kResource = (InternalSyntaxToken?)this.VisitTerminal(context.E_KResource, SoalSyntaxKind.KResource);
                QualifierGreen? entity = null;
                if (context.E_entity is not null) entity = (QualifierGreen?)this.Visit(context.E_entity) ?? QualifierGreen.__Missing;
                else entity = QualifierGreen.__Missing;
                ResourceBlock1Green? block = null;
                if (context.E_Block is not null) block = (ResourceBlock1Green?)this.Visit(context.E_Block);
                var tSemicolon = (InternalSyntaxToken?)this.VisitTerminal(context.E_TSemicolon, SoalSyntaxKind.TSemicolon);
                return _factory.Resource(isReadOnly, kResource, entity, block, tSemicolon);
            }
            
            public override GreenNode? VisitPr_Operation(SoalParser.Pr_OperationContext? context)
            {
                if (context == null) return OperationGreen.__Missing;
                var isAsync = (InternalSyntaxToken?)this.VisitTerminal(context.E_isAsync);
                OutputParameterListGreen? responseParameters = null;
                if (context.E_responseParameters is not null) responseParameters = (OutputParameterListGreen?)this.Visit(context.E_responseParameters) ?? OutputParameterListGreen.__Missing;
                else responseParameters = OutputParameterListGreen.__Missing;
                NameGreen? name = null;
                if (context.E_Name is not null) name = (NameGreen?)this.Visit(context.E_Name) ?? NameGreen.__Missing;
                else name = NameGreen.__Missing;
                InputParameterListGreen? requestParameters = null;
                if (context.E_requestParameters is not null) requestParameters = (InputParameterListGreen?)this.Visit(context.E_requestParameters) ?? InputParameterListGreen.__Missing;
                else requestParameters = InputParameterListGreen.__Missing;
                OperationBlock1Green? block = null;
                if (context.E_Block is not null) block = (OperationBlock1Green?)this.Visit(context.E_Block);
                var tSemicolon = (InternalSyntaxToken?)this.VisitTerminal(context.E_TSemicolon, SoalSyntaxKind.TSemicolon);
                return _factory.Operation(isAsync, responseParameters, name, requestParameters, block, tSemicolon);
            }
            
            public override GreenNode? VisitPr_InputParameterList(SoalParser.Pr_InputParameterListContext? context)
            {
                if (context == null) return InputParameterListGreen.__Missing;
                var tLParen = (InternalSyntaxToken?)this.VisitTerminal(context.E_TLParen, SoalSyntaxKind.TLParen);
                InputParameterListBlock1Green? block = null;
                if (context.E_Block is not null) block = (InputParameterListBlock1Green?)this.Visit(context.E_Block);
                var tRParen = (InternalSyntaxToken?)this.VisitTerminal(context.E_TRParen, SoalSyntaxKind.TRParen);
                return _factory.InputParameterList(tLParen, block, tRParen);
            }
            
            public override GreenNode? VisitPr_OutputParameterListAlt1(SoalParser.Pr_OutputParameterListAlt1Context? context)
            {
                if (context == null) return OutputParameterListAlt1Green.__Missing;
                var kVoid = (InternalSyntaxToken?)this.VisitTerminal(context.E_KVoid, SoalSyntaxKind.KVoid);
                return _factory.OutputParameterListAlt1(kVoid);
            }
            
            public override GreenNode? VisitPr_OutputParameterListAlt2(SoalParser.Pr_OutputParameterListAlt2Context? context)
            {
                if (context == null) return OutputParameterListAlt2Green.__Missing;
                SingleReturnParameterGreen? parameters = null;
                if (context.E_parameters is not null) parameters = (SingleReturnParameterGreen?)this.Visit(context.E_parameters) ?? SingleReturnParameterGreen.__Missing;
                else parameters = SingleReturnParameterGreen.__Missing;
                return _factory.OutputParameterListAlt2(parameters);
            }
            
            public override GreenNode? VisitPr_OutputParameterListAlt3(SoalParser.Pr_OutputParameterListAlt3Context? context)
            {
                if (context == null) return OutputParameterListAlt3Green.__Missing;
                var tLParen = (InternalSyntaxToken?)this.VisitTerminal(context.E_TLParen, SoalSyntaxKind.TLParen);
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
                        parametersBuilder.AddSeparator((InternalSyntaxToken?)this.VisitTerminal(_separator, SoalSyntaxKind.TComma));
                    }
                    else
                    {
                        parametersBuilder.AddSeparator((InternalSyntaxToken?)this.VisitTerminal((IToken?)null, SoalSyntaxKind.TComma));
                    }
                    var _item = E_parameters2Context[i];
                    if (_item is not null) parametersBuilder.Add((ParameterGreen?)this.Visit(_item) ?? ParameterGreen.__Missing);
                    else parametersBuilder.Add(ParameterGreen.__Missing);
                }
                var parameters = parametersBuilder.ToList();
                _pool.Free(parametersBuilder);
                var tRParen = (InternalSyntaxToken?)this.VisitTerminal(context.E_TRParen, SoalSyntaxKind.TRParen);
                return _factory.OutputParameterListAlt3(tLParen, parameters, tRParen);
            }
            
            public override GreenNode? VisitPr_Parameter(SoalParser.Pr_ParameterContext? context)
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
            
            public override GreenNode? VisitPr_SingleReturnParameter(SoalParser.Pr_SingleReturnParameterContext? context)
            {
                if (context == null) return SingleReturnParameterGreen.__Missing;
                TypeReferenceGreen? type = null;
                if (context.E_type is not null) type = (TypeReferenceGreen?)this.Visit(context.E_type) ?? TypeReferenceGreen.__Missing;
                else type = TypeReferenceGreen.__Missing;
                return _factory.SingleReturnParameter(type);
            }
            
            public override GreenNode? VisitPr_Service(SoalParser.Pr_ServiceContext? context)
            {
                if (context == null) return ServiceGreen.__Missing;
                var kService = (InternalSyntaxToken?)this.VisitTerminal(context.E_KService, SoalSyntaxKind.KService);
                NameGreen? name = null;
                if (context.E_Name is not null) name = (NameGreen?)this.Visit(context.E_Name) ?? NameGreen.__Missing;
                else name = NameGreen.__Missing;
                var tColon = (InternalSyntaxToken?)this.VisitTerminal(context.E_TColon, SoalSyntaxKind.TColon);
                QualifierGreen? @interface = null;
                if (context.E_interface is not null) @interface = (QualifierGreen?)this.Visit(context.E_interface) ?? QualifierGreen.__Missing;
                else @interface = QualifierGreen.__Missing;
                var tLBrace = (InternalSyntaxToken?)this.VisitTerminal(context.E_TLBrace, SoalSyntaxKind.TLBrace);
                var kBinding = (InternalSyntaxToken?)this.VisitTerminal(context.E_KBinding, SoalSyntaxKind.KBinding);
                BindingKindGreen? binding = null;
                if (context.E_binding is not null) binding = (BindingKindGreen?)this.Visit(context.E_binding) ?? BindingKindGreen.__Missing;
                else binding = BindingKindGreen.__Missing;
                var tSemicolon = (InternalSyntaxToken?)this.VisitTerminal(context.E_TSemicolon, SoalSyntaxKind.TSemicolon);
                var tRBrace = (InternalSyntaxToken?)this.VisitTerminal(context.E_TRBrace, SoalSyntaxKind.TRBrace);
                return _factory.Service(kService, name, tColon, @interface, tLBrace, kBinding, binding, tSemicolon, tRBrace);
            }
            
            public override GreenNode? VisitPr_BindingKind(SoalParser.Pr_BindingKindContext? context)
            {
                if (context?.E_Token == null) return BindingKindGreen.__Missing;
                InternalSyntaxToken? token = null;
                if (context.LR_KREST() is not null) token = (InternalSyntaxToken?)this.VisitTerminal(context.LR_KREST());
                if (context.LR_KSOAP() is not null) token = (InternalSyntaxToken?)this.VisitTerminal(context.LR_KSOAP());
                if (token is null) token = (InternalSyntaxToken?)this.VisitTerminal((IToken?)null, SoalSyntaxKind.KREST);
                return _factory.BindingKind(token);
            }
            
            public override GreenNode? VisitPr_TypeReference(SoalParser.Pr_TypeReferenceContext? context)
            {
                if (context == null) return TypeReferenceGreen.__Missing;
                SimpleTypeGreen? type = null;
                if (context.E_type is not null) type = (SimpleTypeGreen?)this.Visit(context.E_type) ?? SimpleTypeGreen.__Missing;
                else type = SimpleTypeGreen.__Missing;
                var isNullable = (InternalSyntaxToken?)this.VisitTerminal(context.E_isNullable);
                TypeReferenceBlock1Green? isArray = null;
                if (context.E_isArray is not null) isArray = (TypeReferenceBlock1Green?)this.Visit(context.E_isArray);
                return _factory.TypeReference(type, isNullable, isArray);
            }
            
            public override GreenNode? VisitPr_SimpleTypeAlt1(SoalParser.Pr_SimpleTypeAlt1Context? context)
            {
                if (context == null) return SimpleTypeAlt1Green.__Missing;
                var kObject = (InternalSyntaxToken?)this.VisitTerminal(context.E_KObject, SoalSyntaxKind.KObject);
                return _factory.SimpleTypeAlt1(kObject);
            }
            
            public override GreenNode? VisitPr_SimpleTypeAlt2(SoalParser.Pr_SimpleTypeAlt2Context? context)
            {
                if (context == null) return SimpleTypeAlt2Green.__Missing;
                var kBinary = (InternalSyntaxToken?)this.VisitTerminal(context.E_KBinary, SoalSyntaxKind.KBinary);
                return _factory.SimpleTypeAlt2(kBinary);
            }
            
            public override GreenNode? VisitPr_SimpleTypeAlt3(SoalParser.Pr_SimpleTypeAlt3Context? context)
            {
                if (context == null) return SimpleTypeAlt3Green.__Missing;
                var kBool = (InternalSyntaxToken?)this.VisitTerminal(context.E_KBool, SoalSyntaxKind.KBool);
                return _factory.SimpleTypeAlt3(kBool);
            }
            
            public override GreenNode? VisitPr_SimpleTypeAlt4(SoalParser.Pr_SimpleTypeAlt4Context? context)
            {
                if (context == null) return SimpleTypeAlt4Green.__Missing;
                var kString = (InternalSyntaxToken?)this.VisitTerminal(context.E_KString, SoalSyntaxKind.KString);
                return _factory.SimpleTypeAlt4(kString);
            }
            
            public override GreenNode? VisitPr_SimpleTypeAlt5(SoalParser.Pr_SimpleTypeAlt5Context? context)
            {
                if (context == null) return SimpleTypeAlt5Green.__Missing;
                var kInt = (InternalSyntaxToken?)this.VisitTerminal(context.E_KInt, SoalSyntaxKind.KInt);
                return _factory.SimpleTypeAlt5(kInt);
            }
            
            public override GreenNode? VisitPr_SimpleTypeAlt6(SoalParser.Pr_SimpleTypeAlt6Context? context)
            {
                if (context == null) return SimpleTypeAlt6Green.__Missing;
                var kLong = (InternalSyntaxToken?)this.VisitTerminal(context.E_KLong, SoalSyntaxKind.KLong);
                return _factory.SimpleTypeAlt6(kLong);
            }
            
            public override GreenNode? VisitPr_SimpleTypeAlt7(SoalParser.Pr_SimpleTypeAlt7Context? context)
            {
                if (context == null) return SimpleTypeAlt7Green.__Missing;
                var kFloat = (InternalSyntaxToken?)this.VisitTerminal(context.E_KFloat, SoalSyntaxKind.KFloat);
                return _factory.SimpleTypeAlt7(kFloat);
            }
            
            public override GreenNode? VisitPr_SimpleTypeAlt8(SoalParser.Pr_SimpleTypeAlt8Context? context)
            {
                if (context == null) return SimpleTypeAlt8Green.__Missing;
                var kDouble = (InternalSyntaxToken?)this.VisitTerminal(context.E_KDouble, SoalSyntaxKind.KDouble);
                return _factory.SimpleTypeAlt8(kDouble);
            }
            
            public override GreenNode? VisitPr_SimpleTypeAlt9(SoalParser.Pr_SimpleTypeAlt9Context? context)
            {
                if (context == null) return SimpleTypeAlt9Green.__Missing;
                var kDate = (InternalSyntaxToken?)this.VisitTerminal(context.E_KDate, SoalSyntaxKind.KDate);
                return _factory.SimpleTypeAlt9(kDate);
            }
            
            public override GreenNode? VisitPr_SimpleTypeAlt10(SoalParser.Pr_SimpleTypeAlt10Context? context)
            {
                if (context == null) return SimpleTypeAlt10Green.__Missing;
                var kTime = (InternalSyntaxToken?)this.VisitTerminal(context.E_KTime, SoalSyntaxKind.KTime);
                return _factory.SimpleTypeAlt10(kTime);
            }
            
            public override GreenNode? VisitPr_SimpleTypeAlt11(SoalParser.Pr_SimpleTypeAlt11Context? context)
            {
                if (context == null) return SimpleTypeAlt11Green.__Missing;
                var kDatetime = (InternalSyntaxToken?)this.VisitTerminal(context.E_KDatetime, SoalSyntaxKind.KDatetime);
                return _factory.SimpleTypeAlt11(kDatetime);
            }
            
            public override GreenNode? VisitPr_SimpleTypeAlt12(SoalParser.Pr_SimpleTypeAlt12Context? context)
            {
                if (context == null) return SimpleTypeAlt12Green.__Missing;
                var kDuration = (InternalSyntaxToken?)this.VisitTerminal(context.E_KDuration, SoalSyntaxKind.KDuration);
                return _factory.SimpleTypeAlt12(kDuration);
            }
            
            public override GreenNode? VisitPr_SimpleTypeAlt13(SoalParser.Pr_SimpleTypeAlt13Context? context)
            {
                if (context == null) return SimpleTypeAlt13Green.__Missing;
                QualifierGreen? qualifier = null;
                if (context.E_Qualifier is not null) qualifier = (QualifierGreen?)this.Visit(context.E_Qualifier) ?? QualifierGreen.__Missing;
                else qualifier = QualifierGreen.__Missing;
                return _factory.SimpleTypeAlt13(qualifier);
            }
            
            public override GreenNode? VisitPr_Name(SoalParser.Pr_NameContext? context)
            {
                if (context == null) return NameGreen.__Missing;
                IdentifierGreen? identifier = null;
                if (context.E_Identifier is not null) identifier = (IdentifierGreen?)this.Visit(context.E_Identifier) ?? IdentifierGreen.__Missing;
                else identifier = IdentifierGreen.__Missing;
                return _factory.Name(identifier);
            }
            
            public override GreenNode? VisitPr_Qualifier(SoalParser.Pr_QualifierContext? context)
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
                        identifierBuilder.AddSeparator((InternalSyntaxToken?)this.VisitTerminal(_separator, SoalSyntaxKind.TDot));
                    }
                    else
                    {
                        identifierBuilder.AddSeparator((InternalSyntaxToken?)this.VisitTerminal((IToken?)null, SoalSyntaxKind.TDot));
                    }
                    var _item = E_Identifier2Context[i];
                    if (_item is not null) identifierBuilder.Add((IdentifierGreen?)this.Visit(_item) ?? IdentifierGreen.__Missing);
                    else identifierBuilder.Add(IdentifierGreen.__Missing);
                }
                var identifier = identifierBuilder.ToList();
                _pool.Free(identifierBuilder);
                return _factory.Qualifier(identifier);
            }
            
            public override GreenNode? VisitPr_Identifier(SoalParser.Pr_IdentifierContext? context)
            {
                if (context?.E_Token == null) return IdentifierGreen.__Missing;
                InternalSyntaxToken? token = null;
                if (context.LR_TIdentifier() is not null) token = (InternalSyntaxToken?)this.VisitTerminal(context.LR_TIdentifier());
                if (context.LR_TVerbatimIdentifier() is not null) token = (InternalSyntaxToken?)this.VisitTerminal(context.LR_TVerbatimIdentifier());
                if (token is null) token = (InternalSyntaxToken?)this.VisitTerminal((IToken?)null, SoalSyntaxKind.TIdentifier);
                return _factory.Identifier(token);
            }
            
            public override GreenNode? VisitPr_MainBlock1(SoalParser.Pr_MainBlock1Context? context)
            {
                if (context == null) return MainBlock1Green.__Missing;
                var E_DeclarationListContext = context._E_DeclarationList;
                var declarationListBuilder = _pool.Allocate<DeclarationGreen>();
                for (int i = 0; i < E_DeclarationListContext.Count; ++i)
                {
                    if (E_DeclarationListContext[i] is not null) declarationListBuilder.Add((DeclarationGreen?)this.Visit(E_DeclarationListContext[i]) ?? DeclarationGreen.__Missing);
                    else declarationListBuilder.Add(DeclarationGreen.__Missing);
                }
                var declarationList = declarationListBuilder.ToList();
                _pool.Free(declarationListBuilder);
                return _factory.MainBlock1(declarationList);
            }
            
            public override GreenNode? VisitPr_EnumTypeBlock1(SoalParser.Pr_EnumTypeBlock1Context? context)
            {
                if (context == null) return EnumTypeBlock1Green.__Missing;
                var literalsBuilder = _pool.AllocateSeparated<EnumLiteralGreen>(reversed: false);
                var E_literals1Context = context.E_literals1;
                if (E_literals1Context is not null) literalsBuilder.Add((EnumLiteralGreen?)this.Visit(E_literals1Context) ?? EnumLiteralGreen.__Missing);
                else literalsBuilder.Add(EnumLiteralGreen.__Missing);
                var E_literals2Context = context._E_literals2;
                var E_TComma1Context = context._E_TComma1;
                for (int i = 0; i < E_literals2Context.Count; ++i)
                {
                    if (i < E_TComma1Context.Count)
                    {
                        var _separator = E_TComma1Context[i];
                        literalsBuilder.AddSeparator((InternalSyntaxToken?)this.VisitTerminal(_separator, SoalSyntaxKind.TComma));
                    }
                    else
                    {
                        literalsBuilder.AddSeparator((InternalSyntaxToken?)this.VisitTerminal((IToken?)null, SoalSyntaxKind.TComma));
                    }
                    var _item = E_literals2Context[i];
                    if (_item is not null) literalsBuilder.Add((EnumLiteralGreen?)this.Visit(_item) ?? EnumLiteralGreen.__Missing);
                    else literalsBuilder.Add(EnumLiteralGreen.__Missing);
                }
                var literals = literalsBuilder.ToList();
                _pool.Free(literalsBuilder);
                return _factory.EnumTypeBlock1(literals);
            }
            
            public override GreenNode? VisitPr_EnumTypeBlock1literalsBlock(SoalParser.Pr_EnumTypeBlock1literalsBlockContext? context)
            {
                if (context == null) return EnumTypeBlock1literalsBlockGreen.__Missing;
                var tComma = (InternalSyntaxToken?)this.VisitTerminal(context.E_TComma1, SoalSyntaxKind.TComma);
                EnumLiteralGreen? literals = null;
                if (context.E_literals2 is not null) literals = (EnumLiteralGreen?)this.Visit(context.E_literals2) ?? EnumLiteralGreen.__Missing;
                else literals = EnumLiteralGreen.__Missing;
                return _factory.EnumTypeBlock1literalsBlock(tComma, literals);
            }
            
            public override GreenNode? VisitPr_StructTypeBlock1(SoalParser.Pr_StructTypeBlock1Context? context)
            {
                if (context == null) return StructTypeBlock1Green.__Missing;
                var tColon = (InternalSyntaxToken?)this.VisitTerminal(context.E_TColon, SoalSyntaxKind.TColon);
                QualifierGreen? baseType = null;
                if (context.E_baseType is not null) baseType = (QualifierGreen?)this.Visit(context.E_baseType) ?? QualifierGreen.__Missing;
                else baseType = QualifierGreen.__Missing;
                return _factory.StructTypeBlock1(tColon, baseType);
            }
            
            public override GreenNode? VisitPr_ResourceBlock1(SoalParser.Pr_ResourceBlock1Context? context)
            {
                if (context == null) return ResourceBlock1Green.__Missing;
                var kThrows = (InternalSyntaxToken?)this.VisitTerminal(context.E_KThrows, SoalSyntaxKind.KThrows);
                var exceptionsBuilder = _pool.AllocateSeparated<QualifierGreen>(reversed: false);
                var E_exceptions1Context = context.E_exceptions1;
                if (E_exceptions1Context is not null) exceptionsBuilder.Add((QualifierGreen?)this.Visit(E_exceptions1Context) ?? QualifierGreen.__Missing);
                else exceptionsBuilder.Add(QualifierGreen.__Missing);
                var E_exceptions2Context = context._E_exceptions2;
                var E_TComma1Context = context._E_TComma1;
                for (int i = 0; i < E_exceptions2Context.Count; ++i)
                {
                    if (i < E_TComma1Context.Count)
                    {
                        var _separator = E_TComma1Context[i];
                        exceptionsBuilder.AddSeparator((InternalSyntaxToken?)this.VisitTerminal(_separator, SoalSyntaxKind.TComma));
                    }
                    else
                    {
                        exceptionsBuilder.AddSeparator((InternalSyntaxToken?)this.VisitTerminal((IToken?)null, SoalSyntaxKind.TComma));
                    }
                    var _item = E_exceptions2Context[i];
                    if (_item is not null) exceptionsBuilder.Add((QualifierGreen?)this.Visit(_item) ?? QualifierGreen.__Missing);
                    else exceptionsBuilder.Add(QualifierGreen.__Missing);
                }
                var exceptions = exceptionsBuilder.ToList();
                _pool.Free(exceptionsBuilder);
                return _factory.ResourceBlock1(kThrows, exceptions);
            }
            
            public override GreenNode? VisitPr_ResourceBlock1exceptionsBlock(SoalParser.Pr_ResourceBlock1exceptionsBlockContext? context)
            {
                if (context == null) return ResourceBlock1exceptionsBlockGreen.__Missing;
                var tComma = (InternalSyntaxToken?)this.VisitTerminal(context.E_TComma1, SoalSyntaxKind.TComma);
                QualifierGreen? exceptions = null;
                if (context.E_exceptions2 is not null) exceptions = (QualifierGreen?)this.Visit(context.E_exceptions2) ?? QualifierGreen.__Missing;
                else exceptions = QualifierGreen.__Missing;
                return _factory.ResourceBlock1exceptionsBlock(tComma, exceptions);
            }
            
            public override GreenNode? VisitPr_OperationBlock1(SoalParser.Pr_OperationBlock1Context? context)
            {
                if (context == null) return OperationBlock1Green.__Missing;
                var kThrows = (InternalSyntaxToken?)this.VisitTerminal(context.E_KThrows, SoalSyntaxKind.KThrows);
                var exceptionsBuilder = _pool.AllocateSeparated<QualifierGreen>(reversed: false);
                var E_exceptions1Context = context.E_exceptions1;
                if (E_exceptions1Context is not null) exceptionsBuilder.Add((QualifierGreen?)this.Visit(E_exceptions1Context) ?? QualifierGreen.__Missing);
                else exceptionsBuilder.Add(QualifierGreen.__Missing);
                var E_exceptions2Context = context._E_exceptions2;
                var E_TComma1Context = context._E_TComma1;
                for (int i = 0; i < E_exceptions2Context.Count; ++i)
                {
                    if (i < E_TComma1Context.Count)
                    {
                        var _separator = E_TComma1Context[i];
                        exceptionsBuilder.AddSeparator((InternalSyntaxToken?)this.VisitTerminal(_separator, SoalSyntaxKind.TComma));
                    }
                    else
                    {
                        exceptionsBuilder.AddSeparator((InternalSyntaxToken?)this.VisitTerminal((IToken?)null, SoalSyntaxKind.TComma));
                    }
                    var _item = E_exceptions2Context[i];
                    if (_item is not null) exceptionsBuilder.Add((QualifierGreen?)this.Visit(_item) ?? QualifierGreen.__Missing);
                    else exceptionsBuilder.Add(QualifierGreen.__Missing);
                }
                var exceptions = exceptionsBuilder.ToList();
                _pool.Free(exceptionsBuilder);
                return _factory.OperationBlock1(kThrows, exceptions);
            }
            
            public override GreenNode? VisitPr_OperationBlock1exceptionsBlock(SoalParser.Pr_OperationBlock1exceptionsBlockContext? context)
            {
                if (context == null) return OperationBlock1exceptionsBlockGreen.__Missing;
                var tComma = (InternalSyntaxToken?)this.VisitTerminal(context.E_TComma1, SoalSyntaxKind.TComma);
                QualifierGreen? exceptions = null;
                if (context.E_exceptions2 is not null) exceptions = (QualifierGreen?)this.Visit(context.E_exceptions2) ?? QualifierGreen.__Missing;
                else exceptions = QualifierGreen.__Missing;
                return _factory.OperationBlock1exceptionsBlock(tComma, exceptions);
            }
            
            public override GreenNode? VisitPr_InputParameterListBlock1(SoalParser.Pr_InputParameterListBlock1Context? context)
            {
                if (context == null) return InputParameterListBlock1Green.__Missing;
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
                        parametersBuilder.AddSeparator((InternalSyntaxToken?)this.VisitTerminal(_separator, SoalSyntaxKind.TComma));
                    }
                    else
                    {
                        parametersBuilder.AddSeparator((InternalSyntaxToken?)this.VisitTerminal((IToken?)null, SoalSyntaxKind.TComma));
                    }
                    var _item = E_parameters2Context[i];
                    if (_item is not null) parametersBuilder.Add((ParameterGreen?)this.Visit(_item) ?? ParameterGreen.__Missing);
                    else parametersBuilder.Add(ParameterGreen.__Missing);
                }
                var parameters = parametersBuilder.ToList();
                _pool.Free(parametersBuilder);
                return _factory.InputParameterListBlock1(parameters);
            }
            
            public override GreenNode? VisitPr_InputParameterListBlock1parametersBlock(SoalParser.Pr_InputParameterListBlock1parametersBlockContext? context)
            {
                if (context == null) return InputParameterListBlock1parametersBlockGreen.__Missing;
                var tComma = (InternalSyntaxToken?)this.VisitTerminal(context.E_TComma1, SoalSyntaxKind.TComma);
                ParameterGreen? parameters = null;
                if (context.E_parameters2 is not null) parameters = (ParameterGreen?)this.Visit(context.E_parameters2) ?? ParameterGreen.__Missing;
                else parameters = ParameterGreen.__Missing;
                return _factory.InputParameterListBlock1parametersBlock(tComma, parameters);
            }
            
            public override GreenNode? VisitPr_OutputParameterListAlt3parametersBlock(SoalParser.Pr_OutputParameterListAlt3parametersBlockContext? context)
            {
                if (context == null) return OutputParameterListAlt3parametersBlockGreen.__Missing;
                var tComma = (InternalSyntaxToken?)this.VisitTerminal(context.E_TComma1, SoalSyntaxKind.TComma);
                ParameterGreen? parameters = null;
                if (context.E_parameters2 is not null) parameters = (ParameterGreen?)this.Visit(context.E_parameters2) ?? ParameterGreen.__Missing;
                else parameters = ParameterGreen.__Missing;
                return _factory.OutputParameterListAlt3parametersBlock(tComma, parameters);
            }
            
            public override GreenNode? VisitPr_TypeReferenceBlock1(SoalParser.Pr_TypeReferenceBlock1Context? context)
            {
                if (context == null) return TypeReferenceBlock1Green.__Missing;
                var tLBracket = (InternalSyntaxToken?)this.VisitTerminal(context.E_TLBracket, SoalSyntaxKind.TLBracket);
                var tRBracket = (InternalSyntaxToken?)this.VisitTerminal(context.E_TRBracket, SoalSyntaxKind.TRBracket);
                return _factory.TypeReferenceBlock1(tLBracket, tRBracket);
            }
            
            public override GreenNode? VisitPr_QualifierIdentifierBlock(SoalParser.Pr_QualifierIdentifierBlockContext? context)
            {
                if (context == null) return QualifierIdentifierBlockGreen.__Missing;
                var tDot = (InternalSyntaxToken?)this.VisitTerminal(context.E_TDot1, SoalSyntaxKind.TDot);
                IdentifierGreen? identifier = null;
                if (context.E_Identifier2 is not null) identifier = (IdentifierGreen?)this.Visit(context.E_Identifier2) ?? IdentifierGreen.__Missing;
                else identifier = IdentifierGreen.__Missing;
                return _factory.QualifierIdentifierBlock(tDot, identifier);
            }
        }
    }
}
