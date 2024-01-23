using System;
using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.Binding;

#nullable enable

namespace MetaDslx.Languages.MetaCompiler.Compiler
{
    public class CompilerSemanticsFactory : SemanticsFactory
    {
        public CompilerSemanticsFactory(Compilation compilation, Language language) 
            : base(compilation, language)
        {
        }

        public override BinderFactoryVisitor CreateBinderFactoryVisitor(BinderFactory binderFactory)
        {
            return new global::MetaDslx.Languages.MetaCompiler.Compiler.Binding.CompilerBinderFactoryVisitor(binderFactory);
        }
    }
}
