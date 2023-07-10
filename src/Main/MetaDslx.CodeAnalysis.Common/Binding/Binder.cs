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
        public Compilation Compilation
        {
            get => _compilation;
            internal set => _compilation = value;
        }
        public Binder ParentBinder => _parentBinder;
        public SyntaxNodeOrToken Syntax => _syntax;

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
                    lazyBinder.ResolveChildren();
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

        internal void InitChildBinders(ImmutableArray<Binder> children)
        {
            ImmutableInterlocked.InterlockedInitialize(ref _childBinders, children);
        }
    }
}
