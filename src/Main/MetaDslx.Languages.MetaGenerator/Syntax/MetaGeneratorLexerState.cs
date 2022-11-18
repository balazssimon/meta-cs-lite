using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.Languages.MetaGenerator.Syntax
{
    public enum MetaGeneratorLexerState
    {
        None,
        ControlBeginWs,
        ControlBegin,
        ControlEndWs,
        ControlEnd,
        TemplateHeader,
        TemplateHeaderEnd,
        TemplateOutput,
        TemplateControl,
        TemplateControlContextual,
        TemplateEnd,
        End,
        Eof
    }
}
