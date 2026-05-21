#nullable enable

namespace LangSmith
{
    public partial interface IExecuteClient
    {
        /// <summary>
        /// Execute a command<br/>
        /// Execute a shell command and return stdout, stderr, and exit code
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.HandlersExecResponse> ExecuteACommandAsync(

            global::LangSmith.HandlersExecRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Execute a command<br/>
        /// Execute a shell command and return stdout, stderr, and exit code
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.HandlersExecResponse>> ExecuteACommandAsResponseAsync(

            global::LangSmith.HandlersExecRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Execute a command<br/>
        /// Execute a shell command and return stdout, stderr, and exit code
        /// </summary>
        /// <param name="command"></param>
        /// <param name="cwd"></param>
        /// <param name="env"></param>
        /// <param name="shell"></param>
        /// <param name="timeoutSeconds"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.HandlersExecResponse> ExecuteACommandAsync(
            global::LangSmith.SandboxapiCommand? command = default,
            string? cwd = default,
            global::System.Collections.Generic.Dictionary<string, string>? env = default,
            string? shell = default,
            int? timeoutSeconds = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}