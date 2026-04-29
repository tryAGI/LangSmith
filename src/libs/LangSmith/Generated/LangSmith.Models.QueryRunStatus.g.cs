
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum QueryRunStatus
    {
        /// <summary>
        /// 
        /// </summary>
        RunStatusError,
        /// <summary>
        /// 
        /// </summary>
        RunStatusPending,
        /// <summary>
        /// 
        /// </summary>
        RunStatusSuccess,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class QueryRunStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this QueryRunStatus value)
        {
            return value switch
            {
                QueryRunStatus.RunStatusError => "ERROR",
                QueryRunStatus.RunStatusPending => "PENDING",
                QueryRunStatus.RunStatusSuccess => "SUCCESS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static QueryRunStatus? ToEnum(string value)
        {
            return value switch
            {
                "ERROR" => QueryRunStatus.RunStatusError,
                "PENDING" => QueryRunStatus.RunStatusPending,
                "SUCCESS" => QueryRunStatus.RunStatusSuccess,
                _ => null,
            };
        }
    }
}