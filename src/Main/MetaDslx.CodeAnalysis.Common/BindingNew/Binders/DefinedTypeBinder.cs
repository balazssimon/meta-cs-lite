using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.PooledObjects;
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

        public override string ToString()
        {
            var builder = PooledStringBuilder.GetInstance();
            var sb = builder.Builder;
            sb.Append(this.GetType().Name);
            sb.Append(": [");
            sb.Append(Type);
            sb.Append("]");
            return builder.ToStringAndFree();
        }
    }
}
