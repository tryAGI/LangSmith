#nullable enable

namespace LangSmith
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// Create a snapshot<br/>
        /// Create a snapshot from a Docker image (async build).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.SandboxesSnapshotResponse> CreateASnapshotAsync(

            global::LangSmith.SandboxesCreateSnapshotPayload request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a snapshot<br/>
        /// Create a snapshot from a Docker image (async build).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.SandboxesSnapshotResponse>> CreateASnapshotAsResponseAsync(

            global::LangSmith.SandboxesCreateSnapshotPayload request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a snapshot<br/>
        /// Create a snapshot from a Docker image (async build).
        /// </summary>
        /// <param name="description">
        /// Description says what this snapshot's image can do, so a caller can hand it to an agent as a capability summary. At most 1024 characters.
        /// </param>
        /// <param name="dockerImage"></param>
        /// <param name="fsCapacityBytes"></param>
        /// <param name="labels">
        /// Labels seed the snapshot's labels, overriding any label of the same key derived from the Docker image.
        /// </param>
        /// <param name="name"></param>
        /// <param name="registryId"></param>
        /// <param name="runConfig">
        /// RunConfig overrides the runtime configuration taken from the Docker image.<br/>
        /// Every sandbox created from the snapshot runs as the image's USER, in its<br/>
        /// WORKDIR, with its ENV beneath the sandbox's own env_vars; user and<br/>
        /// work_dir given here replace the image's, and env_vars merge over it.
        /// </param>
        /// <param name="tag">
        /// mutable Docker-style tag; defaults to "latest"
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.SandboxesSnapshotResponse> CreateASnapshotAsync(
            string dockerImage,
            long fsCapacityBytes,
            string name,
            string? description = default,
            global::System.Collections.Generic.Dictionary<string, string>? labels = default,
            string? registryId = default,
            global::LangSmith.SandboxapiRunConfig? runConfig = default,
            string? tag = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}