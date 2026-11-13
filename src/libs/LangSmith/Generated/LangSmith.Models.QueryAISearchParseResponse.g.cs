
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class QueryAISearchParseResponse
    {
        /// <summary>
        /// Interpretations to choose from. Returned only when allow_clarification is true and the search is ambiguous; no other fields are set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clarification")]
        public global::LangSmith.QueryAISearchClarification? Clarification { get; set; }

        /// <summary>
        /// Filter expression for the query API's filter parameter. Omitted when there is none.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        public string? Filter { get; set; }

        /// <summary>
        /// Upper bound on start time (RFC 3339, UTC) for the query API's max_start_time parameter. Omitted when the search names no end; keep your own time range.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_start_time")]
        public global::System.DateTime? MaxStartTime { get; set; }

        /// <summary>
        /// Lower bound on start time (RFC 3339, UTC) for the query API's min_start_time parameter. Omitted when the search names no start; keep your own time range.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_start_time")]
        public global::System.DateTime? MinStartTime { get; set; }

        /// <summary>
        /// Query API to send the plan to: runs, traces or threads.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.QueryAISearchParseResponseScopeJsonConverter))]
        public global::LangSmith.QueryAISearchParseResponseScope? Scope { get; set; }

        /// <summary>
        /// Plain-language criterion for the query API's sem_filter parameter, matched against conversation messages. Null when the search has no conversational criterion.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sem_filter")]
        public string? SemFilter { get; set; }

        /// <summary>
        /// Filter expression for the threads query API's thread_filter parameter. Omitted when there is none.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thread_filter")]
        public string? ThreadFilter { get; set; }

        /// <summary>
        /// Filter expression for the query API's trace_filter parameter. Omitted when there is none.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace_filter")]
        public string? TraceFilter { get; set; }

        /// <summary>
        /// Filter expression for the query API's tree_filter parameter. Omitted when there is none.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tree_filter")]
        public string? TreeFilter { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryAISearchParseResponse" /> class.
        /// </summary>
        /// <param name="clarification">
        /// Interpretations to choose from. Returned only when allow_clarification is true and the search is ambiguous; no other fields are set.
        /// </param>
        /// <param name="filter">
        /// Filter expression for the query API's filter parameter. Omitted when there is none.
        /// </param>
        /// <param name="maxStartTime">
        /// Upper bound on start time (RFC 3339, UTC) for the query API's max_start_time parameter. Omitted when the search names no end; keep your own time range.
        /// </param>
        /// <param name="minStartTime">
        /// Lower bound on start time (RFC 3339, UTC) for the query API's min_start_time parameter. Omitted when the search names no start; keep your own time range.
        /// </param>
        /// <param name="scope">
        /// Query API to send the plan to: runs, traces or threads.
        /// </param>
        /// <param name="semFilter">
        /// Plain-language criterion for the query API's sem_filter parameter, matched against conversation messages. Null when the search has no conversational criterion.
        /// </param>
        /// <param name="threadFilter">
        /// Filter expression for the threads query API's thread_filter parameter. Omitted when there is none.
        /// </param>
        /// <param name="traceFilter">
        /// Filter expression for the query API's trace_filter parameter. Omitted when there is none.
        /// </param>
        /// <param name="treeFilter">
        /// Filter expression for the query API's tree_filter parameter. Omitted when there is none.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueryAISearchParseResponse(
            global::LangSmith.QueryAISearchClarification? clarification,
            string? filter,
            global::System.DateTime? maxStartTime,
            global::System.DateTime? minStartTime,
            global::LangSmith.QueryAISearchParseResponseScope? scope,
            string? semFilter,
            string? threadFilter,
            string? traceFilter,
            string? treeFilter)
        {
            this.Clarification = clarification;
            this.Filter = filter;
            this.MaxStartTime = maxStartTime;
            this.MinStartTime = minStartTime;
            this.Scope = scope;
            this.SemFilter = semFilter;
            this.ThreadFilter = threadFilter;
            this.TraceFilter = traceFilter;
            this.TreeFilter = treeFilter;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryAISearchParseResponse" /> class.
        /// </summary>
        public QueryAISearchParseResponse()
        {
        }

    }
}