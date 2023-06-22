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
        private readonly Type? _nestingModelObjectType;
        private readonly string? _nestingProperty;

        public DefineAnnotation(Type? modelObjectType = null)
        {
            _modelObjectType = modelObjectType;
        }

        public DefineAnnotation(Type nestingModelObjectType, string nestingProperty, Type? modelObjectType = null)
        {
            _nestingModelObjectType = nestingModelObjectType;
            _nestingProperty = nestingProperty;
            _modelObjectType = modelObjectType;
        }

        public Type? ModelObjectType => _modelObjectType;
        public Type? NestingModelObjectType => _nestingModelObjectType;
        public string? NestingProperty => _nestingProperty;
    }
}
