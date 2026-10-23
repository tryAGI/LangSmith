
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum RepohostProvider
    {
        /// <summary>
        ///
        /// </summary>
        GitHub,
        /// <summary>
        ///
        /// </summary>
        GitLab,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RepohostProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepohostProvider value)
        {
            return value switch
            {
                RepohostProvider.GitHub => "github",
                RepohostProvider.GitLab => "gitlab",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepohostProvider? ToEnum(string value)
        {
            return value switch
            {
                "github" => RepohostProvider.GitHub,
                "gitlab" => RepohostProvider.GitLab,
                _ => null,
            };
        }
    }
}