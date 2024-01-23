using MetaDslx.Languages.MetaModel.Compiler.Syntax;
using MetaDslx.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Languages.MetaModel.Compiler
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
                    case MetaSyntaxKind.ClassNameAlt1:
                        var ca1 = (ClassNameAlt1Syntax)node;
                        if (ca1.Identifier is not null) return ca1.Identifier.ToString();
                        else return ca1.SymbolType.ToString();
                    case MetaSyntaxKind.ClassNameAlt2:
                        var ca2 = (ClassNameAlt2Syntax)node;
                        return ca2.Identifier.ToString();
                    case MetaSyntaxKind.PropertyNameAlt1:
                        var pa1 = (PropertyNameAlt1Syntax)node;
                        if (pa1.Identifier is not null) return pa1.Identifier.ToString();
                        else return pa1.SymbolProperty.ToString();
                    case MetaSyntaxKind.PropertyNameAlt2:
                        var pa2 = (PropertyNameAlt2Syntax)node;
                        return pa2.Identifier.ToString();
                    default:
                        break;
                }
            }
            return base.ExtractName(nodeOrToken);
        }
    }
}
