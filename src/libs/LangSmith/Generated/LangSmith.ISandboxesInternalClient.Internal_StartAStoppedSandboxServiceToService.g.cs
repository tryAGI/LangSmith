#nullable enable

namespace LangSmith
{
    public partial interface ISandboxesInternalClient
    {
        /// <summary>
        /// Internal: start a stopped sandbox (service-to-service)<br/>
        /// Called by the sandbox-router to wake stopped Firecracker boxes. Blocks until the sandbox is ready or times out. The name parameter accepts either the display name or the K8s sandbox name (sb-&lt;uuid&gt;).
        /// </summary>
        /// <param name="name"></param>
        /// <param name="xTenantId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.SandboxesClaimResponse> Internal_StartAStoppedSandboxServiceToServiceAsync(
            string name,
            string xTenantId,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}