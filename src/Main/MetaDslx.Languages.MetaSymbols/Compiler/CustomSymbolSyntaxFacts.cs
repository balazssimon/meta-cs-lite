using MetaDslx.Languages.MetaSymbols.Compiler.Syntax;
using MetaDslx.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Languages.MetaSymbols.Compiler
{
    internal class CustomSymbolSyntaxFacts : SymbolSyntaxFacts
    {
        public override bool TryExtractValue(MetaType expectedType, SyntaxNodeOrToken nodeOrToken, out object? value)
        {
            if (nodeOrToken.AsNode() is ArrayDimensionsSyntax arrayDimensions)
            {
                value = arrayDimensions.Block.Count;
                return true;
            }
            else
            {
                return base.TryExtractValue(expectedType, nodeOrToken, out value);
            }
        }

    }
}
