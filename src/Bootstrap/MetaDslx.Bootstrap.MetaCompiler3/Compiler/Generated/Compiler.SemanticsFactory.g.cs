using System;
using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.Binding;

#nullable enable

namespace MetaDslx.Bootstrap.MetaCompiler3.Compiler
{
    public class CompilerSemanticsFactory : SemanticsFactory
    {
        public CompilerSemanticsFactory(Compilation compilation, Language language) 
            : base(compilation, language)
        {
        }

        public override BinderFactoryVisitor CreateBinderFactoryVisitor(BinderFactory binderFactory)
        {
            return new global::MetaDslx.Bootstrap.MetaCompiler3.Compiler.Binding.CompilerBinderFactoryVisitor(binderFactory);
        }
    }
}
