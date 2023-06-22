using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.Languages.MetaCompiler.Annotations
{
    [Flags]
    public enum AnnotationTargets
    {
        None = 0,
        LexerRule = 0x0001,
        ParserRule = 0x0002
    }
}
