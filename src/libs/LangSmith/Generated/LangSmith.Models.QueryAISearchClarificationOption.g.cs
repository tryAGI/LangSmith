
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class QueryAISearchClarificationOption
    {
        /// <summary>
        /// Filter expression for the query API's filter parameter. Omitted when there is none.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        public string? Filter { get; set; }

        /// <summary>
        /// Short description of this interpretation to show the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

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
        /// Query API this interpretation is planned for.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.QueryAISearchClarificationOptionScopeJsonConverter))]
        public global::LangSmith.QueryAISearchClarificationOptionScope? Scope { get; set; }

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
        /// Initializes a new instance of the <see cref="QueryAISearchClarificationOption" /> class.
        /// </summary>
        /// <param name="filter">
        /// Filter expression for the query API's filter parameter. Omitted when there is none.
        /// </param>
        /// <param name="label">
        /// Short description of this interpretation to show the user.
        /// </param>
        /// <param name="maxStartTime">
        /// Upper bound on start time (RFC 3339, UTC) for the query API's max_start_time parameter. Omitted when the search names no end; keep your own time range.
        /// </param>
        /// <param name="minStartTime">
        /// Lower bound on start time (RFC 3339, UTC) for the query API's min_start_time parameter. Omitted when the search names no start; keep your own time range.
        /// </param>
        /// <param name="scope">
        /// Query API this interpretation is planned for.
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
        public QueryAISearchClarificationOption(
            string? filter,
            string? label,
            global::System.DateTime? maxStartTime,
            global::System.DateTime? minStartTime,
            global::LangSmith.QueryAISearchClarificationOptionScope? scope,
            string? semFilter,
            string? threadFilter,
            string? traceFilter,
            string? treeFilter)
        {
            this.Filter = filter;
            this.Label = label;
            this.MaxStartTime = maxStartTime;
            this.MinStartTime = minStartTime;
            this.Scope = scope;
            this.SemFilter = semFilter;
            this.ThreadFilter = threadFilter;
            this.TraceFilter = traceFilter;
            this.TreeFilter = treeFilter;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryAISearchClarificationOption" /> class.
        /// </summary>
        public QueryAISearchClarificationOption()
        {
        }

    }
}