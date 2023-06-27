using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis.Annotations
{
    [AnnotationUsage(AnnotationTargets.All)]
    [DeclarationTable]
    public class NestingAnnotation : Annotation
    {
        private readonly Type? _type;
        private readonly string? _property;

        public NestingAnnotation(Type type, string property)
        {
            _type = type;
            _property = property;
        }

        public Type? Type => _type;
        public string? Property => _property;
    }
}
