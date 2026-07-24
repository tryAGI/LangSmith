#nullable enable

namespace LangSmith
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// Glob a sandbox filesystem<br/>
        /// Find files under a root path matching a glob pattern (supports **). Entries are returned in lexical order by path.
        /// </summary>
        /// <param name="sandboxId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.SandboxesGlobResponse> GlobASandboxFilesystemAsync(
            string sandboxId,

            global::LangSmith.SandboxesGlobRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Glob a sandbox filesystem<br/>
        /// Find files under a root path matching a glob pattern (supports **). Entries are returned in lexical order by path.
        /// </summary>
        /// <param name="sandboxId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.SandboxesGlobResponse>> GlobASandboxFilesystemAsResponseAsync(
            string sandboxId,

            global::LangSmith.SandboxesGlobRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Glob a sandbox filesystem<br/>
        /// Find files under a root path matching a glob pattern (supports **). Entries are returned in lexical order by path.
        /// </summary>
        /// <param name="sandboxId"></param>
        /// <param name="limit"></param>
        /// <param name="path"></param>
        /// <param name="pattern"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.SandboxesGlobResponse> GlobASandboxFilesystemAsync(
            string sandboxId,
            int? limit = default,
            string? path = default,
            string? pattern = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}