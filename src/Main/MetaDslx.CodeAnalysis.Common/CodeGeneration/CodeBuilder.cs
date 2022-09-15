using MetaDslx.CodeAnalysis.PooledObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeGeneration
{
    public sealed class CodeBuilder
    {
        private static readonly ObjectPool<CodeBuilder> s_pool = new ObjectPool<CodeBuilder>(() => new CodeBuilder(), 20);

        private StringBuilder _sb;
        private string _prefix;
        private string _suffix;
        private bool _isAtLineStart;
        private bool _dontSplitMultiLineValues;
        private List<(string prefix, string suffix)> _indentStack;

        private CodeBuilder()
        {
            _sb = new StringBuilder();
            _prefix = "";
            _suffix = "";
            _isAtLineStart = true;
            _dontSplitMultiLineValues = false;
            _indentStack = new List<(string prefix, string suffix)>();
        }

        public static CodeBuilder GetInstance()
        {
            return s_pool.Allocate();
        }

        public int Length => _sb.Length;
        public string Prefix => _prefix;
        public string Suffix => _suffix;
        public bool IsAtLineStart => _isAtLineStart;
        public bool DontSplitMultiLineValues 
        {
            get => _dontSplitMultiLineValues; 
            set => _dontSplitMultiLineValues = value; 
        }

        public void Free()
        {
            _sb.Clear();
            _prefix = "";
            _suffix = "";
            _isAtLineStart = true;
            _dontSplitMultiLineValues = false;
            _indentStack.Clear();
            s_pool.Free(this);
        }

        public void Push(string prefix = "    ", string suffix = "")
        {
            AppendLine();
            _indentStack.Add((_prefix, _suffix));
            _prefix += prefix;
            _suffix += suffix;
        }

        public void Pop()
        {
            if (_indentStack.Count == 0) return;//throw new InvalidOperationException("Push-Pop mismatch.");
            AppendLine();
            var indent = _indentStack[_indentStack.Count - 1];
            _indentStack.RemoveAt(_indentStack.Count - 1);
            _prefix = indent.prefix;
            _suffix = indent.suffix;
        }

        public void WritePrefix()
        {
            _sb.Append(_prefix);
            if (!string.IsNullOrEmpty(_prefix)) _isAtLineStart = IsLineEnd(_prefix[_prefix.Length - 1]);
        }

        public void WriteSuffix()
        {
            _sb.Append(_suffix);
            if (!string.IsNullOrEmpty(_suffix)) _isAtLineStart = IsLineEnd(_suffix[_suffix.Length - 1]);
        }

        public void Write(bool value)
        {
            BeginLine();
            _sb.Append(value);
            _isAtLineStart = false;
        }

        public void Write(byte value)
        {
            BeginLine();
            _sb.Append(value);
            _isAtLineStart = false;
        }

        public void Write(sbyte value)
        {
            BeginLine();
            _sb.Append(value);
            _isAtLineStart = false;
        }

        public void Write(short value)
        {
            BeginLine();
            _sb.Append(value);
            _isAtLineStart = false;
        }

        public void Write(int value)
        {
            BeginLine();
            _sb.Append(value);
            _isAtLineStart = false;
        }

        public void Write(long value)
        {
            BeginLine();
            _sb.Append(value);
            _isAtLineStart = false;
        }

        public void Write(ushort value)
        {
            BeginLine();
            _sb.Append(value);
            _isAtLineStart = false;
        }

        public void Write(uint value)
        {
            BeginLine();
            _sb.Append(value);
            _isAtLineStart = false;
        }

        public void Write(ulong value)
        {
            BeginLine();
            _sb.Append(value);
            _isAtLineStart = false;
        }

        public void Write(float value)
        {
            BeginLine();
            _sb.Append(value);
            _isAtLineStart = false;
        }

        public void Write(double value)
        {
            BeginLine();
            _sb.Append(value);
            _isAtLineStart = false;
        }

        public void Write(decimal value)
        {
            BeginLine();
            _sb.Append(value);
            _isAtLineStart = false;
        }

        public void Write(char value)
        {
            BeginLine();
            if (value == '\r' || (value == '\n' && _sb[_sb.Length - 1] != '\r'))
            {
                EndLine();
            }
            _sb.Append(value);
            _isAtLineStart = IsLineEnd(value);
        }

        public void Write(char[] value)
        {
            Write(value.AsSpan());
        }

        public void Write(ReadOnlySpan<char> value)
        {
            if (_dontSplitMultiLineValues)
            {
                WriteWithoutSplit(value);
            }
            else
            {
                bool first = true;
                var reader = new LineReader(value);
                while (!reader.EndOfStream)
                {
                    if (!first) EndLine();
                    var line = reader.ReadLine();
                    WriteWithoutSplit(line);
                    first = false;
                }
                if (reader.HasFinalLineEnd) AppendLine();
            }
        }

        private void WriteWithoutSplit(ReadOnlySpan<char> value)
        {
            BeginLine();
            _sb.Append(value);
            if (value.Length > 0) _isAtLineStart = IsLineEnd(value[value.Length - 1]);
        }

        public void Write(object? obj)
        {
            if (obj == null) return;
            else Write(obj.ToString());
        }

        public void Write(string? text)
        {
            if (text == null) return;
            Write(text.AsSpan());
        }

        public void Write(string format, params object[] args)
        {
            Write(string.Format(format, args));
        }

        public void WriteLine()
        {
            BeginLine();
            EndLine();
        }

        public void WriteLine(bool value)
        {
            Write(value);
            AppendLine();
        }

        public void WriteLine(byte value)
        {
            Write(value);
            AppendLine();
        }

        public void WriteLine(sbyte value)
        {
            Write(value);
            AppendLine();
        }

        public void WriteLine(short value)
        {
            Write(value);
            AppendLine();
        }

        public void WriteLine(int value)
        {
            Write(value);
            AppendLine();
        }

        public void WriteLine(long value)
        {
            Write(value);
            AppendLine();
        }

        public void WriteLine(ushort value)
        {
            Write(value);
            AppendLine();
        }

        public void WriteLine(uint value)
        {
            Write(value);
            AppendLine();
        }

        public void WriteLine(ulong value)
        {
            Write(value);
            AppendLine();
        }

        public void WriteLine(float value)
        {
            Write(value);
            AppendLine();
        }

        public void WriteLine(double value)
        {
            Write(value);
            AppendLine();
        }

        public void WriteLine(decimal value)
        {
            Write(value);
            AppendLine();
        }

        public void WriteLine(char value)
        {
            Write(value);
            AppendLine();
        }

        public void WriteLine(char[] value)
        {
            Write(value);
            AppendLine();
        }

        public void WriteLine(ReadOnlySpan<char> value)
        {
            Write(value);
            AppendLine();
        }

        public void WriteLine(object? obj)
        {
            Write(obj);
            AppendLine();
        }

        public void WriteLine(string? text)
        {
            Write(text);
            AppendLine();
        }

        public void WriteLine(string format, params object[] args)
        {
            Write(format, args);
            AppendLine();
        }

        public void AppendLine(bool force = false)
        {
            if (force || !_isAtLineStart)
            {
                WriteLine();
            }
        }

        private void BeginLine()
        {
            if (_isAtLineStart) WritePrefix();
        }

        private void EndLine()
        {
            WriteSuffix();
            _sb.AppendLine();
            _isAtLineStart = true;
        }

        private bool IsLineEnd(char ch)
        {
            return ch == '\r' || ch == '\n';
        }

        public override string ToString()
        {
            return _sb.ToString();
        }

        public string ToStringAndFree()
        {
            var result = _sb.ToString();
            Free();
            return result;
        }
    }
}
