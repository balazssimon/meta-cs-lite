using MetaDslx.CodeAnalysis.Binding;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;

namespace MetaDslx.CodeAnalysis.Declarations
{
    public sealed class LazySingleDeclaration : SingleDeclaration
    {
        private readonly LazyBinder _binder;
        private ImmutableArray<Declaration> _children;
        private ImmutableArray<string> _childNames;

        internal LazySingleDeclaration(
            SyntaxNodeOrToken syntax,
            Type modelObjectType,
            LazyBinder binder)
            : base(syntax, modelObjectType)
        {
            _binder = binder;
        }

        public override ImmutableArray<Diagnostic> Diagnostics => ImmutableArray<Diagnostic>.Empty;

        public override string? Name => null;

        public override string? MetadataName => null;

        public override Location NameLocation => Location.None;

        public override ImmutableArray<Declaration> Children
        {
            get
            {
                if (_children.IsDefault)
                {
                    var children = _binder.BuildDeclarationTree().Cast<SingleDeclaration,Declaration>();
                    ImmutableInterlocked.InterlockedInitialize(ref _children, children);
                }
                return _children;
            }
        }

        public override ImmutableArray<string> ChildNames
        {
            get
            {
                if (_childNames.IsDefault)
                {
                    var childNames = Children.Where(child => child.Name is not null).Select(child => child.Name!).ToImmutableArray();
                    ImmutableInterlocked.InterlockedInitialize(ref _childNames, childNames);
                }
                return _childNames;
            }
        }
    }
}
