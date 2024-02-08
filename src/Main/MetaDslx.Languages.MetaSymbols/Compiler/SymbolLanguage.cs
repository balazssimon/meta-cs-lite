using MetaDslx.CodeAnalysis.Syntax;
using MetaDslx.Languages.MetaSymbols.Compiler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Languages.MetaSymbols.Compiler
{
    public partial class SymbolLanguage
    {
        partial void RegisterServices()
        {
            RegisterGlobal<SyntaxFacts, CustomSymbolSyntaxFacts>();
        }
    }
}
