using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis.Annotations
{
    [AnnotationUsage(AnnotationTargets.LexerRuleName)]
    [DeclarationTable]
    public class MergeAnnotation : Annotation
    {
        private bool _allow;

        public MergeAnnotation(bool allow = true)
        {
            _allow = allow;
        }

        public bool Allow => _allow;
    }
}
