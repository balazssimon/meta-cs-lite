using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Declarations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Bootstrap.Antlr4.Sandy
{
    public class SandyCompilationFactory : CompilationFactory
    {
        public override RootSingleDeclaration CreateDeclarationTree(SyntaxTree syntaxTree, string scriptClassName, bool isSubmission)
        {
            throw new NotImplementedException();
        }
    }
}
