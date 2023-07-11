using MetaDslx.CodeAnalysis.PooledObjects;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Reflection;
using System.Text;

namespace MetaDslx.CodeAnalysis.Binding
{
    public class BinderFactoryVisitor : SyntaxVisitor
    {
        private readonly BinderFactory _factory;
        private readonly Stack<Binder> _binderStack = new Stack<Binder>();
        private readonly Stack<ArrayBuilder<Binder>> _childBindersStack = new Stack<ArrayBuilder<Binder>>();

        private bool _isRoot;
        private int _position;
        private bool _forChild;
        private int _lazyIndex;

        public BinderFactoryVisitor(BinderFactory factory)
        {
            _factory = factory;
        }

        public Language Language => _factory.Language;
        protected bool IsRoot => _isRoot;
        protected int Position => _position;
        protected bool ForChild => _forChild;
        protected int LazyIndex => _lazyIndex;

        internal void Initialize(bool isRoot, int position, bool forChild, int lazyIndex)
        {
            _binderStack.Clear();
            _childBindersStack.Clear();

            _isRoot = isRoot;
            _position = position;
            _forChild = forChild;
            _lazyIndex = lazyIndex;
        }

        internal protected void Begin(Binder binder, SyntaxNodeOrToken syntax)
        {
            var parentBinder = _binderStack.Count > 0 ? _binderStack.Peek() : null;
            binder.InitBinder(parentBinder, syntax);
            _binderStack.Push(binder);
            if (_childBindersStack.Count > 0)
            {
                var children = _childBindersStack.Peek();
                children.Add(binder);
            }
            _childBindersStack.Push(ArrayBuilder<Binder>.GetInstance());
        }

        internal protected ImmutableArray<Binder> End(Binder binder)
        {
            var parentBinder = _binderStack.Pop();
            Debug.Assert(object.ReferenceEquals(parentBinder, binder));
            var childBinders = _childBindersStack.Pop();
            return binder.InitChildBinders(childBinders.ToImmutableAndFree());
        }

    }
}
