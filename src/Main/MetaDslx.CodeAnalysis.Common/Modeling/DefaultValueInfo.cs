using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Symbols;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace MetaDslx.Modeling
{
    internal class DefaultValueInfo : ValueInfo
    {
        private static readonly ConditionalWeakTable<object, object> s_tags = new ConditionalWeakTable<object, object>();

        public DefaultValueInfo(object value) 
            : base(value)
        {
        }

        public override CodeAnalysis.Location? Location { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override SourceLocation? SourceLocation { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override Symbol? Symbol { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override CodeAnalysis.SyntaxReference? Syntax { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override ISymbol? CSharpSymbol { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override object? Tag
        {
            get
            {
                if (s_tags.TryGetValue(Value, out var tag)) return tag;
                else return null;
            }
            set
            {
                if (s_tags.TryGetValue(Value, out var _)) s_tags.Remove(Value);
                if (value is not null) s_tags.Add(Value, value);
            }
        }
    }
}
