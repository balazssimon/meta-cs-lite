using MetaDslx.CodeAnalysis.Syntax.InternalSyntax;
using MetaDslx.CodeAnalysis.Text;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Antlr4
{
    public abstract class Antlr4SyntaxParser : SyntaxParser
    {
        protected Antlr4SyntaxParser(SyntaxLexer lexer, SyntaxNode? oldTree, ParseData? oldParseData, IEnumerable<TextChangeRange>? changes, CancellationToken cancellationToken)
            : base(lexer, oldTree, oldParseData, changes, cancellationToken)
        {
        }
    }
}
