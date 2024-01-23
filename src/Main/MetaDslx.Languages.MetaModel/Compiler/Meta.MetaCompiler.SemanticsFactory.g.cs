using System;
using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.Binding;

#nullable enable

namespace MetaDslx.Languages.MetaModel.Compiler
{
    public class MetaSemanticsFactory : SemanticsFactory
    {
        public MetaSemanticsFactory(Compilation compilation, Language language) 
            : base(compilation, language)
        {
        }

        public override BinderFactoryVisitor CreateBinderFactoryVisitor(BinderFactory binderFactory)
        {
            return new global::MetaDslx.Languages.MetaModel.Compiler.Binding.MetaBinderFactoryVisitor(binderFactory);
        }
    }
}
