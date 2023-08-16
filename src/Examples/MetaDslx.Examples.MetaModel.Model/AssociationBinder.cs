using MetaDslx.CodeAnalysis.Binding;
using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.CodeAnalysis.Symbols;
using MetaDslx.CodeAnalysis.Symbols.Model;
using MetaDslx.Examples.MetaModel.Model;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Examples.MetaModel
{
    public class AssociationBinder : Binder
    {
        protected override void CollectValueBinders(IPropertyBinder propertyBinder, ArrayBuilder<IValueBinder> valueBinders, CancellationToken cancellationToken)
        {
        }

        protected override ImmutableArray<object?> BindValues(BindingContext context)
        {
            var qualifiers = this.GetQualifierBinders(context.CancellationToken);
            if (qualifiers.Length == 2)
            {
                var first = (Binder)qualifiers[0];
                var second = (Binder)qualifiers[1];
                var firstSymbol = first.Bind(context).FirstOrDefault() as DeclaredSymbol;
                var secondSymbol = second.Bind(context).FirstOrDefault() as DeclaredSymbol;
                var firstProp = (firstSymbol as IModelSymbol)?.ModelObject as MetaProperty;
                var secondProp = (secondSymbol as IModelSymbol)?.ModelObject as MetaProperty;
                if (firstProp is not null && secondProp is not null)
                {
                    firstProp.OppositeProperties.Add(secondProp);
                }
            }
            return ImmutableArray<object?>.Empty;
        }
    }
}
