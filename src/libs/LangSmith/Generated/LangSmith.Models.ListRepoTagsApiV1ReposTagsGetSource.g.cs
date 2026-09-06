
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum ListRepoTagsApiV1ReposTagsGetSource
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
    public static class ListRepoTagsApiV1ReposTagsGetSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListRepoTagsApiV1ReposTagsGetSource value)
        {
            return value switch
            {
                ListRepoTagsApiV1ReposTagsGetSource.External => "external",
                ListRepoTagsApiV1ReposTagsGetSource.Internal => "internal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListRepoTagsApiV1ReposTagsGetSource? ToEnum(string value)
        {
            return value switch
            {
                "external" => ListRepoTagsApiV1ReposTagsGetSource.External,
                "internal" => ListRepoTagsApiV1ReposTagsGetSource.Internal,
                _ => null,
            };
        }
    }
}