using MetaDslx.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.Languages.MetaCompiler.Antlr
{
    public interface ICachedRuleContext
    {
        GreenNode CachedNode { get; }
    }
}
