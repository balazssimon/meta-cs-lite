using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis.Binding
{
    public class ConstantBinder : Binder, IValueBinder
    {
        private readonly object? _value;

        public ConstantBinder(object? value)
        {
            _value = value;
        }

        public object? Value => _value;
    }
}
