using MetaDslx.CodeAnalysis.PooledObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis.Symbols
{
    public class SymbolDisplayFormat
    {
        public static readonly SymbolDisplayFormat Default = new SymbolDisplayFormat(includeSymbolKind: true);
        public static readonly SymbolDisplayFormat QualifiedNameOnlyFormat = new SymbolDisplayFormat(includeQualifier: true);
        public static readonly SymbolDisplayFormat FullyQualifiedFormat = new SymbolDisplayFormat(includeQualifier: true, includeGlobalScope: true);

        private readonly bool _includeSymbolKind;
        private readonly bool _includeQualifier;
        private readonly bool _includeGlobalScope;

        protected SymbolDisplayFormat(bool includeSymbolKind = false, bool includeQualifier = false, bool includeGlobalScope = false) 
        {
            _includeSymbolKind = includeSymbolKind;
            _includeQualifier = includeQualifier;
            _includeGlobalScope = includeGlobalScope;
        }

        public bool IncludeSymbolKind => _includeSymbolKind;
        public bool IncludeQualifier => _includeQualifier;
        public bool IncludeGlobalScope => _includeGlobalScope;
    }

}
