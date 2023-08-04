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
    public class QualifierBinder : Binder, IQualifierBinder
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

        protected override void CollectNameBinders(ArrayBuilder<INameBinder> nameBinders, CancellationToken cancellationToken)
        {
        }

        protected override void CollectQualifierBinders(ArrayBuilder<IQualifierBinder> qualifierBinders, CancellationToken cancellationToken)
        {
            qualifierBinders.Add(this);
        }

        protected override void CollectIdentifierBinders(ArrayBuilder<IIdentifierBinder> identifierBinders, CancellationToken cancellationToken)
        {
        }

        protected override void CollectValueBinders(ImmutableArray<IPropertyBinder> propertyBinders, ArrayBuilder<IValueBinder> valueBinders, CancellationToken cancellationToken)
        {
        }

        protected override ImmutableArray<object?> BindValues(BindingContext context)
        {
            // TODO:MetaDslx
            return base.BindValues(context);
        }

        public Symbol? GetIdentifierSymbol(BindingContext context, IIdentifierBinder identifier)
        {
            // TODO:MetaDslx
            throw new NotImplementedException();
        }
    }
}
