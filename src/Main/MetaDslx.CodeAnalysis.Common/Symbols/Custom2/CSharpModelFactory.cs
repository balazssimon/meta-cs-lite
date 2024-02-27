using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace MetaDslx.CodeAnalysis.Symbols
{
    public abstract class CSharpModelFactory
    {
        public abstract MetaDslx.Modeling.IModelObject? Create(MetaDslx.Modeling.Model model, ISymbol csharpSymbol, string? id = null);
    }
}
