
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum QuerySortOrder
    {
        /// <summary>
        /// 
        /// </summary>
        SortOrderAsc,
        /// <summary>
        /// 
        /// </summary>
        SortOrderDesc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class QuerySortOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this QuerySortOrder value)
        {
            return value switch
            {
                QuerySortOrder.SortOrderAsc => "ASC",
                QuerySortOrder.SortOrderDesc => "DESC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static QuerySortOrder? ToEnum(string value)
        {
            return value switch
            {
                "ASC" => QuerySortOrder.SortOrderAsc,
                "DESC" => QuerySortOrder.SortOrderDesc,
                _ => null,
            };
        }
    }
}