using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.Languages.MetaCompiler.Annotations
{
    [AnnotationUsage(AnnotationTargets.All)]
    public class UseAnnotation : Annotation
    {
        private readonly ImmutableArray<Type> _types;

        public UseAnnotation(ImmutableArray<Type> types)
        {
            _types = types;
        }

        public ImmutableArray<Type> Types => _types;
        public List<Type> TypesList { get; }
    }
}
