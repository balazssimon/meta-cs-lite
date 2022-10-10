using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Text;

namespace MetaDslx.Modeling
{
    [Flags]
    public enum ModelValidationFlags
    {
        None = 0x00,
        Nullable = 0x01,
        Readonly = 0x02,
    }
}
