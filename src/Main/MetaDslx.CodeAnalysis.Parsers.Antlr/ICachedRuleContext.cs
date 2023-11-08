using MetaDslx.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis.Parsers.Antlr
{
    public interface ICachedRuleContext
    {
        GreenNode CachedNode { get; }
    }
}
