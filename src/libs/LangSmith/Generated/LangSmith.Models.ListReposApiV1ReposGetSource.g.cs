
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum ListReposApiV1ReposGetSource
    {
        /// <summary>
        ///
        /// </summary>
        External,
        /// <summary>
        ///
        /// </summary>
        Internal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListReposApiV1ReposGetSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListReposApiV1ReposGetSource value)
        {
            return value switch
            {
                ListReposApiV1ReposGetSource.External => "external",
                ListReposApiV1ReposGetSource.Internal => "internal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListReposApiV1ReposGetSource? ToEnum(string value)
        {
            return value switch
            {
                "external" => ListReposApiV1ReposGetSource.External,
                "internal" => ListReposApiV1ReposGetSource.Internal,
                _ => null,
            };
        }
    }
}