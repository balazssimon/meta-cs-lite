using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.Languages.MetaCompiler.Syntax
{
    public enum MetaCompilerTokenKind
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
        Number,
        String,
        VerbatimString,
        Other
    }
}
