// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using System.Collections.Immutable;
using System.Diagnostics;
using System.Text;
using Microsoft.CodeAnalysis;
using Roslyn.Utilities;

namespace MetaDslx.CodeAnalysis.Syntax
{
    public abstract class BranchingDirective : Directive
    {
        public BranchingDirective(SyntaxNodeOrToken syntax, bool isActive) 
            : base(syntax, isActive)
        {
        }
    }

    public abstract class ConditionalDirective : BranchingDirective
    {
        public ConditionalDirective(SyntaxNodeOrToken syntax, bool isActive)
            : base(syntax, isActive)
        {
        }

        public abstract SyntaxNodeOrToken Condition { get; }
        public abstract bool ConditionValue { get; }
    }

    public class IfDirective : ConditionalDirective
    {
        private readonly SyntaxNodeOrToken _condition;
        private readonly bool _branchTaken;
        private readonly bool _conditionValue;

        public IfDirective(SyntaxNodeOrToken syntax, SyntaxNodeOrToken condition, bool isActive, bool branchTaken, bool conditionValue)
            : base(syntax, isActive)
        {
            _condition = condition;
            _branchTaken = branchTaken;
            _conditionValue = conditionValue;
        }

        public override SyntaxNodeOrToken Condition => _condition;

        public override bool BranchTaken => _branchTaken;

        public override bool ConditionValue => _conditionValue;

        public override DirectiveKind Kind => DirectiveKind.If;

        public override bool HasRelatedDirectives => true;
    }

    public class ElifDirective : ConditionalDirective
    {
        private readonly SyntaxNodeOrToken _condition;
        private readonly bool _branchTaken;
        private readonly bool _conditionValue;

        public ElifDirective(SyntaxNodeOrToken syntax, SyntaxNodeOrToken condition, bool isActive, bool branchTaken, bool conditionValue)
            : base(syntax, isActive)
        {
            _condition = condition;
            _branchTaken = branchTaken;
            _conditionValue = conditionValue;
        }

        public override SyntaxNodeOrToken Condition => _condition;

        public override bool BranchTaken => _branchTaken;

        public override bool ConditionValue => _conditionValue;

        public override DirectiveKind Kind => DirectiveKind.Elif;

        public override bool HasRelatedDirectives => true;
    }

    public class ElseDirective : BranchingDirective
    {
        private readonly bool _branchTaken;

        public ElseDirective(SyntaxNodeOrToken syntax, bool isActive, bool branchTaken)
            : base(syntax, isActive)
        {
            _branchTaken = branchTaken;
        }

        public override DirectiveKind Kind => DirectiveKind.Else;

        public override bool BranchTaken => _branchTaken;

        public override bool HasRelatedDirectives => true;
    }

    public class EndIfDirective : Directive
    {
        public EndIfDirective(SyntaxNodeOrToken syntax, bool isActive)
            : base(syntax, isActive)
        {
        }

        public override DirectiveKind Kind => DirectiveKind.EndIf;

        public override bool HasRelatedDirectives => true;
    }

    public class RegionDirective : Directive
    {
        public RegionDirective(SyntaxNodeOrToken syntax, bool isActive)
            : base(syntax, isActive)
        {
        }

        public override DirectiveKind Kind => DirectiveKind.Region;

        public override bool HasRelatedDirectives => true;
    }

    public class EndRegionDirective : Directive
    {
        public EndRegionDirective(SyntaxNodeOrToken syntax, bool isActive)
            : base(syntax, isActive)
        {
        }

        public override DirectiveKind Kind => DirectiveKind.EndRegion;

        public override bool HasRelatedDirectives => true;
    }
    public class DefineDirective : Directive
    {
        private readonly string _name;

        public DefineDirective(SyntaxNodeOrToken syntax, bool isActive, string name)
            : base(syntax, isActive)
        {
            _name = name;
        }

        public override DirectiveKind Kind => DirectiveKind.Define;

        public string Name => _name;

        public override string GetIdentifier()
        {
            return _name;
        }
    }

    public class UndefDirective : Directive
    {
        private readonly string _name;

        public UndefDirective(SyntaxNodeOrToken syntax, bool isActive, string name)
            : base(syntax, isActive)
        {
            _name = name;
        }

        public override DirectiveKind Kind => DirectiveKind.Undef;

        public string Name => _name;

        public override string GetIdentifier()
        {
            return _name;
        }
    }

    public class ReferenceDirective : Directive
    {
        private readonly string _file;

        public ReferenceDirective(SyntaxNodeOrToken syntax, bool isActive, string file)
            : base(syntax, isActive)
        {
            _file = file;
        }

        public override DirectiveKind Kind => DirectiveKind.Reference;

        public string File => _file;
    }

    public class LoadDirective : Directive
    {
        private readonly string _file;

        public LoadDirective(SyntaxNodeOrToken syntax, bool isActive, string file)
            : base(syntax, isActive)
        {
            _file = file;
        }

        public override DirectiveKind Kind => DirectiveKind.Load;

        public string File => _file;
    }

    public class ExternAliasDirective : Directive
    {
        private SyntaxNodeOrToken _aliasName;

        public ExternAliasDirective(SyntaxNodeOrToken syntax, SyntaxNodeOrToken aliasName)
            : base(syntax, true)
        {
            _aliasName = aliasName;
        }

        public override DirectiveKind Kind => DirectiveKind.ExternAlias;

        public SyntaxNodeOrToken AliasName => _aliasName;
    }

    public class UsingDirective : Directive
    {
        private SyntaxNodeOrToken _aliasName;
        private SyntaxNodeOrToken _targetName;
        private ImmutableArray<SyntaxNodeOrToken> _targetQualifiedName;
        private bool _isStatic;
        private bool _isGlobal;

        public UsingDirective(SyntaxNodeOrToken syntax, SyntaxNodeOrToken aliasName, SyntaxNodeOrToken targetName, ImmutableArray<SyntaxNodeOrToken> targetQualifiedName, bool isStatic, bool isGlobal)
            : base(syntax, true)
        {
            _aliasName = aliasName;
            _targetName = targetName;
            _targetQualifiedName = targetQualifiedName;
            _isStatic = isStatic;
            _isGlobal = isGlobal;
        }

        public override DirectiveKind Kind => DirectiveKind.Using;
        public SyntaxNodeOrToken AliasName => _aliasName;
        public SyntaxNodeOrToken TargetName => _targetName;
        public ImmutableArray<SyntaxNodeOrToken> TargetQualifiedName => _targetQualifiedName;
        public bool IsStatic => _isStatic;
        public bool IsGlobal => _isGlobal;
    }

    public enum LineDirectiveKind
    {
        Default,
        Hidden,
        Number
    }

    public class LineDirective : Directive
    {
        private readonly LineDirectiveKind _kind;
        private readonly int _line;
        private readonly string? _file;

        public LineDirective(SyntaxNodeOrToken syntax, bool isActive, int line, string? file = null)
            : base(syntax, isActive)
        {
            _kind = LineDirectiveKind.Number;
            _line = line;
            _file = file;
        }

        public LineDirective(SyntaxNodeOrToken syntax, bool isActive, LineDirectiveKind kind)
            : base(syntax, isActive)
        {
            _kind = kind;
            _line = 0;
            _file = null;
        }

        public override DirectiveKind Kind => DirectiveKind.Line;

        public LineDirectiveKind LineKind => _kind;
        public string? File => _file;
        public int Line => _line;
    }

    public enum PragmaWarningKind
    {
        Warning,
        Nullable
    }

    internal class PragmaWarningDirective : Directive
    {
        private readonly PragmaWarningState _state;
        private readonly PragmaWarningKind _kind;
        private readonly ImmutableArray<string> _errorIds;

        public PragmaWarningDirective(SyntaxNodeOrToken syntax, bool isActive, PragmaWarningState state, PragmaWarningKind kind, ImmutableArray<string> errorIds)
            : base(syntax, isActive)
        {
            _state = state;
            _kind = kind;
            _errorIds = errorIds;
        }

        public override DirectiveKind Kind => DirectiveKind.PragmaWarning;
        public PragmaWarningKind PragmaWarningKind => _kind;
        public PragmaWarningState State => _state;
        public ImmutableArray<string> ErrorIds => _errorIds;
    }

    internal class NullableDirective : Directive
    {
        private readonly PragmaWarningState _state;

        public NullableDirective(SyntaxNodeOrToken syntax, bool isActive, PragmaWarningState state)
            : base(syntax, isActive)
        {
            _state = state;
        }

        public override DirectiveKind Kind => DirectiveKind.Line;
        public PragmaWarningState State => _state;
    }
}
