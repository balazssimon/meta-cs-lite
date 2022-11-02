using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Text;

namespace MetaDslx.Languages.MetaGenerator
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
        GeneratorKeyword,
        String,
        VerbatimString,
        Number,
        TemplateOutput,
        TemplateControlBegin,
        TemplateControlEnd,
        Other
    }
}
