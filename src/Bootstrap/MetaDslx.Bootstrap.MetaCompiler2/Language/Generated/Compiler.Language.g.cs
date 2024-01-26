using Autofac;
using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Syntax;
using MetaDslx.CodeAnalysis.Syntax.InternalSyntax;

#nullable enable

namespace MetaDslx.Bootstrap.MetaCompiler2.Compiler
{
    using global::MetaDslx.Bootstrap.MetaCompiler2.Compiler.Syntax;
    using global::MetaDslx.Bootstrap.MetaCompiler2.Compiler.Syntax.InternalSyntax;

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
            TryRegisterGlobal<SyntaxFacts, CompilerSyntaxFacts>();
            TryRegisterGlobal<InternalSyntaxFactory, CompilerInternalSyntaxFactory>();
            TryRegisterGlobal<SyntaxFactory, CompilerSyntaxFactory>();
            TryRegisterGlobal<CompilationFactory, CompilerCompilationFactory>();
            TryRegisterCompilationScoped<SemanticsFactory, CompilerSemanticsFactory>();
        }

        partial void RegisterServices();
    }
}
