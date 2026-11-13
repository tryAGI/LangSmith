
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class QueryAISearchParseRequestBody
    {
        /// <summary>
        /// Natural-language description of the runs, traces or threads to find, at most 2000 UTF-8 bytes.<br/>
        /// Example: threads where the agent did not complete the task and spent more than $1
        /// </summary>
        /// <example>threads where the agent did not complete the task and spent more than $1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("ai_search")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AiSearch { get; set; }

        /// <summary>
        /// When true, an ambiguous search returns clarification options instead of a single plan. Defaults to false.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_clarification")]
        public bool? AllowClarification { get; set; }

        /// <summary>
        /// Tracing project UUIDs used to interpret the search. Send the same projects to the query API.<br/>
        /// Example: [018e4c7e-a9fb-7ef0-a5b6-6ea3a82e9327]
        /// </summary>
        /// <example>[018e4c7e-a9fb-7ef0-a5b6-6ea3a82e9327]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Guid> ProjectIds { get; set; }

        /// <summary>
        /// Query API to plan for: runs, traces or threads. When omitted, it is inferred from the search and defaults to traces.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.QueryAISearchParseRequestBodyScopeJsonConverter))]
        public global::LangSmith.QueryAISearchParseRequestBodyScope? Scope { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryAISearchParseRequestBody" /> class.
        /// </summary>
        /// <param name="aiSearch">
        /// Natural-language description of the runs, traces or threads to find, at most 2000 UTF-8 bytes.<br/>
        /// Example: threads where the agent did not complete the task and spent more than $1
        /// </param>
        /// <param name="projectIds">
        /// Tracing project UUIDs used to interpret the search. Send the same projects to the query API.<br/>
        /// Example: [018e4c7e-a9fb-7ef0-a5b6-6ea3a82e9327]
        /// </param>
        /// <param name="allowClarification">
        /// When true, an ambiguous search returns clarification options instead of a single plan. Defaults to false.
        /// </param>
        /// <param name="scope">
        /// Query API to plan for: runs, traces or threads. When omitted, it is inferred from the search and defaults to traces.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueryAISearchParseRequestBody(
            string aiSearch,
            global::System.Collections.Generic.IList<global::System.Guid> projectIds,
            bool? allowClarification,
            global::LangSmith.QueryAISearchParseRequestBodyScope? scope)
        {
            this.AiSearch = aiSearch ?? throw new global::System.ArgumentNullException(nameof(aiSearch));
            this.AllowClarification = allowClarification;
            this.ProjectIds = projectIds ?? throw new global::System.ArgumentNullException(nameof(projectIds));
            this.Scope = scope;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryAISearchParseRequestBody" /> class.
        /// </summary>
        public QueryAISearchParseRequestBody()
        {
        }

    }
}