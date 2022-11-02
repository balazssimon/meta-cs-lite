using MetaDslx.CodeAnalysis.Text;
using MetaDslx.Languages.MetaCompiler.Syntax;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.Languages.MetaCompiler
{
    internal class MetaCompilerTokenStream
    {
        private struct Entry
        {
            public MetaCompilerToken Token;
            public int Line;
            public int Character;
        }

        private MetaCompilerLexer _lexer;
        private List<Entry> _tokens;
        private int _position;
        private bool _endOfFile;
        private Entry _eofEntry;

        public MetaCompilerTokenStream(MetaCompilerLexer lexer)
        {
            _lexer = lexer;
            _tokens = new List<Entry>();
        }

        public MetaCompilerToken CurrentToken => PeekToken(0);
        public int Position => _position;
        public int Line => _endOfFile ? _eofEntry.Line : PeekEntry(0).Line;
        public int Character => _endOfFile ? _eofEntry.Character : PeekEntry(0).Character;
        public LinePosition LinePosition => new LinePosition(_endOfFile ? _eofEntry.Line : Line, _endOfFile ? _eofEntry.Character : Character);
        public bool EndOfFile => _endOfFile;

        public MetaCompilerToken EatToken()
        {
            if (_tokens.Count > 0 || FetchToken())
            {
                var entry = _tokens[0];
                _tokens.RemoveAt(0);
                var token = entry.Token;
                _position += token.Text.Length;
                if (token.Kind == MetaCompilerTokenKind.EndOfFile)
                {
                    _eofEntry = entry;
                    _endOfFile = true;
                }
                return token;
            }
            return MetaCompilerToken.None;
        }

        public void EatTokens(int count)
        {
            for (int i = 0; i < count; i++)
            {
                this.EatToken();
            }
        }

        public MetaCompilerToken PeekToken(int index = 0)
        {
            if (FetchTokens(index + 1))
            {
                var token = _tokens[index];
                return token.Token;
            }
            return MetaCompilerToken.None;
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
            while (!_lexer.EndOfFile)
            {
                var token = _lexer.Lex();
                if (token.Kind == MetaCompilerTokenKind.Whitespace ||
                    token.Kind == MetaCompilerTokenKind.EndOfLine ||
                    token.Kind == MetaCompilerTokenKind.SingleLineComment ||
                    token.Kind == MetaCompilerTokenKind.MultiLineComment)
                {
                    continue;
                }
                else
                {
                    var entry = new Entry() { Token = token, Line = _lexer.Line, Character = _lexer.Column };
                    _tokens.Add(entry);
                    return true;
                }
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
