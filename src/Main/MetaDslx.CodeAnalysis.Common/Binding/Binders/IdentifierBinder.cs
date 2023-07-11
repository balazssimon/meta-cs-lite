using MetaDslx.CodeAnalysis.Declarations;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.CodeAnalysis.Binding
{
    public class IdentifierBinder : Binder, IValueBinder
    {
        protected override ImmutableArray<SingleDeclaration> BuildDeclarationTree(SingleDeclarationBuilder builder)
        {
            builder.AddIdentifier(this.GetName(), this.GetMetadataName(), this.Location);
            return ImmutableArray<SingleDeclaration>.Empty;
        }

        protected virtual string? GetName()
        {
            return this.Syntax.ToString();
        }

        protected virtual string? GetMetadataName()
        {
            return this.GetName();
        }
    }
}
