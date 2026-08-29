#nullable enable

namespace LangSmith
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// Resume a streamed sandbox command<br/>
        /// Continue streaming a command started by the stream start endpoint. The offsets are also the ack for everything below them, which frees the sandbox's output buffer and unpauses a command waiting for room. Attaches only: a command the sandbox no longer has returns 404 rather than running again.
        /// </summary>
        /// <param name="sandboxId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Collections.Generic.IAsyncEnumerable<string> ResumeAStreamedSandboxCommandAsync(
            string sandboxId,

            global::LangSmith.SandboxesExecStreamResumeRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Resume a streamed sandbox command<br/>
        /// Continue streaming a command started by the stream start endpoint. The offsets are also the ack for everything below them, which frees the sandbox's output buffer and unpauses a command waiting for room. Attaches only: a command the sandbox no longer has returns 404 rather than running again.
        /// </summary>
        /// <param name="sandboxId"></param>
        /// <param name="commandId">
        /// CommandID names the command to attach to.
        /// </param>
        /// <param name="stderrOffset"></param>
        /// <param name="stdoutOffset">
        /// StdoutOffset and StderrOffset are where to continue from, and are also the<br/>
        /// ack for every buffered byte below them. Zero replays from the beginning,<br/>
        /// which is what a retry sends when the stream broke before any output arrived.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Collections.Generic.IAsyncEnumerable<string> ResumeAStreamedSandboxCommandAsync(
            string sandboxId,
            string? commandId = default,
            int? stderrOffset = default,
            long? stdoutOffset = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}