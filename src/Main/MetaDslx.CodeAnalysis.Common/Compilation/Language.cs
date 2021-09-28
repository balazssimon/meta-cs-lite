using MetaDslx.CodeAnalysis.Syntax;
using MetaDslx.CodeAnalysis.Syntax.InternalSyntax;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis
{
    public abstract class Language
    {
        internal static readonly Language NoLanguage = new NoLanguageImplementation();

        public abstract InternalSyntaxFactory InternalSyntaxFactory { get; }
        public abstract SyntaxFacts SyntaxFacts { get; }
        public abstract SyntaxFactory SyntaxFactory { get; }

        private class NoLanguageImplementation : Language
        {
            public override SyntaxFacts SyntaxFacts => throw new NotImplementedException();

            public override InternalSyntaxFactory InternalSyntaxFactory => throw new NotImplementedException();

            public override SyntaxFactory SyntaxFactory => throw new NotImplementedException();
        }
    }
}
