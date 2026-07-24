#nullable enable

namespace LangSmith
{
    public partial interface IRunsClient
    {
        /// <summary>
        /// Get a public shared trace run<br/>
        /// **Alpha:** The request and response contract may change;<br/>
        /// Returns one run within the trace identified by the share token. The request supplies only the run ID and that run's exact start_time coordinate.
        /// </summary>
        /// <param name="accept"></param>
        /// <param name="shareToken"></param>
        /// <param name="runId"></param>
        /// <param name="startTime"></param>
        /// <param name="selects"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.QueryRunResponse> GetAPublicSharedTraceRunAsync(
            global::System.Guid shareToken,
            global::System.Guid runId,
            global::System.DateTime startTime,
            global::System.Collections.Generic.IList<string> selects,
            string? accept = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a public shared trace run<br/>
        /// **Alpha:** The request and response contract may change;<br/>
        /// Returns one run within the trace identified by the share token. The request supplies only the run ID and that run's exact start_time coordinate.
        /// </summary>
        /// <param name="accept"></param>
        /// <param name="shareToken"></param>
        /// <param name="runId"></param>
        /// <param name="startTime"></param>
        /// <param name="selects"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.QueryRunResponse>> GetAPublicSharedTraceRunAsResponseAsync(
            global::System.Guid shareToken,
            global::System.Guid runId,
            global::System.DateTime startTime,
            global::System.Collections.Generic.IList<string> selects,
            string? accept = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}