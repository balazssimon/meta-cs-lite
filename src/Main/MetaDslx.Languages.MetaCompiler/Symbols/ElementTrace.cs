using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Languages.MetaCompiler.Symbols
{
    [DebuggerDisplay("{ToDebugString()}")]
    internal class ElementTrace
    {
        private readonly PElementSymbol _element;
        private readonly ImmutableArray<ElementTrace> _next;

        public ElementTrace(PElementSymbol element, ImmutableArray<ElementTrace> next)
        {
            _element = element;
            _next = next;
        }

        public PElementSymbol Element => _element;
        public ImmutableArray<ElementTrace> Next => _next;

        public override string ToString()
        {
            return $"{_element}";
        }

        private string ToDebugString()
        {
            return $"{_element}[{_next.Length}]";
        }
    }
}
