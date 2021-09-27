using Microsoft.CodeAnalysis.Text;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.CodeAnalysis
{
#pragma warning disable CA1200 // Avoid using cref tags with a prefix
    /// <summary>
    /// Represents a trivia in the syntax tree.
    /// </summary>
#pragma warning restore CA1200 // Avoid using cref tags with a prefix
    public readonly struct SyntaxTrivia : IEquatable<SyntaxTrivia>
    {
        public SyntaxTree SyntaxTree { get; }
        public TextSpan Span { get; }

        public bool Equals(SyntaxTrivia other)
        {
            throw new NotImplementedException();
        }
    }
}
