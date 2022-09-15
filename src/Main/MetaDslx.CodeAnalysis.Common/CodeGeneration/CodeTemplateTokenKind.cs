using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Text;

namespace MetaDslx.CodeAnalysis.CodeGeneration
{
    public enum CodeTemplateTokenKind
    {
        Identifier,
        Keyword,
        String,
        Number,
        TemplateOutput,
        Other
    }
}
