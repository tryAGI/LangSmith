
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Default Value: desc
    /// </summary>
    public enum GetFleetAgentsSortOrder
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
    public static class GetFleetAgentsSortOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetFleetAgentsSortOrder value)
        {
            return value switch
            {
                GetFleetAgentsSortOrder.Asc => "asc",
                GetFleetAgentsSortOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetFleetAgentsSortOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => GetFleetAgentsSortOrder.Asc,
                "desc" => GetFleetAgentsSortOrder.Desc,
                _ => null,
            };
        }
    }
}