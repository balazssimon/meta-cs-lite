using MetaDslx.CodeAnalysis.Symbols;
using MetaDslx.Languages.MetaSymbols.Model;
using MetaDslx.Modeling;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MetaDslx.Languages.MetaSymbols.Compiler
{
    internal class SymbolModelFactory : CSharpModelFactory
    {
        private SymbolsModelMultiFactory _modelFactory = new SymbolsModelMultiFactory();

        public override IModelObject? Create(Modeling.Model model, ISymbol csharpSymbol, string? id = null)
        {
            var attrs = csharpSymbol.GetAttributes();
            if (attrs.Any(attr => attr.AttributeClass?.Name == "SymbolAttribute"/* && attr.AttributeClass.ContainingNamespace.ToDisplayString(Microsoft.CodeAnalysis.SymbolDisplayFormat.FullyQualifiedFormat) == "global::MetaDslx.CodeAnalysis.Symbols"*/))
            {
                var symbol = _modelFactory.Symbol(model, id);
                symbol.MRootNamespace = csharpSymbol.ContainingNamespace.ToDisplayString(Microsoft.CodeAnalysis.SymbolDisplayFormat.CSharpErrorMessageFormat);
                var name = csharpSymbol.Name;
                if (name is not null && name.EndsWith("Symbol") && name != "Symbol") name = name.Substring(0, name.Length - 6);
                symbol.Name = name;
                return symbol;
            }
            return null;
        }
    }
}
