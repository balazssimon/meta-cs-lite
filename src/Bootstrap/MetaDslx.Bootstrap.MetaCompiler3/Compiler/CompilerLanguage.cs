using MetaDslx.Bootstrap.MetaCompiler3.Compiler.Syntax;
using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Bootstrap.MetaCompiler3.Compiler
{
    public partial class CompilerLanguage
    {
        partial void RegisterServices()
        {
            Register<SyntaxFacts, CustomCompilerSyntaxFacts>();
        }
    }
}
