using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.Languages.MetaCompiler.Annotations
{
    [AnnotationUsage(AnnotationTargets.All)]
    [DeclarationTable]
    public class ValueAnnotation : Annotation
    {
        private readonly Type? _type;

        public ValueAnnotation(Type? type)
        {
            _type = type;
        }

        public Type? Type => _type;
    }
}
