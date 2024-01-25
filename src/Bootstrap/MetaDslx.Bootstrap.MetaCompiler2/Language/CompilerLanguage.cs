using MetaDslx.Bootstrap.MetaCompiler2.Compiler.Syntax;
using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Bootstrap.MetaCompiler2.Compiler
{
    public partial class CompilerLanguage
    {
        partial void RegisterServices()
        {
            RegisterGlobal<SyntaxFacts, CustomCompilerSyntaxFacts>();
            RegisterGlobal<CompilationFactory, CustomCompilerCompilationFactory>();
        }
    }
}
