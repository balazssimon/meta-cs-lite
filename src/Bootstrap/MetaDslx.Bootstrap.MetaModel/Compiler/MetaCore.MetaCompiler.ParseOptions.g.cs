using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Syntax;
using MetaDslx.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

#nullable enable

namespace MetaDslx.Bootstrap.MetaModel.Compiler.Syntax
{
    /// <summary>
    /// This class stores several source parsing related options and offers access to their values.
    /// </summary>
    public sealed class MetaCoreParseOptions : ParseOptions, IEquatable<MetaCoreParseOptions>
    {
        /// <summary>
        /// The default parse options.
        /// </summary>
        public static MetaCoreParseOptions Default { get; } = new MetaCoreParseOptions();

        private ImmutableArray<string> _preprocessorSymbols;
        private ImmutableDictionary<string, string> _features;

        /// <summary>
        /// Gets the effective language version, which the compiler uses to select the
        /// language rules to apply to the program.
        /// </summary>
        public MetaCoreLanguageVersion LanguageVersion { get; private set; }

        /// <summary>
        /// Gets the specified language version, which is the value that was specified in
        /// the call to the constructor, or modified using the <see cref="WithLanguageVersion"/> method,
        /// or provided on the command line.
        /// </summary>
        public MetaCoreLanguageVersion SpecifiedLanguageVersion { get; private set; }

        public override ImmutableArray<string> PreprocessorSymbols => _preprocessorSymbols;

        public MetaCoreParseOptions(
            MetaCoreLanguageVersion languageVersion = MetaCoreLanguageVersion.Default,
            DocumentationMode documentationMode = DocumentationMode.Parse,
            SourceCodeKind kind = SourceCodeKind.Regular,
            IEnumerable<string>? preprocessorSymbols = null)
            : this(languageVersion,
                  documentationMode,
                  kind,
                  preprocessorSymbols.ToImmutableArrayOrEmpty(),
                  ImmutableDictionary<string, string>.Empty)
        {
        }

        internal MetaCoreParseOptions(
            MetaCoreLanguageVersion languageVersion,
            DocumentationMode documentationMode,
            SourceCodeKind kind,
            ImmutableArray<string> preprocessorSymbols,
            IReadOnlyDictionary<string, string>? features)
            : base(kind, documentationMode)
        {
            this.SpecifiedLanguageVersion = languageVersion;
            this.LanguageVersion = languageVersion.MapSpecifiedToEffectiveVersion();
            _preprocessorSymbols = preprocessorSymbols.ToImmutableArrayOrEmpty();
            _features = features?.ToImmutableDictionary() ?? ImmutableDictionary<string, string>.Empty;
        }

        private MetaCoreParseOptions(MetaCoreParseOptions other) : this(
            languageVersion: other.SpecifiedLanguageVersion,
            documentationMode: other.DocumentationMode,
            kind: other.Kind,
            preprocessorSymbols: other.PreprocessorSymbols)
        {
        }

        public override Language Language => MetaCoreLanguage.Instance;

        public new MetaCoreParseOptions WithKind(SourceCodeKind kind)
        {
            if (kind == this.Kind)
            {
                return this;
            }

            return new MetaCoreParseOptions(this) { Kind = kind };
        }

        public MetaCoreParseOptions WithLanguageVersion(MetaCoreLanguageVersion version)
        {
            if (version == this.SpecifiedLanguageVersion)
            {
                return this;
            }

            var effectiveLanguageVersion = version.MapSpecifiedToEffectiveVersion();
            return new MetaCoreParseOptions(this) { SpecifiedLanguageVersion = version, LanguageVersion = effectiveLanguageVersion };
        }

        public MetaCoreParseOptions WithPreprocessorSymbols(IEnumerable<string>? preprocessorSymbols)
        {
            return WithPreprocessorSymbols(preprocessorSymbols.AsImmutableOrNull());
        }

        public MetaCoreParseOptions WithPreprocessorSymbols(params string[]? preprocessorSymbols)
        {
            return WithPreprocessorSymbols(preprocessorSymbols.AsImmutableOrNull());
        }

        public MetaCoreParseOptions WithPreprocessorSymbols(ImmutableArray<string> symbols)
        {
            if (symbols.IsDefault)
            {
                symbols = ImmutableArray<string>.Empty;
            }

            if (symbols.Equals(this.PreprocessorSymbols))
            {
                return this;
            }

            return new MetaCoreParseOptions(this) { _preprocessorSymbols = symbols };
        }

        public new MetaCoreParseOptions WithDocumentationMode(DocumentationMode documentationMode)
        {
            if (documentationMode == this.DocumentationMode)
            {
                return this;
            }

            return new MetaCoreParseOptions(this) { DocumentationMode = documentationMode };
        }

        protected override ParseOptions CommonWithKind(SourceCodeKind kind)
        {
            return WithKind(kind);
        }

        protected override ParseOptions CommonWithDocumentationMode(DocumentationMode documentationMode)
        {
            return WithDocumentationMode(documentationMode);
        }

        protected override bool IsFeatureEnabled(string feature)
        {
            MetaCoreLanguageVersion availableVersion = LanguageVersion;
            MetaCoreLanguageVersion requiredVersion = MetaCoreLanguage.Instance.SyntaxFacts.GetRequiredLanguageVersion(feature);
            return availableVersion >= requiredVersion;
        }

        public override Diagnostic? GetDiagnosticForFeature(string feature)
        {
            MetaCoreLanguageVersion availableVersion = LanguageVersion;
            MetaCoreLanguageVersion requiredVersion = MetaCoreLanguage.Instance.SyntaxFacts.GetRequiredLanguageVersion(feature);
            if (availableVersion < requiredVersion)
            {
                return Diagnostic.Create(CommonErrorCode.ERR_FeatureNotAvailableInVersion, Location.None, feature, Language.Name, availableVersion.ToDisplayString(), requiredVersion.ToDisplayString());
            }
            return null;
        }

        protected override void CommonValidateOptions(ArrayBuilder<Diagnostic> builder)
        {
            // Validate LanguageVersion not SpecifiedLanguageVersion, after Latest/Default has been converted:
            if (!LanguageVersion.IsValid())
            {
                builder.Add(Diagnostic.Create(CommonErrorCode.ERR_BadLanguageVersion, Location.None, LanguageVersion.ToString()));
            }

            if (!PreprocessorSymbols.IsDefaultOrEmpty)
            {
                foreach (var symbol in PreprocessorSymbols)
                {
                    if (symbol == null)
                    {
                        builder.Add(Diagnostic.Create(CommonErrorCode.ERR_InvalidPreprocessingSymbol, Location.None, "null"));
                    }
                    else if (!Language.SyntaxFacts.IsValidIdentifier(symbol))
                    {
                        builder.Add(Diagnostic.Create(CommonErrorCode.ERR_InvalidPreprocessingSymbol, Location.None, symbol));
                    }
                }
            }
        }

        public override bool Equals(object? obj)
        {
            return this.Equals(obj as MetaCoreParseOptions);
        }

        public bool Equals(MetaCoreParseOptions? other)
        {
            if (object.ReferenceEquals(this, other))
            {
                return true;
            }

            if (!base.EqualsHelper(other))
            {
                return false;
            }

            return this.SpecifiedLanguageVersion == other.SpecifiedLanguageVersion;
        }

        public override int GetHashCode()
        {
            return
                Hash.Combine(base.GetHashCodeHelper(),
                Hash.Combine((int)this.SpecifiedLanguageVersion, 0));
        }
    }
}
