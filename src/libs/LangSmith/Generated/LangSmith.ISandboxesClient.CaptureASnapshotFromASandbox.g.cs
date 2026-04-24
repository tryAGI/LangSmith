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
        /// <param name="checkpoint">
        /// if omitted, creates a fresh checkpoint from the running VM
        /// </param>
        /// <param name="requestName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.SandboxesSnapshotResponse> CaptureASnapshotFromASandboxAsync(
            string name,
            string requestName,
            string? checkpoint = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}