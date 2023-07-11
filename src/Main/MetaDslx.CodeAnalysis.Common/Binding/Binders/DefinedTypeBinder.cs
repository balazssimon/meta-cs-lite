using MetaDslx.CodeAnalysis.Declarations;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.CodeAnalysis.Binding
{
    public class DefinedTypeBinder : Binder
    {
        private readonly Type _type;

        public DefinedTypeBinder(Type type)
        {
            _type = type;
        }

        public Type Type => _type;

        protected override ImmutableArray<SingleDeclaration> BuildDeclarationTree(SingleDeclarationBuilder builder)
        {
            builder.Type = this.Type;
            return base.BuildDeclarationTree(builder);
        }
    }
}
