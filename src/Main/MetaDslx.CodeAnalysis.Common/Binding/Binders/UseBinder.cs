using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.PooledObjects;
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
    }
}
