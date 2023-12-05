using MetaDslx.CodeAnalysis;
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
        /// The expression '{0}' of type '{1}' is not assignable to the expected type '{2}'
        /// </summary>
        public static readonly DiagnosticDescriptor ERR_IncompatibleExpressionType = DiagnosticDescriptor.Error(nameof(ERR_IncompatibleExpressionType), "Incompatible expression type", "The expression '{0}' of type '{1}' is not assignable to the expected type '{2}'");

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

        /// <summary>
        /// Rule '{0}' with return type '{1}' should be assigned to a property
        /// </summary>
        public static readonly DiagnosticDescriptor WRN_RuleWithTypeMissingAssignment = DiagnosticDescriptor.Warning(nameof(WRN_RuleWithTypeMissingAssignment), "Missing assigment for rule with type", "Rule '{0}' with return type '{1}' should be assigned to a property");

        /// <summary>
        /// Block '{0}' without a return type cannot be assigned to a property
        /// </summary>
        public static readonly DiagnosticDescriptor ERR_InvalidBlockAssignment = DiagnosticDescriptor.Error(nameof(ERR_InvalidBlockAssignment), "Invalid block assignment", "Block '{0}' without a return type cannot be assigned to a property");

        /// <summary>
        /// Default reference is ambiguous between '{0}' and '{1}'. Make sure to use the [DefaultReferenceAnnotation] exactly once.
        /// </summary>
        public static readonly DiagnosticDescriptor ERR_AmbiguousDefaultReference = DiagnosticDescriptor.Error(nameof(ERR_AmbiguousDefaultReference), "Ambiguous default reference", "Default reference is ambiguous between '{0}' and '{1}'. Make sure to use the [DefaultReferenceAnnotation] exactly once.");
    }
}
