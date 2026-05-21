
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListRepoTagsApiV1ReposTagsGetSource2
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
    public static class ListRepoTagsApiV1ReposTagsGetSource2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListRepoTagsApiV1ReposTagsGetSource2 value)
        {
            return value switch
            {
                ListRepoTagsApiV1ReposTagsGetSource2.External => "external",
                ListRepoTagsApiV1ReposTagsGetSource2.Internal => "internal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListRepoTagsApiV1ReposTagsGetSource2? ToEnum(string value)
        {
            return value switch
            {
                "external" => ListRepoTagsApiV1ReposTagsGetSource2.External,
                "internal" => ListRepoTagsApiV1ReposTagsGetSource2.Internal,
                _ => null,
            };
        }
    }
}