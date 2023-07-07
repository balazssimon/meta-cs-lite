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

        private int _position;
        private bool _forChild;
        private int _lazyIndex;

        public BinderFactoryVisitor(BinderFactory factory)
        {
            _factory = factory;
        }

        public Language Language => _factory.Language;
        protected int Position => _position;
        protected bool ForChild => _forChild;
        protected int LazyIndex => _lazyIndex;

        internal void Initialize(int position, bool forChild, int lazyIndex)
        {
            _binderStack.Clear();
            _childBindersStack.Clear();

            _position = position;
            _forChild = forChild;
            _lazyIndex = lazyIndex;
        }

        internal protected void Begin(Binder binder, SyntaxNodeOrToken syntax)
        {
            var parentBinder = _binderStack.Count > 0 ? _binderStack.Peek() : null;
            binder.InitBinder(parentBinder, syntax);
            _binderStack.Push(binder);
            _childBindersStack.Push(ArrayBuilder<Binder>.GetInstance());
        }

        internal protected void End(Binder binder)
        {
            var parentBinder = _binderStack.Pop();
            Debug.Assert(object.ReferenceEquals(parentBinder, binder));
            var childBinders = _childBindersStack.Pop();
            binder.InitChildBinders(childBinders.ToImmutableAndFree());
        }

    }
}
