#nullable enable

namespace LangSmith
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// Create a sandbox claim<br/>
        /// Create a new sandbox from a template. Optionally blocks until ready or timeout.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.SandboxesClaimResponse> CreateASandboxClaimAsync(

            global::LangSmith.SandboxesCreateClaimPayload request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a sandbox claim<br/>
        /// Create a new sandbox from a template. Optionally blocks until ready or timeout.
        /// </summary>
        /// <param name="idleTtlSeconds"></param>
        /// <param name="name"></param>
        /// <param name="proxyConfig"></param>
        /// <param name="templateName"></param>
        /// <param name="timeout"></param>
        /// <param name="ttlSeconds"></param>
        /// <param name="waitForReady"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.SandboxesClaimResponse> CreateASandboxClaimAsync(
            string templateName,
            int? idleTtlSeconds = default,
            string? name = default,
            global::LangSmith.SandboxesProxyConfig? proxyConfig = default,
            int? timeout = default,
            int? ttlSeconds = default,
            bool? waitForReady = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}