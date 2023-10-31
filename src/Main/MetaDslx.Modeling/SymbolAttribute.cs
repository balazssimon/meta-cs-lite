using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.Modeling
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface)]
    public class SymbolAttribute : Attribute
    {
        private readonly Type _symbolType;

        public SymbolAttribute(Type symbolType)
        {
            _symbolType = symbolType;
        }

        public Type SymbolType => _symbolType;
    }
}
