using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis.Symbols
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Method, AllowMultiple = false)]
    public class PhaseAttribute : Attribute
    {
        private readonly string _name;

        public PhaseAttribute(string? name = null)
        {
            _name = name;
        }

        public string Name => _name;
    }
}
