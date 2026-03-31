#nullable enable

namespace LangSmith
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// Update a sandbox claim<br/>
        /// Update a sandbox claim's display name. The name must be unique within the tenant.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.SandboxesClaimResponse> UpdateASandboxClaimAsync(

            global::LangSmith.SandboxesUpdateClaimPayload request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a sandbox claim<br/>
        /// Update a sandbox claim's display name. The name must be unique within the tenant.
        /// </summary>
        /// <param name="fsCapacityBytes"></param>
        /// <param name="idleTtlSeconds"></param>
        /// <param name="memBytes"></param>
        /// <param name="name"></param>
        /// <param name="proxyConfig"></param>
        /// <param name="ttlSeconds"></param>
        /// <param name="vcpus"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.SandboxesClaimResponse> UpdateASandboxClaimAsync(
            long? fsCapacityBytes = default,
            int? idleTtlSeconds = default,
            long? memBytes = default,
            string? name = default,
            global::LangSmith.SandboxesProxyConfig? proxyConfig = default,
            int? ttlSeconds = default,
            int? vcpus = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}