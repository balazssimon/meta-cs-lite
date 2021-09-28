using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis.Syntax
{
    public interface IDirectiveTriviaSyntax
    {
        Directive Directive { get; }

        SyntaxTrivia ParentTrivia { get; }
        SyntaxToken EndOfDirectiveToken { get; }
        IEnumerable<IDirectiveTriviaSyntax> GetRelatedDirectives();
    }
}
