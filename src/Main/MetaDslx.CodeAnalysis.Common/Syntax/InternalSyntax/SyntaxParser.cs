using MetaDslx.CodeAnalysis.Text;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Syntax.InternalSyntax
{
    public abstract class SyntaxParser : AbstractParser
    {
        private CancellationToken _cancellationToken;
        private int _position;
        private ParserState? _state;

        protected SyntaxParser(SyntaxLexer lexer, SyntaxNode? oldTree, ParseData? oldParseData, IEnumerable<TextChangeRange>? changes, CancellationToken cancellationToken) 
            : base(lexer)
        {
            _cancellationToken = cancellationToken;
            _position = 0;
            _state = null;
        }

        public CancellationToken CancellationToken => _cancellationToken;

        public override int Position => _position;

        public override ParserState? State => _state;

    }
}
