using MetaDslx.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.Languages.MetaCompiler.Model
{
    public interface IElementWithLocation
    {
        Location Location { get; }
    }
}
