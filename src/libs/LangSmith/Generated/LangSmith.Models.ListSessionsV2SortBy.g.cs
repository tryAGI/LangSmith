
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Default Value: START_TIME
    /// </summary>
    public enum ListSessionsV2SortBy
    {
        /// <summary>
        ///
        /// </summary>
        ErrorRate,
        /// <summary>
        ///
        /// </summary>
        Feedback,
        /// <summary>
        ///
        /// </summary>
        LastRunStartTime,
        /// <summary>
        ///
        /// </summary>
        LatencyP50,
        /// <summary>
        ///
        /// </summary>
        LatencyP99,
        /// <summary>
        ///
        /// </summary>
        Name,
        /// <summary>
        ///
        /// </summary>
        StartTime,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListSessionsV2SortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListSessionsV2SortBy value)
        {
            return value switch
            {
                ListSessionsV2SortBy.ErrorRate => "ERROR_RATE",
                ListSessionsV2SortBy.Feedback => "FEEDBACK",
                ListSessionsV2SortBy.LastRunStartTime => "LAST_RUN_START_TIME",
                ListSessionsV2SortBy.LatencyP50 => "LATENCY_P50",
                ListSessionsV2SortBy.LatencyP99 => "LATENCY_P99",
                ListSessionsV2SortBy.Name => "NAME",
                ListSessionsV2SortBy.StartTime => "START_TIME",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListSessionsV2SortBy? ToEnum(string value)
        {
            return value switch
            {
                "ERROR_RATE" => ListSessionsV2SortBy.ErrorRate,
                "FEEDBACK" => ListSessionsV2SortBy.Feedback,
                "LAST_RUN_START_TIME" => ListSessionsV2SortBy.LastRunStartTime,
                "LATENCY_P50" => ListSessionsV2SortBy.LatencyP50,
                "LATENCY_P99" => ListSessionsV2SortBy.LatencyP99,
                "NAME" => ListSessionsV2SortBy.Name,
                "START_TIME" => ListSessionsV2SortBy.StartTime,
                _ => null,
            };
        }
    }
}