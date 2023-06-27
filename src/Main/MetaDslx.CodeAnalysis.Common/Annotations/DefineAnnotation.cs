using MetaDslx.CodeAnalysis.Syntax.InternalSyntax;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis.Annotations
{
    [AnnotationUsage(AnnotationTargets.All)]
    [DeclarationTable]
    public class DefineAnnotation : Annotation
    {
        private readonly Type? _type;

        public DefineAnnotation(Type? type = null)
        {
            _type = type;
        }
        
        public Type? Type => _type;
    }
}
