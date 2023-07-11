using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.Text;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.CodeAnalysis.Binding
{
    public sealed class RootBinder : Binder, IValueBinder
    {
        private readonly Type? _type;

        public RootBinder(Type? type = null)
        {
            _type = type;
        }

        public Type? Type => _type;

        public RootSingleDeclaration BuildDeclarationTree(string? scriptClassName, bool isSubmission)
        {
            var builder = new SingleDeclarationBuilder(this.Syntax, this.Type);
            builder.AddChildren(this.BuildDeclarationTree(builder));
            return (RootSingleDeclaration)builder.ToImmutableAndFree(root: true, rootName: scriptClassName)[0];
        }

        internal override RootBinder? GetRootBinder()
        {
            return this;
        }

        public override Binder GetBinder(SyntaxNodeOrToken syntax)
        {
            var result = base.GetBinder(syntax);
            return result ?? this;
        }

        public override Binder GetEnclosingBinder(TextSpan span)
        {
            var result = base.GetEnclosingBinder(span);
            return result ?? this;
        }
    }
}
