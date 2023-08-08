using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis
{
    public static class ErrorCode
    {
        public const string CompilerCategory = "Compiler";

        /// <summary>
        /// Syntax error: {0}
        /// </summary>
        public static readonly DiagnosticDescriptor ERR_SyntaxError = DiagnosticDescriptor.Error(nameof(ERR_SyntaxError), "Syntax error", "{0}");

        /// <summary>
        /// Syntax warning: {0}
        /// </summary>
        public static readonly DiagnosticDescriptor WRN_SyntaxWarning = DiagnosticDescriptor.Warning(nameof(WRN_SyntaxWarning), "Syntax warning", "{0}");

        /// <summary>
        /// Code generation error: {0}
        /// </summary>
        public static readonly DiagnosticDescriptor ERR_CodeGenerationError = DiagnosticDescriptor.Error(nameof(ERR_CodeGenerationError), "Code generation error", "{0}");

        /// <summary>
        /// Could not read file '{0}' -- {1}
        /// </summary>
        public static readonly DiagnosticDescriptor ERR_FileReadError = DiagnosticDescriptor.Error(nameof(ERR_FileReadError), "File read error", "Could not read file '{0}' -- {1}");

        /// <summary>
        /// Unrecognized escape sequence
        /// </summary>
        public static readonly DiagnosticDescriptor ERR_IllegalEscape = DiagnosticDescriptor.Error(nameof(ERR_IllegalEscape), "Illegal escape", "Unrecognized escape sequence");
    }
}
