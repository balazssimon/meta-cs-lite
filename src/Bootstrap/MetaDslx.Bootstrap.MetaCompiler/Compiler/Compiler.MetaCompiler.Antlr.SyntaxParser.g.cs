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
                QualifierGreen? qualifier = null;
                if (context.qualifierAntlr1 is not null) qualifier = (QualifierGreen?)this.Visit(context.qualifierAntlr1) ?? QualifierGreen.__Missing;
                else qualifier = QualifierGreen.__Missing;
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
            	return _factory.Main((InternalSyntaxToken)kNamespace, qualifier, (InternalSyntaxToken)tSemicolon, @using, declarations, (InternalSyntaxToken)eof);
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
            	return _factory.LanguageDeclaration((InternalSyntaxToken)kLanguage, name);
            }
            public override GreenNode? VisitPr_ParserRule(CompilerParser.Pr_ParserRuleContext? context)
            {
               	if (context == null) return ParserRuleGreen.__Missing;
                NameGreen? name = null;
                if (context.nameAntlr1 is not null) name = (NameGreen?)this.Visit(context.nameAntlr1) ?? NameGreen.__Missing;
                else name = NameGreen.__Missing;
                ParserRuleBlock1Green? parserRuleBlock1 = null;
                if (context.parserRuleBlock1Antlr1 is not null) parserRuleBlock1 = (ParserRuleBlock1Green?)this.Visit(context.parserRuleBlock1Antlr1);
                var tColon = this.VisitTerminal(context.tColon, CompilerSyntaxKind.TColon);
                var parserRuleAlternativeListBuilder = _pool.AllocateSeparated<ParserRuleAlternativeGreen>(reversed: false);
                var alternativesContext = context.alternativesAntlr1;
                if (alternativesContext is not null) parserRuleAlternativeListBuilder.Add((ParserRuleAlternativeGreen?)this.Visit(alternativesContext) ?? ParserRuleAlternativeGreen.__Missing);
                else parserRuleAlternativeListBuilder.Add(ParserRuleAlternativeGreen.__Missing);
                var parserRuleAlternativeListContext = context._parserRuleBlock2Antlr1;
                for (int i = 0; i < parserRuleAlternativeListContext.Count; ++i)
                {
                    var itemContext = parserRuleAlternativeListContext[i];
                    if (itemContext is not null)
                    {
                        var item = itemContext.alternativesAntlr1;
                        var separator = itemContext.tBar;
                        parserRuleAlternativeListBuilder.AddSeparator(this.VisitTerminal(separator, CompilerSyntaxKind.TBar));
                        if (item is not null) parserRuleAlternativeListBuilder.Add((ParserRuleAlternativeGreen?)this.Visit(item) ?? ParserRuleAlternativeGreen.__Missing);
                        else parserRuleAlternativeListBuilder.Add(ParserRuleAlternativeGreen.__Missing);
                    }
                }
                var parserRuleAlternativeList = parserRuleAlternativeListBuilder.ToList();
                _pool.Free(parserRuleAlternativeListBuilder);
                var tSemicolon = this.VisitTerminal(context.tSemicolon, CompilerSyntaxKind.TSemicolon);
            	return _factory.ParserRule(name, parserRuleBlock1, (InternalSyntaxToken)tColon, parserRuleAlternativeList, (InternalSyntaxToken)tSemicolon);
            }
            public override GreenNode? VisitPr_BlockRule(CompilerParser.Pr_BlockRuleContext? context)
            {
               	if (context == null) return BlockRuleGreen.__Missing;
                var isBlock = this.VisitTerminal(context.isBlock, CompilerSyntaxKind.KBlock);
                NameGreen? name = null;
                if (context.nameAntlr1 is not null) name = (NameGreen?)this.Visit(context.nameAntlr1) ?? NameGreen.__Missing;
                else name = NameGreen.__Missing;
                var tColon = this.VisitTerminal(context.tColon, CompilerSyntaxKind.TColon);
                var parserRuleAlternativeListBuilder = _pool.AllocateSeparated<ParserRuleAlternativeGreen>(reversed: false);
                var alternativesContext = context.alternativesAntlr1;
                if (alternativesContext is not null) parserRuleAlternativeListBuilder.Add((ParserRuleAlternativeGreen?)this.Visit(alternativesContext) ?? ParserRuleAlternativeGreen.__Missing);
                else parserRuleAlternativeListBuilder.Add(ParserRuleAlternativeGreen.__Missing);
                var parserRuleAlternativeListContext = context._blockRuleBlock1Antlr1;
                for (int i = 0; i < parserRuleAlternativeListContext.Count; ++i)
                {
                    var itemContext = parserRuleAlternativeListContext[i];
                    if (itemContext is not null)
                    {
                        var item = itemContext.alternativesAntlr1;
                        var separator = itemContext.tBar;
                        parserRuleAlternativeListBuilder.AddSeparator(this.VisitTerminal(separator, CompilerSyntaxKind.TBar));
                        if (item is not null) parserRuleAlternativeListBuilder.Add((ParserRuleAlternativeGreen?)this.Visit(item) ?? ParserRuleAlternativeGreen.__Missing);
                        else parserRuleAlternativeListBuilder.Add(ParserRuleAlternativeGreen.__Missing);
                    }
                }
                var parserRuleAlternativeList = parserRuleAlternativeListBuilder.ToList();
                _pool.Free(parserRuleAlternativeListBuilder);
                var tSemicolon = this.VisitTerminal(context.tSemicolon, CompilerSyntaxKind.TSemicolon);
            	return _factory.BlockRule((InternalSyntaxToken)isBlock, name, (InternalSyntaxToken)tColon, parserRuleAlternativeList, (InternalSyntaxToken)tSemicolon);
            }
            public override GreenNode? VisitPr_ParserRuleAlternative(CompilerParser.Pr_ParserRuleAlternativeContext? context)
            {
               	if (context == null) return ParserRuleAlternativeGreen.__Missing;
                ParserRuleAlternativeBlock1Green? parserRuleAlternativeBlock1 = null;
                if (context.parserRuleAlternativeBlock1Antlr1 is not null) parserRuleAlternativeBlock1 = (ParserRuleAlternativeBlock1Green?)this.Visit(context.parserRuleAlternativeBlock1Antlr1);
                var elementsContext = context._elementsAntlr1;
                var elementsBuilder = _pool.Allocate<ParserRuleElementGreen>();
                for (int i = 0; i < elementsContext.Count; ++i)
                {
                    if (elementsContext[i] is not null) elementsBuilder.Add((ParserRuleElementGreen?)this.Visit(elementsContext[i]) ?? ParserRuleElementGreen.__Missing);
                    else elementsBuilder.Add(ParserRuleElementGreen.__Missing);
                }
                var elements = elementsBuilder.ToList();
                _pool.Free(elementsBuilder);
                ParserRuleAlternativeBlock2Green? parserRuleAlternativeBlock2 = null;
                if (context.parserRuleAlternativeBlock2Antlr1 is not null) parserRuleAlternativeBlock2 = (ParserRuleAlternativeBlock2Green?)this.Visit(context.parserRuleAlternativeBlock2Antlr1) ?? ParserRuleAlternativeBlock2Green.__Missing;
                else parserRuleAlternativeBlock2 = ParserRuleAlternativeBlock2Green.__Missing;
            	return _factory.ParserRuleAlternative(parserRuleAlternativeBlock1, elements, parserRuleAlternativeBlock2);
            }
            public override GreenNode? VisitPr_ParserRuleElement(CompilerParser.Pr_ParserRuleElementContext? context)
            {
               	if (context == null) return ParserRuleElementGreen.__Missing;
                NameGreen? name = null;
                if (context.nameAntlr1 is not null) name = (NameGreen?)this.Visit(context.nameAntlr1) ?? NameGreen.__Missing;
                else name = NameGreen.__Missing;
            	return _factory.ParserRuleElement(name);
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
            public override GreenNode? VisitPr_ParserRuleBlock1(CompilerParser.Pr_ParserRuleBlock1Context? context)
            {
               	if (context == null) return ParserRuleBlock1Green.__Missing;
                var kReturns = this.VisitTerminal(context.kReturns, CompilerSyntaxKind.KReturns);
                QualifierGreen? returnType = null;
                if (context.returnTypeAntlr1 is not null) returnType = (QualifierGreen?)this.Visit(context.returnTypeAntlr1) ?? QualifierGreen.__Missing;
                else returnType = QualifierGreen.__Missing;
            	return _factory.ParserRuleBlock1((InternalSyntaxToken)kReturns, returnType);
            }
            public override GreenNode? VisitPr_ParserRuleBlock2(CompilerParser.Pr_ParserRuleBlock2Context? context)
            {
               	if (context == null) return ParserRuleBlock2Green.__Missing;
                var tBar = this.VisitTerminal(context.tBar, CompilerSyntaxKind.TBar);
                ParserRuleAlternativeGreen? alternatives = null;
                if (context.alternativesAntlr1 is not null) alternatives = (ParserRuleAlternativeGreen?)this.Visit(context.alternativesAntlr1) ?? ParserRuleAlternativeGreen.__Missing;
                else alternatives = ParserRuleAlternativeGreen.__Missing;
            	return _factory.ParserRuleBlock2((InternalSyntaxToken)tBar, alternatives);
            }
            public override GreenNode? VisitPr_BlockRuleBlock1(CompilerParser.Pr_BlockRuleBlock1Context? context)
            {
               	if (context == null) return BlockRuleBlock1Green.__Missing;
                var tBar = this.VisitTerminal(context.tBar, CompilerSyntaxKind.TBar);
                ParserRuleAlternativeGreen? alternatives = null;
                if (context.alternativesAntlr1 is not null) alternatives = (ParserRuleAlternativeGreen?)this.Visit(context.alternativesAntlr1) ?? ParserRuleAlternativeGreen.__Missing;
                else alternatives = ParserRuleAlternativeGreen.__Missing;
            	return _factory.BlockRuleBlock1((InternalSyntaxToken)tBar, alternatives);
            }
            public override GreenNode? VisitPr_ParserRuleAlternativeBlock1(CompilerParser.Pr_ParserRuleAlternativeBlock1Context? context)
            {
               	if (context == null) return ParserRuleAlternativeBlock1Green.__Missing;
                var tLBrace = this.VisitTerminal(context.tLBrace, CompilerSyntaxKind.TLBrace);
                QualifierGreen? returnType = null;
                if (context.returnTypeAntlr1 is not null) returnType = (QualifierGreen?)this.Visit(context.returnTypeAntlr1) ?? QualifierGreen.__Missing;
                else returnType = QualifierGreen.__Missing;
                var tRBrace = this.VisitTerminal(context.tRBrace, CompilerSyntaxKind.TRBrace);
            	return _factory.ParserRuleAlternativeBlock1((InternalSyntaxToken)tLBrace, returnType, (InternalSyntaxToken)tRBrace);
            }
            public override GreenNode? VisitPr_ParserRuleAlternativeBlock2(CompilerParser.Pr_ParserRuleAlternativeBlock2Context? context)
            {
               	if (context == null) return ParserRuleAlternativeBlock2Green.__Missing;
                var tEqGt = this.VisitTerminal(context.tEqGt, CompilerSyntaxKind.TEqGt);
                ExpressionGreen? returnValue = null;
                if (context.returnValueAntlr1 is not null) returnValue = (ExpressionGreen?)this.Visit(context.returnValueAntlr1) ?? ExpressionGreen.__Missing;
                else returnValue = ExpressionGreen.__Missing;
            	return _factory.ParserRuleAlternativeBlock2((InternalSyntaxToken)tEqGt, returnValue);
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
        }
    }
}
