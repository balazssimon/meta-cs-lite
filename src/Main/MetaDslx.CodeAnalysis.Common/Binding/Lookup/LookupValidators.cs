using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis.Binding.Lookup
{
    public static class LookupValidators
    {
        public static readonly ILookupValidator TypeOnly = new LookupTypeOnlyValidator();
    }
}
