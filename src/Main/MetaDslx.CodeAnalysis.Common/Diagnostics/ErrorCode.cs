using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis
{
    internal static class ErrorCode
    {
        public const string CompilerCategory = "Compiler";

        /// <summary>
        /// Provided source code kind is unsupported or invalid: '{0}'
        /// </summary>
        public static readonly DiagnosticDescriptor ERR_BadSourceCodeKind = DiagnosticDescriptor.CompilerError(nameof(ERR_BadSourceCodeKind), "Bad source code kind", "Provided source code kind is unsupported or invalid: '{0}'");

        /// <summary>
        /// Provided documentation mode is unsupported or invalid: '{0}'
        /// </summary>
        public static readonly DiagnosticDescriptor ERR_BadDocumentationMode = DiagnosticDescriptor.CompilerError(nameof(ERR_BadDocumentationMode), "Bad documentation mode", "Provided documentation mode is unsupported or invalid: '{0}'");

        /// <summary>
        /// Source file references are not supported.
        /// </summary>
        public static readonly DiagnosticDescriptor ERR_SourceFileReferencesNotSupported = DiagnosticDescriptor.CompilerError(nameof(ERR_SourceFileReferencesNotSupported), "Source file references not supported", "Source file references are not supported.");

        /// <summary>
        /// Source file '{0}' could not be opened -- {1}
        /// </summary>
        public static readonly DiagnosticDescriptor ERR_NoSourceFile = DiagnosticDescriptor.CompilerError(nameof(ERR_NoSourceFile), "No source file", "Source file '{0}' could not be opened -- {1}");

        /// <summary>
        /// Could not read file '{0}' -- {1}
        /// </summary>
        public static readonly DiagnosticDescriptor ERR_FileReadError = DiagnosticDescriptor.CompilerError(nameof(ERR_FileReadError), "File read error", "Could not read file '{0}' -- {1}");
    }
}
