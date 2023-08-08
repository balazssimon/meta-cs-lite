// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using MetaDslx.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace MetaDslx.CodeAnalysis
{
    /// <summary>
    /// Represents parse options common to C# and VB.
    /// </summary>
    public abstract class ParseOptions
    {
        private readonly Lazy<ImmutableArray<Diagnostic>> _lazyErrors;

        /// <summary>
        /// Specifies whether to parse as regular code files, script files or interactive code.
        /// </summary>
        public SourceCodeKind Kind { get; protected set; }

        /// <summary>
        /// Gets a value indicating whether the documentation comments are parsed.
        /// </summary>
        /// <value><c>true</c> if documentation comments are parsed, <c>false</c> otherwise.</value>
        public DocumentationMode DocumentationMode { get; protected set; }

        protected ParseOptions(SourceCodeKind kind, DocumentationMode documentationMode)
        {
            this.Kind = kind;
            this.DocumentationMode = documentationMode;

            _lazyErrors = new Lazy<ImmutableArray<Diagnostic>>(() =>
            {
                var builder = ArrayBuilder<Diagnostic>.GetInstance();
                ValidateOptions(builder);
                return builder.ToImmutableAndFree();
            });
        }

        /// <summary>
        /// Gets the source language ("C#" or "Visual Basic").
        /// </summary>
        public abstract Language Language { get; }

        /// <summary>
        /// Errors collection related to an incompatible set of parse options
        /// </summary>
        public ImmutableArray<Diagnostic> Errors
        {
            get { return _lazyErrors.Value; }
        }

        /// <summary>
        /// Creates a new options instance with the specified source code kind.
        /// </summary>
        public ParseOptions WithKind(SourceCodeKind kind)
        {
            return CommonWithKind(kind);
        }

        /// <summary>
        /// Performs validation of options compatibilities and generates diagnostics if needed
        /// </summary>
        protected abstract void CommonValidateOptions(ArrayBuilder<Diagnostic> builder);

        public void ValidateOptions(ArrayBuilder<Diagnostic> builder)
        {
            // Validate SpecifiedKind not Kind, to catch deprecated specified kinds:
            if (!Kind.IsValid())
            {
                builder.Add(Diagnostic.Create(CommonErrorCode.ERR_BadSourceCodeKind, Location.None, Kind));
            }

            if (!DocumentationMode.IsValid())
            {
                builder.Add(Diagnostic.Create(CommonErrorCode.ERR_BadDocumentationMode, Location.None, DocumentationMode));
            }

            CommonValidateOptions(builder);
        }

        protected abstract ParseOptions CommonWithKind(SourceCodeKind kind);

        /// <summary>
        /// Creates a new options instance with the specified documentation mode.
        /// </summary>
        public ParseOptions WithDocumentationMode(DocumentationMode documentationMode)
        {
            return CommonWithDocumentationMode(documentationMode);
        }

        protected abstract ParseOptions CommonWithDocumentationMode(DocumentationMode documentationMode);

        protected abstract bool IsFeatureEnabled(string feature);
        public abstract Diagnostic? GetDiagnosticForFeature(string feature);

        /// <summary>
        /// Names of defined preprocessor symbols.
        /// </summary>
        public abstract ImmutableArray<string> PreprocessorSymbols { get; }

        public abstract override bool Equals(object? obj);

        protected bool EqualsHelper([NotNullWhen(true)] ParseOptions? other)
        {
            if (object.ReferenceEquals(other, null))
            {
                return false;
            }

            return
                this.Kind == other.Kind &&
                this.DocumentationMode == other.DocumentationMode &&
                (this.PreprocessorSymbols == null ? other.PreprocessorSymbols == null : this.PreprocessorSymbols.SequenceEqual(other.PreprocessorSymbols, StringComparer.Ordinal));
        }

        public abstract override int GetHashCode();

        protected int GetHashCodeHelper()
        {
            return
                Hash.Combine((int)this.Kind,
                Hash.Combine((int)this.DocumentationMode,
                Hash.Combine(Hash.CombineValues(this.PreprocessorSymbols, StringComparer.Ordinal), 0)));
        }

        private static int HashFeatures(IReadOnlyDictionary<string, string> features)
        {
            int value = 0;
            foreach (var kv in features)
            {
                value = Hash.Combine(kv.Key.GetHashCode(),
                        Hash.Combine(kv.Value.GetHashCode(), value));
            }

            return value;
        }

        public static bool operator ==(ParseOptions? left, ParseOptions? right)
        {
            return object.Equals(left, right);
        }

        public static bool operator !=(ParseOptions? left, ParseOptions? right)
        {
            return !object.Equals(left, right);
        }
    }
}
