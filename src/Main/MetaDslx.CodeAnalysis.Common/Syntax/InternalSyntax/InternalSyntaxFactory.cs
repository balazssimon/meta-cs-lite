using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.CodeAnalysis.Text;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Syntax.InternalSyntax
{
    public abstract class InternalSyntaxFactory
    {
        internal readonly ObjectPool<CachingIdentityFactory<string, int>> KeywordKindPool;

        private const string CrLf = "\r\n";
        private SyntaxFacts _syntaxFacts;

        public readonly InternalSyntaxTrivia CarriageReturnLineFeed;
        public readonly InternalSyntaxTrivia LineFeed;
        public readonly InternalSyntaxTrivia CarriageReturn;
        public readonly InternalSyntaxTrivia Space;
        public readonly InternalSyntaxTrivia Tab;

        public readonly InternalSyntaxTrivia ElasticCarriageReturnLineFeed;
        public readonly InternalSyntaxTrivia ElasticLineFeed;
        public readonly InternalSyntaxTrivia ElasticCarriageReturn;
        public readonly InternalSyntaxTrivia ElasticSpace;
        public readonly InternalSyntaxTrivia ElasticTab;

        public readonly InternalSyntaxTrivia ElasticZeroSpace;

        protected InternalSyntaxFactory(SyntaxFacts syntaxFacts)
        {
            _syntaxFacts = syntaxFacts;
            KeywordKindPool =
                CachingIdentityFactory<string, int>.CreatePool(
                            512,
                            (key) =>
                            {
                                var kind = syntaxFacts.GetReservedKeywordRawKind(key);
                                if (kind == (int)InternalSyntaxKind.None)
                                {
                                    kind = syntaxFacts.GetContextualKeywordRawKind(key);
                                }
                                return kind;
                            });

            CarriageReturnLineFeed = EndOfLine(CrLf);
            LineFeed = EndOfLine("\n");
            CarriageReturn = EndOfLine("\r");
            Space = Whitespace(" ");
            Tab = Whitespace("\t");

            ElasticCarriageReturnLineFeed = EndOfLine(CrLf, elastic: true);
            ElasticLineFeed = EndOfLine("\n", elastic: true);
            ElasticCarriageReturn = EndOfLine("\r", elastic: true);
            ElasticSpace = Whitespace(" ", elastic: true);
            ElasticTab = Whitespace("\t", elastic: true);

            ElasticZeroSpace = Whitespace(string.Empty, elastic: true);
        }

        public virtual InternalSyntaxToken DefaultSeparator
        {
            get { return this.Token(_syntaxFacts.DefaultSeparatorRawKind); }
        }

        public virtual InternalSyntaxToken EndOfFile
        {
            get { return this.Token(null, (int)InternalSyntaxKind.Eof, string.Empty, null); }
        }

        public InternalSyntaxTrivia EndOfLine(string text, bool elastic = false)
        {
            InternalSyntaxTrivia? trivia = null;

            // use predefined trivia
            switch (text)
            {
                case "\r":
                    trivia = elastic ? ElasticCarriageReturn : CarriageReturn;
                    break;
                case "\n":
                    trivia = elastic ? ElasticLineFeed : LineFeed;
                    break;
                case "\r\n":
                    trivia = elastic ? ElasticCarriageReturnLineFeed : CarriageReturnLineFeed;
                    break;
            }

            // note: predefined trivia might not yet be defined during initialization
            if (trivia != null)
            {
                return trivia;
            }

            trivia = this.Trivia(_syntaxFacts.DefaultEndOfLineRawKind, text);
            if (!elastic)
            {
                return trivia;
            }

            return trivia.WithAnnotationsGreen(new[] { SyntaxAnnotation.ElasticAnnotation });
        }

        public InternalSyntaxTrivia Whitespace(string text, bool elastic = false)
        {
            var trivia = this.Trivia(_syntaxFacts.DefaultWhitespaceRawKind, text);
            if (!elastic)
            {
                return trivia;
            }

            return trivia.WithAnnotationsGreen(new[] { SyntaxAnnotation.ElasticAnnotation });
        }

        internal protected abstract InternalSyntaxTrivia Trivia(int kind, string text, bool elastic = false);
        internal protected abstract InternalSyntaxToken Token(int kind);
        internal protected abstract InternalSyntaxToken Token(GreenNode? leading, int kind, GreenNode? trailing);
        internal protected abstract InternalSyntaxToken Token(GreenNode? leading, int kind, string text, GreenNode? trailing);
        internal protected abstract InternalSyntaxToken Token(GreenNode? leading, int kind, string text, string valueText, GreenNode? trailing);
        internal protected abstract InternalSyntaxToken Token(GreenNode? leading, int kind, string text, object value, GreenNode? trailing);
        internal protected abstract InternalSyntaxToken MissingToken(int kind);
        internal protected abstract InternalSyntaxToken MissingToken(GreenNode? leading, int kind, GreenNode? trailing);

        public abstract InternalSyntaxNode SkippedTokensTrivia(GreenNode token);
        public abstract InternalSyntaxToken BadToken(GreenNode? leading, string text, GreenNode? trailing);

        public InternalSyntaxTrivia ConflictMarker(string text)
        {
            return Trivia((int)InternalSyntaxKind.ConflictMarkerTrivia, text);
        }

        public InternalSyntaxTrivia DisabledText(string text)
        {
            return Trivia((int)InternalSyntaxKind.DisabledTextTrivia, text);
        }

        public InternalSyntax.SyntaxList<TNode> List<TNode>() where TNode : InternalSyntaxNode
        {
            return default(InternalSyntax.SyntaxList<TNode>);
        }

        public InternalSyntax.SyntaxList<TNode> List<TNode>(TNode node) where TNode : InternalSyntaxNode
        {
            return new InternalSyntax.SyntaxList<TNode>(InternalSyntax.SyntaxList.List(node));
        }

        public InternalSyntax.SyntaxList<TNode> List<TNode>(TNode node0, TNode node1) where TNode : InternalSyntaxNode
        {
            return new InternalSyntax.SyntaxList<TNode>(InternalSyntax.SyntaxList.List(node0, node1));
        }

        public GreenNode ListNode(InternalSyntaxNode node0, InternalSyntaxNode node1)
        {
            return InternalSyntax.SyntaxList.List(node0, node1);
        }

        public InternalSyntax.SyntaxList<TNode> List<TNode>(TNode node0, TNode node1, TNode node2) where TNode : InternalSyntaxNode
        {
            return new InternalSyntax.SyntaxList<TNode>(InternalSyntax.SyntaxList.List(node0, node1, node2));
        }

        public GreenNode ListNode(InternalSyntaxNode node0, InternalSyntaxNode node1, InternalSyntaxNode node2)
        {
            return InternalSyntax.SyntaxList.List(node0, node1, node2);
        }

        public InternalSyntax.SyntaxList<TNode> List<TNode>(params TNode[] nodes) where TNode : InternalSyntaxNode
        {
            if (nodes != null)
            {
                return new InternalSyntax.SyntaxList<TNode>(InternalSyntax.SyntaxList.List(nodes));
            }

            return default(InternalSyntax.SyntaxList<TNode>);
        }

        public GreenNode ListNode(params ArrayElement<GreenNode>[] nodes)
        {
            return InternalSyntax.SyntaxList.List(nodes);
        }

        public InternalSyntax.SeparatedSyntaxList<TNode> SeparatedList<TNode>(TNode node) where TNode : InternalSyntaxNode
        {
            return new InternalSyntax.SeparatedSyntaxList<TNode>(new InternalSyntax.SyntaxList<InternalSyntaxNode>(node), false);
        }

        public InternalSyntax.SeparatedSyntaxList<TNode> SeparatedList<TNode>(InternalSyntaxToken token) where TNode : InternalSyntaxNode
        {
            return new InternalSyntax.SeparatedSyntaxList<TNode>(new InternalSyntax.SyntaxList<InternalSyntaxNode>(token), false);
        }

        public InternalSyntax.SeparatedSyntaxList<TNode> SeparatedList<TNode>(TNode node1, InternalSyntaxToken token, TNode node2) where TNode : InternalSyntaxNode
        {
            return new InternalSyntax.SeparatedSyntaxList<TNode>(new InternalSyntax.SyntaxList<InternalSyntaxNode>(InternalSyntax.SyntaxList.List(node1, token, node2)), false);
        }

        public InternalSyntax.SeparatedSyntaxList<TNode> SeparatedList<TNode>(params InternalSyntaxNode[] nodes) where TNode : InternalSyntaxNode
        {
            if (nodes != null)
            {
                return new InternalSyntax.SeparatedSyntaxList<TNode>(InternalSyntax.SyntaxList.List(nodes), false);
            }

            return default(InternalSyntax.SeparatedSyntaxList<TNode>);
        }

        public InternalSyntax.SeparatedSyntaxList<TNode> ReversedSeparatedList<TNode>(TNode node) where TNode : InternalSyntaxNode
        {
            return new InternalSyntax.SeparatedSyntaxList<TNode>(new InternalSyntax.SyntaxList<InternalSyntaxNode>(node), true);
        }

        public InternalSyntax.SeparatedSyntaxList<TNode> ReversedSeparatedList<TNode>(InternalSyntaxToken token) where TNode : InternalSyntaxNode
        {
            return new InternalSyntax.SeparatedSyntaxList<TNode>(new InternalSyntax.SyntaxList<InternalSyntaxNode>(token), true);
        }

        public InternalSyntax.SeparatedSyntaxList<TNode> ReversedSeparatedList<TNode>(InternalSyntaxToken token, TNode node1) where TNode : InternalSyntaxNode
        {
            return new InternalSyntax.SeparatedSyntaxList<TNode>(new InternalSyntax.SyntaxList<InternalSyntaxNode>(InternalSyntax.SyntaxList.List(token, node1)), true);
        }

        public InternalSyntax.SeparatedSyntaxList<TNode> ReversedSeparatedList<TNode>(params InternalSyntaxNode[] nodes) where TNode : InternalSyntaxNode
        {
            if (nodes != null)
            {
                return new InternalSyntax.SeparatedSyntaxList<TNode>(InternalSyntax.SyntaxList.List(nodes), true);
            }

            return new InternalSyntax.SeparatedSyntaxList<TNode>(default, true);
        }

        public virtual IEnumerable<InternalSyntaxTrivia> GetWellKnownTrivia()
        {
            yield return CarriageReturnLineFeed;
            yield return LineFeed;
            yield return CarriageReturn;
            yield return Space;
            yield return Tab;

            yield return ElasticCarriageReturnLineFeed;
            yield return ElasticLineFeed;
            yield return ElasticCarriageReturn;
            yield return ElasticSpace;
            yield return ElasticTab;

            yield return ElasticZeroSpace;
        }

        public abstract IEnumerable<InternalSyntaxToken> GetWellKnownTokens();

        public abstract AbstractLexer CreateLexer(SourceText text, ParseOptions options);
        public abstract AbstractParser CreateParser(AbstractLexer lexer, SyntaxNode? oldTree, ParseData? oldParseData, IEnumerable<TextChangeRange>? changes, CancellationToken cancellationToken = default);

    }
}
