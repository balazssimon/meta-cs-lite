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

        private SingleDeclaration(SyntaxReference syntaxReference, Type modelObjectType)
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


        public static SingleDeclaration Create(SyntaxReference syntaxReference, Type modelObjectType, string? name, string? metadataName, SourceLocation? nameLocation, bool canMerge, ImmutableArray<Declaration> children, ImmutableArray<Diagnostic> diagnostics)
        {
            if (name is not null)
            {
                if (nameLocation is null) throw new ArgumentNullException(nameof(nameLocation), "Name location must not be null if the name is not null.");
                return children.IsDefaultOrEmpty ? new WithName(syntaxReference, modelObjectType, name, metadataName ?? name, nameLocation!, canMerge) : new WithNameAndChildren(syntaxReference, modelObjectType, name, metadataName ?? name, nameLocation!, canMerge, children);
            }
            else
            {
                return children.IsDefaultOrEmpty ? new Empty(syntaxReference, modelObjectType) : new WithChildren(syntaxReference, modelObjectType, children);
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
            return Hash.Combine(this.MetadataName?.GetHashCode() ?? 0, this.ModelObjectType?.GetHashCode() ?? 0);
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
        }

        private class WithName : SingleDeclaration
        {
            private readonly string _name;
            private readonly string _metadataName;
            private readonly SourceLocation _nameLocation;
            private readonly bool _canMerge;

            public WithName(SyntaxReference syntaxReference, Type modelObjectType, string name, string metadataName, SourceLocation nameLocation, bool canMerge)
                : base(syntaxReference, modelObjectType)
            {
                _name = name;
                _metadataName = metadataName;
                _nameLocation = nameLocation;
                _canMerge = canMerge;
            }

            public override string? Name => _name;

            public override string? MetadataName => _metadataName;

            public override bool CanMerge => _canMerge;

            public override ImmutableArray<Declaration> Children => ImmutableArray<Declaration>.Empty;

            public override ImmutableArray<string> ChildNames => ImmutableArray<string>.Empty;

            public override Location NameLocation => _nameLocation;
        }

        private class WithChildren : SingleDeclaration
        {
            private readonly ImmutableArray<Declaration> _children;
            private ImmutableArray<string> _childNames;

            public WithChildren(SyntaxReference syntaxReference, Type modelObjectType, ImmutableArray<Declaration> children)
                : base(syntaxReference, modelObjectType)
            {
                _children = children;
            }

            public override string? Name => null;

            public override string? MetadataName => null;

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

        private class WithNameAndChildren : SingleDeclaration
        {
            private readonly string _name;
            private readonly string _metadataName;
            private readonly bool _canMerge;
            private readonly SourceLocation _nameLocation;
            private readonly ImmutableArray<Declaration> _children;
            private ImmutableArray<string> _childNames;

            public WithNameAndChildren(SyntaxReference syntaxReference, Type modelObjectType, string name, string metadataName, SourceLocation nameLocation, bool canMerge, ImmutableArray<Declaration> children)
                : base(syntaxReference, modelObjectType)
            {
                _name = name;
                _metadataName = metadataName;
                _nameLocation = nameLocation;
                _canMerge = canMerge;
                _children = children;
            }

            public override string? Name => _name;

            public override string? MetadataName => _metadataName;

            public override bool CanMerge => _canMerge;

            public override Location NameLocation => _nameLocation;

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
}
