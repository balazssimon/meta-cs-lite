using Roslyn.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis
{
    public class CompilationOptions
    {
        public static readonly CompilationOptions Default = new CompilationOptions();

        private readonly bool _referencesSupersedeLowerVersions;

        public CompilationOptions(bool referencesSupersedeLowerVersions = true)
        {
            _referencesSupersedeLowerVersions = referencesSupersedeLowerVersions;
        }

        /// <summary>
        /// Apply additional disambiguation rules during resolution of referenced assemblies.
        /// </summary>
        public bool ReferencesSupersedeLowerVersions => _referencesSupersedeLowerVersions;

        public CompilationOptions WithReferencesSupersedeLowerVersions(bool referencesSupersedeLowerVersions)
        {
            if (_referencesSupersedeLowerVersions != referencesSupersedeLowerVersions) return Update(referencesSupersedeLowerVersions);
            else return this;
        }

        protected virtual CompilationOptions Update(bool referencesSupersedeLowerVersions)
        {
            return new CompilationOptions(referencesSupersedeLowerVersions);
        }

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
