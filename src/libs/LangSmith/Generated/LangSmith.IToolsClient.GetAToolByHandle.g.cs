#nullable enable

namespace LangSmith
{
    public partial interface IToolsClient
    {
        /// <summary>
        /// Get a tool by handle<br/>
        /// Returns a tool identified by its handle.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.ToolsTool> GetAToolByHandleAsync(
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}