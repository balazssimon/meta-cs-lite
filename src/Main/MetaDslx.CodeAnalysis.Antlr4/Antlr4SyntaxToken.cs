using Antlr4.Runtime;
using MetaDslx.CodeAnalysis.Syntax.InternalSyntax;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis.Antlr4
{
    public class Antlr4SyntaxToken : IToken
    {
        private readonly int _index;
        private readonly int _position;
        private readonly int _line;
        private readonly int _column;

        public Antlr4SyntaxToken(InternalSyntaxToken green, int index, int position, int line, int column)
        {
            Green = green;
            _index = index;
            _position = position;
            _line = line;
            _column = column;
        }

        public InternalSyntaxToken Green { get; }

        public string Text => Green.Text;

        public int Type => Antlr4SyntaxKind.ToAntlr4(Green.RawKind);

        public int Line => _line + 1;

        public int Column => _column + 1;

        public int Channel => 0;

        public int TokenIndex => _index;

        public int StartIndex => _position;

        public int StopIndex => _position + Green.FullWidth - 1;

        public ITokenSource TokenSource => throw new NotImplementedException();

        public ICharStream InputStream => throw new NotImplementedException();

        public override string ToString()
        {
            string? text = Text?.Replace("\t", "\\t")?.Replace("\r", "\\r")?.Replace("\n", "\\n");
            if (Type == IntStreamConstants.EOF) text = "<EOF>";
            return $"[@{TokenIndex},{StartIndex}:{StopIndex}={text},<{Type}>,{Line}:{Column}]";
        }
    }
}
