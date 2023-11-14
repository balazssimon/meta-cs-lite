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
                UsingBlock1Green? usingBlock1 = null;
                if (context.usingBlock1Antlr1 is not null) usingBlock1 = (UsingBlock1Green?)this.Visit(context.usingBlock1Antlr1) ?? UsingBlock1Green.__Missing;
                else usingBlock1 = UsingBlock1Green.__Missing;
                var tSemicolon = this.VisitTerminal(context.tSemicolon, CompilerSyntaxKind.TSemicolon);
            	return _factory.Using((InternalSyntaxToken)kUsing, usingBlock1, (InternalSyntaxToken)tSemicolon);
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
            public override GreenNode? VisitPr_ParserRule(CompilerParser.Pr_ParserRuleContext? context)
            {
               	if (context == null) return ParserRuleGreen.__Missing;
                var annotations1Context = context._annotations1Antlr1;
                var annotations1Builder = _pool.Allocate<AnnotationGreen>();
                for (int i = 0; i < annotations1Context.Count; ++i)
                {
                    if (annotations1Context[i] is not null) annotations1Builder.Add((AnnotationGreen?)this.Visit(annotations1Context[i]) ?? AnnotationGreen.__Missing);
                    else annotations1Builder.Add(AnnotationGreen.__Missing);
                }
                var annotations1 = annotations1Builder.ToList();
                _pool.Free(annotations1Builder);
                ParserRuleBlock1Green? parserRuleBlock1 = null;
                if (context.parserRuleBlock1Antlr1 is not null) parserRuleBlock1 = (ParserRuleBlock1Green?)this.Visit(context.parserRuleBlock1Antlr1) ?? ParserRuleBlock1Green.__Missing;
                else parserRuleBlock1 = ParserRuleBlock1Green.__Missing;
                var tColon = this.VisitTerminal(context.tColon, CompilerSyntaxKind.TColon);
                var pAlternativeListBuilder = _pool.AllocateSeparated<PAlternativeGreen>(reversed: false);
                var alternativesContext = context.alternativesAntlr1;
                if (alternativesContext is not null) pAlternativeListBuilder.Add((PAlternativeGreen?)this.Visit(alternativesContext) ?? PAlternativeGreen.__Missing);
                else pAlternativeListBuilder.Add(PAlternativeGreen.__Missing);
                var pAlternativeListContext = context._parserRuleBlock2Antlr1;
                for (int i = 0; i < pAlternativeListContext.Count; ++i)
                {
                    var itemContext = pAlternativeListContext[i];
                    if (itemContext is not null)
                    {
                        var item = itemContext.alternativesAntlr1;
                        var separator = itemContext.tBar;
                        pAlternativeListBuilder.AddSeparator(this.VisitTerminal(separator, CompilerSyntaxKind.TBar));
                        if (item is not null) pAlternativeListBuilder.Add((PAlternativeGreen?)this.Visit(item) ?? PAlternativeGreen.__Missing);
                        else pAlternativeListBuilder.Add(PAlternativeGreen.__Missing);
                    }
                }
                var pAlternativeList = pAlternativeListBuilder.ToList();
                _pool.Free(pAlternativeListBuilder);
                var tSemicolon = this.VisitTerminal(context.tSemicolon, CompilerSyntaxKind.TSemicolon);
            	return _factory.ParserRule(annotations1, parserRuleBlock1, (InternalSyntaxToken)tColon, pAlternativeList, (InternalSyntaxToken)tSemicolon);
            }
            public override GreenNode? VisitPr_LexerRule(CompilerParser.Pr_LexerRuleContext? context)
            {
               	if (context == null) return LexerRuleGreen.__Missing;
                var annotations1Context = context._annotations1Antlr1;
                var annotations1Builder = _pool.Allocate<AnnotationGreen>();
                for (int i = 0; i < annotations1Context.Count; ++i)
                {
                    if (annotations1Context[i] is not null) annotations1Builder.Add((AnnotationGreen?)this.Visit(annotations1Context[i]) ?? AnnotationGreen.__Missing);
                    else annotations1Builder.Add(AnnotationGreen.__Missing);
                }
                var annotations1 = annotations1Builder.ToList();
                _pool.Free(annotations1Builder);
                LexerRuleBlock1Green? lexerRuleBlock1 = null;
                if (context.lexerRuleBlock1Antlr1 is not null) lexerRuleBlock1 = (LexerRuleBlock1Green?)this.Visit(context.lexerRuleBlock1Antlr1) ?? LexerRuleBlock1Green.__Missing;
                else lexerRuleBlock1 = LexerRuleBlock1Green.__Missing;
                var tColon = this.VisitTerminal(context.tColon, CompilerSyntaxKind.TColon);
                var lAlternativeListBuilder = _pool.AllocateSeparated<LAlternativeGreen>(reversed: false);
                var alternativesContext = context.alternativesAntlr1;
                if (alternativesContext is not null) lAlternativeListBuilder.Add((LAlternativeGreen?)this.Visit(alternativesContext) ?? LAlternativeGreen.__Missing);
                else lAlternativeListBuilder.Add(LAlternativeGreen.__Missing);
                var lAlternativeListContext = context._lexerRuleBlock2Antlr1;
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
            	return _factory.LexerRule(annotations1, lexerRuleBlock1, (InternalSyntaxToken)tColon, lAlternativeList, (InternalSyntaxToken)tSemicolon);
            }
            public override GreenNode? VisitPr_PAlternative(CompilerParser.Pr_PAlternativeContext? context)
            {
               	if (context == null) return PAlternativeGreen.__Missing;
                PAlternativeBlock1Green? pAlternativeBlock1 = null;
                if (context.pAlternativeBlock1Antlr1 is not null) pAlternativeBlock1 = (PAlternativeBlock1Green?)this.Visit(context.pAlternativeBlock1Antlr1);
                var elementsContext = context._elementsAntlr1;
                var elementsBuilder = _pool.Allocate<PElementGreen>();
                for (int i = 0; i < elementsContext.Count; ++i)
                {
                    if (elementsContext[i] is not null) elementsBuilder.Add((PElementGreen?)this.Visit(elementsContext[i]) ?? PElementGreen.__Missing);
                    else elementsBuilder.Add(PElementGreen.__Missing);
                }
                var elements = elementsBuilder.ToList();
                _pool.Free(elementsBuilder);
                PAlternativeBlock2Green? pAlternativeBlock2 = null;
                if (context.pAlternativeBlock2Antlr1 is not null) pAlternativeBlock2 = (PAlternativeBlock2Green?)this.Visit(context.pAlternativeBlock2Antlr1);
            	return _factory.PAlternative(pAlternativeBlock1, elements, pAlternativeBlock2);
            }
            public override GreenNode? VisitPr_PElement(CompilerParser.Pr_PElementContext? context)
            {
               	if (context == null) return PElementGreen.__Missing;
                PElementBlock1Green? pElementBlock1 = null;
                if (context.pElementBlock1Antlr1 is not null) pElementBlock1 = (PElementBlock1Green?)this.Visit(context.pElementBlock1Antlr1);
                var valueAnnotationsContext = context._valueAnnotationsAntlr1;
                var valueAnnotationsBuilder = _pool.Allocate<AnnotationGreen>();
                for (int i = 0; i < valueAnnotationsContext.Count; ++i)
                {
                    if (valueAnnotationsContext[i] is not null) valueAnnotationsBuilder.Add((AnnotationGreen?)this.Visit(valueAnnotationsContext[i]) ?? AnnotationGreen.__Missing);
                    else valueAnnotationsBuilder.Add(AnnotationGreen.__Missing);
                }
                var valueAnnotations = valueAnnotationsBuilder.ToList();
                _pool.Free(valueAnnotationsBuilder);
                PElementValueGreen? value = null;
                if (context.valueAntlr1 is not null) value = (PElementValueGreen?)this.Visit(context.valueAntlr1) ?? PElementValueGreen.__Missing;
                else value = PElementValueGreen.__Missing;
                InternalSyntaxToken? multiplicity = null;
                if (context.tQuestion is not null) multiplicity = (InternalSyntaxToken)this.VisitTerminal(context.tQuestion);
                if (context.tAsterisk is not null) multiplicity = (InternalSyntaxToken)this.VisitTerminal(context.tAsterisk);
                if (context.tPlus is not null) multiplicity = (InternalSyntaxToken)this.VisitTerminal(context.tPlus);
                if (context.tQuestionQuestion is not null) multiplicity = (InternalSyntaxToken)this.VisitTerminal(context.tQuestionQuestion);
                if (context.tAsteriskQuestion is not null) multiplicity = (InternalSyntaxToken)this.VisitTerminal(context.tAsteriskQuestion);
                if (context.tPlusQuestion is not null) multiplicity = (InternalSyntaxToken)this.VisitTerminal(context.tPlusQuestion);
            	return _factory.PElement(pElementBlock1, valueAnnotations, value, (InternalSyntaxToken)multiplicity);
            }
            public override GreenNode? VisitPr_PReferenceAlt1(CompilerParser.Pr_PReferenceAlt1Context? context)
            {
               	if (context == null) return PReferenceAlt1Green.__Missing;
                IdentifierGreen? rule = null;
                if (context.ruleAntlr1 is not null) rule = (IdentifierGreen?)this.Visit(context.ruleAntlr1) ?? IdentifierGreen.__Missing;
                else rule = IdentifierGreen.__Missing;
            	return _factory.PReferenceAlt1(rule);
            }
            public override GreenNode? VisitPr_PReferenceAlt2(CompilerParser.Pr_PReferenceAlt2Context? context)
            {
               	if (context == null) return PReferenceAlt2Green.__Missing;
                var tHash = this.VisitTerminal(context.tHash, CompilerSyntaxKind.THash);
                QualifierGreen? referencedTypes = null;
                if (context.referencedTypesAntlr1 is not null) referencedTypes = (QualifierGreen?)this.Visit(context.referencedTypesAntlr1) ?? QualifierGreen.__Missing;
                else referencedTypes = QualifierGreen.__Missing;
            	return _factory.PReferenceAlt2((InternalSyntaxToken)tHash, referencedTypes);
            }
            public override GreenNode? VisitPr_PReferenceAlt3(CompilerParser.Pr_PReferenceAlt3Context? context)
            {
               	if (context == null) return PReferenceAlt3Green.__Missing;
                var tHashLBrace = this.VisitTerminal(context.tHashLBrace, CompilerSyntaxKind.THashLBrace);
                var qualifierListBuilder = _pool.AllocateSeparated<QualifierGreen>(reversed: false);
                var referencedTypesContext = context.referencedTypesAntlr1;
                if (referencedTypesContext is not null) qualifierListBuilder.Add((QualifierGreen?)this.Visit(referencedTypesContext) ?? QualifierGreen.__Missing);
                else qualifierListBuilder.Add(QualifierGreen.__Missing);
                var qualifierListContext = context._pReferenceAlt3Block1Antlr1;
                for (int i = 0; i < qualifierListContext.Count; ++i)
                {
                    var itemContext = qualifierListContext[i];
                    if (itemContext is not null)
                    {
                        var item = itemContext.referencedTypesAntlr1;
                        var separator = itemContext.tComma;
                        qualifierListBuilder.AddSeparator(this.VisitTerminal(separator, CompilerSyntaxKind.TComma));
                        if (item is not null) qualifierListBuilder.Add((QualifierGreen?)this.Visit(item) ?? QualifierGreen.__Missing);
                        else qualifierListBuilder.Add(QualifierGreen.__Missing);
                    }
                }
                var qualifierList = qualifierListBuilder.ToList();
                _pool.Free(qualifierListBuilder);
                var tRBrace = this.VisitTerminal(context.tRBrace, CompilerSyntaxKind.TRBrace);
            	return _factory.PReferenceAlt3((InternalSyntaxToken)tHashLBrace, qualifierList, (InternalSyntaxToken)tRBrace);
            }
            public override GreenNode? VisitPr_PEof(CompilerParser.Pr_PEofContext? context)
            {
               	if (context == null) return PEofGreen.__Missing;
                var kEof = this.VisitTerminal(context.kEof, CompilerSyntaxKind.KEof);
            	return _factory.PEof((InternalSyntaxToken)kEof);
            }
            public override GreenNode? VisitPr_PKeyword(CompilerParser.Pr_PKeywordContext? context)
            {
               	if (context == null) return PKeywordGreen.__Missing;
                var text = this.VisitTerminal(context.textAntlr1, CompilerSyntaxKind.TString);
            	return _factory.PKeyword((InternalSyntaxToken)text);
            }
            public override GreenNode? VisitPr_PBlock(CompilerParser.Pr_PBlockContext? context)
            {
               	if (context == null) return PBlockGreen.__Missing;
                var tLParen = this.VisitTerminal(context.tLParen, CompilerSyntaxKind.TLParen);
                var pAlternativeListBuilder = _pool.AllocateSeparated<PAlternativeGreen>(reversed: false);
                var alternativesContext = context.alternativesAntlr1;
                if (alternativesContext is not null) pAlternativeListBuilder.Add((PAlternativeGreen?)this.Visit(alternativesContext) ?? PAlternativeGreen.__Missing);
                else pAlternativeListBuilder.Add(PAlternativeGreen.__Missing);
                var pAlternativeListContext = context._pBlockBlock1Antlr1;
                for (int i = 0; i < pAlternativeListContext.Count; ++i)
                {
                    var itemContext = pAlternativeListContext[i];
                    if (itemContext is not null)
                    {
                        var item = itemContext.alternativesAntlr1;
                        var separator = itemContext.tBar;
                        pAlternativeListBuilder.AddSeparator(this.VisitTerminal(separator, CompilerSyntaxKind.TBar));
                        if (item is not null) pAlternativeListBuilder.Add((PAlternativeGreen?)this.Visit(item) ?? PAlternativeGreen.__Missing);
                        else pAlternativeListBuilder.Add(PAlternativeGreen.__Missing);
                    }
                }
                var pAlternativeList = pAlternativeListBuilder.ToList();
                _pool.Free(pAlternativeListBuilder);
                var tRParen = this.VisitTerminal(context.tRParen, CompilerSyntaxKind.TRParen);
            	return _factory.PBlock((InternalSyntaxToken)tLParen, pAlternativeList, (InternalSyntaxToken)tRParen);
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
            public override GreenNode? VisitPr_LReference(CompilerParser.Pr_LReferenceContext? context)
            {
               	if (context == null) return LReferenceGreen.__Missing;
                IdentifierGreen? rule = null;
                if (context.ruleAntlr1 is not null) rule = (IdentifierGreen?)this.Visit(context.ruleAntlr1) ?? IdentifierGreen.__Missing;
                else rule = IdentifierGreen.__Missing;
            	return _factory.LReference(rule);
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
            public override GreenNode? VisitPr_IntExpression(CompilerParser.Pr_IntExpressionContext? context)
            {
               	if (context == null) return IntExpressionGreen.__Missing;
                var intValue = this.VisitTerminal(context.intValueAntlr1, CompilerSyntaxKind.TInteger);
            	return _factory.IntExpression((InternalSyntaxToken)intValue);
            }
            public override GreenNode? VisitPr_StringExpression(CompilerParser.Pr_StringExpressionContext? context)
            {
               	if (context == null) return StringExpressionGreen.__Missing;
                var stringValue = this.VisitTerminal(context.stringValueAntlr1, CompilerSyntaxKind.TString);
            	return _factory.StringExpression((InternalSyntaxToken)stringValue);
            }
            public override GreenNode? VisitPr_ReferenceExpression(CompilerParser.Pr_ReferenceExpressionContext? context)
            {
               	if (context == null) return ReferenceExpressionGreen.__Missing;
                QualifierGreen? qualifier = null;
                if (context.qualifierAntlr1 is not null) qualifier = (QualifierGreen?)this.Visit(context.qualifierAntlr1) ?? QualifierGreen.__Missing;
                else qualifier = QualifierGreen.__Missing;
            	return _factory.ReferenceExpression(qualifier);
            }
            public override GreenNode? VisitPr_ExpressionTokens(CompilerParser.Pr_ExpressionTokensContext? context)
            {
               	if (context == null) return ExpressionTokensGreen.__Missing;
                InternalSyntaxToken? tokens = null;
                if (context.kNull is not null) tokens = (InternalSyntaxToken)this.VisitTerminal(context.kNull);
                if (context.boolValue is not null) tokens = (InternalSyntaxToken)this.VisitTerminal(context.boolValue);
                if (context.kFalse is not null) tokens = (InternalSyntaxToken)this.VisitTerminal(context.kFalse);
            	return _factory.ExpressionTokens((InternalSyntaxToken)tokens);
            }
            public override GreenNode? VisitPr_Annotation(CompilerParser.Pr_AnnotationContext? context)
            {
               	if (context == null) return AnnotationGreen.__Missing;
                var tLBracket = this.VisitTerminal(context.tLBracket, CompilerSyntaxKind.TLBracket);
                QualifierGreen? type = null;
                if (context.typeAntlr1 is not null) type = (QualifierGreen?)this.Visit(context.typeAntlr1) ?? QualifierGreen.__Missing;
                else type = QualifierGreen.__Missing;
                AnnotationArgumentsGreen? annotationArguments = null;
                if (context.annotationArgumentsAntlr1 is not null) annotationArguments = (AnnotationArgumentsGreen?)this.Visit(context.annotationArgumentsAntlr1);
                var tRBracket = this.VisitTerminal(context.tRBracket, CompilerSyntaxKind.TRBracket);
            	return _factory.Annotation((InternalSyntaxToken)tLBracket, type, annotationArguments, (InternalSyntaxToken)tRBracket);
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
            public override GreenNode? VisitPr_Identifier(CompilerParser.Pr_IdentifierContext? context)
            {
               	if (context == null) return IdentifierGreen.__Missing;
                var tIdentifier = this.VisitTerminal(context.tIdentifierAntlr1, CompilerSyntaxKind.TIdentifier);
            	return _factory.Identifier((InternalSyntaxToken)tIdentifier);
            }
            public override GreenNode? VisitPr_UsingBlock1Alt1(CompilerParser.Pr_UsingBlock1Alt1Context? context)
            {
               	if (context == null) return UsingBlock1Alt1Green.__Missing;
                QualifierGreen? namespaces = null;
                if (context.namespacesAntlr1 is not null) namespaces = (QualifierGreen?)this.Visit(context.namespacesAntlr1) ?? QualifierGreen.__Missing;
                else namespaces = QualifierGreen.__Missing;
            	return _factory.UsingBlock1Alt1(namespaces);
            }
            public override GreenNode? VisitPr_UsingBlock1Alt2(CompilerParser.Pr_UsingBlock1Alt2Context? context)
            {
               	if (context == null) return UsingBlock1Alt2Green.__Missing;
                var kMetamodel = this.VisitTerminal(context.kMetamodel, CompilerSyntaxKind.KMetamodel);
                QualifierGreen? metaModelSymbols = null;
                if (context.metaModelSymbolsAntlr1 is not null) metaModelSymbols = (QualifierGreen?)this.Visit(context.metaModelSymbolsAntlr1) ?? QualifierGreen.__Missing;
                else metaModelSymbols = QualifierGreen.__Missing;
            	return _factory.UsingBlock1Alt2((InternalSyntaxToken)kMetamodel, metaModelSymbols);
            }
            public override GreenNode? VisitPr_GrammarBlock1(CompilerParser.Pr_GrammarBlock1Context? context)
            {
               	if (context == null) return GrammarBlock1Green.__Missing;
                var rulesContext = context._rulesAntlr1;
                var rulesBuilder = _pool.Allocate<RuleGreen>();
                for (int i = 0; i < rulesContext.Count; ++i)
                {
                    if (rulesContext[i] is not null) rulesBuilder.Add((RuleGreen?)this.Visit(rulesContext[i]) ?? RuleGreen.__Missing);
                    else rulesBuilder.Add(RuleGreen.__Missing);
                }
                var rules = rulesBuilder.ToList();
                _pool.Free(rulesBuilder);
            	return _factory.GrammarBlock1(rules);
            }
            public override GreenNode? VisitPr_ParserRuleBlock1Alt1(CompilerParser.Pr_ParserRuleBlock1Alt1Context? context)
            {
               	if (context == null) return ParserRuleBlock1Alt1Green.__Missing;
                var isBlock = this.VisitTerminal(context.isBlock, CompilerSyntaxKind.KBlock);
                NameGreen? name = null;
                if (context.nameAntlr1 is not null) name = (NameGreen?)this.Visit(context.nameAntlr1) ?? NameGreen.__Missing;
                else name = NameGreen.__Missing;
            	return _factory.ParserRuleBlock1Alt1((InternalSyntaxToken)isBlock, name);
            }
            public override GreenNode? VisitPr_ParserRuleBlock1Alt2(CompilerParser.Pr_ParserRuleBlock1Alt2Context? context)
            {
               	if (context == null) return ParserRuleBlock1Alt2Green.__Missing;
                IdentifierGreen? returnType = null;
                if (context.returnTypeAntlr1 is not null) returnType = (IdentifierGreen?)this.Visit(context.returnTypeAntlr1) ?? IdentifierGreen.__Missing;
                else returnType = IdentifierGreen.__Missing;
            	return _factory.ParserRuleBlock1Alt2(returnType);
            }
            public override GreenNode? VisitPr_ParserRuleBlock1Alt3(CompilerParser.Pr_ParserRuleBlock1Alt3Context? context)
            {
               	if (context == null) return ParserRuleBlock1Alt3Green.__Missing;
                NameGreen? name = null;
                if (context.nameAntlr1 is not null) name = (NameGreen?)this.Visit(context.nameAntlr1) ?? NameGreen.__Missing;
                else name = NameGreen.__Missing;
                var kReturns = this.VisitTerminal(context.kReturns, CompilerSyntaxKind.KReturns);
                QualifierGreen? returnType = null;
                if (context.returnTypeAntlr1 is not null) returnType = (QualifierGreen?)this.Visit(context.returnTypeAntlr1) ?? QualifierGreen.__Missing;
                else returnType = QualifierGreen.__Missing;
            	return _factory.ParserRuleBlock1Alt3(name, (InternalSyntaxToken)kReturns, returnType);
            }
            public override GreenNode? VisitPr_ParserRuleBlock2(CompilerParser.Pr_ParserRuleBlock2Context? context)
            {
               	if (context == null) return ParserRuleBlock2Green.__Missing;
                var tBar = this.VisitTerminal(context.tBar, CompilerSyntaxKind.TBar);
                PAlternativeGreen? alternatives = null;
                if (context.alternativesAntlr1 is not null) alternatives = (PAlternativeGreen?)this.Visit(context.alternativesAntlr1) ?? PAlternativeGreen.__Missing;
                else alternatives = PAlternativeGreen.__Missing;
            	return _factory.ParserRuleBlock2((InternalSyntaxToken)tBar, alternatives);
            }
            public override GreenNode? VisitPr_PAlternativeBlock1(CompilerParser.Pr_PAlternativeBlock1Context? context)
            {
               	if (context == null) return PAlternativeBlock1Green.__Missing;
                var tLBrace = this.VisitTerminal(context.tLBrace, CompilerSyntaxKind.TLBrace);
                QualifierGreen? returnType = null;
                if (context.returnTypeAntlr1 is not null) returnType = (QualifierGreen?)this.Visit(context.returnTypeAntlr1) ?? QualifierGreen.__Missing;
                else returnType = QualifierGreen.__Missing;
                var tRBrace = this.VisitTerminal(context.tRBrace, CompilerSyntaxKind.TRBrace);
            	return _factory.PAlternativeBlock1((InternalSyntaxToken)tLBrace, returnType, (InternalSyntaxToken)tRBrace);
            }
            public override GreenNode? VisitPr_PAlternativeBlock2(CompilerParser.Pr_PAlternativeBlock2Context? context)
            {
               	if (context == null) return PAlternativeBlock2Green.__Missing;
                var tEqGt = this.VisitTerminal(context.tEqGt, CompilerSyntaxKind.TEqGt);
                ExpressionGreen? returnValue = null;
                if (context.returnValueAntlr1 is not null) returnValue = (ExpressionGreen?)this.Visit(context.returnValueAntlr1) ?? ExpressionGreen.__Missing;
                else returnValue = ExpressionGreen.__Missing;
            	return _factory.PAlternativeBlock2((InternalSyntaxToken)tEqGt, returnValue);
            }
            public override GreenNode? VisitPr_PElementBlock1(CompilerParser.Pr_PElementBlock1Context? context)
            {
               	if (context == null) return PElementBlock1Green.__Missing;
                var nameAnnotationsContext = context._nameAnnotationsAntlr1;
                var nameAnnotationsBuilder = _pool.Allocate<AnnotationGreen>();
                for (int i = 0; i < nameAnnotationsContext.Count; ++i)
                {
                    if (nameAnnotationsContext[i] is not null) nameAnnotationsBuilder.Add((AnnotationGreen?)this.Visit(nameAnnotationsContext[i]) ?? AnnotationGreen.__Missing);
                    else nameAnnotationsBuilder.Add(AnnotationGreen.__Missing);
                }
                var nameAnnotations = nameAnnotationsBuilder.ToList();
                _pool.Free(nameAnnotationsBuilder);
                NameGreen? name = null;
                if (context.nameAntlr1 is not null) name = (NameGreen?)this.Visit(context.nameAntlr1) ?? NameGreen.__Missing;
                else name = NameGreen.__Missing;
                InternalSyntaxToken? assignment = null;
                if (context.tEq is not null) assignment = (InternalSyntaxToken)this.VisitTerminal(context.tEq);
                if (context.tQuestionEq is not null) assignment = (InternalSyntaxToken)this.VisitTerminal(context.tQuestionEq);
                if (context.tExclEq is not null) assignment = (InternalSyntaxToken)this.VisitTerminal(context.tExclEq);
                if (context.tPlusEq is not null) assignment = (InternalSyntaxToken)this.VisitTerminal(context.tPlusEq);
            	return _factory.PElementBlock1(nameAnnotations, name, (InternalSyntaxToken)assignment);
            }
            public override GreenNode? VisitPr_PReferenceAlt3Block1(CompilerParser.Pr_PReferenceAlt3Block1Context? context)
            {
               	if (context == null) return PReferenceAlt3Block1Green.__Missing;
                var tComma = this.VisitTerminal(context.tComma, CompilerSyntaxKind.TComma);
                QualifierGreen? referencedTypes = null;
                if (context.referencedTypesAntlr1 is not null) referencedTypes = (QualifierGreen?)this.Visit(context.referencedTypesAntlr1) ?? QualifierGreen.__Missing;
                else referencedTypes = QualifierGreen.__Missing;
            	return _factory.PReferenceAlt3Block1((InternalSyntaxToken)tComma, referencedTypes);
            }
            public override GreenNode? VisitPr_PBlockBlock1(CompilerParser.Pr_PBlockBlock1Context? context)
            {
               	if (context == null) return PBlockBlock1Green.__Missing;
                var tBar = this.VisitTerminal(context.tBar, CompilerSyntaxKind.TBar);
                PAlternativeGreen? alternatives = null;
                if (context.alternativesAntlr1 is not null) alternatives = (PAlternativeGreen?)this.Visit(context.alternativesAntlr1) ?? PAlternativeGreen.__Missing;
                else alternatives = PAlternativeGreen.__Missing;
            	return _factory.PBlockBlock1((InternalSyntaxToken)tBar, alternatives);
            }
            public override GreenNode? VisitPr_LexerRuleBlock1Alt1(CompilerParser.Pr_LexerRuleBlock1Alt1Context? context)
            {
               	if (context == null) return LexerRuleBlock1Alt1Green.__Missing;
                var kToken = this.VisitTerminal(context.kToken, CompilerSyntaxKind.KToken);
                NameGreen? name = null;
                if (context.nameAntlr1 is not null) name = (NameGreen?)this.Visit(context.nameAntlr1) ?? NameGreen.__Missing;
                else name = NameGreen.__Missing;
                LexerRuleBlock1Alt1Block1Green? lexerRuleBlock1Alt1Block1 = null;
                if (context.lexerRuleBlock1Alt1Block1Antlr1 is not null) lexerRuleBlock1Alt1Block1 = (LexerRuleBlock1Alt1Block1Green?)this.Visit(context.lexerRuleBlock1Alt1Block1Antlr1);
            	return _factory.LexerRuleBlock1Alt1((InternalSyntaxToken)kToken, name, lexerRuleBlock1Alt1Block1);
            }
            public override GreenNode? VisitPr_LexerRuleBlock1Alt2(CompilerParser.Pr_LexerRuleBlock1Alt2Context? context)
            {
               	if (context == null) return LexerRuleBlock1Alt2Green.__Missing;
                var isHidden = this.VisitTerminal(context.isHidden, CompilerSyntaxKind.KHidden);
                NameGreen? name = null;
                if (context.nameAntlr1 is not null) name = (NameGreen?)this.Visit(context.nameAntlr1) ?? NameGreen.__Missing;
                else name = NameGreen.__Missing;
            	return _factory.LexerRuleBlock1Alt2((InternalSyntaxToken)isHidden, name);
            }
            public override GreenNode? VisitPr_LexerRuleBlock1Alt3(CompilerParser.Pr_LexerRuleBlock1Alt3Context? context)
            {
               	if (context == null) return LexerRuleBlock1Alt3Green.__Missing;
                var isFragment = this.VisitTerminal(context.isFragment, CompilerSyntaxKind.KFragment);
                NameGreen? name = null;
                if (context.nameAntlr1 is not null) name = (NameGreen?)this.Visit(context.nameAntlr1) ?? NameGreen.__Missing;
                else name = NameGreen.__Missing;
            	return _factory.LexerRuleBlock1Alt3((InternalSyntaxToken)isFragment, name);
            }
            public override GreenNode? VisitPr_LexerRuleBlock2(CompilerParser.Pr_LexerRuleBlock2Context? context)
            {
               	if (context == null) return LexerRuleBlock2Green.__Missing;
                var tBar = this.VisitTerminal(context.tBar, CompilerSyntaxKind.TBar);
                LAlternativeGreen? alternatives = null;
                if (context.alternativesAntlr1 is not null) alternatives = (LAlternativeGreen?)this.Visit(context.alternativesAntlr1) ?? LAlternativeGreen.__Missing;
                else alternatives = LAlternativeGreen.__Missing;
            	return _factory.LexerRuleBlock2((InternalSyntaxToken)tBar, alternatives);
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
                IdentifierGreen? name = null;
                if (context.nameAntlr1 is not null) name = (IdentifierGreen?)this.Visit(context.nameAntlr1) ?? IdentifierGreen.__Missing;
                else name = IdentifierGreen.__Missing;
                var tColon = this.VisitTerminal(context.tColon, CompilerSyntaxKind.TColon);
            	return _factory.AnnotationArgumentBlock1(name, (InternalSyntaxToken)tColon);
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
            public override GreenNode? VisitPr_LexerRuleBlock1Alt1Block1(CompilerParser.Pr_LexerRuleBlock1Alt1Block1Context? context)
            {
               	if (context == null) return LexerRuleBlock1Alt1Block1Green.__Missing;
                var kReturns = this.VisitTerminal(context.kReturns, CompilerSyntaxKind.KReturns);
                QualifierGreen? returnType = null;
                if (context.returnTypeAntlr1 is not null) returnType = (QualifierGreen?)this.Visit(context.returnTypeAntlr1) ?? QualifierGreen.__Missing;
                else returnType = QualifierGreen.__Missing;
            	return _factory.LexerRuleBlock1Alt1Block1((InternalSyntaxToken)kReturns, returnType);
            }
        }
    }
}
