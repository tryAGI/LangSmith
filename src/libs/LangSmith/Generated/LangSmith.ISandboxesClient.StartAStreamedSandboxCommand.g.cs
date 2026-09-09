#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace LangSmith
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// Start a streamed sandbox command<br/>
        /// Execute a command inside a sandbox and stream stdout/stderr as Server-Sent Events with base64 payloads. Requires a sandbox on the v2 runtime. Passing a command_id reuses a running command instead of starting a second one. The response ends with an ack_required event when the sandbox's output buffer needs an ack; continue from the reported offsets with the resume endpoint.
        /// </summary>
        /// <param name="sandboxId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Collections.Generic.IAsyncEnumerable<string> StartAStreamedSandboxCommandAsync(
            string sandboxId,

            global::LangSmith.SandboxesExecStreamRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Start a streamed sandbox command<br/>
        /// Execute a command inside a sandbox and stream stdout/stderr as Server-Sent Events with base64 payloads. Requires a sandbox on the v2 runtime. Passing a command_id reuses a running command instead of starting a second one. The response ends with an ack_required event when the sandbox's output buffer needs an ack; continue from the reported offsets with the resume endpoint.
        /// </summary>
        /// <param name="sandboxId"></param>
        /// <param name="command">
        /// Command accepts either a shell command string or an argv string array.
        /// </param>
        /// <param name="commandId">
        /// CommandID makes the request idempotent: a known ID attaches to that<br/>
        /// running command instead of starting a second one.
        /// </param>
        /// <param name="idleTimeoutSeconds">
        /// 0 = default, -1 = never idle-kill
        /// </param>
        /// <param name="runConfig">
        /// RunConfig overrides, for this command only, the user, working directory and env the sandbox's commands run with.
        /// </param>
        /// <param name="shell"></param>
        /// <param name="stdin">
        /// Stdin is the process's entire standard input, base64 on the wire. It is<br/>
        /// written once when the command is spawned and then closed, so the process<br/>
        /// reads EOF; there is no stdin streaming on this endpoint.
        /// </param>
        /// <param name="timeoutSeconds">
        /// 0 = no timeout
        /// </param>
        /// <param name="ttlSeconds">
        /// 0 = default, -1 = keep forever
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Collections.Generic.IAsyncEnumerable<string> StartAStreamedSandboxCommandAsync(
            string sandboxId,
            global::System.Collections.Generic.IList<string>? command = default,
            string? commandId = default,
            int? idleTimeoutSeconds = default,
            global::LangSmith.SandboxapiRunConfig? runConfig = default,
            string? shell = default,
            byte[]? stdin = default,
            int? timeoutSeconds = default,
            int? ttlSeconds = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}