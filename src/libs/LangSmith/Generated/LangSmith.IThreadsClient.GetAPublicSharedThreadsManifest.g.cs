#nullable enable

namespace LangSmith
{
    public partial interface IThreadsClient
    {
        /// <summary>
        /// Get a public shared thread's manifest<br/>
        /// Returns the thread and project a share token is scoped to, plus the project's conversations config.<br/>
        /// Self-hosted deployments require LangSmith `v0.16` or later.
        /// </summary>
        /// <param name="shareToken"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.ThreadshareThreadManifest> GetAPublicSharedThreadsManifestAsync(
            global::System.Guid shareToken,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a public shared thread's manifest<br/>
        /// Returns the thread and project a share token is scoped to, plus the project's conversations config.<br/>
        /// Self-hosted deployments require LangSmith `v0.16` or later.
        /// </summary>
        /// <param name="shareToken"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.ThreadshareThreadManifest>> GetAPublicSharedThreadsManifestAsResponseAsync(
            global::System.Guid shareToken,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}