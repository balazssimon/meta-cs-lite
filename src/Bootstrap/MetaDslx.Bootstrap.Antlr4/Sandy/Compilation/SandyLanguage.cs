using MetaDslx.Bootstrap.Antlr4.Sandy.Syntax;
using MetaDslx.Bootstrap.Antlr4.Sandy.Syntax.InternalSyntax;
using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Syntax;
using MetaDslx.CodeAnalysis.Syntax.InternalSyntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Bootstrap.Antlr4.Sandy
{
    public sealed class SandyLanguage : Language
    {
        public static SandyLanguage Instance = new SandyLanguage();

        private SandySyntaxFacts _syntaxFacts;
        private SandyInternalSyntaxFactory _internalSyntaxFactory;
        private SandySyntaxFactory _syntaxFactory;
        private SandyCompilationFactory _compilationFactory;

        private SandyLanguage()
        {
            _syntaxFacts = new SandySyntaxFacts();
            _internalSyntaxFactory = new SandyInternalSyntaxFactory(_syntaxFacts);
            _syntaxFactory = new SandySyntaxFactory(_internalSyntaxFactory);
            _compilationFactory = new SandyCompilationFactory();
        }

        public override string Name => "Sandy";

        public override SandyInternalSyntaxFactory InternalSyntaxFactory => _internalSyntaxFactory;

        public override SandySyntaxFacts SyntaxFacts => _syntaxFacts;

        public override SandySyntaxFactory SyntaxFactory => _syntaxFactory;

        public override SandyCompilationFactory CompilationFactory => _compilationFactory;
    }
}
