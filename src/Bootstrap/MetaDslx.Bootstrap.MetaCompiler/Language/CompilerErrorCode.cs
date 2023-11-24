﻿using MetaDslx.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Bootstrap.MetaCompiler
{
    public static class CompilerErrorCode
    {
        /// <summary>
        /// The return type '{0}' of the alternative '{1}' is not assignable to the return type '{2}' of the rule '{3}'
        /// </summary>
        public static readonly DiagnosticDescriptor ERR_IncompatibleAltReturnType = DiagnosticDescriptor.Error(nameof(ERR_IncompatibleAltReturnType), "Incompatible alt return type", "The return type '{0}' of the alternative '{1}' is not assignable to the return type '{2}' of the rule '{3}'");

        /// <summary>
        /// Collection property '{0}' must be assigned using the '+=' operator
        /// </summary>
        public static readonly DiagnosticDescriptor ERR_CollectionPropertyWrongAssignment = DiagnosticDescriptor.Error(nameof(ERR_CollectionPropertyWrongAssignment), "Collection property wrong assignment", "Collection property '{0}' must be assigned using the '+=' operator");

        /// <summary>
        /// Non-collection property '{0}' cannot be assigned using the '+=' operator
        /// </summary>
        public static readonly DiagnosticDescriptor ERR_NonCollectionPropertyWrongAssignment = DiagnosticDescriptor.Error(nameof(ERR_NonCollectionPropertyWrongAssignment), "Non-collection property wrong assignment", "Non-collection property '{0}' cannot be assigned using the '+=' operator");

        /// <summary>
        /// Non-boolean property '{0}' cannot be assigned using the '{1}' operator
        /// </summary>
        public static readonly DiagnosticDescriptor ERR_NonBooleanPropertyWrongAssignment = DiagnosticDescriptor.Error(nameof(ERR_NonBooleanPropertyWrongAssignment), "Non-boolean property wrong assignment", "Non-boolean property '{0}' cannot be assigned using the '{1}' operator");

        /// <summary>
        /// Value of type '{0}' cannot be assigned to the expected type '{1}'
        /// </summary>
        public static readonly DiagnosticDescriptor ERR_ValueTypeMismatch = DiagnosticDescriptor.Error(nameof(ERR_ValueTypeMismatch), "Value type mismatch", "Value of type '{0}' cannot be assigned to the expected type '{1}' [{2}]");

        /// <summary>
        /// Block '{0}' is in a circular reference
        /// </summary>
        public static readonly DiagnosticDescriptor ERR_CircularBlockReference = DiagnosticDescriptor.Error(nameof(ERR_CircularBlockReference), "Circular block reference", "Block '{0}' is in a circular reference");
    }
}