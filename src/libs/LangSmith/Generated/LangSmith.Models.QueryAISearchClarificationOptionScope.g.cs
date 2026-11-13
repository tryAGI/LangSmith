
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Query API this interpretation is planned for.
    /// </summary>
    public enum QueryAISearchClarificationOptionScope
    {
        /// <summary>
        ///
        /// </summary>
        Runs,
        /// <summary>
        ///
        /// </summary>
        Threads,
        /// <summary>
        ///
        /// </summary>
        Traces,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class QueryAISearchClarificationOptionScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this QueryAISearchClarificationOptionScope value)
        {
            return value switch
            {
                QueryAISearchClarificationOptionScope.Runs => "runs",
                QueryAISearchClarificationOptionScope.Threads => "threads",
                QueryAISearchClarificationOptionScope.Traces => "traces",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static QueryAISearchClarificationOptionScope? ToEnum(string value)
        {
            return value switch
            {
                "runs" => QueryAISearchClarificationOptionScope.Runs,
                "threads" => QueryAISearchClarificationOptionScope.Threads,
                "traces" => QueryAISearchClarificationOptionScope.Traces,
                _ => null,
            };
        }
    }
}