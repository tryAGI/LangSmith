#nullable enable

namespace LangSmith
{
    public partial interface IRunsanalyticsClient
    {
        /// <summary>
        /// Query users in a tracing project<br/>
        /// GET with body payload — no resources created. Returns users ordered by their most recent matching finished root run, with cursor pagination. Costs and token usage aggregate the window's runs that carry the user's metadata.user_id. The activity window defaults to seven days and must not exceed 31 days. Continuation keeps a fixed activity window but does not provide a snapshot; concurrent activity changes can cause skipped or repeated users.<br/>
        /// Users whose statistics are not yet available have stats_status=pending and null trace_count and error_count. Query again to retrieve statistics; stats_status=ready means statistics were returned, but they may still lag recent activity. Other unavailable metrics are omitted. Backend query failures still return an error.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.RunsanalyticsQueryUsersResponse> QueryUsersInATracingProjectAsync(

            global::LangSmith.RunsanalyticsQueryUsersRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Query users in a tracing project<br/>
        /// GET with body payload — no resources created. Returns users ordered by their most recent matching finished root run, with cursor pagination. Costs and token usage aggregate the window's runs that carry the user's metadata.user_id. The activity window defaults to seven days and must not exceed 31 days. Continuation keeps a fixed activity window but does not provide a snapshot; concurrent activity changes can cause skipped or repeated users.<br/>
        /// Users whose statistics are not yet available have stats_status=pending and null trace_count and error_count. Query again to retrieve statistics; stats_status=ready means statistics were returned, but they may still lag recent activity. Other unavailable metrics are omitted. Backend query failures still return an error.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.RunsanalyticsQueryUsersResponse>> QueryUsersInATracingProjectAsResponseAsync(

            global::LangSmith.RunsanalyticsQueryUsersRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Query users in a tracing project<br/>
        /// GET with body payload — no resources created. Returns users ordered by their most recent matching finished root run, with cursor pagination. Costs and token usage aggregate the window's runs that carry the user's metadata.user_id. The activity window defaults to seven days and must not exceed 31 days. Continuation keeps a fixed activity window but does not provide a snapshot; concurrent activity changes can cause skipped or repeated users.<br/>
        /// Users whose statistics are not yet available have stats_status=pending and null trace_count and error_count. Query again to retrieve statistics; stats_status=ready means statistics were returned, but they may still lag recent activity. Other unavailable metrics are omitted. Backend query failures still return an error.
        /// </summary>
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
        /// <param name="projectId">
        /// ProjectID identifies the tracing project whose users to query.
        /// </param>
        /// <param name="statsWaitMs">
        /// StatsWaitMs limits how long the request waits for user statistics. When the limit<br/>
        /// passes, users are returned with stats_status=pending; fetch their statistics with<br/>
        /// /v2/runs/users/stats. Omit to wait for statistics until the request deadline.
        /// </param>
        /// <param name="traceFilter">
        /// TraceFilter restricts the traces used to discover users and compute their statistics. Project and trace access restrictions always apply.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.RunsanalyticsQueryUsersResponse> QueryUsersInATracingProjectAsync(
            global::System.Guid projectId,
            string? cursor = default,
            string? filter = default,
            global::System.DateTime? maxStartTime = default,
            global::System.DateTime? minStartTime = default,
            int? pageSize = default,
            int? statsWaitMs = default,
            string? traceFilter = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}