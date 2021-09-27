using Microsoft.CodeAnalysis.Text;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.CodeAnalysis
{
#pragma warning disable CA1200 // Avoid using cref tags with a prefix
    /// <summary>
    /// Represents a token in the syntax tree. This is the language agnostic equivalent of <see
    /// cref="T:Microsoft.CodeAnalysis.CSharp.SyntaxToken"/> and <see cref="T:Microsoft.CodeAnalysis.VisualBasic.SyntaxToken"/>.
    /// </summary>
#pragma warning restore CA1200 // Avoid using cref tags with a prefix
    public readonly struct SyntaxToken : IEquatable<SyntaxToken>
    {
        public SyntaxTree SyntaxTree { get; }
        public TextSpan Span { get; }

        public bool Equals(SyntaxToken other)
        {
            throw new NotImplementedException();
        }
    }
}
