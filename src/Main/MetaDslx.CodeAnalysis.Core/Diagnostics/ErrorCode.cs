using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis
{
    public static class ErrorCode
    {
        public const string CompilerCategory = "Compiler";

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
        /// Could not read file '{0}' -- {1}
        /// </summary>
        public static readonly DiagnosticDescriptor ERR_FileReadError = DiagnosticDescriptor.Error(nameof(ERR_FileReadError), "File read error", "Could not read file '{0}' -- {1}");

        /// <summary>
        /// Unrecognized escape sequence
        /// </summary>
        public static readonly DiagnosticDescriptor ERR_IllegalEscape = DiagnosticDescriptor.Error(nameof(ERR_IllegalEscape), "Illegal escape", "Unrecognized escape sequence");

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
        /// Syntax error: {0}
        /// </summary>
        public static readonly DiagnosticDescriptor ERR_SyntaxError = DiagnosticDescriptor.Error(nameof(ERR_SyntaxError), "Syntax error", "{0}");

        /// <summary>
        /// Syntax warning: {0}
        /// </summary>
        public static readonly DiagnosticDescriptor WRN_SyntaxWarning = DiagnosticDescriptor.Warning(nameof(WRN_SyntaxWarning), "Syntax warning", "{0}");

        /// <summary>
        /// Declaration error: {0}
        /// </summary>
        public static readonly DiagnosticDescriptor ERR_DeclarationError = DiagnosticDescriptor.Error(nameof(ERR_DeclarationError), "Declaration error", "{0}");

        /// <summary>
        /// Code generation error: {0}
        /// </summary>
        public static readonly DiagnosticDescriptor ERR_CodeGenerationError = DiagnosticDescriptor.Error(nameof(ERR_CodeGenerationError), "Code generation error", "{0}");

        /// <summary>
        /// XMI error: {0}
        /// </summary>
        public static readonly DiagnosticDescriptor ERR_XmiError = DiagnosticDescriptor.Error(nameof(ERR_XmiError), "XMI error", "{0}");

        /// <summary>
        /// XMI warning: {0}
        /// </summary>
        public static readonly DiagnosticDescriptor WRN_XmiWarning = DiagnosticDescriptor.Warning(nameof(WRN_XmiWarning), "XMI warning", "{0}");

        /// <summary>
        /// '{0}' is a type not supported by the language
        /// </summary>
        public static readonly DiagnosticDescriptor ERR_BogusType = DiagnosticDescriptor.Error(nameof(ERR_BogusType), "Bogus type", "'{0}' is a type not supported by the language");

        /// <summary>
        /// '{0}' is not supported by the language
        /// </summary>
        public static readonly DiagnosticDescriptor ERR_BindToBogus = DiagnosticDescriptor.Error(nameof(ERR_BindToBogus), "Bind to bogus", "'{0}' is not supported by the language");

        /// <summary>
        /// Binding error: {0}
        /// </summary>
        public static readonly DiagnosticDescriptor ERR_BindingError = DiagnosticDescriptor.Error(nameof(ERR_BindingError), "Binding error", "Binding error: {0}");
    }
}
