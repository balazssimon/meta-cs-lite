using Autofac;
using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Syntax;
using MetaDslx.CodeAnalysis.Syntax.InternalSyntax;

#nullable enable

namespace MetaDslx.Languages.MetaCompiler.Compiler
{
    using global::MetaDslx.Languages.MetaCompiler.Compiler.Syntax;
    using global::MetaDslx.Languages.MetaCompiler.Compiler.Syntax.InternalSyntax;

    public sealed partial class CompilerLanguage : Language
    {
        public static CompilerLanguage Instance = new CompilerLanguage();

        public override string Name => "Compiler";

        public new CompilerInternalSyntaxFactory InternalSyntaxFactory => (CompilerInternalSyntaxFactory)base.InternalSyntaxFactory;

        public new CompilerSyntaxFacts SyntaxFacts => (CompilerSyntaxFacts)base.SyntaxFacts;

        public new CompilerSyntaxFactory SyntaxFactory => (CompilerSyntaxFactory)base.SyntaxFactory;

        public new CompilerCompilationFactory CompilationFactory => (CompilerCompilationFactory)base.CompilationFactory;

        protected override void RegisterServicesCore()
        {
            RegisterServices();
            TryRegister<SyntaxFacts, CompilerSyntaxFacts>();
            TryRegister<InternalSyntaxFactory, CompilerInternalSyntaxFactory>();
            TryRegister<SyntaxFactory, CompilerSyntaxFactory>();
            TryRegister<CompilationFactory, CompilerCompilationFactory>();
        }

        partial void RegisterServices();
    }
}
