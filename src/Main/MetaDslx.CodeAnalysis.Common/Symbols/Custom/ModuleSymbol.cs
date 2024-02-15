using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Threading;
using MetaDslx.Modeling;
using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.Symbols;

namespace MetaDslx.CodeAnalysis.Symbols.__Impl
{
    public class ModuleSymbolImpl : ModuleSymbolBase
    {
        public override NamespaceSymbol Complete_GlobalNamespace(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public override NamespaceSymbol GetRootNamespace(SyntaxTree syntaxTree)
        {
            throw new NotImplementedException();
        }
    }
}
