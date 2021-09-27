// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.CodeAnalysis
{
    /// <summary>
    /// Describes how severe a diagnostic is.
    /// </summary>
    public enum DiagnosticSeverity
    {
        /// <summary>
        /// Something that is an issue, as determined by some authority,
        /// but is not surfaced through normal means.
        /// There may be different mechanisms that act on these issues.
        /// </summary>
        Hidden = 0,

        /// <summary>
        /// Information that does not indicate a problem (i.e. not prescriptive).
        /// </summary>
        Info = 1,

        /// <summary>
        /// Something suspicious but allowed.
        /// </summary>
        Warning = 2,

        /// <summary>
        /// Something not allowed by the rules of the language or other authority.
        /// </summary>
        Error = 3,
    }

    /// <summary>
    /// Values for ErrorCode/ERRID that are used internally by the compiler but are not exposed.
    /// </summary>
    internal static class InternalDiagnosticDescriptors
    {
        /// <summary>
        /// The code has yet to be determined.
        /// </summary>
        public static readonly DiagnosticDescriptor Unknown = new DiagnosticDescriptor("Unknown", "Unknown", "Unknown", "Unknown", DiagnosticSeverity.Hidden, false);

        /// <summary>
        /// The code was lazily determined and does not need to be reported.
        /// </summary>
        public static readonly DiagnosticDescriptor Void = new DiagnosticDescriptor("Void", "Void", "Void", "Void", DiagnosticSeverity.Hidden, false);
    }
}
