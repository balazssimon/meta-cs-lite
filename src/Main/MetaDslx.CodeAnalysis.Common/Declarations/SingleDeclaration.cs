using MetaDslx.CodeAnalysis;
using Microsoft.CodeAnalysis;
using Roslyn.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;

namespace MetaDslx.CodeAnalysis.Declarations
{
    public abstract class SingleDeclaration : Declaration
    {
        private readonly SyntaxNodeOrToken _syntax;
        private readonly Type _modelObjectType;

        protected SingleDeclaration(SyntaxNodeOrToken syntax, Type modelObjectType)
        {
            _syntax = syntax;
            _modelObjectType = modelObjectType;
        }

        public virtual bool CanMerge => false;
        public SyntaxNodeOrToken SyntaxReference => _syntax;
        public override Type ModelObjectType => _modelObjectType;
        public abstract Location NameLocation { get; }
        public abstract ImmutableArray<Declaration> Children { get; }
        public abstract ImmutableArray<string> ChildNames { get; }
        public abstract ImmutableArray<Diagnostic> Diagnostics { get; }

        public static RootSingleDeclaration CreateRoot(SyntaxNodeOrToken syntax, string? name, Type modelObjectType, ImmutableArray<SingleDeclaration> children, ImmutableArray<Syntax.ReferenceDirective> referenceDirectives, ImmutableArray<Diagnostic> diagnostics)
        {
            return new RootSingleDeclaration(syntax, name, modelObjectType, children, referenceDirectives, diagnostics);
        }

        public static SingleDeclaration Create(SyntaxNodeOrToken syntax, Type modelObjectType, string? name, string? metadataName, SourceLocation? nameLocation, bool canMerge, ImmutableArray<SingleDeclaration> children, ImmutableArray<Diagnostic> diagnostics)
        {
            if (name is not null && nameLocation is null) throw new ArgumentNullException(nameof(nameLocation), "Name location must not be null if the name is not null.");
            if (diagnostics.IsDefaultOrEmpty)
            {
                if (name is not null)
                {
                    if (canMerge)
                    {
                        return children.IsDefaultOrEmpty ? new MergableWithName(syntax, modelObjectType, name, metadataName ?? name, nameLocation!) : new MergableWithNameAndChildren(syntax, modelObjectType, name, metadataName ?? name, nameLocation!, children);
                    }
                    else
                    {
                        return children.IsDefaultOrEmpty ? new WithName(syntax, modelObjectType, name, metadataName ?? name, nameLocation!) : new WithNameAndChildren(syntax, modelObjectType, name, metadataName ?? name, nameLocation!, children);
                    }
                }
                else
                {
                    if (canMerge)
                    {
                        return children.IsDefaultOrEmpty ? new Mergable(syntax, modelObjectType) : new MergableWithChildren(syntax, modelObjectType, children);
                    }
                    else
                    {
                        return children.IsDefaultOrEmpty ? new Empty(syntax, modelObjectType) : new WithChildren(syntax, modelObjectType, children);
                    }
                }
            }
            else
            {
                if (name is not null)
                {
                    return children.IsDefaultOrEmpty ? new WithNameAndDiagnostics(syntax, modelObjectType, name, metadataName ?? name, nameLocation!, canMerge, diagnostics) : new WithNameAndChildrenAndDiagnostics(syntax, modelObjectType, name, metadataName ?? name, nameLocation!, canMerge, children, diagnostics);
                }
                else
                {
                    if (canMerge)
                    {
                        return children.IsDefaultOrEmpty ? new MergableWithDiagnostics(syntax, modelObjectType, diagnostics) : new WithChildrenAndDiagnostics(syntax, modelObjectType, canMerge, children, diagnostics);
                    }
                    else
                    {
                        return children.IsDefaultOrEmpty ? new EmptyWithDiagnostics(syntax, modelObjectType, diagnostics) : new WithChildrenAndDiagnostics(syntax, modelObjectType, canMerge, children, diagnostics);
                    }
                }
            }
        }

        public override bool Equals(object obj)
        {
            return obj is SingleDeclaration && Equals((SingleDeclaration)obj);
        }

        public bool Equals(SingleDeclaration other)
        {
            // same as itself
            if (object.ReferenceEquals(this, other))
            {
                return true;
            }

            // cannot merge anonymous symbols
            if (this.MetadataName == null) return false;
            if (other.MetadataName == null) return false;

            // kind and name must match
            if ((this.ModelObjectType != other.ModelObjectType) ||
                (this.MetadataName != other.MetadataName))
            {
                return false;
            }

            // whether merge is allowed:
            return this.CanMerge;
        }

        public override int GetHashCode()
        {
            return Hash.Combine(Hash.Combine(this.MetadataName?.GetHashCode() ?? 0, this.ModelObjectType?.GetHashCode() ?? 0), this.CanMerge.GetHashCode());
        }

        private class Empty : SingleDeclaration
        {
            public Empty(SyntaxNodeOrToken syntax, Type modelObjectType)
                : base(syntax, modelObjectType)
            {
            }

            public override string? Name => null;

            public override string? MetadataName => null;

            public override ImmutableArray<Declaration> Children => ImmutableArray<Declaration>.Empty;

            public override ImmutableArray<string> ChildNames => ImmutableArray<string>.Empty;

            public override Location NameLocation => Location.None;

            public override ImmutableArray<Diagnostic> Diagnostics => ImmutableArray<Diagnostic>.Empty;
        }

        private class Mergable : Empty
        {
            public Mergable(SyntaxNodeOrToken syntax, Type modelObjectType) 
                : base(syntax, modelObjectType)
            {
            }

            public override bool CanMerge => true;
        }

        private class EmptyWithDiagnostics : Empty
        {
            private readonly ImmutableArray<Diagnostic> _diagnostics;

            public EmptyWithDiagnostics(SyntaxNodeOrToken syntax, Type modelObjectType, ImmutableArray<Diagnostic> diagnostics) 
                : base(syntax, modelObjectType)
            {
                _diagnostics = diagnostics;
            }

            public override ImmutableArray<Diagnostic> Diagnostics => _diagnostics;
        }

        private class MergableWithDiagnostics : EmptyWithDiagnostics
        {
            public MergableWithDiagnostics(SyntaxNodeOrToken syntax, Type modelObjectType, ImmutableArray<Diagnostic> diagnostics) 
                : base(syntax, modelObjectType, diagnostics)
            {
            }

            public override bool CanMerge => true;
        }

        private class WithName : SingleDeclaration
        {
            private readonly string _name;
            private readonly string _metadataName;
            private readonly SourceLocation _nameLocation;

            public WithName(SyntaxNodeOrToken syntax, Type modelObjectType, string name, string metadataName, SourceLocation nameLocation)
                : base(syntax, modelObjectType)
            {
                _name = name;
                _metadataName = metadataName;
                _nameLocation = nameLocation;
            }

            public override string? Name => _name;

            public override string? MetadataName => _metadataName;

            public override ImmutableArray<Declaration> Children => ImmutableArray<Declaration>.Empty;

            public override ImmutableArray<string> ChildNames => ImmutableArray<string>.Empty;

            public override Location NameLocation => _nameLocation;

            public override ImmutableArray<Diagnostic> Diagnostics => ImmutableArray<Diagnostic>.Empty;
        }

        private class MergableWithName : WithName
        {
            public MergableWithName(SyntaxNodeOrToken syntax, Type modelObjectType, string name, string metadataName, SourceLocation nameLocation) 
                : base(syntax, modelObjectType, name, metadataName, nameLocation)
            {
            }

            public override bool CanMerge => true;
        }

        private class WithNameAndDiagnostics : WithName
        {
            private readonly ImmutableArray<Diagnostic> _diagnostics;
            private readonly bool _canMerge;

            public WithNameAndDiagnostics(SyntaxNodeOrToken syntax, Type modelObjectType, string name, string metadataName, SourceLocation nameLocation, bool canMerge, ImmutableArray<Diagnostic> diagnostics) 
                : base(syntax, modelObjectType, name, metadataName, nameLocation)
            {
                _diagnostics = diagnostics;
                _canMerge = canMerge;
            }

            public override bool CanMerge => _canMerge;
            public override ImmutableArray<Diagnostic> Diagnostics => _diagnostics;
        }

        private class WithChildren : SingleDeclaration
        {
            private readonly ImmutableArray<Declaration> _children;
            private ImmutableArray<string> _childNames;

            public WithChildren(SyntaxNodeOrToken syntax, Type modelObjectType, ImmutableArray<SingleDeclaration> children)
                : base(syntax, modelObjectType)
            {
                _children = children.Cast<SingleDeclaration, Declaration>();
            }

            public override string? Name => null;

            public override string? MetadataName => null;

            public override Location NameLocation => Location.None;

            public override ImmutableArray<Diagnostic> Diagnostics => ImmutableArray<Diagnostic>.Empty;

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

        private class MergableWithChildren : WithChildren
        {
            public MergableWithChildren(SyntaxNodeOrToken syntax, Type modelObjectType, ImmutableArray<SingleDeclaration> children) 
                : base(syntax, modelObjectType, children)
            {
            }

            public override bool CanMerge => true;
        }

        private class WithChildrenAndDiagnostics : WithChildren
        {
            private readonly ImmutableArray<Diagnostic> _diagnostics;
            private readonly bool _canMerge;

            public WithChildrenAndDiagnostics(SyntaxNodeOrToken syntax, Type modelObjectType, bool canMerge, ImmutableArray<SingleDeclaration> children, ImmutableArray<Diagnostic> diagnostics) 
                : base(syntax, modelObjectType, children)
            {
                _diagnostics = diagnostics;
                _canMerge = canMerge;
            }

            public override bool CanMerge => _canMerge;
            public override ImmutableArray<Diagnostic> Diagnostics => _diagnostics;
        }

        private class WithNameAndChildren : SingleDeclaration
        {
            private readonly string _name;
            private readonly string _metadataName;
            private readonly SourceLocation _nameLocation;
            private readonly ImmutableArray<Declaration> _children;
            private ImmutableArray<string> _childNames;

            public WithNameAndChildren(SyntaxNodeOrToken syntax, Type modelObjectType, string name, string metadataName, SourceLocation nameLocation, ImmutableArray<SingleDeclaration> children)
                : base(syntax, modelObjectType)
            {
                _name = name;
                _metadataName = metadataName;
                _nameLocation = nameLocation;
                _children = children.Cast<SingleDeclaration, Declaration>();
            }

            public override string? Name => _name;

            public override string? MetadataName => _metadataName;

            public override Location NameLocation => _nameLocation;

            public override ImmutableArray<Diagnostic> Diagnostics => ImmutableArray<Diagnostic>.Empty;

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

        private class MergableWithNameAndChildren : WithNameAndChildren
        {
            public MergableWithNameAndChildren(SyntaxNodeOrToken syntax, Type modelObjectType, string name, string metadataName, SourceLocation nameLocation, ImmutableArray<SingleDeclaration> children) 
                : base(syntax, modelObjectType, name, metadataName, nameLocation, children)
            {
            }

            public override bool CanMerge => true;
        }

        private class WithNameAndChildrenAndDiagnostics : WithNameAndChildren
        {
            private readonly ImmutableArray<Diagnostic> _diagnostics;
            private readonly bool _canMerge;

            public WithNameAndChildrenAndDiagnostics(SyntaxNodeOrToken syntax, Type modelObjectType, string name, string metadataName, SourceLocation nameLocation, bool canMerge, ImmutableArray<SingleDeclaration> children, ImmutableArray<Diagnostic> diagnostics) 
                : base(syntax, modelObjectType, name, metadataName, nameLocation, children)
            {
                _diagnostics = diagnostics;
                _canMerge = canMerge;
            }

            public override bool CanMerge => _canMerge;
            public override ImmutableArray<Diagnostic> Diagnostics => _diagnostics;
        }

    }
}
