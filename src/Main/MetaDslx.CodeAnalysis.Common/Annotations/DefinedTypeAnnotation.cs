using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis.Annotations
{
    [AnnotationUsage(AnnotationTargets.All)]
    [DeclarationTable]
    public class DefinedTypeAnnotation : Annotation
    {
        private readonly Type _modelObjectType;

        public DefinedTypeAnnotation(Type modelObjectType)
        {
            _modelObjectType = modelObjectType;
        }

        public Type ModelObjectType => _modelObjectType;
    }
}
