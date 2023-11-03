using MetaDslx.Bootstrap.MetaModel.Compiler.Syntax;
using MetaDslx.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Bootstrap.MetaModel.Compiler
{
    internal class SymbolSyntaxFacts : MetaCoreSyntaxFacts
    {
        public override string? ExtractName(SyntaxNodeOrToken nodeOrToken)
        {
            if (nodeOrToken.IsNode)
            {
                var node = (MetaCoreSyntaxNode)nodeOrToken.AsNode();
                switch (node.Kind)
                {
                    case MetaCoreSyntaxKind.ClassNameAlt1:
                        var ca1 = (ClassNameAlt1Syntax)node;
                        if (ca1.TIdentifier.GetMetaCoreKind() != MetaCoreSyntaxKind.None) return ca1.TIdentifier.ToString();
                        else return ca1.SymbolType.ToString();
                    case MetaCoreSyntaxKind.ClassNameAlt2:
                        var ca2 = (ClassNameAlt2Syntax)node;
                        return ca2.TIdentifier.ToString();
                    case MetaCoreSyntaxKind.PropertyNameAlt1:
                        var pa1 = (PropertyNameAlt1Syntax)node;
                        if (pa1.TIdentifier.GetMetaCoreKind() != MetaCoreSyntaxKind.None) return pa1.TIdentifier.ToString();
                        else return pa1.SymbolProperty.ToString();
                    case MetaCoreSyntaxKind.PropertyNameAlt2:
                        var pa2 = (PropertyNameAlt2Syntax)node;
                        return pa2.TIdentifier.ToString();
                    default:
                        break;
                }
            }
            return base.ExtractName(nodeOrToken);
        }
    }
}
