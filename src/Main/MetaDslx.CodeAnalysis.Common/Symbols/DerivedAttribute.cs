using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis.Symbols
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Method, AllowMultiple = false)]
    public class DerivedAttribute : Attribute
    {
        public bool Cached { get; set; }
        public string? Condition { get; set; }
    }
}
