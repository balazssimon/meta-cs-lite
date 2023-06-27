using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis.Annotations
{
    [AnnotationUsage(AnnotationTargets.All)]
    [DeclarationTable]
    public class ConstantAnnotation : Annotation
    {
        private readonly object? _value;

        public ConstantAnnotation(object? value)
        {
            _value = value;
        }

        public object? Value => _value;
    }
}
