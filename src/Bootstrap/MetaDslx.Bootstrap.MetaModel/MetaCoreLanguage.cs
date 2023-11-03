﻿using MetaDslx.CodeAnalysis.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Bootstrap.MetaModel.Compiler
{
    public partial class MetaCoreLanguage
    {
        partial void RegisterServices()
        {
            RegisterGlobal<SyntaxFacts, SymbolSyntaxFacts>();
        }
    }
}
