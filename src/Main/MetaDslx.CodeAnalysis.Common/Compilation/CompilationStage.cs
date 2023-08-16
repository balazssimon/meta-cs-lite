using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis
{
    /// <summary>
    /// Represents the possible compilation stages for which it is possible to get diagnostics
    /// (errors).
    /// </summary>
    public enum CompilationStage
    {
        Parse,
        Declare,
        Compile,
        Emit
    }
}
