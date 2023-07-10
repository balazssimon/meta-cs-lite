using MetaDslx.CodeAnalysis.Binding;
using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.Syntax;
using MetaDslx.CodeAnalysis.Syntax.InternalSyntax;
using MetaDslx.CodeAnalysis.Text;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis
{
    public abstract class Language
    {
        internal static readonly Language NoLanguage = new NoLanguageImplementation();

        private IServiceProvider _serviceProvider;
        private SyntaxFacts _syntaxFacts;
        private InternalSyntaxFactory _internalSyntaxFactory;
        private SyntaxFactory _syntaxFactory;
        private CompilationFactory _compilationFactory;

        public Language()
        {
            var services = new ServiceCollection();
            services.AddSingleton<Language>(this);
            RegisterServicesCore(services);
            _serviceProvider = services.BuildServiceProvider(validateScopes: true);
            _syntaxFacts = _serviceProvider.GetRequiredService<SyntaxFacts>();
            _internalSyntaxFactory = _serviceProvider.GetRequiredService<InternalSyntaxFactory>();
            _syntaxFactory = _serviceProvider.GetRequiredService<SyntaxFactory>();
            _compilationFactory = _serviceProvider.GetRequiredService<CompilationFactory>();
        }

        public abstract string Name { get; }
        public IServiceProvider ServiceProvider => _serviceProvider;
        public InternalSyntaxFactory InternalSyntaxFactory => _internalSyntaxFactory;
        public SyntaxFacts SyntaxFacts => _syntaxFacts;
        public SyntaxFactory SyntaxFactory => _syntaxFactory;
        public CompilationFactory CompilationFactory => _compilationFactory;

        protected abstract void RegisterServicesCore(ServiceCollection services);

        private class NoLanguageImplementation : Language
        {
            public override string Name => throw new NotImplementedException();

            protected override void RegisterServicesCore(ServiceCollection services)
            {
                services.AddSingleton<SyntaxFacts, NoSyntaxFacts>();
                services.AddSingleton<InternalSyntaxFactory, NoInternalSyntaxFactory>();
                services.AddSingleton<SyntaxFactory, NoSyntaxFactory>();
                services.AddSingleton<CompilationFactory, NoCompilationFactory>();
            }

        }

        private class NoSyntaxFacts : SyntaxFacts
        {
            protected internal override int DefaultWhitespaceRawKind => throw new NotImplementedException();

            protected internal override int DefaultEndOfLineRawKind => throw new NotImplementedException();

            protected internal override int DefaultSeparatorRawKind => throw new NotImplementedException();

            protected internal override int DefaultIdentifierRawKind => throw new NotImplementedException();

            protected internal override int GetContextualKeywordRawKind(string text)
            {
                throw new NotImplementedException();
            }

            protected internal override IEnumerable<int> GetContextualKeywordRawKinds()
            {
                throw new NotImplementedException();
            }

            protected internal override int GetFixedTokenRawKind(string text)
            {
                throw new NotImplementedException();
            }

            protected internal override string GetKindText(int rawKind)
            {
                throw new NotImplementedException();
            }

            protected internal override int GetReservedKeywordRawKind(string text)
            {
                throw new NotImplementedException();
            }

            protected internal override IEnumerable<int> GetReservedKeywordRawKinds()
            {
                throw new NotImplementedException();
            }

            protected internal override string GetText(int rawKind)
            {
                throw new NotImplementedException();
            }

            protected internal override object? GetValue(int rawKind)
            {
                throw new NotImplementedException();
            }

            protected internal override bool IsContextualKeyword(int rawKind)
            {
                throw new NotImplementedException();
            }

            protected internal override bool IsDocumentationCommentTrivia(int rawKind)
            {
                throw new NotImplementedException();
            }

            protected internal override bool IsFixedToken(int rawKind)
            {
                throw new NotImplementedException();
            }

            protected internal override bool IsGeneralCommentTrivia(int rawKind)
            {
                throw new NotImplementedException();
            }

            protected internal override bool IsIdentifier(int rawKind)
            {
                throw new NotImplementedException();
            }

            protected internal override bool IsPreprocessorContextualKeyword(int rawKind)
            {
                throw new NotImplementedException();
            }

            protected internal override bool IsPreprocessorDirective(int rawKind)
            {
                throw new NotImplementedException();
            }

            protected internal override bool IsPreprocessorKeyword(int rawKind)
            {
                throw new NotImplementedException();
            }

            protected internal override bool IsReservedKeyword(int rawKind)
            {
                throw new NotImplementedException();
            }

            protected internal override bool IsToken(int rawKind)
            {
                throw new NotImplementedException();
            }

            protected internal override bool IsTrivia(int rawKind)
            {
                throw new NotImplementedException();
            }
        }

        private class NoInternalSyntaxFactory : InternalSyntaxFactory
        {
            public NoInternalSyntaxFactory(SyntaxFacts syntaxFacts) 
                : base(syntaxFacts)
            {
            }

            public override InternalSyntaxToken BadToken(GreenNode? leading, string text, GreenNode? trailing)
            {
                throw new NotImplementedException();
            }

            public override AbstractLexer CreateLexer(SourceText text, ParseOptions options)
            {
                throw new NotImplementedException();
            }

            public override AbstractParser CreateParser(AbstractLexer lexer, SyntaxNode? oldTree, ParseData? oldParseData, IEnumerable<TextChangeRange>? changes, CancellationToken cancellationToken = default)
            {
                throw new NotImplementedException();
            }

            public override IEnumerable<InternalSyntaxToken> GetWellKnownTokens()
            {
                throw new NotImplementedException();
            }

            public override InternalSyntaxNode SkippedTokensTrivia(GreenNode token)
            {
                throw new NotImplementedException();
            }

            protected internal override InternalSyntaxToken MissingToken(int kind)
            {
                throw new NotImplementedException();
            }

            protected internal override InternalSyntaxToken MissingToken(GreenNode? leading, int kind, GreenNode? trailing)
            {
                throw new NotImplementedException();
            }

            protected internal override InternalSyntaxToken Token(int kind)
            {
                throw new NotImplementedException();
            }

            protected internal override InternalSyntaxToken Token(GreenNode? leading, int kind, GreenNode? trailing)
            {
                throw new NotImplementedException();
            }

            protected internal override InternalSyntaxToken Token(GreenNode? leading, int kind, string text, GreenNode? trailing)
            {
                throw new NotImplementedException();
            }

            protected internal override InternalSyntaxToken Token(GreenNode? leading, int kind, string text, string valueText, GreenNode? trailing)
            {
                throw new NotImplementedException();
            }

            protected internal override InternalSyntaxToken Token(GreenNode? leading, int kind, string text, object value, GreenNode? trailing)
            {
                throw new NotImplementedException();
            }

            protected internal override InternalSyntaxTrivia Trivia(int kind, string text, bool elastic = false)
            {
                throw new NotImplementedException();
            }
        }

        private class NoSyntaxFactory : SyntaxFactory
        {
            public NoSyntaxFactory(InternalSyntaxFactory internalSyntaxFactory)
                : base(internalSyntaxFactory)
            {
            }

            public override Language Language => Language.NoLanguage;

            public override ParseOptions DefaultParseOptions => throw new NotImplementedException();

            public override SyntaxTree MakeSyntaxTree(SyntaxNode root, ParseOptions? options = null, string path = "", Encoding? encoding = null)
            {
                throw new NotImplementedException();
            }

            protected override SyntaxTree ParseSyntaxTreeCore(SourceText text, ParseOptions? options = null, string path = "", CancellationToken cancellationToken = default)
            {
                throw new NotImplementedException();
            }

        }

        private class NoCompilationFactory : CompilationFactory
        {
            public override RootSingleDeclaration CreateDeclarationTree(SyntaxTree syntaxTree, string scriptClassName, bool isSubmission)
            {
                throw new NotImplementedException();
            }

            public override BinderFactoryVisitor CreateBinderFactoryVisitor(BinderFactory binderFactory)
            {
                throw new NotImplementedException();
            }
        }
    }
}
