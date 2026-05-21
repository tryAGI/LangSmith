#nullable enable

namespace LangSmith
{
    public partial interface ICheckpointClient
    {
        /// <summary>
        /// Create a checkpoint<br/>
        /// Flush filesystem state and create a point-in-time checkpoint of the running sandbox. With include_memory=true the work is scheduled asynchronously and clients should poll snapshot capture for completion.
        /// </summary>
        /// <param name="includeMemory"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.HandlersCreateCheckpointResponse> CreateACheckpointAsync(
            bool? includeMemory = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a checkpoint<br/>
        /// Flush filesystem state and create a point-in-time checkpoint of the running sandbox. With include_memory=true the work is scheduled asynchronously and clients should poll snapshot capture for completion.
        /// </summary>
        /// <param name="includeMemory"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.HandlersCreateCheckpointResponse>> CreateACheckpointAsResponseAsync(
            bool? includeMemory = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}