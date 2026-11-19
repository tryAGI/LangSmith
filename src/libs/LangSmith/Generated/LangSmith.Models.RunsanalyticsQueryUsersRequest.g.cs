
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RunsanalyticsQueryUsersRequest
    {
        /// <summary>
        /// Cursor continues recent-user discovery with state independent of the number of users already returned.<br/>
        /// The activity window stays fixed, but changes to matching activity can cause skipped or repeated users.<br/>
        /// Maximum encoded length is 65536 bytes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cursor")]
        public string? Cursor { get; set; }

        /// <summary>
        /// Filter narrows which completed root runs count toward a user, using a LangSmith filter expression evaluated<br/>
        /// against each root run; users with no matching root run are not returned. For example: eq(status, "error").<br/>
        /// See https://docs.langchain.com/langsmith/trace-query-syntax#filter-query-language for syntax.<br/>
        /// Example: eq(status, "error")
        /// </summary>
        /// <example>eq(status, "error")</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        public string? Filter { get; set; }

        /// <summary>
        /// MaxStartTime is an exclusive upper bound on root start time; defaults to the current time on the first page. Continuation preserves the original window.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_start_time")]
        public global::System.DateTime? MaxStartTime { get; set; }

        /// <summary>
        /// MinStartTime is an inclusive lower bound on root start time; defaults to seven days before max_start_time. The window must not exceed 31 days.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_start_time")]
        public global::System.DateTime? MinStartTime { get; set; }

        /// <summary>
        /// Limit sets the page size. Changing it preserves the cursor's position and activity window.<br/>
        /// Default Value: 20
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_size")]
        public int? PageSize { get; set; }

        /// <summary>
        /// ProjectID identifies the tracing project whose users to query.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ProjectId { get; set; }

        /// <summary>
        /// StatsWaitMs limits how long the request waits for user statistics. When the limit<br/>
        /// passes, users are returned with stats_status=pending; fetch their statistics with<br/>
        /// /v2/runs/users/stats. Omit to wait for statistics until the request deadline.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stats_wait_ms")]
        public int? StatsWaitMs { get; set; }

        /// <summary>
        /// TraceFilter restricts the traces used to discover users and compute their statistics. Project and trace access restrictions always apply.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace_filter")]
        public string? TraceFilter { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunsanalyticsQueryUsersRequest" /> class.
        /// </summary>
        /// <param name="projectId">
        /// ProjectID identifies the tracing project whose users to query.
        /// </param>
        /// <param name="cursor">
        /// Cursor continues recent-user discovery with state independent of the number of users already returned.<br/>
        /// The activity window stays fixed, but changes to matching activity can cause skipped or repeated users.<br/>
        /// Maximum encoded length is 65536 bytes.
        /// </param>
        /// <param name="filter">
        /// Filter narrows which completed root runs count toward a user, using a LangSmith filter expression evaluated<br/>
        /// against each root run; users with no matching root run are not returned. For example: eq(status, "error").<br/>
        /// See https://docs.langchain.com/langsmith/trace-query-syntax#filter-query-language for syntax.<br/>
        /// Example: eq(status, "error")
        /// </param>
        /// <param name="maxStartTime">
        /// MaxStartTime is an exclusive upper bound on root start time; defaults to the current time on the first page. Continuation preserves the original window.
        /// </param>
        /// <param name="minStartTime">
        /// MinStartTime is an inclusive lower bound on root start time; defaults to seven days before max_start_time. The window must not exceed 31 days.
        /// </param>
        /// <param name="pageSize">
        /// Limit sets the page size. Changing it preserves the cursor's position and activity window.<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="statsWaitMs">
        /// StatsWaitMs limits how long the request waits for user statistics. When the limit<br/>
        /// passes, users are returned with stats_status=pending; fetch their statistics with<br/>
        /// /v2/runs/users/stats. Omit to wait for statistics until the request deadline.
        /// </param>
        /// <param name="traceFilter">
        /// TraceFilter restricts the traces used to discover users and compute their statistics. Project and trace access restrictions always apply.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunsanalyticsQueryUsersRequest(
            global::System.Guid projectId,
            string? cursor,
            string? filter,
            global::System.DateTime? maxStartTime,
            global::System.DateTime? minStartTime,
            int? pageSize,
            int? statsWaitMs,
            string? traceFilter)
        {
            this.Cursor = cursor;
            this.Filter = filter;
            this.MaxStartTime = maxStartTime;
            this.MinStartTime = minStartTime;
            this.PageSize = pageSize;
            this.ProjectId = projectId;
            this.StatsWaitMs = statsWaitMs;
            this.TraceFilter = traceFilter;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunsanalyticsQueryUsersRequest" /> class.
        /// </summary>
        public RunsanalyticsQueryUsersRequest()
        {
        }

    }
}