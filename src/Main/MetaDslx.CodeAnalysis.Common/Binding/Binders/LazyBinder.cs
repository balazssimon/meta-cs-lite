using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.CodeAnalysis.Binding
{
    public sealed class LazyBinder : Binder
    {
        private int _lazyIndex;

        internal int LazyIndex
        {
            get => _lazyIndex;
            set => _lazyIndex = value;
        }

        internal void ResolveChildren()
        {
            var binderFactory = Compilation.GetBinderFactory(Syntax.SyntaxTree);
            binderFactory.BuildBinderTree(this.Syntax, this);
        }
    }
}
