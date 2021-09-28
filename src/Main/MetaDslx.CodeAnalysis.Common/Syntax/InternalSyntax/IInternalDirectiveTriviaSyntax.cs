using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis.Syntax.InternalSyntax
{
    public interface IInternalDirectiveTriviaSyntax
    {
        Directive Directive { get; }
    }
}
