using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Symbols
{
    public abstract class CSharpModelFactory
    {
        public abstract MetaDslx.Modeling.IModelObject? Create(Symbol container, ISymbol csharpSymbol, MetaDslx.Modeling.Model model, DiagnosticBag diagnostics, CancellationToken cancellationToken);
    }
}
