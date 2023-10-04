using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.PooledObjects;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.CodeAnalysis.Binding
{
    public class QualifiedNameBinder : Binder
    {
        private readonly Type? _type;
        private readonly string? _property;

        public QualifiedNameBinder(Type type, string propertyName)
        {
            _type = type;
            _property = propertyName;
        }

        public Type? Type => _type;
        public string? Property => _property;

        protected override ImmutableArray<SingleDeclaration> BuildDeclarationTree(SingleDeclarationBuilder builder)
        {
            builder.NestingType = Type;
            builder.NestingProperty = Property;
            return base.BuildDeclarationTree(builder);
        }

        public override string ToString()
        {
            var builder = PooledStringBuilder.GetInstance();
            var sb = builder.Builder;
            sb.Append(this.GetType().Name);
            sb.Append(": [");
            sb.Append(Type);
            sb.Append(".");
            sb.Append(Property);
            sb.Append("]");
            return builder.ToStringAndFree();
        }
    }
}
