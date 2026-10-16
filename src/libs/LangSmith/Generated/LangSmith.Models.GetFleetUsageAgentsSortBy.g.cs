
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Default Value: cost
    /// </summary>
    public enum GetFleetUsageAgentsSortBy
    {
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
    public static class GetFleetUsageAgentsSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetFleetUsageAgentsSortBy value)
        {
            return value switch
            {
                GetFleetUsageAgentsSortBy.Cost => "cost",
                GetFleetUsageAgentsSortBy.FirstUsed => "first_used",
                GetFleetUsageAgentsSortBy.LastUsed => "last_used",
                GetFleetUsageAgentsSortBy.Runs => "runs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetFleetUsageAgentsSortBy? ToEnum(string value)
        {
            return value switch
            {
                "cost" => GetFleetUsageAgentsSortBy.Cost,
                "first_used" => GetFleetUsageAgentsSortBy.FirstUsed,
                "last_used" => GetFleetUsageAgentsSortBy.LastUsed,
                "runs" => GetFleetUsageAgentsSortBy.Runs,
                _ => null,
            };
        }
    }
}