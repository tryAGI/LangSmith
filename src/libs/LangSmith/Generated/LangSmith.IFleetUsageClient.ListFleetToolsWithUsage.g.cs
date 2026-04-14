#nullable enable

namespace LangSmith
{
    public partial interface IFleetUsageClient
    {
        /// <summary>
        /// List fleet tools with usage<br/>
        /// Returns the top tools in the workspace with run counts, latency, and agent counts for the given time window, sorted by run count descending.
        /// </summary>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.UsageToolUsageResponse> ListFleetToolsWithUsageAsync(
            string startTime,
            string endTime,
            int? limit = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}