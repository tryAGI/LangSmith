
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Default Value: last_run_start_time
    /// </summary>
    public enum GetAgentsSortBy
    {
        /// <summary>
        ///
        /// </summary>
        CreatedAt,
        /// <summary>
        ///
        /// </summary>
        LastRunStartTime,
        /// <summary>
        ///
        /// </summary>
        Name,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAgentsSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAgentsSortBy value)
        {
            return value switch
            {
                GetAgentsSortBy.CreatedAt => "created_at",
                GetAgentsSortBy.LastRunStartTime => "last_run_start_time",
                GetAgentsSortBy.Name => "name",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAgentsSortBy? ToEnum(string value)
        {
            return value switch
            {
                "created_at" => GetAgentsSortBy.CreatedAt,
                "last_run_start_time" => GetAgentsSortBy.LastRunStartTime,
                "name" => GetAgentsSortBy.Name,
                _ => null,
            };
        }
    }
}