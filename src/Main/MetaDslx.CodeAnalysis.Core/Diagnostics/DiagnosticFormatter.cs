﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Globalization;
using MetaDslx.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace MetaDslx.CodeAnalysis
{
    /// <summary>
    /// Formats <see cref="Diagnostic"/> messages.
    /// </summary>
    public class DiagnosticFormatter
    {
        public static readonly DiagnosticFormatter Default = new DiagnosticFormatter();
        public static readonly DiagnosticFormatter MSBuild = new MSBuildDiagnosticFormatter();

        /// <summary>
        /// Formats the <see cref="Diagnostic"/> message using the optional <see cref="IFormatProvider"/>.
        /// </summary>
        /// <param name="diagnostic">The diagnostic.</param>
        /// <param name="formatter">The formatter; or null to use the default formatter.</param>
        /// <returns>The formatted message.</returns>
        public virtual string Format(Diagnostic diagnostic, IFormatProvider? formatter = null)
        {
            if (diagnostic == null)
            {
                throw new ArgumentNullException(nameof(diagnostic));
            }

            var culture = formatter as CultureInfo;

            switch (diagnostic.Location.Kind)
            {
                case LocationKind.SourceFile:
                case LocationKind.ExternalFile:
                    var span = diagnostic.Location.GetLineSpan();
                    var mappedSpan = diagnostic.Location.GetMappedLineSpan();
                    if (!span.IsValid || !mappedSpan.IsValid)
                    {
                        goto default;
                    }

                    string? path, basePath;
                    if (mappedSpan.HasMappedPath)
                    {
                        path = mappedSpan.Path;
                        basePath = span.Path;
                    }
                    else
                    {
                        path = span.Path;
                        basePath = null;
                    }

                    return string.Format(formatter, "{0}{1}: {2}: {3}",
                                         FormatSourcePath(path, basePath, formatter),
                                         FormatSourceSpan(mappedSpan.Span, formatter),
                                         FormatMessagePrefix(diagnostic),
                                         diagnostic.GetMessage(culture));

                default:
                    return string.Format(formatter, "{0}: {1}",
                                         FormatMessagePrefix(diagnostic),
                                         diagnostic.GetMessage(culture));
            }
        }

        internal protected virtual string FormatSourcePath(string path, string? basePath, IFormatProvider? formatter)
        {
            // ignore base path
            return path;
        }

        internal protected virtual string FormatSourceSpan(LinePositionSpan span, IFormatProvider? formatter)
        {
            return string.Format("({0},{1})", span.Start.Line + 1, span.Start.Character + 1);
        }

        internal protected virtual string FormatMessagePrefix(Diagnostic diagnostic)
        {
            string prefix;
            switch (diagnostic.Severity)
            {
                case DiagnosticSeverity.Hidden:
                    prefix = "hidden";
                    break;
                case DiagnosticSeverity.Info:
                    prefix = "info";
                    break;
                case DiagnosticSeverity.Warning:
                    prefix = "warning";
                    break;
                case DiagnosticSeverity.Error:
                    prefix = "error";
                    break;
                default:
                    throw ExceptionUtilities.UnexpectedValue(diagnostic.Severity);
            }
            return prefix;
        }

    }
}
