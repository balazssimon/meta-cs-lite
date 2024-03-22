using MetaDslx.CodeAnalysis;
using Roslyn.Utilities;

#pragma warning disable CS8669

namespace MetaDslx.Languages.MetaModel.Compiler
{
    /// <summary>
    /// Specifies the language version.
    /// </summary>
    public enum MetaLanguageVersion
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

    public static class MetaLanguageVersionFacts
    {
        internal static bool IsValid(this MetaLanguageVersion value)
        {
            switch (value)
            {
                case MetaLanguageVersion.Version1:
                case MetaLanguageVersion.Preview:
                    return true;
            }

            return false;
        }

        /// <summary>
        /// Displays the version number in the format expected on the command-line (/langver flag).
        /// For instance, "6", "7", "7.1", "latest".
        /// </summary>
        public static string ToDisplayString(this MetaLanguageVersion version)
        {
            if (version == MetaLanguageVersion.Version1) return "1";
            if (version == MetaLanguageVersion.Default) return "default";
            if (version == MetaLanguageVersion.Latest) return "latest";
            if (version == MetaLanguageVersion.LatestMajor) return "latestmajor";
            if (version == MetaLanguageVersion.Preview) return "preview";
            throw ExceptionUtilities.UnexpectedValue(version);
        }

        /// <summary>
        /// Try parse a <see cref="MetaLanguageVersion"/> from a string input, returning default if input was null.
        /// </summary>
        public static bool TryParse(string version, out MetaLanguageVersion result)
        {
            if (version == null)
            {
                result = MetaLanguageVersion.Default;
                return true;
            }
            switch (CaseInsensitiveComparison.ToLower(version))
            {
                case "default":
                    result = MetaLanguageVersion.Default;
                    return true;
                case "latest":
                    result = MetaLanguageVersion.Latest;
                    return true;
                case "latestmajor":
                    result = MetaLanguageVersion.LatestMajor;
                    return true;
                case "preview":
                    result = MetaLanguageVersion.Preview;
                    return true;
                case "1":
                case "1.0":
                    result = MetaLanguageVersion.Version1;
                    return true;
                default:
                    result = MetaLanguageVersion.Default;
                    return false;
            }
        }

        /// <summary>
        /// Map a language version (such as Default, Latest, or VersionN) to a specific version (VersionM).
        /// </summary>
        internal static MetaLanguageVersion MapSpecifiedToEffectiveVersion(this MetaLanguageVersion version)
        {
            switch (version)
            {
                case MetaLanguageVersion.Latest:
                case MetaLanguageVersion.Default:
                case MetaLanguageVersion.LatestMajor:
                    return MetaLanguageVersion.Version1;
                default:
                    return version;
            }
        }

        public static MetaLanguageVersion CurrentVersion => MetaLanguageVersion.Version1;
    }

}
