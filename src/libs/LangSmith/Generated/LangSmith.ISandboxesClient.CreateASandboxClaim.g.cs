#nullable enable

namespace LangSmith
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// Create a sandbox claim<br/>
        /// Create a new sandbox from a snapshot. Provide at most one of `snapshot_id` or `snapshot_name`; if neither is provided, the server uses the default static blueprint.
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
        /// Create a new sandbox from a snapshot. Provide at most one of `snapshot_id` or `snapshot_name`; if neither is provided, the server uses the default static blueprint.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.SandboxesClaimResponse>> CreateASandboxClaimAsResponseAsync(

            global::LangSmith.SandboxesCreateClaimPayload request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a sandbox claim<br/>
        /// Create a new sandbox from a snapshot. Provide at most one of `snapshot_id` or `snapshot_name`; if neither is provided, the server uses the default static blueprint.
        /// </summary>
        /// <param name="deleteAfterStopSeconds"></param>
        /// <param name="fsCapacityBytes"></param>
        /// <param name="idleTtlSeconds"></param>
        /// <param name="memBytes"></param>
        /// <param name="name"></param>
        /// <param name="proxyConfig"></param>
        /// <param name="restoreMemory">
        /// RestoreMemory, when non-nil, overrides the server default for<br/>
        /// whether to resume the sandbox from its captured memory snapshot.<br/>
        ///   true  → resume from the memory snapshot if it exists; cold-boot<br/>
        ///           the sandbox otherwise.<br/>
        ///   false → always cold-boot, even if a memory snapshot exists.<br/>
        ///   nil   → use the server default.<br/>
        /// Applies to this request only; a later stop+start of the same<br/>
        /// sandbox reverts to the server default.
        /// </param>
        /// <param name="snapshotId"></param>
        /// <param name="snapshotName"></param>
        /// <param name="tagValueIds"></param>
        /// <param name="vcpus"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.SandboxesClaimResponse> CreateASandboxClaimAsync(
            int? deleteAfterStopSeconds = default,
            long? fsCapacityBytes = default,
            int? idleTtlSeconds = default,
            long? memBytes = default,
            string? name = default,
            global::LangSmith.SandboxesProxyConfig? proxyConfig = default,
            bool? restoreMemory = default,
            string? snapshotId = default,
            string? snapshotName = default,
            global::System.Collections.Generic.IList<string>? tagValueIds = default,
            int? vcpus = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}