using MetaDslx.CodeAnalysis.Declarations;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.CodeAnalysis.Binding
{
    public class NameBinder : Binder
    {
        protected override ImmutableArray<SingleDeclaration> BuildDeclarationTree(SingleDeclarationBuilder builder)
        {
            builder.BeginName();
            try
            {
                return base.BuildDeclarationTree(builder);
            }
            finally
            {
                builder.EndName();
            }
        }
    }
}
