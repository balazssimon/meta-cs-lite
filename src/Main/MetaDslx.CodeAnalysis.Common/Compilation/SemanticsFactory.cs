using MetaDslx.CodeAnalysis.Binding;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis
{
    public abstract class SemanticsFactory
    {
        public abstract BinderFactoryVisitor CreateBinderFactoryVisitor(BinderFactory binderFactory);

    }
}
