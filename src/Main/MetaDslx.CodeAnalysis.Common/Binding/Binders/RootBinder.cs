using MetaDslx.CodeAnalysis.Declarations;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.CodeAnalysis.Binding
{
    public class RootBinder : Binder, IValueBinder
    {
        private readonly Type? _type;

        public RootBinder(Type? type = null)
        {
            _type = type;
        }

        public Type? Type => _type;

        public virtual RootSingleDeclaration BuildDeclarationTree()
        {
            var builder = new SingleDeclarationBuilder(this.Syntax, this.Type);
            builder.AddChildren(this.BuildDeclarationTree(builder));
            return (RootSingleDeclaration)builder.ToImmutableAndFree(root: true)[0];
        }

    }
}
