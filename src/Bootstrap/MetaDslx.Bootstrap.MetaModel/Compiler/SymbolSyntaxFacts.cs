using MetaDslx.Bootstrap.MetaModel.Compiler.Syntax;
using MetaDslx.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Bootstrap.MetaModel.Compiler
{
    internal class SymbolSyntaxFacts : MetaSyntaxFacts
    {
        public override string? ExtractName(SyntaxNodeOrToken nodeOrToken)
        {
            if (nodeOrToken.IsNode)
            {
                var node = (MetaSyntaxNode)nodeOrToken.AsNode();
                switch (node.Kind)
                {
                    case MetaSyntaxKind.MetaClassBlock1Alt1:
                        var ca1 = (MetaClassBlock1Alt1Syntax)node;
                        if (ca1.Identifier is not null) return ca1.Identifier.ToString();
                        else return ca1.SymbolType.ToString();
                    case MetaSyntaxKind.MetaClassBlock1Alt2:
                        var ca2 = (MetaClassBlock1Alt2Syntax)node;
                        return ca2.Identifier.ToString();
                    case MetaSyntaxKind.MetaPropertyBlock2Alt1:
                        var pa1 = (MetaPropertyBlock2Alt1Syntax)node;
                        if (pa1.Identifier is not null) return pa1.Identifier.ToString();
                        else return pa1.SymbolProperty.ToString();
                    case MetaSyntaxKind.MetaPropertyBlock2Alt2:
                        var pa2 = (MetaPropertyBlock2Alt2Syntax)node;
                        return pa2.Identifier.ToString();
                    default:
                        break;
                }
            }
            return base.ExtractName(nodeOrToken);
        }

    }
}
