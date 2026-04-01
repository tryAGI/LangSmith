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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.SandboxesSnapshotResponse> CreateASnapshotAsync(

            global::LangSmith.SandboxesCreateSnapshotPayload request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a snapshot<br/>
        /// Create a snapshot from a Docker image (async build).
        /// </summary>
        /// <param name="dockerImage"></param>
        /// <param name="fsCapacityBytes"></param>
        /// <param name="name"></param>
        /// <param name="registryId"></param>
        /// <param name="registryPassword"></param>
        /// <param name="registryUrl"></param>
        /// <param name="registryUsername"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.SandboxesSnapshotResponse> CreateASnapshotAsync(
            string dockerImage,
            long fsCapacityBytes,
            string name,
            string? registryId = default,
            string? registryPassword = default,
            string? registryUrl = default,
            string? registryUsername = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}