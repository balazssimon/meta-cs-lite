using Roslyn.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.CodeAnalysis
{
    public class CompilationOptions
    {
        public ReportDiagnostic GetEffectiveSeverity(DiagnosticDescriptor descriptor)
        {
            switch (descriptor.DefaultSeverity)
            {
                case DiagnosticSeverity.Hidden:
                    return ReportDiagnostic.Hidden;
                case DiagnosticSeverity.Info:
                    return ReportDiagnostic.Info;
                case DiagnosticSeverity.Warning:
                    return ReportDiagnostic.Warn;
                case DiagnosticSeverity.Error:
                    return ReportDiagnostic.Error;
                default:
                    throw ExceptionUtilities.UnexpectedValue(descriptor.DefaultSeverity);
            }
        }
    }
}
