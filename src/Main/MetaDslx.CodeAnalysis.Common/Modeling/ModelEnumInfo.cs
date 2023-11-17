using MetaDslx.CodeAnalysis;
using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.Modeling
{
    public abstract class ModelEnumInfo
    {
        protected abstract ImmutableDictionary<string, MetaSymbol> LiteralsByName { get; }

        public abstract MetaModel MetaModel { get; }
        public abstract MetaType MetaType { get; }
        public abstract ImmutableArray<string> Literals { get; }

        public bool TryGetValue(string literal, out MetaSymbol value)
        {
            return LiteralsByName.TryGetValue(literal, out value);
        }
    }
}
