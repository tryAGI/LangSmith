#nullable enable

namespace LangSmith
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// Generate a sandbox file download link<br/>
        /// Generate a tokenized link that downloads a single file from a sandbox with no further authentication. This mints a token rather than creating an addressable resource, so it returns 200 with no Location header. The token pins the sandbox, the file path, and the response content type and disposition, so a link cannot be repointed at another file. Links never expire unless expires_in_seconds is set. The link is served from the sandbox service domain, not the API host.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.SandboxesDownloadURLResponse> GenerateASandboxFileDownloadLinkAsync(
            string name,

            global::LangSmith.SandboxesDownloadURLPayload request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate a sandbox file download link<br/>
        /// Generate a tokenized link that downloads a single file from a sandbox with no further authentication. This mints a token rather than creating an addressable resource, so it returns 200 with no Location header. The token pins the sandbox, the file path, and the response content type and disposition, so a link cannot be repointed at another file. Links never expire unless expires_in_seconds is set. The link is served from the sandbox service domain, not the API host.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.SandboxesDownloadURLResponse>> GenerateASandboxFileDownloadLinkAsResponseAsync(
            string name,

            global::LangSmith.SandboxesDownloadURLPayload request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate a sandbox file download link<br/>
        /// Generate a tokenized link that downloads a single file from a sandbox with no further authentication. This mints a token rather than creating an addressable resource, so it returns 200 with no Location header. The token pins the sandbox, the file path, and the response content type and disposition, so a link cannot be repointed at another file. Links never expire unless expires_in_seconds is set. The link is served from the sandbox service domain, not the API host.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="contentDisposition"></param>
        /// <param name="contentType"></param>
        /// <param name="expiresInSeconds">
        /// ExpiresInSeconds is optional; a link with no expiry never expires.
        /// </param>
        /// <param name="path"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.SandboxesDownloadURLResponse> GenerateASandboxFileDownloadLinkAsync(
            string name,
            string path,
            string? contentDisposition = default,
            string? contentType = default,
            int? expiresInSeconds = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}