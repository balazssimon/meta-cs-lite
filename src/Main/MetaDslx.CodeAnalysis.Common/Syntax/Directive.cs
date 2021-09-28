using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace MetaDslx.CodeAnalysis.Syntax
{
    [DebuggerDisplay("{GetDebuggerDisplay(), nq}")]
    public abstract class Directive
    {
        private readonly SyntaxNodeOrToken _syntax;
        private readonly bool _isActive;

        protected Directive(SyntaxNodeOrToken syntax, bool isActive)
        {
            //Debug.Assert(node is IDirectiveTriviaSyntax);
            _syntax = syntax;
            _isActive = isActive;
        }

        public abstract DirectiveKind Kind { get; }

        public SyntaxNodeOrToken Syntax => _syntax;

        public SyntaxTree? SyntaxTree => _syntax.SyntaxTree;

        public Location? Location => _syntax.GetLocation();

        public virtual bool IncrementallyEquivalent(Directive other)
        {
            if (this.Kind != other.Kind)
            {
                return false;
            }

            bool isActive = this.IsActive;
            bool otherIsActive = other.IsActive;

            // states of inactive directives don't matter
            if (!isActive && !otherIsActive)
            {
                return true;
            }

            if (isActive != otherIsActive)
            {
                return false;
            }

            switch (this.Kind)
            {
                case DirectiveKind.Define:
                case DirectiveKind.Undef:
                    return this.GetIdentifier() == other.GetIdentifier();
                case DirectiveKind.If:
                case DirectiveKind.Elif:
                case DirectiveKind.Else:
                    return this.BranchTaken == other.BranchTaken;
                default:
                    return true;
            }
        }

        // Can't be private as it's called by DirectiveStack in its GetDebuggerDisplay()
        internal string GetDebuggerDisplay()
        {
            var writer = new System.IO.StringWriter(System.Globalization.CultureInfo.InvariantCulture);
            _syntax.WriteTo(writer);
            return writer.ToString();
        }

        public virtual string? GetIdentifier()
        {
            return null;
        }

        public virtual bool HasRelatedDirectives
        {
            get { return false; }
        }

        public virtual bool IsActive
        {
            get { return _isActive; }
        }

        public virtual bool BranchTaken
        {
            get { return false; }
        }
    }
}
