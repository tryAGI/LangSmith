#nullable enable

namespace LangSmith
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Get Granular Usage<br/>
        /// Get granular usage data with flexible grouping.<br/>
        /// `kind` selects the billable usage domain:<br/>
        /// - `traces` (default): trace counts.<br/>
        /// - `langsmith_deployments`: LangSmith Deployment metrics (nodes<br/>
        ///   executed, agent runs, agent uptime). The three Deployment fields<br/>
        ///   are populated and `traces` is `0`.<br/>
        /// `trace_tier` (only meaningful for `kind=traces`) optionally restricts<br/>
        /// results to a single retention tier (longlived = extended retention,<br/>
        /// shortlived = standard retention). When `group_by=trace_tier`, results<br/>
        /// are split into one record per retention tier per time bucket.<br/>
        /// `workspace_ids` filters results to the specified workspaces. Only<br/>
        /// workspaces the user has read access to are included.
        /// </summary>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="workspaceIds"></param>
        /// <param name="groupBy">
        /// Dimensions for grouping granular usage data.<br/>
        /// Default Value: workspace
        /// </param>
        /// <param name="kind">
        /// Which billable usage domain a granular-usage query targets.<br/>
        /// - `traces`: trace counts.<br/>
        /// - `langsmith_deployments`: LangSmith Deployment metrics (nodes executed,<br/>
        ///   agent runs, agent uptime).<br/>
        /// Default is `traces` for backward compatibility — existing callers of<br/>
        /// `GET /granular-usage` without a `kind` query param get the same<br/>
        /// response shape they always did.<br/>
        /// Default Value: traces
        /// </param>
        /// <param name="traceTier"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.GranularUsageResponse> GetGranularUsageAsync(
            global::System.DateTime startTime,
            global::System.DateTime endTime,
            global::System.Collections.Generic.IList<global::System.Guid> workspaceIds,
            global::LangSmith.GranularUsageGroupBy? groupBy = default,
            global::LangSmith.GranularUsageKind? kind = default,
            global::LangSmith.TraceTier? traceTier = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Granular Usage<br/>
        /// Get granular usage data with flexible grouping.<br/>
        /// `kind` selects the billable usage domain:<br/>
        /// - `traces` (default): trace counts.<br/>
        /// - `langsmith_deployments`: LangSmith Deployment metrics (nodes<br/>
        ///   executed, agent runs, agent uptime). The three Deployment fields<br/>
        ///   are populated and `traces` is `0`.<br/>
        /// `trace_tier` (only meaningful for `kind=traces`) optionally restricts<br/>
        /// results to a single retention tier (longlived = extended retention,<br/>
        /// shortlived = standard retention). When `group_by=trace_tier`, results<br/>
        /// are split into one record per retention tier per time bucket.<br/>
        /// `workspace_ids` filters results to the specified workspaces. Only<br/>
        /// workspaces the user has read access to are included.
        /// </summary>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="workspaceIds"></param>
        /// <param name="groupBy">
        /// Dimensions for grouping granular usage data.<br/>
        /// Default Value: workspace
        /// </param>
        /// <param name="kind">
        /// Which billable usage domain a granular-usage query targets.<br/>
        /// - `traces`: trace counts.<br/>
        /// - `langsmith_deployments`: LangSmith Deployment metrics (nodes executed,<br/>
        ///   agent runs, agent uptime).<br/>
        /// Default is `traces` for backward compatibility — existing callers of<br/>
        /// `GET /granular-usage` without a `kind` query param get the same<br/>
        /// response shape they always did.<br/>
        /// Default Value: traces
        /// </param>
        /// <param name="traceTier"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.GranularUsageResponse>> GetGranularUsageAsResponseAsync(
            global::System.DateTime startTime,
            global::System.DateTime endTime,
            global::System.Collections.Generic.IList<global::System.Guid> workspaceIds,
            global::LangSmith.GranularUsageGroupBy? groupBy = default,
            global::LangSmith.GranularUsageKind? kind = default,
            global::LangSmith.TraceTier? traceTier = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}