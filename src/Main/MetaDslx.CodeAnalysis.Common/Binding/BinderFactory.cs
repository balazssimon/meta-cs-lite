﻿using MetaDslx.CodeAnalysis.PooledObjects;
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
            _pool = new ObjectPool<BinderFactoryVisitor>(() => _syntaxTree.Language.SyntaxFactory.CreateBinderFactoryVisitor(this), 64);
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
                    var rootBinder = BuildBinderTreeRoot(_syntaxTree.GetRoot());
                    Interlocked.CompareExchange(ref _rootBinder, rootBinder, null);
                }
                return _rootBinder;
            }
        }

        private RootBinder BuildBinderTreeRoot(SyntaxNodeOrToken root)
        {
            Debug.Assert(root != null);
            var rootBinder = new RootBinder(_syntaxTree);
            rootBinder.InitBinder(_compilation.BuckStopsHereBinder, root);
            BinderFactoryVisitor visitor = _pool.Allocate();
            visitor.Initialize(true, root.SpanStart, root.IsToken, -1);
            visitor.Begin(rootBinder, root);
            visitor.Visit(root.IsNode ? root.AsNode() : root.Parent);
            visitor.End(rootBinder);
            _pool.Free(visitor);
            return rootBinder;
        }

        public ImmutableArray<Binder> BuildBinderTreeLazy(SyntaxNodeOrToken root, LazyBinder lazyBinder)
        {
            Debug.Assert(root != null);
            Debug.Assert(lazyBinder != null);
            BinderFactoryVisitor visitor = _pool.Allocate();
            visitor.Initialize(false, root.SpanStart, root.IsToken, -1);
            visitor.Begin(lazyBinder, root);
            visitor.Visit(root.IsNode ? root.AsNode() : root.Parent);
            var result = visitor.End(lazyBinder);
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
