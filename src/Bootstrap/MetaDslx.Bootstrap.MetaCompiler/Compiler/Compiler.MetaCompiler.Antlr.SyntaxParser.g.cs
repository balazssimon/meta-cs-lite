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
                var eof = this.VisitTerminal(context.eof, CompilerSyntaxKind.Eof);
            	return _factory.Main((InternalSyntaxToken)kNamespace, name, (InternalSyntaxToken)tSemicolon, @using, (InternalSyntaxToken)eof);
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
