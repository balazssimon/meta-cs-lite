using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis.Annotations
{
    public interface IScopeAnnotation
    {
        bool IsLocal { get; }
    }
}
