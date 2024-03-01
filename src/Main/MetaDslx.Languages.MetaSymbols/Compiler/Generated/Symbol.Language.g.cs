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

        public new CustomSymbolCompilationFactory CompilationFactory => (CustomSymbolCompilationFactory)base.CompilationFactory;

        protected override void RegisterServicesCore()
        {
            RegisterServices();
            TryRegister<SyntaxFacts, SymbolSyntaxFacts>();
            TryRegister<InternalSyntaxFactory, SymbolInternalSyntaxFactory>();
            TryRegister<SyntaxFactory, SymbolSyntaxFactory>();
            TryRegister<CompilationFactory, SymbolCompilationFactory>();
        }

        partial void RegisterServices();
    }
}
