using MetaDslx.CodeAnalysis;
using Roslyn.Utilities;

#nullable enable

namespace MetaDslx.Bootstrap.MetaCompiler2.Compiler
{
    /// <summary>
    /// Specifies the language version.
    /// </summary>
    public enum CompilerLanguageVersion
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

    public static class CompilerLanguageVersionFacts
    {
        internal static bool IsValid(this CompilerLanguageVersion value)
        {
            switch (value)
            {
                case CompilerLanguageVersion.Version1:
                case CompilerLanguageVersion.Preview:
                    return true;
            }

            return false;
        }

        /// <summary>
        /// Displays the version number in the format expected on the command-line (/langver flag).
        /// For instance, "6", "7", "7.1", "latest".
        /// </summary>
        public static string ToDisplayString(this CompilerLanguageVersion version)
        {
            if (version == CompilerLanguageVersion.Version1) return "1";
            if (version == CompilerLanguageVersion.Default) return "default";
            if (version == CompilerLanguageVersion.Latest) return "latest";
            if (version == CompilerLanguageVersion.LatestMajor) return "latestmajor";
            if (version == CompilerLanguageVersion.Preview) return "preview";
            throw ExceptionUtilities.UnexpectedValue(version);
        }

        /// <summary>
        /// Try parse a <see cref="CompilerLanguageVersion"/> from a string input, returning default if input was null.
        /// </summary>
        public static bool TryParse(string version, out CompilerLanguageVersion result)
        {
            if (version == null)
            {
                result = CompilerLanguageVersion.Default;
                return true;
            }
            switch (CaseInsensitiveComparison.ToLower(version))
            {
                case "default":
                    result = CompilerLanguageVersion.Default;
                    return true;
                case "latest":
                    result = CompilerLanguageVersion.Latest;
                    return true;
                case "latestmajor":
                    result = CompilerLanguageVersion.LatestMajor;
                    return true;
                case "preview":
                    result = CompilerLanguageVersion.Preview;
                    return true;
                case "1":
                case "1.0":
                    result = CompilerLanguageVersion.Version1;
                    return true;
                default:
                    result = CompilerLanguageVersion.Default;
                    return false;
            }
        }

        /// <summary>
        /// Map a language version (such as Default, Latest, or VersionN) to a specific version (VersionM).
        /// </summary>
        internal static CompilerLanguageVersion MapSpecifiedToEffectiveVersion(this CompilerLanguageVersion version)
        {
            switch (version)
            {
                case CompilerLanguageVersion.Latest:
                case CompilerLanguageVersion.Default:
                case CompilerLanguageVersion.LatestMajor:
                    return CompilerLanguageVersion.Version1;
                default:
                    return version;
            }
        }

        public static CompilerLanguageVersion CurrentVersion => CompilerLanguageVersion.Version1;
    }

}
