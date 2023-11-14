using MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax;
using MetaDslx.CodeAnalysis;
using MetaDslx.Languages.MetaModel.Compiler.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax
{
    internal class CustomCompilerSyntaxFacts : CompilerSyntaxFacts
    {
        public override string? ExtractName(SyntaxNodeOrToken nodeOrToken)
        {
            if (nodeOrToken.IsNode)
            {
                var node = (CompilerSyntaxNode)nodeOrToken.AsNode();
                switch (node.Kind)
                {
                    case CompilerSyntaxKind.ParserRule:
                        var pr = (ParserRuleSyntax)node;
                        return ExtractName(pr.ParserRuleBlock1);
                    case CompilerSyntaxKind.ParserRuleBlock1Alt1:
                        var alt1 = (ParserRuleBlock1Alt1Syntax)node;
                        return ExtractName(alt1.Name);
                    case CompilerSyntaxKind.ParserRuleBlock1Alt2:
                        var alt2 = (ParserRuleBlock1Alt2Syntax)node;
                        return ExtractName(alt2.ReturnType);
                    case CompilerSyntaxKind.ParserRuleBlock1Alt3:
                        var alt3 = (ParserRuleBlock1Alt3Syntax)node;
                        return ExtractName(alt3.Name);
                    default:
                        break;
                }
            }
            return base.ExtractName(nodeOrToken);
        }
    }
}
