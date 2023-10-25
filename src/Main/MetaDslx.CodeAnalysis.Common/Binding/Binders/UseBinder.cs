using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.CodeAnalysis.Symbols;
using MetaDslx.CodeAnalysis.Symbols.Model;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Binding
{
    public class UseBinder : Binder, IUseBinder
    {
        private readonly ImmutableArray<Type> _types;

        public UseBinder(ImmutableArray<Type> types)
        {
            _types = types;
        }

        public ImmutableArray<Type> Types => _types;
        public List<Type> TypesList { get; }

        protected override ImmutableArray<SingleDeclaration> BuildDeclarationTree(SingleDeclarationBuilder builder)
        {
            return ImmutableArray<SingleDeclaration>.Empty;
        }

        protected override void CollectNameBinders(ArrayBuilder<INameBinder> nameBinders, CancellationToken cancellationToken)
        {
        }

        protected override void AdjustLookupContext(LookupContext context)
        {
            context.Validators.Add(this);
        }

        protected override bool IsViable(LookupContext context, DeclaredSymbol symbol)
        {
            if (symbol is null) return false;
            if (_types.IsDefaultOrEmpty) return true;
            if (symbol is IModelSymbol modelSymbol)
            {
                foreach (var type in _types)
                {
                    if (type.IsAssignableFrom(modelSymbol.ModelObjectType)) return true;
                }
            }
            foreach (var type in _types)
            {
                if (type.IsAssignableFrom(symbol.GetType())) return true;
            }
            return false;
        }

        public override string ToString()
        {
            var builder = PooledStringBuilder.GetInstance();
            var sb = builder.Builder;
            sb.Append(this.GetType().Name);
            sb.Append(": [");
            var comma = false;
            foreach (var type in _types)
            {
                if (comma) sb.Append(", ");
                else comma = true;
                sb.Append(type.Name);
            }
            sb.Append("]");
            return builder.ToStringAndFree();
        }
    }
}
