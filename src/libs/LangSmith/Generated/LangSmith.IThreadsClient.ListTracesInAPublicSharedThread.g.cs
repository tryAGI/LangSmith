#nullable enable

namespace LangSmith
{
    public partial interface IThreadsClient
    {
        /// <summary>
        /// List traces in a public shared thread<br/>
        /// Returns a page of root traces belonging to the thread identified by the share token. The share token supplies the tenant, project, and thread scope.<br/>
        /// Self-hosted deployments require LangSmith `v0.16` or later.
        /// </summary>
        /// <param name="shareToken"></param>
        /// <param name="selects"></param>
        /// <param name="cursor"></param>
        /// <param name="pageSize"></param>
        /// <param name="order"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.ThreadsQueryThreadTracesResponseBody> ListTracesInAPublicSharedThreadAsync(
            global::System.Guid shareToken,
            global::System.Collections.Generic.IList<string> selects,
            string? cursor = default,
            int? pageSize = default,
            string? order = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List traces in a public shared thread<br/>
        /// Returns a page of root traces belonging to the thread identified by the share token. The share token supplies the tenant, project, and thread scope.<br/>
        /// Self-hosted deployments require LangSmith `v0.16` or later.
        /// </summary>
        /// <param name="shareToken"></param>
        /// <param name="selects"></param>
        /// <param name="cursor"></param>
        /// <param name="pageSize"></param>
        /// <param name="order"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.ThreadsQueryThreadTracesResponseBody>> ListTracesInAPublicSharedThreadAsResponseAsync(
            global::System.Guid shareToken,
            global::System.Collections.Generic.IList<string> selects,
            string? cursor = default,
            int? pageSize = default,
            string? order = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}