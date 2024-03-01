using Autofac;
using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Syntax;
using MetaDslx.CodeAnalysis.Syntax.InternalSyntax;

#nullable enable

namespace MetaDslx.Languages.MetaModel.Compiler
{
    using global::MetaDslx.Languages.MetaModel.Compiler.Syntax;
    using global::MetaDslx.Languages.MetaModel.Compiler.Syntax.InternalSyntax;

    public sealed partial class MetaLanguage : Language
    {
        public static MetaLanguage Instance = new MetaLanguage();

        public override string Name => "Meta";

        public new MetaInternalSyntaxFactory InternalSyntaxFactory => (MetaInternalSyntaxFactory)base.InternalSyntaxFactory;

        public new MetaSyntaxFacts SyntaxFacts => (MetaSyntaxFacts)base.SyntaxFacts;

        public new MetaSyntaxFactory SyntaxFactory => (MetaSyntaxFactory)base.SyntaxFactory;

        public new MetaCompilationFactory CompilationFactory => (MetaCompilationFactory)base.CompilationFactory;

        protected override void RegisterServicesCore()
        {
            RegisterServices();
            TryRegisterGlobal<SyntaxFacts, MetaSyntaxFacts>();
            TryRegisterGlobal<InternalSyntaxFactory, MetaInternalSyntaxFactory>();
            TryRegisterGlobal<SyntaxFactory, MetaSyntaxFactory>();
            TryRegisterGlobal<CompilationFactory, MetaCompilationFactory>();
        }

        partial void RegisterServices();
    }
}
