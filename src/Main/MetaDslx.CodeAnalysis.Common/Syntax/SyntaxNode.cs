using Microsoft.CodeAnalysis.Text;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.CodeAnalysis
{
    public class SyntaxNode
    {
        public SyntaxTree SyntaxTree { get; }
        public TextSpan Span { get; }
    }
}
