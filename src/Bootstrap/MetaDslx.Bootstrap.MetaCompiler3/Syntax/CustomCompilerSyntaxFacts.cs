using MetaDslx.Bootstrap.MetaCompiler2.Compiler.Syntax;
using MetaDslx.CodeAnalysis;
using MetaDslx.Languages.MetaModel.Compiler.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Bootstrap.MetaCompiler2.Compiler.Syntax
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
                    case CompilerSyntaxKind.Rule:
                        var pr = (RuleSyntax)node;
                        return ExtractName(pr.Block);
                    case CompilerSyntaxKind.RuleBlock1Alt1:
                        var alt1 = (RuleBlock1Alt1Syntax)node;
                        return ExtractName(alt1.ReturnType);
                    case CompilerSyntaxKind.RuleBlock1Alt2:
                        var alt2 = (RuleBlock1Alt2Syntax)node;
                        return ExtractName(alt2.Identifier);
                    default:
                        break;
                }
            }
            return base.ExtractName(nodeOrToken);
        }
    }
}
