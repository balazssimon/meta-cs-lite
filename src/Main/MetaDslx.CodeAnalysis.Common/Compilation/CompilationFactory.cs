using MetaDslx.CodeAnalysis.Binding;
using MetaDslx.CodeAnalysis.Declarations;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis
{
    public abstract class CompilationFactory
    {
        public abstract RootSingleDeclaration CreateDeclarationTree(SyntaxTree syntaxTree, string scriptClassName, bool isSubmission);

        public abstract BinderFactoryVisitor CreateBinderFactoryVisitor(BinderFactory binderFactory);

    }
}
