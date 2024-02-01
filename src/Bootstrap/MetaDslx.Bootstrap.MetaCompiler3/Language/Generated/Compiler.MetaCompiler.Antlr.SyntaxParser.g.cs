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
using MetaDslx.Bootstrap.MetaCompiler3.Compiler.Syntax.InternalSyntax;

#nullable enable

namespace MetaDslx.Bootstrap.MetaCompiler3.Compiler.Syntax
{
    public partial class CompilerSyntaxParser : AntlrSyntaxParser
    {
        private readonly AntlrToRoslynVisitor _visitor;

        public CompilerSyntaxParser(
            CompilerSyntaxLexer lexer,
            IncrementalParseData? oldParseData,
            IEnumerable<TextChangeRange> changes,
            CancellationToken cancellationToken = default)
            : base(lexer, oldParseData, changes, cancellationToken)
        {
            _visitor = new AntlrToRoslynVisitor(this);
        }

        protected new CompilerParser AntlrParser => (CompilerParser)base.AntlrParser;

        protected override SyntaxNode ParseRoot()
        {
            ParserState? state = null;
            GreenNode? green = this.ParseMain(ref state);
            var red = (CompilerSyntaxNode)green!.CreateRed();
            return red;
        }

        private GreenNode? ParseMain(ref ParserState? state)
        {
            return _visitor.VisitPr_Main(AntlrParser.pr_Main());
        }

        private class AntlrToRoslynVisitor : CompilerParserBaseVisitor<GreenNode?>
        {
            // list pools - allocators for lists that are used to build sequences of nodes. The lists
            // can be reused (hence pooled) since the syntax factory methods don't keep references to
            // them
            private readonly SyntaxListPool _pool = new SyntaxListPool(); // Don't need to reset this.

            private readonly CompilerSyntaxParser _parser;
            private readonly AntlrTokenStream _tokenStream;
            private readonly CompilerInternalSyntaxFactory _factory;

            public AntlrToRoslynVisitor(CompilerSyntaxParser parser)
            {
                _parser = parser;
                _tokenStream = (AntlrTokenStream)_parser.AntlrParser.InputStream;
                _factory = (CompilerInternalSyntaxFactory)_parser.Language.InternalSyntaxFactory;
            }

            private GreenNode? VisitTerminal(IToken? token, CompilerSyntaxKind kind)
            {
                if (token == null)
                {
                    if (kind != CompilerSyntaxKind.None) return _tokenStream.ConsumeGreenToken(_factory.MissingToken(kind), _parser);
                    else return null;
                }
                var green = _tokenStream.ConsumeGreenToken(token, _parser);
                Debug.Assert(kind == CompilerSyntaxKind.None || green.RawKind == (int)kind);
                return green;
            }

            public GreenNode? VisitTerminal(IToken? token)
            {
                return VisitTerminal(token, CompilerSyntaxKind.None);
            }

            private GreenNode? VisitTerminal(ITerminalNode? node, CompilerSyntaxKind kind)
            {
                if (node?.Symbol == null)
                {
                    if (kind != CompilerSyntaxKind.None) return _factory.MissingToken(kind);
                    else return null;
                }
                var green = _tokenStream.ConsumeGreenToken(node.Symbol, _parser);
                Debug.Assert(kind == CompilerSyntaxKind.None || green.RawKind == (int)kind);
                return green;
            }

            public override GreenNode? VisitTerminal(ITerminalNode? node)
            {
                return VisitTerminal(node, CompilerSyntaxKind.None);
            }
            
            public override GreenNode? VisitPr_Main(CompilerParser.Pr_MainContext? context)
            {
                if (context == null) return MainGreen.__Missing;
                var kNamespace = (InternalSyntaxToken?)this.VisitTerminal(context.E_KNamespace, CompilerSyntaxKind.KNamespace);
                QualifierGreen? qualifier = null;
                if (context.E_Qualifier is not null) qualifier = (QualifierGreen?)this.Visit(context.E_Qualifier) ?? QualifierGreen.__Missing;
                else qualifier = QualifierGreen.__Missing;
                var tSemicolon = (InternalSyntaxToken?)this.VisitTerminal(context.E_TSemicolon, CompilerSyntaxKind.TSemicolon);
                var E_BlockContext = context._E_Block;
                var block1Builder = _pool.Allocate<MainBlock1Green>();
                for (int i = 0; i < E_BlockContext.Count; ++i)
                {
                    if (E_BlockContext[i] is not null) block1Builder.Add((MainBlock1Green?)this.Visit(E_BlockContext[i]) ?? MainBlock1Green.__Missing);
                    else block1Builder.Add(MainBlock1Green.__Missing);
                }
                var block1 = block1Builder.ToList();
                _pool.Free(block1Builder);
                MainBlock2Green? block2 = null;
                if (context.E_Block1 is not null) block2 = (MainBlock2Green?)this.Visit(context.E_Block1) ?? MainBlock2Green.__Missing;
                else block2 = MainBlock2Green.__Missing;
                var endOfFileToken = (InternalSyntaxToken?)this.VisitTerminal(context.E_EndOfFileToken, CompilerSyntaxKind.Eof);
                return _factory.Main(kNamespace, qualifier, tSemicolon, block1, block2, endOfFileToken);
            }
            
            public override GreenNode? VisitPr_UsingMetaModel(CompilerParser.Pr_UsingMetaModelContext? context)
            {
                if (context == null) return UsingMetaModelGreen.__Missing;
                var kMetamodel = (InternalSyntaxToken?)this.VisitTerminal(context.E_KMetamodel, CompilerSyntaxKind.KMetamodel);
                QualifierGreen? metaModelSymbols = null;
                if (context.E_metaModelSymbols is not null) metaModelSymbols = (QualifierGreen?)this.Visit(context.E_metaModelSymbols) ?? QualifierGreen.__Missing;
                else metaModelSymbols = QualifierGreen.__Missing;
                return _factory.UsingMetaModel(kMetamodel, metaModelSymbols);
            }
            
            public override GreenNode? VisitPr_UsingAlt2(CompilerParser.Pr_UsingAlt2Context? context)
            {
                if (context == null) return UsingAlt2Green.__Missing;
                QualifierGreen? namespaces = null;
                if (context.E_namespaces is not null) namespaces = (QualifierGreen?)this.Visit(context.E_namespaces) ?? QualifierGreen.__Missing;
                else namespaces = QualifierGreen.__Missing;
                return _factory.UsingAlt2(namespaces);
            }
            
            public override GreenNode? VisitPr_LanguageDeclaration(CompilerParser.Pr_LanguageDeclarationContext? context)
            {
                if (context == null) return LanguageDeclarationGreen.__Missing;
                var kLanguage = (InternalSyntaxToken?)this.VisitTerminal(context.E_KLanguage, CompilerSyntaxKind.KLanguage);
                NameGreen? name = null;
                if (context.E_Name is not null) name = (NameGreen?)this.Visit(context.E_Name) ?? NameGreen.__Missing;
                else name = NameGreen.__Missing;
                var tSemicolon = (InternalSyntaxToken?)this.VisitTerminal(context.E_TSemicolon, CompilerSyntaxKind.TSemicolon);
                GrammarGreen? grammar = null;
                if (context.E_grammar is not null) grammar = (GrammarGreen?)this.Visit(context.E_grammar) ?? GrammarGreen.__Missing;
                else grammar = GrammarGreen.__Missing;
                return _factory.LanguageDeclaration(kLanguage, name, tSemicolon, grammar);
            }
            
            public override GreenNode? VisitPr_Grammar(CompilerParser.Pr_GrammarContext? context)
            {
                if (context == null) return GrammarGreen.__Missing;
                GrammarBlock1Green? block = null;
                if (context.E_Block is not null) block = (GrammarBlock1Green?)this.Visit(context.E_Block) ?? GrammarBlock1Green.__Missing;
                else block = GrammarBlock1Green.__Missing;
                return _factory.Grammar(block);
            }
            
            public override GreenNode? VisitPr_GrammarRuleAlt1(CompilerParser.Pr_GrammarRuleAlt1Context? context)
            {
                if (context == null) return GrammarRuleAlt1Green.__Missing;
                RuleGreen? rule = null;
                if (context.E_Rule is not null) rule = (RuleGreen?)this.Visit(context.E_Rule) ?? RuleGreen.__Missing;
                else rule = RuleGreen.__Missing;
                return _factory.GrammarRuleAlt1(rule);
            }
            
            public override GreenNode? VisitPr_GrammarRuleAlt2(CompilerParser.Pr_GrammarRuleAlt2Context? context)
            {
                if (context == null) return GrammarRuleAlt2Green.__Missing;
                LexerRuleGreen? lexerRule = null;
                if (context.E_LexerRule is not null) lexerRule = (LexerRuleGreen?)this.Visit(context.E_LexerRule) ?? LexerRuleGreen.__Missing;
                else lexerRule = LexerRuleGreen.__Missing;
                return _factory.GrammarRuleAlt2(lexerRule);
            }
            
            public override GreenNode? VisitPr_Rule(CompilerParser.Pr_RuleContext? context)
            {
                if (context == null) return RuleGreen.__Missing;
                var E_annotationsContext = context._E_annotations;
                var annotations1Builder = _pool.Allocate<ParserAnnotationGreen>();
                for (int i = 0; i < E_annotationsContext.Count; ++i)
                {
                    if (E_annotationsContext[i] is not null) annotations1Builder.Add((ParserAnnotationGreen?)this.Visit(E_annotationsContext[i]) ?? ParserAnnotationGreen.__Missing);
                    else annotations1Builder.Add(ParserAnnotationGreen.__Missing);
                }
                var annotations1 = annotations1Builder.ToList();
                _pool.Free(annotations1Builder);
                RuleBlock1Green? block = null;
                if (context.E_Block is not null) block = (RuleBlock1Green?)this.Visit(context.E_Block) ?? RuleBlock1Green.__Missing;
                else block = RuleBlock1Green.__Missing;
                var tColon = (InternalSyntaxToken?)this.VisitTerminal(context.E_TColon, CompilerSyntaxKind.TColon);
                var alternativesBuilder = _pool.AllocateSeparated<AlternativeGreen>(reversed: false);
                var E_alternatives1Context = context.E_alternatives1;
                if (E_alternatives1Context is not null) alternativesBuilder.Add((AlternativeGreen?)this.Visit(E_alternatives1Context) ?? AlternativeGreen.__Missing);
                else alternativesBuilder.Add(AlternativeGreen.__Missing);
                var E_alternatives2Context = context._E_alternatives2;
                var E_TBar1Context = context._E_TBar1;
                for (int i = 0; i < E_alternatives2Context.Count; ++i)
                {
                    if (i < E_TBar1Context.Count)
                    {
                        var _separator = E_TBar1Context[i];
                        alternativesBuilder.AddSeparator((InternalSyntaxToken?)this.VisitTerminal(_separator, CompilerSyntaxKind.TBar));
                    }
                    else
                    {
                        alternativesBuilder.AddSeparator((InternalSyntaxToken?)this.VisitTerminal((IToken?)null, CompilerSyntaxKind.TBar));
                    }
                    var _item = E_alternatives2Context[i];
                    if (_item is not null) alternativesBuilder.Add((AlternativeGreen?)this.Visit(_item) ?? AlternativeGreen.__Missing);
                    else alternativesBuilder.Add(AlternativeGreen.__Missing);
                }
                var alternatives = alternativesBuilder.ToList();
                _pool.Free(alternativesBuilder);
                var tSemicolon = (InternalSyntaxToken?)this.VisitTerminal(context.E_TSemicolon, CompilerSyntaxKind.TSemicolon);
                return _factory.Rule(annotations1, block, tColon, alternatives, tSemicolon);
            }
            
            public override GreenNode? VisitPr_Alternative(CompilerParser.Pr_AlternativeContext? context)
            {
                if (context == null) return AlternativeGreen.__Missing;
                AlternativeBlock1Green? block1 = null;
                if (context.E_Block is not null) block1 = (AlternativeBlock1Green?)this.Visit(context.E_Block);
                var E_elementsContext = context._E_elements;
                var elementsBuilder = _pool.Allocate<ElementGreen>();
                for (int i = 0; i < E_elementsContext.Count; ++i)
                {
                    if (E_elementsContext[i] is not null) elementsBuilder.Add((ElementGreen?)this.Visit(E_elementsContext[i]) ?? ElementGreen.__Missing);
                    else elementsBuilder.Add(ElementGreen.__Missing);
                }
                var elements = elementsBuilder.ToList();
                _pool.Free(elementsBuilder);
                AlternativeBlock2Green? block2 = null;
                if (context.E_Block1 is not null) block2 = (AlternativeBlock2Green?)this.Visit(context.E_Block1);
                return _factory.Alternative(block1, elements, block2);
            }
            
            public override GreenNode? VisitPr_Element(CompilerParser.Pr_ElementContext? context)
            {
                if (context == null) return ElementGreen.__Missing;
                ElementBlock1Green? block = null;
                if (context.E_Block is not null) block = (ElementBlock1Green?)this.Visit(context.E_Block);
                ElementValueGreen? value = null;
                if (context.E_value is not null) value = (ElementValueGreen?)this.Visit(context.E_value) ?? ElementValueGreen.__Missing;
                else value = ElementValueGreen.__Missing;
                return _factory.Element(block, value);
            }
            
            public override GreenNode? VisitPr_ElementValueAlt1(CompilerParser.Pr_ElementValueAlt1Context? context)
            {
                if (context == null) return ElementValueAlt1Green.__Missing;
                BlockGreen? block = null;
                if (context.E_Block is not null) block = (BlockGreen?)this.Visit(context.E_Block) ?? BlockGreen.__Missing;
                else block = BlockGreen.__Missing;
                return _factory.ElementValueAlt1(block);
            }
            
            public override GreenNode? VisitPr_ElementValueAlt2(CompilerParser.Pr_ElementValueAlt2Context? context)
            {
                if (context == null) return ElementValueAlt2Green.__Missing;
                Eof1Green? eof1 = null;
                if (context.E_Eof1 is not null) eof1 = (Eof1Green?)this.Visit(context.E_Eof1) ?? Eof1Green.__Missing;
                else eof1 = Eof1Green.__Missing;
                return _factory.ElementValueAlt2(eof1);
            }
            
            public override GreenNode? VisitPr_ElementValueAlt3(CompilerParser.Pr_ElementValueAlt3Context? context)
            {
                if (context == null) return ElementValueAlt3Green.__Missing;
                FixedGreen? @fixed = null;
                if (context.E_Fixed is not null) @fixed = (FixedGreen?)this.Visit(context.E_Fixed) ?? FixedGreen.__Missing;
                else @fixed = FixedGreen.__Missing;
                return _factory.ElementValueAlt3(@fixed);
            }
            
            public override GreenNode? VisitPr_ElementValueAlt4(CompilerParser.Pr_ElementValueAlt4Context? context)
            {
                if (context == null) return ElementValueAlt4Green.__Missing;
                RuleRefGreen? ruleRef = null;
                if (context.E_RuleRef is not null) ruleRef = (RuleRefGreen?)this.Visit(context.E_RuleRef) ?? RuleRefGreen.__Missing;
                else ruleRef = RuleRefGreen.__Missing;
                return _factory.ElementValueAlt4(ruleRef);
            }
            
            public override GreenNode? VisitPr_Block(CompilerParser.Pr_BlockContext? context)
            {
                if (context == null) return BlockGreen.__Missing;
                var E_annotationsContext = context._E_annotations;
                var annotations1Builder = _pool.Allocate<ParserAnnotationGreen>();
                for (int i = 0; i < E_annotationsContext.Count; ++i)
                {
                    if (E_annotationsContext[i] is not null) annotations1Builder.Add((ParserAnnotationGreen?)this.Visit(E_annotationsContext[i]) ?? ParserAnnotationGreen.__Missing);
                    else annotations1Builder.Add(ParserAnnotationGreen.__Missing);
                }
                var annotations1 = annotations1Builder.ToList();
                _pool.Free(annotations1Builder);
                var tLParen = (InternalSyntaxToken?)this.VisitTerminal(context.E_TLParen, CompilerSyntaxKind.TLParen);
                var alternativesBuilder = _pool.AllocateSeparated<BlockAlternativeGreen>(reversed: false);
                var E_alternatives1Context = context.E_alternatives1;
                if (E_alternatives1Context is not null) alternativesBuilder.Add((BlockAlternativeGreen?)this.Visit(E_alternatives1Context) ?? BlockAlternativeGreen.__Missing);
                else alternativesBuilder.Add(BlockAlternativeGreen.__Missing);
                var E_alternatives2Context = context._E_alternatives2;
                var E_TBar1Context = context._E_TBar1;
                for (int i = 0; i < E_alternatives2Context.Count; ++i)
                {
                    if (i < E_TBar1Context.Count)
                    {
                        var _separator = E_TBar1Context[i];
                        alternativesBuilder.AddSeparator((InternalSyntaxToken?)this.VisitTerminal(_separator, CompilerSyntaxKind.TBar));
                    }
                    else
                    {
                        alternativesBuilder.AddSeparator((InternalSyntaxToken?)this.VisitTerminal((IToken?)null, CompilerSyntaxKind.TBar));
                    }
                    var _item = E_alternatives2Context[i];
                    if (_item is not null) alternativesBuilder.Add((BlockAlternativeGreen?)this.Visit(_item) ?? BlockAlternativeGreen.__Missing);
                    else alternativesBuilder.Add(BlockAlternativeGreen.__Missing);
                }
                var alternatives = alternativesBuilder.ToList();
                _pool.Free(alternativesBuilder);
                var tRParen = (InternalSyntaxToken?)this.VisitTerminal(context.E_TRParen, CompilerSyntaxKind.TRParen);
                MultiplicityGreen? multiplicity = null;
                if (context.E_multiplicity is not null) multiplicity = (MultiplicityGreen?)this.Visit(context.E_multiplicity);
                return _factory.Block(annotations1, tLParen, alternatives, tRParen, multiplicity);
            }
            
            public override GreenNode? VisitPr_BlockAlternative(CompilerParser.Pr_BlockAlternativeContext? context)
            {
                if (context == null) return BlockAlternativeGreen.__Missing;
                var E_elementsContext = context._E_elements;
                var elementsBuilder = _pool.Allocate<ElementGreen>();
                for (int i = 0; i < E_elementsContext.Count; ++i)
                {
                    if (E_elementsContext[i] is not null) elementsBuilder.Add((ElementGreen?)this.Visit(E_elementsContext[i]) ?? ElementGreen.__Missing);
                    else elementsBuilder.Add(ElementGreen.__Missing);
                }
                var elements = elementsBuilder.ToList();
                _pool.Free(elementsBuilder);
                BlockAlternativeBlock1Green? block = null;
                if (context.E_Block is not null) block = (BlockAlternativeBlock1Green?)this.Visit(context.E_Block);
                return _factory.BlockAlternative(elements, block);
            }
            
            public override GreenNode? VisitPr_RuleRefAlt1(CompilerParser.Pr_RuleRefAlt1Context? context)
            {
                if (context == null) return RuleRefAlt1Green.__Missing;
                var E_annotationsContext = context._E_annotations;
                var annotations1Builder = _pool.Allocate<ParserAnnotationGreen>();
                for (int i = 0; i < E_annotationsContext.Count; ++i)
                {
                    if (E_annotationsContext[i] is not null) annotations1Builder.Add((ParserAnnotationGreen?)this.Visit(E_annotationsContext[i]) ?? ParserAnnotationGreen.__Missing);
                    else annotations1Builder.Add(ParserAnnotationGreen.__Missing);
                }
                var annotations1 = annotations1Builder.ToList();
                _pool.Free(annotations1Builder);
                IdentifierGreen? grammarRule = null;
                if (context.E_grammarRule is not null) grammarRule = (IdentifierGreen?)this.Visit(context.E_grammarRule) ?? IdentifierGreen.__Missing;
                else grammarRule = IdentifierGreen.__Missing;
                MultiplicityGreen? multiplicity = null;
                if (context.E_multiplicity is not null) multiplicity = (MultiplicityGreen?)this.Visit(context.E_multiplicity);
                return _factory.RuleRefAlt1(annotations1, grammarRule, multiplicity);
            }
            
            public override GreenNode? VisitPr_RuleRefAlt2(CompilerParser.Pr_RuleRefAlt2Context? context)
            {
                if (context == null) return RuleRefAlt2Green.__Missing;
                var E_annotations1Context = context._E_annotations1;
                var annotations1Builder = _pool.Allocate<ParserAnnotationGreen>();
                for (int i = 0; i < E_annotations1Context.Count; ++i)
                {
                    if (E_annotations1Context[i] is not null) annotations1Builder.Add((ParserAnnotationGreen?)this.Visit(E_annotations1Context[i]) ?? ParserAnnotationGreen.__Missing);
                    else annotations1Builder.Add(ParserAnnotationGreen.__Missing);
                }
                var annotations1 = annotations1Builder.ToList();
                _pool.Free(annotations1Builder);
                var tHash = (InternalSyntaxToken?)this.VisitTerminal(context.E_THash, CompilerSyntaxKind.THash);
                TypeReferenceGreen? referencedTypes = null;
                if (context.E_referencedTypes is not null) referencedTypes = (TypeReferenceGreen?)this.Visit(context.E_referencedTypes) ?? TypeReferenceGreen.__Missing;
                else referencedTypes = TypeReferenceGreen.__Missing;
                MultiplicityGreen? multiplicity = null;
                if (context.E_multiplicity1 is not null) multiplicity = (MultiplicityGreen?)this.Visit(context.E_multiplicity1);
                return _factory.RuleRefAlt2(annotations1, tHash, referencedTypes, multiplicity);
            }
            
            public override GreenNode? VisitPr_RuleRefAlt3(CompilerParser.Pr_RuleRefAlt3Context? context)
            {
                if (context == null) return RuleRefAlt3Green.__Missing;
                var E_annotations2Context = context._E_annotations2;
                var annotations1Builder = _pool.Allocate<ParserAnnotationGreen>();
                for (int i = 0; i < E_annotations2Context.Count; ++i)
                {
                    if (E_annotations2Context[i] is not null) annotations1Builder.Add((ParserAnnotationGreen?)this.Visit(E_annotations2Context[i]) ?? ParserAnnotationGreen.__Missing);
                    else annotations1Builder.Add(ParserAnnotationGreen.__Missing);
                }
                var annotations1 = annotations1Builder.ToList();
                _pool.Free(annotations1Builder);
                var tHashLBrace = (InternalSyntaxToken?)this.VisitTerminal(context.E_THashLBrace, CompilerSyntaxKind.THashLBrace);
                var referencedTypesBuilder = _pool.AllocateSeparated<TypeReferenceGreen>(reversed: false);
                var E_referencedTypes1Context = context.E_referencedTypes1;
                if (E_referencedTypes1Context is not null) referencedTypesBuilder.Add((TypeReferenceGreen?)this.Visit(E_referencedTypes1Context) ?? TypeReferenceGreen.__Missing);
                else referencedTypesBuilder.Add(TypeReferenceGreen.__Missing);
                var E_referencedTypes2Context = context._E_referencedTypes2;
                var E_TComma1Context = context._E_TComma1;
                for (int i = 0; i < E_referencedTypes2Context.Count; ++i)
                {
                    if (i < E_TComma1Context.Count)
                    {
                        var _separator = E_TComma1Context[i];
                        referencedTypesBuilder.AddSeparator((InternalSyntaxToken?)this.VisitTerminal(_separator, CompilerSyntaxKind.TComma));
                    }
                    else
                    {
                        referencedTypesBuilder.AddSeparator((InternalSyntaxToken?)this.VisitTerminal((IToken?)null, CompilerSyntaxKind.TComma));
                    }
                    var _item = E_referencedTypes2Context[i];
                    if (_item is not null) referencedTypesBuilder.Add((TypeReferenceGreen?)this.Visit(_item) ?? TypeReferenceGreen.__Missing);
                    else referencedTypesBuilder.Add(TypeReferenceGreen.__Missing);
                }
                var referencedTypes = referencedTypesBuilder.ToList();
                _pool.Free(referencedTypesBuilder);
                RuleRefAlt3Block1Green? block = null;
                if (context.E_Block is not null) block = (RuleRefAlt3Block1Green?)this.Visit(context.E_Block);
                var tRBrace = (InternalSyntaxToken?)this.VisitTerminal(context.E_TRBrace, CompilerSyntaxKind.TRBrace);
                MultiplicityGreen? multiplicity = null;
                if (context.E_multiplicity2 is not null) multiplicity = (MultiplicityGreen?)this.Visit(context.E_multiplicity2);
                return _factory.RuleRefAlt3(annotations1, tHashLBrace, referencedTypes, block, tRBrace, multiplicity);
            }
            
            public override GreenNode? VisitPr_Eof1(CompilerParser.Pr_Eof1Context? context)
            {
                if (context == null) return Eof1Green.__Missing;
                var kEof = (InternalSyntaxToken?)this.VisitTerminal(context.E_KEof, CompilerSyntaxKind.KEof);
                return _factory.Eof1(kEof);
            }
            
            public override GreenNode? VisitPr_Fixed(CompilerParser.Pr_FixedContext? context)
            {
                if (context == null) return FixedGreen.__Missing;
                var E_annotationsContext = context._E_annotations;
                var annotations1Builder = _pool.Allocate<ParserAnnotationGreen>();
                for (int i = 0; i < E_annotationsContext.Count; ++i)
                {
                    if (E_annotationsContext[i] is not null) annotations1Builder.Add((ParserAnnotationGreen?)this.Visit(E_annotationsContext[i]) ?? ParserAnnotationGreen.__Missing);
                    else annotations1Builder.Add(ParserAnnotationGreen.__Missing);
                }
                var annotations1 = annotations1Builder.ToList();
                _pool.Free(annotations1Builder);
                var text = (InternalSyntaxToken?)this.VisitTerminal(context.E_text, CompilerSyntaxKind.TString);
                MultiplicityGreen? multiplicity = null;
                if (context.E_multiplicity is not null) multiplicity = (MultiplicityGreen?)this.Visit(context.E_multiplicity);
                return _factory.Fixed(annotations1, text, multiplicity);
            }
            
            public override GreenNode? VisitPr_LexerRuleAlt1(CompilerParser.Pr_LexerRuleAlt1Context? context)
            {
                if (context == null) return LexerRuleAlt1Green.__Missing;
                TokenGreen? token = null;
                if (context.E_Token is not null) token = (TokenGreen?)this.Visit(context.E_Token) ?? TokenGreen.__Missing;
                else token = TokenGreen.__Missing;
                return _factory.LexerRuleAlt1(token);
            }
            
            public override GreenNode? VisitPr_LexerRuleAlt2(CompilerParser.Pr_LexerRuleAlt2Context? context)
            {
                if (context == null) return LexerRuleAlt2Green.__Missing;
                FragmentGreen? fragment = null;
                if (context.E_Fragment is not null) fragment = (FragmentGreen?)this.Visit(context.E_Fragment) ?? FragmentGreen.__Missing;
                else fragment = FragmentGreen.__Missing;
                return _factory.LexerRuleAlt2(fragment);
            }
            
            public override GreenNode? VisitPr_Token(CompilerParser.Pr_TokenContext? context)
            {
                if (context == null) return TokenGreen.__Missing;
                var E_annotationsContext = context._E_annotations;
                var annotations1Builder = _pool.Allocate<LexerAnnotationGreen>();
                for (int i = 0; i < E_annotationsContext.Count; ++i)
                {
                    if (E_annotationsContext[i] is not null) annotations1Builder.Add((LexerAnnotationGreen?)this.Visit(E_annotationsContext[i]) ?? LexerAnnotationGreen.__Missing);
                    else annotations1Builder.Add(LexerAnnotationGreen.__Missing);
                }
                var annotations1 = annotations1Builder.ToList();
                _pool.Free(annotations1Builder);
                TokenBlock1Green? block = null;
                if (context.E_Block is not null) block = (TokenBlock1Green?)this.Visit(context.E_Block) ?? TokenBlock1Green.__Missing;
                else block = TokenBlock1Green.__Missing;
                var tColon = (InternalSyntaxToken?)this.VisitTerminal(context.E_TColon, CompilerSyntaxKind.TColon);
                var alternativesBuilder = _pool.AllocateSeparated<LAlternativeGreen>(reversed: false);
                var E_alternatives1Context = context.E_alternatives1;
                if (E_alternatives1Context is not null) alternativesBuilder.Add((LAlternativeGreen?)this.Visit(E_alternatives1Context) ?? LAlternativeGreen.__Missing);
                else alternativesBuilder.Add(LAlternativeGreen.__Missing);
                var E_alternatives2Context = context._E_alternatives2;
                var E_TBar1Context = context._E_TBar1;
                for (int i = 0; i < E_alternatives2Context.Count; ++i)
                {
                    if (i < E_TBar1Context.Count)
                    {
                        var _separator = E_TBar1Context[i];
                        alternativesBuilder.AddSeparator((InternalSyntaxToken?)this.VisitTerminal(_separator, CompilerSyntaxKind.TBar));
                    }
                    else
                    {
                        alternativesBuilder.AddSeparator((InternalSyntaxToken?)this.VisitTerminal((IToken?)null, CompilerSyntaxKind.TBar));
                    }
                    var _item = E_alternatives2Context[i];
                    if (_item is not null) alternativesBuilder.Add((LAlternativeGreen?)this.Visit(_item) ?? LAlternativeGreen.__Missing);
                    else alternativesBuilder.Add(LAlternativeGreen.__Missing);
                }
                var alternatives = alternativesBuilder.ToList();
                _pool.Free(alternativesBuilder);
                var tSemicolon = (InternalSyntaxToken?)this.VisitTerminal(context.E_TSemicolon, CompilerSyntaxKind.TSemicolon);
                return _factory.Token(annotations1, block, tColon, alternatives, tSemicolon);
            }
            
            public override GreenNode? VisitPr_Fragment(CompilerParser.Pr_FragmentContext? context)
            {
                if (context == null) return FragmentGreen.__Missing;
                var kFragment = (InternalSyntaxToken?)this.VisitTerminal(context.E_KFragment, CompilerSyntaxKind.KFragment);
                NameGreen? name = null;
                if (context.E_Name is not null) name = (NameGreen?)this.Visit(context.E_Name) ?? NameGreen.__Missing;
                else name = NameGreen.__Missing;
                var tColon = (InternalSyntaxToken?)this.VisitTerminal(context.E_TColon, CompilerSyntaxKind.TColon);
                var alternativesBuilder = _pool.AllocateSeparated<LAlternativeGreen>(reversed: false);
                var E_alternatives1Context = context.E_alternatives1;
                if (E_alternatives1Context is not null) alternativesBuilder.Add((LAlternativeGreen?)this.Visit(E_alternatives1Context) ?? LAlternativeGreen.__Missing);
                else alternativesBuilder.Add(LAlternativeGreen.__Missing);
                var E_alternatives2Context = context._E_alternatives2;
                var E_TBar1Context = context._E_TBar1;
                for (int i = 0; i < E_alternatives2Context.Count; ++i)
                {
                    if (i < E_TBar1Context.Count)
                    {
                        var _separator = E_TBar1Context[i];
                        alternativesBuilder.AddSeparator((InternalSyntaxToken?)this.VisitTerminal(_separator, CompilerSyntaxKind.TBar));
                    }
                    else
                    {
                        alternativesBuilder.AddSeparator((InternalSyntaxToken?)this.VisitTerminal((IToken?)null, CompilerSyntaxKind.TBar));
                    }
                    var _item = E_alternatives2Context[i];
                    if (_item is not null) alternativesBuilder.Add((LAlternativeGreen?)this.Visit(_item) ?? LAlternativeGreen.__Missing);
                    else alternativesBuilder.Add(LAlternativeGreen.__Missing);
                }
                var alternatives = alternativesBuilder.ToList();
                _pool.Free(alternativesBuilder);
                var tSemicolon = (InternalSyntaxToken?)this.VisitTerminal(context.E_TSemicolon, CompilerSyntaxKind.TSemicolon);
                return _factory.Fragment(kFragment, name, tColon, alternatives, tSemicolon);
            }
            
            public override GreenNode? VisitPr_LAlternative(CompilerParser.Pr_LAlternativeContext? context)
            {
                if (context == null) return LAlternativeGreen.__Missing;
                var E_elementsContext = context._E_elements;
                var elementsBuilder = _pool.Allocate<LElementGreen>();
                for (int i = 0; i < E_elementsContext.Count; ++i)
                {
                    if (E_elementsContext[i] is not null) elementsBuilder.Add((LElementGreen?)this.Visit(E_elementsContext[i]) ?? LElementGreen.__Missing);
                    else elementsBuilder.Add(LElementGreen.__Missing);
                }
                var elements = elementsBuilder.ToList();
                _pool.Free(elementsBuilder);
                return _factory.LAlternative(elements);
            }
            
            public override GreenNode? VisitPr_LElement(CompilerParser.Pr_LElementContext? context)
            {
                if (context == null) return LElementGreen.__Missing;
                var isNegated = (InternalSyntaxToken?)this.VisitTerminal(context.E_isNegated);
                LElementValueGreen? value = null;
                if (context.E_value is not null) value = (LElementValueGreen?)this.Visit(context.E_value) ?? LElementValueGreen.__Missing;
                else value = LElementValueGreen.__Missing;
                MultiplicityGreen? multiplicity = null;
                if (context.E_multiplicity is not null) multiplicity = (MultiplicityGreen?)this.Visit(context.E_multiplicity);
                return _factory.LElement(isNegated, value, multiplicity);
            }
            
            public override GreenNode? VisitPr_LElementValueAlt1(CompilerParser.Pr_LElementValueAlt1Context? context)
            {
                if (context == null) return LElementValueAlt1Green.__Missing;
                LBlockGreen? lBlock = null;
                if (context.E_LBlock is not null) lBlock = (LBlockGreen?)this.Visit(context.E_LBlock) ?? LBlockGreen.__Missing;
                else lBlock = LBlockGreen.__Missing;
                return _factory.LElementValueAlt1(lBlock);
            }
            
            public override GreenNode? VisitPr_LElementValueAlt2(CompilerParser.Pr_LElementValueAlt2Context? context)
            {
                if (context == null) return LElementValueAlt2Green.__Missing;
                LFixedGreen? lFixed = null;
                if (context.E_LFixed is not null) lFixed = (LFixedGreen?)this.Visit(context.E_LFixed) ?? LFixedGreen.__Missing;
                else lFixed = LFixedGreen.__Missing;
                return _factory.LElementValueAlt2(lFixed);
            }
            
            public override GreenNode? VisitPr_LElementValueAlt3(CompilerParser.Pr_LElementValueAlt3Context? context)
            {
                if (context == null) return LElementValueAlt3Green.__Missing;
                LWildCardGreen? lWildCard = null;
                if (context.E_LWildCard is not null) lWildCard = (LWildCardGreen?)this.Visit(context.E_LWildCard) ?? LWildCardGreen.__Missing;
                else lWildCard = LWildCardGreen.__Missing;
                return _factory.LElementValueAlt3(lWildCard);
            }
            
            public override GreenNode? VisitPr_LElementValueAlt4(CompilerParser.Pr_LElementValueAlt4Context? context)
            {
                if (context == null) return LElementValueAlt4Green.__Missing;
                LRangeGreen? lRange = null;
                if (context.E_LRange is not null) lRange = (LRangeGreen?)this.Visit(context.E_LRange) ?? LRangeGreen.__Missing;
                else lRange = LRangeGreen.__Missing;
                return _factory.LElementValueAlt4(lRange);
            }
            
            public override GreenNode? VisitPr_LElementValueAlt5(CompilerParser.Pr_LElementValueAlt5Context? context)
            {
                if (context == null) return LElementValueAlt5Green.__Missing;
                LReferenceGreen? lReference = null;
                if (context.E_LReference is not null) lReference = (LReferenceGreen?)this.Visit(context.E_LReference) ?? LReferenceGreen.__Missing;
                else lReference = LReferenceGreen.__Missing;
                return _factory.LElementValueAlt5(lReference);
            }
            
            public override GreenNode? VisitPr_LReference(CompilerParser.Pr_LReferenceContext? context)
            {
                if (context == null) return LReferenceGreen.__Missing;
                IdentifierGreen? rule = null;
                if (context.E_rule is not null) rule = (IdentifierGreen?)this.Visit(context.E_rule) ?? IdentifierGreen.__Missing;
                else rule = IdentifierGreen.__Missing;
                return _factory.LReference(rule);
            }
            
            public override GreenNode? VisitPr_LFixed(CompilerParser.Pr_LFixedContext? context)
            {
                if (context == null) return LFixedGreen.__Missing;
                var text = (InternalSyntaxToken?)this.VisitTerminal(context.E_text, CompilerSyntaxKind.TString);
                return _factory.LFixed(text);
            }
            
            public override GreenNode? VisitPr_LWildCard(CompilerParser.Pr_LWildCardContext? context)
            {
                if (context == null) return LWildCardGreen.__Missing;
                var tDot = (InternalSyntaxToken?)this.VisitTerminal(context.E_TDot, CompilerSyntaxKind.TDot);
                return _factory.LWildCard(tDot);
            }
            
            public override GreenNode? VisitPr_LRange(CompilerParser.Pr_LRangeContext? context)
            {
                if (context == null) return LRangeGreen.__Missing;
                var startChar = (InternalSyntaxToken?)this.VisitTerminal(context.E_startChar, CompilerSyntaxKind.TString);
                var tDotDot = (InternalSyntaxToken?)this.VisitTerminal(context.E_TDotDot, CompilerSyntaxKind.TDotDot);
                var endChar = (InternalSyntaxToken?)this.VisitTerminal(context.E_endChar, CompilerSyntaxKind.TString);
                return _factory.LRange(startChar, tDotDot, endChar);
            }
            
            public override GreenNode? VisitPr_LBlock(CompilerParser.Pr_LBlockContext? context)
            {
                if (context == null) return LBlockGreen.__Missing;
                var tLParen = (InternalSyntaxToken?)this.VisitTerminal(context.E_TLParen, CompilerSyntaxKind.TLParen);
                var alternativesBuilder = _pool.AllocateSeparated<LAlternativeGreen>(reversed: false);
                var E_alternatives1Context = context.E_alternatives1;
                if (E_alternatives1Context is not null) alternativesBuilder.Add((LAlternativeGreen?)this.Visit(E_alternatives1Context) ?? LAlternativeGreen.__Missing);
                else alternativesBuilder.Add(LAlternativeGreen.__Missing);
                var E_alternatives2Context = context._E_alternatives2;
                var E_TBar1Context = context._E_TBar1;
                for (int i = 0; i < E_alternatives2Context.Count; ++i)
                {
                    if (i < E_TBar1Context.Count)
                    {
                        var _separator = E_TBar1Context[i];
                        alternativesBuilder.AddSeparator((InternalSyntaxToken?)this.VisitTerminal(_separator, CompilerSyntaxKind.TBar));
                    }
                    else
                    {
                        alternativesBuilder.AddSeparator((InternalSyntaxToken?)this.VisitTerminal((IToken?)null, CompilerSyntaxKind.TBar));
                    }
                    var _item = E_alternatives2Context[i];
                    if (_item is not null) alternativesBuilder.Add((LAlternativeGreen?)this.Visit(_item) ?? LAlternativeGreen.__Missing);
                    else alternativesBuilder.Add(LAlternativeGreen.__Missing);
                }
                var alternatives = alternativesBuilder.ToList();
                _pool.Free(alternativesBuilder);
                var tRParen = (InternalSyntaxToken?)this.VisitTerminal(context.E_TRParen, CompilerSyntaxKind.TRParen);
                return _factory.LBlock(tLParen, alternatives, tRParen);
            }
            
            public override GreenNode? VisitPr_ExpressionAlt1(CompilerParser.Pr_ExpressionAlt1Context? context)
            {
                if (context == null) return ExpressionAlt1Green.__Missing;
                SingleExpressionGreen? singleExpression = null;
                if (context.E_SingleExpression is not null) singleExpression = (SingleExpressionGreen?)this.Visit(context.E_SingleExpression) ?? SingleExpressionGreen.__Missing;
                else singleExpression = SingleExpressionGreen.__Missing;
                return _factory.ExpressionAlt1(singleExpression);
            }
            
            public override GreenNode? VisitPr_ExpressionAlt2(CompilerParser.Pr_ExpressionAlt2Context? context)
            {
                if (context == null) return ExpressionAlt2Green.__Missing;
                ArrayExpressionGreen? arrayExpression = null;
                if (context.E_ArrayExpression is not null) arrayExpression = (ArrayExpressionGreen?)this.Visit(context.E_ArrayExpression) ?? ArrayExpressionGreen.__Missing;
                else arrayExpression = ArrayExpressionGreen.__Missing;
                return _factory.ExpressionAlt2(arrayExpression);
            }
            
            public override GreenNode? VisitPr_SingleExpressionAlt1(CompilerParser.Pr_SingleExpressionAlt1Context? context)
            {
                if (context == null) return SingleExpressionAlt1Green.__Missing;
                SingleExpressionAlt1Block1Green? value = null;
                if (context.E_value is not null) value = (SingleExpressionAlt1Block1Green?)this.Visit(context.E_value) ?? SingleExpressionAlt1Block1Green.__Missing;
                else value = SingleExpressionAlt1Block1Green.__Missing;
                return _factory.SingleExpressionAlt1(value);
            }
            
            public override GreenNode? VisitPr_SingleExpressionAlt2(CompilerParser.Pr_SingleExpressionAlt2Context? context)
            {
                if (context == null) return SingleExpressionAlt2Green.__Missing;
                QualifierGreen? value = null;
                if (context.E_value1 is not null) value = (QualifierGreen?)this.Visit(context.E_value1) ?? QualifierGreen.__Missing;
                else value = QualifierGreen.__Missing;
                return _factory.SingleExpressionAlt2(value);
            }
            
            public override GreenNode? VisitPr_ArrayExpression(CompilerParser.Pr_ArrayExpressionContext? context)
            {
                if (context == null) return ArrayExpressionGreen.__Missing;
                var tLBrace = (InternalSyntaxToken?)this.VisitTerminal(context.E_TLBrace, CompilerSyntaxKind.TLBrace);
                ArrayExpressionBlock1Green? block = null;
                if (context.E_Block is not null) block = (ArrayExpressionBlock1Green?)this.Visit(context.E_Block);
                var tRBrace = (InternalSyntaxToken?)this.VisitTerminal(context.E_TRBrace, CompilerSyntaxKind.TRBrace);
                return _factory.ArrayExpression(tLBrace, block, tRBrace);
            }
            
            public override GreenNode? VisitPr_ParserAnnotation(CompilerParser.Pr_ParserAnnotationContext? context)
            {
                if (context == null) return ParserAnnotationGreen.__Missing;
                var tLBracket = (InternalSyntaxToken?)this.VisitTerminal(context.E_TLBracket, CompilerSyntaxKind.TLBracket);
                QualifierGreen? attributeClass = null;
                if (context.E_attributeClass is not null) attributeClass = (QualifierGreen?)this.Visit(context.E_attributeClass) ?? QualifierGreen.__Missing;
                else attributeClass = QualifierGreen.__Missing;
                ParserAnnotationBlock1Green? block = null;
                if (context.E_Block is not null) block = (ParserAnnotationBlock1Green?)this.Visit(context.E_Block);
                var tRBracket = (InternalSyntaxToken?)this.VisitTerminal(context.E_TRBracket, CompilerSyntaxKind.TRBracket);
                return _factory.ParserAnnotation(tLBracket, attributeClass, block, tRBracket);
            }
            
            public override GreenNode? VisitPr_LexerAnnotation(CompilerParser.Pr_LexerAnnotationContext? context)
            {
                if (context == null) return LexerAnnotationGreen.__Missing;
                var tLBracket = (InternalSyntaxToken?)this.VisitTerminal(context.E_TLBracket, CompilerSyntaxKind.TLBracket);
                QualifierGreen? attributeClass = null;
                if (context.E_attributeClass is not null) attributeClass = (QualifierGreen?)this.Visit(context.E_attributeClass) ?? QualifierGreen.__Missing;
                else attributeClass = QualifierGreen.__Missing;
                LexerAnnotationBlock1Green? block = null;
                if (context.E_Block is not null) block = (LexerAnnotationBlock1Green?)this.Visit(context.E_Block);
                var tRBracket = (InternalSyntaxToken?)this.VisitTerminal(context.E_TRBracket, CompilerSyntaxKind.TRBracket);
                return _factory.LexerAnnotation(tLBracket, attributeClass, block, tRBracket);
            }
            
            public override GreenNode? VisitPr_AnnotationArgument(CompilerParser.Pr_AnnotationArgumentContext? context)
            {
                if (context == null) return AnnotationArgumentGreen.__Missing;
                AnnotationArgumentBlock1Green? block = null;
                if (context.E_Block is not null) block = (AnnotationArgumentBlock1Green?)this.Visit(context.E_Block);
                ExpressionGreen? value = null;
                if (context.E_value is not null) value = (ExpressionGreen?)this.Visit(context.E_value) ?? ExpressionGreen.__Missing;
                else value = ExpressionGreen.__Missing;
                return _factory.AnnotationArgument(block, value);
            }
            
            public override GreenNode? VisitPr_Assignment(CompilerParser.Pr_AssignmentContext? context)
            {
                if (context == null) return AssignmentGreen.__Missing;
                InternalSyntaxToken? token = null;
                if (context.LR_TEq() is not null) token = (InternalSyntaxToken?)this.VisitTerminal(context.LR_TEq());
                if (context.LR_TQuestionEq() is not null) token = (InternalSyntaxToken?)this.VisitTerminal(context.LR_TQuestionEq());
                if (context.LR_TExclEq() is not null) token = (InternalSyntaxToken?)this.VisitTerminal(context.LR_TExclEq());
                if (context.LR_TPlusEq() is not null) token = (InternalSyntaxToken?)this.VisitTerminal(context.LR_TPlusEq());
                if (token is null) token = _factory.None;
                return _factory.Assignment(token);
            }
            
            public override GreenNode? VisitPr_Multiplicity(CompilerParser.Pr_MultiplicityContext? context)
            {
                if (context == null) return MultiplicityGreen.__Missing;
                InternalSyntaxToken? token = null;
                if (context.LR_TQuestion() is not null) token = (InternalSyntaxToken?)this.VisitTerminal(context.LR_TQuestion());
                if (context.LR_TAsterisk() is not null) token = (InternalSyntaxToken?)this.VisitTerminal(context.LR_TAsterisk());
                if (context.LR_TPlus() is not null) token = (InternalSyntaxToken?)this.VisitTerminal(context.LR_TPlus());
                if (context.LR_TQuestionQuestion() is not null) token = (InternalSyntaxToken?)this.VisitTerminal(context.LR_TQuestionQuestion());
                if (context.LR_TAsteriskQuestion() is not null) token = (InternalSyntaxToken?)this.VisitTerminal(context.LR_TAsteriskQuestion());
                if (context.LR_TPlusQuestion() is not null) token = (InternalSyntaxToken?)this.VisitTerminal(context.LR_TPlusQuestion());
                if (token is null) token = _factory.None;
                return _factory.Multiplicity(token);
            }
            
            public override GreenNode? VisitPr_TypeReferenceIdentifierAlt1(CompilerParser.Pr_TypeReferenceIdentifierAlt1Context? context)
            {
                if (context == null) return TypeReferenceIdentifierAlt1Green.__Missing;
                PrimitiveTypeGreen? primitiveType = null;
                if (context.E_PrimitiveType is not null) primitiveType = (PrimitiveTypeGreen?)this.Visit(context.E_PrimitiveType) ?? PrimitiveTypeGreen.__Missing;
                else primitiveType = PrimitiveTypeGreen.__Missing;
                return _factory.TypeReferenceIdentifierAlt1(primitiveType);
            }
            
            public override GreenNode? VisitPr_TypeReferenceIdentifierAlt2(CompilerParser.Pr_TypeReferenceIdentifierAlt2Context? context)
            {
                if (context == null) return TypeReferenceIdentifierAlt2Green.__Missing;
                IdentifierGreen? identifier = null;
                if (context.E_Identifier is not null) identifier = (IdentifierGreen?)this.Visit(context.E_Identifier) ?? IdentifierGreen.__Missing;
                else identifier = IdentifierGreen.__Missing;
                return _factory.TypeReferenceIdentifierAlt2(identifier);
            }
            
            public override GreenNode? VisitPr_TypeReferenceAlt1(CompilerParser.Pr_TypeReferenceAlt1Context? context)
            {
                if (context == null) return TypeReferenceAlt1Green.__Missing;
                PrimitiveTypeGreen? primitiveType = null;
                if (context.E_PrimitiveType is not null) primitiveType = (PrimitiveTypeGreen?)this.Visit(context.E_PrimitiveType) ?? PrimitiveTypeGreen.__Missing;
                else primitiveType = PrimitiveTypeGreen.__Missing;
                return _factory.TypeReferenceAlt1(primitiveType);
            }
            
            public override GreenNode? VisitPr_TypeReferenceAlt2(CompilerParser.Pr_TypeReferenceAlt2Context? context)
            {
                if (context == null) return TypeReferenceAlt2Green.__Missing;
                QualifierGreen? qualifier = null;
                if (context.E_Qualifier is not null) qualifier = (QualifierGreen?)this.Visit(context.E_Qualifier) ?? QualifierGreen.__Missing;
                else qualifier = QualifierGreen.__Missing;
                return _factory.TypeReferenceAlt2(qualifier);
            }
            
            public override GreenNode? VisitPr_PrimitiveType(CompilerParser.Pr_PrimitiveTypeContext? context)
            {
                if (context == null) return PrimitiveTypeGreen.__Missing;
                InternalSyntaxToken? token = null;
                if (context.LR_KBool() is not null) token = (InternalSyntaxToken?)this.VisitTerminal(context.LR_KBool());
                if (context.LR_KInt() is not null) token = (InternalSyntaxToken?)this.VisitTerminal(context.LR_KInt());
                if (context.LR_KDouble() is not null) token = (InternalSyntaxToken?)this.VisitTerminal(context.LR_KDouble());
                if (context.LR_KString() is not null) token = (InternalSyntaxToken?)this.VisitTerminal(context.LR_KString());
                if (context.LR_KType() is not null) token = (InternalSyntaxToken?)this.VisitTerminal(context.LR_KType());
                if (context.LR_KSymbol() is not null) token = (InternalSyntaxToken?)this.VisitTerminal(context.LR_KSymbol());
                if (context.LR_KObject() is not null) token = (InternalSyntaxToken?)this.VisitTerminal(context.LR_KObject());
                if (context.LR_KVoid() is not null) token = (InternalSyntaxToken?)this.VisitTerminal(context.LR_KVoid());
                if (token is null) token = _factory.None;
                return _factory.PrimitiveType(token);
            }
            
            public override GreenNode? VisitPr_Name(CompilerParser.Pr_NameContext? context)
            {
                if (context == null) return NameGreen.__Missing;
                IdentifierGreen? identifier = null;
                if (context.E_Identifier is not null) identifier = (IdentifierGreen?)this.Visit(context.E_Identifier) ?? IdentifierGreen.__Missing;
                else identifier = IdentifierGreen.__Missing;
                return _factory.Name(identifier);
            }
            
            public override GreenNode? VisitPr_Qualifier(CompilerParser.Pr_QualifierContext? context)
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
                        identifierBuilder.AddSeparator((InternalSyntaxToken?)this.VisitTerminal(_separator, CompilerSyntaxKind.TDot));
                    }
                    else
                    {
                        identifierBuilder.AddSeparator((InternalSyntaxToken?)this.VisitTerminal((IToken?)null, CompilerSyntaxKind.TDot));
                    }
                    var _item = E_Identifier2Context[i];
                    if (_item is not null) identifierBuilder.Add((IdentifierGreen?)this.Visit(_item) ?? IdentifierGreen.__Missing);
                    else identifierBuilder.Add(IdentifierGreen.__Missing);
                }
                var identifier = identifierBuilder.ToList();
                _pool.Free(identifierBuilder);
                return _factory.Qualifier(identifier);
            }
            
            public override GreenNode? VisitPr_Identifier(CompilerParser.Pr_IdentifierContext? context)
            {
                if (context == null) return IdentifierGreen.__Missing;
                InternalSyntaxToken? token = null;
                if (context.LR_TIdentifier() is not null) token = (InternalSyntaxToken?)this.VisitTerminal(context.LR_TIdentifier());
                if (context.LR_TVerbatimIdentifier() is not null) token = (InternalSyntaxToken?)this.VisitTerminal(context.LR_TVerbatimIdentifier());
                if (token is null) token = _factory.None;
                return _factory.Identifier(token);
            }
            
            public override GreenNode? VisitPr_MainBlock1(CompilerParser.Pr_MainBlock1Context? context)
            {
                if (context == null) return MainBlock1Green.__Missing;
                var kUsing = (InternalSyntaxToken?)this.VisitTerminal(context.E_KUsing, CompilerSyntaxKind.KUsing);
                UsingGreen? @using = null;
                if (context.E_Using is not null) @using = (UsingGreen?)this.Visit(context.E_Using) ?? UsingGreen.__Missing;
                else @using = UsingGreen.__Missing;
                var tSemicolon = (InternalSyntaxToken?)this.VisitTerminal(context.E_TSemicolon, CompilerSyntaxKind.TSemicolon);
                return _factory.MainBlock1(kUsing, @using, tSemicolon);
            }
            
            public override GreenNode? VisitPr_MainBlock2(CompilerParser.Pr_MainBlock2Context? context)
            {
                if (context == null) return MainBlock2Green.__Missing;
                LanguageDeclarationGreen? declarations = null;
                if (context.E_declarations is not null) declarations = (LanguageDeclarationGreen?)this.Visit(context.E_declarations) ?? LanguageDeclarationGreen.__Missing;
                else declarations = LanguageDeclarationGreen.__Missing;
                return _factory.MainBlock2(declarations);
            }
            
            public override GreenNode? VisitPr_GrammarBlock1(CompilerParser.Pr_GrammarBlock1Context? context)
            {
                if (context == null) return GrammarBlock1Green.__Missing;
                var E_grammarRulesContext = context._E_grammarRules;
                var grammarRulesBuilder = _pool.Allocate<GrammarRuleGreen>();
                for (int i = 0; i < E_grammarRulesContext.Count; ++i)
                {
                    if (E_grammarRulesContext[i] is not null) grammarRulesBuilder.Add((GrammarRuleGreen?)this.Visit(E_grammarRulesContext[i]) ?? GrammarRuleGreen.__Missing);
                    else grammarRulesBuilder.Add(GrammarRuleGreen.__Missing);
                }
                var grammarRules = grammarRulesBuilder.ToList();
                _pool.Free(grammarRulesBuilder);
                return _factory.GrammarBlock1(grammarRules);
            }
            
            public override GreenNode? VisitPr_RuleBlock1Alt1(CompilerParser.Pr_RuleBlock1Alt1Context? context)
            {
                if (context == null) return RuleBlock1Alt1Green.__Missing;
                TypeReferenceIdentifierGreen? returnType = null;
                if (context.E_returnType is not null) returnType = (TypeReferenceIdentifierGreen?)this.Visit(context.E_returnType) ?? TypeReferenceIdentifierGreen.__Missing;
                else returnType = TypeReferenceIdentifierGreen.__Missing;
                return _factory.RuleBlock1Alt1(returnType);
            }
            
            public override GreenNode? VisitPr_RuleBlock1Alt2(CompilerParser.Pr_RuleBlock1Alt2Context? context)
            {
                if (context == null) return RuleBlock1Alt2Green.__Missing;
                IdentifierGreen? identifier = null;
                if (context.E_Identifier is not null) identifier = (IdentifierGreen?)this.Visit(context.E_Identifier) ?? IdentifierGreen.__Missing;
                else identifier = IdentifierGreen.__Missing;
                var kReturns = (InternalSyntaxToken?)this.VisitTerminal(context.E_KReturns, CompilerSyntaxKind.KReturns);
                TypeReferenceGreen? returnType = null;
                if (context.E_returnType1 is not null) returnType = (TypeReferenceGreen?)this.Visit(context.E_returnType1) ?? TypeReferenceGreen.__Missing;
                else returnType = TypeReferenceGreen.__Missing;
                return _factory.RuleBlock1Alt2(identifier, kReturns, returnType);
            }
            
            public override GreenNode? VisitPr_RulealternativesBlock(CompilerParser.Pr_RulealternativesBlockContext? context)
            {
                if (context == null) return RulealternativesBlockGreen.__Missing;
                var tBar = (InternalSyntaxToken?)this.VisitTerminal(context.E_TBar1, CompilerSyntaxKind.TBar);
                AlternativeGreen? alternatives = null;
                if (context.E_alternatives2 is not null) alternatives = (AlternativeGreen?)this.Visit(context.E_alternatives2) ?? AlternativeGreen.__Missing;
                else alternatives = AlternativeGreen.__Missing;
                return _factory.RulealternativesBlock(tBar, alternatives);
            }
            
            public override GreenNode? VisitPr_AlternativeBlock1(CompilerParser.Pr_AlternativeBlock1Context? context)
            {
                if (context == null) return AlternativeBlock1Green.__Missing;
                var E_annotationsContext = context._E_annotations;
                var annotations1Builder = _pool.Allocate<ParserAnnotationGreen>();
                for (int i = 0; i < E_annotationsContext.Count; ++i)
                {
                    if (E_annotationsContext[i] is not null) annotations1Builder.Add((ParserAnnotationGreen?)this.Visit(E_annotationsContext[i]) ?? ParserAnnotationGreen.__Missing);
                    else annotations1Builder.Add(ParserAnnotationGreen.__Missing);
                }
                var annotations1 = annotations1Builder.ToList();
                _pool.Free(annotations1Builder);
                var kAlt = (InternalSyntaxToken?)this.VisitTerminal(context.E_KAlt, CompilerSyntaxKind.KAlt);
                NameGreen? name = null;
                if (context.E_Name is not null) name = (NameGreen?)this.Visit(context.E_Name) ?? NameGreen.__Missing;
                else name = NameGreen.__Missing;
                AlternativeBlock1Block1Green? block = null;
                if (context.E_Block is not null) block = (AlternativeBlock1Block1Green?)this.Visit(context.E_Block);
                var tColon = (InternalSyntaxToken?)this.VisitTerminal(context.E_TColon, CompilerSyntaxKind.TColon);
                return _factory.AlternativeBlock1(annotations1, kAlt, name, block, tColon);
            }
            
            public override GreenNode? VisitPr_AlternativeBlock1Block1(CompilerParser.Pr_AlternativeBlock1Block1Context? context)
            {
                if (context == null) return AlternativeBlock1Block1Green.__Missing;
                var kReturns = (InternalSyntaxToken?)this.VisitTerminal(context.E_KReturns, CompilerSyntaxKind.KReturns);
                TypeReferenceGreen? returnType = null;
                if (context.E_returnType is not null) returnType = (TypeReferenceGreen?)this.Visit(context.E_returnType) ?? TypeReferenceGreen.__Missing;
                else returnType = TypeReferenceGreen.__Missing;
                return _factory.AlternativeBlock1Block1(kReturns, returnType);
            }
            
            public override GreenNode? VisitPr_AlternativeBlock2(CompilerParser.Pr_AlternativeBlock2Context? context)
            {
                if (context == null) return AlternativeBlock2Green.__Missing;
                var tEqGt = (InternalSyntaxToken?)this.VisitTerminal(context.E_TEqGt, CompilerSyntaxKind.TEqGt);
                ExpressionGreen? returnValue = null;
                if (context.E_returnValue is not null) returnValue = (ExpressionGreen?)this.Visit(context.E_returnValue) ?? ExpressionGreen.__Missing;
                else returnValue = ExpressionGreen.__Missing;
                return _factory.AlternativeBlock2(tEqGt, returnValue);
            }
            
            public override GreenNode? VisitPr_ElementBlock1(CompilerParser.Pr_ElementBlock1Context? context)
            {
                if (context == null) return ElementBlock1Green.__Missing;
                var E_annotationsContext = context._E_annotations;
                var annotations1Builder = _pool.Allocate<ParserAnnotationGreen>();
                for (int i = 0; i < E_annotationsContext.Count; ++i)
                {
                    if (E_annotationsContext[i] is not null) annotations1Builder.Add((ParserAnnotationGreen?)this.Visit(E_annotationsContext[i]) ?? ParserAnnotationGreen.__Missing);
                    else annotations1Builder.Add(ParserAnnotationGreen.__Missing);
                }
                var annotations1 = annotations1Builder.ToList();
                _pool.Free(annotations1Builder);
                NameGreen? name = null;
                if (context.E_Name is not null) name = (NameGreen?)this.Visit(context.E_Name) ?? NameGreen.__Missing;
                else name = NameGreen.__Missing;
                AssignmentGreen? assignment = null;
                if (context.E_assignment is not null) assignment = (AssignmentGreen?)this.Visit(context.E_assignment) ?? AssignmentGreen.__Missing;
                else assignment = AssignmentGreen.__Missing;
                return _factory.ElementBlock1(annotations1, name, assignment);
            }
            
            public override GreenNode? VisitPr_BlockalternativesBlock(CompilerParser.Pr_BlockalternativesBlockContext? context)
            {
                if (context == null) return BlockalternativesBlockGreen.__Missing;
                var tBar = (InternalSyntaxToken?)this.VisitTerminal(context.E_TBar1, CompilerSyntaxKind.TBar);
                BlockAlternativeGreen? alternatives = null;
                if (context.E_alternatives2 is not null) alternatives = (BlockAlternativeGreen?)this.Visit(context.E_alternatives2) ?? BlockAlternativeGreen.__Missing;
                else alternatives = BlockAlternativeGreen.__Missing;
                return _factory.BlockalternativesBlock(tBar, alternatives);
            }
            
            public override GreenNode? VisitPr_BlockAlternativeBlock1(CompilerParser.Pr_BlockAlternativeBlock1Context? context)
            {
                if (context == null) return BlockAlternativeBlock1Green.__Missing;
                var tEqGt = (InternalSyntaxToken?)this.VisitTerminal(context.E_TEqGt, CompilerSyntaxKind.TEqGt);
                ExpressionGreen? returnValue = null;
                if (context.E_returnValue is not null) returnValue = (ExpressionGreen?)this.Visit(context.E_returnValue) ?? ExpressionGreen.__Missing;
                else returnValue = ExpressionGreen.__Missing;
                return _factory.BlockAlternativeBlock1(tEqGt, returnValue);
            }
            
            public override GreenNode? VisitPr_RuleRefAlt3referencedTypesBlock(CompilerParser.Pr_RuleRefAlt3referencedTypesBlockContext? context)
            {
                if (context == null) return RuleRefAlt3referencedTypesBlockGreen.__Missing;
                var tComma = (InternalSyntaxToken?)this.VisitTerminal(context.E_TComma1, CompilerSyntaxKind.TComma);
                TypeReferenceGreen? referencedTypes = null;
                if (context.E_referencedTypes2 is not null) referencedTypes = (TypeReferenceGreen?)this.Visit(context.E_referencedTypes2) ?? TypeReferenceGreen.__Missing;
                else referencedTypes = TypeReferenceGreen.__Missing;
                return _factory.RuleRefAlt3referencedTypesBlock(tComma, referencedTypes);
            }
            
            public override GreenNode? VisitPr_RuleRefAlt3Block1(CompilerParser.Pr_RuleRefAlt3Block1Context? context)
            {
                if (context == null) return RuleRefAlt3Block1Green.__Missing;
                var tBar = (InternalSyntaxToken?)this.VisitTerminal(context.E_TBar, CompilerSyntaxKind.TBar);
                IdentifierGreen? grammarRule = null;
                if (context.E_grammarRule is not null) grammarRule = (IdentifierGreen?)this.Visit(context.E_grammarRule) ?? IdentifierGreen.__Missing;
                else grammarRule = IdentifierGreen.__Missing;
                return _factory.RuleRefAlt3Block1(tBar, grammarRule);
            }
            
            public override GreenNode? VisitPr_TokenBlock1Alt1(CompilerParser.Pr_TokenBlock1Alt1Context? context)
            {
                if (context == null) return TokenBlock1Alt1Green.__Missing;
                var kToken = (InternalSyntaxToken?)this.VisitTerminal(context.E_KToken, CompilerSyntaxKind.KToken);
                NameGreen? name = null;
                if (context.E_Name is not null) name = (NameGreen?)this.Visit(context.E_Name) ?? NameGreen.__Missing;
                else name = NameGreen.__Missing;
                TokenBlock1Alt1Block1Green? block = null;
                if (context.E_Block is not null) block = (TokenBlock1Alt1Block1Green?)this.Visit(context.E_Block);
                return _factory.TokenBlock1Alt1(kToken, name, block);
            }
            
            public override GreenNode? VisitPr_TokenBlock1Alt2(CompilerParser.Pr_TokenBlock1Alt2Context? context)
            {
                if (context == null) return TokenBlock1Alt2Green.__Missing;
                var isTrivia = (InternalSyntaxToken?)this.VisitTerminal(context.E_isTrivia, CompilerSyntaxKind.KHidden);
                NameGreen? name = null;
                if (context.E_Name1 is not null) name = (NameGreen?)this.Visit(context.E_Name1) ?? NameGreen.__Missing;
                else name = NameGreen.__Missing;
                return _factory.TokenBlock1Alt2(isTrivia, name);
            }
            
            public override GreenNode? VisitPr_TokenBlock1Alt1Block1(CompilerParser.Pr_TokenBlock1Alt1Block1Context? context)
            {
                if (context == null) return TokenBlock1Alt1Block1Green.__Missing;
                var kReturns = (InternalSyntaxToken?)this.VisitTerminal(context.E_KReturns, CompilerSyntaxKind.KReturns);
                TypeReferenceGreen? returnType = null;
                if (context.E_returnType is not null) returnType = (TypeReferenceGreen?)this.Visit(context.E_returnType) ?? TypeReferenceGreen.__Missing;
                else returnType = TypeReferenceGreen.__Missing;
                return _factory.TokenBlock1Alt1Block1(kReturns, returnType);
            }
            
            public override GreenNode? VisitPr_TokenalternativesBlock(CompilerParser.Pr_TokenalternativesBlockContext? context)
            {
                if (context == null) return TokenalternativesBlockGreen.__Missing;
                var tBar = (InternalSyntaxToken?)this.VisitTerminal(context.E_TBar1, CompilerSyntaxKind.TBar);
                LAlternativeGreen? alternatives = null;
                if (context.E_alternatives2 is not null) alternatives = (LAlternativeGreen?)this.Visit(context.E_alternatives2) ?? LAlternativeGreen.__Missing;
                else alternatives = LAlternativeGreen.__Missing;
                return _factory.TokenalternativesBlock(tBar, alternatives);
            }
            
            public override GreenNode? VisitPr_FragmentalternativesBlock(CompilerParser.Pr_FragmentalternativesBlockContext? context)
            {
                if (context == null) return FragmentalternativesBlockGreen.__Missing;
                var tBar = (InternalSyntaxToken?)this.VisitTerminal(context.E_TBar1, CompilerSyntaxKind.TBar);
                LAlternativeGreen? alternatives = null;
                if (context.E_alternatives2 is not null) alternatives = (LAlternativeGreen?)this.Visit(context.E_alternatives2) ?? LAlternativeGreen.__Missing;
                else alternatives = LAlternativeGreen.__Missing;
                return _factory.FragmentalternativesBlock(tBar, alternatives);
            }
            
            public override GreenNode? VisitPr_LBlockalternativesBlock(CompilerParser.Pr_LBlockalternativesBlockContext? context)
            {
                if (context == null) return LBlockalternativesBlockGreen.__Missing;
                var tBar = (InternalSyntaxToken?)this.VisitTerminal(context.E_TBar1, CompilerSyntaxKind.TBar);
                LAlternativeGreen? alternatives = null;
                if (context.E_alternatives2 is not null) alternatives = (LAlternativeGreen?)this.Visit(context.E_alternatives2) ?? LAlternativeGreen.__Missing;
                else alternatives = LAlternativeGreen.__Missing;
                return _factory.LBlockalternativesBlock(tBar, alternatives);
            }
            
            public override GreenNode? VisitPr_SingleExpressionAlt1Block1Alt1(CompilerParser.Pr_SingleExpressionAlt1Block1Alt1Context? context)
            {
                if (context == null) return SingleExpressionAlt1Block1Alt1Green.__Missing;
                var kNull = (InternalSyntaxToken?)this.VisitTerminal(context.E_KNull, CompilerSyntaxKind.KNull);
                return _factory.SingleExpressionAlt1Block1Alt1(kNull);
            }
            
            public override GreenNode? VisitPr_SingleExpressionAlt1Block1Alt2(CompilerParser.Pr_SingleExpressionAlt1Block1Alt2Context? context)
            {
                if (context == null) return SingleExpressionAlt1Block1Alt2Green.__Missing;
                var kTrue = (InternalSyntaxToken?)this.VisitTerminal(context.E_KTrue, CompilerSyntaxKind.KTrue);
                return _factory.SingleExpressionAlt1Block1Alt2(kTrue);
            }
            
            public override GreenNode? VisitPr_SingleExpressionAlt1Block1Alt3(CompilerParser.Pr_SingleExpressionAlt1Block1Alt3Context? context)
            {
                if (context == null) return SingleExpressionAlt1Block1Alt3Green.__Missing;
                var kFalse = (InternalSyntaxToken?)this.VisitTerminal(context.E_KFalse, CompilerSyntaxKind.KFalse);
                return _factory.SingleExpressionAlt1Block1Alt3(kFalse);
            }
            
            public override GreenNode? VisitPr_SingleExpressionAlt1Block1Alt4(CompilerParser.Pr_SingleExpressionAlt1Block1Alt4Context? context)
            {
                if (context == null) return SingleExpressionAlt1Block1Alt4Green.__Missing;
                var tString = (InternalSyntaxToken?)this.VisitTerminal(context.E_TString, CompilerSyntaxKind.TString);
                return _factory.SingleExpressionAlt1Block1Alt4(tString);
            }
            
            public override GreenNode? VisitPr_SingleExpressionAlt1Block1Alt5(CompilerParser.Pr_SingleExpressionAlt1Block1Alt5Context? context)
            {
                if (context == null) return SingleExpressionAlt1Block1Alt5Green.__Missing;
                var tInteger = (InternalSyntaxToken?)this.VisitTerminal(context.E_TInteger, CompilerSyntaxKind.TInteger);
                return _factory.SingleExpressionAlt1Block1Alt5(tInteger);
            }
            
            public override GreenNode? VisitPr_SingleExpressionAlt1Block1Alt6(CompilerParser.Pr_SingleExpressionAlt1Block1Alt6Context? context)
            {
                if (context == null) return SingleExpressionAlt1Block1Alt6Green.__Missing;
                var tDecimal = (InternalSyntaxToken?)this.VisitTerminal(context.E_TDecimal, CompilerSyntaxKind.TDecimal);
                return _factory.SingleExpressionAlt1Block1Alt6(tDecimal);
            }
            
            public override GreenNode? VisitPr_SingleExpressionAlt1Block1Alt7(CompilerParser.Pr_SingleExpressionAlt1Block1Alt7Context? context)
            {
                if (context == null) return SingleExpressionAlt1Block1Alt7Green.__Missing;
                PrimitiveTypeGreen? primitiveType = null;
                if (context.E_PrimitiveType is not null) primitiveType = (PrimitiveTypeGreen?)this.Visit(context.E_PrimitiveType) ?? PrimitiveTypeGreen.__Missing;
                else primitiveType = PrimitiveTypeGreen.__Missing;
                return _factory.SingleExpressionAlt1Block1Alt7(primitiveType);
            }
            
            public override GreenNode? VisitPr_ArrayExpressionBlock1(CompilerParser.Pr_ArrayExpressionBlock1Context? context)
            {
                if (context == null) return ArrayExpressionBlock1Green.__Missing;
                var itemsBuilder = _pool.AllocateSeparated<SingleExpressionGreen>(reversed: false);
                var E_items1Context = context.E_items1;
                if (E_items1Context is not null) itemsBuilder.Add((SingleExpressionGreen?)this.Visit(E_items1Context) ?? SingleExpressionGreen.__Missing);
                else itemsBuilder.Add(SingleExpressionGreen.__Missing);
                var E_items2Context = context._E_items2;
                var E_TComma1Context = context._E_TComma1;
                for (int i = 0; i < E_items2Context.Count; ++i)
                {
                    if (i < E_TComma1Context.Count)
                    {
                        var _separator = E_TComma1Context[i];
                        itemsBuilder.AddSeparator((InternalSyntaxToken?)this.VisitTerminal(_separator, CompilerSyntaxKind.TComma));
                    }
                    else
                    {
                        itemsBuilder.AddSeparator((InternalSyntaxToken?)this.VisitTerminal((IToken?)null, CompilerSyntaxKind.TComma));
                    }
                    var _item = E_items2Context[i];
                    if (_item is not null) itemsBuilder.Add((SingleExpressionGreen?)this.Visit(_item) ?? SingleExpressionGreen.__Missing);
                    else itemsBuilder.Add(SingleExpressionGreen.__Missing);
                }
                var items = itemsBuilder.ToList();
                _pool.Free(itemsBuilder);
                return _factory.ArrayExpressionBlock1(items);
            }
            
            public override GreenNode? VisitPr_ArrayExpressionBlock1itemsBlock(CompilerParser.Pr_ArrayExpressionBlock1itemsBlockContext? context)
            {
                if (context == null) return ArrayExpressionBlock1itemsBlockGreen.__Missing;
                var tComma = (InternalSyntaxToken?)this.VisitTerminal(context.E_TComma1, CompilerSyntaxKind.TComma);
                SingleExpressionGreen? items = null;
                if (context.E_items2 is not null) items = (SingleExpressionGreen?)this.Visit(context.E_items2) ?? SingleExpressionGreen.__Missing;
                else items = SingleExpressionGreen.__Missing;
                return _factory.ArrayExpressionBlock1itemsBlock(tComma, items);
            }
            
            public override GreenNode? VisitPr_ParserAnnotationBlock1(CompilerParser.Pr_ParserAnnotationBlock1Context? context)
            {
                if (context == null) return ParserAnnotationBlock1Green.__Missing;
                var tLParen = (InternalSyntaxToken?)this.VisitTerminal(context.E_TLParen, CompilerSyntaxKind.TLParen);
                var argumentsBuilder = _pool.AllocateSeparated<AnnotationArgumentGreen>(reversed: false);
                var E_arguments1Context = context.E_arguments1;
                if (E_arguments1Context is not null) argumentsBuilder.Add((AnnotationArgumentGreen?)this.Visit(E_arguments1Context) ?? AnnotationArgumentGreen.__Missing);
                else argumentsBuilder.Add(AnnotationArgumentGreen.__Missing);
                var E_arguments2Context = context._E_arguments2;
                var E_TComma1Context = context._E_TComma1;
                for (int i = 0; i < E_arguments2Context.Count; ++i)
                {
                    if (i < E_TComma1Context.Count)
                    {
                        var _separator = E_TComma1Context[i];
                        argumentsBuilder.AddSeparator((InternalSyntaxToken?)this.VisitTerminal(_separator, CompilerSyntaxKind.TComma));
                    }
                    else
                    {
                        argumentsBuilder.AddSeparator((InternalSyntaxToken?)this.VisitTerminal((IToken?)null, CompilerSyntaxKind.TComma));
                    }
                    var _item = E_arguments2Context[i];
                    if (_item is not null) argumentsBuilder.Add((AnnotationArgumentGreen?)this.Visit(_item) ?? AnnotationArgumentGreen.__Missing);
                    else argumentsBuilder.Add(AnnotationArgumentGreen.__Missing);
                }
                var arguments = argumentsBuilder.ToList();
                _pool.Free(argumentsBuilder);
                var tRParen = (InternalSyntaxToken?)this.VisitTerminal(context.E_TRParen, CompilerSyntaxKind.TRParen);
                return _factory.ParserAnnotationBlock1(tLParen, arguments, tRParen);
            }
            
            public override GreenNode? VisitPr_ParserAnnotationBlock1argumentsBlock(CompilerParser.Pr_ParserAnnotationBlock1argumentsBlockContext? context)
            {
                if (context == null) return ParserAnnotationBlock1argumentsBlockGreen.__Missing;
                var tComma = (InternalSyntaxToken?)this.VisitTerminal(context.E_TComma1, CompilerSyntaxKind.TComma);
                AnnotationArgumentGreen? arguments = null;
                if (context.E_arguments2 is not null) arguments = (AnnotationArgumentGreen?)this.Visit(context.E_arguments2) ?? AnnotationArgumentGreen.__Missing;
                else arguments = AnnotationArgumentGreen.__Missing;
                return _factory.ParserAnnotationBlock1argumentsBlock(tComma, arguments);
            }
            
            public override GreenNode? VisitPr_LexerAnnotationBlock1(CompilerParser.Pr_LexerAnnotationBlock1Context? context)
            {
                if (context == null) return LexerAnnotationBlock1Green.__Missing;
                var tLParen = (InternalSyntaxToken?)this.VisitTerminal(context.E_TLParen, CompilerSyntaxKind.TLParen);
                var argumentsBuilder = _pool.AllocateSeparated<AnnotationArgumentGreen>(reversed: false);
                var E_arguments1Context = context.E_arguments1;
                if (E_arguments1Context is not null) argumentsBuilder.Add((AnnotationArgumentGreen?)this.Visit(E_arguments1Context) ?? AnnotationArgumentGreen.__Missing);
                else argumentsBuilder.Add(AnnotationArgumentGreen.__Missing);
                var E_arguments2Context = context._E_arguments2;
                var E_TComma1Context = context._E_TComma1;
                for (int i = 0; i < E_arguments2Context.Count; ++i)
                {
                    if (i < E_TComma1Context.Count)
                    {
                        var _separator = E_TComma1Context[i];
                        argumentsBuilder.AddSeparator((InternalSyntaxToken?)this.VisitTerminal(_separator, CompilerSyntaxKind.TComma));
                    }
                    else
                    {
                        argumentsBuilder.AddSeparator((InternalSyntaxToken?)this.VisitTerminal((IToken?)null, CompilerSyntaxKind.TComma));
                    }
                    var _item = E_arguments2Context[i];
                    if (_item is not null) argumentsBuilder.Add((AnnotationArgumentGreen?)this.Visit(_item) ?? AnnotationArgumentGreen.__Missing);
                    else argumentsBuilder.Add(AnnotationArgumentGreen.__Missing);
                }
                var arguments = argumentsBuilder.ToList();
                _pool.Free(argumentsBuilder);
                var tRParen = (InternalSyntaxToken?)this.VisitTerminal(context.E_TRParen, CompilerSyntaxKind.TRParen);
                return _factory.LexerAnnotationBlock1(tLParen, arguments, tRParen);
            }
            
            public override GreenNode? VisitPr_LexerAnnotationBlock1argumentsBlock(CompilerParser.Pr_LexerAnnotationBlock1argumentsBlockContext? context)
            {
                if (context == null) return LexerAnnotationBlock1argumentsBlockGreen.__Missing;
                var tComma = (InternalSyntaxToken?)this.VisitTerminal(context.E_TComma1, CompilerSyntaxKind.TComma);
                AnnotationArgumentGreen? arguments = null;
                if (context.E_arguments2 is not null) arguments = (AnnotationArgumentGreen?)this.Visit(context.E_arguments2) ?? AnnotationArgumentGreen.__Missing;
                else arguments = AnnotationArgumentGreen.__Missing;
                return _factory.LexerAnnotationBlock1argumentsBlock(tComma, arguments);
            }
            
            public override GreenNode? VisitPr_AnnotationArgumentBlock1(CompilerParser.Pr_AnnotationArgumentBlock1Context? context)
            {
                if (context == null) return AnnotationArgumentBlock1Green.__Missing;
                IdentifierGreen? namedParameter = null;
                if (context.E_namedParameter is not null) namedParameter = (IdentifierGreen?)this.Visit(context.E_namedParameter) ?? IdentifierGreen.__Missing;
                else namedParameter = IdentifierGreen.__Missing;
                var tColon = (InternalSyntaxToken?)this.VisitTerminal(context.E_TColon, CompilerSyntaxKind.TColon);
                return _factory.AnnotationArgumentBlock1(namedParameter, tColon);
            }
            
            public override GreenNode? VisitPr_QualifierIdentifierBlock(CompilerParser.Pr_QualifierIdentifierBlockContext? context)
            {
                if (context == null) return QualifierIdentifierBlockGreen.__Missing;
                var tDot = (InternalSyntaxToken?)this.VisitTerminal(context.E_TDot1, CompilerSyntaxKind.TDot);
                IdentifierGreen? identifier = null;
                if (context.E_Identifier2 is not null) identifier = (IdentifierGreen?)this.Visit(context.E_Identifier2) ?? IdentifierGreen.__Missing;
                else identifier = IdentifierGreen.__Missing;
                return _factory.QualifierIdentifierBlock(tDot, identifier);
            }
        }
    }
}
