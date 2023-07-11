using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;

namespace MetaDslx.CodeAnalysis.Declarations
{
    public sealed class RootSingleDeclaration : SingleDeclaration
    {
        private readonly string? _name;
        private readonly ImmutableArray<Declaration> _children;
        private ImmutableArray<string> _childNames;
        private readonly ImmutableArray<Syntax.ReferenceDirective> _referenceDirectives;
        private readonly ImmutableArray<Diagnostic> _diagnostics;

        internal RootSingleDeclaration(
            SyntaxNodeOrToken syntax,
            string? name,
            Type modelObjectType,
            ImmutableArray<SingleDeclaration> children,
            ImmutableArray<Syntax.ReferenceDirective> referenceDirectives,
            ImmutableArray<Diagnostic> diagnostics)
            : base(syntax, modelObjectType)
        {
            _name = name;
            _children = children.Cast<SingleDeclaration, Declaration>();
            _referenceDirectives = referenceDirectives;
            _diagnostics = diagnostics;
        }

        public ImmutableArray<Syntax.ReferenceDirective> ReferenceDirectives => _referenceDirectives;

        public override ImmutableArray<Diagnostic> Diagnostics => _diagnostics;

        public override string? Name => _name;

        public override string? MetadataName => _name;

        public override Location NameLocation => Location.None;

        public override ImmutableArray<Declaration> Children => _children;

        public override ImmutableArray<string> ChildNames
        {
            get
            {
                if (_childNames.IsDefault)
                {
                    var childNames = _children.Where(child => child.Name is not null).Select(child => child.Name!).ToImmutableArray();
                    ImmutableInterlocked.InterlockedInitialize(ref _childNames, childNames);
                }
                return _childNames;
            }
        }
    }
}
