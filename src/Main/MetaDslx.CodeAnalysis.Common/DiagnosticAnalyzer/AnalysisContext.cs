// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis.Diagnostics
{
    /// <summary>
    /// Context for initializing an analyzer.
    /// Analyzer initialization can use an <see cref="AnalysisContext"/> to register actions to be executed at any of:
    /// <list type="bullet">
    /// <item>
    /// <description>compilation start,</description>
    /// </item>
    /// <item>
    /// <description>compilation end,</description>
    /// </item>
    /// <item>
    /// <description>completion of parsing a code document,</description>
    /// </item>
    /// <item>
    /// <description>completion of semantic analysis of a code document,</description>
    /// </item>
    /// <item>
    /// <description>completion of semantic analysis of a symbol,</description>
    /// </item>
    /// <item>
    /// <description>start of semantic analysis of a method body or an expression appearing outside a method body,</description>
    /// </item>
    /// <item>
    /// <description>completion of semantic analysis of a method body or an expression appearing outside a method body, or</description>
    /// </item>
    /// <item>
    /// <description>completion of semantic analysis of a syntax node.</description>
    /// </item>
    /// </list>
    /// </summary>
    public abstract class AnalysisContext

    {
    }
}
