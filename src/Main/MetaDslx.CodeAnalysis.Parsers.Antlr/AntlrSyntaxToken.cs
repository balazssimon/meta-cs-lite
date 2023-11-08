using Antlr4.Runtime;
using MetaDslx.CodeAnalysis.Syntax.InternalSyntax;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis.Parsers.Antlr
{
    public class AntlrSyntaxToken : IToken
    {
        private int _type;
        private int _channel;
        private string _text;
        private int _index;
        private int _position;
        private int _line;
        private int _column;
        private int _lookAhead;
        private int _lookBack;

        public AntlrSyntaxToken(int type, int channel, string text, int index, int position, int line, int column, int lookAhead, int lookBack)
        {
            _type = type;
            _channel = channel;
            _text = text;
            _index = index;
            _position = position;
            _line = line;
            _column = column;
            _lookAhead = lookAhead;
            _lookBack = lookBack;
        }
        
        public int Type => _type;

        public int Channel => _channel;

        public string Text => _text;

        public int Line => _line;

        public int Column => _column;

        public int TokenIndex { get => _index; set => _index = value; }

        public int StartIndex { get => _position; set => _position = value; }

        public int StopIndex => _position + _text.Length - 1;

        public int LookAhead => _lookAhead;

        public int LookBack => _lookBack;

        public ITokenSource TokenSource => null;

        public ICharStream InputStream => null;

        public override string ToString()
        {
            string? text = Text?.Replace("\t", "\\t")?.Replace("\r", "\\r")?.Replace("\n", "\\n");
            if (Type == IntStreamConstants.EOF) text = "<EOF>";
            return $"[@{TokenIndex},{StartIndex}:{StopIndex}={text},<{Type}>,{Line}:{Column}]";
        }
    }
}
