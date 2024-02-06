using MetaDslx.CodeAnalysis.Binding;
using MetaDslx.CodeAnalysis.Symbols;
using MetaDslx.Languages.MetaModel.Compiler.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MetaDslx.Languages.MetaModel.Compiler
{
    internal class SymbolPropertyBinder : UseBinder
    {
        protected override void AdjustFinalLookupContext(LookupContext context)
        {
            if (context.Qualifier is not null) return;
            var propertySyntax = this.Syntax.Parent?.Parent as MetaPropertySyntax;
            var classSyntax = propertySyntax?.Parent?.Parent as MetaClassSyntax;
            var symbolSyntax = (classSyntax?.Block1 as MetaClassBlock1Alt1Syntax)?.SymbolType;
            if (symbolSyntax is null) return;
            var symbolBinder = GetBinder(symbolSyntax);
            if (symbolBinder is null) return;
            var symbol = symbolBinder.Bind(context.CancellationToken).FirstOrDefault() as DeclarationSymbol;
            context.Qualifier = symbol;
        }
    }
}
