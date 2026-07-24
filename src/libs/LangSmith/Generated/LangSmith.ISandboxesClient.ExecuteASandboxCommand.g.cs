#nullable enable

namespace LangSmith
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// Execute a sandbox command<br/>
        /// Execute a command inside a sandbox and return stdout, stderr, and exit code.
        /// </summary>
        /// <param name="sandboxId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.SandboxesExecResponse> ExecuteASandboxCommandAsync(
            string sandboxId,

            global::LangSmith.SandboxesExecRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Execute a sandbox command<br/>
        /// Execute a command inside a sandbox and return stdout, stderr, and exit code.
        /// </summary>
        /// <param name="sandboxId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.SandboxesExecResponse>> ExecuteASandboxCommandAsResponseAsync(
            string sandboxId,

            global::LangSmith.SandboxesExecRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Execute a sandbox command<br/>
        /// Execute a command inside a sandbox and return stdout, stderr, and exit code.
        /// </summary>
        /// <param name="sandboxId"></param>
        /// <param name="command">
        /// Command accepts either a shell command string or an argv string array.
        /// </param>
        /// <param name="cwd"></param>
        /// <param name="env"></param>
        /// <param name="shell"></param>
        /// <param name="timeoutSeconds"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.SandboxesExecResponse> ExecuteASandboxCommandAsync(
            string sandboxId,
            global::System.Collections.Generic.IList<string>? command = default,
            string? cwd = default,
            global::System.Collections.Generic.Dictionary<string, string>? env = default,
            string? shell = default,
            int? timeoutSeconds = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}