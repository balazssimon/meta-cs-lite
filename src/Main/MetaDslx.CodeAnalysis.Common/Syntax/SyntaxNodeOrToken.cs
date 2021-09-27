using Microsoft.CodeAnalysis.Text;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.CodeAnalysis
{
    /// <summary>
    /// A wrapper for either a syntax node (<see cref="SyntaxNode"/>) or a syntax token (<see
    /// cref="SyntaxToken"/>).
    /// </summary>
    /// <remarks>
    /// Note that we do not store the token directly, we just store enough information to reconstruct it.
    /// This allows us to reuse nodeOrToken as a token's parent.
    /// </remarks>
    public readonly struct SyntaxNodeOrToken : IEquatable<SyntaxNodeOrToken>
    {
        public SyntaxTree SyntaxTree { get; }
        public TextSpan Span { get; }

        public bool Equals(SyntaxNodeOrToken other)
        {
            throw new NotImplementedException();
        }
    }
}
