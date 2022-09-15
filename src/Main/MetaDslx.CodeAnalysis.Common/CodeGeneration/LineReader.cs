using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeGeneration
{
    public ref struct LineReader
    {
        private ReadOnlySpan<char> _code;
        private bool _hasFinalLineEnd;

        public LineReader(ReadOnlySpan<char> code)
        {
            _code = code;
            int lastIndex = _code.Length - 1;
            while (lastIndex >= 0 && (_code[lastIndex] == '\r' || _code[lastIndex] == '\n'))
            {
                --lastIndex;
            }
            _hasFinalLineEnd = false;
            if (lastIndex + 2 < _code.Length)
            {
                if (_code[lastIndex + 1] == '\r' && _code[lastIndex + 2] == '\n') lastIndex += 2;
                else if (_code[lastIndex + 1] == '\r' || _code[lastIndex + 1] == '\n') lastIndex += 1;
                _hasFinalLineEnd = true;
            }
            else if (lastIndex + 1 < _code.Length)
            {
                if (_code[lastIndex + 1] == '\r' || _code[lastIndex + 1] == '\n') lastIndex += 1;
                _hasFinalLineEnd = true;
            }
            _code = _code.Slice(0, lastIndex + 1);
        }

        public LineReader(string code)
            : this(code.AsSpan())
        {
        }

        public LineReader(char[] code)
            : this(code.AsSpan())
        {
        }

        public bool EndOfStream => _code.Length == 0;
        public bool HasFinalLineEnd => _hasFinalLineEnd;

        public ReadOnlySpan<char> ReadLine()
        {
            int indexR = _code.IndexOf('\r');
            int indexN = _code.IndexOf('\n');
            int lineLength = _code.Length;
            int nextLineStartIndex = _code.Length;
            if (indexR >= 0)
            {
                if (indexN == indexR + 1)
                {
                    lineLength = indexR;
                    nextLineStartIndex = indexN + 1;
                }
                else if (indexN >= 0 && indexN < indexR)
                {
                    lineLength = indexN;
                    nextLineStartIndex = indexN + 1;
                }
                else
                {
                    lineLength = indexR;
                    nextLineStartIndex = indexR + 1;
                }
            }
            else if (indexN >= 0)
            {
                lineLength = indexN;
                nextLineStartIndex = indexN + 1;
            }
            var result = _code.Slice(0, lineLength);
            _code = _code.Slice(nextLineStartIndex);
            return result;
        }
    }
}
