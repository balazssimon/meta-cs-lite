using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.Modeling
{
    [AttributeUsage(AttributeTargets.Property)]
    public class SymbolPropertyAttribute : Attribute
    {
        private readonly string _propertyName;

        public SymbolPropertyAttribute(string propertyName)
        {
            _propertyName = propertyName;
        }

        public string PropertyName => _propertyName;
    }
}
