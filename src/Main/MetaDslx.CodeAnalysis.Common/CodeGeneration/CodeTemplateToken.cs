using MetaDslx.CodeAnalysis.Syntax.InternalSyntax;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace MetaDslx.CodeAnalysis.CodeGeneration
{
    public struct CodeTemplateToken
    {
        public static readonly CodeTemplateToken None = new CodeTemplateToken(CodeTemplateTokenKind.None, string.Empty, -1, CodeTemplateLexerState.None);

        private CodeTemplateTokenKind _kind;
        private string _text;
        private int _position;
        private CodeTemplateLexerState _lexerState;

        public CodeTemplateToken(CodeTemplateTokenKind kind, string text, int position, CodeTemplateLexerState lexerState)
        {
            _kind = kind;
            _text = text;
            _position = position;
            _lexerState = lexerState;
        }

        public CodeTemplateTokenKind Kind => _kind;
        public string Text => _text;
        public int Position => _position;
        public CodeTemplateLexerState LexerState => _lexerState;
        public string EscapedText => _text == null ? null : _text.Replace("\t", "\\t").Replace("\r", "\\r").Replace("\n", "\\n");
        public string EscapedTextForString => _text == null ? null : _text.Replace("\\", "\\\\").Replace("\"", "\\\"").Replace("\t", "\\t").Replace("\r", "\\r").Replace("\n", "\\n");

        public override string ToString()
        {
            return $"{_kind}[{_position}]: '{EscapedText}'";
        }
    }
}
