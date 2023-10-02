using MetaDslx.CodeAnalysis;
using Roslyn.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.Languages.MetaCompiler.Model
{
    public class NamedElement : IElementWithLocation
    {
        public string Name { get; set; }
        public string CSharpName => Name.ToPascalCase();
        public List<Annotation> Annotations { get; } = new List<Annotation>();
        public bool ContainsAnnotations { get; set; }
        public bool ContainsBinders { get; set; }
        public Location Location { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
