﻿using MetaDslx.Bootstrap.MetaCompiler2.Symbols;
using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Symbols.Source;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Bootstrap.MetaCompiler2.Compiler
{
    internal class CustomCompilerCompilationFactory : CompilationFactory
    {
        public override SourceSymbolFactory CreateSourceSymbolFactory(Compilation compilation, SourceModuleSymbol sourceModule)
        {
            return new CustomCompilerSourceSymbolFactory(sourceModule);
        }
    }
}
