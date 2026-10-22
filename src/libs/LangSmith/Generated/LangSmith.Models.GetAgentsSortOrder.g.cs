
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Default Value: desc
    /// </summary>
    public enum GetAgentsSortOrder
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
    public static class GetAgentsSortOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAgentsSortOrder value)
        {
            return value switch
            {
                GetAgentsSortOrder.Asc => "asc",
                GetAgentsSortOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAgentsSortOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => GetAgentsSortOrder.Asc,
                "desc" => GetAgentsSortOrder.Desc,
                _ => null,
            };
        }
    }
}