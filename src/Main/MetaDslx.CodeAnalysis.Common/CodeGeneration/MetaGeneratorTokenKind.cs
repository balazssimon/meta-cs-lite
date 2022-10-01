using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Text;

namespace MetaDslx.CodeAnalysis.CodeGeneration
{
    public enum MetaGeneratorTokenKind
    {
        None,
        EndOfFile,
        Whitespace,
        EndOfLine,
        SingleLineComment,
        MultiLineComment,
        Identifier,
        VerbatimIdentifier,
        Keyword,
        String,
        VerbatimString,
        Number,
        TemplateOutput,
        TemplateControlBegin,
        TemplateControlEnd,
        Other
    }
}
