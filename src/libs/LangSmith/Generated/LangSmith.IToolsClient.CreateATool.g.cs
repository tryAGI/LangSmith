#nullable enable

namespace LangSmith
{
    public partial interface IToolsClient
    {
        /// <summary>
        /// Create a tool<br/>
        /// Creates a new tool in the workspace.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.ToolsTool> CreateAToolAsync(

            global::LangSmith.ToolsCreateToolPayload request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a tool<br/>
        /// Creates a new tool in the workspace.
        /// </summary>
        /// <param name="description"></param>
        /// <param name="enabled"></param>
        /// <param name="handle"></param>
        /// <param name="metadata"></param>
        /// <param name="name"></param>
        /// <param name="parameters"></param>
        /// <param name="returns"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.ToolsTool> CreateAToolAsync(
            string description,
            string handle,
            string name,
            object parameters,
            bool? enabled = default,
            object? metadata = default,
            object? returns = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}