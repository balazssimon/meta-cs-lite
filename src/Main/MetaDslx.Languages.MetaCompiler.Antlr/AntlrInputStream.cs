using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using MetaDslx.CodeAnalysis.Text;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.Languages.MetaCompiler.Antlr
{
    public class AntlrInputStream : ICharStream, IIntStream
    {
        private readonly AntlrSyntaxLexer _lexer;
        private readonly SlidingTextWindow _textWindow;
        private int _resetCounter;
        private int _lookAhead;
        private int _lookBack;
        private int _maxLookAhead;
        private int _maxLookBack;

        public AntlrInputStream(AntlrSyntaxLexer lexer, SlidingTextWindow textWindow)
        {
            _textWindow = textWindow;
            _lexer = lexer;
            _resetCounter = 0;
            _lookAhead = 0;
            _lookBack = 0;
            _maxLookAhead = 0;
            _maxLookBack = 0;
        }

        public int LA(int i)
        {
            char pch;
            if (i > 0 && i - 1 > _lookAhead) _lookAhead = i - 1;
            if (i < 0 && i < _lookBack) _lookBack = i;
            if (_lookAhead > _maxLookAhead) _maxLookAhead = _lookAhead;
            if (_lookBack > _maxLookBack) _maxLookBack = _lookBack;
            if (i > 0) pch = _textWindow.PeekChar(i - 1);
            else if (i < 0) pch = _textWindow.PeekChar(i);
            else pch = SlidingTextWindow.InvalidCharacter;
            if (pch == SlidingTextWindow.InvalidCharacter) return IntStreamConstants.EOF;
            else return pch;
        }

        public int Index => _textWindow.Position;
        public int Size => _textWindow.SourceText.Length;
        public string SourceName => IntStreamConstants.UnknownSourceName;
        public int LookAhead => _lookAhead;
        public int LookBack => _lookBack;
        public int MaxLookAhead => _maxLookAhead;
        public int MaxLookBack => _maxLookBack;

        [return: NotNull]
        public string GetText([NotNull] Interval interval)
        {
            var length = interval.Length;
            if (interval.b >= _textWindow.SourceText.Length) length = _textWindow.SourceText.Length - interval.a;
            if (length < 0 || interval.a >= _textWindow.SourceText.Length) return string.Empty;
            return _textWindow.GetText(interval.a, length, false);
        }

        public void Consume()
        {
            _textWindow.NextChar();
            _lookAhead = 0;
            _lookBack = 0;
        }

        public int Mark()
        {
            return ++_resetCounter;
        }

        public void Release(int marker)
        {
            if (marker != _resetCounter) throw new ArgumentException("Invalid marker to release.", nameof(marker));
            --_resetCounter;
        }

        public void Seek(int index)
        {
            if (!_lexer.Resetting) _textWindow.ResetTo(index);
        }
    }
}
