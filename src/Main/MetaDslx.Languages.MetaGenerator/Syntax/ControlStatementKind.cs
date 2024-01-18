using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.Languages.MetaGenerator.Syntax
{
    public enum ControlStatementKind
    {
        None,
        Expression,
        Statement,
        StatementWithSemicolon,
        BeginStatement,
        EndStatement,
        TemplateControlEnd
    }
}
