using MetaDslx.CodeAnalysis.PooledObjects;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Text;
using System.Xml.Linq;

namespace MetaDslx.CodeAnalysis.Declarations
{
    public class SingleDeclarationBuilder
    {
        private readonly SyntaxNodeOrToken _syntax;
        private ArrayBuilder<Syntax.ReferenceDirective>? _referenceDirectives;
        private ArrayBuilder<SingleDeclaration>? _children;
        private ArrayBuilder<Diagnostic>? _diagnostics;
        private ArrayBuilder<NameBuilder>? _nameStack;
        private ArrayBuilder<QualifierBuilder>? _qualifiedNames;
        private QualifierBuilder? _currentQualifier;
        private int _currentQualifierStack;

        public SingleDeclarationBuilder(SyntaxNodeOrToken syntax, Type? type)
        {
            _syntax = syntax;
            Type = type;
        }

        public SyntaxNodeOrToken Syntax => _syntax;
        public Type? Type { get; set; }
        public bool CanMerge { get; set; }
        public bool IsName => _nameStack != null && _nameStack.Count > 0;
        public NameBuilder CurrentName => _nameStack != null && _nameStack.Count > 0 ? _nameStack[_nameStack.Count - 1] : default;
        public bool HasName => _qualifiedNames is not null && _qualifiedNames.Count > 0;

        public void AddDiagnostic(Diagnostic diagnostic)
        {
            if (_diagnostics is null) _diagnostics = ArrayBuilder<Diagnostic>.GetInstance();
            _diagnostics.Add(diagnostic);
        }

        public ImmutableArray<Diagnostic> GetDiagnostics()
        {
            return _diagnostics is null ? ImmutableArray<Diagnostic>.Empty : _diagnostics.ToImmutable();
        }

        public void AddReferenceDirective(Syntax.ReferenceDirective directive)
        {
            if (_referenceDirectives is null) _referenceDirectives = ArrayBuilder<Syntax.ReferenceDirective>.GetInstance();
            _referenceDirectives.Add(directive);
        }

        public ImmutableArray<Syntax.ReferenceDirective> GetReferenceDirectives()
        {
            return _referenceDirectives is null ? ImmutableArray<Syntax.ReferenceDirective>.Empty : _referenceDirectives.ToImmutable();
        }

        public void AddChildren(ImmutableArray<SingleDeclaration> children)
        {
            if (_children is null) _children = ArrayBuilder<SingleDeclaration>.GetInstance();
            _children.AddRange(children);
        }

        public ImmutableArray<SingleDeclaration> GetChildren()
        {
            return _children is null ? ImmutableArray<SingleDeclaration>.Empty : _children.ToImmutable();
        }

        public void BeginName(Type? qualifierType, string? qualifierProperty)
        {
            if (_nameStack is null) _nameStack = ArrayBuilder<NameBuilder>.GetInstance();
            _nameStack.Push(new NameBuilder(qualifierType, qualifierProperty));
        }

        public void EndName()
        {
            _nameStack.Pop();
        }

        public void BeginQualifier()
        {
            if (!IsName) return;
            if (_qualifiedNames is null) _qualifiedNames = ArrayBuilder<QualifierBuilder>.GetInstance();
            if (_currentQualifier is null)
            {
                _currentQualifier = new QualifierBuilder();
                _qualifiedNames.Add(_currentQualifier);
            }
            ++_currentQualifierStack;
        }

        public void EndQualifier()
        {
            if (!IsName) return;
            --_currentQualifierStack;
            if (_currentQualifierStack == 0)
            {
                _currentQualifier = null;
            }
        }

        public void AddIdentifier(string name, string metadataName, SourceLocation nameLocation)
        {
            if (!IsName) return;
            if (_currentQualifier is null)
            {
                BeginQualifier();
                _currentQualifier.AddIdentifier(name, metadataName, nameLocation, CurrentName.QualifierType, CurrentName.QualifierProperty);
                EndQualifier();
            }
            else
            {
                _currentQualifier.AddIdentifier(name, metadataName, nameLocation, CurrentName.QualifierType, CurrentName.QualifierProperty);
            }
        }

        public virtual ImmutableArray<SingleDeclaration> ToImmutableAndFree(bool root = false, string? rootName = null)
        {
            var result = ImmutableArray<SingleDeclaration>.Empty;
            try
            {
                if (root)
                {
                    result = ImmutableArray.Create<SingleDeclaration>(SingleDeclaration.CreateRoot(_syntax, rootName, Type, GetChildren(), GetReferenceDirectives(), GetDiagnostics()));
                }
                else
                {
                    if (_qualifiedNames is null)
                    {
                        result = ImmutableArray.Create(SingleDeclaration.Create(_syntax, Type, null, null, null, canMerge: CanMerge, isNesting: false, null, GetChildren(), GetDiagnostics()));
                    }
                    else
                    {
                        var builder = ArrayBuilder<SingleDeclaration>.GetInstance();
                        foreach (var qualifier in _qualifiedNames)
                        {
                            builder.Add(qualifier.ToImmutableAndFree(this));
                        }
                        result = builder.ToImmutableAndFree();
                    }
                }
            }
            finally
            {
                if (_children is not null) _children.Free();
                if (_diagnostics is not null) _diagnostics.Free();
                if (_referenceDirectives is not null) _referenceDirectives.Free();
                if (_qualifiedNames is not null) _qualifiedNames.Free();
                if (_nameStack is not null) _nameStack.Free();
            }
            return result;
        }
    }
}
