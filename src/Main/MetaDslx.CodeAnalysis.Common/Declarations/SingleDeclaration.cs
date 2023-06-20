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
        private readonly SyntaxReference _syntaxReference;
        private readonly Type _modelObjectType;

        protected SingleDeclaration(SyntaxReference syntaxReference, Type modelObjectType)
        {
            _syntaxReference = syntaxReference;
            _modelObjectType = modelObjectType;
        }

        public virtual bool CanMerge => false;
        public SyntaxReference SyntaxReference => _syntaxReference;
        public override Type ModelObjectType => _modelObjectType;
        public abstract Location NameLocation { get; }
        public abstract ImmutableArray<Declaration> Children { get; }
        public abstract ImmutableArray<string> ChildNames { get; }
        public abstract ImmutableArray<Diagnostic> Diagnostics { get; }

        public static RootSingleDeclaration CreateRoot(SyntaxReference syntaxReference, Type modelObjectType, ImmutableArray<SingleDeclaration> children, ImmutableArray<Syntax.ReferenceDirective> referenceDirectives, ImmutableArray<Diagnostic> diagnostics)
        {
            return new RootSingleDeclaration(syntaxReference, modelObjectType, children, referenceDirectives, diagnostics);
        }

        public static SingleDeclaration Create(SyntaxReference syntaxReference, Type modelObjectType, string? name, string? metadataName, SourceLocation? nameLocation, bool canMerge, ImmutableArray<SingleDeclaration> children, ImmutableArray<Diagnostic> diagnostics)
        {
            if (name is not null && nameLocation is null) throw new ArgumentNullException(nameof(nameLocation), "Name location must not be null if the name is not null.");
            if (diagnostics.IsDefaultOrEmpty)
            {
                if (name is not null)
                {
                    if (canMerge)
                    {
                        return children.IsDefaultOrEmpty ? new MergableWithName(syntaxReference, modelObjectType, name, metadataName ?? name, nameLocation!) : new MergableWithNameAndChildren(syntaxReference, modelObjectType, name, metadataName ?? name, nameLocation!, children);
                    }
                    else
                    {
                        return children.IsDefaultOrEmpty ? new WithName(syntaxReference, modelObjectType, name, metadataName ?? name, nameLocation!) : new WithNameAndChildren(syntaxReference, modelObjectType, name, metadataName ?? name, nameLocation!, children);
                    }
                }
                else
                {
                    if (canMerge)
                    {
                        return children.IsDefaultOrEmpty ? new Mergable(syntaxReference, modelObjectType) : new MergableWithChildren(syntaxReference, modelObjectType, children);
                    }
                    else
                    {
                        return children.IsDefaultOrEmpty ? new Empty(syntaxReference, modelObjectType) : new WithChildren(syntaxReference, modelObjectType, children);
                    }
                }
            }
            else
            {
                if (name is not null)
                {
                    return children.IsDefaultOrEmpty ? new WithNameAndDiagnostics(syntaxReference, modelObjectType, name, metadataName ?? name, nameLocation!, canMerge, diagnostics) : new WithNameAndChildrenAndDiagnostics(syntaxReference, modelObjectType, name, metadataName ?? name, nameLocation!, canMerge, children, diagnostics);
                }
                else
                {
                    if (canMerge)
                    {
                        return children.IsDefaultOrEmpty ? new MergableWithDiagnostics(syntaxReference, modelObjectType, diagnostics) : new WithChildrenAndDiagnostics(syntaxReference, modelObjectType, canMerge, children, diagnostics);
                    }
                    else
                    {
                        return children.IsDefaultOrEmpty ? new EmptyWithDiagnostics(syntaxReference, modelObjectType, diagnostics) : new WithChildrenAndDiagnostics(syntaxReference, modelObjectType, canMerge, children, diagnostics);
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
            public Empty(SyntaxReference syntaxReference, Type modelObjectType)
                : base(syntaxReference, modelObjectType)
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
            public Mergable(SyntaxReference syntaxReference, Type modelObjectType) 
                : base(syntaxReference, modelObjectType)
            {
            }

            public override bool CanMerge => true;
        }

        private class EmptyWithDiagnostics : Empty
        {
            private readonly ImmutableArray<Diagnostic> _diagnostics;

            public EmptyWithDiagnostics(SyntaxReference syntaxReference, Type modelObjectType, ImmutableArray<Diagnostic> diagnostics) 
                : base(syntaxReference, modelObjectType)
            {
                _diagnostics = diagnostics;
            }

            public override ImmutableArray<Diagnostic> Diagnostics => _diagnostics;
        }

        private class MergableWithDiagnostics : EmptyWithDiagnostics
        {
            public MergableWithDiagnostics(SyntaxReference syntaxReference, Type modelObjectType, ImmutableArray<Diagnostic> diagnostics) 
                : base(syntaxReference, modelObjectType, diagnostics)
            {
            }

            public override bool CanMerge => true;
        }

        private class WithName : SingleDeclaration
        {
            private readonly string _name;
            private readonly string _metadataName;
            private readonly SourceLocation _nameLocation;

            public WithName(SyntaxReference syntaxReference, Type modelObjectType, string name, string metadataName, SourceLocation nameLocation)
                : base(syntaxReference, modelObjectType)
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
            public MergableWithName(SyntaxReference syntaxReference, Type modelObjectType, string name, string metadataName, SourceLocation nameLocation) 
                : base(syntaxReference, modelObjectType, name, metadataName, nameLocation)
            {
            }

            public override bool CanMerge => true;
        }

        private class WithNameAndDiagnostics : WithName
        {
            private readonly ImmutableArray<Diagnostic> _diagnostics;
            private readonly bool _canMerge;

            public WithNameAndDiagnostics(SyntaxReference syntaxReference, Type modelObjectType, string name, string metadataName, SourceLocation nameLocation, bool canMerge, ImmutableArray<Diagnostic> diagnostics) 
                : base(syntaxReference, modelObjectType, name, metadataName, nameLocation)
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

            public WithChildren(SyntaxReference syntaxReference, Type modelObjectType, ImmutableArray<SingleDeclaration> children)
                : base(syntaxReference, modelObjectType)
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
            public MergableWithChildren(SyntaxReference syntaxReference, Type modelObjectType, ImmutableArray<SingleDeclaration> children) 
                : base(syntaxReference, modelObjectType, children)
            {
            }

            public override bool CanMerge => true;
        }

        private class WithChildrenAndDiagnostics : WithChildren
        {
            private readonly ImmutableArray<Diagnostic> _diagnostics;
            private readonly bool _canMerge;

            public WithChildrenAndDiagnostics(SyntaxReference syntaxReference, Type modelObjectType, bool canMerge, ImmutableArray<SingleDeclaration> children, ImmutableArray<Diagnostic> diagnostics) 
                : base(syntaxReference, modelObjectType, children)
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

            public WithNameAndChildren(SyntaxReference syntaxReference, Type modelObjectType, string name, string metadataName, SourceLocation nameLocation, ImmutableArray<SingleDeclaration> children)
                : base(syntaxReference, modelObjectType)
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
            public MergableWithNameAndChildren(SyntaxReference syntaxReference, Type modelObjectType, string name, string metadataName, SourceLocation nameLocation, ImmutableArray<SingleDeclaration> children) 
                : base(syntaxReference, modelObjectType, name, metadataName, nameLocation, children)
            {
            }

            public override bool CanMerge => true;
        }

        private class WithNameAndChildrenAndDiagnostics : WithNameAndChildren
        {
            private readonly ImmutableArray<Diagnostic> _diagnostics;
            private readonly bool _canMerge;

            public WithNameAndChildrenAndDiagnostics(SyntaxReference syntaxReference, Type modelObjectType, string name, string metadataName, SourceLocation nameLocation, bool canMerge, ImmutableArray<SingleDeclaration> children, ImmutableArray<Diagnostic> diagnostics) 
                : base(syntaxReference, modelObjectType, name, metadataName, nameLocation, children)
            {
                _diagnostics = diagnostics;
                _canMerge = canMerge;
            }

            public override bool CanMerge => _canMerge;
            public override ImmutableArray<Diagnostic> Diagnostics => _diagnostics;
        }
    }
}
