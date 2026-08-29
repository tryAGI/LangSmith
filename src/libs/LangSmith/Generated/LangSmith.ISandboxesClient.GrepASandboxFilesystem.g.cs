#nullable enable

namespace LangSmith
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// Grep a sandbox filesystem<br/>
        /// Search files under a root path for a literal text pattern (not a regex).
        /// </summary>
        /// <param name="sandboxId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.SandboxesGrepResponse> GrepASandboxFilesystemAsync(
            string sandboxId,

            global::LangSmith.SandboxesGrepRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Grep a sandbox filesystem<br/>
        /// Search files under a root path for a literal text pattern (not a regex).
        /// </summary>
        /// <param name="sandboxId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.SandboxesGrepResponse>> GrepASandboxFilesystemAsResponseAsync(
            string sandboxId,

            global::LangSmith.SandboxesGrepRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Grep a sandbox filesystem<br/>
        /// Search files under a root path for a literal text pattern (not a regex).
        /// </summary>
        /// <param name="sandboxId"></param>
        /// <param name="glob"></param>
        /// <param name="limit"></param>
        /// <param name="path"></param>
        /// <param name="pattern"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.SandboxesGrepResponse> GrepASandboxFilesystemAsync(
            string sandboxId,
            string? glob = default,
            int? limit = default,
            string? path = default,
            string? pattern = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}