using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Declarations
{
    public sealed class LazyRootDeclaration
    {
        private readonly SyntaxTree _syntaxTree;
        private readonly string? _scriptClassName;
        private readonly bool _isSubmission;
        private RootSingleDeclaration? _rootDeclaration;

        internal LazyRootDeclaration(SyntaxTree syntaxTree, string? scriptClassName, bool isSubmission)
        {
            _syntaxTree = syntaxTree;
            _scriptClassName = scriptClassName;
            _isSubmission = isSubmission;
        }

        public RootSingleDeclaration? CachedRootDeclaration => _rootDeclaration;

        public RootSingleDeclaration GetValue(Compilation compilation)
        {
            if (_rootDeclaration is null)
            {
                RootSingleDeclaration? rootDeclaration;
                var rootBinder = compilation.GetRootBinder(_syntaxTree);
                if (rootBinder != null)
                {
                    rootDeclaration = rootBinder.BuildDeclarationTree(_scriptClassName, _isSubmission);
                }
                else
                {
                    rootDeclaration = SingleDeclaration.CreateRoot(default, null, null, ImmutableArray<SingleDeclaration>.Empty, ImmutableArray<Syntax.ReferenceDirective>.Empty, ImmutableArray<Diagnostic>.Empty);
                }
                Interlocked.CompareExchange(ref _rootDeclaration, rootDeclaration, null);
            }
            return _rootDeclaration;
        }
    }
}
