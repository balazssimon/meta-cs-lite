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
    var kNamespace = (InternalSyntaxToken?)this.VisitTerminal(context.e_KNamespace, CompilerSyntaxKind.KNamespace);
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
            qualifierBuilder.AddSeparator((InternalSyntaxToken?)this.VisitTerminal(_separator, CompilerSyntaxKind.TDot));
        }
        else
        {
            qualifierBuilder.AddSeparator((InternalSyntaxToken?)this.VisitTerminal((IToken?)null, CompilerSyntaxKind.TDot));
        }
        var _item = e_Identifier2Context[i];
        if (_item is not null) qualifierBuilder.Add((IdentifierGreen?)this.Visit(_item) ?? IdentifierGreen.__Missing);
        else qualifierBuilder.Add(IdentifierGreen.__Missing);
    }
    var qualifier = qualifierBuilder.ToList();
    _pool.Free(qualifierBuilder);
    var tSemicolon = (InternalSyntaxToken?)this.VisitTerminal(context.e_TSemicolon, CompilerSyntaxKind.TSemicolon);
    var e_UsingListContext = context._e_UsingList;
    var usingListBuilder = _pool.Allocate<UsingGreen>();
    for (int i = 0; i < e_UsingListContext.Count; ++i)
    {
        if (e_UsingListContext[i] is not null) usingListBuilder.Add((UsingGreen?)this.Visit(e_UsingListContext[i]) ?? UsingGreen.__Missing);
        else usingListBuilder.Add(UsingGreen.__Missing);
    }
    var usingList = usingListBuilder.ToList();
    _pool.Free(usingListBuilder);
    MainBlock1Green? block = null;
    if (context.e_Block is not null) block = (MainBlock1Green?)this.Visit(context.e_Block) ?? MainBlock1Green.__Missing;
    else block = MainBlock1Green.__Missing;
    var endOfFileToken = (InternalSyntaxToken?)this.VisitTerminal(context.e_EndOfFileToken, CompilerSyntaxKind.Eof);
	return _factory.Main(kNamespace, qualifier, tSemicolon, usingList, block, endOfFileToken);
}

public override GreenNode? VisitPr_Using(CompilerParser.Pr_UsingContext? context)
{
   	if (context == null) return UsingGreen.__Missing;
    var kUsing = (InternalSyntaxToken?)this.VisitTerminal(context.e_KUsing, CompilerSyntaxKind.KUsing);
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
            qualifierBuilder.AddSeparator((InternalSyntaxToken?)this.VisitTerminal(_separator, CompilerSyntaxKind.TDot));
        }
        else
        {
            qualifierBuilder.AddSeparator((InternalSyntaxToken?)this.VisitTerminal((IToken?)null, CompilerSyntaxKind.TDot));
        }
        var _item = e_Identifier2Context[i];
        if (_item is not null) qualifierBuilder.Add((IdentifierGreen?)this.Visit(_item) ?? IdentifierGreen.__Missing);
        else qualifierBuilder.Add(IdentifierGreen.__Missing);
    }
    var qualifier = qualifierBuilder.ToList();
    _pool.Free(qualifierBuilder);
    var tSemicolon = (InternalSyntaxToken?)this.VisitTerminal(context.e_TSemicolon, CompilerSyntaxKind.TSemicolon);
	return _factory.Using(kUsing, qualifier, tSemicolon);
}

public override GreenNode? VisitPr_LanguageDeclaration(CompilerParser.Pr_LanguageDeclarationContext? context)
{
   	if (context == null) return LanguageDeclarationGreen.__Missing;
    var kLanguage = (InternalSyntaxToken?)this.VisitTerminal(context.e_KLanguage, CompilerSyntaxKind.KLanguage);
    NameGreen? name = null;
    if (context.e_Name is not null) name = (NameGreen?)this.Visit(context.e_Name) ?? NameGreen.__Missing;
    else name = NameGreen.__Missing;
    var tSemicolon = (InternalSyntaxToken?)this.VisitTerminal(context.e_TSemicolon, CompilerSyntaxKind.TSemicolon);
    GrammarGreen? grammar = null;
    if (context.e_Grammar is not null) grammar = (GrammarGreen?)this.Visit(context.e_Grammar) ?? GrammarGreen.__Missing;
    else grammar = GrammarGreen.__Missing;
	return _factory.LanguageDeclaration(kLanguage, name, tSemicolon, grammar);
}

public override GreenNode? VisitPr_Grammar(CompilerParser.Pr_GrammarContext? context)
{
   	if (context == null) return GrammarGreen.__Missing;
    var e_GrammarRulesContext = context._e_GrammarRules;
    var grammarRulesBuilder = _pool.Allocate<GrammarRuleGreen>();
    for (int i = 0; i < e_GrammarRulesContext.Count; ++i)
    {
        if (e_GrammarRulesContext[i] is not null) grammarRulesBuilder.Add((GrammarRuleGreen?)this.Visit(e_GrammarRulesContext[i]) ?? GrammarRuleGreen.__Missing);
        else grammarRulesBuilder.Add(GrammarRuleGreen.__Missing);
    }
    var grammarRules = grammarRulesBuilder.ToList();
    _pool.Free(grammarRulesBuilder);
	return _factory.Grammar(grammarRules);
}

public override GreenNode? VisitPr_Rule(CompilerParser.Pr_RuleContext? context)
{
   	if (context == null) return RuleGreen.__Missing;
    var e_AnnotationsContext = context._e_Annotations;
    var annotations1Builder = _pool.Allocate<ParserAnnotationGreen>();
    for (int i = 0; i < e_AnnotationsContext.Count; ++i)
    {
        if (e_AnnotationsContext[i] is not null) annotations1Builder.Add((ParserAnnotationGreen?)this.Visit(e_AnnotationsContext[i]) ?? ParserAnnotationGreen.__Missing);
        else annotations1Builder.Add(ParserAnnotationGreen.__Missing);
    }
    var annotations1 = annotations1Builder.ToList();
    _pool.Free(annotations1Builder);
    RuleBlock1Green? block = null;
    if (context.e_Block is not null) block = (RuleBlock1Green?)this.Visit(context.e_Block) ?? RuleBlock1Green.__Missing;
    else block = RuleBlock1Green.__Missing;
    var tColon = (InternalSyntaxToken?)this.VisitTerminal(context.e_TColon, CompilerSyntaxKind.TColon);
    var alternativesBuilder = _pool.AllocateSeparated<AlternativeGreen>(reversed: false);
    var e_Alternatives1Context = context.e_Alternatives1;
    if (e_Alternatives1Context is not null) alternativesBuilder.Add((AlternativeGreen?)this.Visit(e_Alternatives1Context) ?? AlternativeGreen.__Missing);
    else alternativesBuilder.Add(AlternativeGreen.__Missing);
    var e_Alternatives2Context = context._e_Alternatives2;
    var e_TBar1Context = context._e_TBar1;
    for (int i = 0; i < e_Alternatives2Context.Count; ++i)
    {
        if (i < e_TBar1Context.Count)
        {
            var _separator = e_TBar1Context[i];
            alternativesBuilder.AddSeparator((InternalSyntaxToken?)this.VisitTerminal(_separator, CompilerSyntaxKind.TBar));
        }
        else
        {
            alternativesBuilder.AddSeparator((InternalSyntaxToken?)this.VisitTerminal((IToken?)null, CompilerSyntaxKind.TBar));
        }
        var _item = e_Alternatives2Context[i];
        if (_item is not null) alternativesBuilder.Add((AlternativeGreen?)this.Visit(_item) ?? AlternativeGreen.__Missing);
        else alternativesBuilder.Add(AlternativeGreen.__Missing);
    }
    var alternatives = alternativesBuilder.ToList();
    _pool.Free(alternativesBuilder);
    var tSemicolon = (InternalSyntaxToken?)this.VisitTerminal(context.e_TSemicolon, CompilerSyntaxKind.TSemicolon);
	return _factory.Rule(annotations1, block, tColon, alternatives, tSemicolon);
}

public override GreenNode? VisitPr_Token(CompilerParser.Pr_TokenContext? context)
{
   	if (context == null) return TokenGreen.__Missing;
    var e_Annotations1Context = context._e_Annotations1;
    var annotations1Builder = _pool.Allocate<LexerAnnotationGreen>();
    for (int i = 0; i < e_Annotations1Context.Count; ++i)
    {
        if (e_Annotations1Context[i] is not null) annotations1Builder.Add((LexerAnnotationGreen?)this.Visit(e_Annotations1Context[i]) ?? LexerAnnotationGreen.__Missing);
        else annotations1Builder.Add(LexerAnnotationGreen.__Missing);
    }
    var annotations1 = annotations1Builder.ToList();
    _pool.Free(annotations1Builder);
    TokenBlock1Green? block = null;
    if (context.e_Block1 is not null) block = (TokenBlock1Green?)this.Visit(context.e_Block1) ?? TokenBlock1Green.__Missing;
    else block = TokenBlock1Green.__Missing;
    var tColon = (InternalSyntaxToken?)this.VisitTerminal(context.e_TColon1, CompilerSyntaxKind.TColon);
    var alternativesBuilder = _pool.AllocateSeparated<LAlternativeGreen>(reversed: false);
    var e_Alternatives3Context = context.e_Alternatives3;
    if (e_Alternatives3Context is not null) alternativesBuilder.Add((LAlternativeGreen?)this.Visit(e_Alternatives3Context) ?? LAlternativeGreen.__Missing);
    else alternativesBuilder.Add(LAlternativeGreen.__Missing);
    var e_Alternatives4Context = context._e_Alternatives4;
    var e_TBar2Context = context._e_TBar2;
    for (int i = 0; i < e_Alternatives4Context.Count; ++i)
    {
        if (i < e_TBar2Context.Count)
        {
            var _separator = e_TBar2Context[i];
            alternativesBuilder.AddSeparator((InternalSyntaxToken?)this.VisitTerminal(_separator, CompilerSyntaxKind.TBar));
        }
        else
        {
            alternativesBuilder.AddSeparator((InternalSyntaxToken?)this.VisitTerminal((IToken?)null, CompilerSyntaxKind.TBar));
        }
        var _item = e_Alternatives4Context[i];
        if (_item is not null) alternativesBuilder.Add((LAlternativeGreen?)this.Visit(_item) ?? LAlternativeGreen.__Missing);
        else alternativesBuilder.Add(LAlternativeGreen.__Missing);
    }
    var alternatives = alternativesBuilder.ToList();
    _pool.Free(alternativesBuilder);
    var tSemicolon = (InternalSyntaxToken?)this.VisitTerminal(context.e_TSemicolon1, CompilerSyntaxKind.TSemicolon);
	return _factory.Token(annotations1, block, tColon, alternatives, tSemicolon);
}

public override GreenNode? VisitPr_Fragment(CompilerParser.Pr_FragmentContext? context)
{
   	if (context == null) return FragmentGreen.__Missing;
    var kFragment = (InternalSyntaxToken?)this.VisitTerminal(context.e_KFragment, CompilerSyntaxKind.KFragment);
    NameGreen? name = null;
    if (context.e_Name is not null) name = (NameGreen?)this.Visit(context.e_Name) ?? NameGreen.__Missing;
    else name = NameGreen.__Missing;
    var tColon = (InternalSyntaxToken?)this.VisitTerminal(context.e_TColon2, CompilerSyntaxKind.TColon);
    var alternativesBuilder = _pool.AllocateSeparated<LAlternativeGreen>(reversed: false);
    var e_Alternatives5Context = context.e_Alternatives5;
    if (e_Alternatives5Context is not null) alternativesBuilder.Add((LAlternativeGreen?)this.Visit(e_Alternatives5Context) ?? LAlternativeGreen.__Missing);
    else alternativesBuilder.Add(LAlternativeGreen.__Missing);
    var e_Alternatives6Context = context._e_Alternatives6;
    var e_TBar3Context = context._e_TBar3;
    for (int i = 0; i < e_Alternatives6Context.Count; ++i)
    {
        if (i < e_TBar3Context.Count)
        {
            var _separator = e_TBar3Context[i];
            alternativesBuilder.AddSeparator((InternalSyntaxToken?)this.VisitTerminal(_separator, CompilerSyntaxKind.TBar));
        }
        else
        {
            alternativesBuilder.AddSeparator((InternalSyntaxToken?)this.VisitTerminal((IToken?)null, CompilerSyntaxKind.TBar));
        }
        var _item = e_Alternatives6Context[i];
        if (_item is not null) alternativesBuilder.Add((LAlternativeGreen?)this.Visit(_item) ?? LAlternativeGreen.__Missing);
        else alternativesBuilder.Add(LAlternativeGreen.__Missing);
    }
    var alternatives = alternativesBuilder.ToList();
    _pool.Free(alternativesBuilder);
    var tSemicolon = (InternalSyntaxToken?)this.VisitTerminal(context.e_TSemicolon2, CompilerSyntaxKind.TSemicolon);
	return _factory.Fragment(kFragment, name, tColon, alternatives, tSemicolon);
}

public override GreenNode? VisitPr_Alternative(CompilerParser.Pr_AlternativeContext? context)
{
   	if (context == null) return AlternativeGreen.__Missing;
    AlternativeBlock1Green? block1 = null;
    if (context.e_Block is not null) block1 = (AlternativeBlock1Green?)this.Visit(context.e_Block);
    var e_ElementsContext = context._e_Elements;
    var elementsBuilder = _pool.Allocate<ElementGreen>();
    for (int i = 0; i < e_ElementsContext.Count; ++i)
    {
        if (e_ElementsContext[i] is not null) elementsBuilder.Add((ElementGreen?)this.Visit(e_ElementsContext[i]) ?? ElementGreen.__Missing);
        else elementsBuilder.Add(ElementGreen.__Missing);
    }
    var elements = elementsBuilder.ToList();
    _pool.Free(elementsBuilder);
    AlternativeBlock2Green? block2 = null;
    if (context.e_Block1 is not null) block2 = (AlternativeBlock2Green?)this.Visit(context.e_Block1);
	return _factory.Alternative(block1, elements, block2);
}

public override GreenNode? VisitPr_Element(CompilerParser.Pr_ElementContext? context)
{
   	if (context == null) return ElementGreen.__Missing;
    ElementBlock1Green? block = null;
    if (context.e_Block is not null) block = (ElementBlock1Green?)this.Visit(context.e_Block);
    ElementValueGreen? value = null;
    if (context.e_Value is not null) value = (ElementValueGreen?)this.Visit(context.e_Value) ?? ElementValueGreen.__Missing;
    else value = ElementValueGreen.__Missing;
	return _factory.Element(block, value);
}

public override GreenNode? VisitPr_ElementValue(CompilerParser.Pr_ElementValueContext? context)
{
   	if (context == null) return ElementValueGreen.__Missing;
    var e_AnnotationsContext = context._e_Annotations;
    var annotations1Builder = _pool.Allocate<ParserAnnotationGreen>();
    for (int i = 0; i < e_AnnotationsContext.Count; ++i)
    {
        if (e_AnnotationsContext[i] is not null) annotations1Builder.Add((ParserAnnotationGreen?)this.Visit(e_AnnotationsContext[i]) ?? ParserAnnotationGreen.__Missing);
        else annotations1Builder.Add(ParserAnnotationGreen.__Missing);
    }
    var annotations1 = annotations1Builder.ToList();
    _pool.Free(annotations1Builder);
    ElementValueBlock1Green? block = null;
    if (context.e_Block is not null) block = (ElementValueBlock1Green?)this.Visit(context.e_Block) ?? ElementValueBlock1Green.__Missing;
    else block = ElementValueBlock1Green.__Missing;
    InternalSyntaxToken? multiplicity = null;
    if (context.LR_TQuestion() is not null) multiplicity = (InternalSyntaxToken?)this.VisitTerminal(context.LR_TQuestion());
    if (context.LR_TAsterisk() is not null) multiplicity = (InternalSyntaxToken?)this.VisitTerminal(context.LR_TAsterisk());
    if (context.LR_TPlus() is not null) multiplicity = (InternalSyntaxToken?)this.VisitTerminal(context.LR_TPlus());
    if (context.LR_TQuestionQuestion() is not null) multiplicity = (InternalSyntaxToken?)this.VisitTerminal(context.LR_TQuestionQuestion());
    if (context.LR_TAsteriskQuestion() is not null) multiplicity = (InternalSyntaxToken?)this.VisitTerminal(context.LR_TAsteriskQuestion());
    if (context.LR_TPlusQuestion() is not null) multiplicity = (InternalSyntaxToken?)this.VisitTerminal(context.LR_TPlusQuestion());
	return _factory.ElementValue(annotations1, block, multiplicity);
}

public override GreenNode? VisitPr_BlockAlternative(CompilerParser.Pr_BlockAlternativeContext? context)
{
   	if (context == null) return BlockAlternativeGreen.__Missing;
    var e_ElementsContext = context._e_Elements;
    var elementsBuilder = _pool.Allocate<ElementGreen>();
    for (int i = 0; i < e_ElementsContext.Count; ++i)
    {
        if (e_ElementsContext[i] is not null) elementsBuilder.Add((ElementGreen?)this.Visit(e_ElementsContext[i]) ?? ElementGreen.__Missing);
        else elementsBuilder.Add(ElementGreen.__Missing);
    }
    var elements = elementsBuilder.ToList();
    _pool.Free(elementsBuilder);
    BlockAlternativeBlock1Green? block = null;
    if (context.e_Block is not null) block = (BlockAlternativeBlock1Green?)this.Visit(context.e_Block);
	return _factory.BlockAlternative(elements, block);
}

public override GreenNode? VisitPr_LAlternative(CompilerParser.Pr_LAlternativeContext? context)
{
   	if (context == null) return LAlternativeGreen.__Missing;
    var e_ElementsContext = context._e_Elements;
    var elementsBuilder = _pool.Allocate<LElementGreen>();
    for (int i = 0; i < e_ElementsContext.Count; ++i)
    {
        if (e_ElementsContext[i] is not null) elementsBuilder.Add((LElementGreen?)this.Visit(e_ElementsContext[i]) ?? LElementGreen.__Missing);
        else elementsBuilder.Add(LElementGreen.__Missing);
    }
    var elements = elementsBuilder.ToList();
    _pool.Free(elementsBuilder);
	return _factory.LAlternative(elements);
}

public override GreenNode? VisitPr_LElement(CompilerParser.Pr_LElementContext? context)
{
   	if (context == null) return LElementGreen.__Missing;
    var isNegated = (InternalSyntaxToken?)this.VisitTerminal(context.e_IsNegated);
    LElementValueGreen? value = null;
    if (context.e_Value is not null) value = (LElementValueGreen?)this.Visit(context.e_Value) ?? LElementValueGreen.__Missing;
    else value = LElementValueGreen.__Missing;
    InternalSyntaxToken? multiplicity = null;
    if (context.LR_TQuestion() is not null) multiplicity = (InternalSyntaxToken?)this.VisitTerminal(context.LR_TQuestion());
    if (context.LR_TAsterisk() is not null) multiplicity = (InternalSyntaxToken?)this.VisitTerminal(context.LR_TAsterisk());
    if (context.LR_TPlus() is not null) multiplicity = (InternalSyntaxToken?)this.VisitTerminal(context.LR_TPlus());
    if (context.LR_TQuestionQuestion() is not null) multiplicity = (InternalSyntaxToken?)this.VisitTerminal(context.LR_TQuestionQuestion());
    if (context.LR_TAsteriskQuestion() is not null) multiplicity = (InternalSyntaxToken?)this.VisitTerminal(context.LR_TAsteriskQuestion());
    if (context.LR_TPlusQuestion() is not null) multiplicity = (InternalSyntaxToken?)this.VisitTerminal(context.LR_TPlusQuestion());
	return _factory.LElement(isNegated, value, multiplicity);
}

public override GreenNode? VisitPr_LElementValueTokens(CompilerParser.Pr_LElementValueTokensContext? context)
{
   	if (context == null) return LElementValueTokensGreen.__Missing;
    InternalSyntaxToken? token = null;
    if (context.LR_TString() is not null) token = (InternalSyntaxToken?)this.VisitTerminal(context.LR_TString());
    if (context.LR_TDot() is not null) token = (InternalSyntaxToken?)this.VisitTerminal(context.LR_TDot());
    if (token is null) token = _factory.None;
	return _factory.LElementValueTokens(token);
}

public override GreenNode? VisitPr_LBlock(CompilerParser.Pr_LBlockContext? context)
{
   	if (context == null) return LBlockGreen.__Missing;
    var tLParen = (InternalSyntaxToken?)this.VisitTerminal(context.e_TLParen, CompilerSyntaxKind.TLParen);
    var alternativesBuilder = _pool.AllocateSeparated<LAlternativeGreen>(reversed: false);
    var e_Alternatives1Context = context.e_Alternatives1;
    if (e_Alternatives1Context is not null) alternativesBuilder.Add((LAlternativeGreen?)this.Visit(e_Alternatives1Context) ?? LAlternativeGreen.__Missing);
    else alternativesBuilder.Add(LAlternativeGreen.__Missing);
    var e_Alternatives2Context = context._e_Alternatives2;
    var e_TBar1Context = context._e_TBar1;
    for (int i = 0; i < e_Alternatives2Context.Count; ++i)
    {
        if (i < e_TBar1Context.Count)
        {
            var _separator = e_TBar1Context[i];
            alternativesBuilder.AddSeparator((InternalSyntaxToken?)this.VisitTerminal(_separator, CompilerSyntaxKind.TBar));
        }
        else
        {
            alternativesBuilder.AddSeparator((InternalSyntaxToken?)this.VisitTerminal((IToken?)null, CompilerSyntaxKind.TBar));
        }
        var _item = e_Alternatives2Context[i];
        if (_item is not null) alternativesBuilder.Add((LAlternativeGreen?)this.Visit(_item) ?? LAlternativeGreen.__Missing);
        else alternativesBuilder.Add(LAlternativeGreen.__Missing);
    }
    var alternatives = alternativesBuilder.ToList();
    _pool.Free(alternativesBuilder);
    var tRParen = (InternalSyntaxToken?)this.VisitTerminal(context.e_TRParen, CompilerSyntaxKind.TRParen);
	return _factory.LBlock(tLParen, alternatives, tRParen);
}

public override GreenNode? VisitPr_LRange(CompilerParser.Pr_LRangeContext? context)
{
   	if (context == null) return LRangeGreen.__Missing;
    var startChar = (InternalSyntaxToken?)this.VisitTerminal(context.e_StartChar, CompilerSyntaxKind.TString);
    var tDotDot = (InternalSyntaxToken?)this.VisitTerminal(context.e_TDotDot, CompilerSyntaxKind.TDotDot);
    var endChar = (InternalSyntaxToken?)this.VisitTerminal(context.e_EndChar, CompilerSyntaxKind.TString);
	return _factory.LRange(startChar, tDotDot, endChar);
}

public override GreenNode? VisitPr_LReference(CompilerParser.Pr_LReferenceContext? context)
{
   	if (context == null) return LReferenceGreen.__Missing;
    IdentifierGreen? rule = null;
    if (context.e_Rule is not null) rule = (IdentifierGreen?)this.Visit(context.e_Rule) ?? IdentifierGreen.__Missing;
    else rule = IdentifierGreen.__Missing;
	return _factory.LReference(rule);
}

public override GreenNode? VisitPr_ExpressionAlt1(CompilerParser.Pr_ExpressionAlt1Context? context)
{
   	if (context == null) return ExpressionAlt1Green.__Missing;
    SingleExpressionGreen? singleExpression = null;
    if (context.e_SingleExpression is not null) singleExpression = (SingleExpressionGreen?)this.Visit(context.e_SingleExpression) ?? SingleExpressionGreen.__Missing;
    else singleExpression = SingleExpressionGreen.__Missing;
	return _factory.ExpressionAlt1(singleExpression);
}

public override GreenNode? VisitPr_ArrayExpression(CompilerParser.Pr_ArrayExpressionContext? context)
{
   	if (context == null) return ArrayExpressionGreen.__Missing;
    var tLBrace = (InternalSyntaxToken?)this.VisitTerminal(context.e_TLBrace, CompilerSyntaxKind.TLBrace);
    var itemsBuilder = _pool.AllocateSeparated<SingleExpressionGreen>(reversed: false);
    var e_Items1Context = context.e_Items1;
    if (e_Items1Context is not null) itemsBuilder.Add((SingleExpressionGreen?)this.Visit(e_Items1Context) ?? SingleExpressionGreen.__Missing);
    else itemsBuilder.Add(SingleExpressionGreen.__Missing);
    var e_Items2Context = context._e_Items2;
    var e_TComma1Context = context._e_TComma1;
    for (int i = 0; i < e_Items2Context.Count; ++i)
    {
        if (i < e_TComma1Context.Count)
        {
            var _separator = e_TComma1Context[i];
            itemsBuilder.AddSeparator((InternalSyntaxToken?)this.VisitTerminal(_separator, CompilerSyntaxKind.TComma));
        }
        else
        {
            itemsBuilder.AddSeparator((InternalSyntaxToken?)this.VisitTerminal((IToken?)null, CompilerSyntaxKind.TComma));
        }
        var _item = e_Items2Context[i];
        if (_item is not null) itemsBuilder.Add((SingleExpressionGreen?)this.Visit(_item) ?? SingleExpressionGreen.__Missing);
        else itemsBuilder.Add(SingleExpressionGreen.__Missing);
    }
    var items = itemsBuilder.ToList();
    _pool.Free(itemsBuilder);
    var tRBrace = (InternalSyntaxToken?)this.VisitTerminal(context.e_TRBrace, CompilerSyntaxKind.TRBrace);
	return _factory.ArrayExpression(tLBrace, items, tRBrace);
}

public override GreenNode? VisitPr_SingleExpression(CompilerParser.Pr_SingleExpressionContext? context)
{
   	if (context == null) return SingleExpressionGreen.__Missing;
    SingleExpressionBlock1Green? value = null;
    if (context.e_Value is not null) value = (SingleExpressionBlock1Green?)this.Visit(context.e_Value) ?? SingleExpressionBlock1Green.__Missing;
    else value = SingleExpressionBlock1Green.__Missing;
	return _factory.SingleExpression(value);
}

public override GreenNode? VisitPr_ParserAnnotation(CompilerParser.Pr_ParserAnnotationContext? context)
{
   	if (context == null) return ParserAnnotationGreen.__Missing;
    var tLBracket = (InternalSyntaxToken?)this.VisitTerminal(context.e_TLBracket, CompilerSyntaxKind.TLBracket);
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
            qualifierBuilder.AddSeparator((InternalSyntaxToken?)this.VisitTerminal(_separator, CompilerSyntaxKind.TDot));
        }
        else
        {
            qualifierBuilder.AddSeparator((InternalSyntaxToken?)this.VisitTerminal((IToken?)null, CompilerSyntaxKind.TDot));
        }
        var _item = e_Identifier2Context[i];
        if (_item is not null) qualifierBuilder.Add((IdentifierGreen?)this.Visit(_item) ?? IdentifierGreen.__Missing);
        else qualifierBuilder.Add(IdentifierGreen.__Missing);
    }
    var qualifier = qualifierBuilder.ToList();
    _pool.Free(qualifierBuilder);
    ParserAnnotationBlock1Green? block = null;
    if (context.e_Block is not null) block = (ParserAnnotationBlock1Green?)this.Visit(context.e_Block);
    var tRBracket = (InternalSyntaxToken?)this.VisitTerminal(context.e_TRBracket, CompilerSyntaxKind.TRBracket);
	return _factory.ParserAnnotation(tLBracket, qualifier, block, tRBracket);
}

public override GreenNode? VisitPr_LexerAnnotation(CompilerParser.Pr_LexerAnnotationContext? context)
{
   	if (context == null) return LexerAnnotationGreen.__Missing;
    var tLBracket = (InternalSyntaxToken?)this.VisitTerminal(context.e_TLBracket, CompilerSyntaxKind.TLBracket);
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
            qualifierBuilder.AddSeparator((InternalSyntaxToken?)this.VisitTerminal(_separator, CompilerSyntaxKind.TDot));
        }
        else
        {
            qualifierBuilder.AddSeparator((InternalSyntaxToken?)this.VisitTerminal((IToken?)null, CompilerSyntaxKind.TDot));
        }
        var _item = e_Identifier2Context[i];
        if (_item is not null) qualifierBuilder.Add((IdentifierGreen?)this.Visit(_item) ?? IdentifierGreen.__Missing);
        else qualifierBuilder.Add(IdentifierGreen.__Missing);
    }
    var qualifier = qualifierBuilder.ToList();
    _pool.Free(qualifierBuilder);
    LexerAnnotationBlock1Green? block = null;
    if (context.e_Block is not null) block = (LexerAnnotationBlock1Green?)this.Visit(context.e_Block);
    var tRBracket = (InternalSyntaxToken?)this.VisitTerminal(context.e_TRBracket, CompilerSyntaxKind.TRBracket);
	return _factory.LexerAnnotation(tLBracket, qualifier, block, tRBracket);
}

public override GreenNode? VisitPr_AnnotationArgument(CompilerParser.Pr_AnnotationArgumentContext? context)
{
   	if (context == null) return AnnotationArgumentGreen.__Missing;
    AnnotationArgumentBlock1Green? block = null;
    if (context.e_Block is not null) block = (AnnotationArgumentBlock1Green?)this.Visit(context.e_Block);
    ExpressionGreen? value = null;
    if (context.e_Value is not null) value = (ExpressionGreen?)this.Visit(context.e_Value) ?? ExpressionGreen.__Missing;
    else value = ExpressionGreen.__Missing;
	return _factory.AnnotationArgument(block, value);
}

public override GreenNode? VisitPr_TypeReferenceIdentifierAlt1(CompilerParser.Pr_TypeReferenceIdentifierAlt1Context? context)
{
   	if (context == null) return TypeReferenceIdentifierAlt1Green.__Missing;
    InternalSyntaxToken? tokens = null;
    if (context.LR_KBool() is not null) tokens = (InternalSyntaxToken?)this.VisitTerminal(context.LR_KBool());
    if (context.LR_KInt() is not null) tokens = (InternalSyntaxToken?)this.VisitTerminal(context.LR_KInt());
    if (context.LR_KDouble() is not null) tokens = (InternalSyntaxToken?)this.VisitTerminal(context.LR_KDouble());
    if (context.LR_KString() is not null) tokens = (InternalSyntaxToken?)this.VisitTerminal(context.LR_KString());
    if (context.LR_KType() is not null) tokens = (InternalSyntaxToken?)this.VisitTerminal(context.LR_KType());
    if (context.LR_KSymbol() is not null) tokens = (InternalSyntaxToken?)this.VisitTerminal(context.LR_KSymbol());
    if (context.LR_KObject() is not null) tokens = (InternalSyntaxToken?)this.VisitTerminal(context.LR_KObject());
    if (context.LR_KVoid() is not null) tokens = (InternalSyntaxToken?)this.VisitTerminal(context.LR_KVoid());
    if (tokens is null) tokens = _factory.None;
	return _factory.TypeReferenceIdentifierAlt1(tokens);
}

public override GreenNode? VisitPr_TypeReferenceIdentifierAlt2(CompilerParser.Pr_TypeReferenceIdentifierAlt2Context? context)
{
   	if (context == null) return TypeReferenceIdentifierAlt2Green.__Missing;
    IdentifierGreen? identifier = null;
    if (context.e_Identifier is not null) identifier = (IdentifierGreen?)this.Visit(context.e_Identifier) ?? IdentifierGreen.__Missing;
    else identifier = IdentifierGreen.__Missing;
	return _factory.TypeReferenceIdentifierAlt2(identifier);
}

public override GreenNode? VisitPr_TypeReferenceAlt1(CompilerParser.Pr_TypeReferenceAlt1Context? context)
{
   	if (context == null) return TypeReferenceAlt1Green.__Missing;
    InternalSyntaxToken? tokens = null;
    if (context.LR_KBool() is not null) tokens = (InternalSyntaxToken?)this.VisitTerminal(context.LR_KBool());
    if (context.LR_KInt() is not null) tokens = (InternalSyntaxToken?)this.VisitTerminal(context.LR_KInt());
    if (context.LR_KDouble() is not null) tokens = (InternalSyntaxToken?)this.VisitTerminal(context.LR_KDouble());
    if (context.LR_KString() is not null) tokens = (InternalSyntaxToken?)this.VisitTerminal(context.LR_KString());
    if (context.LR_KType() is not null) tokens = (InternalSyntaxToken?)this.VisitTerminal(context.LR_KType());
    if (context.LR_KSymbol() is not null) tokens = (InternalSyntaxToken?)this.VisitTerminal(context.LR_KSymbol());
    if (context.LR_KObject() is not null) tokens = (InternalSyntaxToken?)this.VisitTerminal(context.LR_KObject());
    if (context.LR_KVoid() is not null) tokens = (InternalSyntaxToken?)this.VisitTerminal(context.LR_KVoid());
    if (tokens is null) tokens = _factory.None;
	return _factory.TypeReferenceAlt1(tokens);
}

public override GreenNode? VisitPr_TypeReferenceAlt2(CompilerParser.Pr_TypeReferenceAlt2Context? context)
{
   	if (context == null) return TypeReferenceAlt2Green.__Missing;
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
            qualifierBuilder.AddSeparator((InternalSyntaxToken?)this.VisitTerminal(_separator, CompilerSyntaxKind.TDot));
        }
        else
        {
            qualifierBuilder.AddSeparator((InternalSyntaxToken?)this.VisitTerminal((IToken?)null, CompilerSyntaxKind.TDot));
        }
        var _item = e_Identifier2Context[i];
        if (_item is not null) qualifierBuilder.Add((IdentifierGreen?)this.Visit(_item) ?? IdentifierGreen.__Missing);
        else qualifierBuilder.Add(IdentifierGreen.__Missing);
    }
    var qualifier = qualifierBuilder.ToList();
    _pool.Free(qualifierBuilder);
	return _factory.TypeReferenceAlt2(qualifier);
}

public override GreenNode? VisitPr_Name(CompilerParser.Pr_NameContext? context)
{
   	if (context == null) return NameGreen.__Missing;
    IdentifierGreen? identifier = null;
    if (context.e_Identifier is not null) identifier = (IdentifierGreen?)this.Visit(context.e_Identifier) ?? IdentifierGreen.__Missing;
    else identifier = IdentifierGreen.__Missing;
	return _factory.Name(identifier);
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
    LanguageDeclarationGreen? declarations = null;
    if (context.e_Declarations is not null) declarations = (LanguageDeclarationGreen?)this.Visit(context.e_Declarations) ?? LanguageDeclarationGreen.__Missing;
    else declarations = LanguageDeclarationGreen.__Missing;
	return _factory.MainBlock1(declarations);
}

public override GreenNode? VisitPr_RuleBlock1Alt1(CompilerParser.Pr_RuleBlock1Alt1Context? context)
{
   	if (context == null) return RuleBlock1Alt1Green.__Missing;
    TypeReferenceIdentifierGreen? returnType = null;
    if (context.e_ReturnType is not null) returnType = (TypeReferenceIdentifierGreen?)this.Visit(context.e_ReturnType) ?? TypeReferenceIdentifierGreen.__Missing;
    else returnType = TypeReferenceIdentifierGreen.__Missing;
	return _factory.RuleBlock1Alt1(returnType);
}

public override GreenNode? VisitPr_RuleBlock1Alt2(CompilerParser.Pr_RuleBlock1Alt2Context? context)
{
   	if (context == null) return RuleBlock1Alt2Green.__Missing;
    IdentifierGreen? identifier = null;
    if (context.e_Identifier is not null) identifier = (IdentifierGreen?)this.Visit(context.e_Identifier) ?? IdentifierGreen.__Missing;
    else identifier = IdentifierGreen.__Missing;
    var kReturns = (InternalSyntaxToken?)this.VisitTerminal(context.e_KReturns, CompilerSyntaxKind.KReturns);
    TypeReferenceGreen? returnType = null;
    if (context.e_ReturnType1 is not null) returnType = (TypeReferenceGreen?)this.Visit(context.e_ReturnType1) ?? TypeReferenceGreen.__Missing;
    else returnType = TypeReferenceGreen.__Missing;
	return _factory.RuleBlock1Alt2(identifier, kReturns, returnType);
}

public override GreenNode? VisitPr_RuleAlternativesBlock(CompilerParser.Pr_RuleAlternativesBlockContext? context)
{
   	if (context == null) return RuleAlternativesBlockGreen.__Missing;
    var tBar = (InternalSyntaxToken?)this.VisitTerminal(context.e_TBar1, CompilerSyntaxKind.TBar);
    AlternativeGreen? alternatives = null;
    if (context.e_Alternatives2 is not null) alternatives = (AlternativeGreen?)this.Visit(context.e_Alternatives2) ?? AlternativeGreen.__Missing;
    else alternatives = AlternativeGreen.__Missing;
	return _factory.RuleAlternativesBlock(tBar, alternatives);
}

public override GreenNode? VisitPr_AlternativeBlock1(CompilerParser.Pr_AlternativeBlock1Context? context)
{
   	if (context == null) return AlternativeBlock1Green.__Missing;
    var e_AnnotationsContext = context._e_Annotations;
    var annotations1Builder = _pool.Allocate<ParserAnnotationGreen>();
    for (int i = 0; i < e_AnnotationsContext.Count; ++i)
    {
        if (e_AnnotationsContext[i] is not null) annotations1Builder.Add((ParserAnnotationGreen?)this.Visit(e_AnnotationsContext[i]) ?? ParserAnnotationGreen.__Missing);
        else annotations1Builder.Add(ParserAnnotationGreen.__Missing);
    }
    var annotations1 = annotations1Builder.ToList();
    _pool.Free(annotations1Builder);
    var kAlt = (InternalSyntaxToken?)this.VisitTerminal(context.e_KAlt, CompilerSyntaxKind.KAlt);
    NameGreen? name = null;
    if (context.e_Name is not null) name = (NameGreen?)this.Visit(context.e_Name) ?? NameGreen.__Missing;
    else name = NameGreen.__Missing;
    AlternativeBlock1Block1Green? block = null;
    if (context.e_Block is not null) block = (AlternativeBlock1Block1Green?)this.Visit(context.e_Block);
    var tColon = (InternalSyntaxToken?)this.VisitTerminal(context.e_TColon, CompilerSyntaxKind.TColon);
	return _factory.AlternativeBlock1(annotations1, kAlt, name, block, tColon);
}

public override GreenNode? VisitPr_AlternativeBlock2(CompilerParser.Pr_AlternativeBlock2Context? context)
{
   	if (context == null) return AlternativeBlock2Green.__Missing;
    var tEqGt = (InternalSyntaxToken?)this.VisitTerminal(context.e_TEqGt, CompilerSyntaxKind.TEqGt);
    ExpressionGreen? returnValue = null;
    if (context.e_ReturnValue is not null) returnValue = (ExpressionGreen?)this.Visit(context.e_ReturnValue) ?? ExpressionGreen.__Missing;
    else returnValue = ExpressionGreen.__Missing;
	return _factory.AlternativeBlock2(tEqGt, returnValue);
}

public override GreenNode? VisitPr_ElementBlock1(CompilerParser.Pr_ElementBlock1Context? context)
{
   	if (context == null) return ElementBlock1Green.__Missing;
    var e_AnnotationsContext = context._e_Annotations;
    var annotations1Builder = _pool.Allocate<ParserAnnotationGreen>();
    for (int i = 0; i < e_AnnotationsContext.Count; ++i)
    {
        if (e_AnnotationsContext[i] is not null) annotations1Builder.Add((ParserAnnotationGreen?)this.Visit(e_AnnotationsContext[i]) ?? ParserAnnotationGreen.__Missing);
        else annotations1Builder.Add(ParserAnnotationGreen.__Missing);
    }
    var annotations1 = annotations1Builder.ToList();
    _pool.Free(annotations1Builder);
    NameGreen? name = null;
    if (context.e_Name is not null) name = (NameGreen?)this.Visit(context.e_Name) ?? NameGreen.__Missing;
    else name = NameGreen.__Missing;
    InternalSyntaxToken? assignment = null;
    if (context.LR_TEq() is not null) assignment = (InternalSyntaxToken?)this.VisitTerminal(context.LR_TEq());
    if (context.LR_TQuestionEq() is not null) assignment = (InternalSyntaxToken?)this.VisitTerminal(context.LR_TQuestionEq());
    if (context.LR_TExclEq() is not null) assignment = (InternalSyntaxToken?)this.VisitTerminal(context.LR_TExclEq());
    if (context.LR_TPlusEq() is not null) assignment = (InternalSyntaxToken?)this.VisitTerminal(context.LR_TPlusEq());
    if (assignment is null) assignment = _factory.None;
	return _factory.ElementBlock1(annotations1, name, assignment);
}

public override GreenNode? VisitPr_Tokens(CompilerParser.Pr_TokensContext? context)
{
   	if (context == null) return TokensGreen.__Missing;
    InternalSyntaxToken? token = null;
    if (context.LR_KEof() is not null) token = (InternalSyntaxToken?)this.VisitTerminal(context.LR_KEof());
    if (context.LR_TString() is not null) token = (InternalSyntaxToken?)this.VisitTerminal(context.LR_TString());
    if (token is null) token = _factory.None;
	return _factory.Tokens(token);
}

public override GreenNode? VisitPr_Block(CompilerParser.Pr_BlockContext? context)
{
   	if (context == null) return BlockGreen.__Missing;
    var tLParen = (InternalSyntaxToken?)this.VisitTerminal(context.e_TLParen, CompilerSyntaxKind.TLParen);
    var alternativesBuilder = _pool.AllocateSeparated<BlockAlternativeGreen>(reversed: false);
    var e_Alternatives1Context = context.e_Alternatives1;
    if (e_Alternatives1Context is not null) alternativesBuilder.Add((BlockAlternativeGreen?)this.Visit(e_Alternatives1Context) ?? BlockAlternativeGreen.__Missing);
    else alternativesBuilder.Add(BlockAlternativeGreen.__Missing);
    var e_Alternatives2Context = context._e_Alternatives2;
    var e_TBar1Context = context._e_TBar1;
    for (int i = 0; i < e_Alternatives2Context.Count; ++i)
    {
        if (i < e_TBar1Context.Count)
        {
            var _separator = e_TBar1Context[i];
            alternativesBuilder.AddSeparator((InternalSyntaxToken?)this.VisitTerminal(_separator, CompilerSyntaxKind.TBar));
        }
        else
        {
            alternativesBuilder.AddSeparator((InternalSyntaxToken?)this.VisitTerminal((IToken?)null, CompilerSyntaxKind.TBar));
        }
        var _item = e_Alternatives2Context[i];
        if (_item is not null) alternativesBuilder.Add((BlockAlternativeGreen?)this.Visit(_item) ?? BlockAlternativeGreen.__Missing);
        else alternativesBuilder.Add(BlockAlternativeGreen.__Missing);
    }
    var alternatives = alternativesBuilder.ToList();
    _pool.Free(alternativesBuilder);
    var tRParen = (InternalSyntaxToken?)this.VisitTerminal(context.e_TRParen, CompilerSyntaxKind.TRParen);
	return _factory.Block(tLParen, alternatives, tRParen);
}

public override GreenNode? VisitPr_RuleRefAlt1(CompilerParser.Pr_RuleRefAlt1Context? context)
{
   	if (context == null) return RuleRefAlt1Green.__Missing;
    IdentifierGreen? grammarRule = null;
    if (context.e_GrammarRule is not null) grammarRule = (IdentifierGreen?)this.Visit(context.e_GrammarRule) ?? IdentifierGreen.__Missing;
    else grammarRule = IdentifierGreen.__Missing;
	return _factory.RuleRefAlt1(grammarRule);
}

public override GreenNode? VisitPr_RuleRefAlt2(CompilerParser.Pr_RuleRefAlt2Context? context)
{
   	if (context == null) return RuleRefAlt2Green.__Missing;
    var tHash = (InternalSyntaxToken?)this.VisitTerminal(context.e_THash, CompilerSyntaxKind.THash);
    TypeReferenceGreen? referencedTypes = null;
    if (context.e_ReferencedTypes is not null) referencedTypes = (TypeReferenceGreen?)this.Visit(context.e_ReferencedTypes) ?? TypeReferenceGreen.__Missing;
    else referencedTypes = TypeReferenceGreen.__Missing;
	return _factory.RuleRefAlt2(tHash, referencedTypes);
}

public override GreenNode? VisitPr_RuleRefAlt3(CompilerParser.Pr_RuleRefAlt3Context? context)
{
   	if (context == null) return RuleRefAlt3Green.__Missing;
    var tHashLBrace = (InternalSyntaxToken?)this.VisitTerminal(context.e_THashLBrace, CompilerSyntaxKind.THashLBrace);
    var referencedTypesBuilder = _pool.AllocateSeparated<TypeReferenceGreen>(reversed: false);
    var e_ReferencedTypes1Context = context.e_ReferencedTypes1;
    if (e_ReferencedTypes1Context is not null) referencedTypesBuilder.Add((TypeReferenceGreen?)this.Visit(e_ReferencedTypes1Context) ?? TypeReferenceGreen.__Missing);
    else referencedTypesBuilder.Add(TypeReferenceGreen.__Missing);
    var e_ReferencedTypes2Context = context._e_ReferencedTypes2;
    var e_TComma1Context = context._e_TComma1;
    for (int i = 0; i < e_ReferencedTypes2Context.Count; ++i)
    {
        if (i < e_TComma1Context.Count)
        {
            var _separator = e_TComma1Context[i];
            referencedTypesBuilder.AddSeparator((InternalSyntaxToken?)this.VisitTerminal(_separator, CompilerSyntaxKind.TComma));
        }
        else
        {
            referencedTypesBuilder.AddSeparator((InternalSyntaxToken?)this.VisitTerminal((IToken?)null, CompilerSyntaxKind.TComma));
        }
        var _item = e_ReferencedTypes2Context[i];
        if (_item is not null) referencedTypesBuilder.Add((TypeReferenceGreen?)this.Visit(_item) ?? TypeReferenceGreen.__Missing);
        else referencedTypesBuilder.Add(TypeReferenceGreen.__Missing);
    }
    var referencedTypes = referencedTypesBuilder.ToList();
    _pool.Free(referencedTypesBuilder);
    RuleRefAlt3Block1Green? block = null;
    if (context.e_Block is not null) block = (RuleRefAlt3Block1Green?)this.Visit(context.e_Block);
    var tRBrace = (InternalSyntaxToken?)this.VisitTerminal(context.e_TRBrace, CompilerSyntaxKind.TRBrace);
	return _factory.RuleRefAlt3(tHashLBrace, referencedTypes, block, tRBrace);
}

public override GreenNode? VisitPr_BlockAlternativesBlock1(CompilerParser.Pr_BlockAlternativesBlock1Context? context)
{
   	if (context == null) return BlockAlternativesBlockGreen.__Missing;
    var tBar = (InternalSyntaxToken?)this.VisitTerminal(context.e_TBar1, CompilerSyntaxKind.TBar);
    BlockAlternativeGreen? alternatives = null;
    if (context.e_Alternatives2 is not null) alternatives = (BlockAlternativeGreen?)this.Visit(context.e_Alternatives2) ?? BlockAlternativeGreen.__Missing;
    else alternatives = BlockAlternativeGreen.__Missing;
	return _factory.BlockAlternativesBlock(tBar, alternatives);
}

public override GreenNode? VisitPr_BlockAlternativeBlock1(CompilerParser.Pr_BlockAlternativeBlock1Context? context)
{
   	if (context == null) return BlockAlternativeBlock1Green.__Missing;
    var tEqGt = (InternalSyntaxToken?)this.VisitTerminal(context.e_TEqGt, CompilerSyntaxKind.TEqGt);
    ExpressionGreen? returnValue = null;
    if (context.e_ReturnValue is not null) returnValue = (ExpressionGreen?)this.Visit(context.e_ReturnValue) ?? ExpressionGreen.__Missing;
    else returnValue = ExpressionGreen.__Missing;
	return _factory.BlockAlternativeBlock1(tEqGt, returnValue);
}

public override GreenNode? VisitPr_RuleRefAlt3ReferencedTypesBlock1(CompilerParser.Pr_RuleRefAlt3ReferencedTypesBlock1Context? context)
{
   	if (context == null) return RuleRefAlt3ReferencedTypesBlockGreen.__Missing;
    var tComma = (InternalSyntaxToken?)this.VisitTerminal(context.e_TComma1, CompilerSyntaxKind.TComma);
    TypeReferenceGreen? referencedTypes = null;
    if (context.e_ReferencedTypes2 is not null) referencedTypes = (TypeReferenceGreen?)this.Visit(context.e_ReferencedTypes2) ?? TypeReferenceGreen.__Missing;
    else referencedTypes = TypeReferenceGreen.__Missing;
	return _factory.RuleRefAlt3ReferencedTypesBlock(tComma, referencedTypes);
}

public override GreenNode? VisitPr_RuleRefAlt3Block1(CompilerParser.Pr_RuleRefAlt3Block1Context? context)
{
   	if (context == null) return RuleRefAlt3Block1Green.__Missing;
    var tBar = (InternalSyntaxToken?)this.VisitTerminal(context.e_TBar, CompilerSyntaxKind.TBar);
    IdentifierGreen? grammarRule = null;
    if (context.e_GrammarRule is not null) grammarRule = (IdentifierGreen?)this.Visit(context.e_GrammarRule) ?? IdentifierGreen.__Missing;
    else grammarRule = IdentifierGreen.__Missing;
	return _factory.RuleRefAlt3Block1(tBar, grammarRule);
}

public override GreenNode? VisitPr_TokenBlock1Alt1(CompilerParser.Pr_TokenBlock1Alt1Context? context)
{
   	if (context == null) return TokenBlock1Alt1Green.__Missing;
    var kToken = (InternalSyntaxToken?)this.VisitTerminal(context.e_KToken, CompilerSyntaxKind.KToken);
    NameGreen? name = null;
    if (context.e_Name is not null) name = (NameGreen?)this.Visit(context.e_Name) ?? NameGreen.__Missing;
    else name = NameGreen.__Missing;
    TokenBlock1Alt1Block1Green? block = null;
    if (context.e_Block is not null) block = (TokenBlock1Alt1Block1Green?)this.Visit(context.e_Block);
	return _factory.TokenBlock1Alt1(kToken, name, block);
}

public override GreenNode? VisitPr_TokenBlock1Alt2(CompilerParser.Pr_TokenBlock1Alt2Context? context)
{
   	if (context == null) return TokenBlock1Alt2Green.__Missing;
    var isTrivia = (InternalSyntaxToken?)this.VisitTerminal(context.e_IsTrivia, CompilerSyntaxKind.KHidden);
    NameGreen? name = null;
    if (context.e_Name1 is not null) name = (NameGreen?)this.Visit(context.e_Name1) ?? NameGreen.__Missing;
    else name = NameGreen.__Missing;
	return _factory.TokenBlock1Alt2(isTrivia, name);
}

public override GreenNode? VisitPr_TokenAlternativesBlock(CompilerParser.Pr_TokenAlternativesBlockContext? context)
{
   	if (context == null) return TokenAlternativesBlockGreen.__Missing;
    var tBar = (InternalSyntaxToken?)this.VisitTerminal(context.e_TBar2, CompilerSyntaxKind.TBar);
    LAlternativeGreen? alternatives = null;
    if (context.e_Alternatives4 is not null) alternatives = (LAlternativeGreen?)this.Visit(context.e_Alternatives4) ?? LAlternativeGreen.__Missing;
    else alternatives = LAlternativeGreen.__Missing;
	return _factory.TokenAlternativesBlock(tBar, alternatives);
}

public override GreenNode? VisitPr_FragmentAlternativesBlock(CompilerParser.Pr_FragmentAlternativesBlockContext? context)
{
   	if (context == null) return FragmentAlternativesBlockGreen.__Missing;
    var tBar = (InternalSyntaxToken?)this.VisitTerminal(context.e_TBar3, CompilerSyntaxKind.TBar);
    LAlternativeGreen? alternatives = null;
    if (context.e_Alternatives6 is not null) alternatives = (LAlternativeGreen?)this.Visit(context.e_Alternatives6) ?? LAlternativeGreen.__Missing;
    else alternatives = LAlternativeGreen.__Missing;
	return _factory.FragmentAlternativesBlock(tBar, alternatives);
}

public override GreenNode? VisitPr_LBlockAlternativesBlock(CompilerParser.Pr_LBlockAlternativesBlockContext? context)
{
   	if (context == null) return LBlockAlternativesBlockGreen.__Missing;
    var tBar = (InternalSyntaxToken?)this.VisitTerminal(context.e_TBar1, CompilerSyntaxKind.TBar);
    LAlternativeGreen? alternatives = null;
    if (context.e_Alternatives2 is not null) alternatives = (LAlternativeGreen?)this.Visit(context.e_Alternatives2) ?? LAlternativeGreen.__Missing;
    else alternatives = LAlternativeGreen.__Missing;
	return _factory.LBlockAlternativesBlock(tBar, alternatives);
}

public override GreenNode? VisitPr_Tokens1(CompilerParser.Pr_Tokens1Context? context)
{
   	if (context == null) return Tokens1Green.__Missing;
    InternalSyntaxToken? token = null;
    if (context.LR_KNull() is not null) token = (InternalSyntaxToken?)this.VisitTerminal(context.LR_KNull());
    if (context.LR_KTrue() is not null) token = (InternalSyntaxToken?)this.VisitTerminal(context.LR_KTrue());
    if (context.LR_KFalse() is not null) token = (InternalSyntaxToken?)this.VisitTerminal(context.LR_KFalse());
    if (context.LR_TString() is not null) token = (InternalSyntaxToken?)this.VisitTerminal(context.LR_TString());
    if (context.LR_TInteger() is not null) token = (InternalSyntaxToken?)this.VisitTerminal(context.LR_TInteger());
    if (context.LR_TDecimal() is not null) token = (InternalSyntaxToken?)this.VisitTerminal(context.LR_TDecimal());
    if (token is null) token = _factory.None;
	return _factory.Tokens1(token);
}

public override GreenNode? VisitPr_SingleExpressionBlock1Alt2(CompilerParser.Pr_SingleExpressionBlock1Alt2Context? context)
{
   	if (context == null) return SingleExpressionBlock1Alt2Green.__Missing;
    InternalSyntaxToken? tokens = null;
    if (context.LR_KBool() is not null) tokens = (InternalSyntaxToken?)this.VisitTerminal(context.LR_KBool());
    if (context.LR_KInt() is not null) tokens = (InternalSyntaxToken?)this.VisitTerminal(context.LR_KInt());
    if (context.LR_KDouble() is not null) tokens = (InternalSyntaxToken?)this.VisitTerminal(context.LR_KDouble());
    if (context.LR_KString() is not null) tokens = (InternalSyntaxToken?)this.VisitTerminal(context.LR_KString());
    if (context.LR_KType() is not null) tokens = (InternalSyntaxToken?)this.VisitTerminal(context.LR_KType());
    if (context.LR_KSymbol() is not null) tokens = (InternalSyntaxToken?)this.VisitTerminal(context.LR_KSymbol());
    if (context.LR_KObject() is not null) tokens = (InternalSyntaxToken?)this.VisitTerminal(context.LR_KObject());
    if (context.LR_KVoid() is not null) tokens = (InternalSyntaxToken?)this.VisitTerminal(context.LR_KVoid());
    if (tokens is null) tokens = _factory.None;
	return _factory.SingleExpressionBlock1Alt2(tokens);
}

public override GreenNode? VisitPr_SingleExpressionBlock1Alt3(CompilerParser.Pr_SingleExpressionBlock1Alt3Context? context)
{
   	if (context == null) return SingleExpressionBlock1Alt3Green.__Missing;
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
            qualifierBuilder.AddSeparator((InternalSyntaxToken?)this.VisitTerminal(_separator, CompilerSyntaxKind.TDot));
        }
        else
        {
            qualifierBuilder.AddSeparator((InternalSyntaxToken?)this.VisitTerminal((IToken?)null, CompilerSyntaxKind.TDot));
        }
        var _item = e_Identifier2Context[i];
        if (_item is not null) qualifierBuilder.Add((IdentifierGreen?)this.Visit(_item) ?? IdentifierGreen.__Missing);
        else qualifierBuilder.Add(IdentifierGreen.__Missing);
    }
    var qualifier = qualifierBuilder.ToList();
    _pool.Free(qualifierBuilder);
	return _factory.SingleExpressionBlock1Alt3(qualifier);
}

public override GreenNode? VisitPr_ParserAnnotationBlock1(CompilerParser.Pr_ParserAnnotationBlock1Context? context)
{
   	if (context == null) return ParserAnnotationBlock1Green.__Missing;
    var tLParen = (InternalSyntaxToken?)this.VisitTerminal(context.e_TLParen, CompilerSyntaxKind.TLParen);
    var argumentsBuilder = _pool.AllocateSeparated<AnnotationArgumentGreen>(reversed: false);
    var e_Arguments1Context = context.e_Arguments1;
    if (e_Arguments1Context is not null) argumentsBuilder.Add((AnnotationArgumentGreen?)this.Visit(e_Arguments1Context) ?? AnnotationArgumentGreen.__Missing);
    else argumentsBuilder.Add(AnnotationArgumentGreen.__Missing);
    var e_Arguments2Context = context._e_Arguments2;
    var e_TComma1Context = context._e_TComma1;
    for (int i = 0; i < e_Arguments2Context.Count; ++i)
    {
        if (i < e_TComma1Context.Count)
        {
            var _separator = e_TComma1Context[i];
            argumentsBuilder.AddSeparator((InternalSyntaxToken?)this.VisitTerminal(_separator, CompilerSyntaxKind.TComma));
        }
        else
        {
            argumentsBuilder.AddSeparator((InternalSyntaxToken?)this.VisitTerminal((IToken?)null, CompilerSyntaxKind.TComma));
        }
        var _item = e_Arguments2Context[i];
        if (_item is not null) argumentsBuilder.Add((AnnotationArgumentGreen?)this.Visit(_item) ?? AnnotationArgumentGreen.__Missing);
        else argumentsBuilder.Add(AnnotationArgumentGreen.__Missing);
    }
    var arguments = argumentsBuilder.ToList();
    _pool.Free(argumentsBuilder);
    var tRParen = (InternalSyntaxToken?)this.VisitTerminal(context.e_TRParen, CompilerSyntaxKind.TRParen);
	return _factory.ParserAnnotationBlock1(tLParen, arguments, tRParen);
}

public override GreenNode? VisitPr_LexerAnnotationBlock1(CompilerParser.Pr_LexerAnnotationBlock1Context? context)
{
   	if (context == null) return LexerAnnotationBlock1Green.__Missing;
    var tLParen = (InternalSyntaxToken?)this.VisitTerminal(context.e_TLParen, CompilerSyntaxKind.TLParen);
    var argumentsBuilder = _pool.AllocateSeparated<AnnotationArgumentGreen>(reversed: false);
    var e_Arguments1Context = context.e_Arguments1;
    if (e_Arguments1Context is not null) argumentsBuilder.Add((AnnotationArgumentGreen?)this.Visit(e_Arguments1Context) ?? AnnotationArgumentGreen.__Missing);
    else argumentsBuilder.Add(AnnotationArgumentGreen.__Missing);
    var e_Arguments2Context = context._e_Arguments2;
    var e_TComma1Context = context._e_TComma1;
    for (int i = 0; i < e_Arguments2Context.Count; ++i)
    {
        if (i < e_TComma1Context.Count)
        {
            var _separator = e_TComma1Context[i];
            argumentsBuilder.AddSeparator((InternalSyntaxToken?)this.VisitTerminal(_separator, CompilerSyntaxKind.TComma));
        }
        else
        {
            argumentsBuilder.AddSeparator((InternalSyntaxToken?)this.VisitTerminal((IToken?)null, CompilerSyntaxKind.TComma));
        }
        var _item = e_Arguments2Context[i];
        if (_item is not null) argumentsBuilder.Add((AnnotationArgumentGreen?)this.Visit(_item) ?? AnnotationArgumentGreen.__Missing);
        else argumentsBuilder.Add(AnnotationArgumentGreen.__Missing);
    }
    var arguments = argumentsBuilder.ToList();
    _pool.Free(argumentsBuilder);
    var tRParen = (InternalSyntaxToken?)this.VisitTerminal(context.e_TRParen, CompilerSyntaxKind.TRParen);
	return _factory.LexerAnnotationBlock1(tLParen, arguments, tRParen);
}

public override GreenNode? VisitPr_AnnotationArgumentBlock1(CompilerParser.Pr_AnnotationArgumentBlock1Context? context)
{
   	if (context == null) return AnnotationArgumentBlock1Green.__Missing;
    IdentifierGreen? namedParameter = null;
    if (context.e_NamedParameter is not null) namedParameter = (IdentifierGreen?)this.Visit(context.e_NamedParameter) ?? IdentifierGreen.__Missing;
    else namedParameter = IdentifierGreen.__Missing;
    var tColon = (InternalSyntaxToken?)this.VisitTerminal(context.e_TColon, CompilerSyntaxKind.TColon);
	return _factory.AnnotationArgumentBlock1(namedParameter, tColon);
}

public override GreenNode? VisitPr_MainQualifierBlock6(CompilerParser.Pr_MainQualifierBlock6Context? context)
{
   	if (context == null) return MainQualifierBlockGreen.__Missing;
    var tDot = (InternalSyntaxToken?)this.VisitTerminal(context.e_TDot1, CompilerSyntaxKind.TDot);
    IdentifierGreen? identifier = null;
    if (context.e_Identifier2 is not null) identifier = (IdentifierGreen?)this.Visit(context.e_Identifier2) ?? IdentifierGreen.__Missing;
    else identifier = IdentifierGreen.__Missing;
	return _factory.MainQualifierBlock(tDot, identifier);
}

public override GreenNode? VisitPr_AlternativeBlock1Block1(CompilerParser.Pr_AlternativeBlock1Block1Context? context)
{
   	if (context == null) return AlternativeBlock1Block1Green.__Missing;
    var kReturns = (InternalSyntaxToken?)this.VisitTerminal(context.e_KReturns, CompilerSyntaxKind.KReturns);
    TypeReferenceGreen? returnType = null;
    if (context.e_ReturnType is not null) returnType = (TypeReferenceGreen?)this.Visit(context.e_ReturnType) ?? TypeReferenceGreen.__Missing;
    else returnType = TypeReferenceGreen.__Missing;
	return _factory.AlternativeBlock1Block1(kReturns, returnType);
}

public override GreenNode? VisitPr_TokenBlock1Alt1Block1(CompilerParser.Pr_TokenBlock1Alt1Block1Context? context)
{
   	if (context == null) return TokenBlock1Alt1Block1Green.__Missing;
    var kReturns = (InternalSyntaxToken?)this.VisitTerminal(context.e_KReturns, CompilerSyntaxKind.KReturns);
    TypeReferenceGreen? returnType = null;
    if (context.e_ReturnType is not null) returnType = (TypeReferenceGreen?)this.Visit(context.e_ReturnType) ?? TypeReferenceGreen.__Missing;
    else returnType = TypeReferenceGreen.__Missing;
	return _factory.TokenBlock1Alt1Block1(kReturns, returnType);
}

public override GreenNode? VisitPr_ArrayExpressionItemsBlock(CompilerParser.Pr_ArrayExpressionItemsBlockContext? context)
{
   	if (context == null) return ArrayExpressionItemsBlockGreen.__Missing;
    var tComma = (InternalSyntaxToken?)this.VisitTerminal(context.e_TComma1, CompilerSyntaxKind.TComma);
    SingleExpressionGreen? items = null;
    if (context.e_Items2 is not null) items = (SingleExpressionGreen?)this.Visit(context.e_Items2) ?? SingleExpressionGreen.__Missing;
    else items = SingleExpressionGreen.__Missing;
	return _factory.ArrayExpressionItemsBlock(tComma, items);
}

public override GreenNode? VisitPr_ParserAnnotationBlock1ArgumentsBlock1(CompilerParser.Pr_ParserAnnotationBlock1ArgumentsBlock1Context? context)
{
   	if (context == null) return ParserAnnotationBlock1ArgumentsBlockGreen.__Missing;
    var tComma = (InternalSyntaxToken?)this.VisitTerminal(context.e_TComma1, CompilerSyntaxKind.TComma);
    AnnotationArgumentGreen? arguments = null;
    if (context.e_Arguments2 is not null) arguments = (AnnotationArgumentGreen?)this.Visit(context.e_Arguments2) ?? AnnotationArgumentGreen.__Missing;
    else arguments = AnnotationArgumentGreen.__Missing;
	return _factory.ParserAnnotationBlock1ArgumentsBlock(tComma, arguments);
}

public override GreenNode? VisitPr_LexerAnnotationBlock1ArgumentsBlock1(CompilerParser.Pr_LexerAnnotationBlock1ArgumentsBlock1Context? context)
{
   	if (context == null) return LexerAnnotationBlock1ArgumentsBlockGreen.__Missing;
    var tComma = (InternalSyntaxToken?)this.VisitTerminal(context.e_TComma1, CompilerSyntaxKind.TComma);
    AnnotationArgumentGreen? arguments = null;
    if (context.e_Arguments2 is not null) arguments = (AnnotationArgumentGreen?)this.Visit(context.e_Arguments2) ?? AnnotationArgumentGreen.__Missing;
    else arguments = AnnotationArgumentGreen.__Missing;
	return _factory.LexerAnnotationBlock1ArgumentsBlock(tComma, arguments);
}
}
}
}
