
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Default Value: desc
    /// </summary>
    public enum GetFleetUsageUsersSortOrder
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
    public static class GetFleetUsageUsersSortOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetFleetUsageUsersSortOrder value)
        {
            return value switch
            {
                GetFleetUsageUsersSortOrder.Asc => "asc",
                GetFleetUsageUsersSortOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetFleetUsageUsersSortOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => GetFleetUsageUsersSortOrder.Asc,
                "desc" => GetFleetUsageUsersSortOrder.Desc,
                _ => null,
            };
        }
    }
}