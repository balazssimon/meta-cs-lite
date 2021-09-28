// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Globalization;
using MetaDslx.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace MetaDslx.CodeAnalysis
{
    /// <summary>
    /// Represents a diagnostic, such as a compiler error or a warning, along with the location where it occurred.
    /// </summary>
    [DebuggerDisplay("{GetDebuggerDisplay(), nq}")]
    public abstract partial class Diagnostic : IEquatable<Diagnostic?>, IFormattable
    {
        internal const string CompilerDiagnosticCategory = "Compiler";

        /// <summary>
        /// The default warning level, which is also used for non-error diagnostics.
        /// </summary>
        internal const int DefaultWarningLevel = 4;

        /// <summary>
        /// The warning level used for hidden and info diagnostics. Because these diagnostics interact with other editor features, we want them to always be produced unless /warn:0 is set.
        /// </summary>
        internal const int InfoAndHiddenWarningLevel = 1;

        /// <summary>
        /// The maximum warning level represented by a large value of 9999.
        /// </summary>
        internal const int MaxWarningLevel = 9999;

        /// <summary>
        /// Creates a <see cref="Diagnostic"/> instance.
        /// </summary>
        /// <param name="descriptor">A <see cref="DiagnosticDescriptor"/> describing the diagnostic</param>
        /// <param name="location">An optional primary location of the diagnostic. If null, <see cref="Location"/> will return <see cref="Location.None"/>.</param>
        /// <param name="messageArgs">Arguments to the message of the diagnostic</param>
        /// <returns>The <see cref="Diagnostic"/> instance.</returns>
        public static Diagnostic Create(
            DiagnosticDescriptor descriptor,
            Location? location,
            params object?[]? messageArgs)
        {
            return Create(descriptor, location, null, null, messageArgs);
        }

        /// <summary>
        /// Creates a <see cref="Diagnostic"/> instance.
        /// </summary>
        /// <param name="descriptor">A <see cref="DiagnosticDescriptor"/> describing the diagnostic.</param>
        /// <param name="location">An optional primary location of the diagnostic. If null, <see cref="Location"/> will return <see cref="Location.None"/>.</param>
        /// <param name="properties">
        /// An optional set of name-value pairs by means of which the analyzer that creates the diagnostic
        /// can convey more detailed information to the fixer. If null, <see cref="Properties"/> will return
        /// <see cref="ImmutableDictionary{TKey, TValue}.Empty"/>.
        /// </param>
        /// <param name="messageArgs">Arguments to the message of the diagnostic.</param>
        /// <returns>The <see cref="Diagnostic"/> instance.</returns>
        public static Diagnostic Create(
            DiagnosticDescriptor descriptor,
            Location? location,
            ImmutableDictionary<string, string?>? properties,
            params object?[]? messageArgs)
        {
            return Create(descriptor, location, null, properties, messageArgs);
        }

        /// <summary>
        /// Creates a <see cref="Diagnostic"/> instance.
        /// </summary>
        /// <param name="descriptor">A <see cref="DiagnosticDescriptor"/> describing the diagnostic.</param>
        /// <param name="location">An optional primary location of the diagnostic. If null, <see cref="Location"/> will return <see cref="Location.None"/>.</param>
        /// <param name="additionalLocations">
        /// An optional set of additional locations related to the diagnostic.
        /// Typically, these are locations of other items referenced in the message.
        /// If null, <see cref="AdditionalLocations"/> will return an empty list.
        /// </param>
        /// <param name="messageArgs">Arguments to the message of the diagnostic.</param>
        /// <returns>The <see cref="Diagnostic"/> instance.</returns>
        public static Diagnostic Create(
            DiagnosticDescriptor descriptor,
            Location? location,
            IEnumerable<Location>? additionalLocations,
            params object?[]? messageArgs)
        {
            return Create(descriptor, location, additionalLocations, properties: null, messageArgs: messageArgs);
        }

        /// <summary>
        /// Creates a <see cref="Diagnostic"/> instance.
        /// </summary>
        /// <param name="descriptor">A <see cref="DiagnosticDescriptor"/> describing the diagnostic.</param>
        /// <param name="location">An optional primary location of the diagnostic. If null, <see cref="Location"/> will return <see cref="Location.None"/>.</param>
        /// <param name="additionalLocations">
        /// An optional set of additional locations related to the diagnostic.
        /// Typically, these are locations of other items referenced in the message.
        /// If null, <see cref="AdditionalLocations"/> will return an empty list.
        /// </param>
        /// <param name="properties">
        /// An optional set of name-value pairs by means of which the analyzer that creates the diagnostic
        /// can convey more detailed information to the fixer. If null, <see cref="Properties"/> will return
        /// <see cref="ImmutableDictionary{TKey, TValue}.Empty"/>.
        /// </param>
        /// <param name="messageArgs">Arguments to the message of the diagnostic.</param>
        /// <returns>The <see cref="Diagnostic"/> instance.</returns>
        public static Diagnostic Create(
            DiagnosticDescriptor descriptor,
            Location? location,
            IEnumerable<Location>? additionalLocations,
            ImmutableDictionary<string, string?>? properties,
            params object?[]? messageArgs)
        {
            return Create(descriptor, location, effectiveSeverity: descriptor.DefaultSeverity, additionalLocations, properties, messageArgs);
        }

        /// <summary>
        /// Creates a <see cref="Diagnostic"/> instance.
        /// </summary>
        /// <param name="descriptor">A <see cref="DiagnosticDescriptor"/> describing the diagnostic.</param>
        /// <param name="location">An optional primary location of the diagnostic. If null, <see cref="Location"/> will return <see cref="Location.None"/>.</param>
        /// <param name="effectiveSeverity">Effective severity of the diagnostic.</param>
        /// <param name="additionalLocations">
        /// An optional set of additional locations related to the diagnostic.
        /// Typically, these are locations of other items referenced in the message.
        /// If null, <see cref="AdditionalLocations"/> will return an empty list.
        /// </param>
        /// <param name="properties">
        /// An optional set of name-value pairs by means of which the analyzer that creates the diagnostic
        /// can convey more detailed information to the fixer. If null, <see cref="Properties"/> will return
        /// <see cref="ImmutableDictionary{TKey, TValue}.Empty"/>.
        /// </param>
        /// <param name="messageArgs">Arguments to the message of the diagnostic.</param>
        /// <returns>The <see cref="Diagnostic"/> instance.</returns>
        public static Diagnostic Create(
            DiagnosticDescriptor descriptor,
            Location? location,
            DiagnosticSeverity effectiveSeverity,
            IEnumerable<Location>? additionalLocations,
            ImmutableDictionary<string, string?>? properties,
            params object?[]? messageArgs)
        {
            if (descriptor == null)
            {
                throw new ArgumentNullException(nameof(descriptor));
            }

            var warningLevel = GetDefaultWarningLevel(effectiveSeverity);
            return SimpleDiagnostic.Create(
                descriptor,
                severity: effectiveSeverity,
                warningLevel: warningLevel,
                location: location ?? Location.None,
                additionalLocations: additionalLocations,
                messageArgs: messageArgs,
                properties: properties);
        }

        internal static Diagnostic Create(DiagnosticInfo info)
        {
            return new DiagnosticWithInfo(info, Location.None);
        }

        internal static Diagnostic Create(DiagnosticInfo info, Location location)
        {
            return new DiagnosticWithInfo(info, location);
        }

        /// <summary>
        /// Gets the diagnostic descriptor, which provides a description about a <see cref="Diagnostic"/>.
        /// </summary>
        public abstract DiagnosticDescriptor Descriptor { get; }

        /// <summary>
        /// Gets the diagnostic identifier. For diagnostics generated by the compiler, this will be a numeric code with a prefix such as "CS1001".
        /// </summary>
        public abstract string Id { get; }

        /// <summary>
        /// Gets the category of diagnostic. For diagnostics generated by the compiler, the category will be "Compiler".
        /// </summary>
        internal virtual string Category { get { return this.Descriptor.Category; } }

        /// <summary>
        /// Get the culture specific text of the message.
        /// </summary>
        public abstract string GetMessage(IFormatProvider? formatProvider = null);

        /// <summary>
        /// Gets the default <see cref="DiagnosticSeverity"/> of the diagnostic's <see cref="DiagnosticDescriptor"/>.
        /// </summary>
        /// <remarks>
        /// To get the effective severity of the diagnostic, use <see cref="Severity"/>.
        /// </remarks>
        public virtual DiagnosticSeverity DefaultSeverity { get { return this.Descriptor.DefaultSeverity; } }

        /// <summary>
        /// Gets the effective <see cref="DiagnosticSeverity"/> of the diagnostic.
        /// </summary>
        /// <remarks>
        /// To get the default severity of diagnostic's <see cref="DiagnosticDescriptor"/>, use <see cref="DefaultSeverity"/>.
        /// To determine if this is a warning treated as an error, use <see cref="IsWarningAsError"/>.
        /// </remarks>
        public abstract DiagnosticSeverity Severity { get; }

        /// <summary>
        /// Gets the warning level. This is 0 for diagnostics with severity <see cref="DiagnosticSeverity.Error"/>,
        /// otherwise an integer greater than zero.
        /// </summary>
        public abstract int WarningLevel { get; }

        /// <summary>
        /// Returns true if the diagnostic has a source suppression, i.e. an attribute or a pragma suppression.
        /// </summary>
        public abstract bool IsSuppressed { get; }

        /// <summary>
        /// Gets the <see cref="SuppressionInfo"/> for suppressed diagnostics, i.e. <see cref="IsSuppressed"/> = true.
        /// Otherwise, returns null.
        /// </summary>
        public SuppressionInfo? GetSuppressionInfo(Compilation compilation)
        {
            if (!IsSuppressed)
            {
                return null;
            }

            AttributeData? attribute = null;
            /* TODO:MetaDslx
            var suppressMessageState = new SuppressMessageAttributeState(compilation);
            if (!suppressMessageState.IsDiagnosticSuppressed(
                    this,
                    out attribute))
            {
                attribute = null;
            }
            */
            return new SuppressionInfo(this.Id, attribute);
        }

        /// <summary>
        /// Returns true if this diagnostic is enabled by default by the author of the diagnostic.
        /// </summary>
        internal virtual bool IsEnabledByDefault { get { return this.Descriptor.IsEnabledByDefault; } }

        /// <summary>
        /// Returns true if this is a warning treated as an error; otherwise false.
        /// </summary>
        /// <remarks>
        /// True implies <see cref="DefaultSeverity"/> = <see cref="DiagnosticSeverity.Warning"/>
        /// and <see cref="Severity"/> = <see cref="DiagnosticSeverity.Error"/>.
        /// </remarks>
        public bool IsWarningAsError
        {
            get
            {
                return this.DefaultSeverity == DiagnosticSeverity.Warning &&
                    this.Severity == DiagnosticSeverity.Error;
            }
        }

        /// <summary>
        /// Gets the primary location of the diagnostic, or <see cref="Location.None"/> if no primary location.
        /// </summary>
        public abstract Location Location { get; }

        /// <summary>
        /// Gets an array of additional locations related to the diagnostic.
        /// Typically these are the locations of other items referenced in the message.
        /// </summary>
        public abstract IReadOnlyList<Location> AdditionalLocations { get; }

        /// <summary>
        /// Gets custom tags for the diagnostic.
        /// </summary>
        internal virtual IReadOnlyList<string> CustomTags { get { return (IReadOnlyList<string>)this.Descriptor.CustomTags; } }

        /// <summary>
        /// Gets property bag for the diagnostic. it will return <see cref="ImmutableDictionary{TKey, TValue}.Empty"/> 
        /// if there is no entry. This can be used to put diagnostic specific information you want 
        /// to pass around. for example, to corresponding fixer.
        /// </summary>
        public virtual ImmutableDictionary<string, string?> Properties
            => ImmutableDictionary<string, string?>.Empty;

        string IFormattable.ToString(string? ignored, IFormatProvider? formatProvider)
        {
            return DiagnosticFormatter.Instance.Format(this, formatProvider);
        }

        public override string ToString()
        {
            return DiagnosticFormatter.Instance.Format(this, CultureInfo.CurrentUICulture);
        }

        public abstract override bool Equals(object? obj);

        public abstract override int GetHashCode();

        public abstract bool Equals(Diagnostic? obj);

        private string GetDebuggerDisplay()
        {
            if (this.Descriptor == InternalDiagnosticDescriptors.Unknown) return "Unresolved diagnostic at " + this.Location;
            if (this.Descriptor == InternalDiagnosticDescriptors.Void) return "Void diagnostic at " + this.Location;
            return ToString();
        }

        /// <summary>
        /// Create a new instance of this diagnostic with the Location property changed.
        /// </summary>
        internal abstract Diagnostic WithLocation(Location location);

        /// <summary>
        /// Create a new instance of this diagnostic with the Severity property changed.
        /// </summary>
        internal abstract Diagnostic WithSeverity(DiagnosticSeverity severity);

        /// <summary>
        /// Create a new instance of this diagnostic with the suppression info changed.
        /// </summary>
        internal abstract Diagnostic WithIsSuppressed(bool isSuppressed);

        /// <summary>
        /// Create a new instance of this diagnostic with the given programmatic suppression info.
        /// </summary>
        internal Diagnostic WithProgrammaticSuppression(ProgrammaticSuppressionInfo programmaticSuppressionInfo)
        {
            Debug.Assert(this.ProgrammaticSuppressionInfo == null);
            Debug.Assert(programmaticSuppressionInfo != null);

            return new DiagnosticWithProgrammaticSuppression(this, programmaticSuppressionInfo);
        }

        internal virtual ProgrammaticSuppressionInfo? ProgrammaticSuppressionInfo { get { return null; } }

        internal virtual IReadOnlyList<object?> Arguments
        {
            get { return SpecializedCollections.EmptyReadOnlyList<object?>(); }
        }

        /// <summary>
        /// Returns true if the diagnostic location (or any additional location) is within the given tree and intersects with the filterSpanWithinTree, if non-null.
        /// </summary>
        internal bool HasIntersectingLocation(SyntaxTree tree, TextSpan? filterSpanWithinTree = null)
        {
            if (isLocationWithinSpan(Location, tree, filterSpanWithinTree))
            {
                return true;
            }

            if (AdditionalLocations is null || AdditionalLocations.Count == 0)
            {
                // Avoid possible enumerator allocations if there are no additional locations.
                return false;
            }

            foreach (var location in AdditionalLocations)
            {
                if (isLocationWithinSpan(location, tree, filterSpanWithinTree))
                {
                    return true;
                }
            }

            return false;

            static bool isLocationWithinSpan(Location location, SyntaxTree tree, TextSpan? filterSpan)
            {
                if (location.SourceTree != tree)
                {
                    return false;
                }

                return !filterSpan.HasValue || filterSpan.GetValueOrDefault().IntersectsWith(location.SourceSpan);
            }
        }

        internal Diagnostic? WithReportDiagnostic(ReportDiagnostic reportAction)
        {
            switch (reportAction)
            {
                case ReportDiagnostic.Suppress:
                    // Suppressed diagnostic.
                    return null;
                case ReportDiagnostic.Error:
                    return this.WithSeverity(DiagnosticSeverity.Error);
                case ReportDiagnostic.Default:
                    return this;
                case ReportDiagnostic.Warn:
                    return this.WithSeverity(DiagnosticSeverity.Warning);
                case ReportDiagnostic.Info:
                    return this.WithSeverity(DiagnosticSeverity.Info);
                case ReportDiagnostic.Hidden:
                    return this.WithSeverity(DiagnosticSeverity.Hidden);
                default:
                    throw ExceptionUtilities.UnexpectedValue(reportAction);
            }
        }

        /// <summary>
        /// Gets the default warning level for a diagnostic severity. Warning levels are used with the <c>/warn:N</c>
        /// command line option to suppress diagnostics over a severity of interest. When N is 0, only error severity
        /// messages are produced by the compiler. Values greater than 0 indicated that warnings up to and including
        /// level N should also be included.
        /// </summary>
        /// <remarks>
        /// <see cref="DiagnosticSeverity.Info"/> and <see cref="DiagnosticSeverity.Hidden"/> are treated as warning
        /// level 1. In other words, these diagnostics which typically interact with editor features are enabled unless
        /// the special <c>/warn:0</c> option is set.
        /// </remarks>
        /// <param name="severity">A <see cref="DiagnosticSeverity"/> value.</param>
        /// <returns>The default compiler warning level for <paramref name="severity"/>.</returns>
        internal static int GetDefaultWarningLevel(DiagnosticSeverity severity)
        {
            switch (severity)
            {
                case DiagnosticSeverity.Error:
                    return 0;

                case DiagnosticSeverity.Warning:
                default:
                    return 1;
            }
        }

        /// <summary>
        /// Returns true if a diagnostic is not configurable, i.e. cannot be suppressed or filtered or have its severity changed.
        /// For example, compiler errors are always non-configurable.
        /// </summary>
        public virtual bool IsNotConfigurable()
        {
            return this.CustomTags.Contains(WellKnownDiagnosticTags.NotConfigurable);
        }

        /// <summary>
        /// Returns true if this is an error diagnostic which cannot be suppressed and is guaranteed to break the build.
        /// Only diagnostics which have default severity error and are tagged as NotConfigurable fall in this bucket.
        /// This includes all compiler error diagnostics and specific analyzer error diagnostics that are marked as not configurable by the analyzer author.
        /// </summary>
        public bool IsUnsuppressableError()
            => DefaultSeverity == DiagnosticSeverity.Error && IsNotConfigurable();

        /// <summary>
        /// Returns true if this is a unsuppressed diagnostic with an effective error severity.
        /// </summary>
        public bool IsUnsuppressedError
            => Severity == DiagnosticSeverity.Error && !IsSuppressed;
    }

}
