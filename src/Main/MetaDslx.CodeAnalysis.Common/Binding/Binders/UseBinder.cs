using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.CodeAnalysis.Binding
{
    public class UseBinder : Binder, IValueBinder
    {
        private readonly ImmutableArray<Type> _types;

        public UseBinder(ImmutableArray<Type> types)
        {
            _types = types;
        }

        public ImmutableArray<Type> Types => _types;
        public List<Type> TypesList { get; }
    }
}
