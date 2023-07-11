using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.PooledObjects;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace MetaDslx.CodeAnalysis.Declarations
{
    public abstract class MergedDeclaration : Declaration
    {
        private readonly ImmutableArray<SingleDeclaration> _declarations;

        private MergedDeclaration(ImmutableArray<SingleDeclaration> declarations)
        {
            _declarations = declarations;
        }

        public override string? Name => _declarations[0].Name;

        public override string? MetadataName => _declarations[0].MetadataName;

        public override Type ModelObjectType => _declarations[0].ModelObjectType;

        public ImmutableArray<SingleDeclaration> Declarations => _declarations;

        public ImmutableArray<SyntaxNodeOrToken> SyntaxReferences => _declarations.SelectAsArray(decl => decl.SyntaxReference);

        public ImmutableArray<Location> NameLocations => _declarations.SelectAsArray(decl => decl.NameLocation);

        public abstract ImmutableArray<MergedDeclaration> Children { get; }

        public abstract ImmutableArray<string> ChildNames { get; }

        public static MergedDeclaration Create(SingleDeclaration declaration)
        {
            return Create(ImmutableArray.Create(declaration));
        }
        public static MergedDeclaration Create(ImmutableArray<SingleDeclaration> declarations)
        {
            //Debug.Assert(!declarations.IsDefaultOrEmpty, "The declarations array must not be empty.");
            if (declarations.IsDefaultOrEmpty) return new Error();
            bool isRoot = declarations[0] is RootSingleDeclaration;
            Type modelObjectType = declarations[0].ModelObjectType;
            string? name = declarations[0].Name;
            string? metadataName = declarations[0].MetadataName;
            bool hasChildren = declarations[0].Children.Length > 0;
            bool hasChildrenWithName = declarations[0].Children.Any(child => !string.IsNullOrEmpty(child.Name));
            for (int i = 1; i < declarations.Length; i++)
            {
                var declaration = declarations[i];
                if (declaration is RootSingleDeclaration) isRoot = true;
                if (declaration.ModelObjectType != null)
                {
                    if (modelObjectType == null) modelObjectType = declaration.ModelObjectType;
                    else throw new ArgumentException("The merged declarations must have the same model object type.", nameof(declarations));
                }
                if (!string.IsNullOrEmpty(declaration.Name))
                {
                    if (string.IsNullOrEmpty(name)) name = declaration.Name;
                    else throw new ArgumentException("The merged declarations must have the same name.", nameof(declarations));
                }
                if (!string.IsNullOrEmpty(declaration.MetadataName))
                {
                    if (string.IsNullOrEmpty(metadataName)) metadataName = declaration.MetadataName;
                    else throw new ArgumentException("The merged declarations must have the same metadata name.", nameof(declarations));
                }
                hasChildren |= declaration.Children.Length > 0;
                hasChildrenWithName |= declaration.Children.Any(child => !string.IsNullOrEmpty(child.Name));
            }
            if (isRoot) return new Root(name, metadataName, modelObjectType, declarations);
            else if (!hasChildren) return new Empty(declarations);
            else if (!hasChildrenWithName) return new WithAnonymousChildren(declarations);
            else return new WithChildren(declarations);
        }

        private class Error : MergedDeclaration
        {
            public Error()
                : base(ImmutableArray.Create(SingleDeclaration.Create(null, null, null, null, null, false, ImmutableArray<SingleDeclaration>.Empty, ImmutableArray<Diagnostic>.Empty)))
            {
                
            }

            public override ImmutableArray<MergedDeclaration> Children => ImmutableArray<MergedDeclaration>.Empty;

            public override ImmutableArray<string> ChildNames => ImmutableArray<string>.Empty;
        }

        private class Empty : MergedDeclaration
        {
            public Empty(ImmutableArray<SingleDeclaration> declarations)
                : base(declarations)
            {
            }

            public override ImmutableArray<MergedDeclaration> Children => ImmutableArray<MergedDeclaration>.Empty;

            public override ImmutableArray<string> ChildNames => ImmutableArray<string>.Empty;
        }

        private class WithAnonymousChildren : MergedDeclaration
        {
            private ImmutableArray<MergedDeclaration> _lazyChildren;

            public WithAnonymousChildren(ImmutableArray<SingleDeclaration> declarations) 
                : base(declarations)
            {
            }

            public override ImmutableArray<MergedDeclaration> Children
            {
                get
                {
                    if (_lazyChildren.IsDefault)
                    {
                        var children = _declarations.SelectAsArray(decl => Create(decl));
                        ImmutableInterlocked.InterlockedInitialize(ref _lazyChildren, children);
                    }
                    return _lazyChildren;
                }
            }

            public override ImmutableArray<string> ChildNames => ImmutableArray<string>.Empty;
        }

        private class WithChildren : MergedDeclaration
        {
            private ImmutableArray<MergedDeclaration> _lazyChildren;
            private ImmutableArray<string> _lazyChildNames;

            public WithChildren(ImmutableArray<SingleDeclaration> declarations) 
                : base(declarations)
            {
            }

            private void MakeChildren()
            {
                var nestedDeclarations = ArrayBuilder<SingleDeclaration>.GetInstance();

                foreach (var decl in this.Declarations)
                {
                    foreach (var child in decl.Children)
                    {
                        if (child is SingleDeclaration single)
                        {
                            nestedDeclarations.Add(single);
                        }
                    }
                }

                var members = ArrayBuilder<MergedDeclaration>.GetInstance();
                var memberNames = ArrayBuilder<string>.GetInstance();

                if (nestedDeclarations != null)
                {
                    var membersGrouped = nestedDeclarations.ToDictionary(m => m);
                    nestedDeclarations.Free();

                    foreach (var memberGroup in membersGrouped.Values)
                    {
                        var merged = MergedDeclaration.Create(memberGroup);
                        members.Add(merged);
                        if (merged.Name != null) memberNames.Add(merged.Name);
                    }
                }

                ImmutableInterlocked.InterlockedInitialize(ref _lazyChildren, members.ToImmutableAndFree());
                ImmutableInterlocked.InterlockedInitialize(ref _lazyChildNames, memberNames.ToImmutableAndFree());
            }

            public override ImmutableArray<MergedDeclaration> Children
            {
                get
                {
                    if (_lazyChildren.IsDefault) MakeChildren();
                    return _lazyChildren;
                }
            }

            public override ImmutableArray<string> ChildNames
            {
                get
                {
                    if (_lazyChildNames.IsDefault) MakeChildren();
                    return _lazyChildNames;
                }
            }


        }

        private class Root : WithChildren
        {
            private readonly string _name;
            private readonly string _metadataName;
            private readonly Type _modelObjectType;

            public Root(string name, string metadataName, Type modelObjectType, ImmutableArray<SingleDeclaration> declarations) 
                : base(declarations)
            {
                _name = name;
                _metadataName = metadataName;
                _modelObjectType = modelObjectType;
            }

            public override string? Name => _name;
            public override string? MetadataName => _metadataName;
            public override Type ModelObjectType => _modelObjectType;
        }
    }
}
