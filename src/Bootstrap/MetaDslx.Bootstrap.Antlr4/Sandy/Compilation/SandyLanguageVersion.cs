using MetaDslx.CodeAnalysis;
using Roslyn.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Bootstrap.Antlr4.Sandy
{
    /// <summary>
    /// Specifies the language version.
    /// </summary>
    public enum SandyLanguageVersion
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

    public static class SandyLanguageVersionFacts
    {
        internal static bool IsValid(this SandyLanguageVersion value)
        {
            switch (value)
            {
                case SandyLanguageVersion.Version1:
                case SandyLanguageVersion.Preview:
                    return true;
            }

            return false;
        }

        /// <summary>
        /// Displays the version number in the format expected on the command-line (/langver flag).
        /// For instance, "6", "7", "7.1", "latest".
        /// </summary>
        public static string ToDisplayString(this SandyLanguageVersion version)
        {
            if (version == SandyLanguageVersion.Version1) return "1";
            if (version == SandyLanguageVersion.Default) return "default";
            if (version == SandyLanguageVersion.Latest) return "latest";
            if (version == SandyLanguageVersion.LatestMajor) return "latestmajor";
            if (version == SandyLanguageVersion.Preview) return "preview";
            throw ExceptionUtilities.UnexpectedValue(version);
        }

        /// <summary>
        /// Try parse a <see cref="SandyLanguageVersion"/> from a string input, returning default if input was null.
        /// </summary>
        public static bool TryParse(string version, out SandyLanguageVersion result)
        {
            if (version == null)
            {
                result = SandyLanguageVersion.Default;
                return true;
            }
            switch (CaseInsensitiveComparison.ToLower(version))
            {
                case "default":
                    result = SandyLanguageVersion.Default;
                    return true;
                case "latest":
                    result = SandyLanguageVersion.Latest;
                    return true;
                case "latestmajor":
                    result = SandyLanguageVersion.LatestMajor;
                    return true;
                case "preview":
                    result = SandyLanguageVersion.Preview;
                    return true;
                case "1":
                case "1.0":
                    result = SandyLanguageVersion.Version1;
                    return true;
                default:
                    result = SandyLanguageVersion.Default;
                    return false;
            }
        }

        /// <summary>
        /// Map a language version (such as Default, Latest, or VersionN) to a specific version (VersionM).
        /// </summary>
        internal static SandyLanguageVersion MapSpecifiedToEffectiveVersion(this SandyLanguageVersion version)
        {
            switch (version)
            {
                case SandyLanguageVersion.Latest:
                case SandyLanguageVersion.Default:
                case SandyLanguageVersion.LatestMajor:
                    return SandyLanguageVersion.Version1;
                default:
                    return version;
            }
        }

        public static SandyLanguageVersion CurrentVersion => SandyLanguageVersion.Version1;
    }

}
