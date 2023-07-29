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
    [Flags]
    internal enum SingleDeclarationFlags
    {
        None = 0,
        CanMerge = 0x01,
        IsNesting = 0x02
    }

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
        public virtual bool IsNesting => false;
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

        public static SingleDeclaration Create(SyntaxNodeOrToken syntax, Type modelObjectType, string? name, string? metadataName, SourceLocation? nameLocation, bool canMerge, bool isNesting, ImmutableArray<SingleDeclaration> children, ImmutableArray<Diagnostic> diagnostics)
        {
            if (name is not null && nameLocation is null) throw new ArgumentNullException(nameof(nameLocation), "Name location must not be null if the name is not null.");
            var flags = SingleDeclarationFlags.None;
            if (canMerge) flags |= SingleDeclarationFlags.CanMerge;
            if (isNesting) flags |= SingleDeclarationFlags.IsNesting;
            if (diagnostics.IsDefaultOrEmpty)
            {
                if (name is not null)
                {
                    if (flags != SingleDeclarationFlags.None)
                    {
                        return children.IsDefaultOrEmpty ? new WithNameAndFlags(syntax, flags, modelObjectType, name, metadataName ?? name, nameLocation!) : new WithNameAndChildrenAndFlags(syntax, flags, modelObjectType, name, metadataName ?? name, nameLocation!, children);
                    }
                    else
                    {
                        return children.IsDefaultOrEmpty ? new WithName(syntax, modelObjectType, name, metadataName ?? name, nameLocation!) : new WithNameAndChildren(syntax, modelObjectType, name, metadataName ?? name, nameLocation!, children);
                    }
                }
                else
                {
                    if (flags != SingleDeclarationFlags.None)
                    {
                        return children.IsDefaultOrEmpty ? new WithFlags(syntax, flags, modelObjectType) : new WithChildrenAndFlags(syntax, flags, modelObjectType, children);
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
                    return children.IsDefaultOrEmpty ? new WithNameAndFlagsAndDiagnostics(syntax, flags, modelObjectType, name, metadataName ?? name, nameLocation!, diagnostics) : new WithNameAndChildrenAndFlagsAndDiagnostics(syntax, flags, modelObjectType, name, metadataName ?? name, nameLocation!, children, diagnostics);
                }
                else
                {
                    if (flags != SingleDeclarationFlags.None)
                    {
                        return children.IsDefaultOrEmpty ? new WithFlagsAndDiagnostics(syntax, flags, modelObjectType, diagnostics) : new WithChildrenAndFlagsAndDiagnostics(syntax, flags, modelObjectType, children, diagnostics);
                    }
                    else
                    {
                        return children.IsDefaultOrEmpty ? new WithDiagnostics(syntax, modelObjectType, diagnostics) : new WithChildrenAndFlagsAndDiagnostics(syntax, flags, modelObjectType, children, diagnostics);
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

        private class WithFlags : Empty
        {
            private readonly SingleDeclarationFlags _flags;

            public WithFlags(SyntaxNodeOrToken syntax, SingleDeclarationFlags flags, Type modelObjectType) 
                : base(syntax, modelObjectType)
            {
                _flags = flags;
            }

            public override bool CanMerge => _flags.HasFlag(SingleDeclarationFlags.CanMerge);
            public override bool IsNesting => _flags.HasFlag(SingleDeclarationFlags.IsNesting);
        }

        private class WithDiagnostics : Empty
        {
            private readonly ImmutableArray<Diagnostic> _diagnostics;

            public WithDiagnostics(SyntaxNodeOrToken syntax, Type modelObjectType, ImmutableArray<Diagnostic> diagnostics) 
                : base(syntax, modelObjectType)
            {
                _diagnostics = diagnostics;
            }

            public override ImmutableArray<Diagnostic> Diagnostics => _diagnostics;
        }

        private class WithFlagsAndDiagnostics : WithFlags
        {
            private readonly ImmutableArray<Diagnostic> _diagnostics;

            public WithFlagsAndDiagnostics(SyntaxNodeOrToken syntax, SingleDeclarationFlags flags, Type modelObjectType, ImmutableArray<Diagnostic> diagnostics) 
                : base(syntax, flags, modelObjectType)
            {
                _diagnostics = diagnostics;
            }

            public override ImmutableArray<Diagnostic> Diagnostics => _diagnostics;
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

        private class WithNameAndFlags : WithName
        {
            private readonly SingleDeclarationFlags _flags;

            public WithNameAndFlags(SyntaxNodeOrToken syntax, SingleDeclarationFlags flags, Type modelObjectType, string name, string metadataName, SourceLocation nameLocation) 
                : base(syntax, modelObjectType, name, metadataName, nameLocation)
            {
                _flags = flags;
            }

            public override bool CanMerge => _flags.HasFlag(SingleDeclarationFlags.CanMerge);
            public override bool IsNesting => _flags.HasFlag(SingleDeclarationFlags.IsNesting);
        }

        private class WithNameAndFlagsAndDiagnostics : WithNameAndFlags
        {
            private readonly ImmutableArray<Diagnostic> _diagnostics;

            public WithNameAndFlagsAndDiagnostics(SyntaxNodeOrToken syntax, SingleDeclarationFlags flags, Type modelObjectType, string name, string metadataName, SourceLocation nameLocation, ImmutableArray<Diagnostic> diagnostics) 
                : base(syntax, flags, modelObjectType, name, metadataName, nameLocation)
            {
                _diagnostics = diagnostics;
            }

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

        private class WithChildrenAndFlags : WithChildren
        {
            private readonly SingleDeclarationFlags _flags;

            public WithChildrenAndFlags(SyntaxNodeOrToken syntax, SingleDeclarationFlags flags, Type modelObjectType, ImmutableArray<SingleDeclaration> children) 
                : base(syntax, modelObjectType, children)
            {
                _flags = flags;
            }

            public override bool CanMerge => _flags.HasFlag(SingleDeclarationFlags.CanMerge);
            public override bool IsNesting => _flags.HasFlag(SingleDeclarationFlags.IsNesting);
        }

        private class WithChildrenAndFlagsAndDiagnostics : WithChildrenAndFlags
        {
            private readonly ImmutableArray<Diagnostic> _diagnostics;

            public WithChildrenAndFlagsAndDiagnostics(SyntaxNodeOrToken syntax, SingleDeclarationFlags flags, Type modelObjectType, ImmutableArray<SingleDeclaration> children, ImmutableArray<Diagnostic> diagnostics) 
                : base(syntax, flags, modelObjectType, children)
            {
                _diagnostics = diagnostics;
            }

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

        private class WithNameAndChildrenAndFlags : WithNameAndChildren
        {
            private readonly SingleDeclarationFlags _flags;

            public WithNameAndChildrenAndFlags(SyntaxNodeOrToken syntax, SingleDeclarationFlags flags, Type modelObjectType, string name, string metadataName, SourceLocation nameLocation, ImmutableArray<SingleDeclaration> children) 
                : base(syntax, modelObjectType, name, metadataName, nameLocation, children)
            {
                _flags = flags;
            }

            public override bool CanMerge => _flags.HasFlag(SingleDeclarationFlags.CanMerge);
            public override bool IsNesting => _flags.HasFlag(SingleDeclarationFlags.IsNesting);
        }

        private class WithNameAndChildrenAndFlagsAndDiagnostics : WithNameAndChildrenAndFlags
        {
            private readonly ImmutableArray<Diagnostic> _diagnostics;

            public WithNameAndChildrenAndFlagsAndDiagnostics(SyntaxNodeOrToken syntax, SingleDeclarationFlags flags, Type modelObjectType, string name, string metadataName, SourceLocation nameLocation, ImmutableArray<SingleDeclaration> children, ImmutableArray<Diagnostic> diagnostics)
                : base(syntax, flags, modelObjectType, name, metadataName, nameLocation, children)
            {
                _diagnostics = diagnostics;
            }

            public override ImmutableArray<Diagnostic> Diagnostics => _diagnostics;
        }

    }
}
