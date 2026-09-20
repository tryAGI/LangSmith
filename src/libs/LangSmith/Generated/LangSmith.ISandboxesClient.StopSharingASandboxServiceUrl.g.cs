#nullable enable

namespace LangSmith
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// Stop sharing a sandbox service URL<br/>
        /// Removes the sharing grant for one port, or for every port when port is omitted. A LangSmith login URL stops working immediately. A previously minted service token is not revoked and stays valid until it expires, but no new one can be issued from the removed grant.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="port"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task StopSharingASandboxServiceUrlAsync(
            string name,
            int? port = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Stop sharing a sandbox service URL<br/>
        /// Removes the sharing grant for one port, or for every port when port is omitted. A LangSmith login URL stops working immediately. A previously minted service token is not revoked and stays valid until it expires, but no new one can be issued from the removed grant.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="port"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse> StopSharingASandboxServiceUrlAsResponseAsync(
            string name,
            int? port = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}