using MetaDslx.CodeAnalysis.Binding;
using MetaDslx.CodeAnalysis.Declarations;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis
{
    public abstract class CompilationFactory
    {
        public abstract BinderFactoryVisitor CreateBinderFactoryVisitor(BinderFactory binderFactory);

    }
}
