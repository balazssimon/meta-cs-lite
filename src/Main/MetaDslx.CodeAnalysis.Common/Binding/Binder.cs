using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.PooledObjects;
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

        public virtual Language Language => _syntax == null ? Language.NoLanguage : _syntax.Language;
        public Binder ParentBinder => _parentBinder;
        public SyntaxNodeOrToken Syntax => _syntax;
        public Compilation Compilation
        {
            get => _compilation;
            internal set => _compilation = value;
        }

        public ImmutableArray<Binder> GetChildBinders(bool resolveLazy = false)
        {
            if (this is LazyBinder lazyBinder)
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

        internal virtual void InitBinder(Binder? parent, SyntaxNodeOrToken syntax)
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

        protected virtual ImmutableArray<SingleDeclaration> BuildDeclarationTree(SingleDeclarationBuilder builder, bool resolveLazy = false)
        {
            return BuildChildDeclarationTree(builder, resolveLazy);
        }

        protected virtual ImmutableArray<SingleDeclaration> BuildChildDeclarationTree(SingleDeclarationBuilder builder, bool resolveLazy = false)
        {
            if (_childBinders.IsDefault) return ImmutableArray<SingleDeclaration>.Empty;
            var arrayBuilder = ArrayBuilder<ImmutableArray<SingleDeclaration>>.GetInstance();
            try
            {
                foreach (var child in GetChildBinders(resolveLazy))
                {
                    var decls = child.BuildDeclarationTree(builder, false);
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
    }
}
