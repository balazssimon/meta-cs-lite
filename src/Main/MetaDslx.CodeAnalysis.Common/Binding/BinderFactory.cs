using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.CodeAnalysis.Text;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Text;

namespace MetaDslx.CodeAnalysis.Binding
{
    public sealed class BinderFactory
    {
        private readonly Compilation _compilation;
        private readonly SyntaxTree _syntaxTree;
        private readonly BuckStopsHereBinder _buckStopsHereBinder;

        // In a typing scenario, GetBinder is regularly called with a non-zero position.
        // This results in a lot of allocations of BinderFactoryVisitors. Pooling them
        // reduces this churn to almost nothing.
        private readonly ObjectPool<BinderFactoryVisitor> _pool;

        public BinderFactory(Compilation compilation, SyntaxTree syntaxTree)
        {
            _compilation = compilation;
            _syntaxTree = syntaxTree;
            _buckStopsHereBinder = new BuckStopsHereBinder(compilation, _syntaxTree);
            _pool = new ObjectPool<BinderFactoryVisitor>(() => _compilation.SemanticsFactory.CreateBinderFactoryVisitor(this), 64);
        }

        public Compilation Compilation => _compilation;
        public SyntaxTree SyntaxTree => _syntaxTree;
        public Language Language => _syntaxTree.Language;
        public Binder BuckStopsHereBinder => _buckStopsHereBinder;
        public RootBinder? RootBinder => _buckStopsHereBinder.RootBinder;

        public ImmutableArray<Binder> BuildBinderTree(SyntaxNodeOrToken root, LazyBinder? lazyBinder = null)
        {
            Debug.Assert(root != null);
            var isRoot = lazyBinder is null;
            Binder rootBinder = isRoot ? _buckStopsHereBinder : lazyBinder;
            BinderFactoryVisitor visitor = _pool.Allocate();
            visitor.Initialize(isRoot, root.SpanStart, root.IsToken, -1);
            visitor.Begin(rootBinder, root);
            visitor.Visit(root.IsNode ? root.AsNode() : root.Parent);
            var result = visitor.End(rootBinder);
            _pool.Free(visitor);
            return result;
        }

        public Binder GetBinder(SyntaxNodeOrToken syntax)
        {
            return _buckStopsHereBinder.GetBinder(syntax);
        }

        public Binder GetEnclosingBinder(SyntaxNodeOrToken syntax)
        {
            return _buckStopsHereBinder.GetEnclosingBinder(syntax);
        }

        public Binder GetEnclosingBinder(TextSpan span)
        {
            return _buckStopsHereBinder.GetEnclosingBinder(span);
        }
    }
}
