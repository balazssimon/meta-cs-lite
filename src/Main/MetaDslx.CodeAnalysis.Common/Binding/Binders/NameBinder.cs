using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.CodeAnalysis.Symbols;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Binding
{
    public class NameBinder : Binder, INameBinder
    {
        private readonly Type? _qualifierType;
        private readonly string? _qualifierProperty;

        public NameBinder(Type? qualifierType = null, string? qualifierProperty = null)
        {
            _qualifierType = qualifierType;
            _qualifierProperty = qualifierProperty;
        }

        public Type? QualifierType => _qualifierType;
        public string? QualifierProperty => _qualifierProperty;

        protected override ImmutableArray<SingleDeclaration> BuildDeclarationTree(SingleDeclarationBuilder builder)
        {
            builder.BeginName(_qualifierType, _qualifierProperty);
            try
            {
                return base.BuildDeclarationTree(builder);
            }
            finally
            {
                builder.EndName();
            }
        }

        protected override void CollectNameBinders(ArrayBuilder<INameBinder> nameBinders, CancellationToken cancellationToken)
        {
            nameBinders.Add(this);
        }

        protected override void CollectQualifierBinders(ArrayBuilder<IQualifierBinder> qualifierBinders, CancellationToken cancellationToken)
        {
        }

        protected override void CollectIdentifierBinders(ArrayBuilder<IIdentifierBinder> identifierBinders, CancellationToken cancellationToken)
        {
        }

        public override string ToString()
        {
            var builder = PooledStringBuilder.GetInstance();
            var sb = builder.Builder;
            sb.Append(this.GetType().Name);
            sb.Append(": [");
            sb.Append(QualifierType);
            sb.Append(".");
            sb.Append(QualifierProperty);
            sb.Append("]");
            return builder.ToStringAndFree();
        }
    }
}
