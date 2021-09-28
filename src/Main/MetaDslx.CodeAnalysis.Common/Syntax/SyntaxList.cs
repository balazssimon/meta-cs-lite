// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using Roslyn.Utilities;

namespace MetaDslx.CodeAnalysis.Syntax
{
    internal abstract partial class SyntaxList : SyntaxNode
    {
        internal SyntaxList(InternalSyntax.SyntaxList green, SyntaxNode? parent, int position)
            : base(green, parent, position)
        {
        }

        public override Language Language => this.Parent?.Language ?? Language.NoLanguage;

        protected override SyntaxTree CreateSyntaxTreeForRoot()
        {
            throw ExceptionUtilities.Unreachable;
        }

        public override TResult Accept<TArg, TResult>(SyntaxVisitor<TArg, TResult> visitor, TArg argument)
        {
            throw ExceptionUtilities.Unreachable;
        }

        public override TResult Accept<TResult>(SyntaxVisitor<TResult> visitor)
        {
            throw ExceptionUtilities.Unreachable;
        }

        public override void Accept(SyntaxVisitor visitor)
        {
            throw ExceptionUtilities.Unreachable;
        }
    }
}
