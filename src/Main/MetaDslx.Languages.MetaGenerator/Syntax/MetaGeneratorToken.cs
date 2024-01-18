using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace MetaDslx.Languages.MetaGenerator.Syntax
{
    public struct MetaGeneratorToken
    {
        public static readonly MetaGeneratorToken None = new MetaGeneratorToken(MetaGeneratorTokenKind.None, string.Empty, -1, MetaGeneratorLexerState.None);

        private MetaGeneratorTokenKind _kind;
        private string _text;
        private int _position;
        private MetaGeneratorLexerState _lexerState;

        public MetaGeneratorToken(MetaGeneratorTokenKind kind, string text, int position, MetaGeneratorLexerState lexerState)
        {
            _kind = kind;
            _text = text;
            _position = position;
            _lexerState = lexerState;
        }

        public MetaGeneratorTokenKind Kind
        {
            get => _kind;
            internal set => _kind = value;
        }
        public string Text => _text;
        public int Position => _position;
        public MetaGeneratorLexerState LexerState => _lexerState;
        public string EscapedText => _kind == MetaGeneratorTokenKind.EndOfFile ? "<EOF>" : _text == null ? null : _text.Replace("\t", "\\t").Replace("\r", "\\r").Replace("\n", "\\n");
        public string EscapedTextForString => _text == null ? null : _text.Replace("\\", "\\\\").Replace("\"", "\\\"").Replace("\t", "\\t").Replace("\r", "\\r").Replace("\n", "\\n");

        public override string ToString()
        {
            return $"{_kind}[{_position}]: '{EscapedText}'";
        }
    }
}
