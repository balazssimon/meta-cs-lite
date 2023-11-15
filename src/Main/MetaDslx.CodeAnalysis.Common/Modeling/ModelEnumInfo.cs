using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.Modeling
{
    public abstract class ModelEnumInfo
    {
        protected abstract ImmutableDictionary<string, Enum> LiteralsByName { get; }

        public abstract MetaModel MetaModel { get; }
        public abstract Type MetaType { get; }
        public abstract ImmutableArray<string> Literals { get; }

        public bool TryGetValue(string literal, out Enum value)
        {
            return LiteralsByName.TryGetValue(literal, out value);
        }
    }
}
