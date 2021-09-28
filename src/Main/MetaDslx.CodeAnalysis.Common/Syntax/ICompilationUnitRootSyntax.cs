using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis.Syntax
{
    public interface ICompilationUnitRootSyntax : ICompilationUnitSyntax
    {
        IList<IDirectiveTriviaSyntax> GetReferenceDirectives();
        IList<IDirectiveTriviaSyntax> GetReferenceDirectives(Func<IDirectiveTriviaSyntax, bool> filter);
        IList<IDirectiveTriviaSyntax> GetLoadDirectives();
        DirectiveStack GetConditionalDirectivesStack();
    }
}
