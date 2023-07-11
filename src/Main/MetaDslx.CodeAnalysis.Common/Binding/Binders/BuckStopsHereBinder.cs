using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Binding
{
    /// <summary>
    /// A binder that knows no symbols and will not delegate further.
    /// </summary>
    public sealed class BuckStopsHereBinder : Binder
    {
        private SyntaxTree _syntaxTree;
        private RootBinder? _rootBinder;

        public BuckStopsHereBinder(Compilation compilation, SyntaxTree syntaxTree)
        {
            this.Compilation = compilation;
            _syntaxTree = syntaxTree;
        }

        public override Language Language => _syntaxTree.Language;
        public override SyntaxTree SyntaxTree => _syntaxTree;

        public RootBinder? RootBinder
        {
            get
            {
                if (_rootBinder is null)
                {
                    Interlocked.CompareExchange(ref _rootBinder, GetRootBinder(), null);
                }
                return _rootBinder;
            }
        }
    }
}
