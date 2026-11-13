
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Query API to plan for: runs, traces or threads. When omitted, it is inferred from the search and defaults to traces.
    /// </summary>
    public enum QueryAISearchParseRequestBodyScope
    {
        /// <summary>
        /// runs, traces or threads. When omitted, it is inferred from the search and defaults to traces.
        /// </summary>
        Runs,
        /// <summary>
        /// runs, traces or threads. When omitted, it is inferred from the search and defaults to traces.
        /// </summary>
        Threads,
        /// <summary>
        /// runs, traces or threads. When omitted, it is inferred from the search and defaults to traces.
        /// </summary>
        Traces,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class QueryAISearchParseRequestBodyScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this QueryAISearchParseRequestBodyScope value)
        {
            return value switch
            {
                QueryAISearchParseRequestBodyScope.Runs => "runs",
                QueryAISearchParseRequestBodyScope.Threads => "threads",
                QueryAISearchParseRequestBodyScope.Traces => "traces",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static QueryAISearchParseRequestBodyScope? ToEnum(string value)
        {
            return value switch
            {
                "runs" => QueryAISearchParseRequestBodyScope.Runs,
                "threads" => QueryAISearchParseRequestBodyScope.Threads,
                "traces" => QueryAISearchParseRequestBodyScope.Traces,
                _ => null,
            };
        }
    }
}