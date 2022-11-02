using MetaDslx.CodeAnalysis.Text;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.Languages.MetaGenerator
{
    internal class MetaGeneratorTokenStream
    {
        private struct Entry
        {
            public MetaGeneratorToken Token;
            public int Line;
            public int Character;
        }

        private MetaGeneratorLexer _lexer;
        private MetaGeneratorLexerState _fetchState;
        private List<Entry> _tokens;
        private int _position;
        private bool _endOfFile;
        private Entry _eofEntry;

        public MetaGeneratorTokenStream(MetaGeneratorLexer lexer)
        {
            _lexer = lexer;
            _fetchState = MetaGeneratorLexerState.None;
            _tokens = new List<Entry>();
        }

        public MetaGeneratorToken CurrentToken => PeekToken(0);
        public MetaGeneratorLexerState State => PeekToken(0).LexerState;
        public int Position => _position;
        public int Line => _endOfFile ? _eofEntry.Line : PeekEntry(0).Line;
        public int Character => _endOfFile ? _eofEntry.Character : PeekEntry(0).Character;
        public LinePosition LinePosition => new LinePosition(_endOfFile ? _eofEntry.Line : Line, _endOfFile ? _eofEntry.Character : Character);
        public int MaxLookahead => _lexer.MaxLookahead;
        public bool EndOfFile => _endOfFile;
        public string ControlBegin => _lexer.ControlBegin;
        public string ControlEnd => _lexer.ControlEnd;

        public MetaGeneratorToken EatToken()
        {
            if (_tokens.Count > 0 || FetchToken())
            {
                var entry = _tokens[0];
                _tokens.RemoveAt(0);
                var token = entry.Token;
                _position += token.Text.Length;
                if (token.Kind == MetaGeneratorTokenKind.EndOfFile)
                {
                    _eofEntry = entry;
                    _endOfFile = true;
                }
                return token;
            }
            return MetaGeneratorToken.None;
        }

        public void EatTokens(int count)
        {
            for (int i = 0; i < count; i++)
            {
                this.EatToken();
            }
        }

        public MetaGeneratorToken PeekToken(int index = 0)
        {
            if (FetchTokens(index + 1))
            {
                var token = _tokens[index];
                return token.Token;
            }
            return MetaGeneratorToken.None;
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
            if (_fetchState != MetaGeneratorLexerState.Eof)
            {
                var entry = new Entry() { Token = MetaGeneratorToken.None, Line = _lexer.Line, Character = _lexer.Column };
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
