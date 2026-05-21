
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ThreadsQueryThreadsRequestBody
    {
        /// <summary>
        /// `cursor` is the opaque string from a previous response's `next_cursor`. Omit on the first request; pass the returned cursor to fetch the next page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cursor")]
        public string? Cursor { get; set; }

        /// <summary>
        /// `filter` narrows which threads are returned, using a LangSmith filter expression evaluated against each thread's root run.<br/>
        /// For example: has(tags, "production") or eq(status, "error").<br/>
        /// See https://docs.langchain.com/langsmith/trace-query-syntax#filter-query-language for syntax.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        public string? Filter { get; set; }

        /// <summary>
        /// `max_start_time` is the inclusive upper bound on thread activity (RFC3339 date-time).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_start_time")]
        public global::System.DateTime? MaxStartTime { get; set; }

        /// <summary>
        /// `min_start_time` is the inclusive lower bound on thread activity (RFC3339 date-time).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_start_time")]
        public global::System.DateTime? MinStartTime { get; set; }

        /// <summary>
        /// `page_size` is the maximum number of threads to return in this response. Defaults to 20 when omitted; must be between 1 and 100 inclusive when set. The response may contain fewer threads than `page_size` even when `has_more` is true.<br/>
        /// Default Value: 20<br/>
        /// Example: 20
        /// </summary>
        /// <example>20</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_size")]
        public int? PageSize { get; set; }

        /// <summary>
        /// `project_id` is the tracing project UUID.<br/>
        /// Example: 0190a1b2-c3d4-7ef0-a5b6-6ea3a82e9328
        /// </summary>
        /// <example>0190a1b2-c3d4-7ef0-a5b6-6ea3a82e9328</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public global::System.Guid? ProjectId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreadsQueryThreadsRequestBody" /> class.
        /// </summary>
        /// <param name="cursor">
        /// `cursor` is the opaque string from a previous response's `next_cursor`. Omit on the first request; pass the returned cursor to fetch the next page.
        /// </param>
        /// <param name="filter">
        /// `filter` narrows which threads are returned, using a LangSmith filter expression evaluated against each thread's root run.<br/>
        /// For example: has(tags, "production") or eq(status, "error").<br/>
        /// See https://docs.langchain.com/langsmith/trace-query-syntax#filter-query-language for syntax.
        /// </param>
        /// <param name="maxStartTime">
        /// `max_start_time` is the inclusive upper bound on thread activity (RFC3339 date-time).
        /// </param>
        /// <param name="minStartTime">
        /// `min_start_time` is the inclusive lower bound on thread activity (RFC3339 date-time).
        /// </param>
        /// <param name="pageSize">
        /// `page_size` is the maximum number of threads to return in this response. Defaults to 20 when omitted; must be between 1 and 100 inclusive when set. The response may contain fewer threads than `page_size` even when `has_more` is true.<br/>
        /// Default Value: 20<br/>
        /// Example: 20
        /// </param>
        /// <param name="projectId">
        /// `project_id` is the tracing project UUID.<br/>
        /// Example: 0190a1b2-c3d4-7ef0-a5b6-6ea3a82e9328
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ThreadsQueryThreadsRequestBody(
            string? cursor,
            string? filter,
            global::System.DateTime? maxStartTime,
            global::System.DateTime? minStartTime,
            int? pageSize,
            global::System.Guid? projectId)
        {
            this.Cursor = cursor;
            this.Filter = filter;
            this.MaxStartTime = maxStartTime;
            this.MinStartTime = minStartTime;
            this.PageSize = pageSize;
            this.ProjectId = projectId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreadsQueryThreadsRequestBody" /> class.
        /// </summary>
        public ThreadsQueryThreadsRequestBody()
        {
        }

    }
}