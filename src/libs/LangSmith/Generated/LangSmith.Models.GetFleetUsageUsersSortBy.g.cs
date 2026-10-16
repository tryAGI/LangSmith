
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Default Value: cost
    /// </summary>
    public enum GetFleetUsageUsersSortBy
    {
        /// <summary>
        ///
        /// </summary>
        AgentCount,
        /// <summary>
        ///
        /// </summary>
        Cost,
        /// <summary>
        ///
        /// </summary>
        FirstUsed,
        /// <summary>
        ///
        /// </summary>
        LastUsed,
        /// <summary>
        ///
        /// </summary>
        Runs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetFleetUsageUsersSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetFleetUsageUsersSortBy value)
        {
            return value switch
            {
                GetFleetUsageUsersSortBy.AgentCount => "agent_count",
                GetFleetUsageUsersSortBy.Cost => "cost",
                GetFleetUsageUsersSortBy.FirstUsed => "first_used",
                GetFleetUsageUsersSortBy.LastUsed => "last_used",
                GetFleetUsageUsersSortBy.Runs => "runs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetFleetUsageUsersSortBy? ToEnum(string value)
        {
            return value switch
            {
                "agent_count" => GetFleetUsageUsersSortBy.AgentCount,
                "cost" => GetFleetUsageUsersSortBy.Cost,
                "first_used" => GetFleetUsageUsersSortBy.FirstUsed,
                "last_used" => GetFleetUsageUsersSortBy.LastUsed,
                "runs" => GetFleetUsageUsersSortBy.Runs,
                _ => null,
            };
        }
    }
}