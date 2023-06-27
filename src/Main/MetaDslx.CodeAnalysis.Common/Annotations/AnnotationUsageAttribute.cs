using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis.Annotations
{
    [AttributeUsage(AttributeTargets.Class)]
    public class AnnotationUsageAttribute : Attribute
    {
        private readonly AnnotationTargets _validOn;

        public AnnotationUsageAttribute(AnnotationTargets validOn)
        {
            _validOn = validOn;
        }

        public AnnotationTargets ValidOn => _validOn;
    }
}
