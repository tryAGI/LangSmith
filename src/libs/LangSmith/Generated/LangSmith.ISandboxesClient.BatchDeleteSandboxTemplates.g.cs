#nullable enable

namespace LangSmith
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// Batch delete sandbox templates<br/>
        /// Delete multiple sandbox templates by name in a single request. Templates that are in use by claims or pools are skipped.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.SandboxesBatchDeleteResponse> BatchDeleteSandboxTemplatesAsync(

            global::LangSmith.SandboxesBatchDeleteRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Batch delete sandbox templates<br/>
        /// Delete multiple sandbox templates by name in a single request. Templates that are in use by claims or pools are skipped.
        /// </summary>
        /// <param name="names"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.SandboxesBatchDeleteResponse> BatchDeleteSandboxTemplatesAsync(
            global::System.Collections.Generic.IList<string>? names = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}