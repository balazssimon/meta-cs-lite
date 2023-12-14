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
using MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax.InternalSyntax;

#nullable enable

namespace MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax
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
                var kNamespace = this.VisitTerminal(context.kNamespace, CompilerSyntaxKind.KNamespace);
                QualifierGreen? name = null;
                if (context.nameAntlr1 is not null) name = (QualifierGreen?)this.Visit(context.nameAntlr1) ?? QualifierGreen.__Missing;
                else name = QualifierGreen.__Missing;
                var tSemicolon = this.VisitTerminal(context.tSemicolon, CompilerSyntaxKind.TSemicolon);
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
                var eof = this.VisitTerminal(context.eof, CompilerSyntaxKind.Eof);
            	return _factory.Main((InternalSyntaxToken)kNamespace, name, (InternalSyntaxToken)tSemicolon, @using, declarations, (InternalSyntaxToken)eof);
            }
            public override GreenNode? VisitPr_Using(CompilerParser.Pr_UsingContext? context)
            {
               	if (context == null) return UsingGreen.__Missing;
                var kUsing = this.VisitTerminal(context.kUsing, CompilerSyntaxKind.KUsing);
                QualifierGreen? namespaces = null;
                if (context.namespacesAntlr1 is not null) namespaces = (QualifierGreen?)this.Visit(context.namespacesAntlr1) ?? QualifierGreen.__Missing;
                else namespaces = QualifierGreen.__Missing;
                var tSemicolon = this.VisitTerminal(context.tSemicolon, CompilerSyntaxKind.TSemicolon);
            	return _factory.Using((InternalSyntaxToken)kUsing, namespaces, (InternalSyntaxToken)tSemicolon);
            }
            public override GreenNode? VisitPr_Declarations(CompilerParser.Pr_DeclarationsContext? context)
            {
               	if (context == null) return DeclarationsGreen.__Missing;
                LanguageDeclarationGreen? declarations = null;
                if (context.declarationsAntlr1 is not null) declarations = (LanguageDeclarationGreen?)this.Visit(context.declarationsAntlr1) ?? LanguageDeclarationGreen.__Missing;
                else declarations = LanguageDeclarationGreen.__Missing;
                var declarations1Context = context._declarations1Antlr1;
                var declarations1Builder = _pool.Allocate<RuleGreen>();
                for (int i = 0; i < declarations1Context.Count; ++i)
                {
                    if (declarations1Context[i] is not null) declarations1Builder.Add((RuleGreen?)this.Visit(declarations1Context[i]) ?? RuleGreen.__Missing);
                    else declarations1Builder.Add(RuleGreen.__Missing);
                }
                var declarations1 = declarations1Builder.ToList();
                _pool.Free(declarations1Builder);
            	return _factory.Declarations(declarations, declarations1);
            }
            public override GreenNode? VisitPr_LanguageDeclaration(CompilerParser.Pr_LanguageDeclarationContext? context)
            {
               	if (context == null) return LanguageDeclarationGreen.__Missing;
                var kLanguage = this.VisitTerminal(context.kLanguage, CompilerSyntaxKind.KLanguage);
                NameGreen? name = null;
                if (context.nameAntlr1 is not null) name = (NameGreen?)this.Visit(context.nameAntlr1) ?? NameGreen.__Missing;
                else name = NameGreen.__Missing;
                var tSemicolon = this.VisitTerminal(context.tSemicolon, CompilerSyntaxKind.TSemicolon);
                GrammarGreen? grammar = null;
                if (context.grammarAntlr1 is not null) grammar = (GrammarGreen?)this.Visit(context.grammarAntlr1) ?? GrammarGreen.__Missing;
                else grammar = GrammarGreen.__Missing;
            	return _factory.LanguageDeclaration((InternalSyntaxToken)kLanguage, name, (InternalSyntaxToken)tSemicolon, grammar);
            }
            public override GreenNode? VisitPr_Grammar(CompilerParser.Pr_GrammarContext? context)
            {
               	if (context == null) return GrammarGreen.__Missing;
                GrammarBlock1Green? grammarBlock1 = null;
                if (context.grammarBlock1Antlr1 is not null) grammarBlock1 = (GrammarBlock1Green?)this.Visit(context.grammarBlock1Antlr1) ?? GrammarBlock1Green.__Missing;
                else grammarBlock1 = GrammarBlock1Green.__Missing;
            	return _factory.Grammar(grammarBlock1);
            }
            public override GreenNode? VisitPr_GrammarRuleAlt1(CompilerParser.Pr_GrammarRuleAlt1Context? context)
            {
               	if (context == null) return GrammarRuleAlt1Green.__Missing;
                RuleGreen? rule = null;
                if (context.ruleAntlr1 is not null) rule = (RuleGreen?)this.Visit(context.ruleAntlr1) ?? RuleGreen.__Missing;
                else rule = RuleGreen.__Missing;
            	return _factory.GrammarRuleAlt1(rule);
            }
            public override GreenNode? VisitPr_Block(CompilerParser.Pr_BlockContext? context)
            {
               	if (context == null) return BlockGreen.__Missing;
                var annotations1Context = context._annotations1Antlr1;
                var annotations1Builder = _pool.Allocate<ParserAnnotationGreen>();
                for (int i = 0; i < annotations1Context.Count; ++i)
                {
                    if (annotations1Context[i] is not null) annotations1Builder.Add((ParserAnnotationGreen?)this.Visit(annotations1Context[i]) ?? ParserAnnotationGreen.__Missing);
                    else annotations1Builder.Add(ParserAnnotationGreen.__Missing);
                }
                var annotations1 = annotations1Builder.ToList();
                _pool.Free(annotations1Builder);
                var kBlock = this.VisitTerminal(context.kBlock, CompilerSyntaxKind.KBlock);
                NameGreen? name = null;
                if (context.nameAntlr1 is not null) name = (NameGreen?)this.Visit(context.nameAntlr1) ?? NameGreen.__Missing;
                else name = NameGreen.__Missing;
                BlockBlock1Green? blockBlock1 = null;
                if (context.blockBlock1Antlr1 is not null) blockBlock1 = (BlockBlock1Green?)this.Visit(context.blockBlock1Antlr1);
                var tColon = this.VisitTerminal(context.tColon, CompilerSyntaxKind.TColon);
                var alternativeListBuilder = _pool.AllocateSeparated<AlternativeGreen>(reversed: false);
                var alternativesContext = context.alternativesAntlr1;
                if (alternativesContext is not null) alternativeListBuilder.Add((AlternativeGreen?)this.Visit(alternativesContext) ?? AlternativeGreen.__Missing);
                else alternativeListBuilder.Add(AlternativeGreen.__Missing);
                var alternativeListContext = context._blockBlock2Antlr1;
                for (int i = 0; i < alternativeListContext.Count; ++i)
                {
                    var itemContext = alternativeListContext[i];
                    if (itemContext is not null)
                    {
                        var item = itemContext.alternativesAntlr1;
                        var separator = itemContext.tBar;
                        alternativeListBuilder.AddSeparator(this.VisitTerminal(separator, CompilerSyntaxKind.TBar));
                        if (item is not null) alternativeListBuilder.Add((AlternativeGreen?)this.Visit(item) ?? AlternativeGreen.__Missing);
                        else alternativeListBuilder.Add(AlternativeGreen.__Missing);
                    }
                }
                var alternativeList = alternativeListBuilder.ToList();
                _pool.Free(alternativeListBuilder);
                var tSemicolon = this.VisitTerminal(context.tSemicolon, CompilerSyntaxKind.TSemicolon);
            	return _factory.Block(annotations1, (InternalSyntaxToken)kBlock, name, blockBlock1, (InternalSyntaxToken)tColon, alternativeList, (InternalSyntaxToken)tSemicolon);
            }
            public override GreenNode? VisitPr_Token(CompilerParser.Pr_TokenContext? context)
            {
               	if (context == null) return TokenGreen.__Missing;
                var annotations1Context = context._annotations1Antlr1;
                var annotations1Builder = _pool.Allocate<LexerAnnotationGreen>();
                for (int i = 0; i < annotations1Context.Count; ++i)
                {
                    if (annotations1Context[i] is not null) annotations1Builder.Add((LexerAnnotationGreen?)this.Visit(annotations1Context[i]) ?? LexerAnnotationGreen.__Missing);
                    else annotations1Builder.Add(LexerAnnotationGreen.__Missing);
                }
                var annotations1 = annotations1Builder.ToList();
                _pool.Free(annotations1Builder);
                TokenBlock1Green? tokenBlock1 = null;
                if (context.tokenBlock1Antlr1 is not null) tokenBlock1 = (TokenBlock1Green?)this.Visit(context.tokenBlock1Antlr1) ?? TokenBlock1Green.__Missing;
                else tokenBlock1 = TokenBlock1Green.__Missing;
                var tColon = this.VisitTerminal(context.tColon, CompilerSyntaxKind.TColon);
                var lAlternativeListBuilder = _pool.AllocateSeparated<LAlternativeGreen>(reversed: false);
                var alternativesContext = context.alternativesAntlr1;
                if (alternativesContext is not null) lAlternativeListBuilder.Add((LAlternativeGreen?)this.Visit(alternativesContext) ?? LAlternativeGreen.__Missing);
                else lAlternativeListBuilder.Add(LAlternativeGreen.__Missing);
                var lAlternativeListContext = context._tokenBlock2Antlr1;
                for (int i = 0; i < lAlternativeListContext.Count; ++i)
                {
                    var itemContext = lAlternativeListContext[i];
                    if (itemContext is not null)
                    {
                        var item = itemContext.alternativesAntlr1;
                        var separator = itemContext.tBar;
                        lAlternativeListBuilder.AddSeparator(this.VisitTerminal(separator, CompilerSyntaxKind.TBar));
                        if (item is not null) lAlternativeListBuilder.Add((LAlternativeGreen?)this.Visit(item) ?? LAlternativeGreen.__Missing);
                        else lAlternativeListBuilder.Add(LAlternativeGreen.__Missing);
                    }
                }
                var lAlternativeList = lAlternativeListBuilder.ToList();
                _pool.Free(lAlternativeListBuilder);
                var tSemicolon = this.VisitTerminal(context.tSemicolon, CompilerSyntaxKind.TSemicolon);
            	return _factory.Token(annotations1, tokenBlock1, (InternalSyntaxToken)tColon, lAlternativeList, (InternalSyntaxToken)tSemicolon);
            }
            public override GreenNode? VisitPr_Fragment(CompilerParser.Pr_FragmentContext? context)
            {
               	if (context == null) return FragmentGreen.__Missing;
                var kFragment = this.VisitTerminal(context.kFragment, CompilerSyntaxKind.KFragment);
                NameGreen? name = null;
                if (context.nameAntlr1 is not null) name = (NameGreen?)this.Visit(context.nameAntlr1) ?? NameGreen.__Missing;
                else name = NameGreen.__Missing;
                var tColon = this.VisitTerminal(context.tColon, CompilerSyntaxKind.TColon);
                var lAlternativeListBuilder = _pool.AllocateSeparated<LAlternativeGreen>(reversed: false);
                var alternativesContext = context.alternativesAntlr1;
                if (alternativesContext is not null) lAlternativeListBuilder.Add((LAlternativeGreen?)this.Visit(alternativesContext) ?? LAlternativeGreen.__Missing);
                else lAlternativeListBuilder.Add(LAlternativeGreen.__Missing);
                var lAlternativeListContext = context._fragmentBlock1Antlr1;
                for (int i = 0; i < lAlternativeListContext.Count; ++i)
                {
                    var itemContext = lAlternativeListContext[i];
                    if (itemContext is not null)
                    {
                        var item = itemContext.alternativesAntlr1;
                        var separator = itemContext.tBar;
                        lAlternativeListBuilder.AddSeparator(this.VisitTerminal(separator, CompilerSyntaxKind.TBar));
                        if (item is not null) lAlternativeListBuilder.Add((LAlternativeGreen?)this.Visit(item) ?? LAlternativeGreen.__Missing);
                        else lAlternativeListBuilder.Add(LAlternativeGreen.__Missing);
                    }
                }
                var lAlternativeList = lAlternativeListBuilder.ToList();
                _pool.Free(lAlternativeListBuilder);
                var tSemicolon = this.VisitTerminal(context.tSemicolon, CompilerSyntaxKind.TSemicolon);
            	return _factory.Fragment((InternalSyntaxToken)kFragment, name, (InternalSyntaxToken)tColon, lAlternativeList, (InternalSyntaxToken)tSemicolon);
            }
            public override GreenNode? VisitPr_Rule(CompilerParser.Pr_RuleContext? context)
            {
               	if (context == null) return RuleGreen.__Missing;
                var annotations1Context = context._annotations1Antlr1;
                var annotations1Builder = _pool.Allocate<ParserAnnotationGreen>();
                for (int i = 0; i < annotations1Context.Count; ++i)
                {
                    if (annotations1Context[i] is not null) annotations1Builder.Add((ParserAnnotationGreen?)this.Visit(annotations1Context[i]) ?? ParserAnnotationGreen.__Missing);
                    else annotations1Builder.Add(ParserAnnotationGreen.__Missing);
                }
                var annotations1 = annotations1Builder.ToList();
                _pool.Free(annotations1Builder);
                RuleBlock1Green? ruleBlock1 = null;
                if (context.ruleBlock1Antlr1 is not null) ruleBlock1 = (RuleBlock1Green?)this.Visit(context.ruleBlock1Antlr1) ?? RuleBlock1Green.__Missing;
                else ruleBlock1 = RuleBlock1Green.__Missing;
                var tColon = this.VisitTerminal(context.tColon, CompilerSyntaxKind.TColon);
                var alternativeListBuilder = _pool.AllocateSeparated<AlternativeGreen>(reversed: false);
                var alternativesContext = context.alternativesAntlr1;
                if (alternativesContext is not null) alternativeListBuilder.Add((AlternativeGreen?)this.Visit(alternativesContext) ?? AlternativeGreen.__Missing);
                else alternativeListBuilder.Add(AlternativeGreen.__Missing);
                var alternativeListContext = context._ruleBlock2Antlr1;
                for (int i = 0; i < alternativeListContext.Count; ++i)
                {
                    var itemContext = alternativeListContext[i];
                    if (itemContext is not null)
                    {
                        var item = itemContext.alternativesAntlr1;
                        var separator = itemContext.tBar;
                        alternativeListBuilder.AddSeparator(this.VisitTerminal(separator, CompilerSyntaxKind.TBar));
                        if (item is not null) alternativeListBuilder.Add((AlternativeGreen?)this.Visit(item) ?? AlternativeGreen.__Missing);
                        else alternativeListBuilder.Add(AlternativeGreen.__Missing);
                    }
                }
                var alternativeList = alternativeListBuilder.ToList();
                _pool.Free(alternativeListBuilder);
                var tSemicolon = this.VisitTerminal(context.tSemicolon, CompilerSyntaxKind.TSemicolon);
            	return _factory.Rule(annotations1, ruleBlock1, (InternalSyntaxToken)tColon, alternativeList, (InternalSyntaxToken)tSemicolon);
            }
            public override GreenNode? VisitPr_Alternative(CompilerParser.Pr_AlternativeContext? context)
            {
               	if (context == null) return AlternativeGreen.__Missing;
                AlternativeBlock1Green? alternativeBlock1 = null;
                if (context.alternativeBlock1Antlr1 is not null) alternativeBlock1 = (AlternativeBlock1Green?)this.Visit(context.alternativeBlock1Antlr1);
                var elementsContext = context._elementsAntlr1;
                var elementsBuilder = _pool.Allocate<ElementGreen>();
                for (int i = 0; i < elementsContext.Count; ++i)
                {
                    if (elementsContext[i] is not null) elementsBuilder.Add((ElementGreen?)this.Visit(elementsContext[i]) ?? ElementGreen.__Missing);
                    else elementsBuilder.Add(ElementGreen.__Missing);
                }
                var elements = elementsBuilder.ToList();
                _pool.Free(elementsBuilder);
                AlternativeBlock2Green? alternativeBlock2 = null;
                if (context.alternativeBlock2Antlr1 is not null) alternativeBlock2 = (AlternativeBlock2Green?)this.Visit(context.alternativeBlock2Antlr1);
            	return _factory.Alternative(alternativeBlock1, elements, alternativeBlock2);
            }
            public override GreenNode? VisitPr_Element(CompilerParser.Pr_ElementContext? context)
            {
               	if (context == null) return ElementGreen.__Missing;
                ElementBlock1Green? elementBlock1 = null;
                if (context.elementBlock1Antlr1 is not null) elementBlock1 = (ElementBlock1Green?)this.Visit(context.elementBlock1Antlr1);
                var valueAnnotationsContext = context._valueAnnotationsAntlr1;
                var valueAnnotationsBuilder = _pool.Allocate<ParserAnnotationGreen>();
                for (int i = 0; i < valueAnnotationsContext.Count; ++i)
                {
                    if (valueAnnotationsContext[i] is not null) valueAnnotationsBuilder.Add((ParserAnnotationGreen?)this.Visit(valueAnnotationsContext[i]) ?? ParserAnnotationGreen.__Missing);
                    else valueAnnotationsBuilder.Add(ParserAnnotationGreen.__Missing);
                }
                var valueAnnotations = valueAnnotationsBuilder.ToList();
                _pool.Free(valueAnnotationsBuilder);
                ElementValueGreen? value = null;
                if (context.valueAntlr1 is not null) value = (ElementValueGreen?)this.Visit(context.valueAntlr1) ?? ElementValueGreen.__Missing;
                else value = ElementValueGreen.__Missing;
                InternalSyntaxToken? multiplicity = null;
                if (context.tQuestion is not null) multiplicity = (InternalSyntaxToken)this.VisitTerminal(context.tQuestion);
                if (context.tAsterisk is not null) multiplicity = (InternalSyntaxToken)this.VisitTerminal(context.tAsterisk);
                if (context.tPlus is not null) multiplicity = (InternalSyntaxToken)this.VisitTerminal(context.tPlus);
                if (context.tQuestionQuestion is not null) multiplicity = (InternalSyntaxToken)this.VisitTerminal(context.tQuestionQuestion);
                if (context.tAsteriskQuestion is not null) multiplicity = (InternalSyntaxToken)this.VisitTerminal(context.tAsteriskQuestion);
                if (context.tPlusQuestion is not null) multiplicity = (InternalSyntaxToken)this.VisitTerminal(context.tPlusQuestion);
            	return _factory.Element(elementBlock1, valueAnnotations, value, (InternalSyntaxToken)multiplicity);
            }
            public override GreenNode? VisitPr_BlockInline(CompilerParser.Pr_BlockInlineContext? context)
            {
               	if (context == null) return BlockInlineGreen.__Missing;
                var tLParen = this.VisitTerminal(context.tLParen, CompilerSyntaxKind.TLParen);
                var alternativeListBuilder = _pool.AllocateSeparated<AlternativeGreen>(reversed: false);
                var alternativesContext = context.alternativesAntlr1;
                if (alternativesContext is not null) alternativeListBuilder.Add((AlternativeGreen?)this.Visit(alternativesContext) ?? AlternativeGreen.__Missing);
                else alternativeListBuilder.Add(AlternativeGreen.__Missing);
                var alternativeListContext = context._blockInlineBlock1Antlr1;
                for (int i = 0; i < alternativeListContext.Count; ++i)
                {
                    var itemContext = alternativeListContext[i];
                    if (itemContext is not null)
                    {
                        var item = itemContext.alternativesAntlr1;
                        var separator = itemContext.tBar;
                        alternativeListBuilder.AddSeparator(this.VisitTerminal(separator, CompilerSyntaxKind.TBar));
                        if (item is not null) alternativeListBuilder.Add((AlternativeGreen?)this.Visit(item) ?? AlternativeGreen.__Missing);
                        else alternativeListBuilder.Add(AlternativeGreen.__Missing);
                    }
                }
                var alternativeList = alternativeListBuilder.ToList();
                _pool.Free(alternativeListBuilder);
                var tRParen = this.VisitTerminal(context.tRParen, CompilerSyntaxKind.TRParen);
            	return _factory.BlockInline((InternalSyntaxToken)tLParen, alternativeList, (InternalSyntaxToken)tRParen);
            }
            public override GreenNode? VisitPr_Eof1(CompilerParser.Pr_Eof1Context? context)
            {
               	if (context == null) return Eof1Green.__Missing;
                var kEof = this.VisitTerminal(context.kEof, CompilerSyntaxKind.KEof);
            	return _factory.Eof1((InternalSyntaxToken)kEof);
            }
            public override GreenNode? VisitPr_Keyword(CompilerParser.Pr_KeywordContext? context)
            {
               	if (context == null) return KeywordGreen.__Missing;
                var text = this.VisitTerminal(context.textAntlr1, CompilerSyntaxKind.TString);
            	return _factory.Keyword((InternalSyntaxToken)text);
            }
            public override GreenNode? VisitPr_RuleRefAlt1(CompilerParser.Pr_RuleRefAlt1Context? context)
            {
               	if (context == null) return RuleRefAlt1Green.__Missing;
                IdentifierGreen? grammarRule = null;
                if (context.grammarRuleAntlr1 is not null) grammarRule = (IdentifierGreen?)this.Visit(context.grammarRuleAntlr1) ?? IdentifierGreen.__Missing;
                else grammarRule = IdentifierGreen.__Missing;
            	return _factory.RuleRefAlt1(grammarRule);
            }
            public override GreenNode? VisitPr_RuleRefAlt2(CompilerParser.Pr_RuleRefAlt2Context? context)
            {
               	if (context == null) return RuleRefAlt2Green.__Missing;
                var tHash = this.VisitTerminal(context.tHash, CompilerSyntaxKind.THash);
                ReturnTypeQualifierGreen? referencedTypes = null;
                if (context.referencedTypesAntlr1 is not null) referencedTypes = (ReturnTypeQualifierGreen?)this.Visit(context.referencedTypesAntlr1) ?? ReturnTypeQualifierGreen.__Missing;
                else referencedTypes = ReturnTypeQualifierGreen.__Missing;
            	return _factory.RuleRefAlt2((InternalSyntaxToken)tHash, referencedTypes);
            }
            public override GreenNode? VisitPr_RuleRefAlt3(CompilerParser.Pr_RuleRefAlt3Context? context)
            {
               	if (context == null) return RuleRefAlt3Green.__Missing;
                var tHashLBrace = this.VisitTerminal(context.tHashLBrace, CompilerSyntaxKind.THashLBrace);
                var returnTypeQualifierListBuilder = _pool.AllocateSeparated<ReturnTypeQualifierGreen>(reversed: false);
                var referencedTypesContext = context.referencedTypesAntlr1;
                if (referencedTypesContext is not null) returnTypeQualifierListBuilder.Add((ReturnTypeQualifierGreen?)this.Visit(referencedTypesContext) ?? ReturnTypeQualifierGreen.__Missing);
                else returnTypeQualifierListBuilder.Add(ReturnTypeQualifierGreen.__Missing);
                var returnTypeQualifierListContext = context._ruleRefAlt3Block1Antlr1;
                for (int i = 0; i < returnTypeQualifierListContext.Count; ++i)
                {
                    var itemContext = returnTypeQualifierListContext[i];
                    if (itemContext is not null)
                    {
                        var item = itemContext.referencedTypesAntlr1;
                        var separator = itemContext.tComma;
                        returnTypeQualifierListBuilder.AddSeparator(this.VisitTerminal(separator, CompilerSyntaxKind.TComma));
                        if (item is not null) returnTypeQualifierListBuilder.Add((ReturnTypeQualifierGreen?)this.Visit(item) ?? ReturnTypeQualifierGreen.__Missing);
                        else returnTypeQualifierListBuilder.Add(ReturnTypeQualifierGreen.__Missing);
                    }
                }
                var returnTypeQualifierList = returnTypeQualifierListBuilder.ToList();
                _pool.Free(returnTypeQualifierListBuilder);
                var tRBrace = this.VisitTerminal(context.tRBrace, CompilerSyntaxKind.TRBrace);
            	return _factory.RuleRefAlt3((InternalSyntaxToken)tHashLBrace, returnTypeQualifierList, (InternalSyntaxToken)tRBrace);
            }
            public override GreenNode? VisitPr_LAlternative(CompilerParser.Pr_LAlternativeContext? context)
            {
               	if (context == null) return LAlternativeGreen.__Missing;
                var elementsContext = context._elementsAntlr1;
                var elementsBuilder = _pool.Allocate<LElementGreen>();
                for (int i = 0; i < elementsContext.Count; ++i)
                {
                    if (elementsContext[i] is not null) elementsBuilder.Add((LElementGreen?)this.Visit(elementsContext[i]) ?? LElementGreen.__Missing);
                    else elementsBuilder.Add(LElementGreen.__Missing);
                }
                var elements = elementsBuilder.ToList();
                _pool.Free(elementsBuilder);
            	return _factory.LAlternative(elements);
            }
            public override GreenNode? VisitPr_LElement(CompilerParser.Pr_LElementContext? context)
            {
               	if (context == null) return LElementGreen.__Missing;
                var isNegated = this.VisitTerminal(context.isNegated);
                LElementValueGreen? value = null;
                if (context.valueAntlr1 is not null) value = (LElementValueGreen?)this.Visit(context.valueAntlr1) ?? LElementValueGreen.__Missing;
                else value = LElementValueGreen.__Missing;
                InternalSyntaxToken? multiplicity = null;
                if (context.tQuestion is not null) multiplicity = (InternalSyntaxToken)this.VisitTerminal(context.tQuestion);
                if (context.tAsterisk is not null) multiplicity = (InternalSyntaxToken)this.VisitTerminal(context.tAsterisk);
                if (context.tPlus is not null) multiplicity = (InternalSyntaxToken)this.VisitTerminal(context.tPlus);
                if (context.tQuestionQuestion is not null) multiplicity = (InternalSyntaxToken)this.VisitTerminal(context.tQuestionQuestion);
                if (context.tAsteriskQuestion is not null) multiplicity = (InternalSyntaxToken)this.VisitTerminal(context.tAsteriskQuestion);
                if (context.tPlusQuestion is not null) multiplicity = (InternalSyntaxToken)this.VisitTerminal(context.tPlusQuestion);
            	return _factory.LElement((InternalSyntaxToken)isNegated, value, (InternalSyntaxToken)multiplicity);
            }
            public override GreenNode? VisitPr_LBlock(CompilerParser.Pr_LBlockContext? context)
            {
               	if (context == null) return LBlockGreen.__Missing;
                var tLParen = this.VisitTerminal(context.tLParen, CompilerSyntaxKind.TLParen);
                var lAlternativeListBuilder = _pool.AllocateSeparated<LAlternativeGreen>(reversed: false);
                var alternativesContext = context.alternativesAntlr1;
                if (alternativesContext is not null) lAlternativeListBuilder.Add((LAlternativeGreen?)this.Visit(alternativesContext) ?? LAlternativeGreen.__Missing);
                else lAlternativeListBuilder.Add(LAlternativeGreen.__Missing);
                var lAlternativeListContext = context._lBlockBlock1Antlr1;
                for (int i = 0; i < lAlternativeListContext.Count; ++i)
                {
                    var itemContext = lAlternativeListContext[i];
                    if (itemContext is not null)
                    {
                        var item = itemContext.alternativesAntlr1;
                        var separator = itemContext.tBar;
                        lAlternativeListBuilder.AddSeparator(this.VisitTerminal(separator, CompilerSyntaxKind.TBar));
                        if (item is not null) lAlternativeListBuilder.Add((LAlternativeGreen?)this.Visit(item) ?? LAlternativeGreen.__Missing);
                        else lAlternativeListBuilder.Add(LAlternativeGreen.__Missing);
                    }
                }
                var lAlternativeList = lAlternativeListBuilder.ToList();
                _pool.Free(lAlternativeListBuilder);
                var tRParen = this.VisitTerminal(context.tRParen, CompilerSyntaxKind.TRParen);
            	return _factory.LBlock((InternalSyntaxToken)tLParen, lAlternativeList, (InternalSyntaxToken)tRParen);
            }
            public override GreenNode? VisitPr_LFixed(CompilerParser.Pr_LFixedContext? context)
            {
               	if (context == null) return LFixedGreen.__Missing;
                var text = this.VisitTerminal(context.textAntlr1, CompilerSyntaxKind.TString);
            	return _factory.LFixed((InternalSyntaxToken)text);
            }
            public override GreenNode? VisitPr_LWildCard(CompilerParser.Pr_LWildCardContext? context)
            {
               	if (context == null) return LWildCardGreen.__Missing;
                var tDot = this.VisitTerminal(context.tDot, CompilerSyntaxKind.TDot);
            	return _factory.LWildCard((InternalSyntaxToken)tDot);
            }
            public override GreenNode? VisitPr_LRange(CompilerParser.Pr_LRangeContext? context)
            {
               	if (context == null) return LRangeGreen.__Missing;
                var startChar = this.VisitTerminal(context.StartCharAntlr1, CompilerSyntaxKind.TString);
                var tDotDot = this.VisitTerminal(context.tDotDot, CompilerSyntaxKind.TDotDot);
                var endChar = this.VisitTerminal(context.EndCharAntlr1, CompilerSyntaxKind.TString);
            	return _factory.LRange((InternalSyntaxToken)startChar, (InternalSyntaxToken)tDotDot, (InternalSyntaxToken)endChar);
            }
            public override GreenNode? VisitPr_LReference(CompilerParser.Pr_LReferenceContext? context)
            {
               	if (context == null) return LReferenceGreen.__Missing;
                IdentifierGreen? rule = null;
                if (context.ruleAntlr1 is not null) rule = (IdentifierGreen?)this.Visit(context.ruleAntlr1) ?? IdentifierGreen.__Missing;
                else rule = IdentifierGreen.__Missing;
            	return _factory.LReference(rule);
            }
            public override GreenNode? VisitPr_ExpressionAlt1(CompilerParser.Pr_ExpressionAlt1Context? context)
            {
               	if (context == null) return ExpressionAlt1Green.__Missing;
                SingleExpressionGreen? singleExpression = null;
                if (context.singleExpressionAntlr1 is not null) singleExpression = (SingleExpressionGreen?)this.Visit(context.singleExpressionAntlr1) ?? SingleExpressionGreen.__Missing;
                else singleExpression = SingleExpressionGreen.__Missing;
            	return _factory.ExpressionAlt1(singleExpression);
            }
            public override GreenNode? VisitPr_ArrayExpression(CompilerParser.Pr_ArrayExpressionContext? context)
            {
               	if (context == null) return ArrayExpressionGreen.__Missing;
                var tLBrace = this.VisitTerminal(context.tLBrace, CompilerSyntaxKind.TLBrace);
                ArrayExpressionBlock1Green? arrayExpressionBlock1 = null;
                if (context.arrayExpressionBlock1Antlr1 is not null) arrayExpressionBlock1 = (ArrayExpressionBlock1Green?)this.Visit(context.arrayExpressionBlock1Antlr1);
                var tRBrace = this.VisitTerminal(context.tRBrace, CompilerSyntaxKind.TRBrace);
            	return _factory.ArrayExpression((InternalSyntaxToken)tLBrace, arrayExpressionBlock1, (InternalSyntaxToken)tRBrace);
            }
            public override GreenNode? VisitPr_SingleExpression(CompilerParser.Pr_SingleExpressionContext? context)
            {
               	if (context == null) return SingleExpressionGreen.__Missing;
                SingleExpressionBlock1Green? value = null;
                if (context.valueAntlr1 is not null) value = (SingleExpressionBlock1Green?)this.Visit(context.valueAntlr1) ?? SingleExpressionBlock1Green.__Missing;
                else value = SingleExpressionBlock1Green.__Missing;
            	return _factory.SingleExpression(value);
            }
            public override GreenNode? VisitPr_ParserAnnotation(CompilerParser.Pr_ParserAnnotationContext? context)
            {
               	if (context == null) return ParserAnnotationGreen.__Missing;
                var tLBracket = this.VisitTerminal(context.tLBracket, CompilerSyntaxKind.TLBracket);
                QualifierGreen? attributeClass = null;
                if (context.attributeClassAntlr1 is not null) attributeClass = (QualifierGreen?)this.Visit(context.attributeClassAntlr1) ?? QualifierGreen.__Missing;
                else attributeClass = QualifierGreen.__Missing;
                AnnotationArgumentsGreen? annotationArguments = null;
                if (context.annotationArgumentsAntlr1 is not null) annotationArguments = (AnnotationArgumentsGreen?)this.Visit(context.annotationArgumentsAntlr1);
                var tRBracket = this.VisitTerminal(context.tRBracket, CompilerSyntaxKind.TRBracket);
            	return _factory.ParserAnnotation((InternalSyntaxToken)tLBracket, attributeClass, annotationArguments, (InternalSyntaxToken)tRBracket);
            }
            public override GreenNode? VisitPr_LexerAnnotation(CompilerParser.Pr_LexerAnnotationContext? context)
            {
               	if (context == null) return LexerAnnotationGreen.__Missing;
                var tLBracket = this.VisitTerminal(context.tLBracket, CompilerSyntaxKind.TLBracket);
                QualifierGreen? attributeClass = null;
                if (context.attributeClassAntlr1 is not null) attributeClass = (QualifierGreen?)this.Visit(context.attributeClassAntlr1) ?? QualifierGreen.__Missing;
                else attributeClass = QualifierGreen.__Missing;
                AnnotationArgumentsGreen? annotationArguments = null;
                if (context.annotationArgumentsAntlr1 is not null) annotationArguments = (AnnotationArgumentsGreen?)this.Visit(context.annotationArgumentsAntlr1);
                var tRBracket = this.VisitTerminal(context.tRBracket, CompilerSyntaxKind.TRBracket);
            	return _factory.LexerAnnotation((InternalSyntaxToken)tLBracket, attributeClass, annotationArguments, (InternalSyntaxToken)tRBracket);
            }
            public override GreenNode? VisitPr_AnnotationArguments(CompilerParser.Pr_AnnotationArgumentsContext? context)
            {
               	if (context == null) return AnnotationArgumentsGreen.__Missing;
                var tLParen = this.VisitTerminal(context.tLParen, CompilerSyntaxKind.TLParen);
                var annotationArgumentListBuilder = _pool.AllocateSeparated<AnnotationArgumentGreen>(reversed: false);
                var argumentsContext = context.argumentsAntlr1;
                if (argumentsContext is not null) annotationArgumentListBuilder.Add((AnnotationArgumentGreen?)this.Visit(argumentsContext) ?? AnnotationArgumentGreen.__Missing);
                else annotationArgumentListBuilder.Add(AnnotationArgumentGreen.__Missing);
                var annotationArgumentListContext = context._annotationArgumentsBlock1Antlr1;
                for (int i = 0; i < annotationArgumentListContext.Count; ++i)
                {
                    var itemContext = annotationArgumentListContext[i];
                    if (itemContext is not null)
                    {
                        var item = itemContext.argumentsAntlr1;
                        var separator = itemContext.tComma;
                        annotationArgumentListBuilder.AddSeparator(this.VisitTerminal(separator, CompilerSyntaxKind.TComma));
                        if (item is not null) annotationArgumentListBuilder.Add((AnnotationArgumentGreen?)this.Visit(item) ?? AnnotationArgumentGreen.__Missing);
                        else annotationArgumentListBuilder.Add(AnnotationArgumentGreen.__Missing);
                    }
                }
                var annotationArgumentList = annotationArgumentListBuilder.ToList();
                _pool.Free(annotationArgumentListBuilder);
                var tRParen = this.VisitTerminal(context.tRParen, CompilerSyntaxKind.TRParen);
            	return _factory.AnnotationArguments((InternalSyntaxToken)tLParen, annotationArgumentList, (InternalSyntaxToken)tRParen);
            }
            public override GreenNode? VisitPr_AnnotationArgument(CompilerParser.Pr_AnnotationArgumentContext? context)
            {
               	if (context == null) return AnnotationArgumentGreen.__Missing;
                AnnotationArgumentBlock1Green? annotationArgumentBlock1 = null;
                if (context.annotationArgumentBlock1Antlr1 is not null) annotationArgumentBlock1 = (AnnotationArgumentBlock1Green?)this.Visit(context.annotationArgumentBlock1Antlr1);
                ExpressionGreen? value = null;
                if (context.valueAntlr1 is not null) value = (ExpressionGreen?)this.Visit(context.valueAntlr1) ?? ExpressionGreen.__Missing;
                else value = ExpressionGreen.__Missing;
            	return _factory.AnnotationArgument(annotationArgumentBlock1, value);
            }
            public override GreenNode? VisitPr_ReturnTypeIdentifierAlt1(CompilerParser.Pr_ReturnTypeIdentifierAlt1Context? context)
            {
               	if (context == null) return ReturnTypeIdentifierAlt1Green.__Missing;
                var tPrimitiveType = this.VisitTerminal(context.tPrimitiveTypeAntlr1, CompilerSyntaxKind.TPrimitiveType);
            	return _factory.ReturnTypeIdentifierAlt1((InternalSyntaxToken)tPrimitiveType);
            }
            public override GreenNode? VisitPr_ReturnTypeIdentifierAlt2(CompilerParser.Pr_ReturnTypeIdentifierAlt2Context? context)
            {
               	if (context == null) return ReturnTypeIdentifierAlt2Green.__Missing;
                IdentifierGreen? identifier = null;
                if (context.identifierAntlr1 is not null) identifier = (IdentifierGreen?)this.Visit(context.identifierAntlr1) ?? IdentifierGreen.__Missing;
                else identifier = IdentifierGreen.__Missing;
            	return _factory.ReturnTypeIdentifierAlt2(identifier);
            }
            public override GreenNode? VisitPr_ReturnTypeQualifierAlt1(CompilerParser.Pr_ReturnTypeQualifierAlt1Context? context)
            {
               	if (context == null) return ReturnTypeQualifierAlt1Green.__Missing;
                var tPrimitiveType = this.VisitTerminal(context.tPrimitiveTypeAntlr1, CompilerSyntaxKind.TPrimitiveType);
            	return _factory.ReturnTypeQualifierAlt1((InternalSyntaxToken)tPrimitiveType);
            }
            public override GreenNode? VisitPr_ReturnTypeQualifierAlt2(CompilerParser.Pr_ReturnTypeQualifierAlt2Context? context)
            {
               	if (context == null) return ReturnTypeQualifierAlt2Green.__Missing;
                QualifierGreen? qualifier = null;
                if (context.qualifierAntlr1 is not null) qualifier = (QualifierGreen?)this.Visit(context.qualifierAntlr1) ?? QualifierGreen.__Missing;
                else qualifier = QualifierGreen.__Missing;
            	return _factory.ReturnTypeQualifierAlt2(qualifier);
            }
            public override GreenNode? VisitPr_Name(CompilerParser.Pr_NameContext? context)
            {
               	if (context == null) return NameGreen.__Missing;
                IdentifierGreen? identifier = null;
                if (context.identifierAntlr1 is not null) identifier = (IdentifierGreen?)this.Visit(context.identifierAntlr1) ?? IdentifierGreen.__Missing;
                else identifier = IdentifierGreen.__Missing;
            	return _factory.Name(identifier);
            }
            public override GreenNode? VisitPr_Qualifier(CompilerParser.Pr_QualifierContext? context)
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
                        identifierListBuilder.AddSeparator(this.VisitTerminal(separator, CompilerSyntaxKind.TDot));
                        if (item is not null) identifierListBuilder.Add((IdentifierGreen?)this.Visit(item) ?? IdentifierGreen.__Missing);
                        else identifierListBuilder.Add(IdentifierGreen.__Missing);
                    }
                }
                var identifierList = identifierListBuilder.ToList();
                _pool.Free(identifierListBuilder);
            	return _factory.Qualifier(identifierList);
            }
            public override GreenNode? VisitPr_QualifierList(CompilerParser.Pr_QualifierListContext? context)
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
                        qualifierListBuilder.AddSeparator(this.VisitTerminal(separator, CompilerSyntaxKind.TComma));
                        if (item is not null) qualifierListBuilder.Add((QualifierGreen?)this.Visit(item) ?? QualifierGreen.__Missing);
                        else qualifierListBuilder.Add(QualifierGreen.__Missing);
                    }
                }
                var qualifierList = qualifierListBuilder.ToList();
                _pool.Free(qualifierListBuilder);
            	return _factory.QualifierList(qualifierList);
            }
            public override GreenNode? VisitPr_IdentifierAlt1(CompilerParser.Pr_IdentifierAlt1Context? context)
            {
               	if (context == null) return IdentifierAlt1Green.__Missing;
                var tIdentifier = this.VisitTerminal(context.tIdentifierAntlr1, CompilerSyntaxKind.TIdentifier);
            	return _factory.IdentifierAlt1((InternalSyntaxToken)tIdentifier);
            }
            public override GreenNode? VisitPr_IdentifierAlt2(CompilerParser.Pr_IdentifierAlt2Context? context)
            {
               	if (context == null) return IdentifierAlt2Green.__Missing;
                var tVerbatimIdentifier = this.VisitTerminal(context.tVerbatimIdentifierAntlr1, CompilerSyntaxKind.TVerbatimIdentifier);
            	return _factory.IdentifierAlt2((InternalSyntaxToken)tVerbatimIdentifier);
            }
            public override GreenNode? VisitPr_SimpleQualifier(CompilerParser.Pr_SimpleQualifierContext? context)
            {
               	if (context == null) return SimpleQualifierGreen.__Missing;
                var simpleIdentifierListBuilder = _pool.AllocateSeparated<SimpleIdentifierGreen>(reversed: false);
                var simpleIdentifierContext = context.simpleIdentifierAntlr1;
                if (simpleIdentifierContext is not null) simpleIdentifierListBuilder.Add((SimpleIdentifierGreen?)this.Visit(simpleIdentifierContext) ?? SimpleIdentifierGreen.__Missing);
                else simpleIdentifierListBuilder.Add(SimpleIdentifierGreen.__Missing);
                var simpleIdentifierListContext = context._simpleQualifierBlock1Antlr1;
                for (int i = 0; i < simpleIdentifierListContext.Count; ++i)
                {
                    var itemContext = simpleIdentifierListContext[i];
                    if (itemContext is not null)
                    {
                        var item = itemContext.simpleIdentifierAntlr1;
                        var separator = itemContext.tDot;
                        simpleIdentifierListBuilder.AddSeparator(this.VisitTerminal(separator, CompilerSyntaxKind.TDot));
                        if (item is not null) simpleIdentifierListBuilder.Add((SimpleIdentifierGreen?)this.Visit(item) ?? SimpleIdentifierGreen.__Missing);
                        else simpleIdentifierListBuilder.Add(SimpleIdentifierGreen.__Missing);
                    }
                }
                var simpleIdentifierList = simpleIdentifierListBuilder.ToList();
                _pool.Free(simpleIdentifierListBuilder);
            	return _factory.SimpleQualifier(simpleIdentifierList);
            }
            public override GreenNode? VisitPr_SimpleIdentifier(CompilerParser.Pr_SimpleIdentifierContext? context)
            {
               	if (context == null) return SimpleIdentifierGreen.__Missing;
                var tIdentifier = this.VisitTerminal(context.tIdentifierAntlr1, CompilerSyntaxKind.TIdentifier);
            	return _factory.SimpleIdentifier((InternalSyntaxToken)tIdentifier);
            }
            public override GreenNode? VisitPr_GrammarBlock1(CompilerParser.Pr_GrammarBlock1Context? context)
            {
               	if (context == null) return GrammarBlock1Green.__Missing;
                var grammarRulesContext = context._grammarRulesAntlr1;
                var grammarRulesBuilder = _pool.Allocate<GrammarRuleGreen>();
                for (int i = 0; i < grammarRulesContext.Count; ++i)
                {
                    if (grammarRulesContext[i] is not null) grammarRulesBuilder.Add((GrammarRuleGreen?)this.Visit(grammarRulesContext[i]) ?? GrammarRuleGreen.__Missing);
                    else grammarRulesBuilder.Add(GrammarRuleGreen.__Missing);
                }
                var grammarRules = grammarRulesBuilder.ToList();
                _pool.Free(grammarRulesBuilder);
            	return _factory.GrammarBlock1(grammarRules);
            }
            public override GreenNode? VisitPr_RuleBlock1Alt1(CompilerParser.Pr_RuleBlock1Alt1Context? context)
            {
               	if (context == null) return RuleBlock1Alt1Green.__Missing;
                ReturnTypeIdentifierGreen? returnType = null;
                if (context.returnTypeAntlr1 is not null) returnType = (ReturnTypeIdentifierGreen?)this.Visit(context.returnTypeAntlr1) ?? ReturnTypeIdentifierGreen.__Missing;
                else returnType = ReturnTypeIdentifierGreen.__Missing;
            	return _factory.RuleBlock1Alt1(returnType);
            }
            public override GreenNode? VisitPr_RuleBlock1Alt2(CompilerParser.Pr_RuleBlock1Alt2Context? context)
            {
               	if (context == null) return RuleBlock1Alt2Green.__Missing;
                IdentifierGreen? identifier = null;
                if (context.identifierAntlr1 is not null) identifier = (IdentifierGreen?)this.Visit(context.identifierAntlr1) ?? IdentifierGreen.__Missing;
                else identifier = IdentifierGreen.__Missing;
                var kReturns = this.VisitTerminal(context.kReturns, CompilerSyntaxKind.KReturns);
                ReturnTypeQualifierGreen? returnType = null;
                if (context.returnTypeAntlr1 is not null) returnType = (ReturnTypeQualifierGreen?)this.Visit(context.returnTypeAntlr1) ?? ReturnTypeQualifierGreen.__Missing;
                else returnType = ReturnTypeQualifierGreen.__Missing;
            	return _factory.RuleBlock1Alt2(identifier, (InternalSyntaxToken)kReturns, returnType);
            }
            public override GreenNode? VisitPr_RuleBlock2(CompilerParser.Pr_RuleBlock2Context? context)
            {
               	if (context == null) return RuleBlock2Green.__Missing;
                var tBar = this.VisitTerminal(context.tBar, CompilerSyntaxKind.TBar);
                AlternativeGreen? alternatives = null;
                if (context.alternativesAntlr1 is not null) alternatives = (AlternativeGreen?)this.Visit(context.alternativesAntlr1) ?? AlternativeGreen.__Missing;
                else alternatives = AlternativeGreen.__Missing;
            	return _factory.RuleBlock2((InternalSyntaxToken)tBar, alternatives);
            }
            public override GreenNode? VisitPr_BlockBlock1(CompilerParser.Pr_BlockBlock1Context? context)
            {
               	if (context == null) return BlockBlock1Green.__Missing;
                var kReturns = this.VisitTerminal(context.kReturns, CompilerSyntaxKind.KReturns);
                ReturnTypeQualifierGreen? returnType = null;
                if (context.returnTypeAntlr1 is not null) returnType = (ReturnTypeQualifierGreen?)this.Visit(context.returnTypeAntlr1) ?? ReturnTypeQualifierGreen.__Missing;
                else returnType = ReturnTypeQualifierGreen.__Missing;
            	return _factory.BlockBlock1((InternalSyntaxToken)kReturns, returnType);
            }
            public override GreenNode? VisitPr_BlockBlock2(CompilerParser.Pr_BlockBlock2Context? context)
            {
               	if (context == null) return BlockBlock2Green.__Missing;
                var tBar = this.VisitTerminal(context.tBar, CompilerSyntaxKind.TBar);
                AlternativeGreen? alternatives = null;
                if (context.alternativesAntlr1 is not null) alternatives = (AlternativeGreen?)this.Visit(context.alternativesAntlr1) ?? AlternativeGreen.__Missing;
                else alternatives = AlternativeGreen.__Missing;
            	return _factory.BlockBlock2((InternalSyntaxToken)tBar, alternatives);
            }
            public override GreenNode? VisitPr_BlockInlineBlock1(CompilerParser.Pr_BlockInlineBlock1Context? context)
            {
               	if (context == null) return BlockInlineBlock1Green.__Missing;
                var tBar = this.VisitTerminal(context.tBar, CompilerSyntaxKind.TBar);
                AlternativeGreen? alternatives = null;
                if (context.alternativesAntlr1 is not null) alternatives = (AlternativeGreen?)this.Visit(context.alternativesAntlr1) ?? AlternativeGreen.__Missing;
                else alternatives = AlternativeGreen.__Missing;
            	return _factory.BlockInlineBlock1((InternalSyntaxToken)tBar, alternatives);
            }
            public override GreenNode? VisitPr_AlternativeBlock1(CompilerParser.Pr_AlternativeBlock1Context? context)
            {
               	if (context == null) return AlternativeBlock1Green.__Missing;
                var annotations1Context = context._annotations1Antlr1;
                var annotations1Builder = _pool.Allocate<ParserAnnotationGreen>();
                for (int i = 0; i < annotations1Context.Count; ++i)
                {
                    if (annotations1Context[i] is not null) annotations1Builder.Add((ParserAnnotationGreen?)this.Visit(annotations1Context[i]) ?? ParserAnnotationGreen.__Missing);
                    else annotations1Builder.Add(ParserAnnotationGreen.__Missing);
                }
                var annotations1 = annotations1Builder.ToList();
                _pool.Free(annotations1Builder);
                var kAlt = this.VisitTerminal(context.kAlt, CompilerSyntaxKind.KAlt);
                NameGreen? name = null;
                if (context.nameAntlr1 is not null) name = (NameGreen?)this.Visit(context.nameAntlr1) ?? NameGreen.__Missing;
                else name = NameGreen.__Missing;
                AlternativeBlock1Block1Green? alternativeBlock1Block1 = null;
                if (context.alternativeBlock1Block1Antlr1 is not null) alternativeBlock1Block1 = (AlternativeBlock1Block1Green?)this.Visit(context.alternativeBlock1Block1Antlr1);
                var tColon = this.VisitTerminal(context.tColon, CompilerSyntaxKind.TColon);
            	return _factory.AlternativeBlock1(annotations1, (InternalSyntaxToken)kAlt, name, alternativeBlock1Block1, (InternalSyntaxToken)tColon);
            }
            public override GreenNode? VisitPr_AlternativeBlock2(CompilerParser.Pr_AlternativeBlock2Context? context)
            {
               	if (context == null) return AlternativeBlock2Green.__Missing;
                var tEqGt = this.VisitTerminal(context.tEqGt, CompilerSyntaxKind.TEqGt);
                ExpressionGreen? returnValue = null;
                if (context.returnValueAntlr1 is not null) returnValue = (ExpressionGreen?)this.Visit(context.returnValueAntlr1) ?? ExpressionGreen.__Missing;
                else returnValue = ExpressionGreen.__Missing;
            	return _factory.AlternativeBlock2((InternalSyntaxToken)tEqGt, returnValue);
            }
            public override GreenNode? VisitPr_ElementBlock1(CompilerParser.Pr_ElementBlock1Context? context)
            {
               	if (context == null) return ElementBlock1Green.__Missing;
                var nameAnnotationsContext = context._nameAnnotationsAntlr1;
                var nameAnnotationsBuilder = _pool.Allocate<ParserAnnotationGreen>();
                for (int i = 0; i < nameAnnotationsContext.Count; ++i)
                {
                    if (nameAnnotationsContext[i] is not null) nameAnnotationsBuilder.Add((ParserAnnotationGreen?)this.Visit(nameAnnotationsContext[i]) ?? ParserAnnotationGreen.__Missing);
                    else nameAnnotationsBuilder.Add(ParserAnnotationGreen.__Missing);
                }
                var nameAnnotations = nameAnnotationsBuilder.ToList();
                _pool.Free(nameAnnotationsBuilder);
                IdentifierGreen? symbolProperty = null;
                if (context.symbolPropertyAntlr1 is not null) symbolProperty = (IdentifierGreen?)this.Visit(context.symbolPropertyAntlr1) ?? IdentifierGreen.__Missing;
                else symbolProperty = IdentifierGreen.__Missing;
                InternalSyntaxToken? assignment = null;
                if (context.tEq is not null) assignment = (InternalSyntaxToken)this.VisitTerminal(context.tEq);
                if (context.tQuestionEq is not null) assignment = (InternalSyntaxToken)this.VisitTerminal(context.tQuestionEq);
                if (context.tExclEq is not null) assignment = (InternalSyntaxToken)this.VisitTerminal(context.tExclEq);
                if (context.tPlusEq is not null) assignment = (InternalSyntaxToken)this.VisitTerminal(context.tPlusEq);
            	return _factory.ElementBlock1(nameAnnotations, symbolProperty, (InternalSyntaxToken)assignment);
            }
            public override GreenNode? VisitPr_RuleRefAlt3Block1(CompilerParser.Pr_RuleRefAlt3Block1Context? context)
            {
               	if (context == null) return RuleRefAlt3Block1Green.__Missing;
                var tComma = this.VisitTerminal(context.tComma, CompilerSyntaxKind.TComma);
                ReturnTypeQualifierGreen? referencedTypes = null;
                if (context.referencedTypesAntlr1 is not null) referencedTypes = (ReturnTypeQualifierGreen?)this.Visit(context.referencedTypesAntlr1) ?? ReturnTypeQualifierGreen.__Missing;
                else referencedTypes = ReturnTypeQualifierGreen.__Missing;
            	return _factory.RuleRefAlt3Block1((InternalSyntaxToken)tComma, referencedTypes);
            }
            public override GreenNode? VisitPr_TokenBlock1Alt1(CompilerParser.Pr_TokenBlock1Alt1Context? context)
            {
               	if (context == null) return TokenBlock1Alt1Green.__Missing;
                var kToken = this.VisitTerminal(context.kToken, CompilerSyntaxKind.KToken);
                NameGreen? name = null;
                if (context.nameAntlr1 is not null) name = (NameGreen?)this.Visit(context.nameAntlr1) ?? NameGreen.__Missing;
                else name = NameGreen.__Missing;
                TokenBlock1Alt1Block1Green? tokenBlock1Alt1Block1 = null;
                if (context.tokenBlock1Alt1Block1Antlr1 is not null) tokenBlock1Alt1Block1 = (TokenBlock1Alt1Block1Green?)this.Visit(context.tokenBlock1Alt1Block1Antlr1);
            	return _factory.TokenBlock1Alt1((InternalSyntaxToken)kToken, name, tokenBlock1Alt1Block1);
            }
            public override GreenNode? VisitPr_TokenBlock1Alt2(CompilerParser.Pr_TokenBlock1Alt2Context? context)
            {
               	if (context == null) return TokenBlock1Alt2Green.__Missing;
                var isTrivia1 = this.VisitTerminal(context.isTrivia1, CompilerSyntaxKind.KHidden);
                NameGreen? name = null;
                if (context.nameAntlr1 is not null) name = (NameGreen?)this.Visit(context.nameAntlr1) ?? NameGreen.__Missing;
                else name = NameGreen.__Missing;
            	return _factory.TokenBlock1Alt2((InternalSyntaxToken)isTrivia1, name);
            }
            public override GreenNode? VisitPr_TokenBlock2(CompilerParser.Pr_TokenBlock2Context? context)
            {
               	if (context == null) return TokenBlock2Green.__Missing;
                var tBar = this.VisitTerminal(context.tBar, CompilerSyntaxKind.TBar);
                LAlternativeGreen? alternatives = null;
                if (context.alternativesAntlr1 is not null) alternatives = (LAlternativeGreen?)this.Visit(context.alternativesAntlr1) ?? LAlternativeGreen.__Missing;
                else alternatives = LAlternativeGreen.__Missing;
            	return _factory.TokenBlock2((InternalSyntaxToken)tBar, alternatives);
            }
            public override GreenNode? VisitPr_FragmentBlock1(CompilerParser.Pr_FragmentBlock1Context? context)
            {
               	if (context == null) return FragmentBlock1Green.__Missing;
                var tBar = this.VisitTerminal(context.tBar, CompilerSyntaxKind.TBar);
                LAlternativeGreen? alternatives = null;
                if (context.alternativesAntlr1 is not null) alternatives = (LAlternativeGreen?)this.Visit(context.alternativesAntlr1) ?? LAlternativeGreen.__Missing;
                else alternatives = LAlternativeGreen.__Missing;
            	return _factory.FragmentBlock1((InternalSyntaxToken)tBar, alternatives);
            }
            public override GreenNode? VisitPr_LBlockBlock1(CompilerParser.Pr_LBlockBlock1Context? context)
            {
               	if (context == null) return LBlockBlock1Green.__Missing;
                var tBar = this.VisitTerminal(context.tBar, CompilerSyntaxKind.TBar);
                LAlternativeGreen? alternatives = null;
                if (context.alternativesAntlr1 is not null) alternatives = (LAlternativeGreen?)this.Visit(context.alternativesAntlr1) ?? LAlternativeGreen.__Missing;
                else alternatives = LAlternativeGreen.__Missing;
            	return _factory.LBlockBlock1((InternalSyntaxToken)tBar, alternatives);
            }
            public override GreenNode? VisitPr_SingleExpressionBlock1Alt4(CompilerParser.Pr_SingleExpressionBlock1Alt4Context? context)
            {
               	if (context == null) return SingleExpressionBlock1Alt4Green.__Missing;
                var tInteger = this.VisitTerminal(context.tIntegerAntlr1, CompilerSyntaxKind.TInteger);
            	return _factory.SingleExpressionBlock1Alt4((InternalSyntaxToken)tInteger);
            }
            public override GreenNode? VisitPr_SingleExpressionBlock1Alt5(CompilerParser.Pr_SingleExpressionBlock1Alt5Context? context)
            {
               	if (context == null) return SingleExpressionBlock1Alt5Green.__Missing;
                var tString = this.VisitTerminal(context.tStringAntlr1, CompilerSyntaxKind.TString);
            	return _factory.SingleExpressionBlock1Alt5((InternalSyntaxToken)tString);
            }
            public override GreenNode? VisitPr_SingleExpressionBlock1Alt6(CompilerParser.Pr_SingleExpressionBlock1Alt6Context? context)
            {
               	if (context == null) return SingleExpressionBlock1Alt6Green.__Missing;
                SimpleQualifierGreen? simpleQualifier = null;
                if (context.simpleQualifierAntlr1 is not null) simpleQualifier = (SimpleQualifierGreen?)this.Visit(context.simpleQualifierAntlr1) ?? SimpleQualifierGreen.__Missing;
                else simpleQualifier = SimpleQualifierGreen.__Missing;
            	return _factory.SingleExpressionBlock1Alt6(simpleQualifier);
            }
            public override GreenNode? VisitPr_SingleExpressionBlock1Tokens(CompilerParser.Pr_SingleExpressionBlock1TokensContext? context)
            {
               	if (context == null) return SingleExpressionBlock1TokensGreen.__Missing;
                InternalSyntaxToken? tokens = null;
                if (context.kNull is not null) tokens = (InternalSyntaxToken)this.VisitTerminal(context.kNull);
                if (context.kTrue is not null) tokens = (InternalSyntaxToken)this.VisitTerminal(context.kTrue);
                if (context.kFalse is not null) tokens = (InternalSyntaxToken)this.VisitTerminal(context.kFalse);
            	return _factory.SingleExpressionBlock1Tokens((InternalSyntaxToken)tokens);
            }
            public override GreenNode? VisitPr_ArrayExpressionBlock1(CompilerParser.Pr_ArrayExpressionBlock1Context? context)
            {
               	if (context == null) return ArrayExpressionBlock1Green.__Missing;
                var singleExpressionListBuilder = _pool.AllocateSeparated<SingleExpressionGreen>(reversed: false);
                var itemsContext = context.itemsAntlr1;
                if (itemsContext is not null) singleExpressionListBuilder.Add((SingleExpressionGreen?)this.Visit(itemsContext) ?? SingleExpressionGreen.__Missing);
                else singleExpressionListBuilder.Add(SingleExpressionGreen.__Missing);
                var singleExpressionListContext = context._arrayExpressionBlock1Block1Antlr1;
                for (int i = 0; i < singleExpressionListContext.Count; ++i)
                {
                    var itemContext = singleExpressionListContext[i];
                    if (itemContext is not null)
                    {
                        var item = itemContext.itemsAntlr1;
                        var separator = itemContext.tComma;
                        singleExpressionListBuilder.AddSeparator(this.VisitTerminal(separator, CompilerSyntaxKind.TComma));
                        if (item is not null) singleExpressionListBuilder.Add((SingleExpressionGreen?)this.Visit(item) ?? SingleExpressionGreen.__Missing);
                        else singleExpressionListBuilder.Add(SingleExpressionGreen.__Missing);
                    }
                }
                var singleExpressionList = singleExpressionListBuilder.ToList();
                _pool.Free(singleExpressionListBuilder);
            	return _factory.ArrayExpressionBlock1(singleExpressionList);
            }
            public override GreenNode? VisitPr_AnnotationArgumentsBlock1(CompilerParser.Pr_AnnotationArgumentsBlock1Context? context)
            {
               	if (context == null) return AnnotationArgumentsBlock1Green.__Missing;
                var tComma = this.VisitTerminal(context.tComma, CompilerSyntaxKind.TComma);
                AnnotationArgumentGreen? arguments = null;
                if (context.argumentsAntlr1 is not null) arguments = (AnnotationArgumentGreen?)this.Visit(context.argumentsAntlr1) ?? AnnotationArgumentGreen.__Missing;
                else arguments = AnnotationArgumentGreen.__Missing;
            	return _factory.AnnotationArgumentsBlock1((InternalSyntaxToken)tComma, arguments);
            }
            public override GreenNode? VisitPr_AnnotationArgumentBlock1(CompilerParser.Pr_AnnotationArgumentBlock1Context? context)
            {
               	if (context == null) return AnnotationArgumentBlock1Green.__Missing;
                IdentifierGreen? namedParameter = null;
                if (context.namedParameterAntlr1 is not null) namedParameter = (IdentifierGreen?)this.Visit(context.namedParameterAntlr1) ?? IdentifierGreen.__Missing;
                else namedParameter = IdentifierGreen.__Missing;
                var tColon = this.VisitTerminal(context.tColon, CompilerSyntaxKind.TColon);
            	return _factory.AnnotationArgumentBlock1(namedParameter, (InternalSyntaxToken)tColon);
            }
            public override GreenNode? VisitPr_QualifierBlock1(CompilerParser.Pr_QualifierBlock1Context? context)
            {
               	if (context == null) return QualifierBlock1Green.__Missing;
                var tDot = this.VisitTerminal(context.tDot, CompilerSyntaxKind.TDot);
                IdentifierGreen? identifier = null;
                if (context.identifierAntlr1 is not null) identifier = (IdentifierGreen?)this.Visit(context.identifierAntlr1) ?? IdentifierGreen.__Missing;
                else identifier = IdentifierGreen.__Missing;
            	return _factory.QualifierBlock1((InternalSyntaxToken)tDot, identifier);
            }
            public override GreenNode? VisitPr_QualifierListBlock1(CompilerParser.Pr_QualifierListBlock1Context? context)
            {
               	if (context == null) return QualifierListBlock1Green.__Missing;
                var tComma = this.VisitTerminal(context.tComma, CompilerSyntaxKind.TComma);
                QualifierGreen? qualifier = null;
                if (context.qualifierAntlr1 is not null) qualifier = (QualifierGreen?)this.Visit(context.qualifierAntlr1) ?? QualifierGreen.__Missing;
                else qualifier = QualifierGreen.__Missing;
            	return _factory.QualifierListBlock1((InternalSyntaxToken)tComma, qualifier);
            }
            public override GreenNode? VisitPr_SimpleQualifierBlock1(CompilerParser.Pr_SimpleQualifierBlock1Context? context)
            {
               	if (context == null) return SimpleQualifierBlock1Green.__Missing;
                var tDot = this.VisitTerminal(context.tDot, CompilerSyntaxKind.TDot);
                SimpleIdentifierGreen? simpleIdentifier = null;
                if (context.simpleIdentifierAntlr1 is not null) simpleIdentifier = (SimpleIdentifierGreen?)this.Visit(context.simpleIdentifierAntlr1) ?? SimpleIdentifierGreen.__Missing;
                else simpleIdentifier = SimpleIdentifierGreen.__Missing;
            	return _factory.SimpleQualifierBlock1((InternalSyntaxToken)tDot, simpleIdentifier);
            }
            public override GreenNode? VisitPr_AlternativeBlock1Block1(CompilerParser.Pr_AlternativeBlock1Block1Context? context)
            {
               	if (context == null) return AlternativeBlock1Block1Green.__Missing;
                var kReturns = this.VisitTerminal(context.kReturns, CompilerSyntaxKind.KReturns);
                ReturnTypeQualifierGreen? returnType = null;
                if (context.returnTypeAntlr1 is not null) returnType = (ReturnTypeQualifierGreen?)this.Visit(context.returnTypeAntlr1) ?? ReturnTypeQualifierGreen.__Missing;
                else returnType = ReturnTypeQualifierGreen.__Missing;
            	return _factory.AlternativeBlock1Block1((InternalSyntaxToken)kReturns, returnType);
            }
            public override GreenNode? VisitPr_TokenBlock1Alt1Block1(CompilerParser.Pr_TokenBlock1Alt1Block1Context? context)
            {
               	if (context == null) return TokenBlock1Alt1Block1Green.__Missing;
                var kReturns = this.VisitTerminal(context.kReturns, CompilerSyntaxKind.KReturns);
                ReturnTypeQualifierGreen? returnType = null;
                if (context.returnTypeAntlr1 is not null) returnType = (ReturnTypeQualifierGreen?)this.Visit(context.returnTypeAntlr1) ?? ReturnTypeQualifierGreen.__Missing;
                else returnType = ReturnTypeQualifierGreen.__Missing;
            	return _factory.TokenBlock1Alt1Block1((InternalSyntaxToken)kReturns, returnType);
            }
            public override GreenNode? VisitPr_ArrayExpressionBlock1Block1(CompilerParser.Pr_ArrayExpressionBlock1Block1Context? context)
            {
               	if (context == null) return ArrayExpressionBlock1Block1Green.__Missing;
                var tComma = this.VisitTerminal(context.tComma, CompilerSyntaxKind.TComma);
                SingleExpressionGreen? items = null;
                if (context.itemsAntlr1 is not null) items = (SingleExpressionGreen?)this.Visit(context.itemsAntlr1) ?? SingleExpressionGreen.__Missing;
                else items = SingleExpressionGreen.__Missing;
            	return _factory.ArrayExpressionBlock1Block1((InternalSyntaxToken)tComma, items);
            }
        }
    }
}
