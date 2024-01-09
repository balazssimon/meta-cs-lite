using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Text;

namespace MetaDslx.Languages.MetaGenerator.Syntax
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
        TemplateOutputText,
        TemplateOutputWhitespace,
        TemplateControlBegin,
        TemplateControlEnd,
        Other
    }
}
