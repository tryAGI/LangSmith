
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Default Value: desc
    /// </summary>
    public enum GetDatasetsSortOrder
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
    public static class GetDatasetsSortOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDatasetsSortOrder value)
        {
            return value switch
            {
                GetDatasetsSortOrder.Asc => "asc",
                GetDatasetsSortOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDatasetsSortOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => GetDatasetsSortOrder.Asc,
                "desc" => GetDatasetsSortOrder.Desc,
                _ => null,
            };
        }
    }
}