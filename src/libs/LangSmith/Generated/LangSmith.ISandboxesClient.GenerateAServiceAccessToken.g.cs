#nullable enable

namespace LangSmith
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// Generate a service access token<br/>
        /// Create a short-lived JWT for accessing an HTTP service running on a specific port inside a sandbox. Returns a browser_url (sets auth cookie via redirect), a service_url (for use with the X-Langsmith-Sandbox-Service-Token header), the raw token, and its expiry.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.SandboxesServiceURLResponse> GenerateAServiceAccessTokenAsync(

            global::LangSmith.SandboxesServiceURLPayload request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate a service access token<br/>
        /// Create a short-lived JWT for accessing an HTTP service running on a specific port inside a sandbox. Returns a browser_url (sets auth cookie via redirect), a service_url (for use with the X-Langsmith-Sandbox-Service-Token header), the raw token, and its expiry.
        /// </summary>
        /// <param name="expiresInSeconds"></param>
        /// <param name="port"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.SandboxesServiceURLResponse> GenerateAServiceAccessTokenAsync(
            int? expiresInSeconds = default,
            int? port = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}