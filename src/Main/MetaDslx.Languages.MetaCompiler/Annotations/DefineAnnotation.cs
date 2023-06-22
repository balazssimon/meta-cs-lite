using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.Languages.MetaCompiler.Annotations
{
    [AnnotationUsage(AnnotationTargets.All)]
    [DeclarationTable]
    public class DefineAnnotation : Annotation
    {
        private readonly Type? _modelObjectType;

        public DefineAnnotation(Type? modelObjectType = null)
        {
            _modelObjectType = modelObjectType;
        }

        public Type? ModelObjectType => _modelObjectType;
    }
}
