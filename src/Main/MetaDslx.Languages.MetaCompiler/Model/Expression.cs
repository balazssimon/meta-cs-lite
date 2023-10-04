using MetaDslx.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.Languages.MetaCompiler.Model
{
    public class Expression
    {
        public Location Location { get; set; }
        public string ValueText { get; set; }
        public object Value { get; set; }
        public ImmutableArray<string> Qualifier { get; set; }
        public Type Type { get; set; }
        public CSharpTypeInfo CSharpType { get; set; }
    }
}
