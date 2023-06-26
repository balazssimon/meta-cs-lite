using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.Languages.MetaCompiler.Annotations
{
    [AnnotationUsage(AnnotationTargets.All)]
    [DeclarationTable]
    public class DefineNestedAnnotation : Annotation
    {
        private readonly Type? _type;
        private readonly Type? _nestingType;
        private readonly string? _nestingProperty;

        public DefineNestedAnnotation(Type nestingType, string nestingProperty, Type? type = null)
        {
            _nestingType = nestingType;
            _nestingProperty = nestingProperty;
            _type = type;
        }

        public Type? Type => _type;
        public Type? NestingType => _nestingType;
        public string? NestingProperty => _nestingProperty;
    }
}
