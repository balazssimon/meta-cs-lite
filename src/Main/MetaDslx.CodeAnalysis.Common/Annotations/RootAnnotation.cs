using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis.Annotations
{
    [AnnotationUsage(AnnotationTargets.All)]
    [DeclarationTable]
    public class RootAnnotation : Annotation, IValueAnnotation
    {
        private readonly Type? _type;

        public RootAnnotation(Type? type = null)
        {
            _type = type;
        }

        public Type? Type => _type;
    }
}
