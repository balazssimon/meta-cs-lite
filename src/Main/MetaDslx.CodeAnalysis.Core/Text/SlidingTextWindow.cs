﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using MetaDslx.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace MetaDslx.CodeAnalysis.Text
{
    /// <summary>
    /// Keeps a sliding buffer over the SourceText of a file for the lexer. Also
    /// provides the lexer with the ability to keep track of a current "lexeme"
    /// by leaving a marker and advancing ahead the offset. The lexer can then
    /// decide to "keep" the lexeme by erasing the marker, or abandon the current
    /// lexeme by moving the offset back to the marker.
    /// </summary>
    public sealed class SlidingTextWindow : IDisposable
    {
        /// <summary>
        /// In many cases, e.g. PeekChar, we need the ability to indicate that there are
        /// no characters left and we have reached the end of the stream, or some other
        /// invalid or not present character was asked for. Due to perf concerns, things
        /// like nullable or out variables are not viable. Instead we need to choose a
        /// char value which can never be legal.
        /// 
        /// In .NET, all characters are represented in 16 bits using the UTF-16 encoding.
        /// Fortunately for us, there are a variety of different bit patterns which
        /// are *not* legal UTF-16 characters. 0xffff (char.MaxValue) is one of these
        /// characters -- a legal Unicode code point, but not a legal UTF-16 bit pattern.
        /// </summary>
        public const char InvalidCharacter = char.MaxValue;

        private const int DefaultWindowLength = 2048;

        private readonly SourceText _text;                 // Source of text to parse.
        private int _basis;                                // Offset of the window relative to the SourceText start.
        private int _offset;                               // Offset from the start of the window.
        private readonly int _textEnd;                     // Absolute end position
        private char[] _characterWindow;                   // Moveable window of chars from source text
        private int _characterWindowCount;                 // # of valid characters in chars buffer

        private int _lexemeStart;                          // Start of current lexeme relative to the window start.

        private int _minLexemeLookahead;
        private int _maxLexemeLookahead;
        private int _minLookahead;
        private int _maxLookahead;

        // Example for the above variables:
        // The text starts at 0.
        // The window onto the text starts at basis.
        // The current character is at (basis + offset), AKA the current "Position".
        // The current lexeme started at (basis + lexemeStart), which is <= (basis + offset)
        // The current lexeme is the characters between the lexemeStart and the offset.

        private readonly StringTable _strings;

        private static readonly char[] s_disposedWindow = new char[0];
        private static readonly ObjectPool<char[]> s_windowPool = new ObjectPool<char[]>(() => new char[DefaultWindowLength]);

        public SlidingTextWindow(SourceText text)
        {
            _text = text;
            _basis = 0;
            _offset = 0;
            _textEnd = text.Length;
            _strings = StringTable.GetInstance();
            _characterWindow = s_windowPool.Allocate();
            _lexemeStart = 0;
            _minLookahead = int.MaxValue;
            _maxLookahead = int.MinValue;
            _minLexemeLookahead = int.MaxValue;
            _maxLexemeLookahead = int.MinValue;
        }

        public void Dispose()
        {
            if (_characterWindow != null)
            {
                s_windowPool.Free(_characterWindow);
                _characterWindow = s_disposedWindow;
                _strings.Free();
            }
        }

        public SourceText SourceText => _text;

        /// <summary>
        /// The current absolute position in the text file.
        /// </summary>
        public int Position
        {
            get
            {
                return _basis + _offset;
            }
        }

        /// <summary>
        /// The current offset inside the window (relative to the window start).
        /// </summary>
        public int Offset
        {
            get
            {
                return _offset;
            }
        }

        /// <summary>
        /// The buffer backing the current window.
        /// </summary>
        public char[] CharacterWindow
        {
            get
            {
                return _characterWindow;
            }
        }

        /// <summary>
        /// Returns the start of the current lexeme relative to the window start.
        /// </summary>
        public int LexemeRelativeStart
        {
            get
            {
                return _lexemeStart;
            }
        }

        /// <summary>
        /// Number of characters in the character window.
        /// </summary>
        public int CharacterWindowCount
        {
            get
            {
                return _characterWindowCount;
            }
        }

        /// <summary>
        /// The absolute position of the start of the current lexeme in the given
        /// SourceText.
        /// </summary>
        public int LexemeStartPosition
        {
            get
            {
                return _basis + _lexemeStart;
            }
        }

        /// <summary>
        /// The number of characters in the current lexeme.
        /// </summary>
        public int Width
        {
            get
            {
                return _offset - _lexemeStart;
            }
        }

        public int MinLookahead => _minLookahead;
        public int MaxLookahead => _maxLookahead;
        public int MinLexemeLookahead => _minLexemeLookahead;
        public int MaxLexemeLookahead => _maxLexemeLookahead;

        /// <summary>
        /// Start parsing a new lexeme.
        /// </summary>
        public void Start()
        {
            _lexemeStart = _offset;
            _minLexemeLookahead = int.MaxValue;
            _maxLexemeLookahead = int.MinValue;
        }

        public void ResetTo(int position)
        {
            // if position is within already read character range then just use what we have
            int relative = position - _basis;
            if (relative >= 0 && relative <= _characterWindowCount)
            {
                _offset = relative;
            }
            else
            {
                // we need to reread text buffer
                int amountToRead = Math.Min(_text.Length, position + _characterWindow.Length) - position;
                amountToRead = Math.Max(amountToRead, 0);
                if (amountToRead > 0)
                {
                    _text.CopyTo(position, _characterWindow, 0, amountToRead);
                }

                _lexemeStart = 0;
                _offset = 0;
                _basis = position;
                _characterWindowCount = amountToRead;
            }
        }

        private bool MoreChars(int delta = 0)
        {
            if (_offset + delta < 0) throw new ArgumentOutOfRangeException(nameof(delta), $"Offset+delta value cannot be negative.");
            if (_offset + delta >= _characterWindowCount)
            {
                if (this.Position + delta >= _textEnd)
                {
                    return false;
                }

                // if lexeme scanning is sufficiently into the char buffer, 
                // then refocus the window onto the lexeme
                if (_lexemeStart > (_characterWindowCount / 4))
                {
                    Array.Copy(_characterWindow,
                        _lexemeStart,
                        _characterWindow,
                        0,
                        _characterWindowCount - _lexemeStart);
                    _characterWindowCount -= _lexemeStart;
                    _offset -= _lexemeStart;
                    _basis += _lexemeStart;
                    _lexemeStart = 0;
                }

                if (_characterWindowCount >= _characterWindow.Length)
                {
                    // grow char array, since we need more contiguous space
                    char[] oldWindow = _characterWindow;
                    char[] newWindow = new char[_characterWindow.Length * 2];
                    Array.Copy(oldWindow, 0, newWindow, 0, _characterWindowCount);
                    s_windowPool.ForgetTrackedObject(oldWindow, newWindow);
                    _characterWindow = newWindow;
                }

                int amountToRead = Math.Min(_textEnd - (_basis + _characterWindowCount),
                    _characterWindow.Length - _characterWindowCount);
                _text.CopyTo(_basis + _characterWindowCount,
                    _characterWindow,
                    _characterWindowCount,
                    amountToRead);
                _characterWindowCount += amountToRead;
                return amountToRead > 0;
            }

            return true;
        }

        /// <summary>
        /// After reading <see cref=" InvalidCharacter"/>, a consumer can determine
        /// if the InvalidCharacter was in the user's source or a sentinel.
        /// 
        /// Comments and string literals are allowed to contain any Unicode character.
        /// </summary>
        /// <returns></returns>
        public bool IsReallyAtEnd()
        {
            return _offset >= _characterWindowCount && Position >= _textEnd;
        }

        /// <summary>
        /// Advance the current position by one. No guarantee that this
        /// position is valid.
        /// </summary>
        public void AdvanceChar()
        {
            _offset++;
        }

        /// <summary>
        /// Advance the current position by n. No guarantee that this position
        /// is valid.
        /// </summary>
        public void AdvanceChar(int n)
        {
            _offset += n;
        }

        /// <summary>
        /// Grab the next character and advance the position.
        /// </summary>
        /// <returns>
        /// The next character, <see cref="InvalidCharacter" /> if there were no characters 
        /// remaining.
        /// </returns>
        public char NextChar()
        {
            char c = PeekChar();
            if (c != InvalidCharacter)
            {
                this.AdvanceChar();
            }
            return c;
        }

        /// <summary>
        /// Gets the next character if there are any characters in the 
        /// SourceText. May advance the window if we are at the end.
        /// </summary>
        /// <returns>
        /// The next character if any are available. InvalidCharacter otherwise.
        /// </returns>
        public char PeekChar()
        {
            _minLexemeLookahead = Math.Min(_minLexemeLookahead, 1);
            _maxLexemeLookahead = Math.Max(_maxLexemeLookahead, 1);
            _minLookahead = Math.Min(_minLookahead, _minLexemeLookahead);
            _maxLookahead = Math.Max(_maxLookahead, _maxLexemeLookahead);

            if (_offset >= _characterWindowCount && !MoreChars())
            {
                return InvalidCharacter;
            }

            // N.B. MoreChars may update the offset.
            return _characterWindow[_offset];
        }

        /// <summary>
        /// Gets the character at the given offset to the current position if
        /// the position is valid within the SourceText.
        /// </summary>
        /// <returns>
        /// The next character if any are available. InvalidCharacter otherwise.
        /// </returns>
        public char PeekChar(int delta)
        {
            _minLexemeLookahead = Math.Min(_minLexemeLookahead, delta + 1);
            _maxLexemeLookahead = Math.Max(_maxLexemeLookahead, delta + 1);
            _minLookahead = Math.Min(_minLookahead, _minLexemeLookahead);
            _maxLookahead = Math.Max(_maxLookahead, _maxLexemeLookahead);

            char ch;
            if (_offset + delta >= _characterWindowCount && !MoreChars(delta))
            {
                ch = InvalidCharacter;
            }
            else
            {
                // N.B. MoreChars may update the offset.
                ch = _characterWindow[_offset + delta];
            }

            return ch;
        }

        /// <summary>
        /// If the next characters in the window match the given string,
        /// then advance past those characters.  Otherwise, do nothing.
        /// </summary>
        public bool AdvanceIfMatches(string desired)
        {
            int length = desired.Length;

            for (int i = 0; i < length; i++)
            {
                if (PeekChar(i) != desired[i])
                {
                    return false;
                }
            }

            AdvanceChar(length);
            return true;
        }

        private SyntaxDiagnosticInfo CreateIllegalEscapeDiagnostic(int start)
        {
            return new SyntaxDiagnosticInfo(start - this.LexemeStartPosition,
                this.Position - start,
                ErrorCode.ERR_IllegalEscape);
        }

        public string Intern(StringBuilder text)
        {
            return _strings.Add(text);
        }

        public string Intern(char[] array, int start, int length)
        {
            return _strings.Add(array, start, length);
        }

        public string GetInternedText()
        {
            return this.Intern(_characterWindow, _lexemeStart, this.Width);
        }

        public string GetText(bool intern)
        {
            return this.GetText(this.LexemeStartPosition, this.Width, intern);
        }

        public string GetText(int position, int length, bool intern)
        {
            int offset = position - _basis;

            // PERF: Whether interning or not, there are some frequently occurring
            // easy cases we can pick off easily.
            switch (length)
            {
                case 0:
                    return string.Empty;

                case 1:
                    if (_characterWindow[offset] == ' ')
                    {
                        return " ";
                    }
                    if (_characterWindow[offset] == '\n')
                    {
                        return "\n";
                    }
                    break;

                case 2:
                    char firstChar = _characterWindow[offset];
                    if (firstChar == '\r' && _characterWindow[offset + 1] == '\n')
                    {
                        return "\r\n";
                    }
                    if (firstChar == '/' && _characterWindow[offset + 1] == '/')
                    {
                        return "//";
                    }
                    break;

                case 3:
                    if (_characterWindow[offset] == '/' && _characterWindow[offset + 1] == '/' && _characterWindow[offset + 2] == ' ')
                    {
                        return "// ";
                    }
                    break;
            }

            if (intern)
            {
                return this.Intern(_characterWindow, offset, length);
            }
            else
            {
                return new string(_characterWindow, offset, length);
            }
        }

        internal static char GetCharsFromUtf32(uint codepoint, out char lowSurrogate)
        {
            if (codepoint < (uint)0x00010000)
            {
                lowSurrogate = InvalidCharacter;
                return (char)codepoint;
            }
            else
            {
                Debug.Assert(codepoint > 0x0000FFFF && codepoint <= 0x0010FFFF);
                lowSurrogate = (char)((codepoint - 0x00010000) % 0x0400 + 0xDC00);
                return (char)((codepoint - 0x00010000) / 0x0400 + 0xD800);
            }
        }
    }
}
