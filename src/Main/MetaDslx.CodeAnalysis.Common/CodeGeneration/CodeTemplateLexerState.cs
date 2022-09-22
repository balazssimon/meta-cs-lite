using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis.CodeGeneration
{
    public enum CodeTemplateLexerState
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
        TemplateEnd,
        End,
        Eof
    }
}
