using MetaDslx.Languages.MetaCompiler.Compiler.Syntax;
using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Languages.MetaCompiler.Compiler
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
