using Autofac;
using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Syntax;
using MetaDslx.CodeAnalysis.Syntax.InternalSyntax;

#nullable enable

namespace MetaDslx.Bootstrap.MetaModel.Compiler
{
    using MetaDslx.Bootstrap.MetaModel.Compiler.Syntax;
    using MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.InternalSyntax;

    public sealed partial class MetaCoreLanguage : Language
    {
        public static MetaCoreLanguage Instance = new MetaCoreLanguage();

        public override string Name => "MetaCore";

        public new MetaCoreInternalSyntaxFactory InternalSyntaxFactory => (MetaCoreInternalSyntaxFactory)base.InternalSyntaxFactory;

        public new MetaCoreSyntaxFacts SyntaxFacts => (MetaCoreSyntaxFacts)base.SyntaxFacts;

        public new MetaCoreSyntaxFactory SyntaxFactory => (MetaCoreSyntaxFactory)base.SyntaxFactory;

        public new MetaCoreCompilationFactory CompilationFactory => (MetaCoreCompilationFactory)base.CompilationFactory;

        protected override void RegisterServicesCore()
        {
            RegisterServices();
            TryRegisterGlobal<SyntaxFacts, MetaCoreSyntaxFacts>();
            TryRegisterGlobal<InternalSyntaxFactory, MetaCoreInternalSyntaxFactory>();
            TryRegisterGlobal<SyntaxFactory, MetaCoreSyntaxFactory>();
            TryRegisterGlobal<CompilationFactory, MetaCoreCompilationFactory>();
            TryRegisterCompilationScoped<SemanticsFactory, MetaCoreSemanticsFactory>();
        }

        partial void RegisterServices();
    }
}
