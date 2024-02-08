using MetaDslx.CodeAnalysis;
using Roslyn.Utilities;

#nullable enable

namespace MetaDslx.Languages.MetaSymbols.Compiler
{
    /// <summary>
    /// Specifies the language version.
    /// </summary>
    public enum SymbolLanguageVersion
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

    public static class SymbolLanguageVersionFacts
    {
        internal static bool IsValid(this SymbolLanguageVersion value)
        {
            switch (value)
            {
                case SymbolLanguageVersion.Version1:
                case SymbolLanguageVersion.Preview:
                    return true;
            }

            return false;
        }

        /// <summary>
        /// Displays the version number in the format expected on the command-line (/langver flag).
        /// For instance, "6", "7", "7.1", "latest".
        /// </summary>
        public static string ToDisplayString(this SymbolLanguageVersion version)
        {
            if (version == SymbolLanguageVersion.Version1) return "1";
            if (version == SymbolLanguageVersion.Default) return "default";
            if (version == SymbolLanguageVersion.Latest) return "latest";
            if (version == SymbolLanguageVersion.LatestMajor) return "latestmajor";
            if (version == SymbolLanguageVersion.Preview) return "preview";
            throw ExceptionUtilities.UnexpectedValue(version);
        }

        /// <summary>
        /// Try parse a <see cref="SymbolLanguageVersion"/> from a string input, returning default if input was null.
        /// </summary>
        public static bool TryParse(string version, out SymbolLanguageVersion result)
        {
            if (version == null)
            {
                result = SymbolLanguageVersion.Default;
                return true;
            }
            switch (CaseInsensitiveComparison.ToLower(version))
            {
                case "default":
                    result = SymbolLanguageVersion.Default;
                    return true;
                case "latest":
                    result = SymbolLanguageVersion.Latest;
                    return true;
                case "latestmajor":
                    result = SymbolLanguageVersion.LatestMajor;
                    return true;
                case "preview":
                    result = SymbolLanguageVersion.Preview;
                    return true;
                case "1":
                case "1.0":
                    result = SymbolLanguageVersion.Version1;
                    return true;
                default:
                    result = SymbolLanguageVersion.Default;
                    return false;
            }
        }

        /// <summary>
        /// Map a language version (such as Default, Latest, or VersionN) to a specific version (VersionM).
        /// </summary>
        internal static SymbolLanguageVersion MapSpecifiedToEffectiveVersion(this SymbolLanguageVersion version)
        {
            switch (version)
            {
                case SymbolLanguageVersion.Latest:
                case SymbolLanguageVersion.Default:
                case SymbolLanguageVersion.LatestMajor:
                    return SymbolLanguageVersion.Version1;
                default:
                    return version;
            }
        }

        public static SymbolLanguageVersion CurrentVersion => SymbolLanguageVersion.Version1;
    }

}
