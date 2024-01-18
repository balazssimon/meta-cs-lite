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
        TemplateOutputLineStart,
        TemplateOutput,
        TemplateControl,
        TemplateFormatter,
        TemplateEnd,
        End,
        Eof
    }
}
