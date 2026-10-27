#nullable enable

namespace LangSmith
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// Start a sandbox<br/>
        /// Start a stopped or failed sandbox. This endpoint is not idempotent. The optional volumes field is beta and requires sandbox volumes to be enabled for your workspace. Omit it to keep attachments, or send an empty array to detach all volumes. Changing attachments requires a stopped or failed sandbox, runtime access to it (its creator or sandboxes:exec), and, for each newly attached volume, being its creator or holding sandboxes:exec. A start whose volumes differ from those the sandbox's saved memory was captured with fails with 409 unless discard_memory is set, which cold-boots the sandbox without that memory.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.SandboxesSandboxResponse> StartASandboxAsync(
            string name,

            global::LangSmith.SandboxesStartSandboxPayload request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Start a sandbox<br/>
        /// Start a stopped or failed sandbox. This endpoint is not idempotent. The optional volumes field is beta and requires sandbox volumes to be enabled for your workspace. Omit it to keep attachments, or send an empty array to detach all volumes. Changing attachments requires a stopped or failed sandbox, runtime access to it (its creator or sandboxes:exec), and, for each newly attached volume, being its creator or holding sandboxes:exec. A start whose volumes differ from those the sandbox's saved memory was captured with fails with 409 unless discard_memory is set, which cold-boots the sandbox without that memory.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.SandboxesSandboxResponse>> StartASandboxAsResponseAsync(
            string name,

            global::LangSmith.SandboxesStartSandboxPayload request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Start a sandbox<br/>
        /// Start a stopped or failed sandbox. This endpoint is not idempotent. The optional volumes field is beta and requires sandbox volumes to be enabled for your workspace. Omit it to keep attachments, or send an empty array to detach all volumes. Changing attachments requires a stopped or failed sandbox, runtime access to it (its creator or sandboxes:exec), and, for each newly attached volume, being its creator or holding sandboxes:exec. A start whose volumes differ from those the sandbox's saved memory was captured with fails with 409 unless discard_memory is set, which cold-boots the sandbox without that memory.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="discardMemory">
        /// DiscardMemory cold-boots the sandbox, discarding any memory saved when it stopped.
        /// </param>
        /// <param name="volumes">
        /// Volumes, when present, replaces the attached volumes. A start whose volumes differ from those the sandbox's saved memory was captured with fails unless discard_memory is set.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.SandboxesSandboxResponse> StartASandboxAsync(
            string name,
            bool? discardMemory = default,
            global::System.Collections.Generic.IList<global::LangSmith.SandboxesVolumeMountRequest>? volumes = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}