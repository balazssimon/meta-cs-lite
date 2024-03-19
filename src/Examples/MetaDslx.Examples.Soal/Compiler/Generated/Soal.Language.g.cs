using Autofac;
using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Syntax;
using MetaDslx.CodeAnalysis.Syntax.InternalSyntax;

#nullable enable

namespace MetaDslx.Examples.Soal.Compiler
{
    using global::MetaDslx.Examples.Soal.Compiler.Syntax;
    using global::MetaDslx.Examples.Soal.Compiler.Syntax.InternalSyntax;

    public sealed partial class SoalLanguage : Language
    {
        public static SoalLanguage Instance = new SoalLanguage();

        public override string Name => "Soal";

        public new SoalInternalSyntaxFactory InternalSyntaxFactory => (SoalInternalSyntaxFactory)base.InternalSyntaxFactory;

        public new SoalSyntaxFacts SyntaxFacts => (SoalSyntaxFacts)base.SyntaxFacts;

        public new SoalSyntaxFactory SyntaxFactory => (SoalSyntaxFactory)base.SyntaxFactory;

        public new SoalCompilationFactory CompilationFactory => (SoalCompilationFactory)base.CompilationFactory;

        protected override void RegisterServicesCore()
        {
            RegisterServices();
            TryRegister<SyntaxFacts, SoalSyntaxFacts>();
            TryRegister<InternalSyntaxFactory, SoalInternalSyntaxFactory>();
            TryRegister<SyntaxFactory, SoalSyntaxFactory>();
            TryRegister<CompilationFactory, SoalCompilationFactory>();
        }

        partial void RegisterServices();
    }
}
