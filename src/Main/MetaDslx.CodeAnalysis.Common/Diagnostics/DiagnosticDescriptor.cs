// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading;
using Roslyn.Utilities;

namespace MetaDslx.CodeAnalysis
{
    /// <summary>
    /// Provides a description about a <see cref="Diagnostic"/>
    /// </summary>
    public sealed class DiagnosticDescriptor : IEquatable<DiagnosticDescriptor?>
    {
        internal const string CompilerCategory = "Compiler";

        /// <summary>
        /// An unique identifier for the diagnostic.
        /// </summary>
        public string Id { get; }

        /// <summary>
        /// A short localizable title describing the diagnostic.
        /// </summary>
        public string Title { get; }

        /// <summary>
        /// An optional longer localizable description for the diagnostic.
        /// </summary>
        public string Description { get; }

        /// <summary>
        /// An optional hyperlink that provides more detailed information regarding the diagnostic.
        /// </summary>
        public string HelpLinkUri { get; }

        /// <summary>
        /// A localizable format message string, which can be passed as the first argument to <see cref="String.Format(string, object[])"/> when creating the diagnostic message with this descriptor.
        /// </summary>
        /// <returns></returns>
        public string MessageFormat { get; }

        /// <summary>
        /// The category of the diagnostic (like Design, Naming etc.)
        /// </summary>
        public string Category { get; }

        /// <summary>
        /// The default severity of the diagnostic.
        /// </summary>
        public DiagnosticSeverity DefaultSeverity { get; }

        /// <summary>
        /// Returns true if the diagnostic is enabled by default.
        /// </summary>
        public bool IsEnabledByDefault { get; }

        /// <summary>
        /// Custom tags for the diagnostic.
        /// </summary>
        public ImmutableArray<string> CustomTags { get; }

        /// <summary>
        /// Create a DiagnosticDescriptor, which provides description about a <see cref="Diagnostic"/>.
        /// NOTE: For localizable <paramref name="title"/>, <paramref name="description"/> and/or <paramref name="messageFormat"/>,
        /// use constructor overload <see cref="DiagnosticDescriptor(string, string, string, string, DiagnosticSeverity, bool, string, string, string[])"/>.
        /// </summary>
        /// <param name="id">A unique identifier for the diagnostic. For example, code analysis diagnostic ID "CA1001".</param>
        /// <param name="title">A short title describing the diagnostic. For example, for CA1001: "Types that own disposable fields should be disposable".</param>
        /// <param name="messageFormat">A format message string, which can be passed as the first argument to <see cref="String.Format(string, object[])"/> when creating the diagnostic message with this descriptor.
        /// For example, for CA1001: "Implement IDisposable on '{0}' because it creates members of the following IDisposable types: '{1}'."</param>
        /// <param name="category">The category of the diagnostic (like Design, Naming etc.). For example, for CA1001: "Microsoft.Design".</param>
        /// <param name="defaultSeverity">Default severity of the diagnostic.</param>
        /// <param name="isEnabledByDefault">True if the diagnostic is enabled by default.</param>
        /// <param name="description">An optional longer description of the diagnostic.</param>
        /// <param name="helpLinkUri">An optional hyperlink that provides a more detailed description regarding the diagnostic.</param>
        /// <param name="customTags">Optional custom tags for the diagnostic. See <see cref="WellKnownDiagnosticTags"/> for some well known tags.</param>
        public DiagnosticDescriptor(
            string id,
            string title,
            string messageFormat,
            string category,
            DiagnosticSeverity defaultSeverity,
            bool isEnabledByDefault,
            string? description = null,
            string? helpLinkUri = null,
            params string[] customTags)
            : this(id, title, messageFormat, category, defaultSeverity, isEnabledByDefault, description, helpLinkUri, customTags.AsImmutableOrEmpty())
        {
        }

        internal DiagnosticDescriptor(
            string id,
            string title,
            string messageFormat,
            string category,
            DiagnosticSeverity defaultSeverity,
            bool isEnabledByDefault,
            string? description,
            string? helpLinkUri,
            ImmutableArray<string> customTags)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                throw new ArgumentException(ExceptionMessages.DiagnosticIdCantBeNullOrWhitespace, nameof(id));
            }

            if (messageFormat == null)
            {
                throw new ArgumentNullException(nameof(messageFormat));
            }

            if (category == null)
            {
                throw new ArgumentNullException(nameof(category));
            }

            if (title == null)
            {
                throw new ArgumentNullException(nameof(title));
            }

            this.Id = id;
            this.Title = title;
            this.Category = category;
            this.MessageFormat = messageFormat;
            this.DefaultSeverity = defaultSeverity;
            this.IsEnabledByDefault = isEnabledByDefault;
            this.Description = description ?? string.Empty;
            this.HelpLinkUri = helpLinkUri ?? string.Empty;
            this.CustomTags = customTags;
        }

        public static DiagnosticDescriptor CompilerError(string id, string title, string messageFormat)
        {
            return new DiagnosticDescriptor(id, title, messageFormat, CompilerCategory, DiagnosticSeverity.Error, true);
        }

        public static DiagnosticDescriptor CompilerWarning(string id, string title, string messageFormat)
        {
            return new DiagnosticDescriptor(id, title, messageFormat, CompilerCategory, DiagnosticSeverity.Warning, true);
        }

        public bool Equals(DiagnosticDescriptor? other)
        {
            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return
                other != null &&
                this.Category == other.Category &&
                this.DefaultSeverity == other.DefaultSeverity &&
                this.Description.Equals(other.Description) &&
                this.HelpLinkUri == other.HelpLinkUri &&
                this.Id == other.Id &&
                this.IsEnabledByDefault == other.IsEnabledByDefault &&
                this.MessageFormat.Equals(other.MessageFormat) &&
                this.Title.Equals(other.Title);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as DiagnosticDescriptor);
        }

        public override int GetHashCode()
        {
            return Hash.Combine(this.Category.GetHashCode(),
                Hash.Combine(this.DefaultSeverity.GetHashCode(),
                Hash.Combine(this.Description.GetHashCode(),
                Hash.Combine(this.HelpLinkUri.GetHashCode(),
                Hash.Combine(this.Id.GetHashCode(),
                Hash.Combine(this.IsEnabledByDefault.GetHashCode(),
                Hash.Combine(this.MessageFormat.GetHashCode(),
                    this.Title.GetHashCode())))))));
        }

        /// <summary>
        /// Gets the effective severity of diagnostics created based on this descriptor and the given <see cref="CompilationOptions"/>.
        /// </summary>
        /// <param name="compilationOptions">Compilation options</param>
        public ReportDiagnostic GetEffectiveSeverity(CompilationOptions compilationOptions)
        {
            if (compilationOptions == null)
            {
                throw new ArgumentNullException(nameof(compilationOptions));
            }

            // Create a dummy diagnostic to compute the effective diagnostic severity for given compilation options
            return compilationOptions.GetEffectiveSeverity(this);
        }

        // internal for testing purposes.
        internal static ReportDiagnostic MapSeverityToReport(DiagnosticSeverity severity)
        {
            switch (severity)
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
                    throw ExceptionUtilities.UnexpectedValue(severity);
            }
        }

        /// <summary>
        /// Returns true if diagnostic descriptor is not configurable, i.e. cannot be suppressed or filtered or have its severity changed.
        /// For example, compiler errors are always non-configurable.
        /// </summary>
        public bool IsNotConfigurable()
        {
            return this.CustomTags.Contains(WellKnownDiagnosticTags.NotConfigurable);
        }
    }
}
