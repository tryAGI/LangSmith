#nullable enable

namespace LangSmith
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// Generate a service access token<br/>
        /// Create a short-lived JWT for accessing an HTTP service running on a specific port inside a sandbox. Returns a browser_url (sets auth cookie via redirect), a service_url (for use with the X-Langsmith-Sandbox-Service-Token header), the raw token, and its expiry. Set access=restricted|workspace to instead enable durable LangSmith login (no token; users authenticate with their normal LangSmith session), or access=off to disable it. LangSmith login and token access are mutually exclusive per service URL.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.SandboxesServiceURLResponse> GenerateAServiceAccessTokenAsync(
            string name,

            global::LangSmith.SandboxesServiceURLPayload request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate a service access token<br/>
        /// Create a short-lived JWT for accessing an HTTP service running on a specific port inside a sandbox. Returns a browser_url (sets auth cookie via redirect), a service_url (for use with the X-Langsmith-Sandbox-Service-Token header), the raw token, and its expiry. Set access=restricted|workspace to instead enable durable LangSmith login (no token; users authenticate with their normal LangSmith session), or access=off to disable it. LangSmith login and token access are mutually exclusive per service URL.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.SandboxesServiceURLResponse>> GenerateAServiceAccessTokenAsResponseAsync(
            string name,

            global::LangSmith.SandboxesServiceURLPayload request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate a service access token<br/>
        /// Create a short-lived JWT for accessing an HTTP service running on a specific port inside a sandbox. Returns a browser_url (sets auth cookie via redirect), a service_url (for use with the X-Langsmith-Sandbox-Service-Token header), the raw token, and its expiry. Set access=restricted|workspace to instead enable durable LangSmith login (no token; users authenticate with their normal LangSmith session), or access=off to disable it. LangSmith login and token access are mutually exclusive per service URL.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="access">
        /// Access selects the login mode, mutually exclusive with the minted token.<br/>
        /// Omit the field for token mode: mint a short-lived service token (default).<br/>
        ///   "restricted" — LangSmith login: any user with SandboxesRead on the sandbox.<br/>
        ///   "workspace"  — LangSmith login: any member of the owning workspace.<br/>
        ///   "off"        — remove an existing LangSmith login grant and mint a token.<br/>
        /// A LangSmith login grant is durable; token mode is refused (409) while one exists.
        /// </param>
        /// <param name="expiresInSeconds"></param>
        /// <param name="port"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.SandboxesServiceURLResponse> GenerateAServiceAccessTokenAsync(
            string name,
            global::LangSmith.SandboxesServiceURLPayloadAccess? access = default,
            int? expiresInSeconds = default,
            int? port = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}