#nullable enable

namespace LangSmith
{
    public partial interface IThreadsClient
    {
        /// <summary>
        /// Get one run in a public shared thread<br/>
        /// Returns a single run, including full inputs and outputs, provided its trace root belongs to the shared thread.<br/>
        /// Self-hosted deployments require LangSmith `v0.16` or later.
        /// </summary>
        /// <param name="shareToken"></param>
        /// <param name="runId"></param>
        /// <param name="startTime"></param>
        /// <param name="selects"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.QueryRunResponse> GetOneRunInAPublicSharedThreadAsync(
            global::System.Guid shareToken,
            global::System.Guid runId,
            global::System.DateTime startTime,
            global::System.Collections.Generic.IList<string> selects,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get one run in a public shared thread<br/>
        /// Returns a single run, including full inputs and outputs, provided its trace root belongs to the shared thread.<br/>
        /// Self-hosted deployments require LangSmith `v0.16` or later.
        /// </summary>
        /// <param name="shareToken"></param>
        /// <param name="runId"></param>
        /// <param name="startTime"></param>
        /// <param name="selects"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.QueryRunResponse>> GetOneRunInAPublicSharedThreadAsResponseAsync(
            global::System.Guid shareToken,
            global::System.Guid runId,
            global::System.DateTime startTime,
            global::System.Collections.Generic.IList<string> selects,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}