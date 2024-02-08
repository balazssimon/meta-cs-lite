using System;
using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.Binding;

#nullable enable

namespace MetaDslx.Languages.MetaSymbols.Compiler
{
    public class SymbolSemanticsFactory : SemanticsFactory
    {
        public SymbolSemanticsFactory(Compilation compilation, Language language) 
            : base(compilation, language)
        {
        }

        public override BinderFactoryVisitor CreateBinderFactoryVisitor(BinderFactory binderFactory)
        {
            return new global::MetaDslx.Languages.MetaSymbols.Compiler.Binding.SymbolBinderFactoryVisitor(binderFactory);
        }
    }
}
