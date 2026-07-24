#nullable enable

namespace LangSmith
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// Create a sandbox<br/>
        /// Create a new sandbox from a snapshot. Provide at most one of `snapshot_id` or `snapshot_name`; if neither is provided, the server uses the default snapshot.
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
        /// Create a new sandbox from a snapshot. Provide at most one of `snapshot_id` or `snapshot_name`; if neither is provided, the server uses the default snapshot.
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
        /// Create a new sandbox from a snapshot. Provide at most one of `snapshot_id` or `snapshot_name`; if neither is provided, the server uses the default snapshot.
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
        /// <param name="memBytes"></param>
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
        /// <param name="snapshotId"></param>
        /// <param name="snapshotName"></param>
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
            string? snapshotId = default,
            string? snapshotName = default,
            global::System.Collections.Generic.IList<string>? tagValueIds = default,
            int? vcpus = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}