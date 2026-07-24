#nullable enable

namespace LangSmith
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Export Granular Usage Csv<br/>
        /// Export granular usage data as CSV.<br/>
        /// Same `kind` semantics as `/granular-usage`. The CSV's value columns<br/>
        /// vary by kind:<br/>
        /// - `traces`: single `Traces` column.<br/>
        /// - `langsmith_deployments`: `Nodes Executed`, `Agent Runs`,<br/>
        ///   `Agent Uptime (seconds)` columns.<br/>
        /// Dimension columns are identical across kinds.
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
        global::System.Threading.Tasks.Task<string> ExportGranularUsageCsvAsync(
            global::System.DateTime startTime,
            global::System.DateTime endTime,
            global::System.Collections.Generic.IList<global::System.Guid> workspaceIds,
            global::LangSmith.GranularUsageGroupBy? groupBy = default,
            global::LangSmith.GranularUsageKind? kind = default,
            global::LangSmith.TraceTier? traceTier = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Export Granular Usage Csv<br/>
        /// Export granular usage data as CSV.<br/>
        /// Same `kind` semantics as `/granular-usage`. The CSV's value columns<br/>
        /// vary by kind:<br/>
        /// - `traces`: single `Traces` column.<br/>
        /// - `langsmith_deployments`: `Nodes Executed`, `Agent Runs`,<br/>
        ///   `Agent Uptime (seconds)` columns.<br/>
        /// Dimension columns are identical across kinds.
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
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<string>> ExportGranularUsageCsvAsResponseAsync(
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