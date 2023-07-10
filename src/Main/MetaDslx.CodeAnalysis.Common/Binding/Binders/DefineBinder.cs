using MetaDslx.CodeAnalysis.Syntax.InternalSyntax;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis.Binding
{
    public class DefineBinder : Binder, IValueBinder
    {
        private readonly Type? _type;

        public DefineBinder(Type? type = null)
        {
            _type = type;
        }

        public Type? Type => _type;
    }
}
