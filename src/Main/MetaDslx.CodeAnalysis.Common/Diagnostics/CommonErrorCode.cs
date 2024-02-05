using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis
{
    public static class CommonErrorCode
    {
        public const string CompilerCategory = "Compiler";

        /// <summary>
        /// Unused symbols: {0}
        /// </summary>
        public static readonly DiagnosticDescriptor HDN_UnusedSymbols = DiagnosticDescriptor.Hidden(nameof(HDN_UnusedSymbols), "Unused symbols", "Unused symbols: {0}");

        /// <summary>
        /// Unused namespaces: {0}
        /// </summary>
        public static readonly DiagnosticDescriptor HDN_UnusedNamespaces = DiagnosticDescriptor.Hidden(nameof(HDN_UnusedNamespaces), "Unused namespaces", "Unused namespaces: {0}");

        /// <summary>
        /// The following meta types are not used from the imported meta model '{0}': {1}
        /// </summary>
        public static readonly DiagnosticDescriptor WRN_UnusedMetaTypes = DiagnosticDescriptor.Warning(nameof(WRN_UnusedMetaTypes), "Unused meta types", "The following meta types are not used from the imported meta model '{0}': {1}");

        /// <summary>
        /// Properties '{0}' and '{1}' are not mutually opposite of each other
        /// </summary>
        public static readonly DiagnosticDescriptor WRN_NonMutualOpposite = DiagnosticDescriptor.Warning(nameof(WRN_NonMutualOpposite), "Opposite mismatch", "Properties '{0}' and '{1}' are not mutually opposite of each other");

        /// <summary>
        /// Provided source code kind is unsupported or invalid: '{0}'
        /// </summary>
        public static readonly DiagnosticDescriptor ERR_BadSourceCodeKind = DiagnosticDescriptor.Error(nameof(ERR_BadSourceCodeKind), "Bad source code kind", "Provided source code kind is unsupported or invalid: '{0}'");

        /// <summary>
        /// Provided documentation mode is unsupported or invalid: '{0}'
        /// </summary>
        public static readonly DiagnosticDescriptor ERR_BadDocumentationMode = DiagnosticDescriptor.Error(nameof(ERR_BadDocumentationMode), "Bad documentation mode", "Provided documentation mode is unsupported or invalid: '{0}'");

        /// <summary>
        /// Source file references are not supported.
        /// </summary>
        public static readonly DiagnosticDescriptor ERR_SourceFileReferencesNotSupported = DiagnosticDescriptor.Error(nameof(ERR_SourceFileReferencesNotSupported), "Source file references not supported", "Source file references are not supported.");

        /// <summary>
        /// Source file '{0}' could not be opened -- {1}
        /// </summary>
        public static readonly DiagnosticDescriptor ERR_NoSourceFile = DiagnosticDescriptor.Error(nameof(ERR_NoSourceFile), "No source file", "Source file '{0}' could not be opened -- {1}");

        /// <summary>
        /// Provided language version is unsupported or invalid: '{0}'.
        /// </summary>
        public static readonly DiagnosticDescriptor ERR_BadLanguageVersion = DiagnosticDescriptor.Error(nameof(ERR_BadLanguageVersion), "Bad language version", "Provided language version is unsupported or invalid: '{0}'.");

        /// <summary>
        /// Invalid name for a preprocessing symbol; '{0}' is not a valid identifier
        /// </summary>
        public static readonly DiagnosticDescriptor ERR_InvalidPreprocessingSymbol = DiagnosticDescriptor.Error(nameof(ERR_InvalidPreprocessingSymbol), "Invalid preprocessing symbol", "Invalid name for a preprocessing symbol; '{0}' is not a valid identifier");

        /// <summary>
        /// Feature '{0}' is not available in {1} {2}. Please use language version {3} or greater.
        /// </summary>
        public static readonly DiagnosticDescriptor ERR_FeatureNotAvailableInVersion = DiagnosticDescriptor.Error(nameof(ERR_FeatureNotAvailableInVersion), "Feature not available in version", "Feature '{0}' is not available in {1} {2}. Please use language version {3} or greater.");

        /// <summary>
        /// {0}
        /// </summary>
        public static readonly DiagnosticDescriptor ERR_DeclarationError = DiagnosticDescriptor.Error(nameof(ERR_DeclarationError), "Declaration error", "{0}");

        /// <summary>
        /// '{0}' is a type not supported by the language
        /// </summary>
        public static readonly DiagnosticDescriptor ERR_BogusType = DiagnosticDescriptor.Error(nameof(ERR_BogusType), "Bogus type", "'{0}' is a type not supported by the language");

        /// <summary>
        /// '{0}' is not supported by the language
        /// </summary>
        public static readonly DiagnosticDescriptor ERR_BindToBogus = DiagnosticDescriptor.Error(nameof(ERR_BindToBogus), "Bind to bogus", "'{0}' is not supported by the language");

        /// <summary>
        /// {0}
        /// </summary>
        public static readonly DiagnosticDescriptor ERR_BindingError = DiagnosticDescriptor.Error(nameof(ERR_BindingError), "Binding error", "{0}");

        /// <summary>
        /// '{0}' is a {1} but is used like a {2}
        /// </summary>
        public static readonly DiagnosticDescriptor ERR_BadSymbolKindKnown = DiagnosticDescriptor.Error(nameof(ERR_BadSymbolKindKnown), "Bad symbol", "'{0}' is a {1} but is used like a {2}");

        /// <summary>
        /// '{0}' is a {1}, which is not valid in the given context
        /// </summary>
        public static readonly DiagnosticDescriptor ERR_BadSymbolKindUnknown = DiagnosticDescriptor.Error(nameof(ERR_BadSymbolKindUnknown), "Bad symbol", "'{0}' is a {1}, which is not valid in the given context");

        /// <summary>
        /// '{0}' is a {1} but is used like a {2}
        /// </summary>
        public static readonly DiagnosticDescriptor ERR_BadModelObjectTypeKnown = DiagnosticDescriptor.Error(nameof(ERR_BadModelObjectTypeKnown), "Bad model object", "'{0}' is a {1} but is used like a {2}");

        /// <summary>
        /// '{0}' is a {1}, which is not valid in the given context
        /// </summary>
        public static readonly DiagnosticDescriptor ERR_BadModelObjectTypeUnknown = DiagnosticDescriptor.Error(nameof(ERR_BadModelObjectTypeUnknown), "Bad model object", "'{0}' is a {1}, which is not valid in the given context");

        /// <summary>
        /// Non-invocable member '{0}' cannot be used like a method.
        /// </summary>
        public static readonly DiagnosticDescriptor ERR_NonInvocableMemberCalled = DiagnosticDescriptor.Error(nameof(ERR_NonInvocableMemberCalled), "Not invocable", "Non-invocable member '{0}' cannot be used like a method.");

        /// <summary>
        /// The {1} in '{0}' conflicts with the imported {3} in '{2}'. Using the symbol defined in '{0}'.
        /// </summary>
        public static readonly DiagnosticDescriptor WRN_SameFullNameThisAggAgg = DiagnosticDescriptor.Warning(nameof(WRN_SameFullNameThisAggAgg), "Name conflict", "The {1} in '{0}' conflicts with the imported {3} in '{2}'. Using the symbol defined in '{0}'.");

        /// <summary>
        /// '{0}' is an ambiguous reference between {1} and {2}
        /// </summary>
        public static readonly DiagnosticDescriptor ERR_AmbigContext = DiagnosticDescriptor.Error(nameof(ERR_AmbigContext), "Name conflict", "'{0}' is an ambiguous reference between {1} and {2}");

        /// <summary>
        /// '{0}' has an ambiguous value between {1} and {2}
        /// </summary>
        public static readonly DiagnosticDescriptor ERR_AmbigValue = DiagnosticDescriptor.Error(nameof(ERR_AmbigValue), "Value conflict", "'{0}' has an ambiguous value between {1} and {2}");

        /// <summary>
        /// The name '{0}' does not exist in {1}
        /// </summary>
        public static readonly DiagnosticDescriptor ERR_DottedNameNotFoundInAgg = DiagnosticDescriptor.Error(nameof(ERR_DottedNameNotFoundInAgg), "Name not found", "The name '{0}' does not exist in {1}");

        /// <summary>
        /// The name '{0}' could not be found in the global namespace (are you missing an assembly reference?)
        /// </summary>
        public static readonly DiagnosticDescriptor ERR_GlobalSingleNameNotFound = DiagnosticDescriptor.Error(nameof(ERR_GlobalSingleNameNotFound), "Name not found", "The name '{0}' could not be found in the global namespace (are you missing an assembly reference?)");

        /// <summary>
        /// The name '{0}' does not exist in the namespace '{1}' (are you missing an assembly reference?)
        /// </summary>
        public static readonly DiagnosticDescriptor ERR_DottedNameNotFoundInNS = DiagnosticDescriptor.Error(nameof(ERR_DottedNameNotFoundInNS), "Name not found", "The name '{0}' does not exist in the namespace '{1}' (are you missing an assembly reference?)");

        /// <summary>
        /// The name '{0}' could not be found (are you missing a using directive or an assembly reference?)
        /// </summary>
        public static readonly DiagnosticDescriptor ERR_SingleNameNotFound = DiagnosticDescriptor.Error(nameof(ERR_SingleNameNotFound), "Name not found", "The name '{0}' could not be found (are you missing a using directive or an assembly reference?)");

        /// <summary>
        /// Value '{0}' of type '{1}' cannot be assigned to symbol property '{2}:{3}'
        /// </summary>
        public static readonly DiagnosticDescriptor ERR_InvalidSymbolPrimitivePropertyValue = DiagnosticDescriptor.Error(nameof(ERR_InvalidSymbolPrimitivePropertyValue), "Invalid value", "Value '{0}' of type '{1}' cannot be assigned to symbol property '{2}:{3}'");

        /// <summary>
        /// {0} of type '{1}' cannot be assigned to symbol property '{2}:{3}'
        /// </summary>
        public static readonly DiagnosticDescriptor ERR_InvalidSymbolPropertyValue = DiagnosticDescriptor.Error(nameof(ERR_InvalidSymbolPropertyValue), "Invalid value", "{0} of type '{1}' cannot be assigned to symbol property '{2}:{3}'");

        /// <summary>
        /// Value '{0}' of type '{1}' cannot be assigned to model property '{2}:{3}'
        /// </summary>
        public static readonly DiagnosticDescriptor ERR_InvalidModelObjectPrimitivePropertyValue = DiagnosticDescriptor.Error(nameof(ERR_InvalidModelObjectPrimitivePropertyValue), "Invalid value", "Value '{0}' of type '{1}' cannot be assigned to model property '{2}:{3}'");

        /// <summary>
        /// {0} of type '{1}' cannot be assigned to model property '{2}:{3}'
        /// </summary>
        public static readonly DiagnosticDescriptor ERR_InvalidModelObjectPropertyValue = DiagnosticDescriptor.Error(nameof(ERR_InvalidModelObjectPropertyValue), "Invalid value", "{0} of type '{1}' cannot be assigned to model property '{2}:{3}'");

        /// <summary>
        /// File imports are disabled. To enable file imports set CompilationOptions.MergeGlobalNamespace to false.
        /// </summary>
        public static readonly DiagnosticDescriptor ERR_FileImportsDisabled = DiagnosticDescriptor.Error(nameof(ERR_FileImportsDisabled), "File imports disabled", "File imports are disabled. To enable file imports set CompilationOptions.MergeGlobalNamespace to false.");

        /// <summary>
        /// Imported file '0' ('{1}') could not be found.
        /// </summary>
        public static readonly DiagnosticDescriptor ERR_ImportedFileNotFound = DiagnosticDescriptor.Error(nameof(ERR_ImportedFileNotFound), "Import not found", "Imported file '{0}' ('{1}') could not be found.");
    }
}
