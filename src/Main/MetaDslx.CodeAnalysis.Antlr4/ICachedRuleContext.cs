using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis.Antlr4
{
    public interface ICachedRuleContext
    {
        GreenNode CachedNode { get; }
    }
}
