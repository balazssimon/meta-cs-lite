using MetaDslx.CodeAnalysis;
using Roslyn.Utilities;

#nullable enable

namespace MetaDslx.Bootstrap.MetaModel.Compiler
{
    /// <summary>
    /// Specifies the language version.
    /// </summary>
    public enum MetaCoreLanguageVersion
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

    public static class MetaCoreLanguageVersionFacts
    {
        internal static bool IsValid(this MetaCoreLanguageVersion value)
        {
            switch (value)
            {
                case MetaCoreLanguageVersion.Version1:
                case MetaCoreLanguageVersion.Preview:
                    return true;
            }

            return false;
        }

        /// <summary>
        /// Displays the version number in the format expected on the command-line (/langver flag).
        /// For instance, "6", "7", "7.1", "latest".
        /// </summary>
        public static string ToDisplayString(this MetaCoreLanguageVersion version)
        {
            if (version == MetaCoreLanguageVersion.Version1) return "1";
            if (version == MetaCoreLanguageVersion.Default) return "default";
            if (version == MetaCoreLanguageVersion.Latest) return "latest";
            if (version == MetaCoreLanguageVersion.LatestMajor) return "latestmajor";
            if (version == MetaCoreLanguageVersion.Preview) return "preview";
            throw ExceptionUtilities.UnexpectedValue(version);
        }

        /// <summary>
        /// Try parse a <see cref="MetaCoreLanguageVersion"/> from a string input, returning default if input was null.
        /// </summary>
        public static bool TryParse(string version, out MetaCoreLanguageVersion result)
        {
            if (version == null)
            {
                result = MetaCoreLanguageVersion.Default;
                return true;
            }
            switch (CaseInsensitiveComparison.ToLower(version))
            {
                case "default":
                    result = MetaCoreLanguageVersion.Default;
                    return true;
                case "latest":
                    result = MetaCoreLanguageVersion.Latest;
                    return true;
                case "latestmajor":
                    result = MetaCoreLanguageVersion.LatestMajor;
                    return true;
                case "preview":
                    result = MetaCoreLanguageVersion.Preview;
                    return true;
                case "1":
                case "1.0":
                    result = MetaCoreLanguageVersion.Version1;
                    return true;
                default:
                    result = MetaCoreLanguageVersion.Default;
                    return false;
            }
        }

        /// <summary>
        /// Map a language version (such as Default, Latest, or VersionN) to a specific version (VersionM).
        /// </summary>
        internal static MetaCoreLanguageVersion MapSpecifiedToEffectiveVersion(this MetaCoreLanguageVersion version)
        {
            switch (version)
            {
                case MetaCoreLanguageVersion.Latest:
                case MetaCoreLanguageVersion.Default:
                case MetaCoreLanguageVersion.LatestMajor:
                    return MetaCoreLanguageVersion.Version1;
                default:
                    return version;
            }
        }

        public static MetaCoreLanguageVersion CurrentVersion => MetaCoreLanguageVersion.Version1;
    }

}
