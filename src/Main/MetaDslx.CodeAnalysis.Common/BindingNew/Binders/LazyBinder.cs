using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.PooledObjects;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Binding
{
    public sealed class LazyBinder : Binder
    {
        private int _lazyIndex;
        private readonly bool _weak;
        private ImmutableArray<WeakReference<Binder>> _childBinders;

        public LazyBinder(bool weak = false)
        {
            _weak = weak;
        }

        public bool IsWeak => _weak;

        internal int LazyIndex
        {
            get => _lazyIndex;
            set => _lazyIndex = value;
        }

        internal override ImmutableArray<Binder> InitChildBinders(ImmutableArray<Binder> children)
        {
            if (_weak)
            {
                // don't call base InitChildBinders, which stores children in a strong reference
                Debug.Assert(_childBinders.IsDefault || _childBinders.Length == children.Length);
                var result = ArrayBuilder<Binder>.GetInstance();
                var builder = ArrayBuilder<WeakReference<Binder>>.GetInstance();
                for (int i = 0; i < children.Length; ++i)
                {
                    var newChild = children[i];
                    if (!_childBinders.IsDefault && i < _childBinders.Length && _childBinders[i].TryGetTarget(out var oldChild))
                    {
                        result.Add(oldChild);
                    }
                    else
                    {
                        result.Add(newChild);
                        builder.Add(new WeakReference<Binder>(newChild));
                    }
                }
                ImmutableInterlocked.InterlockedExchange(ref _childBinders, builder.ToImmutableAndFree());
                return result.ToImmutableAndFree();
            }
            else
            {
                return base.InitChildBinders(children);
            }
        }

        internal ImmutableArray<Binder> ResolveChildren()
        {
            var binderFactory = Compilation.GetBinderFactory(Syntax.SyntaxTree);
            return binderFactory.BuildBinderTreeLazy(this.Syntax, this);
        }

        internal ImmutableArray<SingleDeclaration> BuildDeclarationTree()
        {
            var builder = new SingleDeclarationBuilder(this.Syntax, null);
            BuildChildDeclarationTree(builder, true);
            return builder.ToImmutableAndFree();
        }

        protected override ImmutableArray<SingleDeclaration> BuildDeclarationTree(SingleDeclarationBuilder builder)
        {
            return ImmutableArray.Create<SingleDeclaration>(new LazySingleDeclaration(Syntax, null, this));
        }

    }
}
