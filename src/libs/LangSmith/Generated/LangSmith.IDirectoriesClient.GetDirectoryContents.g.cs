#nullable enable

namespace LangSmith
{
    public partial interface IDirectoriesClient
    {
        /// <summary>
        /// Get directory contents<br/>
        /// Resolves the flattened file tree for an agent or skill repository at a specific commit, tag, or latest.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="commit"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.DirectoriesGetDirectoryResponse> GetDirectoryContentsAsync(
            string owner,
            string repo,
            string? commit = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get directory contents<br/>
        /// Resolves the flattened file tree for an agent or skill repository at a specific commit, tag, or latest.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="commit"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.DirectoriesGetDirectoryResponse>> GetDirectoryContentsAsResponseAsync(
            string owner,
            string repo,
            string? commit = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}