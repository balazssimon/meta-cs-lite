using MetaDslx.CodeAnalysis.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Diagnostics;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis
{
    public static class DiagnosticExtensions
    {

        /// <summary>
        /// Gets the effective severity of diagnostics created based on this descriptor and the given <see cref="CompilationOptions"/>.
        /// </summary>
        /// <param name="compilationOptions">Compilation options</param>
        public static ReportDiagnostic GetEffectiveSeverity(this DiagnosticDescriptor descriptor, CompilationOptions compilationOptions)
        {
            if (compilationOptions == null)
            {
                throw new ArgumentNullException(nameof(compilationOptions));
            }

            // Create a dummy diagnostic to compute the effective diagnostic severity for given compilation options
            return compilationOptions.GetEffectiveSeverity(descriptor);
        }

        /// <summary>
        /// Gets the <see cref="SuppressionInfo"/> for suppressed diagnostics, i.e. <see cref="Diagnostic.IsSuppressed"/> = true.
        /// Otherwise, returns null.
        /// </summary>
        public static SuppressionInfo? GetSuppressionInfo(this Diagnostic descriptor, Compilation compilation)
        {
            if (!descriptor.IsSuppressed)
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
            return new SuppressionInfo(descriptor.Id, attribute);
        }

        /// <summary>
        /// Returns true if the diagnostic location (or any additional location) is within the given tree and intersects with the filterSpanWithinTree, if non-null.
        /// </summary>
        internal static bool HasIntersectingLocation(this Diagnostic diagnostic, SyntaxTree tree, TextSpan? filterSpanWithinTree = null)
        {
            if (isLocationWithinSpan(diagnostic.Location, tree, filterSpanWithinTree))
            {
                return true;
            }

            if (diagnostic.AdditionalLocations is null || diagnostic.AdditionalLocations.Count == 0)
            {
                // Avoid possible enumerator allocations if there are no additional locations.
                return false;
            }

            foreach (var location in diagnostic.AdditionalLocations)
            {
                if (isLocationWithinSpan(location, tree, filterSpanWithinTree))
                {
                    return true;
                }
            }

            return false;

            static bool isLocationWithinSpan(Location location, SyntaxTree tree, TextSpan? filterSpan)
            {
                if (location is SourceLocation sourceLocation && sourceLocation.SourceTree != tree)
                {
                    return false;
                }

                return !filterSpan.HasValue || filterSpan.GetValueOrDefault().IntersectsWith(location.SourceSpan);
            }
        }
    }
}
