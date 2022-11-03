using MetaDslx.CodeAnalysis.Text;
using MetaDslx.Languages.MetaCompiler.Syntax;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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
        private bool _ignoreWhitespaceAndComments;

        public MetaCompilerTokenStream(MetaCompilerLexer lexer)
        {
            _lexer = lexer;
            _tokens = new List<Entry>();
            _ignoreWhitespaceAndComments = true;
        }

        public MetaCompilerToken CurrentToken => PeekToken(0);
        public int Position => _position;
        public int Line => _endOfFile ? _eofEntry.Line : PeekEntry(0).Line;
        public int Character => _endOfFile ? _eofEntry.Character : PeekEntry(0).Character;
        public LinePosition LinePosition => new LinePosition(_endOfFile ? _eofEntry.Line : Line, _endOfFile ? _eofEntry.Character : Character);
        public bool EndOfFile => _endOfFile;
        public bool IgnoreWhitespaceAndComments
        {
            get => _ignoreWhitespaceAndComments;
            set => _ignoreWhitespaceAndComments = value;
        }

        public MetaCompilerToken NextToken()
        {
            EatToken();
            return CurrentToken;
        }

        public MetaCompilerToken EatToken()
        {
            if (!_endOfFile)
            {
                var index = BufferedTokenIndex(0);
                if (index < _tokens.Count)
                {
                    var entry = _tokens[index];
                    for (int i = 0; i <= index; i++)
                    {
                        _position += _tokens[0].Token.Text.Length;
                        _tokens.RemoveAt(0);
                    }
                    var token = entry.Token;
                    if (token.Kind == MetaCompilerTokenKind.EndOfFile)
                    {
                        _eofEntry = entry;
                        _endOfFile = true;
                    }
                    return token;
                }
                else
                {
                    _endOfFile = true;
                }
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
            index = BufferedTokenIndex(index);
            if (index < _tokens.Count)
            {
                var token = _tokens[index];
                return token.Token;
            }
            return MetaCompilerToken.None;
        }

        private Entry PeekEntry(int index = 0)
        {
            index = BufferedTokenIndex(index);
            if (index < _tokens.Count)
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
                var entry = new Entry() { Token = token, Line = _lexer.Line, Character = _lexer.Column };
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

        private int BufferedTokenCount()
        {
            if (IgnoreWhitespaceAndComments) return _tokens.Where(IsWhitespaceOrComment).Count(); 
            else return _tokens.Count;
        }

        private int BufferedTokenIndex(int index)
        {
            if (IgnoreWhitespaceAndComments)
            {
                var count = _tokens.Count;
                var i = 0;
                var bufferedIndex = 0;
                while (true)
                {
                    if (i >= count)
                    {
                        count = i + 1;
                        if (!FetchTokens(count)) return _tokens.Count - 1;
                    }
                    if (!IsWhitespaceOrComment(_tokens[i]))
                    {
                        if (bufferedIndex == index) return i;
                        else ++bufferedIndex;
                    }
                    ++i;
                }
            }
            else
            {
                if (!FetchTokens(index + 1)) return _tokens.Count - 1;
                else return index;
            }
        }

        private bool IsWhitespaceOrComment(Entry entry)
        {
            switch (entry.Token.Kind)
            {
                case MetaCompilerTokenKind.Whitespace:
                case MetaCompilerTokenKind.EndOfLine:
                case MetaCompilerTokenKind.SingleLineComment:
                case MetaCompilerTokenKind.MultiLineComment:
                    return true;
                default:
                    return false;
            }
        }
    }
}
