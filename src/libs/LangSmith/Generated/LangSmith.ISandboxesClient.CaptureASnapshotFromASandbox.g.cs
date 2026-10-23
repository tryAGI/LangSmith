#nullable enable

namespace LangSmith
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// Capture a snapshot from a sandbox<br/>
        /// Create a snapshot by capturing the current state of a sandbox or promoting an existing checkpoint.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.SandboxesSnapshotResponse> CaptureASnapshotFromASandboxAsync(
            string name,

            global::LangSmith.SandboxesCaptureSnapshotPayload request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Capture a snapshot from a sandbox<br/>
        /// Create a snapshot by capturing the current state of a sandbox or promoting an existing checkpoint.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.SandboxesSnapshotResponse>> CaptureASnapshotFromASandboxAsResponseAsync(
            string name,

            global::LangSmith.SandboxesCaptureSnapshotPayload request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Capture a snapshot from a sandbox<br/>
        /// Create a snapshot by capturing the current state of a sandbox or promoting an existing checkpoint.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="checkpoint">
        /// if omitted, creates a fresh checkpoint from the running VM
        /// </param>
        /// <param name="confirmAllowSnapshotSecretValues">
        /// Must be true when the included settings hold literal secret values (opaque values rather than workspace secret references, and any env var value), acknowledging that the snapshot stores them and every sandbox created from it can use them.
        /// </param>
        /// <param name="description">
        /// Description says what this snapshot's image can do, so a caller can hand it to an agent as a capability summary. At most 1024 characters.
        /// </param>
        /// <param name="dockerImage">
        /// sandbox-local Docker image to export
        /// </param>
        /// <param name="fsCapacityBytes">
        /// required for Docker image export unless the sandbox has a capacity
        /// </param>
        /// <param name="imageConfig">
        /// ImageConfig sets the command and ports the snapshot records, as a Docker image's ENTRYPOINT, CMD and EXPOSE do. By default a capture keeps<br/>
        /// those of the snapshot the sandbox was created from; each field given here replaces that one, and an empty list clears it. A function<br/>
        /// serving the snapshot runs this command and listens on its one exposed port.
        /// </param>
        /// <param name="include">
        /// Sandbox settings to carry into the snapshot. Sandboxes created from it start with each carried setting their create request leaves unset: "mounts" (the mount_config, with its auth), "proxy_config", "env_vars", "resources" (CPU and memory), "lifecycle" (idle_ttl_seconds, delete_after_stop_seconds, preserve_memory_on_stop), and "labels" (merged under this request's labels; reserved com.langchain.* labels are left out). "all" names every one of these. VM memory is captured with include_memory, not here. Warning: mounts, proxy_config and env_vars carry the sandbox's credentials, and every sandbox created from the snapshot can use them.
        /// </param>
        /// <param name="includeMemory">
        /// IncludeMemory, when true, captures a full VM memory snapshot<br/>
        /// alongside the filesystem clone. Only honored when the sandbox is running<br/>
        /// AND Checkpoint is omitted (i.e. a fresh in-VM checkpoint is requested).<br/>
        /// Defaults to false to keep snapshots small unless memory restore is<br/>
        /// explicitly desired.
        /// </param>
        /// <param name="labels">
        /// Labels seed the captured snapshot's labels.
        /// </param>
        /// <param name="requestName"></param>
        /// <param name="runConfig">
        /// RunConfig overrides the runtime configuration the snapshot carries: for a<br/>
        /// docker_image export, the image's USER, WORKDIR and ENV; for a capture of<br/>
        /// the running VM, the sandbox's own. user and work_dir replace, env_vars<br/>
        /// merge.
        /// </param>
        /// <param name="tag">
        /// mutable Docker-style tag; defaults to "latest"
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.SandboxesSnapshotResponse> CaptureASnapshotFromASandboxAsync(
            string name,
            string requestName,
            string? checkpoint = default,
            bool? confirmAllowSnapshotSecretValues = default,
            string? description = default,
            string? dockerImage = default,
            long? fsCapacityBytes = default,
            global::LangSmith.SandboxesSnapshotImageConfig? imageConfig = default,
            global::System.Collections.Generic.IList<global::LangSmith.SandboxesCaptureSnapshotPayloadIncludeItem>? include = default,
            bool? includeMemory = default,
            global::System.Collections.Generic.Dictionary<string, string>? labels = default,
            global::LangSmith.SandboxapiRunConfig? runConfig = default,
            string? tag = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}