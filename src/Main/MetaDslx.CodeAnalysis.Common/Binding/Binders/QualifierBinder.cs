using MetaDslx.CodeAnalysis.Declarations;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.CodeAnalysis.Binding
{
    public class QualifierBinder : Binder, IValueBinder
    {
        protected override ImmutableArray<SingleDeclaration> BuildDeclarationTree(SingleDeclarationBuilder builder)
        {
            builder.BeginQualifier();
            try
            {
                return base.BuildDeclarationTree(builder);
            }
            finally
            {
                builder.EndQualifier();
            }
        }
    }
}
