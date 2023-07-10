﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis.Binding
{
    public class ValueBinder : Binder, IValueBinder
    {
        private readonly Type? _type;

        public ValueBinder(Type? type)
        {
            _type = type;
        }

        public Type? Type => _type;
    }
}
