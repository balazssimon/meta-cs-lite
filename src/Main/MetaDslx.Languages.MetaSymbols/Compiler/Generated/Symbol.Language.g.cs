using Autofac;
using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Syntax;
using MetaDslx.CodeAnalysis.Syntax.InternalSyntax;

#nullable enable

namespace MetaDslx.Languages.MetaSymbols.Compiler
{
    using global::MetaDslx.Languages.MetaSymbols.Compiler.Syntax;
    using global::MetaDslx.Languages.MetaSymbols.Compiler.Syntax.InternalSyntax;

    public sealed partial class SymbolLanguage : Language
    {
        public static SymbolLanguage Instance = new SymbolLanguage();

        public override string Name => "Symbol";

        public new SymbolInternalSyntaxFactory InternalSyntaxFactory => (SymbolInternalSyntaxFactory)base.InternalSyntaxFactory;

        public new SymbolSyntaxFacts SyntaxFacts => (SymbolSyntaxFacts)base.SyntaxFacts;

        public new SymbolSyntaxFactory SyntaxFactory => (SymbolSyntaxFactory)base.SyntaxFactory;

        public new SymbolCompilationFactory CompilationFactory => (SymbolCompilationFactory)base.CompilationFactory;

        protected override void RegisterServicesCore()
        {
            RegisterServices();
            TryRegisterGlobal<SyntaxFacts, SymbolSyntaxFacts>();
            TryRegisterGlobal<InternalSyntaxFactory, SymbolInternalSyntaxFactory>();
            TryRegisterGlobal<SyntaxFactory, SymbolSyntaxFactory>();
            TryRegisterGlobal<CompilationFactory, SymbolCompilationFactory>();
            TryRegisterCompilationScoped<SemanticsFactory, SymbolSemanticsFactory>();
        }

        partial void RegisterServices();
    }
}
