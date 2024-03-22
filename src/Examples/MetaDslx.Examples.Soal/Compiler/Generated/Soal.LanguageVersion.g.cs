using MetaDslx.CodeAnalysis;
using Roslyn.Utilities;

#pragma warning disable CS8669

namespace MetaDslx.Examples.Soal.Compiler
{
    /// <summary>
    /// Specifies the language version.
    /// </summary>
    public enum SoalLanguageVersion
    {
        /// <summary>
        /// Language version 1
        /// </summary>
        Version1 = 1,

        /// <summary>
        /// The latest major supported version.
        /// </summary>
        LatestMajor = int.MaxValue - 2,

        /// <summary>
        /// Preview of the next language version.
        /// </summary>
        Preview = int.MaxValue - 1,

        /// <summary>
        /// The latest supported version of the language.
        /// </summary>
        Latest = int.MaxValue,

        /// <summary>
        /// The default language version, which is the latest supported version.
        /// </summary>
        Default = 0,
    }

    public static class SoalLanguageVersionFacts
    {
        internal static bool IsValid(this SoalLanguageVersion value)
        {
            switch (value)
            {
                case SoalLanguageVersion.Version1:
                case SoalLanguageVersion.Preview:
                    return true;
            }

            return false;
        }

        /// <summary>
        /// Displays the version number in the format expected on the command-line (/langver flag).
        /// For instance, "6", "7", "7.1", "latest".
        /// </summary>
        public static string ToDisplayString(this SoalLanguageVersion version)
        {
            if (version == SoalLanguageVersion.Version1) return "1";
            if (version == SoalLanguageVersion.Default) return "default";
            if (version == SoalLanguageVersion.Latest) return "latest";
            if (version == SoalLanguageVersion.LatestMajor) return "latestmajor";
            if (version == SoalLanguageVersion.Preview) return "preview";
            throw ExceptionUtilities.UnexpectedValue(version);
        }

        /// <summary>
        /// Try parse a <see cref="SoalLanguageVersion"/> from a string input, returning default if input was null.
        /// </summary>
        public static bool TryParse(string version, out SoalLanguageVersion result)
        {
            if (version == null)
            {
                result = SoalLanguageVersion.Default;
                return true;
            }
            switch (CaseInsensitiveComparison.ToLower(version))
            {
                case "default":
                    result = SoalLanguageVersion.Default;
                    return true;
                case "latest":
                    result = SoalLanguageVersion.Latest;
                    return true;
                case "latestmajor":
                    result = SoalLanguageVersion.LatestMajor;
                    return true;
                case "preview":
                    result = SoalLanguageVersion.Preview;
                    return true;
                case "1":
                case "1.0":
                    result = SoalLanguageVersion.Version1;
                    return true;
                default:
                    result = SoalLanguageVersion.Default;
                    return false;
            }
        }

        /// <summary>
        /// Map a language version (such as Default, Latest, or VersionN) to a specific version (VersionM).
        /// </summary>
        internal static SoalLanguageVersion MapSpecifiedToEffectiveVersion(this SoalLanguageVersion version)
        {
            switch (version)
            {
                case SoalLanguageVersion.Latest:
                case SoalLanguageVersion.Default:
                case SoalLanguageVersion.LatestMajor:
                    return SoalLanguageVersion.Version1;
                default:
                    return version;
            }
        }

        public static SoalLanguageVersion CurrentVersion => SoalLanguageVersion.Version1;
    }

}
