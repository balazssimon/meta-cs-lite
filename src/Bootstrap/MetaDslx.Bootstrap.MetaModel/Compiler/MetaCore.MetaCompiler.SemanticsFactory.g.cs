using System;
using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.Binding;

#nullable enable

namespace MetaDslx.Bootstrap.MetaModel.Compiler
{
    public class MetaCoreSemanticsFactory : SemanticsFactory
    {
        public MetaCoreSemanticsFactory(Compilation compilation, Language language) 
            : base(compilation, language)
        {
        }

        public override BinderFactoryVisitor CreateBinderFactoryVisitor(BinderFactory binderFactory)
        {
            return new MetaDslx.Bootstrap.MetaModel.Compiler.Binding.MetaCoreBinderFactoryVisitor(binderFactory);
        }
    }
}
