﻿using System;
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
        Keyword,
        Number,
        Character,
        String,
        VerbatimString,
        ControlCode,
        Other
    }
}