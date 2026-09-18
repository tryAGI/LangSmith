#nullable enable

namespace LangSmith
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// List hourly sandbox usage costs<br/>
        /// Returns priced usage per sandbox or snapshot and UTC hour in the half-open requested interval. LCU uses the recorded compute amount for sandboxes; snapshots have zero LCU. LSU allocates the recorded workspace storage amount proportionally to attributed bytes, including checkpoints on their sandbox and snapshots as separate resources. Resource filters preserve each resource's share. Rate changes do not reprice recorded amounts. An access-filtered page can have no items and a non-null next_cursor; continue until next_cursor is null.
        /// </summary>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="resourceType"></param>
        /// <param name="resourceIds"></param>
        /// <param name="pageSize">
        /// Default Value: 20
        /// </param>
        /// <param name="granularity">
        /// Default Value: HOUR
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.SandboxesSandboxUsageCostsResponse> ListHourlySandboxUsageCostsAsync(
            global::System.DateTime startTime,
            global::System.DateTime endTime,
            global::LangSmith.GetSandboxesUsageCostsResourceType? resourceType = default,
            global::System.Collections.Generic.IList<string>? resourceIds = default,
            int? pageSize = default,
            global::LangSmith.GetSandboxesUsageCostsGranularity? granularity = default,
            string? cursor = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List hourly sandbox usage costs<br/>
        /// Returns priced usage per sandbox or snapshot and UTC hour in the half-open requested interval. LCU uses the recorded compute amount for sandboxes; snapshots have zero LCU. LSU allocates the recorded workspace storage amount proportionally to attributed bytes, including checkpoints on their sandbox and snapshots as separate resources. Resource filters preserve each resource's share. Rate changes do not reprice recorded amounts. An access-filtered page can have no items and a non-null next_cursor; continue until next_cursor is null.
        /// </summary>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="resourceType"></param>
        /// <param name="resourceIds"></param>
        /// <param name="pageSize">
        /// Default Value: 20
        /// </param>
        /// <param name="granularity">
        /// Default Value: HOUR
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.SandboxesSandboxUsageCostsResponse>> ListHourlySandboxUsageCostsAsResponseAsync(
            global::System.DateTime startTime,
            global::System.DateTime endTime,
            global::LangSmith.GetSandboxesUsageCostsResourceType? resourceType = default,
            global::System.Collections.Generic.IList<string>? resourceIds = default,
            int? pageSize = default,
            global::LangSmith.GetSandboxesUsageCostsGranularity? granularity = default,
            string? cursor = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}