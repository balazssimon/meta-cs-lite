using MetaDslx.Languages.MetaCompiler.Symbols;
using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Symbols.Source;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Languages.MetaCompiler.Compiler
{
    internal class CustomCompilerCompilationFactory : CompilationFactory
    {
        public override SourceSymbolFactory CreateSourceSymbolFactory(Compilation compilation, SourceModuleSymbol sourceModule)
        {
            return new CustomCompilerSourceSymbolFactory(sourceModule);
        }
    }
}
