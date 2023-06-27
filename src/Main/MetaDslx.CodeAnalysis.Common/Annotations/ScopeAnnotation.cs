using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis.Annotations
{
    [AnnotationUsage(AnnotationTargets.All)]
    [DeclarationTable]
    public class ScopeAnnotation : Annotation, IScopeAnnotation
    {
        private bool _local;

        public ScopeAnnotation(bool local = false)
        {
            _local = local;
        }

        public bool IsLocal => _local;
    }
}
