// !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
// WARNING: This is an auto-generated file. Any manual changes will be lost when the file is regenerated.
// !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Syntax;
using MetaDslx.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace MetaDslx.Bootstrap.Antlr4.Sandy.Syntax
{
    /// <summary>
    /// This class stores several source parsing related options and offers access to their values.
    /// </summary>
    public sealed class SandyParseOptions : ParseOptions, IEquatable<SandyParseOptions>
    {
        /// <summary>
        /// The default parse options.
        /// </summary>
        public static SandyParseOptions Default { get; } = new SandyParseOptions();

        private ImmutableArray<string> _preprocessorSymbols;
        private ImmutableDictionary<string, string> _features;

        /// <summary>
        /// Gets the effective language version, which the compiler uses to select the
        /// language rules to apply to the program.
        /// </summary>
        public SandyLanguageVersion LanguageVersion { get; private set; }

        /// <summary>
        /// Gets the specified language version, which is the value that was specified in
        /// the call to the constructor, or modified using the <see cref="WithLanguageVersion"/> method,
        /// or provided on the command line.
        /// </summary>
        public SandyLanguageVersion SpecifiedLanguageVersion { get; private set; }

        public override ImmutableArray<string> PreprocessorSymbols => _preprocessorSymbols;

        public SandyParseOptions(
            SandyLanguageVersion languageVersion = SandyLanguageVersion.Default,
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

        internal SandyParseOptions(
            SandyLanguageVersion languageVersion,
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

        private SandyParseOptions(SandyParseOptions other) : this(
            languageVersion: other.SpecifiedLanguageVersion,
            documentationMode: other.DocumentationMode,
            kind: other.Kind,
            preprocessorSymbols: other.PreprocessorSymbols)
        {
        }

        public override SandyLanguage Language => SandyLanguage.Instance;

        public new SandyParseOptions WithKind(SourceCodeKind kind)
        {
            if (kind == this.Kind)
            {
                return this;
            }

            return new SandyParseOptions(this) { Kind = kind };
        }

        public SandyParseOptions WithLanguageVersion(SandyLanguageVersion version)
        {
            if (version == this.SpecifiedLanguageVersion)
            {
                return this;
            }

            var effectiveLanguageVersion = version.MapSpecifiedToEffectiveVersion();
            return new SandyParseOptions(this) { SpecifiedLanguageVersion = version, LanguageVersion = effectiveLanguageVersion };
        }

        public SandyParseOptions WithPreprocessorSymbols(IEnumerable<string>? preprocessorSymbols)
        {
            return WithPreprocessorSymbols(preprocessorSymbols.AsImmutableOrNull());
        }

        public SandyParseOptions WithPreprocessorSymbols(params string[]? preprocessorSymbols)
        {
            return WithPreprocessorSymbols(preprocessorSymbols.AsImmutableOrNull());
        }

        public SandyParseOptions WithPreprocessorSymbols(ImmutableArray<string> symbols)
        {
            if (symbols.IsDefault)
            {
                symbols = ImmutableArray<string>.Empty;
            }

            if (symbols.Equals(this.PreprocessorSymbols))
            {
                return this;
            }

            return new SandyParseOptions(this) { _preprocessorSymbols = symbols };
        }

        public new SandyParseOptions WithDocumentationMode(DocumentationMode documentationMode)
        {
            if (documentationMode == this.DocumentationMode)
            {
                return this;
            }

            return new SandyParseOptions(this) { DocumentationMode = documentationMode };
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
            SandyLanguageVersion availableVersion = LanguageVersion;
            SandyLanguageVersion requiredVersion = Language.SyntaxFacts.GetRequiredLanguageVersion(feature);
            return availableVersion >= requiredVersion;
        }

        public override Diagnostic? GetDiagnosticForFeature(string feature)
        {
            SandyLanguageVersion availableVersion = LanguageVersion;
            SandyLanguageVersion requiredVersion = Language.SyntaxFacts.GetRequiredLanguageVersion(feature);
            if (availableVersion < requiredVersion)
            {
                return Diagnostic.Create(ErrorCode.ERR_FeatureNotAvailableInVersion, Location.None, feature, Language.Name, availableVersion.ToDisplayString(), requiredVersion.ToDisplayString());
            }
            return null;
        }

        protected override void CommonValidateOptions(ArrayBuilder<Diagnostic> builder)
        {
            // Validate LanguageVersion not SpecifiedLanguageVersion, after Latest/Default has been converted:
            if (!LanguageVersion.IsValid())
            {
                builder.Add(Diagnostic.Create(ErrorCode.ERR_BadLanguageVersion, Location.None, LanguageVersion.ToString()));
            }

            if (!PreprocessorSymbols.IsDefaultOrEmpty)
            {
                foreach (var symbol in PreprocessorSymbols)
                {
                    if (symbol == null)
                    {
                        builder.Add(Diagnostic.Create(ErrorCode.ERR_InvalidPreprocessingSymbol, Location.None, "null"));
                    }
                    else if (!Language.SyntaxFacts.IsValidIdentifier(symbol))
                    {
                        builder.Add(Diagnostic.Create(ErrorCode.ERR_InvalidPreprocessingSymbol, Location.None, symbol));
                    }
                }
            }
        }

        public override bool Equals(object? obj)
        {
            return this.Equals(obj as SandyParseOptions);
        }

        public bool Equals(SandyParseOptions? other)
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

