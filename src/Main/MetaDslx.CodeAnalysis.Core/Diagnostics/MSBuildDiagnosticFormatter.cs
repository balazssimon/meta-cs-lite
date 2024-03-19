using MetaDslx.CodeAnalysis.Text;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MetaDslx.CodeAnalysis
{
    internal class MSBuildDiagnosticFormatter : DiagnosticFormatter
    {
        internal protected override string FormatSourcePath(string path, string? basePath, IFormatProvider? formatter)
        {
            return path;
            //return Path.GetFileName(path);
        }

        internal protected override string FormatSourceSpan(LinePositionSpan span, IFormatProvider? formatter)
        {
            return string.Format("({0},{1},{2},{3})", span.Start.Line + 1, span.Start.Character + 1, span.End.Line + 1, span.End.Character + 1);
        }

        internal protected override string FormatMessagePrefix(Diagnostic diagnostic)
        {
            var prefix = base.FormatMessagePrefix(diagnostic);
            return string.Format("{0} {1}", prefix, diagnostic.Id);
        }
    }
}
