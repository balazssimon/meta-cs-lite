using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.Languages.MetaCompiler.Syntax
{
    public struct MetaCompilerToken
    {
        public static readonly MetaCompilerToken None = new MetaCompilerToken(MetaCompilerTokenKind.None, string.Empty, -1);

        private MetaCompilerTokenKind _kind;
        private string _text;
        private int _position;

        public MetaCompilerToken(MetaCompilerTokenKind kind, string text, int position)
        {
            _kind = kind;
            _text = text;
            _position = position;
        }

        public MetaCompilerTokenKind Kind => _kind;
        public string Text => _text;
        public int Position => _position;
        public string EscapedText => _kind == MetaCompilerTokenKind.EndOfFile ? "<EOF>" : _text == null ? null : _text.Replace("\t", "\\t").Replace("\r", "\\r").Replace("\n", "\\n");
        public string EscapedTextForString => _text == null ? null : _text.Replace("\\", "\\\\").Replace("\"", "\\\"").Replace("\t", "\\t").Replace("\r", "\\r").Replace("\n", "\\n");

        public override string ToString()
        {
            return $"{_kind}[{_position}]: '{EscapedText}'";
        }
    }
}
