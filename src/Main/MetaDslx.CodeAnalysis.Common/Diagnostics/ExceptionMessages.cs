using System;

namespace MetaDslx.CodeAnalysis
{
    internal static class ExceptionMessages
    {
        public const string StartMustNotBeNegative = "'start' must not be negative";
        public const string EndMustNotBeLessThanStart = "'end' must not be less than 'start'";

        public const string ChangesMustBeWithinBoundsOfSourceText = "Changes must be within bounds of SourceText.";
        public const string ChangesMustNotOverlap = "The changes must not overlap.";

        public const string StreamMustSupportReadAndSeek = "Stream must support read and seek operations.";
        public const string StreamIsTooLong = "Stream is too long.";

        public const string InvalidHash = "Invalid hash.";
        public const string UnsupportedHashAlgorithm = "Unsupported hash algorithm.";

        public const string SpanDoesNotIncludeStartOfLine = "The span does not include the start of a line.";
        public const string SpanDoesNotIncludeEndOfLine = "The span does not include the end of a line.";

        public const string DiagnosticIdCantBeNullOrWhitespace = "A DiagnosticDescriptor must have an Id that is neither null nor an empty string nor a string that only contains white space.";
        public const string SuppressionIdCantBeNullOrWhitespace = "A SuppressionDescriptor must have an Id that is neither null nor an empty string nor a string that only contains white space.";

        public const string ReferenceResolverShouldReturnReadableNonNullStream = "Reference resolver should return readable non-null stream.";

        public const string SourceTextCannotBeEmbedded = "SourceText cannot be embedded. Provide encoding or canBeEmbedded=true at construction.";

        public const string ArgumentCannotBeEmpty = "Argument cannot be empty.";

        public const string SeparatorIsExpected = "separator is expected";
        public const string ElementIsExpected = "element is expected";

        public const string InvalidNodeToTrack = "Node to track is not a descendant of the root.";
    }
}
