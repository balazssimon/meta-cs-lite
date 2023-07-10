using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis.Binding
{
    public class NestingBinder : Binder
    {
        private readonly Type? _type;
        private readonly string? _property;

        public NestingBinder(Type type, string property)
        {
            _type = type;
            _property = property;
        }

        public Type? Type => _type;
        public string? Property => _property;
    }
}
