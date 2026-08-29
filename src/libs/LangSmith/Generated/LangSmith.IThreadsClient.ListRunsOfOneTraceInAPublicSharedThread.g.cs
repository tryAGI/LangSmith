#nullable enable

namespace LangSmith
{
    public partial interface IThreadsClient
    {
        /// <summary>
        /// List runs of one trace in a public shared thread<br/>
        /// Returns every run in the given trace, provided that trace's root belongs to the shared thread.<br/>
        /// Self-hosted deployments require LangSmith `v0.16` or later.
        /// </summary>
        /// <param name="shareToken"></param>
        /// <param name="traceId"></param>
        /// <param name="selects"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.ThreadsPublicSharedThreadTraceRunsResponseBody> ListRunsOfOneTraceInAPublicSharedThreadAsync(
            global::System.Guid shareToken,
            global::System.Guid traceId,
            global::System.Collections.Generic.IList<string> selects,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List runs of one trace in a public shared thread<br/>
        /// Returns every run in the given trace, provided that trace's root belongs to the shared thread.<br/>
        /// Self-hosted deployments require LangSmith `v0.16` or later.
        /// </summary>
        /// <param name="shareToken"></param>
        /// <param name="traceId"></param>
        /// <param name="selects"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.ThreadsPublicSharedThreadTraceRunsResponseBody>> ListRunsOfOneTraceInAPublicSharedThreadAsResponseAsync(
            global::System.Guid shareToken,
            global::System.Guid traceId,
            global::System.Collections.Generic.IList<string> selects,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}