#nullable enable

namespace LangSmith
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// Open a sandbox TCP tunnel<br/>
        /// Open a WebSocket tunnel to a specific port inside a sandbox.
        /// </summary>
        /// <param name="sandboxId"></param>
        /// <param name="xSandboxPort"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task OpenASandboxTcpTunnelAsync(
            string sandboxId,
            int? xSandboxPort = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Open a sandbox TCP tunnel<br/>
        /// Open a WebSocket tunnel to a specific port inside a sandbox.
        /// </summary>
        /// <param name="sandboxId"></param>
        /// <param name="xSandboxPort"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse> OpenASandboxTcpTunnelAsResponseAsync(
            string sandboxId,
            int? xSandboxPort = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}