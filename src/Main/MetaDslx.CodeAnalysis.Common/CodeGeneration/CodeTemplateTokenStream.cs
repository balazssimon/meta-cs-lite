using MetaDslx.CodeAnalysis.Text;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis.CodeGeneration
{
    internal class CodeTemplateTokenStream
    {
        private struct Entry
        {
            public CodeTemplateToken Token;
            public CodeTemplateLexerState LexerState;
            public int Line;
            public int Character;
        }

        private CodeTemplateLexer _lexer;
        private CodeTemplateLexerState _fetchState;
        private List<Entry> _tokens;
        private bool _endOfFile;

        public CodeTemplateTokenStream(CodeTemplateLexer lexer)
        {
            _lexer = lexer;
            _fetchState = CodeTemplateLexerState.None;
            _tokens = new List<Entry>();
        }

        public CodeTemplateToken CurrentToken => PeekToken(0);
        public CodeTemplateLexerState State => PeekEntry(0).LexerState;
        public int Line => PeekEntry(0).Line;
        public int Character => PeekEntry(0).Character;
        public LinePosition LinePosition => new LinePosition(Line, Character);
        public bool EndOfFile => _endOfFile;

        public CodeTemplateToken EatToken()
        {
            if (_tokens.Count > 0 || FetchToken())
            {
                var token = _tokens[0].Token;
                _tokens.RemoveAt(0);
                if (token.Kind == CodeTemplateTokenKind.EndOfFile)
                {
                    _endOfFile = true;
                }
                return token;
            }
            return CodeTemplateToken.None;
        }

        public CodeTemplateToken PeekToken(int index = 0)
        {
            if (FetchTokens(index + 1))
            {
                var token = _tokens[index];
                return token.Token;
            }
            return CodeTemplateToken.None;
        }

        private Entry PeekEntry(int index = 0)
        {
            if (FetchTokens(index + 1))
            {
                var entry = _tokens[index];
                return entry;
            }
            return default;
        }

        private bool FetchToken()
        {
            if (_fetchState != CodeTemplateLexerState.Eof)
            {
                var entry = new Entry() { Token = CodeTemplateToken.None, LexerState = _fetchState, Line = _lexer.Line, Character = _lexer.Column };
                entry.Token = _lexer.Lex(ref _fetchState);
                _tokens.Add(entry);
                return true;
            }
            return false;
        }

        private bool FetchTokens(int count)
        {
            while (count > _tokens.Count && FetchToken());
            return count <= _tokens.Count;
        }
    }
}
