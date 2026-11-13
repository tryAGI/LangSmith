
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Query API to send the plan to: runs, traces or threads.
    /// </summary>
    public enum QueryAISearchParseResponseScope
    {
        /// <summary>
        /// runs, traces or threads.
        /// </summary>
        Runs,
        /// <summary>
        /// runs, traces or threads.
        /// </summary>
        Threads,
        /// <summary>
        /// runs, traces or threads.
        /// </summary>
        Traces,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class QueryAISearchParseResponseScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this QueryAISearchParseResponseScope value)
        {
            return value switch
            {
                QueryAISearchParseResponseScope.Runs => "runs",
                QueryAISearchParseResponseScope.Threads => "threads",
                QueryAISearchParseResponseScope.Traces => "traces",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static QueryAISearchParseResponseScope? ToEnum(string value)
        {
            return value switch
            {
                "runs" => QueryAISearchParseResponseScope.Runs,
                "threads" => QueryAISearchParseResponseScope.Threads,
                "traces" => QueryAISearchParseResponseScope.Traces,
                _ => null,
            };
        }
    }
}