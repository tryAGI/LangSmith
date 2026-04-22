#nullable enable

namespace LangSmith
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// Create a sandbox claim<br/>
        /// Create a new sandbox. The snapshot may be identified by `snapshot_id` (UUID) or by `snapshot_name` (tenant-scoped unique name); exactly one of `template_name`, `snapshot_id`, or `snapshot_name` must be set. Optionally blocks until ready or timeout.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.SandboxesClaimResponse> CreateASandboxClaimAsync(

            global::LangSmith.SandboxesCreateClaimPayload request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a sandbox claim<br/>
        /// Create a new sandbox. The snapshot may be identified by `snapshot_id` (UUID) or by `snapshot_name` (tenant-scoped unique name); exactly one of `template_name`, `snapshot_id`, or `snapshot_name` must be set. Optionally blocks until ready or timeout.
        /// </summary>
        /// <param name="fsCapacityBytes"></param>
        /// <param name="idleTtlSeconds"></param>
        /// <param name="memBytes"></param>
        /// <param name="name"></param>
        /// <param name="proxyConfig"></param>
        /// <param name="snapshotId"></param>
        /// <param name="snapshotName"></param>
        /// <param name="templateName">
        /// required for Kata path
        /// </param>
        /// <param name="timeout"></param>
        /// <param name="ttlSeconds"></param>
        /// <param name="vcpus"></param>
        /// <param name="waitForReady"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.SandboxesClaimResponse> CreateASandboxClaimAsync(
            long? fsCapacityBytes = default,
            int? idleTtlSeconds = default,
            long? memBytes = default,
            string? name = default,
            global::LangSmith.SandboxesProxyConfig? proxyConfig = default,
            string? snapshotId = default,
            string? snapshotName = default,
            string? templateName = default,
            int? timeout = default,
            int? ttlSeconds = default,
            int? vcpus = default,
            bool? waitForReady = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}