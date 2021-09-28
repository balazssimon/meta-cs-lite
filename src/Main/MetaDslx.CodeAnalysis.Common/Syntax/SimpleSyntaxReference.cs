// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using MetaDslx.CodeAnalysis.Text;
using System;
using System.Threading;

namespace MetaDslx.CodeAnalysis
{
    /// <summary>
    /// this is a basic do-nothing implementation of a syntax reference
    /// </summary>
    public class SimpleSyntaxReference : SyntaxReference
    {
        private readonly SyntaxNodeOrToken _nodeOrToken;

        public SimpleSyntaxReference(SyntaxNodeOrToken nodeOrToken)
        {
            if (nodeOrToken.SyntaxTree == null) throw new ArgumentException("The node or token must be part of a syntax tree.", nameof(nodeOrToken));
            _nodeOrToken = nodeOrToken;
        }

        public override SyntaxTree SyntaxTree
        {
            get
            {
                return _nodeOrToken.SyntaxTree!;
            }
        }

        public override TextSpan Span
        {
            get
            {
                return _nodeOrToken.Span;
            }
        }

        public override SyntaxNodeOrToken GetSyntax(CancellationToken cancellationToken)
        {
            return _nodeOrToken;
        }
    }
}
