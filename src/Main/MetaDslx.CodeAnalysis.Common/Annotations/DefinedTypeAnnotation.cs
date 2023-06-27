﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis.Annotations
{
    [AnnotationUsage(AnnotationTargets.All)]
    [DeclarationTable]
    public class DefinedTypeAnnotation : Annotation
    {
        private readonly Type _type;

        public DefinedTypeAnnotation(Type type)
        {
            _type = type;
        }

        public Type Type => _type;
    }
}
