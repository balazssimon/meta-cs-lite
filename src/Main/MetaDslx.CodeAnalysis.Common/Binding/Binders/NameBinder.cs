using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.CodeAnalysis.Symbols;
using MetaDslx.Modeling;
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
        private readonly ModelProperty? _qualifierProperty;

        public NameBinder(Type? qualifierType = null, ModelProperty? qualifierProperty = null)
        {
            _qualifierType = qualifierType;
            _qualifierProperty = qualifierProperty;
        }

        public Type? QualifierType => _qualifierType;
        public ModelProperty? QualifierProperty => _qualifierProperty;

        protected override ImmutableArray<SingleDeclaration> BuildDeclarationTree(SingleDeclarationBuilder builder)
        {
            builder.BeginName(_qualifierType, _qualifierProperty?.Name);
            try
            {
                var result = BuildChildDeclarationTree(builder);
                if (!builder.HasName)
                {
                    var name = this.Language.SyntaxFacts.ExtractName(this.Syntax);
                    if (!string.IsNullOrEmpty(name))
                    {
                        var metadataName = this.Language.SyntaxFacts.ExtractMetadataName(this.Syntax);
                        builder.AddIdentifier(name, metadataName, this.Location);
                    }
                }
                return result;
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

        /*protected override void CollectQualifierBinders(ArrayBuilder<IQualifierBinder> qualifierBinders, CancellationToken cancellationToken)
        {
        }

        protected override void CollectIdentifierBinders(ArrayBuilder<IIdentifierBinder> identifierBinders, CancellationToken cancellationToken)
        {
        }*/

        public override string ToString()
        {
            var builder = PooledStringBuilder.GetInstance();
            var sb = builder.Builder;
            sb.Append(this.GetType().Name);
            sb.Append(": [");
            if (QualifierType is not null)
            {
                sb.Append(QualifierType);
                sb.Append(".");
            }
            if (QualifierProperty is not null)
            {
                sb.Append(QualifierProperty.Name);
            }
            sb.Append("]");
            return builder.ToStringAndFree();
        }
    }
}
