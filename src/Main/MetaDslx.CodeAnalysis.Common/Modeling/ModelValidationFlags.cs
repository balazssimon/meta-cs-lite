using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Text;

namespace MetaDslx.Modeling
{
    [Flags]
    internal enum ModelValidationFlags
    {
        None = 0x00,
        IsDefault = 0x01,
        Nullable = 0x02,
        ReadOnly = 0x04,
        FullPropertyStack = 0x08,

        All = Nullable | ReadOnly | FullPropertyStack
    }
}
