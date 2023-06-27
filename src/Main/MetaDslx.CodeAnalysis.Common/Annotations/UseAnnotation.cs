using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.CodeAnalysis.Annotations
{
    [AnnotationUsage(AnnotationTargets.All)]
    public class UseAnnotation : Annotation, IValueAnnotation
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
