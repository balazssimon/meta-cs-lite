using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis.Annotations
{
    [AnnotationUsage(AnnotationTargets.LexerRuleName)]
    [DeclarationTable]
    public class IdentifierAnnotation : Annotation
    {
    }
}
