﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace MetaDslx.CodeAnalysis
{
#pragma warning disable CA1200 // Avoid using cref tags with a prefix
    /// <summary>
    /// Represents structured trivia that contains skipped tokens. This is implemented by
    /// <see cref="T:MetaDslx.CodeAnalysis.CSharp.Syntax.SkippedTokensTriviaSyntax"/> and
    /// <see cref="T:MetaDslx.CodeAnalysis.VisualBasic.Syntax.SkippedTokensTriviaSyntax"/>.
    /// </summary>
#pragma warning restore CA1200 // Avoid using cref tags with a prefix
    public interface ISkippedTokensTriviaSyntax
    {
        SyntaxTokenList Tokens { get; }
    }
}
