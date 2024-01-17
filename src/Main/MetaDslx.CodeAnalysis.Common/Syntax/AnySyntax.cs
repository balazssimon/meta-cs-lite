using MetaDslx.CodeAnalysis.Syntax.InternalSyntax;
using MetaDslx.CodeAnalysis.Text;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis
{
    public struct AnySyntax : IEquatable<AnySyntax>
    {
        private SyntaxNode? _syntaxNode;
        private SyntaxToken _syntaxToken;

        public AnySyntax(SyntaxNodeOrToken syntaxNodeOrToken)
        {
            if (syntaxNodeOrToken.IsNode) _syntaxNode = syntaxNodeOrToken.AsNode();
            else _syntaxToken = syntaxNodeOrToken.AsToken();
        }

        public AnySyntax(SyntaxNode syntaxNode)
        {
            _syntaxNode = syntaxNode;
        }

        public AnySyntax(SyntaxToken syntaxToken)
        {
            _syntaxToken = syntaxToken;
        }

        public bool IsNode => _syntaxNode is not null && _syntaxNode.RawKind != (int)InternalSyntaxKind.List;

        public bool IsList => _syntaxNode is not null && _syntaxNode.RawKind == (int)InternalSyntaxKind.List;

        public bool IsToken => _syntaxToken.RawKind != (int)InternalSyntaxKind.None;

        public bool IsNull => _syntaxNode is null || _syntaxToken.RawKind == (int)InternalSyntaxKind.None;

        public SyntaxNode? AsNode() => _syntaxNode;

        public SyntaxToken AsToken() => _syntaxToken;

        public SyntaxList<TNode> AsList<TNode>()
            where TNode : SyntaxNode
        {
            return IsList ? new SyntaxList<TNode>(_syntaxNode) : default;
        }

        public SeparatedSyntaxList<TNode> AsSeparatedList<TNode>(bool reversed)
            where TNode : SyntaxNode
        {
            return IsList ? new SeparatedSyntaxList<TNode>(_syntaxNode, 0, reversed) : default;
        }

        public Language Language => _syntaxNode?.Language ?? _syntaxToken.Language;

        public SyntaxTree SyntaxTree => _syntaxNode?.SyntaxTree ?? _syntaxToken.SyntaxTree;

        public TextSpan Span => _syntaxNode?.Span ?? _syntaxToken.Span;

        public TextSpan FullSpan => _syntaxNode?.FullSpan ?? _syntaxToken.FullSpan;

        public int SpanStart => _syntaxNode?.SpanStart ?? _syntaxToken.SpanStart;

        public int RawKind => _syntaxNode?.RawKind ?? _syntaxToken.RawKind;

        public bool IsMissing => _syntaxNode?.IsMissing ?? _syntaxToken.IsMissing;

        public bool ContainsDiagnostics => _syntaxNode?.ContainsDiagnostics ?? _syntaxToken.ContainsDiagnostics;

        public IEnumerable<Diagnostic> GetDiagnostics() => _syntaxNode?.GetDiagnostics() ?? _syntaxToken.GetDiagnostics();

        public Location? GetLocation() => _syntaxNode?.GetLocation() ?? _syntaxToken.GetLocation();

        public int Width => _syntaxNode?.Width ?? _syntaxToken.Width;

        public int FullWidth => _syntaxNode?.FullWidth ?? _syntaxToken.FullWidth;

        public int EndPosition => _syntaxNode?.EndPosition ?? _syntaxToken.EndPosition;

        /// <summary>
        /// Determines whether two <see cref="AnySyntax"/>es are equal.
        /// </summary>
        public static bool operator ==(AnySyntax left, AnySyntax right)
        {
            return left.Equals(right);
        }

        /// <summary>
        /// Determines whether two <see cref="AnySyntax"/>es are unequal.
        /// </summary>
        public static bool operator !=(AnySyntax left, AnySyntax right)
        {
            return !left.Equals(right);
        }

        public bool Equals(AnySyntax other)
        {
            return other._syntaxNode == _syntaxNode && other._syntaxToken == _syntaxToken;
        }

        public override bool Equals(object obj)
        {
            if (obj is AnySyntax otherSyntax) return Equals(otherSyntax);
            else return false;
        }

        /// <summary>
        /// Serves as hash function for <see cref="AnySyntax"/>.
        /// </summary>
        public override int GetHashCode()
        {
            return _syntaxNode?.GetHashCode() ?? _syntaxToken.GetHashCode();
        }

        public override string ToString()
        {
            return _syntaxNode?.ToString() ?? _syntaxToken.ToString();
        }

        public string ToFullString()
        {
            return _syntaxNode?.ToFullString() ?? _syntaxToken.ToFullString();
        }
    }
}
