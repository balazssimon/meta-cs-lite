using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.CodeAnalysis
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
    }
}
