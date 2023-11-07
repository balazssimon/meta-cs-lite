using MetaDslx.CodeAnalysis.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Languages.MetaModel.Compiler
{
    public partial class MetaLanguage
    {
        partial void RegisterServices()
        {
            RegisterGlobal<SyntaxFacts, SymbolSyntaxFacts>();
        }
    }
}
