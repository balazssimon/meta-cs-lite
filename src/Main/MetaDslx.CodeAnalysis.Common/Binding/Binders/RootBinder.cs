using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis.Binding
{
    public class RootBinder : Binder, IValueBinder
    {
        private readonly Type? _type;

        public RootBinder(Type? type = null)
        {
            _type = type;
        }

        public Type? Type => _type;
    }
}
