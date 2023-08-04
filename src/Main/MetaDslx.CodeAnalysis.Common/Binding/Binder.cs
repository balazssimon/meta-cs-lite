using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.CodeAnalysis.Symbols;
using MetaDslx.CodeAnalysis.Text;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Binding
{
    /// <summary>
    /// A Binder converts names in to symbols and syntax nodes into bound trees. It is context
    /// dependent, relative to a location in source code.
    /// </summary>
    public abstract partial class Binder
    {
        private Compilation _compilation;
        private Binder? _parentBinder;
        private ImmutableArray<Binder> _childBinders;
        private SyntaxNodeOrToken _syntax;
        private ImmutableArray<Diagnostic> _diagnostics;
        private ImmutableArray<object?> _boundValues;

        public virtual Language Language => _syntax == null ? Language.NoLanguage : _syntax.Language;
        public virtual SyntaxTree SyntaxTree => _parentBinder.SyntaxTree;
        public Binder ParentBinder => _parentBinder;
        public SyntaxNodeOrToken Syntax => _syntax;
        public SourceLocation? Location => (SourceLocation?)_syntax.GetLocation();
        public TextSpan FullSpan => _syntax.FullSpan;

        public Compilation Compilation
        {
            get => _compilation;
            internal set => _compilation = value;
        }

        internal virtual RootBinder? GetRootBinder()
        {
            foreach (var child in GetChildBinders())
            {
                var root = child.GetRootBinder();
                if (root is not null) return root;
            }
            return null;
        }

        public virtual Binder GetBinder(SyntaxNodeOrToken syntax)
        {
            var span = syntax.FullSpan;
            if (this.FullSpan.Contains(span))
            {
                return this.GetBinder(this, syntax);
            }
            return null;
        }

        public Binder GetEnclosingBinder(SyntaxNodeOrToken syntax)
        {
            return GetEnclosingBinder(syntax.FullSpan);
        }

        public virtual Binder GetEnclosingBinder(TextSpan span)
        {
            if (this.FullSpan.Contains(span))
            {
                return this.GetBinder(this, span);
            }
            return null;
        }

        private Binder? GetBinder(Binder parent, SyntaxNodeOrToken syntax)
        {
            var span = syntax.FullSpan;
            var parentStack = ArrayBuilder<Binder>.GetInstance();
            parentStack.Add(parent);
            var repeat = true;
            while (repeat)
            {
                repeat = false;
                var currentParent = parentStack[parentStack.Count - 1];
                foreach (var child in currentParent.GetChildBinders(resolveLazy: true))
                {
                    if (child.FullSpan.Contains(span))
                    {
                        parentStack.Add(child);
                        repeat = true;
                        break;
                    }
                }
            }
            for (int i = parentStack.Count - 1; i >= 0; --i)
            {
                var currentParent = parentStack[i];
                if (currentParent.Syntax == syntax) return currentParent;
            }
            return null;
        }

        private Binder? GetBinder(Binder parent, TextSpan span)
        {
            var currentParent = parent;
            var repeat = true;
            while (repeat)
            {
                repeat = false;
                foreach (var child in currentParent.GetChildBinders(resolveLazy: true))
                {
                    if (child.FullSpan.Contains(span))
                    {
                        currentParent = child;
                        repeat = true;
                        break;
                    }
                }
            }
            return parent;
        }

        public ImmutableArray<Binder> GetChildBinders(bool resolveLazy = false, CancellationToken cancellationToken = default)
        {
            if (this is BuckStopsHereBinder buckStopsHereBinder)
            {
                if (_childBinders.IsDefault)
                {
                    var syntaxTree = buckStopsHereBinder.SyntaxTree;
                    var factory = Compilation.GetBinderFactory(syntaxTree);
                    if (syntaxTree.TryGetRoot(out var root) && root is not null)
                    {
                        return factory.BuildBinderTree(root);
                    }
                    else
                    {
                        return ImmutableArray<Binder>.Empty;
                    }
                }
            }
            else if (this is LazyBinder lazyBinder)
            {
                if (!resolveLazy)
                {
                    return ImmutableArray<Binder>.Empty;
                }
                else if (_childBinders.IsDefault)
                {
                    return lazyBinder.ResolveChildren();
                }
            }
            return _childBinders;
        }

        internal void InitBinder(Binder? parent, SyntaxNodeOrToken syntax)
        {
            _syntax = syntax;
            if (parent is not null)
            {
                Interlocked.CompareExchange(ref _compilation, parent._compilation, null);
                Interlocked.CompareExchange(ref _parentBinder, parent, null);
            }
        }

        internal virtual ImmutableArray<Binder> InitChildBinders(ImmutableArray<Binder> children)
        {
            ImmutableInterlocked.InterlockedInitialize(ref _childBinders, children);
            return children;
        }

        protected virtual ImmutableArray<SingleDeclaration> BuildDeclarationTree(SingleDeclarationBuilder builder)
        {
            return BuildChildDeclarationTree(builder);
        }

        protected ImmutableArray<SingleDeclaration> BuildChildDeclarationTree(SingleDeclarationBuilder builder, bool resolveLazy = false)
        {
            if (_childBinders.IsDefault) return ImmutableArray<SingleDeclaration>.Empty;
            var arrayBuilder = ArrayBuilder<ImmutableArray<SingleDeclaration>>.GetInstance();
            try
            {
                foreach (var child in GetChildBinders(resolveLazy))
                {
                    var decls = child.BuildDeclarationTree(builder);
                    if (!decls.IsDefaultOrEmpty) arrayBuilder.Add(decls);
                }
                if (arrayBuilder.Count == 0) return ImmutableArray<SingleDeclaration>.Empty;
                else if (arrayBuilder.Count == 1) return arrayBuilder[0];
                else
                {
                    var resultBuilder = ArrayBuilder<SingleDeclaration>.GetInstance();
                    foreach (var decls in arrayBuilder)
                    {
                        resultBuilder.AddRange(decls);
                    }
                    return resultBuilder.ToImmutableAndFree();
                }
            }
            finally
            {
                arrayBuilder.Free();
            }
        }

        public virtual ImmutableArray<Symbol> DefinedSymbols => ImmutableArray<Symbol>.Empty;

        public virtual ImmutableArray<Symbol> ContainingSymbols => ParentBinder?.ContainingSymbols ?? ImmutableArray<Symbol>.Empty;

        public virtual ImmutableArray<Symbol> ContainingDefinedSymbols => ParentBinder?.ContainingDefinedSymbols ?? ImmutableArray<Symbol>.Empty;

        public ImmutableArray<INameBinder> GetNameBinders(CancellationToken cancellationToken = default)
        {
            var nameBinders = ArrayBuilder<INameBinder>.GetInstance();
            CollectNameBinders(nameBinders, cancellationToken);
            return nameBinders.ToImmutableAndFree();
        }

        protected virtual void CollectNameBinders(ArrayBuilder<INameBinder> nameBinders, CancellationToken cancellationToken)
        {
            foreach (var child in GetChildBinders(false, cancellationToken))
            {
                child.CollectNameBinders(nameBinders, cancellationToken);
            }
        }

        public ImmutableArray<IQualifierBinder> GetQualifierBinders(CancellationToken cancellationToken = default)
        {
            var qualifierBinders = ArrayBuilder<IQualifierBinder>.GetInstance();
            CollectQualifierBinders(qualifierBinders, cancellationToken);
            return qualifierBinders.ToImmutableAndFree();
        }

        protected virtual void CollectQualifierBinders(ArrayBuilder<IQualifierBinder> qualifierBinders, CancellationToken cancellationToken)
        {
            foreach (var child in GetChildBinders(false, cancellationToken))
            {
                child.CollectQualifierBinders(qualifierBinders, cancellationToken);
            }
        }

        public ImmutableArray<IIdentifierBinder> GetIdentifierBinders(CancellationToken cancellationToken = default)
        {
            var identifierBinders = ArrayBuilder<IIdentifierBinder>.GetInstance();
            CollectIdentifierBinders(identifierBinders, cancellationToken);
            return identifierBinders.ToImmutableAndFree();
        }

        protected virtual void CollectIdentifierBinders(ArrayBuilder<IIdentifierBinder> identifierBinders, CancellationToken cancellationToken)
        {
            foreach (var child in GetChildBinders(false, cancellationToken))
            {
                child.CollectIdentifierBinders(identifierBinders, cancellationToken);
            }
        }

        public ImmutableArray<IPropertyBinder> GetPropertyBinders(CancellationToken cancellationToken = default)
        {
            var propertyBinders = ArrayBuilder<IPropertyBinder>.GetInstance();
            CollectPropertyBinders(propertyBinders, cancellationToken);
            return propertyBinders.ToImmutableAndFree();
        }

        protected virtual void CollectPropertyBinders(ArrayBuilder<IPropertyBinder> propertyBinders, CancellationToken cancellationToken)
        {
            foreach (var child in GetChildBinders(false, cancellationToken))
            {
                child.CollectPropertyBinders(propertyBinders, cancellationToken);
            }
        }

        public ImmutableArray<IValueBinder> GetValueBinders(ImmutableArray<IPropertyBinder> propertyBinders, CancellationToken cancellationToken = default)
        {
            var valueBinders = ArrayBuilder<IValueBinder>.GetInstance();
            CollectValueBinders(propertyBinders, valueBinders, cancellationToken);
            return valueBinders.ToImmutableAndFree();
        }

        protected virtual void CollectValueBinders(ImmutableArray<IPropertyBinder> propertyBinders, ArrayBuilder<IValueBinder> valueBinders, CancellationToken cancellationToken)
        {
            foreach (var child in GetChildBinders(false, cancellationToken))
            {
                child.CollectValueBinders(propertyBinders, valueBinders, cancellationToken);
            }
        }

        protected INameBinder? GetEnclosingNameBinder()
        {
            INameBinder? lastName = null;
            var currentBinder = this;
            while (currentBinder != null)
            {
                if (currentBinder is INameBinder nameBinder)
                {
                    lastName = nameBinder;
                }
                else if (currentBinder is IValueBinder || currentBinder is IScopeBinder)
                {
                    break;
                }
                currentBinder = currentBinder.ParentBinder;
            }
            return lastName;
        }

        protected IQualifierBinder? GetEnclosingQualifierBinder()
        {
            IQualifierBinder? lastQualifier = null;
            var currentBinder = this;
            while (currentBinder != null)
            {
                if (currentBinder is IQualifierBinder qualifierBinder)
                {
                    lastQualifier = qualifierBinder;
                }
                else if (currentBinder is IValueBinder || currentBinder is IScopeBinder)
                {
                    break;
                }
                currentBinder = currentBinder.ParentBinder;
            }
            return lastQualifier;
        }

        protected virtual IPropertyBinder? GetEnclosingPropertyBinder()
        {
            return ParentBinder?.GetEnclosingPropertyBinder();
        }

        public ImmutableArray<object?> Bind(BindingContext context)
        {
            if (_boundValues.IsDefault)
            {
                var diagnosticBag = DiagnosticBag.GetInstance();
                var boundValues = BindValues(context);
                ImmutableInterlocked.InterlockedInitialize(ref _boundValues, boundValues);
                ImmutableInterlocked.InterlockedInitialize(ref _diagnostics, diagnosticBag.ToReadOnlyAndFree());
            }
            context.Diagnostics.AddRange(_diagnostics);
            return _boundValues;
        }

        protected virtual ImmutableArray<object?> BindValues(BindingContext context)
        {
            return ImmutableArray<object?>.Empty;
        }

        public override string ToString()
        {
            return this.GetType().Name;
        }
    }
}
