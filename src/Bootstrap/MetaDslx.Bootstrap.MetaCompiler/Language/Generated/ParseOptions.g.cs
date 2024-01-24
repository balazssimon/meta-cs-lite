using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Syntax;
using MetaDslx.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

#nullable enable

namespace MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax
{
    /// <summary>
    /// This class stores several source parsing related options and offers access to their values.
    /// </summary>
    public sealed class CompilerParseOptions : ParseOptions, IEquatable<CompilerParseOptions>
    {
        /// <summary>
        /// The default parse options.
        /// </summary>
        public static CompilerParseOptions Default { get; } = new CompilerParseOptions();

        private ImmutableArray<string> _preprocessorSymbols;
        private ImmutableDictionary<string, string> _features;

        /// <summary>
        /// Gets the effective language version, which the compiler uses to select the
        /// language rules to apply to the program.
        /// </summary>
        public CompilerLanguageVersion LanguageVersion { get; private set; }

        /// <summary>
        /// Gets the specified language version, which is the value that was specified in
        /// the call to the constructor, or modified using the <see cref="WithLanguageVersion"/> method,
        /// or provided on the command line.
        /// </summary>
        public CompilerLanguageVersion SpecifiedLanguageVersion { get; private set; }

        public override ImmutableArray<string> PreprocessorSymbols => _preprocessorSymbols;

        public CompilerParseOptions(
            CompilerLanguageVersion languageVersion = CompilerLanguageVersion.Default,
            DocumentationMode documentationMode = DocumentationMode.Parse,
            SourceCodeKind kind = SourceCodeKind.Regular,
            global::System.Collections.Generic.IEnumerable<string>? preprocessorSymbols = null)
            : this(languageVersion,
                  documentationMode,
                  kind,
                  preprocessorSymbols.ToImmutableArrayOrEmpty(),
                  ImmutableDictionary<string, string>.Empty)
        {
        }

        internal CompilerParseOptions(
            CompilerLanguageVersion languageVersion,
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

        private CompilerParseOptions(CompilerParseOptions other) : this(
            languageVersion: other.SpecifiedLanguageVersion,
            documentationMode: other.DocumentationMode,
            kind: other.Kind,
            preprocessorSymbols: other.PreprocessorSymbols)
        {
        }

        public override Language Language => CompilerLanguage.Instance;

        public new CompilerParseOptions WithKind(SourceCodeKind kind)
        {
            if (kind == this.Kind)
            {
                return this;
            }

            return new CompilerParseOptions(this) { Kind = kind };
        }

        public CompilerParseOptions WithLanguageVersion(CompilerLanguageVersion version)
        {
            if (version == this.SpecifiedLanguageVersion)
            {
                return this;
            }

            var effectiveLanguageVersion = version.MapSpecifiedToEffectiveVersion();
            return new CompilerParseOptions(this) { SpecifiedLanguageVersion = version, LanguageVersion = effectiveLanguageVersion };
        }

        public CompilerParseOptions WithPreprocessorSymbols(global::System.Collections.Generic.IEnumerable<string>? preprocessorSymbols)
        {
            return WithPreprocessorSymbols(preprocessorSymbols.AsImmutableOrNull());
        }

        public CompilerParseOptions WithPreprocessorSymbols(params string[]? preprocessorSymbols)
        {
            return WithPreprocessorSymbols(preprocessorSymbols.AsImmutableOrNull());
        }

        public CompilerParseOptions WithPreprocessorSymbols(ImmutableArray<string> symbols)
        {
            if (symbols.IsDefault)
            {
                symbols = ImmutableArray<string>.Empty;
            }

            if (symbols.Equals(this.PreprocessorSymbols))
            {
                return this;
            }

            return new CompilerParseOptions(this) { _preprocessorSymbols = symbols };
        }

        public new CompilerParseOptions WithDocumentationMode(DocumentationMode documentationMode)
        {
            if (documentationMode == this.DocumentationMode)
            {
                return this;
            }

            return new CompilerParseOptions(this) { DocumentationMode = documentationMode };
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
            CompilerLanguageVersion availableVersion = LanguageVersion;
            CompilerLanguageVersion requiredVersion = CompilerLanguage.Instance.SyntaxFacts.GetRequiredLanguageVersion(feature);
            return availableVersion >= requiredVersion;
        }

        public override Diagnostic? GetDiagnosticForFeature(string feature)
        {
            CompilerLanguageVersion availableVersion = LanguageVersion;
            CompilerLanguageVersion requiredVersion = CompilerLanguage.Instance.SyntaxFacts.GetRequiredLanguageVersion(feature);
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
            return this.Equals(obj as CompilerParseOptions);
        }

        public bool Equals(CompilerParseOptions? other)
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
