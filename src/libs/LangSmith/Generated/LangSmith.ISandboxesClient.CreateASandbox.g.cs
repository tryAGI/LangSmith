#nullable enable

namespace LangSmith
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// Create a sandbox<br/>
        /// Create a new sandbox from a snapshot. Provide at most one of `snapshot_id` or `snapshot_name`; if neither is provided, the server uses the default snapshot. `snapshot_name` accepts a Docker-style `name` or `name:tag` reference (a bare name resolves to `name:latest`).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.SandboxesSandboxResponse> CreateASandboxAsync(

            global::LangSmith.SandboxesCreateSandboxPayload request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a sandbox<br/>
        /// Create a new sandbox from a snapshot. Provide at most one of `snapshot_id` or `snapshot_name`; if neither is provided, the server uses the default snapshot. `snapshot_name` accepts a Docker-style `name` or `name:tag` reference (a bare name resolves to `name:latest`).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.SandboxesSandboxResponse>> CreateASandboxAsResponseAsync(

            global::LangSmith.SandboxesCreateSandboxPayload request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a sandbox<br/>
        /// Create a new sandbox from a snapshot. Provide at most one of `snapshot_id` or `snapshot_name`; if neither is provided, the server uses the default snapshot. `snapshot_name` accepts a Docker-style `name` or `name:tag` reference (a bare name resolves to `name:latest`).
        /// </summary>
        /// <param name="cpuMillicores">
        /// CPUMillicores optionally requests CPU at millicore granularity (e.g. 500 = 0.5 vCPU); takes precedence over VCPUs. Fractional (sub-vCPU) values are not available for every sandbox.
        /// </param>
        /// <param name="deleteAfterStopSeconds"></param>
        /// <param name="envVars"></param>
        /// <param name="fsCapacityBytes"></param>
        /// <param name="idleTtlSeconds"></param>
        /// <param name="labels">
        /// Labels are free-form key/value metadata persisted with the sandbox and returned on reads. Labels from the source snapshot are inherited unless overridden here.
        /// </param>
        /// <param name="memBytes">
        /// Memory for the sandbox, in bytes. Memory is tied to CPU at 4 GiB per vCPU: omit it and it follows that ratio; set it and it must stay within 50% of the ratio for the requested CPU, so a 1 vCPU sandbox accepts 2-6 GiB. Setting memory without CPU derives the CPU from the same ratio. Maximum 64 GiB.
        /// </param>
        /// <param name="mountConfig"></param>
        /// <param name="name"></param>
        /// <param name="preserveMemoryOnStop">
        /// PreserveMemoryOnStop, when true, suspends the sandbox's memory on a<br/>
        /// voluntary stop (idle timeout or explicit stop) so the next start resumes<br/>
        /// from where it left off. Default false discards memory and keeps only the<br/>
        /// filesystem, so the next start is a cold boot. Restarts triggered by<br/>
        /// infrastructure maintenance always preserve memory regardless of this setting.
        /// </param>
        /// <param name="proxyConfig"></param>
        /// <param name="restoreMemory">
        /// RestoreMemory selects how the sandbox handles a snapshot's captured memory:<br/>
        ///   nil   → if-present: resume from memory when the snapshot has it, else cold-boot (default).<br/>
        ///   true  → always: resume from memory; rejected if the snapshot has none.<br/>
        ///   false → never: always cold-boot.<br/>
        /// Applies to this request only.
        /// </param>
        /// <param name="snapshot">
        /// Snapshot is a Docker-style name or name:tag reference to boot from. A bare name resolves to name:latest.
        /// </param>
        /// <param name="snapshotId"></param>
        /// <param name="snapshotName">
        /// SnapshotName is a synonym for Snapshot, accepted for compatibility with clients that predate it. Set one or the other.
        /// </param>
        /// <param name="tagValueIds"></param>
        /// <param name="vcpus"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.SandboxesSandboxResponse> CreateASandboxAsync(
            int? cpuMillicores = default,
            int? deleteAfterStopSeconds = default,
            global::System.Collections.Generic.Dictionary<string, string>? envVars = default,
            long? fsCapacityBytes = default,
            int? idleTtlSeconds = default,
            global::System.Collections.Generic.Dictionary<string, string>? labels = default,
            long? memBytes = default,
            global::LangSmith.SandboxesSandboxMountConfig? mountConfig = default,
            string? name = default,
            bool? preserveMemoryOnStop = default,
            global::LangSmith.SandboxesProxyConfig? proxyConfig = default,
            bool? restoreMemory = default,
            string? snapshot = default,
            string? snapshotId = default,
            string? snapshotName = default,
            global::System.Collections.Generic.IList<string>? tagValueIds = default,
            int? vcpus = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}