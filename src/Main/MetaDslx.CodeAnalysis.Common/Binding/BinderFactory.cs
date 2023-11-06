using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.CodeAnalysis.Text;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Binding
{
    public sealed class BinderFactory
    {
        private readonly Compilation _compilation;
        private readonly SyntaxTree _syntaxTree;
        private RootBinder? _rootBinder;

        // In a typing scenario, GetBinder is regularly called with a non-zero position.
        // This results in a lot of allocations of BinderFactoryVisitors. Pooling them
        // reduces this churn to almost nothing.
        private readonly ObjectPool<BinderFactoryVisitor> _pool;

        public BinderFactory(Compilation compilation, SyntaxTree syntaxTree)
        {
            _compilation = compilation;
            _syntaxTree = syntaxTree;
            _pool = new ObjectPool<BinderFactoryVisitor>(() => _compilation[_syntaxTree.Language].SemanticsFactory.CreateBinderFactoryVisitor(this), 64);
        }

        public Compilation Compilation => _compilation;
        public SyntaxTree SyntaxTree => _syntaxTree;
        public Language Language => _syntaxTree.Language;
        public RootBinder? RootBinder
        {
            get
            {
                if (_rootBinder is null)
                {
                    var rootBinders = BuildBinderTree(_syntaxTree.GetRoot());
                    var rootBinder = rootBinders.OfType<RootBinder>().FirstOrDefault();
                    Debug.Assert(rootBinder is not null);
                    Interlocked.CompareExchange(ref _rootBinder, rootBinder, null);
                }
                return _rootBinder;
            }
        }

        public ImmutableArray<Binder> BuildBinderTree(SyntaxNodeOrToken root, LazyBinder? lazyBinder = null)
        {
            Debug.Assert(root != null);
            var isRoot = lazyBinder is null;
            Binder rootBinder = isRoot ? _compilation.BuckStopsHereBinder : lazyBinder;
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
            return RootBinder.GetBinder(syntax);
        }

        public Binder GetEnclosingBinder(SyntaxNodeOrToken syntax)
        {
            return RootBinder.GetEnclosingBinder(syntax);
        }

        public Binder GetEnclosingBinder(TextSpan span)
        {
            return RootBinder.GetEnclosingBinder(span);
        }
    }
}
