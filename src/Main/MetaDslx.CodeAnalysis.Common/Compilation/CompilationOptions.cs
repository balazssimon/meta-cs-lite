using MetaDslx.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.CodeAnalysis
{
    public class CompilationOptions
    {
        public static readonly CompilationOptions Default = new CompilationOptions();

        private readonly Lazy<ImmutableArray<Diagnostic>> _lazyErrors;

        private readonly bool _referencesSupersedeLowerVersions;
        private readonly bool _concurrentBuild;

        public CompilationOptions(bool referencesSupersedeLowerVersions = true,
            bool concurrentBuild = true)
        {
            _referencesSupersedeLowerVersions = referencesSupersedeLowerVersions;
            _concurrentBuild = concurrentBuild;

            _lazyErrors = new Lazy<ImmutableArray<Diagnostic>>(() =>
            {
                var builder = ArrayBuilder<Diagnostic>.GetInstance();
                ValidateOptions(builder);
                return builder.ToImmutableAndFree();
            });
        }

        /// <summary>
        /// Errors collection related to an incompatible set of parse options
        /// </summary>
        public ImmutableArray<Diagnostic> Errors
        {
            get { return _lazyErrors.Value; }
        }

        /// <summary>
        /// Apply additional disambiguation rules during resolution of referenced assemblies.
        /// </summary>
        public bool ReferencesSupersedeLowerVersions => _referencesSupersedeLowerVersions;

        /// <summary>
        /// Specifies whether building compilation may use multiple threads.
        /// </summary>
        public bool ConcurrentBuild => _concurrentBuild;

        public CompilationOptions WithReferencesSupersedeLowerVersions(bool referencesSupersedeLowerVersions)
        {
            if (_referencesSupersedeLowerVersions != referencesSupersedeLowerVersions) return Update(referencesSupersedeLowerVersions, _concurrentBuild);
            else return this;
        }

        public CompilationOptions WithConcurrentBuild(bool concurrentBuild)
        {
            if (_concurrentBuild != concurrentBuild) return Update(_referencesSupersedeLowerVersions, concurrentBuild);
            else return this;
        }

        protected virtual CompilationOptions Update(bool referencesSupersedeLowerVersions, bool concurrentBuild)
        {
            return new CompilationOptions(referencesSupersedeLowerVersions, concurrentBuild);
        }

        /// <summary>
        /// Performs validation of options compatibilities and generates diagnostics if needed
        /// </summary>
        public void ValidateOptions(ArrayBuilder<Diagnostic> builder)
        {
            CommonValidateOptions(builder);
        }

        /// <summary>
        /// Performs validation of options compatibilities and generates diagnostics if needed
        /// </summary>
        protected virtual void CommonValidateOptions(ArrayBuilder<Diagnostic> builder)
        {

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
