using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis.Binding.Lookup
{
    public static class LookupValidators
    {
        public static readonly ILookupValidator TypeOnly = new LookupTypeOnlyValidator();
        public static readonly ILookupValidator NamespaceOnly = new LookupNamespaceOnlyValidator();
        public static readonly ILookupValidator NamespaceOrTypeOnly = new LookupNamespaceOrTypeOnlyValidator();
    }
}
