
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Default Value: desc
    /// </summary>
    public enum ListSessionsV2SortOrder
    {
        /// <summary>
        ///
        /// </summary>
        Asc,
        /// <summary>
        ///
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListSessionsV2SortOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListSessionsV2SortOrder value)
        {
            return value switch
            {
                ListSessionsV2SortOrder.Asc => "asc",
                ListSessionsV2SortOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListSessionsV2SortOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ListSessionsV2SortOrder.Asc,
                "desc" => ListSessionsV2SortOrder.Desc,
                _ => null,
            };
        }
    }
}